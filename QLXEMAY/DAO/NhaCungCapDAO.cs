using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXEMAY.DAO
{
    class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        internal static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhaCungCapDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public DataTable getNhaCungCap()
        {
            DataTable data = new DataTable();
            string query = "exec getNhaCungCap";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool insertNCC(string MaNCC, string TenNCC, string DiaChi, string SDT)
        {
            string query = string.Format("Insert into tblNhaCungCap Values('{0}', N'{1}', N'{2}', N'{3}')", MaNCC, TenNCC, DiaChi, SDT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool updateNCC(string MaNCC, string TenNCC, string DiaChi, string SDT)
        {
            string query = string.Format("UPDATE tblNhaCungCap set TenNCC=N'{1}', DiaChi=N'{2}',SDT=N'{3}' where MaNCC='{0}'", MaNCC, TenNCC, DiaChi, SDT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool eraseNCC(string MaNCC)
        {
            string query = "exec eraseNhaCungCap @MaNCC";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNCC });
            return result > 0;
        }
        public DataTable findNCC(string TenNCC)
        {
            DataTable data = new DataTable();
            string query = "exec findNhaCungCap @TenNCC";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenNCC });
            return data;
        }
    }
}
