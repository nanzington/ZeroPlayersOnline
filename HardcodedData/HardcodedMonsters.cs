using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedMonsters {
        public static void InitMonsters(Dictionary<string, AreaMonster> MonsterLib) {
            List<AreaMonster> toAdd = new();

            List<ItemDrop> GemDrop = new() {
                new("uncutSapphire", 1, 260, 1, 1), 
                new("uncutEmerald", 1, 520, 1, 1), 
                new("uncutRuby", 1, 1040, 1, 1), 
                new("talismanChaos", 1, 2773, 1, 1), new("talismanNature", 1, 2773, 1, 1), 
                new("uncutDiamond", 1, 4160, 1, 1), 
                new("spearRune", 1, 15600, 1, 1), new("shieldLeftHalf", 1, 31200, 1, 1), new("spearDragon", 1, 41600, 1, 1)
            };

            toAdd.Add(new("Giant newt", "newt", 1, 3, 0, false, "1d3", "Slash", 5, "Melee") { DropTable = new() { new("eyeNewt", 1, 2, 1, 1), new("bonesRegular", 1, 1, 1, 1), new("meatRawNewt", 1, 1, 1, 1) } });
            toAdd.Add(new("Cow", "cow", 1, 5, 0, false, "1d2", "Stab", 5, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawBeef", 1, 1, 1, 1), new("cowhide", 1, 1, 1, 1), new("clueScrollBeginner", 1, 128, 1, 1) } });
            toAdd.Add(new("Chicken", "chicken", 1, 2, 0, false, "1d2-1", "Stab", 5, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawChicken", 1, 1, 1, 1), new("feather", 1, 2, 5, 15), new("clueScrollBeginner", 1, 300, 1, 1) } });
            toAdd.Add(new("Zombie", "tiZombie", 5, 8, 0, false, "1d3+1", "Slash", 10, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("coins", 1, 4, 10, 10), new("coins", 1, 43, 18, 18), new("coins", 1, 64, 13, 13), new("coins", 1, 64, 28, 28), new("scrollChampionZombie", 1, 5000, 1, 1) } });

            toAdd.Add(new("Rat", "rat", 1, 2, 0, false, "1d3-2", "Slash", 1, "Melee"));
            toAdd.Add(new("Giant rat", "ratGiant", 3, 5, 0, false, "1d3-1", "Slash", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawRat", 1, 1, 1, 1), new("clueScrollBeginner", 1, 128, 1, 1) } });
            toAdd.Add(new("Imp", "imp", 1, 8, 0, false, "1d3-1", "Slash", 1, "Melee") { DropTable = new() { 
                new("ashesFiendish", 1, 1, 1, 1), new("burntFood", 1, 32, 1, 1),
                new("beadWhite", 1, 25, 1, 1), new("beadRed", 1, 25, 1, 1), new("beadBlack", 1, 25, 1, 1), new("beadYellow", 1, 25, 1, 1),
                new("boltsBronze", 1, 16, 1, 1), new("wizardBlueHat", 1, 16, 1, 1),
                new("eggChicken", 1, 25, 1, 1), new("meatRawChicken", 1, 25, 1, 1), new("cabbage", 1, 64, 1, 1), new("doughBread", 1, 64, 1, 1), new("bread", 1, 128, 1, 1), new("meatCookedBeef", 1, 128, 1, 1),
                new("hammer", 1, 16, 1, 1), new("tinderbox", 1, 25, 1, 1), new("shears", 1, 32, 1, 1), new("bucketEmpty", 1, 32, 1, 1), new("bucketWater", 1, 64, 1, 1), new("jugEmpty", 1, 64, 1, 1),  new("jugWater", 1, 64, 1, 1), new("potEmpty", 1, 64, 1, 1),  new("potFlour", 1, 64, 1, 1),
                new("woolBall", 1, 16, 1, 1), new("talismanMind", 1, 18, 1, 1), new("ashes", 1, 21, 1, 1), new("clayDust", 1, 32, 1, 1), new("cadava", 1, 32, 1, 1), new("grain", 1, 42, 1, 1), new("chefHat", 1, 64, 1, 1),
                new("scrollChampionImp", 1, 5000, 1, 1) 
            } });

            toAdd.Add(new("Farmer", "farmer", 7, 12, 0, false, "1d3-2", "Slash", 1, "Melee", 3.6) { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1),  
                new("coins", 1, 3, 3, 3), new("coins", 1, 128, 25, 25),
                new("runeEarth", 1, 64, 4, 4), new("runeFire", 1, 64, 6, 6), new("runeMind", 1, 64, 9, 9), new("runeChaos", 1, 128, 2, 2),
                new("seedGuam", 1, 46, 1, 1), new("seedMarrentill", 1, 62, 1, 1), new("seedTarromin", 1, 82, 1, 1), new("seedHarralander", 1, 106, 1, 1), new("seedRanarr", 1, 135, 1, 1), new("seedIrit", 1, 186, 1, 1), new("seedAvantoe", 1, 248, 1, 1), new("seedKwuarm", 1, 298, 1, 1), new("seedCadantine", 1, 372, 1, 1), new("seedLantadyme", 1, 497, 1, 1), new("seedDwarfweed", 1, 497, 1, 1),
                new("seedPotato", 1, 10, 1, 4), new("seedOnion", 1, 19, 1, 3), new("seedCabbage", 1, 38, 1, 3), new("seedTomato", 1, 76, 1, 2), new("seedSweetcorn", 1, 152, 1, 2), new("seedStrawberry", 1, 303, 1, 1), new("seedWatermelon", 1, 606, 1, 1), new("seedSnapegrass", 1, 606, 1, 1),
                new("talismanEarth", 1, 64, 1, 1), new("clueScrollBeginner", 1, 90, 1, 1), new("clueScrollEasy", 1, 128, 1, 1), new("potionEnergy", 1, 25, 1, 1)
            } });

            toAdd.Add(new("Frog", "frog", 5, 8, 0, false, "1d3-2", "Earth", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("clueScrollBeginner", 1, 90, 1, 1) } });
            toAdd.Add(new("Big frog", "frogBig", 10, 18, 0, false, "1d3-1", "Earth", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("clueScrollBeginner", 1, 70, 1, 1) } });
            toAdd.Add(new("Giant frog", "frogGiant", 13, 23, 0, false, "1d3-1", "Earth", 1, "Melee") { DropTable = new() { new("bonesBig", 1, 1, 1, 1), new("clueScrollBeginner", 1, 64, 1, 1) } });
            
            toAdd.Add(new("Goblin", "goblin", 2, 5, 0, false, "1d3-2", "Stab", 1, "Melee") { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1),  
                new("spearBronze", 1, 32, 1, 1), new("sqShieldBronze", 1, 43, 1, 1), 
                new("coins", 1, 5, 5, 5), new("coins", 1, 43, 9, 9), new("coins", 1, 43, 15, 15), new("coins", 1, 64, 20, 20), new("coins", 1, 128, 1, 1),    
                new("runeWater", 1, 21, 6, 6), new("runeBody", 1, 26, 7, 7), new("runeEarth", 1, 43, 4, 4), new("boltsBronze", 1, 43, 8, 8), 
                new("hammer", 1, 9, 1, 1), new("potionEnergy", 1, 20, 1, 1), new("goblinMail", 1, 26, 1, 1), new("chefHat", 1, 26, 1, 1), new("goblinBook", 1, 64, 1, 1), new("beer", 1, 64, 1, 1), new("talismanAir", 1, 128, 1, 1), new("necklaceBrass", 1, 128, 1, 1),
                new("clueScrollBeginner", 1, 64, 1, 1), new("clueScrollEasy", 1, 128, 1, 1),    
                new("scrollChampionGoblin", 1, 5000, 1, 1) 
            } });

            toAdd.Add(new("Giant spider", "spiderGiant", 2, 5, 0, false, "1d3-2", "Fire", 1, "Melee") { DropTable = new() { new("clueScrollBeginner", 1, 128, 1, 1) } });
            
            toAdd.Add(new("H.A.M. guard", "hamGuard", 12, 15, 0, false, "1d3-1", "Crush", 1, "Melee", 4.2) { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1), new("coins", 1, 8, 1, 20), 
                new("hatchetBronze", 1, 37, 1, 1), new("daggerBronze", 1, 37, 1, 1), new("pickaxeBronze", 1, 37, 1, 1), new("hatchetIron", 1, 37, 1, 1), new("daggerIron", 1, 37, 1, 1), new("pickaxeIron", 1, 37, 1, 1), new("bodyLeather", 1, 37, 1, 1),  new("hatchetSteel", 1, 55, 1, 1), new("daggerSteel", 1, 55, 1, 1), new("pickaxeSteel", 1, 55, 1, 1),
                new("hamGloves", 1, 44, 1, 1), new("hamBoots", 1, 55, 1, 1), new("hamShirt", 1, 83, 1, 1), new("hamSkirt", 1, 83, 1, 1), new("hamLogo", 1, 83, 1, 1), new("hamHood", 1, 110, 1, 1), new("hamCloak", 1, 110, 1, 1),
                new("arrowsBronze", 1, 41, 1, 12), new("arrowsSteel", 1, 55, 1, 10),
                new("spiritHerb", 1, 110, 1, 1), new("spiritHerb", 1, 220, 1, 1), new("spiritHerb", 1, 333, 1, 1), new("spiritFish", 1, 55, 1, 3),  new("spiritOreIron", 1, 55, 1, 1), new("spiritOreCoal", 1, 55, 1, 1),  new("spiritWoodPine", 1, 36, 1, 3),
                new("seedPotato", 1, 31, 4, 4), new("seedOnion", 1, 42, 4, 4), new("seedCabbage", 1, 63, 4, 4), new("seedTomato", 1, 126, 3, 3), new("seedSweetcorn", 1, 253, 3, 3), new("seedStrawberry", 1, 507, 2, 2), new("seedWatermelon", 1, 1061, 2, 2),  new("seedSnapegrass", 1, 1458, 2, 2),
                new("cowhide", 1, 37, 1, 3), new("uncutOpal", 1, 55, 1, 1), new("uncutJade", 1, 55, 1, 1), new("meatRawChicken", 1, 55, 1, 3), new("coinPouchMedium", 1, 8, 1, 1), new("feather", 1, 37, 1, 6), new("knife", 1, 55, 1, 1), new("needle", 1, 55, 1, 1), new("tinderbox", 1, 55, 1, 1),
                new("clueScrollEasy", 1, 55, 1, 1)
            } });

            toAdd.Add(new("Lesser demon", "wizDemonLesser", 82, 79, 0, false, "1d8", "Water", 1, "Melee") { Inaccessible = true, DropTable = new(GemDrop) { 
                new("ashesVile", 1, 1, 1, 1),  
                new("coins", 1, 3, 120, 120), new("coins", 1, 4, 40, 40), new("coins", 1, 13, 200, 200), new("coins", 1, 18, 10, 10), new("coins", 1, 128, 450, 450),  
                new("helmSteel", 1, 32, 1, 1), new("hatchetSteel", 1, 32, 1, 1), new("scimitarSteel", 1, 43, 1, 1), new("sqShieldMithril", 1, 128, 1, 1), new("chainmailMithril", 1, 128, 1, 1), new("helmRune", 1, 128, 1, 1),
                new("runeFire", 1, 16, 60, 60), new("runeChaos", 1, 26, 12, 12), new("runeDeath", 1, 43, 3, 3), new("runeFire", 1, 128, 30, 30),
                new("spiritHerb", 1, 512, 1, 1), new("spiritOreGold", 1, 64, 1, 1), new("jugWine", 1, 43, 1, 1),
                new("scrollChampionLesserDemon", 1, 5000, 1, 1) 
            } });

            toAdd.Add(new("Wizard", "wizard", 9, 14, 0, false, "1d4", "Water", 1, "Melee") { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1),  
                new("keyClue", 1, 1, 1, 1, false, true, new("ClueMedium", 0, "M_CrypticWizard")),
                new("coins", 1, 6, 1, 1), new("coins", 1, 14, 2, 2), new("coins", 1, 18, 18, 18), new("coins", 1, 128, 30, 30),
                new("staff", 1, 16, 1, 1), new("wizardBlueHat", 1, 19, 1, 1), new("wizardBlueRobe", 1, 43, 1, 1), new("wizardBlueBottom", 1, 43, 1, 1),
                new("runeChaos", 1, 16, 2, 2), new("runeNature", 1, 16, 2, 2), new("runeAir", 1, 43, 5, 5), new("runeBody", 1, 43, 5, 5), new("runeEarth", 1, 43, 5, 5), new("runeFire", 1, 43, 5, 5), new("runeMind", 1, 43, 5, 5), new("runeWater", 1, 43, 5, 5),  new("runeAir", 1, 64, 12, 12), new("runeBody", 1, 64, 12, 12), new("runeEarth", 1, 64, 12, 12), new("runeFire", 1, 64, 12, 12), new("runeMind", 1, 64, 12, 12), new("runeWater", 1, 64, 12, 12),
                new("runeBlood", 1, 128, 2, 2), new("runeLaw", 1, 128, 2, 2), new("talismanMind", 1, 32, 1, 1), new("talismanWater", 1, 43, 1, 1)
            } });

            toAdd.Add(new("Skeleton", "mistWizSkeleton", 13, 18, 0, true, "1d3-1", "Earth", 10, "Melee") { Requirements = new() { new("QuestAt", 20, "MI_RestlessGhost"), new("Item", 1, "mistWizGhostSkull", false) }, SeeWithoutRequirements = false, DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("scrollChampionSkeleton", 1, 5000, 1, 1) } });
            toAdd.Add(new("Unicorn", "unicorn", 15, 19, 0, false, "1d3-1", "Stab", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("unicornHorn", 1, 1, 1, 1) } });
            toAdd.Add(new("Black bear", "bearBlack", 19, 25, 0, false, "1d3", "Fire", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("bearFur", 1, 1, 1, 1), new("meatRawBear", 1, 1, 1, 1) } });
            toAdd.Add(new("Ram", "ram", 2, 8, 0, false, "1d3-2", "Fire", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1) } });
            toAdd.Add(new("Scorpion", "scorpion", 14, 17, 0, false, "1d3-1", "Stab", 1, "Melee") { DropTable = new() { new("clueScrollBeginner", 1, 100, 1, 1) } });
            
            toAdd.Add(new("Cave goblin", "goblinCave", 3, 10, 0, false, "1d3-2", "Fire", 1, "Melee") { 
                DropTable = new() { 
                    new("bonesRegular", 1, 1, 1, 1), 
                    new("coins", 1, 8, 15, 15), new("coins", 1, 10, 20, 20), new("coins", 1, 13, 5, 5), new("coins", 1, 13, 9, 9), new("coins", 1, 50, 1, 1),     
                    new("runeBody", 1, 10, 7, 7), new("runeWater", 1, 10, 6, 6), new("runeEarth", 1, 10, 4, 4),
                    new("hammer", 1, 13, 1, 1), new("tinderbox", 1, 13, 1, 1),
                    new("necklaceBrass", 1, 13, 1, 1),    
                    new("clueScrollBeginner", 1, 64, 1, 1), new("clueScrollEasy", 1, 128, 1, 1),    
                    new("scrollChampionGoblin", 1, 5000, 1, 1)  
                } 
            });

            toAdd.Add(new("Cave bug", "caveBug", 6, 5, 0, true, "1d3-2", "Fire", 1, "Melee") { 
                SlayerReq = 7,
                DropTable = new() {  
                    new("coins", 1, 16, 3, 3), new("coins", 1, 43, 8, 8), 
                    new("runeWater", 1, 26, 8, 8), new("runeNature", 1, 26, 1, 1), new("runeEarth", 1, 64, 6, 6), new("runeNature", 1, 128, 2, 2),
                    new("spiritHerb", 1, 8, 1, 1), new("spiritHerb", 1, 22, 1, 1), new("spiritHerb", 1, 30, 1, 1), new("spiritHerb", 1, 40, 1, 1),  new("spiritHerb", 1, 51, 1, 1),  new("spiritHerb", 1, 65, 1, 1), new("spiritHerb", 1, 89, 1, 1),  new("spiritHerb", 1, 119, 1, 1), new("spiritHerb", 1, 143, 1, 1),  new("spiritHerb", 1, 178, 1, 1), new("spiritHerb", 1, 237, 1, 1),  new("spiritHerb", 1, 237, 1, 1),
                    new("candle", 1, 26, 1, 1), new("tinderbox", 1, 43, 1, 1), new("candleLanternEmpty", 1, 128, 1, 1),
                    new("unicornHornDust", 1, 64, 1, 1), new("eyeNewt", 1, 64, 1, 1), new("spiderEggsRed", 1, 64, 1, 1), new("limpwurt", 1, 128, 1, 1), new("snapegrass", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Cave crawler", "caveCrawler", 23, 22, 0, true, "1d3", "Crush", 1, "Melee") { 
                SlayerReq = 10, PoisonSeverity = 8,
                DropTable = new(GemDrop) {  
                    new("bootsBronze", 1, 128, 1, 1), new("coins", 1, 26, 3, 3), new("coins", 1, 43, 8, 8), new("coins", 1, 43, 29, 29), new("coins", 1, 128, 10, 10),  
                    new("runeNature", 1, 21, 3, 4), new("runeFire", 1, 26, 12, 12), new("runeEarth", 1, 64, 9, 9),
                    new("seedPotato", 1, 10, 1, 4), new("seedOnion", 1, 20, 1, 3), new("seedCabbage", 1, 39, 1, 3), new("seedTomato", 1, 79, 1, 2), new("seedSweetcorn", 1, 158, 1, 2), new("seedStrawberry", 1, 315, 1, 1), new("seedWatermelon", 1, 630, 1, 1), new("seedSnapegrass", 1, 630, 1, 1),
                    new("spiritHerb", 1, 23, 1, 1), new("spiritHerb", 1, 31, 1, 1), new("spiritHerb", 1, 41, 1, 1), new("spiritHerb", 1, 53, 1, 1),  new("spiritHerb", 1, 68, 1, 1),  new("spiritHerb", 1, 93, 1, 1), new("spiritHerb", 1, 124, 1, 1),  new("spiritHerb", 1, 149, 1, 1), new("spiritHerb", 1, 186, 1, 1),  new("spiritHerb", 1, 248, 1, 1), new("spiritHerb", 1, 248, 1, 1),
                    new("vialWater", 1, 10, 1, 1), new("whiteberry", 1, 25, 1, 1), new("unicornHornDust", 1, 64, 1, 1), new("eyeNewt", 1, 128, 1, 1), new("spiderEggsRed", 1, 128, 1, 1), new("limpwurt", 1, 128, 1, 1), new("snapegrass", 1, 128, 1, 1), new("potionEnergy", 1, 20, 1, 1),
                } 
            });

            toAdd.Add(new("Cave slime", "caveSlime", 23, 25, 0, false, "1d3-1", "Earth", 1, "Melee") { 
                SlayerReq = 17,
                DropTable = new(GemDrop) { 
                    new("swampTar", 1, 1, 1, 6), new("coins", 1, 3, 10, 10), new("coins", 1, 4, 4, 4), new("coins", 1, 13, 22, 22), new("coins", 1, 18, 1, 1), new("coins", 1, 64, 46, 46),    
                    new("swordIron", 1, 18, 1, 1), new("hatchetBronze", 1, 43, 1, 1), new("kiteshieldIron", 1, 64, 1, 1), new("helmBronze", 1, 128, 1, 1), new("bootsIron", 1, 128, 1, 1), 
                    new("runeWater", 1, 26, 15, 15), new("runeEarth", 1, 43, 5, 5),
                    new("torch", 1, 12, 1, 1), new("barGold", 1, 64, 1, 1), new("oilLanternFrame", 1, 39, 1, 3),
                    new("clueScrollEasy", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Rockslug", "rockSlug", 29, 27, 0, false, "1d4", "Earth", 1, "Melee") { 
                SlayerReq = 20, KillItem = "saltBag",
                DropTable = new(GemDrop) { 
                    new("mysticGlovesLight", 1, 512, 1, 1), 
                    new("runeEarth", 1, 4, 4, 4), new("runeEarth", 1, 32, 42, 42), new("runeChaos", 1, 32, 2, 2),
                    new("spiritOreIron", 1, 6, 1, 1), new("spiritOreCoal", 1, 10, 1, 1), new("spiritOreTin", 1, 16, 1, 1), new("spiritOreCopper", 1, 43, 1, 1), new("spiritOreMithril", 1, 128, 1, 1),
                    new("seedPotato", 1, 38, 4, 4), new("seedOnion", 1, 51, 4, 4), new("seedCabbage", 1, 77, 4, 4), new("seedTomato", 1, 155, 3, 3), new("seedSweetcorn", 1, 311, 3, 3), new("seedStrawberry", 1, 623, 2, 2), new("seedWatermelon", 1, 1303, 2, 2), new("seedSnapegrass", 1, 1792, 2, 2),
                    new("dwarvenStout", 1, 10, 1, 1), new("hammer", 1, 13, 1, 1)
                } 
            });
            
            toAdd.Add(new("Big frog", "frogBig24", 24, 25, 0, false, "1d-1", "Stab", 1, "Melee") { 
                DropTable = new() { 
                    new("bonesRegular", 1, 1, 1, 1), 
                    new("coins", 1, 4, 5, 5), new("coins", 1, 7, 15, 15), 
                    new("runeWater", 1, 13, 12, 12), new("runeEarth", 1, 13, 12, 12), new("runeNature", 1, 18, 4, 4), new("runeCosmic", 1, 21, 2, 2),
                    new("talismanWater", 1, 128, 1, 1), new("talismanEarth", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Giant frog", "frogGiant99", 99, 100, 0, false, "1d10-1", "Stab", 1, "Melee") {
                DropTable = new() { 
                    new("bonesBig", 1, 1, 1, 1), new("spearMithril", 1, 64, 1, 1), new("boneLong", 1, 400, 1, 1), new("boneCurved", 1, 5013, 1, 1),
                    new("coins", 1, 13, 30, 30), new("coins", 1, 16, 2, 2), new("coins", 1, 26, 37, 37),   
                    new("runeNature", 1, 13, 1, 1), new("runeNature", 1, 13, 3, 3), new("runeNature", 1, 13, 9, 9), new("runeCosmic", 1, 43, 5, 5), new("runeBlood", 1, 128, 1, 1),
                    new("arrowsIron", 1, 64, 22, 22), new("arrowsSteel", 1, 128, 45, 45),
                    new("frogLegsGiant", 1, 2, 1, 1), new("spiritOreCoal", 1, 128, 1, 1), new("rollSpinach", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Dark wizard", "wizardDark7", 7, 12, 0, true, "1d3-1", "Stab", 1, "Magic") {
                DropTable = new() { 
                    new("bonesRegular", 1, 1, 1, 1), new("staff", 1, 16, 1, 1), new("wizardBlackHat", 1, 21, 1, 1), new("wizardBlackRobe", 1, 43, 1, 1), new("wizardBlackBottom", 1, 43, 1, 1),
                    new("coins", 1, 8, 1, 1), new("coins", 1, 8, 2, 2), new("coins", 1, 18, 4, 4), new("coins", 1, 43, 29, 29), new("coins", 1, 128, 30, 30), 
                    new("runeEarth", 1, 32, 36, 36), new("runeAir", 1, 43, 10, 10), new("runeWater", 1, 43, 10, 10), new("runeEarth", 1, 43, 10, 10), new("runeFire", 1, 43, 10, 10), new("runeAir", 1, 64, 18, 18), new("runeWater", 1, 64, 18, 18), new("runeEarth", 1, 64, 18, 18), new("runeFire", 1, 64, 18, 18),
                    new("runeNature", 1, 18, 4, 4), new("runeChaos", 1, 21, 5, 5), new("runeMind", 1, 43, 10, 10), new("runeBody", 1, 43, 10, 10), new("runeMind", 1, 64, 18, 18), new("runeBody", 1, 64, 18, 18), new("runeBlood", 1, 64, 2, 2), new("runeCosmic", 1, 128, 2, 2), new("runeLaw", 1, 128, 3, 3),
                    new("talismanWater", 1, 128, 1, 1), new("talismanFire", 1, 128, 1, 1), new("clueScrollBeginner", 1, 50, 1, 1), new("potionEnergy", 1, 20, 1, 1)
                } 
            });

            toAdd.Add(new("Dark wizard", "wizardDark20", 20, 24, 0, true, "1d6", "Stab", 1, "Magic") {
                DropTable = new() { 
                    new("bonesRegular", 1, 1, 1, 1), new("staff", 1, 32, 1, 1), new("wizardBlackHat", 1, 21, 1, 1), new("wizardBlackRobe", 1, 43, 1, 1), new("wizardBlackBottom", 1, 43, 1, 1),
                    new("coins", 1, 8, 1, 1), new("coins", 1, 8, 2, 2), new("coins", 1, 14, 4, 4), new("coins", 1, 43, 29, 29), new("coins", 1, 128, 30, 30), 
                    new("runeEarth", 1, 32, 36, 36), new("runeAir", 1, 43, 10, 10), new("runeWater", 1, 43, 10, 10), new("runeEarth", 1, 43, 10, 10), new("runeFire", 1, 43, 10, 10), new("runeAir", 1, 64, 18, 18), new("runeWater", 1, 64, 18, 18), new("runeEarth", 1, 64, 18, 18), new("runeFire", 1, 64, 18, 18),
                    new("runeNature", 1, 18, 4, 4), new("runeChaos", 1, 21, 4, 4), new("runeMind", 1, 43, 10, 10), new("runeBody", 1, 43, 10, 10), new("runeMind", 1, 64, 18, 18), new("runeBody", 1, 64, 18, 18), new("runeBlood", 1, 64, 2, 2), new("runeCosmic", 1, 128, 2, 2), new("runeLaw", 1, 128, 3, 3),
                    new("talismanWater", 1, 64, 1, 1), new("talismanFire", 1, 64, 1, 1), new("clueScrollBeginner", 1, 35, 1, 1), new("potionEnergy", 1, 20, 1, 1)
                } 
            });

            toAdd.Add(new("Guard", "guard", 21, 22, 0, true, "1d3", "Fire", 1, "Melee") {
                DropTable = new() { 
                    new("bonesRegular", 1, 1, 1, 1), 
                    new("boltsIron", 1, 13, 2, 12), new("arrowsSteel", 1, 32, 1, 1), new("arrowsBronze", 1, 43, 1, 1), new("arrowsBronze", 1, 64, 2, 2), new("arrowsSteel", 1, 128, 5, 5),
                    new("runeAir", 1, 64, 6, 6), new("runeEarth", 1, 64, 3, 3), new("runeFire", 1, 64, 2, 2), new("runeBlood", 1, 128, 1, 1), new("runeChaos", 1, 128, 1, 1), new("runeNature", 1, 128, 1, 1), 
                    new("seedPotato", 1, 19, 4, 4), new("seedOnion", 1, 25, 4, 4), new("seedCabbage", 1, 38, 4, 4), new("seedTomato", 1, 77, 3, 3), new("seedSweetcorn", 1, 155, 3, 3), new("seedStrawberry", 1, 311, 2, 2), new("seedWatermelon", 1, 651, 2, 2), new("seedSnapegrass", 1, 896, 2, 2),
                    new("coins", 1, 7, 1, 1), new("coins", 1, 8, 7, 7), new("coins", 1, 14, 12, 12), new("coins", 1, 16, 4, 4), new("coins", 1, 32, 25, 25), new("coins", 1, 32, 17, 17), new("coins", 1, 64, 30, 30),
                    new("daggerIron", 1, 21, 1, 1), new("talismanBody", 1, 43, 1, 1), new("grain", 1, 128, 1, 1), new("spiritOreIron", 1, 128, 1, 1), new("clueScrollMedium", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Barbarian", "barbarian9", 9, 20, 0, true, "1d2", "Fire", 1, "Melee") {
                DropTable = new(GemDrop) { 
                    new("bonesRegular", 1, 1, 1, 1),  
                    new("hatchetBronze", 1, 21, 1, 1), new("staff", 1, 32, 1, 1), new("maceIron", 1, 128, 1, 1), 
                    new("runeChaos", 1, 32, 2, 2), new("arrowsBronze", 1, 43, 15, 15), new("runeEarth", 1, 43, 2, 2), new("runeFire", 1, 64, 5, 5), new("runeMind", 1, 64, 5, 5), new("runeLaw", 1, 128, 2, 2),
                    new("coins", 1, 3, 5, 5), new("coins", 1, 14, 8, 8), new("coins", 1, 26, 17, 17), new("coins", 1, 43, 27, 27),
                    new("spiritOreTin", 1, 128, 1, 1), new("bearFur", 1, 128, 1, 1), new("beer", 1, 128, 1, 1), new("meatCookedBeef", 1, 128, 1, 1), new("mouldRing", 1, 128, 1, 1),
                    new("clueScrollBeginner", 1, 75, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Barbarian", "barbarian10", 10, 18, 0, true, "1d2", "Fire", 1, "Melee") {
                DropTable = new(GemDrop) { 
                    new("bonesRegular", 1, 1, 1, 1),  
                    new("hatchetBronze", 1, 21, 1, 1), new("staff", 1, 32, 1, 1), new("maceIron", 1, 128, 1, 1), 
                    new("runeChaos", 1, 32, 2, 2), new("arrowsBronze", 1, 43, 15, 15), new("runeEarth", 1, 43, 2, 2), new("runeFire", 1, 64, 5, 5), new("runeMind", 1, 64, 5, 5), new("runeLaw", 1, 128, 2, 2),
                    new("coins", 1, 3, 5, 5), new("coins", 1, 14, 8, 8), new("coins", 1, 26, 17, 17), new("coins", 1, 43, 27, 27),
                    new("spiritOreTin", 1, 128, 1, 1), new("bearFur", 1, 128, 1, 1), new("beer", 1, 128, 1, 1), new("meatCookedBeef", 1, 128, 1, 1), new("mouldRing", 1, 128, 1, 1),
                    new("clueScrollBeginner", 1, 75, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Barbarian", "barbarian15", 15, 24, 0, true, "1d2", "Stab", 1, "Ranged") {
                DropTable = new(GemDrop) { 
                    new("bonesRegular", 1, 1, 1, 1),  
                    new("hatchetBronze", 1, 21, 1, 1), new("battleaxeBronze", 1, 32, 1, 1), new("maceIron", 1, 128, 1, 1), 
                    new("runeChaos", 1, 32, 3, 3), new("arrowsBronze", 1, 32, 10, 10), new("runeEarth", 1, 43, 5, 5), new("runeFire", 1, 64, 8, 8), new("runeMind", 1, 64, 10, 10), new("runeLaw", 1, 128, 2, 2),
                    new("coins", 1, 3, 8, 8), new("coins", 1, 14, 12, 12), new("coins", 1, 26, 25, 25), new("coins", 1, 43, 32, 32),
                    new("spiritOreTin", 1, 128, 1, 1), new("bearFur", 1, 128, 1, 1), new("beer", 1, 128, 1, 1), new("meatCookedBeef", 1, 128, 1, 1), new("mouldRing", 1, 128, 1, 1),
                    new("clueScrollBeginner", 1, 55, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Barbarian", "barbarian17", 17, 24, 0, true, "1d3", "Fire", 1, "Ranged") {
                DropTable = new(GemDrop) { 
                    new("bonesRegular", 1, 1, 1, 1),  
                    new("hatchetBronze", 1, 21, 1, 1), new("battleaxeBronze", 1, 32, 1, 1), new("maceIron", 1, 128, 1, 1), 
                    new("runeChaos", 1, 32, 3, 3), new("arrowsBronze", 1, 32, 10, 10), new("runeEarth", 1, 43, 5, 5), new("runeFire", 1, 64, 8, 8), new("runeMind", 1, 64, 10, 10), new("runeLaw", 1, 128, 2, 2),
                    new("coins", 1, 3, 8, 8), new("coins", 1, 14, 12, 12), new("coins", 1, 26, 25, 25), new("coins", 1, 43, 32, 32),
                    new("spiritOreTin", 1, 128, 1, 1), new("bearFur", 1, 128, 1, 1), new("beer", 1, 128, 1, 1), new("meatCookedBeef", 1, 128, 1, 1), new("mouldRing", 1, 128, 1, 1),
                    new("clueScrollBeginner", 1, 55, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
                } 
            });

            toAdd.Add(new("Gunthor the Brave", "barbarianGunthor", 29, 35, 0, true, "1d4", "Fire", 1, "Ranged", 3.6) {
                DropTable = new(GemDrop) { 
                    new("bonesRegular", 1, 1, 1, 1),  
                    new("hatchetIron", 1, 21, 1, 1), new("battleaxeBronze", 1, 32, 1, 1), new("maceIron", 1, 128, 1, 1), 
                    new("runeChaos", 1, 32, 3, 3), new("arrowsBronze", 1, 32, 10, 10), new("runeEarth", 1, 43, 5, 5), new("runeFire", 1, 64, 8, 8), new("runeMind", 1, 64, 10, 10), new("runeLaw", 1, 128, 2, 2),
                    new("coins", 1, 3, 8, 8), new("coins", 1, 14, 12, 12), new("coins", 1, 26, 25, 25), new("coins", 1, 43, 32, 32),
                    new("spiritOreTin", 1, 128, 1, 1), new("bearFur", 1, 128, 1, 1), new("beer", 1, 128, 1, 1), new("meatCookedBeef", 1, 128, 1, 1), new("mouldRing", 1, 128, 1, 1),
                    new("clueScrollBeginner", 1, 30, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
                } 
            });


            for (int i = 0; i < toAdd.Count; i++) { 
                MonsterLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
