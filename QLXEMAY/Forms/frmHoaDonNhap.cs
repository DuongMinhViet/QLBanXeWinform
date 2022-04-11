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
    public partial class frmHoaDonNhap : Form
    {
        int checkbtn = 0;
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtMaHD.ResetText();
            dtNgayNhap.Value = DateTime.Today;
            cboMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            cboMaXe.ResetText();
            txtMaDM.ResetText();
            txtSoLuong.ResetText();
            txtTenXe.ResetText();
            txtTenDM.ResetText();
            txtDonGia.ResetText();
            txtThanhTien.ResetText();
            txtTimMaHD.ResetText();
            dgvHDN.DataSource = null;
        }
        private void show(bool act)
        {
            txtMaHD.Enabled = act;
            txtMaNV.Enabled = act;
            txtTenNV.Enabled = act;
            cboMaNCC.Enabled = act;
            txtTenNCC.Enabled = act;
            txtDiaChi.Enabled = act;
            txtDienThoai.Enabled = act;
            cboMaXe.Enabled = act;
            txtMaDM.Enabled = act;
            txtSoLuong.Enabled = act;
            txtTenXe.Enabled = act;
            txtTenDM.Enabled = act;
            txtDonGia.Enabled = act;
            txtThanhTien.Enabled = act;
            btnAddNCC.Enabled = act;
            btnAddMaXe.Enabled = act;
            btnThem.Enabled = act;
            btnLuu.Enabled = act;
            btnSua.Enabled = act;
            btnThem.Enabled = act;
        }
        private void LoadListCTHDN(string MaCTHDN)
        {
            dgvHDN.DataSource = DAO.CTHoaDonNhapDAO.Instance.getCTHoaDonNhap(MaCTHDN);
            //Datagridview
            dgvHDN.Columns[0].HeaderText = "Mã Xe";
            dgvHDN.Columns[1].HeaderText = "Tên xe";
            dgvHDN.Columns[2].HeaderText = "Danh mục xe";
            dgvHDN.Columns[3].HeaderText = "Số lượng";
            dgvHDN.Columns[4].HeaderText = "Đơn giá nhập";
            dgvHDN.Columns[5].HeaderText = "Thành Tiền";
            dgvHDN.AllowUserToAddRows = false;
        }
        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            show(false);
            btnThem.Enabled = true;
            string MaCTHDN = txtMaHD.Text;
            LoadListCTHDN(MaCTHDN);
            //Fill dữ liệu vào cboNCC
            cboMaNCC.Enabled = true;
            cboMaNCC.DataSource = DAO.DataProvider.Instance.ExecuteQuery("select * from tblNhaCungCap");
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "MaNCC";
            btnAddNCC.Enabled = true;
            cboMaNCC.Text = "";
            //Fill dữ liệu vào cboXe
            cboMaXe.Enabled = true;
            cboMaXe.DataSource = DAO.DataProvider.Instance.ExecuteQuery("select * from tblXe");
            cboMaXe.DisplayMember = "MaXe";
            cboMaXe.ValueMember = "MaXe";
            btnAddMaXe.Enabled = true;
            cboMaXe.Text = "";
            //GetNhanVien
            txtMaNV.Text = DAO.Function.getMaNV;
            //AutoComplete
            DAO.Function.Instance.autoComplete(txtTimMaHD, "select * from tblChiTietHDN", "MaCTHDN");
        }
        private void dgvHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            cboMaXe.Text = dgvHDN.CurrentRow.Cells[0].Value.ToString();
            txtSoLuong.Text = dgvHDN.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTimMaHD.Text.Trim().Length != 0)
                {
                    string MaCTHDN = txtTimMaHD.Text;
                    LoadListCTHDN(MaCTHDN);
                    txtMaHD.Text = MaCTHDN;
                    string query = string.Format("Select tblHDNhap.MaNV, tblHDNhap.MaNCC, tblChiTietHDN.MaXe from tblChiTietHDN join tblHDNhap on tblChiTietHDN.MaCTHDN = tblHDNhap.MaHDN  where MaCTHDN = '{0}'", MaCTHDN);
                    DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query);
                    if(data.Rows.Count >0)
                    {
                        txtMaNV.Text = data.Rows[0]["MaNV"].ToString();
                        cboMaNCC.Text = data.Rows[0]["MaNCC"].ToString();
                        cboMaXe.Text = data.Rows[0]["MaXe"].ToString();
                        cboMaXe.Enabled = false;
                        cboMaNCC.Enabled = false;
                        txtThanhTien.Text = DAO.CTHoaDonNhapDAO.Instance.getThanhTien(MaCTHDN);
                        txtSoLuong.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Hoá đơn này không có sản phẩm!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập mã hoá đơn cần tìm!");
                    return;
                }
            }
            catch { }
        }
        private void cboMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MaNCC = cboMaNCC.Text;
                string query = string.Format("Select * from tblNhaCungCap where MaNCC = '{0}'", MaNCC);
                DataTable dataNCC = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenNCC.Text = dataNCC.Rows[0]["TenNCC"].ToString();
                txtDiaChi.Text = dataNCC.Rows[0]["DiaChi"].ToString();
                txtDienThoai.Text = dataNCC.Rows[0]["SDT"].ToString();
            }
            catch { txtTenNCC.Text = ""; txtDiaChi.Text = "";txtDienThoai.Text = ""; }
        }
        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.Enabled = true;
                string MaXe = cboMaXe.Text;
                string query = string.Format("select TenXe,tblXe.MaDM,TenDM,GiaMua from tblXe join tblDanhMucXe on tblXe.MaDM = tblDanhMucXe.MaDM where MaXe = '{0}'",MaXe);
                DataTable dataXe = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenXe.Text = dataXe.Rows[0]["TenXe"].ToString();
                txtMaDM.Text = dataXe.Rows[0]["MaDM"].ToString();
                txtTenDM.Text = dataXe.Rows[0]["TenDM"].ToString();
                txtDonGia.Text = dataXe.Rows[0]["GiaMua"].ToString();
            }
            catch { txtTenXe.Text = "";txtMaDM.Text = "";txtTenDM.Text = "";txtDonGia.Text = ""; }
        }

        private void cboMaDM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string MaDM = txtMaDM.Text;
                string query = string.Format("select * from tblDanhMucXe where MaDM ='{0}'", MaDM);
                DataTable dataDM = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenDM.Text = dataDM.Rows[0]["TenDM"].ToString();
            }
            catch { txtTenDM.Text = ""; }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("select TenNV from tblNhanVien where MaNV = '{0}'", txtMaNV.Text);
                DataTable dt = new DataTable();
                dt = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenNV.Text = dt.Rows[0]["TenNV"].ToString();
            }
            catch { }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            resetValue();
            string tenBang = "tblChiTietHDN";
            string maBatDau = "HDN0";
            string TruongMa = "MaCTHDN";
            txtMaHD.Text = DAO.Function.Instance.createMaNV(tenBang, maBatDau, TruongMa);
            btnLuu.Enabled = true;
            txtDonGia.Enabled = true;
            checkbtn = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            String HDN = txtMaHD.Text;
            string MaDM = txtMaDM.Text;
            string MaXe = cboMaXe.Text;
            string SoLuong = txtSoLuong.Text;
            string DonGiaNhap = txtDonGia.Text;
            string MaNV = txtMaNV.Text;
            string MaNCC = cboMaNCC.Text;
            string NgayNhap = dtNgayNhap.Value.ToString();
            if (checkbtn == 1)
            {
                try
                {
                    if (cboMaNCC.Text.Trim().Length ==0 )
                    {
                        MessageBox.Show("Bạn phải chọn nhà cung cấp");
                        return;
                    }
                    if(txtSoLuong.Text.Trim().Length ==0)
                    {
                        MessageBox.Show("Bạn phải chọn số lượng");
                        return;
                    }
                    DataTable dataCTHDN = DAO.DataProvider.Instance.ExecuteQuery(string.Format("SELECT MaXe,MaDM FROM tblChiTietHDN where MaCTHDN = '{0}' and MaXe ='{1}' and MaDM = '{2}'",HDN,MaXe,MaDM));
                    if(dataCTHDN.Rows.Count > 0)
                    {
                        MessageBox.Show("Bạn đã nhập sản phẩm này rồi!");
                        return;
                    }
                    if (DAO.CTHoaDonNhapDAO.Instance.insertHDNhap(HDN, MaDM, MaXe, SoLuong, DonGiaNhap, MaNV, MaNCC, NgayNhap))
                    {
                        MessageBox.Show("Thêm mới thành công!");
                        LoadListCTHDN(HDN);
                    }
                    txtThanhTien.Text = DAO.CTHoaDonNhapDAO.Instance.getThanhTien(HDN);

                }
                catch { }
                DAO.Function.Instance.autoComplete(txtTimMaHD, "select * from tblChiTietHDN", "MaCTHDN");

            }
            if (checkbtn == 2)
            {
                try
                {
                    if (DAO.CTHoaDonNhapDAO.Instance.updateCTHDNhap(HDN,MaXe,SoLuong,DonGiaNhap))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadListCTHDN(HDN);
                    }
                    txtThanhTien.Text = DAO.CTHoaDonNhapDAO.Instance.getThanhTien(HDN);
                }
                catch { }
                DAO.Function.Instance.autoComplete(txtTimMaHD, "select * from tblChiTietHDN", "MaCTHDN");
                btnSua.Enabled = false;

            }
        }
        private void cboMaNCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string MaNCC = cboMaNCC.Text;
                string query = string.Format("Select * from tblNhaCungCap where MaNCC = '{0}'", MaNCC);
                DataTable dataNCC = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenNCC.Text = dataNCC.Rows[0]["TenNCC"].ToString();
                txtDiaChi.Text = dataNCC.Rows[0]["DiaChi"].ToString();
                txtDienThoai.Text = dataNCC.Rows[0]["SDT"].ToString();
            }
            catch { txtTenNCC.Text = ""; txtDiaChi.Text = ""; txtDienThoai.Text = ""; }
        }
        private void cboMaXe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSoLuong.Enabled = false;
                string MaCTHDN = txtMaHD.Text;
                string query = string.Format("select TenXe,tblChiTietHDN.MaDM,tblDanhMucXe.TenDM,tblChiTietHDN.SoLuong,tblChiTietHDN.DonGiaNhap from tblChiTietHDN join tblXe on tblChiTietHDN.MaXe = tblXe.MaXe join tblDanhMucXe on tblDanhMucXe.MaDM = tblChiTietHDN.MaDM where MaCTHDN ='{0}'",MaCTHDN );
                DataTable dataXe = DAO.DataProvider.Instance.ExecuteQuery(query);
                txtTenXe.Text = dataXe.Rows[0]["TenXe"].ToString();
                txtMaDM.Text = dataXe.Rows[0]["MaDM"].ToString();
                txtTenDM.Text = dataXe.Rows[0]["TenDM"].ToString();
                txtSoLuong.Text = dataXe.Rows[0]["SoLuong"].ToString();
                txtDonGia.Text = dataXe.Rows[0]["DonGiaNhap"].ToString();
            }
            catch { txtTenXe.Text = ""; txtMaDM.Text = ""; txtTenDM.Text = ""; txtDonGia.Text = ""; }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resetValue();
            dgvHDN.DataSource = null;
            btnThem.Enabled = true;
            btnTim.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cboMaNCC.Enabled = true;
            txtSoLuong.Enabled = true;
            cboMaXe.Enabled = true;
            txtDonGia.Enabled = true;
            checkbtn = 2;
            btnThem.Enabled = false;
        }

        private void dgvHDN_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xoá bản ghi này không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string MaXe = dgvHDN.CurrentRow.Cells[0].Value.ToString();
                    if(DAO.CTHoaDonNhapDAO.Instance.eraseCTHDNhap(MaXe))
                    {
                        MessageBox.Show("Xoá thành công!");
                        LoadListCTHDN(txtMaHD.Text);
                    }
                    if (dgvHDN.Rows.Count > 0)
                    {
                        LoadListCTHDN(txtMaHD.Text);
                    }
                    else
                    {
                        resetValue();
                    }
                }
                catch { }
            }    
        }
        private void btnAddNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap f_NCC = new frmNhaCungCap();
            f_NCC.ShowDialog();
            cboMaNCC.DataSource = DAO.DataProvider.Instance.ExecuteQuery("select * from tblNhaCungCap");
            cboMaNCC.DisplayMember = "MaNCC";
            cboMaNCC.ValueMember = "MaNCC";
            cboMaNCC.Text = "";
        }
        private void btnAddMaXe_Click(object sender, EventArgs e)
        {
            frmXe f_Xe = new frmXe();
            f_Xe.ShowDialog();
            cboMaXe.Enabled = true;
            cboMaXe.DataSource = DAO.DataProvider.Instance.ExecuteQuery("select * from tblXe");
            cboMaXe.DisplayMember = "MaXe";
            cboMaXe.ValueMember = "MaXe";
            btnAddMaXe.Enabled = true;
            cboMaXe.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
