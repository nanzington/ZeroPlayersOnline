using GoRogue.DiceNotation.Terms;
using SadConsole.EasingFunctions;
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


        public static bool AnyVisible() {
            if (CollectionLog.IsVisible)
                return true;
            if (CraftingMenu.IsVisible)
                return true;
            if (Guide.IsVisible)
                return true;
            if (Quests.IsVisible)
                return true;
            if (Compendium.IsVisible)
                return true;
            
            return false;
        }

        public static void HideAll() {
            CollectionLog.IsVisible = false;
            CraftingMenu.IsVisible = false;
            Guide.IsVisible = false;
            Quests.IsVisible = false;
            Compendium.IsVisible = false;
        }

        public static void SetupWindows() {
            CollectionLog = new(70, 30);
            CollectionLog.CanDrag = true;
            CollectionLog.Position = new Point(25, 10);
            CollectionLog.Title = "Collection Log".Align(HorizontalAlignment.Center, 68);

            Guide = new(100, 30);
            Guide.CanDrag = true;
            Guide.Position = new Point(25, 10);
            Guide.Title = "Guidebook".Align(HorizontalAlignment.Center, 98);

            CraftingMenu = new(100, 30);
            CraftingMenu.CanDrag = true;
            CraftingMenu.Position = new Point(25, 10);
            CraftingMenu.Title = "Crafting Menu".Align(HorizontalAlignment.Center, 98);

            Quests = new(100, 30);
            Quests.CanDrag = true;
            Quests.Position = new Point(25, 10);
            Quests.Title = "Quest Log".Align(HorizontalAlignment.Center, 98);
 
            Compendium = new(100, 30);
            Compendium.CanDrag = true;
            Compendium.Position = new Point(25, 10);
            Compendium.Title = "Compendium".Align(HorizontalAlignment.Center, 98);
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
         

        static List<CompendiumResult> Sources = new();
        public static void CompendiumDraw() {
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
                int qty = 1;
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;


                if (GameLoop.ZPO.ItemLibrary.Count > 24) {
                    if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, GameLoop.ZPO.ItemLibrary.Count - 24); }
                    if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, GameLoop.ZPO.ItemLibrary.Count - 24); }
                } else {
                    CompendiumSidebarTop = 0;
                }

                int sidebarY = 3; 

                
                Compendium.PrintStringField(2, sidebarY++, "Filter: ", ref Filter, ref SelectedField, "itemFilter");
                Compendium.DrawLine(new Point(1, sidebarY), new Point(29, sidebarY++), 196);

                List<Item> items = GameLoop.ZPO.ItemLibrary.Values.Where(u => u.Name != null && u.Name.ToLower().Contains(Filter.ToLower())).OrderBy(o => o.Name).ToList();

                for(int i = CompendiumSidebarTop; i < items.Count && i < CompendiumSidebarTop + 24; i++) {
                    Compendium.PrintClickable(1, sidebarY++, new ColoredString(items[i].Name, items[i].GetColor(), Color.Black), () => { CompendiumViewingID = items[i].ID; CompendiumShowSources = false; });
                }

                if (GameLoop.ZPO.ItemLibrary.TryGetValue(CompendiumViewingID, out Item? item)) {
                    int itemY = 3;

                    Compendium.Print(32, itemY++, "     ID: " + item.ID); 
                    Compendium.Print(71, 3, ("Color: r" + item.colR + " / g" + item.colG + " / b" + item.colB).Align(HorizontalAlignment.Right, 27));
                    Compendium.Print(32, itemY++, "   Name: " + item.Name, item.GetColor());  
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

                        itemY += 2;
                        
                        if (item.Potion.Count > 0) {
                            Compendium.Print(32, itemY, "Potion Effects: ", Color.White); 
                            for (int pot = 0; pot < item.Potion.Count; pot++) {
                                Compendium.Print(48, itemY++, item.Potion[pot].Stat + " " + (item.Potion[pot].Change > 0 ? "+" : "") + item.Potion[pot].Change, Color.White); 
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
                            Compendium.PrintClickable(1, sidebarY++, new ColoredString(output.Name, output.GetColor(), Color.Black), () => { CompendiumViewingID = recipes[i].FirstItem; CompendiumViewingID2 = recipes[i].SecondItem; });
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
                                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(output.Name, output.GetColor(), Color.Black), () => { 
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
                            Compendium.PrintClickable(2, sidebarY++, stations[i].Name, () => { CompendiumViewingID2 = stations[i].Name; Sources = StationLocations(CompendiumViewingID2); });
                        }
                    } else {
                        if (GameLoop.ZPO.ProcessingStations.TryGetValue(CompendiumViewingID2, out ProcessingStation? station) && station != null) {
                            List<ProcessingRecipe> masterRecipes = station.Recipes.OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputID))).ToList();
                            
                            List<ProcessingRecipe> recipes = station.Recipes.Where(u => (GameLoop.ZPO.ResolveItemName(u.InputID).ToLower().Contains(Filter.ToLower())) || (GameLoop.ZPO.ResolveItemName(u.OutputID).ToLower().Contains(Filter.ToLower()))).OrderBy(o => (GameLoop.ZPO.ResolveItemName(o.OutputID))).ToList();
                            
                            if (recipes.Count > 20) {
                                if (Helper.ScrolledUp()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop - qty, 0, recipes.Count - 20); }
                                if (Helper.ScrolledDown()) { CompendiumSidebarTop = Math.Clamp(CompendiumSidebarTop + qty, 0, recipes.Count - 20); }
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

                            for (int i = CompendiumSidebarTop; i < recipes.Count && i < CompendiumSidebarTop + 20; i++) {
                                Item? output = GameLoop.ZPO.ResolveItem(recipes[i].OutputID);

                                if (output != null) {
                                    Compendium.PrintClickable(2, sidebarY++, new ColoredString(output.Name, output.GetColor(), Color.Black), () => { 
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
                                Compendium.PrintClickable(32, npcY++, "| " + GameLoop.ZPO.ResolveItemName(npc.PickpocketLoot[i].Item) + " [" + npc.PickpocketLoot[i].Weight + "]", () => { ResetAllCompendiumValues(); CompendiumCat = "Items"; CompendiumViewingID = npc.PickpocketLoot[i].Item; });
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
                        Compendium.Print(32, monY++, "Aggro: Lv" + mon.AggroLevel + " (Always Aggro: " + Helper.Checkmark(mon.AlwaysAggro) + new ColoredString(")")); 
                        Compendium.Print(32, monY++, "Damage: " + mon.DamageDice + " " + mon.DamageType, Color.White);
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

                    if (GameLoop.ZPO.player.QuestLog.TryGetValue(quests[i].ID, out Quest? questProg) && questProg != null) {
                        if (questProg.CurrentStage != -1) { col = Color.Yellow; } 
                        if (questProg.CurrentStage == questProg.CompleteStage) { col = Color.Lime; }
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
                                Compendium.Print(32, questY++, "| " + quest.RequirementsToStart[i].GetSummary(), quest.RequirementsToStart[i].CheckRequirement(GameLoop.ZPO.player) ? Color.Lime : Color.Crimson);
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
                            Compendium.PrintClickable(32, skillY++, Helper.Truncate(Sources[i].Display, 67), () => { SetAllCompendiumValues(Sources[i]); });
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
                        sources.Add(new("[" + recipes[i].SkillLevel.ToString().Align(HorizontalAlignment.Right, 3) + "] Process " + GameLoop.ZPO.ResolveItemName(recipes[i].InputID) + " to " + GameLoop.ZPO.ResolveItemName(recipes[i].OutputID) + " at " + kv.Value.Name, "Recipes", "ProcessRecipe", "", kv.Value.Name, i));
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
                    sources.Add(new("[" + kv.Value.Level.ToString().Align(HorizontalAlignment.Right, 3) + "] " + kv.Value.InteractVerb + " " + kv.Value.Name, "Gathering", "", kv.Value.ID, "", 0));
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
                        int totalWeight = 0;
                        for (int i = 0; i < kv.Value.PickpocketLoot.Count; i++) {
                            totalWeight += kv.Value.PickpocketLoot[i].Weight;
                        }

                        for (int i = 0; i < kv.Value.PickpocketLoot.Count; i++) {
                            if (kv.Value.PickpocketLoot[i].Item == id) { 
                                sources.Add(new("Pickpocket: " + kv.Value.PickpocketLoot[i].Weight + "/" + totalWeight + " from " + kv.Value.Name, "NPCs", "", kv.Value.ID, "", 0));
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

            sources = sources.OrderBy(o => o.Display).ToList();
            return sources;
        }


        static List<AreaMonster> monsterList = new();
        static List<BossFight> bossList = new();

        public static void CollectionLogDraw() {
            CollectionLog.Clear();
            Helper.DrawBox(CollectionLog, 0, 0, 68, 28);
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
                
                if (GameLoop.ZPO.ItemLibrary.TryGetValue(CollectionID, out Item? cask) && cask != null) { 
                    if (cask.DropTable.Count > 24) {
                        if (Helper.ScrolledUp()) { CollectionDropTop = Math.Clamp(CollectionDropTop - 1, 0, cask.DropTable.Count - 24); }
                        if (Helper.ScrolledDown()) { CollectionDropTop = Math.Clamp(CollectionDropTop + 1, 0, cask.DropTable.Count - 24); }
                    }

                    int KC = 0;

                    if (GameLoop.ZPO.player.CollectionLogClues.ContainsKey(CollectionID)) {
                        KC = GameLoop.ZPO.player.CollectionLogClues[CollectionID].KillCount;
                    }

                    CollectionLog.Print(26, 1, (cask.Name + " (" + KC + " Opened)").Align(HorizontalAlignment.Center, 42), Color.White);
                    CollectionLog.DrawLine(new Point(26, 2), new Point(68, 2), 196, Color.White);
                    CollectionLog.Print(26, 3, "Item Name", Color.White);
                    CollectionLog.Print(49, 3, "Chance", Color.White);
                    CollectionLog.Print(60, 3, "Obtained", Color.White);
                    CollectionLog.DrawLine(new Point(26, 4), new Point(68, 4), 196, Color.White);

                    int printCount = 0;
                    for (int i = CollectionDropTop; i < cask.DropTable.Count && i < CollectionDropTop + 24; i++) { 
                        int timesObtained = 0;

                        if (GameLoop.ZPO.player.CollectionLogClues[CollectionID].DropsObtained.ContainsKey(cask.DropTable[i].ItemID)) {
                            timesObtained = GameLoop.ZPO.player.CollectionLogClues[CollectionID].DropsObtained[cask.DropTable[i].ItemID];
                        }

                        string name = GameLoop.ZPO.ResolveItemName(cask.DropTable[i].ItemID); 

                        string dropchance = (cask.DropTable[i].DropX).ToString().PadLeft(5) + " in " + cask.DropTable[i].InY;

                        CollectionLog.Print(26, 5 + printCount, name, timesObtained > 0 ? Color.White : Color.DarkSlateGray);
                        CollectionLog.Print(58, 5 + printCount, timesObtained.ToString().PadLeft(10), timesObtained > 0 ? Color.White : Color.DarkSlateGray);
                        CollectionLog.Print(45, 5 + printCount, dropchance, timesObtained > 0 ? Color.White : Color.DarkSlateGray);
                        printCount++;
                    } 

                    if (CollectionDropTop != 0) {
                        CollectionLog.PrintVertical(69, 5, new ColoredString("^++", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 5, new ColoredString("^++", Color.Lime, Color.Black));
                    }

                    if (cask.DropTable.Count > CollectionDropTop + 24) {
                        CollectionLog.PrintVertical(69, 26, new ColoredString("++v", Color.Lime, Color.Black));
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

                    CollectionLog.Print(26, 1, (view.Name + " (" + KC + " KC)").Align(HorizontalAlignment.Center, 42), Color.White);
                    CollectionLog.DrawLine(new Point(26, 2), new Point(68, 2), 196, Color.White);
                    CollectionLog.Print(26, 3, "Item Name", Color.White);
                    CollectionLog.Print(49, 3, "Chance", Color.White);
                    CollectionLog.Print(60, 3, "Obtained", Color.White);
                    CollectionLog.DrawLine(new Point(26, 4), new Point(68, 4), 196, Color.White);

                    int printCount = 0;
                    for (int i = CollectionDropTop; i < view.DropTable.Count && i < CollectionDropTop + 24; i++) {
                        int timesObtained = 0;

                        if (GameLoop.ZPO.player.CollectionLogBoss.ContainsKey(view.ID)) {
                            if (GameLoop.ZPO.player.CollectionLogBoss[view.ID].DropsObtained.ContainsKey(view.DropTable[i].ItemID)) {
                                timesObtained = GameLoop.ZPO.player.CollectionLogBoss[view.ID].DropsObtained[view.DropTable[i].ItemID];
                            }
                        }

                        string name = GameLoop.ZPO.ResolveItemName(view.DropTable[i].ItemID);

                        string dropchance = (view.DropTable[i].DropX).ToString().PadLeft(5) + " in " + view.DropTable[i].InY;

                        CollectionLog.Print(26, 5 + printCount, name, timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        CollectionLog.Print(58, 5 + printCount, timesObtained.ToString().PadLeft(10), timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        CollectionLog.Print(45, 5 + printCount, dropchance, timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        printCount++;
                    }

                    if (CollectionDropTop != 0) {
                        CollectionLog.PrintVertical(69, 5, new ColoredString("^++", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 5, new ColoredString("^++", Color.Lime, Color.Black));
                    }

                    if (view.DropTable.Count > CollectionDropTop + 24) {
                        CollectionLog.PrintVertical(69, 26, new ColoredString("++v", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 26, new ColoredString("++v", Color.Lime, Color.Black));
                    }
                }
            } else {
                monsterList.Clear();
                monsterList = GameLoop.ZPO.MonsterLibrary.Values.ToList().OrderBy(f => f.Name).ToList();

                for (int i = 0; i < monsterList.Count; i++) {
                    CollectionLog.PrintClickable(1, 1 + i, new ColoredString(" " + monsterList[i].Name, CollectionID == monsterList[i].ID ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = monsterList[i].ID; });
                }

                if (GameLoop.ZPO.MonsterLibrary.ContainsKey(CollectionID)) {
                    AreaMonster view = GameLoop.ZPO.MonsterLibrary[CollectionID];

                    if (view.DropTable.Count > 24) {
                        if (Helper.ScrolledUp()) { CollectionDropTop = Math.Clamp(CollectionDropTop - 1, 0, view.DropTable.Count - 24); }
                        if (Helper.ScrolledDown()) { CollectionDropTop = Math.Clamp(CollectionDropTop + 1, 0, view.DropTable.Count - 24); }
                    } 

                    int KC = 0;

                    if (GameLoop.ZPO.player.CollectionLog.ContainsKey(view.ID)) {
                        KC = GameLoop.ZPO.player.CollectionLog[view.ID].KillCount;
                    }

                    CollectionLog.Print(26, 1, (view.Name + " (" + KC + " KC)").Align(HorizontalAlignment.Center, 42), Color.White);
                    CollectionLog.DrawLine(new Point(26, 2), new Point(68, 2), 196, Color.White);
                    CollectionLog.Print(26, 3, "Item Name", Color.White);
                    CollectionLog.Print(49, 3, "Chance", Color.White);
                    CollectionLog.Print(60, 3, "Obtained", Color.White);
                    CollectionLog.DrawLine(new Point(26, 4), new Point(68, 4), 196, Color.White);

                    int printCount = 0;
                    for (int i = CollectionDropTop; i < view.DropTable.Count && i < CollectionDropTop + 24; i++) {
                        int timesObtained = 0;

                        if (GameLoop.ZPO.player.CollectionLog.ContainsKey(view.ID)) {
                            if (GameLoop.ZPO.player.CollectionLog[view.ID].DropsObtained.ContainsKey(view.DropTable[i].ItemID)) {
                                timesObtained = GameLoop.ZPO.player.CollectionLog[view.ID].DropsObtained[view.DropTable[i].ItemID];
                            }
                        }

                        string name = GameLoop.ZPO.ResolveItemName(view.DropTable[i].ItemID);

                        string dropchance = (view.DropTable[i].DropX).ToString().PadLeft(5) + " in " + view.DropTable[i].InY;

                        CollectionLog.Print(26, 5 + printCount, name, timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        CollectionLog.Print(58, 5 + printCount, timesObtained.ToString().PadLeft(10), timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        CollectionLog.Print(45, 5 + printCount, dropchance, timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        printCount++;
                    }

                    if (CollectionDropTop != 0) {
                        CollectionLog.PrintVertical(69, 5, new ColoredString("^++", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 5, new ColoredString("^++", Color.Lime, Color.Black));
                    }

                    if (view.DropTable.Count > CollectionDropTop + 24) {
                        CollectionLog.PrintVertical(69, 26, new ColoredString("++v", Color.Lime, Color.Black));
                        CollectionLog.PrintVertical(25, 26, new ColoredString("++v", Color.Lime, Color.Black));
                    }
                }
            }


            
            CollectionLog.PrintClickable(45, 0, new ColoredString("[CLUE]", CollectionCat == "Clue" ? Color.White : Color.DarkSlateGray, Color.Black), () => { CollectionCat = "Clue"; });
            CollectionLog.PrintClickable(52, 0, new ColoredString("[BOSS]", CollectionCat == "Boss" ? Color.White : Color.DarkSlateGray, Color.Black), () => { CollectionCat = "Boss"; }); 
            CollectionLog.PrintClickable(59, 0, new ColoredString("[MONSTER]", CollectionCat == "Monster" ? Color.White : Color.DarkSlateGray, Color.Black), () => { CollectionCat = "Monster"; });

            CollectionLog.PrintClickable(69, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { CollectionLog.IsVisible = false; });
        }

        public static void CraftingMenuDraw() {
            CraftingMenu.Clear(); 
            Helper.DrawBox(CraftingMenu, 0, 0, 98, 28);
            CraftingMenu.Print(2, 0, "[Crafting Menu - " + CraftingType + "]");
            CraftingMenu.DrawLine(new Point(25, 1), new Point(25, 28), 179);  

            List<string> ItemsUsed = new();

            if (GameLoop.ZPO.CraftLib.ContainsKey(CraftingType)) {
                foreach (var craft in GameLoop.ZPO.CraftLib[CraftingType]) {
                    string item = GameLoop.ZPO.ResolveItemName(craft.NeededItems[0].Split(",")[0]); // TODO: Remake this to list all items somehow
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

            for (int i = 0; i < ActiveRecipes.Count; i++) {
                CraftRecipe rec = ActiveRecipes[i];
                string name = GameLoop.ZPO.ResolveItemName(rec.OutputItem) + (rec.OutputQty > 1 ? " x" + rec.OutputQty : "");

                string[] item = rec.NeededItems[0].Split(",");
                // TODO: Rework this display too, to account for multiple possible reagents
                string line = name.Align(HorizontalAlignment.Left, 31, ' ') + 179.AsString() + " "
                    + rec.Level.ToString().Align(HorizontalAlignment.Right, 3) + " " + 179.AsString() + " "
                    + rec.ExpGranted.ToString().Align(HorizontalAlignment.Right, 5) + " " + 179.AsString() + " "
                    + item[1].Align(HorizontalAlignment.Right, 5) + " " + 179.AsString() + " "
                    + GameLoop.ZPO.ResolveItemName(rec.ExtraTool);

                if (GameLoop.ZPO.player.CanCraft(rec)) { 
                    CraftingMenu.PrintClickable(27, 3 + i, new ColoredString(line, Color.White, Color.Black), () => { GameLoop.ZPO.player.TryCraft(rec); });
                } else { 
                    CraftingMenu.Print(27, 3 + i, line, Color.Crimson);
                }
            }


            CraftingMenu.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { CraftingMenu.IsVisible = false; });
        }

        public static void PopulateCraftList() {
            ActiveRecipes.Clear();

            if (GameLoop.ZPO.CraftLib.ContainsKey(CraftingType)) {
                foreach (var craft in GameLoop.ZPO.CraftLib[CraftingType]) {
                    string itemNeeded = GameLoop.ZPO.ResolveItemName(craft.NeededItems[0].Split(",")[0]); // TODO: Maybe involve multiple ingredients, or just file it under the first/primary permanently?
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
                if (GameLoop.ZPO.player.QuestLog.TryGetValue(ViewingQuestID, out Quest? currQuest)) { 
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

            foreach(var kv in GameLoop.ZPO.player.QuestLog) {
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

                    if (QuestsInFilter[i].CurrentStage != -1) {
                        col = Color.Yellow;
                    }

                    if (QuestsInFilter[i].CurrentStage == QuestsInFilter[i].CompleteStage) {
                        col = Color.Lime;
                    }

                    Quests.PrintClickable(19, 1 + i, new ColoredString(QuestsInFilter[i].Name, col, Color.Black), () => {
                        ViewingQuestID = QuestsInFilter[i].ID;

                        if (GameLoop.ZPO.player.QuestLog.TryGetValue(ViewingQuestID, out Quest? nowViewing)) {
                            if (nowViewing != null) {
                                if (nowViewing.CurrentStage == -1) {
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
                if (GameLoop.ZPO.player.QuestLog.TryGetValue(ViewingQuestID, out Quest? currQuest)) {

                    if (QuestOverview) {
                        Quests.Print(19, 1, "Quest Name: " + currQuest.Name);
                        Quests.Print(19, 2, "Difficulty: " + currQuest.Difficulty);
                        Quests.Print(19, 3, "    Length: " + currQuest.Length);
                        int afterDesc = Quests.PrintMultiLine(19, 5, currQuest.Description, 80) + 2;

                        if (currQuest.CurrentStage != -1) {
                            Quests.PrintClickable(19, afterDesc, "[View Quest Log]", () => { QuestOverview = false; QuestBlockScrollTop = 0; });

                            if (currQuest.CurrentStage == currQuest.CompleteStage)
                                Quests.Print(19, afterDesc + 2, "Quest Complete!", Color.Lime);
                        }
                    } else {
                        int visibleStages = 0;
                        
                        foreach (var kv in currQuest.Stages) {
                            if (kv.Key <= currQuest.CurrentStage) {
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

                            if (kv.Key <= currQuest.CurrentStage) {
                                Color col = Color.DarkSlateGray;

                                if (kv.Key == currQuest.CurrentStage)
                                    col = Color.White;

                                printY = Quests.PrintMultiLine(19, printY, kv.Value.Description, 80, col.R, col.G, col.B);

                                printY += 2;
                            }
                        }

                        if (currQuest.CurrentStage == currQuest.CompleteStage)
                            Quests.Print(19, printY, "Quest Complete!", Color.Lime);

                        Quests.DrawLine(new Point(1, 29), (98, 29), 196, Color.White);
                    }
                } 
            }

            Quests.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { Quests.IsVisible = false; });
        }
    }
}
