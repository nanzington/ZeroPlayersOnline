using System.Security.Cryptography.X509Certificates;
using ZeroPlayersOnline.DataTypes;
using Key = SadConsole.Input.Keys;

namespace ZeroPlayersOnline.UI {
    public class MainMenu : MiniDream {
        public Stream menuXP;
        public SadRex.Image menuImage;

        public Console menuBackdrop;

        public string MenuMode = "Main";
        public string TypingBox = "";

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

                mini.Con.Print(28, 13, "Grand Exchange:");
                mini.Con.PrintClickable(44, 13, new ColoredString("Full", GameLoop.ZPO.player.GrandExchangeMode == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.GrandExchangeMode = 0; });
                mini.Con.PrintClickable(49, 13, new ColoredString("Bronze", GameLoop.ZPO.player.GrandExchangeMode == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.GrandExchangeMode = 1; });
                mini.Con.PrintClickable(56, 13, new ColoredString("None", GameLoop.ZPO.player.GrandExchangeMode == 2 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.GrandExchangeMode = 2; });

                mini.Con.Print(29, 14, "Death Penalty:");
                mini.Con.PrintClickable(44, 14, new ColoredString("None", GameLoop.ZPO.player.DeathMode == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DeathMode = 0; });
                mini.Con.PrintClickable(49, 14, new ColoredString("Drop Inv", GameLoop.ZPO.player.DeathMode == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DeathMode = 1; });
                mini.Con.PrintClickable(58, 14, new ColoredString("Permadeath", GameLoop.ZPO.player.DeathMode == 2 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DeathMode = 2; });

                mini.Con.PrintClickableBool(27, 15, "Instadeath Mode: ", ref GameLoop.ZPO.player.NightmareMode);

                mini.Con.Print(28, 16, "Exp Multiplier:");
                mini.Con.PrintClickable(28 + 16, 16, new ColoredString("0", GameLoop.ZPO.player.ExpMultiplier == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 0; });
                mini.Con.PrintClickable(28 + 18, 16, new ColoredString("1", GameLoop.ZPO.player.ExpMultiplier == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 1; });
                mini.Con.PrintClickable(28 + 20, 16, new ColoredString("2", GameLoop.ZPO.player.ExpMultiplier == 2 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 2; });
                mini.Con.PrintClickable(28 + 22, 16, new ColoredString("5", GameLoop.ZPO.player.ExpMultiplier == 5 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 5; });
                mini.Con.PrintClickable(28 + 24, 16, new ColoredString("10", GameLoop.ZPO.player.ExpMultiplier == 10 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.ExpMultiplier = 10; });


                mini.Con.Print(27, 17, "GP to Buy 1 EXP:");
                mini.Con.PrintClickable(28 + 16, 17, new ColoredString("0", GameLoop.ZPO.player.PayToWin == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 0; });
                mini.Con.PrintClickable(28 + 18, 17, new ColoredString("1", GameLoop.ZPO.player.PayToWin == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 1; });
                mini.Con.PrintClickable(28 + 20, 17, new ColoredString("2", GameLoop.ZPO.player.PayToWin == 2 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 2; });
                mini.Con.PrintClickable(28 + 22, 17, new ColoredString("5", GameLoop.ZPO.player.PayToWin == 5 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 5; });
                mini.Con.PrintClickable(28 + 24, 17, new ColoredString("10", GameLoop.ZPO.player.PayToWin == 10 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.PayToWin = 10; });

                mini.Con.PrintClickableBool(27, 18, "Only Pay to Win: ", ref GameLoop.ZPO.player.OnlyPayToWin);
                 
                mini.Con.Print(27, 19, "Drop Multiplier:");
                mini.Con.PrintClickable(28 + 16, 19, new ColoredString("0", GameLoop.ZPO.player.DropMultiplier == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 0; });
                mini.Con.PrintClickable(28 + 18, 19, new ColoredString("1", GameLoop.ZPO.player.DropMultiplier == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 1; });
                mini.Con.PrintClickable(28 + 20, 19, new ColoredString("2", GameLoop.ZPO.player.DropMultiplier == 2 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 2; });
                mini.Con.PrintClickable(28 + 22, 19, new ColoredString("5", GameLoop.ZPO.player.DropMultiplier == 5 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 5; });
                mini.Con.PrintClickable(28 + 24, 19, new ColoredString("10", GameLoop.ZPO.player.DropMultiplier == 10 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.DropMultiplier = 10; });
                 
                mini.Con.PrintScrollableInteger(21, 20, "Max Kills Per Monster: ", ref GameLoop.ZPO.player.KillLimit, false, -1);

                mini.Con.Print(27, 21, "Item Randomizer:");
                mini.Con.PrintClickable(44, 21, new ColoredString("Off", GameLoop.ZPO.player.RandomItems == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomItems = 0; });
                mini.Con.PrintClickable(48, 21, new ColoredString("No Logic", GameLoop.ZPO.player.RandomItems == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomItems = 1; });
                mini.Con.PrintClickable(57, 21, new ColoredString("No Logic+", GameLoop.ZPO.player.RandomItems == 2 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomItems = 2; });

                mini.Con.Print(23, 22, "Location Randomizer:");
                mini.Con.PrintClickable(44, 22, new ColoredString("Off", GameLoop.ZPO.player.RandomLocs == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomLocs = 0; });
                mini.Con.PrintClickable(48, 22, new ColoredString("No Logic", GameLoop.ZPO.player.RandomLocs == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomLocs = 1; });

                mini.Con.Print(22, 23, "Gathering Randomizer:");
                mini.Con.PrintClickable(44, 23, new ColoredString("Off", GameLoop.ZPO.player.RandomGathering == 0 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomGathering = 0; });
                mini.Con.PrintClickable(48, 23, new ColoredString("No Logic", GameLoop.ZPO.player.RandomGathering == 1 ? Color.Lime : Color.DarkSlateGray, Color.Black), () => { GameLoop.ZPO.player.RandomGathering = 1; });




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
    }
}
