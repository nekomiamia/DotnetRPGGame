using System.Drawing;
using DotnetRPGGame.Weapon;

namespace DotnetRPGGame.Player
{
    public class Monster : NPC
    {
        public override double Hurt(NPC npc)
        {
            npc = (Hero) npc;
            return base.Hurt(npc);
        }
    }
}