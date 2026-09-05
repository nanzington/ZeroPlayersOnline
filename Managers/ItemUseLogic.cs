using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Managers {
    public static class ItemUseLogic {
        public static int UsingSlot = -1;

        public static bool UseItem(Item item, Player player) {
            if (item.UseString == "GetGold") {
                player.HeldGold += item.UseInt;
                GameLoop.ZPO.Log.AddMessage("You open the " + item.Name + " and find " + item.UseInt + " gold pieces.");
            } else if (item.UseString == "Bones") {
                GameLoop.ZPO.Log.AddMessage("You bury the " + item.Name.ToLowerInvariant() + " and get " + item.UseInt + " prayer experience.");
                player.TryGrantExp("Prayer", 5, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
            } else if (item.UseString == "Heal") {
                player.CurrentHP = Math.Clamp(player.CurrentHP + item.UseInt, player.CurrentHP, player.Skills["Constitution"].Level);
                GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the " + item.Name.ToLowerInvariant() + " and recover some hitpoints.", Color.Goldenrod, Color.Black));

                if (item.Potion != null) {
                    for (int i = 0; i < item.Potion.Count; i++) {
                        bool found = false;
                        for (int j = 0; j < player.ActivePotions.Count; j++) {
                            if (player.ActivePotions[j].Stat == item.Potion[i].Stat) {
                                if (player.ActivePotions[j].Change < 0) {
                                    player.ActivePotions[j].Change += item.Potion[i].Change;
                                    found = true;
                                } else {
                                    if (player.ActivePotions[j].Change < item.Potion[i].Change) {
                                        player.ActivePotions[j].Change = item.Potion[i].Change;
                                        found = true;
                                    }
                                }
                            }
                        }
                        if (!found)
                            player.ActivePotions.Add(Helper.Clone(item.Potion[i]));
                    } 
                }
            } else if (item.UseString == "PlantSeed") {
                if (GameLoop.ZPO.Atlas.ContainsKey(player.NavLoc)) {
                    Location curr = GameLoop.ZPO.Atlas[player.NavLoc];

                    bool foundPlantSpot = false;

                    for (int i = 0; i < curr.FarmingPatchesHere.Count; i++) {
                        if (player.FarmingPatches.ContainsKey(curr.FarmingPatchesHere[i])) {
                            FarmingPatch patch = player.FarmingPatches[curr.FarmingPatchesHere[i]];

                            if (patch.PatchType == item.UseString2 && patch.SeedPlanted == "") {
                                if (player.Skills["Farming"].Level >= item.UseInt) {
                                    patch.SeedPlanted = item.ID;
                                    patch.TimeLeft = item.UseInt3;
                                    foundPlantSpot = true;
                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You plant the " + item.Name.ToLowerInvariant() + ".", Color.Goldenrod, Color.Black));
                                } else {
                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You need " + item.UseInt + " Farming to plant that.", Color.Crimson, Color.Black));
                                    return false;
                                }
                                break;
                            }
                        }
                    }
                    
                    if (!foundPlantSpot) {
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("No " + item.UseString2.ToLowerInvariant() + " patches here to plant that.", Color.Crimson, Color.Black));
                        return false;
                    }
                } else {
                    return false;
                }
            } else if (item.UseString == "Dig") {
                ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Dig");

                if (GameLoop.ZPO.Atlas.TryGetValue(player.NavLoc, out Location? curr)) {
                    if (curr != null) {
                        if (curr.DigItem != "") {
                            if (GameLoop.ZPO.ItemLibrary.TryGetValue(curr.DigItem, out Item? dug)) {
                                if (dug != null) {
                                    player.TryPickup(Helper.Clone(dug), dug.Quantity);
                                }
                            }
                        }
                    }
                }
            } else if (item.UseString == "ClueTutorial") {
                ClueLogic.SetOrShowStep("Tutorial", player, GameLoop.ZPO.Log);
            } else if (item.UseString == "Casket") {
                List<Item> rolledItems = new();
                List<Item> guaranteedItems = new();

                if (!player.CollectionLogClues.ContainsKey(item.ID))
                    player.CollectionLogClues.Add(item.ID, new(item.ID)); 
                player.CollectionLogClues[item.ID].KillCount += 1;

                for (int j = 0; j < item.DropTable.Count; j++) {
                    ItemDrop drop = item.DropTable[j]; 
                    if (player.DropModifier != 2 && player.DropMultiplier != 0) {
                        if (GameLoop.rand.Next(drop.InY) < (drop.DropX * player.DropMultiplier) || (player.PrayerActive("Good Fortune") && GameLoop.rand.Next(drop.InY) < (drop.DropX * player.DropMultiplier)) || (player.DropModifier == 1 && player.CollectionLogClues[item.ID].DryProtection(drop.ItemID, (int) Math.Ceiling(drop.InY / (double) (drop.DropX * player.DropMultiplier))))) {
                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(drop.ItemID)) {
                                Item spawn = Helper.Clone(GameLoop.ZPO.ItemLibrary[drop.ItemID]);

                                if (drop.QuantityMin == drop.QuantityMax)
                                    spawn.Quantity = drop.QuantityMin;
                                else {
                                    int amt = GameLoop.rand.Next(drop.QuantityMax - drop.QuantityMin) + drop.QuantityMin;
                                    spawn.Quantity = amt;
                                } 

                                if (player.CollectionLogClues[item.ID].DryProtection(drop.ItemID, (int) Math.Ceiling(drop.InY / (double) (drop.DropX * player.DropMultiplier)))) {
                                    GameLoop.ZPO.Log.AddMessage("Due to Dry Protection you receive " + spawn.Name + ".", Color.Lime);
                                    guaranteedItems.Add(spawn);
                                } else {
                                    rolledItems.Add(spawn);
                                }
                            }

                            if (!player.CollectionLogClues[item.ID].DropsObtained.ContainsKey(drop.ItemID))
                                player.CollectionLogClues[item.ID].DropsObtained.Add(drop.ItemID, 0); 
                        }
                    }

                    if (player.DropModifier == 2) {
                        if (player.CollectionLogClues[item.ID].NoRNGDrop(drop.ItemID, (int) Math.Ceiling(drop.InY / (double) (drop.DropX * player.DropMultiplier)))) {
                            if (!player.CollectionLogClues[item.ID].DropsObtained.ContainsKey(drop.ItemID))
                                player.CollectionLogClues[item.ID].DropsObtained.Add(drop.ItemID, 0);

                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(drop.ItemID)) {
                                Item spawn = Helper.Clone(GameLoop.ZPO.ItemLibrary[drop.ItemID]);

                                if (drop.QuantityMin == drop.QuantityMax)
                                    spawn.Quantity = drop.QuantityMin;
                                else {
                                    int amt = GameLoop.rand.Next(drop.QuantityMax - drop.QuantityMin) + drop.QuantityMin;
                                    spawn.Quantity = amt;
                                }

                                guaranteedItems.Add(spawn);
                            }
                        }
                    }
                }

                rolledItems.Shuffle();
                 
                
                GameLoop.ZPO.Log.AddMessage(new ColoredString("You open the casket...", Color.Green, Color.Black));
                for (int i = 0; i < 5; i++) {
                    if (i < rolledItems.Count) {
                        player.CollectionLogClues[item.ID].DropsObtained[rolledItems[i].ID] += 1;

                        int odds = 1;
                        for (int j = 0; j < item.DropTable.Count; j++) {
                            if (item.DropTable[j].ItemID == rolledItems[i].ID) {
                                odds = item.DropTable[j].InY;
                                break;
                            }
                        }

                        Color excitement = Color.Goldenrod;
                        if (odds >= 10) {
                            excitement = Color.LightGoldenrodYellow;
                        }

                        string name = rolledItems[i].Name;

                        if (rolledItems[i].Quantity > 1)
                            name = rolledItems[i].Quantity + " " + name + "s";

                        GameLoop.ZPO.Log.AddMessage(new ColoredString("The casket had " + name + " in it!", excitement, Color.Black));
                        player.TryPickup(rolledItems[i], rolledItems[i].Quantity);
                    } else {
                        player.HeldGold += item.UseInt;
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("The casket had " + item.UseInt + " gold pieces in it.", Color.DarkGoldenrod, Color.Black));
                    }
                }
                
                for (int i = 0; i < guaranteedItems.Count; i++) { 
                    player.CollectionLogClues[item.ID].DropsObtained[guaranteedItems[i].ID] += 1;

                    int odds = 1;
                    for (int j = 0; j < item.DropTable.Count; j++) {
                        if (item.DropTable[j].ItemID == guaranteedItems[i].ID) {
                            odds = item.DropTable[j].InY;
                            break;
                        }
                    }

                    Color excitement = Color.Goldenrod;
                    if (odds >= 10) {
                        excitement = Color.LightGoldenrodYellow;
                    }

                    string name = guaranteedItems[i].Name;

                    if (guaranteedItems[i].Quantity > 1)
                        name = guaranteedItems[i].Quantity + " " + name + "s";

                    GameLoop.ZPO.Log.AddMessage(new ColoredString("The casket had " + name + " in it!", excitement, Color.Black));
                    player.TryPickup(guaranteedItems[i], guaranteedItems[i].Quantity);
                } 
            } else if (item.UseString == "Needle") {
                GameLoop.ZPO.CraftingMenu.IsVisible = true;
                GameLoop.ZPO.CraftingType = "Needle";
            } else if (item.UseString == "Knife") {
                GameLoop.ZPO.CraftingMenu.IsVisible = true;
                GameLoop.ZPO.CraftingType = "Knife";
            } else if (item.UseString == "SecondExamine") {
                GameLoop.ZPO.Log.AddMessage(new ColoredString(item.MiscString, Color.SandyBrown, Color.Black));

                foreach (var kv in player.QuestLog) {
                    kv.Value.CheckProgress(player, "ExamineItem", item.ID, 0);
                }
            } else if (item.UseString == "CleanHerb") {
                if (player.Skills.TryGetValue("Herblore", out Skill? herb) && herb != null) {
                    if (herb.Level >= item.UseInt) {
                        if (GameLoop.ZPO.ItemLibrary.TryGetValue(item.UseString2, out Item? spawn) && spawn != null) {
                            player.TryPickup(spawn, 1);
                            player.TryGrantExp("Herblore", item.UseInt2, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
                        } else {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString(item.UseString2 + " does not currently exist, herb preserved.", Color.Crimson, Color.Black));
                            return false;
                        }
                    } else { 
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You need " + item.UseInt + " Herblore to clean that. (Have " + herb.Level + ")", Color.Crimson, Color.Black));
                        return false;
                    }
                } else {
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Malformed skill list, could not find Herblore entry.", Color.Crimson, Color.Black));
                    return false;
                }
            } else if (item.UseString == "Potion") {
                if (item.Potion != null) {
                    for (int i = 0; i < item.Potion.Count; i++) {
                        bool found = false;
                        for (int j = 0; j < player.ActivePotions.Count; j++) {
                            if (player.ActivePotions[j].Stat == item.Potion[i].Stat) {
                                if (player.ActivePotions[j].Change < 0) {
                                    player.ActivePotions[j].Change += item.Potion[i].Change;
                                    found = true;
                                } else {
                                    if (player.ActivePotions[j].Change < item.Potion[i].Change) {
                                        player.ActivePotions[j].Change = item.Potion[i].Change;
                                        found = true;
                                    } else {
                                        return false;
                                    }
                                }
                            }
                        }
                        if (!found)
                            player.ActivePotions.Add(Helper.Clone(item.Potion[i]));
                    }

                    item.UseInt4--;

                    if (item.UseInt4 > 0)
                        return false;
                }
            } else if (item.UseString == "SlayerGem") {
                if (player.SlayerTask != "") {
                    GameLoop.ZPO.Log.AddMessage("You task is to kill " + player.SlayerKillsRemaining + " more " + GameLoop.ZPO.ResolveMonsterName(player.SlayerTask) + (player.SlayerKillsRemaining > 1 ? "s" : "") + ". (" + player.SlayerPoints + " pts, " + player.SlayerTaskStreak + " streak)", Color.MediumPurple);
                } else {
                    GameLoop.ZPO.Log.AddMessage("You have no active task. (" + player.SlayerPoints + " pts, " + player.SlayerTaskStreak + " streak)", Color.MediumPurple);
                }
            }

            return true;
        }


        public static bool TryCombineItems(Player player, int i) {
            if (UsingSlot == -1) {
                UsingSlot = i;
            }
            else {
                string first = player.Inventory[UsingSlot].ID;
                string second = player.Inventory[i].ID;

                if (GameLoop.ZPO.UseRecipes.ContainsKey(new TwoWayString(first, second))) {
                    Recipe rec = GameLoop.ZPO.UseRecipes[new TwoWayString(first, second)];
                    int firstSlot = UsingSlot;
                    int secondSlot = i;

                    if (rec.FirstItem == second) {
                        firstSlot = i;
                        secondSlot = UsingSlot;
                    }

                    Item firstItem = player.Inventory[firstSlot];
                    Item secondItem = player.Inventory[secondSlot];
                     
                    UsingSlot = -1; 

                    if (!firstItem.Noted && !secondItem.Noted) { 
                        if (firstItem.Quantity < rec.FirstQty) {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You need " + rec.FirstQty + " " + firstItem.Name + " to do that.", Color.Crimson, Color.Black));
                            return false;
                        }

                        if (secondItem.Quantity < rec.SecondQty) {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You need " + rec.SecondQty + " " + secondItem.Name + " to do that.", Color.Crimson, Color.Black));
                            return false;
                        }

                        firstItem.Quantity -= rec.FirstQty;
                        if (firstItem.Quantity <= 0)
                            player.Inventory.Remove(firstItem);

                        secondItem.Quantity -= rec.SecondQty;
                        if (secondItem.Quantity <= 0)
                            player.Inventory.Remove(secondItem);

                        if (rec.OutputItem[0] != '_') {
                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(rec.OutputItem)) {
                                Item made = Helper.Clone(GameLoop.ZPO.ItemLibrary[rec.OutputItem]);
                                made.Quantity = rec.OutputQty;

                                player.TryPickup(made, made.Quantity);
                            } else {
                                GameLoop.ZPO.Log.AddMessage(new ColoredString("You get the feeling that should've resulted in " + rec.OutputItem + ", but that item doesn't exist.", Color.Crimson, Color.Black));
                            }
                        } else {
                            if (rec.OutputItem == "_fire") {
                                if (GameLoop.ZPO.Atlas.ContainsKey(player.NavLoc) && GameLoop.ZPO.ProcessingStations.ContainsKey("Range")) {
                                    Location curr = GameLoop.ZPO.Atlas[player.NavLoc];
                                                     
                                    ProcessingStation fire = Helper.Clone(GameLoop.ZPO.ProcessingStations["Range"]);
                                    fire.Name = "Fire";
                                    fire.TimeLeft = rec.OutputQty;
                                    fire.TimeMade = Helper.Time();
                                    fire.ItemOnExpire = rec.MiscString;
                                                     
                                    curr.TempStations.Add(fire);
                                }
                                                
                                GameLoop.ZPO.Log.AddMessage(new ColoredString("You start a fire with the " + secondItem.Name + ".", Color.OrangeRed, Color.Black));
                            }
                        }

                        player.TryGrantExp(rec.SkillUsed, rec.ExpGranted, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);

                        return true;
                    }
                }
                else {
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Those two items don't combine like that.", Color.Crimson, Color.Black));
                    UsingSlot = -1;
                }
            }

            return false;
        }

        public static bool TryEquipItem(Player player, int i) {
            Item item = player.Inventory[i];

            bool canEquip = true;

            if (item.EquipSkill != "") {
                if (player.Skills.ContainsKey(item.EquipSkill)) {
                    if (player.Skills[item.EquipSkill].Level < item.EquipLevel) {
                        canEquip = false;
                    }
                }
            }

            if (canEquip) {
                player.Inventory.RemoveAt(i);

                                        
                if (player.Equipment.ContainsKey(item.EquipSlot)) {
                    if (player.Equipment[item.EquipSlot].ID == item.ID && item.Stackable) {
                        player.Equipment[item.EquipSlot].Quantity += item.Quantity; 
                        return true;
                    } else {
                        Item unequip = player.Equipment[item.EquipSlot];
                        player.TryPickup(unequip, unequip.Quantity);
                        player.Equipment.Remove(item.EquipSlot);

                        if (item.EquipSlot == "Weapon" && item.TwoHanded && player.Equipment.ContainsKey("Offhand")) {
                            Item offhand = player.Equipment["Offhand"];
                            player.TryPickup(offhand, offhand.Quantity);
                            player.Equipment.Remove("Offhand");
                        }
                    }
                }

                player.Equipment.Add(item.EquipSlot, item);

                return true;
            }

            return false;
        } 
    }
}
