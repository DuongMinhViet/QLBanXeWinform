using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLXEMAY.DAO
{
    class DMXeDAO
    {
        private static DMXeDAO instance;

        internal static DMXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DMXeDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable getDMXe()
        {
            DataTable data = new DataTable();
            string query = "exec getDMXe";
            data = DAO.DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool insertDMXe(string MaDMXe, string TenDMXe)
        {
            string query = string.Format("Insert into tblDanhMucXe Values('{0}', N'{1}')", MaDMXe,TenDMXe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool updateDMXe(string MaDMXe,string TenDMXe)
        {
            string query = string.Format("Update tblDanhMucXe set TenDM = N'{1}' where MaDM = '{0}' ", MaDMXe, TenDMXe);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool eraseDMXe(string MaNV)
        {
            string query = string.Format("delete tblDanhMucXe where MaDM = '{0}'", MaNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result> 0;
        }
        public DataTable findDMXE(string TenDMXe)
        {
            string query = string.Format("exec findDMXe @TenDM");
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenDMXe });
            return data;
        }
    }
}
