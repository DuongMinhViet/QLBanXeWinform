using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLXEMAY.DAO
{
    class QLHDNhapDAO
    {
        private static QLHDNhapDAO instance;

        internal static QLHDNhapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLHDNhapDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        
        public bool deleteHDN(String MaHDN)
        {
            string query = "exec deleteHDN @MaHDN";
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaHDN });
            return resuilt > 0;
        }
        public bool updateHDN(String MaHDN, string MaNV,string MaNCC)
        {
            string query = string.Format("UPDATE tblHDNhap set MaNV ='{1}', MaNCC = '{2}' where MaHDN = '{0}'", MaHDN, MaNV, MaNCC); 
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {MaHDN,MaNV,MaNCC});
            return resuilt > 0;
        }
        public DataTable findMaHD(string MaHDN)
        {
            DataTable data = new DataTable();
            string query = "exec findMaHD @MaHDN";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { MaHDN });
            return data;
        }
        public DataTable findNCC(String TenNCC)
        {
            DataTable data = new DataTable();
            string query = "exec findNCC @TenNCC";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { TenNCC });
            return data;
        }
        public DataTable findNV(string TenNV)
        {
            DataTable data = new DataTable();
            string query = "exec findNV @TenNV";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { TenNV });
            return data;
        }
    }
}
