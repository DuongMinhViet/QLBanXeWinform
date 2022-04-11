
namespace QLXEMAY.Forms
{
    partial class frmQuanLiHDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiHDN));
            this.lblDSHDN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSHDN = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.lblNVNhap = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbNCC = new System.Windows.Forms.RadioButton();
            this.rbNVNhap = new System.Windows.Forms.RadioButton();
            this.rbMaHD = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDN)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDSHDN
            // 
            this.lblDSHDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDSHDN.AutoSize = true;
            this.lblDSHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHDN.ForeColor = System.Drawing.Color.Snow;
            this.lblDSHDN.Location = new System.Drawing.Point(202, 15);
            this.lblDSHDN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSHDN.Name = "lblDSHDN";
            this.lblDSHDN.Size = new System.Drawing.Size(596, 37);
            this.lblDSHDN.TabIndex = 0;
            this.lblDSHDN.Text = "DANH SÁCH HÓA ĐƠN NHẬP HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDSHDN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 65);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.dgvDSHDN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(2, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(909, 245);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvDSHDN
            // 
            this.dgvDSHDN.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDSHDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHDN.Location = new System.Drawing.Point(2, 21);
            this.dgvDSHDN.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSHDN.Name = "dgvDSHDN";
            this.dgvDSHDN.RowHeadersWidth = 51;
            this.dgvDSHDN.RowTemplate.Height = 24;
            this.dgvDSHDN.Size = new System.Drawing.Size(905, 222);
            this.dgvDSHDN.TabIndex = 7;
            this.dgvDSHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHDN_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.txtNCC);
            this.groupBox3.Controls.Add(this.txtNV);
            this.groupBox3.Controls.Add(this.dtNgayNhap);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.txtMaHD);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnIn);
            this.groupBox3.Controls.Add(this.lblNVNhap);
            this.groupBox3.Controls.Add(this.lblTongTien);
            this.groupBox3.Controls.Add(this.lblNCC);
            this.groupBox3.Controls.Add(this.lblNgayNhap);
            this.groupBox3.Controls.Add(this.lblMaHD);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(2, 306);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(909, 246);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(647, 187);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 46);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtNCC
            // 
            this.txtNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCC.Location = new System.Drawing.Point(112, 158);
            this.txtNCC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(150, 26);
            this.txtNCC.TabIndex = 20;
            // 
            // txtNV
            // 
            this.txtNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNV.Location = new System.Drawing.Point(424, 70);
            this.txtNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(150, 26);
            this.txtNV.TabIndex = 19;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhap.Location = new System.Drawing.Point(112, 117);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(150, 26);
            this.dtNgayNhap.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(424, 117);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 26);
            this.txtTongTien.TabIndex = 13;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(112, 73);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(150, 26);
            this.txtMaHD.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(824, 50);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 46);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(647, 50);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 46);
            this.btnSua.TabIndex = 15;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(647, 117);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 46);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(824, 117);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(133, 46);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // lblNVNhap
            // 
            this.lblNVNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNVNhap.AutoSize = true;
            this.lblNVNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVNhap.Location = new System.Drawing.Point(290, 76);
            this.lblNVNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNVNhap.Name = "lblNVNhap";
            this.lblNVNhap.Size = new System.Drawing.Size(123, 20);
            this.lblNVNhap.TabIndex = 4;
            this.lblNVNhap.Text = "Nhân viên nhập:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(290, 121);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(79, 20);
            this.lblTongTien.TabIndex = 3;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblNCC
            // 
            this.lblNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNCC.AutoSize = true;
            this.lblNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.Location = new System.Drawing.Point(-6, 164);
            this.lblNCC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(111, 20);
            this.lblNCC.TabIndex = 2;
            this.lblNCC.Text = "Nhà cung cấp:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(-6, 121);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(89, 20);
            this.lblNgayNhap.TabIndex = 1;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.Location = new System.Drawing.Point(-6, 77);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(97, 20);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 554);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.rbNCC);
            this.groupBox1.Controls.Add(this.rbNVNhap);
            this.groupBox1.Controls.Add(this.rbMaHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(909, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(684, 2);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(133, 45);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(424, 18);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(240, 26);
            this.txtTimKiem.TabIndex = 5;
            // 
            // rbNCC
            // 
            this.rbNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbNCC.AutoSize = true;
            this.rbNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNCC.Location = new System.Drawing.Point(283, 24);
            this.rbNCC.Margin = new System.Windows.Forms.Padding(2);
            this.rbNCC.Name = "rbNCC";
            this.rbNCC.Size = new System.Drawing.Size(125, 24);
            this.rbNCC.TabIndex = 4;
            this.rbNCC.TabStop = true;
            this.rbNCC.Text = "Nhà cung cấp";
            this.rbNCC.UseVisualStyleBackColor = true;
            this.rbNCC.CheckedChanged += new System.EventHandler(this.rbNCC_CheckedChanged);
            // 
            // rbNVNhap
            // 
            this.rbNVNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbNVNhap.AutoSize = true;
            this.rbNVNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNVNhap.Location = new System.Drawing.Point(147, 24);
            this.rbNVNhap.Margin = new System.Windows.Forms.Padding(2);
            this.rbNVNhap.Name = "rbNVNhap";
            this.rbNVNhap.Size = new System.Drawing.Size(137, 24);
            this.rbNVNhap.TabIndex = 3;
            this.rbNVNhap.TabStop = true;
            this.rbNVNhap.Text = "Nhân viên nhập";
            this.rbNVNhap.UseVisualStyleBackColor = true;
            this.rbNVNhap.CheckedChanged += new System.EventHandler(this.rbNVNhap_CheckedChanged);
            // 
            // rbMaHD
            // 
            this.rbMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMaHD.AutoSize = true;
            this.rbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaHD.Location = new System.Drawing.Point(20, 23);
            this.rbMaHD.Margin = new System.Windows.Forms.Padding(2);
            this.rbMaHD.Name = "rbMaHD";
            this.rbMaHD.Size = new System.Drawing.Size(111, 24);
            this.rbMaHD.TabIndex = 2;
            this.rbMaHD.TabStop = true;
            this.rbMaHD.Text = "Mã hóa đơn";
            this.rbMaHD.UseVisualStyleBackColor = true;
            this.rbMaHD.CheckedChanged += new System.EventHandler(this.rbMaHD_CheckedChanged);
            // 
            // frmQuanLiHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(913, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLiHDN";
            this.Text = "Quản lí Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.frmQuanLiHDN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDN)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDSHDN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSHDN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblNVNhap;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rbNCC;
        private System.Windows.Forms.RadioButton rbNVNhap;
        private System.Windows.Forms.RadioButton rbMaHD;
    }
}