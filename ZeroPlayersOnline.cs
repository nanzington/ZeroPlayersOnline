using GoRogue.DiceNotation.Terms;
using SadConsole.Input;
using SadConsole.UI; 
using System.Diagnostics;
using ZeroPlayersOnline.DataTypes; 
using ZeroPlayersOnline.HardcodedData;
using ZeroPlayersOnline.Hardcodes;
using ZeroPlayersOnline.Managers;
using ZeroPlayersOnline.UI; 
using Key = SadConsole.Input.Keys;

namespace ZeroPlayersOnline {
    public class ZeroPlayersOnline : MiniDream {
        public Player player;

        public Dictionary<string, Location> Atlas = new();
        public Dictionary<string, GatheringTile> GatherSpots = new();
        public Dictionary<string, Item> ItemLibrary = new();
        public Dictionary<string, ProcessingStation> ProcessingStations = new();
        public Dictionary<TwoWayString, Recipe> UseRecipes = new();
        public Dictionary<string, NPC> NPCLibrary = new();
        public Dictionary<string, AreaMonster> MonsterLibrary = new();
        public Dictionary<string, Prayer> PrayerLibrary = new();
        public Dictionary<string, List<CraftRecipe>> CraftLib = new();
        public Dictionary<string, Spell> SpellLibrary = new();

        public Dictionary<string, ClueStep> ClueStepLibrary = new();
        public Dictionary<string, Quest> QuestLibrary = new();

        public MessageLog Log = new();

        public string SelectedMenu = "Resources";
        public string SidebarMenu = "Inventory";
        public int UsingSlot = -1;
        public int SwapSlot = -1;
        public List<Skill> RecentlyTrainedSkills = new();

        public int CurrDialogueStage = -1;
        public NPC? ConversationPartner = null;

        public AreaMonster AttackingMonster = null;
        public double LastHitTime = 0;
        public double GraceTimeStart = 0;
        public string Targetting = "Single";

        public double LastHealedTick = 0;


        public Window CollectionLog;
        public string CollectionID = "";
        public int CollectionDropTop = 0;
        public int CollectionSideTop = 0;

        public Window CraftingMenu;
        public string CraftingType = "";
        public string CraftingSubtype = "";
        public List<CraftRecipe> ActiveRecipes = new();

        public Window Guide;
        public string GuideTab = "Introduction";
         
        public Window Quests;
        public string QuestFilter = "All";
        public string ViewingQuestID = "";
        public bool QuestOverview = true;
        public int QuestBlockScrollTop = 0;
        public string QuestSort = "A->Z";

        public string MagicTab = "Combat";
        public bool WarnedTutorialTele = false;
        public double TimeWarned = 0;

        public bool WithdrawingNotes = false;

        public int SecondsSinceAutosave = 0;
        public double TimeLastTicked = 0;

        public Rectangle ActivityRect = new Rectangle(new Point(111, 10), new Point(147, 34));
        public int ActivityItemTop = 0;

        public int SidebarScrollTop = 0;
        public Rectangle SidebarRect = new Rectangle(new Point(0, 15), new Point(54, 34));


        public ZeroPlayersOnline() {
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


            player = new();

            RebuildLibraries();

            TryAddSkills();
            TryAddPrayers();
            TryAddSpells();
            TryAddQuests();

            player.CurrentHP = 10;


            Log.AddMessage(new ColoredString("Press F1 at any time to open/close the guidebook.", Color.Turquoise, Color.Black));

            /*
            if (Directory.Exists("./data/ZPO/locations/")) {
                string[] mapFiles = Directory.GetFiles("./data/ZPO/locations/");

                foreach (string fileName in mapFiles) { 
                    Location loc = JsonConvert.DeserializeObject<Location>(File.ReadAllText(fileName)); 
                    if (!Atlas.ContainsKey(loc.ID))
                        Atlas.Add(loc.ID, loc); 
                }
            }

            if (Directory.Exists("./data/ZPO/gatherSpots/")) {
                string[] mapFiles = Directory.GetFiles("./data/ZPO/gatherSpots/");

                foreach (string fileName in mapFiles) {
                    GatheringTile loc = JsonConvert.DeserializeObject<GatheringTile>(File.ReadAllText(fileName));
                    if (!GatherSpots.ContainsKey(loc.Name))
                        GatherSpots.Add(loc.Name, loc);
                }
            }
            */
        } 

        public void GuideDraw() {
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


        List<AreaMonster> monsterList = new();

        public void CollectionLogDraw() {
            CollectionLog.Clear();
            Helper.DrawBox(CollectionLog, 0, 0, 68, 28);
            CollectionLog.Print(2, 0, "[Collection Log]");


            CollectionLog.DrawLine(new Point(25, 1), new Point(25, 28), 179, Color.White);

            if (CollectionID.Contains("casket")) {
                CollectionLog.PrintClickable(2, 1, new ColoredString("Tutorial Casket", CollectionID == "casketTutorial" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketTutorial"; });
                CollectionLog.PrintClickable(2, 2, new ColoredString("Beginner Casket", CollectionID == "casketBeginner" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketBeginner"; });
                CollectionLog.PrintClickable(2, 3, new ColoredString("Easy Casket", CollectionID == "casketEasy" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketEasy"; });
                CollectionLog.PrintClickable(2, 4, new ColoredString("Medium Casket", CollectionID == "casketMedium" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketMedium"; });
                CollectionLog.PrintClickable(2, 5, new ColoredString("Hard Casket", CollectionID == "casketHard" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketHard"; });
                CollectionLog.PrintClickable(2, 6, new ColoredString("Elite Casket", CollectionID == "casketElite" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketElite"; });
                CollectionLog.PrintClickable(2, 7, new ColoredString("Master Casket", CollectionID == "casketMaster" ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = "casketMaster"; });
                
                if (ItemLibrary.TryGetValue(CollectionID, out Item? cask) && cask != null) { 
                    if (cask.DropTable.Count > 24) {
                        if (Helper.ScrolledUp()) { CollectionDropTop = Math.Clamp(CollectionDropTop - 1, 0, cask.DropTable.Count - 24); }
                        if (Helper.ScrolledDown()) { CollectionDropTop = Math.Clamp(CollectionDropTop + 1, 0, cask.DropTable.Count - 24); }
                    }

                    int KC = 0;

                    if (player.CollectionLogClues.ContainsKey(CollectionID)) {
                        KC = player.CollectionLogClues[CollectionID].KillCount;
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

                        if (player.CollectionLogClues[CollectionID].DropsObtained.ContainsKey(cask.DropTable[i].ItemID)) {
                            timesObtained = player.CollectionLogClues[CollectionID].DropsObtained[cask.DropTable[i].ItemID];
                        }

                        string name = ResolveItemName(cask.DropTable[i].ItemID); 

                        string dropchance = (cask.DropTable[i].DropX).ToString().PadLeft(5) + " in " + cask.DropTable[i].InY;

                        CollectionLog.Print(26, 5 + printCount, name, timesObtained > 0 ? Color.White : Color.DarkSlateGray);
                        CollectionLog.Print(58, 5 + printCount, timesObtained.ToString().PadLeft(10), timesObtained > 0 ? Color.White : Color.DarkSlateGray);
                        CollectionLog.Print(45, 5 + printCount, dropchance, timesObtained > 0 ? Color.White : Color.DarkSlateGray);
                        printCount++;
                    }
                }
            } else {
                monsterList.Clear();
                monsterList = MonsterLibrary.Values.ToList().OrderBy(f => f.Name).ToList();

                for (int i = 0; i < monsterList.Count; i++) {
                    CollectionLog.PrintClickable(1, 1 + i, new ColoredString(monsterList[i].Name, CollectionID == monsterList[i].ID ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = monsterList[i].ID; });
                }

                if (MonsterLibrary.ContainsKey(CollectionID)) {
                    AreaMonster view = MonsterLibrary[CollectionID];

                    if (view.DropTable.Count > 24) {
                        if (Helper.ScrolledUp()) { CollectionDropTop = Math.Clamp(CollectionDropTop - 1, 0, view.DropTable.Count - 24); }
                        if (Helper.ScrolledDown()) { CollectionDropTop = Math.Clamp(CollectionDropTop + 1, 0, view.DropTable.Count - 24); }
                    } 

                    int KC = 0;

                    if (player.CollectionLog.ContainsKey(view.ID)) {
                        KC = player.CollectionLog[view.ID].KillCount;
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

                        if (player.CollectionLog.ContainsKey(view.ID)) {
                            if (player.CollectionLog[view.ID].DropsObtained.ContainsKey(view.DropTable[i].ItemID)) {
                                timesObtained = player.CollectionLog[view.ID].DropsObtained[view.DropTable[i].ItemID];
                            }
                        }

                        string name = ResolveItemName(view.DropTable[i].ItemID);

                        string dropchance = (view.DropTable[i].DropX).ToString().PadLeft(5) + " in " + view.DropTable[i].InY;

                        CollectionLog.Print(26, 5 + printCount, name, timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        CollectionLog.Print(58, 5 + printCount, timesObtained.ToString().PadLeft(10), timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        CollectionLog.Print(45, 5 + printCount, dropchance, timesObtained > 0 ? Color.White : Color.DarkSlateGray, Color.Black);
                        printCount++;
                    }
                }
            }


            CollectionLog.PrintClickable(69, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { CollectionLog.IsVisible = false; });
        }

        public void CraftingMenuDraw() {
            CraftingMenu.Clear(); 
            Helper.DrawBox(CraftingMenu, 0, 0, 98, 28);
            CraftingMenu.Print(2, 0, "[Crafting Menu - " + CraftingType + "]");
            CraftingMenu.DrawLine(new Point(25, 1), new Point(25, 28), 179);  

            List<string> ItemsUsed = new();

            if (CraftLib.ContainsKey(CraftingType)) {
                foreach (var craft in CraftLib[CraftingType]) {
                    string item = ResolveItemName(craft.NeededItems[0].Split(",")[0]); // TODO: Remake this to list all items somehow
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
                string name = ResolveItemName(rec.OutputItem) + (rec.OutputQty > 1 ? " x" + rec.OutputQty : "");

                string[] item = rec.NeededItems[0].Split(",");
                // TODO: Rework this display too, to account for multiple possible reagents
                string line = name.Align(HorizontalAlignment.Left, 31, ' ') + 179.AsString() + " "
                    + rec.Level.ToString().Align(HorizontalAlignment.Right, 3) + " " + 179.AsString() + " "
                    + rec.ExpGranted.ToString().Align(HorizontalAlignment.Right, 5) + " " + 179.AsString() + " "
                    + item[1].Align(HorizontalAlignment.Right, 5) + " " + 179.AsString() + " "
                    + ResolveItemName(rec.ExtraTool);

                if (player.CanCraft(rec)) { 
                    CraftingMenu.PrintClickable(27, 3 + i, new ColoredString(line, Color.White, Color.Black), () => { player.TryCraft(rec); });
                } else { 
                    CraftingMenu.Print(27, 3 + i, line, Color.Crimson);
                }
            }


            CraftingMenu.PrintClickable(99, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { CraftingMenu.IsVisible = false; });
        }

        public List<string> QuestLengths = [ "Very Short", "Short", "Medium", "Long", "Very Long" ];
        public List<string> QuestDifficulties = ["Novice", "Intermediate", "Experienced", "Master", "Grandmaster" ];
        public List<string> QuestRegions = [ "Asgarnia", "Desert", "Fremennik", "Kandarin", "Karamja", "Misthalin", "Morytania", "Wilderness" ];

        public void QuestDraw() {
            Quests.Clear();
            Helper.DrawBox(Quests, 0, 0, 98, 28);
            if (ViewingQuestID == "") {
                Quests.Print(2, 0, "[Quest Log - " + QuestFilter + " Quests]");
            } else { 
                if (player.QuestLog.TryGetValue(ViewingQuestID, out Quest? currQuest)) { 
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

            foreach(var kv in player.QuestLog) {
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

                    if (QuestsInFilter[i].CanStartQuest(player)) {
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

                        if (player.QuestLog.TryGetValue(ViewingQuestID, out Quest? nowViewing)) {
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
                if (player.QuestLog.TryGetValue(ViewingQuestID, out Quest? currQuest)) {

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

        public void SidebarDraw(UI_EmbeddedMini mini) {
            Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;

            mini.Con.DrawLine(new Point(55, 0), new Point(55, 34), 179);
             
            if (LastHealedTick + 3000 < Helper.Time()) {
                player.CurrentHP = Math.Clamp(player.CurrentHP + 1, 0, player.Skills["Constitution"].Level);
                LastHealedTick = Helper.Time();
            }


            mini.Con.Print(0, 0, "    HP: " + player.CurrentHP.ToString().Align(HorizontalAlignment.Right, 4, ' ') + " / " + player.Skills["Constitution"].Level.ToString().Align(HorizontalAlignment.Right, 4, ' '), Color.Crimson);
            mini.Con.Print(0, 1, "Prayer: " + player.TotalActivePrayers().ToString().Align(HorizontalAlignment.Right, 4, ' ') + " / " + player.GetEffectiveSkillLevel("Prayer").ToString().Align(HorizontalAlignment.Right, 4, ' '), Color.DodgerBlue);

            mini.Con.Print(0, 3, " Level: " + player.GetCombatLevel(), Color.Yellow); 

            bool magic = player.IsMaging();

            mini.Con.Print(0, 4, "Damage: " + player.GetDamageDice() + " " + player.GetDamageType(), Color.Yellow); 
            mini.Con.Print(0, 5, "vMelee: " + player.TotalArmorValue("Melee"), Color.Yellow);
            mini.Con.Print(0, 6, "vMagic: " + player.TotalArmorValue("Magic"), Color.Yellow);
            mini.Con.Print(0, 7, "vRange: " + player.TotalArmorValue("Ranged"), Color.Yellow);

            if (player.CastingSpell != "") {
                if (SpellLibrary.ContainsKey(player.CastingSpell)) {
                    if (player.CanCast(SpellLibrary[player.CastingSpell]) != "") {
                        player.CastingSpell = ""; 
                    }
                }
            }

            if (player.CastingSpell != "") {
                if (SpellLibrary.ContainsKey(player.CastingSpell)) { 
                    mini.Con.PrintClickable(0, 9, new ColoredString("*" + SpellLibrary[player.CastingSpell].Name.Align(HorizontalAlignment.Center, 18) + "*", Color.SkyBlue, Color.Black), () => { player.CastingSpell = ""; });
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

            if (Atlas.ContainsKey(player.NavLoc)) {
                Location curr = Atlas[player.NavLoc];


                if (curr.ItemSpawns.Count > 0) {  
                    for (int i = 0; i < curr.ItemSpawns.Count; i++) {  
                        if (curr.ItemSpawns[i].LastPickedUp + (curr.ItemSpawns[i].RespawnTimer * 1000) < Helper.Time() || curr.ItemSpawns[i].LastPickedUp == 0) {
                            bool itemSpawnedAlready = false;
                            if (curr.ItemSpawns[i].ReqToSpawn != null && !curr.ItemSpawns[i].ReqToSpawn.CheckRequirement(player)) {
                                itemSpawnedAlready = true;
                            } 

                            for (int j = 0; j < curr.ItemsHere.Count; j++) {
                                if (player.RandomItems == 0) {
                                    if (curr.ItemsHere[j].ID == curr.ItemSpawns[i].ItemID) {
                                        itemSpawnedAlready = true;
                                    }
                                } else {
                                    if (ItemLibrary.ContainsKey(curr.ItemSpawns[i].ItemID)) {
                                        if (curr.ItemsHere[j].ID == ItemLibrary[curr.ItemSpawns[i].ItemID].ID) {
                                            itemSpawnedAlready = true;
                                        }
                                    }
                                }
                            }

                            if (!itemSpawnedAlready) {
                                if (ItemLibrary.ContainsKey(curr.ItemSpawns[i].ItemID)) {
                                    Item spawn = Helper.Clone(ItemLibrary[curr.ItemSpawns[i].ItemID]);
                                    curr.ItemsHere.Add(spawn);
                                    curr.ItemSpawns[i].LastPickedUp = Helper.Time();
                                }
                            }
                        }
                    }
                }




                mini.Con.DrawLine(new Point(0, 12), new Point(54, 12), 196);

                mini.Con.PrintClickable(1, 13, new ColoredString("INV", SidebarMenu == "Inventory" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Inventory"; });
                mini.Con.Print(5, 13, "|"); 
                mini.Con.PrintClickable(7, 13, new ColoredString("EQP", SidebarMenu == "Equipment" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Equipment"; });
                mini.Con.Print(11, 13, "|");
                mini.Con.PrintClickable(13, 13, new ColoredString("SKL", SidebarMenu == "Skills" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Skills"; });
                mini.Con.Print(17, 13, "|");
                mini.Con.PrintClickable(19, 13, new ColoredString("MAG", SidebarMenu == "Magic" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Magic"; });
                mini.Con.Print(23, 13, "|");
                mini.Con.PrintClickable(25, 13, new ColoredString("PRA", SidebarMenu == "Prayer" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Prayer"; });
                mini.Con.Print(29, 13, "|");
                mini.Con.PrintClickable(31, 13, new ColoredString("EMO", SidebarMenu == "Emote" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Emote"; });
                mini.Con.Print(35, 13, "|");
                mini.Con.PrintClickable(37, 13, new ColoredString("QST", SidebarMenu == "Quest" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Quest"; });
                mini.Con.Print(41, 13, "|");
                mini.Con.PrintClickable(43, 13, new ColoredString("LOG", SidebarMenu == "Log" ? Color.Yellow : Color.White, Color.Black), () => { SidebarMenu = "Log"; });


                mini.Con.DrawLine(new Point(0, 14), new Point(54, 14), 196);

                if (SidebarMenu == "Inventory") {

                    for (int i = 0; i < player.InventoryLimit; i++) {
                        mini.Con.DrawLine(new Point(0, 15 + i), new Point(54, 15 + i), '-', Color.DarkSlateGray);

                        if (i < player.Inventory.Count) {
                            string line = player.Inventory[i].Name;

                            if (player.Inventory[i].Quantity > 1) {
                                line += " x" + player.Inventory[i].Quantity;
                            }

                            if (player.Inventory[i].Noted) {
                                line += " (n)";
                            }

                            int colorSum = player.Inventory[i].colR + player.Inventory[i].colG + player.Inventory[i].colB;

                            Color itemName = new Color(player.Inventory[i].colR, player.Inventory[i].colG, player.Inventory[i].colB);

                            mini.Con.Print(0, 15 + i, line, (mousePos.X < 55 && mousePos.Y == 15 + i) ? itemName.GetDarker() : itemName, colorSum < 60 ? Color.White : Color.Black);

                            bool dropped = false; 

                            if (player.Inventory[i].UseString != "") {
                                if (!player.Inventory[i].Noted) {
                                    mini.Con.PrintClickable(46, 15 + i, new ColoredString("* ", Color.Yellow, Color.Black), () => {
                                        Item item = player.Inventory[i];
                                        bool success = UseItem(item);

                                        if (item.ConsumedOnUse && success) {
                                            if (player.PrayerActive("Cornucopia")) {
                                                if (GameLoop.rand.Next(5) != 0) { 
                                                    item.Quantity -= 1;
                                                } else { 
                                                    Log.AddMessage(new ColoredString("The blessing of the cornucopia preserves your item.", Color.Goldenrod, Color.Black));
                                                }
                                            } else {
                                                item.Quantity -= 1;
                                            }
                                        }

                                        if (item.Quantity <= 0) {
                                            player.Inventory.RemoveAt(i);
                                            dropped = true;
                                        }
                                    });
                                }
                            }

                            if (dropped)
                                break;

                            if (player.Inventory[i].EquipSlot != "" && !player.Inventory[i].Noted) {
                                mini.Con.PrintClickable(46, 15 + i, new ColoredString("E ", Color.Yellow, Color.Black), () => {
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
                                                dropped = true;
                                                return;
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

                                        dropped = true;
                                    }
                                });
                            } 

                            mini.Con.PrintClickable(48, 15 + i, new ColoredString("> ", Color.Turquoise, Color.Black), () => {
                                if (SwapSlot == -1) {
                                    SwapSlot = i;
                                }
                                else {
                                    Item first = Helper.Clone(player.Inventory[SwapSlot]);
                                    player.Inventory[SwapSlot] = Helper.Clone(player.Inventory[i]);
                                    player.Inventory[i] = first;
                                    SwapSlot = -1;
                                }
                            });


                            mini.Con.PrintClickable(54, 15 + i, new ColoredString("X", Color.Crimson, Color.Black), () => { 
                                int qty = 1;
                                
                                if (Helper.EitherShift())
                                    qty *= 5;
                                if (Helper.EitherControl())
                                    qty *= 10;

                                if (qty > player.Inventory[i].Quantity)
                                    qty = player.Inventory[i].Quantity;


                                if (curr.IsBank && player.CanUseBanks) {
                                    bool found = false;

                                    for (int j = 0; j < player.BankedItems.Count; j++) {
                                        if (player.BankedItems[j].ID.Equals(player.Inventory[i].ID)) {
                                            player.BankedItems[j].Quantity += qty;
                                            player.Inventory[i].Quantity -= qty;
                                            found = true;
                                            break;
                                        }
                                    }

                                    if (!found) { 
                                        Item clone = Helper.Clone(player.Inventory[i]);
                                        clone.Quantity = qty;
                                        clone.Noted = false;
                                        player.BankedItems.Add(clone);
                                        player.Inventory[i].Quantity -= qty;
                                    }  
                                }
                                else {
                                    if (curr.ShopItemsHere.Count == 0 || !player.CanUseShops) {
                                        if (player.Inventory[i].DestroyOnDrop) {
                                            if (player.Inventory[i].ID == "clueScrollTutorial") {
                                                player.CurrentClueTutorial = "";
                                            } else if (player.Inventory[i].ID == "clueScrollBeginner") {
                                                player.CurrentClueBeginner = "";
                                            } else if (player.Inventory[i].ID == "clueScrollEasy") {
                                                player.CurrentClueEasy = "";
                                            } else if (player.Inventory[i].ID == "clueScrollMedium") {
                                                player.CurrentClueMedium = "";
                                            } else if (player.Inventory[i].ID == "clueScrollHard") {
                                                player.CurrentClueHard = "";
                                            } else if (player.Inventory[i].ID == "clueScrollElite") {
                                                player.CurrentClueElite = "";
                                            } else if (player.Inventory[i].ID == "clueScrollMaster") {
                                                player.CurrentClueMaster = "";
                                            }

                                            player.Inventory.RemoveAt(i);
                                            dropped = true;
                                            return;
                                        } else {
                                            bool found = false;
                                            if (player.Inventory[i].Stackable || player.Inventory[i].Noted) {
                                                for (int j = 0; j < curr.ItemsHere.Count; j++) {
                                                    if (curr.ItemsHere[j].ID == player.Inventory[i].ID && curr.ItemsHere[j].Noted == player.Inventory[i].Noted) {
                                                        curr.ItemsHere[j].Quantity += qty;
                                                        player.Inventory[i].Quantity -= qty;
                                                        found = true;
                                                    }
                                                }
                                            }

                                            if (!found) {
                                                Item clone = Helper.Clone(player.Inventory[i]);
                                                clone.Quantity = qty;

                                                curr.ItemsHere.Add(clone);
                                                player.Inventory[i].Quantity -= qty;
                                            }
                                        }
                                    }
                                    else {
                                        player.HeldGold += player.Inventory[i].Value * qty;
                                        player.Inventory[i].Quantity -= qty;
                                    }
                                }

                                if (player.Inventory[i].Quantity <= 0) {
                                    player.Inventory.RemoveAt(i);
                                    dropped = true;
                                }
                            });

                            if (dropped)
                                break;

                            mini.Con.PrintClickable(52, 15 + i, new ColoredString("? ", Color.MediumPurple, Color.Black), () => { 
                                Log.AddMessage(new ColoredString(player.Inventory[i].ExamineText, Color.SandyBrown, Color.Black)); 

                                foreach (var kv in player.QuestLog) {
                                    kv.Value.CheckProgress(player, "ExamineItem", player.Inventory[i].ID, 0);
                                }
                            });

                            if (!player.Inventory[i].Noted) {
                                mini.Con.PrintClickable(50, 15 + i, new ColoredString("U ", UsingSlot == i ? Color.Green : Color.Yellow, Color.Black), () => {
                                    if (UsingSlot == -1) {
                                        UsingSlot = i;
                                    }
                                    else {
                                        string first = player.Inventory[UsingSlot].ID;
                                        string second = player.Inventory[i].ID;

                                        if (UseRecipes.ContainsKey(new TwoWayString(first, second))) {
                                            Recipe rec = UseRecipes[new TwoWayString(first, second)];
                                            int firstSlot = UsingSlot;
                                            int secondSlot = i;

                                            if (rec.FirstItem == second) {
                                                firstSlot = i;
                                                secondSlot = UsingSlot;
                                            }

                                            Item firstItem = player.Inventory[firstSlot];
                                            Item secondItem = player.Inventory[secondSlot];

                                            if (!firstItem.Noted && !secondItem.Noted) { 
                                                if (firstItem.Quantity < rec.FirstQty) {
                                                    Log.AddMessage(new ColoredString("You need " + rec.FirstQty + " " + firstItem.Name + " to do that.", Color.Crimson, Color.Black));
                                                    return;
                                                }

                                                if (secondItem.Quantity < rec.SecondQty) {
                                                    Log.AddMessage(new ColoredString("You need " + rec.SecondQty + " " + secondItem.Name + " to do that.", Color.Crimson, Color.Black));
                                                    return;
                                                }

                                                firstItem.Quantity -= rec.FirstQty;
                                                if (firstItem.Quantity <= 0)
                                                    player.Inventory.Remove(firstItem);

                                                secondItem.Quantity -= rec.SecondQty;
                                                if (secondItem.Quantity <= 0)
                                                    player.Inventory.Remove(secondItem);

                                                if (rec.OutputItem[0] != '_') {
                                                    if (ItemLibrary.ContainsKey(rec.OutputItem)) {
                                                        Item made = Helper.Clone(ItemLibrary[rec.OutputItem]);
                                                        made.Quantity = rec.OutputQty;

                                                        player.TryPickup(made, made.Quantity);
                                                    } else {
                                                        Log.AddMessage(new ColoredString("You get the feeling that should've resulted in " + rec.OutputItem + ", but that item doesn't exist.", Color.Crimson, Color.Black));
                                                    }
                                                } else {
                                                    if (rec.OutputItem == "_fire") {
                                                        if (Atlas.ContainsKey(player.NavLoc)) {
                                                            Location curr = Atlas[player.NavLoc];
                                                     
                                                            ProcessingStation fire = Helper.Clone(ProcessingStations["Range"]);
                                                            fire.Name = "Fire";
                                                            fire.TimeLeft = rec.OutputQty;
                                                            fire.TimeMade = Helper.Time();
                                                            fire.ItemOnExpire = rec.MiscString;
                                                     
                                                            curr.TempStations.Add(fire);
                                                        }
                                                
                                                        Log.AddMessage(new ColoredString("You start a fire with the " + secondItem.Name + ".", Color.OrangeRed, Color.Black));
                                                    }
                                                }

                                                player.TryGrantExp(rec.SkillUsed, rec.ExpGranted, Log, RecentlyTrainedSkills);

                                                dropped = true;
                                            }
                                            UsingSlot = -1; 
                                        }
                                        else {
                                            Log.AddMessage(new ColoredString("Those two items don't combine like that.", Color.Crimson, Color.Black));
                                            UsingSlot = -1;
                                        }
                                    }
                                });
                            } else { 
                                mini.Con.Print(50, 15 + i, "  ");
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
                    if (player.Equipment.ContainsKey("Weapon")) {
                        string name = player.Equipment["Weapon"].Name + (player.Equipment["Weapon"].Quantity > 1 ? " x" + player.Equipment["Weapon"].Quantity : "");
                        mini.Con.PrintClickable(13, printY, new ColoredString(name, player.Equipment["Weapon"].GetColor(), player.Equipment["Weapon"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Weapon"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Weapon");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "| Off-hand: ");
                    if (player.Equipment.ContainsKey("Offhand")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Offhand"].Name, player.Equipment["Offhand"].GetColor(), player.Equipment["Offhand"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Offhand"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Offhand");
                        });
                    }
                     
                    printY++;

                    mini.Con.Print(1, printY, "|     Head: "); 
                    if (player.Equipment.ContainsKey("Head")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Head"].Name, player.Equipment["Head"].GetColor(), player.Equipment["Head"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Head"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Head");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Body: "); 
                    if (player.Equipment.ContainsKey("Body")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Body"].Name, player.Equipment["Body"].GetColor(), player.Equipment["Body"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Body"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Body");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Legs: "); 
                    if (player.Equipment.ContainsKey("Legs")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Legs"].Name, player.Equipment["Legs"].GetColor(), player.Equipment["Legs"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Legs"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Legs");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|    Hands: ");
                    if (player.Equipment.ContainsKey("Hands")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Hands"].Name, player.Equipment["Hands"].GetColor(), player.Equipment["Hands"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Hands"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Hands");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Feet: ");
                    if (player.Equipment.ContainsKey("Feet")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Feet"].Name, player.Equipment["Feet"].GetColor(), player.Equipment["Feet"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Feet"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Feet");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Cape: ");
                    if (player.Equipment.ContainsKey("Cape")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Cape"].Name, player.Equipment["Cape"].GetColor(), player.Equipment["Cape"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Cape"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Cape");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Ring: ");
                    if (player.Equipment.ContainsKey("Ring")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Ring"].Name, player.Equipment["Ring"].GetColor(), player.Equipment["Ring"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Ring"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Ring");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|   Amulet: ");
                    if (player.Equipment.ContainsKey("Amulet")) {
                        mini.Con.PrintClickable(13, printY, new ColoredString(player.Equipment["Amulet"].Name, player.Equipment["Amulet"].GetColor(), player.Equipment["Amulet"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Amulet"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Amulet");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|   Pocket: ");
                    if (player.Equipment.ContainsKey("Pocket")) {
                        string name = player.Equipment["Pocket"].Name + (player.Equipment["Pocket"].Quantity > 1 ? " x" + player.Equipment["Pocket"].Quantity : "");
                        mini.Con.PrintClickable(13, printY, new ColoredString(name, player.Equipment["Pocket"].GetColor(), player.Equipment["Pocket"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Pocket"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Pocket");
                        });
                    }

                    printY++;

                    mini.Con.Print(1, printY, "|     Ammo: ");
                    if (player.Equipment.ContainsKey("Ammo")) {
                        string name = player.Equipment["Ammo"].Name + (player.Equipment["Ammo"].Quantity > 1 ? " x" + player.Equipment["Ammo"].Quantity : "");
                        mini.Con.PrintClickable(13, printY, new ColoredString(name, player.Equipment["Ammo"].GetColor(), player.Equipment["Ammo"].ColorSum() < 60 ? Color.White : Color.Black), () => {
                            Item item = player.Equipment["Ammo"];
                            player.TryPickup(item, item.Quantity);
                            player.Equipment.Remove("Ammo");
                        });
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

                    for (int i = SidebarScrollTop; i < playerSkills.Count; i++) {
                        bool mouseHovering = mousePos.X < 54 && mousePos.Y == printY;

                        mini.Con.Print(1, printY, playerSkills[i].Name, mouseHovering ? Color.Yellow : Color.White);
                        mini.Con.Print(20, printY, playerSkills[i].Level.ToString().PadLeft(3), mouseHovering ? Color.Yellow : Color.White);

                        if (player.PayToWin == 0) { 
                            mini.Con.Print(31, printY, playerSkills[i].ExpToLevel().ToString().PadLeft(8), mouseHovering ? Color.Yellow : Color.White);
                        } else {
                            int actualExpNeeded = (int)Math.Ceiling((double) playerSkills[i].EXPNeeded() / (double) player.ExpMultiplier);
                            Color couldBuy = Color.Lime;
                            if (player.HeldGold < player.PayToWin * actualExpNeeded) { couldBuy = Color.Crimson; }

                            mini.Con.PrintClickable(31, printY, new ColoredString(playerSkills[i].EXPNeeded().ToString().PadLeft(8), mouseHovering ? couldBuy : Color.White, Color.Black), () => {
                                player.TryGrantExp(playerSkills[i].Name, actualExpNeeded, Log, RecentlyTrainedSkills, true);
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

                    List<Prayer> prayers = player.Prayers.Values.ToList();
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
                    mini.Con.PrintClickable(1, printY++, "Nod Head", () => { Log.AddMessage("You nod your head."); ClueLogic.GenericStep(player, Log, "Emote", "Nod"); });
                    mini.Con.PrintClickable(1, printY++, "Shake Head", () => { Log.AddMessage("You shake your head."); ClueLogic.GenericStep(player, Log, "Emote", "Shake"); });
                    mini.Con.PrintClickable(1, printY++, "Think", () => { Log.AddMessage("You ponder for a moment."); ClueLogic.GenericStep(player, Log, "Emote", "Think"); });
                    mini.Con.PrintClickable(1, printY++, "Beckon", () => { Log.AddMessage("You beckon to nobody in particular."); ClueLogic.GenericStep(player, Log, "Emote", "Beckon"); });
                    mini.Con.PrintClickable(1, printY++, "Dance", () => { Log.AddMessage("You shake your body in a dance."); ClueLogic.GenericStep(player, Log, "Emote", "Dance"); });
                    mini.Con.PrintClickable(1, printY++, "Cry", () => { Log.AddMessage("You break down and cry for a moment."); ClueLogic.GenericStep(player, Log, "Emote", "Cry"); }); 
                    mini.Con.PrintClickable(1, printY++, "Clap", () => { Log.AddMessage("You clap your hands."); ClueLogic.GenericStep(player, Log, "Emote", "Clap"); });
                    mini.Con.PrintClickable(1, printY++, "Wave", () => { Log.AddMessage("You wave your arm vigorously."); ClueLogic.GenericStep(player, Log, "Emote", "Wave"); });

                    printY = 17;
                    mini.Con.PrintClickable(20, printY++, "Laugh", () => { Log.AddMessage("You throw your head back and laugh heartily."); ClueLogic.GenericStep(player, Log, "Emote", "Laugh"); });
                    mini.Con.PrintClickable(20, printY++, "Jig", () => { Log.AddMessage("You dance a little jig."); ClueLogic.GenericStep(player, Log, "Emote", "Jig"); });
                    mini.Con.PrintClickable(20, printY++, "Blow Kiss", () => { Log.AddMessage("You blow a kiss."); ClueLogic.GenericStep(player, Log, "Emote", "BlowKiss"); }); 
                    mini.Con.PrintClickable(20, printY++, "Salute", () => { Log.AddMessage("You put your hand to your head in a crisp salute."); ClueLogic.GenericStep(player, Log, "Emote", "Salute"); });
                    mini.Con.PrintClickable(20, printY++, "Bow", () => { Log.AddMessage("You take a bow."); ClueLogic.GenericStep(player, Log, "Emote", "Bow"); });
                    mini.Con.PrintClickable(20, printY++, "Shrug", () => { Log.AddMessage("You shrug your shoulders."); ClueLogic.GenericStep(player, Log, "Emote", "Shrug"); });
                    mini.Con.PrintClickable(20, printY++, "Jump for Joy", () => { Log.AddMessage("You jump for joy."); ClueLogic.GenericStep(player, Log, "Emote", "JumpForJoy"); });
                    mini.Con.PrintClickable(20, printY++, "Spin", () => { Log.AddMessage("You twirl around quickly with your arms stretched out."); ClueLogic.GenericStep(player, Log, "Emote", "Spin"); });

                    printY = 17;
                    mini.Con.PrintClickable(40, printY++, "Panic", () => { Log.AddMessage("You panic for a moment."); ClueLogic.GenericStep(player, Log, "Emote", "Panic"); });
                    mini.Con.PrintClickable(40, printY++, "Shake Fist", () => { Log.AddMessage("You shake your fist in anger."); ClueLogic.GenericStep(player, Log, "Emote", "ShakeFist"); });
                    mini.Con.PrintClickable(40, printY++, "Cheer", () => { Log.AddMessage("You cheer. Hurray!"); ClueLogic.GenericStep(player, Log, "Emote", "Cheer"); });
                    mini.Con.PrintClickable(40, printY++, "Yawn", () => { Log.AddMessage("You let out a yawn."); ClueLogic.GenericStep(player, Log, "Emote", "Yawn"); });
                    mini.Con.PrintClickable(40, printY++, "Headbang", () => { Log.AddMessage("You bang your head to music only you can hear."); ClueLogic.GenericStep(player, Log, "Emote", "Headbang"); });
                    mini.Con.PrintClickable(40, printY++, "Raspberry", () => { Log.AddMessage("You blow a raspberry."); ClueLogic.GenericStep(player, Log, "Emote", "Raspberry"); });
                    mini.Con.PrintClickable(40, printY++, "Sit Down", () => { Log.AddMessage("You sit down for a bit. This was nice."); ClueLogic.GenericStep(player, Log, "Emote", "SitDown"); });
                } else if (SidebarMenu == "Quest") {
                    mini.Con.Print(1, 15, "Quest Name");
                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    int printQuest = 0;
                    int count = -1;

                    int questPoints = 0;
                    int totalPossibleQP = 0;

                    List<Quest> sortedList = player.QuestLog.Values.ToList();

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
                        if (kv.CurrentStage == kv.CompleteStage)
                            questPoints += kv.QuestPoints;


                        count++;
                        if (count < SidebarScrollTop) {
                            continue;
                        } 

                        Color col = Color.DarkSlateGray;

                        if (kv.CanStartQuest(player)) {
                            col = Color.Crimson;
                        }

                        if (kv.CurrentStage != -1) {
                            col = Color.Yellow;
                        }

                        if (kv.CurrentStage == kv.CompleteStage) {
                            col = Color.Lime;
                        }

                        mini.Con.PrintClickable(0, 17 + printQuest, new ColoredString(kv.Name, col, Color.Black), () => {
                            Quests.IsVisible = true;
                            ViewingQuestID = kv.ID;
                             
                            if (kv.CurrentStage == -1) {
                                QuestOverview = true;
                            } else {
                                QuestOverview = false;
                                QuestBlockScrollTop = 0;
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
                    
                    mini.Con.PrintClickable(37, 15, new ColoredString("Combat", MagicTab == "Combat" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { MagicTab = "Combat"; });
                    mini.Con.PrintClickable(44, 15, new ColoredString("Tele", MagicTab == "Tele" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { MagicTab = "Tele"; });
                    mini.Con.PrintClickable(49, 15, new ColoredString("Skill", MagicTab == "Skill" ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { MagicTab = "Skill"; });

                    mini.Con.DrawLine(new Point(0, 16), new Point(54, 16), 196);

                    List<Spell> spells = new();

                    foreach (var kv in player.Spells) {
                        if (kv.Value.Book == player.MagicBook && kv.Value.Category == MagicTab) {
                            spells.Add(kv.Value);
                        }
                    }

                    for (int i = 0; i < spells.Count; i++) {
                        string cast = player.CanCast(spells[i]);

                        mini.Con.PrintClickable(6, 17 + i, new ColoredString(spells[i].Name, player.CastingSpell == spells[i].ID ? Color.Lime : cast.Contains("runes") ? Color.Crimson : cast.Contains("Magic") ? Color.DarkSlateGray : cast.Contains("cooldown") ? Color.Yellow : Color.White, Color.Black), () => { 
                            if (cast == "") {
                                if (MagicTab == "Combat") {
                                    player.CastingSpell = spells[i].ID;
                                }

                                if (MagicTab == "Tele") {
                                    if (curr.Region == "Tutorial Island" && !WarnedTutorialTele) {
                                        WarnedTutorialTele = true;
                                        TimeWarned = Helper.Time();
                                        Log.AddMessage("Are you sure you want to teleport away from Tutorial Island? You cannot return later.", Color.Crimson);
                                    } else {
                                        if (Atlas.TryGetValue(spells[i].MiscString, out Location? dest)) {
                                            player.ConsumeItems(spells[i].Runes);
                                            player.NavLoc = spells[i].MiscString; // TODO: Check to make sure the player is allowed in that region
                                            spells[i].TimeLastCast = Helper.Time();
                                        } else {
                                            Log.AddMessage("Teleport destination does not exist.", Color.Crimson);
                                        } 
                                    }
                                }
                            } else {
                                Log.AddMessage(new ColoredString("Cannot cast spell: " + cast, Color.Crimson, Color.Black));
                            }
                        });

                        mini.Con.Print(1, 17+i, spells[i].Level.ToString().Align(HorizontalAlignment.Right, 2));
                        mini.Con.PrintClickable(4, 17+i, new ColoredString("?", Color.MediumPurple, Color.Black), () => { Log.AddMessage(spells[i].Description); });
                    }
                } else if (SidebarMenu == "Log") {
                    mini.Con.Print(1, 15, "Clue Collection Logs"); 

                    int tutGot = 0;
                    int tutMax = 0;


                    if (player.CollectionLogClues.ContainsKey("casketTutorial")) {
                        tutGot = player.CollectionLogClues["casketTutorial"].DropsObtained.Count;

                        if (ItemLibrary.TryGetValue("casketTutorial", out Item? caskTut)) {
                            if (caskTut != null) { 
                                tutMax = caskTut.DropTable.Count;
                            }
                        }
                    } 

                    mini.Con.PrintClickable(1, 16, new ColoredString("| Tutorial: " + tutGot.ToString().Align(HorizontalAlignment.Right, 3) + " / " + tutMax.ToString().Align(HorizontalAlignment.Right, 3), tutGot == tutMax ? Color.Lime : Color.White, Color.Black), () => { CollectionID = "casketTutorial"; CollectionLog.IsVisible = true; CollectionDropTop = 0;});

                    mini.Con.Print(1, 17, "| Beginner: ");
                    mini.Con.Print(1, 18, "|     Easy: ");
                    mini.Con.Print(1, 19, "|   Medium: ");
                    mini.Con.Print(1, 20, "|     Hard: ");
                    mini.Con.Print(1, 21, "|    Elite: ");
                    mini.Con.Print(1, 22, "|   Master: ");
                }
            }
        }

        public void LocationDraw(UI_EmbeddedMini mini) { 
            Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;

            if (Atlas.ContainsKey(player.NavLoc)) {
                Location curr = Atlas[player.NavLoc];
                 
                mini.Con.Print(57, 0, curr.DisplayName.Align(HorizontalAlignment.Center, 91));
                mini.Con.DrawLine(new Point(56, 1), new Point(148, 1), 196); 

                int descY = mini.Con.PrintMultiLine(57, 3, curr.Description, 92);

                int printY = descY;

                printY += 2;

                mini.Con.DrawLine(new Point(56, printY), new Point(148, printY++), 196);

                mini.Con.Print(57, printY, "Other Players Here: ");
                mini.Con.Print(77, printY++, "(none)", Color.DarkSlateGray);

                mini.Con.DrawLine(new Point(56, printY), new Point(148, printY++), 196);

                int resourceY = printY;
                 
                if (curr.ConnectedLocations.Count > 0) {
                    mini.Con.Print(57, printY++, "Connected Locations: ");

                    for (int i = 0; i < curr.ConnectedLocations.Count; i++) {
                        if (Atlas.ContainsKey(curr.ConnectedLocations[i].Destination)) {
                            Location dest = Atlas[curr.ConnectedLocations[i].Destination];
                            mini.Con.PrintClickable(57, printY++, "| " + dest.DisplayName, () => {
                                player.NavLoc = dest.ID;
                                GraceTimeStart = Helper.Time();
                                AttackingMonster = null;

                                if (curr.MonstersHere.Count > 0) {
                                    for (int j = 0; j < curr.MonstersHere.Count; j++) {
                                        curr.MonstersHere[j].AttackingPlayer = false;
                                    }
                                }
                            });
                        }
                        else {
                            mini.Con.Print(57, printY++, "| " + curr.ConnectedLocations[i].Destination, Color.DarkSlateGray);
                        }
                    }

                } 

                if (curr.MonstersHere.Count > 0) {
                    mini.Con.DrawLine(new Point(56, printY), new Point(109, printY++), 196);

                    mini.Con.Print(57, printY, "Monsters Here: ");
                    mini.Con.PrintClickable(72, printY, new ColoredString("(SINGLE)", Targetting == "Single" ? Color.Yellow : Color.White, Color.Black), () => { Targetting = "Single"; });
                    mini.Con.PrintClickable(81, printY, new ColoredString("(ORDER)", Targetting == "Order" ? Color.Yellow : Color.White, Color.Black), () => { Targetting = "Order"; });
                    mini.Con.PrintClickable(89, printY++, new ColoredString("(RANDOM)", Targetting == "Random" ? Color.Yellow : Color.White, Color.Black), () => { Targetting = "Random"; });

                    if (GraceTimeStart + 5000 > Helper.Time()) {
                        mini.Con.Print(98, printY - 1, "Grace: " + Math.Floor(GraceTimeStart + 5000 - Helper.Time()), Color.DarkSlateGray);
                    }

                    if (AttackingMonster != null && AttackingMonster.CurrentHP <= 0) {
                        if (Targetting == "Order") {
                            for (int j = 0; j < curr.MonstersHere.Count; j++) {
                                if (curr.MonstersHere[j].CurrentHP > 0) {
                                    AttackingMonster = curr.MonstersHere[j];
                                    break;
                                }
                            }
                        }
                        else if (Targetting == "Random") { 
                            while (AttackingMonster.CurrentHP <= 0) {
                                AttackingMonster = curr.MonstersHere[GameLoop.rand.Next(curr.MonstersHere.Count)];
                            }
                        }
                    } 

                    for (int i = 0; i < curr.MonstersHere.Count; i++) {
                        AreaMonster thisOne = curr.MonstersHere[i];

                        bool reachedKillLimit = player.KillLimit == 0 ? true : false;
                        if (player.CollectionLog.ContainsKey(thisOne.ID)) {
                            reachedKillLimit = player.KillLimit != -1 && player.CollectionLog[thisOne.ID].KillCount >= player.KillLimit; 
                        }

                        Color nameCol = Color.White;

                        if (thisOne.AggroLevel > player.GetCombatLevel() || thisOne.AlwaysAggro || thisOne.AttackingPlayer)
                            nameCol = Color.Crimson;

                        if (thisOne == AttackingMonster)
                            nameCol = Color.Yellow;

                        if (thisOne.CurrentHP <= 0)
                            nameCol = nameCol.GetDarker();

                        if (GraceTimeStart + 5000 < Helper.Time() && thisOne.TimeLastAttacked + 1000 < Helper.Time() && thisOne.CurrentHP > 0) {
                            if (thisOne.AggroLevel > player.GetCombatLevel() || thisOne.AlwaysAggro || thisOne.AttackingPlayer) {
                                thisOne.TimeLastAttacked = Helper.Time();

                                int dmg = GoRogue.DiceNotation.Dice.Roll(thisOne.DamageDice);
                                int modified = dmg;

                                int hitChance = GameLoop.rand.Next(100);

                                bool safespotting = false;

                                if (player.Equipment.ContainsKey("Weapon")) {
                                    if (player.Equipment["Weapon"].EquipSkill == "Ranged" || player.Equipment["Weapon"].EquipSkill == "Magic") {
                                        if (thisOne.DamageType == "Melee") {
                                            safespotting = true;
                                        }
                                    }
                                }

                                if (player.IsMaging()) {
                                    safespotting = true;
                                }

                                if (!safespotting) {
                                    if (hitChance < 25 + (player.GetEffectiveSkillLevel("Defense") / 4.0)) {
                                        Log.AddMessage(new ColoredString(thisOne.Name + " tried to hit you but missed!", Color.Yellow, Color.Black));
                                    } else {
                                        modified -= player.TotalArmorValue(thisOne.DamageType);

                                        if ((player.PrayerActive("Protect from Magic") && thisOne.DamageType == "Magic") || (player.PrayerActive("Protect from Melee") && thisOne.DamageType == "Melee") || (player.PrayerActive("Protect from Range") && thisOne.DamageType == "Ranged")) {
                                            modified /= 2;
                                        }
                                         
                                        if (dmg != modified) {
                                            if (modified <= 0) {
                                                Log.AddMessage(new ColoredString(thisOne.Name + " hit you for " + dmg + ", but you took no damage!", Color.Crimson, Color.Black));
                                            } else {
                                                Log.AddMessage(new ColoredString(thisOne.Name + " hit you for " + dmg + ", reduced to " + modified + "!", Color.Crimson, Color.Black));
                                            }
                                        } else {
                                            Log.AddMessage(new ColoredString(thisOne.Name + " hit you for " + dmg + "!", Color.Crimson, Color.Black));
                                        }

                                        bool died = player.TakeDamage(modified, Log);

                                        if (player.DefenseExpSplit > 0 && !reachedKillLimit)
                                            player.TryGrantExp("Defense", dmg * player.DefenseExpSplit, Log, RecentlyTrainedSkills);

                                        if (player.DefenseExpSplit < 4 && !reachedKillLimit)
                                            player.TryGrantExp("Constitution", dmg * (4 - player.DefenseExpSplit), Log, RecentlyTrainedSkills);

                                        if (died)
                                            break;
                                    }
                                }
                            }
                        }

                        double attackSpeed = 1.0;

                        if (player.Equipment.TryGetValue("Weapon", out Item? wep)) {
                            if (wep != null)
                                attackSpeed = wep.AttackSpeed;
                        }

                        if (player.Equipment.TryGetValue("Ammo", out Item? ammo)) {

                        }

                        bool hasAmmo = true;
                        bool usedAmmo = false;

                        if (AttackingMonster != null && LastHitTime + (1000 * attackSpeed) < Helper.Time() && AttackingMonster.CurrentHP > 0) {
                            LastHitTime = Helper.Time();
                            AttackingMonster.AttackingPlayer = true;

                            reachedKillLimit = player.KillLimit == 0 ? true : false;
                            if (player.CollectionLog.ContainsKey(AttackingMonster.ID)) {
                                reachedKillLimit = player.KillLimit != -1 && player.CollectionLog[AttackingMonster.ID].KillCount >= player.KillLimit;
                            }

                            int hitChance = GameLoop.rand.Next(100); 
                             
                            // Remove a unit of ammo if this is a ranged weapon
                            if (wep != null) {
                                if (wep.EquipAmmo == "Self") {
                                    wep.Quantity -= 1;
                                    Item droppedAmmo = Helper.Clone(wep);
                                    droppedAmmo.Quantity = 1;
                                    if (GameLoop.rand.Next(4) != 0)
                                        TryPlaceItem(player.NavLoc, droppedAmmo);
                                    usedAmmo = true;
                                } else if (wep.EquipAmmo == "Arrow") {
                                    if (ammo != null && ammo.EquipDamageType == "Arrow") {
                                        ammo.Quantity -= 1;
                                        Item droppedAmmo = Helper.Clone(ammo);
                                        droppedAmmo.Quantity = 1;
                                        if (GameLoop.rand.Next(4) != 0)
                                            TryPlaceItem(player.NavLoc, droppedAmmo);
                                        usedAmmo = true;
                                    } else {
                                        hasAmmo = false;
                                    }
                                } else if (wep.EquipAmmo == "Bolt") {
                                    if (ammo != null && ammo.EquipDamageType == "Bolt") {
                                        ammo.Quantity -= 1;
                                        Item droppedAmmo = Helper.Clone(ammo);
                                        droppedAmmo.Quantity = 1;
                                        if (GameLoop.rand.Next(4) != 0)
                                            TryPlaceItem(player.NavLoc, droppedAmmo);
                                        usedAmmo = true;
                                    } else {
                                        hasAmmo = false;
                                    }
                                }
                            } 

                            if (hasAmmo) {
                                string whichSkill = player.IsMaging() ? "Magic" : usedAmmo ? "Ranged" : "Attack";

                                if (player.IsMaging()) {
                                    player.ConsumeItems(player.Spells[player.CastingSpell].Runes, false, true);
                                    
                                    int spellExp = player.Spells[player.CastingSpell].ExpOnCast;
                                    player.TryGrantExp("Magic", spellExp, Log, RecentlyTrainedSkills);
                                }

                                if (hitChance > 25 + (player.GetEffectiveSkillLevel(whichSkill) / 2.0)) {
                                    Log.AddMessage(new ColoredString("You tried to hit the " + AttackingMonster.Name + " but missed!", Color.Crimson, Color.Black));
                                } else {
                                    int pdmg = GoRogue.DiceNotation.Dice.Roll(player.GetDamageDice());
                                    bool crit = false;

                                    if (player.GetDamageType() == AttackingMonster.WeakType) {
                                        if (player.GetDamageType() == "Undead") {
                                            pdmg = (int)Math.Ceiling(pdmg * 3f);
                                        } else {
                                            pdmg = (int)Math.Ceiling(pdmg * 1.5f);
                                        }
                                    }

                                    int critTarget = 20;

                                    if (player.PrayerActive("Improved Critical I"))
                                        critTarget -= 1;
                                    if (player.PrayerActive("Improved Critical II"))
                                        critTarget -= 2;
                                    if (player.PrayerActive("Improved Critical III"))
                                        critTarget -= 3;

                                    int critRoll = GameLoop.rand.Next(20) + 1;

                                    if (critRoll >= critTarget) {
                                        crit = true;
                                        pdmg *= 2;
                                    }



                                    if (pdmg > AttackingMonster.CurrentHP)
                                        pdmg = AttackingMonster.CurrentHP;

                                    AttackingMonster.CurrentHP -= pdmg;
                                     
                                    Log.AddMessage(new ColoredString("You hit the " + AttackingMonster.Name + " for " + pdmg + "." + (crit ? " Critical Hit!" : ""), crit ? Color.Lime : Color.Green, Color.Black));

                                    if (player.IsMaging()) {  
                                        player.TryGrantExp("Magic", (pdmg * 4), Log, RecentlyTrainedSkills);

                                        string cast = player.CanCast(player.Spells[player.CastingSpell]);
                                        if (cast != "") { 
                                            Log.AddMessage(new ColoredString("Cannot cast spell anymore: " + cast, Color.Crimson, Color.Black)); 
                                            player.CastingSpell = "";
                                        }
                                    } else if (usedAmmo) { 
                                        player.TryGrantExp("Ranged", pdmg * 4, Log, RecentlyTrainedSkills);
                                    } else {
                                        if (player.OffenseExpSplit > 0 && !reachedKillLimit)
                                            player.TryGrantExp("Attack", pdmg * player.OffenseExpSplit, Log, RecentlyTrainedSkills);

                                        if (player.OffenseExpSplit < 4 && !reachedKillLimit)
                                            player.TryGrantExp("Strength", pdmg * (4 - player.OffenseExpSplit), Log, RecentlyTrainedSkills);
                                    }

                                    if (AttackingMonster.CurrentHP <= 0) {
                                        AttackingMonster.TimeLastKilled = Helper.Time();
                                        AttackingMonster.AttackingPlayer = false;

                                        if (!player.CollectionLog.ContainsKey(AttackingMonster.ID))
                                            player.CollectionLog.Add(AttackingMonster.ID, new(AttackingMonster.ID));

                                        player.CollectionLog[AttackingMonster.ID].KillCount += 1;

                                        if (player.KillLimit != -1 && player.CollectionLog[AttackingMonster.ID].KillCount == player.KillLimit) {
                                            Log.AddMessage(new ColoredString("You've killed " + player.KillLimit + " " + AttackingMonster.Name + "s and will no longer receive drops or exp from them."));
                                        }

                                        if (AttackingMonster.DropTable != null && AttackingMonster.DropTable.Count > 0) {
                                            for (int j = 0; j < AttackingMonster.DropTable.Count; j++) {
                                                ItemDrop drop = AttackingMonster.DropTable[j];

                                                if (drop.EvenAt0x || !reachedKillLimit) {
                                                    int dropX = drop.DropX;

                                                    dropX *= player.DropMultiplier;

                                                    if (reachedKillLimit)
                                                        dropX = 0;

                                                    if (drop.EvenAt0x && dropX == 0)
                                                        dropX = drop.DropX;

                                                    int dropRoll = GameLoop.rand.Next(drop.InY);
                                                    int dropRoll2 = GameLoop.rand.Next(drop.InY);

                                                    if (dropRoll < dropX || (player.PrayerActive("Good Fortune") && dropRoll2 < dropX)) {
                                                        if (!player.CollectionLog[AttackingMonster.ID].DropsObtained.ContainsKey(drop.ItemID))
                                                            player.CollectionLog[AttackingMonster.ID].DropsObtained.Add(drop.ItemID, 0);
                                                        player.CollectionLog[AttackingMonster.ID].DropsObtained[drop.ItemID] += 1;

                                                        if (ItemLibrary.ContainsKey(drop.ItemID)) {
                                                            Item spawn = Helper.Clone(ItemLibrary[drop.ItemID]);

                                                            if (drop.QuantityMin == drop.QuantityMax)
                                                                spawn.Quantity = drop.QuantityMin;
                                                            else {
                                                                int amt = GameLoop.rand.Next(drop.QuantityMax - drop.QuantityMin) + drop.QuantityMin;
                                                                spawn.Quantity = amt;
                                                            }

                                                            curr.ItemsHere.Add(spawn);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            } else { 
                                Log.AddMessage(new ColoredString("You haven't got any valid ammo for your weapon!", Color.Crimson, Color.Black));
                            }
                        }

                        if (thisOne.CurrentHP <= 0 && thisOne.TimeLastKilled + (thisOne.RespawnTime * 1000) < Helper.Time()) {
                            thisOne.CurrentHP = thisOne.MaxHP; 
                            thisOne.TimeLastAttacked = Helper.Time();
                            thisOne.AttackingPlayer = false;
                        } 
                        mini.Con.Print(57, printY, "|");
                        mini.Con.PrintClickable(59, printY, new ColoredString(curr.MonstersHere[i].Name, nameCol, Color.Black), () => { AttackingMonster = thisOne; });


                        mini.Con.Print(80, printY, "(" + thisOne.CurrentHP + "/" + thisOne.MaxHP + " hp)");

                        mini.Con.PrintClickable(106, printY++, "Log", () => {
                            CollectionLog.IsVisible = true;
                            CollectionID = thisOne.ID;
                            CollectionDropTop = 0;
                        });

                        if (usedAmmo) {
                            List<string> empties = new();
                            foreach (var kv in player.Equipment) {
                                if (kv.Value.Quantity <= 0) {
                                    empties.Add(kv.Key);
                                }
                            }

                            foreach (var rem in empties) {
                                player.Equipment.Remove(rem);
                            }
                        }
                    }
                } 

                int resourceX = 110;

                mini.Con.DrawLine(new Point(resourceX, resourceY), new Point(resourceX, 34), 179);

                if (curr.IsBank && player.CanUseBanks)
                    mini.Con.PrintClickable(resourceX + 2, resourceY, new ColoredString("B", SelectedMenu == "Items" ? Color.Yellow : player.BankedItems.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Items"; });
                else
                    mini.Con.PrintClickable(resourceX + 2, resourceY, new ColoredString("I", SelectedMenu == "Items" ? Color.Yellow : curr.ItemsHere.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Items"; });
                
                
                mini.Con.Print(resourceX + 4, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 6, resourceY, new ColoredString("N", SelectedMenu == "NPCs" ? Color.Yellow : curr.NPCsHere.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "NPCs"; });
                mini.Con.Print(resourceX + 8, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 10, resourceY, new ColoredString("P", SelectedMenu == "Processing" ? Color.Yellow : curr.ProcessingStations.Count > 0 || curr.TempStations.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Processing"; });
                mini.Con.Print(resourceX + 12, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 14, resourceY, new ColoredString("R", SelectedMenu == "Resources" ? Color.Yellow : curr.LocalGathers.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Resources"; });
                mini.Con.Print(resourceX + 16, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 18, resourceY, new ColoredString("C", SelectedMenu == "Chat" ? Color.Yellow : ConversationPartner != null ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Chat"; });
                mini.Con.Print(resourceX + 20, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 22, resourceY, new ColoredString("S", SelectedMenu == "Shop" ? Color.Yellow : curr.ShopItemsHere.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Shop"; });
                mini.Con.Print(resourceX + 24, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 26, resourceY, new ColoredString("F", SelectedMenu == "Farming" ? Color.Yellow : curr.FarmingPatchesHere.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Farming"; });


                resourceY++;
                mini.Con.DrawLine(new Point(resourceX + 1, resourceY), new Point(148, resourceY), 196);
                resourceY++;

                if (SelectedMenu == "Resources") {
                    mini.Con.Print(resourceX + 2, resourceY++, "Resource Nodes Here");

                    if (curr.LocalGathers.Count > 0) {
                        for (int i = 0; i < curr.LocalGathers.Count; i++) {
                            GatheringTile tile = curr.LocalGathers[i];
                            mini.Con.Print(resourceX + 2, resourceY, "|");

                            Color interact = Color.White;

                            if (tile.LastGathered + (tile.RestockTime * 1000) < Helper.Time() || tile.LastGathered == 0) {
                                if (tile.CanGather(player) == "") {
                                    interact = Color.Green;
                                }
                                else {
                                    interact = Color.Crimson;
                                }

                                mini.Con.PrintClickable(resourceX + 4, resourceY++, new ColoredString(tile.InteractVerb + " " + tile.Name, interact, Color.Black), () => { tile.Gather(player, Log, ItemLibrary, curr, RecentlyTrainedSkills); });
                            }
                            else {
                                int secondsToRestock = (int)Math.Floor((tile.LastGathered + (tile.RestockTime * 1000) - Helper.Time()) / 1000f);
                                mini.Con.Print(resourceX + 4, resourceY++, tile.InteractVerb + " " + tile.Name + " [" + secondsToRestock + "]");
                            }
                        }
                    }
                    else {
                        mini.Con.Print(resourceX + 2, resourceY, "|");
                        mini.Con.Print(resourceX + 4, resourceY++, "(no resources here)", Color.DarkSlateGray);
                    }
                }
                else if (SelectedMenu == "Items") { 
                    if (curr.IsBank && player.CanUseBanks) {
                        mini.Con.Print(resourceX + 2, resourceY, "Items in Bank"); 

                        mini.Con.PrintClickable(resourceX + 23, resourceY, "(sort)", () => { player.BankedItems = player.BankedItems.OrderBy(o => o.Name).ToList(); });
                         
                        mini.Con.PrintClickable(resourceX + 30, resourceY++, new ColoredString("(noted)", WithdrawingNotes ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { WithdrawingNotes = !WithdrawingNotes; }); 

                        ActivityItemTop = Math.Clamp(ActivityItemTop, 0, player.BankedItems.Count);

                        if (ActivityRect.Contains(mousePos)) {
                            if (Helper.ScrolledUp()) { ActivityItemTop = Math.Clamp(ActivityItemTop - 1, 0, player.BankedItems.Count); }
                            if (Helper.ScrolledDown()) { ActivityItemTop = Math.Clamp(ActivityItemTop + 1, 0, player.BankedItems.Count); }
                        }

                        if (player.BankedItems.Count > 0) {
                            for (int i = ActivityItemTop; i < player.BankedItems.Count && i < ActivityItemTop + 22; i++) { 
                                Item item = player.BankedItems[i];

                                string name = item.Name;
                                if (name.Length > 25)
                                    name = name[..25];

                                name += item.Quantity > 1 ? " x" + item.Quantity : "";

                                if (item.Noted) {
                                    name += " (n)";
                                }

                                bool picked = false;

                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.PrintClickable(resourceX + 4, resourceY, new ColoredString(name, item.GetColor(), item.ColorSum() < 50 ? Color.White : Color.Black), () => { 
                                    int qty = 1;

                                    if (Helper.EitherShift())
                                        qty *= 5;
                                    if (Helper.EitherControl())
                                        qty *= 10;

                                    if (qty >= item.Quantity)
                                        qty = item.Quantity;


                                    if (player.TryPickup(item, qty, item.Noteable ? WithdrawingNotes : false)) { 
                                        if (item.Quantity <= 0) {
                                            player.BankedItems.RemoveAt(i); 
                                            picked = true;
                                        }
                                    }
                                });
                                mini.Con.PrintClickable(147, resourceY, new ColoredString("X", Color.Crimson, Color.Black), () => { player.BankedItems.RemoveAt(i); picked = true; });

                                resourceY++;

                                if (picked)
                                    break;
                            }
                        }
                        else {
                            mini.Con.Print(resourceX + 2, resourceY, "|");
                            mini.Con.Print(resourceX + 4, resourceY++, "(no items banked)", Color.DarkSlateGray);
                        }
                    }
                    else {
                        mini.Con.Print(resourceX + 2, resourceY++, "Items on Ground Here"); 
                        ActivityItemTop = Math.Clamp(ActivityItemTop, 0, curr.ItemsHere.Count);

                        if (ActivityRect.Contains(mousePos)) {
                            if (Helper.ScrolledUp()) { ActivityItemTop = Math.Clamp(ActivityItemTop - 1, 0, curr.ItemsHere.Count); }
                            if (Helper.ScrolledDown()) { ActivityItemTop = Math.Clamp(ActivityItemTop + 1, 0, curr.ItemsHere.Count); }
                        }

                        if (curr.ItemsHere.Count > 0) {
                            for (int i = ActivityItemTop; i < curr.ItemsHere.Count && i < ActivityItemTop + 22; i++) { 
                                Item item = curr.ItemsHere[i];

                                string name = item.Name;
                                if (name.Length > 25)
                                    name = name[..25];

                                name = name + (item.Quantity > 1 ? " x" + item.Quantity : "");

                                if (item.Noted) {
                                    name += " (n)";
                                }

                                bool picked = false;

                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.PrintClickable(resourceX + 4, resourceY, new ColoredString(name, item.GetColor(), item.ColorSum() < 50 ? Color.White : Color.Black), () => { 
                                    int qty = 1;

                                    if (Helper.EitherShift())
                                        qty *= 5;
                                    if (Helper.EitherControl())
                                        qty *= 10;

                                    if (qty >= item.Quantity)
                                        qty = item.Quantity;


                                    if (player.TryPickup(item, qty, item.Noted)) { 
                                        if (item.Quantity <= 0) {
                                            curr.ItemsHere.RemoveAt(i); 
                                            picked = true;
                                        }
                                    } 
                                });
                                mini.Con.PrintClickable(147, resourceY, new ColoredString("X", Color.Crimson, Color.Black), () => { curr.ItemsHere.RemoveAt(i); picked = true; });

                                resourceY++;

                                if (picked)
                                    break;
                            }
                        }
                        else {
                            mini.Con.Print(resourceX + 2, resourceY, "|");
                            mini.Con.Print(resourceX + 4, resourceY++, "(no items here)", Color.DarkSlateGray);
                        }
                    }
                }
                else if (SelectedMenu == "Processing") {
                    mini.Con.Print(resourceX + 2, resourceY++, "Processing Stations Here");

                    if (curr.ProcessingStations.Count > 0 || curr.TempStations.Count > 0) {
                        for (int i = 0; i < curr.ProcessingStations.Count; i++) {
                            if (ProcessingStations.ContainsKey(curr.ProcessingStations[i])) {
                                ProcessingStation station = ProcessingStations[curr.ProcessingStations[i]];
                                mini.Con.Print(resourceX + 2, resourceY, "|");  

                                mini.Con.PrintClickable(resourceX + 4, resourceY, station.Name, () => { 
                                    station.TryProcessItem(player, Log, ItemLibrary, RecentlyTrainedSkills); 

                                    if (station.OpensUI) {
                                        CraftingMenu.IsVisible = true;
                                        CraftingType = station.Name;
                                    }
                                });

                                if (!station.OpensUI) {
                                    mini.Con.PrintClickable(resourceX + 2, resourceY, new ColoredString(236.AsString(), Color.MediumPurple, Color.Black), () => {
                                        while (station.TryProcessItem(player, Log, ItemLibrary, RecentlyTrainedSkills)) {

                                        }
                                    });
                                }

                                resourceY++;
                            }
                            else {
                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.Print(resourceX + 4, resourceY++, curr.ProcessingStations[i], Color.DarkSlateGray);
                            }
                        }

                        for (int i = curr.TempStations.Count - 1; i >= 0; i--) { 
                            ProcessingStation station = curr.TempStations[i];

                            int secondsSinceMade = (int) Math.Floor((station.TimeMade + (station.TimeLeft * 60000)) - Helper.Time()) / 1000;

                            mini.Con.Print(resourceX + 2, resourceY, "|");
                            mini.Con.PrintClickable(resourceX + 4, resourceY++, station.Name + " [" + secondsSinceMade + "]", () => { station.TryProcessItem(player, Log, ItemLibrary, RecentlyTrainedSkills); });

                            if (station.TimeLeft != -1) {
                                if (station.TimeMade + (station.TimeLeft * 60000) <= Helper.Time()) {
                                    if (ItemLibrary.ContainsKey(station.ItemOnExpire)) {
                                        curr.ItemsHere.Add(Helper.Clone(ItemLibrary[station.ItemOnExpire]));
                                    }

                                    curr.TempStations.RemoveAt(i); 
                                }
                            }
                        }
                    }
                    else {
                        mini.Con.Print(resourceX + 2, resourceY, "|");
                        mini.Con.Print(resourceX + 4, resourceY++, "(no stations here)", Color.DarkSlateGray);
                    }
                }
                else if (SelectedMenu == "NPCs") {
                    mini.Con.Print(resourceX + 2, resourceY++, "NPCs Here");

                    if (curr.NPCsHere.Count > 0) {
                        for (int i = 0; i < curr.NPCsHere.Count; i++) {
                            if (NPCLibrary.ContainsKey(curr.NPCsHere[i])) {
                                NPC thisOne = NPCLibrary[curr.NPCsHere[i]];

                                if (thisOne.ReqToSee != null && !thisOne.ReqToSee.CheckRequirement(player)) {
                                    continue;
                                }

                                mini.Con.PrintClickable(resourceX + 2, resourceY, "| " + thisOne.Name, () => {
                                    if (!ClueLogic.GenericStep(player, Log, "Speak", thisOne.ID) && !ClueLogic.GenericStep(player, Log, "Anagram", thisOne.ID)) {
                                        CurrDialogueStage = 0;
                                        ConversationPartner = thisOne;

                                        if (ConversationPartner.Dialogue.ContainsKey(CurrDialogueStage)) {
                                            Log.AddMessage(ConversationPartner.Name + ": " + ConversationPartner.Dialogue[CurrDialogueStage].Text);
                                        }

                                        SelectedMenu = "Chat";
                                    }
                                });

                                if (thisOne.PickpocketLevel > 0) {
                                    mini.Con.PrintClickable(146, resourceY++, "P", () => {
                                        thisOne.TryPickpocket(player, RecentlyTrainedSkills, ItemLibrary, Log);
                                    });
                                }
                                else {
                                    resourceY++;
                                }
                            }
                        }
                    }
                    else {
                        mini.Con.Print(resourceX + 2, resourceY, "|");
                        mini.Con.Print(resourceX + 4, resourceY++, "(no NPCs here)", Color.DarkSlateGray);
                    }
                }
                else if (SelectedMenu == "Chat") {
                    if (ConversationPartner != null) {
                        if (ConversationPartner.Dialogue.ContainsKey(CurrDialogueStage)) {
                            DialogueStage dia = ConversationPartner.Dialogue[CurrDialogueStage];

                            if (dia.Choices != null && dia.Choices.Count > 0) {
                                for (int i = 0; i < dia.Choices.Count; i++) {
                                    DialogueChoice choice = dia.Choices[i];

                                    if (!choice.CanClick() && !choice.ShowAnyways) {
                                        continue;
                                    }


                                    mini.Con.Print(resourceX + 2, resourceY, "|");
                                    mini.Con.PrintClickable(resourceX + 4, resourceY++, new ColoredString(choice.Text, choice.CanClick() ? Color.White : Color.Crimson, Color.Black), () => {
                                        if (choice.CanClick()) {
                                            CurrDialogueStage = choice.LeadsToStage;

                                            if (ConversationPartner.Dialogue.ContainsKey(CurrDialogueStage)) {
                                                Log.AddMessage(ConversationPartner.Name + ": " + ConversationPartner.Dialogue[CurrDialogueStage].Text);
                                            }

                                            if (choice.TeleportTo != "") {
                                                player.NavLoc = choice.TeleportTo;

                                                if (choice.SetSpawnToo) {
                                                    player.NavRespawn = choice.TeleportTo;
                                                }
                                            }

                                            if (ConversationPartner.Dialogue.ContainsKey(CurrDialogueStage)) {
                                                DialogueStage newDia = ConversationPartner.Dialogue[CurrDialogueStage];

                                                if (newDia.SetsQuest != "") {
                                                    if (player.QuestLog.TryGetValue(newDia.SetsQuest, out Quest? quest)) {
                                                        if (quest != null) {
                                                            if (quest.CurrentStage < newDia.SetsQuestStageTo) {
                                                                quest.CurrentStage = newDia.SetsQuestStageTo;
                                                            }

                                                            if (quest.CurrentStage == quest.CompleteStage) {
                                                                Log.AddMessage(new ColoredString("You have completed " + quest.Name + "!", Color.Lime, Color.Black));
                                                                quest.ProcessRewards(player);
                                                            }
                                                        }
                                                    }
                                                }

                                                if (newDia.ItemsGiven != null) {
                                                    for (int i = 0; i < newDia.ItemsGiven.Count; i++) {
                                                        if (newDia.ItemsGiven[i].Contains(",")) {
                                                            string[] split = newDia.ItemsGiven[i].Split(",");

                                                            if (ItemLibrary.TryGetValue(split[0], out Item? give)) {
                                                                if (give != null) {
                                                                    Item actualGive = Helper.Clone(give);

                                                                    if (int.TryParse(split[1], out int qty)) {
                                                                        actualGive.Quantity = qty;
                                                                    }

                                                                    player.TryPickup(Helper.Clone(actualGive), actualGive.Quantity);
                                                                }
                                                            }
                                                        } else {
                                                            if (ItemLibrary.TryGetValue(newDia.ItemsGiven[i], out Item? give)) {
                                                                if (give != null) {
                                                                    player.TryPickup(Helper.Clone(give), give.Quantity);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        } else {
                                            if (choice.ClickReq != null) {
                                                Log.AddMessage(new ColoredString("Requirement not met: " + choice.ClickReq.GetSummary(), Color.Crimson, Color.Black));
                                            }
                                        }
                                    });
                                }
                            }

                            if (CurrDialogueStage == -1) {
                                ConversationPartner = null;
                                SelectedMenu = "NPCs";
                            }
                        }
                        else {
                            mini.Con.Print(resourceX + 2, resourceY, "| (invalid dialogue stage)", Color.DarkSlateGray);
                        }
                    }
                    else {
                        mini.Con.Print(resourceX + 2, resourceY, "| (not speaking to anyone)", Color.DarkSlateGray);
                    }
                }
                else if (SelectedMenu == "Shop") {
                    mini.Con.Print(resourceX + 2, resourceY++, "Shop Items Here");

                    if (curr.ShopItemsHere.Count > 0) {
                        for (int i = 0; i < curr.ShopItemsHere.Count; i++) {
                            if (ItemLibrary.ContainsKey(curr.ShopItemsHere[i])) {
                                Item shop = Helper.Clone(ItemLibrary[curr.ShopItemsHere[i]]);

                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.Print(resourceX + 4, resourceY, new ColoredString(shop.Name, shop.GetColor(), shop.ColorSum() < 50 ? Color.White : Color.Black) + new ColoredString(" (" + shop.Value + "gp)"));

                                if (shop.Stackable) {
                                    mini.Con.PrintClickable(141, resourceY, "1", () => {
                                        if (player.CanUseShops) {
                                            if (player.HeldGold >= shop.Value) {
                                                player.HeldGold -= shop.Value;
                                                player.TryPickup(shop, 1);
                                                Log.AddMessage("You purchased a "  + shop.Name + " for " + shop.Value + " gp.", Color.Goldenrod);
                                            } else {
                                                Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                            }
                                        } else {
                                            Log.AddMessage(new ColoredString("You aren't allowed to use shops.", Color.Crimson, Color.Black));
                                        }
                                    });

                                    mini.Con.PrintClickable(143, resourceY, "10", () => {
                                        if (player.CanUseShops) {
                                            if (player.HeldGold >= shop.Value * 10) {
                                                player.HeldGold -= shop.Value * 10;
                                                shop.Quantity = 10;
                                                player.TryPickup(shop, 10);
                                                Log.AddMessage("You purchased 10x "  + shop.Name + " for " + shop.Value*10 + " gp.", Color.Goldenrod);
                                            } else {
                                                Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                            }
                                        } else {
                                            Log.AddMessage(new ColoredString("You aren't allowed to use shops.", Color.Crimson, Color.Black));
                                        }
                                    });

                                    mini.Con.PrintClickable(146, resourceY, "50", () => {
                                        if (player.CanUseShops) {
                                            if (player.HeldGold >= shop.Value * 50) {
                                                player.HeldGold -= shop.Value * 50;
                                                shop.Quantity = 50;
                                                player.TryPickup(shop, 50);
                                                Log.AddMessage("You purchased 50x "  + shop.Name + " for " + shop.Value*50 + " gp.", Color.Goldenrod);
                                            } else {
                                                Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                            }
                                        } else {
                                            Log.AddMessage(new ColoredString("You aren't allowed to use shops.", Color.Crimson, Color.Black));
                                        }
                                    });
                                }
                                else {
                                    mini.Con.PrintClickable(146, resourceY, "1", () => {
                                        if (player.CanUseShops) {
                                            if (player.HeldGold >= shop.Value) {
                                                player.HeldGold -= shop.Value;
                                                player.TryPickup(shop, 1);
                                                Log.AddMessage("You purchased a "  + shop.Name + " for " + shop.Value + " gp.", Color.Goldenrod);
                                            } else {
                                                Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                            }
                                        } else {
                                            Log.AddMessage(new ColoredString("You aren't allowed to use shops.", Color.Crimson, Color.Black));
                                        }
                                    });
                                }

                                resourceY++;
                            }
                            else {
                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.Print(resourceX + 4, resourceY++, curr.ShopItemsHere[i], Color.DarkSlateGray);
                            }
                        }
                    }
                    else {
                        mini.Con.Print(resourceX + 2, resourceY, "|");
                        mini.Con.Print(resourceX + 4, resourceY++, "(no shop items here)", Color.DarkSlateGray);
                    }
                }
                else if (SelectedMenu == "Farming") {
                    mini.Con.Print(resourceX + 2, resourceY++, "Farming Patches Here"); 
                    if (curr.FarmingPatchesHere.Count > 0) {
                        for (int i = 0; i < curr.FarmingPatchesHere.Count; i++) {
                            if (player.FarmingPatches.ContainsKey(curr.FarmingPatchesHere[i])) {
                                FarmingPatch patch = player.FarmingPatches[curr.FarmingPatchesHere[i]];

                                mini.Con.Print(resourceX + 2, resourceY, "|");

                                if (patch.SeedPlanted == "") { 
                                    mini.Con.Print(resourceX + 4, resourceY, "(Empty " + patch.PatchType + " Patch)");
                                } else {
                                    if (patch.TimeLeft <= 0) {
                                        patch.TimeLeft = 0;
                                        mini.Con.PrintClickable(resourceX + 4, resourceY, new ColoredString(ResolveItemName(patch.SeedPlanted) + " [" + patch.TimeLeft + "]", Color.Lime, Color.Black), () => {
                                            Item? seed = ResolveItem(patch.SeedPlanted);
                                            if (seed != null) {
                                                Item? output = Helper.Clone(ResolveItem(seed.UseString3));
                                                if (output != null) {
                                                    int qty = 5 + (int) Math.Floor((player.Skills["Farming"].Level - seed.UseInt) / 5.0) + patch.Compost;

                                                    if (output.Stackable) {
                                                        output.Quantity = qty; 
                                                        player.TryGrantExp("Farming", seed.UseInt2 * qty, Log, RecentlyTrainedSkills);
                                                        if (!player.TryPickup(output, output.Quantity)) {
                                                            curr.ItemsHere.Add(output);  
                                                            Log.AddMessage(new ColoredString("Your inventory is full, so the " + output.Name + "s fall to the ground." , Color.Crimson, Color.Black));
                                                        }
                                                    } else {
                                                        for (int i = 0; i < qty; i++) {
                                                            player.TryGrantExp("Farming", seed.UseInt2, Log, RecentlyTrainedSkills);
                                                            if (!player.TryPickup(output, 1)) {
                                                                curr.ItemsHere.Add(output); 
                                                                Log.AddMessage(new ColoredString("Your inventory is full, so the " + output.Name + " falls to the ground.", Color.Crimson, Color.Black)); 
                                                            }
                                                        }
                                                    }
                                                } else {
                                                    Log.AddMessage(new ColoredString("The harvested item crumbles away in your hands, this should be reported as a bug.", Color.Crimson, Color.Black));
                                                }
                                            } else { 
                                                Log.AddMessage(new ColoredString("The harvested seed crumbles away in your hands, this should be reported as a bug.", Color.Crimson, Color.Black));
                                            } 

                                            patch.ClearPatch();
                                        });
                                    } else {
                                        mini.Con.Print(resourceX + 4, resourceY, ResolveItemName(patch.SeedPlanted) + " [" + (patch.TimeLeft / player.FarmGrowthIncrement) + "]");
                                    }
                                    mini.Con.PrintClickable(resourceX + 2, resourceY, new ColoredString("X", Color.Crimson, Color.Black), () => { patch.ClearPatch(); });
                                } 
                                 

                                resourceY++;
                            } else {
                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.Print(resourceX + 4, resourceY++, curr.FarmingPatchesHere[i], Color.DarkSlateGray);
                            }
                        }
                    } else {
                        mini.Con.Print(resourceX + 2, resourceY, "|");
                        mini.Con.Print(resourceX + 4, resourceY++, "(no farming patches here)", Color.DarkSlateGray);
                    }
                }


            }


            mini.Win.PrintClickable(143, 49, "[SAVE]", () => { ManualSave(); });
        }

        public void LogDraw(UI_EmbeddedMini mini) {
            mini.Con.DrawLine(new Point(0, 35), new Point(148, 35), 196);
            for (int i = Log.TopIndex; i < Log.Log.Count && i < Log.TopIndex + 12; i++) {
                int printY = 36 + (i - Log.TopIndex);
                if (Log.Log[i].Count == 1)
                    mini.Con.Print(0, printY, Log.Log[i].Message);
                else
                    mini.Con.Print(0, printY, Log.Log[i].Message + " (x" + Log.Log[i].Count.ToString() + ")");
            }
        }


        public void Update(UI_EmbeddedMini mini) {
            //Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;  

            mini.Con.Clear();
            mini.SingleSquare.Clear();
            mini.DoubleSquare.Clear();
            mini.QuadSquare.Clear();


            SidebarDraw(mini); 
            LocationDraw(mini); 
            LogDraw(mini); 

            if (CollectionLog.IsVisible)
                CollectionLogDraw();

            if (Guide.IsVisible)
                GuideDraw();
             
            if (CraftingMenu.IsVisible)
                CraftingMenuDraw();

            if (Quests.IsVisible)
                QuestDraw();

            if (TimeLastTicked + 1000 < Helper.Time()) {
                TickTime();
            } 
        }

        List<string> activityTabs = new() { "Items", "NPCs", "Processing", "Resources", "Chat", "Shop", "Farming" };

        public void Input(UI_EmbeddedMini mini) {
            Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;
            if (Helper.HotkeyDown(Key.Escape)) {
                if (CollectionLog.IsVisible) {
                    CollectionLog.IsVisible = false;
                    return;
                }

                if (Guide.IsVisible) {
                    Guide.IsVisible = false;
                    return;
                }

                if (CraftingMenu.IsVisible) {
                    CraftingMenu.IsVisible = false;
                    return;
                }

                if (Quests.IsVisible) {
                    Quests.IsVisible = false;
                    return;
                } 
                Close(mini);
            }

            if (mousePos.Y > 34 && !CollectionLog.IsVisible && !Guide.IsVisible && !CraftingMenu.IsVisible && !Quests.IsVisible) {
                if (Helper.ScrolledUp()) { Log.TopIndex = Math.Clamp(Log.TopIndex - 1, 0, Log.Log.Count); }
                if (Helper.ScrolledDown()) { Log.TopIndex = Math.Clamp(Log.TopIndex + 1, 0, Log.Log.Count); }
            }

            if (SidebarRect.Contains(mousePos) && !CollectionLog.IsVisible && !Guide.IsVisible && !CraftingMenu.IsVisible && !Quests.IsVisible) {
                if (SidebarMenu == "Prayer") {
                    if (Helper.ScrolledUp()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop - 1, 0, player.Prayers.Count - 18); }
                    if (Helper.ScrolledDown()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop + 1, 0, player.Prayers.Count - 18); }
                } else if (SidebarMenu == "Skills") {
                    if (Helper.ScrolledUp()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop - 1, 0, player.Skills.Count - 18); }
                    if (Helper.ScrolledDown()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop + 1, 0, player.Skills.Count - 18); }
                } else if (SidebarMenu == "Quest") {
                    if (player.QuestLog.Count > 18) {
                        if (Helper.ScrolledUp()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop - 1, 0, player.QuestLog.Count - 18); }
                        if (Helper.ScrolledDown()) { SidebarScrollTop = Math.Clamp(SidebarScrollTop + 1, 0, player.QuestLog.Count - 18); }
                    }
                }
            }

            if (Helper.HotkeyDown(Key.Tab)) {
                for (int i = 0; i < activityTabs.Count; i++) {
                    if (activityTabs[i] == SelectedMenu) {
                        if (i == activityTabs.Count - 1) {
                            SelectedMenu = activityTabs[0];
                        }
                        else {
                            SelectedMenu = activityTabs[i + 1];
                        }

                        break;
                    }
                }
            }

            if (Helper.HotkeyDown(Key.C)) {
                CollectionLog.IsVisible = !CollectionLog.IsVisible;
                Guide.IsVisible = false;
                CraftingMenu.IsVisible = false;
                Quests.IsVisible = false;
            }

            if (Helper.HotkeyDown(Key.F1)) {
                Guide.IsVisible = !Guide.IsVisible;
                CollectionLog.IsVisible = false;
                CraftingMenu.IsVisible = false;
                Quests.IsVisible = false;
            }

            if (Helper.HotkeyDown(Key.Q)) {
                Quests.IsVisible = !Quests.IsVisible;
                Guide.IsVisible = false;
                CollectionLog.IsVisible = false;
                CraftingMenu.IsVisible = false;
            }

            if (GameHost.Instance.Mouse.RightClicked) {
                Log.AddMessage(mousePos.ToString()); 
                player.HeldGold += 1000;
            }
        }

        public void Close(UI_EmbeddedMini mini) {
            ManualSave(false);
            Reset();
            mini.Toggle();
        }

        public void Reset() {
            HardResetPlayer();
        }


        public void ManualSave(bool announce = true) {
            if (!Directory.Exists("./saves/")) {
                Directory.CreateDirectory("./saves/");
            }

            Helper.SerializeToFile(player, "./saves/" + player.Name + ".json"); 
            SecondsSinceAutosave = 0;

            if (announce)
                Log.AddMessage("Player data saved!");
        }

        public void TickTime() {
            TimeLastTicked = Helper.Time();

            SecondsSinceAutosave++;

            if (SecondsSinceAutosave >= 600) { 
                ManualSave();

                SecondsSinceAutosave = 0;

                Log.AddMessage("Player autosave complete.");
            }

            foreach (var kv in player.FarmingPatches) {
                if (kv.Value.SeedPlanted != "" && kv.Value.TimeLeft > 0) {
                    kv.Value.TimeLeft -= player.FarmGrowthIncrement;
                }
            }

            if (WarnedTutorialTele) {
                if (TimeWarned + 5000 < Helper.Time()) {
                    WarnedTutorialTele = false;
                }
            }
        }

        public bool UseItem(Item item) {
            if (item.UseString == "GetGold") {
                player.HeldGold += item.UseInt;
                Log.AddMessage("You open the " + item.Name + " and find " + item.UseInt + " gold pieces.");
            } else if (item.UseString == "Bones") {
                Log.AddMessage("You bury the " + item.Name.ToLowerInvariant() + " and get " + item.UseInt + " prayer experience.");
                player.TryGrantExp("Prayer", 5, Log, RecentlyTrainedSkills);
            } else if (item.UseString == "Heal") {
                player.CurrentHP = Math.Clamp(player.CurrentHP + item.UseInt, player.CurrentHP, player.Skills["Constitution"].Level);
                Log.AddMessage(new ColoredString("You eat the " + item.Name.ToLowerInvariant() + " and recover some hitpoints.", Color.Goldenrod, Color.Black));
            } else if (item.UseString == "PlantSeed") {
                if (Atlas.ContainsKey(player.NavLoc)) {
                    Location curr = Atlas[player.NavLoc];

                    bool foundPlantSpot = false;

                    for (int i = 0; i < curr.FarmingPatchesHere.Count; i++) {
                        if (player.FarmingPatches.ContainsKey(curr.FarmingPatchesHere[i])) {
                            FarmingPatch patch = player.FarmingPatches[curr.FarmingPatchesHere[i]];

                            if (patch.PatchType == item.UseString2 && patch.SeedPlanted == "") {
                                if (player.Skills["Farming"].Level >= item.UseInt) {
                                    patch.SeedPlanted = item.ID;
                                    patch.TimeLeft = item.UseInt3;
                                    foundPlantSpot = true;
                                    Log.AddMessage(new ColoredString("You plant the " + item.Name.ToLowerInvariant() + ".", Color.Goldenrod, Color.Black));
                                } else {
                                    Log.AddMessage(new ColoredString("You need " + item.UseInt + " Farming to plant that.", Color.Crimson, Color.Black));
                                    return false;
                                }
                                break;
                            }
                        }
                    }
                    
                    if (!foundPlantSpot) {
                        Log.AddMessage(new ColoredString("No " + item.UseString2.ToLowerInvariant() + " patches here to plant that.", Color.Crimson, Color.Black));
                        return false;
                    }
                } else {
                    return false;
                }
            } else if (item.UseString == "Dig") {
                ClueLogic.GenericStep(player, Log, "Dig");

                if (Atlas.TryGetValue(player.NavLoc, out Location? curr)) {
                    if (curr != null) {
                        if (curr.DigItem != "") {
                            if (ItemLibrary.TryGetValue(curr.DigItem, out Item? dug)) {
                                if (dug != null) {
                                    player.TryPickup(Helper.Clone(dug), dug.Quantity);
                                }
                            }
                        }
                    }
                }
            } else if (item.UseString == "ClueTutorial") {
                ClueLogic.SetOrShowStep("Tutorial", player, Log);
            } else if (item.UseString == "Casket") {
                List<Item> rolledItems = new();

                for (int j = 0; j < item.DropTable.Count; j++) {
                    ItemDrop drop = item.DropTable[j];

                    if (GameLoop.rand.Next(drop.InY) < drop.DropX) {
                        if (!player.CollectionLogClues.ContainsKey(item.ID))
                            player.CollectionLogClues.Add(item.ID, new(item.ID));

                        if (!player.CollectionLogClues[item.ID].DropsObtained.ContainsKey(drop.ItemID))
                            player.CollectionLogClues[item.ID].DropsObtained.Add(drop.ItemID, 0);

                        if (ItemLibrary.ContainsKey(drop.ItemID)) {
                            Item spawn = Helper.Clone(ItemLibrary[drop.ItemID]);

                            if (drop.QuantityMin == drop.QuantityMax)
                                spawn.Quantity = drop.QuantityMin;
                            else {
                                int amt = GameLoop.rand.Next(drop.QuantityMax - drop.QuantityMin) + drop.QuantityMin;
                                spawn.Quantity = amt;
                            }

                            rolledItems.Add(spawn);
                        }
                    }
                }

                rolledItems.Shuffle();
                 
                
                Log.AddMessage(new ColoredString("You open the casket...", Color.Green, Color.Black));
                player.CollectionLogClues[item.ID].KillCount += 1;
                for (int i = 0; i < 5; i++) {
                    if (i < rolledItems.Count) {
                        player.CollectionLogClues[item.ID].DropsObtained[rolledItems[i].ID] += rolledItems[i].Quantity;

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

                        Log.AddMessage(new ColoredString("The casket had " + name + " in it!", excitement, Color.Black));
                        player.TryPickup(rolledItems[i], rolledItems[i].Quantity);
                    } else {
                        player.HeldGold += item.UseInt;
                        Log.AddMessage(new ColoredString("The casket had " + item.UseInt + " gold pieces in it.", Color.DarkGoldenrod, Color.Black));
                    }
                } 
            } else if (item.UseString == "Needle") {
                CraftingMenu.IsVisible = true;
                CraftingType = "Needle";
            } else if (item.UseString == "Knife") {
                CraftingMenu.IsVisible = true;
                CraftingType = "Knife";
            } else if (item.UseString == "SecondExamine") {
                Log.AddMessage(new ColoredString(item.MiscString, Color.SandyBrown, Color.Black));

                foreach (var kv in player.QuestLog) {
                    kv.Value.CheckProgress(player, "ExamineItem", item.ID, 0);
                }
            }

            return true;
        }

        public void DestroyItem(int slot) {
            if (player.Inventory.Count > slot) {
                if (player.Inventory[slot].ID == "clueScrollTutorial") {
                    player.CurrentClueTutorial = "";
                    player.Inventory.RemoveAt(slot);
                }
            }
        }


        public void HardResetPlayer() {
            player = new();
            TryAddSkills();
            TryAddPrayers();
            TryAddSpells();
            player.CurrentHP = 10;

            RebuildLibraries();

            Log.Log.Clear();
            Log.AddMessage(new ColoredString("Press F1 at any time to open/close the guidebook.", Color.Turquoise, Color.Black));
        }

        public void SoftResetPlayer() {
            player.Inventory.Clear();
            player.Equipment.Clear();

            player.Skills.Clear();
            TryAddSkills();
            player.Prayers.Clear();
            TryAddPrayers();
            player.Spells.Clear();
            TryAddSpells();
            player.CurrentHP = 10;


            player.CollectionLog.Clear();
            player.BankedItems.Clear();
            player.ItemsEverObtained.Clear();
            player.ActivePotions.Clear();

            player.QuestLog.Clear();
            TryAddQuests();
            
            foreach (var patch in player.FarmingPatches) {
                patch.Value.ClearPatch();
            }

            foreach (var prayer in player.Prayers) {
                prayer.Value.Active = false;
            }
             
            Log.AddMessage(new ColoredString("Character soft-reset complete.", Color.Turquoise, Color.Black));
        }

        public void RemapItems(bool justApply = false) {
            if (!justApply) {
                List<string> itemIDs = ItemLibrary.Keys.ToList();
                int mapTo = 0;

                foreach (var kv in ItemLibrary) {
                    mapTo = GameLoop.rand.Next(itemIDs.Count);
                    player.ItemIDRemaps.Add(kv.Key, itemIDs[mapTo]);
                    itemIDs.RemoveAt(mapTo);
                }
            }

            Dictionary<string, Item> cloneLib = ItemLibrary.Clone();

            ItemLibrary.Clear();

            foreach (var kv in player.ItemIDRemaps) {
                ItemLibrary.Add(kv.Value, cloneLib[kv.Key]);
            }
        } 

        public void RebuildLibraries() {
            ItemLibrary.Clear();
            GatherSpots.Clear();
            ProcessingStations.Clear();
            UseRecipes.Clear();
            MonsterLibrary.Clear();
            Atlas.Clear();
            NPCLibrary.Clear();
            PrayerLibrary.Clear();
            player.FarmingPatches.Clear();
            ClueStepLibrary.Clear();
            CraftLib.Clear();
            QuestLibrary.Clear();
            SpellLibrary.Clear();

            HardcodedItems.InitItems(ItemLibrary);
            HardcodedGathering.InitGathers(GatherSpots);
            HardcodedProcessing.InitProcessors(ProcessingStations);
            HardcodedUseRecipes.InitUseRecipes(UseRecipes);
            HardcodedMonsters.InitMonsters(MonsterLibrary);
            HardcodedLocations.InitLocs(Atlas, GatherSpots, MonsterLibrary);
            HardcodedNPCs.InitNPCs(NPCLibrary);
            HardcodedPrayers.InitPrayers(PrayerLibrary);
            HardcodedFarmPatches.InitPatches(player.FarmingPatches);
            HardcodedClueSteps.InitClues(ClueStepLibrary);
            HardcodedCraftRecipes.InitCrafts(CraftLib);
            HardcodedQuests.InitQuests(QuestLibrary);
            HardcodedSpells.InitSpells(SpellLibrary);
        }

        public Item? ResolveItem(string ID) {
            if (player.RandomItems == 0) {
                if (ItemLibrary.ContainsKey(ID)) {
                    return ItemLibrary[ID];
                }
            } else {
                if (player.ItemIDRemaps.ContainsKey(ID)) {
                    if (ItemLibrary.ContainsKey(player.ItemIDRemaps[ID])) {
                        return ItemLibrary[player.ItemIDRemaps[ID]];
                    }
                }
            } 

            return null;
        }

        public string ResolveItemName(string ID) {
            if (ResolveItem(ID) is Item item && item != null) {
                return item.Name;
            }

            return ID;
        }

        public void PopulateCraftList() {
            ActiveRecipes.Clear();

            if (CraftLib.ContainsKey(CraftingType)) {
                foreach (var craft in CraftLib[CraftingType]) {
                    string itemNeeded = ResolveItemName(craft.NeededItems[0].Split(",")[0]); // TODO: Maybe involve multiple ingredients, or just file it under the first/primary permanently?
                    if (itemNeeded == CraftingSubtype) {
                        ActiveRecipes.Add(craft);
                    }
                }
            }
        }

        public void TryPlaceItem(string loc, Item item) {
            if (Atlas.TryGetValue(loc, out Location? curr)) {
                if (curr != null) {
                    bool found = false;
                    for (int i = 0; i < curr.ItemsHere.Count; i++) {
                        if (curr.ItemsHere[i].ID == item.ID && item.Stackable) {
                            curr.ItemsHere[i].Quantity += item.Quantity;
                            found = true;
                            break;
                        }
                    }

                    if (!found) {
                        curr.ItemsHere.Add(item);
                    }
                }
            }
        }

        public void TryAddQuests() {
            foreach (var kv in QuestLibrary) {
                player.QuestLog.TryAdd(kv.Key, kv.Value);
            }
        }

         public void TryAddSkills() {
            player.Skills.TryAdd("Woodcutting", new Skill("Woodcutting"));
            player.Skills.TryAdd("Mining", new Skill("Mining"));
            player.Skills.TryAdd("Smithing", new Skill("Smithing"));
            player.Skills.TryAdd("Thieving", new Skill("Thieving"));
            player.Skills.TryAdd("Cooking", new Skill("Cooking"));
            player.Skills.TryAdd("Fishing", new Skill("Fishing"));
            player.Skills.TryAdd("Runecrafting", new Skill("Runecrafting"));
            player.Skills.TryAdd("Crafting", new Skill("Crafting"));
            player.Skills.TryAdd("Farming", new Skill("Farming"));
            player.Skills.TryAdd("Herblore", new Skill("Herblore"));
            player.Skills.TryAdd("Agility", new Skill("Agility"));
            player.Skills.TryAdd("Firemaking", new Skill("Firemaking"));
            player.Skills.TryAdd("Fletching", new Skill("Fletching"));

            player.Skills.TryAdd("Constitution", new Skill("Constitution") { Level = 10 });
            player.Skills.TryAdd("Attack", new Skill("Attack"));
            player.Skills.TryAdd("Strength", new Skill("Strength"));
            player.Skills.TryAdd("Defense", new Skill("Defense"));
            player.Skills.TryAdd("Prayer", new Skill("Prayer"));
            player.Skills.TryAdd("Ranged", new Skill("Ranged"));
            player.Skills.TryAdd("Magic", new Skill("Magic"));
        }

        public void TryAddPrayers() { 
            foreach (var kv in PrayerLibrary) {
                player.Prayers.TryAdd(kv.Key, kv.Value);
            }
        }

        public void TryAddSpells() {
            foreach (var kv in SpellLibrary) {
                player.Spells.TryAdd(kv.Key, kv.Value);
            }
        }
    }
}
