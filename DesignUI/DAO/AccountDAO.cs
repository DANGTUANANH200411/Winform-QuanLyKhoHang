using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignUI.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance;}
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(tmp);
            string hasPassWord = "";
            foreach(byte item in hasData)
            {
                hasPassWord += item;
            }
            string query = "EXEC sp_LOGIN_ACCOUNT @TAIKHOAN , @MATKHAU";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPassWord});
            return result.Rows.Count > 0;
        }
        public bool FindAccountByUserName(string userName)
        {
            string query = "EXEC sp_TIM_ACCOUNT_TK @TAIKHOAN";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            return result.Rows.Count > 0;
        }

        public bool CheckPasswordLv2(string userName, string passWordLV2)
        {
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(passWordLV2);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(tmp);
            string hasPassWordLV2 = "";
            foreach (byte item in hasData)
            {
                hasPassWordLV2 += item;
            }
            string query = "EXEC sp_TIM_ACCOUNT_MKC2 @TAIKHOAN , @MATKHAUCAP2";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPassWordLV2 });
            return result.Rows.Count > 0;
        }

        public bool CheckNewPassword(string passWord) //Kiểm tra điều kiện chuỗi
        {
            bool specialChar = true;
            bool upperChar = false;
            bool lowerChar = false;
            bool digitChar = false;
            //Kiểm tra có chứa kí tự đặc biệt
            var regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(passWord))
                specialChar = false;
            //Kiểm tra chữ hoa, thường và số
            for (int i = 0; i <= passWord.Length - 1; i++)
            {
                if (Char.IsUpper(passWord[i]))
                    upperChar = true;
                if (Char.IsLower(passWord[i]))
                    lowerChar = true;
                if (Char.IsDigit(passWord[i]))
                    digitChar = true;
            }
            if (specialChar == true && upperChar == true && lowerChar == true && digitChar == true)
                return true;
            return false;
        }

        public bool ResetPassword(string userName, string passWord)
        {
            byte[] tmp = ASCIIEncoding.ASCII.GetBytes(passWord);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(tmp);
            string hasPassWord = "";
            foreach (byte item in hasData)
            {
                hasPassWord += item;
            }
            string query = "EXEC sp_UPDATE_ACCOUNT_PW @TAIKHOAN , @MATKHAU";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { userName, hasPassWord });
            return result > 0;
        }
    }
}
