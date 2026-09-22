namespace ZeroPlayersOnline.DataTypes {
    public class BookPage {
        public string Name = ""; // Used to build table of contents

        public string Text = ""; // 30ish characters wide multiline

        public string ReachedAction = ""; // Action ID for what to do when the book is reached
        public List<Requirement> Requirements = new(); // Requirements to do the action
        public List<string> ItemsGiven = new();
        public string MiscString = "";
        public string MiscString2 = "";
        public int MiscInt = 0;

        public BookPage(string name, string text, string reached = "", string miscS = "", int miscI = 0, List<string>? items = null, List<Requirement>? reqs = null, string miscS2 = "") {
            Name = name;
            Text = text;
            ReachedAction = reached;

            ReachedAction = reached;
            MiscString = miscS;
            MiscInt = miscI;
            MiscString2 = miscS2;

            if (reqs != null) {
                Requirements = reqs;
            }

            if (items != null) {
                ItemsGiven = items;
            }
        }

        public void Reached() {
            foreach (var req in Requirements) {
                if (!req.CheckRequirement(GameLoop.ZPO.player, false, true)) {
                    return;
                }
            }

            if (ReachedAction == "Quest") {
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(MiscString, out Quest? quest) && quest != null) {
                    if (GameLoop.ZPO.player.QuestLog.TryGetValue(MiscString, out QuestStatus? status) && status != null) {
                        if (status.CurrentStage < MiscInt) {
                            status.CurrentStage = MiscInt;

                            if (status.CurrentStage == quest.CompleteStage) {
                                GameLoop.ZPO.Log.AddMessage(new ColoredString("You have completed " + quest.Name + "!", Color.Lime, Color.Black));
                                quest.ProcessRewards(GameLoop.ZPO.player);
                            }
                        }
                    }
                }
            }

            if (ReachedAction == "Data" && MiscString != "" && MiscString2 != "") { 
                Helper.AlterWorldState(MiscString, MiscString2, MiscInt);
            }

            foreach (var itemStr in ItemsGiven) { 
                if (itemStr.Contains(",")) {
                    string[] split = itemStr.Split(",");
                    if (split[0] == "Gold") {
                        int.TryParse(split[1], out int qty);
                        GameLoop.ZPO.player.GiveGold(qty); 
                    } else {
                        if (GameLoop.ZPO.ItemLibrary.TryGetValue(split[0], out Item? give)) {
                            if (give != null) {
                                Item actualGive = new(give);

                                if (int.TryParse(split[1], out int qty)) {
                                    actualGive.Quantity = qty;
                                }

                                GameLoop.ZPO.player.TryPickup(new Item(actualGive), actualGive.Quantity);
                            }
                        }
                    }
                } else {
                    if (GameLoop.ZPO.ItemLibrary.TryGetValue(itemStr, out Item? give)) {
                        if (give != null) {
                            GameLoop.ZPO.player.TryPickup(new Item(give), give.Quantity);
                        }
                    }
                } 
            }
        }
    }
}
