
namespace QLXEMAY.Forms
{
    partial class frmQuanLiHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiHDB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDSHDB = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.lblNVBan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSHDB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rbKH = new System.Windows.Forms.RadioButton();
            this.rbNVBan = new System.Windows.Forms.RadioButton();
            this.rbMaHD = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDSHDB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 65);
            this.panel1.TabIndex = 0;
            // 
            // lblDSHDB
            // 
            this.lblDSHDB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDSHDB.AutoSize = true;
            this.lblDSHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSHDB.ForeColor = System.Drawing.Color.Snow;
            this.lblDSHDB.Location = new System.Drawing.Point(202, 15);
            this.lblDSHDB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSHDB.Name = "lblDSHDB";
            this.lblDSHDB.Size = new System.Drawing.Size(572, 37);
            this.lblDSHDB.TabIndex = 0;
            this.lblDSHDB.Text = "DANH SÁCH HÓA ĐƠN BÁN HÀNG";
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 598);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.txtKH);
            this.groupBox3.Controls.Add(this.txtNV);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.dtNgayBan);
            this.groupBox3.Controls.Add(this.txtTongTien);
            this.groupBox3.Controls.Add(this.txtMaHD);
            this.groupBox3.Controls.Add(this.btnLuu);
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnIn);
            this.groupBox3.Controls.Add(this.lblNVBan);
            this.groupBox3.Controls.Add(this.lblTongTien);
            this.groupBox3.Controls.Add(this.lblKH);
            this.groupBox3.Controls.Add(this.lblNgayBan);
            this.groupBox3.Controls.Add(this.lblMaHD);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Teal;
            this.groupBox3.Location = new System.Drawing.Point(2, 330);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(909, 266);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // txtKH
            // 
            this.txtKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.Location = new System.Drawing.Point(112, 161);
            this.txtKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(150, 26);
            this.txtKH.TabIndex = 21;
            // 
            // txtNV
            // 
            this.txtNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNV.Location = new System.Drawing.Point(424, 70);
            this.txtNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(150, 26);
            this.txtNV.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(656, 176);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 46);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBan.Location = new System.Drawing.Point(112, 117);
            this.dtNgayBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(150, 26);
            this.dtNgayBan.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(424, 117);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 26);
            this.txtTongTien.TabIndex = 13;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(112, 73);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(150, 26);
            this.txtMaHD.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(811, 50);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnSua.Location = new System.Drawing.Point(656, 50);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnXoa.Location = new System.Drawing.Point(656, 117);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnIn.Location = new System.Drawing.Point(811, 117);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(133, 46);
            this.btnIn.TabIndex = 17;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // lblNVBan
            // 
            this.lblNVBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNVBan.AutoSize = true;
            this.lblNVBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVBan.Location = new System.Drawing.Point(290, 76);
            this.lblNVBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNVBan.Name = "lblNVBan";
            this.lblNVBan.Size = new System.Drawing.Size(114, 20);
            this.lblNVBan.TabIndex = 4;
            this.lblNVBan.Text = "Nhân viên bán:";
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
            // lblKH
            // 
            this.lblKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(-6, 164);
            this.lblKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(98, 20);
            this.lblKH.TabIndex = 2;
            this.lblKH.Text = "Khách hàng:";
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayBan.AutoSize = true;
            this.lblNgayBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayBan.Location = new System.Drawing.Point(-6, 121);
            this.lblNgayBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(80, 20);
            this.lblNgayBan.TabIndex = 1;
            this.lblNgayBan.Text = "Ngày bán:";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.dgvDSHDB);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(2, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(909, 265);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvDSHDB
            // 
            this.dgvDSHDB.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDSHDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHDB.Location = new System.Drawing.Point(2, 21);
            this.dgvDSHDB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSHDB.Name = "dgvDSHDB";
            this.dgvDSHDB.RowHeadersWidth = 51;
            this.dgvDSHDB.RowTemplate.Height = 24;
            this.dgvDSHDB.Size = new System.Drawing.Size(905, 242);
            this.dgvDSHDB.TabIndex = 7;
            this.dgvDSHDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHDB_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.rbKH);
            this.groupBox1.Controls.Add(this.rbNVBan);
            this.groupBox1.Controls.Add(this.rbMaHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(909, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(687, 14);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(135, 34);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(424, 18);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(240, 26);
            this.txtTimKiem.TabIndex = 5;
            // 
            // rbKH
            // 
            this.rbKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbKH.AutoSize = true;
            this.rbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKH.Location = new System.Drawing.Point(283, 24);
            this.rbKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbKH.Name = "rbKH";
            this.rbKH.Size = new System.Drawing.Size(112, 24);
            this.rbKH.TabIndex = 4;
            this.rbKH.TabStop = true;
            this.rbKH.Text = "Khách hàng";
            this.rbKH.UseVisualStyleBackColor = true;
            this.rbKH.CheckedChanged += new System.EventHandler(this.rbKH_CheckedChanged);
            // 
            // rbNVBan
            // 
            this.rbNVBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbNVBan.AutoSize = true;
            this.rbNVBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNVBan.Location = new System.Drawing.Point(147, 24);
            this.rbNVBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNVBan.Name = "rbNVBan";
            this.rbNVBan.Size = new System.Drawing.Size(128, 24);
            this.rbNVBan.TabIndex = 3;
            this.rbNVBan.TabStop = true;
            this.rbNVBan.Text = "Nhân viên bán";
            this.rbNVBan.UseVisualStyleBackColor = true;
            this.rbNVBan.CheckedChanged += new System.EventHandler(this.rbNVBan_CheckedChanged);
            // 
            // rbMaHD
            // 
            this.rbMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMaHD.AutoSize = true;
            this.rbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMaHD.Location = new System.Drawing.Point(20, 23);
            this.rbMaHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMaHD.Name = "rbMaHD";
            this.rbMaHD.Size = new System.Drawing.Size(111, 24);
            this.rbMaHD.TabIndex = 2;
            this.rbMaHD.TabStop = true;
            this.rbMaHD.Text = "Mã hóa đơn";
            this.rbMaHD.UseVisualStyleBackColor = true;
            this.rbMaHD.CheckedChanged += new System.EventHandler(this.rbMaHD_CheckedChanged);
            // 
            // frmQuanLiHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(913, 663);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLiHDB";
            this.Text = "Quản lí Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.frmQuanLiHDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDSHDB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label lblNVBan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DataGridView dgvDSHDB;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rbKH;
        private System.Windows.Forms.RadioButton rbNVBan;
        private System.Windows.Forms.RadioButton rbMaHD;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.TextBox txtNV;
    }
}