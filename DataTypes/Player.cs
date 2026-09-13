using GoRogue.DiceNotation.Terms;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using ZeroPlayersOnline.Managers;

namespace ZeroPlayersOnline.DataTypes {
    public class Player {
        public string Name = "Player"; 
        public string NavLoc = "TI_Main";
        public string NavRespawn = "TI_Temple";

        public int CurrentHP = 0;
        public int HeldGold = 0;

        public int OffenseExpSplit = 2;
        public int DefenseExpSplit = 2;

        // Difficulty Settings

        public int GrandExchangeMode = 1; // 0 = full, 1 = limited/bronze, 2 = none/iron
        public int DeathMode = 1; // 0 = no death penalty, 1 = drop items, 2 = reset character
        public bool NightmareMode = false; // if true, any damage taken will kill the player

        public int ExpMultiplier = 1; // Multiply all gained exp by this amount
        public int PayToWin = 0; // If 0, experience is earned normally. Otherwise this is the cost in GP to get 1 exp (before the above multiplier is applied).
        public bool OnlyPayToWin = false; // If true and PayToWin isn't 0, exp can ONLY be bought, not earned

        public int DropMultiplier = 1; // Multiply all drop chance by this, high values may result in an issue
        public int DropModifier = 0; // 0 = Normal, 1 = Dry Protection, 2 = No RNG Drops

        public List<string> PermittedRegions = new(); // If empty all regions allowed, otherwise you can only go to maps in a region in this list

        public bool LocationLock = false; // If true, can only go to locations in the following list, and successfully going to a location not in it costs a LocationPoint
        public Dictionary<string, LocationCompletion> UnlockedLocations = new(); // 
        public int LocationPoints = 0; // Incremented each time you finish all tasks in a location
        public List<string> CompletedFeats = new();

        public int KillLimit = -1; // -1 = uncapped, otherwise after this many kills each unique monster name it will stop giving exp/drops
        public Dictionary<string, int> KillTracker = new(); // Log monsters by name and KC here

        public Dictionary<string, string> ItemIDRemaps = new(); // For randomizer
        public Dictionary<string, string> LocationIDRemaps = new(); // For randomizer
        public Dictionary<string, string> GatheringSpotRemapes = new(); // For randomizer

        public int RandomItems = 0; // 0 = not random, 1 = no logic rando set, 2 = no logic rando changing
        public int RandomLocs = 0; // 0 = not random, 1 = no logic rando
        public int RandomGathering = 0; // 0 = no random, 1 = no logic rando

        public int InventoryLimit = 20;
        public bool CanUseShops = true;
        public bool ShopsAlwaysFullPrice = false;
        public bool CanUseBanks = true;
        public int FarmGrowthIncrement = 60;

        // End of Difficulty Settings



        
        public List<ItemWrapper> Inventory = new();
        public Dictionary<string, ItemWrapper> Equipment = new(); 
        public Dictionary<string, Skill> Skills = new(); 
        public Dictionary<string, CollectionLogEntry> CollectionLog = new();
        public Dictionary<string, CollectionLogEntry> CollectionLogClues = new();
        public Dictionary<string, CollectionLogEntry> CollectionLogBoss = new();
        public List<ItemWrapper> BankedItems = new(); 
        public List<string> ItemsEverObtained = new();

        public string PrayerBook = "Normal";
        public Dictionary<string, Prayer> Prayers = new();

        public string MagicBook = "Standard";
        public string CastingSpell = "";

        public List<PotionStat> ActivePotions = new(); 
        public Dictionary<string, FarmingPatch> FarmingPatches = new();

        public Dictionary<string, QuestStatus> QuestLog = new();

        public string CurrentClueTutorial = "";
        public int StepsDoneTutorial = 0;
        public string CurrentClueBeginner = "";
        public int StepsDoneBeginner = 0;
        public string CurrentClueEasy = "";
        public int StepsDoneEasy = 0;
        public string CurrentClueMedium = "";
        public int StepsDoneMedium = 0;
        public string CurrentClueHard = "";
        public int StepsDoneHard = 0;
        public string CurrentClueElite = "";
        public int StepsDoneElite = 0;
        public string CurrentClueMaster = "";
        public int StepsDoneMaster = 0;

        public string SlayerTask = "";
        public int SlayerKillsRemaining = 0;
        public int SlayerTaskStreak = 0;
        public int SlayerPoints = 0;
         
        public string ArtisanTask = "";
        public int ArtisanTaskRemaining = 0;
        public int ArtisanTaskStreak = 0;
        public int ArtisanPoints = 0;

        public int SecondsPlayed = 0;

        [JsonIgnore]
        public List<HunterCreature> SpawnedCreatures = new();

        public int GetCombatLevel() {
            int atk = Skills["Attack"].Level;
            int str = Skills["Strength"].Level;
            int def = Skills["Defense"].Level;
            int con = Skills["Constitution"].Level;
            int ran = Skills["Ranged"].Level;
            int mag = Skills["Magic"].Level;
            int pra = Skills["Prayer"].Level;
            
            return Math.Clamp((atk + str + def + con + ran + mag + (pra / 2)) / 4, 1, 999);
        }

        public string GetDamageDice() {
            int weaponTier = 1;
            bool maging = IsMaging();

            if (Equipment.TryGetValue("Weapon", out ItemWrapper? eqpWrap) && eqpWrap.GetRef() is Item eqp) {
                weaponTier = eqp.EquipTier + 1;

                if (eqp.EquipSkill == "Ranged") {
                    if (eqp.EquipAmmo == "Arrow" || eqp.EquipAmmo == "Bolt") { // Only other option currently is Self, where we don't need to change weaponTier
                        if (Equipment.TryGetValue("Ammo", out ItemWrapper? ammoWrap) && ammoWrap.GetRef() is Item ammo) {
                            if (ammo.EquipLevel <= eqp.EquipLevel) {
                                weaponTier = ammo.EquipTier + 1;
                            } else {
                                weaponTier = eqp.EquipTier + 1;
                            }
                        } else {
                            weaponTier = 0;
                        }
                    } 
                }

                if (maging && eqp.EquipSkill != "Magic") {
                    weaponTier = 1;
                }
            }
            int strength = (int)Math.Clamp(Math.Floor(GetEffectiveSkillLevel("Strength") / 5f) + 1, 1, 10); 

            if (maging) { 
                strength = GameLoop.ZPO.SpellLibrary[CastingSpell].Tier * 2;
            }

            foreach (var kv in Equipment) {
                if (kv.Value.GetRef() is Item item && item.MiscString == "OmniBoost") {
                    strength += item.EquipTier;
                }
            }

            return weaponTier + "d" + strength;
        }

        public string GetDamageType() {
            if (IsMaging()) {
                return GameLoop.ZPO.SpellLibrary[CastingSpell].MiscString;
            }

            if (Equipment.TryGetValue("Weapon", out ItemWrapper? wepWrapper) && wepWrapper.GetRef() is Item wep)
                return wep.EquipDamageType;
            return "Crush";
        }

        public bool TryPickup(ItemWrapper wrap, int qty, bool noted = false, bool shop = false, bool fromGround = false) {
            if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? curr)) {
                for (int i = 0; i < Inventory.Count; i++) { 
                    if (Inventory[i].ID == wrap.ID && (Inventory[i].GetRef() is Item inv && (inv.Stackable || (noted && Inventory[i].Noted)))) {
                        Inventory[i].Quantity += qty; 
                        if (!shop)
                            wrap.Quantity -= qty;
                        return true; 
                    }
                }

                ItemWrapper clone = Helper.Clone(wrap);
             
                if (Inventory.Count < InventoryLimit) {
                    if (wrap.GetRef() is Item pickup && (pickup.Stackable || (pickup.Noteable && noted))) { 
                        if (noted)
                            clone.Noted = true;

                        clone.Quantity = qty;
                        if (!shop)
                            wrap.Quantity -= qty;
                        Inventory.Add(clone);
                    } else {
                        for (int i = 0; i < qty; i++) { 
                            ItemWrapper secondClone = Helper.Clone(clone);
                            secondClone.Quantity = 1;
                            clone.Quantity--;
                            if (!shop)
                                wrap.Quantity--;

                            if (Inventory.Count < InventoryLimit)
                                Inventory.Add(secondClone);
                            else {
                                if (curr.IsBank && CanUseBanks) {
                                    BankItem(secondClone);
                                    return true;
                                } else {
                                    GameLoop.ZPO.TryPlaceItem(NavLoc, secondClone);
                                    return true;
                                }
                            }
                        }
                    }
                    return true;
                } 

                if (fromGround) {
                    GameLoop.ZPO.Log.AddMessage("Your inventory is too full to pick up anything else right now.", Color.Crimson);
                    return false;
                }
                 
                if (curr.IsBank && CanUseBanks) {
                    BankItem(clone); 
                    return true;
                }

                for (int i = 0; i < curr.ItemsHere.Count; i++) {
                    if (curr.ItemsHere[i].ID == wrap.ID && wrap.Noted == curr.ItemsHere[i].Noted && curr.ItemsHere[i].UseInt4 == wrap.Charges) {
                        curr.ItemsHere[i].Quantity += qty; 
                        return true; 
                    }
                }

                if (clone.GetRef() is Item drop)
                    curr.ItemsHere.Add(drop);
                return true;
            }

            return false;
        }


        public bool TryPickup(Item item, int qty, bool noted = false, bool shop = false, bool fromGround = false) {  
            if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? curr)) {
                for (int i = 0; i < Inventory.Count; i++) { 
                    if (Inventory[i].GetRef() is Item wrap && wrap.ID == item.ID && (wrap.Stackable || (noted && Inventory[i].Noted))) {
                        Inventory[i].Quantity += qty; 
                        if (!shop)
                            item.Quantity -= qty;
                        return true; 
                    }
                }

                Item clone = Helper.Clone(item);
             
                if (Inventory.Count < InventoryLimit) {
                    if (item.Stackable || (item.Noteable && noted)) { 
                        if (noted)
                            clone.Noted = true;

                        clone.Quantity = qty;
                        if (!shop)
                            item.Quantity -= qty;
                        Inventory.Add(new(clone));
                    } else {
                        for (int i = 0; i < qty; i++) { 
                            Item secondClone = Helper.Clone(clone);
                            secondClone.Quantity = 1;
                            clone.Quantity--;
                            if (!shop)
                                item.Quantity--;

                            if (Inventory.Count < InventoryLimit)
                                Inventory.Add(new(secondClone));
                            else {
                                if (curr.IsBank && CanUseBanks) {
                                    BankItem(new(secondClone));
                                    return true;
                                } else {
                                    GameLoop.ZPO.TryPlaceItem(NavLoc, new(secondClone));
                                    return true;
                                }
                            }
                        }
                    }
                    return true;
                } 

                if (fromGround) {
                    GameLoop.ZPO.Log.AddMessage("Your inventory is too full to pick up anything else right now.", Color.Crimson);
                    return false;
                }
                 
                if (curr.IsBank && CanUseBanks) {
                    BankItem(new(clone)); 
                    return true;
                }

                for (int i = 0; i < curr.ItemsHere.Count; i++) {
                    if (curr.ItemsHere[i].ID == item.ID && item.Noted == curr.ItemsHere[i].Noted && curr.ItemsHere[i].UseInt4 == item.UseInt4) {
                        curr.ItemsHere[i].Quantity += qty; 
                        return true; 
                    }
                }

                curr.ItemsHere.Add(clone);
                return true;
            }

            return false;
        }

        public void BankItem(ItemWrapper item) {  
            for (int j = 0; j < BankedItems.Count; j++) {
                if (BankedItems[j].ID == item.ID && BankedItems[j].Charges == item.Charges) {
                    BankedItems[j].Quantity += item.Quantity; 
                    return; 
                }
            }

            item.Noted = false;
            BankedItems.Add(item);
        }

        public bool TryDrop(int i) {
            if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? curr) && curr != null) {
                int qty = 1;
                                
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;

                if (qty > Inventory[i].Quantity || Helper.EitherAlt())
                    qty = Inventory[i].Quantity;


                if (Inventory[i].GetRef() is Item toDrop) {
                    if (curr.IsBank && CanUseBanks) {
                        ItemWrapper clone = Helper.Clone(Inventory[i]);
                        clone.Quantity = qty; 
                        BankItem(clone);

                        Inventory[i].Quantity -= qty; 
                    }
                    else {
                        if (curr.ShopItemsHere.Count == 0 || !CanUseShops) {
                            if (toDrop.DestroyOnDrop) {
                                if (Inventory[i].ID == "clueScrollTutorial") {
                                    CurrentClueTutorial = "";
                                } else if (Inventory[i].ID == "clueScrollBeginner") {
                                    CurrentClueBeginner = "";
                                } else if (Inventory[i].ID == "clueScrollEasy") {
                                    CurrentClueEasy = "";
                                } else if (Inventory[i].ID == "clueScrollMedium") {
                                    CurrentClueMedium = "";
                                } else if (Inventory[i].ID == "clueScrollHard") {
                                    CurrentClueHard = "";
                                } else if (Inventory[i].ID == "clueScrollElite") {
                                    CurrentClueElite = "";
                                } else if (Inventory[i].ID == "clueScrollMaster") {
                                    CurrentClueMaster = "";
                                }

                                Inventory.RemoveAt(i);
                                return true;
                            } else {
                                bool found = false;
                                for (int j = 0; j < curr.ItemsHere.Count; j++) {
                                    if (curr.ItemsHere[j].ID == Inventory[i].ID && curr.ItemsHere[j].Noted == Inventory[i].Noted && curr.ItemsHere[j].UseInt4 == Inventory[i].Charges) {
                                        curr.ItemsHere[j].Quantity += qty;
                                        Inventory[i].Quantity -= qty;
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found) {
                                    Item clone = Helper.Clone(toDrop);
                                    clone.Quantity = qty;

                                    curr.ItemsHere.Add(clone);
                                    Inventory[i].Quantity -= qty;
                                }
                            }
                        }
                        else {
                            int sellValue = toDrop.Value;

                            if (Inventory[i].Charges != 0 && toDrop.UseString == "Potion") {
                                sellValue *= Inventory[i].Charges;
                            } 
                                        
                            if (!ShopsAlwaysFullPrice && !curr.ShopItemsHere.Contains(Inventory[i].ID)) {
                                sellValue = (int) (Math.Floor(sellValue / 2.0));
                            }

                            HeldGold += sellValue * qty;
                            Inventory[i].Quantity -= qty;
                        }
                    }
                }

                if (Inventory[i].Quantity <= 0) {
                    Inventory.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }


        public void TryGrantExp(string which, int amount, MessageLog log, List<Skill> RecentSkills, bool buying = false) {
            if (Skills.ContainsKey(which)) { 
                int oldLevel = Skills[which].Level; 

                if (OnlyPayToWin && !buying)
                    return;

                if (PayToWin > 0 && buying) { 

                    if (HeldGold >= (PayToWin * amount)) {
                        HeldGold -= PayToWin * amount;
                        log.AddMessage(new ColoredString("Paid " + String.Format($"{PayToWin * amount:n0}") + " for " + (amount * ExpMultiplier) + " " + which + " experience.", Color.Goldenrod, Color.Black));
                    } else {
                        log.AddMessage(new ColoredString("Sorry, " + Name + "! I can't give credit. Come back when you're a little... mmmm... richer! (Need " + String.Format($"{PayToWin * amount:n0}") + "gp)", Color.Crimson, Color.Black));
                        return;
                    }
                }

                bool grantingExp = false;

                if (buying) {
                    grantingExp = true;
                } else {
                    if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? curr) && curr != null) {
                        if (curr.DungeoneeringLevel >= 1) {
                            if (GetEffectiveSkillLevel("Dungeoneering") >= curr.DungeoneeringLevel) {
                                grantingExp = true;
                                Skills["Dungeoneering"].GrantExp(((int) Math.Ceiling(amount / 5.0)) * ExpMultiplier, log, RecentSkills);
                            } else {
                                log.AddMessage("You need " + curr.DungeoneeringLevel + " Dungeoneering to gain experience here.", Color.Crimson);
                            }
                        } else {
                            grantingExp = true;
                        }
                    } else {
                        grantingExp = true;
                    }
                }

                if (grantingExp) {
                    Skills[which].GrantExp(amount * ExpMultiplier, log, RecentSkills);

                    if (which == "Constitution" && oldLevel != Skills[which].Level) {
                        CurrentHP += (Skills[which].Level - oldLevel);
                    }
                }
            } 
        } 

        public bool TakeDamage(int amt, MessageLog log) {  
            CurrentHP -= amt;

            if (CurrentHP <= 0 || (NightmareMode && amt > 0)) {
                Die(log);
                return true;
            }

            return false;
        }

        public void Die(MessageLog log) {
            if (DeathMode == 1) { // Drop all items
                if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? deathSpot)) {
                    if (deathSpot != null) {
                        for (int i = Inventory.Count - 1; i >= 0; i--) {
                            if (Inventory[i].GetRef() is Item drop) {
                                bool found = false;
                                for (int j = 0; j < deathSpot.ItemsHere.Count; j++) {
                                    if (deathSpot.ItemsHere[j].ID == Inventory[i].ID && drop.Stackable) {
                                        deathSpot.ItemsHere[j].Quantity += Inventory[i].Quantity;
                                        found = true;
                                        break;
                                    }
                                }

                                if (!found) {
                                    deathSpot.ItemsHere.Add(drop);
                                }

                                Inventory.RemoveAt(i);
                            }
                        }
                        
                        foreach (var kv in Equipment) { 
                            GameLoop.ZPO.TryPlaceItem(NavLoc, kv.Value); 
                        } 
                        Equipment.Clear();
                    }
                }
            }

            log.AddMessage(new ColoredString("Oh no, you died!", Color.Crimson, Color.Black));

            if (DeathMode == 2) { // Reset character and whole world so you can't cheese it by dropping items before dying then picking them up
                GameLoop.ZPO.RebuildLibraries();
                GameLoop.ZPO.SoftResetPlayer();
            } 

            NavLoc = NavRespawn;
            CurrentHP = Skills["Constitution"].Level;
        }



        public void AddFeat(string feat) {
            if (LocationLock) {
                if (!CompletedFeats.Contains(feat)) {
                    CompletedFeats.Add(feat);

                    foreach (var kv in UnlockedLocations) {
                        if (!kv.Value.Completed) {
                            kv.Value.CheckCompletion(this);
                        }
                    }
                }
            }
        }

        public bool PrayerActive(string which) {
            if (Prayers.TryGetValue(which, out Prayer? p)) {
                if (p != null) {
                    return p.Active;
                }
            } 

            return false;
        }

        public void TryTogglePrayer(string which) {
            if (Prayers.TryGetValue(which, out Prayer? p)) {
                if (p != null) {
                    if (p.Active) {
                        p.Active = false;
                        return;
                    } else { 
                        int PrayerLev = Skills["Prayer"].Level;
                        int EffectivePL = GetEffectiveSkillLevel("Prayer");

                        if (p.Level <= PrayerLev) {
                            if (TotalActivePrayers() + p.Level <= EffectivePL) {
                                p.Active = true;
                            } else { 
                                GameLoop.ZPO.Log.AddMessage(new ColoredString("You have too many prayers active to activate that one right now.", Color.Crimson, Color.Black));
                            }
                        } else {
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You aren't high enough level to activate that prayer yet.", Color.Crimson, Color.Black));
                        }
                    }
                }
            }
        }

        public int TotalActivePrayers() {
            int count = 0;

            foreach (var kv in Prayers) {
                if (kv.Value.Active) {
                    count += kv.Value.Level;
                }
            }

            return count;
        }

        public int GetEffectiveSkillLevel(string which) {
            if (Skills.TryGetValue(which, out Skill? s)) {
                if (s != null) {
                    int level = s.Level;

                    foreach (var pot in ActivePotions) {
                        if (pot.Stat == which) {
                            level += pot.Change;
                        }
                    }

                    foreach (var kv in Prayers) {
                        if (kv.Value.Active && kv.Value.SkillBuffed == which) {
                            level += (int) Math.Ceiling(kv.Value.Level / 2.0);
                        }
                    }

                    return level;
                }
            }

            return 1;  
        } 


        public bool CanCraft(CraftRecipe craft) {
            if (!Skills.ContainsKey(craft.Skill))
                return false;
            if (Skills[craft.Skill].Level < craft.Level)
                return false;
            if (!GameLoop.ZPO.ItemLibrary.ContainsKey(craft.OutputItem))
                return false;

            if (craft.ExtraTool != "") {
                bool hasTool = false;
                for (int i = 0; i < Inventory.Count; i++) {
                    if (Inventory[i].ID == craft.ExtraTool && !Inventory[i].Noted) {
                        hasTool = true;
                        break;
                    }
                }

                if (!hasTool)
                    return false;
            }


            return HasAllItems(craft.NeededItems, false, true);
        }

        public void TryCraft(CraftRecipe craft) {
            if (!CanCraft(craft))
                return;

            ConsumeItems(craft.NeededItems); 

            Item item = Helper.Clone(GameLoop.ZPO.ItemLibrary[craft.OutputItem]);
            if (item.Stackable) {
                for (int i = 0; i < craft.OutputQty; i++) {
                    Item clone = Helper.Clone(item);
                    TryPickup(clone, 1);
                }
            } else {
                item.Quantity = craft.OutputQty; 
                TryPickup(item, item.Quantity);
            }
            TryGrantExp(craft.Skill, craft.ExpGranted, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
        }

        public bool HasAllItems(List<string> items, bool notedOkay = false, bool equippedOkay = false) { 
            foreach (var itemString in items) {
                string item = itemString;
                int qty = 1;
                int countHeld = 0;

                if (itemString.Contains(",")) {
                    string[] split = itemString.Split(",");
                    
                    if (int.TryParse(split[1], out int parseQty)) {
                        qty = parseQty;
                    }

                    item = split[0];
                }

                // Check for items that count as the item but aren't the item (for example, elemental staves)
                for (int i = 0; i < Inventory.Count; i++) {
                    if (Inventory[i].GetRef() is Item comp && comp.MiscString == "CountsAs" && comp.UseString2 == item && !comp.MustBeEquipped) {
                        if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                            if (Inventory[i].Charges == -1) {
                                countHeld = qty;
                            } else { 
                                countHeld += comp.UseInt;
                            } 
                        }
                    }
                }

                if (equippedOkay) {
                    foreach (var kv in Equipment) {
                        if (kv.Value.GetRef() is Item eqp && eqp.MiscString == "CountsAs" && eqp.UseString2 == item) {
                            if (kv.Value.Charges == -1) {
                                countHeld = qty;
                            } else {
                                countHeld += kv.Value.Charges;
                            }
                        }
                    }
                } 


                // Check for actual copies of the item
                for (int i = 0; i < Inventory.Count; i++) {
                    if (Inventory[i].ID == item) {
                        if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                            countHeld += Inventory[i].Quantity;
                        }
                    }
                }

                if (equippedOkay) {
                    foreach (var kv in Equipment) {
                        if (kv.Value.ID == item) {
                            countHeld += kv.Value.Quantity;
                        }
                    }
                }

                if (countHeld < qty)
                    return false;
            }

            return true;
        }

        public void ConsumeItems(List<string> items, bool notedOkay = false, bool equippedOkay = false) {
            foreach (var itemString in items) {
                string item = itemString;
                int qty = 1;
                int countNeeded = 0;

                if (itemString.Contains(",")) {
                    string[] split = itemString.Split(",");
                    
                    if (int.TryParse(split[1], out int parseQty)) {
                        qty = parseQty;
                    }

                    item = split[0];
                }

                countNeeded = qty;

                // Check for items that count as the item but aren't the item (for example, elemental staves)
                for (int i = 0; i < Inventory.Count; i++) {
                    if (Inventory[i].GetRef() is Item comp && comp.MiscString == "CountsAs" && comp.UseString2 == item && !comp.MustBeEquipped) {
                        if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                            if (Inventory[i].Charges == -1) {
                                countNeeded = 0;
                            } else { 
                                if (Inventory[i].Charges > countNeeded) {
                                    Inventory[i].Charges -= countNeeded;
                                    countNeeded = 0; 
                                } else {
                                    countNeeded -= Inventory[i].Charges;
                                    Inventory[i].Charges = 0;
                                }
                            } 
                        }
                    }
                }

                if (equippedOkay) {
                    foreach (var kv in Equipment) {
                        if (kv.Value.GetRef() is Item eqp && eqp.MiscString == "CountsAs" && eqp.UseString2 == item) {
                            if (kv.Value.Charges == -1) {
                                countNeeded = 0;
                            } else {
                                if (kv.Value.Charges > countNeeded) {
                                    kv.Value.Charges -= countNeeded;
                                    countNeeded = 0; 
                                } else {
                                    countNeeded -= kv.Value.Charges;
                                    kv.Value.Charges = 0;
                                }
                            }
                        }
                    }
                } 

                if (countNeeded <= 0)
                    continue;


                // Check for the actual item matches
                for (int i = Inventory.Count - 1; i >= 0; i--) {
                    if (Inventory[i].ID == item) {
                        if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                            if (countNeeded > Inventory[i].Quantity) {
                                countNeeded -= Inventory[i].Quantity;
                                Inventory.RemoveAt(i); 
                            } else { 
                                Inventory[i].Quantity -= countNeeded;
                                countNeeded = 0;

                                if (Inventory[i].Quantity <= 0) {
                                    Inventory.RemoveAt(i); 
                                }
                            } 

                            if (countNeeded == 0)
                                break;
                        }
                    }
                }

                List<string> EquipClear = new();

                if (equippedOkay && countNeeded > 0) {
                    foreach (var kv in Equipment) {
                        if (kv.Value.ID == item) {
                            if (countNeeded > kv.Value.Quantity) {
                                countNeeded -= kv.Value.Quantity;
                                EquipClear.Add(kv.Key);
                            } else {
                                kv.Value.Quantity -= countNeeded;
                                countNeeded = 0;

                                if (kv.Value.Quantity <= 0) {
                                    EquipClear.Add(kv.Key);
                                }
                            } 
                        }
                    }
                }

                foreach (var kv in EquipClear) {
                    Equipment.Remove(kv);
                }
            }
        }


        public int TotalArmorValue(string against) {
            double count = 0;

            foreach (var kv in Equipment) {
                if (kv.Value.GetRef() is Item eqp) {
                    double num = eqp.EquipTier;
                    if (eqp.EquipSkill == "Defense") {
                        if (eqp.MiscString == "DefenseMelee") {
                            if (against == "Ranged") {
                                num *= 2;
                            }
                            if (against == "Magic") {
                                num = (int)Math.Floor(num / 2.0);
                            }
                        }

                        if (eqp.MiscString == "DefenseMagic") {
                            if (against == "Melee") {
                                num *= 2;
                            }
                            if (against == "Ranged") {
                                num = Math.Floor(num / 2.0);
                            }
                        }

                        if (eqp.MiscString == "DefenseRange") {
                            if (against == "Magic") {
                                num *= 2;
                            }
                            if (against == "Melee") {
                                num = Math.Floor(num / 2.0);
                            }
                        }

                        count += num;
                    }
                }
            }

            foreach (var kv in Equipment) {
                if (kv.Value.GetRef() is Item eqp && eqp.MiscString == "OmniBoost") {
                    count += eqp.EquipTier;
                }
            }

            count /= 5.0;



            return (int) Math.Ceiling(count);
        }


        public bool IsMaging() {
            if (CastingSpell == "")
                return false;
            if (!GameLoop.ZPO.SpellLibrary.ContainsKey(CastingSpell))
                return false;
            if (!Skills.ContainsKey("Magic"))
                return false;
            
            Spell spell = GameLoop.ZPO.SpellLibrary[CastingSpell];

            if (spell.Book != MagicBook)
                return false;

            if (spell.Level > Skills["Magic"].Level)
                return false;

            if (!HasAllItems(spell.Runes, false, true))
                return false;

            return true;
        }

        public string CanCast(Spell spell) {
            if (!Skills.ContainsKey("Magic"))
                return "Malformed skill list, Magic entry not found.";
            if (spell.Book != MagicBook)
                return "Incorrect spellbook active.";
            if (spell.Level > Skills["Magic"].Level)
                return "Need " + spell.Level + " Magic to cast that spell, only have " + Skills["Magic"].Level + ".";
            if (!HasAllItems(spell.Runes, false, true)) {
                string items = "";

                for (int i = 0; i < spell.Runes.Count; i++) {
                    string[] rune = spell.Runes[i].Split(",");
                    int qty = 0;

                    if (int.TryParse(rune[1], out qty)) {
                        if (i != 0)
                            items += ", ";
                        items += qty + "x " + GameLoop.ZPO.ResolveItemName(rune[0]); 
                    } 
                }

                return "Missing runes, need " + items + ".";
            }

            if (spell.TimeLastCast != 0 && spell.TimeLastCast + spell.CooldownInMS > Helper.Time()) {
                int timeLeft = (int) (((spell.TimeLastCast + spell.CooldownInMS) - Helper.Time()) / 1000);
                if (timeLeft > 60) {
                    int minutes = timeLeft / 60;
                    int seconds = timeLeft % 60;
                    return "On cooldown, " + minutes + "m " + seconds + "s remaining.";
                } else {
                    return "On cooldown, " + timeLeft + " seconds remaining.";
                }
            }

            return "";
        }
    }
}
