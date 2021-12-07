using System;

namespace RPGGameModel.DataBase
{
    public class gamedata
    {
        private string _username;
        private byte[] _data;
        public string Username
        {
            get => _username;
            set => _username = value ?? throw new ArgumentNullException(nameof(value));
        }

        public byte[] Data
        {
            get => _data;
            set => _data = value ?? throw new ArgumentNullException(nameof(value));
        }

    }
}