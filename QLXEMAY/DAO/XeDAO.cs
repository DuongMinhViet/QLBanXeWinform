using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLXEMAY.DAO
{
    class XeDAO
    {
        private static XeDAO instance;

        internal static XeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable getXe()
        {
            DataTable data = new DataTable();
            string query = "exec getXe";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool insertXe(string MaXe, string TenXe, string MaDM, int SoLuong , string GiaMua,string GiaBan, string Anh,string GhiChu,string HangSX,string PhanKhoi)
        {
            string query = string.Format("Insert into tblXe Values('{0}', N'{1}', '{2}', '{3}', cast('{4}' as money), cast('{5}' as money), '{6}', N'{7}', '{8}', '{9}')", MaXe, TenXe, MaDM, SoLuong, GiaMua, GiaBan, Anh, GhiChu, HangSX, PhanKhoi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool updateXe(string MaXe, string TenXe, string MaDM, int SoLuong, string GiaMua, string GiaBan, string Anh, string GhiChu, string HangSX, string PhanKhoi)
        {
            string query = string.Format("UPDATE tblXe set TenXe=N'{1}', MaDM=N'{2}',SoLuong='{3}',GiaMua=Cast('{4}' as money),GiaBan=Cast('{5}' as money),Anh='{6}',GhiChu=N'{7}',HangSX=N'{8}',PhanKhoi='{9}' where MaXe='{0}'", MaXe, TenXe, MaDM, SoLuong, GiaMua, GiaBan, Anh, GhiChu, HangSX, PhanKhoi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool eraseXe(string MaXe)
        {
            string query = "exec eraseXe @MaXe";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaXe });
            return result > 0;
        }
        public DataTable findXe(string TenXe)
        {
            DataTable data = new DataTable();
            string query = "exec findXe @TenXe";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenXe });
            return data;
        }
    }
}
