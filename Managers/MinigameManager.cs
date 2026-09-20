using System;
using System.Collections.Generic;
using System.Text;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.UI;

namespace ZeroPlayersOnline.Managers {
    public static class MinigameManager {
        public static int MTA_Count, MTA_Orbs, MTA_FruitCount, MTA_CoinCount, MTA_FreeAlch, MTA_TelePos, MTA_TeleWidth, MTA_MazeCount = 0;
        public static string MTA_Special = "Icosahedron";
        public static double MTA_Timer, MTA_BoneTimer = 0; 
        public static List<string> MTA_Types = ["Icosahedron", "Cube", "Pentamid", "Cylinder"];
        public static List<string> MTA_Bones = [ "mtaBone1", "mtaBone2", "mtaBone3", "mtaBone4" ];
        public static List<string> MTA_Alchs = [ "mtaAlch1", "mtaAlch2", "mtaAlch3", "mtaAlch4", "mtaAlch5" ]; 
        public static MTA_Map? MTA_TeleMap = null; 
            
        

        public static void Draw(UI_EmbeddedMini mini, Player player, int resX, int resY) { 
            if (GameLoop.ZPO.Atlas.TryGetValue(player.NavLoc, out Location? curr) && curr != null && curr.MinigameID is string minigame && minigame != "") {
                if (minigame == "MageEnchanting") {
                    mini.Con.Print(resX + 2, resY, "Pizazz: " + player.PizazzTelekinetic + "t " + player.PizazzGraveyard + "g " + player.PizazzEnchantment + "e " + player.PizazzAlchemist + "a");
                    
                    mini.Con.Print(resX + 2, resY + 2, "Current Shape: " + MTA_Special); 
                    mini.Con.Print(resX + 2, resY + 4, "Enchant Streak: " + MTA_Count);
                    mini.Con.Print(resX + 2, resY + 6, "Orb Count: " + MTA_Orbs); 
                }

                if (minigame == "MageGraveyard") {
                    mini.Con.Print(resX + 2, resY, "Pizazz: " + player.PizazzTelekinetic + "t " + player.PizazzGraveyard + "g " + player.PizazzEnchantment + "e " + player.PizazzAlchemist + "a");
                    
                    mini.Con.Print(resX + 2, resY + 2, " Best Bone: " + GameLoop.ZPO.ResolveItemName(MTA_Bones[3]));
                    mini.Con.Print(resX + 2, resY + 3, " Good Bone: " + GameLoop.ZPO.ResolveItemName(MTA_Bones[2]));
                    mini.Con.Print(resX + 2, resY + 4, " Okay Bone: " + GameLoop.ZPO.ResolveItemName(MTA_Bones[1]));
                    mini.Con.Print(resX + 2, resY + 5, "Worst Bone: " + GameLoop.ZPO.ResolveItemName(MTA_Bones[0])); 
                    mini.Con.Print(resX + 2, resY + 7, "Fruit Count: " + MTA_FruitCount);
                }

                if (minigame == "MageAlchemist") {
                    mini.Con.Print(resX + 2, resY, "Pizazz: " + player.PizazzTelekinetic + "t " + player.PizazzGraveyard + "g " + player.PizazzEnchantment + "e " + player.PizazzAlchemist + "a");
                    
                    mini.Con.Print(resX + 2, resY + 2, "30 gp: " + GameLoop.ZPO.ResolveItemName(MTA_Alchs[4]), MTA_FreeAlch == 4 ? Color.Lime : Color.White);
                    mini.Con.Print(resX + 2, resY + 3, "15 gp: " + GameLoop.ZPO.ResolveItemName(MTA_Alchs[3]), MTA_FreeAlch == 3 ? Color.Lime : Color.White);
                    mini.Con.Print(resX + 2, resY + 4, " 8 gp: " + GameLoop.ZPO.ResolveItemName(MTA_Alchs[2]), MTA_FreeAlch == 2 ? Color.Lime : Color.White);
                    mini.Con.Print(resX + 2, resY + 5, " 5 gp: " + GameLoop.ZPO.ResolveItemName(MTA_Alchs[1]), MTA_FreeAlch == 1 ? Color.Lime : Color.White);
                    mini.Con.Print(resX + 2, resY + 6, " 1 gp: " + GameLoop.ZPO.ResolveItemName(MTA_Alchs[0]), MTA_FreeAlch == 0 ? Color.Lime : Color.White);  
                    mini.Con.Print(resX + 2, resY + 8, "Coin Count: " + MTA_CoinCount);

                    mini.Con.Print(resX + 2, resY + 10, "Free to Alch: " + GameLoop.ZPO.ResolveItemName(MTA_Alchs[MTA_FreeAlch]));
                }

                if (minigame == "MageTelekinetic") { 
                    mini.Con.Print(resX + 2, resY, "Pizazz: " + player.PizazzTelekinetic + "t " + player.PizazzGraveyard + "g " + player.PizazzEnchantment + "e " + player.PizazzAlchemist + "a");
                    mini.Con.Print(resX + 2, resY + 2, "Mazes Solved: " + MTA_MazeCount); 

                    if (MTA_TeleMap != null) {
                        for(int i = 0; i < MTA_TeleMap.Map.Length; i++) {
                            int x = i % MTA_TeleMap.Width;
                            int y = i / MTA_TeleMap.Width;

                            if (i == MTA_TelePos) {
                                mini.Con.Print(resX + 2 + x, resY + 4 + y, "@", Color.Turquoise);
                            } else {
                                mini.Con.Print(resX + 2 + x, resY + 4 + y, MTA_TeleMap.Map[i].ToString(), i == MTA_TeleMap.GoalIdx ? Color.Lime : Color.DarkSlateGray);
                            }
                        }

                        if (GameLoop.ZPO.SpellLibrary.TryGetValue("utilTelegrab", out Spell? telegrab) && telegrab != null) {
                            if (MTA_TeleMap.TileAt(MTA_TelePos - MTA_TeleMap.Width) == "_" && player.CanCast(telegrab) == "") { 
                                mini.Con.PrintClickable(resX + 14 , resY + 5, "Pull Statue North", () => {
                                    telegrab.Cast(player, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);

                                    while (MTA_TeleMap.TileAt(MTA_TelePos - MTA_TeleMap.Width) == "_") {
                                        MTA_TelePos -= MTA_TeleMap.Width;
                                    }
                                });
                            } else {
                                mini.Con.Print(resX + 14 , resY + 5, "Pull Statue North", Color.DarkSlateGray);
                            }

                            if (MTA_TeleMap.TileAt(MTA_TelePos + 1) == "_" && player.CanCast(telegrab) == "") { 
                                mini.Con.PrintClickable(resX + 14 , resY + 7, "Pull Statue East", () => {
                                    telegrab.Cast(player, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);

                                    while (MTA_TeleMap.TileAt(MTA_TelePos + 1) == "_") {
                                        MTA_TelePos += 1;
                                    }
                                });
                            } else {
                                mini.Con.Print(resX + 14 , resY + 7, "Pull Statue East", Color.DarkSlateGray);
                            }

                            if (MTA_TeleMap.TileAt(MTA_TelePos - 1) == "_" && player.CanCast(telegrab) == "") { 
                                mini.Con.PrintClickable(resX + 14 , resY + 9, "Pull Statue West", () => {
                                    telegrab.Cast(player, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);

                                    while (MTA_TeleMap.TileAt(MTA_TelePos - 1) == "_") {
                                        MTA_TelePos -= 1;
                                    }
                                });
                            } else {
                                mini.Con.Print(resX + 14 , resY + 9, "Pull Statue West", Color.DarkSlateGray);
                            }

                            if (MTA_TeleMap.TileAt(MTA_TelePos + MTA_TeleMap.Width) == "_" && player.CanCast(telegrab) == "") { 
                                mini.Con.PrintClickable(resX + 14 , resY + 11, "Pull Statue South", () => {
                                    telegrab.Cast(player, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);

                                    while (MTA_TeleMap.TileAt(MTA_TelePos + MTA_TeleMap.Width) == "_") {
                                        MTA_TelePos += MTA_TeleMap.Width;
                                    }
                                });
                            } else {
                                mini.Con.Print(resX + 14 , resY + 11, "Pull Statue South", Color.DarkSlateGray);
                            }
                        } else { 
                            mini.Con.Print(resX + 14 , resY + 5, "Pull Statue North", Color.DarkSlateGray);
                            mini.Con.Print(resX + 14 , resY + 7, "Pull Statue East", Color.DarkSlateGray);
                            mini.Con.Print(resX + 14 , resY + 9, "Pull Statue West", Color.DarkSlateGray);
                            mini.Con.Print(resX + 14 , resY + 11, "Pull Statue South", Color.DarkSlateGray);
                        } 

                        mini.Con.PrintClickable(resX + 2 , resY + 15, "Reset Maze", () => { MTA_TelePos = MTA_TeleMap.StartIdx;  });
                        mini.Con.PrintClickable(resX + 2 , resY + 17, "  New Maze", () => { MTA_SetupTeleMap(); });

                        if (MTA_TelePos == MTA_TeleMap.GoalIdx) {
                            MTA_MazeCount++;
                            if (MTA_MazeCount >= 5) {
                                GameLoop.ZPO.Log.AddMessage("You have completed five mazes and receive 10 Telekinetic Pizazz points, 1200 Magic Experience, and 10 law runes.", Color.Lime);
                                player.TryGrantExp("Magic", 1200, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
                                player.PizazzTelekinetic += 10;

                                if (GameLoop.ZPO.ItemLibrary.TryGetValue("runeLaw", out Item? law) && law != null) {
                                    player.TryPickup(new Item(law), 10);
                                }
                                MTA_MazeCount = 0;
                            } else {
                                GameLoop.ZPO.Log.AddMessage("You have moved the statue to the goal tile, and gain 2 Telekinetic Pizazz points and 200 Magic experience.", Color.Lime);
                                player.TryGrantExp("Magic", 200, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
                                player.PizazzTelekinetic += 2;
                            }
                            MTA_SetupTeleMap();
                        }
                    } else {
                        MTA_SetupTeleMap();
                    }
                }
            }
        }

        public static void MTA_SetupTeleMap(int force = -1) {
            MTA_Map blank = new(10, 88, 81, 
                "xxxxxxxxxx" + 
                "x________x" + 
                "x________x" +
                "x________x" +
                "x________x" +
                "x________x" +
                "x________x" +
                "x________x" +
                "x________x" +
                "xxxxxxxxxx");
            List<MTA_Map> Maps = new() {
                new(10, 88, 81, 
                "xxxxxxxxxx" + 
                "x_x______x" + 
                "x_____x__x" +
                "x__x_____x" +
                "x_x_____xx" +
                "x_x__x___x" +
                "x_xx_____x" +
                "x_x______x" +
                "x_x______x" +
                "xxxxxxxxxx"),
                new(10, 66, 23, 
                "xxxxxxxxxx" + 
                "x__x_____x" + 
                "x________x" +
                "x_______xx" +
                "x___x____x" +
                "x_x___x__x" +
                "x____x___x" +
                "xx__x____x" +
                "x________x" +
                "xxxxxxxxxx"),
                new(10, 18, 11, 
                "xxxxxxxxxx" + 
                "x__x___x_x" + 
                "x__x_x___x" +
                "x_x____x_x" +
                "x__x_____x" +
                "x_x__x___x" +
                "x__x___x_x" +
                "x_x______x" +
                "x____x___x" +
                "xxxxxxxxxx"),
                new(10, 44, 61, 
                "xxxxxxxxxx" + 
                "x________x" + 
                "x_xx_xxx_x" +
                "x_xx_x_x_x" +
                "x____x_x_x" +
                "xxxxxxxx_x" +
                "x_xx_____x" +
                "x_xx_xxxxx" +
                "x____x___x" +
                "xxxxxxxxxx"),
                new(10, 34, 28, 
                "xxxxxxxxxx" + 
                "xx____xxxx" + 
                "x______x_x" +
                "x_x__x_x_x" +
                "x_x__x_x_x" +
                "x______x_x" +
                "x__x_____x" +
                "x________x" +
                "xx_____xxx" +
                "xxxxxxxxxx"),
                new(10, 88, 11, 
                "xxxxxxxxxx" + 
                "x_x____x_x" + 
                "x__x___x_x" +
                "x______x_x" +
                "x______x_x" +
                "x_x______x" +
                "xxxxxxx__x" +
                "x_______xx" +
                "x________x" +
                "xxxxxxxxxx"),
                new(10, 26, 87, 
                "xxxxxxxxxx" + 
                "x________x" + 
                "x______x_x" +
                "x__x_____x" +
                "x_x___x_xx" +
                "x________x" +
                "xx__x__x_x" +
                "x_x______x" +
                "x_______xx" +
                "xxxxxxxxxx"),
                new(10, 48, 38, 
                "xxxxxxxxxx" + 
                "x_______xx" + 
                "x___x__x_x" +
                "xx___x___x" +
                "x__x_____x" +
                "x_x_____xx" +
                "x____x___x" +
                "x_______xx" +
                "xx_______x" +
                "xxxxxxxxxx"),
                new(10, 81, 18, 
                "xxxxxxxxxx" + 
                "x________x" + 
                "x_xxxxxxxx" +
                "x________x" +
                "x_xxxxx_xx" +
                "x_x_____xx" +
                "x_x______x" +
                "xxxxxxxx_x" +
                "x________x" +
                "xxxxxxxxxx"),
                new(10, 46, 83, 
                "xxxxxxxxxx" + 
                "x__xxxx__x" + 
                "xx____x__x" +
                "x_____x_xx" +
                "x_x__x___x" +
                "x________x" +
                "x_x______x" +
                "x__x_____x" +
                "x___x_x__x" +
                "xxxxxxxxxx"),
                new(10, 14, 81, 
                "xxxxxxxxxx" + 
                "x__x_____x" + 
                "x_______xx" +
                "x___x____x" +
                "x_x___xxxx" +
                "x__x_____x" +
                "xxxx___x_x" +
                "x___xxxx_x" +
                "x________x" +
                "xxxxxxxxxx")
            };

            MTA_TeleMap = Maps[force != -1 ? force : GameLoop.rand.Next(Maps.Count)];
            MTA_TelePos = MTA_TeleMap.StartIdx;
            MTA_TeleWidth = MTA_TeleMap.Width;
        }
    }
}
