namespace ZeroPlayersOnline.DataTypes {
    public class Player {
        public string Name = "Player"; 
        public string NavLoc = "TI_Main";
        public string NavRespawn = "TI_Temple";

        public int CurrentHP = 0;
        public int HeldGold = 0;

        public int OffenseExpSplit = 2;
        public int DefenseExpSplit = 2;

        // Difficulty Settings

        public int GrandExchangeMode = 1; // 0 = full, 1 = limited/bronze, 2 = none/iron
        public int DeathMode = 1; // 0 = no death penalty, 1 = drop items, 2 = reset character
        public bool NightmareMode = false; // if true, any damage taken will kill the player

        public int ExpMultiplier = 1; // Multiply all gained exp by this amount
        public int PayToWin = 0; // If 0, experience is earned normally. Otherwise this is the cost in GP to get 1 exp (before the above multiplier is applied).
        public bool OnlyPayToWin = false; // If true and PayToWin isn't 0, exp can ONLY be bought, not earned

        public int DropMultiplier = 1; // Multiply all drop chance by this, high values may result in an issue

        public List<string> PermittedRegions = new(); // If empty all regions allowed, otherwise you can only go to maps in a region in this list

        public bool LocationLock = false; // If true, can only go to locations in the following list, and successfully going to a location not in it costs a LocationPoint
        public Dictionary<string, LocationCompletion> UnlockedLocations = new(); // 
        public int LocationPoints = 0; // Incremented each time you finish all tasks in a location
        public List<string> CompletedFeats = new();

        public int KillLimit = -1; // -1 = uncapped, otherwise after this many kills each unique monster name it will stop giving exp/drops
        public Dictionary<string, int> KillTracker = new(); // Log monsters by name and KC here

        public Dictionary<string, string> ItemIDRemaps = new(); // For randomizer
        public Dictionary<string, string> LocationIDRemaps = new(); // For randomizer
        public Dictionary<string, string> GatheringSpotRemapes = new(); // For randomizer

        public int RandomItems = 0; // 0 = not random, 1 = no logic rando set, 2 = no logic rando changing
        public int RandomLocs = 0; // 0 = not random, 1 = no logic rando
        public int RandomGathering = 0; // 0 = no random, 1 = no logic rando

        public int InventoryLimit = 20;
        public bool CanUseShops = true;
        public bool CanUseBanks = true;
        public int FarmGrowthIncrement = 60;

        // End of Difficulty Settings



        
        public List<Item> Inventory = new();
        public Dictionary<string, Item> Equipment = new(); 
        public Dictionary<string, Skill> Skills = new(); 
        public Dictionary<string, CollectionLogEntry> CollectionLog = new();
        public Dictionary<string, CollectionLogEntry> CollectionLogClues = new();
        public List<Item> BankedItems = new(); 
        public List<string> ItemsEverObtained = new();

        public string PrayerBook = "Normal";
        public Dictionary<string, Prayer> Prayers = new();

        public List<PotionStat> ActivePotions = new(); 
        public Dictionary<string, FarmingPatch> FarmingPatches = new();

        public string CurrentClueTutorial = "";
        public int StepsDoneTutorial = 0;
        public string CurrentClueBeginner = "";
        public int StepsDoneBeginner = 0;
        public string CurrentClueEasy = "";
        public int StepsDoneEasy = 0;
        public string CurrentClueMedium = "";
        public int StepsDoneMedium = 0;
        public string CurrentClueHard = "";
        public int StepsDoneHard = 0;
        public string CurrentClueElite = "";
        public int StepsDoneElite = 0;
        public string CurrentClueMaster = "";
        public int StepsDoneMaster = 0;

        public int GetCombatLevel() {
            int atk = Skills["Attack"].Level;
            int str = Skills["Strength"].Level;
            int def = Skills["Defense"].Level;
            int con = Skills["Constitution"].Level;
            
            return Math.Clamp((atk + str + def + con) / 4, 1, 999);
        }

        public string GetDamageDice() {
            int weaponTier = 1;

            if (Equipment.ContainsKey("Weapon"))
                weaponTier = Equipment["Weapon"].EquipTier + 1;

            int strength = (int)Math.Clamp(Math.Floor(GetEffectiveSkillLevel("Strength") / 5f) + 1, 1, 10);

            return weaponTier + "d" + strength;
        }

        public string GetDamageType() {
            if (Equipment.ContainsKey("Weapon"))
                return Equipment["Weapon"].EquipDamageType;
            return "Crush";
        }


        public bool TryPickup(Item item) { 
            for (int i = 0; i < Inventory.Count; i++) {
                if (Inventory[i].ID == item.ID && Inventory[i].Stackable) {
                    Inventory[i].Quantity += item.Quantity;
                    return true; 
                }
            }
             
            if (Inventory.Count < InventoryLimit) {
                Inventory.Add(item);
                return true;
            }

            return false;
        }


        public void TryGrantExp(string which, int amount, MessageLog log, List<Skill> RecentSkills, bool buying = false) {
            if (Skills.ContainsKey(which)) {
                int oldLevel = Skills[which].Level; 

                if (OnlyPayToWin && !buying)
                    return;

                if (PayToWin > 0 && buying) { 

                    if (HeldGold >= (PayToWin * amount)) {
                        HeldGold -= PayToWin * amount;
                        log.AddMessage(new ColoredString("Paid " + String.Format($"{PayToWin * amount:n0}") + " for " + (amount * ExpMultiplier) + " " + which + " experience.", Color.Goldenrod, Color.Black));
                    } else {
                        log.AddMessage(new ColoredString("You need " + String.Format($"{PayToWin * amount:n0}") + " gold for that. Try again when you're a little richer.", Color.Crimson, Color.Black));
                        return;
                    }
                }


                Skills[which].GrantExp(amount * ExpMultiplier, log, RecentSkills);

                if (which == "Constitution" && oldLevel != Skills[which].Level) {
                    CurrentHP += (Skills[which].Level - oldLevel);
                }
            }

            
        }

        public bool TakeDamage(int amt, MessageLog log) {  
            CurrentHP -= amt;

            if (CurrentHP <= 0 || (NightmareMode && amt > 0)) {
                Die(log);
                return true;
            }

            return false;
        }

        public void Die(MessageLog log) {
            if (DeathMode == 1) { // Drop all items
                if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? deathSpot)) {
                    if (deathSpot != null) {
                        for (int i = Inventory.Count - 1; i >= 0; i--) {
                            bool found = false;
                            for (int j = 0; j < deathSpot.ItemsHere.Count; j++) {
                                if (deathSpot.ItemsHere[j].ID == Inventory[i].ID && Inventory[i].Stackable) {
                                    deathSpot.ItemsHere[j].Quantity += Inventory[i].Quantity;
                                    found = true;
                                    break;
                                }
                            }

                            if (!found) {
                                deathSpot.ItemsHere.Add(Inventory[i]);
                            }

                            Inventory.RemoveAt(i);
                        }
                    }
                }
            }

            log.AddMessage(new ColoredString("Oh no, you died!", Color.Crimson, Color.Black));

            if (DeathMode == 2) { // Reset character and whole world so you can't cheese it by dropping items before dying then picking them up
                GameLoop.ZPO.RebuildLibraries();
                GameLoop.ZPO.SoftResetPlayer();
            } 

            NavLoc = NavRespawn;
            CurrentHP = Skills["Constitution"].Level;
        }



        public void AddFeat(string feat) {
            if (LocationLock) {
                if (!CompletedFeats.Contains(feat)) {
                    CompletedFeats.Add(feat);

                    foreach (var kv in UnlockedLocations) {
                        if (!kv.Value.Completed) {
                            kv.Value.CheckCompletion(this);
                        }
                    }
                }
            }
        }

        public bool PrayerActive(string which) {
            if (Prayers.TryGetValue(which, out Prayer? p)) {
                if (p != null) {
                    return p.Active;
                }
            } 

            return false;
        }

        public void TryTogglePrayer(string which) {
            if (Prayers.TryGetValue(which, out Prayer? p)) {
                if (p != null) {
                    if (p.Active) {
                        p.Active = false;
                        return;
                    } else { 
                        int PrayerLev = Skills["Prayer"].Level;
                        int EffectivePL = GetEffectiveSkillLevel("Prayer");

                        if (p.Level <= PrayerLev) {
                            if (TotalActivePrayers() + p.Level <= EffectivePL) {
                                p.Active = true;
                            } else { 
                                GameLoop.ZPO.Log.AddMessage(new ColoredString("You have too many prayers active to activate that one right now.", Color.Crimson, Color.Black));
                            }
                        } else {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You aren't high enough level to activate that prayer yet.", Color.Crimson, Color.Black));
                        }
                    }
                }
            }
        }

        public int TotalActivePrayers() {
            int count = 0;

            foreach (var kv in Prayers) {
                if (kv.Value.Active) {
                    count += kv.Value.Level;
                }
            }

            return count;
        }

        public int GetEffectiveSkillLevel(string which) {
            if (Skills.TryGetValue(which, out Skill? s)) {
                if (s != null) {
                    int level = s.Level;

                    foreach (var pot in ActivePotions) {
                        if (pot.Stat == which) {
                            level += pot.Change;
                        }
                    }

                    foreach (var kv in Prayers) {
                        if (kv.Value.Active && kv.Value.SkillBuffed == which) {
                            level += (int) Math.Ceiling(kv.Value.Level / 2.0);
                        }
                    }

                    return level;
                }
            }

            return 1;  
        } 


        public bool CanCraft(CraftRecipe craft) {
            if (!Skills.ContainsKey(craft.Skill))
                return false;
            if (Skills[craft.Skill].Level < craft.Level)
                return false;
            if (!GameLoop.ZPO.ItemLibrary.ContainsKey(craft.OutputItem))
                return false;

            if (craft.ExtraTool != "") {
                bool hasTool = false;
                for (int i = 0; i < Inventory.Count; i++) {
                    if (Inventory[i].ID == craft.ExtraTool) {
                        hasTool = true;
                        break;
                    }
                }

                if (!hasTool)
                    return false;
            }

            int reagentCount = 0;

            for (int i = 0; i < Inventory.Count; i++) {
                if (Inventory[i].ID == craft.NeededItem) {
                    reagentCount += Inventory[i].Quantity;
                }
            }

            if (reagentCount < craft.NeededQty)
                return false;

            return true;
        }

        public void TryCraft(CraftRecipe craft) {
            if (!CanCraft(craft))
                return;

            int stillNeeded = craft.NeededQty;

            for (int i = Inventory.Count - 1; i >= 0; i--) {
                if (Inventory[i].ID == craft.NeededItem) {
                    if (Inventory[i].Quantity >= stillNeeded) {
                        Inventory[i].Quantity -= stillNeeded;
                        stillNeeded = 0;
                    } else {
                        stillNeeded -= Inventory[i].Quantity;
                        Inventory[i].Quantity = 0; 
                    }

                    if (Inventory[i].Quantity <= 0) {
                        Inventory.RemoveAt(i);
                    }
                }

                if (stillNeeded <= 0)
                    break;
            }

            Item item = Helper.Clone(GameLoop.ZPO.ItemLibrary[craft.OutputItem]);
            item.Quantity = craft.OutputQty;

            TryPickup(item);
            TryGrantExp(craft.Skill, craft.ExpGranted, GameLoop.ZPO.Log, GameLoop.ZPO.RecentlyTrainedSkills);
        }


        public int TotalArmorValue(string against) {
            int count = 0;

            foreach (var kv in Equipment) {
                int num = kv.Value.UseInt;
                if (kv.Value.EquipSkill == "Defense") {
                    if (kv.Value.MiscString == "DefenseMelee") {
                        if (against == "Ranged") {
                            num *= 2;
                        }
                        if (against == "Magic") {
                            num = (int)Math.Ceiling(num / 2.0);
                        }
                    }

                    if (kv.Value.MiscString == "DefenseMagic") {
                        if (against == "Melee") {
                            num *= 2;
                        }
                        if (against == "Ranged") {
                            num = (int)Math.Ceiling(num / 2.0);
                        }
                    }

                    if (kv.Value.MiscString == "DefenseRange") {
                        if (against == "Magic") {
                            num *= 2;
                        }
                        if (against == "Melee") {
                            num = (int)Math.Ceiling(num / 2.0);
                        }
                    }

                    count += num;
                }
            }

            return count;
        }
    }
}
