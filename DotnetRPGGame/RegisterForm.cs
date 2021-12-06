using System;
using System.Windows.Forms;
using MySql = DotnetRPGGame.DataBaseConnection.MySql;

namespace DotnetRPGGame
{
    public partial class RegisterForm : Form
    {
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
            DataBaseConnection.MySql mySql = new DataBaseConnection.MySql();
            string username = usernameTbx.Text;
            string password = passwordTbx.Text;
            if (mySql.InsertData(username,password))
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