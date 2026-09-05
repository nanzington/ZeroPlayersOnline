using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlayersOnline.DataTypes {
    public class ItemDrop {
        public string ItemID = "";
        public int DropX = 0;
        public int InY = 0;

        public int QuantityMin = 0;
        public int QuantityMax = 1;

        public bool EvenAt0x = false;

        public bool Noted = false;

        public ItemDrop(string id, int x, int y, int min, int max, bool noted = false, bool evenIf0 = false) {
            ItemID = id;
            DropX = x;
            InY = y;

            QuantityMin = min;
            QuantityMax = max;

            Noted = noted;

            EvenAt0x = evenIf0;
        }

        // Rolls 0 to InY, if less than DropX, success
        // So if DropX is 1 and InY is 10, then on a roll of 0-9, landing on a 0 is a successful drop, giving 10% chance to drop


        public void RollDrop(Player player, CollectionLogEntry? log) {
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
                        int dropRoll = GameLoop.rand.Next(InY);
                        int dropRoll2 = GameLoop.rand.Next(InY);

                        if (dropRoll < dropX || (player.PrayerActive("Good Fortune") && dropRoll2 < dropX) || (player.DropModifier == 1 && log.DryProtection(ItemID, (int) Math.Ceiling(InY / (double) dropX)))) {
                            if (!log.DropsObtained.ContainsKey(ItemID))
                                log.DropsObtained.Add(ItemID, 0);
                            log.DropsObtained[ItemID] += 1;

                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(ItemID)) {
                                Item spawn = Helper.Clone(GameLoop.ZPO.ItemLibrary[ItemID]);

                                if (QuantityMin == QuantityMax)
                                    spawn.Quantity = QuantityMin;
                                else {
                                    int amt = GameLoop.rand.Next(QuantityMax - QuantityMin) + QuantityMin;
                                    spawn.Quantity = amt;
                                }

                                GameLoop.ZPO.TryPlaceItem(player.NavLoc, spawn); 
                            }
                        }
                    } else {
                        if (log.NoRNGDrop(ItemID, InY / (int) Math.Ceiling(InY / (double) dropX))) {
                            if (!log.DropsObtained.ContainsKey(ItemID))
                                log.DropsObtained.Add(ItemID, 0);
                            log.DropsObtained[ItemID] += 1;

                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(ItemID)) {
                                Item spawn = Helper.Clone(GameLoop.ZPO.ItemLibrary[ItemID]);

                                if (QuantityMin == QuantityMax)
                                    spawn.Quantity = QuantityMin;
                                else {
                                    int amt = GameLoop.rand.Next(QuantityMax - QuantityMin) + QuantityMin;
                                    spawn.Quantity = amt;
                                }

                                GameLoop.ZPO.TryPlaceItem(player.NavLoc, spawn);
                            }
                        }
                    }
                }
            }
        }
    }
}
