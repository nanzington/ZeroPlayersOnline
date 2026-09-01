using Newtonsoft.Json;

namespace ZeroPlayersOnline.DataTypes {
    public class ProcessingStation {
        public string Name = ""; 

        public List<ProcessingRecipe> Recipes = new();

        public bool OpensUI = false;

        [JsonIgnore]
        public int TimeLeft = -1;

        [JsonIgnore]
        public double TimeMade = 0;

        [JsonIgnore]
        public string ItemOnExpire = "";

        public ProcessingStation(string n, bool ui = false) {
            Name = n;  
            OpensUI = ui;
        }

        public bool TryProcessItem(Player p, MessageLog log, Dictionary<string, Item> ItemLibrary, List<Skill> RecentSkills) {
            for (int i = 0; i < p.Inventory.Count; i++) {
                bool changedInv = false;
                for (int j = 0; j < Recipes.Count; j++) {
                    if (p.Inventory[i].ID == Recipes[j].InputID && !p.Inventory[i].Noted) {
                        if (Recipes[j].SkillUsed != "") {
                            if (p.Skills.ContainsKey(Recipes[j].SkillUsed) && p.Skills[Recipes[j].SkillUsed].Level < Recipes[j].SkillLevel) {
                                log.AddMessage(new ColoredString("You get the feeling you should have " + Recipes[j].SkillLevel + " " + Recipes[j].SkillUsed + " to try that.", Color.Crimson, Color.Black));
                                return false;
                            } 
                        } 

                        p.Inventory[i].Quantity -= 1;
                        if (p.Inventory[i].Quantity <= 0) {
                            p.Inventory.RemoveAt(i);
                            changedInv = true;
                        }

                        int extra = 0;

                        if (ItemLibrary.ContainsKey(Recipes[j].OutputID)) {
                            Item item = Helper.Clone(ItemLibrary[Recipes[j].OutputID]);

                            if (Recipes[j].HighSkillExtraOutputs) {
                                int skillDiff = p.Skills[Recipes[j].SkillUsed].Level - Recipes[j].SkillLevel;
                                extra = (int) Math.Floor(skillDiff / 10.0);
                                item.Quantity += extra;
                            }

                            p.TryPickup(item, item.Quantity);
                        }

                        p.TryGrantExp(Recipes[j].SkillUsed, Recipes[j].SkillEXP * (1 + extra), log, RecentSkills);
                        return true;
                    }
                    if (changedInv)
                        break;
                }
                if (changedInv)
                    break;
            }

            return false;
        }
    }
}
