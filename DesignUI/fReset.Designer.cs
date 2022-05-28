
namespace DesignUI
{
    partial class fReset
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPasswordLv2 = new System.Windows.Forms.TextBox();
            this.txbNewPassword1 = new System.Windows.Forms.TextBox();
            this.txbNewPassword2 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbCheckUserName = new System.Windows.Forms.Label();
            this.lbCheckReEnter = new System.Windows.Forms.Label();
            this.lbCheckNewPassword = new System.Windows.Forms.Label();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản";
            // 
            // txbUserName
            // 
            this.txbUserName.BackColor = System.Drawing.Color.White;
            this.txbUserName.Location = new System.Drawing.Point(224, 11);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(243, 27);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu cấp 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(70, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // txbPasswordLv2
            // 
            this.txbPasswordLv2.BackColor = System.Drawing.Color.White;
            this.txbPasswordLv2.Location = new System.Drawing.Point(224, 61);
            this.txbPasswordLv2.Margin = new System.Windows.Forms.Padding(2);
            this.txbPasswordLv2.Name = "txbPasswordLv2";
            this.txbPasswordLv2.Size = new System.Drawing.Size(243, 27);
            this.txbPasswordLv2.TabIndex = 2;
            this.txbPasswordLv2.UseSystemPasswordChar = true;
            // 
            // txbNewPassword1
            // 
            this.txbNewPassword1.BackColor = System.Drawing.Color.White;
            this.txbNewPassword1.Location = new System.Drawing.Point(224, 112);
            this.txbNewPassword1.Margin = new System.Windows.Forms.Padding(2);
            this.txbNewPassword1.MaxLength = 12;
            this.txbNewPassword1.Name = "txbNewPassword1";
            this.txbNewPassword1.Size = new System.Drawing.Size(243, 27);
            this.txbNewPassword1.TabIndex = 3;
            this.txbNewPassword1.UseSystemPasswordChar = true;
            this.txbNewPassword1.TextChanged += new System.EventHandler(this.txbNewPassword1_TextChanged);
            // 
            // txbNewPassword2
            // 
            this.txbNewPassword2.BackColor = System.Drawing.Color.White;
            this.txbNewPassword2.Location = new System.Drawing.Point(224, 165);
            this.txbNewPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.txbNewPassword2.MaxLength = 12;
            this.txbNewPassword2.Name = "txbNewPassword2";
            this.txbNewPassword2.Size = new System.Drawing.Size(243, 27);
            this.txbNewPassword2.TabIndex = 4;
            this.txbNewPassword2.UseSystemPasswordChar = true;
            this.txbNewPassword2.TextChanged += new System.EventHandler(this.txbNewPassWord2_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(240, 218);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 34);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbCheckUserName
            // 
            this.lbCheckUserName.AutoSize = true;
            this.lbCheckUserName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCheckUserName.ForeColor = System.Drawing.Color.Red;
            this.lbCheckUserName.Location = new System.Drawing.Point(70, 40);
            this.lbCheckUserName.Name = "lbCheckUserName";
            this.lbCheckUserName.Size = new System.Drawing.Size(163, 19);
            this.lbCheckUserName.TabIndex = 9;
            this.lbCheckUserName.Text = "* Tài khoản không tồn tại";
            this.lbCheckUserName.Visible = false;
            // 
            // lbCheckReEnter
            // 
            this.lbCheckReEnter.AutoSize = true;
            this.lbCheckReEnter.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCheckReEnter.ForeColor = System.Drawing.Color.Red;
            this.lbCheckReEnter.Location = new System.Drawing.Point(70, 197);
            this.lbCheckReEnter.Name = "lbCheckReEnter";
            this.lbCheckReEnter.Size = new System.Drawing.Size(233, 19);
            this.lbCheckReEnter.TabIndex = 9;
            this.lbCheckReEnter.Text = "* Mật khẩu nhập lại không chính xác";
            this.lbCheckReEnter.Visible = false;
            // 
            // lbCheckNewPassword
            // 
            this.lbCheckNewPassword.AutoSize = true;
            this.lbCheckNewPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCheckNewPassword.ForeColor = System.Drawing.Color.Red;
            this.lbCheckNewPassword.Location = new System.Drawing.Point(70, 143);
            this.lbCheckNewPassword.Name = "lbCheckNewPassword";
            this.lbCheckNewPassword.Size = new System.Drawing.Size(219, 19);
            this.lbCheckNewPassword.TabIndex = 9;
            this.lbCheckNewPassword.Text = "* Mật khẩu phải từ 6 đến 12 ký tự";
            this.lbCheckNewPassword.Visible = false;
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbShowPassword.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbShowPassword.Location = new System.Drawing.Point(335, 197);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(116, 24);
            this.ckbShowPassword.TabIndex = 5;
            this.ckbShowPassword.Text = "Hiện mật khẩu";
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // fReset
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 263);
            this.Controls.Add(this.ckbShowPassword);
            this.Controls.Add(this.lbCheckReEnter);
            this.Controls.Add(this.lbCheckNewPassword);
            this.Controls.Add(this.lbCheckUserName);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txbNewPassword2);
            this.Controls.Add(this.txbNewPassword1);
            this.Controls.Add(this.txbPasswordLv2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khôi phục mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbPasswordLv2;
        private System.Windows.Forms.TextBox txbNewPassword1;
        private System.Windows.Forms.TextBox txbNewPassword2;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbCheckUserName;
        private System.Windows.Forms.Label lbCheckReEnter;
        private System.Windows.Forms.Label lbCheckNewPassword;
        private System.Windows.Forms.CheckBox ckbShowPassword;
    }
}