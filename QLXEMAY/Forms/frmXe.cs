using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLXEMAY.Forms
{
    public partial class frmXe : Form
    {
        string imagename;
        int checkbtn = 0;
        public frmXe()
        {
            InitializeComponent();
        }
        public void Enable(bool act)
        {
            cbDMXe.Enabled = act;
            txtPhanKhoi.Enabled = act;
            txtSoLuong.Enabled = act;
            txtHangSX.Enabled = act;
            txtGiaBan.Enabled = act;
            txtGiaMua.Enabled = act;
            txtGhiChu.Enabled = act;
            btnThem.Enabled = act;
            btnSua.Enabled = act;
            btnLuu.Enabled = act;
            btnXoa.Enabled = act;
            btnAnhXe.Enabled = act;
        }
        private void ResetValue()
        {
            txtMaXe.ResetText();
            txtTenXe.ResetText();
            cbDMXe.ResetText();
            txtSoLuong.ResetText();
            txtHangSX.ResetText();
            txtPhanKhoi.ResetText();
            txtHangSX.ResetText();
            txtGiaMua.ResetText();
            txtGiaBan.ResetText();
            txtGhiChu.ResetText();
            txtMaXe.ResetText();
            pbAnh.Image = null;
        }

        private void LoadXe()
        {
            DataTable data = new DataTable();
            string query = "exec getXe";
            data = DAO.DataProvider.Instance.ExecuteQuery(query);
            dgvXe.DataSource = data;
        }
        private void btnAnhXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "JPG(*.jpg) |*.jpg|PNG(*.png) |*.png|All files(*.*) |*.* ";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                pbAnh.Image = Image.FromFile(dlgopen.FileName);
                imagename = dlgopen.FileName;
            }
            dlgopen.FilterIndex = 1;
            dlgopen.Title = "Chọn ảnh của xe";
        }
        private void frmXe_Load(object sender, EventArgs e)
        {
            txtMaXe.Enabled = false;
            //ĐỔ dữ liệu vào danh mục xe
            DataTable dataDM = new DataTable();
            string query = "exec getDMXe";
            dataDM = DAO.DataProvider.Instance.ExecuteQuery(query);
            cbDMXe.DataSource = dataDM;
            cbDMXe.DisplayMember = "TenDM";
            cbDMXe.ValueMember = "MaDM";
            cbDMXe.Text = "";
            //Tải dữ liệu lên grid
            LoadXe();
            dgvXe.Columns[0].HeaderText = "Mã xe";
            dgvXe.Columns[1].HeaderText = "Tên xe";
            dgvXe.Columns[2].HeaderText = "Mã danh mục";
            dgvXe.Columns[3].HeaderText = "Số lượng";
            dgvXe.Columns[4].HeaderText = "Giá mua";
            dgvXe.Columns[5].HeaderText = "Giá bán";
            dgvXe.Columns[6].HeaderText = "Ảnh";
            dgvXe.Columns[7].HeaderText = "Ghi chú";
            dgvXe.Columns[8].HeaderText = "Hãng Sản xuất";
            dgvXe.Columns[9].HeaderText = "Phân khối";
            ResetValue();
            Enable(false);
            btnThem.Enabled = true;
            string query_tenxe = "select * from tblXe";
            DAO.Function.Instance.autoComplete(txtTenXe, query_tenxe, "TenXe");
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaXe.Text = dgvXe.CurrentRow.Cells[0].Value.ToString();
            txtTenXe.Text = dgvXe.CurrentRow.Cells[1].Value.ToString();
            cbDMXe.Text = dgvXe.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvXe.CurrentRow.Cells[3].Value.ToString();
            txtGiaMua.Text = dgvXe.CurrentRow.Cells[4].Value.ToString();
            txtGiaBan.Text = dgvXe.CurrentRow.Cells[5].Value.ToString();
            txtGhiChu.Text = dgvXe.CurrentRow.Cells[7].Value.ToString();
            txtHangSX.Text = dgvXe.CurrentRow.Cells[8].Value.ToString();
            txtPhanKhoi.Text = dgvXe.CurrentRow.Cells[9].Value.ToString();
            try
            {
                imagename = dgvXe.CurrentRow.Cells[6].Value.ToString();
                pbAnh.Image = Image.FromFile(imagename);
            }
            catch { }
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBang = "tblXe";
            string maBatDau = "XE0";
            string TruongMa = "MaXe";
            ResetValue();
            txtMaXe.Text = DAO.Function.Instance.createMaNV(tenBang, maBatDau, TruongMa);
            LoadXe();
            Enable(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            checkbtn = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maxe = txtMaXe.Text;
            string tenxe = txtTenXe.Text;
            string dmxe = cbDMXe.SelectedValue.ToString();
            string phankhoi = txtPhanKhoi.Text;
            int soluong = int.Parse(txtSoLuong.Text);
            string hangsx = txtHangSX.Text;
            string giamua, giaban;
            if(txtGiaMua.Text.Trim().Length != 0)
            {
                giamua = txtGiaMua.Text;
            }
            else
            {
                giamua = "0";
            }
            if (txtGiaBan.Text.Trim().Length != 0)
            {
                giaban = txtGiaBan.Text;
            }
            else
            {
                giaban = "0";
            }
            string Anh = imagename;
            string ghichu = txtGhiChu.Text;
            if (checkbtn == 1)
            {
                if (txtTenXe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa điền tên xe!");
                    return;
                }
                if(cbDMXe.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn danh mục xe!");
                    return;
                }
                if (txtPhanKhoi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa điền số phân khối!");
                    return;
                }
                if (txtHangSX.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa điền hãng sản xuất!");
                    return;
                }
                try
                {
                    if (DAO.XeDAO.Instance.insertXe(maxe, tenxe, dmxe, soluong, giamua, giaban,Anh,ghichu, hangsx, phankhoi))
                    {
                        MessageBox.Show("Thêm mới xe thành công!");
                        LoadXe();
                    }
                }
                catch { }
                ResetValue();
                Enable(false);
                btnThem.Enabled = true;
                checkbtn = 0;
            }
            if (checkbtn == 2)
            {
                try
                {
                    if (DAO.XeDAO.Instance.updateXe(maxe, tenxe, dmxe, soluong, giamua, giaban, Anh, ghichu, hangsx, phankhoi))
                    {
                        MessageBox.Show("Cập nhật xe thành công!");
                        LoadXe();
                    }
                }
                catch { }
                ResetValue();
                Enable(false);
                checkbtn = 0;
                btnThem.Enabled = true;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Enable(true);
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            checkbtn = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maxe = txtMaXe.Text;
            try
            {
                if (DAO.XeDAO.Instance.eraseXe(maxe))
                {
                    MessageBox.Show("Xóa xe thành công!");
                    LoadXe();
                }
            }
            catch { }
            ResetValue();
            Enable(false);
            btnThem.Enabled = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dtXe = new DataTable();
            string query = "exec getXe";
            dtXe = DAO.DataProvider.Instance.ExecuteQuery(query);
            if (dtXe.Rows.Count>0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook =
                exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "CỬA HÀNG Xe Máy Dương Lộc Thành";

                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 12;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: 37B - TT Mỹ Đức - Hà Nội";

                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 0973728229";

                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:G5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH CÁC MẶT HÀNG";

                exSheet.get_Range("A7:K7").Font.Bold = true;
                exSheet.get_Range("A7:K7").HorizontalAlignment =
                Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã Xe";
                exSheet.get_Range("C7").Value = "Tên xe";
                exSheet.get_Range("D7").Value = "Mã Danh Mục";
                exSheet.get_Range("E7").Value = "Số lượng";
                exSheet.get_Range("F7").Value = "Giá mua";
                exSheet.get_Range("G7").Value = "Giá bán";
                exSheet.get_Range("H7").Value = "Ảnh";
                exSheet.get_Range("I7").Value = "Ghi chú";
                exSheet.get_Range("K7").Value = "Hãng sản xuất";
                exSheet.get_Range("L7").Value = "Phân khối";

                for (int i = 0; i < dtXe.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":L" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dtXe.Rows[i]["MaXe"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dtXe.Rows[i]["TenXe"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dtXe.Rows[i]["MaDM"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dtXe.Rows[i]["SoLuong"].ToString();
                    exSheet.get_Range("F" + (i + 8).ToString()).Value = dtXe.Rows[i]["GiaMua"].ToString();
                    exSheet.get_Range("G" + (i + 8).ToString()).Value = dtXe.Rows[i]["GiaBan"].ToString();
                    exSheet.get_Range("H" + (i + 8).ToString()).Value = dtXe.Rows[i]["Anh"].ToString();
                    exSheet.get_Range("I" + (i + 8).ToString()).Value = dtXe.Rows[i]["GhiChu"].ToString();
                    exSheet.get_Range("K" + (i + 8).ToString()).Value = dtXe.Rows[i]["HangSX"].ToString();
                    exSheet.get_Range("L" + (i + 8).ToString()).Value = dtXe.Rows[i]["PhanKhoi"].ToString();

                    exSheet.Name = "Xe";
                    //Kích hoạt file Excel
                    exBook.Activate();

                    //Thiết lập các thuộc tính của SaveFileDialog
                    dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc)|*.doc | All files(*.*) | *.* ";
                    dlgSave.FilterIndex = 1;
                    dlgSave.AddExtension = true;
                    dlgSave.DefaultExt = ".xlsx";

                    if (dlgSave.ShowDialog() == DialogResult.OK)
                        //Lưu file Excel
                        exBook.SaveAs(dlgSave.FileName.ToString());

                    //Thoát khỏi ứng dụng
                    exApp.Quit();
                }
            }
            else
                MessageBox.Show("Không có danh sách khách hàng để in");




        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValue();
            Enable(false);
            btnThem.Enabled = true;
            LoadXe();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenxe = txtTenXe.Text;
            dgvXe.DataSource=DAO.XeDAO.Instance.findXe(tenxe);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số");
            }
        }
    }
}