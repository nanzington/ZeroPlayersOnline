using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedUseRecipes {
        public static void InitUseRecipes(Dictionary<TwoWayString, Recipe> RecipeLib) {
            List<Recipe> toAdd = new();

            // Firemaking
            toAdd.Add(new("tinderbox", "logPine", "_fire", 0, 1, 1, "Firemaking", 1, 40, miscStr: "ashes")); 

            // Smithing, ore mixes
            toAdd.Add(new("oreCopper", "oreTin", "oreMixBronze", 1, 1, 1, "Smithing", 1, 2));
            toAdd.Add(new("oreIron", "oreIron", "oreMixIron", 1, 1, 1, "Smithing", 10, 4));
            toAdd.Add(new("oreIron", "oreCoal", "oreMixSteel", 1, 1, 1, "Smithing", 20, 8));
            toAdd.Add(new("oreMithril", "oreCoal", "oreMixMithril", 1, 1, 1, "Smithing", 30, 16));
            toAdd.Add(new("oreAdamant", "oreLuminite", "oreMixAdamant", 1, 1, 1, "Smithing", 40, 32));

            // Fletching
            toAdd.Add(new("bowstring", "shortbowPineU", "shortbowPine", 1, 1, 1, "Fletching", 1, 5));
            toAdd.Add(new("bowstring", "shortbowOakU", "shortbowOak", 1, 1, 1, "Fletching", 10, 10));
            toAdd.Add(new("bowstring", "shortbowWillowU", "shortbowWillow", 1, 1, 1, "Fletching", 20, 15));
            toAdd.Add(new("bowstring", "shortbowTeakU", "shortbowTeak", 1, 1, 1, "Fletching", 30, 30));
            toAdd.Add(new("bowstring", "shortbowMapleU", "shortbowMaple", 1, 1, 1, "Fletching", 40, 45));
            toAdd.Add(new("bowstring", "shortbowAcadiaU", "shortbowAcadia", 1, 1, 1, "Fletching", 50, 60));
            toAdd.Add(new("bowstring", "shortbowMahoganyU", "shortbowMahogany", 1, 1, 1, "Fletching", 60, 75));
            toAdd.Add(new("bowstring", "shortbowYewU", "shortbowYew", 1, 1, 1, "Fletching", 70, 90));
            toAdd.Add(new("bowstring", "shortbowMagicU", "shortbowMagic", 1, 1, 1, "Fletching", 80, 105));
            toAdd.Add(new("bowstring", "shortbowElderU", "shortbowElder", 1, 1, 1, "Fletching", 90, 120));
            toAdd.Add(new("arrowshaft", "feather", "headlessShaft", 15, 15, 15, "Fletching", 1, 15)); 
            toAdd.Add(new("headlessShaft", "arrowheadsBronze", "arrowsBronze", 15, 15, 15, "Fletching", 1, 20)); 
            toAdd.Add(new("headlessShaft", "arrowheadsIron", "arrowsIron", 15, 15, 15, "Fletching", 10, 40)); 
            toAdd.Add(new("headlessShaft", "arrowheadsSteel", "arrowsSteel", 15, 15, 15, "Fletching", 20, 80)); 
            toAdd.Add(new("headlessShaft", "arrowheadsMithril", "arrowsMithril", 15, 15, 15, "Fletching", 30, 120)); 
            toAdd.Add(new("headlessShaft", "arrowheadsAdamant", "arrowsAdamant", 15, 15, 15, "Fletching", 40, 160)); 
            toAdd.Add(new("boltsUnfBronze", "feather", "boltsBronze", 10, 10, 10, "Fletching", 1, 5)); 
            toAdd.Add(new("boltsUnfIron", "feather", "boltsIron", 10, 10, 10, "Fletching", 10, 15)); 
            toAdd.Add(new("boltsUnfSteel", "feather", "boltsSteel", 10, 10, 10, "Fletching", 20, 35)); 
            toAdd.Add(new("boltsUnfMithril", "feather", "boltsMithril", 10, 10, 10, "Fletching", 30, 50));
            toAdd.Add(new("boltsUnfAdamant", "feather", "boltsAdamant", 10, 10, 10, "Fletching", 40, 70));  

            // Herblore
            toAdd.Add(new("vialWater", "herbCleanGuam", "potionUnfGuam", 1, 1, 1, "Herblore", 1, 0)); 
            toAdd.Add(new("potionUnfGuam", "eyeNewt", "potionAttack", 1, 1, 1, "Herblore", 1, 25)); 


            // Cooking 
            toAdd.Add(new("potFlour", "bucketWater", "doughBread", 1, 1, 1, "Cooking", 1, 0, returns: ["potEmpty", "bucketEmpty"]));
            toAdd.Add(new("potFlour", "jugWater", "doughBread", 1, 1, 1, "Cooking", 1, 0, returns: ["potEmpty", "jugEmpty"]));
            toAdd.Add(new("potFlour", "bowlWater", "doughBread", 1, 1, 1, "Cooking", 1, 0, returns: ["potEmpty", "bowlEmpty"]));
            toAdd.Add(new("tinCakeEmpty", "eggChicken", "tinCakeEgg", 1, 1, 1, "Cooking", 1, 0)); 
            toAdd.Add(new("tinCakeEgg", "potFlour", "tinCakeFlour", 1, 1, 1, "Cooking", 1, 0, returns: ["potEmpty"])); 
            toAdd.Add(new("tinCakeFlour", "bucketMilk", "tinCakeBatter", 1, 1, 1, "Cooking", 1, 0, returns: ["bucketEmpty"])); 
            toAdd.Add(new("cakeChocolate2", "cakeChocolate2", "cakeChocolate1", 1, 1, 1, "Cooking", 1, 0)); 
            toAdd.Add(new("cakeChocolate2", "cakeChocolate1", "cakeChocolate", 1, 1, 1, "Cooking", 1, 0)); 
             
            // Farming 
            toAdd.Add(new("plantPot", "seedTreePine", "plantPotPine", 1, 1, 1, "Farming", 1, 10)); 
            toAdd.Add(new("plantPot", "seedTreeOak", "plantPotOak", 1, 1, 1, "Farming", 1, 20)); 
            toAdd.Add(new("plantPot", "seedTreeWillow", "plantPotWillow", 1, 1, 1, "Farming", 1, 30)); 
            toAdd.Add(new("plantPot", "seedTreeTeak", "plantPotTeak", 1, 1, 1, "Farming", 1, 40)); 
            toAdd.Add(new("plantPot", "seedTreeMaple", "plantPotMaple", 1, 1, 1, "Farming", 1, 50)); 
            toAdd.Add(new("plantPot", "seedTreeAcadia", "plantPotAcadia", 1, 1, 1, "Farming", 1, 60)); 
            toAdd.Add(new("plantPot", "seedTreeMahogany", "plantPotMahogany", 1, 1, 1, "Farming", 1, 70)); 
            toAdd.Add(new("plantPot", "seedTreeYew", "plantPotYew", 1, 1, 1, "Farming", 1, 80)); 
            toAdd.Add(new("plantPot", "seedTreeMagic", "plantPotMagic", 1, 1, 1, "Farming", 1, 90)); 
            toAdd.Add(new("plantPot", "seedTreeElder", "plantPotElder", 1, 1, 1, "Farming", 1, 100));  
            toAdd.Add(new("plantPot", "seedTreeApple", "plantPotApple", 1, 1, 1, "Farming", 1, 27)); 
            toAdd.Add(new("plantPot", "seedTreeBanana", "plantPotBanana", 1, 1, 1, "Farming", 1, 33)); 
            toAdd.Add(new("plantPot", "seedTreeOrange", "plantPotOrange", 1, 1, 1, "Farming", 1, 39)); 
            toAdd.Add(new("plantPot", "seedTreeCurry", "plantPotCurry", 1, 1, 1, "Farming", 1, 42)); 
            toAdd.Add(new("plantPot", "seedTreePineapple", "plantPotPineapple", 1, 1, 1, "Farming", 1, 51)); 
            toAdd.Add(new("plantPot", "seedTreePapaya", "plantPotPapaya", 1, 1, 1, "Farming", 1, 57)); 
            toAdd.Add(new("plantPot", "seedTreePalm", "plantPotPalm", 1, 1, 1, "Farming", 1, 68)); 

            for (int i = 0; i < toAdd.Count; i++) {
                TwoWayString ID = new(toAdd[i].FirstItem, toAdd[i].SecondItem);
                RecipeLib.Add(ID, toAdd[i]);
            }
        }
    }
}
