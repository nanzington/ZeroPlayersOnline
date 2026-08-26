using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Managers {
    public static class ClueLogic {
        public static void DigStep(Player player, MessageLog Log) {
            if (player.CurrentClueTutorial != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueTutorial, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == "Dig" && player.NavLoc == clueTut.SolveLoc) { 
                            ProgressStep("Tutorial", player, Log);
                        }
                    }
                }
            }

            if (player.CurrentClueBeginner != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueBeginner, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == "Dig" && player.NavLoc == clueTut.SolveLoc) { 
                            ProgressStep("Beginner", player, Log);
                        }
                    }
                }
            }

            if (player.CurrentClueEasy != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueEasy, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == "Dig" && player.NavLoc == clueTut.SolveLoc) { 
                            ProgressStep("Easy", player, Log);
                        }
                    }
                }
            }

            if (player.CurrentClueMedium != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueMedium, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == "Dig" && player.NavLoc == clueTut.SolveLoc) {
                            ProgressStep("Medium", player, Log);
                        }
                    }
                }
            }

            if (player.CurrentClueHard != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueHard, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == "Dig" && player.NavLoc == clueTut.SolveLoc) {
                            ProgressStep("Hard", player, Log);
                        }
                    }
                }
            }

            if (player.CurrentClueElite != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueElite, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == "Dig" && player.NavLoc == clueTut.SolveLoc) {
                            ProgressStep("Elite", player, Log);
                        }
                    }
                }
            }

            if (player.CurrentClueMaster != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueMaster, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == "Dig" && player.NavLoc == clueTut.SolveLoc) {
                            ProgressStep("Master", player, Log);
                        }
                    }
                }
            }
        }

        public static bool TalkStep(Player player, MessageLog Log, string NpcID) {
            if (player.CurrentClueTutorial != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueTutorial, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if ((clueTut.ClueType == "Speak" || clueTut.ClueType == "Anagram") && NpcID == clueTut.EmoteOrNpc) {
                            ProgressStep("Tutorial", player, Log);
                            return true;
                        }
                    }
                }
            }

            if (player.CurrentClueBeginner != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueBeginner, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if ((clueTut.ClueType == "Speak" || clueTut.ClueType == "Anagram") && NpcID == clueTut.EmoteOrNpc) {
                            ProgressStep("Beginner", player, Log);
                            return true;
                        }
                    }
                }
            }

            if (player.CurrentClueEasy != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueEasy, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if ((clueTut.ClueType == "Speak" || clueTut.ClueType == "Anagram") && NpcID == clueTut.EmoteOrNpc) {
                            ProgressStep("Easy", player, Log);
                            return true;
                        }
                    }
                }
            }

            if (player.CurrentClueMedium != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueMedium, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if ((clueTut.ClueType == "Speak" || clueTut.ClueType == "Anagram") && NpcID == clueTut.EmoteOrNpc) {
                            ProgressStep("Medium", player, Log);
                            return true;
                        }
                    }
                }
            }

            if (player.CurrentClueHard != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueHard, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if ((clueTut.ClueType == "Speak" || clueTut.ClueType == "Anagram") && NpcID == clueTut.EmoteOrNpc) {
                            ProgressStep("Hard", player, Log);
                            return true;
                        }
                    }
                }
            }

            if (player.CurrentClueElite != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueElite, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if ((clueTut.ClueType == "Speak" || clueTut.ClueType == "Anagram") && NpcID == clueTut.EmoteOrNpc) {
                            ProgressStep("Elite", player, Log);
                            return true;
                        }
                    }
                }
            }

            if (player.CurrentClueMaster != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueMaster, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if ((clueTut.ClueType == "Speak" || clueTut.ClueType == "Anagram") && NpcID == clueTut.EmoteOrNpc) {
                            ProgressStep("Master", player, Log);
                            return true;
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
                                player.TryPickup(caskTut);
                            }
                        }
                        toIncrement = 0;
                        Log.AddMessage(new ColoredString("You finished the treasure hunt and found a casket!", Color.Turquoise, Color.Black));
                    } else {
                        if (GameLoop.ZPO.ItemLibrary.TryGetValue("clueScroll" + tier, out Item? scrollTut)) {
                            if (scrollTut != null) {
                                player.TryPickup(scrollTut);
                            }
                        }
                        Log.AddMessage(new ColoredString("You found another clue scroll!", Color.Turquoise, Color.Black));
                    }

                    break;
                }
            }
        }

        public static void SetOrShowStep(string tier, Player player, MessageLog Log) {
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
            }
        }
    }
}
