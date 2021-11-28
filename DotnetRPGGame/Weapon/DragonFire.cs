namespace DotnetRPGGame.Weapon
{
    public class DragonFire : Weapons
    {
        public DragonFire()
        {
            this.WeaponName = "龙龙火球";
            this.WeaponType = WeaponTypes.Attack;
            this.WeaponAtk = 30;
            this.WeaponAc = 0;
            this.Lucky = 30;
        }
    }
}