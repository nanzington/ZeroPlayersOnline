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
        public Dictionary<string, BossFight> BossLibrary = new();
        public Dictionary<string, HunterCreature> HunterLibrary = new();

        public Dictionary<string, ClueStep> ClueStepLibrary = new();
        public Dictionary<string, Quest> QuestLibrary = new();

        public MessageLog Log = new();


        public int CurrDialogueStage = -1;
        public NPC? ConversationPartner = null;
        
        public string SelectedMenu = "Resources";

        public AreaMonster AttackingMonster = null;
        public bool AttackingBoss = false;
        public double LastHitTime = 0;
        public double GraceTimeStart = 0;
        public string Targetting = "Single";  

        public Window CollectionLog;
        public string CollectionID = "";
        public int CollectionDropTop = 0;
        public int CollectionSideTop = 0;
        public string CollectionCat = "";

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

        public bool WithdrawingNotes = false;

        public int SecondsSinceAutosave = 0;
        public double TimeLastTicked = 0;

        public Rectangle ActivityRect = new Rectangle(new Point(111, 10), new Point(147, 34));
        public int ActivityItemTop = 0;


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
        List<BossFight> bossList = new();

        public void CollectionLogDraw() {
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
                bossList = BossLibrary.Values.ToList().OrderBy(f => f.Name).ToList();

                for (int i = 0; i < bossList.Count; i++) {
                    CollectionLog.PrintClickable(1, 1 + i, new ColoredString(" " + bossList[i].Name, CollectionID == bossList[i].ID ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = bossList[i].ID; });
                }

                if (BossLibrary.ContainsKey(CollectionID)) {
                    BossFight view = BossLibrary[CollectionID];

                    if (view.DropTable.Count > 24) {
                        if (Helper.ScrolledUp()) { CollectionDropTop = Math.Clamp(CollectionDropTop - 1, 0, view.DropTable.Count - 24); }
                        if (Helper.ScrolledDown()) { CollectionDropTop = Math.Clamp(CollectionDropTop + 1, 0, view.DropTable.Count - 24); }
                    } 

                    int KC = 0;

                    if (player.CollectionLogBoss.ContainsKey(view.ID)) {
                        KC = player.CollectionLogBoss[view.ID].KillCount;
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

                        if (player.CollectionLogBoss.ContainsKey(view.ID)) {
                            if (player.CollectionLogBoss[view.ID].DropsObtained.ContainsKey(view.DropTable[i].ItemID)) {
                                timesObtained = player.CollectionLogBoss[view.ID].DropsObtained[view.DropTable[i].ItemID];
                            }
                        }

                        string name = ResolveItemName(view.DropTable[i].ItemID);

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
                monsterList = MonsterLibrary.Values.ToList().OrderBy(f => f.Name).ToList();

                for (int i = 0; i < monsterList.Count; i++) {
                    CollectionLog.PrintClickable(1, 1 + i, new ColoredString(" " + monsterList[i].Name, CollectionID == monsterList[i].ID ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = monsterList[i].ID; });
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
                        if (Atlas.TryGetValue(curr.ConnectedLocations[i].Destination, out Location? dest) && dest != null) { 
                            string name = dest.DisplayName; 

                            if (curr.ConnectedLocations[i].AltName != "") {
                                name = curr.ConnectedLocations[i].AltName;
                            }

                            if (dest.Region != curr.Region)
                                name += " [" + dest.Region + "]";

                            mini.Con.PrintClickable(57, printY++, new ColoredString("| " + name, curr.ConnectedLocations[i].CanTraverse(player) ? Color.White : Color.Crimson, Color.Black), () => {
                                if (curr.ConnectedLocations[i].CanTraverse(player)) {
                                    curr.ConnectedLocations[i].Traverse(player); 
                                    GraceTimeStart = Helper.Time();
                                    AttackingMonster = null;

                                    if (curr.MonstersHere.Count > 0) {
                                        for (int j = 0; j < curr.MonstersHere.Count; j++) {
                                            curr.MonstersHere[j].AttackingPlayer = false;
                                        }
                                    }
                                } else {
                                    if (curr.ConnectedLocations[i].Requirements is List<Requirement> req) {
                                        Log.AddMessage("Missing some requirements to go there: " + (curr.ConnectedLocations[i].OnlyNeedOneReq ? "(only need one)" : ""), Color.Crimson);

                                        for (int j = 0; j < req.Count; j++) {
                                            Log.AddMessage("| " + req[j].GetSummary(), req[j].CheckRequirement(player) ? Color.Lime : Color.Crimson); 
                                        }
                                    }
                                }
                            });
                        }
                        else {
                            mini.Con.Print(57, printY++, "| " + curr.ConnectedLocations[i].Destination, Color.DarkSlateGray);
                        }
                    }

                } 

                if (curr.BossHere != "" && BossLibrary.TryGetValue(curr.BossHere, out BossFight? boss) && boss != null) {  
                    mini.Con.DrawLine(new Point(56, printY), new Point(109, printY++), 196);
                    mini.Con.Print(57, printY, "Boss Here: ");

                    mini.Con.PrintClickable(68, printY, "(Log)", () => {
                        CollectionLog.IsVisible = true;
                        CollectionID = boss.ID;
                        CollectionCat = "Boss";
                        CollectionDropTop = 0;
                    });

                    mini.Con.PrintClickable(74, printY, new ColoredString("(Attack)", AttackingBoss ? Color.Crimson : Color.DarkSlateGray, Color.Black), () => {
                        AttackingBoss = !AttackingBoss;
                    });
                    
                    double timeToAttack = boss.TimeLastAttacked + boss.AttackSpeedInMS - Helper.Time(); 
                    string bossDice = boss.DefaultDmgDice;
                    string bossType = boss.DefaultDmgType;

                    if (boss.UsingMove != -1 && boss.Specials.Count > boss.UsingMove) {
                        bossDice = boss.Specials[boss.UsingMove].DamageDice;
                        bossType = boss.Specials[boss.UsingMove].DamageType;
                    }

                    bool reachedKillLimit = player.KillLimit == 0 ? true : false;
                    if (player.CollectionLogBoss.ContainsKey(boss.ID)) {
                        reachedKillLimit = player.KillLimit != -1 && player.CollectionLogBoss[boss.ID].KillCount >= player.KillLimit; 
                    }

                    if (GraceTimeStart + 5000 > Helper.Time()) {
                        mini.Con.Print(98, printY, "Grace: " + Math.Floor(GraceTimeStart + 5000 - Helper.Time()), Color.DarkSlateGray);
                    } else { 
                        if (timeToAttack > 0 && boss.CurrentHP > 0)
                            mini.Con.Print(95, printY, "Attack:  " + (Math.Floor(timeToAttack)).ToString().Align(HorizontalAlignment.Right, 5));
                    } 

                    printY++; 

                    mini.Con.Print(57, printY, "| " + boss.Name + " (" + boss.CurrentHP + "/" + boss.MaxHP + " hp)", (boss.AggroLevel > player.GetCombatLevel() || boss.AlwaysAggro || boss.AttackingPlayer) ? Color.Crimson : Color.White);
                    mini.Con.Print(97, printY, "Next: " + bossType.Align(HorizontalAlignment.Right, 6));
                    

                    printY += 2;


                    
                    mini.Con.Print(57, printY++, "Lanes ");
                    for (int i = 0; i < boss.LanesHere; i++) {
                        mini.Con.PrintClickable(57, printY, "| Lane: ", () => { boss.CurrentLane = i; });

                        if (boss.CurrentLane == i) {
                            Color col = Color.White;

                            if (boss.UsingMove != -1) {
                                if (boss.Specials.Count > boss.UsingMove) {
                                    if (boss.Specials[boss.UsingMove].HitsLanes.Contains(i)) {
                                        if (timeToAttack > boss.AttackSpeedInMS / 2.0) {
                                            col = Color.Yellow;
                                        } else {
                                            col = Color.Crimson;
                                        }
                                    }
                                }
                            }

                            mini.Con.PrintClickable(65, printY++, new ColoredString("(standing here)", col, Color.Black), () => { boss.CurrentLane = i; });
                        } else {
                            Color col = Color.DarkSlateGray;

                            if (boss.UsingMove != -1) {
                                if (boss.Specials.Count > boss.UsingMove) {
                                    if (boss.Specials[boss.UsingMove].HitsLanes.Contains(i)) {
                                        if (timeToAttack > boss.AttackSpeedInMS / 2.0) {
                                            col = Color.Yellow;
                                        } else {
                                            col = Color.Crimson;
                                        }
                                    }
                                }
                            }

                            mini.Con.PrintClickable(65, printY++, new ColoredString("(empty)", col, Color.Black), () => { boss.CurrentLane = i; });
                        }
                    }

                    if (GraceTimeStart + 5000 < Helper.Time() && boss.TimeLastAttacked + boss.AttackSpeedInMS < Helper.Time() && boss.CurrentHP > 0) {
                        if (boss.AggroLevel > player.GetCombatLevel() || boss.AlwaysAggro || boss.AttackingPlayer) {
                            boss.TimeLastAttacked = Helper.Time();

                            int dmg = GoRogue.DiceNotation.Dice.Roll(bossDice);
                            int modified = dmg;

                            int hitChance = GameLoop.rand.Next(100);

                            bool safespotting = false;

                            if (player.Equipment.ContainsKey("Weapon")) {
                                if (player.Equipment["Weapon"].EquipSkill == "Ranged" || player.Equipment["Weapon"].EquipSkill == "Magic") {
                                    if (bossType == "Melee") {
                                        safespotting = true;
                                    }
                                }
                            }

                            if (player.IsMaging()) {
                                safespotting = true;
                            }

                            if (!safespotting && boss.UsingMove != -1 && boss.Specials.Count > boss.UsingMove && !boss.Specials[boss.UsingMove].HitsLanes.Contains(boss.CurrentLane)) {
                                safespotting = true;
                                Log.AddMessage(new ColoredString("You deftly dodge out of the way of the boss' special attack.", Color.Green, Color.Black));
                            }

                            if (!safespotting) {
                                if (hitChance < 25 + (player.GetEffectiveSkillLevel("Defense") / 4.0)) {
                                    Log.AddMessage(new ColoredString(boss.Name + " tried to hit you but missed!", Color.Yellow, Color.Black));
                                } else {
                                    modified -= player.TotalArmorValue(bossType);

                                    if ((player.PrayerActive("Protect from Magic") && bossType == "Magic") || (player.PrayerActive("Protect from Melee") && bossType == "Melee") || (player.PrayerActive("Protect from Range") && bossType == "Ranged")) {
                                        modified /= 2;
                                    }
                                         
                                    if (dmg != modified) {
                                        if (modified <= 0) {
                                            Log.AddMessage(new ColoredString(boss.Name + " hit you for " + dmg + ", but you took no damage!", Color.Crimson, Color.Black));
                                        } else {
                                            Log.AddMessage(new ColoredString(boss.Name + " hit you for " + dmg + ", reduced to " + modified + "!", Color.Crimson, Color.Black));
                                        }
                                    } else {
                                        Log.AddMessage(new ColoredString(boss.Name + " hit you for " + dmg + "!", Color.Crimson, Color.Black));
                                    }
                                    
                                    bool died = modified > 0 ? player.TakeDamage(modified, Log) : false;

                                    if (player.DefenseExpSplit > 0 && !reachedKillLimit)
                                        player.TryGrantExp("Defense", dmg * player.DefenseExpSplit, Log, SidebarManager.RecentlyTrainedSkills);

                                    if (player.DefenseExpSplit < 4 && !reachedKillLimit)
                                        player.TryGrantExp("Constitution", dmg * (4 - player.DefenseExpSplit), Log, SidebarManager.RecentlyTrainedSkills);

                                    if (died)
                                        return;
                                }
                            }

                            if (boss.UsingMove != -1) {
                                boss.UsingMove = -1;
                                boss.MovesSinceSpecial = 0;
                            } else {
                                boss.MovesSinceSpecial++;

                                if (boss.MovesSinceSpecial == boss.AttacksBetweenSpecials && boss.Specials.Count > 0) {
                                    boss.UsingMove = GameLoop.rand.Next(boss.Specials.Count);
                                    Log.AddMessage(boss.Specials[boss.UsingMove].WarningText, Color.Yellow);
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

                    if (LastHitTime + (1000 * attackSpeed) < Helper.Time() && boss.CurrentHP > 0 && AttackingBoss) {
                        LastHitTime = Helper.Time();
                        boss.AttackingPlayer = true;

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
                                player.TryGrantExp("Magic", spellExp, Log, SidebarManager.RecentlyTrainedSkills);
                            }

                            if (hitChance > 25 + (player.GetEffectiveSkillLevel(whichSkill) / 2.0)) {
                                Log.AddMessage(new ColoredString("You tried to hit the " + boss.Name + " but missed!", Color.Crimson, Color.Black));
                            } else {
                                int pdmg = GoRogue.DiceNotation.Dice.Roll(player.GetDamageDice());
                                bool crit = false;

                                if (player.GetDamageType() == boss.WeakType) {
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



                                if (pdmg > boss.CurrentHP)
                                    pdmg = boss.CurrentHP;

                                boss.CurrentHP -= pdmg;
                                     
                                Log.AddMessage(new ColoredString("You hit the " + boss.Name + " for " + pdmg + "." + (crit ? " Critical Hit!" : ""), crit ? Color.Lime : Color.Green, Color.Black));

                                if (player.IsMaging()) {  
                                    player.TryGrantExp("Magic", (pdmg * 4), Log, SidebarManager.RecentlyTrainedSkills);

                                    string cast = player.CanCast(player.Spells[player.CastingSpell]);
                                    if (cast != "") { 
                                        Log.AddMessage(new ColoredString("Cannot cast spell anymore: " + cast, Color.Crimson, Color.Black)); 
                                        player.CastingSpell = "";
                                    }
                                } else if (usedAmmo) { 
                                    player.TryGrantExp("Ranged", pdmg * 4, Log, SidebarManager.RecentlyTrainedSkills);
                                } else {
                                    if (player.OffenseExpSplit > 0 && !reachedKillLimit)
                                        player.TryGrantExp("Attack", pdmg * player.OffenseExpSplit, Log, SidebarManager.RecentlyTrainedSkills);

                                    if (player.OffenseExpSplit < 4 && !reachedKillLimit)
                                        player.TryGrantExp("Strength", pdmg * (4 - player.OffenseExpSplit), Log, SidebarManager.RecentlyTrainedSkills);
                                }

                                if (boss.CurrentHP <= 0) {
                                    boss.TimeLastKilled = Helper.Time();
                                    boss.AttackingPlayer = false;

                                    if (!player.CollectionLogBoss.ContainsKey(boss.ID))
                                        player.CollectionLogBoss.Add(boss.ID, new(boss.ID));

                                    player.CollectionLogBoss[boss.ID].KillCount += 1;

                                    if (player.KillLimit != -1 && player.CollectionLogBoss[boss.ID].KillCount == player.KillLimit) {
                                        Log.AddMessage(new ColoredString("You've killed " + player.KillLimit + " " + boss.Name + "s and will no longer receive drops or exp from them."));
                                    }

                                    if (boss.DropTable != null && boss.DropTable.Count > 0) {
                                        for (int j = 0; j < boss.DropTable.Count; j++) {
                                            ItemDrop drop = boss.DropTable[j];

                                            drop.RollDrop(player, player.CollectionLogBoss[boss.ID]);
                                        }
                                    }
                                }
                            }
                        } else { 
                            Log.AddMessage(new ColoredString("You haven't got any valid ammo for your weapon!", Color.Crimson, Color.Black));
                        }
                    }

                    if (boss.CurrentHP <= 0 && boss.TimeLastKilled + (boss.RespawnTime * 1000) < Helper.Time()) {
                        boss.CurrentHP = boss.MaxHP; 
                        boss.TimeLastAttacked = Helper.Time();
                        boss.AttackingPlayer = false;
                    }  

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
                            List<AreaMonster> alive = new();

                            for (int mon = 0; mon < curr.MonstersHere.Count; mon++) {
                                if (curr.MonstersHere[mon].CurrentHP > 0)
                                    alive.Add(curr.MonstersHere[mon]);
                            }

                            while (AttackingMonster.CurrentHP <= 0 && alive.Count > 0) {
                                AttackingMonster = alive[GameLoop.rand.Next(alive.Count)];
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

                                        bool died = modified > 0 ? player.TakeDamage(modified, Log) : false;

                                        if (player.DefenseExpSplit > 0 && !reachedKillLimit)
                                            player.TryGrantExp("Defense", dmg * player.DefenseExpSplit, Log, SidebarManager.RecentlyTrainedSkills);

                                        if (player.DefenseExpSplit < 4 && !reachedKillLimit)
                                            player.TryGrantExp("Constitution", dmg * (4 - player.DefenseExpSplit), Log, SidebarManager.RecentlyTrainedSkills);

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
                                    player.TryGrantExp("Magic", spellExp, Log, SidebarManager.RecentlyTrainedSkills);
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
                                        player.TryGrantExp("Magic", (pdmg * 4), Log, SidebarManager.RecentlyTrainedSkills);

                                        string cast = player.CanCast(player.Spells[player.CastingSpell]);
                                        if (cast != "") { 
                                            Log.AddMessage(new ColoredString("Cannot cast spell anymore: " + cast, Color.Crimson, Color.Black)); 
                                            player.CastingSpell = "";
                                        }
                                    } else if (usedAmmo) { 
                                        player.TryGrantExp("Ranged", pdmg * 4, Log, SidebarManager.RecentlyTrainedSkills);
                                    } else {
                                        if (player.OffenseExpSplit > 0 && !reachedKillLimit)
                                            player.TryGrantExp("Attack", pdmg * player.OffenseExpSplit, Log, SidebarManager.RecentlyTrainedSkills);

                                        if (player.OffenseExpSplit < 4 && !reachedKillLimit)
                                            player.TryGrantExp("Strength", pdmg * (4 - player.OffenseExpSplit), Log, SidebarManager.RecentlyTrainedSkills);
                                    }

                                    if (AttackingMonster.ID == player.SlayerTask) {
                                        player.TryGrantExp("Slayer", pdmg * 4, Log, SidebarManager.RecentlyTrainedSkills);
                                    }

                                    if (AttackingMonster.CurrentHP <= 0) {
                                        AttackingMonster.TimeLastKilled = Helper.Time();
                                        AttackingMonster.AttackingPlayer = false;

                                        if (AttackingMonster.ID == player.SlayerTask) {
                                            player.SlayerKillsRemaining--;

                                            if (player.SlayerKillsRemaining <= 0) {
                                                Log.AddMessage("You have finished your Slayer task and should go get another.", Color.MediumPurple);
                                                player.SlayerTask = "";
                                                player.SlayerKillsRemaining = 0;
                                                // TODO: Add slayer points if from a real slayer master
                                            }
                                        }

                                        if (!player.CollectionLog.ContainsKey(AttackingMonster.ID))
                                            player.CollectionLog.Add(AttackingMonster.ID, new(AttackingMonster.ID));

                                        player.CollectionLog[AttackingMonster.ID].KillCount += 1;

                                        if (player.KillLimit != -1 && player.CollectionLog[AttackingMonster.ID].KillCount == player.KillLimit) {
                                            Log.AddMessage(new ColoredString("You've killed " + player.KillLimit + " " + AttackingMonster.Name + "s and will no longer receive drops or exp from them."));
                                        }

                                        if (AttackingMonster.DropTable != null && AttackingMonster.DropTable.Count > 0) {
                                            for (int j = 0; j < AttackingMonster.DropTable.Count; j++) {
                                                ItemDrop drop = AttackingMonster.DropTable[j];

                                                drop.RollDrop(player, player.CollectionLog[AttackingMonster.ID]);
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
                            CollectionCat = "Monster";
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
                mini.Con.Print(resourceX + 28, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 30, resourceY, new ColoredString("H", SelectedMenu == "Hunter" ? Color.Yellow : (curr.HunterSpots.Count > 0 || player.SpawnedCreatures.Count > 0) ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Hunter"; });

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

                                mini.Con.PrintClickable(resourceX + 4, resourceY++, new ColoredString(tile.InteractVerb + " " + tile.Name, interact, Color.Black), () => { tile.Gather(player, Log, ItemLibrary, curr, SidebarManager.RecentlyTrainedSkills); });
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

                                if (item.Name.Contains("potion") && item.UseInt4 != 0) {
                                    name += " (" + item.UseInt4 + " doses)";
                                }

                                bool picked = false;

                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.PrintClickable(resourceX + 4, resourceY, new ColoredString(name, item.GetColor(), item.ColorSum() < 50 ? Color.White : Color.Black), () => { 
                                    int qty = 1;

                                    if (Helper.EitherShift())
                                        qty *= 5;
                                    if (Helper.EitherControl())
                                        qty *= 10;

                                    if (qty >= item.Quantity || Helper.EitherAlt())
                                        qty = item.Quantity;


                                    if (player.TryPickup(item, qty, item.Noteable ? WithdrawingNotes : false, fromGround: true)) { 
                                        if (item.Quantity <= 0) {
                                            player.BankedItems.RemoveAt(i); 
                                            picked = true;
                                        }
                                    }
                                }); 

                                if (picked)
                                    break;

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
                            for (int i = ActivityItemTop; i < curr.ItemsHere.Count && i < ActivityItemTop + 20; i++) { 
                                Item item = curr.ItemsHere[i];

                                string name = item.Name;
                                if (name.Length > 25)
                                    name = name[..25];

                                name = name + (item.Quantity > 1 ? " x" + item.Quantity : "");

                                if (item.Noted) {
                                    name += " (n)";
                                }

                                if (item.Name.Contains("potion") && item.UseInt4 != 0) {
                                    name += " (" + item.UseInt4 + " doses)";
                                }

                                bool picked = false;

                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.PrintClickable(resourceX + 4, resourceY, new ColoredString(name, item.GetColor(), item.ColorSum() < 50 ? Color.White : Color.Black), () => { 
                                    int qty = 1;

                                    if (Helper.EitherShift())
                                        qty *= 5;
                                    if (Helper.EitherControl())
                                        qty *= 10;

                                    if (qty >= item.Quantity || Helper.EitherAlt())
                                        qty = item.Quantity;

                                    if (player.TryPickup(item, qty, item.Noted, fromGround: true)) {  
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
                                    station.LastWorked = "";
                                    station.TryProcessItem(player, Log, ItemLibrary, SidebarManager.RecentlyTrainedSkills); 

                                    if (station.OpensUI) {
                                        CraftingMenu.IsVisible = true;
                                        CraftingType = station.Name;
                                    }
                                });

                                if (!station.OpensUI) {
                                    mini.Con.PrintClickable(resourceX + 2, resourceY, new ColoredString(236.AsString(), Color.MediumPurple, Color.Black), () => {
                                        station.LastWorked = "";

                                        while (station.TryProcessItem(player, Log, ItemLibrary, SidebarManager.RecentlyTrainedSkills)) {

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
                            mini.Con.PrintClickable(resourceX + 4, resourceY++, station.Name + " [" + secondsSinceMade + "]", () => { station.TryProcessItem(player, Log, ItemLibrary, SidebarManager.RecentlyTrainedSkills); });

                            if (station.TimeLeft != -1) {
                                if (station.TimeMade + (station.TimeLeft * 60000) <= Helper.Time()) {
                                    if (ItemLibrary.ContainsKey(station.ItemOnExpire)) {
                                        TryPlaceItem(player.NavLoc, Helper.Clone(ItemLibrary[station.ItemOnExpire]));
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

                                int extraButtons = 146;
                                if (thisOne.SlayerTasks.Count > 0) {
                                    mini.Con.PrintClickable(extraButtons, resourceY, "S", () => {
                                        if (player.SlayerTask == "") {
                                            SlayerTask task = thisOne.SlayerTasks[GameLoop.rand.Next(thisOne.SlayerTasks.Count)];
                                            player.SlayerTask = task.TargetID;
                                            player.SlayerKillsRemaining = (task.KillMin >= task.KillMax) ? task.KillMin : GameLoop.rand.Next(task.KillMax - task.KillMin) + task.KillMin;

                                            Log.AddMessage("Your new task is to kill " + player.SlayerKillsRemaining + " " + ResolveMonsterName(player.SlayerTask) + "s.", Color.MediumPurple);
                                        }
                                    });

                                    extraButtons -=2 ;
                                }

                                if (thisOne.PickpocketLevel > 0) {
                                    mini.Con.PrintClickable(extraButtons, resourceY, "P", () => {
                                        thisOne.TryPickpocket(player, SidebarManager.RecentlyTrainedSkills, ItemLibrary, Log);
                                    });

                                    extraButtons -= 2;
                                }
                                
                                resourceY++; 
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
                                            if (choice.ClickReqs != null) {
                                                Log.AddMessage(new ColoredString("Requirement(s) not met: ", Color.Crimson, Color.Black));
                                                for (int i = 0; i < choice.ClickReqs.Count; i++) {
                                                    Log.AddMessage("| " + choice.ClickReqs[i].GetSummary(), choice.ClickReqs[i].CheckRequirement(player) ? Color.Lime : Color.Crimson);
                                                }
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
                                                Log.AddMessage("You purchased a "  + shop.Name + " for " + shop.Value + " gp.", Color.Goldenrod);
                                                if (!player.TryPickup(shop, 1)) {
                                                    Log.AddMessage("Your inventory is full and the "  + shop.Name + " falls to the ground.", Color.Crimson);
                                                }
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
                                                Log.AddMessage("You purchased 10x "  + shop.Name + " for " + shop.Value*10 + " gp.", Color.Goldenrod);
                                                if (!player.TryPickup(shop, 10)) {
                                                    Log.AddMessage("Your inventory is full and the 10x "  + shop.Name + " fall to the ground.", Color.Crimson);
                                                }
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
                                                Log.AddMessage("You purchased 50x "  + shop.Name + " for " + shop.Value*50 + " gp.", Color.Goldenrod);
                                                if (!player.TryPickup(shop, 50)) {
                                                    Log.AddMessage("Your inventory is full and the 50x "  + shop.Name + " fall to the ground.", Color.Crimson);
                                                }
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
                                                Log.AddMessage("You purchased a "  + shop.Name + " for " + shop.Value + " gp.", Color.Goldenrod);
                                                if (!player.TryPickup(shop, 1)) {
                                                    Log.AddMessage("Your inventory is full and the "  + shop.Name + " falls to the ground.", Color.Crimson);
                                                }
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
                                                        player.TryGrantExp("Farming", seed.UseInt2 * qty, Log, SidebarManager.RecentlyTrainedSkills);
                                                        if (!player.TryPickup(output, output.Quantity)) {
                                                            Log.AddMessage(new ColoredString("Your inventory is full, so the " + output.Name + "s fall to the ground." , Color.Crimson, Color.Black));
                                                        }
                                                    } else {
                                                        for (int i = 0; i < qty; i++) {
                                                            player.TryGrantExp("Farming", seed.UseInt2, Log, SidebarManager.RecentlyTrainedSkills);

                                                            Item clone = Helper.Clone(output);
                                                            clone.Quantity = 1;

                                                            output.Quantity--;

                                                            if (!player.TryPickup(clone, 1)) {
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
                } else if (SelectedMenu == "Hunter") { 
                    mini.Con.Print(resourceX + 2, resourceY++, "Hunter Creatures Here"); 

                    if (curr.CreaturesHere.Count < curr.HunterSpots.Count) { 
                        for (int i = 0; i < curr.HunterSpots.Count; i++) {
                            if (HunterLibrary.TryGetValue(curr.HunterSpots[i], out HunterCreature? hunt) && hunt != null) {
                                HunterCreature clone = Helper.Clone(hunt);
                                clone.CurrentLane = GameLoop.rand.Next(10);
                                clone.TimeSpawned = Helper.Time();
                                curr.CreaturesHere.Add(clone);
                            }
                        }
                    }

                    int placedTraps = 0;

                    if (curr.CreaturesHere.Count > 0) {
                        List<HunterCreature> uniques = new();

                        for (int i = 0; i < 10; i++) {
                            if (!curr.TrapsDown.ContainsKey(i))
                                curr.TrapsDown.Add(i, "");
                            
                            if (curr.TrapsDown[i] != "")
                                placedTraps++;
                        }

                        for (int i = 0; i < 10; i++) {
                            ColoredString line = new ColoredString("| ", Color.White, Color.Black);

                            if (curr.TrapsDown[i] != "") {
                                if (ItemLibrary.TryGetValue(curr.TrapsDown[i], out Item? trap)) {
                                    line += new ColoredString(trap.Name + " ", Color.White, Color.Black);
                                } else {
                                    line += new ColoredString(curr.TrapsDown[i] + " ", Color.DarkSlateGray, Color.Black);
                                }
                            } else {
                                line += new ColoredString("(no trap) ", Color.DarkSlateGray, Color.Black);
                            }

                            for (int j = 0; j < curr.CreaturesHere.Count; j++) {
                                bool added = false;
                                for (int checkToAdd = 0; checkToAdd < uniques.Count; checkToAdd++) {
                                    if (uniques[checkToAdd].ID == curr.CreaturesHere[j].ID)
                                        added = true;
                                }
                                if (!added)
                                    uniques.Add(curr.CreaturesHere[j]);

                                if (curr.CreaturesHere[j].TimeLastCaught != 0 && curr.CreaturesHere[j].TimeLastCaught + (curr.CreaturesHere[j].RespawnTime * 1000) > Helper.Time()) {
                                    continue;
                                }

                                if (curr.CreaturesHere[j].TimeLastMoved + 1000 < Helper.Time()) {
                                    int move = GameLoop.rand.Next(3);

                                    if (move == 0) {
                                        if (curr.CreaturesHere[j].CurrentLane > 0) {
                                            curr.CreaturesHere[j].CurrentLane--;
                                        } else {
                                            curr.CreaturesHere[j].CurrentLane++;
                                        }
                                    } else if (move == 1) {
                                        if (curr.CreaturesHere[j].CurrentLane < 9) {
                                            curr.CreaturesHere[j].CurrentLane++;
                                        } else {
                                            curr.CreaturesHere[j].CurrentLane--;
                                        }
                                    }

                                    curr.CreaturesHere[j].TimeLastMoved = Helper.Time();


                                    if (curr.TrapsDown.TryGetValue(curr.CreaturesHere[j].CurrentLane, out string? trapID) && trapID != "") {
                                        if (curr.CreaturesHere[j].CatchID == trapID) {
                                            if (player.GetEffectiveSkillLevel("Hunter") >= curr.CreaturesHere[j].CatchLevel) {
                                                int skillMod = player.GetEffectiveSkillLevel("Hunter") - curr.CreaturesHere[j].CatchLevel;

                                                int roll = GameLoop.rand.Next(100);

                                                if (roll < 50 + skillMod) {
                                                    player.TryGrantExp("Hunter", curr.CreaturesHere[j].CatchEXP, Log, SidebarManager.RecentlyTrainedSkills);
                                                    
                                                    foreach (var kv in curr.CreaturesHere[j].Drops) {
                                                        kv.RollDrop(player, null);
                                                    } 

                                                    curr.CreaturesHere[j].TimeLastCaught = Helper.Time();
                                                }

                                                if (ItemLibrary.TryGetValue(trapID, out Item? trap) && trap != null) {
                                                    player.TryPickup(Helper.Clone(trap), 1);
                                                }

                                                curr.TrapsDown[curr.CreaturesHere[j].CurrentLane] = "";
                                            } else {
                                                Log.AddMessage("You need " + curr.CreaturesHere[j].CatchLevel + " Hunter to catch these.", Color.Crimson);
                                            }
                                        }
                                    } 
                                }


                                if (curr.CreaturesHere[j].CurrentLane == i) {
                                    line += new ColoredString("*", curr.CreaturesHere[j].GetColor(), Color.Black);
                                }
                            }

                            if (curr.TrapsDown[i] == "") {
                                mini.Con.PrintClickable(resourceX + 2, resourceY++, line, () => {
                                    if (ItemUseLogic.UsingSlot != -1) {
                                        if (player.Inventory.Count > ItemUseLogic.UsingSlot) {
                                            if (placedTraps < 3) {
                                                curr.TrapsDown[i] = player.Inventory[ItemUseLogic.UsingSlot].ID;
                                                player.Inventory.RemoveAt(ItemUseLogic.UsingSlot);
                                                ItemUseLogic.UsingSlot = -1;
                                            } else {
                                                Log.AddMessage("You can only place up to 3 traps in a location.", Color.Crimson);
                                            }
                                        }
                                    }
                                });
                            } else {
                                mini.Con.PrintClickable(resourceX + 2, resourceY++, line, () => {
                                    if (ItemLibrary.TryGetValue(curr.TrapsDown[i], out Item? trap) && trap != null) {
                                        player.TryPickup(Helper.Clone(trap), 1);
                                    }

                                    curr.TrapsDown[i] = "";
                                });
                            }
                        }

                        for (int i = 0; i < uniques.Count; i++) {
                            ColoredString line = new ColoredString("* " + uniques[i].Name + " [" + uniques[i].CatchLevel + ", " + ResolveItemName(uniques[i].CatchID) + "]", uniques[i].GetColor(), Color.Black);
                            mini.Con.Print(resourceX + 2, 34 - i, line);
                        }
                    } else {
                        mini.Con.Print(resourceX + 2, resourceY, "|");
                        mini.Con.Print(resourceX + 4, resourceY++, "(no hunter creatures here)", Color.DarkSlateGray);
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


            SidebarManager.Draw(mini, player); 
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

        List<string> activityTabs = new() { "Items", "NPCs", "Processing", "Resources", "Chat", "Shop", "Farming", "Hunter" };

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

            if (SidebarManager.SidebarRect.Contains(mousePos) && !CollectionLog.IsVisible && !Guide.IsVisible && !CraftingMenu.IsVisible && !Quests.IsVisible) {
                if (SidebarManager.SidebarMenu == "Prayer") {
                    if (Helper.ScrolledUp()) { SidebarManager.SidebarScrollTop = Math.Clamp(SidebarManager.SidebarScrollTop - 1, 0, player.Prayers.Count - 18); }
                    if (Helper.ScrolledDown()) { SidebarManager.SidebarScrollTop = Math.Clamp(SidebarManager.SidebarScrollTop + 1, 0, player.Prayers.Count - 18); }
                } else if (SidebarManager.SidebarMenu == "Skills") {
                    if (Helper.ScrolledUp()) { SidebarManager.SidebarScrollTop = Math.Clamp(SidebarManager.SidebarScrollTop - 1, 0, player.Skills.Count - 18); }
                    if (Helper.ScrolledDown()) { SidebarManager.SidebarScrollTop = Math.Clamp(SidebarManager.SidebarScrollTop + 1, 0, player.Skills.Count - 18); }
                } else if (SidebarManager.SidebarMenu == "Quest") {
                    if (player.QuestLog.Count > 18) {
                        if (Helper.ScrolledUp()) { SidebarManager.SidebarScrollTop = Math.Clamp(SidebarManager.SidebarScrollTop - 1, 0, player.QuestLog.Count - 18); }
                        if (Helper.ScrolledDown()) { SidebarManager.SidebarScrollTop = Math.Clamp(SidebarManager.SidebarScrollTop + 1, 0, player.QuestLog.Count - 18); }
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


            if (!Quests.IsVisible && !Guide.IsVisible && !CollectionLog.IsVisible && !CraftingMenu.IsVisible) {
                if (Atlas.TryGetValue(player.NavLoc, out Location? curr) && curr != null) {
                    if (Helper.HotkeyDown(Key.NumPad1) && curr.ConnectedLocations.Count > 0 && curr.ConnectedLocations[0].CanTraverse(player)) {
                        curr.ConnectedLocations[0].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad2) && curr.ConnectedLocations.Count > 1 && curr.ConnectedLocations[1].CanTraverse(player)) {
                        curr.ConnectedLocations[1].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad3) && curr.ConnectedLocations.Count > 2 && curr.ConnectedLocations[2].CanTraverse(player)) {
                        curr.ConnectedLocations[2].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad4) && curr.ConnectedLocations.Count > 3 && curr.ConnectedLocations[3].CanTraverse(player)) {
                        curr.ConnectedLocations[3].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad5) && curr.ConnectedLocations.Count > 4 && curr.ConnectedLocations[4].CanTraverse(player)) {
                        curr.ConnectedLocations[4].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad6) && curr.ConnectedLocations.Count > 5 && curr.ConnectedLocations[5].CanTraverse(player)) {
                        curr.ConnectedLocations[5].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad7) && curr.ConnectedLocations.Count > 6 && curr.ConnectedLocations[6].CanTraverse(player)) {
                        curr.ConnectedLocations[6].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad8) && curr.ConnectedLocations.Count > 7 && curr.ConnectedLocations[7].CanTraverse(player)) {
                        curr.ConnectedLocations[7].Traverse(player);
                    }

                    if (Helper.HotkeyDown(Key.NumPad9) && curr.ConnectedLocations.Count > 8 && curr.ConnectedLocations[8].CanTraverse(player)) {
                        curr.ConnectedLocations[8].Traverse(player);
                    } 
                }
            }


            if (GameHost.Instance.Mouse.RightClicked) {
                // Leaving this here just in case
                //player.HeldGold += 1000;
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



            for (int i = player.ActivePotions.Count - 1; i >= 0; i--) {
                player.ActivePotions[i].SecondsSinceWeaken++;

                if (player.ActivePotions[i].SecondsSinceWeaken >= 60) {
                    player.ActivePotions[i].SecondsSinceWeaken = 0;

                    if (player.ActivePotions[i].Change > 0)
                        player.ActivePotions[i].Change--;
                    else if (player.ActivePotions[i].Change < 0)
                        player.ActivePotions[i].Change++;

                    if (player.ActivePotions[i].Change == 0) {
                        player.ActivePotions.RemoveAt(i);
                    }
                }
            }

            if (player.Equipment.TryGetValue("Pet", out Item? pet) && pet != null) {
                if (GameLoop.rand.Next(100) == 0 && pet.PetBlurbs != null && pet.PetBlurbs.Count > 0) {
                    Log.AddMessage(pet.PetBlurbs[GameLoop.rand.Next(pet.PetBlurbs.Count)], pet.GetColor());
                }
            }
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

            TrySetupLogs();

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
            player.CollectionLogClues.Clear();
            player.CollectionLogBoss.Clear();
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
            BossLibrary.Clear();
            HunterLibrary.Clear();

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
            HardcodedBosses.InitBosses(BossLibrary);
            HardcodedHunter.InitHunter(HunterLibrary);
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

        public string ResolveMonsterName(string ID) {
            if (MonsterLibrary.TryGetValue(ID, out AreaMonster? mon) && mon != null) {
                return mon.Name;
            }

            return ID;
        }

        public string ResolveBossName(string ID) {
            if (BossLibrary.TryGetValue(ID, out BossFight? mon) && mon != null) {
                return mon.Name;
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
                        if (curr.ItemsHere[i].ID == item.ID && item.Noted == curr.ItemsHere[i].Noted) {
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
            player.Skills.TryAdd("Dungeoneering", new Skill("Dungeoneering"));
            player.Skills.TryAdd("Hunter", new Skill("Hunter"));
            player.Skills.TryAdd("Slayer", new Skill("Slayer"));

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

        public void TrySetupLogs() { 
            player.CollectionLogClues.TryAdd("casketTutorial", new("casketTutorial"));
        }
    }
}
