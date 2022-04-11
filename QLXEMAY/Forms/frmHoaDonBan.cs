using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QLXEMAY.Forms
{
    public partial class frmHoaDonBan : Form
    {
        int checkbtn = 0;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtMaHD.ResetText();
            cbMaKH.ResetText();
            txtTenKH.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            cbMaXe.ResetText();
            txtTenXe.ResetText();
            txtSoLuong.ResetText();
            txtDonGia.ResetText();
            txtDMXe.ResetText();
            txtThanhTien.ResetText();
            txtTim.ResetText();
            dgvHDB.DataSource = null;
        }
        private void Show(bool act)
        {
            txtMaHD.Enabled = act;
            txtMaNV.Enabled = act;
            txtTenNV.Enabled = act;
            cbMaKH.Enabled = act;
            txtTenKH.Enabled = act;
            txtDiaChi.Enabled = act;
            txtDienThoai.Enabled = act;
            cbMaXe.Enabled = act;
            txtDonGia.Enabled = act;
            txtTenXe.Enabled = act;
            txtSoLuong.Enabled = act;
            txtDMXe.Enabled = act;
            btnThem.Enabled = act;
            btnSua.Enabled = act;
            btnLuu.Enabled = act;
            txtThanhTien.Enabled = act;
        }
        private void LoadListCTHDB(string MaCTHDB)
        {
            dgvHDB.DataSource = DAO.CTHoaDonBanDAO.Instance.getCTHoaDonBan(MaCTHDB);
            //Datagridview
            dgvHDB.Columns[0].HeaderText = "Mã Xe";
            dgvHDB.Columns[1].HeaderText = "Tên xe";
            dgvHDB.Columns[2].HeaderText = "Danh mục xe";
            dgvHDB.Columns[3].HeaderText = "Số lượng";
            dgvHDB.Columns[4].HeaderText = "Đơn giá bán";
            dgvHDB.Columns[5].HeaderText = "Thành Tiền";
            dgvHDB.AllowUserToAddRows = false;
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            Show(false);
            btnThem.Enabled = true;
            string MaHDB = txtMaHD.Text;
            LoadListCTHDB(MaHDB);
            //Fill dữ liệu lên cboMaKH
            cbMaKH.Enabled = true;
            cbMaKH.DataSource = DAO.DataProvider.Instance.ExecuteQuery("SELECT * FROM  tblKhachHang");
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";
            cbMaKH.Text = "";
            //Fill dữ liệu lên cboXe
            cbMaXe.Enabled = true;
            cbMaXe.DataSource = DAO.DataProvider.Instance.ExecuteQuery("select * from tblXe");
            cbMaXe.DisplayMember = "MaXe";
            cbMaXe.ValueMember = "MaXe";
            cbMaXe.Text = "";
            resetValue();
            //getNV
            txtMaNV.Text = DAO.Function.getMaNV;
            //autoComplete
            DAO.Function.Instance.autoComplete(txtTim, "select * from tblChiTietHDB", "MaCTHDB");


        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MaKH = cbMaKH.Text;
                string query = String.Format("select * from tblKhachHang WHERE MaKH ='{0}'", MaKH);
                DataTable dataKH = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenKH.Text = dataKH.Rows[0]["TenKH"].ToString();
                txtDiaChi.Text = dataKH.Rows[0]["DiaChi"].ToString();
                txtDienThoai.Text = dataKH.Rows[0]["SDT"].ToString();
            }
            catch { txtTenKH.Text = ""; txtDiaChi.Text = "";txtDienThoai.Text = ""; }
        }

        private void cbMaXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MaXe = cbMaXe.Text;
                string query = String.Format("select * from tblXe where MaXe = '{0}'", MaXe);
                DataTable dataXe = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenXe.Text = dataXe.Rows[0]["TenXe"].ToString();
                txtDonGia.Text = dataXe.Rows[0]["GiaBan"].ToString();
                txtDMXe.Text = dataXe.Rows[0]["MaDM"].ToString();
            }
            catch { txtTenXe.Text = ""; txtDonGia.Text = ""; }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("select TenNV from tblNhanVien where MaNV = '{0}'", txtMaNV.Text);
                DataTable dt = new DataTable();
                dt = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenNV.Text = dt.Rows[0]["TenNV"].ToString();
            }
            catch { }
        }
        private void cbMaXe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string MaXe = cbMaXe.Text;
                string query = String.Format("select * from tblXe where MaXe = '{0}'", MaXe);
                DataTable dataXe = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenXe.Text = dataXe.Rows[0]["TenXe"].ToString();
                txtDonGia.Text = dataXe.Rows[0]["GiaBan"].ToString();
                txtDMXe.Text = dataXe.Rows[0]["MaDM"].ToString();
            }
            catch { txtTenXe.Text = ""; txtDonGia.Text = ""; }
        }

        private void cbMaKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string MaKH = cbMaKH.Text;
                string query = String.Format("select * from tblKhachHang WHERE MaKH ='{0}'", MaKH);
                DataTable dataKH = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenKH.Text = dataKH.Rows[0]["TenKH"].ToString();
                txtDiaChi.Text = dataKH.Rows[0]["DiaChi"].ToString();
                txtDienThoai.Text = dataKH.Rows[0]["SDT"].ToString();
            }
            catch { txtTenKH.Text = ""; txtDiaChi.Text = ""; txtDienThoai.Text = ""; }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTim.Text.Trim().Length != 0)
                {
                    string MaCTHDB = txtTim.Text;
                    LoadListCTHDB(MaCTHDB);
                    txtMaHD.Text = MaCTHDB;
                    string query = string.Format("Select tblHDBan.MaNV, tblHDBan.MaKH, tblChiTietHDB.MaXe,SoLuong from tblChiTietHDB join tblHDBan on tblChiTietHDB.MaCTHDB = tblHDBan.MaHDB  where MaCTHDB = '{0}'", MaCTHDB);
                    DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query);
                    if(data.Rows.Count >0 )
                    {
                        txtMaNV.Text = data.Rows[0]["MaNV"].ToString();
                        cbMaKH.Text = data.Rows[0]["MaKH"].ToString();
                        cbMaXe.Enabled = false;
                        cbMaKH.Enabled = false;
                        txtThanhTien.Text = DAO.CTHoaDonBanDAO.Instance.getThanhTien(MaCTHDB);
                        txtSoLuong.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Hoá đơn này không có sản phẩm!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập mã hoá đơn cần tìm!");
                    return;
                }
            }
            catch
            {
                
            }
        }

        private void dgvHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            cbMaXe.Text = dgvHDB.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = dgvHDB.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            resetValue();
            Show(false);
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            dgvHDB.DataSource = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            resetValue();
            string tenBang = "tblChiTietHDB";
            string maBatDau = "HDB0";
            string TruongMa = "MaCTHDB";
            txtMaHD.Text = DAO.Function.Instance.createMaNV(tenBang, maBatDau, TruongMa);
            txtSoLuong.Enabled = true;
            btnLuu.Enabled = true;
            checkbtn = 1;
            txtDonGia.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cbMaKH.Enabled = true;
            txtSoLuong.Enabled = true;
            cbMaXe.Enabled = true;
            checkbtn = 2;
            btnLuu.Enabled = true;
            txtDonGia.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String HDB = txtMaHD.Text;
            string MaDM = txtDMXe.Text;
            string MaXe = cbMaXe.Text;
            string SoLuong = txtSoLuong.Text;
            string DonGiaBan = txtDonGia.Text;
            string MaNV = txtMaNV.Text;
            string MaKH = cbMaKH.Text;
            string NgayBan = dtNgayBan.Value.ToString();
            if(checkbtn == 1)
            {
                try
                {
                    if (cbMaKH.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải chọn khách hàng");
                        return;
                    }
                    if (txtSoLuong.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Bạn phải chọn số lượng");
                        return;
                    }
                    DataTable dataCTHDB = DAO.DataProvider.Instance.ExecuteQuery(string.Format("SELECT MaXe,MaDM FROM tblChiTietHDB where MaCTHDB = '{0}' and MaXe ='{1}' and MaDM = '{2}'", HDB, MaXe, MaDM));
                    if (dataCTHDB.Rows.Count > 0)
                    {
                        MessageBox.Show("Sản phẩm này đã mua!");
                        return;
                    }
                    if (DAO.CTHoaDonBanDAO.Instance.insertHDBan(HDB, MaDM, MaXe, SoLuong, DonGiaBan, MaNV, MaKH, NgayBan))
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        LoadListCTHDB(HDB);
                    }
                    txtThanhTien.Text = DAO.CTHoaDonBanDAO.Instance.getThanhTien(HDB);

                }
                catch { }
                DAO.Function.Instance.autoComplete(txtTim, "select * from tblChiTietHDB", "MaCTHDB");
            }
            if (checkbtn == 2)
            {
                try
                {
                    if (DAO.CTHoaDonBanDAO.Instance.updateCTHDBan(HDB, MaXe, SoLuong,DonGiaBan))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadListCTHDB(HDB);
                    }
                    txtThanhTien.Text = DAO.CTHoaDonBanDAO.Instance.getThanhTien(HDB);
                }
                catch { }
                DAO.Function.Instance.autoComplete(txtTim, "select * from tblChiTietHDB", "MaCTHDB");

            }
        }
        private void dgvHDB_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string MaXe = dgvHDB.CurrentRow.Cells[0].Value.ToString();
                    if (DAO.CTHoaDonBanDAO.Instance.eraseCTHDBan(MaXe))
                    {
                        MessageBox.Show("Xoá thành công!");
                        LoadListCTHDB(txtMaHD.Text);
                    }
                    if (dgvHDB.Rows.Count > 0)
                    {
                        LoadListCTHDB(txtMaHD.Text);
                    }
                    else
                    {
                        resetValue();
                    }
                }
                catch { }
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
             frmKhachHang f_KH = new frmKhachHang();
            f_KH.ShowDialog();
            cbMaKH.DataSource = DAO.DataProvider.Instance.ExecuteQuery("select * from tblKhachHang");
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";
            cbMaKH.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = DAO.CTHoaDonBanDAO.Instance.getCTHoaDonBan(txtMaHD.Text);
            //khai bao va khoi tao 
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

            //Định dạng chung
            Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
            tenCuaHang.Font.Size = 12;
            tenCuaHang.Font.Bold = true;
            tenCuaHang.Font.Bold = Color.Blue;
            tenCuaHang.Value = "Cửa hàng bán xe máy Minh Việt";

            Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
            dcCuaHang.Font.Size = 12;
            dcCuaHang.Font.Bold = true;
            dcCuaHang.Font.Bold = Color.Blue;
            dcCuaHang.Value = "Địa chỉ: Xóm 6 - Xã Phúc Lâm - Hà Nội";

            Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
            dtCuaHang.Font.Size = 12;
            dtCuaHang.Font.Bold = true;
            dtCuaHang.Font.Bold = Color.Blue;
            dtCuaHang.Value = "Điện thoại: 0965990999";

            Excel.Range Header = (Excel.Range)exSheet.Cells[5, 2];
            exSheet.get_Range("B5:G5").Merge(true);
            Header.Font.Size = 13;
            Header.Font.Bold = true;
            Header.Font.Bold = Color.Red;
            Header.Value = "Hoá đơn bán hàng";


            Excel.Range SoHD = (Excel.Range)exSheet.Cells[7, 7];
            SoHD.Font.Bold = true;
            SoHD.Value = "Số hoá đơn: " + txtMaHD.Text;

            Excel.Range Ngay = (Excel.Range)exSheet.Cells[8, 2];
            Ngay.Font.Bold = true;
            Ngay.Value = "Ngày: " + dtNgayBan.Text;

            Excel.Range TenKH = (Excel.Range)exSheet.Cells[9, 2];
            TenKH.Font.Bold = true;
            TenKH.Value = "Tên khách hàng: " + txtTenKH.Text;

            Excel.Range SDT = (Excel.Range)exSheet.Cells[9, 6];
            SDT.Font.Bold = true;
            SDT.Value = "Số điện thoại:  " + txtDienThoai.Text;

            Excel.Range DC = (Excel.Range)exSheet.Cells[10, 2];
            DC.Font.Bold = true;
            DC.Value = "Dịa chỉ:  " + txtDiaChi.Text;

            exSheet.get_Range("H20").Value = "Thanh toán: " + txtThanhTien.Text;
            //Định dang tiêu đề
            exSheet.get_Range("B11:H11").Font.Bold = true;
            exSheet.get_Range("B11:H11").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            exSheet.get_Range("B11").Value = "STT";
            exSheet.get_Range("C11").Value = "Mã xe";
            exSheet.get_Range("D11").Value = "Tên xe";
            exSheet.get_Range("E11").Value = "Danh mục xe";
            exSheet.get_Range("F11").Value = "Số lượng";
            exSheet.get_Range("G11").Value = "Đơn giá";
            exSheet.get_Range("H11").Value = "Thành tiền";

            //In dữ liệu 
            for (int i=0;i<dgvHDB.Rows.Count;i++)
            {
                exSheet.get_Range("B" + (i + 12).ToString() + ":H" + (i + 12).ToString()).Font.Bold = false;
                exSheet.get_Range("B" + (i + 12).ToString()).Value = (i + 1).ToString();
                exSheet.get_Range("C" + (i + 12).ToString()).Value = data.Rows[i]["MaXe"].ToString();
                exSheet.get_Range("D" + (i + 12).ToString()).Value = data.Rows[i]["TenXe"].ToString();
                exSheet.get_Range("E" + (i + 12).ToString()).Value = data.Rows[i]["MaDM"].ToString();
                exSheet.get_Range("F" + (i + 12).ToString()).Value = data.Rows[i]["SoLuong"].ToString();
                exSheet.get_Range("G" + (i + 12).ToString()).Value = data.Rows[i]["DonGiaBan"].ToString();
                exSheet.get_Range("H" + (i + 12).ToString()).Value = data.Rows[i]["ThanhTien"].ToString();
            }

            exSheet.Name = "HoaDon";
            exBook.Activate();
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Excel Document (*.xlsx |*.xlsx   |All files(*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = ".xlsx";
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                exBook.SaveAs(dlgSave.FileName.ToString());
            exApp.Quit();
        }
    }
}
