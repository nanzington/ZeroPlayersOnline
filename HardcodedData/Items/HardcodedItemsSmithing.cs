using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsSmithing {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();

            itemsToAdd.Add(new Item("Copper ore", "A pile of copper ore nuggets.", "oreCopper", Color.Orange, 3));
            itemsToAdd.Add(new Item("Copper ore spirit", "When mining copper, this is consumed and you will receive an extra ore.", "spiritOreCopper", Color.Orange, 20, true) { MiscString = "Spirit", UseString2 = "oreCopper" });
            itemsToAdd.Add(new Item("Tin ore", "A pile of tin ore nuggets.", "oreTin", Color.DarkGray, 3)); 
            itemsToAdd.Add(new Item("Tin ore spirit", "When mining tin, this is consumed and you will receive an extra ore.", "spiritOreTin", Color.DarkGray, 20, true) { MiscString = "Spirit", UseString2 = "oreTin" });
            itemsToAdd.Add(new Item("Bronze ore mix", "A mix of copper and tin ore nuggets.", "oreMixBronze", ColorLib.Bronze, 6)); 
            itemsToAdd.Add(new Item("Bronze bar", "It's a bar of bronze.", "barBronze", ColorLib.Bronze, 8));
            itemsToAdd.Add(new Item("Iron ore", "A pile of iron ore nuggets.", "oreIron", ColorLib.Bronze, 15)); 
            itemsToAdd.Add(new Item("Iron ore spirit", "When mining iron, this is consumed and you will receive an extra ore.", "spiritOreIron", ColorLib.Bronze, 20, true) { MiscString = "Spirit", UseString2 = "oreIron" });
            itemsToAdd.Add(new Item("Iron ore mix", "A mix iron ore nuggets with the impurities sifted out.", "oreMixIron", ColorLib.Bronze, 25)); 
            itemsToAdd.Add(new Item("Iron bar", "It's a bar of iron.", "barIron", ColorLib.Iron, 30));
            itemsToAdd.Add(new Item("Coal", "A lump of raw coal.", "oreCoal", Color.DimGray, 30)); 
            itemsToAdd.Add(new Item("Coal spirit", "When mining coal, this is consumed and you will receive an extra lump.", "spiritOreCoal", Color.DimGray, 20, true) { MiscString = "Spirit", UseString2 = "oreCoal" });
            itemsToAdd.Add(new Item("Steel ore mix", "A mix of iron ore nuggets and coal.", "oreMixSteel", ColorLib.Bronze, 45)); 
            itemsToAdd.Add(new Item("Steel bar", "It's a bar of iron.", "barSteel", ColorLib.Steel, 60)); 
            itemsToAdd.Add(new Item("Mithril ore", "A pile of mithril ore nuggets.", "oreMithril", ColorLib.Mithril, 60)); 
            itemsToAdd.Add(new Item("Mithril ore spirit", "When mining mithril, this is consumed and you will receive an extra ore.", "spiritOreMithril", ColorLib.Mithril, 20, true) { MiscString = "Spirit", UseString2 = "oreMithril" });
            itemsToAdd.Add(new Item("Mithril ore mix", "A mix of mithril ore nuggets and coal.", "oreMixMithril", ColorLib.Mithril, 90)); 
            itemsToAdd.Add(new Item("Mithril bar", "It's a bar of mithril.", "barMithril", ColorLib.Mithril, 120));
            itemsToAdd.Add(new Item("Luminite", "A lump of raw luminite.", "oreLuminite", Color.Yellow, 60));  
            itemsToAdd.Add(new Item("Luminite spirit", "When mining luminite, this is consumed and you will receive an extra lump.", "spiritOreLuminite", Color.Yellow, 20, true) { MiscString = "Spirit", UseString2 = "oreLuminite" });
            itemsToAdd.Add(new Item("Adamant ore", "A pile of adamant ore nuggets.", "oreAdamant", ColorLib.Adamant, 120)); 
            itemsToAdd.Add(new Item("Adamant ore spirit", "When mining adamant, this is consumed and you will receive an extra ore.", "spiritOreAdamant", ColorLib.Adamant, 20, true) { MiscString = "Spirit", UseString2 = "oreAdamant" });
            itemsToAdd.Add(new Item("Adamant ore mix", "A mix of adamant ore nuggets and luminite.", "oreMixAdamant", ColorLib.Adamant, 180)); 
            itemsToAdd.Add(new Item("Adamant bar", "It's a bar of adamant.", "barAdamant", ColorLib.Adamant, 240));
            itemsToAdd.Add(new Item("Runite ore", "A pile of runite ore nuggets.", "oreRunite", ColorLib.Rune, 300)); 
            itemsToAdd.Add(new Item("Runite ore spirit", "When mining runite, this is consumed and you will receive an extra ore.", "spiritOreRunite", ColorLib.Rune, 20, true) { MiscString = "Spirit", UseString2 = "oreRunite" });
            itemsToAdd.Add(new Item("Runite ore mix", "A mix of runite ore nuggets and luminite.", "oreMixRunite", ColorLib.Rune, 360)); 
            itemsToAdd.Add(new Item("Rune bar", "It's a bar of rune.", "barRune", ColorLib.Rune, 480));
            itemsToAdd.Add(new Item("Drakolith", "A lump of raw drakolith.", "oreDrakolith", Color.Yellow, 250));  
            itemsToAdd.Add(new Item("Drakolith spirit", "When mining drakolith, this is consumed and you will receive an extra lump.", "spiritOreDrakolith", Color.Yellow, 20, true) { MiscString = "Spirit", UseString2 = "oreDrakolith" });
            itemsToAdd.Add(new Item("Orichalcum ore", "A pile of orichalcum ore nuggets.", "oreOrichalcum", Color.Crimson, 500)); 
            itemsToAdd.Add(new Item("Orichalcum ore spirit", "When mining orichalcum, this is consumed and you will receive an extra ore.", "spiritOreOrichalcum", Color.Crimson, 20, true) { MiscString = "Spirit", UseString2 = "oreOrichalcum" });
            itemsToAdd.Add(new Item("Orichalcum ore mix", "A mix of orichalcum ore nuggets and drakolith.", "oreMixOrichalcum", Color.Crimson, 750)); 
            itemsToAdd.Add(new Item("Orichalcum bar", "It's a bar of orichalcum.", "barOrichalcum", Color.Crimson, 1000));
            itemsToAdd.Add(new Item("Phasmatite", "A lump of raw phasmatite.", "orePhasmatite", Color.SpringGreen, 500));  
            itemsToAdd.Add(new Item("Phasmatite spirit", "When mining phasmatite, this is consumed and you will receive an extra lump.", "spiritOrePhasmatite", Color.SpringGreen, 20, true) { MiscString = "Spirit", UseString2 = "orePhasmatite" });
            itemsToAdd.Add(new Item("Necrite ore", "A pile of necrite ore nuggets.", "oreNecrite", Color.ForestGreen, 1000)); 
            itemsToAdd.Add(new Item("Necrite ore spirit", "When mining necrite, this is consumed and you will receive an extra ore.", "spiritOreNecrite", Color.ForestGreen, 20, true) { MiscString = "Spirit", UseString2 = "oreNecrite" });
            itemsToAdd.Add(new Item("Necrite ore mix", "A mix of necrite ore nuggets and phasmatite.", "oreMixNecrite", Color.ForestGreen, 1500)); 
            itemsToAdd.Add(new Item("Necronium bar", "It's a bar of necronium.", "barNecronium", Color.ForestGreen, 2000)); 
            itemsToAdd.Add(new Item("Banite ore", "A pile of banite ore nuggets.", "oreBanite", Color.MediumSlateBlue, 1500)); 
            itemsToAdd.Add(new Item("Banite ore spirit", "When mining banite, this is consumed and you will receive an extra ore.", "spiritOreBanite", Color.MediumSlateBlue, 20, true) { MiscString = "Spirit", UseString2 = "oreBanite" });
            itemsToAdd.Add(new Item("Banite ore mix", "A mix of banite ore nuggets and phasmatite.", "oreMixBanite", Color.MediumSlateBlue, 3000)); 
            itemsToAdd.Add(new Item("Bane bar", "It's a bar of bane.", "barBane", Color.MediumSlateBlue, 4000)); 
            itemsToAdd.Add(new Item("Light animica", "The power of light condensed into an ore.", "oreAnimicaLight", Color.Turquoise, 3750, true));
            itemsToAdd.Add(new Item("Dark animica", "The power of darkness condensed into an ore.", "oreAnimicaDark", Color.Purple, 3750, true));
            itemsToAdd.Add(new Item("Animica mix", "A mix of light and dark animica.", "oreMixAnimica", Color.White, 7500)); 
            itemsToAdd.Add(new Item("Light animica ore spirit", "When mining light animica, this is consumed and you will receive an extra ore.", "spiritOreAnimicaLight", Color.Turquoise, 20, true) { MiscString = "Spirit", UseString2 = "oreAnimicaLight" });
            itemsToAdd.Add(new Item("Dark animica ore spirit", "When mining dark animica, this is consumed and you will receive an extra ore.", "spiritOreAnimicaDark", Color.Purple, 20, true) { MiscString = "Spirit", UseString2 = "oreAnimicaDark" });
            itemsToAdd.Add(new Item("Elder rune bar", "It's a bar of elder rune.", "barElderRune", ColorLib.Rune.GetBrighter(), 8000));
            itemsToAdd.Add(new Item("Silver ore", "A pile of silver ore nuggets.", "oreSilver", ColorLib.Steel, 50)); 
            itemsToAdd.Add(new Item("Silver ore spirit", "When mining silver, this is consumed and you will receive an extra ore.", "spiritOreSilver", ColorLib.Steel, 20, true) { MiscString = "Spirit", UseString2 = "oreSilver" });
            itemsToAdd.Add(new Item("Silver ore mix", "A mix silver ore nuggets with the impurities sifted out.", "oreMixSilver", ColorLib.Steel, 100)); 
            itemsToAdd.Add(new Item("Silver bar", "It's a bar of silver.", "barSilver", ColorLib.Steel, 150)); 
            itemsToAdd.Add(new Item("Gold ore", "A pile of gold ore nuggets.", "oreGold", Color.Goldenrod, 100)); 
            itemsToAdd.Add(new Item("Gold ore spirit", "When mining gold, this is consumed and you will receive an extra ore.", "spiritOreGold", Color.Goldenrod, 20, true) { MiscString = "Spirit", UseString2 = "oreGold" });
            itemsToAdd.Add(new Item("Gold ore mix", "A mix gold ore nuggets with the impurities sifted out.", "oreMixGold", Color.Goldenrod, 200)); 
            itemsToAdd.Add(new Item("Gold bar", "It's a bar of gold.", "barGold", Color.Goldenrod, 300));

            // Smithing Factory
            List<MaterialDef> Metals = new() {
                new("Tutorial", Color.White, 2, 1, 100, "slight"), 
                new("Bronze", ColorLib.Bronze, 1, 1, 15, "minimal"), 
                new("Iron", ColorLib.Iron, 2, 10, 45, "slight"),
                new("Black", Color.DimGray, 3, 10, 500, "sinister"),  
                new("Steel", ColorLib.Steel, 3, 20, 90, "adequate"), 
                new("Mithril", ColorLib.Mithril, 4, 30, 180, "good"),
                new("Adamant", ColorLib.Adamant, 5, 40, 360, "great"), 
                new("Rune", ColorLib.Rune, 6, 50, 720, "proprietary"), 
                new("Dragon", Color.Crimson.GetBrighter(), 8, 60, 1500, "draconic"),
                new("Orichalcum", Color.Crimson, 7, 60, 1500, "excellent"), 
                new("Necronium", Color.ForestGreen, 8, 70, 3000, "incredible"), 
                new("Bane", Color.MediumSlateBlue, 9, 80, 6000, "amazing"),
                new("Elder rune", ColorLib.Rune.GetBrighter(), 10, 90, 12000, "unbelievable")
            }; 

            for (int i = 0; i < Metals.Count; i++) {
                int fullMult = Metals[i].CostMultiplier;

                string tempName = Metals[i].Name == "Elder rune" ? "ElderRune" : Metals[i].Name;

                Item helm = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head.", "helm" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(helm);

                Item platebody = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso.", "platebody" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(platebody);

                Item chainmail = new Item(Metals[i].Name + " chainmail", "Provides " + Metals[i].Descriptor + " melee protection for the torso.", "chainmail" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(chainmail);

                Item platelegs = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs.", "platelegs" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(platelegs);

                Item plateskirt = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs.", "plateskirt" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(plateskirt);

                Item boots = new Item(Metals[i].Name + " boots", "Provides " + Metals[i].Descriptor + " melee protection for the feet.", "boots" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Feet",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(boots);

                Item gauntlets = new Item(Metals[i].Name + " gauntlets", "Provides " + Metals[i].Descriptor + " melee protection for the hands.", "gauntlets" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Hands",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(gauntlets);

                Item arrows = new Item(Metals[i].Name + " arrows", "Time flies like an arrow. Fruit flies like a banana.", "arrows" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true) {
                    EquipSlot = "Ammo",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedStandard"
                };
                itemsToAdd.Add(arrows);

                Item unfbolts = new Item(Metals[i].Name + " bolts (unf)", tempName + " crossbow bolts, sans feathers.", "boltsUnf" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true);
                itemsToAdd.Add(unfbolts);

                Item bolts = new Item(Metals[i].Name + " bolts", tempName + " crossbow bolts.", "bolts" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true) {
                    EquipSlot = "Ammo",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedHeavy"
                };
                itemsToAdd.Add(bolts);

                Item knives = new Item(Metals[i].Name + " knives", "A finely balanced throwing knife.", "knives" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 5, true) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedLight", EquipAmmo = "Self"
                };
                itemsToAdd.Add(knives);

                Item arrowheads = new Item(Metals[i].Name + " arrowheads", "I can make some arrows with these.", "arrowheads" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true);
                itemsToAdd.Add(arrowheads);

                Item hatchet = new Item(Metals[i].Name + " hatchet", "Good for chopping trees.", "hatchet" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult, misc: "Hatchet") {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash"
                };
                itemsToAdd.Add(hatchet);

                Item pickaxe = new Item(Metals[i].Name + " pickaxe", "Good for mining.", "pickaxe" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult, misc: "Pickaxe") {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab", AttackSpeed = 1.5
                };
                itemsToAdd.Add(pickaxe);

                Item dagger = new Item(Metals[i].Name + " dagger", "Good for stabbing.", "dagger" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab"
                };
                itemsToAdd.Add(dagger);

                Item sword = new Item(Metals[i].Name + " sword", "Good for slashing.", "sword" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash"
                };
                itemsToAdd.Add(sword);

                Item mace = new Item(Metals[i].Name + " mace", "Good for crushing.", "mace" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Crush"
                };
                itemsToAdd.Add(mace); 

                Item scimitar = new Item(Metals[i].Name + " scimitar", "Good for slashing quickly.", "scimitar" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash", AttackSpeed = 0.75
                };
                itemsToAdd.Add(scimitar);

                Item spear = new Item(Metals[i].Name + " spear", "Good for stabbing quickly.", "spear" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab", AttackSpeed = 0.75, TwoHanded = true
                };
                itemsToAdd.Add(spear);

                Item battleaxe = new Item(Metals[i].Name + " battleaxe", "Powerful slashes but slow.", "battleaxe" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash", AttackSpeed = 1.5, TwoHanded = true
                };
                itemsToAdd.Add(battleaxe);
                 
                Item sword2h = new Item(Metals[i].Name + " 2h sword", "Powerful stabs but slow.", "sword2h" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab", AttackSpeed = 1.5, TwoHanded = true
                };
                itemsToAdd.Add(sword2h);

                Item warhammer = new Item(Metals[i].Name + " warhammer", "Powerful crushing but slow.", "warhammer" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Crush", AttackSpeed = 1.5, TwoHanded = true
                };
                itemsToAdd.Add(warhammer);

                Item sqshield = new Item(Metals[i].Name + " square shield", "A medium square shield.", "sqShield" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Offhand",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(sqshield);

                Item kiteshield = new Item(Metals[i].Name + " kiteshield", "A large metal shield.", "kiteshield" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 3) {
                    EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(kiteshield);

                itemsToAdd.Add(new Item(Metals[i].Name + " crossbow limbs", "Can be combined with a crossbow stock to make an unstrung crossbow.", "limbs" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult));

                if (tempName == "Bronze" || tempName == "Bronze" || tempName == "Iron" || tempName == "Steel" || tempName == "Black" || tempName == "Mithril" || tempName == "Adamant") {
                    // Trimmed
                    Item helmT = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head. Trimmed.", "helm" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                        CosmeticNote = "t", EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(helmT); 

                    Item platebodyT = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso. Trimmed.", "platebody" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 10) {
                        CosmeticNote = "t", EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platebodyT);

                    Item platelegsT = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed.", "platelegs" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "t", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platelegsT);

                    Item plateskirtT = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed.", "plateskirt" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "t", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(plateskirtT);

                    Item kiteshieldT = new Item(Metals[i].Name + " kiteshield", "A large metal shield. Trimmed.", "kiteshield" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "t", EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(kiteshieldT);

                    // Gold trimmed
                    Item helmG = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head. Trimmed with gold.", "helm" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                        CosmeticNote = "g", EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(helmG); 

                    Item platebodyG = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso. Trimmed with gold.", "platebody" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 10) {
                        CosmeticNote = "g", EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platebodyG);

                    Item platelegsG = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed with gold.", "platelegs" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "g", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platelegsG);

                    Item plateskirtG = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed with gold.", "plateskirt" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "g", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(plateskirtG);

                    Item kiteshieldG = new Item(Metals[i].Name + " kiteshield", "A large metal shield. Trimmed with gold.", "kiteshield" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "g", EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(kiteshieldG);

                    // Heraldric
                    Item helmH = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head. Bears a heraldric design.", "helm" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                        CosmeticNote = "h", EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(helmH); 

                    Item platebodyH = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso. Bears a heraldric design.", "platebody" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 10) {
                        CosmeticNote = "h", EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platebodyH);

                    Item platelegsH = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Bears a heraldric design.", "platelegs" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "h", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platelegsH);

                    Item plateskirtH = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Bears a heraldric design.", "plateskirt" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "h", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(plateskirtH);

                    Item kiteshieldH = new Item(Metals[i].Name + " kiteshield", "A large metal shield. Bears a heraldric design.", "kiteshield" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "h", EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(kiteshieldH);
                }
            } 
             
            itemsToAdd.Add(new Item("Shield left half", "The left half of a dragon square shield.", "shieldLeftHalf", Color.Crimson.GetBrighter(), 110000));
            itemsToAdd.Add(new Item("Shield right half", "The right half of a dragon square shield.", "shieldRightHalf", Color.Crimson.GetBrighter(), 500000));
            


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
