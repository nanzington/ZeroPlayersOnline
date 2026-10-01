namespace ZeroPlayersOnline.DataTypes {
    public class BossAttack {
        public string WarningText = "";
        public string DamageDice = "1d3";  
        public string DamageType = "Typeless";
        public int PoisonSeverity = 0;

        public List<int> HitsLanes = new();
        public bool LanesRelativeToPlayer = false;


        public BossAttack(string warn, string dmgDice, string dmgType, List<int> lanes, bool relative = false) {
            WarningText = warn;
            DamageDice = dmgDice;
            DamageType = dmgType;
            HitsLanes = lanes;
            LanesRelativeToPlayer = relative;
        }

        public List<int> AdjustedLanes(int playerLane, int laneCount) {
            if (!LanesRelativeToPlayer) {
                return HitsLanes;
            } else {
                List<int> adj = new();

                foreach (int lane in HitsLanes) {
                    if (lane + playerLane >= 0 && lane + playerLane < laneCount) {
                        adj.Add(lane + playerLane);
                    }
                }

                return adj;
            }
        }
    }
}
