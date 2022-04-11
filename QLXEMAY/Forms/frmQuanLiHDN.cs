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
    public partial class frmQuanLiHDN : Form
    {
        public frmQuanLiHDN()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtMaHD.ResetText();
            txtTimKiem.ResetText();
            txtNV.ResetText();
            txtNCC.ResetText();
            txtTongTien.ResetText();
        }
        private void Show(bool act)
        {
            txtMaHD.Enabled = act;
            txtNV.Enabled = act;
            txtNCC.Enabled = act;
            txtTongTien.Enabled = act;
            btnSua.Enabled = act;
            btnXoa.Enabled = act;
            btnLuu.Enabled = act;
        }
        private void LoadListHDN()
        {
            string query = "exec getHDN";
            dgvDSHDN.DataSource = DAO.DataProvider.Instance.ExecuteQuery(query);
        }
        private void frmQuanLiHDN_Load(object sender, EventArgs e)
        {
            LoadListHDN();
            dgvDSHDN.Columns[0].HeaderText = "Mã hoá đơn nhập";
            dgvDSHDN.Columns[1].HeaderText = "Nhân viên";
            dgvDSHDN.Columns[2].HeaderText = "Tên nhân viên";
            dgvDSHDN.Columns[2].Width = 150;
            dgvDSHDN.Columns[3].HeaderText = "Nhà cung cấp";
            dgvDSHDN.Columns[4].HeaderText = "Tên nhà cung cấp";
            dgvDSHDN.Columns[4].Width = 150;
            dgvDSHDN.Columns[5].HeaderText = "Ngày nhập";
            dgvDSHDN.Columns[6].HeaderText = "Trị giá hoá đơn";
            Show(false);
            rbMaHD.Checked = true;
            if(rbMaHD.Checked == true)
            {
                string query = "select * from tblHDNhap";
                string truongTen = "MaHDN";
                DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
            }
            //autocomplete
            DAO.Function.Instance.autoComplete(txtNV, "select * from tblNhanVien", "TenNV");
            DAO.Function.Instance.autoComplete(txtNCC, "select * from tblNhaCungCap", "TenNCC");
        }
        private void dgvDSHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaHD.Text = dgvDSHDN.CurrentRow.Cells[0].Value.ToString();
            txtNV.Text = dgvDSHDN.CurrentRow.Cells[1].Value.ToString();
            txtNCC.Text = dgvDSHDN.CurrentRow.Cells[3].Value.ToString();
            dtNgayNhap.Text = dgvDSHDN.CurrentRow.Cells[5].Value.ToString();
            txtTongTien.Text = dgvDSHDN.CurrentRow.Cells[6].Value.ToString();
            btnSua.Enabled = true;
            if (float.Parse(dgvDSHDN.CurrentRow.Cells[6].Value.ToString()) == 0)
            {
                btnXoa.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resetValue();
            Show(false);
            LoadListHDN();
        }
        private void rbNVNhap_CheckedChanged(object sender, EventArgs e)
        {
            String query = "select * from tblNhanVien";
            string truongTen = "TenNV";
            DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
        }

        private void rbNCC_CheckedChanged(object sender, EventArgs e)
        {
            String query = "select * from tblNhaCungCap";
            string truongTen = "TenNCC";
            DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if(rbMaHD.Checked == true)
            {
                dgvDSHDN.DataSource = DAO.QLHDNhapDAO.Instance.findMaHD(txtTimKiem.Text);
            }    
            if(rbNCC.Checked == true)
            {
                dgvDSHDN.DataSource = DAO.QLHDNhapDAO.Instance.findNCC(txtTimKiem.Text);
            }
            if(rbNVNhap.Checked == true)
            {
                dgvDSHDN.DataSource = DAO.QLHDNhapDAO.Instance.findNV(txtTimKiem.Text);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtNV.Enabled = true;
            txtNCC.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String MaHDN = txtMaHD.Text;
            if(MessageBox.Show("Bạn muốn xoá hoá đơn này không?","Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DAO.QLHDNhapDAO.Instance.deleteHDN(txtMaHD.Text))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadListHDN();
                }
            }    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String MaHDN = txtMaHD.Text;
            string TenNV = txtNV.Text;
            string TenNCC = txtNCC.Text;
            try
            {
                if (DAO.QLHDNhapDAO.Instance.updateHDN(MaHDN, TenNV, TenNCC))
                {
                    MessageBox.Show("cập nhật dữ liệu thành công");
                    LoadListHDN();
                }
            }
            catch { }
        }

        private void rbMaHD_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select * from tblHDNhap";
            string truongTen = "MaHDN";
            DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
        }

  
    }
}
