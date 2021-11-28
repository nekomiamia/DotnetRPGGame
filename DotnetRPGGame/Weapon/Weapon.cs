namespace DotnetRPGGame.Weapon
{
    public class Weapon
    {
        private WeaponTypes weaponType;
        private double weaponAtk;
        private double weaponAc;
        private double weaponHP;
        private double lucky;

        protected WeaponTypes WeaponType
        {
            get => weaponType;
            set => weaponType = value;
        }

        protected double WeaponAtk
        {
            get => weaponAtk;
            set => weaponAtk = value;
        }

        protected double WeaponAc
        {
            get => weaponAc;
            set => weaponAc = value;
        }

        protected double WeaponHp
        {
            get => weaponHP;
            set => weaponHP = value;
        }

        protected double Lucky
        {
            get => lucky;
            set => lucky = value;
        }
        
    }
}