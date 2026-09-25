using Newtonsoft.Json;

namespace ZeroPlayersOnline.DataTypes {
    public class BossFight {
        public string ID = "";
        public string Name = "";
         
        public int Level = 1;
        public int CurrentHP = 1;
        public int MaxHP = 1;

        public string WeakType = "Slash";
        public string SpecialCategory = "";
        public List<string> CountsAsSlayer = new();
        public int DamageReduction = 0; // Reduce damage by this as a percent unless using their weakness

        public int AggroLevel = 0; // If the players combat level is below this, the monster will automatically attack them 
        public bool AlwaysAggro = false;
         
        public string DefaultDmgDice = "1d3";  
        public string DefaultDmgType = "Typeless";
        public int DefaultPoisonSeverity = 0;
        public List<BossAttack> Specials = new();
         
        public int LanesHere = 3;

        public double AttackSpeedInMS = 1000;
        public int AttacksBetweenSpecials = 3; 
        public int RespawnTime = 1;

        public string KillItem = "";
        public int KillItemCount = 0;

        public List<ItemDrop> DropTable = new();


        [JsonIgnore]
        public int CurrentLane = 0;
        [JsonIgnore]
        public int UsingMove = -1;
        [JsonIgnore]
        public double TimeLastKilled = 0;
        [JsonIgnore]
        public bool AttackingPlayer = false;
        [JsonIgnore]
        public double TimeLastAttacked = 0;
        [JsonIgnore]
        public double MovesSinceSpecial = 0;

        public BossFight(string name, string id, int level, int maxHp, string weakness, int dr, int respawn, string defDmgDice, string defDmgType, double attackSpeed = 1000, int attacksBetween = 3, int lanes = 3, bool aggro = false, string specialCat = "", List<BossAttack> specials = null, List<ItemDrop> drops = null) {
            ID = id;
            Name = name;

            Level = level;
            MaxHP = maxHp;
            CurrentHP = MaxHP;

            DamageReduction = dr;
            RespawnTime = respawn;
            
            if (aggro)
                AggroLevel = (level * 2) + 1;
            AlwaysAggro = aggro;

            DefaultDmgDice = defDmgDice;
            DefaultDmgType = defDmgType;

            AttackSpeedInMS = attackSpeed;
            AttacksBetweenSpecials = attacksBetween;
            LanesHere = lanes;
            SpecialCategory = specialCat;

            if (specials != null)
                Specials = specials;
            if (drops != null)
                DropTable = drops;
        }
    }
}
