using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLXEMAY.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShowPass.Checked == true)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
        public bool login(string username, string pass)
        {
            return DAO.AccountDAO.Instance.login(username, pass);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn cần nhập tài khoản!");
                return;
            }    
            if(txtPassWord.Text.Trim()=="")
            {
                MessageBox.Show("Bạn cần nhập mật khẩu!");
                return;
            }
            string username = txtUserName.Text;
            string pass = txtPassWord.Text;
            if(login(username,pass))
            {
                DataTable data = new DataTable();
                string query = string.Format("Select MaNV from tblUser where UserName = '{0}'", txtUserName.Text);
                data = DAO.DataProvider.Instance.ExecuteQuery(query);
                DAO.Function.getMaNV = data.Rows[0]["MaNV"].ToString();
                frmMain fmain = new frmMain();
                this.Visible = false;
                fmain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu!");
                return;
            }
            this.Hide();
        }

        private void ckbSavePass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
