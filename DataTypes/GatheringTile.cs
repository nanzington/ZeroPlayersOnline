using Newtonsoft.Json;
using ZeroPlayersOnline.Managers;

namespace ZeroPlayersOnline.DataTypes {
    public class GatheringTile {
        public string Name = "";
        public string ID = "";

        public string Skill = "";
        public int Level = 1;
        public int ExpGranted = 0;
        public int ExpOnFail = 0;

        public string InteractVerb = "";
        public int SuccessChance = 100;
        public int DepleteChance = 100;

        public int RestockTime = 1; 

        public int DamageOnFail = 0;

        public bool LevelBasedSuccess = false;

        public string NeedToolCat = "";


        public List<WeightedItem>? PossibleItems = null;

        [JsonIgnore]
        public double LastGathered = 0;

        public GatheringTile(string id, string name, string verb, int succ, int deplete, int restock, string skill = "", int skLevel = 0, int exp = 0, int expFail = 0, int damageOnFail = 0, bool levelBasedSucc = false, string neededTool = "", List<WeightedItem>? items = null ) {
            ID = id;
            Name = name;
            InteractVerb = verb;
            SuccessChance = succ;
            DepleteChance = deplete;
            RestockTime = restock;

            PossibleItems = items;
            Skill = skill;
            Level = skLevel;
            ExpGranted = exp;
            ExpOnFail = expFail;

            DamageOnFail = damageOnFail;
            LevelBasedSuccess = levelBasedSucc;
            NeedToolCat = neededTool;
        }


        public string PickItem() {
            if (PossibleItems != null && PossibleItems.Count > 0)
                return Helper.ChooseWeighted<WeightedItem>(PossibleItems).Item;
            return "";
        }

        public void Gather(Player p, MessageLog log, Dictionary<string, Item> itemLibrary, Location currentLoc, List<Skill> Recents) {
            if (CanGather(p) == "") {
                ClueLogic.GenericStep(p, log, "Gather", ID);

                int success = GameLoop.rand.Next(100) + 1;

                if (LevelBasedSuccess && p.Skills.ContainsKey(Skill))
                    success += (p.GetEffectiveSkillLevel(Skill) - Level);
                
                int mod = 0;
                if (NeedToolCat != "") { 
                    mod = -100;
                    foreach (var kv in p.Equipment) {
                        if (kv.Value.MiscString == NeedToolCat) {
                            if (kv.Value.EquipLevel <= p.GetEffectiveSkillLevel(Skill)) { 
                                mod = Math.Max(mod, kv.Value.EquipLevel - Level);
                            }
                        }
                    }

                    for (int i = 0; i < p.Inventory.Count; i++) {
                        if (p.Inventory[i].MiscString == NeedToolCat) {
                            if (p.Inventory[i].EquipLevel <= p.GetEffectiveSkillLevel(Skill)) {
                                mod = Math.Max(mod, p.Inventory[i].EquipLevel - Level);
                            }
                        }
                    }
                }

                if (success <= SuccessChance + mod) {
                    string output = PickItem(); 
                    if (itemLibrary.ContainsKey(output)) {
                        Item receive = Helper.Clone(itemLibrary[output]);
                        if (p.TryPickup(receive, 1)) {
                            log.AddMessage(new ColoredString("You get " + receive.Name.ToLower() + " from the " + Name + ".", Color.Green, Color.Black));
                        } else {
                            log.AddMessage(new ColoredString("Your inventory is full so the " + receive.Name.ToLower() + " falls to the ground.", Color.Goldenrod, Color.Black));
                        }

                        p.TryGrantExp(Skill, ExpGranted, log, Recents);
                    } else {
                        if (output != "") {
                            log.AddMessage(new ColoredString("You " + InteractVerb.ToLower() + " the " + Name.ToLower() + ", but output item doesn't exist.", Color.Firebrick, Color.Black));
                        } else {
                            log.AddMessage(new ColoredString("You " + InteractVerb.ToLower() + " the " + Name.ToLower() + ", but get nothing.", Color.Firebrick, Color.Black));
                        }
                        p.TryGrantExp(Skill, ExpGranted, log, Recents);
                    }

                    int deplete = GameLoop.rand.Next(100) + 1;

                    if (deplete <= DepleteChance - (mod / 2)) { 
                        if (p.PrayerActive("Enduring Nature")) {
                            deplete = GameLoop.rand.Next(100) + 1;

                            if (deplete <= DepleteChance - (mod / 2)) { 
                                LastGathered = Helper.Time();
                            }
                        } else {
                            LastGathered = Helper.Time();
                        }
                    }
                } else {
                    log.AddMessage(new ColoredString("You failed to " + InteractVerb.ToLower() + " the " + Name.ToLower() + ".", Color.Red, Color.Black));

                    if (ExpOnFail > 0) {
                        p.TryGrantExp(Skill, ExpOnFail, log, Recents);
                    }
                }
            } else {
                    log.AddMessage(new ColoredString("You need " + CanGather(p) + " to do that.", Color.Crimson, Color.Black));
            }
        } 

        public string CanGather(Player p) { 
            if (p.Skills.ContainsKey(Skill) && p.Skills[Skill].Level < Level)
                return Level + " " + Skill;
            if (LastGathered + (RestockTime * 1000) > Helper.Time() && LastGathered != 0)
                return "to wait for it to replenish";
            if (!p.Skills.ContainsKey(Skill) && Level > 0)
                return Level + " " + Skill;
            if (NeedToolCat != "") {
                bool foundTool = false;
                foreach (var kv in p.Equipment) {
                    if (kv.Value.MiscString == NeedToolCat) {
                        if (kv.Value.EquipLevel <= p.GetEffectiveSkillLevel(Skill)) {
                            foundTool = true;
                        }
                    }
                }

                for (int i = 0; i < p.Inventory.Count; i++) {
                    if (p.Inventory[i].MiscString == NeedToolCat) {
                        if (p.Inventory[i].EquipLevel <= p.GetEffectiveSkillLevel(Skill)) {
                            foundTool = true;
                        }
                    }
                }

                if (!foundTool)
                    return "a " + NeedToolCat;
            }
            return "";
        }
    }
}
