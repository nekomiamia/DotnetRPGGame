using System;
using System.Drawing;
using DotnetRPGGame.Weapon;

namespace DotnetRPGGame.Player
{
    [Serializable]

    public class Monster : NPC
    {
        public override double Hurt(NPC npc)
        {
            npc = (Hero) npc;
            return base.Hurt(npc);
        }
    }
}