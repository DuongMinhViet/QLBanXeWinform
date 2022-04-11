--Kiểm tra đăng nhập
CREATE or ALTER proc checkLogin
@username nvarchar(10), @password nvarchar(max)
as
begin
	select count(*) from tblUser where UserName = @username and PassWord = @password
end
go
drop proc checkLogin
GO
/*---------------------------------------------------------NHÂN VIÊN-------------------------------------*/
--Fill dữ liệu nhân viên
create proc getNhanVien
as
begin
	select * from tblNhanVien
end
go
drop proc getNhanVien
go
--Xóa dữ liệu nhân viên
create proc eraseNhanVien
@MaNV nvarchar(10)
as
begin
	delete from tblNhanVien where MaNV = @MaNV
end
go
drop proc eraseNhanVien
go
--Tìm kiếm nhân viên theo tên
create proc findNhanVien
@TenNV nvarchar(50)
as
begin
	select * from tblNhanVien where TenNV like N'%'+@TenNV+'%'
end
go
drop proc findNhanVien
go
--Trigger tự động thêm mới một tài khoản khi thêm mới một nhân viên
CREATE OR ALTER TRIGGER dbo.trg_InsertNV
	ON dbo.tblNhanVien
	FOR INSERT
AS 
BEGIN
	SET NOCOUNT ON;
	DECLARE @MaNV NVARCHAR(10), @pass NVARCHAR(MAX)
	SELECT @pass = CONVERT(NVARCHAR(32),HASHBYTES('MD5','1'),2)
	SELECT @MaNV = MaNV FROM INSERTED
	INSERT tblUser VALUES(@MaNV,@pass,@MaNV)
END
GO
/*---------------------------------------------------------Danh Mục Xe-------------------------------------*/
--Fill dữ liệu danh mục xe
create proc getDMXe
as
begin
	select  * from tblDanhMucXe
end
go
--Tìm kiếm danh muc xe
create proc findDMXe
@TenDM nvarchar(10)
as
begin
	select * from tblDanhMucXe where TenDM like N'%'+@TenDM+'%'
end
go

/*---------------------------------------------------------Chi tiết hoá đơn bán-------------------------------------*/
--FILL tblChitIETHDB
create proc getCTHDB 
@MaCTHDB NVARCHAR(10)
as
begin
	SELECT tblChiTietHDB.MaXe,tblXe.TenXe,tblChiTietHDB.MaDM,tblChiTietHDB.SoLuong,DonGiaBan,(tblChiTietHDB.SoLuong*DonGiaBan)AS	ThanhTien	FROM tblChiTietHDB JOIN tblXe ON tblChiTietHDB.MaXe = tblXe.MaXe WHERE MaCTHDB = @MaCTHDB
end
go
drop proc getCTHDB
GO
--Thủ tục insert vào tblHDB khi thểm mới một chi tiết hoá đơn bán
CREATE TYPE CTHDBtype AS TABLE(	
	MaCTHDB NVARCHAR(10),
	MaDM NVARCHAR(10),
	MaXe NVARCHAR (10),
	SoLuong INT,
	DonGiaBan money
)
CREATE OR ALTER PROC NhapHDB @MaHDB NVARCHAR(10),@MaNV NVARCHAR(10),@MaKH NVARCHAR(10),@NgayBan DATETIME, @ParCTHDBtype CTHDBtype READONLY
AS
BEGIN
	BEGIN TRY
		IF (SELECT COUNT(*) FROM tblHDBan WHERE MaHDB = @MaHDB) = 0 BEGIN  
        	INSERT INTO tblHDBan VALUES(@MaHDB,@MaNV,@MaKH,@NgayBan) 
			INSERT INTO tblChiTietHDB SELECT * FROM @ParCTHDBtype
        END
        ELSE BEGIN
			INSERT INTO tblChiTietHDB SELECT * FROM @ParCTHDBtype
		END
	END TRY
	BEGIN CATCH
		print 'Error:' + Error_message();
	END CATCH
END
GO
--Trigger tự cập nhật số lượng xe và cập nhật giá bán 
CREATE OR ALTER trigger Trg_CapNhatSLBan on tblChiTietHDB
AFTER INSERT, UPDATE, DELETE AS
BEGIN
UPDATE S
set S.SoLuong = S.SoLuong - I.SoLuong
from tblXe S join inserted I on S.MaXe = I.MaXe

UPDATE S
set S.SoLuong = S.SoLuong + I.SoLuong
from tblXe S join DELETED I on S.MaXe = I.MaXe
END

/*---------------------------------------------------------Chi tiết hoá đơn nhập-------------------------------------*/
--Fill tblChiTIetHDN
create proc getCTHDN 
@MaCTHDN NVARCHAR(10)
as
begin
	SELECT tblChiTietHDN.MaXe,tblXe.TenXe,tblChiTietHDN.MaDM,tblChiTietHDN.SoLuong,DonGiaNhap,(tblChiTietHDN.SoLuong*DonGiaNhap)AS	ThanhTien	FROM tblChiTietHDN JOIN tblXe ON tblChiTietHDN.MaXe = tblXe.MaXe WHERE MaCTHDN = @MaCTHDN
end
go
drop proc getCTHDN 
GO
EXEC getCTHDN 'HDN01'
--Thủ tục insert vào tblHDN khi thêm mới một chi tiết HDN
CREATE TYPE CTHDNtype AS TABLE(	
	MaCTHDN NVARCHAR(10),
	MaDM NVARCHAR(10),
	MaXe NVARCHAR (10),
	SoLuong INT,
	DonGiaNhap money
)
CREATE OR ALTER PROC NhapHD @MaHDN NVARCHAR(10),@MaNV NVARCHAR(10),@MaNCC NVARCHAR(10),@NgayNhap DATETIME, @ParCTHDNtype CTHDNtype READONLY
AS
BEGIN
	BEGIN TRY
		IF (SELECT COUNT(*) FROM tblHDNhap WHERE MaHDN = @MaHDN) = 0 BEGIN  
        	INSERT INTO tblHDNhap VALUES(@MaHDN,@MaNV,@MaNCC,@NgayNhap) 
			INSERT INTO tblChiTietHDN SELECT * FROM @ParCTHDNtype
        END
        ELSE BEGIN
			INSERT INTO tblChiTietHDN SELECT * FROM @ParCTHDNtype
		END
	END TRY
	BEGIN CATCH
		print 'Error:' + Error_message();
	END CATCH
END
DROP PROC NhapHD
GO
--Trigger tự động cập nhật số lượng xe khi nhập hoá đơn, tự cập nhật giá mua
CREATE OR ALTER trigger Trg_CapNhatSLNhap on tblChiTietHDN
AFTER INSERT, UPDATE, DELETE AS
BEGIN
UPDATE S
set S.SoLuong = S.SoLuong + I.SoLuong
from tblXe S join inserted I on S.MaXe = I.MaXe

UPDATE S
set S.SoLuong = S.SoLuong - I.SoLuong
from tblXe S join DELETED I on S.MaXe = I.MaXe

DECLARE @GiaMua MONEY
SELECT @GiaMua  = DonGiaNhap FROM INSERTED 
UPDATE	tblXe SET GiaMua = @GiaMua 
END
GO
/*---------------------------------------------------------NHÀ CUNG CẤP-------------------------------------*/
--Fill dữ liệu nhà cung cấp
create proc getNhaCungCap
as
begin
	select * from tblNhaCungCap
end
go
drop proc getNhaCungCap
go
--Xóa dữ liệu nhà cung cấp
create proc eraseNhaCungCap
@MaNCC nvarchar(10)
as
begin
	delete from tblNhaCungCap where MaNCC = @MaNCC
end
go
drop proc eraseNhaCungCap
go
--Tìm kiếm nhà cung cấp theo tên
create proc findNhaCungCap
@TenNCC nvarchar(50)
as
begin
	select * from tblNhaCungCap where TenNCC like N'%'+@TenNCC+'%'
end
go
drop proc findNhaCungCap
go

/*---------------------------------------------------------KHÁCH HÀNG-------------------------------------*/
--Fill dữ liệu khách hàng
create proc getKhachHang
as
begin
	select * from tblKhachHang
end
go
drop proc getKhachHang
go
--Xóa dữ liệu khách hàng
create proc eraseKhachHang
@MaKH nvarchar(10)
as
begin
	delete from tblKhachHang where MaKH = @MaKH
end
go
drop proc eraseKhachHang
go
--Tìm kiếm nhà cung cấp theo tên
create proc findKhachHang
@TenKH nvarchar(50)
as
begin
	select * from tblKhachHang where TenKH like N'%'+@TenKH+'%'
end
go
drop proc findKhachHang
go


/*---------------------------------------------------------quản lý hoá đơn nhập-------------------------------------*/
--Lấy ra dữ liệu
CREATE OR ALTER PROC getHDN AS
BEGIN
	SELECT MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC, NgayNhap,ISNULL(SUM(SoLuong * DonGiaNhap), 0) AS TriGiaHD  FROM tblHDNhap LEFT JOIN tblChiTietHDN ON MaCTHDN = MaHDN
	JOIN tblNhanVien nv ON tblHDNhap.MaNV = nv.MaNV JOIN tblNhaCungCap ncc ON tblHDNhap.MaNCC = ncc.MaNCC

	GROUP BY MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC,NgayNhap,SoLuong,DonGiaNhap
END
GO
DROP PROC getHDN
EXEC getHDN
--Find hoá đơn dựa vào mã hoá đơn
CREATE OR ALTER PROC dbo.findMaHD 
(
	@MaHDN NVARCHAR(5)
)
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
	SELECT MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC, NgayNhap,ISNULL(SUM(SoLuong * DonGiaNhap), 0) AS TriGiaHD  FROM tblHDNhap LEFT JOIN tblChiTietHDN ON MaCTHDN = MaHDN
			JOIN tblNhanVien nv ON tblHDNhap.MaNV = nv.MaNV JOIN tblNhaCungCap ncc ON tblHDNhap.MaNCC = ncc.MaNCC
	WHERE MaHDN = @MaHDN
	GROUP BY MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC,NgayNhap,SoLuong,DonGiaNhap
GO
--Find hoá đơn dựa vào tên NCC
CREATE OR ALTER PROCEDURE dbo.findNCC
(
	@TenNCC NVARCHAR(50)
)
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
	SELECT MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC, NgayNhap,ISNULL(SUM(SoLuong * DonGiaNhap), 0) AS TriGiaHD  FROM tblHDNhap LEFT JOIN tblChiTietHDN ON MaCTHDN = MaHDN
	JOIN tblNhaCungCap ncc ON tblHDNhap.MaNCC = ncc.MaNCC JOIN tblNhanVien nv ON tblHDNhap.MaNV = nv.MaNV
	WHERE ncc.TenNCC = @TenNCC
	GROUP BY MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC,NgayNhap,SoLuong,DonGiaNhap
GO
--FUnd hoá đơn dựa trên tên nhân viên
CREATE OR ALTER PROCEDURE dbo.findNV 
(
	@TenNV NVARCHAR(50)
)
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
	SELECT MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC, NgayNhap,ISNULL(SUM(SoLuong * DonGiaNhap), 0) AS TriGiaHD  FROM tblHDNhap LEFT JOIN tblChiTietHDN ON MaCTHDN = MaHDN
	JOIN tblNhanVien nv ON tblHDNhap.MaNV = nv.MaNV JOIN tblNhaCungCap ncc ON tblHDNhap.MaNCC = ncc.MaNCC
	WHERE nv.TenNV = @TenNV
	GROUP BY MaHDN,tblHDNhap.MaNV,nv.TenNV,tblHDNhap.MaNCC,ncc.TenNCC,NgayNhap,SoLuong,DonGiaNhap
GO
--Xoá hoá đơn
CREATE PROC deleteHDN @MaHDN NVARCHAR(10)
AS
BEGIN
	DELETE FROM tblHDNhap WHERE MaHDN = @MaHDN
END	
/*---------------------------------------------------------quản lý hoá đơn bán-------------------------------------*/
--Lấy ra dữ liệu
CREATE OR ALTER PROC getHDB AS
BEGIN
	SELECT MaHDB,tblHDBan.MaNV,TenNV,tblHDBan.MaKH,TenKH, NgayBan,ISNULL(SUM(SoLuong * DonGiaBan), 0) AS TriGiaHD  FROM tblHDBan LEFT JOIN tblChiTietHDB ON MaCTHDB = MaHDB
	JOIN tblNhanVien nv ON tblHDBan.MaNV = nv.MaNV JOIN tblKhachHang kh ON tblHDBan.MaKH = kh.MaKH
	GROUP BY MaHDB,tblHDBan.MaNV,TenNV, tblHDBan.MaKH,TenKH,NgayBan,SoLuong,DonGiaBan
END
GO
DROP PROC getHDB
EXEC getHDB
--Xoá hoá đơn
CREATE PROC deleteHDB @MaHDB NVARCHAR(10)
AS
BEGIN
	DELETE FROM tblHDBan WHERE MaHDB = @MaHDB
END	
--Find hoá đơn dựa vào mã hoá đơn
CREATE OR ALTER PROC dbo.findMaHDB
(
	@MaHDB NVARCHAR(5)
)
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
	SELECT MaHDB,tblHDBan.MaNV,TenNV,tblHDBan.MaKH,TenKH, NgayBan,ISNULL(SUM(SoLuong * DonGiaBan), 0) AS TriGiaHD  FROM tblHDBan LEFT JOIN tblChiTietHDB ON MaCTHDB = MaHDB
	JOIN tblNhanVien nv ON tblHDBan.MaNV = nv.MaNV JOIN tblKhachHang kh ON tblHDBan.MaKH = kh.MaKH
	WHERE MaHDB = @MaHDB
	GROUP BY MaHDB,tblHDBan.MaNV,TenNV,tblHDBan.MaKH,TenKH,NgayBan,SoLuong,DonGiaBan
GO
--Fin hoa đơn bán theo tên nhan viên 
CREATE OR ALTER PROC dbo.findNVB
(
	@TenNV NVARCHAR(5)
)
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
	SELECT MaHDB,tblHDBan.MaNV,TenNV,tblHDBan.MaKH,TenKH, NgayBan,ISNULL(SUM(SoLuong * DonGiaBan), 0) AS TriGiaHD  FROM tblHDBan LEFT JOIN tblChiTietHDB ON MaCTHDB = MaHDB
	JOIN tblNhanVien nv ON tblHDBan.MaNV = nv.MaNV JOIN tblKhachHang kh ON tblHDBan.MaKH = kh.MaKH
	WHERE TenNV = @TenNV
	GROUP BY MaHDB,tblHDBan.MaNV,TenNV,tblHDBan.MaKH,TenKH,NgayBan,SoLuong,DonGiaBan
GO
--Find hoá đơnt heo tên khách hàng
CREATE OR ALTER PROC dbo.findKH
(
	@TenKH NVARCHAR(5)
)
-- WITH ENCRYPTION, RECOMPILE, EXECUTE AS CALLER|SELF|OWNER| 'user_name'
AS
	SELECT MaHDB,tblHDBan.MaNV,TenNV,tblHDBan.MaKH,TenKH, NgayBan,ISNULL(SUM(SoLuong * DonGiaBan), 0) AS TriGiaHD  FROM tblHDBan LEFT JOIN tblChiTietHDB ON MaCTHDB = MaHDB
	JOIN tblNhanVien nv ON tblHDBan.MaNV = nv.MaNV JOIN tblKhachHang kh ON tblHDBan.MaKH = kh.MaKH
	WHERE TenKH = @TenKH
	GROUP BY MaHDB,tblHDBan.MaNV,TenNV,tblHDBan.MaKH,TenKH,NgayBan,SoLuong,DonGiaBan
GO
/*---------------------------------------------------------Doanh thu-------------------------------------*/

CREATE PROC DoanhThu @Nam INT
AS
BEGIN
	Select MONTH(tblHDBan.NgayBan) as Thang, SUM(SoLuong * DonGiaBan) as DoanhThu from tblChiTietHDB join tblHDBan  
		ON tblChiTietHDB.MaCTHDB = tblHDBan.MaHDB
	where YEAR(tblHDBan.NgayBan) = @Nam
	Group by MONTH(NgayBan)
END	

CREATE PROC TongThu @Nam INT
AS
BEGIN
	SELECT SUM(SoLuong * DonGiaBan) AS TongThu FROM tblChiTietHDB join tblHDBan  
		ON tblChiTietHDB.MaCTHDB = tblHDBan.MaHDB where YEAR(tblHDBan.NgayBan) = @Nam
	GROUP BY YEAR(NgayBan)
END	
DROP PROC TongThu
/*---------------------------------------------------------Xe-------------------------------------*/
--Lay danh sach xe
Create proc getXe
as 
begin 
    select * from tblXe
end
go
exec getXe
--Xoa xe
Create proc eraseXe
@MaXe nvarchar(10)
as
begin
	delete from tblXe where MaXe = @MaXe
end
go
--Tim NhanVien
create proc findXe
@TenXe nvarchar(50)
as
begin
	select * from tblXe where TenXe like N'%'+@TenXe+'%'
end
go

