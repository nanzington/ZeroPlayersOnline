using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedProcessing {
        public static void InitProcessors(Dictionary<string, ProcessingStation> Stations) {
            List<ProcessingStation> toAdd = new();

            toAdd.Add(new("Furnace") {
                Recipes = new() {
                    new ProcessingRecipe("bucketSand", "glassMolten", "Crafting", 1, 20, secondaryIn: "ashSoda", secondaryOut: "bucketEmpty"),
                    new ProcessingRecipe("oreMixBronze", "barBronze", "Smithing", 1, 7),
                    new ProcessingRecipe("oreCopper", "barBronze", "Smithing", 1, 7, tertiaryIn: "ringForging"),
                    new ProcessingRecipe("oreTin", "barBronze", "Smithing", 1, 7, tertiaryIn: "ringForging"),
                    new ProcessingRecipe("oreMixIron", "barIron", "Smithing", 10, 20),
                    new ProcessingRecipe("oreIron", "barIron", "Smithing", 10, 20, tertiaryIn: "ringForging"),
                    new ProcessingRecipe("oreMixSteel", "barSteel", "Smithing", 20, 32),
                    new ProcessingRecipe("oreCoal", "barSteel", "Smithing", 20, 32, tertiaryIn: "ringForging"),
                    new ProcessingRecipe("oreMixMithril", "barMithril", "Smithing", 30, 60),
                    new ProcessingRecipe("oreMithril", "barMithril", "Smithing", 30, 60, tertiaryIn: "ringForging"),
                    new ProcessingRecipe("oreMixAdamant", "barAdamant", "Smithing", 40, 85),
                    new ProcessingRecipe("oreAdamant", "barAdamant", "Smithing", 40, 85, tertiaryIn: "ringForging"),
                    new ProcessingRecipe("oreMixSilver", "barSilver", "Smithing", 20, 14),
                    new ProcessingRecipe("oreSilver", "barSilver", "Smithing", 20, 14, tertiaryIn: "ringForging"),
                    new ProcessingRecipe("oreMixGold", "barGold", "Smithing", 20, 23),
                    new ProcessingRecipe("oreGold", "barGold", "Smithing", 20, 23, tertiaryIn: "ringForging")
                }
            });

            toAdd.Add(new("Casting") {
                OpensUI = true
            });

            toAdd.Add(new("Dairy Churn") {
                Recipes = new() {
                    new ProcessingRecipe("bucketMilk", "cream", "Cooking", 21, 18, secondaryOut: "bucketEmpty"),
                    new ProcessingRecipe("cream", "butter", "Cooking", 38, 23),
                    new ProcessingRecipe("butter", "cheese", "Cooking", 48, 24)
                }
            });

            toAdd.Add(new("Tannery") {
                Recipes = new() {
                    new ProcessingRecipe("cowhide", "leatherSoft", "Crafting", 1, 5),
                    new ProcessingRecipe("leatherSoft", "leatherHard", "Crafting", 10, 5),
                    new ProcessingRecipe("hideSnake", "leatherSnakeskin", "Crafting", 20, 5),
                    new ProcessingRecipe("hideDragonGreen", "leatherDragonGreen", "Crafting", 40, 5),
                    new ProcessingRecipe("hideDragonBlue", "leatherDragonBlue", "Crafting", 50, 5),
                    new ProcessingRecipe("hideDragonRed", "leatherDragonRed", "Crafting", 55, 5),
                    new ProcessingRecipe("hideDragonBlack", "leatherDragonBlack", "Crafting", 60, 5)
                }
            });

            toAdd.Add(new("Anvil") {
                OpensUI = true
            });

            toAdd.Add(new("Range") {
                Recipes = new() {
                    new ProcessingRecipe("seaweed", "ashSoda"),
                    new ProcessingRecipe("weedSwamp", "ashSoda"),
                    new ProcessingRecipe("meatRawNewt", "meatCookedNewt", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawBeef", "meatCookedBeef", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawRat", "meatCookedBeef", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawBear", "meatCookedBeef", "Cooking", 1, 30),
                    new ProcessingRecipe("meatCookedBeef", "sinew", "Cooking", 1, 3),
                    new ProcessingRecipe("meatRawChicken", "meatCookedChicken", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawBird", "meatCookedBird", "Cooking", 10, 50),
                    new ProcessingRecipe("fishRawShrimp", "fishCookedShrimp", "Cooking", 1, 15),
                    new ProcessingRecipe("fishRawAnchovies", "fishCookedAnchovies", "Cooking", 1, 30),
                    new ProcessingRecipe("fishRawSardine", "fishCookedSardine", "Cooking", 1, 40),
                    new ProcessingRecipe("fishRawHerring", "fishCookedHerring", "Cooking", 5, 50),
                    new ProcessingRecipe("fishRawMackerel", "fishCookedMackerel", "Cooking", 10, 60),
                    new ProcessingRecipe("fishRawTrout", "fishCookedTrout", "Cooking", 15, 70),
                    new ProcessingRecipe("fishRawCod", "fishCookedCod", "Cooking", 18, 75),
                    new ProcessingRecipe("fishRawPike", "fishCookedPike", "Cooking", 20, 80),
                    new ProcessingRecipe("fishRawSalmon", "fishCookedSalmon", "Cooking", 25, 90),
                    new ProcessingRecipe("fishRawTuna", "fishCookedTuna", "Cooking", 30, 100),
                    new ProcessingRecipe("fishRawLobster", "fishCookedLobster", "Cooking", 40, 120),
                    new ProcessingRecipe("fishRawBass", "fishCookedBass", "Cooking", 43, 130),
                    new ProcessingRecipe("fishRawSwordfish", "fishCookedSwordfish", "Cooking", 45, 140),
                    new ProcessingRecipe("fishRawEelSlimy", "fishCookedEelSlimy", "Cooking", 28, 95),
                    new ProcessingRecipe("fishRawEelCave", "fishCookedEelCave", "Cooking", 28, 95),
                    new ProcessingRecipe("doughBread", "bread", "Cooking", 1, 30),
                    new ProcessingRecipe("potato", "potatoBaked", "Cooking", 7, 15),
                    new ProcessingRecipe("tinCakeBatter", "cake", "Cooking", 40, 180, secondaryOut: "tinCakeEmpty")
                }
            });

            toAdd.Add(new("Pottery Wheel") {
                OpensUI = true
            });

            toAdd.Add(new("Pottery Kiln") {
                Recipes = new() {
                    new ProcessingRecipe("unfiredPot", "potEmpty", "Crafting", 1, 7),
                    new ProcessingRecipe("unfiredCup", "cupEmpty", "Crafting", 3, 9),
                    new ProcessingRecipe("unfiredPieDish", "pieEmpty", "Crafting", 7, 15),
                    new ProcessingRecipe("unfiredBowl", "bowlEmpty", "Crafting", 8, 18),
                    new ProcessingRecipe("unfiredPlantPot", "plantPotEmpty", "Crafting", 19, 20),
                    new ProcessingRecipe("unfiredPotLid", "potLid", "Crafting", 20, 30)
                }
            });

            toAdd.Add(new("Sink") {
                Recipes = new() {
                    new ProcessingRecipe("bucketEmpty", "bucketWater"), 
                    new ProcessingRecipe("clayDust", "claySoft"), 
                    new ProcessingRecipe("vialEmpty", "vialWater"), 
                    new ProcessingRecipe("bowlEmpty", "bowlWater"), 
                    new ProcessingRecipe("jugEmpty", "jugWater"), 
                    new ProcessingRecipe("potFlour", "doughBread", secondaryOut: "potEmpty")
                }
            });

            toAdd.Add(new("Sand") { Recipes = new() { new ProcessingRecipe("bucketEmpty", "bucketSand") } });

            toAdd.Add(new("Air Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraAir", "Runecrafting", 1, 25, "", true, "talismanAir"),
                    new ProcessingRecipe("runeWater", "runeMist", "Runecrafting", 6, 5, "", true, "pureEssence", "", "talismanWater"),
                    new ProcessingRecipe("runeEarth", "runeDust", "Runecrafting", 10, 5, "", true, "pureEssence", "", "talismanEarth"),
                    new ProcessingRecipe("runeFire", "runeSmoke", "Runecrafting", 15, 5, "", true, "pureEssence", "", "talismanFire"),
                    new ProcessingRecipe("runeEssence", "runeAir", "Runecrafting", 1, 5),
                    new ProcessingRecipe("pureEssence", "runeAir", "Runecrafting", 1, 5, extra: true)
                }
            });

            toAdd.Add(new("Mind Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraMind", "Runecrafting", 1, 28, "", true, "talismanMind"), 
                    new ProcessingRecipe("runeEssence", "runeMind", "Runecrafting", 2, 6),
                    new ProcessingRecipe("pureEssence", "runeMind", "Runecrafting", 2, 6, extra: true)
                }
            });

            toAdd.Add(new("Water Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraWater", "Runecrafting", 1, 30, "", true, "talismanWater"),
                    new ProcessingRecipe("runeAir", "runeMist", "Runecrafting", 6, 6, "", true, "pureEssence", "", "talismanAir"),
                    new ProcessingRecipe("runeEarth", "runeMud", "Runecrafting", 13, 6, "", true, "pureEssence", "", "talismanEarth"),
                    new ProcessingRecipe("runeFire", "runeSteam", "Runecrafting", 19, 6, "", true, "pureEssence", "", "talismanFire"),
                    new ProcessingRecipe("runeEssence", "runeWater", "Runecrafting", 5, 6),
                    new ProcessingRecipe("pureEssence", "runeWater", "Runecrafting", 5, 6, extra: true)
                }
            });

            toAdd.Add(new("Earth Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraEarth", "Runecrafting", 1, 33, "", true, "talismanEarth"),
                    new ProcessingRecipe("runeAir", "runeDust", "Runecrafting", 10, 7, "", true, "pureEssence", "", "talismanAir"),
                    new ProcessingRecipe("runeFire", "runeLava", "Runecrafting", 23, 7, "", true, "pureEssence", "", "talismanFire"),
                    new ProcessingRecipe("runeWater", "runeMud", "Runecrafting", 13, 7, "", true, "pureEssence", "", "talismanWater"),
                    new ProcessingRecipe("runeEssence", "runeEarth", "Runecrafting", 9, 7),
                    new ProcessingRecipe("pureEssence", "runeEarth", "Runecrafting", 9, 7, extra: true)
                }
            });

            toAdd.Add(new("Fire Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraFire", "Runecrafting", 1, 35, "", true, "talismanFire"),
                    new ProcessingRecipe("runeAir", "runeSmoke", "Runecrafting", 15, 8, "", true, "pureEssence", "", "talismanAir"),
                    new ProcessingRecipe("runeEarth", "runeLava", "Runecrafting", 23, 8, "", true, "pureEssence", "", "talismanEarth"),
                    new ProcessingRecipe("runeWater", "runeSteam", "Runecrafting", 19, 8, "", true, "pureEssence", "", "talismanWater"),
                    new ProcessingRecipe("runeEssence", "runeFire", "Runecrafting", 14, 8),
                    new ProcessingRecipe("pureEssence", "runeFire", "Runecrafting", 14, 8, extra: true)
                }
            });

            toAdd.Add(new("Body Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraBody", "Runecrafting", 1, 38, "", true, "talismanBody"), 
                    new ProcessingRecipe("runeEssence", "runeBody", "Runecrafting", 20, 8),
                    new ProcessingRecipe("pureEssence", "runeBody", "Runecrafting", 20, 8, extra: true)
                }
            });

            toAdd.Add(new("Cosmic Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraCosmic", "Runecrafting", 1, 40, "", true, "talismanCosmic"), 
                    new ProcessingRecipe("pureEssence", "runeCosmic", "Runecrafting", 27, 8, extra: true)
                }
            });

            toAdd.Add(new("Chaos Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraChaos", "Runecrafting", 1, 43, "", true, "talismanChaos"), 
                    new ProcessingRecipe("pureEssence", "runeChaos", "Runecrafting", 35, 9, extra: true)
                }
            });

            toAdd.Add(new("Astral Altar") {
                Recipes = new() { 
                    new ProcessingRecipe("pureEssence", "runeAstral", "Runecrafting", 40, 9, extra: true)
                }
            });

            toAdd.Add(new("Nature Altar") {
                Recipes = new() { 
                    new ProcessingRecipe("tiara", "tiaraNature", "Runecrafting", 1, 45, "", true, "talismanNature"), 
                    new ProcessingRecipe("pureEssence", "runeNature", "Runecrafting", 44, 9, extra: true)
                }
            });

            toAdd.Add(new("Law Altar") {
                Recipes = new() { 
                    new ProcessingRecipe("tiara", "tiaraLaw", "Runecrafting", 1, 48, "", true, "talismanLaw"), 
                    new ProcessingRecipe("pureEssence", "runeLaw", "Runecrafting", 54, 10, extra: true)
                }
            });

            toAdd.Add(new("Death Altar") {
                Recipes = new() { 
                    new ProcessingRecipe("tiara", "tiaraDeath", "Runecrafting", 1, 50, "", true, "talismanDeath"), 
                    new ProcessingRecipe("pureEssence", "runeDeath", "Runecrafting", 65, 10, extra: true)
                }
            }); 

            toAdd.Add(new("Blood Altar") {
                Recipes = new() {
                    new ProcessingRecipe("tiara", "tiaraBlood", "Runecrafting", 1, 53, "", true, "talismanBlood"),
                    new ProcessingRecipe("pureEssence", "runeBlood", "Runecrafting", 77, 11, extra: true)
                }
            });

            toAdd.Add(new("Soul Altar") {
                Recipes = new() {  
                    new ProcessingRecipe("pureEssence", "runeSoul", "Runecrafting", 90, 30, extra: true)
                }
            });



            toAdd.Add(new("Spinning Wheel") {
                Recipes = new() {
                    new ProcessingRecipe("flax", "bowstring", "Crafting", 1, 5),
                    new ProcessingRecipe("sinew", "crossbowString", "Crafting", 1, 5),
                    new ProcessingRecipe("woolRaw", "woolBall", "Crafting", 1, 3)
                }
            });

            toAdd.Add(new("Windmill") {
                Recipes = new() {
                    new ProcessingRecipe("grain", "potFlour", secondaryIn: "potEmpty")
                }
            });

            toAdd.Add(new("Dairy Cow") {
                Recipes = new() {
                    new ProcessingRecipe("bucketEmpty", "bucketMilk")
                }
            });

            toAdd.Add(new("Level 1 Enchanter") {
                Recipes = new() { 
                    new ProcessingRecipe("mtaIcosahedron", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCube", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaPentamid", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCylinder", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaDragonstone", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("amuletSapphire", "amuletMagic"),
                    new ProcessingRecipe("ringSapphire", "ringRecoil"),
                    new ProcessingRecipe("necklaceSapphire", "necklaceGames"),
                    new ProcessingRecipe("braceletSapphire", "braceletClay"),
                    new ProcessingRecipe("amuletOpal", "amuletBounty"),
                    new ProcessingRecipe("ringOpal", "ringPursuit"),
                    new ProcessingRecipe("necklaceOpal", "necklaceDodgy"),
                    new ProcessingRecipe("braceletOpal", "braceletExpeditious")
                }
            });

            toAdd.Add(new("Level 2 Enchanter") {
                Recipes = new() {
                    new ProcessingRecipe("mtaIcosahedron", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCube", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaPentamid", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCylinder", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaDragonstone", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("amuletEmerald", "amuletDefense"),
                    new ProcessingRecipe("ringEmerald", "ringDueling"),
                    new ProcessingRecipe("necklaceEmerald", "necklaceBinding"),
                    new ProcessingRecipe("braceletEmerald", "braceletCastleWars"),
                    new ProcessingRecipe("amuletJade", "amuletChemistry"),
                    new ProcessingRecipe("ringJade", "ringReturning"),
                    new ProcessingRecipe("necklaceJade", "necklacePassage"),
                    new ProcessingRecipe("braceletJade", "braceletFlamtaer")
                }
            });

            toAdd.Add(new("Level 3 Enchanter") {
                Recipes = new() {
                    new ProcessingRecipe("mtaIcosahedron", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCube", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaPentamid", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCylinder", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaDragonstone", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("amuletRuby", "amuletStrength"),
                    new ProcessingRecipe("ringRuby", "ringForging"),
                    new ProcessingRecipe("necklaceRuby", "necklaceDigsite"),
                    new ProcessingRecipe("braceletRuby", "braceletInoculation"),
                    new ProcessingRecipe("amuletRedTopaz", "amuletBurning"),
                    new ProcessingRecipe("ringRedTopaz", "ringEfaritay"),
                    new ProcessingRecipe("necklaceRedTopaz", "necklaceFaith"),
                    new ProcessingRecipe("braceletRedTopaz", "braceletSlaughter")
                }
            });

            toAdd.Add(new("Level 4 Enchanter") {
                Recipes = new() {
                    new ProcessingRecipe("mtaIcosahedron", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCube", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaPentamid", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCylinder", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaDragonstone", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("amuletDiamond", "amuletPower"),
                    new ProcessingRecipe("ringDiamond", "ringLife"),
                    new ProcessingRecipe("necklaceDiamond", "necklacePhoenix"),
                    new ProcessingRecipe("braceletDiamond", "braceletAbyssal")
                }
            });

            toAdd.Add(new("Level 5 Enchanter") {
                Recipes = new() {
                    new ProcessingRecipe("mtaIcosahedron", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCube", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaPentamid", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCylinder", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaDragonstone", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("amuletDragonstone", "amuletGlory"),
                    new ProcessingRecipe("ringDragonstone", "ringWealth"),
                    new ProcessingRecipe("necklaceDragonstone", "necklaceSkills"),
                    new ProcessingRecipe("braceletDragonstone", "braceletCombat")
                }
            });

            toAdd.Add(new("Level 6 Enchanter") {
                Recipes = new() {
                    new ProcessingRecipe("mtaIcosahedron", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCube", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaPentamid", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaCylinder", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("mtaDragonstone", "mtaOrb", minigameAct: "mtaPizazz"),
                    new ProcessingRecipe("amuletOnyx", "amuletFury"),
                    new ProcessingRecipe("ringOnyx", "ringFortune"),
                    new ProcessingRecipe("necklaceOnyx", "necklaceBerserker"),
                    new ProcessingRecipe("braceletOnyx", "braceletRegen")
                }
            });

            toAdd.Add(new("Orb Depository") { Recipes = new() { new ProcessingRecipe("mtaOrb", "", "Magic", 1, 20, minigameAct: "mtaOrb") } });
            toAdd.Add(new("Fruit Chute") { Recipes = new() { new ProcessingRecipe("fruitBanana", "", minigameAct: "mtaFruit"), new ProcessingRecipe("fruitPeach", "", minigameAct: "mtaFruit") } });
            toAdd.Add(new("Coin Slot") { Recipes = new() { new ProcessingRecipe("mtaAlchCoin", "", minigameAct: "mtaCoin") } });


            for (int i = 0; i < toAdd.Count; i++) {
                Stations.Add(toAdd[i].Name, toAdd[i]);
            }
        }
    }
}
