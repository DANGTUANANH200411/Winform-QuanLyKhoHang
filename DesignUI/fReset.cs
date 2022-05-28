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
    public partial class fReset : Form
    {
        public fReset()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)   //Kiểm tra tất cả điều kiện và cập nhật mật khẩu mới nếu thỏa đk
        {
            string userName = txbUserName.Text;
            string passwordLv2 = txbPasswordLv2.Text;
            string newPassWord1 = txbNewPassword1.Text;
            string newPassWord2 = txbNewPassword2.Text;

            if (AccountDAO.Instance.FindAccountByUserName(userName))    //Kiểm tra tài khoản
            {
                if (AccountDAO.Instance.CheckPasswordLv2(userName, passwordLv2))    //Kiểm tra mk cấp 2
                {
                    if (newPassWord1 == newPassWord2 && newPassWord1.Length >= 6 && newPassWord1.Length <= 12 && AccountDAO.Instance.CheckNewPassword(newPassWord1))    //Kiểm tra mk
                    {
                        if (AccountDAO.Instance.ResetPassword(userName, newPassWord1))  //Cập nhật mật khẩu
                        {
                            MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo");
                            this.Close();
                        }
                    }
                    else
                        MessageBox.Show("Có lỗi khi cập nhật mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Sai mật khẩu cấp 2", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)        //Hàm này hiện dòng báo lỗi khi tài khoản không đúng
        {
            if(!AccountDAO.Instance.FindAccountByUserName(txbUserName.Text))
            {
                lbCheckUserName.Visible = true;
            }
            else
                lbCheckUserName.Visible = false;
        }

        private void txbNewPassword1_TextChanged(object sender, EventArgs e)    //Hàm này hiện dòng báo lỗi khi không thỏa điều kiện mật khẩu
        {
            string passWord = txbNewPassword1.Text;
            if (txbNewPassword1.TextLength < 6 || txbNewPassword1.TextLength > 12)
            {
                lbCheckNewPassword.Text = "*Mật khẩu phải từ 6 đến 12 ký tự";
                lbCheckNewPassword.Visible = true;
            }
            else if (!AccountDAO.Instance.CheckNewPassword(passWord))
            {
                lbCheckNewPassword.Text = "* Mật khẩu phải chứa: chữ hoa, thường, số và ký tự đặc biệt";
                lbCheckNewPassword.Visible = true;
            }
            else
                lbCheckNewPassword.Visible = false;
        }

        private void txbNewPassWord2_TextChanged(object sender, EventArgs e)    //Hàm này hiện dòng báo lỗi khi nhập lại mk sai
        {
            if (txbNewPassword2.Text != txbNewPassword1.Text)
            {
                lbCheckReEnter.Visible = true;
            }
            else
                lbCheckReEnter.Visible = false;
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e) //Hàm này giúp hiện / ẩn mật khẩu
        {
            if (ckbShowPassword.Checked)
            {
                txbPasswordLv2.UseSystemPasswordChar = false;
                txbNewPassword1.UseSystemPasswordChar = false;
                txbNewPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                txbPasswordLv2.UseSystemPasswordChar = true;
                txbNewPassword1.UseSystemPasswordChar = true;
                txbNewPassword2.UseSystemPasswordChar = true;
            }
        }
    }
}
