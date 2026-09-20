using ZeroPlayersOnline.DataTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZeroPlayersOnline.Managers {
    public static class ItemUseLogic {
        public static int UsingSlot = -1;

        public static bool UseItem(ItemWrapper itemWrap, Player player) {
            if (itemWrap.GetRef() is Item item) { 
                if (item.UseString == "GetGold") {
                    player.HeldGold += item.UseInt;
                    GameLoop.ZPO.Log.AddMessage("You open the " + item.Name + " and find " + item.UseInt + " gold pieces.");
                } else if (item.UseString == "Bones") {
                    GameLoop.ZPO.Log.AddMessage("You bury the " + item.Name.ToLowerInvariant() + " and get " + item.UseInt + " prayer experience.");
                    player.TryGrantExp("Prayer", item.UseInt, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
                } else if (item.UseString == "Ashes") {
                    GameLoop.ZPO.Log.AddMessage("You scatter the " + item.Name.ToLowerInvariant() + " and get " + item.UseInt + " prayer experience.");
                    player.TryGrantExp("Prayer", item.UseInt, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
                } else if (item.UseString == "Heal") {
                    player.CurrentHP = Math.Clamp(player.CurrentHP + item.UseInt, player.CurrentHP, player.Skills["Constitution"].Level);
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the " + item.Name.ToLowerInvariant() + " and recover some hitpoints.", Color.Goldenrod, Color.Black));

                    if (item.Potion != null) {
                        for (int i = 0; i < item.Potion.Count; i++) {
                            player.TryAddPotionEffect(item.Potion[i].Stat, item.Potion[i].Change);
                        } 
                    }
                } else if (item.UseString == "Kebab") {
                    int num = GameLoop.rand.Next(32) + 1;
                    if (num == 1) { 
                        player.CurrentHP = Math.Clamp(player.CurrentHP + 7, player.CurrentHP, player.Skills["Constitution"].Level);
                        player.TryAddPotionEffect("Attack", 2);
                        player.TryAddPotionEffect("Strength", 2);
                        player.TryAddPotionEffect("Defense", 2);
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the kebab. Wow, that was an amazing kebab! You feel really invigorated.", Color.Lime, Color.Black));
                    } else if (num <= 9) {
                        player.CurrentHP = Math.Clamp(player.CurrentHP + 6, player.CurrentHP, player.Skills["Constitution"].Level);
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the kebab. That was a good kebab. You feel a lot better.", Color.Green, Color.Black));
                    } else if (num <= 29) {
                        player.CurrentHP = Math.Clamp(player.CurrentHP + 3, player.CurrentHP, player.Skills["Constitution"].Level);
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the kebab. It heals some health.", Color.Green, Color.Black));
                    } else if (num <= 30) {
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the kebab. That kebab didn't seem to do a lot.", Color.Yellow, Color.Black));
                    } else if (num <= 31) { 
                        string randSkill = player.Skills.Keys.ToList()[GameLoop.rand.Next(player.Skills.Count)];
                        while (randSkill == "Constitution") { 
                            randSkill = player.Skills.Keys.ToList()[GameLoop.rand.Next(player.Skills.Count)];
                        }
                        player.TryAddPotionEffect(randSkill, -3);
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the kebab. That tasted a bit dodgy. You feel a bit ill.", Color.Crimson, Color.Black));
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Eating the kebab has damaged your " + randSkill + " stat.", Color.Crimson, Color.Black));
                    } else if (num <= 32) {
                        string randSkill = player.Skills.Keys.ToList()[GameLoop.rand.Next(player.Skills.Count)];
                        while (randSkill == "Constitution") { 
                            randSkill = player.Skills.Keys.ToList()[GameLoop.rand.Next(player.Skills.Count)];
                        }
                        player.TryAddPotionEffect(randSkill, -4);
                        player.TryAddPotionEffect("Attack", -3);
                        player.TryAddPotionEffect("Strength", -3);
                        player.TryAddPotionEffect("Defense", -3);
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You eat the kebab. That tasted very dodgy. You feel very ill.", Color.Crimson, Color.Black));
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Eating the kebab has done damage to some of your stats.", Color.Crimson, Color.Black));
                    }
                } else if (item.UseString == "FillPot") {
                    if (GameLoop.ZPO.ItemLibrary.TryGetValue("plantPot", out Item? filledPot) && filledPot != null) {
                        player.TryPickup(filledPot, 1);
                    } else {
                        return false;
                    }
                } else if (item.UseString == "TeleSpawn") {
                    player.NavLoc = player.NavRespawn;
                    itemWrap.Charges -= 1;

                    if (itemWrap.Charges <= 0) { 
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Your ring of returning runs out of charge and shatters.", Color.Crimson, Color.Black));
                        return true;
                    } else {
                        return false;
                    }
                } else if (item.UseString == "TeleportMenuCost") {
                    ExtraWindows.Teleport.IsVisible = true;
                    ExtraWindows.TeleWrap = itemWrap;
                    ExtraWindows.TeleFairyRing = false;
                    ExtraWindows.TeleCostsCharges = true;
                    ExtraWindows.TeleportDests = item.TeleportLocations;
                    return false;
                } else if (item.UseString == "Compost") {
                    if (GameLoop.ZPO.Atlas.ContainsKey(player.NavLoc)) {
                        Location curr = GameLoop.ZPO.Atlas[player.NavLoc];

                        bool foundPlantSpot = false;

                        for (int i = 0; i < curr.FarmingPatchesHere.Count; i++) {
                            if (player.FarmingPatches.ContainsKey(curr.FarmingPatchesHere[i])) {
                                FarmingPatch patch = player.FarmingPatches[curr.FarmingPatchesHere[i]];

                                if (patch.SeedPlanted != "" && patch.Compost < item.UseInt) {
                                    patch.Compost = item.UseInt;
                                    foundPlantSpot = true;
                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Applied compost to a patch growing " + GameLoop.ZPO.ResolveItemName(patch.SeedPlanted) + ".", Color.Crimson, Color.Black));
                                    break;
                                }
                            }
                        }

                        if (!foundPlantSpot) {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("No patches here that need compost.", Color.Crimson, Color.Black));
                            return false;
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
                                        patch.RegrowTime = item.UseInt4;
                                        foundPlantSpot = true;
                                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You plant the " + item.Name.ToLowerInvariant() + ".", Color.Goldenrod, Color.Black));

                                        if (player.Equipment.TryGetValue("Amulet", out ItemWrapper? eqp) && eqp != null && eqp.ID == "amuletBounty" && GameLoop.rand.Next(4) == 0) {
                                            eqp.Charges -= 1; 
                                            GameLoop.ZPO.Log.AddMessage(new ColoredString("Your amulet of bounty saves you a seed!", Color.AntiqueWhite, Color.Black));

                                            if (eqp.Charges <= 0) { 
                                                GameLoop.ZPO.Log.AddMessage(new ColoredString("Your amulet of bounty runs out of charge and shatters.", Color.Crimson, Color.Black));
                                                player.Equipment.Remove("Amulet");
                                            }
                                            return false;
                                        }

                                        if (item.Name.Contains("Plant pot")) {
                                            if (GameLoop.ZPO.ItemLibrary.TryGetValue("plantPotEmpty", out Item? newPot) && newPot != null) {
                                                player.TryPickup(newPot, 1);
                                            }
                                        }
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
                    ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Map");

                    if (GameLoop.ZPO.Atlas.TryGetValue(player.NavLoc, out Location? curr)) {
                        if (curr != null) {
                            if (curr.DigItem != "") {
                                if (GameLoop.ZPO.ItemLibrary.TryGetValue(curr.DigItem, out Item? dug)) {
                                    if (dug != null) {
                                        player.TryPickup(new Item(dug), dug.Quantity);
                                    }
                                }
                            }
                        }
                    }
                } else if (item.UseString == "ClueTutorial") {
                    ClueLogic.SetOrShowStep("Tutorial", player, GameLoop.ZPO.Log);
                } else if (item.UseString == "ClueBeginner") {
                    ClueLogic.SetOrShowStep("Beginner", player, GameLoop.ZPO.Log);
                } else if (item.UseString == "ClueEasy") {
                    ClueLogic.SetOrShowStep("Easy", player, GameLoop.ZPO.Log);
                } else if (item.UseString == "ClueMedium") {
                    ClueLogic.SetOrShowStep("Medium", player, GameLoop.ZPO.Log);
                } else if (item.UseString == "ClueHard") {
                    ClueLogic.SetOrShowStep("Hard", player, GameLoop.ZPO.Log);
                } else if (item.UseString == "ClueElite") {
                    ClueLogic.SetOrShowStep("Elite", player, GameLoop.ZPO.Log);
                } else if (item.UseString == "ClueMaster") {
                    ClueLogic.SetOrShowStep("Master", player, GameLoop.ZPO.Log);
                } else if (item.UseString == "Casket") {
                    List<ItemDrop> rolledItems = new();
                    List<ItemDrop> guaranteedItems = new();
                     
                    if (!player.CollectionLogClues.ContainsKey(item.ID))
                        player.CollectionLogClues.Add(item.ID, new(item.ID)); 
                    player.CollectionLogClues[item.ID].KillCount += 1;

                    while (rolledItems.Count < 5) {
                        for (int j = 0; j < item.DropTable.Count; j++) {
                            ItemDrop drop = item.DropTable[j]; 
                            CollectionLogEntry log = player.CollectionLogClues[drop.AltLog != "" ? drop.AltLog : item.ID];

                            log.DropsObtained.TryGetValue(drop.ItemID, out int prevObtained);
                            Item? rolled = drop.RollDrop(player, log, false, true);

                            if (rolled != null) {
                                if (player.DropModifier == 1 && prevObtained == 0 && log.KillCount >= (int) Math.Ceiling(drop.InY / (double) (drop.DropX * player.DropMultiplier)) && !guaranteedItems.Contains(drop) && !rolledItems.Contains(drop)) { // Didn't have drop before, have drop now, at drop rate, probably dry protection
                                    guaranteedItems.Add(drop);
                                } else if (player.DropModifier == 2) { // If it's on No RNG Drops the drops should only ever come back not null 
                                    guaranteedItems.Add(drop);
                                } else {
                                    rolledItems.Add(drop);
                                }
                            }
                        }

                        if (player.DropModifier == 2) // No RNG Drops will never reach 5 items rolled so just break out after one check
                            break;
                    }

                    rolledItems.Shuffle();
                 
                
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You open the casket...", Color.Green, Color.Black));
                    for (int i = 0; i < 5; i++) {
                        if (i < rolledItems.Count) {
                            guaranteedItems.Remove(rolledItems[i]);
                            if (GameLoop.ZPO.ItemLibrary.TryGetValue(rolledItems[i].ItemID, out Item? rolled) && rolled != null) {
                                Item spawn = new(rolled);

                                if (rolledItems[i].QuantityMin == rolledItems[i].QuantityMax) { spawn.Quantity = rolledItems[i].QuantityMin; } 
                                else { spawn.Quantity = GameLoop.rand.Next(rolledItems[i].QuantityMax - rolledItems[i].QuantityMin) + rolledItems[i].QuantityMin; }  

                                bool newToLog = false;
                                if (rolledItems[i].AltLog == "") {
                                    player.CollectionLogClues[item.ID].DropsObtained[rolledItems[i].ItemID] += 1;
                                } else {
                                    if (player.CollectionLogClues.TryGetValue(rolledItems[i].AltLog, out CollectionLogEntry? log) && log != null) {
                                        log.DropsObtained[rolledItems[i].ItemID] += 1;
                                        if (log.DropsObtained[rolledItems[i].ItemID] == 1) { newToLog = true; }
                                    }
                                }

                                Color excitement = Color.Goldenrod;
                                if (rolledItems[i].InY >= 100) { excitement = Color.Green; }
                                if (rolledItems[i].InY >= 1000) { excitement = Color.Lime; }
                                
                                string name = (spawn.Quantity > 1 ? spawn.Quantity + "x " : "") + spawn.Name + (spawn.Quantity > 1 && spawn.Name[^1] != 's' ? "s" : "");

                                GameLoop.ZPO.Log.AddMessage(new ColoredString("The casket had " + name + " in it!" + (newToLog ? " (new!)" : ""), excitement, Color.Black));
                                player.TryPickup(spawn, spawn.Quantity); 
                            }
                        } else {
                            player.HeldGold += item.UseInt;
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("The casket had " + item.UseInt + " gold pieces in it.", Color.DarkGoldenrod, Color.Black));
                        }
                    }

                    
                    
                    if (guaranteedItems.Count > 0) {
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Due to Dry Protection it also has:", Color.Green, Color.Black));
                        for (int i = 0; i < guaranteedItems.Count; i++) { 
                           if (GameLoop.ZPO.ItemLibrary.TryGetValue(guaranteedItems[i].ItemID, out Item? rolled) && rolled != null) {
                                Item spawn = new(rolled);

                                if (guaranteedItems[i].QuantityMin == guaranteedItems[i].QuantityMax) { spawn.Quantity = guaranteedItems[i].QuantityMin; } 
                                else { spawn.Quantity = GameLoop.rand.Next(guaranteedItems[i].QuantityMax - guaranteedItems[i].QuantityMin) + guaranteedItems[i].QuantityMin; }  

                                bool newToLog = false;
                                if (guaranteedItems[i].AltLog == "") {
                                    player.CollectionLogClues[item.ID].DropsObtained[guaranteedItems[i].ItemID] += 1;
                                } else {
                                    if (player.CollectionLogClues.TryGetValue(guaranteedItems[i].AltLog, out CollectionLogEntry? log) && log != null) {
                                        log.DropsObtained[guaranteedItems[i].ItemID] += 1;
                                        if (log.DropsObtained[guaranteedItems[i].ItemID] == 1) { newToLog = true; }
                                    }
                                }

                                Color excitement = Color.Goldenrod;
                                if (guaranteedItems[i].InY >= 100) { excitement = Color.Green; }
                                if (guaranteedItems[i].InY >= 1000) { excitement = Color.Lime; }

                                string name = (spawn.Quantity > 1 ? spawn.Quantity + "x " : "") + spawn.Name + (spawn.Quantity > 1 && spawn.Name[^1] != 's' ? "s" : "");

                                GameLoop.ZPO.Log.AddMessage(new ColoredString("The casket had " + name + " in it!" + (newToLog ? " (new!)" : ""), excitement, Color.Black));
                                player.TryPickup(spawn, spawn.Quantity); 
                            }
                        }
                    }
                } else if (item.UseString == "Needle") {
                    ExtraWindows.CraftingMenu.IsVisible = true;
                    ExtraWindows.CraftingType = "Needle";
                } else if (item.UseString == "Knife") {
                    ExtraWindows.CraftingMenu.IsVisible = true;
                    ExtraWindows.CraftingType = "Knife";
                } else if (item.UseString == "Glassblowing Pipe") {
                    ExtraWindows.CraftingMenu.IsVisible = true;
                    ExtraWindows.CraftingType = "Glassblowing Pipe";
                } else if (item.UseString == "Map") {
                    ExtraWindows.Map.IsVisible = true;
                    ExtraWindows.MapViewing = item.UseString2;
                    ExtraWindows.MapW = item.UseInt;
                    ExtraWindows.MapH = item.UseInt2;
                } else if (item.UseString == "SecondExamine") {
                    GameLoop.ZPO.Log.AddMessage(new ColoredString(item.MiscString, Color.SandyBrown, Color.Black));

                    foreach (var kv in GameLoop.ZPO.QuestLibrary) {
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
                            if (item.Potion[i].Stat == "Heal") { 
                                player.CurrentHP = Math.Clamp(player.CurrentHP + item.Potion[i].Change, player.CurrentHP, player.Skills["Constitution"].Level);
                                GameLoop.ZPO.Log.AddMessage(new ColoredString("The " + item.Name.ToLowerInvariant() + " restores some hitpoints.", Color.Goldenrod, Color.Black)); 
                            } else if (item.Potion[i].Stat == "Restore") {  
                                foreach (var pot in player.ActivePotions) {
                                    if (pot.Change < 0) {
                                        pot.Change = Math.Clamp(pot.Change + item.Potion[i].Change, pot.Change, 0);
                                    }
                                }
                            } else {
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
                                    player.ActivePotions.Add(new(item.Potion[i].Stat, item.Potion[i].Change)); 

                                if (item.Potion[i].Stat == "Antipoison" && player.PoisonStatus > 0) {
                                    player.PoisonStatus = 0;
                                    GameLoop.ZPO.Log.AddMessage("The antipoison cures your poison.", Color.Lime);
                                }
                            } 
                        }

                        itemWrap.Charges--;

                        if (itemWrap.Charges > 0)
                            return false;
                        if (item.UseString3 != "" && GameLoop.ZPO.ItemLibrary.TryGetValue(item.UseString3, out Item? returned) && returned != null)
                            player.TryPickup(new Item(returned), 1);
                    }
                } else if (item.UseString == "SlayerGem") {
                    if (player.SlayerTask != "") {
                        GameLoop.ZPO.Log.AddMessage("You task is to kill " + player.SlayerKillsRemaining + " more " + GameLoop.ZPO.ResolveMonsterName(player.SlayerTask) + (player.SlayerKillsRemaining > 1 ? "s" : "") + ". (" + player.SlayerPoints + " pts, " + player.SlayerTaskStreak + " streak)", Color.MediumPurple);
                    } else {
                        GameLoop.ZPO.Log.AddMessage("You have no active task. (" + player.SlayerPoints + " pts, " + player.SlayerTaskStreak + " streak)", Color.MediumPurple);
                    }
                } else if (item.UseString == "ChargeDragonstone") {
                    foreach (var kv in player.Inventory) {
                        if (kv.ID == "amuletGlory") { kv.Charges = 4; }
                        if (kv.ID == "ringWealth") { kv.Charges = 4; }
                        if (kv.ID == "braceletCombat") { kv.Charges = 4; }
                        if (kv.ID == "necklaceSkills") { kv.Charges = 4; } 
                    }

                    foreach (var kv in player.Equipment) {
                        if (kv.Value.ID == "amuletGlory") { kv.Value.Charges = 4; }
                        if (kv.Value.ID == "ringWealth") { kv.Value.Charges = 4; }
                        if (kv.Value.ID == "braceletCombat") { kv.Value.Charges = 4; }
                        if (kv.Value.ID == "necklaceSkills") { kv.Value.Charges = 4; } 
                    }
                } else if (item.UseString == "Light") {
                    if (player.HasAllItems(["tinderbox,1"])) {
                        itemWrap.ID = item.UseString2;
                        GameLoop.ZPO.Log.AddMessage("You light the " + item.Name + ".", Color.Yellow);
                    } else { 
                        GameLoop.ZPO.Log.AddMessage("You need something to actually light that with, to light it.", Color.Crimson);
                    }
                } else if (item.UseString == "Extinguish") {
                    itemWrap.ID = item.UseString2;
                    GameLoop.ZPO.Log.AddMessage("You extinguish the " + item.Name + ".", Color.Yellow);
                } else if (item.UseString == "ViewInventory") {
                    ExtraWindows.ConWrap = itemWrap;
                    ExtraWindows.InventoryContainer.IsVisible = true;
                }

                return true;
            }
            return false;
        }

        public static bool TryCombineItems(Player player, string first, string second) {
            UsingSlot = -1;
            int i = -1;

            for(int j = 0; j < player.Inventory.Count; j++) {
                if (UsingSlot == -1 && player.Inventory[j].ID == first)
                    UsingSlot = j;
                if (UsingSlot != j && player.Inventory[j].ID == second)
                    i = j;
            } 

            if (UsingSlot != -1 && i != -1) {
                return TryCombineItems(player, i);
            }

            UsingSlot = -1;

            return false;
        }


        public static bool TryCombineItems(Player player, int i) {
            if (UsingSlot == -1 || UsingSlot >= player.Inventory.Count) {
                UsingSlot = i;
            }
            else {
                string first = player.Inventory[UsingSlot].ID;
                string second = player.Inventory[i].ID; 
                int firstSlot = UsingSlot;
                int secondSlot = i;

                if (first.Contains("potion") && second.Contains("potion") && first == second) {
                    if (player.Inventory[i].Charges + player.Inventory[UsingSlot].Charges <= 4) {
                        player.Inventory[i].Charges += player.Inventory[UsingSlot].Charges;
                        player.Inventory.RemoveAt(UsingSlot);
                        player.TryPickup(new Item(GameLoop.ZPO.ItemLibrary["vialEmpty"]), 1);
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("You combine the potions into one vial.", Color.Turquoise, Color.Black));
                    } else {
                        int diff = 4 - player.Inventory[i].Charges;
                        if (diff > 0) {
                            player.Inventory[i].Charges = 4;
                            player.Inventory[UsingSlot].Charges -= diff;
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You fill up one of the vials to the brim.", Color.Turquoise, Color.Black));
                        } else { 
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("That vial is already as full as possible.", Color.Crimson, Color.Black));
                        }
                    }

                    UsingSlot = -1;
                    return true;
                } 

                if (GameLoop.ZPO.ResolveItem(first) is Item firstPouch && GameLoop.ZPO.ResolveItem(second) is Item secondPouch) {  
                    if (secondPouch.ContainableIDs.Contains(first)) { 
                        Item swapPouch = new(firstPouch);
                        firstPouch = secondPouch;
                        secondPouch = swapPouch;

                        string swapStr = first;
                        first = second;
                        second = swapStr;

                        int swapSlot = firstSlot;
                        firstSlot = secondSlot;
                        secondSlot = swapSlot;
                    }

                    ItemWrapper firstPouchWrap = player.Inventory[firstSlot];
                    ItemWrapper secondPouchWrap = player.Inventory[secondSlot];

                    if (firstPouch.ContainableIDs.Contains(second)) {  
                        foreach (var conWrap in firstPouchWrap.Containing) {
                            if (conWrap.ID == second && conWrap.GetRef() is Item con) {
                                if (!conWrap.Noted && (con.Stackable || firstPouch.ContainerStacksUnstackable)) {
                                    conWrap.Quantity += secondPouchWrap.Quantity;
                                    player.Inventory.RemoveAt(secondSlot);
                                    return true;
                                }
                            } 
                        }

                        if (firstPouch.ContainerSlots > 0 && firstPouch.ContainerSlots > firstPouchWrap.Containing.Count) {
                            firstPouchWrap.Containing.Add(secondPouchWrap);
                            player.Inventory.RemoveAt(secondSlot);
                            return true;
                        } else { 
                            GameLoop.ZPO.Log.AddMessage("Container is too full to hold any more items.");
                        }
                    } 
                }
                
                 
                TwoWayString two = new TwoWayString(first, second);
                if (GameLoop.ZPO.UseRecipes.ContainsKey(two)) {
                    SidebarManager.LastPerformedRecipe = two;
                    Recipe rec = GameLoop.ZPO.UseRecipes[two];

                    if (rec.FirstItem == second) {
                        firstSlot = i;
                        secondSlot = UsingSlot;
                    }

                    ItemWrapper firstWrap = player.Inventory[firstSlot];
                    ItemWrapper secondWrap = player.Inventory[secondSlot];

                    Item? firstItem = firstWrap.GetRef();
                    Item? secondItem = secondWrap.GetRef();

                    if (firstItem == null || secondItem == null)
                        return false;
                     
                    UsingSlot = -1; 

                    if (!firstWrap.Noted && !secondWrap.Noted) { 
                        if (firstWrap.Quantity < rec.FirstQty) {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You need " + rec.FirstQty + " " + firstItem.Name + " to do that.", Color.Crimson, Color.Black));
                            return false;
                        }

                        if (secondWrap.Quantity < rec.SecondQty) {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You need " + rec.SecondQty + " " + secondItem.Name + " to do that.", Color.Crimson, Color.Black));
                            return false;
                        }

                        firstWrap.Quantity -= rec.FirstQty;
                        if (firstWrap.Quantity <= 0)
                            player.Inventory.Remove(firstWrap);

                        secondWrap.Quantity -= rec.SecondQty;
                        if (secondWrap.Quantity <= 0)
                            player.Inventory.Remove(secondWrap);

                        if (rec.OutputItem[0] != '_') {
                            if (GameLoop.ZPO.ItemLibrary.ContainsKey(rec.OutputItem)) {
                                Item made = new(GameLoop.ZPO.ItemLibrary[rec.OutputItem]);
                                made.Quantity = rec.OutputQty;

                                if (rec.SkillUsed == "Herblore" && made.UseInt4 > 0) {
                                    foreach (var invWrap in player.Inventory) {
                                        if (invWrap.GetRef() is Item inv) {
                                            if (inv.ID == "spiritHerb") {   
                                                GameLoop.ZPO.Log.AddMessage(new ColoredString("An herb spirit is released, and your vial fills with an extra dose of " + made.Name.ToLower() + ".", Color.Goldenrod, Color.Black));
                                                made.UseInt4 = 4;
                                                invWrap.Quantity -= 1;

                                                if (invWrap.Quantity <= 0) {
                                                    player.Inventory.Remove(invWrap);
                                                }
                                                break;
                                            }
                                        }
                                    }

                                    if (player.Equipment.TryGetValue("Amulet", out ItemWrapper? eqp) && eqp != null && eqp.ID == "amuletChemistry" && GameLoop.rand.Next(20) == 0) { 
                                        eqp.Charges -= 1; 
                                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Your amulet of chemistry allows you to get an extra dose out of your ingredients.", Color.PaleGreen, Color.Black));
                                        if (eqp.Charges <= 0) {
                                            GameLoop.ZPO.Log.AddMessage(new ColoredString("Your amulet of chemistry runs out of charge and shatters.", Color.Crimson, Color.Black));
                                            player.Equipment.Remove("Amulet");
                                        } 
                                    }
                                }

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

                        if (rec.ReturnIDs.Count > 0) {
                            for (int ret = 0; ret < rec.ReturnIDs.Count; ret++) {
                                if (GameLoop.ZPO.ItemLibrary.ContainsKey(rec.ReturnIDs[ret])) {
                                    Item made = new(GameLoop.ZPO.ItemLibrary[rec.ReturnIDs[ret]]);
                                    made.Quantity = 1;

                                    player.TryPickup(made, made.Quantity);
                                } else {
                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You get the feeling that should've resulted in " + GameLoop.ZPO.ResolveItemName(rec.ReturnIDs[ret]) + ", but that item doesn't exist.", Color.Crimson, Color.Black));
                                }
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
            if (player.Inventory[i].GetRef() is Item eqp) {
                bool canEquip = true;

                if (eqp.EquipSkill != "") {
                    if (player.Skills.ContainsKey(eqp.EquipSkill)) {
                        if (player.Skills[eqp.EquipSkill].Level < eqp.EquipLevel) {
                            GameLoop.ZPO.Log.AddMessage("You need at least " + eqp.EquipLevel + " " + eqp.EquipSkill + " to equip that.", Color.Crimson);
                            canEquip = false;
                        }
                    }
                }

                if (canEquip) {     
                    if (player.Equipment.ContainsKey(eqp.EquipSlot)) {
                        if (player.Equipment[eqp.EquipSlot].ID == player.Inventory[i].ID && eqp.Stackable) {
                            player.Equipment[eqp.EquipSlot].Quantity += player.Inventory[i].Quantity; 
                            player.Inventory.RemoveAt(i);
                            return true;
                        } else {
                            ItemWrapper unequip = player.Equipment[eqp.EquipSlot];
                            player.TryPickup(unequip, unequip.Quantity);
                            player.Equipment.Remove(eqp.EquipSlot); 
                        }
                    }

                    if (eqp.EquipSlot == "Weapon" && eqp.TwoHanded && player.Equipment.ContainsKey("Offhand")) {
                        ItemWrapper offhand = player.Equipment["Offhand"];
                        player.TryPickup(offhand, offhand.Quantity);
                        player.Equipment.Remove("Offhand");
                    }

                    if (eqp.EquipSlot == "Offhand" && player.Equipment.TryGetValue("Weapon", out ItemWrapper? wrap) && wrap.GetRef() is Item item && item.TwoHanded) {
                        ItemWrapper unequip = player.Equipment["Weapon"];
                        player.TryPickup(unequip, unequip.Quantity);
                        player.Equipment.Remove("Weapon");
                    }
                    
                    player.Inventory.RemoveAt(i);
                    player.Equipment.Add(eqp.EquipSlot, new(eqp)); 

                    return true;
                }

                return false;
            }
            return false;
        } 
    }
}
