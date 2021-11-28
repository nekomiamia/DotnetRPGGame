namespace DotnetRPGGame.Weapon
{
    public class DragonGun : Weapons
    {
        public DragonGun()
        {
            this.WeaponName = "龙龙枪";
            this.WeaponType = WeaponTypes.Attack;
            this.WeaponAtk = 20;
            this.WeaponAc = 0;
            this.Lucky = 90;
        }
    }
}