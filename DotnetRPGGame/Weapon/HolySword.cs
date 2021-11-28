namespace DotnetRPGGame.Weapon
{
    public class HolySword : Weapon
    {
        HolySword()
        {
            this.WeaponType = WeaponTypes.Attack;
            this.WeaponAtk = 20;
            this.WeaponAc = 0;
            this.WeaponHp = 40;
            this.Lucky = 50;
        }
    }
}