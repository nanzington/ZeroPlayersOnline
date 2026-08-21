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

        public int GrandExchangeMode = 0; // 0 = full, 1 = limited/bronze, 2 = none/iron
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

        // End of Difficulty Settings



        
        public List<Item> Inventory = new();
        public Dictionary<string, Item> Equipment = new(); 
        public Dictionary<string, Skill> Skills = new(); 
        public Dictionary<string, CollectionLogEntry> CollectionLog = new(); 
        public List<Item> BankedItems = new(); 
        public List<string> ItemsEverObtained = new();

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

            int strength = (int)Math.Clamp(Math.Floor(Skills["Strength"].Level / 5f) + 1, 1, 10);

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
             
            if (Inventory.Count < 20) {
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

            }

            if (DeathMode == 2) { // Reset character and whole world so you can't cheese it by dropping items before dying then picking them up

            }
            log.AddMessage(new ColoredString("Oh no, you died!", Color.Crimson, Color.Black));

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
    }
}
