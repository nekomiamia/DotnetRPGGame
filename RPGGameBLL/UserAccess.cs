namespace RPGGameBLL
{
    public class UserAccess
    {
        RPGGameDAL.UserAccess d_userAccess = new RPGGameDAL.UserAccess();

        public int UserLogin(RPGGameModel.DataBase.user _user)
        {
            return d_userAccess.UserLogin(_user.Username, _user.Password);
        }

        public bool UserRegister(RPGGameModel.DataBase.user _user)
        {
            return d_userAccess.UserRegister(_user.Username, _user.Password);
        }
    }
}