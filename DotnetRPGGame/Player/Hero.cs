
using System.Drawing;

namespace DotnetRPGGame.Player
{
    public class Hero
    {
        public double atk; //攻击力
        public double ac; //护甲值
        public double hp; //血量
        public double speed; //速度
        public string nickname;//名字
        public Point selfCoordinate;//自己坐标
        public Point targetCoordinate;//目标坐标

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

        public double Hp
        {
            get => hp;
            set => hp = value;
        }

        public double Speed
        {
            get => speed;
            set => speed = value;
        }

    }
}