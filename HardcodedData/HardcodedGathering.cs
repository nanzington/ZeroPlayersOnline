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
                ID = "plantFlax",
                Name = "Wild Flax",
                Skill = "Farming",
                InteractVerb = "Pick",
                Level = 1,
                ExpGranted = 0,
                ExpOnFail = 0,
                SuccessChance = 100,
                DepleteChance = 60,
                RestockTime = 10,
                DamageOnFail = 0,
                PossibleItems = new() { new("flax", 1) }
            });

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
                ID = "rockEssence",
                Name = "Essence Rock",
                Skill = "Mining",
                InteractVerb = "Mine",
                Level = 1,
                ExpGranted = 5,
                ExpOnFail = 0,
                SuccessChance = 100,
                DepleteChance = 0,
                RestockTime = 15,
                DamageOnFail = 0,
                PossibleItems = new() { new("pureEssence", 1) }
            });

            tiles.Add(new GatheringTile() {
                ID = "rockClay",
                Name = "Clay Deposit",
                Skill = "Mining",
                InteractVerb = "Mine",
                Level = 1,
                ExpGranted = 5,
                ExpOnFail = 0,
                SuccessChance = 100,
                DepleteChance = 0,
                RestockTime = 15,
                DamageOnFail = 0,
                PossibleItems = new() { new("clayDust", 1) }
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

            tiles.Add(new GatheringTile() {
                ID = "clueCrates",
                Name = "Crates", 
                InteractVerb = "Search",
                Level = 0
            });



            for (int i = 0; i < tiles.Count; i++) {
                GatherSpots.Add(tiles[i].ID, tiles[i]);
            } 
        }
    }
}
