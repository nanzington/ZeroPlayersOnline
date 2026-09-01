using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Managers {
    public static class ClueLogic {
        public static bool GenericStep(Player player, MessageLog Log, string clueType, string interacted = "") {
            if (player.CurrentClueTutorial != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueTutorial, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                            if (clueTut.ClueType != "Emote") {
                                ProgressStep("Tutorial", player, Log);
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

                                if (!first || !second || !third)
                                    return false; 
                                 
                                ProgressStep("Tutorial", player, Log);
                                return true;
                            }
                        }
                    }
                }
            }

            if (player.CurrentClueBeginner != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueBeginner, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                            if (clueTut.ClueType != "Emote") {
                                ProgressStep("Beginner", player, Log);
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

                                if (!first || !second || !third)
                                    return false;

                                ProgressStep("Beginner", player, Log);
                                return true;
                            }
                        }
                    }
                }
            }

            if (player.CurrentClueEasy != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueEasy, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                            if (clueTut.ClueType != "Emote") {
                                ProgressStep("Easy", player, Log);
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

                                if (!first || !second || !third)
                                    return false;

                                ProgressStep("Easy", player, Log);
                                return true;
                            }
                        }
                    }
                }
            }

            if (player.CurrentClueMedium != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueMedium, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                            if (clueTut.ClueType != "Emote") {
                                ProgressStep("Medium", player, Log);
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

                                if (!first || !second || !third)
                                    return false;

                                ProgressStep("Medium", player, Log);
                                return true;
                            }
                        }
                    }
                }
            }

            if (player.CurrentClueHard != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueHard, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                            if (clueTut.ClueType != "Emote") {
                                ProgressStep("Hard", player, Log);
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

                                if (!first || !second || !third)
                                    return false;

                                ProgressStep("Hard", player, Log);
                                return true;
                            }
                        }
                    }
                }
            }

            if (player.CurrentClueElite != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueElite, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                            if (clueTut.ClueType != "Emote") {
                                ProgressStep("Elite", player, Log);
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

                                if (!first || !second || !third)
                                    return false;

                                ProgressStep("Elite", player, Log);
                                return true;
                            }
                        }
                    }
                }
            }

            if (player.CurrentClueMaster != "") {
                if (GameLoop.ZPO.ClueStepLibrary.TryGetValue(player.CurrentClueMaster, out ClueStep? clueTut)) {
                    if (clueTut != null) {
                        if (clueTut.ClueType == clueType && player.NavLoc == clueTut.SolveLoc && interacted == clueTut.EmoteOrNpc) {
                            if (clueTut.ClueType != "Emote") {
                                ProgressStep("Master", player, Log);
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

                                if (!first || !second || !third)
                                    return false;

                                ProgressStep("Master", player, Log);
                                return true;
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
                                player.TryPickup(Helper.Clone(caskTut), 1);
                            }
                        }
                        toIncrement = 0;
                        Log.AddMessage(new ColoredString("You finished the treasure hunt and found a casket!", Color.Turquoise, Color.Black));
                    } else {
                        if (GameLoop.ZPO.ItemLibrary.TryGetValue("clueScroll" + tier, out Item? scrollTut)) {
                            if (scrollTut != null) {
                                player.TryPickup(Helper.Clone(scrollTut), 1);
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
            }
        }
    }
}
