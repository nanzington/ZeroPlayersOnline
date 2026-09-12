using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedProcessing {
        public static void InitProcessors(Dictionary<string, ProcessingStation> Stations) {
            List<ProcessingStation> toAdd = new();

            toAdd.Add(new("Furnace") {
                Recipes = new() {
                    new ProcessingRecipe("oreMixBronze", "barBronze", "Smithing", 1, 7),
                    new ProcessingRecipe("oreMixIron", "barIron", "Smithing", 10, 20),
                    new ProcessingRecipe("oreMixSteel", "barSteel", "Smithing", 20, 32),
                    new ProcessingRecipe("oreMixMithril", "barMithril", "Smithing", 30, 60),
                    new ProcessingRecipe("oreMixAdamant", "barAdamant", "Smithing", 40, 85)
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
                    new ProcessingRecipe("meatRawRat", "meatCookedBeef", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawChicken", "meatCookedChicken", "Cooking", 1, 15),
                    new ProcessingRecipe("meatRawBird", "meatCookedBird", "Cooking", 10, 50),
                    new ProcessingRecipe("fishRawShrimp", "fishCookedShrimp", "Cooking", 1, 15),
                    new ProcessingRecipe("fishRawAnchovies", "fishCookedAnchovies", "Cooking", 1, 30),
                    new ProcessingRecipe("fishRawSardine", "fishCookedSardine", "Cooking", 1, 40),
                    new ProcessingRecipe("fishRawHerring", "fishCookedHerring", "Cooking", 5, 50),
                    new ProcessingRecipe("fishRawMackerel", "fishCookedMackerel", "Cooking", 10, 60),
                    new ProcessingRecipe("fishRawTrout", "fishCookedTrout", "Cooking", 15, 70),
                    new ProcessingRecipe("fishRawCod", "fishCookedCod", "Cooking", 18, 75),
                    new ProcessingRecipe("fishRawPike", "fishCookedPike", "Cooking", 20, 80),
                    new ProcessingRecipe("fishRawSalmon", "fishCookedSalmon", "Cooking", 25, 90),
                    new ProcessingRecipe("fishRawTuna", "fishCookedTuna", "Cooking", 30, 100),
                    new ProcessingRecipe("fishRawLobster", "fishCookedLobster", "Cooking", 40, 120),
                    new ProcessingRecipe("fishRawBass", "fishCookedBass", "Cooking", 43, 130),
                    new ProcessingRecipe("fishRawSwordfish", "fishCookedSwordfish", "Cooking", 45, 140),
                    new ProcessingRecipe("doughBread", "bread", "Cooking", 1, 30),
                    new ProcessingRecipe("potato", "potatoBaked", "Cooking", 7, 15),
                    new ProcessingRecipe("tinCakeBatter", "cake", "Cooking", 40, 180, secondaryOut: "tinCakeEmpty")
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
                    new ProcessingRecipe("vialEmpty", "vialWater", "", 0, 0), 
                    new ProcessingRecipe("bowlEmpty", "bowlWater", "", 0, 0), 
                    new ProcessingRecipe("jugEmpty", "jugWater", "", 0, 0), 
                    new ProcessingRecipe("potFlour", "doughBread", "", 0, 0, secondaryOut: "potEmpty")
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

            toAdd.Add(new("Windmill") {
                Recipes = new() {
                    new ProcessingRecipe("grain", "potFlour", "", 0, 0, secondaryIn: "potEmpty")
                }
            });

            toAdd.Add(new("Dairy Cow") {
                Recipes = new() {
                    new ProcessingRecipe("bucketEmpty", "bucketMilk", "", 0, 0)
                }
            });

            for (int i = 0; i < toAdd.Count; i++) {
                Stations.Add(toAdd[i].Name, toAdd[i]);
            }
        }
    }
}
