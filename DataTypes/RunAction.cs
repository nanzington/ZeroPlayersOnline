using Microsoft.Xna.Framework.Audio;
using ZeroPlayersOnline.HardcodedData;
using ZeroPlayersOnline.Managers;

namespace ZeroPlayersOnline.DataTypes {
    public class RunAction {
        public string ActionID = "";
        public string MiscString = "";
        public string MiscString2 = "";
        public int MiscInt = 0;

        public RunAction(string id, string misc, string misc2, int miscint) {
            ActionID = id;
            MiscString = misc;
            MiscString2 = misc2;
            MiscInt = miscint;
        }

        public void Execute() {
            Player player = GameLoop.ZPO.player;
            MessageLog Log = GameLoop.ZPO.Log;

            if (ActionID != "") {
                if (ActionID == "Quest") {
                    player.TryProgressQuest(MiscString, MiscInt);
                }
                            
                if (ActionID == "Data") {
                    Helper.AlterWorldState(MiscString, MiscString2, MiscInt);
                }

                if (ActionID == "TempSkillBoost") { 
                    player.TryAddPotionEffect(MiscString, MiscInt); 
                }

                if (ActionID == "OpenUI") {
                    if (MiscString == "Shop") {
                        ExtraWindows.Shop.IsVisible = true;
                        ExtraWindows.ShopID = MiscString2;
                        ExtraWindows.BuildShop();
                    }
                }

                if (ActionID == "GiveItem") {
                    if (GameLoop.ZPO.ResolveItem(MiscString) is Item given) {
                        player.TryPickup(given, MiscInt);
                    }
                }

                if (ActionID == "EndDialogue") {
                    GameLoop.ZPO.ConversationPartner = null;
                    GameLoop.ZPO.SelectedMenu = "NPCs";
                }

                if (ActionID == "SlayerTask") {
                    if (MiscString == "Cancel") {
                        player.SlayerTask = "";
                        player.SlayerTaskFrom = "";
                        player.SlayerKillsRemaining = 0;
                        player.SlayerAssignedKills = 0;
                        player.SlayerTaskExtended = false;
                        
                        Log.AddMessage("You have cancelled your current task and may now claim another.", Color.Lime);
                    }

                    if (MiscString == "Block") {
                        int maxBlocked = player.GetQuestPoints() / 50;
                        if (player.SlayerBlocked.Count < maxBlocked) { 
                            if (!player.SlayerBlocked.Contains(player.SlayerTask)) {
                                player.SlayerBlocked.Add(player.SlayerTask);
                                player.SlayerTask = "";
                                player.SlayerTaskFrom = "";
                                player.SlayerKillsRemaining = 0;
                                player.SlayerAssignedKills = 0;
                                player.SlayerTaskExtended = false;
                                Log.AddMessage("You have now blocked that monster from being assigned as a slayer task.", Color.Lime);
                            } else {
                                Log.AddMessage("You have already blocked that monster from being assigned as a slayer task.", Color.Crimson);
                            }
                        } else {
                            Log.AddMessage("You can't block any extra tasks at the moment, you need to unblock some first. Can block " + maxBlocked + ", have blocked " + player.SlayerBlocked.Count + ".", Color.Crimson);
                        }
                    }

                    if (MiscString == "Extend") {
                        int extendCount = (int) Math.Ceiling(player.SlayerAssignedKills * 0.2);
                        player.SlayerKillsRemaining += extendCount;
                        player.SlayerTaskExtended = true;
                        Log.AddMessage("Your task has been extended by " + extendCount + ", leaving you with " + player.SlayerKillsRemaining + " kills left.", Color.Lime);
                    }

                    if (MiscString == "Prefer") {
                        int maxPreferred = player.GetQuestPoints() / 50;
                        if (player.SlayerPrefer.Count < maxPreferred) { 
                            if (!player.SlayerPrefer.Contains(player.SlayerTask)) {
                                player.SlayerPrefer.Add(player.SlayerTask);
                                if (!player.SlayerTaskExtended) {
                                    int extendCount = (int) Math.Ceiling(player.SlayerAssignedKills * 0.2);
                                    player.SlayerKillsRemaining += extendCount;   
                                    player.SlayerTaskExtended = true;

                                    Log.AddMessage("Your task has been preferred and extended by " + extendCount + ", leaving you with " + player.SlayerKillsRemaining + " kills left.", Color.Lime);
                                } else {
                                    Log.AddMessage("Your task has been preferred but had already been extended, so your kills left are unchanged.", Color.Lime);
                                }
                            } else {
                                Log.AddMessage("You have already blocked that monster from being assigned as a slayer task.", Color.Crimson);
                            }
                        } else {
                            Log.AddMessage("You can't block any extra tasks at the moment, you need to unblock some first. Can block " + maxPreferred + ", have preferred " + player.SlayerPrefer.Count + ".", Color.Crimson);
                        }
                    }

                    if (MiscString == "Store") {
                        string swapTask = player.SlayerTask;
                        string swapFrom = player.SlayerTaskFrom;
                        int swapKillsLeft = player.SlayerKillsRemaining;
                        int swapKillsAssigned = player.SlayerAssignedKills;
                        bool swapExtended = player.SlayerTaskExtended;

                        player.SlayerTask = player.StoredTask;
                        player.SlayerTaskFrom = player.StoredTaskFrom;
                        player.SlayerKillsRemaining = player.StoredKillsLeft;
                        player.SlayerAssignedKills = player.StoredKillsAssigned;
                        player.SlayerTaskExtended = player.StoredTaskExtended;

                        player.StoredTask = swapTask;
                        player.StoredTaskFrom = swapFrom;
                        player.StoredKillsLeft = swapKillsLeft;
                        player.StoredKillsAssigned = swapKillsAssigned;
                        player.StoredTaskExtended = swapExtended;

                        if (player.SlayerTask == "") { 
                            Log.AddMessage("You store your slayer task, but did not already have one stored and may take another.", Color.Turquoise);
                        } else { 
                            Log.AddMessage("You store your slayer task, retrieving your previously stored task to kill " + player.SlayerKillsRemaining + " " + GameLoop.ZPO.ResolveMonsterName(player.SlayerTask) + "(s).", Color.Turquoise);
                        }
                    }
                }

                if (ActionID == "ClueHelp") {
                    bool printedAny = false;
                    if (player.CurrentClueBeginner != "") { Log.AddMessage("Beginner: " + ClueLogic.HelpLog("Beginner", player), ColorLib.Mithril); printedAny = true; }
                    if (player.CurrentClueEasy != "") {     Log.AddMessage("    Easy: " + ClueLogic.HelpLog("Easy", player), ColorLib.Mithril); printedAny = true; }
                    if (player.CurrentClueMedium != "") {   Log.AddMessage("  Medium: " + ClueLogic.HelpLog("Medium", player), ColorLib.Mithril); printedAny = true; }
                    if (player.CurrentClueHard != "") {     Log.AddMessage("    Hard: " + ClueLogic.HelpLog("Hard", player), ColorLib.Mithril); printedAny = true; }
                    if (player.CurrentClueElite != "") {    Log.AddMessage("   Elite: " + ClueLogic.HelpLog("Elite", player), ColorLib.Mithril); printedAny = true; }
                    if (player.CurrentClueMaster != "") {   Log.AddMessage("  Master: " + ClueLogic.HelpLog("Master", player), ColorLib.Mithril); printedAny = true; }
                                                        
                    if (!printedAny) {
                        Log.AddMessage("Looks like you haven't got any clue steps active right now!", ColorLib.Mithril);
                    }
                }

                if (ActionID == "HansTime") {
                    int totalSeconds = player.SecondsPlayed;
                    int days = (totalSeconds > 86400 ? totalSeconds / 86400 : 0);
                    totalSeconds -= (days * 86400);
                    int hours = (totalSeconds > 3600 ? totalSeconds / 3600 : 0);
                    totalSeconds -= (hours * 3600);
                    int minutes = (totalSeconds > 60 ? totalSeconds / 60 : 0);
                    totalSeconds -= (minutes * 60);

                    string time = (days > 1 ? days + " days, " : days > 0 ? days + " day, " : "") +
                                    (hours > 1 ? hours + " hours, " : hours > 0 ? hours + " hour, " : "") +
                                    (minutes > 1 ? minutes + " minutes, " : minutes > 0 ? minutes + " minute, " : "") +
                                    (totalSeconds > 1 ? totalSeconds + " seconds" : totalSeconds > 0 ? totalSeconds + " second" : "") + ".";

                    Log.AddMessage("You've played for a total of " + time, ColorLib.Mithril);
                }
            }
        }
    }
}
