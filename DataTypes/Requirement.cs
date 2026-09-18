namespace ZeroPlayersOnline.DataTypes {
    public class Requirement {
        public string RequirementType = "";
        public int MiscInt = 0;
        public string MiscString = "";
        public string MiscString2 = "";
        public bool ConsumeItem = false;

        public string CustomSummary = "";

        public Requirement(string ty, int misc1 = 0, string misc2 = "", bool consume = false, string misc3 = "", string summ = "") {
            RequirementType = ty;
            MiscInt = misc1;
            MiscString = misc2;
            MiscString2 = misc3;
            ConsumeItem = consume;
            CustomSummary = summ;
        }

        public string GetSummary() {
            if (CustomSummary != "") {
                return CustomSummary;
            }

            if (RequirementType == "Skill") {
                if (MiscString == "All") { 
                    return "Need level " + MiscInt + " in all skills";
                } 
                return "Need level " + MiscInt + " " + MiscString;
            }

            if (RequirementType == "QuestAt") {
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(MiscString, out Quest? req)) {
                    if (req != null) {
                        if (req.CompleteStage == MiscInt)
                            return "Completed Quest: " + req.Name;
                        else
                            return "Quest: " + req.Name + " [" + MiscInt + "]";
                    }
                }

                return "Completed " + MiscString;
            }

            if (RequirementType == "QuestBelow") {
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(MiscString, out Quest? req)) {
                    if (req != null) {
                        return "Quest: " + req.Name + " [Below Stage " + MiscInt + "]";
                    }
                }

                return "Incomplete " + MiscString;
            }

            if (RequirementType == "Item") {
                if (MiscString == "Gold") {
                    return "Need " + MiscInt + " gold";
                }
                return "Need " + MiscInt + "x " + GameLoop.ZPO.ResolveItemName(MiscString);
            }

            if (RequirementType == "NotItem") { 
                return "Need to NOT have " + MiscInt + "x " + GameLoop.ZPO.ResolveItemName(MiscString);
            }

            if (RequirementType == "CollectionLogComplete") {
                if (MiscString.Contains("clue"))
                    return "Completed the " + MiscString + " collection log";
                else if (MiscString.Contains("boss")) {
                    return "Completed the " + GameLoop.ZPO.ResolveBossName(MiscString) + " collection log";
                }
                else {
                    return "Completed the " + GameLoop.ZPO.ResolveMonsterName(MiscString) + " collection log";
                }
            }

            if (RequirementType == "KillCount") {
                if (MiscString.Contains("clue"))
                    return "Completed " + MiscInt + "x " + MiscString;
                else {
                    return "Killed " + MiscInt + "x " + GameLoop.ZPO.ResolveMonsterName(MiscString);
                }
            } 

            if (RequirementType == "NotWearing") { 
                return "Not wearing a " + GameLoop.ZPO.ResolveItemName(MiscString); 
            }
            
            if (RequirementType == "Wearing") { 
                return "Wearing a " + GameLoop.ZPO.ResolveItemName(MiscString); 
            } 

            if (RequirementType == "Data") {
                return "WorldState: " + MiscString + " " + MiscString2 + " " + MiscInt;
            }

            return "";
        }


        public bool CheckRequirement(Player p, bool itemsNotedOkay) {
            if (RequirementType == "Skill") {
                if (MiscString == "All") {
                    foreach (var kv in p.Skills) {
                        if (kv.Value.Level < MiscInt) {
                            return false;
                        }
                    }
                    return true;
                } else {
                    if (p.Skills.ContainsKey(MiscString)) {
                        if (p.Skills[MiscString].Level >= MiscInt) {
                            return true;
                        }
                    }
                }
            }

            if (RequirementType == "NotSkill") {
                if (MiscString == "All") {
                    foreach (var kv in p.Skills) {
                        if (kv.Value.Level > MiscInt) {
                            return false;
                        }
                    }
                    return true;
                } else {
                    if (p.Skills.ContainsKey(MiscString)) {
                        if (p.Skills[MiscString].Level < MiscInt) {
                            return true;
                        }
                    }
                }
            }

            if (RequirementType == "QuestAt") {
                if (p.QuestLog.TryGetValue(MiscString, out QuestStatus? quest)) {
                    if (quest.CurrentStage == MiscInt) {
                        return true;
                    }
                } else {
                    if (MiscInt == -1) {
                        return true;
                    } else {
                        return false;
                    }
                }
            }

            if (RequirementType == "QuestBelow") {
                if (p.QuestLog.TryGetValue(MiscString, out QuestStatus? quest)) {
                    if (quest.CurrentStage < MiscInt) {
                        return true;
                    }
                } else {
                    if (MiscInt > -1) {
                        return true;
                    } else {
                        return false;
                    }
                }
            }

            if (RequirementType == "QuestPast") {
                if (p.QuestLog.TryGetValue(MiscString, out QuestStatus? quest)) {
                    if (quest.CurrentStage >= MiscInt) {
                        return true;
                    }
                }
            }

            if (RequirementType == "Item") {
                if (MiscString == "Gold") {
                    if (p.HeldGold >= MiscInt) {
                        return true;
                    }
                } else {
                    int count = 0;
                    for (int i = 0; i < p.Inventory.Count; i++) { 
                        if (p.Inventory[i].ID == MiscString || (p.Inventory[i].GetRef() is Item item && item.MiscString == MiscString)) {
                            if (!p.Inventory[i].Noted || itemsNotedOkay)
                                count += p.Inventory[i].Quantity;
                        }
                    }

                    foreach (var kv in p.Equipment) {
                        if (kv.Value.ID == MiscString || (kv.Value.GetRef() is Item eqp && eqp.MiscString == MiscString)) {
                            if (!kv.Value.Noted)
                                count += kv.Value.Quantity;
                        }
                    }

                    if (count >= MiscInt)
                        return true;
                }
            }

            if (RequirementType == "NotItem") {
                if (MiscString == "Gold") {
                    if (p.HeldGold < MiscInt) {
                        return true;
                    }
                } else {
                    int count = 0;
                    for (int i = 0; i < p.Inventory.Count; i++) { 
                        if (p.Inventory[i].ID == MiscString || (p.Inventory[i].GetRef() is Item item && item.MiscString == MiscString)) {
                            if (!p.Inventory[i].Noted || itemsNotedOkay)
                                count += p.Inventory[i].Quantity;
                        }
                    }

                    foreach (var kv in p.Equipment) {
                        if (kv.Value.ID == MiscString || (kv.Value.GetRef() is Item eqp && eqp.MiscString == MiscString)) {
                            if (!kv.Value.Noted)
                                count += kv.Value.Quantity;
                        }
                    }

                    if (count < MiscInt)
                        return true;
                }
            }

            if (RequirementType == "Wearing") {
                foreach (var kv in p.Equipment) {
                    if (kv.Value.ID == MiscString) {
                        return true;
                    }
                }

                return false;
            }

            if (RequirementType == "NotWearing") {
                foreach (var kv in p.Equipment) {
                    if (kv.Value.ID == MiscString) {
                        return false;
                    }
                }

                return true;
            }

            if (RequirementType == "CollectionLogComplete") {
                if (MiscString.Contains("clue")) {
                    List<string> clueTypes = [ "Tutorial", "Beginner", "Easy", "Medium", "Hard", "Elite", "Master" ];

                    for (int i = 0; i < clueTypes.Count; i++) { 
                        if (MiscString == clueTypes[i] + " clue") {
                            if (p.CollectionLogClues.TryGetValue("casket" + clueTypes[i], out CollectionLogEntry? log) && log != null) {
                                if (GameLoop.ZPO.ItemLibrary.TryGetValue("casket" + clueTypes[i], out Item? cask) && cask != null) {
                                    if (cask.DropTable.Count == log.DropsObtained.Count) {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                } else if (MiscString.Contains("boss")) {
                    if (p.CollectionLogBoss.TryGetValue(MiscString, out CollectionLogEntry? log) && log != null) {
                        if (GameLoop.ZPO.BossLibrary.TryGetValue(MiscString, out BossFight? mon) && mon != null) {
                            if (mon.DropTable.Count == log.DropsObtained.Count) {
                                return true;
                            }
                    
                        }
                    }
                } else {
                    if (p.CollectionLog.TryGetValue(MiscString, out CollectionLogEntry? log) && log != null) {
                        if (GameLoop.ZPO.MonsterLibrary.TryGetValue(MiscString, out AreaMonster? mon) && mon != null) {
                            if (mon.DropTable.Count == log.DropsObtained.Count) {
                                return true;
                            }
                    
                        }
                    }
                }
            }

            if (RequirementType == "KillCount") {
                if (MiscString.Contains("clue")) {
                    List<string> clueTypes = [ "Tutorial", "Beginner", "Easy", "Medium", "Hard", "Elite", "Master" ];

                    for (int i = 0; i < clueTypes.Count; i++) { 
                        if (MiscString == clueTypes[i] + " clue") {
                            if (p.CollectionLogClues.TryGetValue("casket" + clueTypes[i], out CollectionLogEntry? log) && log != null) {
                                if (log.KillCount >= MiscInt) {
                                    return true;
                                }
                            }
                        }
                    }
                } else {
                    if (p.CollectionLog.TryGetValue(MiscString, out CollectionLogEntry? log) && log != null) {
                        if (log.KillCount >= MiscInt) {
                            return true;
                        }
                    }
                }
            }

            if (RequirementType == "Data") {
                return Helper.CompareWorldState(MiscString, MiscString2, MiscInt);
            }

            return false;
        }
    }
}
