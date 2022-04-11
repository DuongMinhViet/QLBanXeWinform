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
    public partial class frmNhanVien : Form
    {
        int checkbtn = 0;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void resetValue()
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtDienThoai.ResetText();
            txtDiaChi.ResetText();
            txtTimNV.ResetText();
            dtpNgaySinh.Value = DateTime.Today;
            rdNam.Checked = false;
            rdNu.Checked = false;
        }
        private void Show(bool act)
        {
            txtTenNV.Enabled = act;
            txtDiaChi.Enabled = act;
            txtDienThoai.Enabled = act;
            btnThem.Enabled = act;
            btnSua.Enabled = act;
            btnXoa.Enabled = act;
            btnLuu.Enabled = act;
        }
        private void LoadListNV()
        {
            DataTable data = new DataTable();
            string query = "exec getNhanVien";
            data = DAO.DataProvider.Instance.ExecuteQuery(query);
            dgvNhanVien.DataSource = data;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadListNV();
            dgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns[1].Width = 200;
            dgvNhanVien.Columns[2].HeaderText = "Điện thoại";
            dgvNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns[4].HeaderText = "Giới tính";
            dgvNhanVien.Columns[5].HeaderText = "Ngày sinh";
            dgvNhanVien.AllowUserToAddRows = false;
            resetValue();
            Show(false);
            btnThem.Enabled = true;
            txtMaNV.Enabled = false;
            String query = "select * from tblNhanVien";
            DAO.Function.Instance.autoComplete(txtTimNV, query, "TenNV");
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.CurrentRow.Cells[1].Value.ToString();
            txtDienThoai.Text = dgvNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.CurrentRow.Cells[3].Value.ToString();
            if(dgvNhanVien.CurrentRow.Cells[4].Value.ToString()=="Nam")
            {
                rdNam.Checked = true;
            }
            if (dgvNhanVien.CurrentRow.Cells[4].Value.ToString() == "Nữ")
            {
                rdNu.Checked = true;
            }
            dtpNgaySinh.Text = dgvNhanVien.CurrentRow.Cells[5].Value.ToString();
            Show(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBang = "tblNhanVien";
            string maBatDau = "NV0";
            string truongMa = "MaNV";
            resetValue();
            txtMaNV.Text = DAO.Function.Instance.createMaNV(tenBang,maBatDau,truongMa);
            Show(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            checkbtn = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string tenNV = txtTenNV.Text;
            string DienThoai = txtDienThoai.Text;
            string DiaChi = txtDiaChi.Text;
            string GT = getSex();
            string NgaySinh = dtpNgaySinh.Value.ToString();
            if (checkbtn == 1)
            {
                if (txtTenNV.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhân viên");
                    return;
                }    
                if(txtDienThoai.Text.Trim().Length ==0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại nhân viên");
                    return;
                }    
                if(txtDiaChi.Text.Trim().Length ==0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ nhân viên");
                    return;
                }    
                if(rdNam.Checked == false && rdNu.Checked == false)
                {
                    MessageBox.Show("Bạn phải chọn giới tính cho nhân viên");
                    return;
                }
                try
                {
                    if (DAO.NhanVienDAO.Instance.insertNV(maNV,tenNV,DienThoai,DiaChi,GT,NgaySinh))
                    {
                        MessageBox.Show("Thêm mới nhân viên thành công!");
                        LoadListNV();
                    }
                }
                catch { }
                resetValue();
                Show(false);
                btnThem.Enabled = true;
                checkbtn = 0;
            }
            if(checkbtn == 2)
            {
                try
                {
                    if (DAO.NhanVienDAO.Instance.updateNV(maNV, tenNV, DienThoai, DiaChi, GT, NgaySinh))
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công!");
                        LoadListNV();
                    }
                }
                catch { } 
                resetValue();
                Show(false);
                btnThem.Enabled = true;
                checkbtn = 0;   
            }    
        }
        private string getSex()
        {
            string s = "";
            if(rdNam.Checked == true)
            {
                s = "Nam";
            }
            if (rdNu.Checked == true)

            {
                s = "Nữ";
            }
            return s;
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
            string MaNV = txtMaNV.Text;
            try
            {
                if (DAO.NhanVienDAO.Instance.eraseNV(MaNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!");
                    LoadListNV();
                }
            }
            catch { }
            resetValue();
            Show(false);
            btnThem.Enabled = true;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dtNV = new DataTable();
            string query = "exec getNhanVien";
            dtNV = DAO.DataProvider.Instance.ExecuteQuery(query);



            if (dtNV.Rows.Count > 0) //TH có dữ liệu để ghi
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
                header.Value = "DANH SÁCH CÁC NHÂN VIÊN";



                //Định dạng tiêu đề bảng
                exSheet.get_Range("A7:G7").Font.Bold = true;
                exSheet.get_Range("A7:G7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã NV";
                exSheet.get_Range("C7").Value = "Tên NV";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Số điện thoại";
                exSheet.get_Range("D7").ColumnWidth = 15;
                exSheet.get_Range("E7").Value = "Địa chỉ";
                exSheet.get_Range("E7").ColumnWidth = 10;
                exSheet.get_Range("F7").Value = "Giới tính";
                exSheet.get_Range("G7").Value = "Ngày Sinh";
                exSheet.get_Range("G7").ColumnWidth = 15;

                //In dữ liệu
                for (int i = 0; i < dtNV.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dtNV.Rows[i]["MaNV"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dtNV.Rows[i]["TenNV"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dtNV.Rows[i]["DienThoai"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dtNV.Rows[i]["DiaChi"].ToString();
                    exSheet.get_Range("F" + (i + 8).ToString()).Value = dtNV.Rows[i]["GioiTinh"].ToString();
                    exSheet.get_Range("G" + (i + 8).ToString()).Value = DateTime.Parse(dtNV.Rows[i]["NgaySinh"].ToString());
                }



                exSheet.Name = "NhanVien";
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
                MessageBox.Show("Không có danh sách nhân viên để in");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            resetValue();
            Show(false);
            btnThem.Enabled = true;
            LoadListNV();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           

            if(txtTimNV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải điền tên nhân viên cần nhập");
                return;
            }
            string tenNV = txtTimNV.Text;
            DataTable data = new DataTable(); 
            data = DAO.NhanVienDAO.Instance.findNV(tenNV);
            dgvNhanVien.DataSource = data;
            if(data.Rows.Count <=0)
            {
                MessageBox.Show("Không có nhân viên bạn cần tìm");
                return;
            }    
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn phải nhập số!");
            }
        }
    }
}
