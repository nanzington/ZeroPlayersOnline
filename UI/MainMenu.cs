using System.Security.Cryptography.X509Certificates;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.Hardcodes;
using Key = SadConsole.Input.Keys;

namespace ZeroPlayersOnline.UI {
    public class MainMenu : MiniDream {
        public Stream menuXP;
        public SadRex.Image menuImage;

        public Console menuBackdrop;

        public string MenuMode = "Main";
        public string TypingBox = "";


        public List<Particle> LeftParticles = new();
        public List<Particle> RightParticles = new(); 

        public void Update(UI_EmbeddedMini mini) {
            mini.Con.Clear();
            mini.SingleSquare.Clear();


            //Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;   


            int offX = 16;
            int offY = 2;


            // ZERO 
             
            mini.SingleSquare.Print(offX, offY, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 4, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX, offY + 2, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 3, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX, offY + 4, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 4, offY + 4, "X", Color.White, Color.Black);
             
            mini.SingleSquare.Print(offX + 6, offY, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 10, offY, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 6, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 10, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 6, offY + 2, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 10, offY + 2, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 6, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 10, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 6, offY + 4, "XXXXX", Color.White, Color.Black);
             
            mini.SingleSquare.Print(offX + 12, offY, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 16, offY, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 12, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 13, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 16, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 12, offY + 2, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 14, offY + 2, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 16, offY + 2, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 12, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 15, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 16, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 12, offY + 4, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 16, offY + 4, "X", Color.White, Color.Black);
             
            mini.SingleSquare.Print(offX + 18, offY, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 18, offY + 1, "X", Color.White, Color.Black); 
            mini.SingleSquare.Print(offX + 18, offY + 2, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 18, offY + 3, "X", Color.White, Color.Black); 
            mini.SingleSquare.Print(offX + 18, offY + 4, "XXXXX", Color.White, Color.Black);
             
            mini.SingleSquare.Print(offX + 24, offY, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 24, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 24, offY + 2, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 28, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 24, offY + 4, "XXXXX", Color.White, Color.Black);
             
            mini.SingleSquare.Print(offX + 30, offY, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 30, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 30, offY + 2, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 30, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 30, offY + 4, "XXXXX", Color.White, Color.Black);

            mini.SingleSquare.Print(offX + 36, offY, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 36, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 40, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 36, offY + 2, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 36, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 40, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 36, offY + 4, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 40, offY + 4, "X", Color.White, Color.Black);

            mini.SingleSquare.Print(offX + 42, offY, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 42, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 46, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 42, offY + 2, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 42, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 42, offY + 4, "X", Color.White, Color.Black);

            mini.SingleSquare.Print(offX + 48, offY, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 48, offY + 1, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 48, offY + 2, "XXXXX", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 48, offY + 3, "X", Color.White, Color.Black);
            mini.SingleSquare.Print(offX + 48, offY + 4, "XXXXX", Color.White, Color.Black);


            if (LeftParticles.Count < 100) {
                int randColor = GameLoop.rand.Next(3);
                Color col = randColor == 0 ? Color.Red : randColor == 1 ? Color.Orange : Color.Yellow;
                LeftParticles.Add(new(GameLoop.rand.Next(18), 24, '\\', col.R, col.G, col.B));
            }

            foreach (var pL in LeftParticles) {
                mini.Con.Print(pL.X, pL.Y, pL.Glyph.AsString(), new Color(pL.R, pL.G, pL.B));

                if (pL.LastMoved + 200 < Helper.Time()) {
                    pL.Y -= 1;
                    pL.LastMoved = Helper.Time();


                    int randGlyph = GameLoop.rand.Next(3);

                    pL.Glyph = randGlyph == 0 ? '\\' : randGlyph == 1 ? '/' : '-';
                }
            }


            for (int i = LeftParticles.Count - 1; i >= 0; i--) {
                int distFromMiddle = LeftParticles[i].X - 9;
                if (distFromMiddle < 0)
                    distFromMiddle *= -1;

                if (LeftParticles[i].Y < 15 + distFromMiddle) {
                    LeftParticles.RemoveAt(i);
                }
            }

            if (RightParticles.Count < 100) {
                int randColor = GameLoop.rand.Next(3);
                Color col = randColor == 0 ? Color.Red : randColor == 1 ? Color.Orange : Color.Yellow;
                RightParticles.Add(new(129 + GameLoop.rand.Next(18), 24, '\\', col.R, col.G, col.B));
            }

            foreach (var pL in RightParticles) {
                mini.Con.Print(pL.X, pL.Y, pL.Glyph.AsString(), new Color(pL.R, pL.G, pL.B));

                if (pL.LastMoved + 200 < Helper.Time()) {
                    pL.Y -= 1;
                    pL.LastMoved = Helper.Time();


                    int randGlyph = GameLoop.rand.Next(3);

                    pL.Glyph = randGlyph == 0 ? '\\' : randGlyph == 1 ? '/' : '-';
                }
            }


            for (int i = RightParticles.Count - 1; i >= 0; i--) {
                int distFromMiddle = (RightParticles[i].X - 129) - 9;
                if (distFromMiddle < 0)
                    distFromMiddle *= -1;

                if (RightParticles[i].Y < 15 + distFromMiddle) {
                    RightParticles.RemoveAt(i);
                }
            }

            if (MenuMode == "Main") {
                mini.Con.Print(63, 11, "SERVER STATUS:");
                mini.Con.Print(79, 11, "ONLINE", Color.Lime);
                mini.Con.Print(63, 13, "PLAYER COUNT:");
                mini.Con.Print(84, 13, "0", Color.Lime);

                Helper.DrawBox(mini.Con, 63, 15, 20, 20, 255, 255, 255, 0, true);

                mini.Con.PrintClickable(68, 17, "New Character", () => { MenuMode = "Create"; });
                mini.Con.PrintClickable(70, 19, "Load Game", () => { MenuMode = "Load"; });
                mini.Con.PrintClickable(72, 35, "Exit", () => { Environment.Exit(0); });
            } else if (MenuMode == "Create") {  
                Helper.DrawBox(mini.Con, 20, 10, 105, 34, 255, 255, 255, 0, true);

                mini.Con.PrintStringField(38, 11, "Name: ", ref GameLoop.ZPO.player.Name, ref TypingBox, "playerName");

                int printY = 13;

                mini.Con.Print(28, printY, "Grand Exchange:");
                mini.Con.PrintClickable(44, printY, new ColoredString("Full", GameLoop.ZPO.player.GrandExchangeMode == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.GrandExchangeMode = 0; });
                mini.Con.PrintClickable(49, printY, new ColoredString("Bronze", GameLoop.ZPO.player.GrandExchangeMode == 1 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.GrandExchangeMode = 1; });
                mini.Con.PrintClickable(56, printY, new ColoredString("None", GameLoop.ZPO.player.GrandExchangeMode == 2 ? Color.Crimson : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.GrandExchangeMode = 2; });

                printY++;

                mini.Con.Print(29, printY, "Death Penalty:");
                mini.Con.PrintClickable(44, printY, new ColoredString("None", GameLoop.ZPO.player.DeathMode == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DeathMode = 0; });
                mini.Con.PrintClickable(49, printY, new ColoredString("Drop Inv", GameLoop.ZPO.player.DeathMode == 1 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DeathMode = 1; });
                mini.Con.PrintClickable(58, printY, new ColoredString("Permadeath", GameLoop.ZPO.player.DeathMode == 2 ? Color.Red : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DeathMode = 2; });

                printY++;

                mini.Con.Print(27, printY, "Instadeath Mode: "); 
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("Off", !GameLoop.ZPO.player.NightmareMode ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.NightmareMode = false; });
                mini.Con.PrintClickable(28 + 20, printY, new ColoredString("On", GameLoop.ZPO.player.NightmareMode ? (Helper.Time() % 10 < 5 ? Color.Red : Color.White) : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.NightmareMode = true; });

                printY++;

                mini.Con.Print(28, printY, "Exp Multiplier:");
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("0", GameLoop.ZPO.player.ExpMultiplier == 0 ? Color.Red : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 0; });
                mini.Con.PrintClickable(28 + 18, printY, new ColoredString("1", GameLoop.ZPO.player.ExpMultiplier == 1 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 1; });
                mini.Con.PrintClickable(28 + 20, printY, new ColoredString("2", GameLoop.ZPO.player.ExpMultiplier == 2 ? Color.ForestGreen : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 2; });
                mini.Con.PrintClickable(28 + 22, printY, new ColoredString("5", GameLoop.ZPO.player.ExpMultiplier == 5 ? Color.AnsiGreen : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 5; });
                mini.Con.PrintClickable(28 + 24, printY, new ColoredString("10", GameLoop.ZPO.player.ExpMultiplier == 10 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 10; });

                printY++;

                mini.Con.Print(27, printY, "GP to Buy 1 EXP:");
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("0", GameLoop.ZPO.player.PayToWin == 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 0; });
                mini.Con.PrintClickable(28 + 18, printY, new ColoredString("1", GameLoop.ZPO.player.PayToWin == 1 ? Color.DarkRed : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 1; });
                mini.Con.PrintClickable(28 + 20, printY, new ColoredString("2", GameLoop.ZPO.player.PayToWin == 2 ? Color.AnsiRed : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 2; });
                mini.Con.PrintClickable(28 + 22, printY, new ColoredString("5", GameLoop.ZPO.player.PayToWin == 5 ? Color.Crimson : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 5; });
                mini.Con.PrintClickable(28 + 24, printY, new ColoredString("10", GameLoop.ZPO.player.PayToWin == 10 ? Color.Red : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 10; });
                mini.Con.PrintClickable(28 + 27, printY, new ColoredString("100", GameLoop.ZPO.player.PayToWin == 100 ? (Helper.Time() % 10 < 5 ? Color.Red : Color.White) : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 100; });
                mini.Con.PrintClickable(28 + 31, printY, new ColoredString("1000", GameLoop.ZPO.player.PayToWin == 1000 ? Color.AnsiBlackBright : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 1000; });

                printY++;

                mini.Con.PrintClickableBool(27, printY, "Only Pay to Win: ", ref GameLoop.ZPO.player.OnlyPayToWin);
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("OFF", !GameLoop.ZPO.player.OnlyPayToWin ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.OnlyPayToWin = false; });
                mini.Con.PrintClickable(28 + 20, printY, new ColoredString("ON", GameLoop.ZPO.player.OnlyPayToWin ? Color.Crimson : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.OnlyPayToWin = true; });

                printY++;

                mini.Con.Print(27, printY, "Drop Multiplier:");
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("0", GameLoop.ZPO.player.DropMultiplier == 0 ? Color.Red : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 0; });
                mini.Con.PrintClickable(28 + 18, printY, new ColoredString("1", GameLoop.ZPO.player.DropMultiplier == 1 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 1; });
                mini.Con.PrintClickable(28 + 20, printY, new ColoredString("2", GameLoop.ZPO.player.DropMultiplier == 2 ? Color.ForestGreen : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 2; });
                mini.Con.PrintClickable(28 + 22, printY, new ColoredString("5", GameLoop.ZPO.player.DropMultiplier == 5 ? Color.AnsiGreen : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 5; });
                mini.Con.PrintClickable(28 + 24, printY, new ColoredString("10", GameLoop.ZPO.player.DropMultiplier == 10 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 10; });

                printY++;

                mini.Con.PrintScrollableInteger(21, printY, "Max Kills Per Monster: ", ref GameLoop.ZPO.player.KillLimit, false, -1);
                 
                printY++;

                if (GameLoop.ZPO.player.InventoryLimit == 20)
                    mini.Con.PrintScrollableInteger(27, printY, "Inventory Slots: ", ref GameLoop.ZPO.player.InventoryLimit, false, 1, 20);
                else
                    mini.Con.PrintScrollableInteger(27, printY, "Inventory Slots: ", ref GameLoop.ZPO.player.InventoryLimit, false, 1, 20, r: 155 + (20 - GameLoop.ZPO.player.InventoryLimit) * 5, g: 0, b: 0);

                printY++;

                mini.Con.PrintClickableBool(29, printY, "Can Use Banks: ", ref GameLoop.ZPO.player.CanUseBanks);
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("Yes", GameLoop.ZPO.player.CanUseBanks ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.CanUseBanks = true; });
                mini.Con.PrintClickable(28 + 20, printY, new ColoredString("No", !GameLoop.ZPO.player.CanUseBanks ? Color.AnsiRed : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.CanUseBanks = false; });
                 
                printY++;

                mini.Con.PrintClickableBool(29, printY, "Can Use Shops: ", ref GameLoop.ZPO.player.CanUseShops);
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("Yes", GameLoop.ZPO.player.CanUseShops ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.CanUseShops = true; });
                mini.Con.PrintClickable(28 + 20, printY, new ColoredString("No", !GameLoop.ZPO.player.CanUseShops ? Color.Crimson : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.CanUseShops = false; });

                printY++;

                mini.Con.PrintClickableBool(26, printY, "Farm Growth Time: ", ref GameLoop.ZPO.player.CanUseShops);
                mini.Con.PrintClickable(28 + 16, printY, new ColoredString("Slow", GameLoop.ZPO.player.FarmGrowthIncrement == 1 ? Color.Crimson : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.FarmGrowthIncrement = 1; });
                mini.Con.PrintClickable(28 + 21, printY, new ColoredString("Normal", GameLoop.ZPO.player.FarmGrowthIncrement == 60 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.FarmGrowthIncrement = 60; });
                mini.Con.PrintClickable(28 + 28, printY, new ColoredString("Fast", GameLoop.ZPO.player.FarmGrowthIncrement == 1000 ? Color.AnsiGreen : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.FarmGrowthIncrement = 1000; });
                mini.Con.PrintClickable(28 + 33, printY, new ColoredString("Instant", GameLoop.ZPO.player.FarmGrowthIncrement == 10000 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.FarmGrowthIncrement = 10000; });

                printY++;

                mini.Con.Print(27, printY, "Item Randomizer:");
                mini.Con.PrintClickable(44, printY, new ColoredString("Off", GameLoop.ZPO.player.RandomItems == 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomItems = 0; });
                mini.Con.PrintClickable(48, printY, new ColoredString("No Logic", GameLoop.ZPO.player.RandomItems == 1 ? Color.Red : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomItems = 1; });
                mini.Con.PrintClickable(57, printY, new ColoredString("No Logic+", GameLoop.ZPO.player.RandomItems == 2 ? Color.Crimson : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomItems = 2; });

                printY++;

                mini.Con.Print(23, printY, "Location Randomizer:");
                mini.Con.PrintClickable(44, printY, new ColoredString("Off", GameLoop.ZPO.player.RandomLocs == 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomLocs = 0; });
                mini.Con.PrintClickable(48, printY, new ColoredString("No Logic", GameLoop.ZPO.player.RandomLocs == 1 ? Color.Red : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomLocs = 1; });

                printY++;

                mini.Con.Print(22, printY, "Gathering Randomizer:");
                mini.Con.PrintClickable(44, printY, new ColoredString("Off", GameLoop.ZPO.player.RandomGathering == 0 ? Color.White : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomGathering = 0; });
                mini.Con.PrintClickable(48, printY, new ColoredString("No Logic", GameLoop.ZPO.player.RandomGathering == 1 ? Color.Red : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomGathering = 1; });

                printY++;


                mini.Con.Print(22, 40, "White options are considered the default method of play.", Color.White);
                mini.Con.Print(22, 41, "Green options are considered to make the game easier, brighter means even easier.", Color.Lime);
                mini.Con.Print(22, 42, "Red options are considered to make the game harder, and may make the game impossible.", Color.Crimson); 

                mini.Con.PrintClickable(22, 44, "<- Nevermind", () => { MenuMode = "Main"; });

                if (GameLoop.ZPO.player.Name != "") {
                    mini.Con.PrintClickable(107, 44, "Begin Adventure ->", () => { 
                        GameLoop.ZPO.ManualSave(false); 
                        SwapToGame(false);
                    });
                } else {
                    mini.Con.Print(107, 44, "A Hero Needs a Name");
                }
            } else if (MenuMode == "Load") { 
                Helper.DrawBox(mini.Con, 63, 15, 20, 20, 255, 255, 255, 0, true);

                List<string> saves = new();

                if (!Directory.Exists("./saves/"))
                    Directory.CreateDirectory("./saves/"); 

                saves = Directory.GetFiles("./saves/").ToList();

                for (int i = 0; i < saves.Count; i++) {
                    saves[i] = saves[i].Substring(8)[..^5];
                }


                mini.Con.Print(65, 16, "Choose a Character");
                mini.Con.Print(64, 17, "--------------------");

                for (int i = 0; i < 16; i++) {
                    if (saves.Count > i) {
                        mini.Con.PrintClickable(65, 18 + i, saves[i].Align(HorizontalAlignment.Center, 18), () => {
                            Player p = Helper.DeserializeFromFile<Player>("./saves/" + saves[i] + ".json");
                            GameLoop.ZPO.player = p;

                            PerformUpdateMaintenance();

                            SwapToGame(true);
                        });
                    } else {
                        mini.Con.Print(65, 18 + i, "(Empty Save Slot)", Color.DarkSlateGray);
                    }
                }


                mini.Con.Print(64, 34, "--------------------");
                mini.Con.PrintClickable(68, 35, "Back to Menu", () => { MenuMode = "Main"; });
            }
        }

        public void Input(UI_EmbeddedMini mini) {
            /*
            if (Helper.HotkeyDown(Key.Escape)) { 
                GameLoop.UIManager.zpoWrap.Win.IsVisible = true;
                mini.Win.IsVisible = false;
            }*/
        }

        public void Close(UI_EmbeddedMini mini) { 
        }

        public void Reset() {

        }


        public void SetupTheBG(UI_EmbeddedMini mini) {
            menuXP = new FileStream("./loginbg.xp", FileMode.Open);
            menuImage = SadRex.Image.Load(menuXP);


            ColoredGlyph[] cells = new ColoredGlyph[86 * 48];

            for (int i = 0; i < menuImage.Layers[0].Cells.Count && i < 86 * 48; i++) {
                var cell = menuImage.Layers[0].Cells[i];
                Color convertedFG = new(cell.Foreground.R, cell.Foreground.G, cell.Foreground.B);
                Color convertedBG = new(cell.Background.R, cell.Background.G, cell.Background.B);

                cells[i] = new ColoredGlyph(Color.Transparent, convertedFG, menuImage.Layers[0].Cells[i].Character);
            }

            menuBackdrop = new Console(new CellSurface(86, 48, cells), GameLoop.SquareFont, new Point(12, 12));
            menuBackdrop.UsePixelPositioning = true;
            menuBackdrop.Position = new Point(9, 13); 

            mini.Win.Children.Insert(0, menuBackdrop);  

            menuXP.Close();
        }

        public void SwapToGame(bool loading) { 
            if (GameLoop.ZPO.player.RandomItems != 0) {
                GameLoop.ZPO.RemapItems(loading);
            }

            GameLoop.UIManager.mainMenu.Win.IsVisible = false;
            GameLoop.UIManager.zpoWrap.Win.IsVisible = true;
            MenuMode = "Main";
            GameLoop.ZPO.TimeLastTicked = Helper.Time();
        }

        public void PerformUpdateMaintenance() {
            HardcodedFarmPatches.InitPatches(GameLoop.ZPO.player.FarmingPatches);
            GameLoop.ZPO.TryAddSkills();
            GameLoop.ZPO.TryAddPrayers();
            GameLoop.ZPO.TryAddQuests();
        }
    }
}
