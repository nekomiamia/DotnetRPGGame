using System;

namespace DotnetRPGGame.Weapon
{
    [Serializable]
    public class HolySword : Weapons
    {
        public HolySword()
        {
            this.WeaponName = "圣狗剑";
            this.WeaponType = WeaponTypes.Attack;
            this.WeaponAtk = 25;
            this.WeaponAc = 0;
            this.Lucky = 50;
        }
    }
}