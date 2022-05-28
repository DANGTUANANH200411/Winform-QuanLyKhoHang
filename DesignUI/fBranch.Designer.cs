
namespace DesignUI
{
    partial class fBranch
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
            this.dGVChiNhanh = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThemCN = new System.Windows.Forms.Button();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxMaCN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTenCN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.tbxSDT2 = new System.Windows.Forms.TextBox();
            this.tbxDiaChi2 = new System.Windows.Forms.TextBox();
            this.tbxMaCN2 = new System.Windows.Forms.TextBox();
            this.tbxTenCN2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGVChiNhanh2 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiNhanh)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiNhanh2)).BeginInit();
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
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 494);
            this.tabControl1.TabIndex = 3;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(946, 458);
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
            this.btnXoa.Location = new System.Drawing.Point(606, 52);
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
            this.btnTim.Location = new System.Drawing.Point(497, 53);
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
            this.tbxTim.BackColor = System.Drawing.Color.White;
            this.tbxTim.Location = new System.Drawing.Point(123, 60);
            this.tbxTim.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTim.Name = "tbxTim";
            this.tbxTim.Size = new System.Drawing.Size(334, 27);
            this.tbxTim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(22, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ khóa";
            // 
            // cbxTim
            // 
            this.cbxTim.BackColor = System.Drawing.Color.White;
            this.cbxTim.FormattingEnabled = true;
            this.cbxTim.Items.AddRange(new object[] {
            "Mã chi nhánh",
            "Tên chi nhánh"});
            this.cbxTim.Location = new System.Drawing.Point(123, 17);
            this.cbxTim.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTim.Name = "cbxTim";
            this.cbxTim.Size = new System.Drawing.Size(334, 28);
            this.cbxTim.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(22, 17);
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
            this.panel1.Controls.Add(this.dGVChiNhanh);
            this.panel1.Location = new System.Drawing.Point(2, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 349);
            this.panel1.TabIndex = 0;
            // 
            // dGVChiNhanh
            // 
            this.dGVChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVChiNhanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVChiNhanh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVChiNhanh.BackgroundColor = System.Drawing.Color.White;
            this.dGVChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChiNhanh.Location = new System.Drawing.Point(5, 9);
            this.dGVChiNhanh.Margin = new System.Windows.Forms.Padding(2);
            this.dGVChiNhanh.Name = "dGVChiNhanh";
            this.dGVChiNhanh.ReadOnly = true;
            this.dGVChiNhanh.RowHeadersWidth = 62;
            this.dGVChiNhanh.RowTemplate.Height = 33;
            this.dGVChiNhanh.Size = new System.Drawing.Size(932, 335);
            this.dGVChiNhanh.TabIndex = 0;
            this.dGVChiNhanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVChiNhanh_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThemCN);
            this.tabPage2.Controls.Add(this.tbxSDT);
            this.tabPage2.Controls.Add(this.tbxDiaChi);
            this.tabPage2.Controls.Add(this.tbxMaCN);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbxTenCN);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(946, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThemCN
            // 
            this.btnThemCN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThemCN.Enabled = false;
            this.btnThemCN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThemCN.ForeColor = System.Drawing.Color.White;
            this.btnThemCN.Image = global::DesignUI.Properties.Resources.tick;
            this.btnThemCN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCN.Location = new System.Drawing.Point(780, 350);
            this.btnThemCN.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemCN.Name = "btnThemCN";
            this.btnThemCN.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnThemCN.Size = new System.Drawing.Size(120, 50);
            this.btnThemCN.TabIndex = 10;
            this.btnThemCN.Text = "Thêm";
            this.btnThemCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCN.UseVisualStyleBackColor = false;
            this.btnThemCN.Click += new System.EventHandler(this.btnThemCN_Click);
            // 
            // tbxSDT
            // 
            this.tbxSDT.BackColor = System.Drawing.Color.White;
            this.tbxSDT.Location = new System.Drawing.Point(240, 215);
            this.tbxSDT.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSDT.MaxLength = 10;
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(399, 27);
            this.tbxSDT.TabIndex = 9;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.BackColor = System.Drawing.Color.White;
            this.tbxDiaChi.Location = new System.Drawing.Point(240, 293);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiaChi.MaxLength = 100;
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(399, 27);
            this.tbxDiaChi.TabIndex = 8;
            // 
            // tbxMaCN
            // 
            this.tbxMaCN.BackColor = System.Drawing.Color.White;
            this.tbxMaCN.Location = new System.Drawing.Point(240, 66);
            this.tbxMaCN.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaCN.MaxLength = 5;
            this.tbxMaCN.Name = "tbxMaCN";
            this.tbxMaCN.Size = new System.Drawing.Size(177, 27);
            this.tbxMaCN.TabIndex = 7;
            this.tbxMaCN.TextChanged += new System.EventHandler(this.tbxMaCN_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(93, 211);
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
            this.label6.Location = new System.Drawing.Point(93, 289);
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
            this.label5.Location = new System.Drawing.Point(93, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã chi nhánh";
            // 
            // tbxTenCN
            // 
            this.tbxTenCN.BackColor = System.Drawing.Color.White;
            this.tbxTenCN.Location = new System.Drawing.Point(240, 138);
            this.tbxTenCN.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTenCN.MaxLength = 100;
            this.tbxTenCN.Name = "tbxTenCN";
            this.tbxTenCN.Size = new System.Drawing.Size(399, 27);
            this.tbxTenCN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(91, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên chi nhánh";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCapNhat);
            this.tabPage3.Controls.Add(this.tbxSDT2);
            this.tabPage3.Controls.Add(this.tbxDiaChi2);
            this.tabPage3.Controls.Add(this.tbxMaCN2);
            this.tabPage3.Controls.Add(this.tbxTenCN2);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(946, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cập nhật";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhat.Enabled = false;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = global::DesignUI.Properties.Resources.tick;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.Location = new System.Drawing.Point(757, 350);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCapNhat.Size = new System.Drawing.Size(146, 50);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // tbxSDT2
            // 
            this.tbxSDT2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSDT2.Location = new System.Drawing.Point(658, 196);
            this.tbxSDT2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSDT2.MaxLength = 10;
            this.tbxSDT2.Name = "tbxSDT2";
            this.tbxSDT2.Size = new System.Drawing.Size(245, 27);
            this.tbxSDT2.TabIndex = 9;
            // 
            // tbxDiaChi2
            // 
            this.tbxDiaChi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDiaChi2.Location = new System.Drawing.Point(658, 269);
            this.tbxDiaChi2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiaChi2.MaxLength = 100;
            this.tbxDiaChi2.Name = "tbxDiaChi2";
            this.tbxDiaChi2.Size = new System.Drawing.Size(245, 27);
            this.tbxDiaChi2.TabIndex = 8;
            // 
            // tbxMaCN2
            // 
            this.tbxMaCN2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMaCN2.Location = new System.Drawing.Point(658, 39);
            this.tbxMaCN2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMaCN2.MaxLength = 5;
            this.tbxMaCN2.Name = "tbxMaCN2";
            this.tbxMaCN2.Size = new System.Drawing.Size(134, 27);
            this.tbxMaCN2.TabIndex = 7;
            this.tbxMaCN2.TextChanged += new System.EventHandler(this.tbxMaCN2_TextChanged);
            // 
            // tbxTenCN2
            // 
            this.tbxTenCN2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTenCN2.Location = new System.Drawing.Point(658, 116);
            this.tbxTenCN2.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTenCN2.MaxLength = 100;
            this.tbxTenCN2.Name = "tbxTenCN2";
            this.tbxTenCN2.Size = new System.Drawing.Size(245, 27);
            this.tbxTenCN2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label12.Location = new System.Drawing.Point(499, 194);
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
            this.label11.Location = new System.Drawing.Point(499, 269);
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
            this.label10.Location = new System.Drawing.Point(498, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mã chi nhánh";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label8.Location = new System.Drawing.Point(498, 116);
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
            this.panel2.Controls.Add(this.dGVChiNhanh2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 458);
            this.panel2.TabIndex = 0;
            // 
            // dGVChiNhanh2
            // 
            this.dGVChiNhanh2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVChiNhanh2.BackgroundColor = System.Drawing.Color.White;
            this.dGVChiNhanh2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChiNhanh2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGVChiNhanh2.Location = new System.Drawing.Point(0, 0);
            this.dGVChiNhanh2.Margin = new System.Windows.Forms.Padding(2);
            this.dGVChiNhanh2.Name = "dGVChiNhanh2";
            this.dGVChiNhanh2.RowHeadersWidth = 62;
            this.dGVChiNhanh2.RowTemplate.Height = 33;
            this.dGVChiNhanh2.Size = new System.Drawing.Size(478, 458);
            this.dGVChiNhanh2.TabIndex = 0;
            this.dGVChiNhanh2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVChiNhanh2_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // fBranch
            // 
            this.AcceptButton = this.btnTim;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 494);
            this.Controls.Add(this.tabControl1);
            this.Name = "fBranch";
            this.Text = "Chi nhánh";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiNhanh)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVChiNhanh2)).EndInit();
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
        private System.Windows.Forms.DataGridView dGVChiNhanh;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnThemCN;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxMaCN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTenCN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox tbxSDT2;
        private System.Windows.Forms.TextBox tbxDiaChi2;
        private System.Windows.Forms.TextBox tbxMaCN2;
        private System.Windows.Forms.TextBox tbxTenCN2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGVChiNhanh2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}