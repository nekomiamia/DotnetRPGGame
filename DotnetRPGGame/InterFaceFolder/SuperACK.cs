using System;
using DotnetRPGGame.Player;

namespace DotnetRPGGame.InterFaceFolder
{
    public interface SuperACK
    {
        Tuple<bool,double> SuperAck(NPC npc);
    }
}