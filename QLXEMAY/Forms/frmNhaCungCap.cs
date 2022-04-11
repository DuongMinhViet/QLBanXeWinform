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
    public partial class frmNhaCungCap : Form
    {
        int checkbtn = 0;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void resetValue()
        {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtTimNCC.ResetText();
        }

        private void Show(bool act)
        {
            txtTenNCC.Enabled = act;
            txtDiaChi.Enabled = act;
            txtSDT.Enabled = act;
            btnThem.Enabled = act;
            btnSua.Enabled = act;
            btnXoa.Enabled = act;
            btnLuu.Enabled = act;
        }

        private void LoadListNCC()
        {
            DataTable data = new DataTable();
            string query = "exec getNhaCungCap";
            data = DAO.DataProvider.Instance.ExecuteQuery(query);
            dgvNCC.DataSource = data;

        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadListNCC();
            dgvNCC.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvNCC.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvNCC.Columns[1].Width = 200;
            dgvNCC.Columns[2].HeaderText = "Số điện thoại";
            dgvNCC.Columns[3].HeaderText = "Địa chỉ";
            dgvNCC.AllowUserToAddRows = false;
            resetValue();
            Show(false);
            btnThem.Enabled = true;
            txtMaNCC.Enabled = false;
            string query = "select * from tblNhaCungCap";
            DAO.Function.Instance.autoComplete(txtTimNCC, query, "TenNCC");
            
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            Show(false);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBang = "tblNhaCungCap";
            string maBatDau = "NCC0";
            string truongMa = "MaNCC";
            resetValue();
            txtMaNCC.Text = DAO.Function.Instance.createMaNV(tenBang, maBatDau, truongMa);
            Show(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            checkbtn = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string SDT = txtSDT.Text;
            string DiaChi = txtDiaChi.Text;
            if (checkbtn == 1)
            {
                if (txtTenNCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên nhà cung cấp");
                    return;
                }
                if (txtSDT.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại nhà cung cấp");
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ nhà cung cấp");
                    return;
                }
                try
                {
                    if (DAO.NhaCungCapDAO.Instance.insertNCC(maNCC,tenNCC,SDT,DiaChi))
                    {
                        MessageBox.Show("Thêm mới nhà cung cấp thành công!");
                        LoadListNCC();
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
                    if (DAO.NhaCungCapDAO.Instance.updateNCC(maNCC, tenNCC, SDT, DiaChi))
                    {
                        MessageBox.Show("Sửa thông tin nhà cung cấp thành công!");
                        LoadListNCC();
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
            string MaNCC = txtMaNCC.Text;
            try
            {
                if (DAO.NhaCungCapDAO.Instance.eraseNCC(MaNCC))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!");
                    LoadListNCC();
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
            LoadListNCC();
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            if (txtTimNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải điền tên nhà cung cấp cần tìm");
                return;
            }
            string tenNCC = txtTimNCC.Text;
            DataTable data = new DataTable();
            data = DAO.NhaCungCapDAO.Instance.findNCC(tenNCC);
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            if (data.Rows.Count <= 0)
            {
                MessageBox.Show("Không có nhà cung cấp bạn cần tìm");
                return;
            }
            else
            {
                dgvNCC.DataSource = data;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataTable dtNCC = new DataTable();
            string query = "exec getNhaCungCap";
            dtNCC = DAO.DataProvider.Instance.ExecuteQuery(query);



            if (dtNCC.Rows.Count > 0) //TH có dữ liệu để ghi
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
                header.Value = "DANH SÁCH CÁC NHÀ CUNG CẤP";



                //Định dạng tiêu đề bảng
                exSheet.get_Range("A7:G7").Font.Bold = true;
                exSheet.get_Range("A7:G7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã NCC";
                exSheet.get_Range("C7").Value = "Tên NCC";
                exSheet.get_Range("D7").Value = "Số điện thoại";
                exSheet.get_Range("D7").ColumnWidth = 15;
                exSheet.get_Range("E7").Value = "Địa chỉ";
                exSheet.get_Range("E7").ColumnWidth = 10;



                //In dữ liệu
                for (int i = 0; i < dtNCC.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = dtNCC.Rows[i]["MaNCC"].ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dtNCC.Rows[i]["TenNCC"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dtNCC.Rows[i]["DiaChi"].ToString();
                    exSheet.get_Range("E" + (i + 8).ToString()).Value = dtNCC.Rows[i]["SDT"].ToString();
                }



                exSheet.Name = "NhaCungCap";
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
                MessageBox.Show("Không có danh sách nhà cung cấp để in");
        }
    }
}
