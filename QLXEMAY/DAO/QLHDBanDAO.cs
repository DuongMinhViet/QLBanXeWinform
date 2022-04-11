using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QLXEMAY.DAO
{
    class QLHDBanDAO
    {
        private static QLHDBanDAO instance;

        internal static QLHDBanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new QLHDBanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public bool deleteHDB(String MaHDB)
        {
            string query = "exec deleteHDB @MaHDB";
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaHDB });
            return resuilt > 0;
        }
        public bool updateHDB(String MaHDB, string MaNV, string MaKH)
        {
            string query = string.Format("UPDATE tblHDBan set MaNV ='{1}', MaKH = '{2}' where MaHDB = '{0}'", MaHDB, MaNV, MaKH);
            int resuilt = DAO.DataProvider.Instance.ExecuteNonQuery(query);
            return resuilt > 0;
        }
        public DataTable findMaHDB(string MaHDB)
        {
            DataTable data = new DataTable();
            string query = "exec findMaHDB @MaHDB";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { MaHDB });
            return data;
        }
        public DataTable findKH(String TenKH)
        {
            DataTable data = new DataTable();
            string query = "exec findKH @TenKH";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { TenKH });
            return data;
        }
        public DataTable findNVB(string TenNV)
        {
            DataTable data = new DataTable();
            string query = "exec findNV @TenNV";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { TenNV });
            return data;
        }
    }
}
