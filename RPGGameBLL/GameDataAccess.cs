using RPGGameModel.DataBase;

namespace RPGGameBLL
{
    public class GameDataAccess
    {
        RPGGameDAL.GameDataAccess d_gameDataAccess = new RPGGameDAL.GameDataAccess();

        public gamedata ReadGamedata(gamedata _gamedata)
        {
            gamedata returnGamedata = d_gameDataAccess.SelectProgress(_gamedata.Username);
            return returnGamedata;
        }
        
        public bool SaveGamedata(gamedata _gamedata)
        {
            return d_gameDataAccess.SaveProgress(_gamedata.Username,_gamedata.Data);;
        }
    }
}