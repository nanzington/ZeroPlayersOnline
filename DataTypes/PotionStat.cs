namespace ZeroPlayersOnline.DataTypes {
    public class PotionStat {
        public string Stat = "";
        public int Change = 0; 

        public int SecondsSinceWeaken = 0;

        public PotionStat(string stat, int change) {
            Stat = stat;
            Change = change;
        }
    }
}
