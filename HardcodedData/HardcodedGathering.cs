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
            tiles.Add(new GatheringTile() {
                ID = "treePine",
                Name = "Pine Tree",
                Skill = "Woodcutting",
                InteractVerb = "Chop",
                Level = 1,
                ExpGranted = 25,
                ExpOnFail = 0,
                SuccessChance = 100,
                DepleteChance = 100,
                RestockTime = 15,
                DamageOnFail = 0,
                PossibleItems = new() { new("logPine", 1) }
            });

            tiles.Add(new GatheringTile() {
                ID = "oreCopper",
                Name = "Copper Ore",
                Skill = "Mining",
                InteractVerb = "Mine",
                Level = 1,
                ExpGranted = 17,
                ExpOnFail = 0,
                SuccessChance = 100,
                DepleteChance = 100,
                RestockTime = 15,
                DamageOnFail = 0,
                PossibleItems = new() { new("oreCopper", 1) }
            });

            tiles.Add(new GatheringTile() {
                ID = "oreTin",
                Name = "Tin Ore",
                Skill = "Mining",
                InteractVerb = "Mine",
                Level = 1,
                ExpGranted = 18,
                ExpOnFail = 0,
                SuccessChance = 100,
                DepleteChance = 100,
                RestockTime = 15,
                DamageOnFail = 0,
                PossibleItems = new() { new("oreTin", 1) }
            });

            tiles.Add(new GatheringTile() {
                ID = "fishNetSmall",
                Name = "Small Net Spot",
                Skill = "Fishing",
                InteractVerb = "Fish",
                Level = 1,
                ExpGranted = 10,
                ExpOnFail = 0,
                SuccessChance = 100,
                DepleteChance = 10,
                RestockTime = 15,
                DamageOnFail = 0,
                PossibleItems = new() { new("fishRawShrimp", 3), new("fishRawAnchovies", 1) }
            });



            for (int i = 0; i < tiles.Count; i++) {
                GatherSpots.Add(tiles[i].ID, tiles[i]);
            } 
        }
    }
}
