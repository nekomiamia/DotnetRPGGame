using System;
using DotnetRPGGame.Weapon;
using System.Drawing;
namespace DotnetRPGGame.Player
{
    [Serializable]

    public class SeaDoge : Hero
    {
        public SeaDoge(Point targetCor,Point selfCor)
        {
            Weapon = new HolySword();
            Atk = 60;
            Ac = 25;
            Maxhp = 200;
            Nowhp = 200;
            Speed = 12;
            Nickname = "海狗";
            TargetCoordinate = targetCor;
            SelfCoordinate = selfCor;
        }
    }
}