using System;
using System.Windows.Forms;

namespace WindowsSignIn
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string userId = id.Text;
            string userPassword = password.Text;

            string signInResult = getSignInResult(userId, userPassword);

            MessageBox.Show(signInResult, "로그인");
        }

        private string getSignInResult(string id, string password)
        {
            if(!id.Equals("MyId")) {
                return "존재하지 않는 계정입니다.";
            }
            if(!password.Equals("MyPwd"))
            {
                return "잘못된 비밀번호입니다.";
            }
            return "로그인에 성공했습니다.";
        }
    }
}
