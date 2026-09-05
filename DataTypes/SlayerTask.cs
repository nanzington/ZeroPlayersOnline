namespace ZeroPlayersOnline.DataTypes {
    public class SlayerTask {
        public string TargetID = "";
        public int KillMin = 0;
        public int KillMax = 0;

        public SlayerTask(string id, int min, int max) {
            TargetID = id;
            KillMin = min;
            KillMax = max;
        }
    }
}
