
namespace QLXEMAY.Forms
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaDT = new System.Windows.Forms.Button();
            this.btnNhapDT = new System.Windows.Forms.Button();
            this.btnBaoCaoDT = new System.Windows.Forms.Button();
            this.txtTongThu = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblNam = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblThongKe);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 76);
            this.panel1.TabIndex = 0;
            // 
            // lblThongKe
            // 
            this.lblThongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.ForeColor = System.Drawing.Color.Snow;
            this.lblThongKe.Location = new System.Drawing.Point(378, 18);
            this.lblThongKe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(205, 39);
            this.lblThongKe.TabIndex = 0;
            this.lblThongKe.Text = "THỐNG KÊ";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.69187F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.30813F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(880, 550);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnXoaDT);
            this.groupBox1.Controls.Add(this.btnNhapDT);
            this.groupBox1.Controls.Add(this.btnBaoCaoDT);
            this.groupBox1.Controls.Add(this.txtTongThu);
            this.groupBox1.Controls.Add(this.txtNam);
            this.groupBox1.Controls.Add(this.lblTongThu);
            this.groupBox1.Controls.Add(this.lblNam);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(135, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(609, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Doanh Thu";
            // 
            // btnXoaDT
            // 
            this.btnXoaDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaDT.BackColor = System.Drawing.Color.MintCream;
            this.btnXoaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDT.ForeColor = System.Drawing.Color.Brown;
            this.btnXoaDT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDT.Image")));
            this.btnXoaDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDT.Location = new System.Drawing.Point(466, 167);
            this.btnXoaDT.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaDT.Name = "btnXoaDT";
            this.btnXoaDT.Size = new System.Drawing.Size(73, 43);
            this.btnXoaDT.TabIndex = 6;
            this.btnXoaDT.Text = "Xóa";
            this.btnXoaDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDT.UseVisualStyleBackColor = false;
            this.btnXoaDT.Click += new System.EventHandler(this.btnXoaDT_Click);
            // 
            // btnNhapDT
            // 
            this.btnNhapDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNhapDT.BackColor = System.Drawing.Color.MintCream;
            this.btnNhapDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapDT.ForeColor = System.Drawing.Color.Brown;
            this.btnNhapDT.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDT.Image")));
            this.btnNhapDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapDT.Location = new System.Drawing.Point(321, 167);
            this.btnNhapDT.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapDT.Name = "btnNhapDT";
            this.btnNhapDT.Size = new System.Drawing.Size(87, 43);
            this.btnNhapDT.TabIndex = 5;
            this.btnNhapDT.Text = "Nhập";
            this.btnNhapDT.UseVisualStyleBackColor = false;
            this.btnNhapDT.Click += new System.EventHandler(this.btnNhapDT_Click);
            // 
            // btnBaoCaoDT
            // 
            this.btnBaoCaoDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBaoCaoDT.BackColor = System.Drawing.Color.MintCream;
            this.btnBaoCaoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoDT.ForeColor = System.Drawing.Color.Brown;
            this.btnBaoCaoDT.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoDT.Image")));
            this.btnBaoCaoDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoDT.Location = new System.Drawing.Point(157, 167);
            this.btnBaoCaoDT.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCaoDT.Name = "btnBaoCaoDT";
            this.btnBaoCaoDT.Size = new System.Drawing.Size(93, 43);
            this.btnBaoCaoDT.TabIndex = 4;
            this.btnBaoCaoDT.Text = "Báo cáo";
            this.btnBaoCaoDT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCaoDT.UseVisualStyleBackColor = false;
            this.btnBaoCaoDT.Click += new System.EventHandler(this.btnBaoCaoDT_Click);
            // 
            // txtTongThu
            // 
            this.txtTongThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThu.Location = new System.Drawing.Point(274, 102);
            this.txtTongThu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Size = new System.Drawing.Size(217, 23);
            this.txtTongThu.TabIndex = 2;
            // 
            // txtNam
            // 
            this.txtNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNam.Location = new System.Drawing.Point(274, 49);
            this.txtNam.Margin = new System.Windows.Forms.Padding(2);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(217, 23);
            this.txtNam.TabIndex = 1;
            // 
            // lblTongThu
            // 
            this.lblTongThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.ForeColor = System.Drawing.Color.Teal;
            this.lblTongThu.Location = new System.Drawing.Point(174, 105);
            this.lblTongThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(96, 17);
            this.lblTongThu.TabIndex = 1;
            this.lblTongThu.Text = "Tổng tiền thu:";
            // 
            // lblNam
            // 
            this.lblNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNam.ForeColor = System.Drawing.Color.Teal;
            this.lblNam.Location = new System.Drawing.Point(229, 52);
            this.lblNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(41, 17);
            this.lblNam.TabIndex = 0;
            this.lblNam.Text = "Năm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.dgvDoanhThu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(2, 258);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(869, 258);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Doanh Thu Hàng Tháng Trong Năm";
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvDoanhThu.Location = new System.Drawing.Point(2, 17);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 62;
            this.dgvDoanhThu.Size = new System.Drawing.Size(384, 239);
            this.dgvDoanhThu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.78989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.33463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.7782101F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Teal;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 554);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(392, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(475, 239);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThongKe";
            this.Text = "Báo cáo Thống Kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaDT;
        private System.Windows.Forms.Button btnNhapDT;
        private System.Windows.Forms.Button btnBaoCaoDT;
        private System.Windows.Forms.TextBox txtTongThu;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}