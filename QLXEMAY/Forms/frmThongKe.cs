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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        private void resetvalue()
        {
            txtNam.ResetText();
            txtTongThu.ResetText();
            dgvDoanhThu.DataSource = null;
            chart1.DataSource = null;
        }
        private void LoadDoanhThu(int nam)
        {
            dgvDoanhThu.DataSource = DAO.ThongKeDAO.Instances.DoanhThu(nam);
            dgvDoanhThu.Columns[0].HeaderText = "Tháng";
            dgvDoanhThu.Columns[1].HeaderText = "Doanh Thu";
            dgvDoanhThu.Columns[1].Width = 120;
        }
        private void frmThongKe_Load(object sender, EventArgs e)
        {
            txtTongThu.Enabled = false;
        }

        private void btnNhapDT_Click(object sender, EventArgs e)
        {
            if(txtNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm");
                return;
            }
            int nam = int.Parse(txtNam.Text);
            LoadDoanhThu(nam);
            txtTongThu.Text = DAO.ThongKeDAO.Instances.TongTien(nam);
        }

        private void btnXoaDT_Click(object sender, EventArgs e)
        {
            resetvalue();
        }

        private void btnBaoCaoDT_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(txtNam.Text);
            DataTable data = DAO.ThongKeDAO.Instances.DoanhThu(nam);
            chart1.DataSource = data;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh Thu";
            chart1.Series["DoanhThu"].XValueMember = "Thang";
            chart1.Series["DoanhThu"].YValueMembers = "DoanhThu";
            dgvDoanhThu.DataSource = data;
            if (data.Rows.Count >0)
            {
                //khai bao va khoi tao 
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Bold = Color.Blue;
                tenCuaHang.Value = "Cửa hàng bán xe máy Minh Việt";

                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 12;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Bold = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: Xóm 6 - Xã Phúc Lâm - Hà Nội";

                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Bold = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 0965990999";

                Excel.Range Header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:E5").Merge(true);
                Header.Font.Size = 13;
                Header.Font.Bold = true;
                Header.Font.Bold = Color.Red;
                Header.Value = "Thống kê doanh thu";


                //Định dang tiêu đề
                exSheet.get_Range("B7:D7").Font.Bold = true;
                exSheet.get_Range("B7:D7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("B7").Value = "Số thứ tự";
                exSheet.get_Range("C7").Value = "Tháng";
                exSheet.get_Range("D7").Value = "Doanh thu";
                exSheet.get_Range("D7").ColumnWidth = 25;

                //In dữ liệu 
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    exSheet.get_Range("B" + (i + 8).ToString() + ":D" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("B" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = data.Rows[i]["Thang"].ToString();
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = data.Rows[i]["DoanhThu"].ToString();
                }
                Excel.Range TongThu = (Excel.Range)exSheet.Cells[15, 4];
                TongThu.Font.Size = 12;
                TongThu.Font.Bold = true;
                TongThu.Font.Bold = Color.Blue;
                TongThu.Value = string.Format("Tổng thu của năm {0} là {1}", txtNam.Text, txtTongThu.Text);
                exSheet.Name = "DoanhThu";
                exBook.Activate();
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "Excel Document (*.xlsx |*.xlsx   |All files(*.*)|*.*";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xlsx";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());
                exApp.Quit();
            }
            else
            {
                MessageBox.Show("Không có doanh thu");
            }
        }

    }
}
