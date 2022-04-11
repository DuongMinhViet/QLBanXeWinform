using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLXEMAY.DAO
{
    class AccountDAO
    {
        //Design Patern Singleton
        private static AccountDAO instance;
        internal static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public bool login(string username, string pass)
        {
            MD5 pas = MD5.Create();
            byte[] temp = System.Text.ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hash = pas.ComputeHash(temp);
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < hash.Length;i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            object result;
            string query = "exec checkLogin @username , @password";
            result = DataProvider.Instance.ExecuteScalar(query, new object[] {username,sb.ToString()});
            return int.Parse(result.ToString()) > 0;
        }

    }
}
