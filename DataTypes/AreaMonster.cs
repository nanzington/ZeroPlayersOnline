using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlayersOnline.DataTypes {
    public class AreaMonster {
        public string Name = "";
        public string ID = "";

        public int Level = 1;
        public int CurrentHP = 1;
        public int MaxHP = 1;

        public int DamageReduction = 0; // Reduce damage by this as a percent unless using their weakness

        public int AggroLevel = 0; // If the players combat level is below this, the monster will automatically attack them 
        public bool AlwaysAggro = false;

        public string DamageDice = "1d3"; 
        public string WeakType = "Slash";


        public int RespawnTime = 1;

        public List<ItemDrop> DropTable = new();


        [JsonIgnore]
        public double TimeLastKilled = 0;
        [JsonIgnore]
        public bool AttackingPlayer = false;
        [JsonIgnore]
        public double TimeLastAttacked = 0;

        public AreaMonster(string n, string id, int lv, int hp, int dr, int aggroLv, bool aggro, string ddice, string weakness, int respawn) {
            Name = n;
            ID = id;
            Level = lv;
            MaxHP = hp;
            CurrentHP = hp;
            DamageReduction = dr;

            AggroLevel = aggroLv;
            AlwaysAggro = aggro;

            DamageDice = ddice; 
            WeakType = weakness;

            RespawnTime = respawn;
        } 
    }
}
