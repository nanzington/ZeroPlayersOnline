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

            toAdd.Add(new("Tannery") {
                Recipes = new() {
                    new ProcessingRecipe("cowhide", "leatherSoft", "Crafting", 1, 5),
                    new ProcessingRecipe("leatherSoft", "leatherHard", "Crafting", 1, 5)
                }
            });

            toAdd.Add(new("Anvil") {
                OpensUI = true
            });

            toAdd.Add(new("Range") {
                Recipes = new() {
                    new ProcessingRecipe("meatRawNewt", "meatCookedNewt", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawBeef", "meatCookedBeef", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawChicken", "meatCookedChicken", "Cooking", 1, 15),
                    new ProcessingRecipe("fishRawShrimp", "fishCookedShrimp", "Cooking", 1, 15),
                    new ProcessingRecipe("fishRawAnchovies", "fishCookedAnchovies", "Cooking", 1, 15),
                    new ProcessingRecipe("potato", "potatoBaked", "Cooking", 7, 15)
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
                    new ProcessingRecipe("bucketEmpty", "bucketWater", "", 0, 0), 
                    new ProcessingRecipe("clayDust", "claySoft", "", 0, 0), 
                    new ProcessingRecipe("vialEmpty", "vialWater", "", 0, 0)
                }
            });

            toAdd.Add(new("Air Altar") {
                Recipes = new() {
                    new ProcessingRecipe("pureEssence", "runeAir", "Runecrafting", 1, 5, extra: true)
                }
            });

            toAdd.Add(new("Spinning Wheel") {
                Recipes = new() {
                    new ProcessingRecipe("flax", "bowstring", "Crafting", 1, 5)
                }
            });


            for (int i = 0; i < toAdd.Count; i++) {
                Stations.Add(toAdd[i].Name, toAdd[i]);
            }
        }
    }
}
