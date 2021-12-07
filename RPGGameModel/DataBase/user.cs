using System;

namespace RPGGameModel.DataBase
{
    public class user
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set => _username = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Password
        {
            get => _password;
            set => _password = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}