using System;
using System.Diagnostics;

namespace DotnetRPGGame.EventFolder
{
    public class SendMessge
    {
        //声明一个委托
        public delegate void PassIntToFrmMainEventHandler(string username);
        //声明一个要委托的事件
        public event PassIntToFrmMainEventHandler  PassIntToFrmMainEvent;
        
        public void OnSend(string username)
        {
            PassIntToFrmMainEvent(username);
        }
    }
}