using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLXEMAY.DAO
{
    class ThongKeDAO
    {
        private static ThongKeDAO instances;

        internal static ThongKeDAO Instances
        {
            get
            {
                if (instances == null)
                    instances = new ThongKeDAO();
                return instances;
            }
            private set
            {
                instances = value;
            }
        }
        public DataTable DoanhThu(int nam)
        {
            DataTable data = new DataTable();
            string query = "exec DoanhThu @Nam";
            data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { nam });
            return data;
        }
        public string TongTien(int nam)
        {
            string query = string.Format("EXEC TongThu @Nam");
            Object resuilt = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { nam });
            return resuilt.ToString();
        }
    }
}
