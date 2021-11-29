using System;
using System.Drawing;
using DotnetRPGGame.Weapon;

namespace DotnetRPGGame.Player
{
    [Serializable]

    public class FireDragon : Monster
    {
        
        public FireDragon(Point targetCor,Point selfCor)
        {
            Weapon = new DragonFire();
            Atk = 40;
            Ac = 40;
            Maxhp = 300;
            Nowhp = 300;
            Speed = 9;
            Nickname = "火龙";
            TargetCoordinate = targetCor;
            SelfCoordinate = selfCor;
        }        
    }
}