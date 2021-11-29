using System;
using System.Drawing;
using DotnetRPGGame.Weapon;

namespace DotnetRPGGame.Player
{  
    [Serializable]

    public class GunDragon : Monster
    {
        public GunDragon(Point targetCor,Point selfCor)
        {
            Weapon = new DragonGun();
            Atk = 40;
            Ac = 30;
            Maxhp = 240;
            Nowhp = 240;
            Speed = 10;
            Nickname = "枪龙";
            TargetCoordinate = targetCor;
            SelfCoordinate = selfCor;
        }
    }
}