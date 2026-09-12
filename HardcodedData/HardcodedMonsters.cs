using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedMonsters {
        public static void InitMonsters(Dictionary<string, AreaMonster> MonsterLib) {
            List<AreaMonster> toAdd = new();

            toAdd.Add(new("Giant Newt", "newt", 1, 3, 0, 0, false, "1d3", "Slash", 5, "Melee") { DropTable = new() { new("eyeNewt", 1, 2, 1, 1), new("bonesRegular", 1, 1, 1, 1), new("meatRawNewt", 1, 1, 1, 1) } });
            toAdd.Add(new("Cow", "cow", 1, 5, 0, 0, false, "1d2", "Stab", 5, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawBeef", 1, 1, 1, 1), new("cowhide", 1, 1, 1, 1) } });
            toAdd.Add(new("Chicken", "chicken", 1, 2, 0, 0, false, "1d2-1", "Stab", 5, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawChicken", 1, 1, 1, 1), new("feather", 1, 2, 5, 15) } });
            toAdd.Add(new("Zombie", "tiZombie", 5, 8, 0, 0, false, "1d3+1", "Slash", 10, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1) } });

            toAdd.Add(new("Rat", "rat", 1, 2, 0, 0, false, "1d3-2", "Slash", 1, "Melee"));
            toAdd.Add(new("Giant Rat", "ratGiant", 3, 5, 0, 5, false, "1d3-1", "Slash", 1, "Melee") { DropTable = new() { new("bonesRegular", 1, 1, 1, 1), new("meatRawRat", 1, 1, 1, 1), new("clueScrollBeginner", 1, 128, 1, 1) } });
            toAdd.Add(new("Imp", "imp", 1, 8, 0, 0, false, "1d3-1", "Slash", 1, "Melee") { DropTable = new() { 
                new("ashesFiendish", 1, 1, 1, 1),  
                new("MIST_IC_White", 1, 25, 1, 1), new("MIST_IC_Red", 1, 25, 1, 1), new("MIST_IC_Black", 1, 25, 1, 1), new("MIST_IC_Yellow", 1, 25, 1, 1),
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
            

            for (int i = 0; i < toAdd.Count; i++) { 
                MonsterLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
