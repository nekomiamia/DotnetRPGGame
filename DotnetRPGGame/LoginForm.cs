using System;
using System.Windows.Forms;
using DotnetRPGGame.EventFolder;
using MySql = DotnetRPGGame.DataBaseConnection.MySql;

namespace DotnetRPGGame
{
    public partial class LoginForm : Form
    {
        private LoginForm()
        {
            InitializeComponent();
        }

        private static  LoginForm lgfrm;

        public static  LoginForm GetInstance()
        {
            if (lgfrm==null||lgfrm.IsDisposed)
            {
                lgfrm = new LoginForm();
            }

            return lgfrm;
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTbx.Text;
            string password = passwordTbx.Text;
            DataBaseConnection.MySql mySql = new DataBaseConnection.MySql();
            if (mySql.LoginSearchData(username,password))
            {
                Form1 form1 = new Form1();
                form1._sendMessge.OnSend(username);
                form1.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("账号或密码错误！请重试！");
                passwordTbx.Text = "";
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide(); 
        }
    }
}