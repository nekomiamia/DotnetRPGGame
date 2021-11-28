using System.Drawing;
using DotnetRPGGame.Weapon;

namespace DotnetRPGGame.Player
{
    public class SleepDoge : Hero
    {
        public SleepDoge(Point targetCor,Point selfCor)
        {
            Weapon = new HolyPillow();
            Atk = 20;
            Ac = 10;
            Maxhp = 400;
            Nowhp = 400;
            Speed = 5;
            Nickname = "睡狗";
            TargetCoordinate = targetCor;
            SelfCoordinate = selfCor;
        }
    }
}