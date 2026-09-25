using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsCrafting {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();

            itemsToAdd.Add(new Item("Wool", "Nice and fluffy.", "woolRaw", 255, 255, 255, 5));
            itemsToAdd.Add(new Item("Bark", "Bark from a hollow tree.", "bark", Color.SaddleBrown, 50));
            itemsToAdd.Add(new Item("Fine cloth", "Amazingly untouched by time.", "clothFine", Color.SaddleBrown, 500)); 
            itemsToAdd.Add(new Item("Silk", "It's a sheet of silk.", "clothSilk", Color.AntiqueWhite, 30)); 
            itemsToAdd.Add(new Item("Ball of wool", "Spun from wool.", "woolBall", 255, 255, 255, 7)); 
            itemsToAdd.Add(new Item("Chisel", "Good for detailed crafting.", "chisel", Color.SaddleBrown, 14));

            itemsToAdd.Add(new Item("Ammo mould", "Used to make cannon ammunition.", "mouldAmmo", Color.Gray, 5));
            itemsToAdd.Add(new Item("Amulet mould", "Used to make amulets.", "mouldAmulet", Color.White, 5));
            itemsToAdd.Add(new Item("Bracelet mould", "Used to make bracelets and anklets.", "mouldBracelet", Color.White, 5));
            itemsToAdd.Add(new Item("Bolt mould", "Used to make silver crossbow bolts.", "mouldBolt", Color.White, 25)); 
            itemsToAdd.Add(new Item("Chain link mould", "Used to make chain links.", "mouldChainlink", Color.Gray, 3));
            itemsToAdd.Add(new Item("Conductor mould", "Used to make silver lightning conductors.", "mouldConductor", Color.White, 3));
            itemsToAdd.Add(new Item("Demonic sigil mould", "Used to make the sigil of the demon Agrith Naar.", "mouldDemonicSigil", Color.White, 5));
            itemsToAdd.Add(new Item("Gnomebowl mould", "A large ovenproof bowl.", "mouldGnomebowl", Color.White, 10));
            itemsToAdd.Add(new Item("Holy mould", "Used to make holy symbols of Saradomin.", "mouldHoly", Color.White, 5));
            itemsToAdd.Add(new Item("Key mould", "A key mould, made from a ragged book.", "mouldKey", Color.White, 1));
            itemsToAdd.Add(new Item("Lens mould", "An unusual mould in the shape of a disc.", "mouldLens", Color.Gray, 1));
            itemsToAdd.Add(new Item("M'speak amulet mould", "It's an amulet mould shaped like a monkey head.", "mouldAmuletMonkeyspeak", Color.White, 10));
            itemsToAdd.Add(new Item("Necklace mould", "Used to make necklaces.", "mouldNecklace", Color.White, 5));
            itemsToAdd.Add(new Item("Ring mould", "Used to make rings.", "mouldRing", Color.White, 5));
            itemsToAdd.Add(new Item("Rod clay mould", "Rod of Ivandis mould.", "mouldRodClay", Color.SandyBrown, 5));
            itemsToAdd.Add(new Item("Sickle mould", "Used to make sickles.", "mouldSickle", Color.White, 10));
            itemsToAdd.Add(new Item("Tiara mould", "A mould for tiaras.", "mouldTiara", Color.SaddleBrown, 100));
            itemsToAdd.Add(new Item("Unholy mould", "Used to make unholy symbols.", "mouldUnholy", Color.White, 200));

            // Jewellery Factory
            List<MaterialDef> Jewels = new() {
                new("Gold", Color.Goldenrod, 0, 5, 400, "Gold"),
                new("Opal", Color.AntiqueWhite, 1, 7, 350, "Opal"),
                new("Jade", Color.PaleGreen, 1, 27, 400, "Jade"),
                new("Red topaz", Color.Magenta, 1, 49, 450, "RedTopaz"),
                new("Sapphire", Color.DeepSkyBlue, 2, 7, 1000, "Sapphire"),
                new("Emerald", Color.Lime, 3, 27, 1500, "Emerald"),
                new("Ruby", Color.Crimson, 4, 49, 2200, "Ruby"),
                new("Diamond", Color.White, 5, 57, 3500, "Diamond"),
                new("Dragonstone", Color.Purple, 6, 68, 18000, "Dragonstone"),
                new("Onyx", Color.DimGray, 7, 87, 1000000, "Onyx"),
                new("Zenyte", Color.Orange, 8, 93, 15000000, "Zenyte")
            };

            foreach (var mat in Jewels) {
                if (mat.Name != "Gold") {
                    itemsToAdd.Add(new Item("Uncut " + mat.Name.ToLower(), "An uncut " + mat.Name.ToLower() + ". Used in Crafting (" + mat.Level + ").", "uncut" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier - 300));
                    itemsToAdd.Add(new Item(mat.Name, "This looks valuable.", "cut" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier));
                }
                itemsToAdd.Add(new Item(mat.Name + " ring", "A ring made from " + mat.Name.ToLower() + ".", "ring" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Ring" });
                itemsToAdd.Add(new Item(mat.Name + " amulet", "An amulet made from " + mat.Name.ToLower() + ".", "amulet" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Amulet" });
                itemsToAdd.Add(new Item(mat.Name + " amulet (u)", "An unstrung amulet made from " + mat.Name.ToLower() + ". Can be strung with a ball of wool.", "amulet" + mat.Descriptor + "U", mat.R, mat.G, mat.B, mat.CostMultiplier));
                itemsToAdd.Add(new Item(mat.Name + " necklace", "A necklace made from " + mat.Name.ToLower() + ".", "necklace" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Amulet" });
                itemsToAdd.Add(new Item(mat.Name + " bracelet", "A bracelet made from " + mat.Name.ToLower() + ".", "bracelet" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Hands" });
            }
                
            itemsToAdd.Add(new Item("Unstrung symbol", "It needs a string so I can wear it.", "unstrungSymbol", Color.Gray, 200));
            itemsToAdd.Add(new Item("Unblessed symbol", "A symbol of Saradomin.", "unblessedSymbol", Color.Gray, 200) { EquipSlot = "Amulet" });
            itemsToAdd.Add(new Item("Holy symbol", "A blessed holy symbol of Saradomin.", "holySymbol", Color.DarkGray, 300) { EquipSlot = "Amulet", MiscString = "PrayerBoost", EquipTier = 1 });
            itemsToAdd.Add(new Item("Brass necklace", "I'd prefer a gold one.", "necklaceBrass", ColorLib.Bronze.GetBright(), 30) { EquipSlot = "Amulet" });
            itemsToAdd.Add(new Item("Amulet of accuracy", "It increases my aim.", "amuletAccuracy", Color.Orange, 100) { EquipSlot = "Amulet", MiscString = "HitChance", EquipTier = 10 });
                
            itemsToAdd.Add(new Item("Amulet of magic", "An enchanted sapphire amulet of magic.", "amuletMagic", Color.DeepSkyBlue, 1100) { EquipSlot = "Amulet", MiscString = "MagicBoost", EquipTier = 5 });
            itemsToAdd.Add(new Item("Ring of recoil", "Reflects part of damage taken back to the attacker.", "ringRecoil", Color.DeepSkyBlue, 1100) { EquipSlot = "Ring", UseInt4 = 40 });
            itemsToAdd.Add(new Item("Games necklace", "An enchanted sapphire necklace.", "necklaceGames", Color.DeepSkyBlue, 1100) { EquipSlot = "Amulet", UseInt4 = 8, UseString = "TeleportMenuCost", TeleportLocations = ["ASG_Burthorpe", "KAN_BarbOutpost", "WILD_CorpLair", "MIST_TearsOfGuthix", "KOUR_WintertodtCamp", "DES_GiantsPlateau", "DES_MageTrainingArena", "KAN_CastleWarsLobby"] });
            itemsToAdd.Add(new Item("Bracelet of clay", "Now I can become a potter.", "braceletClay", Color.DeepSkyBlue, 1100) { EquipSlot = "Hands", UseInt4 = 20 });
                
            itemsToAdd.Add(new Item("Amulet of bounty", "25% chance to not consume a seed when planting.", "amuletBounty", Color.AntiqueWhite, 450) { EquipSlot = "Amulet", UseInt4 = 10 });
            itemsToAdd.Add(new Item("Ring of pursuit", "This ring increases your chance to catch hunter creatures in traps.", "ringPursuit", Color.AntiqueWhite, 450) { EquipSlot = "Ring", UseInt4 = 20 });
            itemsToAdd.Add(new Item("Dodgy necklace", "25% chance to avoid damage from failed pickpocketing.", "necklaceDodgy", Color.AntiqueWhite, 450) { EquipSlot = "Amulet", UseInt4 = 10 });
            itemsToAdd.Add(new Item("Expeditious bracelet", "25% chance for one slayer kill to count as two.", "braceletExpeditious", Color.AntiqueWhite, 450) { EquipSlot = "Hands", UseInt4 = 30 });
                
            itemsToAdd.Add(new Item("Amulet of defense", "An enchanted emerald amulet of defense.", "amuletDefense", Color.Lime, 1600) { EquipSlot = "Amulet", MiscString = "DefenseAll", EquipTier = 5 });
            itemsToAdd.Add(new Item("Ring of dueling", "An enchanted emerald ring.", "ringDueling", Color.Lime, 1600) { EquipSlot = "Ring", UseInt4 = 8, UseString = "TeleportMenuCost", TeleportLocations = ["DES_AlKharidEmirsArena", "KAN_CastleWarsLobby", "WILD_FeroxEnclave", "VAR_FortisColosseum" ] });
            itemsToAdd.Add(new Item("Binding necklace", "A necklace embedded with mystical power.", "necklaceBinding", Color.Lime, 1600) { EquipSlot = "Amulet", UseInt4 = 16 });
            itemsToAdd.Add(new Item("Castle wars bracelet", "Must be worn as you enter the game to receive the bonus for that game.", "braceletCastleWars", Color.Lime, 1600) { EquipSlot = "Hands", UseInt4 = 3 }); // TODO: If Castle Wars ever gets implemented, make this work
                
            itemsToAdd.Add(new Item("Amulet of chemistry", "An enchanted emerald amulet of defense.", "amuletChemistry", Color.PaleGreen, 500) { EquipSlot = "Amulet", UseInt4 = 5 });
            itemsToAdd.Add(new Item("Ring of returning", "This ring returns you to your spawn point.", "ringReturning", Color.PaleGreen, 500) { EquipSlot = "Ring", UseInt4 = 5, UseString = "TeleSpawn" });
            itemsToAdd.Add(new Item("Necklace of passage", "This necklace can really take you places.", "necklacePassage", Color.PaleGreen, 500) { EquipSlot = "Amulet", UseInt4 = 5, UseString = "TeleportMenuCost", TeleportLocations = ["MIST_WizardTowerBridge", "KAN_Outpost", "DES_Eagles", "SEA_Wyrmscraig"] });
            itemsToAdd.Add(new Item("Flaemtaer bracelet", "Helps when building the Shades of Mort'ton temple.", "braceletFlamtaer", Color.PaleGreen, 500) { EquipSlot = "Hands", UseInt4 = 80 }); // TODO: If Shades of Mort'ton ever gets implemented, make this work
                
            itemsToAdd.Add(new Item("Amulet of strength", "An enchanted ruby amulet of strength.", "amuletStrength", Color.Crimson, 2300) { EquipSlot = "Amulet", MiscString = "StrengthBoost", EquipTier = 5 });
            itemsToAdd.Add(new Item("Ring of forging", "An enchanted ruby ring. Allows you to smelt primary ores directly into bars.", "ringForging", Color.Crimson, 2300) { EquipSlot = "Ring", UseInt4 = 140 });
            itemsToAdd.Add(new Item("Digsite pendant", "Can teleport you to archaeologically significant areas.", "necklaceDigsite", Color.Crimson, 2300) { EquipSlot = "Amulet", UseInt4 = 5, UseString = "TeleportMenuCost", TeleportLocations = ["MIST_Digsite", "MIST_FossilIsland", "MIST_Lithkren"] });
            itemsToAdd.Add(new Item("Inoculation bracelet", "It eases diseases!", "braceletInoculation", Color.Crimson, 2300) { EquipSlot = "Hands", UseInt4 = 275 }); // TODO: Once disease damage is implemented make this work, also should require Zogre Flesh Eaters completion to equip
                
            itemsToAdd.Add(new Item("Burning amulet", "Useful teleports around the wilderness.", "amuletBurning", Color.Magenta, 550) { EquipSlot = "Amulet", UseInt4 = 5, UseString = "TeleportMenuCost", TeleportLocations = ["WILD_ChaosTemple", "WILD_BanditCampEntrance", "WILD_LavaMazeEntrance"] });
            itemsToAdd.Add(new Item("Efaritay's aid", "Aids the user against vampires.", "ringEfaritay", Color.Magenta, 550) { EquipSlot = "Ring", UseInt4 = 200 });
            itemsToAdd.Add(new Item("Necklace of faith", "While worn, if you are below half health, boosts your effective Prayer level by 25%.", "necklaceFaith", Color.Magenta, 550) { EquipSlot = "Amulet" });
            itemsToAdd.Add(new Item("Bracelet of slaughter", "Occasionally prevents slayer kill count being decremented.", "braceletSlaughter", Color.Magenta, 550) { EquipSlot = "Hands", UseInt4 = 30 });
                
            itemsToAdd.Add(new Item("Amulet of power", "An enchanted diamond amulet of magic.", "amuletPower", Color.White, 3600) { EquipSlot = "Amulet", MiscString = "OffenseBoost", EquipTier = 2 });
            itemsToAdd.Add(new Item("Ring of life", "Aids the user against vampires.", "ringLife", Color.White, 3600) { EquipSlot = "Ring" });
            itemsToAdd.Add(new Item("Phoenix necklace", "If you drop below 20% health, restores 30% of your max health.", "necklacePhoenix", Color.White, 3600) { EquipSlot = "Amulet" });
            itemsToAdd.Add(new Item("Abyssal bracelet", "Makes using the Abyss just slightly safer.", "braceletAbyssal", Color.White, 3600) { EquipSlot = "Hands", UseInt4 = 30 }); // TODO: When the Abyss is implemented, make this teleport you to the inner ring on entry since the skulling thing is pointless
                
            itemsToAdd.Add(new Item("Amulet of glory", "A very powerful dragonstone amulet.", "amuletGlory", Color.Purple, 18100) { EquipSlot = "Amulet", MiscString = "OffenseBoost", EquipTier = 3, UseString = "TeleportMenuCost", TeleportLocations = ["MIST_Edgeville", "KAR_MusaPoint", "MIST_DraynorVillage", "DES_AlKharidPalace" ] });
            itemsToAdd.Add(new Item("Ring of wealth", "An enchanted dragonstone ring that can teleport you.", "ringWealth", Color.Purple, 18100) { EquipSlot = "Ring", UseString = "TeleportMenuCost", TeleportLocations = ["FREM_Miscellania", "MIST_GrandExchange", "ASG_FaladorPark", "FREM_KeldagrimMineSouthwest" ] });
            itemsToAdd.Add(new Item("Skills necklace", "This will help me travel.", "necklaceSkills", Color.Purple, 18100) { EquipSlot = "Amulet", UseString = "TeleportMenuCost", TeleportLocations = ["KAN_FishingGuildOutside", "ASG_MiningGuild", "ASG_CraftingGuild", "MIST_VarrockGuildCooks", "KOUR_WoodcuttingGuild", "KOUR_FarmingGuild" ] });
            itemsToAdd.Add(new Item("Combat bracelet", "A handy way to get around.", "braceletCombat", Color.Purple, 18100) { EquipSlot = "Hands", MiscString = "OmniBoost", EquipTier = 1, UseString = "TeleportMenuCost", TeleportLocations = ["ASG_WarriorsGuild", "MIST_VarrockMineEast", "ASG_EdgevilleMonastery", "KAN_RangingGuild" ] });
                
            itemsToAdd.Add(new Item("Amulet of fury", "A very powerful onyx amulet.", "amuletFury", Color.DimGray, 1000100) { EquipSlot = "Amulet", MiscString = "OmniBoost", EquipTier = 4 });
            itemsToAdd.Add(new Item("Ring of fortune", "A lucky ring that enhances your chance to receive rare drops.", "ringFortune", Color.DimGray, 1000100) { EquipSlot = "Ring", UseString = "TeleportMenuFree", TeleportLocations = ["FREM_Miscellania", "MIST_GrandExchange", "ASG_FaladorPark", "FREM_KeldagrimMineSouthwest" ] });
            itemsToAdd.Add(new Item("Berserker necklace", "Makes obsidian weapons even stronger!", "necklaceBerserker", Color.DimGray, 1000100) { EquipSlot = "Amulet", MiscString = "DefenseAll", EquipTier = -2 }); // TODO: Make this actually make obsidian weapons stronger once they get added
            itemsToAdd.Add(new Item("Regen bracelet", "Helps to restore health.", "braceletRegen", Color.DimGray, 1000100) { EquipSlot = "Hands" });
                
            itemsToAdd.Add(new Item("Slayer ring", "A beautifully mounted slayer gem.", "ringSlayer", Color.MediumPurple, 1000, trade: false) { EquipSlot = "Ring", UseInt4 = 8, UseString = "TeleportMenuCost", TeleportLocations = ["KAN_StrongholdSlayerCave", "MOR_SlayerTowerEntrance", "FREM_SlayerDungeonEntrance", "MOR_TarnsLair", "KAN_DarkBeasts", "SEA_WyrmscraigCavern" ] });
            
                

            itemsToAdd.Add(new Item("Cowhide", "This should be tanned before I can use it.", "cowhide", 255, 255, 255, 10));
            itemsToAdd.Add(new Item("Soft leather", "Suitable for craftworks now.", "leatherSoft", 165, 42, 42, 10));
            itemsToAdd.Add(new Item("Hard leather", "Might offer some real protection if made into armor.", "leatherHard", 139, 69, 19, 20));
            itemsToAdd.Add(new Item("Snake hide", "This should be tanned before I can use it.", "hideSnake", Color.DarkOliveGreen.GetBrightest(), 100));
            itemsToAdd.Add(new Item("Snakeskin", "Scaly but not slimy! Used in Crafting (30).", "leatherSnakeskin", Color.DarkOliveGreen, 200)); 
            itemsToAdd.Add(new Item("Carapace", "Can be used to craft Carapace armor (30).", "carapace", Color.Orange, 100));
            itemsToAdd.Add(new Item("Green dragonhide", "The scaly rough hide from a green dragon.", "hideDragonGreen", Color.ForestGreen.GetBrightest(), 250));
            itemsToAdd.Add(new Item("Green dragon leather", "A piece of prepared green dragonhide. Used in Crafting (40).", "leatherDragonGreen", Color.ForestGreen, 250));
            itemsToAdd.Add(new Item("Blue dragonhide", "The scaly rough hide from a green dragon.", "hideDragonBlue", Color.CadetBlue.GetBrightest(), 375));
            itemsToAdd.Add(new Item("Blue dragon leather", "A piece of prepared blue dragonhide. Used in Crafting (50).", "leatherDragonBlue", Color.CadetBlue, 375));
            itemsToAdd.Add(new Item("Red dragonhide", "The scaly rough hide from a red dragon.", "hideDragonRed", Color.Crimson.GetBrightest(), 500));
            itemsToAdd.Add(new Item("Red dragon leather", "A piece of prepared red dragonhide. Used in Crafting (55).", "leatherDragonRed", Color.Crimson, 500));
            itemsToAdd.Add(new Item("Black dragonhide", "The scaly rough hide from a black dragon.", "hideDragonBlack", Color.DimGray.GetBrightest(), 625));
            itemsToAdd.Add(new Item("Black dragon leather", "A piece of prepared black dragonhide. Used in Crafting (60).", "leatherDragonBlack", Color.DimGray, 625));
            itemsToAdd.Add(new Item("Clay dust", "Some hard dry clay.", "clayDust", 207, 185, 151, 1));
            itemsToAdd.Add(new Item("Soft clay", "Clay soft enough to mould.", "claySoft", 205, 127, 50, 2));
            itemsToAdd.Add(new Item("Unfired pot", "I need to put this in a pottery kiln.", "unfiredPot", 205, 127, 50, 1));
            itemsToAdd.Add(new Item("Unfired cup", "I need to put this in a pottery kiln.", "unfiredCup", 205, 127, 50, 2));
            itemsToAdd.Add(new Item("Unfired pie dish", "I need to put this in a pottery kiln.", "unfiredPieDish", 205, 127, 50, 3));
            itemsToAdd.Add(new Item("Unfired bowl", "I need to put this in a pottery kiln.", "unfiredBowl", 205, 127, 50, 2));
            itemsToAdd.Add(new Item("Unfired plant pot", "I need to put this in a pottery kiln.", "unfiredPlantPot", 205, 127, 50, 1));
            itemsToAdd.Add(new Item("Unfired pot lid", "I need to put this in a pottery kiln.", "unfiredPotLid", 205, 127, 50, 10));
            itemsToAdd.Add(new Item("Pot", "This pot is empty.", "potEmpty", 207, 185, 151, 1));
            itemsToAdd.Add(new Item("Empty cup", "An empty cup.", "cupEmpty", 255, 255, 255, 2));
            itemsToAdd.Add(new Item("Pie dish", "Deceptively pie shaped.", "pieEmpty", 207, 185, 151, 3));
            itemsToAdd.Add(new Item("Bowl", "Useful for mixing things.", "bowlEmpty", 207, 185, 151, 4));
            itemsToAdd.Add(new Item("Empty plant pot", "An empty plant pot.", "plantPotEmpty", 207, 185, 151, 1) { UseString = "FillPot" });
            itemsToAdd.Add(new Item("Pot lid", "This should fit on a normal-sized pot.", "potLid", 207, 185, 151, 15));
            itemsToAdd.Add(new Item("Airtight pot", "This is pretty well sealed.", "potAirtight", 207, 185, 151, 10));
                
            itemsToAdd.Add(new Item("Bucket of sand", "A bucket filled with sand. One of the ingredients for making glass.", "bucketSand", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Seaweed", "Slightly damp seaweed.", "seaweed", Color.SeaGreen, 2));
            itemsToAdd.Add(new Item("Swamp weed", "Swamp weed found in the caves near Dorgesh-Kaan.", "weedSwamp", Color.ForestGreen, 2));
            itemsToAdd.Add(new Item("Soda ash", "One of the ingredients for making glass.", "ashSoda", Color.White, 2));
            itemsToAdd.Add(new Item("Molten glass", "Hot glass ready to be blown into useful objects.", "glassMolten", Color.Orange, 2));
            itemsToAdd.Add(new Item("Lantern lens", "A roughly circular disc of glass.", "glassLens", ColorLib.Steel, 70)); 
            itemsToAdd.Add(new Item("Empty candle lantern", "A candle in a glass cage.", "candleLanternEmpty", ColorLib.Steel, 15));
            itemsToAdd.Add(new Item("Fishbowl", "An empty fishbowl.", "fishbowlEmpty", Color.White, 1));
            itemsToAdd.Add(new Item("Unpowered orb", "Could be imbued with elemental energy.", "orbUnpowered", ColorLib.Steel, 100));
             
            itemsToAdd.Add(new Item("Grain", "Some wheat hands.", "grain", 207, 185, 151, 2));
            

            // Ranged Armor Factory
            List<MaterialDef> Leathers = new() {
                new("Leather", 205, 127, 50, 255, 1, 1, 20, "minimal"), 
                new("Hardleather", 175, 97, 20, 255, 2, 10, 40, "slight"), 
                new("Studded", 175, 97, 20, 255, 3, 20, 110, "adequate"), 
                new("Carapace", Color.Orange, 4, 30, 200, "decent"), 
                new("Snakeskin", Color.DarkOliveGreen, 4.5, 30, 400, "decent-er"), 
                new("Green dragonhide", Color.ForestGreen, 5, 40, 500, "good"),
                new("Blue dragonhide", Color.CadetBlue, 6, 50, 750, "great"),
                new("Red dragonhide", Color.Crimson, 6, 55, 1000, "greater"),
                new("Black dragonhide", Color.DimGray, 6, 55, 1250, "greater")
            };

             for (int i = 0; i < Leathers.Count; i++) {
                int fullMult = Leathers[i].CostMultiplier;

                string tempName = Leathers[i].Name;

                if (tempName.Contains(" d")) { tempName = tempName.Replace(" d", "D"); }

                Item coif = new Item(Leathers[i].Name + " coif", "Provides " + Leathers[i].Descriptor + " ranged protection for the head.", "coif" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 2) {
                    EquipSlot = "Head",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(coif);

                Item body = new Item(Leathers[i].Name + " body", "Provides " + Leathers[i].Descriptor + " ranged protection for the torso.", "body" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(body);

                Item chaps = new Item(Leathers[i].Name + " chaps", "Provides " + Leathers[i].Descriptor + " ranged protection for the legs.", "chaps" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(chaps);

                Item boots = new Item(Leathers[i].Name + " boots", "Provides " + Leathers[i].Descriptor + " ranged protection for the feet.", "boots" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult) {
                    EquipSlot = "Feet",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(boots);

                Item vambraces = new Item(Leathers[i].Name + " vambraces", "Provides " + Leathers[i].Descriptor + " ranged protection for the hands.", "vambraces" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult) {
                    EquipSlot = "Hands",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(vambraces);

                Item shield = new Item(Leathers[i].Name + " shield", "A shield for rangers, made of " + Leathers[i].Name + ".", "shield" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult) {
                    EquipSlot = "Offhand",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(shield);

                // Trimmed body and chaps
                Item bodyT = new Item(Leathers[i].Name + " body", "Provides " + Leathers[i].Descriptor + " ranged protection for the torso. Trimmed.", "body" + tempName + "T", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 10) {
                    CosmeticNote = "t", EquipSlot = "Body",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(bodyT);

                Item chapsT = new Item(Leathers[i].Name + " chaps", "Provides " + Leathers[i].Descriptor + " ranged protection for the legs. Trimmed.", "chaps" + tempName + "T", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 6) {
                    CosmeticNote = "t", EquipSlot = "Legs",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(chapsT);

                // Gold trimmed body and chaps
                Item bodyG = new Item(Leathers[i].Name + " body", "Provides " + Leathers[i].Descriptor + " ranged protection for the torso. Trimmed with gold.", "body" + tempName + "G", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 10) {
                    CosmeticNote = "g", EquipSlot = "Body",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(bodyG);

                Item chapsG = new Item(Leathers[i].Name + " chaps", "Provides " + Leathers[i].Descriptor + " ranged protection for the legs. Trimmed with gold.", "chaps" + tempName + "G", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 6) {
                    CosmeticNote = "g", EquipSlot = "Legs",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(chapsG);
            }

            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
