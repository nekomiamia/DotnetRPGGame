using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using DotnetRPGGame.SaveFloder;
using MySql.Data.MySqlClient;

namespace DotnetRPGGame.DataBaseConnection
{
    public class MySql
    {
        private MySqlConnection connection;
        
        private void ConnectionMySql()
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
                connection = new MySqlConnection(builder.ConnectionString);
                //打开这个链接
                connection.Open();
                Debug.WriteLine("连接成功！");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        
        public bool InsertData(string username,string password)
        {
            ConnectionMySql();
            string sql = "insert into user(username,password) values('"+ username +"','"+ password +"')";
            Debug.WriteLine(sql);
            //string sql = "delete from user where userid='9'";
            //string sql = "update user set username='啊哈',password='123' where userid='8'";
            if (!RegisterSearchData(username))
            {
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                int result = cmd.ExecuteNonQuery();
                Debug.WriteLine("影响数据行数：" + result);
                return true;
            }
            CloseConnection();
            return false;
        }
        
        public bool RegisterSearchData(string username)
        {
            ConnectionMySql();
            string sql = "select 1 from user where username = '" + username + "' limit 1;";
            MySqlCommand cmd = new MySqlCommand(sql,connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool returnFlag = false;
            returnFlag = reader.Read();
            reader.Close();
            CloseConnection();
            return returnFlag;
        }
        
        
        public bool LoginSearchData(string username, string password)
        {
            ConnectionMySql();
            string sql = "select 1 from user where username = '" + username + "' and password = '"+ password +"' limit 1;";
            MySqlCommand cmd = new MySqlCommand(sql,connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            bool returnFlag = false;
            returnFlag = reader.Read();
            reader.Close();
            CloseConnection();
            return returnFlag;
        }


        public GameSaveData ReadGameData(string username)
        {
            ConnectionMySql();
            string sql = "select * from gamedata where username = '" + username + "'";
            MySqlCommand sqlCmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(sqlCmd);
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mysqlDataAdapter);
            mysqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//确定现有 DataSet 架构与传入数据不匹配时需要执行的操作。
            DataSet dataSet = new DataSet();
            DataRow myRow;
            ArrayList arrayList = new ArrayList();

            try
            {
                mysqlDataAdapter.Fill(dataSet, "gamedata");
                myRow = dataSet.Tables["gamedata"].Rows[0];
                byte[] b = null;
                b = (byte[]) myRow["data"];
                //定义一个流
                MemoryStream stream = new MemoryStream(b);
                //定义一个格式化器
                BinaryFormatter bf = new BinaryFormatter(); 

                

                while (stream.Position != stream.Length)
                {
                    arrayList.Add(bf.Deserialize(stream)); //反序列化
                }

                stream.Close();

                if (arrayList.Count == 0)
                {
                    MessageBox.Show("没有取出数据");
                }
                else
                {
                    MessageBox.Show("成功取出数据");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                CloseConnection();
            }
            
            return (GameSaveData)arrayList[0];
        }

        public void SaveGameData(string username, GameSaveData gameSaveData)
        {
            ConnectionMySql();
            string sql = "select * from gamedata where username = '" + username + "'";
            MySqlCommand sqlCmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter mysqlDataAdapter = new MySqlDataAdapter(sqlCmd);
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(mysqlDataAdapter);
            mysqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//确定现有 DataSet 架构与传入数据不匹配时需要执行的操作。
            
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
 
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;
 
            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;
 
            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            
            
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add(gameSaveData);
            //定义一个流
            Stream stream = new MemoryStream();
            //定义一个格式化器
            BinaryFormatter bf = new BinaryFormatter();
            foreach (object obj in arrayList)
            {
                bf.Serialize(stream, obj);  //序列化
            }
            byte[] array = null;
            array = new byte[stream.Length];
            //将二进制流写入数组
            stream.Position = 0;
            stream.Read(array, 0, (int)stream.Length);
            //关闭流
            stream.Close();

            try
            {
                //将查询的结果存到虚拟数据库ds中的虚拟表gamedata中
                mysqlDataAdapter.Fill(ds, "gamedata");

                //将数据表gamedata的数据复制到DataTable对象（取数据）
                dtable = ds.Tables["gamedata"];

                //用DataRowCollection对象获取这个数据表的所有数据行
                coldrow = dtable.Rows;
                
                if (coldrow.Count == 0)
                {
                    drow = ds.Tables["gamedata"].NewRow();
                    drow["username"] = username;
                    drow["data"] = array;
                    ds.Tables["gamedata"].Rows.Add(drow);
                }
                else
                {
                    drow = coldrow[0];
                }
                drow["data"] = array;
                MessageBox.Show(array.Length.ToString());
                mysqlDataAdapter.Update(ds, "gamedata");
                MessageBox.Show("写入数据库成功！", " 信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("写入数据库失败" + ex.Message, " 信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CloseConnection();
            }
            
        }
        
    }
}