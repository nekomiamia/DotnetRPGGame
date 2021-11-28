using System;
using System.Diagnostics;
using System.Drawing;
using DotnetRPGGame.Weapon;

namespace DotnetRPGGame.Player
{
    public class NPC : IComparable<NPC>
    {
        private double atk; //攻击力
        private double ac; //护甲值
        private double maxhp; //最大血量
        private double nowhp; //当前血量
        private int speed; //速度
        private string nickname; //名字
        private Point selfCoordinate; //自己坐标
        private Point targetCoordinate; //目标坐标
        private Weapons weapon;
        
        public int CompareTo(NPC npc)
        {
            if (this.Speed > npc.Speed)
            {
                return -1;
            }
            return 1;
        }
        
        public virtual double Hurt(NPC npc)
        {
            TargetCoordinate = npc.SelfCoordinate;
            double damage = (Atk + Weapon.WeaponAtk) > (npc.Ac + npc.Weapon.WeaponAc)
                ? (Atk + Weapon.WeaponAtk - npc.Ac - npc.Weapon.WeaponAc)
                : 0;
            npc.Nowhp = npc.Nowhp - damage;
            Debug.WriteLine(this.nickname + " hurt "+ npc.nickname + " " + damage);
            return damage;
        }
        
        public void Back()
        {
            TargetCoordinate = SelfCoordinate;
        }
        
        public Weapons Weapon
        {
            get => weapon;
            set => weapon = value;
        }

        public string Nickname
        {
            get => nickname;
            set => nickname = value;
        }

        public Point SelfCoordinate
        {
            get => selfCoordinate;
            set => selfCoordinate = value;
        }

        public Point TargetCoordinate
        {
            get => targetCoordinate;
            set => targetCoordinate = value;
        }

        public double Atk
        {
            get => atk;
            set => atk = value;
        }

        public double Ac
        {
            get => ac;
            set => ac = value;
        }

        public double Maxhp
        {
            get => maxhp;
            set => maxhp = value;
        }

        public double Nowhp
        {
            get => nowhp;
            set => nowhp = value;
        }
        public int Speed
        {
            get => speed;
            set => speed = value;
        }
    }
}