
namespace DesignUI
{
    partial class fExport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTim = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.textBoxTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dGVPhieuXuat = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tbxSLTon = new System.Windows.Forms.TextBox();
            this.tbxMaNV = new System.Windows.Forms.TextBox();
            this.tbxMaCN = new System.Windows.Forms.TextBox();
            this.tbxTenLH = new System.Windows.Forms.TextBox();
            this.tbxLoaiHang = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.numSLXuat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxMaKe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxNhanVien = new System.Windows.Forms.ComboBox();
            this.cbxCN = new System.Windows.Forms.ComboBox();
            this.cbxTenHang = new System.Windows.Forms.ComboBox();
            this.cbxMaHang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhieuXuat)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPageList);
            this.tabControl1.Controls.Add(this.tabPageAdd);
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
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.panel1);
            this.tabPageList.Controls.Add(this.dGVPhieuXuat);
            this.tabPageList.Location = new System.Drawing.Point(4, 35);
            this.tabPageList.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageList.Size = new System.Drawing.Size(946, 455);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "Danh sách phiếu xuất";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbTim);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.textBoxTim);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 57);
            this.panel1.TabIndex = 1;
            // 
            // lbTim
            // 
            this.lbTim.AutoSize = true;
            this.lbTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.lbTim.Location = new System.Drawing.Point(14, 21);
            this.lbTim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTim.Name = "lbTim";
            this.lbTim.Size = new System.Drawing.Size(89, 28);
            this.lbTim.TabIndex = 3;
            this.lbTim.Text = "Từ khóa";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::DesignUI.Properties.Resources.remove;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(609, 13);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // textBoxTim
            // 
            this.textBoxTim.Location = new System.Drawing.Point(128, 21);
            this.textBoxTim.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTim.Name = "textBoxTim";
            this.textBoxTim.Size = new System.Drawing.Size(314, 30);
            this.textBoxTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Image = global::DesignUI.Properties.Resources.search2;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(489, 13);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnTim.Size = new System.Drawing.Size(100, 40);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dGVPhieuXuat
            // 
            this.dGVPhieuXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVPhieuXuat.BackgroundColor = System.Drawing.Color.White;
            this.dGVPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPhieuXuat.Location = new System.Drawing.Point(2, 118);
            this.dGVPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dGVPhieuXuat.Name = "dGVPhieuXuat";
            this.dGVPhieuXuat.ReadOnly = true;
            this.dGVPhieuXuat.RowHeadersWidth = 62;
            this.dGVPhieuXuat.RowTemplate.Height = 33;
            this.dGVPhieuXuat.Size = new System.Drawing.Size(942, 335);
            this.dGVPhieuXuat.TabIndex = 0;
            this.dGVPhieuXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPhieuXuat_CellContentClick);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.tbxSLTon);
            this.tabPageAdd.Controls.Add(this.tbxMaNV);
            this.tabPageAdd.Controls.Add(this.tbxMaCN);
            this.tabPageAdd.Controls.Add(this.tbxTenLH);
            this.tabPageAdd.Controls.Add(this.tbxLoaiHang);
            this.tabPageAdd.Controls.Add(this.btnXuat);
            this.tabPageAdd.Controls.Add(this.numSLXuat);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.textBox3);
            this.tabPageAdd.Controls.Add(this.label10);
            this.tabPageAdd.Controls.Add(this.label9);
            this.tabPageAdd.Controls.Add(this.cbxMaKe);
            this.tabPageAdd.Controls.Add(this.label8);
            this.tabPageAdd.Controls.Add(this.label7);
            this.tabPageAdd.Controls.Add(this.label6);
            this.tabPageAdd.Controls.Add(this.cbxNhanVien);
            this.tabPageAdd.Controls.Add(this.cbxCN);
            this.tabPageAdd.Controls.Add(this.cbxTenHang);
            this.tabPageAdd.Controls.Add(this.cbxMaHang);
            this.tabPageAdd.Controls.Add(this.label5);
            this.tabPageAdd.Controls.Add(this.label4);
            this.tabPageAdd.Controls.Add(this.label3);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 35);
            this.tabPageAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageAdd.Size = new System.Drawing.Size(946, 455);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Thêm mới";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // tbxSLTon
            // 
            this.tbxSLTon.Location = new System.Drawing.Point(509, 278);
            this.tbxSLTon.Name = "tbxSLTon";
            this.tbxSLTon.ReadOnly = true;
            this.tbxSLTon.Size = new System.Drawing.Size(57, 30);
            this.tbxSLTon.TabIndex = 38;
            this.tbxSLTon.TabStop = false;
            // 
            // tbxMaNV
            // 
            this.tbxMaNV.Location = new System.Drawing.Point(690, 212);
            this.tbxMaNV.Name = "tbxMaNV";
            this.tbxMaNV.ReadOnly = true;
            this.tbxMaNV.Size = new System.Drawing.Size(88, 30);
            this.tbxMaNV.TabIndex = 37;
            this.tbxMaNV.TabStop = false;
            // 
            // tbxMaCN
            // 
            this.tbxMaCN.Location = new System.Drawing.Point(690, 150);
            this.tbxMaCN.Name = "tbxMaCN";
            this.tbxMaCN.ReadOnly = true;
            this.tbxMaCN.Size = new System.Drawing.Size(88, 30);
            this.tbxMaCN.TabIndex = 36;
            this.tbxMaCN.TabStop = false;
            // 
            // tbxTenLH
            // 
            this.tbxTenLH.Location = new System.Drawing.Point(743, 36);
            this.tbxTenLH.Name = "tbxTenLH";
            this.tbxTenLH.ReadOnly = true;
            this.tbxTenLH.Size = new System.Drawing.Size(148, 30);
            this.tbxTenLH.TabIndex = 35;
            this.tbxTenLH.TabStop = false;
            // 
            // tbxLoaiHang
            // 
            this.tbxLoaiHang.Location = new System.Drawing.Point(690, 36);
            this.tbxLoaiHang.Name = "tbxLoaiHang";
            this.tbxLoaiHang.ReadOnly = true;
            this.tbxLoaiHang.Size = new System.Drawing.Size(51, 30);
            this.tbxLoaiHang.TabIndex = 34;
            this.tbxLoaiHang.TabStop = false;
            this.tbxLoaiHang.TextChanged += new System.EventHandler(this.tbxLoaiHang_TextChanged);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXuat.Enabled = false;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Image = global::DesignUI.Properties.Resources.tick;
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.Location = new System.Drawing.Point(780, 350);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnXuat.Size = new System.Drawing.Size(120, 50);
            this.btnXuat.TabIndex = 29;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.UseWaitCursor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // numSLXuat
            // 
            this.numSLXuat.BackColor = System.Drawing.Color.White;
            this.numSLXuat.Location = new System.Drawing.Point(687, 278);
            this.numSLXuat.Margin = new System.Windows.Forms.Padding(2);
            this.numSLXuat.Name = "numSLXuat";
            this.numSLXuat.Size = new System.Drawing.Size(54, 30);
            this.numSLXuat.TabIndex = 28;
            this.numSLXuat.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(598, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Loại";
            this.label2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(870, -51);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 30);
            this.textBox3.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label10.Location = new System.Drawing.Point(593, 280);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 28);
            this.label10.TabIndex = 25;
            this.label10.Text = "SL Xuất";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(356, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "SL tồn của SP";
            this.label9.UseWaitCursor = true;
            // 
            // cbxMaKe
            // 
            this.cbxMaKe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaKe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaKe.BackColor = System.Drawing.Color.White;
            this.cbxMaKe.DropDownHeight = 200;
            this.cbxMaKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaKe.FormattingEnabled = true;
            this.cbxMaKe.IntegralHeight = false;
            this.cbxMaKe.Location = new System.Drawing.Point(244, 277);
            this.cbxMaKe.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMaKe.Name = "cbxMaKe";
            this.cbxMaKe.Size = new System.Drawing.Size(90, 31);
            this.cbxMaKe.TabIndex = 21;
            this.cbxMaKe.UseWaitCursor = true;
            this.cbxMaKe.SelectedValueChanged += new System.EventHandler(this.cbxMaKe_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(32, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Kệ chứa";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(593, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã NV";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label6.Location = new System.Drawing.Point(594, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mã CN";
            this.label6.UseWaitCursor = true;
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxNhanVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNhanVien.BackColor = System.Drawing.Color.White;
            this.cbxNhanVien.DropDownHeight = 200;
            this.cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNhanVien.FormattingEnabled = true;
            this.cbxNhanVien.IntegralHeight = false;
            this.cbxNhanVien.Location = new System.Drawing.Point(244, 213);
            this.cbxNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Size = new System.Drawing.Size(285, 31);
            this.cbxNhanVien.TabIndex = 13;
            this.cbxNhanVien.UseWaitCursor = true;
            // 
            // cbxCN
            // 
            this.cbxCN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCN.BackColor = System.Drawing.Color.White;
            this.cbxCN.DropDownHeight = 200;
            this.cbxCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCN.FormattingEnabled = true;
            this.cbxCN.IntegralHeight = false;
            this.cbxCN.Location = new System.Drawing.Point(244, 148);
            this.cbxCN.Margin = new System.Windows.Forms.Padding(2);
            this.cbxCN.Name = "cbxCN";
            this.cbxCN.Size = new System.Drawing.Size(285, 31);
            this.cbxCN.TabIndex = 12;
            this.cbxCN.UseWaitCursor = true;
            // 
            // cbxTenHang
            // 
            this.cbxTenHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenHang.BackColor = System.Drawing.Color.White;
            this.cbxTenHang.DropDownHeight = 200;
            this.cbxTenHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenHang.FormattingEnabled = true;
            this.cbxTenHang.IntegralHeight = false;
            this.cbxTenHang.Location = new System.Drawing.Point(244, 83);
            this.cbxTenHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTenHang.Name = "cbxTenHang";
            this.cbxTenHang.Size = new System.Drawing.Size(285, 31);
            this.cbxTenHang.TabIndex = 11;
            this.cbxTenHang.UseWaitCursor = true;
            // 
            // cbxMaHang
            // 
            this.cbxMaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMaHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMaHang.BackColor = System.Drawing.Color.White;
            this.cbxMaHang.DropDownHeight = 200;
            this.cbxMaHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaHang.FormattingEnabled = true;
            this.cbxMaHang.IntegralHeight = false;
            this.cbxMaHang.Location = new System.Drawing.Point(244, 34);
            this.cbxMaHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMaHang.Name = "cbxMaHang";
            this.cbxMaHang.Size = new System.Drawing.Size(91, 31);
            this.cbxMaHang.TabIndex = 5;
            this.cbxMaHang.UseWaitCursor = true;
            this.cbxMaHang.SelectedValueChanged += new System.EventHandler(this.cbxMaHang_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(32, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhân viên phụ trách";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(32, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chi nhánh";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(32, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên ";
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            this.label1.UseWaitCursor = true;
            // 
            // fExport
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 494);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fExport";
            this.Text = "Xuất kho";
            this.tabControl1.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPhieuXuat)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSLXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textBoxTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dGVPhieuXuat;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.NumericUpDown numSLXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxMaKe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxNhanVien;
        private System.Windows.Forms.ComboBox cbxCN;
        private System.Windows.Forms.ComboBox cbxTenHang;
        private System.Windows.Forms.ComboBox cbxMaHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTenLH;
        private System.Windows.Forms.TextBox tbxLoaiHang;
        private System.Windows.Forms.TextBox tbxMaCN;
        private System.Windows.Forms.TextBox tbxSLTon;
        private System.Windows.Forms.TextBox tbxMaNV;
    }
}