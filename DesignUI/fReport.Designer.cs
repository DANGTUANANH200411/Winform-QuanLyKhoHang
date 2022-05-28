
namespace DesignUI
{
    partial class fReport
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
            this.btnExtract = new System.Windows.Forms.Button();
            this.btnDeleteReport = new System.Windows.Forms.Button();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExtract);
            this.panel1.Controls.Add(this.btnDeleteReport);
            this.panel1.Controls.Add(this.btnViewReport);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnAddReport);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 95);
            this.panel1.TabIndex = 0;
            // 
            // btnExtract
            // 
            this.btnExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnExtract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExtract.ForeColor = System.Drawing.Color.White;
            this.btnExtract.Image = global::DesignUI.Properties.Resources.tick;
            this.btnExtract.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExtract.Location = new System.Drawing.Point(148, 45);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExtract.Size = new System.Drawing.Size(91, 41);
            this.btnExtract.TabIndex = 3;
            this.btnExtract.Text = "Xuất file";
            this.btnExtract.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // btnDeleteReport
            // 
            this.btnDeleteReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnDeleteReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteReport.ForeColor = System.Drawing.Color.White;
            this.btnDeleteReport.Image = global::DesignUI.Properties.Resources.remove;
            this.btnDeleteReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteReport.Location = new System.Drawing.Point(270, 45);
            this.btnDeleteReport.Name = "btnDeleteReport";
            this.btnDeleteReport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnDeleteReport.Size = new System.Drawing.Size(94, 41);
            this.btnDeleteReport.TabIndex = 3;
            this.btnDeleteReport.Text = "Xóa";
            this.btnDeleteReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteReport.UseVisualStyleBackColor = false;
            this.btnDeleteReport.Click += new System.EventHandler(this.btnDeleteReport_Click);
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(197)))), ((int)(((byte)(241)))));
            this.btnViewReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewReport.ForeColor = System.Drawing.Color.White;
            this.btnViewReport.Image = global::DesignUI.Properties.Resources.search2;
            this.btnViewReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewReport.Location = new System.Drawing.Point(31, 45);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnViewReport.Size = new System.Drawing.Size(89, 41);
            this.btnViewReport.TabIndex = 2;
            this.btnViewReport.Text = "Xem";
            this.btnViewReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(119, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnAddReport
            // 
            this.btnAddReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddReport.ForeColor = System.Drawing.Color.White;
            this.btnAddReport.Image = global::DesignUI.Properties.Resources.report;
            this.btnAddReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddReport.Location = new System.Drawing.Point(31, 5);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAddReport.Size = new System.Drawing.Size(208, 38);
            this.btnAddReport.TabIndex = 0;
            this.btnAddReport.Text = "Báo Cáo Tháng";
            this.btnAddReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReport.UseVisualStyleBackColor = false;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtgvDetail);
            this.panel2.Location = new System.Drawing.Point(433, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 681);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(116, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chi tiết phiếu báo cáo";
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetail.Location = new System.Drawing.Point(0, 23);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.ReadOnly = true;
            this.dtgvDetail.RowHeadersWidth = 51;
            this.dtgvDetail.RowTemplate.Height = 29;
            this.dtgvDetail.Size = new System.Drawing.Size(966, 658);
            this.dtgvDetail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(97, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách phiếu báo cáo";
            // 
            // dtgvReport
            // 
            this.dtgvReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(0, 23);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.ReadOnly = true;
            this.dtgvReport.RowHeadersWidth = 51;
            this.dtgvReport.RowTemplate.Height = 29;
            this.dtgvReport.Size = new System.Drawing.Size(420, 566);
            this.dtgvReport.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.dtgvReport);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(2, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 589);
            this.panel3.TabIndex = 3;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fReport";
            this.Text = "Báo cáo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDeleteReport;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDetail;
        private System.Windows.Forms.DataGridView dtgvReport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExtract;
    }
}