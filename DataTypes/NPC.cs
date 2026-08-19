namespace ZeroPlayersOnline.DataTypes {
    public class NPC {
        public string Name = "";
        public string ID = "";

        public int PickpocketLevel = 0;
        public int PickpocketEXP = 0;
        public List<WeightedItem> PickpocketLoot = new();

        public Dictionary<int, DialogueStage> Dialogue = new();

        public NPC(string n, string id, Dictionary<int, DialogueStage> dia, int ppL = 0, int ppExp = 0) {
            Name = n;
            ID = id;
            Dialogue = dia;

            PickpocketLevel = ppL;
            PickpocketEXP = ppExp;
        }


        public void TryPickpocket(Player p, List<Skill> RecentlyTrained, Dictionary<string, Item> ItemLib, MessageLog log) {
            if (p.Skills.ContainsKey("Thieving")) {
                Skill thieving = p.Skills["Thieving"];

                if (thieving.Level >= PickpocketLevel) {
                    int chance = Math.Clamp(20 + (thieving.Level / 2), 20, 80);

                    if (GameLoop.rand.Next(100) + 1 <= chance) {
                        p.TryGrantExp("Thieving", PickpocketEXP, log, RecentlyTrained);

                        if (PickpocketLoot != null && PickpocketLoot.Count > 0) {
                            string item = Helper.ChooseWeighted<WeightedItem>(PickpocketLoot).Item;

                            if (ItemLib.ContainsKey(item)) {
                                Item spawned = Helper.Clone(ItemLib[item]);
                                p.TryPickup(spawned);
                            }
                        } 
                    } else { 
                        log.AddMessage(new ColoredString("Failed to pickpocket " + Name + ".", Color.Crimson, Color.Black));
                        p.TakeDamage(1, log);
                    }
                } else {
                    log.AddMessage(new ColoredString("You need " + PickpocketLevel + " Thieving to do that.", Color.Crimson, Color.Black));
                }
            }
        }
    }
}
