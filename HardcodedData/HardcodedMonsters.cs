using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedMonsters {
        public static void InitMonsters(Dictionary<string, AreaMonster> MonsterLib) {
            List<AreaMonster> toAdd = new();

            toAdd.Add(new("Giant newt", "newt", 1, 3, 0, 0, false, "1d3", "Slash", 5, "Melee") { DropTable = new() { new("eyeNewt", 1, 2, 1, 1), new("bonesRegular", 1, 1, 1, 1), new("meatRawNewt", 1, 1, 1, 1) } });
            toAdd.Add(new("Cow", "cow", 1, 5, 0, 0, false, "1d2", "Stab", 5, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawBeef", 1, 1, 1, 1), new("cowhide", 1, 1, 1, 1) } });
            toAdd.Add(new("Chicken", "chicken", 1, 2, 0, 0, false, "1d2-1", "Stab", 5, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawChicken", 1, 1, 1, 1), new("feather", 1, 2, 5, 15) } });
            toAdd.Add(new("Zombie", "tiZombie", 5, 8, 0, 0, false, "1d3+1", "Slash", 10, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1) } });

            toAdd.Add(new("Rat", "rat", 1, 2, 0, 0, false, "1d3-2", "Slash", 1, "Melee"));
            toAdd.Add(new("Giant rat", "ratGiant", 3, 5, 0, 5, false, "1d3-1", "Slash", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawRat", 1, 1, 1, 1), new("clueScrollBeginner", 1, 128, 1, 1) } });
            toAdd.Add(new("Imp", "imp", 1, 8, 0, 0, false, "1d3-1", "Slash", 1, "Melee") { DropTable = new() { 
                new("ashesFiendish", 1, 1, 1, 1),  
                new("beadWhite", 1, 25, 1, 1), new("beadRed", 1, 25, 1, 1), new("beadBlack", 1, 25, 1, 1), new("beadYellow", 1, 25, 1, 1),
                new("boltsBronze", 1, 16, 1, 1), new("wizardBlueHat", 1, 16, 1, 1),
                new("eggChicken", 1, 25, 1, 1), new("meatRawChicken", 1, 25, 1, 1), new("cabbage", 1, 64, 1, 1), new("doughBread", 1, 64, 1, 1), new("bread", 1, 128, 1, 1), new("meatCookedBeef", 1, 128, 1, 1),
                new("hammer", 1, 16, 1, 1), new("tinderbox", 1, 25, 1, 1), new("shears", 1, 32, 1, 1), new("bucketEmpty", 1, 32, 1, 1), new("bucketWater", 1, 64, 1, 1), new("jugEmpty", 1, 64, 1, 1),  new("jugWater", 1, 64, 1, 1), new("potEmpty", 1, 64, 1, 1),  new("potFlour", 1, 64, 1, 1),
                new("woolBall", 1, 16, 1, 1), new("talismanMind", 1, 18, 1, 1), new("ashes", 1, 21, 1, 1), new("clayDust", 1, 32, 1, 1), new("cadava", 1, 32, 1, 1), new("grain", 1, 42, 1, 1), new("chefHat", 1, 64, 1, 1) 
            } });

            toAdd.Add(new("Farmer", "farmer", 7, 12, 0, 0, false, "1d3-2", "Slash", 1, "Melee") { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1),  
                new("runeEarth", 1, 64, 4, 4), new("runeFire", 1, 64, 6, 6), new("runeMind", 1, 64, 9, 9), new("runeChaos", 1, 128, 2, 2),
                new("seedGuam", 1, 46, 1, 1), new("seedMarrentill", 1, 62, 1, 1), new("seedTarromin", 1, 82, 1, 1), new("seedHarralander", 1, 106, 1, 1), new("seedRanarr", 1, 135, 1, 1), new("seedIrit", 1, 186, 1, 1), new("seedAvantoe", 1, 248, 1, 1), new("seedKwuarm", 1, 298, 1, 1), new("seedCadantine", 1, 372, 1, 1), new("seedLantadyme", 1, 497, 1, 1), new("seedDwarfweed", 1, 497, 1, 1),
                new("seedPotato", 1, 10, 1, 4), new("seedOnion", 1, 19, 1, 3), new("seedCabbage", 1, 38, 1, 3), new("seedTomato", 1, 76, 1, 2), new("seedSweetcorn", 1, 152, 1, 2), new("seedStrawberry", 1, 303, 1, 1), new("seedWatermelon", 1, 606, 1, 1), new("seedSnapegrass", 1, 606, 1, 1),
                new("coinPouchSmall", 1, 3, 1, 1), new("coinPouchMedium", 1, 128, 1, 1),
                new("talismanEarth", 1, 64, 1, 1), new("clueScrollBeginner", 1, 90, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
            } });

            toAdd.Add(new("Frog", "frog", 5, 8, 0, 0, false, "1d3-2", "Earth", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("clueScrollBeginner", 1, 90, 1, 1) } });
            toAdd.Add(new("Big frog", "frogBig", 10, 18, 0, 0, false, "1d3-1", "Earth", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("clueScrollBeginner", 1, 70, 1, 1) } });
            toAdd.Add(new("Giant frog", "frogGiant", 13, 23, 0, 0, false, "1d3-1", "Earth", 1, "Melee") { DropTable = new() { new("bonesBig", 1, 1, 1, 1), new("clueScrollBeginner", 1, 64, 1, 1) } });
            
            toAdd.Add(new("Goblin", "goblin", 2, 5, 0, 0, false, "1d3-2", "Stab", 1, "Melee") { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1),  
                new("daggerBronze", 1, 32, 1, 1), new("sqShieldBronze", 1, 43, 1, 1), 
                new("runeWater", 1, 21, 6, 6), new("runeBody", 1, 26, 7, 7), new("runeEarth", 1, 43, 4, 4), new("boltsBronze", 1, 43, 8, 8),
                new("coinPouchSmall", 1, 5, 1, 1), new("coinPouchMedium", 1, 50, 1, 1),
                new("hammer", 1, 9, 1, 1), new("potionEnergy", 1, 20, 1, 1), new("goblinMail", 1, 26, 1, 1), new("chefHat", 1, 26, 1, 1), new("goblinBook", 1, 64, 1, 1), new("beer", 1, 64, 1, 1), new("talismanAir", 1, 128, 1, 1), new("necklaceBrass", 1, 128, 1, 1),
                new("clueScrollBeginner", 1, 64, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
            } });

            toAdd.Add(new("Giant spider", "spiderGiant", 2, 5, 0, 0, false, "1d3-2", "Fire", 1, "Melee") { DropTable = new() { new("clueScrollBeginner", 1, 128, 1, 1) } });
            
            toAdd.Add(new("H.A.M. Guard", "hamGuard", 12, 15, 0, 0, false, "1d3-2", "Crush", 1, "Melee") { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1),  
                new("hatchetBronze", 1, 37, 1, 1), new("daggerBronze", 1, 37, 1, 1), new("pickaxeBronze", 1, 37, 1, 1), new("hatchetIron", 1, 37, 1, 1), new("daggerIron", 1, 37, 1, 1), new("pickaxeIron", 1, 37, 1, 1), new("bodyLeather", 1, 37, 1, 1),  new("hatchetSteel", 1, 55, 1, 1), new("daggerSteel", 1, 55, 1, 1), new("pickaxeSteel", 1, 55, 1, 1),
                new("hamGloves", 1, 44, 1, 1), new("hamBoots", 1, 55, 1, 1), new("hamShirt", 1, 83, 1, 1), new("hamSkirt", 1, 83, 1, 1), new("hamLogo", 1, 83, 1, 1), new("hamHood", 1, 110, 1, 1), new("hamCloak", 1, 110, 1, 1),
                new("arrowsBronze", 1, 41, 1, 12), new("arrowsSteel", 1, 55, 1, 10),
                new("spiritHerb", 1, 110, 1, 1), new("spiritHerb", 1, 220, 1, 1), new("spiritHerb", 1, 333, 1, 1), new("spiritFish", 1, 55, 1, 3),  new("spiritOreIron", 1, 55, 1, 1), new("spiritOreCoal", 1, 55, 1, 1),  new("spiritWoodPine", 1, 36, 1, 3),
                new("seedPotato", 1, 31, 4, 4), new("seedOnion", 1, 42, 4, 4), new("seedCabbage", 1, 63, 4, 4), new("seedTomato", 1, 126, 3, 3), new("seedSweetcorn", 1, 253, 3, 3), new("seedStrawberry", 1, 507, 2, 2), new("seedWatermelon", 1, 1061, 2, 2),  new("seedSnapegrass", 1, 1458, 2, 2),
                new("cowhide", 1, 37, 1, 3), new("uncutOpal", 1, 55, 1, 1), new("uncutJade", 1, 55, 1, 1), new("meatRawChicken", 1, 55, 1, 3), new("coinPouchMedium", 1, 8, 1, 1), new("feather", 1, 37, 1, 6), new("knife", 1, 55, 1, 1), new("needle", 1, 55, 1, 1), new("tinderbox", 1, 55, 1, 1),
                new("clueScrollEasy", 1, 55, 1, 1)
            } });

            toAdd.Add(new("Lesser Demon", "wizDemonLesser", 82, 79, 0, 0, false, "1d8", "Water", 1, "Melee") { Inaccessible = true, DropTable = new() { 
                new("ashesVile", 1, 1, 1, 1),  
                new("helmSteel", 1, 32, 1, 1), new("hatchetSteel", 1, 32, 1, 1), new("scimitarSteel", 1, 43, 1, 1), new("sqShieldMithril", 1, 128, 1, 1), new("chainmailMithril", 1, 128, 1, 1), new("helmRune", 1, 128, 1, 1),
                new("runeFire", 1, 16, 60, 60), new("runeChaos", 1, 26, 12, 12), new("runeDeath", 1, 43, 3, 3), new("runeFire", 1, 128, 30, 30),
                new("spiritHerb", 1, 512, 1, 1), new("spiritOreGold", 1, 64, 1, 1), new("jugWine", 1, 43, 1, 1),
                new("uncutSapphire", 1, 65, 1, 1), new("uncutEmerald", 1, 130, 1, 1), new("uncutRuby", 1, 260, 1, 1), new("uncutDiamond", 1, 1040, 1, 1), new("talismanChaos", 1, 693, 1, 1), new("talismanNature", 1, 693, 1, 1)
            } });

            toAdd.Add(new("Wizard", "wizard", 9, 14, 0, 0, false, "1d4", "Water", 1, "Melee") { DropTable = new() { 
                new("bonesRegular", 1, 1, 1, 1),  
                new("staff", 1, 16, 1, 1), new("wizardBlueHat", 1, 19, 1, 1), new("wizardBlueRobe", 1, 43, 1, 1), new("wizardBlueBottom", 1, 43, 1, 1),
                new("runeChaos", 1, 16, 2, 2), new("runeNature", 1, 16, 2, 2), new("runeAir", 1, 43, 5, 5), new("runeBody", 1, 43, 5, 5), new("runeEarth", 1, 43, 5, 5), new("runeFire", 1, 43, 5, 5), new("runeMind", 1, 43, 5, 5), new("runeWater", 1, 43, 5, 5),  new("runeAir", 1, 64, 12, 12), new("runeBody", 1, 64, 12, 12), new("runeEarth", 1, 64, 12, 12), new("runeFire", 1, 64, 12, 12), new("runeMind", 1, 64, 12, 12), new("runeWater", 1, 64, 12, 12),
                new("runeBlood", 1, 128, 2, 2), new("runeLaw", 1, 128, 2, 2), new("talismanMind", 1, 32, 1, 1), new("talismanWater", 1, 43, 1, 1)
            } });

            toAdd.Add(new("Skeleton", "mistWizSkeleton", 13, 18, 0, 0, true, "1d3-1", "Earth", 10, "Melee") { Requirements = new() { new("QuestAt", 20, "MI_RestlessGhost"), new("Item", 1, "mistWizGhostSkull", false) }, SeeWithoutRequirements = false, DropTable = new() { new("bonesRegular", 1, 1, 1, 1) } });
            toAdd.Add(new("Unicorn", "unicorn", 15, 19, 0, 0, false, "1d3-1", "Stab", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("unicornHorn", 1, 1, 1, 1) } });
            toAdd.Add(new("Black bear", "bearBlack", 19, 25, 0, 0, false, "1d3", "Fire", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("bearFur", 1, 1, 1, 1), new("meatRawBear", 1, 1, 1, 1) } });
            toAdd.Add(new("Ram", "ram", 2, 8, 0, 0, false, "1d3-2", "Fire", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1) } });
            

            for (int i = 0; i < toAdd.Count; i++) { 
                MonsterLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
