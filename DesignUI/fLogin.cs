using DesignUI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignUI
{
    public partial class fLogin : Form
    {
        private int failCount = 0;
        private int waitTime;
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassword.Text;
            if (AccountDAO.Instance.Login(userName, passWord))
            {
                fWarehouses f = new fWarehouses();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                failCount++;
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (failCount > 0)
                    linkResetPassword.Visible = true;
                if (failCount == 3)
                {
                    btnLogin.Enabled = false;
                    lbcountTime.Visible = true;
                    waitTime = 180;
                    lbcountTime.Text = "*Thử lại sau " + waitTime + "s";
                    timer.Start();
                }
            }
            btnLogin.BackColor = Color.SkyBlue;
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked)
            {
                txbPassword.UseSystemPasswordChar = false;
            }
            else
                txbPassword.UseSystemPasswordChar = true;
        }

        private void linkResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fReset f = new fReset();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            waitTime--;
            if (waitTime == 0)
            {
                timer.Stop();
                btnLogin.Enabled = true;
                lbcountTime.Visible = false;
                failCount = 0;
            }

            lbcountTime.Text = "*Thử lại sau " + waitTime + "s";
        }

        private void txbUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
