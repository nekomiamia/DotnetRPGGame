namespace DotnetRPGGame.Weapon
{
    public class Weapons
    {
        private WeaponTypes weaponType;
        private double weaponAtk;
        private double weaponAc;
        private double lucky;
        private string weaponName;

        public string WeaponName
        {
            get => weaponName;
            set => weaponName = value;
        }

        public WeaponTypes WeaponType
        {
            get => weaponType;
            set => weaponType = value;
        }

        public double WeaponAtk
        {
            get => weaponAtk;
            set => weaponAtk = value;
        }

        public double WeaponAc
        {
            get => weaponAc;
            set => weaponAc = value;
        }

  
        public double Lucky
        {
            get => lucky;
            set => lucky = value;
        }
        
    }
}