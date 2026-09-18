using SadRogue.Primitives.GridViews;
using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Managers {
    public static class ClueLogic {
        public static bool GenericStep(Player player, MessageLog Log, string clueType, string interacted = "") { 
            List<string> ClueDiffs = new() { "Tutorial", "Beginner", "Easy", "Medium", "Hard", "Elite", "Master" }; 
            ref string clueID = ref player.CurrentClueTutorial;

            foreach (var diff in ClueDiffs) {
                if (diff == "Beginner") { clueID = ref player.CurrentClueBeginner; }
                if (diff == "Easy") { clueID = ref player.CurrentClueEasy; }
                if (diff == "Medium") { clueID = ref player.CurrentClueMedium; }
                if (diff == "Hard") { clueID = ref player.CurrentClueHard; }
                if (diff == "Elite") { clueID = ref player.CurrentClueElite; }
                if (diff == "Master") { clueID = ref player.CurrentClueMaster; }

                if (clueID != "") {
                    if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(clueID, out ClueStep? clueTut)) {
                        if (clueTut != null) {
                            if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                                if (clueTut.ClueType != "Emote") {
                                    ProgressStep(diff, player, Log);
                                    return true;
                                } else {
                                    bool first = false;
                                    bool second = false;
                                    bool third = false;

                                    foreach (var kv in GameLoop.ZPO.player.Equipment) {
                                        if (kv.Value.ID == clueTut.Equip1)
                                            first = true;
                                        if (kv.Value.ID == clueTut.Equip2)
                                            second = true;
                                        if (kv.Value.ID == clueTut.Equip3)
                                            third = true;
                                    } 

                                    if (!first && clueTut.Equip1 != "")
                                        return false; 

                                    if (!second && clueTut.Equip2 != "")
                                        return false; 

                                    if (!third && clueTut.Equip3 != "")
                                        return false; 
                                 
                                    ProgressStep(diff, player, Log);
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        public static void ProgressStep(string tier, Player player, MessageLog Log) {
            int stepsNeeded = 3;
            ref int toIncrement = ref player.StepsDoneEasy;
            ref string toReset = ref player.CurrentClueEasy;

            if (tier == "Tutorial") { toIncrement = ref player.StepsDoneTutorial; toReset = ref player.CurrentClueTutorial; stepsNeeded = 1; }
            else if (tier == "Beginner") { toIncrement = ref player.StepsDoneBeginner; toReset = ref player.CurrentClueBeginner; stepsNeeded = 2; }
            else if (tier == "Easy") { toIncrement = ref player.StepsDoneEasy; toReset = ref player.CurrentClueEasy; stepsNeeded = 3; } 
            else if (tier == "Medium") { toIncrement = ref player.StepsDoneMedium; toReset = ref player.CurrentClueMedium; stepsNeeded = 4; } 
            else if (tier == "Hard") { toIncrement = ref player.StepsDoneHard; toReset = ref player.CurrentClueHard; stepsNeeded = 5; } 
            else if (tier == "Elite") { toIncrement = ref player.StepsDoneElite; toReset = ref player.CurrentClueElite; stepsNeeded = 5; } 
            else if (tier == "Master") { toIncrement = ref player.StepsDoneMaster; toReset = ref player.CurrentClueMaster; stepsNeeded = 5; }



            for (int i = 0; i < player.Inventory.Count; i++) {
                if (player.Inventory[i].ID == "clueScroll" + tier) {
                    player.Inventory.RemoveAt(i);
                    toIncrement += 1;
                    toReset = "";

                    if (toIncrement >= stepsNeeded) {
                        if (GameLoop.ZPO.ItemLibrary.TryGetValue("casket" + tier, out Item? caskTut)) {
                            if (caskTut != null) {
                                player.TryPickup(new Item(caskTut), 1);
                            }
                        }
                        toIncrement = 0;
                        Log.AddMessage(new ColoredString("You finished the treasure hunt and found a casket!", Color.Turquoise, Color.Black));
                    } else {
                        if (GameLoop.ZPO.ItemLibrary.TryGetValue("clueScroll" + tier, out Item? scrollTut)) {
                            if (scrollTut != null) {
                                player.TryPickup(new Item(scrollTut), 1);
                            }
                        }
                        Log.AddMessage(new ColoredString("You found another clue scroll!", Color.Turquoise, Color.Black));
                    }

                    break;
                }
            }
        }

        public static void SetOrShowStep(string tier, Player player, MessageLog Log) { 
            ref string clueID = ref player.CurrentClueTutorial;
            
            if (tier == "Beginner") { clueID = ref player.CurrentClueBeginner; }
            if (tier == "Easy") { clueID = ref player.CurrentClueEasy; }
            if (tier == "Medium") { clueID = ref player.CurrentClueMedium; }
            if (tier == "Hard") { clueID = ref player.CurrentClueHard; }
            if (tier == "Elite") { clueID = ref player.CurrentClueElite; }
            if (tier == "Master") { clueID = ref player.CurrentClueMaster; } 

             if (clueID == "") {
                List<string> allClueSteps = new();

                foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                    if (kv.Value.Difficulty == tier) {
                        allClueSteps.Add(kv.Key);
                    }
                }

                clueID = allClueSteps[GameLoop.rand.Next(allClueSteps.Count)];
            }

            if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(clueID, out ClueStep? clue) && clue != null) { 
                if (clue.ClueType != "Map") { 
                    Log.AddMessage(new ColoredString("Clue: " + clue.HintText, Color.SandyBrown, Color.Black));
                } else {
                    ExtraWindows.Clue.IsVisible = true;
                    ExtraWindows.CurrentClue = clue.ID;
                    Log.AddMessage(new ColoredString("Clue: " + clue.HintText, Color.SandyBrown, Color.Black));
                }
            }

            /*
            if (tier == "Tutorial") {
                if (player.CurrentClueTutorial == "") {
                    List<string> allTutorialClues = new();

                    foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                        if (kv.Value.Difficulty == "Tutorial") {
                            allTutorialClues.Add(kv.Key);
                        }
                    }

                    player.CurrentClueTutorial = allTutorialClues[GameLoop.rand.Next(allTutorialClues.Count)];
                }

                if (GameLoop.ZPO.ClueStepLibrary.ContainsKey(player.CurrentClueTutorial)) {
                    Log.AddMessage(new ColoredString("Clue: " + GameLoop.ZPO.ClueStepLibrary[player.CurrentClueTutorial].HintText, Color.SandyBrown, Color.Black));
                }
            } else if (tier == "Beginner") {
                if (player.CurrentClueBeginner == "") {
                    List<string> allClues = new();

                    foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                        if (kv.Value.Difficulty == "Beginner") {
                            allClues.Add(kv.Key);
                        }
                    }

                    player.CurrentClueBeginner = allClues[GameLoop.rand.Next(allClues.Count)];
                }

                if (GameLoop.ZPO.ClueStepLibrary.ContainsKey(player.CurrentClueBeginner)) {
                    Log.AddMessage(new ColoredString("Clue: " + GameLoop.ZPO.ClueStepLibrary[player.CurrentClueBeginner].HintText, Color.SandyBrown, Color.Black));
                }
            } else if (tier == "Easy") {
                if (player.CurrentClueEasy == "") {
                    List<string> allClues = new();

                    foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                        if (kv.Value.Difficulty == "Easy") {
                            allClues.Add(kv.Key);
                        }
                    }

                    player.CurrentClueEasy = allClues[GameLoop.rand.Next(allClues.Count)];
                }

                if (GameLoop.ZPO.ClueStepLibrary.ContainsKey(player.CurrentClueEasy)) {
                    Log.AddMessage(new ColoredString("Clue: " + GameLoop.ZPO.ClueStepLibrary[player.CurrentClueEasy].HintText, Color.SandyBrown, Color.Black));
                }
            } else if (tier == "Medium") {
                if (player.CurrentClueMedium == "") {
                    List<string> allClues = new();

                    foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                        if (kv.Value.Difficulty == "Medium") {
                            allClues.Add(kv.Key);
                        }
                    }

                    player.CurrentClueMedium = allClues[GameLoop.rand.Next(allClues.Count)];
                }

                if (GameLoop.ZPO.ClueStepLibrary.ContainsKey(player.CurrentClueMedium)) {
                    Log.AddMessage(new ColoredString("Clue: " + GameLoop.ZPO.ClueStepLibrary[player.CurrentClueMedium].HintText, Color.SandyBrown, Color.Black));
                }
            } else if (tier == "Hard") {
                if (player.CurrentClueHard == "") {
                    List<string> allClues = new();

                    foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                        if (kv.Value.Difficulty == "Hard") {
                            allClues.Add(kv.Key);
                        }
                    }

                    player.CurrentClueHard = allClues[GameLoop.rand.Next(allClues.Count)];
                }

                if (GameLoop.ZPO.ClueStepLibrary.ContainsKey(player.CurrentClueHard)) {
                    Log.AddMessage(new ColoredString("Clue: " + GameLoop.ZPO.ClueStepLibrary[player.CurrentClueHard].HintText, Color.SandyBrown, Color.Black));
                }
            } else if (tier == "Elite") {
                if (player.CurrentClueElite == "") {
                    List<string> allClues = new();

                    foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                        if (kv.Value.Difficulty == "Elite") {
                            allClues.Add(kv.Key);
                        }
                    }

                    player.CurrentClueElite = allClues[GameLoop.rand.Next(allClues.Count)];
                }

                if (GameLoop.ZPO.ClueStepLibrary.ContainsKey(player.CurrentClueElite)) {
                    Log.AddMessage(new ColoredString("Clue: " + GameLoop.ZPO.ClueStepLibrary[player.CurrentClueElite].HintText, Color.SandyBrown, Color.Black));
                }
            } else if (tier == "Master") {
                if (player.CurrentClueMaster == "") {
                    List<string> allClues = new();

                    foreach (var kv in GameLoop.ZPO.ClueStepLibrary) {
                        if (kv.Value.Difficulty == "Master") {
                            allClues.Add(kv.Key);
                        }
                    }

                    player.CurrentClueMaster = allClues[GameLoop.rand.Next(allClues.Count)];
                }

                if (GameLoop.ZPO.ClueStepLibrary.ContainsKey(player.CurrentClueMaster)) {
                    Log.AddMessage(new ColoredString("Clue: " + GameLoop.ZPO.ClueStepLibrary[player.CurrentClueMaster].HintText, Color.SandyBrown, Color.Black));
                }
            }*/
        }

        public static string HelpLog(string which, Player p) {
            string location = "";
            string interact = "";
            string target = ""; 

            string clueID = "";

            if (which == "Tutorial") { clueID = p.CurrentClueTutorial; } 
            else if (which == "Beginner") { clueID = p.CurrentClueBeginner; } 
            else if (which == "Easy") { clueID = p.CurrentClueEasy; } 
            else if (which == "Medium") { clueID = p.CurrentClueMedium; } 
            else if (which == "Hard") { clueID = p.CurrentClueHard; } 
            else if (which == "Elite") { clueID = p.CurrentClueElite; } 
            else if (which == "Master") { clueID = p.CurrentClueMaster; } 

            if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(clueID, out ClueStep? clue) && clue != null) {
                location = GameLoop.ZPO.ResolveLocationName(clue.SolveLoc);
                    
                if (clue.ClueType == "Speak" || clue.ClueType == "Anagram") {
                    interact = "speak to ";
                    target = GameLoop.ZPO.ResolveNPCName(clue.EmoteOrNpc);
                }

                if (clue.ClueType == "Dig") {
                    interact = "dig with a spade";
                }

                if (clue.ClueType == "Emote") {
                    interact = clue.EmoteOrNpc + " with specific items equipped";
                }

                if (clue.ClueType == "Gather") {
                    interact = "interact with a ";
                    target = GameLoop.ZPO.ResolveGatherName(clue.EmoteOrNpc);
                }
            }

            return "Go to " + location + " and " + interact + target + ".";
        }
    }
}
