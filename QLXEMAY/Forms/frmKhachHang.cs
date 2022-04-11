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
    public partial class frmKhachHang : Form
    {
        int checkbtn = 0;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void resetValue()
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtTimKH.ResetText();
        }

        private void Show(bool act)
        {
            txtTenKH.Enabled = act;
            txtDiaChi.Enabled = act;
            txtSDT.Enabled = act;
            btnThem.Enabled = act;
            btnSua.Enabled = act;
            btnXoa.Enabled = act;
            btnLuu.Enabled = act;
        }

        private void LoadListKH()
        {
            DataTable data = new DataTable();
            string query = "exec getKhachHang";
            data = DAO.DataProvider.Instance.ExecuteQuery(query);
            dgvKhachHang.DataSource = data;

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadListKH();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[1].Width = 200;
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";
            dgvKhachHang.AllowUserToAddRows = false;
            resetValue();
            Show(false);
            btnThem.Enabled = true;
            txtMaKH.Enabled = false;
            string query = "select * from tblKhachHang";
            DAO.Function.Instance.autoComplete(txtTimKH, query, "TenKH");
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            Show(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBang = "tblKhachHang";
            string maBatDau = "KH0";
            string truongMa = "MaKH";
            resetValue();
            txtMaKH.Text = DAO.Function.Instance.createMaNV(tenBang, maBatDau, truongMa);
            Show(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            checkbtn = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text;
            string tenKH = txtTenKH.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            if (checkbtn == 1)
            {
                if (txtTenKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách hàng");
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại khách hàng");
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ khách hàng");
                    return;
                }
                try
                {
                    if (DAO.KhachHangDAO.Instance.insertKH(maKH, tenKH, DiaChi, SDT))
                    {
                        MessageBox.Show("Thêm mới khách hàng thành công!");
                        LoadListKH();
                    }
                }
                catch { }
                resetValue();
                Show(false);
                checkbtn = 0;
            }
            if (checkbtn == 2)
            {
                try
                {
                    if (DAO.KhachHangDAO.Instance.updateKH(maKH, tenKH, DiaChi, SDT))
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công!");
                        LoadListKH();
                    }
                }
                catch { }
                resetValue();
                Show(false);
                btnThem.Enabled = true;
                checkbtn = 0;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Show(true);
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            checkbtn = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text;
            try
            {
                if (DAO.KhachHangDAO.Instance.eraseKH(MaKH))
                {
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadListKH();
                }
            }
            catch { }
            resetValue();
            Show(false);
            btnThem.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resetValue();
            Show(false);
            btnThem.Enabled = true;
            LoadListKH();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            if (txtTimKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải điền tên khách hàng cần tìm");
                return;
            }
            string tenKH = txtTimKH.Text;
            DataTable data = new DataTable();
            data = DAO.KhachHangDAO.Instance.findKH(tenKH);
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            if (data.Rows.Count <= 0)
            {
                MessageBox.Show("Không có khách hàng bạn cần tìm");
                return;
            }
            else
            {
                dgvKhachHang.DataSource = data;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dtKH = new DataTable();
            string query = "exec getKhachHang";
            dtKH = DAO.DataProvider.Instance.ExecuteQuery(query);



            if (dtKH.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];



                //Định dạng chung
                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:G5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH CÁC KHÁCH HÀNG";



                //Định dạng tiêu đề bảng
                exSheet.get_Range("A7:G7").Font.Bold = true;
                exSheet.get_Range("A7:G7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã KH";
                exSheet.get_Range("C7").Value = "Tên KH";
                exSheet.get_Range("D7").Value = "Địa chỉ";
                exSheet.get_Range("D7").ColumnWidth = 15;
                exSheet.get_Range("E7").Value = "Số điện thoại";
                exSheet.get_Range("E7").ColumnWidth = 15;



                //In dữ liệu
                for (int i = 0; i < dtKH.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dtKH.Rows[i]["MaKH"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dtKH.Rows[i]["TenKH"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dtKH.Rows[i]["DiaChi"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dtKH.Rows[i]["SDT"].ToString();
                }



                exSheet.Name = "KhachHang";
                //Kích hoạt file Excel
                exBook.Activate();



                //Thiết lập các thuộc tính của SaveFileDialog
                saveFile.Filter = "Excel Workbook|*.xlsx |Excel 97-2003 Workbook|*.xls |All files|*.*";
                saveFile.FilterIndex = 1;
                saveFile.AddExtension = true;
                saveFile.DefaultExt = ".xlsx";



                if (saveFile.ShowDialog() == DialogResult.OK)
                    //Lưu file Excel
                    exBook.SaveAs(saveFile.FileName.ToString());



                //Thoát khỏi ứng dụng
                exApp.Quit();
            }
            else
                MessageBox.Show("Không có danh sách khách hàng để in");
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số!");
            }
        }
    }
}
