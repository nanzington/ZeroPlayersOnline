using SadConsole.Input;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.UI;

namespace ZeroPlayersOnline.Managers {  
    public static class SidebarManager {
        public static string SidebarMenu = "Inventory"; 
        public static int SwapSlot = -1;
        public static List<Skill> RecentlyTrainedSkills = new();
        
        public static double LastHealedTick = 0; 
        public static double LastPoisonTick = 0; 
        public static int SidebarScrollTop = 0;
        public static Rectangle SidebarRect = new Rectangle(new Point(0, 15), new Point(54, 34));
        
        public static string QuestSort = "A->Z"; 
        public static string MagicTab = "Combat"; 

        public static TwoWayString LastFoundRecipe = null;
        public static TwoWayString LastPerformedRecipe = null;

        public static void Draw(UI_EmbeddedMini mini, Player player) {
            Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;

            mini.Con.DrawLine(new Point(55, 0), new Point(55, 34), 179);
             
            
            if ((player.PrayerActive("Rapid Heal") && LastHealedTick + 1500 < Helper.Time()) || (LastHealedTick + 3000 < Helper.Time())) {
                if (player.Equipment.TryGetValue("Hands", out ItemWrapper? eqp) && eqp != null && eqp.ID == "braceletRegen") {
                    player.CurrentHP = Math.Clamp(player.CurrentHP + 1, 0, player.Skills["Constitution"].Level);
                }
                player.CurrentHP = Math.Clamp(player.CurrentHP + 1, 0, player.Skills["Constitution"].Level);
                LastHealedTick = Helper.Time();
            }

            if (player.PoisonStatus > 0) {
                if (LastPoisonTick + 15000 < Helper.Time()) {
                    LastPoisonTick = Helper.Time();

                    int poisonDamage = Math.Max(1, (int) Math.Floor((player.PoisonStatus + 4) / 5.0));
                    GameLoop.ZPO.Log.AddMessage("You take " + poisonDamage + " damage from poison.", Color.Lime);
                    player.TakeDamage(poisonDamage, GameLoop.ZPO.Log);

                    player.PoisonStatus -= 1;
                    if (player.PoisonStatus == 0) {
                        GameLoop.ZPO.Log.AddMessage("You are no longer poisoned.", Color.Lime);
                    }
                }
            }


            mini.Con.Print(0, 0, "    HP: " + player.CurrentHP.ToString().Align(HorizontalAlignment.Right, 4, ' ') + " / " + player.Skills["Constitution"].Level.ToString().Align(HorizontalAlignment.Right, 4, ' '), Color.Crimson);
            mini.Con.Print(0, 1, "Prayer: " + player.TotalActivePrayers().ToString().Align(HorizontalAlignment.Right, 4, ' ') + " / " + player.GetEffectiveSkillLevel("Prayer").ToString().Align(HorizontalAlignment.Right, 4, ' '), Color.DodgerBlue);

            mini.Con.Print(0, 3, " Level: " + player.GetCombatLevel(), Color.Yellow); 

            bool magic = player.IsMaging();

            string dmgType = player.GetDamageType();
            if (dmgType.Length > 7)
                dmgType = dmgType.Substring(0, 7);

            mini.Con.Print(0, 4, "Damage: " + player.GetDamageDice() + " " + dmgType, Color.Yellow); 
            mini.Con.Print(0, 5, "vMelee: " + player.TotalArmorValue("Melee"), Color.Yellow);
            mini.Con.Print(0, 6, "vMagic: " + player.TotalArmorValue("Magic"), Color.Yellow);
            mini.Con.Print(0, 7, "vRange: " + player.TotalArmorValue("Ranged"), Color.Yellow);

            if (player.CastingSpell != "") {
                if (GameLoop.ZPO.SpellLibrary.ContainsKey(player.CastingSpell)) {
                    if (player.CanCast(GameLoop.ZPO.SpellLibrary[player.CastingSpell]) != "") {
                        player.CastingSpell = ""; 
                    }
                }
            }

            if (player.CastingSpell != "") {
                if (GameLoop.ZPO.SpellLibrary.ContainsKey(player.CastingSpell)) { 
                    mini.Con.PrintClickable(0, 9, new ColoredString("*" + GameLoop.ZPO.SpellLibrary[player.CastingSpell].Name.Align(HorizontalAlignment.Center, 18) + "*", Color.SkyBlue, Color.Black), () => { player.CastingSpell = ""; });
                }
            }


            mini.Con.Print(0, 11, ("Gold: " + String.Format($"{player.HeldGold:n0}")).Align(HorizontalAlignment.Right, 19), Color.Goldenrod);


            mini.Con.DrawLine(new Point(20, 0), new Point(20, 11), 179);
            mini.Con.Print(21, 0, "Recently Trained Skills");
            mini.Con.Print(21, 1, "Skill Name        Lv      To Next", Color.SlateGray);
            if (RecentlyTrainedSkills.Count > 0) {
                for (int i = 0; i < RecentlyTrainedSkills.Count; i++) {
                    int toNext = RecentlyTrainedSkills[i].EXPNeeded();
                    mini.Con.Print(21, 2 + i, "| " + RecentlyTrainedSkills[i].Name);
                    mini.Con.Print(38, 2 + i, RecentlyTrainedSkills[i].Level.ToString().PadLeft(3));
                    mini.Con.Print(47, 2 + i, toNext.ToString().PadLeft(7));
                }
            }

            if (GameLoop.ZPO.Atlas.ContainsKey(player.NavLoc)) {
                Location curr = GameLoop.ZPO.Atlas[player.NavLoc];


                if (curr.ItemSpawns.Count > 0) {  
                    for (int i = 0; i < curr.ItemSpawns.Count; i++) {  
                        if (curr.ItemSpawns[i].LastPickedUp + (curr.ItemSpawns[i].RespawnTimer * 1000) < Helper.Time() || curr.ItemSpawns[i].LastPickedUp == 0) { 
                            int spawnedCount = 0;

                            if (curr.ItemSpawns[i].ReqToSpawn != null && !curr.ItemSpawns[i].ReqToSpawn.CheckRequirement(player, true, true)) {
                                continue;
                            } 
                             
                            for (int j = 0; j < curr.ItemsHere.Count; j++) {
                                if (player.RandomItems == 0) {
                                    if (curr.ItemsHere[j].ID == curr.ItemSpawns[i].ItemID) {
                                        spawnedCount += curr.ItemsHere[j].Quantity;
                                    }
                                } else {
                                    if (GameLoop.ZPO.ItemLibrary.ContainsKey(curr.ItemSpawns[i].ItemID)) {
                                        if (curr.ItemsHere[j].ID == GameLoop.ZPO.ItemLibrary[curr.ItemSpawns[i].ItemID].ID) { 
                                            spawnedCount += curr.ItemsHere[j].Quantity;
                                        }
                                    }
                                }
                            }

                            if (spawnedCount < curr.ItemSpawns[i].SpawnCount) {
                                if (GameLoop.ZPO.ItemLibrary.ContainsKey(curr.ItemSpawns[i].ItemID)) {
                                    Item spawn = new(GameLoop.ZPO.ItemLibrary[curr.ItemSpawns[i].ItemID]);
                                    GameLoop.ZPO.TryPlaceItem(curr.ID, new(spawn));
                                    curr.ItemSpawns[i].LastPickedUp = Helper.Time();
                                }
                            }
                        }
                    }
                }




                mini.Con.DrawLine(new Point(0, 12), new Point(54, 12), 196);
                int hx = 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("INV", SidebarMenu == "Inventory" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Inventory"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|"); 
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("EQP", SidebarMenu == "Equipment" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Equipment"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|");
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("SKL", SidebarMenu == "Skills" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Skills"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|");
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("MAG", SidebarMenu == "Magic" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Magic"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|");
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("PRA", SidebarMenu == "Prayer" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Prayer"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|");
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("EMO", SidebarMenu == "Emote" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Emote"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|");
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("QST", SidebarMenu == "Quest" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Quest"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|");
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("LOG", SidebarMenu == "Log" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Log"; });
                hx = hx + 4;
                mini.Con.Print(hx, 13, "|");
                hx = hx + 2;
                mini.Con.PrintClickable(hx, 13, new ColoredString("POT", SidebarMenu == "Potions" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Potions"; });


                mini.Con.DrawLine(new Point(0, 14), new Point(54, 14), 196);

                if (SidebarMenu == "Inventory") {

                    for (int i = 0; i < player.InventoryLimit; i++) {
                        mini.Con.DrawLine(new Point(0, 15 + i), new Point(54, 15 + i), '-', Color.DarkSlateGray);

                        if (i < player.Inventory.Count && player.Inventory[i].GetRef() is Item inv) {
                            int shop = curr.ShopItemsHere.Contains(player.Inventory[i].ID) ? 2 : curr.ShopItemsHere.Count > 0 ? 1 : 0;
                            ColoredString name = inv.GetNameCS(player.Inventory[i].Quantity, shop, player.Inventory[i].Charges, player.Inventory[i].Noted);

                            mini.Con.Print(0, 15 + i, (mousePos.X < 55 && mousePos.Y == 15 + i) ? name.GetDarker() : name);

                            bool dropped = false; 

                            int px = 52;
                            
                            mini.Con.PrintClickable(54, 15 + i, new ColoredString("X", Color.Crimson, Color.Black), () => { dropped = player.TryDrop(i); });

                            if (dropped)
                                break;

                             if (GameLoop.ZPO.SpellLibrary.TryGetValue("utilAlchemyHigh", out Spell? highAlch) && highAlch != null) { 
                                if (player.CanCast(highAlch) == "") {
                                    mini.Con.PrintClickable(px, 15 + i, new ColoredString(247.AsString() + " ", Color.Lime, Color.Black), () => {
                                        if (player.Inventory[i].GetRef() is Item alched) {
                                            if (alched.HighAlchVal() > 0) {  
                                                player.Inventory[i].Quantity -= 1; 
                                                if (!player.Inventory[i].ID.Contains("mtaAlch")) {
                                                    highAlch.Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);  
                                                    player.HeldGold += alched.HighAlchVal();
                                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You cast High Alchemy and convert the " + alched.Name + " into " + alched.HighAlchVal() + " gold.", Color.Goldenrod, Color.Black));
                                                } else {
                                                    int val = 1;
                                                    if (MinigameManager.MTA_Alchs[1] == alched.ID) { val = 5; }
                                                    if (MinigameManager.MTA_Alchs[2] == alched.ID) { val = 8; }
                                                    if (MinigameManager.MTA_Alchs[3] == alched.ID) { val = 15; }
                                                    if (MinigameManager.MTA_Alchs[4] == alched.ID) { val = 30; }

                                                    if (alched.ID != MinigameManager.MTA_Alchs[MinigameManager.MTA_FreeAlch]) { 
                                                        highAlch.Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);  
                                                    } else {
                                                        player.TryGrantExp("Magic", highAlch.ExpOnCast, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                    }
                                                    
                                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You cast High Alchemy and convert the " + alched.Name + " into " + val + " coins.", Color.DarkGoldenrod, Color.Black));

                                                    if (GameLoop.ZPO.ItemLibrary.TryGetValue("mtaAlchCoin", out Item? coin) && coin != null) {
                                                        player.TryPickup(new Item(coin), val);
                                                    }
                                                }
                                            }
                                        }
                                    }); 
                                    px -= 2;

                                    if (player.Inventory[i].Quantity <= 0) {
                                        player.Inventory.RemoveAt(i);
                                        dropped = true;
                                    }
                                }
                            }

                            if (dropped)
                                break;

                            if (GameLoop.ZPO.SpellLibrary.TryGetValue("utilAlchemyLow", out Spell? lowAlch) && lowAlch != null) { 
                                if (player.CanCast(lowAlch) == "") {
                                    mini.Con.PrintClickable(px, 15 + i, new ColoredString("~ ", Color.Green, Color.Black), () => {
                                        if (player.Inventory[i].GetRef() is Item alched) {
                                            if (alched.LowAlchVal() > 0) {  
                                                player.Inventory[i].Quantity -= 1;

                                                if (!alched.ID.Contains("mtaAlch")) {
                                                    lowAlch.Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);  
                                                    player.HeldGold += alched.LowAlchVal();
                                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You cast Low Alchemy and convert the " + alched.Name + " into " + alched.LowAlchVal() + " gold.", Color.DarkGoldenrod, Color.Black));
                                                } else {
                                                    int val = 1;
                                                    if (MinigameManager.MTA_Alchs[1] == alched.ID) { val = 5; }
                                                    if (MinigameManager.MTA_Alchs[2] == alched.ID) { val = 8; }
                                                    if (MinigameManager.MTA_Alchs[3] == alched.ID) { val = 15; }
                                                    if (MinigameManager.MTA_Alchs[4] == alched.ID) { val = 30; }

                                                    if (alched.ID != MinigameManager.MTA_Alchs[MinigameManager.MTA_FreeAlch]) { 
                                                        lowAlch.Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);  
                                                    } else {
                                                        player.TryGrantExp("Magic", lowAlch.ExpOnCast, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                    }

                                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("You cast Low Alchemy and convert the " + alched.Name + " into " + val + " coins.", Color.DarkGoldenrod, Color.Black));

                                                    if (GameLoop.ZPO.ItemLibrary.TryGetValue("mtaAlchCoin", out Item? coin) && coin != null) {
                                                        player.TryPickup(new Item(coin), val);
                                                    }
                                                }
                                            }
                                        }
                                    }); 
                                    px -= 2;

                                    if (player.Inventory[i].Quantity <= 0) {
                                        player.Inventory.RemoveAt(i);
                                        dropped = true;
                                    }
                                }
                            } 

                            if (dropped)
                                break;

                            mini.Con.PrintClickable(px, 15 + i, new ColoredString("? ", Color.MediumPurple, Color.Black), () => { 
                                if (player.Inventory[i].Containing.Count == 0) {
                                    GameLoop.ZPO.Log.AddMessage(new ColoredString(inv.ExamineText, Color.SandyBrown, Color.Black)); 
                                } else {
                                    string build = inv.Name + ": ";

                                    for (int con = 0; con < player.Inventory[i].Containing.Count; con++) {
                                        build += (con != 0 ? ", " : "") + (player.Inventory[i].Containing[con].Quantity > 1 ? player.Inventory[i].Containing[con].Quantity + "x " : " ") + GameLoop.ZPO.ResolveItemName(player.Inventory[i].Containing[con].ID);
                                    } 

                                    GameLoop.ZPO.Log.AddMessage(build, Color.SandyBrown); 
                                }

                                foreach (var kv in GameLoop.ZPO.QuestLibrary) {
                                    kv.Value.CheckProgress(player, "ExamineItem", player.Inventory[i].ID, 0);
                                }
                            });

                            px -= 2;

                            mini.Con.PrintClickable(px, 15 + i, new ColoredString("> ", Color.Turquoise, Color.Black), () => {
                                if (SwapSlot == -1) {
                                    SwapSlot = i;
                                }
                                else { 
                                    ItemWrapper first = new(player.Inventory[SwapSlot]);
                                    player.Inventory[SwapSlot] = new(player.Inventory[i]);
                                    player.Inventory[i] = first;
                                    SwapSlot = -1;
                                }
                            });

                            px -= 2;

                            if (!player.Inventory[i].Noted) {
                                mini.Con.PrintClickable(px, 15 + i, new ColoredString("U ", ItemUseLogic.UsingSlot == i ? Color.Green : Color.Yellow, Color.Black), () => {
                                    if (ItemUseLogic.UsingSlot != i && ItemUseLogic.TryCombineItems(player, i)) {
                                        dropped = true;
                                    }
                                });
                            } else { 
                                mini.Con.Print(50, 15 + i, "  ");
                            }
                            px -= 2;
                            if (dropped)
                                break;

                            if (inv.UseString != "") {
                                if (!player.Inventory[i].Noted) { 
                                    mini.Con.PrintClickable(px, 15 + i, new ColoredString("* ", Color.Yellow, Color.Black), () => { 
                                        bool success = ItemUseLogic.UseItem(player.Inventory[i], player);

                                        if (inv.ConsumedOnUse && success) {
                                            if (player.PrayerActive("Cornucopia")) {
                                                if (GameLoop.rand.Next(5) != 0) { 
                                                    player.Inventory[i].Quantity -= 1;
                                                } else { 
                                                    GameLoop.ZPO.Log.AddMessage(new ColoredString("The blessing of the cornucopia preserves your item.", Color.Goldenrod, Color.Black));
                                                }
                                            } else {
                                                player.Inventory[i].Quantity -= 1;
                                            }
                                        }

                                        if (player.Inventory[i].Quantity <= 0) {
                                            player.Inventory.RemoveAt(i);
                                            dropped = true;
                                        }
                                    });
                                    px -= 2;
                                }
                            }

                            if (dropped)
                                break;

                            if (inv.EquipSlot != "" && !player.Inventory[i].Noted) {
                                mini.Con.PrintClickable(px, 15 + i, new ColoredString("E ", Color.Yellow, Color.Black), () => { dropped = ItemUseLogic.TryEquipItem(player, i); });
                                px -= 2;
                            } 

                            if (dropped)
                                break;
                        }
                    }
                }

                else if (SidebarMenu == "Equipment") {
                    mini.Con.Print(36, 32, " Combat EXP Split");
                    mini.Con.PrintClickable(39, 33, "ATK " + player.OffenseExpSplit, () => {
                        player.OffenseExpSplit = Math.Clamp(player.OffenseExpSplit + 1, 0, 4);
                    });

                    mini.Con.Print(45, 33, ":");

                    mini.Con.PrintClickable(47, 33, 4 - player.OffenseExpSplit + " STR", () => {
                        player.OffenseExpSplit = Math.Clamp(player.OffenseExpSplit - 1, 0, 4);
                    });

                    

                    mini.Con.PrintClickable(39, 34, "DEF " + player.DefenseExpSplit, () => {
                        player.DefenseExpSplit = Math.Clamp(player.DefenseExpSplit + 1, 0, 4);
                    });

                    mini.Con.Print(45, 34, ":");

                    mini.Con.PrintClickable(47, 34, 4 - player.DefenseExpSplit + " CON", () => {
                        player.DefenseExpSplit = Math.Clamp(player.DefenseExpSplit - 1, 0, 4);
                    });

                    mini.Con.Print(1, 15, "Equipped Items");

                    int printY = 16;

                    mini.Con.Print(1, printY, "|   Weapon: "); 
                    if (player.Equipment.TryGetValue("Weapon", out ItemWrapper? wepWrap) && wepWrap.GetRef() is Item wep) {
                        ColoredString name = wep.GetNameCS(wepWrap.Quantity, 0, wepWrap.Charges, wepWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Weapon"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Weapon");
                        });

                        if (wep.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(wepWrap, player);

                                if (wep.ConsumedOnUse && success) {
                                    wepWrap.TryConsume();
                                }

                                if (wepWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Weapon"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "| Off-hand: ");
                    if (player.Equipment.TryGetValue("Offhand", out ItemWrapper? offWrap) && offWrap.GetRef() is Item off) {
                        ColoredString name = off.GetNameCS(offWrap.Quantity, 0, offWrap.Charges, offWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Offhand"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Offhand");
                        });

                        if (off.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(offWrap, player);

                                if (off.ConsumedOnUse && success) {
                                    offWrap.TryConsume();
                                }

                                if (offWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Offhand"); 
                                }
                            });  
                        }
                    }
                     
                    printY++;

                    mini.Con.Print(1, printY, "|     Head: "); 
                    if (player.Equipment.TryGetValue("Head", out ItemWrapper? headWrap) && headWrap.GetRef() is Item head) {
                        ColoredString name = head.GetNameCS(headWrap.Quantity, 0, headWrap.Charges, headWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Head"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Head");
                        });

                        if (head.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(headWrap, player);

                                if (head.ConsumedOnUse && success) {
                                    headWrap.TryConsume();
                                }

                                if (headWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Head"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Body: "); 
                    if (player.Equipment.TryGetValue("Body", out ItemWrapper? bodyWrap) && bodyWrap.GetRef() is Item body) { 
                        ColoredString name = body.GetNameCS(bodyWrap.Quantity, 0, bodyWrap.Charges, bodyWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Body"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Body");
                        });

                        if (body.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(bodyWrap, player);

                                if (body.ConsumedOnUse && success) {
                                    bodyWrap.TryConsume();
                                }

                                if (bodyWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Body"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Legs: "); 
                    if (player.Equipment.TryGetValue("Legs", out ItemWrapper? legWrap) && legWrap.GetRef() is Item legs) {
                        ColoredString name = legs.GetNameCS(legWrap.Quantity, 0, legWrap.Charges, legWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Legs"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Legs");
                        });

                        if (legs.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(legWrap, player);

                                if (legs.ConsumedOnUse && success) {
                                    legWrap.TryConsume();
                                }

                                if (legWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Legs"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|    Hands: ");
                    if (player.Equipment.TryGetValue("Hands", out ItemWrapper? handWrap) && handWrap.GetRef() is Item hands) {
                        ColoredString name = hands.GetNameCS(handWrap.Quantity, 0, handWrap.Charges, handWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Hands"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Hands");
                        });

                        if (hands.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(handWrap, player);

                                if (hands.ConsumedOnUse && success) {
                                    handWrap.TryConsume();
                                }

                                if (handWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Hands"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Feet: ");
                    if (player.Equipment.TryGetValue("Feet", out ItemWrapper? feetWrap) && feetWrap.GetRef() is Item feet) {
                        ColoredString name = feet.GetNameCS(feetWrap.Quantity, 0, feetWrap.Charges, feetWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Feet"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Feet");
                        });

                        if (feet.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(feetWrap, player);

                                if (feet.ConsumedOnUse && success) {
                                    feetWrap.TryConsume();
                                }

                                if (feetWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Feet"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Cape: ");
                    if (player.Equipment.TryGetValue("Cape", out ItemWrapper? capeWrap) && capeWrap.GetRef() is Item cape) {
                        ColoredString name = cape.GetNameCS(capeWrap.Quantity, 0, capeWrap.Charges, capeWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Cape"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Cape");
                        });

                        if (cape.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(capeWrap, player);

                                if (cape.ConsumedOnUse && success) {
                                    capeWrap.TryConsume();
                                }

                                if (capeWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Cape"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Ring: ");
                    if (player.Equipment.TryGetValue("Ring", out ItemWrapper? ringWrap) && ringWrap.GetRef() is Item ring) {
                        ColoredString name = ring.GetNameCS(ringWrap.Quantity, 0, ringWrap.Charges, ringWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Ring"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Ring");
                        });

                        if (ring.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(ringWrap, player);

                                if (ring.ConsumedOnUse && success) {
                                    ringWrap.TryConsume();
                                }

                                if (ringWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Ring"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|   Amulet: ");
                    if (player.Equipment.TryGetValue("Amulet", out ItemWrapper? amuletWrap) && amuletWrap.GetRef() is Item amulet) {
                        ColoredString name = amulet.GetNameCS(amuletWrap.Quantity, 0, amuletWrap.Charges, amuletWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Amulet"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Amulet");
                        });

                        if (amulet.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(amuletWrap, player);

                                if (amulet.ConsumedOnUse && success) {
                                    amuletWrap.TryConsume();
                                }

                                if (amuletWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Amulet"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|   Pocket: ");
                    if (player.Equipment.TryGetValue("Pocket", out ItemWrapper? pocketWrap) && pocketWrap.GetRef() is Item pocket) {
                        ColoredString name = pocket.GetNameCS(pocketWrap.Quantity, 0, pocketWrap.Charges, pocketWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Pocket"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Pocket");
                        });

                        if (pocket.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(pocketWrap, player);

                                if (pocket.ConsumedOnUse && success) {
                                    pocketWrap.TryConsume();
                                }

                                if (pocketWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Pocket"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Ammo: ");
                    if (player.Equipment.TryGetValue("Ammo", out ItemWrapper? ammoWrap) && ammoWrap.GetRef() is Item ammo) { 
                        ColoredString name = ammo.GetNameCS(ammoWrap.Quantity, 0, ammoWrap.Charges, ammoWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Ammo"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Ammo");
                        });

                        if (ammo.UseString != "") {  
                            mini.Con.PrintClickable(13 + name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(ammoWrap, player);

                                if (ammo.ConsumedOnUse && success) {
                                    ammoWrap.TryConsume();
                                }

                                if (ammoWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Ammo"); 
                                }
                            });  
                        }
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|      Pet: ");
                    if (player.Equipment.TryGetValue("Pet", out ItemWrapper? petWrap) && petWrap.GetRef() is Item pet) { 
                        ColoredString name = pet.GetNameCS(petWrap.Quantity, 0, petWrap.Charges, petWrap.Noted);
                        mini.Con.PrintClickable(13, printY, name, () => {
                            ItemWrapper item = player.Equipment["Pet"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Pet");
                        });

                        if (pet.UseString != "") {  
                            mini.Con.PrintClickable(13 + pet.Name.Length + 1, printY, new ColoredString("*", Color.Yellow, Color.Black), () => { 
                                bool success = ItemUseLogic.UseItem(petWrap, player);

                                if (pet.ConsumedOnUse && success) {
                                    petWrap.TryConsume();
                                }

                                if (petWrap.Quantity <= 0) {
                                    player.Equipment.Remove("Pet"); 
                                }
                            });  
                        }
                    }
                }
            
                else if (SidebarMenu == "Skills") {
                    List<Skill> playerSkills = player.Skills.Values.OrderBy(f => f.Name).ToList();

                    mini.Con.Print(1, 15, "Skill Name");
                    mini.Con.Print(21, 15, "Lv");
                    mini.Con.Print(31, 15, "To Next");
                    mini.Con.Print(45, 15, "Total Exp");

                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    int printY = 17;

                    for (int i = SidebarScrollTop; i < playerSkills.Count && i < SidebarScrollTop + 18; i++) {
                        bool mouseHovering = mousePos.X < 54 && mousePos.Y == printY;

                        mini.Con.PrintClickable(1, printY, new ColoredString(playerSkills[i].Name, mouseHovering ? Color.Yellow : Color.White, Color.Black), () => {
                            ExtraWindows.Compendium.IsVisible = true;
                            ExtraWindows.ResetAllCompendiumValues(); 
                            ExtraWindows.CompendiumSidebarTop = 0;
                            ExtraWindows.CompendiumSourceTop = 0;
                            ExtraWindows.CompendiumDropTop = 0;
                            ExtraWindows.CompendiumCat = "Skills";
                            ExtraWindows.CompendiumViewingID = playerSkills[i].Name;
                            ExtraWindows.Sources = ExtraWindows.AllSkillUses(playerSkills[i].Name);
                        });

                        int esl = player.GetEffectiveSkillLevel(playerSkills[i].Name);

                        mini.Con.Print(20, printY, playerSkills[i].Level.ToString().PadLeft(3), mouseHovering ? Color.Yellow : Color.White);

                        if (esl != playerSkills[i].Level) {
                            mini.Con.Print(25, printY, ("(" + esl.ToString() + ")"), mouseHovering ? Color.Yellow : esl < playerSkills[i].Level ? Color.Crimson : Color.Lime);
                        }

                        if (player.PayToWin == 0) { 
                            mini.Con.Print(31, printY, playerSkills[i].ExpToLevel().ToString().PadLeft(8), mouseHovering ? Color.Yellow : Color.White);
                        } else {
                            int actualExpNeeded = (int)Math.Ceiling((double) playerSkills[i].EXPNeeded() / (double) player.ExpMultiplier);
                            Color couldBuy = Color.Lime;
                            if (player.HeldGold < player.PayToWin * actualExpNeeded) { couldBuy = Color.Crimson; }

                            mini.Con.PrintClickable(31, printY, new ColoredString(playerSkills[i].EXPNeeded().ToString().PadLeft(8), mouseHovering ? couldBuy : Color.White, Color.Black), () => {
                                player.TryGrantExp(playerSkills[i].Name, actualExpNeeded, GameLoop.ZPO.Log, RecentlyTrainedSkills, true);
                            });
                        }


                        mini.Con.Print(46, printY, playerSkills[i].Exp.ToString().PadLeft(8), mouseHovering ? Color.Yellow : Color.White);

                        printY++;
                    }
                }

                else if (SidebarMenu == "Prayer") {
                    mini.Con.Print(1, 15, "Prayer Name");
                    mini.Con.Print(20, 15, "Lv");
                    mini.Con.Print(23, 15, "Description");
                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    List<Prayer> prayers = player.Prayers.Values.OrderBy(o => o.Level).ThenBy(o => o.Name).ToList();
                    int printLine = 17;
                    int skipped = 0;

                    int prayLv = player.Skills["Prayer"].Level;

                    mini.Con.PrintClickable(43, 15, new ColoredString("Disable All", Color.Crimson, Color.Black), () => {
                        foreach (var kv in player.Prayers) {
                            kv.Value.Active = false;
                        }
                    });

                    for (int i = 0; i < prayers.Count; i++) {
                        if (prayers[i].Book == player.PrayerBook) {
                            if (skipped >= SidebarScrollTop && printLine < 35) {
                                mini.Con.PrintClickable(1, printLine, new ColoredString(prayers[i].Name, prayers[i].Active ? Color.Lime : prayers[i].Level > prayLv ? Color.DarkSlateGray : Color.White, Color.Black), () => { player.TryTogglePrayer(prayers[i].Name); });
                                mini.Con.Print(20, printLine, prayers[i].Level.ToString(), prayers[i].Level > prayLv ? Color.DarkSlateGray : Color.White); 
                                mini.Con.Print(23, printLine++, prayers[i].Description, prayers[i].Level > prayLv ? Color.DarkSlateGray : Color.White);
                            } else {
                                skipped++;
                            }
                        }
                    }
                } else if (SidebarMenu == "Emote") {
                    mini.Con.Print(1, 15, "Emote Name"); 
                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    int printY = 17; 
                    mini.Con.PrintClickable(1, printY++, "Nod Head", () => { GameLoop.ZPO.Log.AddMessage("You nod your head."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Nod"); });
                    mini.Con.PrintClickable(1, printY++, "Shake Head", () => { GameLoop.ZPO.Log.AddMessage("You shake your head."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Shake"); });
                    mini.Con.PrintClickable(1, printY++, "Think", () => { GameLoop.ZPO.Log.AddMessage("You ponder for a moment."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Think"); });
                    mini.Con.PrintClickable(1, printY++, "Beckon", () => { GameLoop.ZPO.Log.AddMessage("You beckon to nobody in particular."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Beckon"); });
                    mini.Con.PrintClickable(1, printY++, "Dance", () => { GameLoop.ZPO.Log.AddMessage("You shake your body in a dance."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Dance"); });
                    mini.Con.PrintClickable(1, printY++, "Cry", () => { GameLoop.ZPO.Log.AddMessage("You break down and cry for a moment."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Cry"); }); 
                    mini.Con.PrintClickable(1, printY++, "Clap", () => { GameLoop.ZPO.Log.AddMessage("You clap your hands."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Clap"); });
                    mini.Con.PrintClickable(1, printY++, "Wave", () => { GameLoop.ZPO.Log.AddMessage("You wave your arm vigorously."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Wave"); });

                    printY = 17;
                    mini.Con.PrintClickable(20, printY++, "Laugh", () => { GameLoop.ZPO.Log.AddMessage("You throw your head back and laugh heartily."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Laugh"); });
                    mini.Con.PrintClickable(20, printY++, "Jig", () => { GameLoop.ZPO.Log.AddMessage("You dance a little jig."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Jig"); });
                    mini.Con.PrintClickable(20, printY++, "Blow Kiss", () => { GameLoop.ZPO.Log.AddMessage("You blow a kiss."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "BlowKiss"); }); 
                    mini.Con.PrintClickable(20, printY++, "Salute", () => { GameLoop.ZPO.Log.AddMessage("You put your hand to your head in a crisp salute."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Salute"); });
                    mini.Con.PrintClickable(20, printY++, "Bow", () => { GameLoop.ZPO.Log.AddMessage("You take a bow."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Bow"); });
                    mini.Con.PrintClickable(20, printY++, "Shrug", () => { GameLoop.ZPO.Log.AddMessage("You shrug your shoulders."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Shrug"); });
                    mini.Con.PrintClickable(20, printY++, "Jump for Joy", () => { GameLoop.ZPO.Log.AddMessage("You jump for joy."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "JumpForJoy"); });
                    mini.Con.PrintClickable(20, printY++, "Spin", () => { GameLoop.ZPO.Log.AddMessage("You twirl around quickly with your arms stretched out."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Spin"); });

                    printY = 17;
                    mini.Con.PrintClickable(40, printY++, "Panic", () => { GameLoop.ZPO.Log.AddMessage("You panic for a moment."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Panic"); });
                    mini.Con.PrintClickable(40, printY++, "Shake Fist", () => { GameLoop.ZPO.Log.AddMessage("You shake your fist in anger."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "ShakeFist"); });
                    mini.Con.PrintClickable(40, printY++, "Cheer", () => { GameLoop.ZPO.Log.AddMessage("You cheer. Hurray!"); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Cheer"); });
                    mini.Con.PrintClickable(40, printY++, "Yawn", () => { GameLoop.ZPO.Log.AddMessage("You let out a yawn."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Yawn"); });
                    mini.Con.PrintClickable(40, printY++, "Headbang", () => { GameLoop.ZPO.Log.AddMessage("You bang your head to music only you can hear."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Headbang"); });
                    mini.Con.PrintClickable(40, printY++, "Raspberry", () => { GameLoop.ZPO.Log.AddMessage("You blow a raspberry."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "Raspberry"); });
                    mini.Con.PrintClickable(40, printY++, "Sit Down", () => { GameLoop.ZPO.Log.AddMessage("You sit down for a bit. This was nice."); ClueLogic.GenericStep(player, GameLoop.ZPO.Log, "Emote", "SitDown"); });
                } else if (SidebarMenu == "Quest") {
                    mini.Con.Print(1, 15, "Quest Name");
                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    int printQuest = 0;
                    int count = -1;

                    int questPoints = 0;
                    int totalPossibleQP = 0;

                    List<Quest> sortedList = GameLoop.ZPO.QuestLibrary.Values.ToList();

                    if (QuestSort == "A->Z") {
                        sortedList = sortedList.OrderBy(o => o.Name).ToList();
                    } else if (QuestSort == "!A->Z") {
                        sortedList = sortedList.OrderBy(o => o.Name).Reverse().ToList();
                    } else if (QuestSort == "Release") {
                        sortedList = sortedList.OrderBy(o => o.DateFullyImplemented).ToList();
                    } else if (QuestSort == "!Release") {
                        sortedList = sortedList.OrderBy(o => o.DateFullyImplemented).Reverse().ToList();
                    }

                    foreach (var kv in sortedList) {
                        totalPossibleQP += kv.QuestPoints;
                        if (kv.CurrentStage() == kv.CompleteStage)
                            questPoints += kv.QuestPoints;


                        count++;
                        if (count < SidebarScrollTop) {
                            continue;
                        } 

                        Color col = Color.DarkSlateGray;

                        if (kv.CanStartQuest(player)) {
                            col = Color.Crimson;
                        }

                        if (kv.CurrentStage() != -1) {
                            col = Color.Yellow;
                        }

                        if (kv.CurrentStage() == kv.CompleteStage) {
                            col = Color.Lime;
                        }

                        mini.Con.PrintClickable(0, 17 + printQuest, new ColoredString(kv.Name, col, Color.Black), () => {
                            ExtraWindows.Quests.IsVisible = true;
                            ExtraWindows.ViewingQuestID = kv.ID;
                             
                            if (kv.CurrentStage() == -1) {
                                ExtraWindows.QuestOverview = true;
                            } else {
                                ExtraWindows.QuestOverview = false;
                                ExtraWindows.QuestBlockScrollTop = 0;
                            } 
                        });

                        printQuest++; 
                    }
                     
                    mini.Con.Print(32, 15, "Quest Points: " + questPoints.ToString().Align(HorizontalAlignment.Right, 3) + " / " + totalPossibleQP.ToString().Align(HorizontalAlignment.Right, 3));

                    mini.Con.DrawLine(new Point(0, 33), new Point(54, 33), 196);

                    mini.Con.PrintClickable(0, 34, new ColoredString("A->Z", QuestSort == "A->Z" ? Color.Lime : QuestSort == "!A->Z" ? Color.Crimson : Color.White, Color.Black), () => {
                        if (QuestSort == "A->Z") {
                            QuestSort = "!A->Z";
                        } else {
                            QuestSort = "A->Z";
                        }
                    });
                    mini.Con.PrintClickable(5, 34, new ColoredString("Release", QuestSort == "Release" ? Color.Lime : QuestSort == "!Release" ? Color.Crimson : Color.White, Color.Black), () => {
                        if (QuestSort == "Release") {
                            QuestSort = "!Release";
                        } else {
                            QuestSort = "Release";
                        }
                    });
                } else if (SidebarMenu == "Magic") { 
                    mini.Con.Print(1, 15, player.MagicBook + " Spellbook Spells");
                    
                    mini.Con.PrintClickable(38, 15, new ColoredString("Combat", MagicTab == "Combat" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { MagicTab = "Combat"; });
                    mini.Con.PrintClickable(45, 15, new ColoredString("Tele", MagicTab == "Tele" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { MagicTab = "Tele"; });
                    mini.Con.PrintClickable(50, 15, new ColoredString("Util", MagicTab == "Utility" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { MagicTab = "Utility"; });

                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    List<Spell> spells = new();

                    foreach (var kv in GameLoop.ZPO.SpellLibrary) {
                        if (kv.Value.Book == player.MagicBook && kv.Value.Category == MagicTab) {
                            spells.Add(kv.Value);
                        }
                    }

                    for (int i = 0; i < spells.Count; i++) {
                        string cast = player.CanCast(spells[i]);

                        mini.Con.PrintClickable(6, 17 + i, new ColoredString(spells[i].Name, player.CastingSpell == spells[i].ID ? Color.Lime : cast.Contains("cooldown") ? Color.Yellow : cast.Contains("Magic") ? Color.DarkSlateGray : cast != "" ? Color.Crimson : Color.White, Color.Black), () => { 
                            if (cast == "") {
                                if (MagicTab == "Combat") {
                                    player.CastingSpell = spells[i].ID;
                                }

                                if (MagicTab == "Tele") {
                                    if (curr.Region == "Tutorial Island") {
                                        player.ConsumeItems(spells[i].Runes);
                                        player.NavLoc = "TI_Main";
                                        spells[i].TimeLastCast = Helper.Time();
                                        GameLoop.ZPO.Log.AddMessage("The pull of the island distorts your magic and you appear in the center of Tutorial Island.", Color.MediumPurple);
                                    } else {
                                        if (GameLoop.ZPO.Atlas.TryGetValue(spells[i].MiscString, out Location? dest)) {
                                            spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                            GameLoop.ZPO.Log.AddMessage("You teleport to " + dest.DisplayName + ".", Color.MediumPurple);
                                        } else {
                                            GameLoop.ZPO.Log.AddMessage("Teleport destination does not exist.", Color.Crimson);
                                        } 
                                    }
                                }

                                if (MagicTab == "Utility") {
                                    if (spells[i].ID == "utilBonesBananas") {
                                        bool anyBones = false;
                                        int extras = 0;
                                        foreach (var kv in player.Inventory) {
                                            if (new List<string>() { "bonesRegular", "bonesWolf", "bonesBat", "bonesBig", "bonesBleached", "bonesBurnt", "bonesJogre", "bonesMonkey", "mtaBone1", "mtaBone2", "mtaBone3", "mtaBone4", "bonesAlan" }.Contains(kv.ID) && !kv.Noted) {
                                                if (kv.ID.Contains("mtaBone")) {
                                                    int qty = 0;
                                                    if (MinigameManager.MTA_Bones[1] == kv.ID) { qty = 1; }
                                                    if (MinigameManager.MTA_Bones[2] == kv.ID) { qty = 2; }
                                                    if (MinigameManager.MTA_Bones[3] == kv.ID) { qty = 3; }
                                                    
                                                    extras += qty;
                                                }
                                                kv.ID = "fruitBanana";
                                                anyBones = true; 
                                            }
                                        }

                                        if (extras > 0) {
                                            if (GameLoop.ZPO.ItemLibrary.TryGetValue("fruitBanana", out Item? banan) && banan != null) {
                                                player.TryPickup(new Item(banan), extras);
                                            }
                                        }

                                        if (anyBones) {
                                            spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                            GameLoop.ZPO.Log.AddMessage("You cast Bones to Bananas and all your bones become bananas.", Color.MediumPurple);
                                        } else {
                                            GameLoop.ZPO.Log.AddMessage("You have no applicable bones to transmute.", Color.Crimson);
                                        }
                                    }

                                    if (spells[i].ID == "utilBonesPeaches") {
                                        bool anyBones = false;
                                        int extras = 0;
                                        foreach (var kv in player.Inventory) {
                                            if (new List<string>() { "bonesRegular", "bonesWolf", "bonesBat", "bonesBig", "bonesBleached", "bonesBurnt", "bonesJogre", "bonesMonkey", "mtaBone1", "mtaBone2", "mtaBone3", "mtaBone4", "bonesAlan" }.Contains(kv.ID) && !kv.Noted) {
                                                if (kv.ID.Contains("mtaBone")) {
                                                    int qty = 0;
                                                    if (MinigameManager.MTA_Bones[1] == kv.ID) { qty = 1; }
                                                    if (MinigameManager.MTA_Bones[2] == kv.ID) { qty = 2; }
                                                    if (MinigameManager.MTA_Bones[3] == kv.ID) { qty = 3; }
                                                     
                                                    extras += qty;
                                                }

                                                kv.ID = "fruitPeach";
                                                anyBones = true;
                                            }
                                        }

                                        if (extras > 0) {
                                            if (GameLoop.ZPO.ItemLibrary.TryGetValue("fruitPeach", out Item? peach) && peach != null) {
                                                player.TryPickup(new Item(peach), extras);
                                            }
                                        }

                                        if (anyBones) {
                                            spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                            GameLoop.ZPO.Log.AddMessage("You cast Bones to Peaches and all your bones become peaches.", Color.MediumPurple);
                                        } else {
                                            GameLoop.ZPO.Log.AddMessage("You have no applicable bones to transmute.", Color.Crimson);
                                        }
                                    }

                                    if (spells[i].ID == "utilSuperheat") { 
                                        if (GameLoop.ZPO.ProcessingStations.TryGetValue("Furnace", out ProcessingStation? furnace) && furnace != null) {
                                            furnace.LastWorked = "";
                                            if (furnace.TryProcessItem(player, GameLoop.ZPO.Log, GameLoop.ZPO.ItemLibrary, RecentlyTrainedSkills)) {
                                                spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                GameLoop.ZPO.Log.AddMessage("You cast Superheat Item and smelt an ore mix into a bar.", Color.MediumPurple);
                                            } else {
                                                GameLoop.ZPO.Log.AddMessage("You have no ore mixes you have the smithing level to be able to smelt.", Color.Crimson);
                                            }
                                        } 
                                    }

                                    if (spells[i].ID == "utilAlchemyLow") {   
                                        GameLoop.ZPO.Log.AddMessage("Cast this by clicking the ~ icon on an item line in your inventory.", Color.Crimson); 
                                    }

                                    if (spells[i].ID == "utilAlchemyHigh") {   
                                        GameLoop.ZPO.Log.AddMessage("Cast this by clicking the " + 247.AsString() + " icon on an item line in your inventory.", Color.Crimson); 
                                    }

                                    if (spells[i].ID == "utilEnchant1") { 
                                        if (GameLoop.ZPO.ProcessingStations.TryGetValue("Level 1 Enchanter", out ProcessingStation? enchant) && enchant != null) {
                                            enchant.LastWorked = "";
                                            if (enchant.TryProcessItem(player, GameLoop.ZPO.Log, GameLoop.ZPO.ItemLibrary, RecentlyTrainedSkills)) {
                                                spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                GameLoop.ZPO.Log.AddMessage("You enchant a piece of sapphire/opal jewellery.", Color.MediumPurple);
                                            } else {
                                                GameLoop.ZPO.Log.AddMessage("You have no unenchanted sapphire/opal jewellery to enchant.", Color.Crimson);
                                            }
                                        } 
                                    }

                                    if (spells[i].ID == "utilEnchant2") { 
                                        if (GameLoop.ZPO.ProcessingStations.TryGetValue("Level 2 Enchanter", out ProcessingStation? enchant) && enchant != null) {
                                            enchant.LastWorked = "";
                                            if (enchant.TryProcessItem(player, GameLoop.ZPO.Log, GameLoop.ZPO.ItemLibrary, RecentlyTrainedSkills)) {
                                                spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                GameLoop.ZPO.Log.AddMessage("You enchant a piece of emerald/jade jewellery.", Color.MediumPurple);
                                            } else {
                                                GameLoop.ZPO.Log.AddMessage("You have no unenchanted emerald/jade jewellery to enchant.", Color.Crimson);
                                            }
                                        } 
                                    }

                                    if (spells[i].ID == "utilEnchant3") { 
                                        if (GameLoop.ZPO.ProcessingStations.TryGetValue("Level 3 Enchanter", out ProcessingStation? enchant) && enchant != null) {
                                            enchant.LastWorked = "";
                                            if (enchant.TryProcessItem(player, GameLoop.ZPO.Log, GameLoop.ZPO.ItemLibrary, RecentlyTrainedSkills)) {
                                                spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                GameLoop.ZPO.Log.AddMessage("You enchant a piece of ruby/red topaz jewellery.", Color.MediumPurple);
                                            } else {
                                                GameLoop.ZPO.Log.AddMessage("You have no unenchanted ruby/red topaz jewellery to enchant.", Color.Crimson);
                                            }
                                        } 
                                    }

                                    if (spells[i].ID == "utilEnchant4") { 
                                        if (GameLoop.ZPO.ProcessingStations.TryGetValue("Level 4 Enchanter", out ProcessingStation? enchant) && enchant != null) {
                                            enchant.LastWorked = "";
                                            if (enchant.TryProcessItem(player, GameLoop.ZPO.Log, GameLoop.ZPO.ItemLibrary, RecentlyTrainedSkills)) {
                                                spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                GameLoop.ZPO.Log.AddMessage("You enchant a piece of diamond topaz jewellery.", Color.MediumPurple);
                                            } else {
                                                GameLoop.ZPO.Log.AddMessage("You have no unenchanted diamond topaz jewellery to enchant.", Color.Crimson);
                                            }
                                        } 
                                    }

                                    if (spells[i].ID == "utilEnchant5") { 
                                        if (GameLoop.ZPO.ProcessingStations.TryGetValue("Level 5 Enchanter", out ProcessingStation? enchant) && enchant != null) {
                                            enchant.LastWorked = "";
                                            if (enchant.TryProcessItem(player, GameLoop.ZPO.Log, GameLoop.ZPO.ItemLibrary, RecentlyTrainedSkills)) {
                                                spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                GameLoop.ZPO.Log.AddMessage("You enchant a piece of dragonstone jewellery.", Color.MediumPurple);
                                            } else {
                                                GameLoop.ZPO.Log.AddMessage("You have no unenchanted dragonstone jewellery to enchant.", Color.Crimson);
                                            }
                                        } 
                                    }

                                    if (spells[i].ID == "utilEnchant6") { 
                                        if (GameLoop.ZPO.ProcessingStations.TryGetValue("Level 6 Enchanter", out ProcessingStation? enchant) && enchant != null) {
                                            enchant.LastWorked = "";
                                            if (enchant.TryProcessItem(player, GameLoop.ZPO.Log, GameLoop.ZPO.ItemLibrary, RecentlyTrainedSkills)) {
                                                spells[i].Cast(player, GameLoop.ZPO.Log, RecentlyTrainedSkills);
                                                GameLoop.ZPO.Log.AddMessage("You enchant a piece of onyx jewellery.", Color.MediumPurple);
                                            } else {
                                                GameLoop.ZPO.Log.AddMessage("You have no unenchanted onyx jewellery to enchant.", Color.Crimson);
                                            }
                                        } 
                                    }
                                }
                            } else {
                                GameLoop.ZPO.Log.AddMessage(new ColoredString("Cannot cast spell: " + cast, Color.Crimson, Color.Black));
                            }
                        });

                        mini.Con.Print(1, 17+i, spells[i].Level.ToString().Align(HorizontalAlignment.Right, 2));
                        mini.Con.PrintClickable(4, 17+i, new ColoredString("?", Color.MediumPurple, Color.Black), () => { GameLoop.ZPO.Log.AddMessage(spells[i].Description); });
                    }
                } else if (SidebarMenu == "Log") {
                    mini.Con.Print(1, 15, "Clue Collection Logs");

                    if (!player.CollectionLogClues.ContainsKey("casketTutorial")) {
                        player.CollectionLogClues.Add("casketTutorial", new("casketTutorial"));
                    }

                    if (player.CollectionLogClues.TryGetValue("casketTutorial", out CollectionLogEntry? tutLog) && tutLog != null)
                        mini.Con.PrintClickable(1, 16, new ColoredString("| Tutorial: " + tutLog.ActualObtained().ToString().Align(HorizontalAlignment.Right, 3) + " / " + tutLog.TryFindTotal().ToString().Align(HorizontalAlignment.Right, 3), tutLog.LogComplete() ? Color.Lime : Color.White, Color.Black), () => { ExtraWindows.CollectionID = "casketTutorial"; ExtraWindows.CollectionLog.IsVisible = true; ExtraWindows.CollectionDropTop = 0; ExtraWindows.CollectionCat = "Clue"; });
                    else 
                        mini.Con.Print(1, 16, "| Tutorial: ");

                    if (!player.CollectionLogClues.ContainsKey("casketBeginner")) {
                        player.CollectionLogClues.Add("casketBeginner", new("casketBeginner"));
                    }

                    if (player.CollectionLogClues.TryGetValue("casketBeginner", out CollectionLogEntry? begLog) && begLog != null)
                        mini.Con.PrintClickable(1, 17, new ColoredString("| Beginner: " + begLog.ActualObtained().ToString().Align(HorizontalAlignment.Right, 3) + " / " + begLog.TryFindTotal().ToString().Align(HorizontalAlignment.Right, 3), begLog.LogComplete() ? Color.Lime : Color.White, Color.Black), () => { ExtraWindows.CollectionID = "casketBeginner"; ExtraWindows.CollectionLog.IsVisible = true; ExtraWindows.CollectionDropTop = 0; ExtraWindows.CollectionCat = "Clue"; });
                    else 
                        mini.Con.Print(1, 17, "| Beginner: ");

                    if (!player.CollectionLogClues.ContainsKey("casketEasy")) {
                        player.CollectionLogClues.Add("casketEasy", new("casketEasy"));
                    }

                    if (player.CollectionLogClues.TryGetValue("casketEasy", out CollectionLogEntry? easyLog) && easyLog != null)
                        mini.Con.PrintClickable(1, 18, new ColoredString("|     Easy: " + easyLog.ActualObtained().ToString().Align(HorizontalAlignment.Right, 3) + " / " + easyLog.TryFindTotal().ToString().Align(HorizontalAlignment.Right, 3), easyLog.LogComplete() ? Color.Lime : Color.White, Color.Black), () => { ExtraWindows.CollectionID = "casketEasy"; ExtraWindows.CollectionLog.IsVisible = true; ExtraWindows.CollectionDropTop = 0; ExtraWindows.CollectionCat = "Clue"; });
                    else 
                        mini.Con.Print(1, 18, "|     Easy: ");
                     
                    mini.Con.Print(1, 19, "|   Medium: ");
                    mini.Con.Print(1, 20, "|     Hard: ");
                    mini.Con.Print(1, 21, "|    Elite: ");
                    mini.Con.Print(1, 22, "|   Master: ");

                    if (!player.CollectionLogClues.ContainsKey("General")) {
                        player.CollectionLogClues.Add("General", new("General"));
                    }

                    if (player.CollectionLogClues.TryGetValue("General", out CollectionLogEntry? genLog) && genLog != null)
                        mini.Con.PrintClickable(1, 23, new ColoredString("|  General: " + genLog.ActualObtained().ToString().Align(HorizontalAlignment.Right, 3) + " / " + genLog.TryFindTotal().ToString().Align(HorizontalAlignment.Right, 3), genLog.LogComplete() ? Color.Lime : Color.White, Color.Black), () => { ExtraWindows.CollectionID = "General"; ExtraWindows.CollectionLog.IsVisible = true; ExtraWindows.CollectionDropTop = 0; ExtraWindows.CollectionCat = "Clue"; });
                    else 
                        mini.Con.Print(1, 23, "|  General: ");
                } else if (SidebarMenu == "Potions") {
                    mini.Con.Print(1, 15, "Active Potion Effects", Color.White);
                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    int qty = 1;
                    if (Helper.EitherShift())
                        qty *= 5;
                    if (Helper.EitherControl())
                        qty *= 10;

                    if (player.ActivePotions.Count > 18) {
                        if (Helper.ScrolledUp()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop - qty, 0, player.ActivePotions.Count - 18); }
                        if (Helper.ScrolledDown()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop + qty, 0, player.ActivePotions.Count - 18); }
                    } else {
                        SidebarScrollTop = 0;
                    }
                    
                    int printY = 17;
                    if (player.ActivePotions.Count > 0) { 
                        for (int pot = SidebarScrollTop; pot < player.ActivePotions.Count && pot < SidebarScrollTop + 18; pot++) {
                            Color col = player.ActivePotions[pot].Change > 0 ? Color.Green : Color.Crimson;
                            if (mousePos.Y == printY && mousePos.X < 55) {
                                col = col.GetDark();
                            }

                            mini.Con.Print(1, printY++, new ColoredString("| ") + new ColoredString(player.ActivePotions[pot].Stat.Align(HorizontalAlignment.Left, 45) + " (" + ((player.ActivePotions[pot].Change > 0 ? "+" : "") + player.ActivePotions[pot].Change).ToString().Align(HorizontalAlignment.Right, 3) + ")", col, Color.Black));
                        }
                    } else {
                        mini.Con.Print(1, printY++, "(no active potion effects)", Color.DarkSlateGray);
                    }
                }
            } 
        }

    }
}
