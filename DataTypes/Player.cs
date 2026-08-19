namespace ZeroPlayersOnline.DataTypes {
    public class Player {
        public string Name = "";
        public SpecificPosition Position = new(25, 21, 0, 0, "Surface");
        public string NavLoc = "TI_Main";
        public string NavRespawn = "TI_Temple";

        public int skinR = 221;
        public int skinG = 168;
        public int skinB = 160;

        public int CurrentHP = 0;
        public int HeldGold = 0;

        public int OffenseExpSplit = 2;
        public int DefenseExpSplit = 2;

        public List<Item> Inventory = new();
        public Dictionary<string, Item> Equipment = new();

        public Dictionary<string, Skill> Skills = new();

        public Dictionary<string, CollectionLogEntry> CollectionLog = new();

        public List<Item> BankedItems = new();

        public ColoredString GetAppearance() {
            return new ColoredString("@", new Color(skinR, skinG, skinB), Color.Black);
        } 

        public Point GetPos() { return Position.GetPos(); } 
        public Point GetMapPos() { return Position.GetMapPos(); }

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


        public void TryGrantExp(string which, int amount, MessageLog log, List<Skill> RecentSkills) {
            if (Skills.ContainsKey(which)) {
                int oldLevel = Skills[which].Level;
                Skills[which].GrantExp(amount, log, RecentSkills);

                if (which == "Constitution" && oldLevel != Skills[which].Level) {
                    CurrentHP += (Skills[which].Level - oldLevel);
                }
            }

            
        }

        public bool TakeDamage(int amt, MessageLog log) {
            CurrentHP -= amt;

            if (CurrentHP <= 0) {
                Die(log);
                return true;
            }

            return false;
        }

        public void Die(MessageLog log) {
            log.AddMessage(new ColoredString("Oh no, you died!", Color.Crimson, Color.Black));

            NavLoc = NavRespawn;
            CurrentHP = Skills["Constitution"].Level;
        }
    }
}
