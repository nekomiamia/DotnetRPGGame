using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotnetRPGGame
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      DataBaseConnection.MySql mySql = new DataBaseConnection.MySql();
      LoginForm loginForm = LoginForm.GetInstance();
      Application.Run(loginForm);
    }
  }
}
