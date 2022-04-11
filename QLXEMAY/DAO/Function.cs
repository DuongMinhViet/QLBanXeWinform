using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace QLXEMAY.DAO
{
    class Function
    {
        private static Function instance;

        internal static Function Instance
        {
            get
            {
                if (instance == null)
                    instance = new Function();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public static string getMaNV;
        public string createMaNV(string tenBang, string maBatDau, string TruongMa)
        {
            int id = 1;
            bool dung = false;
            string ma = "";
            DataTable data = new DataTable();
            while (dung == false)
            {
                data = DataProvider.Instance.ExecuteQuery("select * from " + tenBang + "  where " + TruongMa + " ='" + maBatDau + id.ToString() + "'");
                if (data.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                    dung = false;
                }
            }
            ma = maBatDau + id.ToString();
            return ma;
        }
        public void autoComplete(TextBox tb, string query, string TruongTen)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DataTable data1 = DAO.DataProvider.Instance.ExecuteQuery(query);
            for (int i = 0; i < data1.Rows.Count; i++)
            {
                auto.Add(data1.Rows[i][TruongTen].ToString());
            }
            tb.AutoCompleteCustomSource = auto;
        }
    }
}
