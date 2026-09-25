using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZeroPlayersOnline.DataTypes {
    public class NPC {
        public string Name = "";
        public string ID = "";

        public int PickpocketLevel = 0;
        public int PickpocketEXP = 0;
        public int PickpocketDamage = 0;
        public List<ItemDrop> PickpocketLoot = new();

        public Dictionary<int, DialogueStage> Dialogue = new();
        public Requirement? ReqToSee = null;

        public int SlayerLevel, MinSlayerLevel, MinCombatLevel = 0;
        public List<SlayerTask> SlayerTasks = new();

        public NPC(string n, string id, Dictionary<int, DialogueStage> dia, int ppL = 0, int ppExp = 0, int ppDmg = 1, Requirement req = null) {
            Name = n;
            ID = id;
            Dialogue = dia;

            PickpocketLevel = ppL;
            PickpocketEXP = ppExp;
            PickpocketDamage = ppDmg;

            ReqToSee = req;
        }


        public void TryPickpocket(Player p, List<Skill> RecentlyTrained, Dictionary<string, Item> ItemLib, MessageLog log) {
            if (p.Skills.ContainsKey("Thieving")) {
                Skill thieving = p.Skills["Thieving"];

                if (thieving.Level >= PickpocketLevel) {
                    int chance = Math.Clamp(50 + ((thieving.Level - PickpocketLevel) / 2), 40, 80);

                    if (GameLoop.rand.Next(100) + 1 <= chance) {
                        p.TryGrantExp("Thieving", PickpocketEXP, log, RecentlyTrained);

                        if (PickpocketLoot != null && PickpocketLoot.Count > 0) {
                            List<Item> rolled = new();
                            while (rolled.Count < 1) {
                                foreach (var item in PickpocketLoot) {
                                    Item? roll = item.RollDrop(p, null, false, true);

                                    if (roll != null) {
                                        roll.UseInt3 = (int) Math.Round(item.InY, MidpointRounding.AwayFromZero);
                                        rolled.Add(roll);
                                    }
                                }
                            }

                            rolled = rolled.OrderBy(o => o.UseInt3).Reverse().ToList();

                            if (rolled.Count > 0) {
                                p.TryPickup(rolled[0], rolled[0].Quantity);
                            }
                        } 
                    } else { 
                        log.AddMessage(new ColoredString("Failed to pickpocket " + Name + ".", Color.Crimson, Color.Black));

                        if (p.Equipment.TryGetValue("Amulet", out ItemWrapper? eqp) && eqp != null && eqp.ID == "necklaceDodgy" && GameLoop.rand.Next(4) == 0) {
                            eqp.Charges -= 1; 
                            log.AddMessage(new ColoredString("Your dodgy necklace lets you avoid damage.", Color.AntiqueWhite, Color.Black));

                            if (eqp.Charges <= 0) { 
                                log.AddMessage(new ColoredString("Your dodgy necklace runs out of charge and shatters.", Color.Crimson, Color.Black));
                                p.Equipment.Remove("Amulet");
                            }
                        } else {
                            p.TakeDamage(PickpocketDamage, log);
                        }
                    }
                } else {
                    log.AddMessage(new ColoredString("You need " + PickpocketLevel + " Thieving to do that.", Color.Crimson, Color.Black));
                }
            }
        }
    }
}
