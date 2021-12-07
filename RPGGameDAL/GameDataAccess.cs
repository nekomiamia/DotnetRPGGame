using MySql.Data.MySqlClient;
using RPGGameModel.DataBase;

namespace RPGGameDAL
{
    public class GameDataAccess
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();
        
        //保存进度的方法 insert
        public bool InsertProgress(string name, byte[] data)
        {
            db.chkConnection();
            MySqlCommand cmd = new MySqlCommand("insert into gamedata(username,data) values(@col1,@col2)",db.con);
            cmd.Parameters.Add("@col1", MySqlDbType.String).Value = name;
            MySqlParameter param = new MySqlParameter();
            param.MySqlDbType = MySqlDbType.VarBinary;
            param.ParameterName = "@col2";
            param.Value = data;
            cmd.Parameters.Add(param);
            return db.InsertRowCommand(cmd);
        }

        //保存进度的方法 update
        public bool UpdateProgress(string name, byte[] data)
        {
            db.chkConnection();
            MySqlCommand cmd = new MySqlCommand("update gamedata set data = @col2 where username = @col1",db.con);
            cmd.Parameters.Add("@col1", MySqlDbType.String).Value = name;
            MySqlParameter param = new MySqlParameter();
            param.MySqlDbType = MySqlDbType.VarBinary;
            param.ParameterName = "@col2";
            param.Value = data;
            cmd.Parameters.Add(param);
            return db.InsertRowCommand(cmd);
        }
        
        public bool SaveProgress(string name, byte[] data)
        {
            if (SelectProgress(name)==null)
            {
                return InsertProgress(name, data);
            }
            return UpdateProgress(name, data);
        }
        
        
        //取进度的方法 select
        public gamedata SelectProgress(string name)
        {
            string strsql = "select * from gamedata where username = '" + name + "'";
            return db.ReturnUserdata(strsql);
        }
    }
}