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

            if (RequirementType == "QuestPast") {
                if (GameLoop.ZPO.QuestLibrary.TryGetValue(MiscString, out Quest? req)) {
                    if (req != null) {
                        return "Quest: " + req.Name + " [At or Above Stage " + MiscInt + "]";
                    }
                }

                return "Partial Completion " + MiscString;
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

            if (RequirementType == "Pizazz") {
                int have = 0;
                if (MiscString == "Telekinetic") { have = GameLoop.ZPO.player.PizazzTelekinetic; }
                if (MiscString == "Enchantment") { have = GameLoop.ZPO.player.PizazzEnchantment; }
                if (MiscString == "Alchemist") { have = GameLoop.ZPO.player.PizazzAlchemist; }
                if (MiscString == "Graveyard") { have = GameLoop.ZPO.player.PizazzGraveyard; }

                return "Need " + MiscInt + " " + MiscString + " Pizazz points (have " + have + ").";
            }

            if (RequirementType == "ItemOwned") {
                return GameLoop.ZPO.ResolveItemName(MiscString) + " in inventory, equipment, or bank.";
            }
            
            if (RequirementType == "ItemNotOwned") {
                return GameLoop.ZPO.ResolveItemName(MiscString) + " not in inventory, equipment, or bank.";
            }

            if (RequirementType == "DiaryComplete") {
                return "Must complete the " + MiscString + " " + MiscString2 + " Achievement Diary.";
            }

            if (RequirementType == "AnyEquipInSlot") {
                return "Must be wearing any item in the " + MiscString + " slot.";
            }

            if (RequirementType == "ClueMedium") {
                return "Only while a specific medium clue step is active. (" + MiscString + ")";
            }

            if (RequirementType == "CombatAtLeast") {
                return "Must have Combat level " + MiscInt + " or higher.";
            }

            if (RequirementType == "CombatAtMost") {
                return "Must have Combat level " + MiscInt + " or lower.";
            }

            if (RequirementType == "SlayerTask") {
                if (MiscString == "Any") {
                    return "Must have a slayer task active.";
                } else {
                    return "Must have an active " + GameLoop.ZPO.ResolveMonsterName(GameLoop.ZPO.player.SlayerTask) + " task.";
                }
            }

            if (RequirementType == "SlayerNotBlocked") { return "Must not have " + GameLoop.ZPO.ResolveMonsterName(GameLoop.ZPO.player.SlayerTask) + " tasks blocked already."; }
            if (RequirementType == "SlayerBlocked") { return "Must have " + GameLoop.ZPO.ResolveMonsterName(GameLoop.ZPO.player.SlayerTask) + " tasks blocked."; }
            
            if (RequirementType == "SlayerNotPreferred") { return "Must not have " + GameLoop.ZPO.ResolveMonsterName(GameLoop.ZPO.player.SlayerTask) + " tasks preferred already.";  }
            if (RequirementType == "SlayerPreferred") { return "Must have " + GameLoop.ZPO.ResolveMonsterName(GameLoop.ZPO.player.SlayerTask) + " tasks preferred.";  }

            if (RequirementType == "SlayerBlockRoom") {
                int max = GameLoop.ZPO.player.GetQuestPoints() / 50;
                return "Must have fewer than " + max + " tasks blocked - blocking " + GameLoop.ZPO.player.SlayerBlocked.Count + "."; 
            }

            if (RequirementType == "SlayerPreferRoom") {
                int max = GameLoop.ZPO.player.GetQuestPoints() / 50;
                return "Must have fewer than " + max + " tasks preferred - preferring " + GameLoop.ZPO.player.SlayerPrefer.Count + "."; 
            }

            if (RequirementType == "SlayerNotExtended") { return "Current slayer task must not already be extended."; }
            if (RequirementType == "SlayerExtended") { return "Current slayer task must already be extended."; }

            return "";
        }


        public bool CheckRequirement(Player p, bool itemsNotedOkay, bool itemsEquippedOkay = false) {
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
                    if (p.GoldTotal() >= MiscInt) {
                        return true;
                    }
                } else { 
                    if (p.HasAllItems([MiscString+","+MiscInt], itemsNotedOkay, itemsEquippedOkay)) {
                        return true;
                    }
                }
            }

            if (RequirementType == "NotItem") {
                if (MiscString == "Gold") {
                    if (p.GoldTotal() < MiscInt) {
                        return true;
                    }
                } else {
                    if (!p.HasAllItems([MiscString+","+MiscInt])) {
                        return true;
                    } 
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

            if (RequirementType == "Pizazz") {
                if (MiscString == "Telekinetic") { if (p.PizazzTelekinetic >= MiscInt) { return true; } }
                if (MiscString == "Enchantment") { if (p.PizazzEnchantment >= MiscInt) { return true; } }
                if (MiscString == "Alchemist") { if (p.PizazzAlchemist >= MiscInt) { return true; } }
                if (MiscString == "Graveyard") { if (p.PizazzGraveyard >= MiscInt) { return true; } }
            }

            if (RequirementType == "ItemOwned") {
                foreach (var kv in p.Inventory) { if (kv.ID == MiscString) { return true; } }
                foreach (var kv in p.Equipment) { if (kv.Value.ID == MiscString) { return true; } }
                foreach (var kv in p.BankedItems) { if (kv.ID == MiscString) { return true; } }
            }

            if (RequirementType == "ItemNotOwned") {
                foreach (var kv in p.Inventory) { if (kv.ID == MiscString) { return false; } }
                foreach (var kv in p.Equipment) { if (kv.Value.ID == MiscString) { return false; } }
                foreach (var kv in p.BankedItems) { if (kv.ID == MiscString) { return false; } }

                return true;
            }

            if (RequirementType == "AnyEquipInSlot") {
                if (p.Equipment.ContainsKey(MiscString)) {
                    return true;
                }
            }

            if (RequirementType == "ClueMedium") { if (p.CurrentClueMedium == MiscString) { return true; } }


            if (RequirementType == "CombatAtLeast") { if (p.GetCombatLevel() >= MiscInt) { return true; } }
            if (RequirementType == "CombatAtMost") { if (p.GetCombatLevel() <= MiscInt) { return true; } }

            if (RequirementType == "SlayerTask") {
                if (MiscString == "Any") {
                    if (p.SlayerTask != "") { return true; }
                    else if (p.SlayerTask == MiscString) { return true; }
                }
            }

            if (RequirementType == "SlayerNotBlocked") { if (!p.SlayerBlocked.Contains(p.SlayerTask)) { return true; } }
            if (RequirementType == "SlayerBlocked") { if (p.SlayerBlocked.Contains(p.SlayerTask)) { return true; } }
            
            if (RequirementType == "SlayerNotPreferred") { if (!p.SlayerPrefer.Contains(p.SlayerTask)) { return true; } }
            if (RequirementType == "SlayerPreferred") { if (p.SlayerPrefer.Contains(p.SlayerTask)) { return true; } }

            if (RequirementType == "SlayerBlockRoom") {
                int max = p.GetQuestPoints() / 50;
                if (p.SlayerBlocked.Count < max) { 
                    return true;
                }
            }

            if (RequirementType == "SlayerPreferRoom") {
                int max = p.GetQuestPoints() / 50;
                if (p.SlayerPrefer.Count < max) { 
                    return true;
                }
            }

            if (RequirementType == "SlayerExtended") { if (p.SlayerTaskExtended) { return true; }}
            if (RequirementType == "SlayerNotExtended") { if (!p.SlayerTaskExtended) { return true; }}



            return false;
        }
    }
}
