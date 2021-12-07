using System;
using System.Windows.Forms;
using RPGGameBLL;
using RPGGameModel.DataBase;


namespace DotnetRPGGame
{
    public partial class RegisterForm : Form
    {
        private user m_user = new user();
        private UserAccess b_userAccess = new UserAccess();
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = LoginForm.GetInstance();
            loginForm.Show();
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            string username = usernameTbx.Text;
            string password = passwordTbx.Text;
            m_user.Username = username;
            m_user.Password = password;
            
            if (b_userAccess.UserRegister(m_user))
            {
                MessageBox.Show("注册成功!");
                Form1 form1 = new Form1();
                form1._sendMessge.OnSend(username);
                form1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名重复，请重新输入!");
                usernameTbx.Text = "";
                passwordTbx.Text = "";
            }
        }
    }
}