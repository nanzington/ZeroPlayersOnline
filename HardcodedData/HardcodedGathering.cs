using ZeroPlayersOnline.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedGathering {
        public static void InitGathers(Dictionary<string, GatheringTile> GatherSpots) {
            List<GatheringTile> tiles = new();
            tiles.Add(new GatheringTile("plantFlax", "Wild Flax", "Pick", 100, 60, 10, "Farming", 1, 0, 0, items: new() { new("flax", 1) })); 
            tiles.Add(new GatheringTile("plantPotato", "Potato Plant", "Pick", 100, 100, 5, "Farming", 1, 0, 0, items: new() { new("potato", 1) })); 
            tiles.Add(new GatheringTile("plantGrain", "Wheat", "Pick", 100, 100, 5, "Farming", 1, 0, 0, items: new() { new("grain", 1) })); 
            tiles.Add(new GatheringTile("plantGuam", "Guam Bush", "Pick", 100, 100, 10, "Farming", 1, 5, 0,items: new() { new("herbGrimyGuam", 1) }));

            tiles.Add(new GatheringTile("treePine", "Pine Tree", "Chop", 100, 100, 10, "Woodcutting", 1, 25, 0, neededTool: "Hatchet", items: new() { new("logPine", 1) }));
            tiles.Add(new GatheringTile("rootsPine", "Pine Roots", "Chop", 100, 100, 10, "Woodcutting", 1, 25, 0, neededTool: "Hatchet", items: new() { new("logPine", 1) }));
            tiles.Add(new GatheringTile("treeOak", "Oak Tree", "Chop", 100, 70, 20, "Woodcutting", 10, 38, 0, neededTool: "Hatchet", items: new() { new("logOak", 1) }));
            tiles.Add(new GatheringTile("treeWillow", "Willow Tree", "Chop", 100, 70, 20, "Woodcutting", 20, 68, 0, neededTool: "Hatchet", items: new() { new("logWillow", 1) }));
            tiles.Add(new GatheringTile("treeTeak", "Teak Tree", "Chop", 100, 70, 20, "Woodcutting", 30, 85, 0, neededTool: "Hatchet", items: new() { new("logTeak", 1) }));
            tiles.Add(new GatheringTile("treeMaple", "Maple Tree", "Chop", 100, 60, 30, "Woodcutting", 40, 100, 0, neededTool: "Hatchet", items: new() { new("logMaple", 1) }));
            tiles.Add(new GatheringTile("treeAcadia", "Acadia Tree", "Chop", 100, 60, 30, "Woodcutting", 50, 80, 0, neededTool: "Hatchet", items: new() { new("logAcadia", 1) }));
            tiles.Add(new GatheringTile("treeMahogany", "Mahogany Tree", "Chop", 100, 50, 40, "Woodcutting", 60, 125, 0, neededTool: "Hatchet", items: new() { new("logMahogany", 1) }));
            tiles.Add(new GatheringTile("treeYew", "Yew Tree", "Chop", 100, 50, 40, "Woodcutting", 70, 188, 0, neededTool: "Hatchet", items: new() { new("logYew", 1) }));
            tiles.Add(new GatheringTile("treeMagic", "Magic Tree", "Chop", 100, 40, 50, "Woodcutting", 80, 365, 0, neededTool: "Hatchet", items: new() { new("logMagic", 1) }));
            tiles.Add(new GatheringTile("treeElder", "Elder Tree", "Chop", 100, 30, 60, "Woodcutting", 90, 425, 0, neededTool: "Hatchet", items: new() { new("logElder", 1) }));

            tiles.Add(new GatheringTile("rockEssence", "Essence Rock", "Mine", 100, 10, 10, "Mining", 1, 5, neededTool: "Pickaxe", items: new() { new("pureEssence", 1) })); 
            tiles.Add(new GatheringTile("rockClay", "Clay Deposit", "Mine", 100, 20, 10, "Mining", 1, 5, neededTool: "Pickaxe", items: new() { new("clayDust", 1) }) ); 
            tiles.Add(new GatheringTile("oreCopper", "Copper Ore", "Mine", 100, 100, 15, "Mining", 1, 7, neededTool: "Pickaxe", items: new() { new("oreCopper", 1) })); 
            tiles.Add(new GatheringTile("oreTin", "Tin Ore", "Mine", 100, 100, 15, "Mining", 1, 8, neededTool: "Pickaxe", items: new() { new("oreTin", 1) }));
            tiles.Add(new GatheringTile("oreIron", "Iron Ore", "Mine", 100, 100, 15, "Mining", 10, 20, neededTool: "Pickaxe", items: new() { new("oreIron", 1) }));
            tiles.Add(new GatheringTile("oreCoal", "Coal", "Mine", 100, 100, 15, "Mining", 20, 55, neededTool: "Pickaxe", items: new() { new("oreCoal", 1) }));
            tiles.Add(new GatheringTile("oreMithril", "Mithril Ore", "Mine", 100, 100, 15, "Mining", 30, 65, neededTool: "Pickaxe", items: new() { new("oreMithril", 1) }));
            tiles.Add(new GatheringTile("oreLuminite", "Luminite", "Mine", 100, 100, 15, "Mining", 40, 80, neededTool: "Pickaxe", items: new() { new("oreLuminite", 1) }));
            tiles.Add(new GatheringTile("oreAdamant", "Adamant Ore", "Mine", 100, 100, 15, "Mining", 40, 90, neededTool: "Pickaxe", items: new() { new("oreAdamant", 1) }));

            tiles.Add(new GatheringTile("fishNetSmall", "Small Net Spot", "Fish", 100, 10, 15, "Fishing", 1, 10, neededTool: "Small net", items: new() { new("fishRawShrimp", 3), new("fishRawAnchovies", 1, "Fishing", 5, 40) }));
            tiles.Add(new GatheringTile("fishNetBig", "Big Net Spot", "Fish", 100, 10, 15, "Fishing", 16, 20, neededTool: "Big net", items: new() { new("fishRawMackerel", 8), new("fishRawCod", 4, "Fishing", 23, 45), new("fishRawBass", 2, "Fishing", 46, 100) }));
            tiles.Add(new GatheringTile("fishBaitLow", "Bait Spot (Low)", "Fish", 100, 10, 15, "Fishing", 5, 20, neededTool: "Fishing rod", neededBait: "baitFish", items: new() { new("fishRawSardine", 5), new("fishRawHerring", 3, "Fishing", 10, 30), new("fishRawPike", 2, "Fishing", 25, 60) }));
            tiles.Add(new GatheringTile("fishLure", "Lure Spot", "Fish", 100, 10, 15, "Fishing", 20, 50, neededTool: "Fly fishing rod", neededBait: "feather", items: new() { new("fishRawTrout", 5), new("fishRawSalmon", 3, "Fishing", 30, 70) }));
            
            tiles.Add(new GatheringTile("stallVegetable", "Vegetable Stall", "Steal from", 100, 30, 10, "Thieving", 2, 10, items: new() { new("potato", 2), new("onion", 2), new("cabbage", 2), new("tomato", 2), new("garlic", 1) }));
            tiles.Add(new GatheringTile("stallBakery", "Bakery Stall", "Steal from", 100, 30, 10, "Thieving", 5, 16, items: new() { new("bread", 4), new("cake", 5), new("cakeChocolate2", 1) }));
            tiles.Add(new GatheringTile("stallCrafting", "Crafting Stall", "Steal from", 100, 30, 10, "Thieving", 10, 16, items: new() { new("chisel", 1), new("mouldNecklace", 5), new("mouldRing", 1) }));
            tiles.Add(new GatheringTile("stallWine", "Wine Stall", "Steal from", 100, 30, 10, "Thieving", 22, 27, items: new() { new("jugEmpty", 12), new("jugWater", 5), new("grapes", 6), new("jugWine", 5), new("bottleWine", 2) }));
            tiles.Add(new GatheringTile("stallSeed", "Seed Stall", "Steal from", 100, 30, 10, "Thieving", 27, 10, items: new() { new("seedPotato", 15), new("seedOnion", 15), new("seedCabbage", 12), new("seedTomato", 5), new("seedSweetcorn", 6), new("seedWatermelon", 2), new("seedBarley", 16), new("seedHammerstone", 20), new("seedAsgarnian", 11), new("seedJute", 7), new("seedYanillian", 9), new("seedKrandorian", 4), new("seedWildblood", 1), new("seedMarigold", 20), new("seedRosemary", 6), new("seedNasturtium", 4) }));


            tiles.Add(new GatheringTile("sheep", "Sheep", "Shear", 100, 100, 5, "Farming", 0, 0, 0, 0, false, "Shears", "", new() { new("woolRaw", 1) }));
            tiles.Add(new GatheringTile("clueCrates", "Crates", "Search", 100, 100, 5));

            tiles.Add(new GatheringTile("lumbridgeFlag", "Lumbridge Flag", "Raise", 100, 100, 0)); // TODO: Make this tie into the task/achievement diary system, it's a Lumbridge task



            for (int i = 0; i < tiles.Count; i++) {
                GatherSpots.Add(tiles[i].ID, tiles[i]);
            } 
        }
    }
}
