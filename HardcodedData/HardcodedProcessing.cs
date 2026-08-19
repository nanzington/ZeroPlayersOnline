using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedProcessing {
        public static void InitProcessors(Dictionary<string, ProcessingStation> Stations) {
            List<ProcessingStation> toAdd = new();

            toAdd.Add(new("Furnace") {
                Recipes = new() {
                    new ProcessingRecipe("oreMixBronze", "barBronze", "Smithing", 1, 7)
                }
            });

            toAdd.Add(new("Anvil") {
                Recipes = new() {
                    new ProcessingRecipe("progHelmBronze2", "helmBronze", "Smithing", 1, 30),
                    new ProcessingRecipe("progDaggerBronze", "daggerBronze", "Smithing", 1, 15)
                }
            });

            toAdd.Add(new("Range") {
                Recipes = new() {
                    new ProcessingRecipe("meatRawNewt", "meatCookedNewt", "Cooking", 1, 15),
                    new ProcessingRecipe("fishRawShrimp", "fishCookedShrimp", "Cooking", 1, 15),
                    new ProcessingRecipe("fishRawAnchovies", "fishCookedAnchovies", "Cooking", 1, 15)
                }
            });

            toAdd.Add(new("Sink") {
                Recipes = new() {
                    new ProcessingRecipe("bucketEmpty", "bucketWater", "", 0, 0)
                }
            });


            for (int i = 0; i < toAdd.Count; i++) {
                Stations.Add(toAdd[i].Name, toAdd[i]);
            }
        }
    }
}
