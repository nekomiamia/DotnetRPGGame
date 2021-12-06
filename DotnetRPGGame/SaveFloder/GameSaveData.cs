using System;
using DotnetRPGGame.Player;

namespace DotnetRPGGame.SaveFloder
{
    [Serializable]
    public class GameSaveData
    {
        private int saveRoundNumber;
        private int saveAckNumber;
        private Monster m1;
        private Monster m2;
        private Hero h1;
        private Hero h2;

        public int SaveRoundNumber { get => saveRoundNumber; set => saveRoundNumber = value; }
        public int SaveAckNumber { get => saveAckNumber; set => saveAckNumber = value; }
        public Monster M1 { get => m1; set => m1 = value; }
        public Monster M2 { get => m2; set => m2 = value; }
        public Hero H1 { get => h1; set => h1 = value; }
        public Hero H2 { get => h2; set => h2 = value; }

        public GameSaveData(int saveRoundNumber, int saveAckNumber, Monster m1, Monster m2, Hero h1, Hero h2)
        {
            this.SaveRoundNumber = saveRoundNumber;
            this.SaveAckNumber = saveAckNumber;
            this.M1 = m1;
            this.M2 = m2;
            this.H1 = h1;
            this.H2 = h2;
        }
        
        
    }
}