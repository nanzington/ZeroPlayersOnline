using ZeroPlayersOnline.DataTypes; 
using ZeroPlayersOnline.Hardcodes;
using ZeroPlayersOnline.UI; 
using SadConsole.Input;
using SadConsole.UI; 
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

        public Window Guide;
        public string GuideTab = "Introduction";


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


            player = new();

            HardcodedItems.InitItems(ItemLibrary);
            HardcodedGathering.InitGathers(GatherSpots);
            HardcodedProcessing.InitProcessors(ProcessingStations);
            HardcodedUseRecipes.InitUseRecipes(UseRecipes);
            HardcodedMonsters.InitMonsters(MonsterLibrary);
            HardcodedLocations.InitLocs(Atlas, GatherSpots, MonsterLibrary);
            HardcodedNPCs.InitNPCs(NPCLibrary);

            TryAddSkills();

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

        public void TryAddSkills() {
            player.Skills.TryAdd("Woodcutting", new Skill("Woodcutting"));
            player.Skills.TryAdd("Mining", new Skill("Mining"));
            player.Skills.TryAdd("Smithing", new Skill("Smithing"));
            player.Skills.TryAdd("Thieving", new Skill("Thieving"));
            player.Skills.TryAdd("Cooking", new Skill("Cooking"));
            player.Skills.TryAdd("Fishing", new Skill("Fishing"));

            player.Skills.TryAdd("Constitution", new Skill("Constitution") { Level = 10 });
            player.Skills.TryAdd("Attack", new Skill("Attack"));
            player.Skills.TryAdd("Strength", new Skill("Strength"));
            player.Skills.TryAdd("Defense", new Skill("Defense"));
            player.Skills.TryAdd("Prayer", new Skill("Prayer"));
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

                printY = Guide.PrintMultiLine(22, printY, "Welcome to Zero Players Online! The interface can be a little intimidating but this guide will hopefully ease you into the process of playing the game.", 78);
                printY += 2;

                printY = Guide.PrintMultiLine(22, printY, "The area to the top left contains your important stats readout, including HP and Gold, and skills you've recently gained experience in.", 78);
                printY += 2;

                printY = Guide.PrintMultiLine(22, printY, "Below this readout is the content area, containing tabs you can switch between at the top to view your inventory, equipment, and more.", 78);
                printY += 2;

                printY = Guide.PrintMultiLine(22, printY, "Underneath this and the width of the screen is your message log, where important messages are sent by the game.", 78);
                printY += 2;

                printY = Guide.PrintMultiLine(22, printY, "The top of the right side of the screen is your current location, listing its description and title.", 78);
                printY += 2;

                printY = Guide.PrintMultiLine(22, printY, "To the left below this are connected locations and monsters at this location. You can click a connected location to move to it.", 78);
                printY += 2;

                printY = Guide.PrintMultiLine(22, printY, "Finally to the right is the activity box, containing resources you can collect, items on the ground, NPCs, shop items, and processing stations at this location. Pressing TAB will cycle the tab shown here, or you can click on the letters at the top to change to specific tabs.", 78);
                printY += 3;

                printY = Guide.PrintMultiLine(22, printY, "This is all a lot to take in, but hopefully with some practice it will become more natural to navigate.", 78);
            }
        }


        List<AreaMonster> monsterList = new();

        public void CollectionLogDraw() {
            CollectionLog.Clear();
            Helper.DrawBox(CollectionLog, 0, 0, 68, 28);
            CollectionLog.Print(2, 0, "[Collection Log]");


            CollectionLog.DrawLine(new Point(25, 1), new Point(25, 28), 179);

            monsterList.Clear();
            monsterList = MonsterLibrary.Values.ToList().OrderBy(f => f.Name).ToList();

            for (int i = 0; i < monsterList.Count; i++) {
                CollectionLog.PrintClickable(1, 1 + i, new ColoredString(monsterList[i].Name, CollectionID == monsterList[i].ID ? Color.Yellow : Color.White, Color.Black), () => { CollectionID = monsterList[i].ID; });
            }

            if (MonsterLibrary.ContainsKey(CollectionID)) {
                AreaMonster view = MonsterLibrary[CollectionID];
                int KC = 0;

                if (player.CollectionLog.ContainsKey(view.ID)) {
                    KC = player.CollectionLog[view.ID].KillCount;
                }

                CollectionLog.Print(26, 1, (view.Name + " (" + KC + " KC)").Align(HorizontalAlignment.Center, 42));
                CollectionLog.DrawLine(new Point(26, 2), new Point(68, 2), 196);
                CollectionLog.Print(26, 3, "Item Name");
                CollectionLog.Print(49, 3, "Chance");
                CollectionLog.Print(60, 3, "Obtained");
                CollectionLog.DrawLine(new Point(26, 4), new Point(68, 4), 196);

                for (int i = 0; i < view.DropTable.Count; i++) {
                    int timesObtained = 0;

                    if (player.CollectionLog.ContainsKey(view.ID)) {
                        if (player.CollectionLog[view.ID].DropsObtained.ContainsKey(view.DropTable[i].ItemID)) {
                            timesObtained = player.CollectionLog[view.ID].DropsObtained[view.DropTable[i].ItemID];
                        }
                    }

                    string name = view.DropTable[i].ItemID;

                    if (ItemLibrary.ContainsKey(view.DropTable[i].ItemID))
                        name = ItemLibrary[view.DropTable[i].ItemID].Name;

                    string dropchance = (view.DropTable[i].DropX).ToString().PadLeft(5) + " in " + view.DropTable[i].InY;

                    CollectionLog.Print(26, 5 + i, name);
                    CollectionLog.Print(58, 5 + i, timesObtained.ToString().PadLeft(10));
                    CollectionLog.Print(45, 5 + i, dropchance);
                }
            }


            CollectionLog.PrintClickable(69, 0, new ColoredString("X", Color.Crimson, Color.Black), () => { CollectionLog.IsVisible = false; });
        }

        public void SidebarDraw(UI_EmbeddedMini mini) {
            Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;

            mini.Con.DrawLine(new Point(55, 0), new Point(55, 34), 179);
             
            if (LastHealedTick + 3000 < Helper.Time()) {
                player.CurrentHP = Math.Clamp(player.CurrentHP + 1, 0, player.Skills["Constitution"].Level);
                LastHealedTick = Helper.Time();
            }


            mini.Con.Print(1, 0, "HP: " + player.CurrentHP + " / " + player.Skills["Constitution"].Level, Color.Crimson);

            mini.Con.Print(1, 2, "Level: " + player.GetCombatLevel(), Color.Yellow);

            mini.Con.Print(1, 3, "Damage: " + player.GetDamageDice(), Color.Yellow);


            mini.Con.Print(1, 11, "Gold: " + String.Format($"{player.HeldGold:n0}"), Color.Goldenrod);


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
                            for (int j = 0; j < curr.ItemsHere.Count; j++) {
                                if (curr.ItemsHere[j].ID == curr.ItemSpawns[i].ItemID) {
                                    itemSpawnedAlready = true;
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


                mini.Con.DrawLine(new Point(0, 14), new Point(54, 14), 196);

                if (SidebarMenu == "Inventory") {

                    for (int i = 0; i < 20; i++) {
                        mini.Con.DrawLine(new Point(0, 15 + i), new Point(54, 15 + i), '-', Color.DarkSlateGray);

                        if (i < player.Inventory.Count) {
                            string line = player.Inventory[i].Name;

                            if (player.Inventory[i].Quantity > 1) {
                                line += " (x" + player.Inventory[i].Quantity + ")";
                            }

                            int colorSum = player.Inventory[i].colR + player.Inventory[i].colG + player.Inventory[i].colB;

                            Color itemName = new Color(player.Inventory[i].colR, player.Inventory[i].colG, player.Inventory[i].colB);

                            mini.Con.Print(0, 15 + i, line, (mousePos.X < 55 && mousePos.Y == 15 + i) ? itemName.GetDarker() : itemName, colorSum < 60 ? Color.White : Color.Black);

                            bool dropped = false;

                            if (player.Inventory[i].UseString != "") {
                                mini.Con.PrintClickable(46, 15 + i, new ColoredString("* ", Color.Yellow, Color.Black), () => {
                                    Item item = player.Inventory[i];
                                    UseItem(item);

                                    if (item.ConsumedOnUse) {
                                        item.Quantity -= 1;
                                    }

                                    if (item.Quantity <= 0) {
                                        player.Inventory.RemoveAt(i);
                                        dropped = true;
                                    }
                                });
                            }

                            if (dropped)
                                break;

                            if (player.Inventory[i].EquipSlot != "") {
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
                                            Item unequip = player.Equipment[item.EquipSlot];
                                            player.TryPickup(unequip);
                                            player.Equipment.Remove(item.EquipSlot);
                                        }

                                        player.Equipment.Add(item.EquipSlot, item);

                                        return;
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
                                if (curr.IsBank) {
                                    Item item = Helper.Clone(player.Inventory[i]); 
                                    player.BankedItems.Add(item);
                                }
                                else {
                                    if (curr.ShopItemsHere.Count == 0) {
                                        Item item = Helper.Clone(player.Inventory[i]);
                                        curr.ItemsHere.Add(item);
                                    }
                                    else {
                                        player.HeldGold += player.Inventory[i].Value * player.Inventory[i].Quantity;
                                    }
                                }

                                player.Inventory.RemoveAt(i);
                                dropped = true;
                            });

                            mini.Con.PrintClickable(52, 15 + i, new ColoredString("? ", Color.MediumPurple, Color.Black), () => { Log.AddMessage(player.Inventory[i].ExamineText); });

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

                                        if (ItemLibrary.ContainsKey(rec.OutputItem)) {
                                            Item made = Helper.Clone(ItemLibrary[rec.OutputItem]);
                                            made.Quantity = rec.OutputQty;

                                            player.TryPickup(made);
                                        }
                                        else {
                                            Log.AddMessage(new ColoredString("You get the feeling that should've resulted in " + rec.OutputItem + ", but that item doesn't exist.", Color.Crimson, Color.Black));
                                        }

                                        player.TryGrantExp(rec.SkillUsed, rec.ExpGranted, Log, RecentlyTrainedSkills);

                                        dropped = true;
                                        UsingSlot = -1;
                                    }
                                    else {
                                        Log.AddMessage(new ColoredString("Those two items don't combine like that.", Color.Crimson, Color.Black));
                                        UsingSlot = -1;
                                    }
                                }
                            });


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

                    mini.Con.Print(1, 16, "|   Weapon: "); 
                    if (player.Equipment.ContainsKey("Weapon")) {
                        mini.Con.PrintClickable(13, 16, player.Equipment["Weapon"].Name, () => {
                            Item item = player.Equipment["Weapon"];
                            player.TryPickup(item);
                            player.Equipment.Remove("Weapon");
                        });
                    }

                    mini.Con.Print(1, 17, "| Off-hand: ");
                    if (player.Equipment.ContainsKey("Offhand")) {
                        mini.Con.PrintClickable(13, 17, player.Equipment["Offhand"].Name, () => {
                            Item item = player.Equipment["Offhand"];
                            player.TryPickup(item);
                            player.Equipment.Remove("Offhand");
                        });
                    }

                    mini.Con.Print(1, 18, "|     Head: "); 
                    if (player.Equipment.ContainsKey("Head")) {
                        mini.Con.PrintClickable(13, 18, player.Equipment["Head"].Name, () => {
                            Item item = player.Equipment["Head"];
                            player.TryPickup(item);
                            player.Equipment.Remove("Head");
                        });
                    }

                    mini.Con.Print(1, 19, "|     Body: "); 
                    if (player.Equipment.ContainsKey("Body")) {
                        mini.Con.PrintClickable(13, 19, player.Equipment["Body"].Name, () => {
                            Item item = player.Equipment["Body"];
                            player.TryPickup(item);
                            player.Equipment.Remove("Body");
                        });
                    }

                    mini.Con.Print(1, 20, "|     Legs: "); 
                    if (player.Equipment.ContainsKey("Legs")) {
                        mini.Con.PrintClickable(13, 20, player.Equipment["Legs"].Name, () => {
                            Item item = player.Equipment["Legs"];
                            player.TryPickup(item);
                            player.Equipment.Remove("Legs");
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
                     
                    for (int i = 0; i < playerSkills.Count; i++) {
                        bool mouseHovering = mousePos.X < 54 && mousePos.Y == 17 + i;

                        mini.Con.Print(1, 17 + i, playerSkills[i].Name, mouseHovering ? Color.Yellow : Color.White);
                        mini.Con.Print(20, 17 + i, playerSkills[i].Level.ToString().PadLeft(3), mouseHovering ? Color.Yellow : Color.White);
                        mini.Con.Print(31, 17 + i, playerSkills[i].ExpToLevel().ToString().PadLeft(8), mouseHovering ? Color.Yellow : Color.White);
                        mini.Con.Print(46, 17 + i, playerSkills[i].Exp.ToString().PadLeft(8), mouseHovering ? Color.Yellow : Color.White);
                    }
                }
            }
        }

        public void LocationDraw(UI_EmbeddedMini mini) { 
            Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;

            if (Atlas.ContainsKey(player.NavLoc)) {
                Location curr = Atlas[player.NavLoc];

                mini.Con.Print(57, 0, curr.DisplayName.Align(HorizontalAlignment.Center, 92));
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
                        if (Atlas.ContainsKey(curr.ConnectedLocations[i])) {
                            Location dest = Atlas[curr.ConnectedLocations[i]];
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
                            mini.Con.Print(57, printY++, "| " + curr.ConnectedLocations[i], Color.DarkSlateGray);
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

                                Log.AddMessage(new ColoredString(thisOne.Name + " hit you for " + dmg + "!", Color.Crimson, Color.Black));

                                bool died = player.TakeDamage(dmg, Log);

                                if (player.DefenseExpSplit > 0)
                                    player.TryGrantExp("Defense", dmg * player.DefenseExpSplit, Log, RecentlyTrainedSkills);

                                if (player.DefenseExpSplit < 4)
                                    player.TryGrantExp("Constitution", dmg * (4 - player.DefenseExpSplit), Log, RecentlyTrainedSkills);

                                if (died)
                                    break;
                            }
                        }

                        if (AttackingMonster != null && LastHitTime + 1000 < Helper.Time() && AttackingMonster.CurrentHP > 0) {
                            LastHitTime = Helper.Time();
                            AttackingMonster.AttackingPlayer = true;

                            int pdmg = GoRogue.DiceNotation.Dice.Roll(player.GetDamageDice());

                            if (player.GetDamageType() == AttackingMonster.WeakType)
                                pdmg = (int)Math.Ceiling(pdmg * 1.5f);

                            AttackingMonster.CurrentHP -= pdmg;

                            if (player.OffenseExpSplit > 0)
                                player.TryGrantExp("Attack", pdmg * player.OffenseExpSplit, Log, RecentlyTrainedSkills);

                            if (player.DefenseExpSplit < 4)
                                player.TryGrantExp("Strength", pdmg * (4 - player.OffenseExpSplit), Log, RecentlyTrainedSkills);

                            if (AttackingMonster.CurrentHP <= 0) {
                                AttackingMonster.TimeLastKilled = Helper.Time();
                                AttackingMonster.AttackingPlayer = false;

                                if (!player.CollectionLog.ContainsKey(AttackingMonster.ID))
                                    player.CollectionLog.Add(AttackingMonster.ID, new(AttackingMonster.ID));

                                player.CollectionLog[AttackingMonster.ID].KillCount += 1;

                                if (AttackingMonster.DropTable != null && AttackingMonster.DropTable.Count > 0) {
                                    for (int j = 0; j < AttackingMonster.DropTable.Count; j++) {
                                        ItemDrop drop = AttackingMonster.DropTable[j];

                                        if (GameLoop.rand.Next(drop.InY) < drop.DropX) {
                                            if (!player.CollectionLog[AttackingMonster.ID].DropsObtained.ContainsKey(drop.ItemID))
                                                player.CollectionLog[AttackingMonster.ID].DropsObtained.Add(drop.ItemID, 0);
                                            player.CollectionLog[AttackingMonster.ID].DropsObtained[drop.ItemID] += 1;

                                            if (ItemLibrary.ContainsKey(drop.ItemID)) {
                                                Item spawn = Helper.Clone(ItemLibrary[drop.ItemID]);

                                                if (drop.QuantityMin == drop.QuantityMax)
                                                    spawn.Quantity = drop.QuantityMin;
                                                else {
                                                    int amt = GameLoop.rand.Next(drop.QuantityMax - drop.QuantityMin) + drop.QuantityMin;
                                                }

                                                curr.ItemsHere.Add(spawn);
                                            }
                                        }
                                    }
                                }
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
                        });
                    }
                }


                int resourceX = 110;

                mini.Con.DrawLine(new Point(resourceX, resourceY), new Point(resourceX, 34), 179);

                if (curr.IsBank)
                    mini.Con.PrintClickable(resourceX + 2, resourceY, new ColoredString("B", SelectedMenu == "Items" ? Color.Yellow : player.BankedItems.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Items"; });
                else
                    mini.Con.PrintClickable(resourceX + 2, resourceY, new ColoredString("I", SelectedMenu == "Items" ? Color.Yellow : curr.ItemsHere.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Items"; });
                
                
                mini.Con.Print(resourceX + 4, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 6, resourceY, new ColoredString("N", SelectedMenu == "NPCs" ? Color.Yellow : curr.NPCsHere.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "NPCs"; });
                mini.Con.Print(resourceX + 8, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 10, resourceY, new ColoredString("P", SelectedMenu == "Processing" ? Color.Yellow : curr.ProcessingStations.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Processing"; });
                mini.Con.Print(resourceX + 12, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 14, resourceY, new ColoredString("R", SelectedMenu == "Resources" ? Color.Yellow : curr.LocalGathers.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Resources"; });
                mini.Con.Print(resourceX + 16, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 18, resourceY, new ColoredString("C", SelectedMenu == "Chat" ? Color.Yellow : ConversationPartner != null ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Chat"; });
                mini.Con.Print(resourceX + 20, resourceY, "|");
                mini.Con.PrintClickable(resourceX + 22, resourceY, new ColoredString("S", SelectedMenu == "Shop" ? Color.Yellow : curr.ShopItemsHere.Count > 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { SelectedMenu = "Shop"; });


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
                                if (tile.CanGather(player)) {
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
                    if (curr.IsBank) {
                        mini.Con.Print(resourceX + 2, resourceY++, "Items in Bank"); 
                        ActivityItemTop = Math.Clamp(ActivityItemTop, 0, player.BankedItems.Count);

                        if (ActivityRect.Contains(mousePos)) {
                            if (Helper.ScrolledUp()) { ActivityItemTop = Math.Clamp(ActivityItemTop - 1, 0, player.BankedItems.Count); }
                            if (Helper.ScrolledDown()) { ActivityItemTop = Math.Clamp(ActivityItemTop + 1, 0, player.BankedItems.Count); }
                        }

                        if (player.BankedItems.Count > 0) {
                            for (int i = ActivityItemTop; i < player.BankedItems.Count && i < ActivityItemTop + 22; i++) { 
                                Item item = player.BankedItems[i];

                                string name = item.Name;
                                if (name.Length > 20)
                                    name = name[..20];

                                bool picked = false;

                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.PrintClickable(resourceX + 4, resourceY, name, () => { if (player.TryPickup(item)) { player.BankedItems.RemoveAt(i); picked = true; } });
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
                                if (name.Length > 20)
                                    name = name[..20];

                                bool picked = false;

                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.PrintClickable(resourceX + 4, resourceY, name, () => { if (player.TryPickup(item)) { curr.ItemsHere.RemoveAt(i); picked = true; } });
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

                    if (curr.ProcessingStations.Count > 0) {
                        for (int i = 0; i < curr.ProcessingStations.Count; i++) {
                            if (ProcessingStations.ContainsKey(curr.ProcessingStations[i])) {
                                ProcessingStation station = ProcessingStations[curr.ProcessingStations[i]];
                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.PrintClickable(resourceX + 4, resourceY++, station.Name, () => { station.TryProcessItem(player, Log, ItemLibrary, RecentlyTrainedSkills); });
                            }
                            else {
                                mini.Con.Print(resourceX + 2, resourceY, "|");
                                mini.Con.Print(resourceX + 4, resourceY++, curr.ProcessingStations[i], Color.DarkSlateGray);
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

                                mini.Con.PrintClickable(resourceX + 2, resourceY, "| " + thisOne.Name, () => {
                                    CurrDialogueStage = 0;
                                    ConversationPartner = thisOne;

                                    if (ConversationPartner.Dialogue.ContainsKey(CurrDialogueStage)) {
                                        Log.AddMessage(ConversationPartner.Name + ": " + ConversationPartner.Dialogue[CurrDialogueStage].Text);
                                    }

                                    SelectedMenu = "Chat";
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
                                    mini.Con.Print(resourceX + 2, resourceY, "|");
                                    mini.Con.PrintClickable(resourceX + 4, resourceY++, choice.Text, () => {
                                        CurrDialogueStage = choice.LeadsToStage;

                                        if (ConversationPartner.Dialogue.ContainsKey(CurrDialogueStage)) {
                                            Log.AddMessage(ConversationPartner.Name + ": " + ConversationPartner.Dialogue[CurrDialogueStage].Text);
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
                                mini.Con.Print(resourceX + 4, resourceY, shop.Name + " (" + shop.Value + "gp)");

                                if (shop.Stackable) {
                                    mini.Con.PrintClickable(141, resourceY, "1", () => {
                                        if (player.HeldGold >= shop.Value) {
                                            player.HeldGold -= shop.Value;
                                            player.TryPickup(shop);
                                        }
                                        else {
                                            Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                        }
                                    });

                                    mini.Con.PrintClickable(143, resourceY, "10", () => {
                                        if (player.HeldGold >= shop.Value * 10) {
                                            player.HeldGold -= shop.Value * 10;
                                            shop.Quantity = 10;
                                            player.TryPickup(shop);
                                        }
                                        else {
                                            Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                        }
                                    });

                                    mini.Con.PrintClickable(146, resourceY, "50", () => {
                                        if (player.HeldGold >= shop.Value * 50) {
                                            player.HeldGold -= shop.Value * 50;
                                            shop.Quantity = 50;
                                            player.TryPickup(shop);
                                        }
                                        else {
                                            Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
                                        }
                                    });
                                }
                                else {
                                    mini.Con.PrintClickable(146, resourceY, "1", () => {
                                        if (player.HeldGold >= shop.Value) {
                                            player.HeldGold -= shop.Value;
                                            player.TryPickup(shop);
                                        }
                                        else {
                                            Log.AddMessage(new ColoredString("You don't have enough gold to buy that!", Color.Crimson, Color.Black));
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


            if (TimeLastTicked + 1000 < Helper.Time()) {
                TickTime();
            }
        }

        List<string> activityTabs = new() { "Items", "NPCs", "Processing", "Resources", "Chat", "Shop" };

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

                Close(mini);
            }

            if (mousePos.Y > 34) {
                if (Helper.ScrolledUp()) { Log.TopIndex = Math.Clamp(Log.TopIndex - 1, 0, Log.Log.Count); }
                if (Helper.ScrolledDown()) { Log.TopIndex = Math.Clamp(Log.TopIndex + 1, 0, Log.Log.Count); }
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
            }

            if (Helper.HotkeyDown(Key.F1)) {
                Guide.IsVisible = !Guide.IsVisible;
            }

            if (GameHost.Instance.Mouse.RightClicked) {
                Log.AddMessage(mousePos.ToString());
            }
        }

        public void Close(UI_EmbeddedMini mini) {
            Reset();
            mini.Toggle();
        }

        public void Reset() {

        }


        public void ManualSave() {
            GameLoop.SaveFile.zpoPlayer = Helper.Clone(player);
            GameLoop.ManualSave();

            SecondsSinceAutosave = 0;

            Log.AddMessage("Player data saved!");
        }

        public void TickTime() {
            TimeLastTicked = Helper.Time();

            SecondsSinceAutosave++;

            if (SecondsSinceAutosave >= 600) {
                GameLoop.SaveFile.zpoPlayer = Helper.Clone(player);
                GameLoop.ManualSave();

                SecondsSinceAutosave = 0;

                Log.AddMessage("Player autosave complete.");
            }
        }

        public void UseItem(Item item) {
            if (item.UseString == "GetGold") {
                player.HeldGold += item.UseInt; 
                Log.AddMessage("You open the " + item.Name + " and find 5 gold pieces.");
            } else if (item.UseString == "Bones") {
                Log.AddMessage("You bury the " + item.Name.ToLowerInvariant() + " and get " + item.UseInt + " prayer experience.");
                player.TryGrantExp("Prayer", 5, Log, RecentlyTrainedSkills);
            } else if (item.UseString == "Heal") {
                player.CurrentHP = Math.Clamp(player.CurrentHP + item.UseInt, player.CurrentHP, player.Skills["Constitution"].Level);
                Log.AddMessage(new ColoredString("You eat the " + item.Name.ToLowerInvariant() + " and recover some hitpoints.", Color.Goldenrod, Color.Black));
            }
        }
    }
}
