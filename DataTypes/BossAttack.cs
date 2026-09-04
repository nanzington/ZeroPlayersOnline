namespace ZeroPlayersOnline.DataTypes {
    public class BossAttack {
        public string WarningText = "";
        public string DamageDice = "1d3";  
        public string DamageType = "Typeless";

        public List<int> HitsLanes = new();


        public BossAttack(string warn, string dmgDice, string dmgType, List<int> lanes) {
            WarningText = warn;
            DamageDice = dmgDice;
            DamageType = dmgType;
            HitsLanes = lanes;
        }
    }
}
