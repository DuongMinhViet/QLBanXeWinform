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
    public partial class frmQuanLiHDB : Form
    {
        public frmQuanLiHDB()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtTimKiem.ResetText();
            txtMaHD.ResetText();
            txtTongTien.ResetText();
            txtKH.ResetText();
            txtNV.ResetText();
        }
        private void Show(bool act)
        {
            txtMaHD.Enabled = act;
            txtNV.Enabled = act;
            txtKH.Enabled = act;
            txtTongTien.Enabled = act;
            btnSua.Enabled = act;
            btnXoa.Enabled = act;
            btnLuu.Enabled = act;
        }
        private void LoadListHDB()
        {
            string query = "exec getHDB";
            dgvDSHDB.DataSource = DAO.DataProvider.Instance.ExecuteQuery(query);
        }
        private void frmQuanLiHDB_Load(object sender, EventArgs e)
        {
            LoadListHDB();
            dgvDSHDB.Columns[0].HeaderText = "Mã hoá đơn bán";
            dgvDSHDB.Columns[1].HeaderText = "Nhân viên";
            dgvDSHDB.Columns[2].HeaderText = "Tên nhân viên";
            dgvDSHDB.Columns[2].Width = 150;
            dgvDSHDB.Columns[3].HeaderText = "Khách hàng";
            dgvDSHDB.Columns[4].HeaderText = "Tên khách hàng";
            dgvDSHDB.Columns[4].Width = 150;
            dgvDSHDB.Columns[5].HeaderText = "Ngày bán";
            dgvDSHDB.Columns[6].HeaderText = "Trị giá hoá đơn";
            Show(false);
            rbMaHD.Checked = true;
            if (rbMaHD.Checked == true)
            {
                string query = "select * from tblHDBan";
                string truongTen = "MaHDB";
                DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
            }
            DAO.Function.Instance.autoComplete(txtNV, "select * from tblNhanVien", "TenNV");
            DAO.Function.Instance.autoComplete(txtKH, "select * from tblKhachHang", "TenKH");
        }

        private void dgvDSHDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dgvDSHDB.CurrentRow.Cells[0].Value.ToString();
            txtNV.Text = dgvDSHDB.CurrentRow.Cells[1].Value.ToString();
            txtKH.Text = dgvDSHDB.CurrentRow.Cells[3].Value.ToString();
            dtNgayBan.Text = dgvDSHDB.CurrentRow.Cells[5].Value.ToString();
            txtTongTien.Text = dgvDSHDB.CurrentRow.Cells[6].Value.ToString();
            btnSua.Enabled = true;
            if (float.Parse(dgvDSHDB.CurrentRow.Cells[6].Value.ToString()) == 0)
            {
                btnXoa.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resetValue();
            Show(false);
            LoadListHDB();
        }

        private void rbNVBan_CheckedChanged(object sender, EventArgs e)
        {
            String query = "select * from tblNhanVien";
            string truongTen = "TenNV";
            DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
        }

        private void rbKH_CheckedChanged(object sender, EventArgs e)
        {
            String query = "select * from tblKhachHang";
            string truongTen = "TenKH";
            DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (rbMaHD.Checked == true)
            {
                dgvDSHDB.DataSource = DAO.QLHDBanDAO.Instance.findMaHDB(txtTimKiem.Text);
            }
            if (rbKH.Checked == true)
            {
                dgvDSHDB.DataSource = DAO.QLHDBanDAO.Instance.findKH(txtTimKiem.Text);
            }
            if (rbNVBan.Checked == true)
            {
                dgvDSHDB.DataSource = DAO.QLHDBanDAO.Instance.findNVB(txtTimKiem.Text);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtNV.Enabled = true;
            txtKH.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String MaHDN = txtMaHD.Text;
            if (MessageBox.Show("Bạn muốn xoá hoá đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DAO.QLHDBanDAO.Instance.deleteHDB(txtMaHD.Text))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadListHDB();
                }
                resetValue();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String MaHDB = txtMaHD.Text;
            string MaNV = txtNV.Text;
            string MaKH = txtKH.Text;
            try
            {
                if (DAO.QLHDBanDAO.Instance.updateHDB(MaHDB, MaNV, MaKH))
                {
                    MessageBox.Show("cập nhật dữ liệu thành công");
                    LoadListHDB();
                }
            }
            catch { }
        }

        private void rbMaHD_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select * from tblHDBan";
            string truongTen = "MaHDB";
            DAO.Function.Instance.autoComplete(txtTimKiem, query, truongTen);
        }
    }
}
