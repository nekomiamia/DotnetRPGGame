using System;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using RPGGameModel.DataBase;

namespace RPGGameDAL
{
    public class DBbase
    {
        
        //实例化连接对象 con
        public MySqlConnection con;

        public DBbase()
        {
            
            try
            {
                //与数据库连接的信息
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                //用户名
                builder.UserID = "root";
                //密码
                builder.Password = "506506";
                //服务器地址
                builder.Server = "localhost";
                //连接时的数据库
                builder.Database = "dotnetrpggame";
                //定义与数据连接的链接
                con = new MySqlConnection(builder.ConnectionString);
                //打开这个链接
                con.Open();
                Debug.WriteLine("连接成功！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        
        
        //检测连接是否打开
        public void chkConnection()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        //执行语句，返回该语句查询的数据行的总数
        public int returnRowCount(string strSQL)
        {
            chkConnection();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
        }

        public gamedata ReturnUserdata(string strSQL)
        {
            chkConnection();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gamedata _gamedata = new gamedata();
                _gamedata.Username = (string) ds.Tables[0].Rows[0]["username"];
                _gamedata.Data = (byte[]) ds.Tables[0].Rows[0]["data"];
                
                return _gamedata;
            }
            catch
            {
                return null;
            }
        }
        
        
        public bool InsertRowString(string strSQL)
        {
            chkConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(strSQL,con);
                //执行SQL
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public bool InsertRowCommand(MySqlCommand sqlCommand)
        {
            chkConnection();
            try
            {
                //执行SQL
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                throw e;
                return false;
            }
        }
        
        public bool UpdateRowCommand(MySqlCommand sqlCommand)
        {
            chkConnection();
            try
            {
                //执行SQL
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}