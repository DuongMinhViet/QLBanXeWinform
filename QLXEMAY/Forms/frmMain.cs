using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXEMAY.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            timer1_kick.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if(pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }
        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonNhap f_HDN = new frmHoaDonNhap();
            f_HDN.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDonBan f_HDB = new frmHoaDonBan();
            f_HDB.Show();
        }
        int i = 10;
        Random rand = new Random();
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                lbFooter.Left += i;
                if (lbFooter.Left >= this.Width - lbFooter.Width || lbFooter.Left <= 0)
                { i = -i; lbFooter.ForeColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255)); }
            }
            catch { }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien f_NV = new frmNhanVien();
            f_NV.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f_KH = new frmKhachHang();
            f_KH.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f_NCC = new frmNhaCungCap();
            f_NCC.Show();
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXe F_XE = new frmXe();
            F_XE.Show();
        }

        private void hóaĐơnBánToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLiHDB f_HDB = new frmQuanLiHDB();
            f_HDB.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuanLiHDN f_HDN = new frmQuanLiHDN();
            f_HDN.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe f_TK = new frmThongKe();
            f_TK.Show();
        }

        private void danhMụcXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMucXe f_DM = new frmDanhMucXe();
            f_DM.Show();
        }
    }
}
