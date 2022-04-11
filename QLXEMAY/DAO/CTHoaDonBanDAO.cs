using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLXEMAY.DAO
{
    class CTHoaDonBanDAO
    {
        private static CTHoaDonBanDAO instance;

        internal static CTHoaDonBanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTHoaDonBanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable getCTHoaDonBan(string MaCTHDB)
        {
            DataTable data = new DataTable();
            string query = "exec getCTHDB @MaCTHDB";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { MaCTHDB });
            return data;
        }
        public string getThanhTien(string MaCTHDB)
        {
            string query = string.Format("SELECT SUM(SoLuong * DonGiaBan) FROM tblChiTietHDB where MaCTHDB ='{0}'", MaCTHDB);
            Object resuilt = DAO.DataProvider.Instance.ExecuteScalar(query);
            return resuilt.ToString();
        }
        public bool insertHDBan(string MaHDB, string MaDM, string MaXe, string SoLuong, string DonGiaBan, string MaNV, string MaKH, string NgayBan)
        {
            string query = string.Format(" DECLARE @VarCTHDBtype AS CTHDBtype INSERT INTO @VarCTHDBtype VALUES ('{0}','{1}','{2}','{3}','{4}') EXEC NhapHDB '{0}','{5}','{6}','{7}',@VarCTHDBtype", MaHDB, MaDM, MaXe, SoLuong, DonGiaBan, MaNV, MaKH, NgayBan);
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query);
            return resuilt > 0;
        }
        public bool updateCTHDBan(String MaHDB, string MaXe, string SoLuong,string DonGia)
        {
            string query = string.Format("UPDATE tblChiTietHDB set SoLuong ='{1}',DonGiaBan='{2}' where MaXe ='{0}'",MaXe, SoLuong,DonGia);
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query);
            return resuilt > 0;
        }
        public bool eraseCTHDBan(string MaXe)
        {
            string query = string.Format("delete from tblChiTietHDB where MaXe = '{0}'", MaXe);
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query);
            return resuilt > 0;
        }
    }
}
