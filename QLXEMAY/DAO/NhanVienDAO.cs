using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLXEMAY.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;
        internal static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public bool insertNV(string MaNV,string TenNV, string DienThoai, string DiaChi, string GT, string NS)
        {
            string query = string.Format("Insert into tblNhanVien Values('{0}', N'{1}', '{2}', N'{3}', N'{4}', '{5}')",MaNV,TenNV,DienThoai,DiaChi,GT,NS);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result>0;
        }
        public bool updateNV(string MaNV, string TenNV, string DienThoai, string DiaChi, string GT, string NS)
        {
            string query = string.Format("UPDATE tblNhanVien set TenNV=N'{1}', DienThoai='{2}',DiaChi=N'{3}',GioiTinh=N'{4}',NgaySinh='{5}' where MaNV='{0}'", MaNV, TenNV, DienThoai, DiaChi, GT, NS);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool eraseNV(string MaNV)
        {
            string query = "exec eraseNhanVien @MaNV";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { MaNV });
            return result > 0;
        }
        public DataTable findNV(string TenNV)
        {
            DataTable data = new DataTable();
            string query = "exec findNhanVien @TenNV";
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { TenNV });
            return data;
        }
    }
}
