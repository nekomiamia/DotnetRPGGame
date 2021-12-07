

namespace RPGGameDAL
{
    public class UserAccess
    {
        //实例化DBbase 对象
        DBbase db = new DBbase();
        
        //用户登录的方法
        public int UserLogin(string name, string password)
        {
            string strsql = "select * from user where username = '" + name + "' and password = '" + password + "'";
            return db.returnRowCount(strsql);
        }

        public bool UserRegister(string name, string password)
        {
            string strsql = "select * from user where username = '" + name + "'";
            if (db.returnRowCount(strsql)==0)
            {
                strsql = "insert into user(username,password) values('" + name + "','" + password + "')";
            }
            else
            {
                return false;
            }
            return db.InsertRowString(strsql);
        }
        
    }
}