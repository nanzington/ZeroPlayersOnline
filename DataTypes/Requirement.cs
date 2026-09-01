namespace ZeroPlayersOnline.DataTypes {
    public class Requirement {
        public string RequirementType = "";
        public int MiscInt = 0;
        public string MiscString = "";
        public bool ConsumeItem = false;

        public Requirement(string ty, int misc1 = 0, string misc2 = "", bool consume = false) {
            RequirementType = ty;
            MiscInt = misc1;
            MiscString = misc2;
            ConsumeItem = consume;
        }

        public string GetSummary() {
            if (RequirementType == "Skill") {
                return "Lv" + MiscInt + " " + MiscString;
            }

            if (RequirementType == "QuestAt") {
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(MiscString, out Quest? req)) {
                    if (req != null) {
                        return "Completed " + req.Name;
                    }
                }

                return "Completed " + MiscString;
            }

            if (RequirementType == "Item") {
                return "Need " + GameLoop.ZPO.ResolveItemName(MiscString);
            }

            return "";
        }


        public bool CheckRequirement(Player p) {
            if (RequirementType == "Skill") {
                if (p.Skills.ContainsKey(MiscString)) {
                    if (p.Skills[MiscString].Level >= MiscInt) {
                        return true;
                    }
                }
            }

            if (RequirementType == "QuestAt") {
                if (p.QuestLog.TryGetValue(MiscString, out Quest? quest)) {
                    if (quest.CurrentStage == MiscInt) {
                        return true;
                    }
                }
            }

            if (RequirementType == "QuestPast") {
                if (p.QuestLog.TryGetValue(MiscString, out Quest? quest)) {
                    if (quest.CurrentStage >= MiscInt) {
                        return true;
                    }
                }
            }

            if (RequirementType == "Item") {
                int count = 0;
                for (int i = 0; i < p.Inventory.Count; i++) { 
                    if (p.Inventory[i].ID == MiscString || p.Inventory[i].MiscString == MiscString) {
                        if (!p.Inventory[i].Noted)
                            count += p.Inventory[i].Quantity;
                    }
                }

                foreach (var kv in p.Equipment) {
                    if (kv.Value.ID == MiscString || kv.Value.MiscString == MiscString) {
                        if (!kv.Value.Noted)
                            count += kv.Value.Quantity;
                    }
                }

                if (count >= MiscInt)
                    return true;
            }


            return false;
        }
    }
}
