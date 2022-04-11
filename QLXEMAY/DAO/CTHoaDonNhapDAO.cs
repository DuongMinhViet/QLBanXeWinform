using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLXEMAY.DAO
{
    class CTHoaDonNhapDAO
    {
        private static CTHoaDonNhapDAO instance;

        internal static CTHoaDonNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTHoaDonNhapDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable getCTHoaDonNhap(string MaCTHDN)
        {
            DataTable data = new DataTable();
            string query = "exec getCTHDN @MaCTHDN";
            data = DAO.DataProvider.Instance.ExecuteQuery(query,new object[] { MaCTHDN});
            return data;
        }
        public string getThanhTien(string MaCTHDN)
        {
            string query = string.Format("SELECT SUM(SolUONG * DonGiaNhap) FROM tblChiTietHDN where MaCTHDN ='{0}'", MaCTHDN);
            Object resuilt =DAO.DataProvider.Instance.ExecuteScalar(query);
            return resuilt.ToString();
        }
        public bool insertHDNhap(string MaHDN,string MaDM,string MaXe,string SoLuong, string DonGiaNhap,string MaNV, string MaNCC, string NgayNhap)
        {
            string query = string.Format(" DECLARE @VarCTHDNtype AS CTHDNtype INSERT INTO @VarCTHDNtype VALUES ('{0}','{1}','{2}','{3}','{4}') EXEC NhapHD '{0}','{5}','{6}','{7}',@VarCTHDNtype",MaHDN,MaDM,MaXe,SoLuong,DonGiaNhap,MaNV,MaNCC,NgayNhap);
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query);
            return resuilt > 0;
        }
        public bool updateCTHDNhap(String MaHDN, string MaXe,string SoLuong, string DonGiaNhap)
        {
            string query = string.Format("UPDATE tblChiTietHDN set SoLuong ='{1}', DonGiaNhap = '{2}' where MaXe ='{0}'",MaXe, SoLuong,DonGiaNhap);
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query);
            return resuilt > 0;
        }
        public bool eraseCTHDNhap(string MaXe)
        {
            string query = string.Format("delete from tblChiTietHDN where MaXe = '{0}'", MaXe);
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query);
            return resuilt > 0;
        }
    }
}
