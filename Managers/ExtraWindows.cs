using GoRogue;
using GoRogue.DiceNotation.Terms;
using SadConsole.EasingFunctions;
using SadConsole.Input;
using SadConsole.UI;
using ZeroPlayersOnline.DataTypes;
using Key = SadConsole.Input.Keys;

namespace ZeroPlayersOnline.Managers {
    public static class ExtraWindows {
        public static Window CollectionLog;
        public static string CollectionID = "";
        public static int CollectionDropTop = 0;
        public static int CollectionSideTop = 0;
        public static string CollectionCat = "";

        public static Window CraftingMenu;
        public static string CraftingType = "";
        public static string CraftingSubtype = "";
        public static List<CraftRecipe> ActiveRecipes = new();
        public static int CraftingListTop = 0;

        public static Window Guide;
        public static string GuideTab = "Introduction";
         
        public static Window Quests;
        public static string QuestFilter = "All";
        public static string ViewingQuestID = "";
        public static bool QuestOverview = true;
        public static int QuestBlockScrollTop = 0;
         
        public static Window Compendium;
        public static string CompendiumCat = "Overview";
        public static string CompendiumSubCat = "";
        public static string CompendiumViewingID = "";
        public static string CompendiumViewingID2 = "";
        public static int CompendiumViewingIndex = 0;
        public static int CompendiumViewingIndex2 = 0;
        public static int CompendiumSidebarTop = 0;
        public static int CompendiumSourceTop = 0;
        public static int CompendiumDropTop = 0;
        public static bool CompendiumShowSources = false;
        public static string Filter = "";
        public static string SelectedField = "";


        public static Window Map;
        public static int MapW;
        public static int MapH;
        public static string MapViewing = "";
        public static Color MapLandmark = Color.Turquoise;
        public static Color MapPlayerLoc = Color.Lime;
         
        
        public static Window Debug;
        public static string DebugMenu = "Overview";
        public static int DebugRandomSource = 0;

        public static Window Clue;
        public static string CurrentClue = "";

        public static Window Teleport; 
        public static List<string> TeleportDests = new();
        public static ItemWrapper? TeleWrap = null;
        public static bool TeleCostsCharges = false;
        public static bool TeleFairyRing = false;

        public static Window InventoryContainer;
        public static ItemWrapper? ConWrap = null;

        
        public static Window Book;
        public static string BookID = "";
        public static int LeftPage = 0;
         
        public static Window Cutscene;
        public static string CutsceneID = "";
        public static int CutsceneScene = 0;
        public static int CutsceneDialogue = 0;

        public static Window Shop;
        public static string ShopID = "";
        public static string SlayerTab = "Unlocks";
        public static int ShopTop = 0;
        public static List<string> ShopItems = new();
        public static List<SlayerReward> SlayerUnlocks = new();
        public static List<SlayerReward> SlayerBuy = new();
        public static List<SlayerReward> SlayerTasks = new();
        public static List<SlayerReward> SlayerCosmetics = new();

        public static bool AnyVisible(string except = "") {
            if (CollectionLog.IsVisible && except != "Collection")
                return true;
            if (CraftingMenu.IsVisible && except != "Crafting")
                return true;
            if (Guide.IsVisible && except != "Guidebook")
                return true;
            if (Quests.IsVisible && except != "Quests")
                return true;
            if (Compendium.IsVisible && except != "Compendium")
                return true;
            if (Map.IsVisible && except != "Map")
                return true;
            if (Debug.IsVisible && except != "Debug")
                return true;
            if (Clue.IsVisible && except != "Clue")
                return true;
            if (Teleport.IsVisible && except != "Teleport")
                return true;
            if (InventoryContainer.IsVisible && except != "InventoryContainer")
                return true;
            if (Book.IsVisible && except != "Book") 
                return true;
            if (Cutscene.IsVisible && except != "Cutscene")
                return true;
            if (Shop.IsVisible && except != "Shop")
                return true;
            
            return false;
        }

        public static void HideAll() {
            CollectionLog.IsVisible = false;
            CraftingMenu.IsVisible = false;
            Guide.IsVisible = false;
            Quests.IsVisible = false;
            Compendium.IsVisible = false;
            Map.IsVisible = false;
            Debug.IsVisible = false;
            Clue.IsVisible = false;
            Teleport.IsVisible = false;
            InventoryContainer.IsVisible = false;
            Book.IsVisible = false;
            Cutscene.IsVisible = false;
            Shop.IsVisible = false;
        }

        public static void SetupWindows() {
            CollectionLog = new(100, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Collection Log".Align(HorizontalAlignment.Center, 98)};
            Guide = new(100, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Guidebook".Align(HorizontalAlignment.Center, 98)};
            CraftingMenu = new(100, 30) { CanDrag = true, Position = new Point(15, 10), Title = "Crafting Menu".Align(HorizontalAlignment.Center, 98)};
            Map = new(50, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Map".Align(HorizontalAlignment.Center, 48)};
            Quests = new(100, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Quest Log".Align(HorizontalAlignment.Center, 98)};
            Compendium = new(100, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Compendium".Align(HorizontalAlignment.Center, 98)};
            Debug = new(100, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Debug Menu".Align(HorizontalAlignment.Center, 98)};
            Clue = new(70, 20) { CanDrag = true, Position = new Point(25, 10), Title = "Clue Scroll".Align(HorizontalAlignment.Center, 68)};
            Teleport = new(50, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Teleports".Align(HorizontalAlignment.Center, 48)};
            InventoryContainer = new(50, 10) { CanDrag = true, Position = new Point(25, 10), Title = "Inventory COntainer".Align(HorizontalAlignment.Center, 48)}; 
            Book = new(77, 25) { CanDrag = true, Position = new Point(25, 10), Title = "Book".Align(HorizontalAlignment.Center, 75)}; 
            Cutscene = new(100, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Cutscene".Align(HorizontalAlignment.Center, 98)};
            Shop = new(50, 30) { CanDrag = true, Position = new Point(25, 10), Title = "Shop".Align(HorizontalAlignment.Center, 48)}; 
        }

        public static void GuideDraw() {
            Guide.Clear();
            Helper.DrawBox(Guide, 0, 0, 98, 28);
            Guide.Print(2, 0, "[Zero Players Online Guidebook]");
            Guide.DrawLine(new Point(20, 1), new Point(20, 28), 179);

            Guide.PrintClickable(2, 2, new ColoredString("Introduction", GuideTab == "Introduction" ? Color.Yellow : Color.White, Color.Black), () => { GuideTab = "Introduction"; });
            Guide.PrintClickable(2, 4, new ColoredString("Combat", GuideTab == "Combat" ? Color.Yellow : Color.White, Color.Black), () => { GuideTab = "Combat"; });
            Guide.PrintClickable(2, 6, new ColoredString("Skilling", GuideTab == "Skilling" ? Color.Yellow : Color.White, Color.Black), () => { GuideTab = "Skilling"; });
            Guide.PrintClickable(2, 8, new ColoredString("Shops", GuideTab == "Shops" ? Color.Yellow : Color.White, Color.Black), () => { GuideTab = "Shops"; });
            Guide.PrintClickable(2, 10, new ColoredString("NPC Dialogue", GuideTab == "NPC Dialogue" ? Color.Yellow : Color.White, Color.Black), () => { GuideTab = "NPC Dialogue"; });

            int printY = 2;

            if (GuideTab == "Introduction") {

                printY = Guide.PrintMultiLine(22, printY,
                    "Welcome to Zero Players Online! The interface can be a little intimidating but this guide will hopefully ease you into the process of playing the game." + " /n /n " +
                    "The area to the top left contains your important stats readout, including HP and Gold, and skills you've recently gained experience in." + " /n /n " +
                    "Below this readout is the content area, containing tabs you can switch between at the top to view your inventory, equipment, and more." + " /n /n " +
                    "Underneath this and the width of the screen is your message log, where important messages are sent by the game." + " /n /n " +
                    "The top of the right side of the screen is your current location, listing its description and title." + " /n /n " +
                    "To the left below this are connected locations and monsters at this location. You can click a connected location to move to it." + " /n /n " +
                    "Finally to the right is the activity box, containing resources you can collect, items on the ground, NPCs, shop items, and processing stations at this location. Pressing TAB will cycle the tab shown here, or you can click on the letters at the top to change to specific tabs." + " /n /n " +
                    "This is all a lot to take in, but hopefully with some practice it will become more natural to navigate."
                    , 78);
            }
        }
         

        public static void MapDraw() {
            Map.Clear();
            Helper.DrawBox(Map, 0, 0, 48, 28);
            Map.Print(2, 0, "[Map - " + MapViewing + "]");

            string mapIDPrefix = "";

            if (MapViewing == "Lumbridge Swamp") {
                mapIDPrefix = "MIST_LumbridgeSwamp";
            }

            int pX = (49 - MapW * 3) / 2;
            int pY = (28 - MapH * 2) / 2;
            
            bool playerInArea = GameLoop.ZPO.player.NavLoc.Contains(mapIDPrefix); 
             

            for (int i = 0; i < MapW * MapH; i++) {
                bool playerAtNumber = GameLoop.ZPO.player.NavLoc == mapIDPrefix + i;
                bool landmark = false;

                if (GameLoop.ZPO.Atlas.TryGetValue(mapIDPrefix + i, out Location? loc)) {
                    landmark = loc.MazeLandmark;
                }

                int x = i % MapW;
                int y = i / MapW;
                Map.DrawLine(new Point(pX, pY + (y * 2)), new Point(pX + (MapW * 3), pY + (y * 2)), 196, Color.Khaki);
                Map.DrawLine(new Point(pX + (x * 3), pY), new Point(pX + (x * 3), pY + (MapH * 2)), 179, Color.Khaki);
                 
                Map.Print(pX + (x * 3) + 1, pY + (y * 2) + 1, i.ToString(), playerAtNumber ? MapPlayerLoc : landmark ? MapLandmark : Color.Khaki);
            }
            Map.DrawLine(new Point(pX + (MapW * 3), pY), new Point(pX + (MapW * 3), pY + (MapH * 2)), 179, Color.Khaki);
            Map.DrawLine(new Point(pX, pY + (MapH * 2)), new Point(pX + (MapW * 3), pY + (MapH * 2)), 196, Color.Khaki);

            for (int i = 0; i < (MapW + 1) * (MapH + 1); i++) {
                int x = i % (MapW + 1);
                int y = i / (MapW + 1);
                Map.Print(pX + (x * 3), pY + (y * 2), "*", Color.Khaki);
            }
             

            
            Map.Print(1, 26, "Click the following lines to change their color.", Color.White);
            Map.PrintClickable(1, 27, new ColoredString("Maps in this color are areas of interest.", MapLandmark, Color.Black), () => { MapLandmark = new Color(GameLoop.rand.Next(256), GameLoop.rand.Next(256), GameLoop.rand.Next(256)); });
            Map.PrintClickable(1, 28, new ColoredString("You are at the map marked in this color.", MapPlayerLoc, Color.Black), () => { MapPlayerLoc = new Color(GameLoop.rand.Next(256), GameLoop.rand.Next(256), GameLoop.rand.Next(256)); });

            Map.PrintClickable(49, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Map.IsVisible = false; });
        }

        public static List<CompendiumResult> Sources = new();
        
        public static void DebugDraw() {
            Debug.Clear();
            Helper.DrawBox(Debug, 0, 0, 98, 28);
            Debug.Print(2, 0, "[Debug Menu]");
            Debug.DrawLine(new Point(20, 1), new Point(20, 28), 179);

            Debug.PrintClickable(2, 1, new ColoredString("Overview", DebugMenu == "Overview" ? Color.Yellow : Color.White, Color.Black), () => { DebugMenu = "Overview"; });
            Debug.PrintClickable(2, 3, new ColoredString("Broken Links", DebugMenu == "Unfound" ? Color.Yellow : Color.White, Color.Black), () => { Sources = DebugSources(); DebugMenu = "Unfound"; });
            Debug.PrintClickable(18, 3, new ColoredString("?", Color.MediumPurple, Color.Black), () => { Sources = DebugSources(); DebugMenu = "Unfound"; DebugRandomSource = GameLoop.rand.Next(Sources.Count); });
            
            Debug.PrintClickable(2, 4, new ColoredString("Unobtainable Items", DebugMenu == "Unobtainable" ? Color.Yellow : Color.White, Color.Black), () => { Sources = DebugUnobtainable(); DebugMenu = "Unobtainable"; });
            
            if (DebugMenu == "Overview") {
                Debug.Print(22, 1, "         Locations: " + GameLoop.ZPO.Atlas.Count);
                Debug.Print(22, 2, "             Items: " + GameLoop.ZPO.ItemLibrary.Count);
                Debug.Print(22, 3, "       Use Recipes: " + GameLoop.ZPO.UseRecipes.Count);
                Debug.Print(22, 4, "     Craft Recipes: " + GameLoop.ZPO.CraftLib.Values.Sum(o => o.Count));
                Debug.Print(22, 5, "Processing Recipes: " + (GameLoop.ZPO.ProcessingStations.Values.Sum(o => o.Recipes.Count) - GameLoop.ZPO.ProcessingStations["Fire"].Recipes.Count));
                Debug.Print(22, 6, "              NPCs: " + GameLoop.ZPO.NPCLibrary.Count);
                Debug.Print(22, 7, "          Monsters: " + GameLoop.ZPO.MonsterLibrary.Count);

                int tutorialSteps = GameLoop.ZPO.ClueStepLibrary.Values.Where(o => o.Difficulty == "Tutorial").Count();
                int beginnerSteps = GameLoop.ZPO.ClueStepLibrary.Values.Where(o => o.Difficulty == "Beginner").Count();
                int easySteps = GameLoop.ZPO.ClueStepLibrary.Values.Where(o => o.Difficulty == "Easy").Count();
                int mediumSteps = GameLoop.ZPO.ClueStepLibrary.Values.Where(o => o.Difficulty == "Medium").Count();
                int hardSteps = GameLoop.ZPO.ClueStepLibrary.Values.Where(o => o.Difficulty == "Hard").Count();


                Debug.Print(22, 8, "        Clue Steps: " + tutorialSteps + "t / " + beginnerSteps + "b / " + easySteps + "e / " + mediumSteps + "m / " + hardSteps + "h");
                Debug.Print(22, 9, "            Quests: " + GameLoop.ZPO.QuestLibrary.Count);
            } else { 
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;

                if (Sources.Count > 27) {
                    if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - qty, 0, Sources.Count - 27); }
                    if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + qty, 0, Sources.Count - 27); }
                } else {
                    CompendiumSourceTop = 0;
                }

                int sourceY = 1;
            
                if (DebugMenu == "Unfound")
                    Debug.Print(22, sourceY++, "Things found where the ID may be wrong or refer to a nonexistent item: ", Color.Crimson);
                if (DebugMenu == "Unobtainable")
                    Debug.Print(22, sourceY++, "Items with no source found: ", Color.Crimson);

                for (int source = CompendiumSourceTop; source < Sources.Count && source < CompendiumSourceTop + 27; source++) {
                    Debug.Print(22, sourceY++, Sources[source].Display, DebugRandomSource == sourceY - 2 ? Color.Yellow : Color.White);
                }
            }
        }

        public static List<CompendiumResult> DebugSources() {
            List<CompendiumResult> findings = new();

            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.DigItem != "" && GameLoop.ZPO.ResolveItem(kv.Value.DigItem) == null) {
                    findings.Add(new("Loc: " + kv.Value.ID + ": Dig Item (" + kv.Value.DigItem + ")", "", "", "", "", 0));
                }

                foreach (var conn in kv.Value.ConnectedLocations) {
                    if (!GameLoop.ZPO.Atlas.ContainsKey(conn.Destination)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Conn Dest (" + conn.Destination + ")", "", "", "", "", 0));
                    }

                    if (conn.CheckFailDest != "" && !GameLoop.ZPO.Atlas.ContainsKey(conn.CheckFailDest)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Conn Fail (" + conn.CheckFailDest + ")", "", "", "", "", 0));
                    }
                }

                foreach (var gather in kv.Value.GatheringSpots) {
                    if (!GameLoop.ZPO.GatherSpots.ContainsKey(gather)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Gather (" + gather + ")", "", "", "", "", 0));
                    }
                }

                foreach (var station in kv.Value.ProcessingStations) {
                    if (!GameLoop.ZPO.ProcessingStations.ContainsKey(station)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Station (" + station + ")", "", "", "", "", 0));
                    }
                }

                foreach (var item in kv.Value.ItemSpawns) {
                    if (!GameLoop.ZPO.ItemLibrary.ContainsKey(item.ItemID)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Item Spawn (" + item.ItemID + ")", "", "", "", "", 0));
                    }
                }

                foreach (var mon in kv.Value.AreaMonsters) {
                    if (!GameLoop.ZPO.MonsterLibrary.ContainsKey(mon)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Monster (" + mon + ")", "", "", "", "", 0));
                    }
                }

                if (kv.Value.BossHere != "" && !GameLoop.ZPO.BossLibrary.ContainsKey(kv.Value.BossHere)) {
                    findings.Add(new("Loc: " + kv.Value.ID + ": Boss (" + kv.Value.BossHere + ")", "", "", "", "", 0));
                }

                foreach (var npc in kv.Value.NPCsHere) {
                    if (!GameLoop.ZPO.NPCLibrary.ContainsKey(npc)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": NPC (" + npc + ")", "", "", "", "", 0));
                    }
                }

                foreach (var item in kv.Value.ShopItemsHere) {
                    if (!GameLoop.ZPO.ItemLibrary.ContainsKey(item)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Shop Item (" + item + ")", "", "", "", "", 0));
                    }
                }

                foreach (var patch in kv.Value.FarmingPatchesHere) {
                    if (!GameLoop.ZPO.player.FarmingPatches.ContainsKey(patch)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Farm Patch (" + patch + ")", "", "", "", "", 0));
                    }
                }

                foreach (var hunt in kv.Value.HunterSpots) {
                    if (!GameLoop.ZPO.HunterLibrary.ContainsKey(hunt)) {
                        findings.Add(new("Loc: " + kv.Value.ID + ": Hunter Creature (" + hunt + ")", "", "", "", "", 0));
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.GatherSpots) {
                if (kv.Value.NeededBait != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.NeededBait)) {
                    findings.Add(new("Gather: " + kv.Value.ID + ": Bait (" + kv.Value.NeededBait + ")", "", "", "", "", 0));
                }

                if (kv.Value.PossibleItems != null) {
                    foreach (var loot in kv.Value.PossibleItems) {
                        if (loot.Item != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(loot.Item)) {
                            findings.Add(new("Gather: " + kv.Value.ID + ": Loot (" + loot.Item + ")", "", "", "", "", 0));
                        }
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.ItemLibrary) { 
                if (kv.Value.DropTable != null) {
                    foreach (var loot in kv.Value.DropTable) {
                        if (loot.ItemID != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(loot.ItemID)) {
                            findings.Add(new("Item: " + kv.Value.ID + ": Drop Table (" + loot.ItemID + ")", "", "", "", "", 0));
                        }
                    }

                    foreach (var tp in kv.Value.TeleportLocations) {
                        if (tp != "" && !GameLoop.ZPO.Atlas.ContainsKey(tp)) {
                            findings.Add(new("Item: " + kv.Value.ID + ": TeleLoc (" + tp + ")", "", "", "", "", 0));
                        }
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.ProcessingStations) { 
                if (kv.Value.Recipes != null) {
                    foreach (var loot in kv.Value.Recipes) {
                        if (loot.InputID != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(loot.InputID)) {
                            findings.Add(new("Process: " + kv.Value.Name + ": Recipe In (" + loot.InputID + ")", "", "", "", "", 0));
                        }

                        if (loot.SecondaryIn != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(loot.SecondaryIn)) {
                            findings.Add(new("Process: " + kv.Value.Name + ": Second In (" + loot.SecondaryIn + ")", "", "", "", "", 0));
                        }

                        if (loot.OutputID != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(loot.OutputID)) {
                            findings.Add(new("Process: " + kv.Value.Name + ": Recipe Out (" + loot.OutputID + ")", "", "", "", "", 0));
                        }

                        if (loot.SecondaryOut != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(loot.SecondaryOut)) {
                            findings.Add(new("Process: " + kv.Value.Name + ": Second Out (" + loot.SecondaryOut + ")", "", "", "", "", 0));
                        }
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.UseRecipes) {  
                if (kv.Value.FirstItem != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.FirstItem)) {
                    findings.Add(new("UseRecipe: First Item (" + kv.Value.FirstItem + ")", "", "", "", "", 0));
                }
                
                if (kv.Value.SecondItem != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.SecondItem)) {
                    findings.Add(new("UseRecipe: Second Item (" + kv.Value.SecondItem + ")", "", "", "", "", 0));
                } 

                if (kv.Value.OutputItem != "" && kv.Value.OutputItem[0] != '_' && !GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.OutputItem)) {
                    findings.Add(new("UseRecipe: Output Item (" + kv.Value.OutputItem + ")", "", "", "", "", 0));
                } 
            }

            foreach (var kv in GameLoop.ZPO.NPCLibrary) {  
                foreach (var pick in kv.Value.PickpocketLoot) {
                    if (!GameLoop.ZPO.ItemLibrary.ContainsKey(pick.ItemID)) {
                        findings.Add(new("NPC: " + kv.Value.ID + " Pickpocket (" + pick.ItemID + ")", "", "", "", "", 0));
                    }
                }

                foreach (var dia in kv.Value.Dialogue) {
                    if (dia.Value.ItemsGiven != null) {
                        foreach (var item in dia.Value.ItemsGiven) {
                            string[] split = item.Split(",");
                            if (split[0] != "Gold" && !GameLoop.ZPO.ItemLibrary.ContainsKey(split[0])) {
                                findings.Add(new("NPC: " + kv.Value.ID + " Dialogue (" + split[0] + ")", "", "", "", "", 0));
                            }
                        }
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.MonsterLibrary) {  
                foreach (var drop in kv.Value.DropTable) {
                    if (!GameLoop.ZPO.ItemLibrary.ContainsKey(drop.ItemID)) {
                        findings.Add(new("Monster: " + kv.Value.ID + " Drop (" + drop.ItemID + ")", "", "", "", "", 0));
                    }
                } 
            }

            foreach (var kv in GameLoop.ZPO.CraftLib) {  
                foreach (var rec in kv.Value) {
                    if (rec.ExtraTool != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(rec.ExtraTool)) {
                        findings.Add(new("Craft Rec: " + kv.Key + " Tool (" + rec.ExtraTool + ")", "", "", "", "", 0));
                    }

                    foreach (var need in rec.NeededItems) {
                        string[] split = need.Split(",");
                        if (!GameLoop.ZPO.ItemLibrary.ContainsKey(split[0])) {
                            findings.Add(new("Craft Rec: " + kv.Key + " Material (" + split[0] + ")", "", "", "", "", 0));
                        }
                    }

                    if (!GameLoop.ZPO.ItemLibrary.ContainsKey(rec.OutputItem)) {
                        findings.Add(new("Craft Rec: " + kv.Key + " Output (" + rec.OutputItem + ")", "", "", "", "", 0));
                    }
                } 
            }

            foreach (var kv in GameLoop.ZPO.BossLibrary) {  
                foreach (var drop in kv.Value.DropTable) {
                    if (!GameLoop.ZPO.ItemLibrary.ContainsKey(drop.ItemID)) {
                        findings.Add(new("Boss: " + kv.Value.ID + " Drop (" + drop.ItemID + ")", "", "", "", "", 0));
                    }
                } 
            }

            foreach (var kv in GameLoop.ZPO.HunterLibrary) {  
                foreach (var drop in kv.Value.Drops) {
                    if (!GameLoop.ZPO.ItemLibrary.ContainsKey(drop.ItemID)) {
                        findings.Add(new("Hunter Creature: " + kv.Value.ID + " Drop (" + drop.ItemID + ")", "", "", "", "", 0));
                    }
                } 
            }

            foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {   
                if (kv.Value.Equip1 != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.Equip1)) {
                    findings.Add(new("Clue: " + kv.Value.ID + " Equip1 (" + kv.Value.Equip1 + ")", "", "", "", "", 0));
                } 

                if (kv.Value.Equip2 != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.Equip2)) {
                    findings.Add(new("Clue: " + kv.Value.ID + " Equip2 (" + kv.Value.Equip2 + ")", "", "", "", "", 0));
                }

                if (kv.Value.Equip3 != "" && !GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.Equip3)) {
                    findings.Add(new("Clue: " + kv.Value.ID + " Equip3 (" + kv.Value.Equip3 + ")", "", "", "", "", 0));
                }
            }

            foreach (var kv in GameLoop.ZPO.QuestLibrary) {   
                foreach (var reward in kv.Value.Rewards) {
                    if (reward.RewardType == "Item" && reward.MiscString != "" && reward.MiscString != "Gold" && !GameLoop.ZPO.ItemLibrary.ContainsKey(reward.MiscString)) {
                        findings.Add(new("Quest: " + kv.Value.ID + " Reward (" + reward.MiscString + ")", "", "", "", "", 0));
                    }  
                }
            }

            return findings;
        }
        
        public static void CompendiumDraw() { 
            Point mousePos = new MouseScreenObjectState(Compendium, GameHost.Instance.Mouse).CellPosition;

            Compendium.Clear();
            Helper.DrawBox(Compendium, 0, 0, 98, 28);
            Compendium.Print(2, 0, "[Zero Players Online Compendium]");
            Compendium.DrawLine(new Point(1, 2), new Point(98, 2), 196);

            List<string> Categories = [ "Overview", "Items", "Recipes", "NPCs", "Monsters", "Gathering", "Skills", "Locations", "Quests", "Hunter", "Bosses", "Clues", "Farming", "Spells", "Prayers" ];
             
            if (Helper.RightClicked()) {
                for (int i = 0; i < Categories.Count; i++) {
                    if (Categories[i] == CompendiumCat) {
                        if (i + 1 >= Categories.Count) {
                            CompendiumCat = Categories[0];
                        } else {
                            CompendiumCat = Categories[i+1];
                        }
                        
                        break;
                    }
                }
            }

            int cx = 2;
            for (int i = 0; i < Categories.Count; i++) {
                Compendium.PrintClickable(cx, 1, new ColoredString(CompendiumCat == Categories[i] ? Categories[i] : Categories[i].Substring(0, 2), CompendiumCat == Categories[i] ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = Categories[i]; });
                
                cx += (CompendiumCat == Categories[i] ? Categories[i] : Categories[i].Substring(0, 2)).Length + 1;
            }

            int printY = 3;

            if (CompendiumCat == "Overview") { 
                printY = Compendium.PrintMultiLine(2, printY,
                    "Welcome to Zero Players Online! This is the Compendium, a sort of extremely basic in-game wiki generated directly from the game data and formatted as best as possible." + " /n /n " +
                    "Please take note that there are no spoiler warnings on the pages. You may see information you do not wish to know, or lose out on the sense of discovery from figuring something out yourself. There are no penalties for viewing the information within, but give due consideration before clicking through." + " /n /n " +
                    "The final warning for the Compendium is that the information is not particularly beautified or sorted well. While information will be as complete as possible, it may be difficult to display some things in a way that conveys all intended meaning. Knowledge of the codebase or game mechanics may be required to understand how specific elements connect to eachother." + " /n /n " +
                    ""
                    , 97);
            } 
            else if (CompendiumCat == "Items") { 
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179); 

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "itemFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<Item> items = GameLoop.ZPO.ItemLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (items.Count > 24) {
                    if (mousePos.X < 30) {
                        if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, items.Count - 24); }
                        if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, items.Count - 24); }
                    }
                } else {
                    CompendiumSidebarTop = 0;
                }

                for(int i = CompendiumSidebarTop; i < items.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(1, sidebarY++, items[i].GetNameCS(1, 0), () => { CompendiumViewingID = items[i].ID; CompendiumShowSources = false; });
                }

                if (GameLoop.ZPO.ItemLibrary.TryGetValue(CompendiumViewingID, out Item? item)) {
                    int itemY = 3;

                    Compendium.Print(32, itemY++, "     ID: " + item.ID); 
                    Compendium.Print(71, 3, ("Color: r" + item.colR + " / g" + item.colG + " / b" + item.colB).Align(HorizontalAlignment.Right, 27));
                    Compendium.Print(32, itemY++, "   Name: " + item.GetNameCS(1));  
                    Compendium.PrintClickable(84, 4, "[Show Sources]", () => { CompendiumShowSources = !CompendiumShowSources; Sources = ItemSources(item.ID); });

                    if (!CompendiumShowSources) {
                        Compendium.Print(32, itemY++, "  Value: " + item.Value + "gp, HA: " + item.HighAlchVal() + ", LA: " + item.LowAlchVal(), Color.Goldenrod);  
                        itemY = Compendium.PrintMultiLine(32, itemY, "Examine: " + item.ExamineText, 68);  

                        itemY += 2; 

                        Compendium.Print(32, itemY++, "Stackable " + Helper.Checkmark(item.Stackable) + new ColoredString(" / Tradeable ") + Helper.Checkmark(item.Tradeable) + new ColoredString(" / Noteable ")  + Helper.Checkmark(item.Noteable));
                        itemY++;
                        
                        Compendium.Print(32, itemY++, "MiscString: " + (item.MiscString != "" ? item.MiscString : "(none)"), item.MiscString == "" ? Color.DarkSlateGray : Color.White); 
                        itemY++;
                        
                        if (item.EquipSlot != "") {
                            Compendium.Print(32, itemY++, "Equipment Info:", Color.White); 
                            Compendium.Print(32, itemY++, "Slot: " + item.EquipSlot + " / Tier: " + item.EquipTier + " / Dmg Type: " + (item.EquipDamageType != "" ? item.EquipDamageType : "(none)"), Color.White); 
                            Compendium.Print(32, itemY++, "Skill: " + (item.EquipSkill != "" ? item.EquipSkill : "(none)") + " / Level: " + item.EquipLevel + " / Speed: " + item.AttackSpeed, Color.White);
                            Compendium.Print(32, itemY++, new ColoredString("Ammo: " + (item.EquipAmmo != "" ? item.EquipAmmo : "(none)") + " / TwoHanded: ") + Helper.Checkmark(item.TwoHanded));  
                            itemY++;
                        }

                        Compendium.Print(32, itemY++, "Usage Info:    ConsumedOnUse: " + Helper.Checkmark(item.ConsumedOnUse));  
                        Compendium.Print(32, itemY, "UseString: " + (item.UseString != "" ? item.UseString : "(none)"), Color.White); 
                        Compendium.Print(70, itemY++, "UseInt: " + item.UseInt, Color.White); 
                        Compendium.Print(32, itemY, "UseString2: " + (item.UseString2 != "" ? item.UseString2 : "(none)"), Color.White); 
                        Compendium.Print(70, itemY++, "UseInt2: " + item.UseInt2, Color.White); 
                        Compendium.Print(32, itemY, "UseString3: " + (item.UseString3 != "" ? item.UseString3 : "(none)"), Color.White); 
                        Compendium.Print(70, itemY++, "UseInt3: " + item.UseInt3, Color.White); 
                        Compendium.Print(32, itemY, "MustBeEquipped: " + Helper.Checkmark(item.MustBeEquipped)); 
                        Compendium.Print(70, itemY++, "UseInt4: " + item.UseInt4, Color.White); 
                        Compendium.Print(32, itemY, "DestroyOnDrop: " + Helper.Checkmark(item.DestroyOnDrop)); 
                        Compendium.Print(70, itemY, "Cosmetic: " + Helper.Checkmark(item.Cosmetic)); 
                          
                        if (item.Potion.Count > 0) {
                            itemY += 2;
                            Compendium.Print(32, itemY, "Potion Effects: ", Color.White); 
                            for (int pot = 0; pot < item.Potion.Count; pot++) {
                                Compendium.Print(48, itemY++, item.Potion[pot].Stat + " " + (item.Potion[pot].Change > 0 ? "+" : "") + item.Potion[pot].Change, Color.White); 
                            }
                        }

                        if (item.DropTable.Count > 0) {
                            itemY += 2;

                            int drop = 1;
                            if (Helper.EitherShift())
                                drop *= 5;
                            if (Helper.EitherControl())
                                drop *= 10;


                            if (item.DropTable.Count > 9 && mousePos.X > 30) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - drop, 0, item.DropTable.Count - 9); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + drop, 0, item.DropTable.Count - 9); }
                            } else {
                                CompendiumDropTop = 0;
                            }
                            
                            Compendium.Print(32, itemY++, "Drop Table: ", Color.White); 
                            for (int pot = CompendiumDropTop; pot < item.DropTable.Count && pot < CompendiumDropTop + 9; pot++) {
                                Compendium.PrintClickable(32, itemY++, "| " + GameLoop.ZPO.ResolveItemName(item.DropTable[pot].ItemID) + " (" + item.DropTable[pot].DropX + "/" + item.DropTable[pot].InY + ")", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = item.DropTable[pot].ItemID; }); 
                            }

                        }
                    } else {
                        if (Sources.Count > 20) {
                            if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - qty, 0, Sources.Count - 20); }
                            if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + qty, 0, Sources.Count - 20); }
                        } else {
                            CompendiumSourceTop = 0;
                        }

                        int sourceY = 6;
                        
                        Compendium.Print(32, sourceY++, "Potential Item Sources: ", Color.White);

                        for (int source = CompendiumSourceTop; source < Sources.Count && source < CompendiumSourceTop + 20; source++) {
                            Compendium.PrintClickable(32, sourceY++, new ColoredString("| " + Sources[source].Display, Color.White, Color.Black), () => { ResetAllCompendiumValues(); SetAllCompendiumValues(Sources[source]); });
                        }
                    }  
                }
            } 
            else if (CompendiumCat == "Recipes") {
                Compendium.PrintClickable(4, 3, new ColoredString("Use", CompendiumSubCat == "UseRecipe" ? Color.Yellow : Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Recipes"; CompendiumSubCat = "UseRecipe"; });
                Compendium.PrintClickable(11, 3, new ColoredString("Craft", CompendiumSubCat == "CraftRecipe" ? Color.Yellow : Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Recipes"; CompendiumSubCat = "CraftRecipe"; });
                Compendium.PrintClickable(20, 3, new ColoredString("Process", CompendiumSubCat == "ProcessRecipe" ? Color.Yellow : Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Recipes"; CompendiumSubCat = "ProcessRecipe"; });
                Compendium.DrawLine(new Point(1, 4), new Point(29, 4), 196);
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                 
                Compendium.PrintStringField(2, 5, "Filter: ", ref Filter, ref SelectedField, "recipeFilter");
                Compendium.DrawLine(new Point(1, 6), new Point(29, 6), 196);

                if (CompendiumSubCat == "UseRecipe") {
                    List<Recipe> recipes = GameLoop.ZPO.UseRecipes.Values.ToList().Where(u => (GameLoop.ZPO.ResolveItemName(u.FirstItem).ToLower().Contains(Filter.ToLower()) || GameLoop.ZPO.ResolveItemName(u.SecondItem).ToLower().Contains(Filter.ToLower()) || GameLoop.ZPO.ResolveItemName(u.OutputItem).ToLower().Contains(Filter.ToLower()))).OrderBy(o => GameLoop.ZPO.ResolveItemName(o.OutputItem)).ToList();

                    int qty = 1;
                    if (Helper.EitherShift())
                        qty *= 5;
                    if (Helper.EitherControl())
                        qty *= 10;


                    if (recipes.Count > 20) {
                        if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, recipes.Count - 20); }
                        if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, recipes.Count - 20); }
                    } else {
                        CompendiumSidebarTop = 0;
                    }


                    int sidebarY = 7;
                    for (int i = CompendiumSidebarTop; i < recipes.Count && i < CompendiumSidebarTop + 18; i++) {
                        Item? output = GameLoop.ZPO.ResolveItem(recipes[i].OutputItem);
                        if (output != null) {
                            Compendium.PrintClickable(1, sidebarY++, output.GetNameCS(1), () => { CompendiumViewingID = recipes[i].FirstItem; CompendiumViewingID2 = recipes[i].SecondItem; });
                        } else {
                            Compendium.PrintClickable(1, sidebarY++, new ColoredString(GameLoop.ZPO.ResolveItemName(recipes[i].OutputItem)), () => { CompendiumViewingID = recipes[i].FirstItem; CompendiumViewingID2 = recipes[i].SecondItem; });
                        }
                    }

                    if (CompendiumViewingID != "" && CompendiumViewingID2 != "") {
                        TwoWayString view = new(CompendiumViewingID, CompendiumViewingID2);

                        int viewY = 3;
                        if (GameLoop.ZPO.UseRecipes.TryGetValue(view, out Recipe? viewingRecipe) && viewingRecipe != null) {
                            Compendium.PrintClickable(32, viewY++, new ColoredString(" First Item: " + (viewingRecipe.FirstQty != 0 ? viewingRecipe.FirstQty + "x " : "") + GameLoop.ZPO.ResolveItemName(viewingRecipe.FirstItem), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = viewingRecipe.FirstItem; });
                            Compendium.PrintClickable(32, viewY++, new ColoredString("Second Item: " + (viewingRecipe.SecondQty != 0 ? viewingRecipe.SecondQty + "x " : "") + GameLoop.ZPO.ResolveItemName(viewingRecipe.SecondItem), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = viewingRecipe.SecondItem; });
                            Compendium.PrintClickable(32, viewY++, new ColoredString("Output Item: " + (viewingRecipe.OutputQty != 0 ? viewingRecipe.OutputQty + "x " : "") + GameLoop.ZPO.ResolveItemName(viewingRecipe.OutputItem), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = viewingRecipe.OutputItem; });
                             
                            viewY++;

                            Compendium.Print(32, viewY++, "Skill Level: " + viewingRecipe.SkillLevelReq + " " + viewingRecipe.SkillUsed + " (+" + viewingRecipe.ExpGranted + " exp)", Color.White); 
                            Compendium.Print(32, viewY++, "Misc String: " + viewingRecipe.MiscString, Color.White); 
                             
                            viewY++;
                                
                            Compendium.Print(32, viewY++, " Fail Output: " + viewingRecipe.FailID, Color.White);
                            Compendium.Print(32, viewY++, "Stop Failing: " + viewingRecipe.StopFailLevel, Color.White);

                            if (viewingRecipe.OutputItem == "_fire") {
                                viewY++;
                                Compendium.Print(32, viewY++, "Creates a temporary fire processing station. Uses Range recipes.");
                            }    
                        } 
                    }
                } else if (CompendiumSubCat == "CraftRecipe") {
                    List<string> stations = GameLoop.ZPO.CraftLib.Keys.ToList().Where(u => u.ToLower().Contains(Filter.ToLower())).OrderBy(o => o).ToList();

                    int qty = 1;
                    if (Helper.EitherShift())
                        qty *= 5;
                    if (Helper.EitherControl())
                        qty *= 10;


                    if (CompendiumViewingID2 == "") {
                        if (stations.Count > 24) {
                            if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, stations.Count - 24); }
                            if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, stations.Count - 24); }
                        } else {
                            CompendiumSidebarTop = 0;
                        }
                    }


                    int sidebarY = 7;
                    
                    if (CompendiumViewingID2 == "") {
                        for (int i = CompendiumSidebarTop; i < stations.Count && i < CompendiumSidebarTop + 24; i++) { 
                            Compendium.PrintClickable(2, sidebarY++, stations[i], () => { CompendiumViewingID2 = stations[i]; });
                        }
                    } else {
                        if (GameLoop.ZPO.CraftLib.TryGetValue(CompendiumViewingID2, out List<CraftRecipe>? recipes) && recipes != null) {
                            recipes = recipes.Where(u => (u.Skill.ToLower().Contains(Filter.ToLower())) || GameLoop.ZPO.ResolveItemName(u.ExtraTool).ToLower().Contains(Filter.ToLower()) || GameLoop.ZPO.ResolveItemName(u.OutputItem).ToLower().Contains(Filter.ToLower())).OrderBy(o => GameLoop.ZPO.ResolveItemName(o.OutputItem)).ToList();
                            List<CraftRecipe> masterRecipes = GameLoop.ZPO.CraftLib[CompendiumViewingID2].OrderBy(o => GameLoop.ZPO.ResolveItemName(o.OutputItem)).ToList();

                            if (recipes.Count > 20) {
                                if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, recipes.Count - 20); }
                                if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, recipes.Count - 20); }
                            } else {
                                CompendiumSidebarTop = 0;
                            }

                            Compendium.PrintClickable(2, sidebarY++, CompendiumViewingID2.Align(HorizontalAlignment.Left, 21) + "[BACK]", () => { CompendiumViewingID2 = ""; return; });
                            Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                            for (int i = CompendiumSidebarTop; i < recipes.Count && i < CompendiumSidebarTop + 20; i++) {
                                Item? output = GameLoop.ZPO.ResolveItem(recipes[i].OutputItem);

                                if (output != null) {
                                    Compendium.PrintClickable(2, sidebarY++, output.GetNameCS(), () => { 
                                        for (int j = 0; j < masterRecipes.Count; j++) {
                                            if (masterRecipes[j] == recipes[i]) {
                                                CompendiumViewingIndex = j;
                                            }
                                        } 
                                    }); 
                                } else {
                                    Compendium.PrintClickable(2, sidebarY++, GameLoop.ZPO.ResolveItemName(recipes[i].OutputItem), () => { 
                                        for (int j = 0; j < masterRecipes.Count; j++) {
                                            if (masterRecipes[j] == recipes[i]) {
                                                CompendiumViewingIndex = j;
                                            }
                                        } 
                                    }); 
                                }
                            }
                            
                            if (CompendiumViewingIndex >= 0 && CompendiumViewingIndex < masterRecipes.Count) {
                                CraftRecipe rec = masterRecipes[CompendiumViewingIndex]; 

                                int recY = 3;
                                 
                                Compendium.PrintClickable(32, recY++, new ColoredString("Output Item: " + (rec.OutputQty > 1 ? rec.OutputQty + "x " : "") + GameLoop.ZPO.ResolveItemName(rec.OutputItem), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = rec.OutputItem;});
                                Compendium.PrintClickable(32, recY++, new ColoredString("Tool Needed: " + GameLoop.ZPO.ResolveItemName(rec.ExtraTool), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = rec.ExtraTool;});
                                recY++;
                                
                                Compendium.Print(32, recY++, "Skill: " + rec.Level + " " + rec.Skill + " (+" + rec.ExpGranted + " exp)", Color.White);
                                recY++; 

                                Compendium.Print(32, recY, "Items Needed: ");
                                for (int reagent = 0; reagent < rec.NeededItems.Count; reagent++) {
                                    string[] split = rec.NeededItems[reagent].Split(",");

                                    if (split.Length == 2) {
                                        Compendium.PrintClickable(46, recY++, new ColoredString(split[1] + "x " + GameLoop.ZPO.ResolveItemName(split[0]), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = split[0]; });
                                    } else {
                                        Compendium.PrintClickable(46, recY++, new ColoredString(GameLoop.ZPO.ResolveItemName(rec.NeededItems[reagent]), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = rec.NeededItems[reagent]; });
                                    } 
                                }
                            }
                        }
                    }  
                } else if (CompendiumSubCat == "ProcessRecipe") {
                     List<ProcessingStation> stations = GameLoop.ZPO.ProcessingStations.Values.ToList().Where(u => u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                    int qty = 1;
                    if (Helper.EitherShift())
                        qty *= 5;
                    if (Helper.EitherControl())
                        qty *= 10;


                    if (CompendiumViewingID2 == "") {
                        if (stations.Count > 22) {
                            if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, stations.Count - 22); }
                            if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, stations.Count - 22); }
                        } else {
                            CompendiumSidebarTop = 0;
                        }
                    }


                    int sidebarY = 7;
                    
                    if (CompendiumViewingID2 == "") {
                        for (int i = CompendiumSidebarTop; i < stations.Count && i < CompendiumSidebarTop + 22; i++) { 
                            Compendium.PrintClickable(2, sidebarY++, stations[i].Name, () => { CompendiumViewingID2 = stations[i].Name; Sources = StationLocations(CompendiumViewingID2); });
                        }
                    } else {
                        if (GameLoop.ZPO.ProcessingStations.TryGetValue(CompendiumViewingID2, out ProcessingStation? station) && station != null) {
                            List<ProcessingRecipe> masterRecipes = station.Recipes.OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputID))).ToList();
                            
                            List<ProcessingRecipe> recipes = station.Recipes.Where(u => (GameLoop.ZPO.ResolveItemName(u.InputID).ToLower().Contains(Filter.ToLower())) || (GameLoop.ZPO.ResolveItemName(u.OutputID).ToLower().Contains(Filter.ToLower()))).OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputID))).ToList();
                            
                            if (recipes.Count > 19) {
                                if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, recipes.Count - 19); }
                                if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, recipes.Count - 19); }
                            } else {
                                CompendiumSidebarTop = 0;
                            }

                            Compendium.Print(2, sidebarY, CompendiumViewingID2, Color.White);
                            Compendium.PrintClickable(28, sidebarY, new ColoredString("X", Color.Crimson, Color.Black), () => { CompendiumViewingID2 = ""; return; });
                            Compendium.PrintClickable(26, sidebarY++, new ColoredString("?", Color.MediumPurple, Color.Black), () => { Sources = StationLocations(CompendiumViewingID2); CompendiumViewingIndex = -1; return; });
                            Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                            int recY = 3; 

                            if (station.OpensUI) { 
                                Compendium.Print(2, sidebarY, "Opens UI for Craft Recipes", Color.White);
                            }

                            for (int i = CompendiumSidebarTop; i < recipes.Count && i < CompendiumSidebarTop + 19; i++) {
                                Item? output = GameLoop.ZPO.ResolveItem(recipes[i].OutputID);

                                if (output != null) {
                                    Compendium.PrintClickable(2, sidebarY++, output.GetNameCS(), () => { 
                                        for (int j = 0; j < masterRecipes.Count; j++) {
                                            if (masterRecipes[j] == recipes[i]) {
                                                CompendiumViewingIndex = j;
                                            }
                                        } 
                                    }); 
                                } else {
                                    Compendium.PrintClickable(2, sidebarY++, GameLoop.ZPO.ResolveItemName(recipes[i].OutputID), () => { 
                                        for (int j = 0; j < masterRecipes.Count; j++) {
                                            if (masterRecipes[j] == recipes[i]) {
                                                CompendiumViewingIndex = j;
                                            }
                                        } 
                                    }); 
                                }
                            }
                            
                            if (CompendiumViewingIndex == -1) {
                                int srcQty = 1;
                                if (Helper.EitherShift())
                                    srcQty *= 5;
                                if (Helper.EitherControl())
                                    srcQty *= 10;


                                if (Sources.Count > 20) {
                                    if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - srcQty, 0, Sources.Count - 20); }
                                    if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + srcQty, 0, Sources.Count - 20); }
                                } else {
                                    CompendiumSourceTop = 0;
                                }

                                Compendium.Print(32, recY++, CompendiumViewingID2 + " Locations Found: ", Color.White);
                                if (Sources.Count > 0) {
                                    for (int i = 0; i < Sources.Count; i++) {
                                        Compendium.PrintClickable(32, recY++, "| " + Sources[i].Display, () => { ResetAllCompendiumValues(); SetAllCompendiumValues(Sources[i]); });
                                    }
                                } else { 
                                    Compendium.Print(32, recY++, "| (not found in any map)", Color.DarkSlateGray);
                                }
                            } else if (CompendiumViewingIndex >= 0 && CompendiumViewingIndex < masterRecipes.Count) {
                                ProcessingRecipe rec = masterRecipes[CompendiumViewingIndex];     

                                Compendium.PrintClickable(32, recY++, new ColoredString(" Input Item: " + GameLoop.ZPO.ResolveItemName(rec.InputID), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = rec.InputID;});
                                Compendium.PrintClickable(32, recY++, new ColoredString("Output Item: " + GameLoop.ZPO.ResolveItemName(rec.OutputID), Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = rec.OutputID;});
                                recY++;
                                
                                Compendium.Print(32, recY++, "Skill: " + rec.SkillLevel + " " + rec.SkillUsed + " (+" + rec.SkillEXP + " exp)", Color.White);

                                recY++;
                                
                                Compendium.Print(32, recY++, " Fail Output: " + rec.FailOutput, Color.White);
                                Compendium.Print(32, recY++, "Stop Failing: " + rec.StopFailingLevel, Color.White);
                            }
                        }
                    }  
                }
            } 
            else if (CompendiumCat == "NPCs") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.NPCLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.NPCLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.NPCLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "npcFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<NPC> npcs = GameLoop.ZPO.NPCLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < npcs.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(1, sidebarY++, new ColoredString(npcs[i].Name, (CompendiumViewingID == npcs[i].ID ? Color.Yellow : Color.White), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "NPCs"; CompendiumViewingID = npcs[i].ID; CompendiumViewingIndex = 0; });
                }

                if (GameLoop.ZPO.NPCLibrary.TryGetValue(CompendiumViewingID, out NPC? npc) && npc != null) {
                    int npcY = 3;
                    
                    Compendium.Print(32, npcY++, "  ID: " + npc.ID, Color.White);
                    Compendium.Print(32, npcY++, "Name: " + npc.Name, Color.White);
                    Compendium.PrintClickable(82, 3, "[Show Locations]", () => { CompendiumShowSources = !CompendiumShowSources; if (CompendiumShowSources) { Sources = NPCLocations(npc.ID); } });

                    if (CompendiumShowSources) {
                        npcY++;
                        Compendium.Print(32, npcY++, "Locations Found: ", Color.White);
                        for (int i = 0; i < Sources.Count; i++) {
                            Compendium.PrintClickable(32, npcY++, "| " + Sources[i].Display, () => { ResetAllCompendiumValues(); SetAllCompendiumValues(Sources[i]); });
                        }
                    } else { 
                        if (npc.ReqToSee != null) {
                            npcY++;
                            Compendium.Print(32, npcY++, "Requirement to See: " + npc.ReqToSee.GetSummary(), Color.White);
                        }

                        if (npc.PickpocketLevel > 0) {
                            npcY++;
                            Compendium.Print(32, npcY++, "Pickpocket: " + npc.PickpocketLevel + " (+" + npc.PickpocketEXP + " exp)", Color.White);

                            for (int i = 0; i < npc.PickpocketLoot.Count; i++) {
                                Compendium.PrintClickable(32, npcY++, "| " + GameLoop.ZPO.ResolveItemName(npc.PickpocketLoot[i].ItemID) + " [" + npc.PickpocketLoot[i].DropX + "/" + npc.PickpocketLoot[i].InY + "]", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = npc.PickpocketLoot[i].ItemID; });
                            }
                        }

                        if (npc.SlayerLevel > 0 && npc.SlayerTasks != null && npc.SlayerTasks.Count > 0) { 
                            npcY++;
                            Compendium.Print(32, npcY++, "Slayer Master: Level " + npc.SlayerLevel + " Required", Color.White);

                            for (int i = 0; i < npc.SlayerTasks.Count; i++) {
                                Compendium.PrintClickable(32, npcY++, "| " + GameLoop.ZPO.ResolveMonsterName(npc.SlayerTasks[i].TargetID) + " [" + npc.SlayerTasks[i].KillMin + " - " + npc.SlayerTasks[i].KillMax + "]", () => { ResetAllCompendiumValues(); CompendiumCat = "Monsters"; CompendiumViewingID = npc.SlayerTasks[i].TargetID; });
                            }
                        }

                        if (npc.Dialogue != null && npc.Dialogue.Count > 0) { 
                            npcY++;
                            Compendium.Print(32, npcY++, "Dialogue Stages: ", Color.White); 

                            int diaX = 32;

                            foreach (var kv in npc.Dialogue) {
                                if (diaX > 94) {
                                    diaX = 32;
                                    npcY++;
                                }

                                Compendium.PrintClickable(diaX, npcY, new ColoredString(kv.Key.ToString(), CompendiumViewingIndex == kv.Key ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingIndex = kv.Key; });
                                diaX += kv.Key.ToString().Length + 1; 
                            }

                            npcY += 2;

                            if (npc.Dialogue.TryGetValue(CompendiumViewingIndex, out DialogueStage? stage) && stage != null) {
                                npcY = Compendium.PrintMultiLine(32, npcY, "\"" + stage.Text + "\"", 64);
                                npcY++;
                            
                                if (stage.SetsQuest != "") {
                                    npcY++;
                                    Compendium.PrintClickable(32, npcY++, "Sets Quest: " + stage.SetsQuest + " to stage " + stage.SetsQuestStageTo, () => { ResetAllCompendiumValues(); CompendiumCat = "Quests"; CompendiumViewingID = stage.SetsQuest; CompendiumViewingIndex = stage.SetsQuestStageTo; });
                                }

                                if (stage.ItemsGiven != null && stage.ItemsGiven.Count > 0) {
                                    npcY++;
                                    Compendium.Print(32, npcY++, "Items Given When Stage Reached: ", Color.White);

                                    for (int i = 0; i < stage.ItemsGiven.Count; i++) {
                                        string[] split = stage.ItemsGiven[i].Split(",");
                                        Compendium.PrintClickable(32, npcY++, "| " + (split.Length > 1 && split[1] != "1" ? split[1] + "x " : "") + GameLoop.ZPO.ResolveItemName(split[0]), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = split[0]; });
                                    }
                                }

                                if (stage.Choices != null && stage.Choices.Count > 0) { 
                                    npcY++;
                                    Compendium.Print(32, npcY++, "Dialogue Choices: ", Color.White);

                                    int x = 32;
                                    for (int i = 0; i < stage.Choices.Count; i++) { 
                                        Compendium.PrintClickable(x, npcY, new ColoredString(i.ToString(), CompendiumViewingIndex2 == i ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingIndex2 = i; });
                                        x += i.ToString().Length + 1;
                                    }

                                    npcY += 2;

                                    if (stage.Choices.Count > CompendiumViewingIndex2) { 
                                        Compendium.Print(32, npcY++, "Text: " + stage.Choices[CompendiumViewingIndex2].Text, Color.White); 
                                        Compendium.PrintClickable(32, npcY++, "Leads to Stage: " + stage.Choices[CompendiumViewingIndex2].LeadsToStage, () => { CompendiumViewingIndex = stage.Choices[CompendiumViewingIndex2].LeadsToStage; CompendiumViewingIndex2 = 0; });  
                                        if (stage.Choices[CompendiumViewingIndex2].TeleportTo != "")
                                            Compendium.PrintClickable(32, npcY++, "Teleport " + (stage.Choices[CompendiumViewingIndex2].SetSpawnToo ? "(and set spawn)" : "") + ": " + stage.Choices[CompendiumViewingIndex2].TeleportTo, () => { ResetAllCompendiumValues(); CompendiumCat = "Locations"; CompendiumViewingID = stage.Choices[CompendiumViewingIndex2].TeleportTo;});  
                                        if (stage.Choices[CompendiumViewingIndex2].ClickReqs != null && stage.Choices[CompendiumViewingIndex2].ClickReqs.Count > 0) { 
                                            Compendium.Print(32, npcY++, "Requirements to Click: (Show if not met: " + Helper.Checkmark(stage.Choices[CompendiumViewingIndex2].ShowAnyways) + new ColoredString(")")); 

                                            for (int i = 0; i < stage.Choices[CompendiumViewingIndex2].ClickReqs.Count; i++) {
                                                Compendium.Print(32, npcY++, "| " + stage.Choices[CompendiumViewingIndex2].ClickReqs[i].GetSummary(), Color.White); 
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            } 
            else if (CompendiumCat == "Monsters") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.MonsterLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.MonsterLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.MonsterLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "monFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<AreaMonster> mons = GameLoop.ZPO.MonsterLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < mons.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(mons[i].Name, (CompendiumViewingID == mons[i].ID ? Color.Yellow : Color.White), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Monsters"; CompendiumViewingID = mons[i].ID; });
                }

                if (GameLoop.ZPO.MonsterLibrary.TryGetValue(CompendiumViewingID, out AreaMonster? mon) && mon != null) {
                    int monY = 3;

                    Compendium.Print(32, monY++, "  ID: " + mon.ID, Color.White);
                    Compendium.Print(32, monY++, "Name: " + mon.Name, Color.White);
                    Compendium.PrintClickable(82, 3, "[Show Locations]", () => { CompendiumShowSources = !CompendiumShowSources; if (CompendiumShowSources) { Sources = MonsterLocations(mon.ID); } });
                    
                    if (CompendiumShowSources) {
                        int srcQty = 1;
                        if (Helper.EitherShift())
                            srcQty *= 5;
                        if (Helper.EitherControl())
                            srcQty *= 10;


                        if (Sources.Count > 20) {
                            if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - srcQty, 0, Sources.Count - 20); }
                            if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + srcQty, 0, Sources.Count - 20); }
                        } else {
                            CompendiumSourceTop = 0;
                        }

                        monY++;
                        Compendium.Print(32, monY++, "Locations Found: ", Color.White);
                        if (Sources.Count > 0) {
                            for (int i = CompendiumSourceTop; i < Sources.Count && i < CompendiumSourceTop + 20; i++) {
                                Compendium.PrintClickable(32, monY++, "| " + Sources[i].Display, () => { SetAllCompendiumValues(Sources[i]); });
                            }
                        } else { 
                            Compendium.Print(32, monY++, "| (not found in any map)", Color.White);
                        }
                    } else {
                        monY++;
                        Compendium.Print(32, monY++, "Level: " + mon.Level, Color.White);
                        Compendium.Print(32, monY++, "MaxHP: " + mon.MaxHP, Color.White);
                        monY++;
                        Compendium.Print(32, monY++, "Damage Reduction: " + mon.DamageReduction + "% (Weakness: " + mon.WeakType + ")", Color.White); 
                        Compendium.Print(32, monY++, "Aggro: Lv" + mon.AggroLevel); 
                        Compendium.Print(32, monY++, "Damage: " + mon.DamageDice + " " + mon.DamageType, Color.White);
                        Compendium.Print(32, monY++, "Category: " + mon.SpecialCategory + ", Counts As Slayer ID:" + mon.CountsAsSlayer, Color.White);
                        Compendium.Print(32, monY++, "Respawn: " + mon.RespawnTime + " seconds", Color.White);

                        monY++;
                        Compendium.Print(32, monY++, "Drop Table: ", Color.White);

                        if (mon.DropTable.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (mon.DropTable.Count > 10) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, mon.DropTable.Count - 10); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, mon.DropTable.Count - 10); }
                            } else {
                                CompendiumDropTop = 0;
                            }


                            for (int i = CompendiumDropTop; i < mon.DropTable.Count && i < CompendiumDropTop + 10; i++) { 
                                if (mon.DropTable[i].QuantityMin != mon.DropTable[i].QuantityMax) { 
                                    Compendium.Print(32, monY++, "| " + GameLoop.ZPO.ResolveItemName(mon.DropTable[i].ItemID) + " (" + mon.DropTable[i].QuantityMin + " - " + mon.DropTable[i].QuantityMax + ") [" + mon.DropTable[i].DropX + "/" + mon.DropTable[i].InY + "]", Color.White);
                                } else { 
                                    Compendium.Print(32, monY++, "| " + GameLoop.ZPO.ResolveItemName(mon.DropTable[i].ItemID) + " (" + mon.DropTable[i].QuantityMin + ") [" + mon.DropTable[i].DropX + "/" + mon.DropTable[i].InY + "]", Color.White);
                                }
                            }
                        } else {
                            Compendium.Print(32, monY++, "| " + new ColoredString("no drops", Color.DarkSlateGray, Color.Black));
                        }
                    }
                }
            } 
            else if (CompendiumCat == "Gathering") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.GatherSpots.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.GatherSpots.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.GatherSpots.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "gatherFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<GatheringTile> gathers = GameLoop.ZPO.GatherSpots.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < gathers.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(gathers[i].Name, (CompendiumViewingID == gathers[i].ID ? Color.Yellow : Color.White), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Gathering"; CompendiumViewingID = gathers[i].ID; });
                }

                if (GameLoop.ZPO.GatherSpots.TryGetValue(CompendiumViewingID, out GatheringTile? gather) && gather != null) {
                    int gatherY = 3;

                    Compendium.Print(32, gatherY++, "  ID: " + gather.ID, Color.White);
                    Compendium.Print(32, gatherY++, "Name: " + gather.Name, Color.White);
                    Compendium.PrintClickable(82, 3, "[Show Locations]", () => { CompendiumShowSources = !CompendiumShowSources; if (CompendiumShowSources) { Sources = GatherLocations(gather.ID); } });
                    
                    if (CompendiumShowSources) {
                        gatherY++;
                        Compendium.Print(32, gatherY++, "Locations Found: ", Color.White);

                        if (Sources.Count > 0) {
                            int srcQty = 1;
                            if (Helper.EitherShift())
                                srcQty *= 5;
                            if (Helper.EitherControl())
                                srcQty *= 10;


                            if (Sources.Count > 20) {
                                if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - srcQty, 0, Sources.Count - 20); }
                                if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + srcQty, 0, Sources.Count - 20); }
                            } else {
                                CompendiumSourceTop = 0;
                            }

                            for (int i = CompendiumSourceTop; i < Sources.Count && i < CompendiumSourceTop + 20; i++) {
                                Compendium.PrintClickable(32, gatherY++, "| " + Sources[i].Display, () => { SetAllCompendiumValues(Sources[i]); });
                            }
                        } else {
                            Compendium.Print(32, gatherY++, "| (not found in any map)", Color.DarkSlateGray);
                        }
                    } else {
                        gatherY++; 
                        if (gather.Skill != "")
                            Compendium.Print(32, gatherY++, "Skill: " + gather.Level + " " + gather.Skill + " (+" + gather.ExpGranted + " exp, " + gather.ExpOnFail + " on fail)", Color.White);
                        if (gather.NeedToolCat != "")
                            Compendium.Print(32, gatherY++, "Needed Tool: " + gather.NeedToolCat, Color.White);
                        Compendium.Print(32, gatherY++, "Success Chance: " + gather.SuccessChance + " (Level Based Success " + Helper.Checkmark(gather.LevelBasedSuccess) + new ColoredString(")"));
                        Compendium.Print(32, gatherY++, "Deplete Chance: " + gather.DepleteChance, Color.White);
                        Compendium.Print(32, gatherY++, "  Restock Time: " + gather.RestockTime + " seconds", Color.White);
                        Compendium.Print(32, gatherY++, "Damage on Fail: " + gather.DamageOnFail, Color.White);
                     
                        gatherY++;
                        Compendium.Print(32, gatherY++, "Possible Items: ", Color.White);

                        if (gather.PossibleItems != null && gather.PossibleItems.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (gather.PossibleItems.Count > 10) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, gather.PossibleItems.Count - 10); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, gather.PossibleItems.Count - 10); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            int totalWeight = 0;
                            for (int i = 0; i < gather.PossibleItems.Count; i++) { 
                                totalWeight += gather.PossibleItems[i].Weight;
                            }

                            for (int i = CompendiumDropTop; i < gather.PossibleItems.Count && i < CompendiumDropTop + 15; i++) { 
                                Compendium.PrintClickable(32, gatherY++, "| " + GameLoop.ZPO.ResolveItemName(gather.PossibleItems[i].Item) + " [" + gather.PossibleItems[i].Weight + "/" + totalWeight + "]", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = gather.PossibleItems[i].Item; });
                            }
                        } else { 
                            Compendium.Print(32, gatherY++, "| (no drops)", Color.DarkSlateGray);
                        }
                    }
                }
            } 
            else if (CompendiumCat == "Locations") {
                Compendium.DrawLine(new Point(40, 3), new Point(40, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.Atlas.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.Atlas.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.Atlas.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "locFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(39, sidebarY++), 196);

                List<Location> locs = GameLoop.ZPO.Atlas.Values.Where(u => (u.DisplayName != null && u.DisplayName.ToLower().Contains(Filter.ToLower())) || (u.Region != null && u.Region.ToLower().Contains(Filter.ToLower()))).OrderBy(o => o.DisplayName).ToList();

                for(int i = CompendiumSidebarTop; i < locs.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(Helper.Truncate(locs[i].DisplayName, 38), (CompendiumViewingID == locs[i].ID ? Color.Yellow : Color.White), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Locations"; CompendiumViewingID = locs[i].ID; });
                }

                if (GameLoop.ZPO.Atlas.TryGetValue(CompendiumViewingID, out Location? loc) && loc != null) {
                    int locY = 3;

                    Compendium.Print(42, locY++, "    ID: " + loc.ID, Color.White);
                    Compendium.Print(42, locY++, "  Name: " + loc.DisplayName, Color.White);
                    Compendium.Print(42, locY++, "Region: " + loc.Region, Color.White);

                    locY++;
                    Compendium.Print(42, locY++, "IsBank: " + Helper.Checkmark(loc.IsBank));
                    Compendium.PrintClickable(42, locY++, "Dig Item: " + (loc.DigItem == "" ? "(none)" : GameLoop.ZPO.ResolveItemName(loc.DigItem)), () => { if (loc.DigItem != "") { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = loc.DigItem; }});
                    Compendium.Print(42, locY++, "Dungeon Level: " + loc.DungeoneeringLevel, Color.White);
                    
                    locY++;
                    List<string> tabs = [ "Gather", "Processing", "Items", "NPCs", "Shop", "Farming Patches", "Hunter", "Monsters", "Boss", "Connections" ];
                    int dx = 55; 
                    if (Helper.HotkeyDown(Key.Tab)) { CompendiumViewingIndex2++; if (CompendiumViewingIndex2 >= tabs.Count) { CompendiumViewingIndex2 = 0;} } 

                    Compendium.Print(42, locY, "Things Here: ", Color.White);
                    for (int i = 0; i < tabs.Count; i++) {
                        Compendium.PrintClickable(dx, locY, new ColoredString(CompendiumViewingIndex2 == i ? tabs[i] : tabs[i][0].ToString(), CompendiumViewingIndex2 == i ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingIndex2 = i; });
                        dx += (CompendiumViewingIndex2 == i ? tabs[i] : tabs[i][0].ToString()).Length + 1;
                    }
                    locY++;

                    CompendiumViewingIndex2 = Math.Clamp(CompendiumViewingIndex2, 0, tabs.Count - 1);
                    if (tabs[CompendiumViewingIndex2] == "Gather") {
                        if (loc.GatheringSpots.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.GatheringSpots.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.GatheringSpots.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.GatheringSpots.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.GatheringSpots.Count && i < CompendiumDropTop + 15; i++) { 
                                Compendium.PrintClickable(42, locY++, "| " + GameLoop.ZPO.ResolveGatherName(loc.GatheringSpots[i]), () => { ResetAllCompendiumValues(); CompendiumCat = "Gathering"; CompendiumViewingID = loc.GatheringSpots[i]; });
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no gather spots here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "Processing") {
                        if (loc.ProcessingStations.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.ProcessingStations.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.ProcessingStations.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.ProcessingStations.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.ProcessingStations.Count && i < CompendiumDropTop + 15; i++) { 
                                Compendium.PrintClickable(42, locY++, "| " + GameLoop.ZPO.ResolveGatherName(loc.ProcessingStations[i]), () => { ResetAllCompendiumValues(); CompendiumCat = "Recipes"; CompendiumSubCat = "ProcessRecipe"; CompendiumViewingID2 = loc.ProcessingStations[i]; });
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no processing stations here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "Items") {
                        if (loc.ItemSpawns.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.ItemSpawns.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.ItemSpawns.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.ItemSpawns.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.ItemSpawns.Count && i < CompendiumDropTop + 17; i++) { 
                                Compendium.PrintClickable(42, locY++, "| " + GameLoop.ZPO.ResolveItemName(loc.ItemSpawns[i].ItemID) + " (" + (loc.ItemSpawns[i].ReqToSpawn != null ? loc.ItemSpawns[i].ReqToSpawn.GetSummary() + ")" : ""), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = loc.ItemSpawns[i].ItemID; });
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no item spawns here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "NPCs") {
                        if (loc.NPCsHere.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.NPCsHere.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.NPCsHere.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.NPCsHere.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.NPCsHere.Count && i < CompendiumDropTop + 17; i++) { 
                                if (GameLoop.ZPO.NPCLibrary.TryGetValue(loc.NPCsHere[i], out NPC? npc)) {
                                    Compendium.PrintClickable(42, locY++, "| " + npc.Name + (npc.ReqToSee != null ? " (" + npc.ReqToSee.GetSummary() + ")" : ""), () => { ResetAllCompendiumValues(); CompendiumCat = "NPCs"; CompendiumViewingID = npc.ID; });
                                } else {
                                    Compendium.PrintClickable(42, locY++, "| " + loc.NPCsHere[i], () => { ResetAllCompendiumValues(); CompendiumCat = "NPCs"; CompendiumViewingID = loc.NPCsHere[i]; });
                                }
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no NPCs here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "Shop") {
                        if (loc.ShopItemsHere.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.ShopItemsHere.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.ShopItemsHere.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.ShopItemsHere.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.ShopItemsHere.Count && i < CompendiumDropTop + 17; i++) { 
                                Item? item = GameLoop.ZPO.ResolveItem(loc.ShopItemsHere[i]);

                                if (item != null) {
                                    Compendium.PrintClickable(42, locY++, "| " + item.Name + " (" + item.Value + "gp)", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = item.ID; });
                                } else {
                                    Compendium.PrintClickable(42, locY++, "| " + loc.ShopItemsHere[i], () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = loc.ShopItemsHere[i]; });
                                }
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no shop items here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "Farming Patches") {
                        if (loc.FarmingPatchesHere.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.FarmingPatchesHere.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.FarmingPatchesHere.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.FarmingPatchesHere.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.FarmingPatchesHere.Count && i < CompendiumDropTop + 17; i++) {  
                                if (GameLoop.ZPO.player.FarmingPatches.TryGetValue(loc.FarmingPatchesHere[i], out FarmingPatch? patch)) {
                                    Compendium.PrintClickable(42, locY++, "| " + patch.PatchType + (patch.SeedPlanted != "" ? " (" + GameLoop.ZPO.ResolveItemName(patch.SeedPlanted) + ", " + patch.TimeLeft + ")" : ""), () => { ResetAllCompendiumValues(); CompendiumCat = "Farming"; CompendiumViewingID = patch.ID; });
                                } else {
                                    Compendium.Print(42, locY++, "| " + loc.FarmingPatchesHere[i], Color.White);
                                }
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no farming patches here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "Hunter") {
                        if (loc.HunterSpots.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.HunterSpots.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.HunterSpots.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.HunterSpots.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.HunterSpots.Count && i < CompendiumDropTop + 17; i++) {  
                                if (GameLoop.ZPO.HunterLibrary.TryGetValue(loc.HunterSpots[i], out HunterCreature? hunter)) {
                                    Compendium.PrintClickable(42, locY++, "| " + hunter.Name + " (Lv" + hunter.CatchLevel + ", " + hunter.CatchEXP + " exp, " + GameLoop.ZPO.ResolveItemName(hunter.CatchID) + ")", () => { ResetAllCompendiumValues(); CompendiumCat = "Hunter"; CompendiumViewingID = hunter.ID; });
                                } else {
                                    Compendium.Print(42, locY++, "| " + loc.HunterSpots[i], Color.White);
                                }
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no hunter creatures here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "Monsters") {
                        if (loc.AreaMonsters.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.AreaMonsters.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.AreaMonsters.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.AreaMonsters.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.AreaMonsters.Count && i < CompendiumDropTop + 17; i++) {  
                                if (GameLoop.ZPO.MonsterLibrary.TryGetValue(loc.AreaMonsters[i], out AreaMonster? mon)) {
                                    Compendium.PrintClickable(42, locY++, "| " + mon.Name, () => { ResetAllCompendiumValues(); CompendiumCat = "Monsters"; CompendiumViewingID = mon.ID; });
                                } else {
                                    Compendium.PrintClickable(42, locY++, "| " + loc.AreaMonsters[i], () => { ResetAllCompendiumValues(); CompendiumCat = "Monsters"; CompendiumViewingID = loc.AreaMonsters[i]; });
                                }
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no monsters here)", Color.DarkSlateGray);
                        }
                    } else if (tabs[CompendiumViewingIndex2] == "Boss") {
                        if (loc.BossHere != "") {
                            if (GameLoop.ZPO.BossLibrary.TryGetValue(loc.BossHere, out BossFight? boss) && boss != null) {
                                Compendium.PrintClickable(42, locY++, "| " + boss.Name, () => { ResetAllCompendiumValues(); CompendiumCat = "Bosses"; CompendiumViewingID = boss.ID; });
                            } else { 
                                Compendium.PrintClickable(42, locY++, "| " + loc.BossHere, () => { ResetAllCompendiumValues(); CompendiumCat = "Bosses"; CompendiumViewingID = loc.BossHere; });
                            } 
                        } else {
                            Compendium.Print(42, locY++, "| (no boss here)", Color.DarkSlateGray);
                        }
                    }  else if (tabs[CompendiumViewingIndex2] == "Connections") {
                        if (loc.ConnectedLocations.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (loc.ConnectedLocations.Count > 17) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, loc.ConnectedLocations.Count - 17); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, loc.ConnectedLocations.Count - 17); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < loc.ConnectedLocations.Count && i < CompendiumDropTop + 17; i++) {  
                                Connection conn = loc.ConnectedLocations[i];

                                ColoredString line = new("| " + GameLoop.ZPO.ResolveLocationName(conn.Destination));

                                if (conn.AltName != "")
                                    line = new("| " + conn.AltName); 
                                if (conn.ExpTo != "") {
                                    line += new ColoredString(" (+" + conn.ExpGranted + " " + conn.ExpTo + " exp, Check: ") + Helper.Checkmark(conn.SkillCheck) + new ColoredString(")");
                                } 
                                Compendium.PrintClickable(42, locY++, line, () => { ResetAllCompendiumValues(); CompendiumCat = "Locations"; CompendiumViewingID = conn.Destination; }); 
                                 
                                if (conn.SkillCheck) {
                                    Compendium.PrintClickable(42, locY++, "| (above if fail check) " + GameLoop.ZPO.ResolveLocationName(conn.CheckFailDest), () => { ResetAllCompendiumValues(); CompendiumCat = "Locations"; CompendiumViewingID = conn.CheckFailDest; });
                                }
                            }
                        } else {
                            Compendium.Print(42, locY++, "| (no connections here)", Color.DarkSlateGray);
                        }
                    }
                }
            } 
            else if (CompendiumCat == "Quests") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.QuestLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.QuestLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.QuestLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "questFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<Quest> quests = GameLoop.ZPO.QuestLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < quests.Count && i < CompendiumSidebarTop + 24; i++) {
                    Color col = Color.White;

                    if (GameLoop.ZPO.player.QuestLog.TryGetValue(quests[i].ID, out QuestStatus? questProg) && questProg != null) {
                        if (questProg.CurrentStage != -1) { col = Color.Yellow; } 
                        if (questProg.CurrentStage == quests[i].CompleteStage) { col = Color.Lime; }
                    } 

                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(quests[i].Name, (CompendiumViewingID == quests[i].ID ? Color.Turquoise : col), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Quests"; CompendiumViewingID = quests[i].ID; });
                }

                if (GameLoop.ZPO.QuestLibrary.TryGetValue(CompendiumViewingID, out Quest? quest) && quest != null) {
                    int questY = 3; 

                    Compendium.Print(32, questY++, "          ID: " + quest.ID, Color.White);
                    Compendium.Print(86, questY - 1, "QP: " + quest.QuestPoints, Color.White);
                    Compendium.Print(32, questY++, "        Name: " + quest.Name, Color.White); 
                    Compendium.Print(83, questY - 1, "Added: " + quest.DateFullyImplemented, Color.White);
                    Compendium.Print(32, questY++, "      Length: " + quest.Length, Color.White);  
                    Compendium.Print(32, questY++, "  Difficulty: " + quest.Difficulty, Color.White);

                    if (quest.RegionsNeeded != null && quest.RegionsNeeded.Count > 0) {
                        string regions = ""; 
                        for (int i = 0; i < quest.RegionsNeeded.Count; i++) {
                            regions += (i != 0 ? ", " : "") + quest.RegionsNeeded[i];
                        }

                        Compendium.Print(32, questY++, "Need Regions: " + regions, Color.White);    
                    }
                    questY++;
                    Compendium.Print(32, questY, "Description: ", Color.White); 
                    Compendium.PrintMultiLine(45, questY++, quest.Description, 53);

                    questY += 4;  
                    
                    Compendium.PrintClickable(32, questY++, "  Start NPC: " + GameLoop.ZPO.ResolveNPCName(quest.StartNPC), () => { ResetAllCompendiumValues(); CompendiumCat = "Quests"; CompendiumViewingID = quest.StartNPC; }); 
                    questY++;
                    Compendium.Print(32, questY, "Tabs: ", Color.White);
                    Compendium.PrintClickable(38, questY, new ColoredString("Requirements", CompendiumViewingID2 == "Requirements" ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingID2 = "Requirements"; });
                    Compendium.PrintClickable(51, questY, new ColoredString("Rewards", CompendiumViewingID2 == "Rewards" ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingID2 = "Rewards"; });
                    Compendium.PrintClickable(59, questY++, new ColoredString("Stages", CompendiumViewingID2 == "Stages" ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingID2 = "Stages"; });


                    if (CompendiumViewingID2 == "Requirements") {
                        if (quest.RequirementsToStart != null && quest.RequirementsToStart.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (quest.RequirementsToStart.Count > 10) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, quest.RequirementsToStart.Count - 10); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, quest.RequirementsToStart.Count - 10); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < quest.RequirementsToStart.Count && i < CompendiumDropTop + 10 && questY < 29; i++) { 
                                Compendium.Print(32, questY++, "| " + quest.RequirementsToStart[i].GetSummary(), quest.CanStartQuest(GameLoop.ZPO.player) ? Color.Lime : Color.Crimson);
                            }
                        } else {
                            Compendium.Print(32, questY++, "| (no requirements)", Color.DarkSlateGray);  
                        }
                    } else if (CompendiumViewingID2 == "Rewards") {
                        if (quest.Rewards != null && quest.Rewards.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (quest.Rewards.Count > 10) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, quest.Rewards.Count - 10); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, quest.Rewards.Count - 10); }
                            } else {
                                CompendiumDropTop = 0;
                            } 

                            for (int i = CompendiumDropTop; i < quest.Rewards.Count && i < CompendiumDropTop + 10 && questY < 29; i++) { 
                                Compendium.Print(32, questY++, "| " + quest.Rewards[i].GetSummary(), Color.White);
                            }
                        } else {
                            Compendium.Print(32, questY++, "| (no rewards)", Color.DarkSlateGray);  
                        }
                    }  else if (CompendiumViewingID2 == "Stages") {
                        if (quest.Stages != null && quest.Stages.Count > 0) {  
                            int qx = 32;
                            int qy = questY;
                            questY++;

                            foreach (var kv in quest.Stages) {
                                Compendium.PrintClickable(qx, qy, new ColoredString(kv.Key.ToString(), CompendiumViewingIndex2 == kv.Key ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingIndex2 = kv.Key; return; });
                                qx += kv.Key.ToString().Length + 1;

                                if (kv.Key == CompendiumViewingIndex2) { 
                                    Compendium.Print(32, questY++, "  Next Stage: " + kv.Value.LeadsToStage, Color.White);  
                                    Compendium.Print(32, questY, "ProgressType: " + kv.Value.ProgressType, Color.White);

                                    if (GameLoop.ZPO.ItemLibrary.ContainsKey(kv.Value.MiscString))
                                        Compendium.PrintClickable(65, questY++, "Item: " + GameLoop.ZPO.ResolveItemName(kv.Value.MiscString), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = kv.Value.MiscString; });
                                    else if (GameLoop.ZPO.NPCLibrary.ContainsKey(kv.Value.MiscString))
                                        Compendium.PrintClickable(65, questY++, "NPC: " + GameLoop.ZPO.ResolveNPCName(kv.Value.MiscString), () => { ResetAllCompendiumValues(); CompendiumCat = "NPCs"; CompendiumViewingID = kv.Value.MiscString; });
                                    else
                                        Compendium.Print(65, questY++, "MiscString: " + kv.Value.MiscString, Color.White);
                                    if (kv.Value.MiscInt != 0)
                                        Compendium.Print(32, questY++, "     MiscInt: " + kv.Value.MiscInt, Color.White);  
                                    Compendium.PrintMultiLine(32, questY++, " Description: " + kv.Value.Description, 66);
                                } 
                            }
                        } else {
                            Compendium.Print(32, questY++, "| (no stages found, quest may not be implemented yet)", Color.DarkSlateGray);  
                        }
                    } 
                }
            }
            else if (CompendiumCat == "Hunter") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.HunterLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.HunterLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.HunterLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "hunterFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<HunterCreature> creatures = GameLoop.ZPO.HunterLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < creatures.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(creatures[i].Name, (CompendiumViewingID == creatures[i].ID ? Color.Yellow : Color.White), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Hunter"; CompendiumViewingID = creatures[i].ID; });
                }

                if (GameLoop.ZPO.HunterLibrary.TryGetValue(CompendiumViewingID, out HunterCreature? creature) && creature != null) {
                    int hunterY = 3;

                    Compendium.Print(32, hunterY++, "  ID: " + creature.ID, Color.White);
                    Compendium.Print(32, hunterY++, "Name: " + creature.Name, Color.White);
                    Compendium.Print(71, 3, ("Color: r" + creature.R + " / g" + creature.G + " / b" + creature.B).Align(HorizontalAlignment.Right, 27), creature.GetColor());
                    Compendium.PrintClickable(82, 4, "[Show Locations]", () => { CompendiumShowSources = !CompendiumShowSources; if (CompendiumShowSources) { Sources = HunterLocations(creature.ID); } });
                    
                    if (CompendiumShowSources) {
                        hunterY++;
                        Compendium.Print(32, hunterY++, "Locations Found: ", Color.White);

                        if (Sources.Count > 0) {
                            int srcQty = 1;
                            if (Helper.EitherShift())
                                srcQty *= 5;
                            if (Helper.EitherControl())
                                srcQty *= 10;


                            if (Sources.Count > 20) {
                                if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - srcQty, 0, Sources.Count - 20); }
                                if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + srcQty, 0, Sources.Count - 20); }
                            } else {
                                CompendiumSourceTop = 0;
                            }

                            for (int i = CompendiumSourceTop; i < Sources.Count && i < CompendiumSourceTop + 20; i++) {
                                Compendium.PrintClickable(32, hunterY++, "| " + Sources[i].Display, () => { SetAllCompendiumValues(Sources[i]); });
                            }
                        } else {
                            Compendium.Print(32, hunterY++, "| (not found in any map)", Color.DarkSlateGray);
                        }
                    } else {
                        hunterY++; 

                        
                        Compendium.PrintClickable(32, hunterY++, "Catch: " + creature.CatchLevel + " Hunter with " + GameLoop.ZPO.ResolveItemName(creature.CatchID) + " (+" + creature.CatchEXP + " exp)", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = creature.CatchID; });
                        Compendium.PrintClickable(32, hunterY++, " Lure: " + GameLoop.ZPO.ResolveItemName(creature.LureID), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = creature.LureID; });
                        
                        hunterY++;

                        Compendium.Print(32, hunterY++, "Lifetime: " + creature.SecondsToDisappear, Color.White);
                        Compendium.Print(32, hunterY++, "Respawn Time: " + creature.RespawnTime, Color.White); 
                     
                        hunterY++;
                        Compendium.Print(32, hunterY++, "Possible Items: ", Color.White);

                        if (creature.Drops != null && creature.Drops.Count > 0) {
                            int dropQty = 1;
                            if (Helper.EitherShift())
                                dropQty *= 5;
                            if (Helper.EitherControl())
                                dropQty *= 10;


                            if (creature.Drops.Count > 10) {
                                if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, creature.Drops.Count - 10); }
                                if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, creature.Drops.Count - 10); }
                            } else {
                                CompendiumDropTop = 0;
                            }  

                            for (int i = CompendiumDropTop; i < creature.Drops.Count && i < CompendiumDropTop + 15; i++) { 
                                Compendium.PrintClickable(32, hunterY++, "| " + GameLoop.ZPO.ResolveItemName(creature.Drops[i].ItemID) + " [" + creature.Drops[i].DropX + "/" + creature.Drops[i].InY + "]", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = creature.Drops[i].ItemID; });
                            }
                        } else { 
                            Compendium.Print(32, hunterY++, "| (no drops)", Color.DarkSlateGray);
                        }
                    }
                }
            }
            else if (CompendiumCat == "Bosses") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.BossLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.BossLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.BossLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "bossFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<BossFight> bosses = GameLoop.ZPO.BossLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < bosses.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(bosses[i].Name, (CompendiumViewingID == bosses[i].ID ? Color.Yellow : Color.White), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Bosses"; CompendiumViewingID = bosses[i].ID; });
                }

                if (GameLoop.ZPO.BossLibrary.TryGetValue(CompendiumViewingID, out BossFight? boss) && boss != null) {
                    int bossY = 3;

                    Compendium.Print(32, bossY++, "  ID: " + boss.ID, Color.White);
                    Compendium.Print(32, bossY++, "Name: " + boss.Name, Color.White); 
                    Compendium.PrintClickable(82, 3, "[Show Locations]", () => { CompendiumShowSources = !CompendiumShowSources; if (CompendiumShowSources) { Sources = BossLocations(boss.ID); } });
                    
                    if (CompendiumShowSources) {
                        bossY++;
                        Compendium.Print(32, bossY++, "Locations Found: ", Color.White);

                        if (Sources.Count > 0) {
                            int srcQty = 1;
                            if (Helper.EitherShift())
                                srcQty *= 5;
                            if (Helper.EitherControl())
                                srcQty *= 10;


                            if (Sources.Count > 20) {
                                if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - srcQty, 0, Sources.Count - 20); }
                                if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + srcQty, 0, Sources.Count - 20); }
                            } else {
                                CompendiumSourceTop = 0;
                            }

                            for (int i = CompendiumSourceTop; i < Sources.Count && i < CompendiumSourceTop + 20; i++) {
                                Compendium.PrintClickable(32, bossY++, "| " + Sources[i].Display, () => { SetAllCompendiumValues(Sources[i]); });
                            }
                        } else {
                            Compendium.Print(32, bossY++, "| (not found in any map)", Color.DarkSlateGray);
                        }
                    } else {
                        bossY++; 

                        Compendium.Print(32, bossY++, "Level: " + boss.Level, Color.White);
                        Compendium.Print(32, bossY++, "MaxHP: " + boss.MaxHP, Color.White);
                        Compendium.Print(32, bossY++, "Special Category: " + boss.SpecialCategory + ", Counts as Slayer ID: " + boss.CountsAsSlayer, Color.White); 
                        bossY++;
                        Compendium.Print(32, bossY++, "Damage Reduction: " + boss.DamageReduction + "% (Weakness: " + boss.WeakType + ")", Color.White); 
                        Compendium.Print(32, bossY++, "Aggro: Lv" + boss.AggroLevel + " (Always Aggro: " + Helper.Checkmark(boss.AlwaysAggro) + new ColoredString(")")); 
                        Compendium.Print(32, bossY++, "Default Damage: " + boss.DefaultDmgDice + " " + boss.DefaultDmgType, Color.White);
                        Compendium.Print(32, bossY++, "Attack Speed: " + boss.AttackSpeedInMS + "ms", Color.White);
                        Compendium.Print(32, bossY++, "Attacks Between Specials: " + boss.AttacksBetweenSpecials, Color.White);
                        bossY++; 
                        Compendium.Print(32, bossY++, "Respawn: " + boss.RespawnTime + " seconds", Color.White);
                        Compendium.Print(32, bossY++, "Lanes Here: " + boss.LanesHere, Color.White); 

                        bossY++;
                        Compendium.Print(32, bossY, "Tables: ", Color.White);
                        Compendium.PrintClickable(40, bossY, new ColoredString("Drops", CompendiumViewingIndex2 == 0 ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingIndex2 = 0; });
                        Compendium.PrintClickable(46, bossY++, new ColoredString("Attacks", CompendiumViewingIndex2 == 1 ? Color.Yellow : Color.DarkSlateGray, Color.Black), () => { CompendiumViewingIndex2 = 1; }); 

                        if (CompendiumViewingIndex2 == 0) {
                            bossY++;
                            Compendium.Print(32, bossY++, "Possible Items: ", Color.White);

                            if (boss.DropTable != null && boss.DropTable.Count > 0) {
                                int dropQty = 1;
                                if (Helper.EitherShift())
                                    dropQty *= 5;
                                if (Helper.EitherControl())
                                    dropQty *= 10;


                                if (boss.DropTable.Count > 8) {
                                    if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, boss.DropTable.Count - 8); }
                                    if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, boss.DropTable.Count - 8); }
                                } else {
                                    CompendiumDropTop = 0;
                                }  

                                for (int i = CompendiumDropTop; i < boss.DropTable.Count && i < CompendiumDropTop + 8; i++) { 
                                    Compendium.PrintClickable(32, bossY++, "| " + GameLoop.ZPO.ResolveItemName(boss.DropTable[i].ItemID) + " [" + boss.DropTable[i].DropX + "/" + boss.DropTable[i].InY + "]", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = boss.DropTable[i].ItemID; });
                                }
                            } else { 
                                Compendium.Print(32, bossY++, "| (no drops)", Color.DarkSlateGray);
                            }
                        } else if (CompendiumViewingIndex2 == 1) {
                            bossY++;
                            Compendium.Print(32, bossY++, "Possible Attacks: ", Color.White);

                            if (boss.Specials != null && boss.Specials.Count > 0) {
                                int dropQty = 1;
                                if (Helper.EitherShift())
                                    dropQty *= 5;
                                if (Helper.EitherControl())
                                    dropQty *= 10;


                                if (boss.Specials.Count > 4) {
                                    if (Helper.ScrolledUp()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop - dropQty, 0, boss.Specials.Count - 4); }
                                    if (Helper.ScrolledDown()) { CompendiumDropTop = Math.Clamp(CompendiumDropTop + dropQty, 0, boss.Specials.Count - 4); }
                                } else {
                                    CompendiumDropTop = 0;
                                }  

                                for (int i = CompendiumDropTop; i < boss.Specials.Count && i < CompendiumDropTop + 4; i++) {
                                    string lanes = "";

                                    for (int j = 0; j < boss.Specials[i].HitsLanes.Count; j++) {
                                        lanes += (j != 0 ? ", " : "") + boss.Specials[i].HitsLanes[j];
                                    }
                                    Compendium.Print(32, bossY++, Helper.Truncate(boss.Specials[i].WarningText, 67), Color.White);
                                    Compendium.Print(32, bossY++, "> " + boss.Specials[i].DamageDice + " " + boss.Specials[i].DamageType + ", Lanes: " + lanes, Color.White);
                                }
                            } else { 
                                Compendium.Print(32, bossY++, "| (no specials)", Color.DarkSlateGray);
                            }
                        }
                    }
                }
            }
            else if (CompendiumCat == "Farming") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.player.FarmingPatches.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.player.FarmingPatches.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.player.FarmingPatches.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "farmFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<FarmingPatch> patches = GameLoop.ZPO.player.FarmingPatches.Values.Where(u => (u.ID != null && u.ID.ToLower().Contains(Filter.ToLower())) || (u.PatchType != null && u.PatchType.ToLower().Contains(Filter.ToLower()))).OrderBy(o => o.ID).ToList();

                for(int i = CompendiumSidebarTop; i < patches.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(patches[i].ID, (CompendiumViewingID == patches[i].ID ? Color.Turquoise : (patches[i].SeedPlanted != "" && patches[i].TimeLeft <= 0) ? Color.Lime : (patches[i].SeedPlanted != "" && patches[i].TimeLeft > 0) ? Color.Yellow : Color.White), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Farming"; CompendiumViewingID = patches[i].ID; });
                }

                if (GameLoop.ZPO.player.FarmingPatches.TryGetValue(CompendiumViewingID, out FarmingPatch? patch) && patch != null) {
                    int patchY = 3;

                    Compendium.Print(32, patchY++, "  ID: " + patch.ID, Color.White);
                    Compendium.Print(32, patchY++, "Type: " + patch.PatchType, Color.White); 
                    Compendium.PrintClickable(82, 3, "[Show Locations]", () => { CompendiumShowSources = !CompendiumShowSources; if (CompendiumShowSources) { Sources = PatchLocations(patch.ID); } });
                    
                    if (CompendiumShowSources) {
                        patchY++;
                        Compendium.Print(32, patchY++, "Locations Found: ", Color.White);

                        if (Sources.Count > 0) {
                            int srcQty = 1;
                            if (Helper.EitherShift())
                                srcQty *= 5;
                            if (Helper.EitherControl())
                                srcQty *= 10;


                            if (Sources.Count > 20) {
                                if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - srcQty, 0, Sources.Count - 20); }
                                if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + srcQty, 0, Sources.Count - 20); }
                            } else {
                                CompendiumSourceTop = 0;
                            }

                            for (int i = CompendiumSourceTop; i < Sources.Count && i < CompendiumSourceTop + 20; i++) {
                                Compendium.PrintClickable(32, patchY++, "| " + Sources[i].Display, () => { SetAllCompendiumValues(Sources[i]); });
                            }
                        } else {
                            Compendium.Print(32, patchY++, "| (not found in any map)", Color.DarkSlateGray);
                        }
                    } else {
                        patchY++; 

                        if (patch.SeedPlanted != "") {
                            Compendium.PrintClickable(32, patchY++, "Seed Planted: " + GameLoop.ZPO.ResolveItemName(patch.SeedPlanted), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = patch.SeedPlanted; });
                            Compendium.Print(32, patchY++, "Time Remaining: " + patch.SeedPlanted, Color.White);
                            Compendium.Print(32, patchY++, "Compost: " + patch.Compost, Color.DarkSlateGray);
                        } else {
                            Compendium.Print(32, patchY++, "No Seed Planted", Color.DarkSlateGray);
                        }
                    }
                }
            } 
            else if (CompendiumCat == "Clues") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.ClueStepLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.ClueStepLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.ClueStepLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "clueFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<ClueStep> clues = GameLoop.ZPO.ClueStepLibrary.Values.Where(u => (u.ID != null && u.ID.ToLower().Contains(Filter.ToLower())) || (u.HintText != null && u.HintText.ToLower().Contains(Filter.ToLower()))).OrderBy(o => o.ID).ToList();

                for(int i = CompendiumSidebarTop; i < clues.Count && i < CompendiumSidebarTop + 24; i++) {
                    Color col = Color.White;

                    if (GameLoop.ZPO.player.CurrentClueTutorial == clues[i].ID)
                        col = Color.Yellow;
                    if (GameLoop.ZPO.player.CurrentClueBeginner == clues[i].ID)
                        col = Color.Yellow;
                    if (GameLoop.ZPO.player.CurrentClueEasy == clues[i].ID)
                        col = Color.Yellow;
                    if (GameLoop.ZPO.player.CurrentClueMedium == clues[i].ID)
                        col = Color.Yellow;
                    if (GameLoop.ZPO.player.CurrentClueHard == clues[i].ID)
                        col = Color.Yellow;
                    if (GameLoop.ZPO.player.CurrentClueElite == clues[i].ID)
                        col = Color.Yellow;
                    if (GameLoop.ZPO.player.CurrentClueMaster == clues[i].ID)
                        col = Color.Yellow;

                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(clues[i].ID, (CompendiumViewingID == clues[i].ID ? Color.Turquoise : col), Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Clues"; CompendiumViewingID = clues[i].ID; });
                }

                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(CompendiumViewingID, out ClueStep? clue) && clue != null) {
                    int clueY = 3;

                    Compendium.Print(32, clueY++, "  ID: " + clue.ID, Color.White);
                    Compendium.Print(32, clueY, "Hint: ", Color.White);
                    
                    clueY = Compendium.PrintMultiLine(38, clueY++, clue.HintText, 60, Color.SandyBrown.R, Color.SandyBrown.G, Color.SandyBrown.B);
                    
                    clueY += 2; 
                    
                    Compendium.Print(32, clueY++, "Difficulty: " + clue.Difficulty, Color.White);
                    Compendium.Print(32, clueY++, " Clue Type: " + clue.ClueType, Color.White);
                    Compendium.PrintClickable(32, clueY++, " Solve Map: " + GameLoop.ZPO.ResolveLocationName(clue.SolveLoc), () => { ResetAllCompendiumValues(); CompendiumCat = "Locations"; CompendiumViewingID = clue.SolveLoc; });
                    Compendium.Print(32, clueY++, "EmoteOrNPC: " + GameLoop.ZPO.ResolveNPCName(clue.EmoteOrNpc), Color.White);

                    clueY++; 
                    Compendium.PrintClickable(32, clueY++, "Equip 1: " + GameLoop.ZPO.ResolveItemName(clue.Equip1), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = clue.Equip1; });
                    Compendium.PrintClickable(32, clueY++, "Equip 2: " + GameLoop.ZPO.ResolveItemName(clue.Equip2), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = clue.Equip2; });
                    Compendium.PrintClickable(32, clueY++, "Equip 3: " + GameLoop.ZPO.ResolveItemName(clue.Equip3), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = clue.Equip3; });
                }
            }
            else if (CompendiumCat == "Skills") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.player.Skills.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.player.Skills.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.player.Skills.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3;  
                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "skillFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<Skill> skills = GameLoop.ZPO.player.Skills.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < skills.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(skills[i].Name, CompendiumViewingID == skills[i].Name ? Color.Yellow : Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Skills"; CompendiumViewingID = skills[i].Name; Sources = AllSkillUses(skills[i].Name); });
                }

                if (GameLoop.ZPO.player.Skills.TryGetValue(CompendiumViewingID, out Skill? skill) && skill != null) {
                    int skillY = 3;

                    Compendium.Print(32, skillY, "Name: " + skill.Name, Color.White);
                    Compendium.Print(57, skillY, "Level: " + skill.Level, Color.White); 
                    Compendium.Print(72, skillY, "Exp: " + skill.Exp + "/" + skill.ExpToLevel(), Color.White);  

                    skillY += 2;

                    if (Sources.Count > 0) {
                        int srcQty = 1;
                        if (Helper.EitherShift())
                            srcQty *= 5;
                        if (Helper.EitherControl())
                            srcQty *= 10;


                        if (Sources.Count > 24) {
                            if (Helper.ScrolledUp()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop - srcQty, 0, Sources.Count - 24); }
                            if (Helper.ScrolledDown()) { CompendiumSourceTop = Math.Clamp(CompendiumSourceTop + srcQty, 0, Sources.Count - 24); }
                        } else {
                            CompendiumSourceTop = 0;
                        }

                        for (int i = CompendiumSourceTop; i < Sources.Count && i < CompendiumSourceTop + 24; i++) {
                            int.TryParse(Sources[i].Display[1..4], out int level);
                            Compendium.PrintClickable(32, skillY++, new ColoredString(Helper.Truncate(Sources[i].Display, 67), level <= skill.Level ? Color.White : Color.DarkSlateGray, Color.Black), () => { SetAllCompendiumValues(Sources[i]); });
                        }
                    } else {
                        Compendium.Print(32, skillY++, "(skill doesn't gate any content)", Color.DarkSlateGray);
                    }   
                }
            }
            else if (CompendiumCat == "Spells") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.SpellLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.SpellLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.SpellLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "spellFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<Spell> spells = GameLoop.ZPO.SpellLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Level).ToList();

                for(int i = CompendiumSidebarTop; i < spells.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(spells[i].Name, CompendiumViewingID == spells[i].Name ? Color.Yellow : Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Spells"; CompendiumViewingID = spells[i].ID; });
                }

                if (GameLoop.ZPO.SpellLibrary.TryGetValue(CompendiumViewingID, out Spell? spell) && spell != null) {
                    int spellY = 3;

                    Compendium.Print(32, spellY++, "       Name: " + spell.Name, Color.White);  
                    Compendium.Print(32, spellY++, "       Book: " + spell.Book, Color.White); 
                    Compendium.Print(32, spellY++, "   Category: " + spell.Category, Color.White); 
                    Compendium.Print(32, spellY++, "Description: " + spell.Description, Color.White); 

                    spellY++;
                    Compendium.Print(32, spellY++, "      Level: " + spell.Level, Color.White);
                    Compendium.Print(32, spellY++, "Exp on Cast: " + spell.ExpOnCast, Color.White);  
                    Compendium.Print(32, spellY++, "       Tier: " + spell.Tier, Color.White);  
                    Compendium.Print(32, spellY++, " MiscString: " + spell.MiscString, Color.White);
                    Compendium.Print(32, spellY++, "Cooldown MS: " + spell.CooldownInMS, Color.White);

                    spellY++;
                    
                    Compendium.Print(32, spellY++, "Runes per Cast: ", Color.White);
                    if (spell.Runes != null && spell.Runes.Count > 0) {
                        for (int i = 0; i < spell.Runes.Count; i++) {
                            string[] split = spell.Runes[i].Split(",");
                            Compendium.PrintClickable(32, spellY++, "| " + (split.Length > 1 ? split[1] + "x " : "") + GameLoop.ZPO.ResolveItemName(split[0]), () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = split[0]; });
                        }
                    } else {
                        Compendium.Print(32, spellY++, "| (no runes required)", Color.DarkSlateGray);
                    }
                } 
            }
            else if (CompendiumCat == "Prayers") {
                Compendium.DrawLine(new Point(30, 3), new Point(30, 28), 179);
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.PrayerLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.PrayerLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.PrayerLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "prayerFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<Prayer> prayers = GameLoop.ZPO.PrayerLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Level).ToList();

                for(int i = CompendiumSidebarTop; i < prayers.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(prayers[i].Name, CompendiumViewingID == prayers[i].Name ? Color.Yellow : Color.White, Color.Black), () => { ResetAllCompendiumValues(); CompendiumCat = "Prayers"; CompendiumViewingID = prayers[i].Name; });
                }

                if (GameLoop.ZPO.PrayerLibrary.TryGetValue(CompendiumViewingID, out Prayer? prayer) && prayer != null) {
                    int prayerY = 3;

                    Compendium.Print(32, prayerY++, "        Name: " + prayer.Name, Color.White);  
                    Compendium.Print(32, prayerY++, "        Book: " + prayer.Book, Color.White); 
                    Compendium.Print(32, prayerY++, " Description: " + prayer.Description, Color.White); 

                    prayerY++;
                    Compendium.Print(32, prayerY++, "       Level: " + prayer.Level, Color.White);
                    Compendium.Print(32, prayerY++, "Skill Buffed: " + prayer.SkillBuffed, Color.White);
                } 
            }
        
            
            Compendium.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Compendium.IsVisible = false; });    
        }

        public static void ResetAllCompendiumValues() {
            CompendiumCat = "";
            CompendiumSubCat = "";
            CompendiumViewingID = "";
            CompendiumViewingID2 = "";
            CompendiumViewingIndex = 0;
            CompendiumViewingIndex2 = 0;
            CompendiumShowSources = false; 
        }

        public static void SetAllCompendiumValues(CompendiumResult res) {
            CompendiumCat = res.Category;
            CompendiumSubCat = res.SubCategory;
            CompendiumViewingID = res.ViewID;
            CompendiumViewingID2 = res.ViewID2;
            CompendiumViewingIndex = res.ViewIndex;
            CompendiumViewingIndex2 = res.ViewIndex2;
            CompendiumSourceTop = 0;
            CompendiumDropTop = 0;
        }

        public static List<CompendiumResult> StationLocations(string id) {
            List<CompendiumResult> sources = new();
            
            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.ProcessingStations != null && kv.Value.ProcessingStations.Count > 0) {
                    if (kv.Value.ProcessingStations.Contains(id)) {
                        sources.Add(new("[" + kv.Value.Region + "] " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 1));
                    }
                }
            }
            
            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> PatchLocations(string id) {
            List<CompendiumResult> sources = new();
            
            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.FarmingPatchesHere != null && kv.Value.FarmingPatchesHere.Count > 0) {
                    if (kv.Value.FarmingPatchesHere.Contains(id)) {
                        sources.Add(new("[" + kv.Value.Region + "] " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 5));
                    }
                }
            }
            
            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

         public static List<CompendiumResult> BossLocations(string id) {
            List<CompendiumResult> sources = new();
            
            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.BossHere != null && kv.Value.BossHere == id) { 
                        sources.Add(new("[" + kv.Value.Region + "] " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 8)); 
                }
            }
            
            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> HunterLocations(string id) {
            List<CompendiumResult> sources = new();
            
            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.HunterSpots != null && kv.Value.HunterSpots.Count > 0) {
                    if (kv.Value.HunterSpots.Contains(id)) {
                        sources.Add(new("[" + kv.Value.Region + "] " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 6));
                    }
                }
            }
            
            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> GatherLocations(string id) {
            List<CompendiumResult> sources = new();
            
            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.GatheringSpots != null && kv.Value.GatheringSpots.Count > 0) {
                    if (kv.Value.GatheringSpots.Contains(id)) {
                        sources.Add(new("[" + kv.Value.Region + "] " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 0));
                    }
                }
            }
            
            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> MonsterLocations(string id) {
            List<CompendiumResult> sources = new();
            
            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.AreaMonsters != null && kv.Value.AreaMonsters.Count > 0) {
                    if (kv.Value.AreaMonsters.Contains(id)) {
                        sources.Add(new("[" + kv.Value.Region + "] " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 7));
                    }
                }
            }
            
            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> NPCLocations(string id) {
            List<CompendiumResult> sources = new();
            
            foreach (var kv in GameLoop.ZPO.Atlas) {
                if (kv.Value.NPCsHere != null && kv.Value.NPCsHere.Count > 0) {
                    if (kv.Value.NPCsHere.Contains(id)) {
                        sources.Add(new("[" + kv.Value.Region + "] " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 3));
                    }
                }
            }
            
            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> AllSkillUses(string id) {
            List<CompendiumResult> sources = new();

            foreach (var kv in GameLoop.ZPO.ItemLibrary) {
                if (kv.Value.EquipSkill == id) {
                    sources.Add(new("[" + kv.Value.EquipLevel.ToString().Align(HorizontalAlignment.Right, 3) + "] Equip " + kv.Value.Name, "Items", "", kv.Value.ID, "", 0) );
                }
            }

            foreach (var kv in GameLoop.ZPO.UseRecipes) {
                if (kv.Value.SkillUsed == id) {
                    sources.Add(new("[" + kv.Value.SkillLevelReq.ToString().Align(HorizontalAlignment.Right, 3) + "] Use " + GameLoop.ZPO.ResolveItemName(kv.Value.FirstItem) + " on " + GameLoop.ZPO.ResolveItemName(kv.Value.SecondItem) + " to make " + GameLoop.ZPO.ResolveItemName(kv.Value.OutputItem), "Recipes", "UseRecipe", kv.Value.FirstItem, kv.Value.SecondItem, 0) );
                }
            }

            foreach (var kv in GameLoop.ZPO.CraftLib) {
                List<CraftRecipe> recipes = kv.Value.OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputItem))).ToList();
                for (int i = 0; i < recipes.Count; i++) {
                    if (recipes[i].Skill == id) {
                        sources.Add(new("[" + recipes[i].Level.ToString().Align(HorizontalAlignment.Right, 3) + "] Craft " + GameLoop.ZPO.ResolveItemName(recipes[i].OutputItem) + " at " + recipes[i].Station, "Recipes", "CraftRecipe", "", recipes[i].Station, i));
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.ProcessingStations) {
                List<ProcessingRecipe> recipes = kv.Value.Recipes.OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputID))).ToList();
                for (int i = 0; i < recipes.Count; i++) {
                    if (recipes[i].SkillUsed == id) {
                        if (kv.Value.Name != "Fire")
                            sources.Add(new("[" + recipes[i].SkillLevel.ToString().Align(HorizontalAlignment.Right, 3) + "] Process " + GameLoop.ZPO.ResolveItemName(recipes[i].InputID) + " to " + GameLoop.ZPO.ResolveItemName(recipes[i].OutputID) + " at " + kv.Value.Name, "Recipes", "ProcessRecipe", "", kv.Value.Name, i));
                    
                        if (recipes[i].SkillUsed == "Cooking" && recipes[i].StopFailingLevel > 0) {
                            sources.Add(new("[" + recipes[i].SkillLevel.ToString().Align(HorizontalAlignment.Right, 3) + "] Stop burning " + GameLoop.ZPO.ResolveItemName(recipes[i].InputID) + " on " + kv.Value.Name, "Recipes", "ProcessRecipe", "", kv.Value.Name, i));
                        }    
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.Atlas) {
                for (int i = 0; i < kv.Value.ConnectedLocations.Count; i++) {
                    if (kv.Value.ConnectedLocations[i].ExpTo == id) { 
                        sources.Add(new("[" + kv.Value.ConnectedLocations[i].Level.ToString().Align(HorizontalAlignment.Right, 3) + "] Map: " + kv.Value.DisplayName + " [" + kv.Value.Region + "] to " + (kv.Value.ConnectedLocations[i].AltName == "" ? GameLoop.ZPO.ResolveLocationName(kv.Value.ConnectedLocations[i].Destination) : kv.Value.ConnectedLocations[i].AltName), "Locations", "", kv.Value.ID, "", 0, 9));
                    }
                } 

                if (kv.Value.DungeoneeringLevel > 0 && id == "Dungeoneering") {
                    sources.Add(new("[" + kv.Value.DungeoneeringLevel.ToString().Align(HorizontalAlignment.Right, 3) + "] Dungeon: " + kv.Value.DisplayName + " [" + kv.Value.Region + "]", "Locations", "", kv.Value.ID, "", 0));
                }
            }

            foreach (var kv in GameLoop.ZPO.ItemLibrary) {  
                if (kv.Value.UseString == "CleanHerb" && id == "Herblore") {
                    sources.Add(new("[" + kv.Value.UseInt.ToString().Align(HorizontalAlignment.Right, 3) + "] Clean " + kv.Value.Name, "Items", "", kv.Value.ID, "", 0));
                }

                if (kv.Value.UseString == "PlantSeed" && id == "Farming") {
                    sources.Add(new("[" + kv.Value.UseInt.ToString().Align(HorizontalAlignment.Right, 3) + "] Plant " + kv.Value.Name, "Items", "", kv.Value.ID, "", 0));
                }
            }

            foreach (var kv in GameLoop.ZPO.GatherSpots) {
                if (kv.Value.Skill == id) {
                    if (kv.Value.PossibleItems != null && kv.Value.PossibleItems.Count > 1) {
                        for (int i = 0; i < kv.Value.PossibleItems.Count; i++) {
                            int level = kv.Value.Level;
                            if (kv.Value.PossibleItems[i].MiscInt != 0)
                                level = kv.Value.PossibleItems[i].MiscInt;

                            sources.Add(new("[" + level.ToString().Align(HorizontalAlignment.Right, 3) + "] " + kv.Value.InteractVerb + " " + kv.Value.Name + " - " + GameLoop.ZPO.ResolveItemName(kv.Value.PossibleItems[i].Item), "Gathering", "", kv.Value.ID, "", 0));
                        }
                    } else {
                        sources.Add(new("[" + kv.Value.Level.ToString().Align(HorizontalAlignment.Right, 3) + "] " + kv.Value.InteractVerb + " " + kv.Value.Name, "Gathering", "", kv.Value.ID, "", 0));
                    }
                } 
            }

            foreach (var kv in GameLoop.ZPO.QuestLibrary) {
                if (kv.Value.RequirementsToStart != null) {
                    for (int i = 0; i < kv.Value.RequirementsToStart.Count; i++) {
                        if (kv.Value.RequirementsToStart[i].RequirementType == "Skill" && kv.Value.RequirementsToStart[i].MiscString == id) { 
                            sources.Add(new("[" + kv.Value.RequirementsToStart[i].MiscInt.ToString().Align(HorizontalAlignment.Right, 3) + "] Required to Start Quest: " + kv.Value.Name, "Quests", "", kv.Value.ID, "", 0));
                        }
                    }
                } 
            }

            foreach (var kv in GameLoop.ZPO.NPCLibrary) { 
                if (kv.Value.ReqToSee != null && kv.Value.ReqToSee.RequirementType == "Skill" && kv.Value.ReqToSee.MiscString == id) {
                    sources.Add(new("[" + kv.Value.ReqToSee.MiscInt.ToString().Align(HorizontalAlignment.Right, 3) + "] See NPC: " + kv.Value.Name, "NPCs", "", kv.Value.ID, "", 0));
                }

                if (kv.Value.PickpocketLevel > 0 && id == "Thieving") { 
                    sources.Add(new("[" + kv.Value.PickpocketLevel.ToString().Align(HorizontalAlignment.Right, 3) + "] Pickpocket " + kv.Value.Name, "NPCs", "", kv.Value.ID, "", 0)); 
                }
            }

            if (id == "Hunter") {
                foreach (var kv in GameLoop.ZPO.HunterLibrary) { 
                    sources.Add(new("[" + kv.Value.CatchLevel.ToString().Align(HorizontalAlignment.Right, 3) + "] Catch " + kv.Value.Name, "Hunter", "", kv.Value.ID, "", 0, 9));      
                } 
            }

            if (id == "Magic") {
                foreach (var kv in GameLoop.ZPO.SpellLibrary) {
                    sources.Add(new("[" + kv.Value.Level.ToString().Align(HorizontalAlignment.Right, 3) + "] Cast " + kv.Value.Name + " (" + kv.Value.Book + " Spellbook)", "Spells", "", kv.Value.ID, "", 0));  
                }
            }

            if (id == "Prayer") {
                foreach (var kv in GameLoop.ZPO.PrayerLibrary) {
                    sources.Add(new("[" + kv.Value.Level.ToString().Align(HorizontalAlignment.Right, 3) + "] Pray for " + kv.Value.Name + " (" + kv.Value.Book + " Prayers)", "Prayers", "", kv.Value.Name, "", 0));  
                }
            }

            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> ItemSources(string id) {
            List<CompendiumResult> sources = new();

            foreach (var kv in GameLoop.ZPO.UseRecipes) {
                if (kv.Value.OutputItem == id) {
                    sources.Add(new("UseRecipe: " + GameLoop.ZPO.ResolveItemName(kv.Value.FirstItem) + " + " + GameLoop.ZPO.ResolveItemName(kv.Value.SecondItem), "Recipes", "UseRecipe", kv.Value.FirstItem, kv.Value.SecondItem, 0) );
                }

                if (kv.Value.FailID == id) {
                    sources.Add(new("UseRecipe: " + GameLoop.ZPO.ResolveItemName(kv.Value.FirstItem) + " + " + GameLoop.ZPO.ResolveItemName(kv.Value.SecondItem) + " failed below " + kv.Value.StopFailLevel + " " + kv.Value.SkillUsed, "Recipes", "UseRecipe", kv.Value.FirstItem, kv.Value.SecondItem, 0));
                }
            }

            foreach (var kv in GameLoop.ZPO.CraftLib) {
                List<CraftRecipe> recipes = kv.Value.OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputItem))).ToList();
                for (int i = 0; i < recipes.Count; i++) {
                    if (recipes[i].OutputItem == id) {
                        sources.Add(new("CraftRecipe: " + recipes[i].Level + " " + recipes[i].Skill + " at " + recipes[i].Station, "Recipes", "CraftRecipe", "", recipes[i].Station, i));
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.ProcessingStations) {
                List<ProcessingRecipe> recipes = kv.Value.Recipes.OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputID))).ToList();
                for (int i = 0; i < recipes.Count; i++) {
                    if (recipes[i].OutputID == id) {
                        if (recipes[i].SkillLevel > 0) {
                            sources.Add(new("Processing: " + GameLoop.ZPO.ResolveItemName(recipes[i].InputID) + " at " + kv.Value.Name + " (" + recipes[i].SkillLevel + " " + recipes[i].SkillUsed + ")", "Recipes", "ProcessRecipe", "", kv.Value.Name, i));
                        } else {
                            sources.Add(new("Processing: " + GameLoop.ZPO.ResolveItemName(recipes[i].InputID) + " at " + kv.Value.Name, "Recipes", "ProcessRecipe", "", kv.Value.Name, i));
                        }
                    }

                    if (recipes[i].FailOutput == id) {
                        sources.Add(new("Processing: " + GameLoop.ZPO.ResolveItemName(recipes[i].InputID) + " failed at " + kv.Value.Name + " below " + recipes[i].StopFailingLevel + " " + recipes[i].SkillUsed, "Recipes", "ProcessRecipe", "", kv.Value.Name, i));
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.MonsterLibrary) {
                for (int i = 0; i < kv.Value.DropTable.Count; i++) {
                    if (kv.Value.DropTable[i].ItemID == id) {
                        sources.Add(new("Drop: " + kv.Value.DropTable[i].DropX + "/" + kv.Value.DropTable[i].InY + " from " + kv.Value.Name, "Monsters", "", kv.Value.ID, "", 0));
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.BossLibrary) {
                for (int i = 0; i < kv.Value.DropTable.Count; i++) {
                    if (kv.Value.DropTable[i].ItemID == id) {
                        sources.Add(new("Boss: " + kv.Value.DropTable[i].DropX + "/" + kv.Value.DropTable[i].InY + " from " + kv.Value.Name, "Bosses", "", kv.Value.ID, "", 0));
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.Atlas) {
                for (int i = 0; i < kv.Value.ItemSpawns.Count; i++) {
                    if (kv.Value.ItemSpawns[i].ItemID == id) {
                        sources.Add(new("Map Spawn: " + kv.Value.DisplayName, "Locations", "", kv.Value.ID, "", 0, 2));
                    }
                }

                if (kv.Value.ShopItemsHere != null) {
                    for (int i = 0; i < kv.Value.ShopItemsHere.Count; i++) {
                        if (kv.Value.ShopItemsHere[i] == id) {
                            sources.Add(new("Shop: " + kv.Value.DisplayName + " [" + kv.Value.Region + "]", "Locations", "", kv.Value.ID, "", 0, 4));
                        }
                    }
                }

                if (kv.Value.DigItem != null && kv.Value.DigItem != "" && kv.Value.DigItem == id) {
                    sources.Add(new("Dig at Location: " + kv.Value.DisplayName + " [" + kv.Value.Region + "]", "Locations", "", kv.Value.ID, "", 0));
                }
            }

            foreach (var kv in GameLoop.ZPO.ItemLibrary) {
                for (int i = 0; i < kv.Value.DropTable.Count; i++) {
                    if (kv.Value.DropTable[i].ItemID == id) {
                        sources.Add(new("Item Loot: " + kv.Value.DropTable[i].DropX + "/" + kv.Value.DropTable[i].InY + " from " + kv.Value.Name, "Items", "", kv.Value.ID, "", 0));
                    }
                }

                if (kv.Value.UseString == "CleanHerb" && kv.Value.UseString2 == id) {
                    sources.Add(new("Clean Herb: " + kv.Value.Name + " at " + kv.Value.UseInt + " Herblore", "Items", "", kv.Value.ID, "", 0));
                }

                if (kv.Value.UseString == "PlantSeed" && kv.Value.UseString3 == id) {
                    sources.Add(new("Seed Produce: " + kv.Value.Name + " at " + kv.Value.UseInt + " Farming", "Items", "", kv.Value.ID, "", 0));
                }

                if (kv.Value.ItemReturned == id) {
                    sources.Add(new("Returned when " + kv.Value.Name + " is fully consumed.", "Items", "", kv.Value.ID, "", 0));
                }

                if (kv.Value.UseString == "Transform" && kv.Value.UseString2 == id) { sources.Add(new("Received from Activating: " + kv.Value.Name, "Items", "", kv.Value.ID, "", 0)); }
                if (kv.Value.UseString == "Extinguish" && kv.Value.UseString2 == id) { sources.Add(new("Received from Extinguishing: " + kv.Value.Name, "Items", "", kv.Value.ID, "", 0)); }
            }

            foreach (var kv in GameLoop.ZPO.GatherSpots) {
                if (kv.Value.PossibleItems != null) {
                    for (int i = 0; i < kv.Value.PossibleItems.Count; i++) {
                        if (kv.Value.PossibleItems[i].Item == id) {
                            int totalWeight = 0;

                            for (int j = 0; j < kv.Value.PossibleItems.Count; j++) {
                                totalWeight += kv.Value.PossibleItems[j].Weight;
                            }

                            sources.Add(new("Gather: " + kv.Value.PossibleItems[i].Weight + "/" + totalWeight + " from " + kv.Value.Name, "Gathering", "", kv.Value.ID, "", 0));
                        }
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.QuestLibrary) {
                if (kv.Value.Rewards != null) {
                    for (int i = 0; i < kv.Value.Rewards.Count; i++) {
                        if (kv.Value.Rewards[i].RewardType == "Item" && kv.Value.Rewards[i].MiscString == id) {
                            sources.Add(new("Quest Reward: " + kv.Value.Name, "Quests", "", kv.Value.ID, "", 0));
                        }
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.NPCLibrary) {
                if (kv.Value.Dialogue != null) {
                    foreach (var kv2 in kv.Value.Dialogue) {
                        if (kv2.Value.ItemsGiven != null) {
                            for (int i = 0; i < kv2.Value.ItemsGiven.Count; i++) {
                                if (kv2.Value.ItemsGiven[i].Split(",")[0] == id) {
                                    sources.Add(new("Given by NPC: " + kv.Value.Name, "NPCs", "", kv.Value.ID, "", kv2.Key));
                                }
                            }
                        }
                    }

                    if (kv.Value.PickpocketLoot != null) {  
                        for (int i = 0; i < kv.Value.PickpocketLoot.Count; i++) {
                            if (kv.Value.PickpocketLoot[i].ItemID == id) { 
                                sources.Add(new("Pickpocket: " + kv.Value.PickpocketLoot[i].DropX + "/" + kv.Value.PickpocketLoot[i].InY + " from " + kv.Value.Name, "NPCs", "", kv.Value.ID, "", 0));
                            }
                        }
                    }
                }
            }

            foreach (var kv in GameLoop.ZPO.HunterLibrary) {
                if (kv.Value.Drops != null) {
                    for (int i = 0; i < kv.Value.Drops.Count; i++ ) { 
                        if (kv.Value.Drops[i].ItemID == id) {
                            sources.Add(new("Hunter: " + kv.Value.Drops[i].DropX + "/" + kv.Value.Drops[i].InY + " from " + kv.Value.Name, "Hunter", "", kv.Value.ID, "", 0, 9));
                        }
                    }
                }
            } 

            if (id == "mtaAlchCoin") { sources.Add(new("Cast Low or High Alchemy on the items from Alchemist's Playground in Mage Training Arena.", "Items", "", id, "", 0)); }
            if (id == "fruitPeach") { sources.Add(new("Cast Bones to Peaches with low level bones in your inventory.", "Items", "", id, "", 0)); }
            if (id == "maskDragith") { sources.Add(new("Activate any of the five pieces of the mask with all five parts in your inventory.", "Items", "", id, "", 0)); }


            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }

        public static List<CompendiumResult> DebugUnobtainable() { 
            List<CompendiumResult> sources = new();

            foreach (var kv in GameLoop.ZPO.ItemLibrary) {
                if (ItemSources(kv.Key).Count == 0) {
                    sources.Add(new("Item: " + GameLoop.ZPO.ResolveItemName(kv.Key) + " (" + kv.Key + ")", "", "", "", "", 0, 0));
                }
            }


            return sources;
        }


        static List<AreaMonster> monsterList = new();
        static List<BossFight> bossList = new();

        public static void CollectionLogDraw() { 
            Point mousePos = new MouseScreenObjectState(CollectionLog, GameHost.Instance.Mouse).CellPosition;
            CollectionLog.Clear();
            Helper.DrawBox(CollectionLog, 0, 0, 98, 28);
            CollectionLog.Print(2, 0, "[Collection Log]");


            CollectionLog.DrawLine(new Point(25, 1), new Point(25, 28), 179, Color.White);

            if (CollectionCat == "Clue") {
                CollectionLog.PrintClickable(2, 1, new ColoredString("Tutorial Casket", CollectionID == "casketTutorial" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketTutorial"; });
                CollectionLog.PrintClickable(2, 2, new ColoredString("Beginner Casket", CollectionID == "casketBeginner" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketBeginner"; });
                CollectionLog.PrintClickable(2, 3, new ColoredString("Easy Casket", CollectionID == "casketEasy" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketEasy"; });
                CollectionLog.PrintClickable(2, 4, new ColoredString("Medium Casket", CollectionID == "casketMedium" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketMedium"; });
                CollectionLog.PrintClickable(2, 5, new ColoredString("Hard Casket", CollectionID == "casketHard" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketHard"; });
                CollectionLog.PrintClickable(2, 6, new ColoredString("Elite Casket", CollectionID == "casketElite" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketElite"; });
                CollectionLog.PrintClickable(2, 7, new ColoredString("Master Casket", CollectionID == "casketMaster" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketMaster"; });
                CollectionLog.PrintClickable(2, 7, new ColoredString("General Collection", CollectionID == "General" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "General"; });
                
                Item? cask = null;

                GameLoop.ZPO.ItemLibrary.TryGetValue(CollectionID, out cask);

                if (CollectionID == "General") {
                    GameLoop.ZPO.ItemLibrary.TryGetValue("casketEasy", out cask);
                }


                if (cask != null && GameLoop.ZPO.player.CollectionLogClues.ContainsKey(CollectionID)) { 
                    int qty = 1;
                    if (Helper.EitherShift()) {
                        qty *= 5;
                    }
                    if (Helper.EitherControl()) {
                        qty *= 10;
                    }

                    int count = cask.DropTable.Where(o => o.AltLog == CollectionID || (CollectionID != "General" && o.AltLog == "")).ToList().Count;

                    if (count > 24) {
                        if (Helper.ScrolledUp()) { CollectionDropTop = Math.Clamp(CollectionDropTop - qty, 0, count - 24); }
                        if (Helper.ScrolledDown()) { CollectionDropTop = Math.Clamp(CollectionDropTop + qty, 0, count - 24); }
                    }

                    int KC = 0;

                    if (GameLoop.ZPO.player.CollectionLogClues.ContainsKey(CollectionID)) {
                        KC = GameLoop.ZPO.player.CollectionLogClues[CollectionID].KillCount;
                    }

                    CollectionLog.Print(26, 1, (cask.Name + " (" + KC + " Opened)").Align(HorizontalAlignment.Center, 72), Color.White);
                    CollectionLog.DrawLine(new Point(26, 2), new Point(98, 2), 196, Color.White);
                    CollectionLog.Print(27, 3, "Item Name", Color.White);
                    CollectionLog.Print(79, 3, "Chance", Color.White);
                    CollectionLog.Print(90, 3, "Obtained", Color.White);
                    CollectionLog.DrawLine(new Point(26, 4), new Point(98, 4), 196, Color.White);

                    int printCount = 0;
                    List<ItemDrop> dropsSorted = cask.DropTable.Where(o => o.AltLog == CollectionID || (CollectionID != "General" && o.AltLog == "")).OrderBy(o => o.InY).ThenBy(p => GameLoop.ZPO.ResolveItemName(p.ItemID)).ToList();
                    for (int i = CollectionDropTop; i < dropsSorted.Count && i < CollectionDropTop + 24; i++) { 
                        int timesObtained = 0;

                        if (GameLoop.ZPO.player.CollectionLogClues[CollectionID].DropsObtained.ContainsKey(dropsSorted[i].ItemID)) {
                            timesObtained = GameLoop.ZPO.player.CollectionLogClues[CollectionID].DropsObtained[dropsSorted[i].ItemID];
                        }

                        string name = GameLoop.ZPO.ResolveItemName(dropsSorted[i].ItemID); 

                        if (dropsSorted[i].QuantityMax > 1) {
                            if (dropsSorted[i].QuantityMin == dropsSorted[i].QuantityMax) {
                                name += " (" + dropsSorted[i].QuantityMin + ")";
                            } else { 
                                name += " (" + dropsSorted[i].QuantityMin + "-" + dropsSorted[i].QuantityMax + ")";
                            }
                        }

                        string dropchance = (dropsSorted[i].DropX).ToString().PadLeft(5) + " in " + dropsSorted[i].InY;

                        Color col = timesObtained > 0 ? Color.White : Color.DarkSlateGray;
                        if (mousePos.Y == 5 + printCount && mousePos.X > 25)
                            col = col.GetDarker();

                        CollectionLog.Print(27, 5 + printCount, name, col);
                        CollectionLog.Print(88, 5 + printCount, timesObtained.ToString().PadLeft(10), col);
                        CollectionLog.Print(75, 5 + printCount, dropchance, col);
                        printCount++;
                    } 

                    if (CollectionDropTop != 0) {
                        CollectionLog.PrintVertical(99, 5, new ColoredString("^++", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 5, new ColoredString("^++", Color.Lime, Color.Black));
                    }

                    if (cask.DropTable.Count > CollectionDropTop + 24) {
                        CollectionLog.PrintVertical(99, 26, new ColoredString("++v", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 26, new ColoredString("++v", Color.Lime, Color.Black));
                    }
                }
            } else if (CollectionCat == "Boss") {
                bossList.Clear();
                bossList = GameLoop.ZPO.BossLibrary.Values.ToList().OrderBy(f => f.Name).ToList();

                for (int i = 0; i < bossList.Count; i++) {
                    CollectionLog.PrintClickable(1, 1 + i, new ColoredString(" " + bossList[i].Name, CollectionID == bossList[i].ID ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = bossList[i].ID; });
                }

                if (GameLoop.ZPO.BossLibrary.ContainsKey(CollectionID)) {
                    BossFight view = GameLoop.ZPO.BossLibrary[CollectionID];

                    if (view.DropTable.Count > 24) {
                        if (Helper.ScrolledUp()) { CollectionDropTop = Math.Clamp(CollectionDropTop - 1, 0, view.DropTable.Count - 24); }
                        if (Helper.ScrolledDown()) { CollectionDropTop = Math.Clamp(CollectionDropTop + 1, 0, view.DropTable.Count - 24); }
                    } 

                    int KC = 0;

                    if (GameLoop.ZPO.player.CollectionLogBoss.ContainsKey(view.ID)) {
                        KC = GameLoop.ZPO.player.CollectionLogBoss[view.ID].KillCount;
                    }

                    CollectionLog.Print(26, 1, (view.Name + " (" + KC + " KC)").Align(HorizontalAlignment.Center, 72), Color.White);
                    CollectionLog.DrawLine(new Point(26, 2), new Point(98, 2), 196, Color.White);
                    CollectionLog.Print(27, 3, "Item Name", Color.White);
                    CollectionLog.Print(79, 3, "Chance", Color.White);
                    CollectionLog.Print(90, 3, "Obtained", Color.White);
                    CollectionLog.DrawLine(new Point(26, 4), new Point(98, 4), 196, Color.White);

                    int printCount = 0; 
                    List<ItemDrop> dropsSorted = view.DropTable.OrderBy(o => o.InY).ThenBy(p => GameLoop.ZPO.ResolveItemName(p.ItemID)).ToList();
                    for (int i = CollectionDropTop; i < dropsSorted.Count && i < CollectionDropTop + 24; i++) {
                        int timesObtained = 0;

                        if (GameLoop.ZPO.player.CollectionLogBoss.ContainsKey(view.ID)) {
                            if (GameLoop.ZPO.player.CollectionLogBoss[view.ID].DropsObtained.ContainsKey(dropsSorted[i].ItemID)) {
                                timesObtained = GameLoop.ZPO.player.CollectionLogBoss[view.ID].DropsObtained[dropsSorted[i].ItemID];
                            }
                        }

                        string name = GameLoop.ZPO.ResolveItemName(dropsSorted[i].ItemID); 

                        if (dropsSorted[i].QuantityMax > 1) {
                            if (dropsSorted[i].QuantityMin == dropsSorted[i].QuantityMax) {
                                name += " (" + dropsSorted[i].QuantityMin + ")";
                            } else { 
                                name += " (" + dropsSorted[i].QuantityMin + "-" + dropsSorted[i].QuantityMax + ")";
                            }
                        }

                        string dropchance = (dropsSorted[i].DropX).ToString().PadLeft(5) + " in " + dropsSorted[i].InY;

                        Color col = timesObtained > 0 ? Color.White : Color.DarkSlateGray;
                        if (mousePos.Y == 5 + printCount && mousePos.X > 25)
                            col = col.GetDarker();

                        CollectionLog.Print(27, 5 + printCount, name, col);
                        CollectionLog.Print(88, 5 + printCount, timesObtained.ToString().PadLeft(10), col);
                        CollectionLog.Print(75, 5 + printCount, dropchance, col);
                        printCount++;
                    }

                    if (CollectionDropTop != 0) {
                        CollectionLog.PrintVertical(99, 5, new ColoredString("^++", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 5, new ColoredString("^++", Color.Lime, Color.Black));
                    }

                    if (view.DropTable.Count > CollectionDropTop + 24) {
                        CollectionLog.PrintVertical(99, 26, new ColoredString("++v", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 26, new ColoredString("++v", Color.Lime, Color.Black));
                    }
                }
            } else {
                monsterList.Clear();
                monsterList = GameLoop.ZPO.MonsterLibrary.Values.ToList().OrderBy(f => f.Name).ToList();

                int qty = 1;
                if (Helper.EitherShift()) { qty *= 5; }
                if (Helper.EitherControl()) { qty *= 10; }

                if (monsterList.Count > 28) {
                    if (Helper.ScrolledUp() && mousePos.X < 26) { CollectionSideTop = Math.Clamp(CollectionSideTop - qty, 0, monsterList.Count - 28); }
                    if (Helper.ScrolledDown() && mousePos.X < 26) { CollectionSideTop = Math.Clamp(CollectionSideTop + qty, 0, monsterList.Count - 28); }
                } else {
                    CollectionSideTop = 0;
                }

                for (int i = CollectionSideTop; i < monsterList.Count && i < CollectionSideTop + 28; i++) {
                    CollectionLog.PrintClickable(1, 1 + (i - CollectionSideTop), new ColoredString(Helper.Truncate(monsterList[i].Name.Align(HorizontalAlignment.Left, 21), 21) + (248.AsString() + monsterList[i].Level.ToString().Align(HorizontalAlignment.Right, 3)), CollectionID == monsterList[i].ID ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = monsterList[i].ID; });
                }

                if (GameLoop.ZPO.MonsterLibrary.ContainsKey(CollectionID)) {
                    AreaMonster view = GameLoop.ZPO.MonsterLibrary[CollectionID];

                    if (view.DropTable.Count > 24) {
                        if (Helper.ScrolledUp() && mousePos.X > 26) { CollectionDropTop = Math.Clamp(CollectionDropTop - qty, 0, view.DropTable.Count - 24); }
                        if (Helper.ScrolledDown() && mousePos.X > 26) { CollectionDropTop = Math.Clamp(CollectionDropTop + qty, 0, view.DropTable.Count - 24); }
                    } else {
                        CollectionDropTop = 0;
                    }

                    int KC = 0;

                    if (GameLoop.ZPO.player.CollectionLog.ContainsKey(view.ID)) {
                        KC = GameLoop.ZPO.player.CollectionLog[view.ID].KillCount;
                    }

                    CollectionLog.Print(26, 1, (view.Name + " (" + KC + " KC)").Align(HorizontalAlignment.Center, 72), Color.White);
                    CollectionLog.DrawLine(new Point(26, 2), new Point(98, 2), 196, Color.White);
                    CollectionLog.Print(27, 3, "Item Name", Color.White);
                    CollectionLog.Print(79, 3, "Chance", Color.White);
                    CollectionLog.Print(90, 3, "Obtained", Color.White);
                    CollectionLog.DrawLine(new Point(26, 4), new Point(98, 4), 196, Color.White);

                    int printCount = 0;
                    List<ItemDrop> dropsSorted = view.DropTable.OrderBy(o => o.InY).ThenBy(p => GameLoop.ZPO.ResolveItemName(p.ItemID)).ToList();
                    for (int i = CollectionDropTop; i < dropsSorted.Count && i < CollectionDropTop + 24; i++) {
                        int timesObtained = 0;

                        if (GameLoop.ZPO.player.CollectionLog.ContainsKey(view.ID)) {
                            if (GameLoop.ZPO.player.CollectionLog[view.ID].DropsObtained.ContainsKey(dropsSorted[i].ItemID)) {
                                timesObtained = GameLoop.ZPO.player.CollectionLog[view.ID].DropsObtained[dropsSorted[i].ItemID];
                            }
                        }

                        string name = GameLoop.ZPO.ResolveItemName(dropsSorted[i].ItemID); 

                        if (dropsSorted[i].QuantityMax > 1) {
                            if (dropsSorted[i].QuantityMin == dropsSorted[i].QuantityMax) {
                                name += " (" + dropsSorted[i].QuantityMin + ")";
                            } else { 
                                name += " (" + dropsSorted[i].QuantityMin + "-" + dropsSorted[i].QuantityMax + ")";
                            }
                        }

                        string dropchance = (dropsSorted[i].DropX).ToString().PadLeft(5) + " in " + dropsSorted[i].InY;

                        Color col = timesObtained > 0 ? Color.White : Color.DarkSlateGray;
                        if (mousePos.Y == 5 + printCount && mousePos.X > 25)
                            col = col.GetDarker();

                        CollectionLog.Print(27, 5 + printCount, name, col);
                        CollectionLog.Print(88, 5 + printCount, timesObtained.ToString().PadLeft(10), col);
                        CollectionLog.Print(75, 5 + printCount, dropchance, col);
                        printCount++;
                    }

                    if (CollectionDropTop != 0) {
                        CollectionLog.PrintVertical(99, 5, new ColoredString("^++", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 5, new ColoredString("^++", Color.Lime, Color.Black));
                    }

                    if (view.DropTable.Count > CollectionDropTop + 24) {
                        CollectionLog.PrintVertical(99, 26, new ColoredString("++v", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 26, new ColoredString("++v", Color.Lime, Color.Black));
                    }
                }
            }


            
            CollectionLog.PrintClickable(75, 0, new ColoredString("[CLUE]", CollectionCat == "Clue" ? Color.White : Color.DarkSlateGray, Color.Black), () => { CollectionCat = "Clue"; });
            CollectionLog.PrintClickable(82, 0, new ColoredString("[BOSS]", CollectionCat == "Boss" ? Color.White : Color.DarkSlateGray, Color.Black), () => { CollectionCat = "Boss"; }); 
            CollectionLog.PrintClickable(89, 0, new ColoredString("[MONSTER]", CollectionCat == "Monster" ? Color.White : Color.DarkSlateGray, Color.Black), () => { CollectionCat = "Monster"; });

            CollectionLog.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { CollectionLog.IsVisible = false; });
        }

        public static void CraftingMenuDraw() { 
            Point mousePos = new MouseScreenObjectState(CraftingMenu, GameHost.Instance.Mouse).CellPosition;

            CraftingMenu.Clear(); 
            Helper.DrawBox(CraftingMenu, 0, 0, 98, 28);
            CraftingMenu.Print(2, 0, "[Crafting Menu - " + CraftingType + "]");
            CraftingMenu.DrawLine(new Point(25, 1), new Point(25, 28), 179);  

            List<string> ItemsUsed = new();

            if (GameLoop.ZPO.CraftLib.ContainsKey(CraftingType)) {
                foreach (var craft in GameLoop.ZPO.CraftLib[CraftingType]) {
                    string item = GameLoop.ZPO.ResolveItemName(craft.NeededItems[0].Split(",")[0]);
                    if (!ItemsUsed.Contains(item)) {
                        ItemsUsed.Add(item);
                    }
                }

                ItemsUsed.Sort();  
            }

            if (CraftingSubtype == "" || !ItemsUsed.Contains(CraftingSubtype)) {
                if (ItemsUsed.Count > 0) {
                    CraftingSubtype = ItemsUsed[0];
                    PopulateCraftList();
                }
            } 

            for (int i = 0; i < ItemsUsed.Count; i++) {
                CraftingMenu.PrintClickable(1, 1 + i, ItemsUsed[i], () => { CraftingSubtype = ItemsUsed[i]; PopulateCraftList(); });
            } 

            CraftingMenu.DrawLine(new Point(26, 2), new Point(98, 2), 196, Color.White);
            CraftingMenu.Print(27, 1, "Crafted Item", Color.White); 
            CraftingMenu.Print(60, 1, "Lev", Color.White);
            CraftingMenu.Print(67, 1, "Exp", Color.White);
            CraftingMenu.Print(74, 1, "Input", Color.White);
            CraftingMenu.Print(85, 1, "Tool", Color.White);

            int idx = 1;
            if (Helper.EitherShift())
                idx *= 5;
            if (Helper.EitherControl())
                idx *= 10;


            if (ActiveRecipes.Count > 26) {
                if (Helper.ScrolledUp() && mousePos.X > 25) { CraftingListTop = Math.Clamp(CraftingListTop - idx, 0, ActiveRecipes.Count - 26); }
                if (Helper.ScrolledDown() && mousePos.X > 25) { CraftingListTop = Math.Clamp(CraftingListTop + idx, 0, ActiveRecipes.Count - 26); }
            } else {
                CraftingListTop = 0;
            }

            int printY = 0;
            for (int i = CraftingListTop; i < ActiveRecipes.Count && i < CraftingListTop + 26; i++) {
                CraftRecipe rec = ActiveRecipes[i];
                string name = GameLoop.ZPO.ResolveItemName(rec.OutputItem) + (rec.OutputQty > 1 ? " x" + rec.OutputQty : "");

                string[] item = rec.NeededItems[0].Split(",");
                string line = name.Align(HorizontalAlignment.Left, 31, ' ') + 179.AsString() + " "
                    + rec.Level.ToString().Align(HorizontalAlignment.Right, 3) + " " + 179.AsString() + " "
                    + rec.ExpGranted.ToString().Align(HorizontalAlignment.Right, 5) + " " + 179.AsString() + " "
                    + item[1].Align(HorizontalAlignment.Right, 5) + " " + 179.AsString() + " "
                    + GameLoop.ZPO.ResolveItemName(rec.ExtraTool);

                if (GameLoop.ZPO.player.CanCraft(rec)) { 
                    CraftingMenu.PrintClickable(27, 3 + printY++, new ColoredString(line, Color.White, Color.Black), () => { GameLoop.ZPO.player.TryCraft(rec); });
                } else { 
                    CraftingMenu.PrintClickable(27, 3 + printY++, new ColoredString(line, Color.Crimson, Color.Black), () => {
                        string mats = "To make " + GameLoop.ZPO.ResolveItemName(rec.OutputItem).ToLower() + ": " + rec.Level + " " + rec.Skill + ", ";

                        for (int mat = 0; mat < rec.NeededItems.Count; mat++) {
                            string[] split = rec.NeededItems[mat].Split(",");
                            mats += (mat == 0 ? "" : ", ") + (split.Length > 1 ? split[1] + "x " : "") + GameLoop.ZPO.ResolveItemName(split[0]).ToLower();
                        } 

                        if (rec.ExtraTool != "") {
                            string name = GameLoop.ZPO.ResolveItemName(rec.ExtraTool).ToLower();
                            mats += " and a" + (Helper.VowelStart(name) ? "n ": " ") + name + ".";
                        }

                        GameLoop.ZPO.Log.AddMessage(mats, Color.Crimson);

                        if (rec.Reqs.Count > 0) { 
                            foreach (var kv in rec.Reqs) { 
                                GameLoop.ZPO.Log.AddMessage("Also: " + kv.GetSummary(), kv.CheckRequirement(GameLoop.ZPO.player, false, true) ? Color.Lime : Color.Crimson);
                            } 
                        }
                    });
                }
            }


            CraftingMenu.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { CraftingMenu.IsVisible = false; });
        }

        public static void PopulateCraftList() {
            ActiveRecipes.Clear();

            if (GameLoop.ZPO.CraftLib.ContainsKey(CraftingType)) {
                foreach (var craft in GameLoop.ZPO.CraftLib[CraftingType]) {
                    string itemNeeded = GameLoop.ZPO.ResolveItemName(craft.NeededItems[0].Split(",")[0]);
                    if (itemNeeded == CraftingSubtype) {
                        ActiveRecipes.Add(craft);
                    }
                }
            }
        }

        public static List<string> QuestLengths = [ "Very Short", "Short", "Medium", "Long", "Very Long" ];
        public static List<string> QuestDifficulties = ["Novice", "Intermediate", "Experienced", "Master", "Grandmaster" ];
        public static List<string> QuestRegions = [ "Asgarnia", "Desert", "Fremennik", "Kandarin", "Karamja", "Misthalin", "Morytania", "Wilderness" ];

        public static void QuestDraw() {
            Quests.Clear();
            Helper.DrawBox(Quests, 0, 0, 98, 28);
            if (ViewingQuestID == "") {
                Quests.Print(2, 0, "[Quest Log - " + QuestFilter + " Quests]");
            } else { 
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(ViewingQuestID, out Quest? currQuest)) { 
                    Quests.Print(2, 0, "[Quest Log - " + currQuest.Name + "]");
                } 
            } 
            Quests.DrawLine(new Point(17, 1), new Point(17, 28), 179);

            Quests.PrintClickable(1, 1, new ColoredString("Show All Quests", QuestFilter == "All" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { QuestFilter = "All"; ViewingQuestID = ""; });


            int printSide = 3;
            Quests.Print(1, printSide++, "By Length");
            for (int i = 0; i < QuestLengths.Count; i++) {
                Quests.PrintClickable(2, printSide++, new ColoredString(QuestLengths[i], QuestFilter == QuestLengths[i] ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { QuestFilter = QuestLengths[i]; ViewingQuestID = ""; });
            }
            printSide++;

            Quests.Print(1, printSide++, "By Difficulty");
            for (int i = 0; i < QuestDifficulties.Count; i++) {
                Quests.PrintClickable(2, printSide++, new ColoredString(QuestDifficulties[i], QuestFilter == QuestDifficulties[i] ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { QuestFilter = QuestDifficulties[i]; ViewingQuestID = ""; });
            }
            printSide++;

            Quests.Print(1, printSide, "By Region"); 
            Quests.PrintClickable(11, printSide++, new ColoredString("(Mine)", QuestFilter == "MyRegions" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { QuestFilter = "MyRegions"; ViewingQuestID = ""; });

            for (int i = 0; i < QuestRegions.Count; i++) {
                Quests.PrintClickable(2, printSide++, new ColoredString(QuestRegions[i], QuestFilter == QuestRegions[i] ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { QuestFilter = QuestRegions[i]; ViewingQuestID = ""; });
            }
            printSide++;

            List<Quest> QuestsInFilter = new();
            QuestsInFilter = QuestsInFilter.OrderBy(o => o.Name).ToList();

            foreach(var kv in GameLoop.ZPO.QuestLibrary) {
                if (QuestFilter == "MyRegions") {

                }
                else {
                    if (QuestFilter == "All" || kv.Value.Difficulty == QuestFilter || kv.Value.Length == QuestFilter || kv.Value.RegionsNeeded.Contains(QuestFilter)) {
                        QuestsInFilter.Add(kv.Value);
                    }
                }
            }

            if (ViewingQuestID == "") {
                for(int i = 0; i < QuestsInFilter.Count; i++) { 
                    Color col = Color.DarkSlateGray;

                    if (QuestsInFilter[i].CanStartQuest(GameLoop.ZPO.player)) {
                        col = Color.Crimson;
                    }

                    if (QuestsInFilter[i].CurrentStage() != -1) {
                        col = Color.Yellow;
                    }

                    if (QuestsInFilter[i].CurrentStage() == QuestsInFilter[i].CompleteStage) {
                        col = Color.Lime;
                    }

                    Quests.PrintClickable(19, 1 + i, new ColoredString(QuestsInFilter[i].Name, col, Color.Black), () => {
                        ViewingQuestID = QuestsInFilter[i].ID;

                        if (GameLoop.ZPO.QuestLibrary.TryGetValue(ViewingQuestID, out Quest? nowViewing)) {
                            if (nowViewing != null) {
                                if (nowViewing.CurrentStage() == -1) {
                                    QuestOverview = true;
                                } else {
                                    QuestOverview = false; 
                                    QuestBlockScrollTop = 0;
                                }
                            } else {
                                QuestOverview = true;
                            }
                        } else {
                            QuestOverview = true;
                        }
                    });
                }
            } else {
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(ViewingQuestID, out Quest? currQuest)) {

                    if (QuestOverview) {
                        Quests.Print(19, 1, "Quest Name: " + currQuest.Name);
                        Quests.Print(19, 2, "Difficulty: " + currQuest.Difficulty);
                        Quests.Print(19, 3, "    Length: " + currQuest.Length);
                        int afterDesc = Quests.PrintMultiLine(19, 5, currQuest.Description, 80) + 2;

                        if (currQuest.CurrentStage() != -1) {
                            Quests.PrintClickable(19, afterDesc, "[View Quest Log]", () => { QuestOverview = false; QuestBlockScrollTop = 0; });

                            if (currQuest.CurrentStage() == currQuest.CompleteStage)
                                Quests.Print(19, afterDesc + 2, "Quest Complete!", Color.Lime);
                        }
                    } else {
                        int visibleStages = 0;
                        
                        foreach (var kv in currQuest.Stages) {
                            if (kv.Key <= currQuest.CurrentStage()) {
                                visibleStages++;
                            }
                        }

                        if (Helper.ScrolledUp()) { QuestBlockScrollTop = Math.Clamp(QuestBlockScrollTop - 1, 0, visibleStages - 1); }
                        if (Helper.ScrolledDown()) { QuestBlockScrollTop = Math.Clamp(QuestBlockScrollTop + 1, 0, visibleStages - 1); }


                        Quests.PrintClickable(19, 1, "[View Quest Overview]", () => { QuestOverview = true; });

                        int printY = 3;
                        int count = -1; 
                        foreach (var kv in currQuest.Stages) {
                            count++;
                            if (count < QuestBlockScrollTop) { 
                                continue;
                            }

                            if (kv.Key <= currQuest.CurrentStage()) {
                                Color col = Color.DarkSlateGray;

                                if (kv.Key == currQuest.CurrentStage())
                                    col = Color.White;

                                printY = Quests.PrintMultiLine(19, printY, kv.Value.Description, 80, col.R, col.G, col.B);

                                printY += 2;
                            }
                        }

                        if (currQuest.CurrentStage() == currQuest.CompleteStage)
                            Quests.Print(19, printY, "Quest Complete!", Color.Lime);

                        Quests.DrawLine(new Point(1, 29), (98, 29), 196, Color.White);
                    }
                } 
            }

            Quests.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Quests.IsVisible = false; });
        }
    
        
        public static void ClueDraw() {
            Clue.Clear();
            Helper.DrawBox(Clue, 0, 0, 68, 18);
            Clue.Print(2, 0, "[Clue Scroll]".Align(HorizontalAlignment.Center, 66, (char) 196)); 

            if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(CurrentClue, out ClueStep? clue) && clue != null) {
                if (GameLoop.ZPO.Atlas.TryGetValue(clue.SolveLoc, out Location? loc) && loc != null) {
                    int endpoint = Clue.PrintMultiLine(2, 0, loc.Description, 66);

                    Clue.Clear();
                    Helper.DrawBox(Clue, 0, 0, 68, 18);
                    Clue.Print(2, 0, "[Clue Scroll]".Align(HorizontalAlignment.Center, 66, (char) 196)); 

                    Clue.PrintMultiLine(2, (20 - endpoint) / 2, loc.Description, 66, center: true);
                }
            }
             
            
            Clue.Print(2, 18, "Find the map location with this description.", Color.DarkSlateGray); 
            Clue.PrintClickable(69, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Clue.IsVisible = false; });
        }    
    
        
        public static void TeleportDraw() {
            Teleport.Clear();
            Helper.DrawBox(Teleport, 0, 0, 48, 28);
            Teleport.Print(2, 0, "[Teleport Options]");

            for(int i = 0; i < TeleportDests.Count; i++) {
                if (GameLoop.ZPO.Atlas.TryGetValue(TeleportDests[i], out Location? dest)) { 
                    Teleport.PrintClickable(2, 1 + i, dest.DisplayName, () => { 
                        Teleport.IsVisible = false; 
                        GameLoop.ZPO.player.NavLoc = TeleportDests[i]; 
                        GameLoop.ZPO.Log.AddMessage("You teleport to " + GameLoop.ZPO.ResolveLocationName(TeleportDests[i]) + ".");
                        TeleportDests = new();

                        if (TeleWrap != null && TeleCostsCharges) { 
                            TeleWrap.Charges -= 1;  
                            if (TeleWrap.Charges <= 0) {
                                if (TeleWrap.GetRef() is Item unwrap && unwrap.ShattersAtZeroCharges) {
                                    GameLoop.ZPO.Log.AddMessage("Your " + unwrap.Name + " runs out of charges and shatters.", Color.Crimson);
                                    GameLoop.ZPO.player.Inventory.Remove(TeleWrap);
                                    
                                    if (unwrap.EquipSlot != "" && GameLoop.ZPO.player.Equipment.TryGetValue(unwrap.EquipSlot, out ItemWrapper? wrap) && wrap != null && wrap == TeleWrap) {
                                        GameLoop.ZPO.player.Equipment.Remove(unwrap.EquipSlot);
                                    }
                                }
                            }
                        }

                        TeleWrap = null; 
                    });
                } else {
                    Teleport.Print(2, 1 + i, TeleportDests[i], Color.DarkSlateGray);
                }
            }
             
              
            Teleport.PrintClickable(49, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Teleport.IsVisible = false; });
        }    
    
        public static void InventoryContainerDraw() {
            InventoryContainer.Clear();
            Helper.DrawBox(InventoryContainer, 0, 0, 48, 8);
            if (ConWrap != null && ConWrap.GetRef() is Item con) {
                InventoryContainer.Print(2, 0, "[Inventory Container - " + con.Name + "]");

                for (int i = ConWrap.Containing.Count - 1; i >= 0; i--) {
                    if (ConWrap.Containing[i].GetRef() is Item contained) {
                        InventoryContainer.PrintClickable(2, 1 + i, contained.GetNameCS(ConWrap.Containing[i].Quantity, 0, ConWrap.Containing[i].Charges, ConWrap.Containing[i].Noted), () => {
                            int qty = 1;
                            if (Helper.EitherShift()) { qty *= 5; }
                            if (Helper.EitherControl()) { qty *= 10; }
                            if (qty > ConWrap.Containing[i].Quantity || Helper.EitherAlt()) { qty = ConWrap.Containing[i].Quantity; }

                            GameLoop.ZPO.player.TryPickup(ConWrap.Containing[i], qty);
                             
                            if (ConWrap.Containing[i].Quantity <= 0) {
                                ConWrap.Containing.RemoveAt(i);
                            }
                        });
                    }
                }
            }
            InventoryContainer.PrintClickable(49, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { InventoryContainer.IsVisible = false; ConWrap = null; });
        }        
    
        
        public static void BookDraw() {
            Book.Clear();
            Helper.DrawBox(Book, 0, 0, 75, 23);

            if (GameLoop.ZPO.BookLibrary.TryGetValue(BookID, out Book? book)) {
                Book.Print(1, 0, ("[" + book.Name + "]").Align(HorizontalAlignment.Center, 75, (char) 196));

                if (book.FrameType == 1) {
                    Book.DrawLine(new Point(3, 2), new Point(35, 2), 196, Color.White);
                    Book.DrawLine(new Point(41, 2), new Point(73, 2), 196, Color.White); 
                    Book.Print(36, 3, "\\   /", Color.White);

                    Book.DrawLine(new Point(2, 4), new Point(2, 22), 179, Color.White);
                    Book.DrawLine(new Point(3, 3), new Point(3, 21), 179, Color.White);
                    Book.DrawLine(new Point(73, 3), new Point(73, 21), 179, Color.White);
                    Book.DrawLine(new Point(74, 3), new Point(74, 22), 179, Color.White);

                    Book.DrawLine(new Point(3, 22), new Point(35, 22), 196, Color.White);
                    Book.DrawLine(new Point(41, 22), new Point(73, 22), 196, Color.White); 
                    Book.DrawLine(new Point(3, 23), new Point(35, 23), 196, Color.White);
                    Book.DrawLine(new Point(41, 23), new Point(73, 23), 196, Color.White); 
                    Book.Print(36, 22, "/   \\", Color.White);
                    Book.Print(35, 23, "/     \\", Color.White);
                     
                    Book.Print(3, 2, "/", Color.White);
                    Book.Print(2, 3, "/", Color.White);
                    Book.Print(3, 22, "/", Color.White);
                    Book.Print(2, 23, "/", Color.White);
                     
                    Book.Print(73, 2, "\\", Color.White);
                    Book.Print(74, 3, "\\", Color.White);
                    Book.Print(73, 22, "\\", Color.White);
                    Book.Print(74, 23, "\\", Color.White);
                    Book.Print(36, 23, "_____", Color.White);
                    
                    Book.DrawLine(new Point(37, 4), new Point(37, 21), 179, Color.White);
                    Book.DrawLine(new Point(38, 4), new Point(38, 21), '|', Color.White);
                    Book.DrawLine(new Point(39, 4), new Point(39, 21), 179, Color.White);
                    
                    Book.Print(5, 3, book.Pages[LeftPage].Name, Color.White);
                    Book.PrintMultiLine(5, 5, book.Pages[LeftPage].Text, 31);

                    if (book.Pages.Count > LeftPage + 1) { 
                        Book.Print(41, 3, book.Pages[LeftPage + 1].Name.Align(HorizontalAlignment.Right, 31), Color.White);
                        Book.PrintMultiLine(43, 5, book.Pages[LeftPage + 1].Text, 31);
                    }

                    if (book.Pages.Count > LeftPage + 2) { 
                        Book.PrintClickable(61, 23, "[NEXT PAGE]", () => { 
                            LeftPage += 2; 
                            book.Pages[LeftPage].Reached(); 
                            if (book.Pages.Count > LeftPage + 1) { 
                                book.Pages[LeftPage+1].Reached(); 
                            }
                        });
                    }
                    if (LeftPage > 1) { Book.PrintClickable(5, 23, "[LAST PAGE]", () => { LeftPage -= 2; }); }
                } else if (book.FrameType == 0) { 
                    Book.DrawLine(new Point(21, 2), new Point(55, 2), 196, Color.White);
                    Book.DrawLine(new Point(21, 21), new Point(55, 21), 196, Color.White);
                    Book.DrawLine(new Point(21, 3), new Point(21, 20), 179, Color.White);
                    Book.DrawLine(new Point(55, 3), new Point(55, 20), 179, Color.White);
                     
                    Book.Print(22, 3, book.Pages[LeftPage].Name.Align(HorizontalAlignment.Center, 33), Color.White);
                    Book.PrintMultiLine(23, 5, book.Pages[LeftPage].Text, 31);

                    if (book.Pages.Count > LeftPage + 1) { 
                        Book.PrintClickable(45, 22, "[NEXT PAGE]", () => { 
                            LeftPage += 1; 
                            book.Pages[LeftPage].Reached();
                        });
                    }
                    if (LeftPage > 0) { Book.PrintClickable(21, 22, "[LAST PAGE]", () => { LeftPage -= 1; }); }
                }
            }
            Book.PrintClickable(76, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Book.IsVisible = false; });
        }    
    
        public static void CutsceneDraw() {
            Cutscene.Clear();
            Helper.DrawBox(Cutscene, 0, 0, 98, 28);

            if (GameLoop.ZPO.CutsceneLibrary.TryGetValue(CutsceneID, out Cutscene? cut)) { 
                Cutscene.Print(2, 0, ("[" + cut.DisplayTitle + "]").Align(HorizontalAlignment.Center, 98, (char)196));
                
                Helper.DrawBox(Cutscene, 1, 1, 96, 18);
                Helper.DrawBox(Cutscene, 1, 20, 96, 7);

                if (CutsceneScene < cut.Scenes.Count) { 
                    Cutscene.PrintMultiLine(2, 8, cut.Scenes[CutsceneScene].Description, 96, center: true);

                    if (CutsceneDialogue < cut.Scenes[CutsceneScene].DialogueLines.Count) {
                        Cutscene.PrintMultiLine(2, 22, cut.Scenes[CutsceneScene].DialogueLines[CutsceneDialogue], 96, center: true);
                    }

                    if (cut.Scenes[CutsceneScene].DialogueLines.Count > CutsceneDialogue + 1) {
                        Cutscene.PrintClickable(92, 28, "[NEXT]", () => { CutsceneDialogue++; });
                    } else if (cut.Scenes.Count > CutsceneScene + 1) { 
                        Cutscene.PrintClickable(92, 28, "[NEXT]", () => { CutsceneDialogue = 0; CutsceneScene++; });
                    } else {
                        Cutscene.PrintClickable(91, 28, "[CLOSE]", () => { CutsceneDialogue = 0; CutsceneScene = 0; Cutscene.IsVisible = false; });
                    }

                    if (CutsceneDialogue > 0) { 
                        Cutscene.PrintClickable(2, 28, "[BACK]", () => { CutsceneDialogue--; });
                    } else if (CutsceneScene > 0) { 
                        Cutscene.PrintClickable(2, 28, "[BACK]", () => { CutsceneScene--; CutsceneDialogue = cut.Scenes[CutsceneScene].DialogueLines.Count - 1; });
                    }
                } 
            }

            
            Cutscene.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { 
                Cutscene.IsVisible = false; 
                CutsceneScene = 0;
                CutsceneDialogue = 0;
            });
        }
        

        public static void ShopDraw() {
            Shop.Clear();
            Helper.DrawBox(Shop, 0, 0, 48, 28);
            Shop.Print(2, 0, "[Shop - " + ShopID + "]");

            int resourceX = 1;
            int resourceY = 1;

            MessageLog Log = GameLoop.ZPO.Log;

            if (ShopID == "Slayer Rewards") {
                Shop.Print(2, 0, "[Shop - " + ShopID + " (" + GameLoop.ZPO.player.SlayerPoints + " points)]");
                Shop.PrintClickable(2, 1, new ColoredString("Unlocks", SlayerTab == "Unlocks" ? Color.Yellow : Color.White, Color.Black), () => { SlayerTab = "Unlocks"; });
                Shop.Print(10, 1, 179.AsString(), Color.White);
                Shop.PrintClickable(12, 1, new ColoredString("Buy", SlayerTab == "Buy" ? Color.Yellow : Color.White, Color.Black), () => { SlayerTab = "Buy"; });
                Shop.Print(16, 1, 179.AsString(), Color.White);
                Shop.PrintClickable(18, 1, new ColoredString("Tasks", SlayerTab == "Tasks" ? Color.Yellow : Color.White, Color.Black), () => { SlayerTab = "Tasks"; });
                Shop.Print(24, 1, 179.AsString(), Color.White);
                Shop.PrintClickable(26, 1, new ColoredString("Cosmetic", SlayerTab == "Cosmetic" ? Color.Yellow : Color.White, Color.Black), () => { SlayerTab = "Cosmetic"; });
                Shop.DrawLine(new Point(1, 2), new Point(48, 2), 196, Color.White);

                resourceY = 3;
                List<SlayerReward> viewing = SlayerUnlocks;
                if (SlayerTab == "Unlocks") { viewing = SlayerUnlocks; }
                else if (SlayerTab == "Buy") { viewing = SlayerBuy; }
                else if (SlayerTab == "Tasks") { viewing = SlayerTasks; }

                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (viewing.Count > 26) {
                    if (Helper.ScrolledUp()) { ShopTop = Math.Clamp(ShopTop - qty, 0, viewing.Count - 26); }
                    if (Helper.ScrolledDown()) { ShopTop = Math.Clamp(ShopTop + qty, 0, viewing.Count - 26); }
                } else {
                    ShopTop = 0;
                }

                for (int i = ShopTop; i < viewing.Count && i < ShopTop + 26; i++) {
                    SlayerReward reward = viewing[i];

                    Shop.PrintClickable(resourceX, resourceY, new ColoredString("?", Color.MediumPurple, Color.Black), () => { 
                        Log.AddMessage(new ColoredString(reward.Description, Color.SandyBrown, Color.Black));
                    });
                    int spaceAfterName = 46 - reward.Name.Length;

                    Shop.PrintClickable(resourceX + 2, resourceY++, new ColoredString(reward.Name + ("(" + reward.SlayerPointCost + " points)").Align(HorizontalAlignment.Right, spaceAfterName), !reward.AllReqsMet() || (GameLoop.ZPO.player.SlayerPoints < reward.SlayerPointCost) ? Color.Crimson : Color.White, Color.Black), () => {
                        if (GameLoop.ZPO.player.CanUseShops) {
                            if (!reward.AllReqsMet()) { 
                                List<string> failed = new();
                                foreach (var req in reward.Reqs) { 
                                    if (!req.CheckRequirement(GameLoop.ZPO.player, false, true)) {
                                        failed.Add(req.GetSummary());
                                    }
                                }

                                if (failed.Count == 1) { 
                                    Log.AddMessage("Missing requirement: " + failed[0], Color.Crimson);  
                                } else {
                                    Log.AddMessage("Missing requirements: ", Color.Crimson); 
                                    foreach (var fail in failed) { 
                                        Log.AddMessage("| " + fail, Color.Crimson); 
                                    } 
                                }

                                return;
                            }

                            if (GameLoop.ZPO.player.SlayerPoints >= reward.SlayerPointCost) {
                                GameLoop.ZPO.player.SlayerPoints -= reward.SlayerPointCost; 

                                if (SlayerTab != "Tasks") {
                                    Log.AddMessage("You unlocked " + reward.Name + " for " + reward.SlayerPointCost + " slayer points.", Color.Goldenrod); 
                                }

                                foreach (var act in reward.Actions) {
                                    act.Execute();
                                }
                            } else {
                                Log.AddMessage(new ColoredString("You don't have enough slayer points to buy that!", Color.Crimson, Color.Black));
                            }
                        } else {
                            Log.AddMessage(new ColoredString("You aren't allowed to use shops. Yes, that includes the Slayer Rewards shop.", Color.Crimson, Color.Black));
                        }
                    }); 
                } 
            } else {
                foreach (var shopStr in ShopItems) {
                    if (GameLoop.ZPO.ItemLibrary.ContainsKey(shopStr)) {
                        Item shop = new(GameLoop.ZPO.ItemLibrary[shopStr]); 
                        Shop.Print(resourceX, resourceY, "|");
                        int spaceAfterName = 46 - shop.GetName(1, 0, shop.UseInt4).Length;

                        int qty = 1;
                        if (Helper.EitherShift()) { qty *= 5; }
                        if (Helper.EitherControl()) { qty *= 10; }

                        Shop.PrintClickable(resourceX + 2, resourceY, shop.GetNameCS(1, 0, shop.UseInt4) + new ColoredString(("(" + shop.Value + "gp)").Align(HorizontalAlignment.Right, spaceAfterName)), () => {
                            if (GameLoop.ZPO.player.CanUseShops) {
                                if (GameLoop.ZPO.player.GoldTotal() >= shop.Value * qty) {
                                    GameLoop.ZPO.player.TakeGold(shop.Value * qty); 

                                    if (qty == 1)
                                        Log.AddMessage("You purchased a" + (Helper.VowelStart(shop.Name.ToLower()) ? "n " : " ") + shop.Name + " for " + shop.Value + " gp.", Color.Goldenrod);
                                    else 
                                        Log.AddMessage("You purchased " + qty + "x " + shop.Name + " for " + shop.Value + " gp.", Color.Goldenrod);

                                    if (!GameLoop.ZPO.player.TryPickup(shop, qty, false, true)) {
                                        Log.AddMessage("Your inventory is full and the "  + shop.Name + " falls to the ground.", Color.Crimson);
                                    }
                                } else {
                                    Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                }
                            } else {
                                Log.AddMessage(new ColoredString("You aren't allowed to use shops.", Color.Crimson, Color.Black));
                            }
                        }); 

                        resourceY++;
                    }
                    else {
                        Shop.Print(resourceX, resourceY, "|");
                        Shop.Print(resourceX + 2, resourceY++, shopStr, Color.DarkSlateGray);
                    }
                }
            }
            

            Shop.PrintClickable(49, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Shop.IsVisible = false; });
        }

        public static void BuildShop() {
            ShopItems.Clear();

            if (ShopID == "Slayer Equipment") {
                ShopItems.Add("gemSlayer");
                
                ShopItems.Add("staffSlayer");
                ShopItems.Add("shieldMirror");
                ShopItems.Add("spearLeafbladed");
                ShopItems.Add("arrowsBroad");
                ShopItems.Add("arrowheadsBroad");
                ShopItems.Add("boltsUnfBroad");
                ShopItems.Add("boltsBroad");
                 
                ShopItems.Add("facemask");
                ShopItems.Add("nosepeg");
                ShopItems.Add("earmuffs");
                ShopItems.Add("helmSpiny"); 
                ShopItems.Add("glovesSlayer");
                ShopItems.Add("bootsInsulated");
                ShopItems.Add("bootsStone");
                ShopItems.Add("witchwood");
                ShopItems.Add("lanternBug");  

                ShopItems.Add("bellSlayer"); 
                ShopItems.Add("hammerRock");
                ShopItems.Add("bagSalt");
                ShopItems.Add("saltShaker");
                ShopItems.Add("iceCooler");
                ShopItems.Add("iceShaker");
                ShopItems.Add("fungicide");
                ShopItems.Add("fungicideShaker");
                ShopItems.Add("explosiveFishing"); 
                ShopItems.Add("explosiveShaker");

                ShopItems.Add("gogglesReinforced"); // TODO: make this only show up if porcine of interest is completed
            }





            SlayerUnlocks.Clear();
            SlayerUnlocks.Add(new("Malevolent Masquerade", 400, "Learn to assemble a slayer helmet, which requires 55 Crafting.", [ new("Data", 0, "SlayerHelm", false, "equals", "Must not already know how to craft slayer helmets.") ], [ new("Data", "SlayerHelm", "set", 1)]));
            SlayerUnlocks.Add(new("Ring Bling", 150, "Learn to craft a slayer ring, which requires 75 Crafting.", [ new("Data", 0, "SlayerRing", false, "equals", "Must not already know how to craft slayer rings.") ], [ new("Data", "SlayerRing", "set", 1)]));
            SlayerUnlocks.Add(new("Broader Fletching", 300, "Learn to fletch broad arrows (52 Fletching), and broad bolts (55 Fletching).", [ new("Data", 0, "SlayerBroadFletching", false, "equals", "Must not already know how to fletch broad arrows/bolts.") ], [ new("Data", "SlayerBroadFletching", "set", 1)]));
            SlayerUnlocks.Add(new("Seeing Red", 50, "Konar, Duradel, and Nieve will be able to assign red dragons as your task.", [ new("Data", 0, "SlayerRedDragons", false, "equals", "Must not already be assignable red dragons.") ], [ new("Data", "SlayerRedDragons", "set", 1)]));
            SlayerUnlocks.Add(new("Watch the Birdie", 80, "Konar, Duradel, Nieve, Chaeldar, and Krystilia will be able to assign Aviansie as your task.", [ new("Data", 0, "SlayerAviansie", false, "equals", "Must not already be assignable Aviansie.") ], [ new("Data", "SlayerAviansie", "set", 1)]));
            SlayerUnlocks.Add(new("Hot Stuff", 100, "Duradel, Nieve, and Chaeldar, will be able to assign TzHaar as your task.", [ new("Data", 0, "SlayerTzHaar", false, "equals", "Must not already be assignable TzHaar.") ], [ new("Data", "SlayerTzhaar", "set", 1)]));
            SlayerUnlocks.Add(new("Like a Boss", 200, "Konar, Duradel, Krystilia and Nieve will be able to assign various bosses as your task.", [ new("Data", 0, "SlayerBosses", false, "equals", "Must not already be assignable bosses.") ], [ new("Data", "SlayerBosses", "set", 1)]));
            SlayerUnlocks.Add(new("Reptile Got Ripped", 80, "Konar, Duradel, Nieve, and Chaeldar will be able to assign Lizardmen as your task.", [ new("Data", 0, "SlayerLizardmen", false, "equals", "Must not already be assignable Lizardmen.") ], [ new("Data", "SlayerLizardmen", "set", 1)]));
            SlayerUnlocks.Add(new("Bigger and Badder", 50, "Certain slayer monsters will have the chance of spawning a superior version whilst on a Slayer task.", [ new("Data", 0, "SlayerSuperior", false, "equals", "Must not already have superiors unlocked.") ], [ new("Data", "SlayerSuperior", "set", 1)]));
            SlayerUnlocks.Add(new("Duly Noted", 200, "Mithril dragons will drop mithril bars in noted form if killed during an assignment.", [ new("Data", 0, "SlayerMithril", false, "equals", "Must not already receive mithril bars as notes.") ], [ new("Data", "SlayerMithril", "set", 1)]));
            SlayerUnlocks.Add(new("Stop the Wyvern", 500, "Stops you from getting Fossil Island Wyvern tasks, without counting towards the blocked task limit.", [ new("Data", 0, "SlayerWyverns", false, "equals", "Must not already have Wyverns turned off.") ], [ new("Data", "SlayerWyverns", "set", 1)]));
            SlayerUnlocks.Add(new("Basilocked", 80, "Konar, Duradel, and Nieve will be able to assign basilisks as your task.", [ new("Data", 0, "SlayerBasilisk", false, "equals", "Must not already be assignable basilisks.") ], [ new("Data", "SlayerBasilisk", "set", 1)]));
            SlayerUnlocks.Add(new("Actual Vampire Slayer", 80, "Konar, Duradel, Nieve, and Chaeldar will be able to assign vampires as your task.", [ new("Data", 0, "SlayerVampire", false, "equals", "Must not already be assignable vampires.") ], [ new("Data", "SlayerVampire", "set", 1)]));
            SlayerUnlocks.Add(new("Task Storage", 500, "Gain the ability to store your current task.", [ new("Data", 0, "SlayerStorage", false, "equals", "Must not already be able to store your task.") ], [ new("Data", "SlayerStorage", "set", 1)]));
            SlayerUnlocks.Add(new("I Wildy More Slayer", 0, "Krystilia will be able to assign jellies, dust devils, nechryaels, and abyssal demons as your task.", [ new("Data", 0, "SlayerWildy", false, "equals", "Must not already be assignable various wilderness monsters.") ], [ new("Data", "SlayerWildy", "set", 1)]));
            SlayerUnlocks.Add(new("Warped Reality", 60, "Konar, Duradel, Nieve, and Chaeldar will be able to assign Warped creatures as your task. Not the ones in the Lumbridge Catacombs.", [ new("Data", 0, "SlayerWarped", false, "equals", "Must not already be assignable warped creatures.") ], [ new("Data", "SlayerWarped", "set", 1)]));
            SlayerUnlocks.Add(new("Lured In", 80, "Duradel and Nieve will be able to assign aquanites as your task.", [ new("Data", 0, "SlayerAquanite", false, "equals", "Must not already be assignable aquanites.") ], [ new("Data", "SlayerAquanite", "set", 1)]));
            SlayerUnlocks.Add(new("Wings Spread", 80, "Duradel and Nieve will be able to assign gryphons as your task.", [ new("Data", 0, "SlayerGryphon", false, "equals", "Must not already be assignable gryphons.") ], [ new("Data", "SlayerGryphon", "set", 1)]));
            SlayerUnlocks.Add(new("Chance of Heavy Frost", 100, "Duradel and Nieve will assign frost dragon tasks slightly more often.", [ new("Data", 0, "SlayerFrost", false, "equals", "Must not already have more likely frost dragons.") ], [ new("Data", "SlayerFrost", "set", 1)]));
            
            SlayerBuy.Clear();
            SlayerBuy.Add(new("Slayer ring (8)", 75, "An equippable ring that acts as a slayer gem and lets you teleport to useful slayer sites.", null, [ new("GiveItem", "ringSlayer", "", 1)]));
            SlayerBuy.Add(new("Broad bolts (x250)", 35, "Bolts that can damage Turoths and Kurask. Level 55 Slayer and 50 Ranged, alongside a suitable crossbow, are required to fire these bolts.", null, [ new("GiveItem", "boltsBroad", "", 250)]));
            SlayerBuy.Add(new("Broad arrows (x250)", 35, "Bolts that can damage Turoths and Kurask. Level 55 Slayer and 50 Ranged, alongside a suitable crossbow, are required to fire these bolts.", null, [ new("GiveItem", "boltsBroad", "", 250)]));
            SlayerBuy.Add(new("Herb sack", 75, "Stores up to 30 of each type of grimy herb (for a total of 450 herbs). Requires 58 Herblore.", [ new("Skill", 58, "Herblore") ], [ new("GiveItem", "sackHerb", "", 1)]));
            SlayerBuy.Add(new("Rune pouch", 750, "Stores up to 3 types of runes. Only one can be owned. Can also be obtained by exchanging a rune pouch note at a bank.", [ new("ItemNotOwned", 1, "pouchRune") ], [ new("GiveItem", "sackHerb", "", 1)]));
            
            SlayerTasks.Clear();
            SlayerTasks.Add(new("Cancel task", 30, "Cancels your current task without ending your streak.", [ new("SlayerTask", 1, "Any")], [ new("SlayerTask", "Cancel", "", 1)]));
            SlayerTasks.Add(new("Block task", 100, "Cancels your current task without ending your streak, and adds it to your block list so you don't receive it again.", [ new("SlayerTask", 1, "Any"), new("SlayerBlockRoom", 1, ""), new("SlayerNotBlocked", 1, "") ], [ new("SlayerTask", "Block", "", 1)]));
            SlayerTasks.Add(new("Extend task", 100, "Extends your current task by 20% of the originally assigned kills.", [ new("SlayerTask", 1, "Any"), new("SlayerNotExtended", 1, "") ], [ new("SlayerTask", "Extend", "", 1)]));
            SlayerTasks.Add(new("Prefer task", 100, "Makes it more likely you will receive this task in the future, and extends the task by 20%.", [ new("SlayerTask", 1, "Any"), new("SlayerPreferRoom", 1, ""), new("SlayerNotPreferred", 1, "") ], [ new("SlayerTask", "Prefer", "", 1)]));
            SlayerTasks.Add(new("Store task", 0, "Swap your active task with your stored task, if any.", [ new("Data", 1, "SlayerStorage", false, "equals", "Must have unlocked task storage from the Unlocks menu.") ], [ new("SlayerTask", "Store", "", 1)]));
            

        }

    }
}
