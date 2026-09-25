namespace ZeroPlayersOnline.DataTypes {
    public class SlayerTask : WeightedItem {
        public string TargetID = "";
        public int KillMin = 0;
        public int KillMax = 0; 

        public List<Requirement> Reqs = new();

        public SlayerTask(string id, int min, int max, int weight, List<Requirement> reqs = null) : base(id, weight, reqs: reqs) {
            TargetID = id;
            KillMin = min;
            KillMax = max;
        }
    }
}
