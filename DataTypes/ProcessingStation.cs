using Newtonsoft.Json;

namespace ZeroPlayersOnline.DataTypes {
    public class ProcessingStation {
        public string Name = ""; 

        public List<ProcessingRecipe> Recipes = new();

        public bool OpensUI = false;

        [JsonIgnore]
        public int TimeLeft = -1;

        [JsonIgnore]
        public double TimeMade = 0;

        [JsonIgnore]
        public string ItemOnExpire = "";

        [JsonIgnore]
        public string LastWorked = "";

        public ProcessingStation(string n, bool ui = false) {
            Name = n;  
            OpensUI = ui;
        }

        public bool TryProcessItem(Player p, MessageLog log, Dictionary<string, Item> ItemLibrary, List<Skill> RecentSkills) { 
            for (int i = 0; i < p.Inventory.Count; i++) {
                bool changedInv = false;
                for (int j = 0; j < Recipes.Count; j++) {
                    if (p.Inventory[i].ID == Recipes[j].InputID && !p.Inventory[i].Noted) {
                        if (Recipes[j].SkillUsed != "") {
                            if (p.Skills.ContainsKey(Recipes[j].SkillUsed) && p.Skills[Recipes[j].SkillUsed].Level < Recipes[j].SkillLevel) {
                                log.AddMessage(new ColoredString("You get the feeling you should have " + Recipes[j].SkillLevel + " " + Recipes[j].SkillUsed + " to make " + GameLoop.ZPO.ResolveItemName(Recipes[j].OutputID) + ".", Color.Crimson, Color.Black));
                                continue;
                            } 
                        } 

                        if (Recipes[j].SecondaryIn != "" && !p.HasAllItems([Recipes[j].SecondaryIn + ",1" ])) {
                            continue;
                        } 

                        if (Recipes[j].TertiaryIn != "" && !p.HasAllItems([Recipes[j].TertiaryIn + ",1"], false, true)) {
                            continue;
                        }

                        if (LastWorked == "") {
                            LastWorked = p.Inventory[i].ID; 
                        } else {
                            if (LastWorked != p.Inventory[i].ID)
                                continue;
                        }

                        if (Recipes[j].SkillUsed == "Runecrafting" && Recipes[j].TertiaryIn != "") {
                            int pureEssCount = 0;

                            foreach (var kv in p.Inventory) {
                                if (kv.ID == "pureEssence") {
                                    pureEssCount++;
                                }
                            }

                            if (p.Inventory[i].Quantity < pureEssCount) {
                                pureEssCount = p.Inventory[i].Quantity;
                            }

                            p.Inventory[i].Quantity -= pureEssCount;
                            if (p.Inventory[i].Quantity <= 0) {
                                p.Inventory.RemoveAt(i);
                                changedInv = true;
                            }

                            int invCount = p.Inventory.Count;
                            if (Recipes[j].SecondaryIn != "") {
                                p.ConsumeItems([Recipes[j].SecondaryIn + "," + pureEssCount]);
                            }
                            if (invCount != p.Inventory.Count) {
                                changedInv = true;
                            }

                            invCount = p.Inventory.Count;
                            if (Recipes[j].TertiaryIn != "") {
                                p.ConsumeItems([Recipes[j].TertiaryIn + "," + pureEssCount], false, true);
                            }
                            if (invCount != p.Inventory.Count) {
                                changedInv = true;
                            } 


                            int extra = 0;

                            if (ItemLibrary.ContainsKey(Recipes[j].OutputID)) {
                                Item item = new(ItemLibrary[Recipes[j].OutputID]);
                                item.Quantity = pureEssCount;

                                if (Recipes[j].HighSkillExtraOutputs) {
                                    int skillDiff = p.Skills[Recipes[j].SkillUsed].Level - Recipes[j].SkillLevel;
                                    extra = (int) Math.Floor(skillDiff / 10.0);
                                    item.Quantity += extra * pureEssCount;
                                }

                                if (GameLoop.rand.Next(2) == 0) {
                                    if (p.Equipment.TryGetValue("Amulet", out ItemWrapper? eqp) && eqp != null && eqp.ID == "necklaceBinding") {
                                        eqp.Charges -= 1; 
                                        log.AddMessage(new ColoredString("Your binding necklace lets you combine all the runes successfully.", Color.AntiqueWhite, Color.Black));

                                        if (eqp.Charges <= 0) { 
                                            log.AddMessage(new ColoredString("Your binding necklace runs out of charge and shatters.", Color.Crimson, Color.Black));
                                            p.Equipment.Remove("Amulet");
                                        }
                                    } else {
                                        item.Quantity /= 2;
                                        if (item.Quantity == 0)
                                            item.Quantity = 1;
                                    }
                                }

                                p.TryPickup(item, item.Quantity);
                            }

                            p.TryGrantExp(Recipes[j].SkillUsed, (Recipes[j].SkillEXP * (1 + extra)) * pureEssCount, log, RecentSkills);
                            return true;
                        } else if (Recipes[j].SkillUsed == "Smithing" && Recipes[j].TertiaryIn != "") { // AKA: Smelting bars and they've got a ring of forging
                            if (!p.HasAllItems([Recipes[j].TertiaryIn+",1"], false, true, true)) {
                                return false;
                            }

                            p.Inventory[i].Quantity -= 1;
                            if (p.Inventory[i].Quantity <= 0) {
                                p.Inventory.RemoveAt(i);
                                changedInv = true;
                            }

                            int invCount = p.Inventory.Count;
                            if (Recipes[j].SecondaryIn != "") {
                                p.ConsumeItems([Recipes[j].SecondaryIn+",1"]);
                            }
                            if (invCount != p.Inventory.Count) {
                                changedInv = true;
                            }

                            int extra = 0;

                            if (ItemLibrary.ContainsKey(Recipes[j].OutputID)) {
                                Item item = new(ItemLibrary[Recipes[j].OutputID]);

                                if (Recipes[j].HighSkillExtraOutputs) {
                                    int skillDiff = p.Skills[Recipes[j].SkillUsed].Level - Recipes[j].SkillLevel;
                                    extra = (int) Math.Floor(skillDiff / 10.0);
                                    item.Quantity += extra;
                                }

                                p.TryPickup(item, item.Quantity);
                            }

                            if (Recipes[j].SecondaryOut != "") {
                                if (ItemLibrary.ContainsKey(Recipes[j].SecondaryOut)) {
                                    Item item = new(ItemLibrary[Recipes[j].SecondaryOut]); 

                                    p.TryPickup(item, item.Quantity);
                                }
                            }
                            string nameOre = GameLoop.ZPO.ResolveItemName(Recipes[j].InputID).ToLower();
                            string nameBar = GameLoop.ZPO.ResolveItemName(Recipes[j].OutputID).ToLower();
                            log.AddMessage("Your ring of forging allows you to smelt a" + (Helper.VowelStart(nameOre) ? "n " : " ") + nameOre + " directly into a" + (Helper.VowelStart(nameBar) ? "n " : " ") + nameBar + ".", Color.Crimson);

                            if (p.Equipment.TryGetValue("Ring", out ItemWrapper? eqp) && eqp != null && eqp.ID == "ringForging") {
                                eqp.Charges -= 1;  

                                if (eqp.Charges <= 0) { 
                                    log.AddMessage(new ColoredString("Your ring of forging runs out of charge and shatters.", Color.Crimson, Color.Black));
                                    p.Equipment.Remove("Ring");
                                }
                            }

                            p.TryGrantExp(Recipes[j].SkillUsed, Recipes[j].SkillEXP * (1 + extra), log, RecentSkills);
                            return true;
                        } else {
                            p.Inventory[i].Quantity -= 1;
                            if (p.Inventory[i].Quantity <= 0) {
                                p.Inventory.RemoveAt(i);
                                changedInv = true;
                            }

                            int invCount = p.Inventory.Count;
                            if (Recipes[j].SecondaryIn != "") {
                                p.ConsumeItems([Recipes[j].SecondaryIn+",1"]);
                            }
                            if (invCount != p.Inventory.Count) {
                                changedInv = true;
                            }

                            int extra = 0;

                            if (ItemLibrary.ContainsKey(Recipes[j].OutputID)) {
                                Item item = new(ItemLibrary[Recipes[j].OutputID]);

                                if (Recipes[j].HighSkillExtraOutputs) {
                                    int skillDiff = p.Skills[Recipes[j].SkillUsed].Level - Recipes[j].SkillLevel;
                                    extra = (int) Math.Floor(skillDiff / 10.0);
                                    item.Quantity += extra;
                                }

                                p.TryPickup(item, item.Quantity);
                            }

                            if (Recipes[j].SecondaryOut != "") {
                                if (ItemLibrary.ContainsKey(Recipes[j].SecondaryOut)) {
                                    Item item = new(ItemLibrary[Recipes[j].SecondaryOut]); 

                                    p.TryPickup(item, item.Quantity);
                                }
                            }

                            p.TryGrantExp(Recipes[j].SkillUsed, Recipes[j].SkillEXP * (1 + extra), log, RecentSkills);
                            return true;
                        }
                    } 
                    if (changedInv)
                        break;
                }
                if (changedInv)
                    break;
            }

            return false;
        }
    }
}
