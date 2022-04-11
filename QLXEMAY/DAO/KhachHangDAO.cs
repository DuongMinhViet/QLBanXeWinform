using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXEMAY.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;
        internal static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
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
            string query = "exec getKhachHang";
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool insertKH(string MaKH, string TenKH, string DiaChi, string SDT)
        {
            string query = string.Format("Insert into tblKhachHang Values('{0}', N'{1}', N'{2}', '{3}')", MaKH, TenKH, DiaChi, SDT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool updateKH(string MaKH, string TenKH, string DiaChi, string SDT)
        {
            string query = string.Format("UPDATE tblKhachHang set TenKH=N'{1}', DiaChi=N'{2}',SDT='{3}' where MaKH='{0}'", MaKH, TenKH, DiaChi, SDT);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool eraseKH(string MaKH)
        {
            string query = "exec eraseKhachHang @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaKH });
            return result > 0;
        }
        public DataTable findKH(string TenKH)
        {
            DataTable data = new DataTable();
            string query = "exec findKhachHang @TenKH";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenKH });
            return data;
        }
    }
}
