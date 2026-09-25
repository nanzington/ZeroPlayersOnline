using Newtonsoft.Json;

namespace ZeroPlayersOnline.DataTypes {
    public class ItemDrop {
        public string ItemID = "";
        public int DropX = 0;
        public double InY = 0;

        public int QuantityMin = 0;
        public int QuantityMax = 1;

        public bool EvenAt0x = false;

        public bool Noted = false;
         
        public Requirement? Requirement = null;

        public string AltLog = "";

        [JsonConstructor]
        public ItemDrop() {}

        public ItemDrop(string id, int x, double y, int min, int max, bool noted = false, bool evenIf0 = false, Requirement? req = null, string altlog = "") {
            ItemID = id;
            DropX = x;
            InY = y;

            QuantityMin = min;
            QuantityMax = max;

            Noted = noted;

            EvenAt0x = evenIf0;

            Requirement = req;
            AltLog = altlog; // Basically just used for the general clue log drops to redirect them
        }

        public ItemDrop(ItemDrop other) {
            ItemID = other.ItemID;
            DropX = other.DropX;
            InY = other.InY;
            QuantityMin = other.QuantityMin;
            QuantityMax = other.QuantityMax;
            EvenAt0x = other.EvenAt0x;
            Noted = other.Noted;
            Requirement = other.Requirement;
            AltLog = other.AltLog;
        }

        // Rolls 0 to InY, if less than DropX, success
        // So if DropX is 1 and InY is 10, then on a roll of 0-9, landing on a 0 is a successful drop, giving 10% chance to drop


        public Item? RollDrop(Player player, CollectionLogEntry? log, bool inaccessible = false, bool justReturn = false) {
            if (Requirement != null && !Requirement.CheckRequirement(player, true, true))
                return null;


            if (log == null)
                log = new CollectionLogEntry("");

            bool reachedKillLimit = player.KillLimit == 0 ? true : false;
            if (log.KillCount >= player.KillLimit && player.KillLimit > 0) {
                reachedKillLimit = true;
            }

            if (EvenAt0x || !reachedKillLimit) {
                int dropX = DropX;

                dropX *= player.DropMultiplier;

                if (reachedKillLimit)
                    dropX = 0;

                if (EvenAt0x && dropX == 0)
                    dropX = DropX;


                if (dropX != 0) {
                    if (player.DropModifier != 2) {
                        int dropRoll = GameLoop.rand.Next((int) Math.Round(InY, MidpointRounding.AwayFromZero));
                        int dropRoll2 = GameLoop.rand.Next((int) Math.Round(InY, MidpointRounding.AwayFromZero));
                        int dropRoll3 = GameLoop.rand.Next((int) Math.Round(InY, MidpointRounding.AwayFromZero));
                        int dropRoll4 = GameLoop.rand.Next((int) Math.Round(InY, MidpointRounding.AwayFromZero));

                        bool wealth = false;
                        bool fortune = false;

                        if (player.Equipment.TryGetValue("Ring", out ItemWrapper? eqp) && eqp != null && eqp.ID == "ringWealth") { wealth = true; }
                        if (player.Equipment.TryGetValue("Ring", out ItemWrapper? eqp2) && eqp2 != null && eqp2.ID == "ringFortune") { wealth = true; fortune = true; }

                        bool dryActive = log.DryProtection(ItemID, (int) Math.Ceiling(InY / (double) dropX));
                        if (dropRoll < dropX || (player.PrayerActive("Good Fortune") && dropRoll2 < dropX) || (wealth && dropRoll3 < dropX) || (fortune && dropRoll4 < dropX) ||  (player.DropModifier == 1 && dryActive)) {
                            if (!log.DropsObtained.ContainsKey(ItemID))
                                log.DropsObtained.Add(ItemID, 0);
                            if (!justReturn)
                                log.DropsObtained[ItemID] += 1;

                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(ItemID)) {
                                Item spawn = new(GameLoop.ZPO.ItemLibrary[ItemID]);

                                if (QuantityMin == QuantityMax)
                                    spawn.Quantity = QuantityMin;
                                else {
                                    int amt = GameLoop.rand.Next(QuantityMax - QuantityMin) + QuantityMin;
                                    spawn.Quantity = amt;
                                }

                                if (justReturn) {
                                    return new(spawn);
                                }

                                if (player.DropModifier == 1 && log.DropsObtained[ItemID] == 1 && dryActive && InY != 1) { 
                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Received " + GameLoop.ZPO.ResolveItemName(ItemID) + " due to Dry Protection.", Color.Green, Color.Black));
                                }

                                GameLoop.ZPO.TryPlaceItem(player.NavLoc, new(spawn, inaccessible)); 
                            }
                        }
                    } else {
                        if (log.NoRNGDrop((int) Math.Ceiling(InY / (double) dropX))) {
                            if (!log.DropsObtained.ContainsKey(ItemID))
                                log.DropsObtained.Add(ItemID, 0);
                            if (!justReturn)
                                log.DropsObtained[ItemID] += 1;

                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(ItemID)) {
                                Item spawn = new(GameLoop.ZPO.ItemLibrary[ItemID]);

                                if (QuantityMin == QuantityMax)
                                    spawn.Quantity = QuantityMin;
                                else {
                                    int amt = GameLoop.rand.Next(QuantityMax - QuantityMin) + QuantityMin;
                                    spawn.Quantity = amt;
                                }

                                if (justReturn)
                                    return spawn;

                                GameLoop.ZPO.TryPlaceItem(player.NavLoc, new(spawn, inaccessible));
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
