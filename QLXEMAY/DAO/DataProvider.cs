using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLXEMAY.DAO
{
    class DataProvider
    {

        //Design Patern Singleton
        private static DataProvider instance;
        internal static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private string strConnection = "Data Source=DESKTOP-1R33GOL\\SQLEXPRESS;Initial Catalog=QLXEMAY;Integrated Security=True";

        //Câu lệnh trả về kết quả làm một DataTable
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            //Dữ liệu sẽ luôn luôn được giải phóng sau khi kết thúc khối lệnh, kể cả khi câu lệnh điều khiển trong khối lệnh có xảy ra lỗi
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if(parameter!= null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }    
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
                connection.Dispose();
            }
            return data;
        }


        //Phương thức trả về số dòng thành công trong truy vấn sql (insert,delete,update)
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            //Dữ liệu sẽ luôn luôn được giải phóng sau khi kết thúc khối lệnh, kể cả khi câu lệnh điều khiển trong khối lệnh có xảy ra lỗi
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
            }
            return data;
        }


        //Câu lệnh trả về 1 giá trị là cột đầu tiên của dòng đầu tiên
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            //Dữ liệu sẽ luôn luôn được giải phóng sau khi kết thúc khối lệnh, kể cả khi câu lệnh điều khiển trong khối lệnh có xảy ra lỗi
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                connection.Close();
                connection.Dispose();
            }
            return data;
        }
    }
}
