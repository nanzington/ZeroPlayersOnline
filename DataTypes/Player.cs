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

        // Quality of Life options
        public bool CoinPouch = true; // aka HeldGold allowed to be used, or force player to use the coins item
        public bool CoinPouchDeath = false; // Drops the contents of your coin pouch when you die

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
        public string SlayerTaskFrom = "";
        public int SlayerAssignedKills = 0;
        public int SlayerKillsRemaining = 0; 
        public int SlayerTaskStreak = 0;
        public int SlayerPoints = 0;
        public bool SlayerTaskExtended = false;

        public string StoredTask = "";
        public string StoredTaskFrom = "";
        public int StoredKillsLeft = 0;
        public int StoredKillsAssigned = 0; 
        public bool StoredTaskExtended = false;

        public List<string> SlayerBlocked = new();
        public List<string> SlayerPrefer = new();
         
        public string ArtisanTask = "";
        public int ArtisanTaskRemaining = 0;
        public int ArtisanTaskStreak = 0;
        public int ArtisanPoints = 0;

        public int SecondsPlayed = 0;
        public int PoisonStatus = 0; 

        public int PizazzEnchantment = 0;
        public int PizazzGraveyard = 0;
        public int PizazzTelekinetic = 0;
        public int PizazzAlchemist = 0;
         

        public Dictionary<string, int> WorldState = new();

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
            double weaponTier = 1;
            bool maging = IsMaging();

            string style = "Melee";

            if (Equipment.TryGetValue("Weapon", out ItemWrapper? eqpWrap) && eqpWrap.GetRef() is Item eqp) {
                weaponTier = eqp.EquipTier;

                if (eqp.EquipSkill == "Ranged") {
                    style = "Ranged";
                    if (eqp.EquipAmmo == "RangedStandard" || eqp.EquipAmmo == "RangedHeavy") { // Only other option currently is Self, where we don't need to change weaponTier
                        if (Equipment.TryGetValue("Ammo", out ItemWrapper? ammoWrap) && ammoWrap.GetRef() is Item ammo) {
                            if (ammo.EquipLevel <= eqp.EquipLevel) {
                                weaponTier = ammo.EquipTier;
                            } else {
                                weaponTier = eqp.EquipTier;
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
            double strength = (int)Math.Clamp(Math.Floor(GetEffectiveSkillLevel("Strength") / 10f) + 1, 1, 10); 

            if (maging) { 
                style = "Magic";
                strength = GameLoop.ZPO.SpellLibrary[CastingSpell].Tier * 2;
            }

            if (style == "Ranged") {
                strength = (int)Math.Clamp(Math.Floor(GetEffectiveSkillLevel("Ranged") / 10f) + 1, 1, 10); 
            }

            double partialBoost = 0;
            foreach (var kv in Equipment) {
                if (kv.Value.GetRef() is Item item) {
                    if (item.MiscString == "OmniBoost" || item.MiscString == "OffenseBoost") {
                        strength += item.EquipTier;
                    }

                    if (item.MiscString == "PowerMelee" && style == "Melee") {
                        partialBoost += item.EquipTier / 5.0;
                    }

                    if (item.MiscString == "PowerRange" && style == "Ranged") {
                        partialBoost += item.EquipTier / 5.0;
                    }

                    if (item.MiscString == "PowerMagic" && style == "Magic") {
                        partialBoost += item.EquipTier / 5.0;
                    }

                    if (item.MiscString == "OffenseBoostMelee" && style == "Melee") {
                        partialBoost += item.EquipTier;
                    }
                    
                    if (item.MiscString == "OffenseBoostRange" && style == "Ranged") {
                        partialBoost += item.EquipTier;
                    }

                    if (item.MiscString == "OffenseBoostMagic" && style == "Magic") {
                        partialBoost += item.EquipTier;
                    }
                } 
            }

            strength += (int) Math.Floor(partialBoost);

            return ((int) Math.Floor(weaponTier)) + "d" + ((int) Math.Floor(strength));
        }

        public string GetDamageType() {
            if (IsMaging()) {
                return GameLoop.ZPO.SpellLibrary[CastingSpell].MiscString;
            }

            if (Equipment.TryGetValue("Weapon", out ItemWrapper? wepWrapper) && wepWrapper.GetRef() is Item wep)
                return wep.EquipDamageType;
            return "Crush";
        }

        public string GetSecondaryDamageType() {
            if (Equipment.TryGetValue("Weapon", out ItemWrapper? wepWrapper) && wepWrapper.GetRef() is Item wep)
                return wep.EquipSecondaryDamage;
            return "";
        }

        public bool TryPickup(ItemWrapper wrap, int qty, bool noted = false, bool shop = false, bool fromGround = false) {
            bool alreadyOwned = false;
            if (wrap.GetRef() is Item item && item.OnlyOneOwnable) {
                if (Helper.Requirement("ItemOwned", 1, wrap.ID)) {
                    GameLoop.ZPO.Log.AddMessage("You already own one of those (in inventory, bank, or equipped) and can't pick up another.", Color.Crimson);
                    alreadyOwned = true;
                }
            }

            if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? curr)) {
                ItemWrapper clone = new(wrap) { Quantity = qty };
                if (!alreadyOwned) {
                    for (int i = 0; i < Inventory.Count; i++) { 
                        if (Inventory[i].ID == wrap.ID && (Inventory[i].GetRef() is Item inv && (inv.Stackable || (noted && Inventory[i].Noted)))) {
                            Inventory[i].Quantity += qty; 
                            if (!shop)
                                wrap.Quantity -= qty;
                            return true; 
                        }
                    } 
             
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
                                ItemWrapper secondClone = new(clone);
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
                }

                if (fromGround) {
                    if (!alreadyOwned) {
                        GameLoop.ZPO.Log.AddMessage("Your inventory is too full to pick up anything else right now.", Color.Crimson);
                    }

                    return false;
                }
                 
                if (curr.IsBank && CanUseBanks && !alreadyOwned) {
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
            bool alreadyOwned = false;
            if (item.OnlyOneOwnable) {
                if (Helper.Requirement("ItemOwned", 1, item.ID)) {
                    GameLoop.ZPO.Log.AddMessage("You already own one of those (in inventory, bank, or equipped) and can't pick up another.", Color.Crimson);
                    alreadyOwned = true;
                }
            }

            if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? curr)) { 
                Item clone = new(item) { Quantity = qty };

                if (!alreadyOwned) {
                    for (int i = 0; i < Inventory.Count; i++) { 
                        if (Inventory[i].GetRef() is Item wrap && wrap.ID == item.ID && (wrap.Stackable || (noted && Inventory[i].Noted))) {
                            Inventory[i].Quantity += qty;
                            if (!shop)
                                item.Quantity -= qty;
                            return true; 
                        }
                    }
             
                    if (Inventory.Count < InventoryLimit) {
                        if (item.Stackable || (item.Noteable && noted)) { 
                            if (noted)
                                clone.Noted = true;
                            if (!shop)
                                item.Quantity -= qty;
                            Inventory.Add(new(clone));
                        } else {
                            for (int i = 0; i < qty; i++) { 
                                Item secondClone = new(clone) { Quantity = 1 }; 
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
                                        return false;
                                    }
                                }
                            }
                        }
                        return true;
                    } 
                }

                if (fromGround) {
                    GameLoop.ZPO.Log.AddMessage("Your inventory is too full to pick up anything else right now.", Color.Crimson);
                    return false;
                }
                 
                if (curr.IsBank && CanUseBanks && !alreadyOwned) {
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

        public bool TryDrop(int i, int qtyOverride = -1) {
            if (GameLoop.ZPO.Atlas.TryGetValue(NavLoc, out Location? curr) && curr != null) {
                int qty = 1;
                                
                if (Helper.EitherShift())
                    qty *= 5;
                if (Helper.EitherControl())
                    qty *= 10;

                if (qtyOverride != -1)
                    qty = qtyOverride;

                if (qty > Inventory[i].Quantity || Helper.EitherAlt())
                    qty = Inventory[i].Quantity; 

                if (Inventory[i].GetRef() is Item toDrop) {
                    if (curr.IsBank && CanUseBanks) {
                        ItemWrapper clone = new(Inventory[i]);
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
                                    Item clone = new(toDrop);
                                    clone.Quantity = qty;

                                    if (Inventory[i].Containing.Count > 0) {
                                        foreach (var con in Inventory[i].Containing) {
                                            clone.Containing.Add(new(con));
                                        }
                                    }

                                    curr.ItemsHere.Add(clone);
                                    Inventory[i].Quantity -= qty;
                                }
                            }
                        }
                        else {
                            if (Inventory[i].Containing.Count > 0) {
                                GameLoop.ZPO.Log.AddMessage("You probably don't want to sell that, and should remove all items from it first if you do.", Color.Crimson);
                            } else {
                                if (Inventory[i].ID == "coins") { 
                                    GameLoop.ZPO.Log.AddMessage("It is inadvisable to sell coins, as you're unlikely to get the better end of that deal.", Color.Crimson);
                                } else {
                                    int sellValue = toDrop.Value;

                                    if (Inventory[i].Charges != 0 && toDrop.UseString == "Potion") {
                                        sellValue *= Inventory[i].Charges;
                                    } 

                                    if (curr.ShopPriceMultiplier != 1.0) {
                                        sellValue = (int) (sellValue * curr.ShopPriceMultiplier);
                                    }
                                        
                                    if (!ShopsAlwaysFullPrice && !curr.ShopItemsHere.Contains(Inventory[i].ID)) {
                                        sellValue = (int) (Math.Floor(sellValue / 2.0));
                                    }

                                    GiveGold(sellValue * qty);
                                    Inventory[i].Quantity -= qty;
                                }
                            }
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


        public void TryGrantExp(string which, int amountIn, MessageLog log, List<Skill> RecentSkills, bool buying = false) {
            int amount = amountIn;

            foreach (var pot in ActivePotions) {
                if (pot.Stat == "Experience") {
                    amount = amount + ((int) Math.Ceiling(amount * (pot.Change / 100.0)));
                }
            }


            if (Skills.ContainsKey(which)) { 
                int oldLevel = Skills[which].Level; 

                if (OnlyPayToWin && !buying)
                    return;

                if (PayToWin > 0 && buying) { 

                    if (GoldTotal() >= (PayToWin * amount)) {
                        TakeGold(PayToWin * amount); 
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

            if (CurrentHP > 0) {
                int maxHP = GetEffectiveSkillLevel("Constitution");
                
                if (CurrentHP <  maxHP * 0.2) {
                    if (Equipment.TryGetValue("Amulet", out ItemWrapper? eqp) && eqp != null && eqp.ID == "necklacePhoenix") { 
                        CurrentHP = (int) Math.Clamp(CurrentHP + (maxHP * 0.3), CurrentHP, maxHP);
                         
                        log.AddMessage(new ColoredString("Your phoenix necklace restores you from low health, then shatters.", Color.White, Color.Black));
                        Equipment.Remove("Amulet"); 
                    }  
                }

                if (CurrentHP <  maxHP * 0.1) {
                    if (Equipment.TryGetValue("Ring", out ItemWrapper? eqp) && eqp != null && eqp.ID == "ringLife") {  
                        NavLoc = NavRespawn; 
                        log.AddMessage(new ColoredString("Your ring of life teleports you away from danger, then shatters.", Color.White, Color.Black));
                        Equipment.Remove("Ring"); 
                    }  
                }
            }

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
                            TryDrop(i, Inventory[i].Quantity);
                        }
                        
                        foreach (var kv in Equipment) { 
                            GameLoop.ZPO.TryPlaceItem(NavLoc, kv.Value); 
                        } 
                        Equipment.Clear();

                        if (HeldGold > 0 && CoinPouchDeath) {
                            if (GameLoop.ZPO.ResolveItem("coins") is Item coin) {
                                coin.Quantity = HeldGold;
                                GameLoop.ZPO.TryPlaceItem(NavLoc, new(coin));
                                HeldGold = 0;
                            }
                        }
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
            PoisonStatus = 0;
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
                    double level = s.Level;

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

                    foreach (var kv in Equipment) {
                        if (kv.Value.GetRef() is Item eqp) {
                            if (eqp.MiscString == which + "Boost") {
                                level += eqp.EquipTier;
                            }
                        }
                    }

                    if (CurrentHP < Skills["Constitution"].Level / 2) {
                        if (Equipment.TryGetValue("Amulet", out ItemWrapper? eqp) && eqp != null && eqp.ID == "necklaceFaith") {  
                            level = (int) Math.Ceiling((double) level * 1.25);
                        }
                    }

                    return (int) Math.Floor(level);
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

            foreach (var req in craft.Reqs) {
                if (!req.CheckRequirement(this, false, true)) {
                    return false;
                }
            }

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

            Item item = new(GameLoop.ZPO.ItemLibrary[craft.OutputItem]);
            if (item.Stackable) {
                for (int i = 0; i < craft.OutputQty; i++) {
                    Item clone = new(item);
                    TryPickup(clone, 1);
                }
            } else {
                item.Quantity = craft.OutputQty; 
                TryPickup(item, item.Quantity);
            }
            TryGrantExp(craft.Skill, craft.ExpGranted, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills);
        }

        public bool HasAllItems(List<string> items, bool notedOkay = false, bool equippedOkay = false, bool ONLYequipped = false) { 
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

                if (!ONLYequipped) {
                    // Check for items that count as the item but aren't the item (for example, elemental staves)
                    for (int i = 0; i < Inventory.Count; i++) {
                        if (Inventory[i].GetRef() is Item comp && comp.CountsAsIDs.Contains(item) && !comp.MustBeEquipped) {
                            if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                                if (Inventory[i].Charges == -1) {
                                    countHeld = qty;
                                } else { 
                                    if (comp.Stackable) { 
                                        countHeld += Inventory[i].Quantity;
                                    } else {
                                        countHeld += Inventory[i].Charges;
                                    }
                                } 
                            }
                        }

                        for (int con = 0; con < Inventory[i].Containing.Count; con++) {
                            if (Inventory[i].Containing[con].GetRef() is Item conInv && conInv.CountsAsIDs.Contains(item)) {
                                if (Inventory[i].Containing[con].Charges == -1) {
                                    countHeld = qty;
                                } else {
                                    if (conInv.Stackable) {
                                        countHeld += Inventory[i].Containing[con].Quantity;
                                    } else {
                                        countHeld += Inventory[i].Containing[con].Charges;
                                    }
                                }
                            }
                        }
                    }
                }

                if (equippedOkay) {
                    foreach (var kv in Equipment) {
                        if (kv.Value.GetRef() is Item eqp && eqp.CountsAsIDs.Contains(item)) {
                            if (kv.Value.Charges == -1) {
                                countHeld = qty;
                            } else {
                                if (eqp.Stackable) {
                                    countHeld += kv.Value.Quantity;
                                } else {
                                    countHeld += kv.Value.Charges;
                                }
                            }
                        }

                        for (int con = 0; con < kv.Value.Containing.Count; con++) {
                            if (kv.Value.Containing[con].GetRef() is Item conEqp && conEqp.CountsAsIDs.Contains(item)) {
                                if (kv.Value.Containing[con].Charges == -1) {
                                    countHeld = qty;
                                } else {
                                    if (conEqp.Stackable) {
                                        countHeld += kv.Value.Containing[con].Quantity;
                                    } else {
                                        countHeld += kv.Value.Containing[con].Charges;
                                    }
                                }
                            }
                        }
                    }
                } 


                if (!ONLYequipped) {
                    // Check for actual copies of the item
                    for (int i = 0; i < Inventory.Count; i++) {
                        if (Inventory[i].ID == item) {
                            if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) { 
                                countHeld += Inventory[i].Quantity;
                            }
                        }

                        for (int con = 0; con < Inventory[i].Containing.Count; con++) {
                            if (Inventory[i].Containing[con].ID == item) { 
                                countHeld += Inventory[i].Containing[con].Quantity; 
                            }
                        }
                    }
                }

                if (equippedOkay) {
                    foreach (var kv in Equipment) {
                        if (kv.Value.ID == item) {
                            countHeld += kv.Value.Quantity;
                        }

                        for (int con = 0; con < kv.Value.Containing.Count; con++) {
                            if (kv.Value.Containing[con].GetRef() is Item conEqp && conEqp.ID == item) { 
                                countHeld += kv.Value.Containing[con].Quantity; 
                            }
                        }
                    }
                }

                if (countHeld < qty)
                    return false;
            }

            return true;
        }

        public void ConsumeItems(List<string> items, bool notedOkay = false, bool equippedOkay = false) {
            Dictionary<string, int> CountsLeft = new();
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

                CountsLeft.Add(item, countNeeded);
            } 

            List<string> EquipClear = new();

            // Check for items that count as the item but aren't the item (for example, elemental staves) and have infinite charge
            for (int i = 0; i < Inventory.Count; i++) {
                if (Inventory[i].GetRef() is Item comp && !comp.MustBeEquipped) {
                    for (int j = 0; j < comp.CountsAsIDs.Count; j++) {
                        if (CountsLeft.ContainsKey(comp.CountsAsIDs[j])) {
                            if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                                if (Inventory[i].Charges == -1) {
                                    CountsLeft[comp.CountsAsIDs[j]] = 0;
                                }
                            }
                        }
                    }

                    if (CountsLeft.ContainsKey(Inventory[i].ID)) {
                        if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                            if (Inventory[i].Charges == -1) {
                                CountsLeft[Inventory[i].ID] = 0;
                            }
                        }
                    }
                }

                for (int con = 0; con < Inventory[i].Containing.Count; con++) { // Can any applicable item even be stored in a container? I have no idea
                    if (CountsLeft.ContainsKey(Inventory[i].Containing[con].ID)) {
                        if (!Inventory[i].Containing[con].Noted || (Inventory[i].Containing[con].Noted && notedOkay)) {
                            if (Inventory[i].Containing[con].Charges == -1) {
                                CountsLeft[Inventory[i].Containing[con].ID] = 0;
                            }
                        }
                    } 
                }
            }  

            if (equippedOkay) {
                foreach (var kv in Equipment) {
                    if (kv.Value.GetRef() is Item eqp) {
                        for (int j = 0; j < eqp.CountsAsIDs.Count; j++) {
                            if (CountsLeft.ContainsKey(eqp.CountsAsIDs[j])) {
                                if (!kv.Value.Noted || (kv.Value.Noted && notedOkay)) {
                                    if (kv.Value.Charges == -1) {
                                        CountsLeft[eqp.CountsAsIDs[j]] = 0;
                                    }
                                }
                            }
                        }

                        if (CountsLeft.ContainsKey(kv.Value.ID)) {
                            if (!kv.Value.Noted || (kv.Value.Noted && notedOkay)) {
                                if (kv.Value.Charges == -1) {
                                    CountsLeft[kv.Value.ID] = 0;
                                }
                            }
                        }
                    }

                    for (int con = 0; con < kv.Value.Containing.Count; con++) { // Can any applicable item even be stored in a container? I have no idea
                        if (CountsLeft.ContainsKey(kv.Value.Containing[con].ID)) {
                            if (!kv.Value.Containing[con].Noted || (kv.Value.Containing[con].Noted && notedOkay)) {
                                if (kv.Value.Containing[con].Charges == -1) {
                                    CountsLeft[kv.Value.Containing[con].ID] = 0;
                                }
                            }
                        } 
                    }
                }
            } 

            // Check for items that count as the item but aren't the item (for example, elemental staves)
            for (int i = Inventory.Count - 1; i >= 0; i--) {
                if (Inventory[i].GetRef() is Item comp && !comp.MustBeEquipped) {
                    int highestUsed = 0;
                    for (int j = 0; j < comp.CountsAsIDs.Count; j++) {
                        if (CountsLeft.ContainsKey(comp.CountsAsIDs[j])) {
                            if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                                if (Inventory[i].Charges == -1) {
                                    CountsLeft[comp.CountsAsIDs[j]] = 0;
                                } else {
                                    if (comp.Stackable) {
                                        if (Inventory[i].Quantity > CountsLeft[comp.CountsAsIDs[j]]) {
                                            highestUsed = Math.Max(highestUsed, CountsLeft[comp.CountsAsIDs[j]]);
                                            CountsLeft[comp.CountsAsIDs[j]] = 0; 
                                        } else {
                                            CountsLeft[comp.CountsAsIDs[j]] -= Inventory[i].Quantity;
                                            highestUsed = Math.Max(highestUsed, Inventory[i].Quantity); 
                                        }
                                    } else {
                                        if (Inventory[i].Charges > CountsLeft[comp.CountsAsIDs[j]]) {
                                            highestUsed = Math.Max(highestUsed, CountsLeft[comp.CountsAsIDs[j]]);
                                            CountsLeft[comp.CountsAsIDs[j]] = 0; 
                                        } else {
                                            CountsLeft[comp.CountsAsIDs[j]] -= Inventory[i].Charges;
                                            highestUsed = Math.Max(highestUsed, Inventory[i].Charges);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (highestUsed > 0) {
                        if (comp.Stackable) {
                            Inventory[i].Quantity -= highestUsed;
                            if (Inventory[i].Quantity <= 0) {
                                Inventory.RemoveAt(i); 
                                continue;
                            }
                        } else {
                            Inventory[i].Charges -= highestUsed;
                            if (Inventory[i].Charges <= 0 && comp.ShattersAtZeroCharges) {
                                Inventory.RemoveAt(i); 
                                continue;
                            } 
                        }
                    }

                    if (CountsLeft.ContainsKey(Inventory[i].ID)) {
                        if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                            if (Inventory[i].Charges == -1) {
                                CountsLeft[Inventory[i].ID] = 0;
                            } else {
                                if (comp.Stackable) {
                                    if (Inventory[i].Quantity > CountsLeft[Inventory[i].ID]) {
                                        Inventory[i].Quantity -= CountsLeft[Inventory[i].ID];
                                        CountsLeft[Inventory[i].ID] = 0; 
                                    } else {
                                        CountsLeft[Inventory[i].ID] -= Inventory[i].Quantity;
                                        Inventory[i].Quantity = 0;
                                        Inventory.RemoveAt(i);
                                        continue; 
                                    }
                                } else {
                                    if (Inventory[i].Charges > CountsLeft[Inventory[i].ID]) {
                                        Inventory[i].Charges -= CountsLeft[Inventory[i].ID];
                                        CountsLeft[Inventory[i].ID] = 0; 
                                    } else {
                                        CountsLeft[Inventory[i].ID] -= Inventory[i].Charges;
                                        Inventory[i].Charges = 0;
                                    }
                                }
                            }
                        }
                    }
                }

                if (Inventory[i].Containing.Count > 0) {
                    for (int condex = Inventory[i].Containing.Count - 1; condex >= 0; condex--) {
                        ItemWrapper con = Inventory[i].Containing[condex];
                        if (CountsLeft.ContainsKey(con.ID) && con.GetRef() is Item comp2) {
                            if (!con.Noted || (con.Noted && notedOkay)) {
                                if (con.Charges == -1) {
                                    CountsLeft[con.ID] = 0;
                                } else {
                                    if (comp2.Stackable) {
                                        if (con.Quantity > CountsLeft[con.ID]) {
                                            con.Quantity -= CountsLeft[con.ID];
                                            CountsLeft[con.ID] = 0; 
                                        } else {
                                            CountsLeft[con.ID] -= con.Quantity;
                                            con.Quantity = 0;
                                            Inventory[i].Containing.RemoveAt(condex);
                                            continue; 
                                        }
                                    } else {
                                        if (con.Charges > CountsLeft[con.ID]) {
                                            con.Charges -= CountsLeft[con.ID];
                                            CountsLeft[con.ID] = 0; 
                                        } else {
                                            CountsLeft[con.ID] -= con.Charges;
                                            con.Charges = 0;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }  

            if (equippedOkay) {
                foreach (var kv in Equipment) {
                    if (kv.Value.GetRef() is Item eqp) {
                        int highestUsed = 0;

                        for (int j = 0; j < eqp.CountsAsIDs.Count; j++) {
                            if (CountsLeft.ContainsKey(eqp.CountsAsIDs[j])) {
                                if (!kv.Value.Noted || (kv.Value.Noted && notedOkay)) {
                                    if (kv.Value.Charges == -1) {
                                        CountsLeft[eqp.CountsAsIDs[j]] = 0;
                                    } else {
                                        if (eqp.Stackable) {
                                            if (kv.Value.Quantity > CountsLeft[eqp.CountsAsIDs[j]]) {
                                                highestUsed = Math.Max(highestUsed, CountsLeft[eqp.CountsAsIDs[j]]);
                                                CountsLeft[eqp.CountsAsIDs[j]] = 0; 
                                            } else {
                                                CountsLeft[eqp.CountsAsIDs[j]] -= kv.Value.Quantity;
                                                highestUsed = Math.Max(highestUsed, kv.Value.Quantity);
                                                EquipClear.Add(kv.Key);
                                            }
                                        } else {
                                            if (kv.Value.Charges > CountsLeft[eqp.CountsAsIDs[j]]) {
                                                highestUsed = Math.Max(highestUsed, CountsLeft[eqp.CountsAsIDs[j]]);
                                                CountsLeft[eqp.CountsAsIDs[j]] = 0; 
                                            } else {
                                                CountsLeft[eqp.CountsAsIDs[j]] -= kv.Value.Charges;
                                                highestUsed = Math.Max(highestUsed, kv.Value.Charges);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (highestUsed > 0) {
                            if (eqp.Stackable) {
                                kv.Value.Quantity -= highestUsed;
                                if (kv.Value.Quantity <= 0) {
                                    EquipClear.Add(kv.Key);
                                }
                            } else {
                                kv.Value.Charges -= highestUsed;
                                if (kv.Value.Charges <= 0 && eqp.ShattersAtZeroCharges) {
                                    EquipClear.Add(kv.Key);
                                } 
                            }
                        }

                        if (CountsLeft.ContainsKey(kv.Value.ID)) {
                            if (!kv.Value.Noted || (kv.Value.Noted && notedOkay)) {
                                if (kv.Value.Charges == -1) {
                                    CountsLeft[kv.Value.ID] = 0;
                                } else {
                                    if (eqp.Stackable) {
                                        if (kv.Value.Quantity > CountsLeft[kv.Value.ID]) {
                                            kv.Value.Quantity -= CountsLeft[kv.Value.ID];
                                            CountsLeft[kv.Value.ID] = 0; 
                                        } else {
                                            CountsLeft[kv.Value.ID] -= kv.Value.Quantity;
                                            kv.Value.Quantity = 0;
                                            EquipClear.Add(kv.Key);
                                        }
                                    } else {
                                        if (kv.Value.Charges > CountsLeft[kv.Value.ID]) {
                                            kv.Value.Charges -= CountsLeft[kv.Value.ID];
                                            CountsLeft[kv.Value.ID] = 0; 
                                        } else {
                                            CountsLeft[kv.Value.ID] -= kv.Value.Charges;
                                            kv.Value.Charges = 0;

                                            if (eqp.ShattersAtZeroCharges)
                                                EquipClear.Add(kv.Key);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                    if (kv.Value.Containing.Count > 0) {
                        for (int condex = kv.Value.Containing.Count - 1; condex >= 0; condex--) {
                            ItemWrapper con = kv.Value.Containing[condex];
                            if (CountsLeft.ContainsKey(con.ID) && con.GetRef() is Item comp2) {
                                if (!con.Noted || (con.Noted && notedOkay)) {
                                    if (con.Charges == -1) {
                                        CountsLeft[con.ID] = 0;
                                    } else {
                                        if (comp2.Stackable) {
                                            if (con.Quantity > CountsLeft[con.ID]) {
                                                con.Quantity -= CountsLeft[con.ID];
                                                CountsLeft[con.ID] = 0; 
                                            } else {
                                                CountsLeft[con.ID] -= con.Quantity;
                                                con.Quantity = 0;
                                                kv.Value.Containing.RemoveAt(condex); 
                                                continue;
                                            }
                                        } else {
                                            if (con.Charges > CountsLeft[con.ID]) {
                                                con.Charges -= CountsLeft[con.ID];
                                                CountsLeft[con.ID] = 0; 
                                            } else {
                                                CountsLeft[con.ID] -= con.Charges;
                                                con.Charges = 0;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Check for the actual item matches
            for (int i = Inventory.Count - 1; i >= 0; i--) {
                if (CountsLeft.ContainsKey(Inventory[i].ID)) {
                    if (!Inventory[i].Noted || (Inventory[i].Noted && notedOkay)) {
                        if (CountsLeft[Inventory[i].ID] > Inventory[i].Quantity) {
                            CountsLeft[Inventory[i].ID] -= Inventory[i].Quantity;
                            Inventory.RemoveAt(i); 
                            continue;
                        } else { 
                            Inventory[i].Quantity -= CountsLeft[Inventory[i].ID];
                            CountsLeft[Inventory[i].ID] = 0;

                            if (Inventory[i].Quantity <= 0) {
                                Inventory.RemoveAt(i); 
                                continue;
                            }
                        }
                    }
                }

                if (Inventory[i].Containing.Count > 0) {
                    for (int condex = Inventory[i].Containing.Count - 1; condex >= 0; condex--) {
                        ItemWrapper con = Inventory[i].Containing[condex];

                        if (CountsLeft.ContainsKey(con.ID)) {
                            if (!con.Noted || (con.Noted && notedOkay)) {
                                if (CountsLeft[con.ID] > con.Quantity) {
                                    CountsLeft[con.ID] -= con.Quantity;
                                    Inventory[i].Containing.RemoveAt(condex);
                                    continue;
                                } else {
                                    con.Quantity -= CountsLeft[con.ID];
                                    CountsLeft[con.ID] = 0;

                                    if (con.Quantity <= 0) {
                                        Inventory[i].Containing.RemoveAt(condex);
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
            } 

            if (equippedOkay) {
                foreach (var kv in Equipment) {
                    if (CountsLeft.ContainsKey(kv.Value.ID)) {
                        if (CountsLeft[kv.Value.ID] > kv.Value.Quantity) {
                            CountsLeft[kv.Value.ID] -= kv.Value.Quantity;
                            EquipClear.Add(kv.Key);
                        } else {
                            kv.Value.Quantity -= CountsLeft[kv.Value.ID];
                            CountsLeft[kv.Value.ID] = 0;

                            if (kv.Value.Quantity <= 0) {
                                EquipClear.Add(kv.Key);
                            }
                        } 
                    }

                    if (kv.Value.Containing.Count > 0) {
                        for (int condex = kv.Value.Containing.Count - 1; condex >= 0; condex--) {
                            ItemWrapper con = kv.Value.Containing[condex];

                            if (CountsLeft.ContainsKey(con.ID)) {
                                if (!con.Noted || (con.Noted && notedOkay)) {
                                    if (CountsLeft[con.ID] > con.Quantity) {
                                        CountsLeft[con.ID] -= con.Quantity;
                                        kv.Value.Containing.RemoveAt(condex);
                                    } else {
                                        con.Quantity -= CountsLeft[con.ID];
                                        CountsLeft[con.ID] = 0;

                                        if (con.Quantity <= 0) {
                                            kv.Value.Containing.RemoveAt(condex);
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var kv in EquipClear) {
                Equipment.Remove(kv);
            } 
        }


        public int TotalArmorValue(string against) {
            double count = 0;

            foreach (var kv in Equipment) {
                if (kv.Value.GetRef() is Item eqp) {
                    double num = eqp.EquipTier;
                    if (eqp.EquipSkill == "Defense" || eqp.MiscString == "DefenseAll") {
                        if (eqp.MiscString == "DefenseMelee") {
                            if (against == "Ranged") {
                                num *= 2;
                            }
                            if (against == "Magic") {
                                num = (int)Math.Floor(num / 2.0);
                            }

                            if (eqp.MiscString == "PowerMelee") {
                                num = Math.Floor(num * 0.8);
                            }
                        }

                        if (eqp.MiscString == "DefenseMagic" || eqp.MiscString == "PowerMagic") {
                            if (against == "Melee") {
                                num *= 2;
                            }
                            if (against == "Ranged") {
                                num = Math.Floor(num / 2.0);
                            }

                            if (eqp.MiscString == "PowerMagic") {
                                num = Math.Floor(num * 0.8);
                            }
                        }

                        if (eqp.MiscString == "DefenseRange") {
                            if (against == "Magic") {
                                num *= 2;
                            }
                            if (against == "Melee") {
                                num = Math.Floor(num / 2.0);
                            }

                            if (eqp.MiscString == "PowerRange") {
                                num = Math.Floor(num * 0.8);
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

            for (int i = 0; i < spell.ToCast.Count; i++) {
                if (!spell.ToCast[i].CheckRequirement(this, false)) {
                    return "Missing Requirement: " + spell.ToCast[i].GetSummary();
                }
            }

            return "";
        }

        public void TryAddPotionEffect(string stat, int change) {
            bool found = false;
            for (int j = 0; j < ActivePotions.Count; j++) {
                if (ActivePotions[j].Stat == stat) {
                    if (ActivePotions[j].Change < 0) {
                        ActivePotions[j].Change += change;
                        found = true;
                    } else {
                        if (ActivePotions[j].Change < change) {
                            ActivePotions[j].Change = change;
                            found = true;
                        }
                    }
                }
            }
            if (!found)
                ActivePotions.Add(new(stat, change));
        }

        public bool HasLightSource() {
            foreach (var kv in Inventory) {
                if (kv.GetRef() is Item item) {
                    if (item.ProvidesLight) { return true; }
                }
            }

            foreach (var kv in Equipment) {
                if (kv.Value.GetRef() is Item eqp) {
                    if (eqp.ProvidesLight) { return true; }
                }
            }

            return false;
        }

        public bool HasOpenFlame() {
            foreach (var kv in Inventory) {
                if (kv.GetRef() is Item item) {
                    if (item.ExposedFlame) { return true; }
                }
            }

            foreach (var kv in Equipment) {
                if (kv.Value.GetRef() is Item eqp) {
                    if (eqp.ExposedFlame) { return true; }
                }
            }

            return false;
        }

        public void ExtinguishLights(bool coveredToo) {
            foreach (var kv in Inventory) {
                if (kv.GetRef() is Item item) {
                    if (item.Name.Contains("(lit)") && (item.ExposedFlame || (!item.ExposedFlame && coveredToo)) && item.UseString != "" && GameLoop.ZPO.ItemLibrary.ContainsKey(item.UseString2)) {
                        kv.ID = item.UseString2;
                        GameLoop.ZPO.Log.AddMessage("Your " + GameLoop.ZPO.ResolveItemName(kv.ID) + " is extinguished!");
                    }
                }
            }
        }

        public bool HasMinigameItem() { // TODO: Placeholder, Implement this when there are things you carry around that need to display minigame info, like construction contracts
            return false;
        }

        public void TakeGold(int amount) {
            int qtyLeft = amount;
            if (CoinPouch && HeldGold >= qtyLeft) { HeldGold -= qtyLeft; qtyLeft = 0; } 
            if (qtyLeft > 0 && CoinPouch) { qtyLeft -= HeldGold; HeldGold = 0; } 
            if (qtyLeft > 0) { ConsumeItems(["coins," + qtyLeft]); }
        }

        public void GiveGold(int amount) {
            if (CoinPouch) { HeldGold += amount; }
            else {
                if (GameLoop.ZPO.ResolveItem("coins") is Item coin) {
                    TryPickup(new Item(coin), amount);
                }
            }
        }

        public int GoldTotal() {
            int total = 0;

            if (CoinPouch) { total += HeldGold; }

            foreach (var kv in Inventory) {
                if (kv.ID == "coins") { total += kv.Quantity; }
                if (kv.Containing.Count > 0) {
                    foreach (var con in kv.Containing) {
                        if (con.ID == "coins") { total += con.Quantity; }
                    }
                }
            }

            foreach (var kv in Equipment) {
                if (kv.Value.ID == "coins") { total += kv.Value.Quantity; }
                if (kv.Value.Containing.Count > 0) {
                    foreach (var con in kv.Value.Containing) {
                        if (con.ID == "coins") { total += con.Quantity; }
                    }
                }
            }

            return total;
        }

        public void TryProgressQuest(string ID, int stage) {
            if (GameLoop.ZPO.QuestLibrary.TryGetValue(ID, out Quest? quest)) {
                if (QuestLog.TryGetValue(ID, out QuestStatus? status)) {
                    if (status.CurrentStage < stage) {
                        status.CurrentStage = stage;
                        if (status.CurrentStage == quest.CompleteStage) { 
                            GameLoop.ZPO.Log.AddMessage(new ColoredString("You have completed " + quest.Name + "!", Color.Lime, Color.Black));
                            quest.ProcessRewards(this);
                        }
                    }
                }
            }
        }

        public void ProgressSlayerTask(AreaMonster AttackingMonster) {
            if (AttackingMonster.ID == SlayerTask || (AttackingMonster.CountsAsSlayer.Contains(SlayerTask))) {
                if (Equipment.TryGetValue("Hands", out ItemWrapper? eqp) && eqp != null && eqp.ID == "braceletExpeditious" && GameLoop.rand.Next(4) == 0) { 
                    eqp.Charges -= 1; 
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Your expeditious bracelet made that kill count double!", Color.AntiqueWhite, Color.Black));

                    if (eqp.Charges <= 0) { 
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Your expeditious bracelet runs out of charge and shatters.", Color.Crimson, Color.Black));
                        Equipment.Remove("Hands");
                    }
                    SlayerKillsRemaining -= 2;
                } else if (Equipment.TryGetValue("Hands", out ItemWrapper? eqp2) && eqp2 != null && eqp2.ID == "braceletSlaughter" && GameLoop.rand.Next(4) == 0) { 
                    eqp2.Charges -= 1; 
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Your bracelet of slaughter made that kill count not count.", Color.Magenta, Color.Black));

                    if (eqp2.Charges <= 0) { 
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Your bracelet of slaughter runs out of charge and shatters.", Color.Crimson, Color.Black));
                        Equipment.Remove("Hands");
                    }
                } else { 
                    SlayerKillsRemaining--;
                }

                if (SlayerKillsRemaining <= 0) {
                    GameLoop.ZPO.Log.AddMessage("You have finished your Slayer task and should go get another.", Color.MediumPurple);
                    SlayerTask = "";
                    SlayerKillsRemaining = 0;
                    SlayerAssignedKills = 0;
                    SlayerTaskExtended = false;
                    
                    SlayerTaskStreak++;

                    if (SlayerTaskFrom == "mistLumJacquelyn") {
                        if (SlayerTaskStreak % 50 == 0) { SlayerPoints += QuestCompleted("DES_SmokingKills") ? 15 : 7; }
                        else if (SlayerTaskStreak % 10 == 0) { SlayerPoints += QuestCompleted("DES_SmokingKills)") ? 5 : 2; }
                        else { SlayerPoints += QuestCompleted("DES_SmokingKills)") ? 1 : 1; }
                    }

                    SlayerTaskFrom = "";
                }
            }
        }

        public void ProgressSlayerTask(BossFight boss) {
            if (boss.ID == SlayerTask || (boss.CountsAsSlayer.Contains(SlayerTask))) {
                if (Equipment.TryGetValue("Hands", out ItemWrapper? eqp) && eqp != null && eqp.ID == "braceletExpeditious" && GameLoop.rand.Next(4) == 0) { 
                    eqp.Charges -= 1; 
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Your expeditious bracelet made that kill count double!", Color.AntiqueWhite, Color.Black));

                    if (eqp.Charges <= 0) { 
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Your expeditious bracelet runs out of charge and shatters.", Color.Crimson, Color.Black));
                        Equipment.Remove("Hands");
                    }
                    SlayerKillsRemaining -= 2;
                } else if (Equipment.TryGetValue("Hands", out ItemWrapper? eqp2) && eqp2 != null && eqp2.ID == "braceletSlaughter" && GameLoop.rand.Next(4) == 0) { 
                    eqp2.Charges -= 1; 
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("Your bracelet of slaughter made that kill count not count.", Color.Magenta, Color.Black));

                    if (eqp2.Charges <= 0) { 
                        GameLoop.ZPO.Log.AddMessage(new ColoredString("Your bracelet of slaughter runs out of charge and shatters.", Color.Crimson, Color.Black));
                        Equipment.Remove("Hands");
                    }
                } else { 
                    SlayerKillsRemaining--;
                }

                if (SlayerKillsRemaining <= 0) {
                    GameLoop.ZPO.Log.AddMessage("You have finished your Slayer task and should go get another.", Color.MediumPurple);
                    SlayerTask = "";
                    SlayerKillsRemaining = 0;
                    SlayerAssignedKills = 0;
                    SlayerTaskExtended = false;
                    
                    SlayerTaskStreak++;

                    if (SlayerTaskFrom == "mistLumJacquelyn") {
                        if (SlayerTaskStreak % 50 == 0) { SlayerPoints += QuestCompleted("DES_SmokingKills") ? 15 : 7; }
                        else if (SlayerTaskStreak % 10 == 0) { SlayerPoints += QuestCompleted("DES_SmokingKills)") ? 5 : 2; }
                        else { SlayerPoints += QuestCompleted("DES_SmokingKills)") ? 1 : 1; }
                    }

                    SlayerTaskFrom = ""; 
                }
            }
        }

        public bool QuestCompleted(string id) {
            if (GameLoop.ZPO.QuestLibrary.TryGetValue(id, out Quest? quest)) {
                if (QuestLog.TryGetValue(id, out QuestStatus? status)) {
                    if (status.CurrentStage == quest.CompleteStage) {
                        return true;
                    }
                }
            }

            return false;
        }

        public int GetQuestPoints(bool total = false) { 
            int questPoints = 0;
            int totalPossibleQP = 0; 

            foreach (var kv in GameLoop.ZPO.QuestLibrary) {
                totalPossibleQP += kv.Value.QuestPoints;
                if (kv.Value.CurrentStage() == kv.Value.CompleteStage)
                    questPoints += kv.Value.QuestPoints;
            }

            return total ? totalPossibleQP : questPoints;
        }
    }
}
