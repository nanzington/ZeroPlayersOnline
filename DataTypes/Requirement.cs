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
                if (MiscString == "All") { 
                    return "Need level " + MiscInt + " in all skills";
                } 
                return "Need level " + MiscInt + " " + MiscString;
            }

            if (RequirementType == "QuestAt") {
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(MiscString, out Quest? req)) {
                    if (req != null) {
                        return "Completed Quest: " + req.Name;
                    }
                }

                return "Completed " + MiscString;
            }

            if (RequirementType == "Item") {
                return "Need " + GameLoop.ZPO.ResolveItemName(MiscString);
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

            return "";
        }


        public bool CheckRequirement(Player p) {
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

            if (RequirementType == "CollectionLogComplete") {
                if (MiscString.Contains("clue")) {
                    List<string> clueTypes = [ "Tutorial", "Beginner", "Easy", "Medium", "Hard", "Elite", "Master" ];

                    for (int i = 0; i < clueTypes.Count; i++) { 
                        if (MiscString == clueTypes[i] + " clue") {
                            if (GameLoop.ZPO.player.CollectionLogClues.TryGetValue("casket" + clueTypes[i], out CollectionLogEntry? log) && log != null) {
                                if (GameLoop.ZPO.ItemLibrary.TryGetValue("casket" + clueTypes[i], out Item? cask) && cask != null) {
                                    if (cask.DropTable.Count == log.DropsObtained.Count) {
                                        return true;
                                    }
                                }
                            }
                        }
                    }
                } else if (MiscString.Contains("boss")) {
                    if (GameLoop.ZPO.player.CollectionLogBoss.TryGetValue(MiscString, out CollectionLogEntry? log) && log != null) {
                        if (GameLoop.ZPO.BossLibrary.TryGetValue(MiscString, out BossFight? mon) && mon != null) {
                            if (mon.DropTable.Count == log.DropsObtained.Count) {
                                return true;
                            }
                    
                        }
                    }
                } else {
                    if (GameLoop.ZPO.player.CollectionLog.TryGetValue(MiscString, out CollectionLogEntry? log) && log != null) {
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
                            if (GameLoop.ZPO.player.CollectionLogClues.TryGetValue("casket" + clueTypes[i], out CollectionLogEntry? log) && log != null) {
                                if (log.KillCount >= MiscInt) {
                                    return true;
                                }
                            }
                        }
                    }
                } else {
                    if (GameLoop.ZPO.player.CollectionLog.TryGetValue(MiscString, out CollectionLogEntry? log) && log != null) {
                        if (log.KillCount >= MiscInt) {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
