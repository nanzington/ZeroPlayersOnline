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
        public bool ProperName = false;

        public int Level = 1;
        public int CurrentHP = 1;
        public int MaxHP = 1;

        public int DamageReduction = 0; // Reduce damage by this as a percent unless using their weakness

        public int AggroLevel = 0; // If the players combat level is below this, the monster will automatically attack them 
        public bool AlwaysAggro = false;

        public string DamageDice = "1d3"; 
        public string WeakType = "Slash";
        public string DamageType = "Typeless";
        public double AttackSpeedSeconds = 2.4;
        
        public int PoisonSeverity = 0;


        public int RespawnTime = 1;

        public List<ItemDrop> DropTable = new();

        public List<Requirement> Requirements = new();
        public bool SeeWithoutRequirements = true;

        public bool Inaccessible = false;
        public string SpecialCategory = "";
        public List<string> CountsAsSlayer = new();
        public int SlayerReq = 0;
        public string KillItem = "";
        public int KillItemCount = 0;
        

        [JsonIgnore]
        public double TimeLastKilled = 0;
        [JsonIgnore]
        public bool AttackingPlayer = false;
        [JsonIgnore]
        public double TimeLastAttacked = 0;

        public AreaMonster(string n, string id, int lv, int hp, int dr, bool aggro, string ddice, string weakness, int respawn, string dtype, double atkSpeed = 2.4, List<Requirement>? reqs = null, bool seeAnyways = true, bool inaccessible = false, string specialCat = "", bool proper = false) {
            Name = n;
            ID = id;
            Level = lv;
            MaxHP = hp;
            CurrentHP = hp;
            DamageReduction = dr;

            if (aggro)
                AggroLevel = (lv * 2) + 1;
            
            AlwaysAggro = aggro;

            DamageDice = ddice; 
            WeakType = weakness;
            DamageType = dtype;
            AttackSpeedSeconds = atkSpeed;

            RespawnTime = respawn;
            Inaccessible = inaccessible;
            SpecialCategory = specialCat; 

            if (reqs != null)
                Requirements = reqs;
            SeeWithoutRequirements = seeAnyways;

            ProperName = proper;
        } 

        public bool AllReqsMet(Player p) {
            bool all = true;

            if (Requirements != null && Requirements.Count > 0) {
                for (int i = 0; i < Requirements.Count; i++) {
                    if (!Requirements[i].CheckRequirement(p, false, true)) {
                        all = false;
                    }
                }
            }

            return all;
        }

        public string GetSummary() {
            string build = "";

            build += Name + ": Deals " + DamageDice + " " + DamageType + " damage. Weak to " + WeakType + ".";

            if (DamageReduction > 0)
                build += " " + DamageReduction + " DR.";

            if (CountsAsSlayer.Count > 0) {
                string slayerB = "";
                for (int i = 0; i < CountsAsSlayer.Count; i++) {
                    slayerB += (i == 0 ? ", " : "") + (i == CountsAsSlayer.Count - 1 ? "and " : "") + GameLoop.ZPO.ResolveMonsterName(CountsAsSlayer[i]);
                }
                
                build += " Counts for " + slayerB + " Slayer tasks.";
            }

            if (SpecialCategory != "") {
                build += " Counts as " + SpecialCategory + ".";
            }

            return build;
        }
    }
}
