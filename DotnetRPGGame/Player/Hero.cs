using System;
using System.Drawing;
using DotnetRPGGame.Weapon;

namespace DotnetRPGGame.Player
{
    public class Hero : NPC
    {
        public override double Hurt(NPC npc)
        {
            npc = (Monster) npc;
            return base.Hurt(npc);
        }

       
    }
}