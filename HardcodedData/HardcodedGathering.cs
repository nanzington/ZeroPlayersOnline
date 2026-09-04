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
            tiles.Add(new GatheringTile("plantFlax", "Wild FLax", "Pick", 100, 60, 10, "Farming", 1, 0, 0, items: new() { new("flax", 1) })); 
            tiles.Add(new GatheringTile("plantGuam", "Guam Bush", "Pick", 100, 100, 10, "Farming", 1, 5, 0,items: new() { new("herbGrimyGuam", 1) }));

            tiles.Add(new GatheringTile("treePine", "Pine Tree", "Chop", 100, 100, 10, "Woodcutting", 1, 25, 0, neededTool: "Hatchet", items: new() { new("logPine", 1) }));
            tiles.Add(new GatheringTile("rootsPine", "Pine Roots", "Chop", 100, 100, 10, "Woodcutting", 1, 25, 0, neededTool: "Hatchet", items: new() { new("logPine", 1) }));

            tiles.Add(new GatheringTile("rockEssence", "Essence Rock", "Mine", 100, 30, 10, "Mining", 1, 5, neededTool: "Pickaxe", items: new() { new("pureEssence", 1) })); 
            tiles.Add(new GatheringTile("rockClay", "Clay Deposit", "Mine", 100, 60, 10, "Mining", 1, 5, neededTool: "Pickaxe", items: new() { new("clayDust", 1) }) ); 
            tiles.Add(new GatheringTile("oreCopper", "Copper Ore", "Mine", 100, 100, 15, "Mining", 1, 17, neededTool: "Pickaxe", items: new() { new("oreCopper", 1) })); 
            tiles.Add(new GatheringTile("oreTin", "Tin Ore", "Mine", 100, 100, 15, "Mining", 1, 18, neededTool: "Pickaxe", items: new() { new("oreTin", 1) }));

            tiles.Add(new GatheringTile("fishNetSmall", "Small Net Spot", "Fish", 100, 10, 15, "Fishing", 1, 10, neededTool: "Small net", items: new() { new("fishRawShrimp", 3), new("fishRawAnchovies", 1) }));

            tiles.Add(new GatheringTile("clueCrates", "Crates", "Search", 100, 100, 5));



            for (int i = 0; i < tiles.Count; i++) {
                GatherSpots.Add(tiles[i].ID, tiles[i]);
            } 
        }
    }
}
