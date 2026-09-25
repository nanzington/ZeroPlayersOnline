using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.HardcodedData {
    public static class DropTables {
        public static List<ItemDrop> GemDrop = new() {
            new("uncutSapphire", 1, 2.03, 1, 1), 
            new("uncutEmerald", 1, 4.06, 1, 1), 
            new("uncutRuby", 1, 8.13, 1, 1), 
            new("talismanChaos", 1, 21.7, 1, 1), new("talismanNature", 1, 21.7, 1, 1), 
            new("uncutDiamond", 1, 32.5, 1, 1), 
            new("spearRune", 1, 122.2, 1, 1), new("shieldLeftHalf", 1, 243.75, 1, 1), new("spearDragon", 1, 325.0, 1, 1)
        };

        public static List<ItemDrop> AllotmentSeeds = new() { 
            new("seedPotato", 1, 2.739, 4, 4), 
            new("seedOnion", 1, 3.652, 4, 4), 
            new("seedCabbage", 1, 5.478, 4, 4), 
            new("seedTomato", 1, 10.96, 3, 3), 
            new("seedSweetcorn", 1, 21.91, 3, 3), 
            new("seedStrawberry", 1, 43.83, 2, 2), 
            new("seedSnapegrass", 1, 67.9, 2, 2),
            new("seedWatermelon", 1, 126, 2, 2)
        };

        public static List<ItemDrop> HopSeeds = new() {
            new("seedBarley", 1, 4.367, 4, 4),
            new("seedHammerstone", 1, 4.386, 3, 3),
            new("seedAsgarnian", 1, 5.814, 3, 3),
            new("seedJute", 1, 5.848, 2, 2),
            new("seedYanillian", 1, 8.772, 2, 2),
            new("seedKrandorian", 1, 17.54, 2, 2),
            new("seedWildblood", 1, 34.38, 1, 1)
        };

        public static List<ItemDrop> FlowerSeeds = new() {
            new("seedMarigold", 1, 2.66, 1, 1),
            new("seedNasturtium", 1, 4.016, 1, 1),
            new("seedRosemary", 1, 6.211, 1, 1),
            new("seedWoad", 1, 8.403, 1, 1),
            new("seedLimpwurt", 1, 10.53, 1, 1)
        };

        public static List<ItemDrop> BushSeeds = new() {
            new("seedRedberry", 1, 2.5, 1, 1),
            new("seedCadava", 1, 3.571, 1, 1),
            new("seedDwellberry", 1, 5, 1, 1),
            new("seedJangerberry", 1, 12.5, 1, 1),
            new("seedWhiteberry", 1, 34.48, 1, 1),
            new("seedPoisonIvy", 1, 90.91, 1, 1)
        };

        public static List<ItemDrop> HerbSeeds = new() {
            new("seedGuam", 1, 3.125, 1, 1),
            new("seedMarrentill", 1, 4.587, 1, 1),
            new("seedTarromin", 1, 6.711, 1, 1),
            new("seedHarralander", 1, 9.901, 1, 1),
            new("seedRanarr", 1, 14.49, 1, 1),
            new("seedIrit", 1, 31.25, 1, 1),
            new("seedToadflax", 1, 21.28, 1, 1),
            new("seedAvantoe", 1, 45.45, 1, 1),
            new("seedKwuarm", 1, 66.67, 1, 1),
            new("seedSnapdragon", 1, 100, 1, 1),
            new("seedCadantine", 1, 142.9, 1, 1),
            new("seedLantadyme", 1, 200, 1, 1),
            new("seedDwarfweed", 1, 333.3, 1, 1),
            new("seedTorstol", 1, 500, 1, 1)
        };

        public static List<ItemDrop> SpecialSeeds = new() {
            new("seedBittercap", 1, 2.2, 1, 1),
            new("seedBelladonna", 1, 3.667, 1, 1),
            new("seedCactus", 1, 5.5, 1, 1),
            new("seedPotatoCactus", 1, 11, 1, 1)
        };

        public static List<ItemDrop> GenericHumanTable = new() { 
            HerbSeeds.But(128.0/23.0),
            new("bonesRegular", 1, 1, 1, 1),
            new("helmBronze", 1, 64, 1, 1), new("daggerIron", 1, 128, 1, 1), 
            new("boltsBronze", 1, 6, 2, 12), new("arrowsBronze", 1, 43, 7, 7), new("runeEarth", 1, 64, 4, 4), new("runeFire", 1, 64, 6, 6), new("runeMind", 1, 64, 9, 9), new("runeChaos", 1, 128, 2, 2),
            new("coins", 1, 3, 3, 3), new("coins", 1, 6, 10, 10), new("coins", 1, 14, 5, 5), new("coins", 1, 32, 15, 15), new("coins", 1, 128, 25, 25),
            new("baitFish", 1, 26, 1, 1), new("spiritOreCopper", 1, 64, 1, 1), new("talismanEarth", 1, 64, 1, 1), new("cabbage", 1, 128, 1, 1), new("potionEnergy", 1, 15, 1, 1),
            new("clueScrollBeginner", 1, 90, 1, 1), new("clueScrollEasy", 1, 128, 1, 1)
        };
    }
}
