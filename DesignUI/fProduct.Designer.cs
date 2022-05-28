 
namespace DesignUI
{
    partial class fProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txbSearchProduct = new System.Windows.Forms.TextBox();
            this.cbSearchProduct = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxShelvesID = new System.Windows.Forms.ComboBox();
            this.cbxProductKindID = new System.Windows.Forms.ComboBox();
            this.txbProductAmount = new System.Windows.Forms.TextBox();
            this.txbSupplierName = new System.Windows.Forms.TextBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.txbProductID = new System.Windows.Forms.TextBox();
            this.txbProductKindName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteProduct);
            this.panel1.Controls.Add(this.btnUpdateProduct);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.btnSearchProduct);
            this.panel1.Controls.Add(this.txbSearchProduct);
            this.panel1.Controls.Add(this.cbSearchProduct);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = global::DesignUI.Properties.Resources.remove;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(840, 8);
            this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDeleteProduct.Size = new System.Drawing.Size(103, 39);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Image = global::DesignUI.Properties.Resources.fix;
            this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProduct.Location = new System.Drawing.Point(731, 7);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnUpdateProduct.Size = new System.Drawing.Size(104, 40);
            this.btnUpdateProduct.TabIndex = 5;
            this.btnUpdateProduct.Text = "Sửa";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::DesignUI.Properties.Resources.add;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.Location = new System.Drawing.Point(622, 6);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAddProduct.Size = new System.Drawing.Size(105, 41);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Image = global::DesignUI.Properties.Resources.search2;
            this.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchProduct.Location = new System.Drawing.Point(24, 6);
            this.btnSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSearchProduct.Size = new System.Drawing.Size(84, 41);
            this.btnSearchProduct.TabIndex = 3;
            this.btnSearchProduct.Text = "Tìm";
            this.btnSearchProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txbSearchProduct
            // 
            this.txbSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchProduct.BackColor = System.Drawing.Color.White;
            this.txbSearchProduct.Location = new System.Drawing.Point(296, 12);
            this.txbSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txbSearchProduct.Name = "txbSearchProduct";
            this.txbSearchProduct.Size = new System.Drawing.Size(305, 27);
            this.txbSearchProduct.TabIndex = 2;
            // 
            // cbSearchProduct
            // 
            this.cbSearchProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSearchProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSearchProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearchProduct.BackColor = System.Drawing.Color.White;
            this.cbSearchProduct.FormattingEnabled = true;
            this.cbSearchProduct.Location = new System.Drawing.Point(128, 11);
            this.cbSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cbSearchProduct.Name = "cbSearchProduct";
            this.cbSearchProduct.Size = new System.Drawing.Size(155, 28);
            this.cbSearchProduct.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.cbxShelvesID);
            this.panel3.Controls.Add(this.cbxProductKindID);
            this.panel3.Controls.Add(this.txbProductAmount);
            this.panel3.Controls.Add(this.txbSupplierName);
            this.panel3.Controls.Add(this.txbProductName);
            this.panel3.Controls.Add(this.txbProductID);
            this.panel3.Controls.Add(this.txbProductKindName);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(619, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(335, 437);
            this.panel3.TabIndex = 2;
            // 
            // cbxShelvesID
            // 
            this.cbxShelvesID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxShelvesID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxShelvesID.BackColor = System.Drawing.SystemColors.Control;
            this.cbxShelvesID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxShelvesID.FormattingEnabled = true;
            this.cbxShelvesID.Items.AddRange(new object[] {
            "L01",
            "L02",
            "L03"});
            this.cbxShelvesID.Location = new System.Drawing.Point(169, 11);
            this.cbxShelvesID.Margin = new System.Windows.Forms.Padding(2);
            this.cbxShelvesID.Name = "cbxShelvesID";
            this.cbxShelvesID.Size = new System.Drawing.Size(145, 28);
            this.cbxShelvesID.TabIndex = 16;
            this.cbxShelvesID.SelectedValueChanged += new System.EventHandler(this.cbxShelvesID_SelectedValueChanged);
            this.cbxShelvesID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxShelvesID_KeyPress);
            // 
            // cbxProductKindID
            // 
            this.cbxProductKindID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxProductKindID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProductKindID.BackColor = System.Drawing.SystemColors.Control;
            this.cbxProductKindID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxProductKindID.FormattingEnabled = true;
            this.cbxProductKindID.Location = new System.Drawing.Point(169, 63);
            this.cbxProductKindID.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProductKindID.Name = "cbxProductKindID";
            this.cbxProductKindID.Size = new System.Drawing.Size(145, 28);
            this.cbxProductKindID.TabIndex = 16;
            this.cbxProductKindID.SelectedValueChanged += new System.EventHandler(this.cbxProductKindID_SelectedValueChanged);
            // 
            // txbProductAmount
            // 
            this.txbProductAmount.Location = new System.Drawing.Point(169, 336);
            this.txbProductAmount.Name = "txbProductAmount";
            this.txbProductAmount.ReadOnly = true;
            this.txbProductAmount.Size = new System.Drawing.Size(145, 27);
            this.txbProductAmount.TabIndex = 13;
            // 
            // txbSupplierName
            // 
            this.txbSupplierName.Location = new System.Drawing.Point(169, 282);
            this.txbSupplierName.MaxLength = 100;
            this.txbSupplierName.Name = "txbSupplierName";
            this.txbSupplierName.ReadOnly = true;
            this.txbSupplierName.Size = new System.Drawing.Size(145, 27);
            this.txbSupplierName.TabIndex = 12;
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(169, 230);
            this.txbProductName.MaxLength = 50;
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.ReadOnly = true;
            this.txbProductName.Size = new System.Drawing.Size(145, 27);
            this.txbProductName.TabIndex = 11;
            // 
            // txbProductID
            // 
            this.txbProductID.Location = new System.Drawing.Point(169, 174);
            this.txbProductID.MaxLength = 6;
            this.txbProductID.Name = "txbProductID";
            this.txbProductID.ReadOnly = true;
            this.txbProductID.Size = new System.Drawing.Size(145, 27);
            this.txbProductID.TabIndex = 9;
            // 
            // txbProductKindName
            // 
            this.txbProductKindName.Location = new System.Drawing.Point(169, 119);
            this.txbProductKindName.MaxLength = 30;
            this.txbProductKindName.Name = "txbProductKindName";
            this.txbProductKindName.ReadOnly = true;
            this.txbProductKindName.Size = new System.Drawing.Size(145, 27);
            this.txbProductKindName.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Image = global::DesignUI.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(61, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSave.Size = new System.Drawing.Size(102, 48);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Image = global::DesignUI.Properties.Resources.remove;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(212, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancel.Size = new System.Drawing.Size(102, 48);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(16, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label5.Location = new System.Drawing.Point(16, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label4.Location = new System.Drawing.Point(16, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên hàng:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(16, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hàng:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã kệ hàng:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label9.Location = new System.Drawing.Point(16, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên loại hàng:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại hàng:";
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.Location = new System.Drawing.Point(0, 52);
            this.dtgvProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.ReadOnly = true;
            this.dtgvProduct.RowHeadersWidth = 62;
            this.dtgvProduct.RowTemplate.Height = 33;
            this.dtgvProduct.Size = new System.Drawing.Size(618, 437);
            this.dtgvProduct.TabIndex = 0;
            this.dtgvProduct.TabStop = false;
            // 
            // fProduct
            // 
            this.AcceptButton = this.btnSearchProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 494);
            this.Controls.Add(this.dtgvProduct);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txbSearchProduct;
        private System.Windows.Forms.ComboBox cbSearchProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbProductKindName;
        private System.Windows.Forms.TextBox txbProductAmount;
        private System.Windows.Forms.TextBox txbSupplierName;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.ComboBox cbxProductKindID;
        private System.Windows.Forms.ComboBox cbxShelvesID;
        private System.Windows.Forms.TextBox txbProductID;
    }
}