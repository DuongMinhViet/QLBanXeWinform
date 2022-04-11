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
    public partial class frmDanhMucXe : Form
    {
        int checkbtn = 0;
        public frmDanhMucXe()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtMaDMXe.ResetText();
            txtTenDMXe.ResetText();
            txtTimDMXe.ResetText();
        }
        private void show(bool act)
        {
            txtTenDMXe.Enabled = act;
            btnThem.Enabled = act;
            btnSua.Enabled = act;
            btnLuu.Enabled = act;
            btnXoa.Enabled = act;
        }
        private void LoadListDMXe()
        {
            dgvDMXe.DataSource = DAO.DMXeDAO.Instance.getDMXe();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            resetValue();
            show(false);
            btnThem.Enabled = true;
            LoadListDMXe();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaDMXe = txtMaDMXe.Text;
            string TenDMXe = txtTenDMXe.Text;
            if(checkbtn == 1)
            {
                if(txtTenDMXe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên danh mục");
                    return;
                }
                try
                {
                    if (DAO.DMXeDAO.Instance.insertDMXe(MaDMXe, TenDMXe)){
                        MessageBox.Show("Thêm mới thành công!");
                        LoadListDMXe();
                    }
                }
                catch { }
                checkbtn = 0;
                resetValue();
                show(false);
                btnThem.Enabled = true;
            }
            if(checkbtn==2)
            {
                try
                {
                    if (DAO.DMXeDAO.Instance.updateDMXe(MaDMXe, TenDMXe))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công !");
                        LoadListDMXe();
                    }
                }
                catch { }
                checkbtn = 0;
                resetValue();
                show(false);
                btnThem.Enabled = true;
            }    
        }
        private void frmDanhMucXe_Load(object sender, EventArgs e)
        {
            LoadListDMXe();
            txtMaDMXe.Enabled = false;
            dgvDMXe.Columns[0].HeaderText = "Mã danh mục";
            dgvDMXe.Columns[1].HeaderText = "Tên danh mục";
            dgvDMXe.AllowUserToAddRows = false;
            show(false);
            btnThem.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBang = "tblDanhMucXe";
            string maBatDau = "MA0";
            string TruongMa = "MaDM";
            resetValue();
            txtMaDMXe.Text = DAO.Function.Instance.createMaNV(tenBang, maBatDau, TruongMa);
            show(true);
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            checkbtn = 1;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            show(false);
            txtTenDMXe.Enabled = true;
            btnLuu.Enabled = true;
            checkbtn = 2;
        }

        private void dgvDMXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDMXe.Text = dgvDMXe.CurrentRow.Cells[0].Value.ToString();
            txtTenDMXe.Text = dgvDMXe.CurrentRow.Cells[1].Value.ToString();
            show(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNV = txtMaDMXe.Text;
            try
            {
                if (DAO.DMXeDAO.Instance.eraseDMXe(MaNV))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadListDMXe();
                }
                resetValue();
                show(false);
                btnThem.Enabled = true;
            }
            catch { }
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            if (txtTimDMXe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải điền tên danh mục cần nhập");
                return;
            }
            string tenDMXe = txtTimDMXe.Text;
            DataTable data = new DataTable();
            data = DAO.DMXeDAO.Instance.findDMXE(tenDMXe);
            dgvDMXe.DataSource = data;
            if (data.Rows.Count <= 0)
            {
                MessageBox.Show("Không có danh mục bạn cần tìm");
                return;
            }

        }
    }
}
