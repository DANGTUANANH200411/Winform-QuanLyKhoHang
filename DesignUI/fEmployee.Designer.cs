
namespace DesignUI
{
    partial class fEmployee
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.tbxTim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGVNhanVien = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxChucVu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbxMaNV2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cbxGioiTinh2 = new System.Windows.Forms.ComboBox();
            this.tbxSDT2 = new System.Windows.Forms.TextBox();
            this.tbxDiaChi2 = new System.Windows.Forms.TextBox();
            this.tbxChucVu2 = new System.Windows.Forms.TextBox();
            this.tbxTenNV2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGVNhanVien2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhanVien)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhanVien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 494);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnXoa);
            this.tabPage1.Controls.Add(this.btnTim);
            this.tabPage1.Controls.Add(this.tbxTim);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbxTim);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(946, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tổng quan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::DesignUI.Properties.Resources.remove;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(611, 49);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Image = global::DesignUI.Properties.Resources.search2;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(495, 49);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTim.Size = new System.Drawing.Size(100, 40);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // tbxTim
            // 
            this.tbxTim.Location = new System.Drawing.Point(137, 57);
            this.tbxTim.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTim.Name = "tbxTim";
            this.tbxTim.Size = new System.Drawing.Size(322, 30);
            this.tbxTim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ khóa";
            // 
            // cbxTim
            // 
            this.cbxTim.FormattingEnabled = true;
            this.cbxTim.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên"});
            this.cbxTim.Location = new System.Drawing.Point(137, 15);
            this.cbxTim.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTim.Name = "cbxTim";
            this.cbxTim.Size = new System.Drawing.Size(322, 31);
            this.cbxTim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm theo";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dGVNhanVien);
            this.panel1.Location = new System.Drawing.Point(2, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 349);
            this.panel1.TabIndex = 0;
            // 
            // dGVNhanVien
            // 
            this.dGVNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dGVNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNhanVien.Location = new System.Drawing.Point(5, 9);
            this.dGVNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dGVNhanVien.Name = "dGVNhanVien";
            this.dGVNhanVien.ReadOnly = true;
            this.dGVNhanVien.RowHeadersWidth = 62;
            this.dGVNhanVien.RowTemplate.Height = 33;
            this.dGVNhanVien.Size = new System.Drawing.Size(932, 335);
            this.dGVNhanVien.TabIndex = 0;
            this.dGVNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNhanVien_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxMaNV);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnThemNV);
            this.tabPage2.Controls.Add(this.tbxSDT);
            this.tabPage2.Controls.Add(this.tbxDiaChi);
            this.tabPage2.Controls.Add(this.tbxChucVu);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbxGioiTinh);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbxTenNV);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(946, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.BackColor = System.Drawing.Color.White;
            this.tbxMaNV.Location = new System.Drawing.Point(272, 67);
            this.tbxMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaNV.MaxLength = 6;
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.Size = new System.Drawing.Size(290, 30);
            this.tbxMaNV.TabIndex = 12;
            this.tbxMaNV.TextChanged += new System.EventHandler(this.tbxMaNV_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label13.Location = new System.Drawing.Point(100, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 28);
            this.label13.TabIndex = 11;
            this.label13.Text = "Mã nhân viên";
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnThemNV.Enabled = false;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemNV.Image = global::DesignUI.Properties.Resources.tick;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNV.Location = new System.Drawing.Point(780, 350);
            this.btnThemNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThemNV.Size = new System.Drawing.Size(120, 50);
            this.btnThemNV.TabIndex = 10;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // tbxSDT
            // 
            this.tbxSDT.BackColor = System.Drawing.Color.White;
            this.tbxSDT.Location = new System.Drawing.Point(272, 320);
            this.tbxSDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSDT.MaxLength = 100;
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(435, 30);
            this.tbxSDT.TabIndex = 9;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.BackColor = System.Drawing.Color.White;
            this.tbxDiaChi.Location = new System.Drawing.Point(272, 266);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiaChi.MaxLength = 100;
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(435, 30);
            this.tbxDiaChi.TabIndex = 8;
            // 
            // tbxChucVu
            // 
            this.tbxChucVu.BackColor = System.Drawing.Color.White;
            this.tbxChucVu.Location = new System.Drawing.Point(272, 217);
            this.tbxChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.tbxChucVu.MaxLength = 50;
            this.tbxChucVu.Name = "tbxChucVu";
            this.tbxChucVu.Size = new System.Drawing.Size(435, 30);
            this.tbxChucVu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(100, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label6.Location = new System.Drawing.Point(100, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(100, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức vụ";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.BackColor = System.Drawing.Color.White;
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(272, 165);
            this.cbxGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(286, 31);
            this.cbxGioiTinh.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(100, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // tbxTenNV
            // 
            this.tbxTenNV.BackColor = System.Drawing.Color.White;
            this.tbxTenNV.Location = new System.Drawing.Point(272, 113);
            this.tbxTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTenNV.MaxLength = 50;
            this.tbxTenNV.Name = "tbxTenNV";
            this.tbxTenNV.Size = new System.Drawing.Size(431, 30);
            this.tbxTenNV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(100, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhân viên";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbxMaNV2);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.btnCapNhat);
            this.tabPage3.Controls.Add(this.cbxGioiTinh2);
            this.tabPage3.Controls.Add(this.tbxSDT2);
            this.tabPage3.Controls.Add(this.tbxDiaChi2);
            this.tabPage3.Controls.Add(this.tbxChucVu2);
            this.tabPage3.Controls.Add(this.tbxTenNV2);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(946, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cập nhật";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbxMaNV2
            // 
            this.tbxMaNV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMaNV2.BackColor = System.Drawing.Color.White;
            this.tbxMaNV2.Location = new System.Drawing.Point(664, 28);
            this.tbxMaNV2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaNV2.MaxLength = 6;
            this.tbxMaNV2.Name = "tbxMaNV2";
            this.tbxMaNV2.Size = new System.Drawing.Size(137, 30);
            this.tbxMaNV2.TabIndex = 13;
            this.tbxMaNV2.TextChanged += new System.EventHandler(this.tbxMaNV2_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label14.Location = new System.Drawing.Point(518, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 28);
            this.label14.TabIndex = 12;
            this.label14.Text = "Mã NV";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = global::DesignUI.Properties.Resources.tick;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.Location = new System.Drawing.Point(761, 350);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCapNhat.Size = new System.Drawing.Size(139, 50);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbxGioiTinh2
            // 
            this.cbxGioiTinh2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGioiTinh2.BackColor = System.Drawing.Color.White;
            this.cbxGioiTinh2.FormattingEnabled = true;
            this.cbxGioiTinh2.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh2.Location = new System.Drawing.Point(664, 126);
            this.cbxGioiTinh2.Margin = new System.Windows.Forms.Padding(2);
            this.cbxGioiTinh2.Name = "cbxGioiTinh2";
            this.cbxGioiTinh2.Size = new System.Drawing.Size(94, 31);
            this.cbxGioiTinh2.TabIndex = 10;
            // 
            // tbxSDT2
            // 
            this.tbxSDT2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSDT2.BackColor = System.Drawing.Color.White;
            this.tbxSDT2.Location = new System.Drawing.Point(664, 288);
            this.tbxSDT2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSDT2.MaxLength = 10;
            this.tbxSDT2.Name = "tbxSDT2";
            this.tbxSDT2.Size = new System.Drawing.Size(180, 30);
            this.tbxSDT2.TabIndex = 9;
            // 
            // tbxDiaChi2
            // 
            this.tbxDiaChi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDiaChi2.BackColor = System.Drawing.Color.White;
            this.tbxDiaChi2.Location = new System.Drawing.Point(664, 235);
            this.tbxDiaChi2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiaChi2.MaxLength = 100;
            this.tbxDiaChi2.Name = "tbxDiaChi2";
            this.tbxDiaChi2.Size = new System.Drawing.Size(261, 30);
            this.tbxDiaChi2.TabIndex = 8;
            // 
            // tbxChucVu2
            // 
            this.tbxChucVu2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxChucVu2.BackColor = System.Drawing.Color.White;
            this.tbxChucVu2.Location = new System.Drawing.Point(664, 174);
            this.tbxChucVu2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxChucVu2.MaxLength = 50;
            this.tbxChucVu2.Name = "tbxChucVu2";
            this.tbxChucVu2.Size = new System.Drawing.Size(261, 30);
            this.tbxChucVu2.TabIndex = 7;
            // 
            // tbxTenNV2
            // 
            this.tbxTenNV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTenNV2.BackColor = System.Drawing.Color.White;
            this.tbxTenNV2.Location = new System.Drawing.Point(664, 76);
            this.tbxTenNV2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTenNV2.MaxLength = 50;
            this.tbxTenNV2.Name = "tbxTenNV2";
            this.tbxTenNV2.Size = new System.Drawing.Size(261, 30);
            this.tbxTenNV2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label12.Location = new System.Drawing.Point(518, 290);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 28);
            this.label12.TabIndex = 5;
            this.label12.Text = "Số điện thoại";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label11.Location = new System.Drawing.Point(518, 235);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 28);
            this.label11.TabIndex = 4;
            this.label11.Text = "Địa chỉ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label10.Location = new System.Drawing.Point(518, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "Chức vụ";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(518, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Giới tính";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(518, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.dGVNhanVien2);
            this.panel2.Location = new System.Drawing.Point(7, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(483, 437);
            this.panel2.TabIndex = 0;
            // 
            // dGVNhanVien2
            // 
            this.dGVNhanVien2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVNhanVien2.BackgroundColor = System.Drawing.Color.White;
            this.dGVNhanVien2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNhanVien2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGVNhanVien2.Location = new System.Drawing.Point(0, 2);
            this.dGVNhanVien2.Margin = new System.Windows.Forms.Padding(2);
            this.dGVNhanVien2.Name = "dGVNhanVien2";
            this.dGVNhanVien2.ReadOnly = true;
            this.dGVNhanVien2.RowHeadersWidth = 62;
            this.dGVNhanVien2.RowTemplate.Height = 33;
            this.dGVNhanVien2.Size = new System.Drawing.Size(470, 430);
            this.dGVNhanVien2.TabIndex = 0;
            this.dGVNhanVien2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNhanVien2_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // fEmployee
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 494);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fEmployee";
            this.Text = "Nhân viên";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhanVien)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVNhanVien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox tbxTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGVNhanVien;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxMaNV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxGioiTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbxMaNV2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cbxGioiTinh2;
        private System.Windows.Forms.TextBox tbxSDT2;
        private System.Windows.Forms.TextBox tbxDiaChi2;
        private System.Windows.Forms.TextBox tbxChucVu2;
        private System.Windows.Forms.TextBox tbxTenNV2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGVNhanVien2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}