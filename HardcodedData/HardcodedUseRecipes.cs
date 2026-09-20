using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

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
            toAdd.Add(new("oreSilver", "oreSilver", "oreMixSilver", 1, 1, 1, "Smithing", 20, 8));
            toAdd.Add(new("oreGold", "oreGold", "oreMixGold", 1, 1, 1, "Smithing", 40, 32));
            
            toAdd.Add(new("shieldLeftHalf", "shieldRightHalf", "sqShieldDragon", s: "Smithing", lv: 60, exp: 75));

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
             
            toAdd.Add(new("stockPine", "limbsBronze", "crossbowPineU", 1, 1, 1, "Fletching", 1, 5));
            toAdd.Add(new("stockOak", "limbsIron", "crossbowOakU", 1, 1, 1, "Fletching", 10, 10));
            toAdd.Add(new("stockWillow", "limbsSteel", "crossbowWillowU", 1, 1, 1, "Fletching", 20, 15));
            toAdd.Add(new("stockTeak", "limbsMithril", "crossbowTeakU", 1, 1, 1, "Fletching", 30, 30));
            toAdd.Add(new("stockMaple", "limbsAdamant", "crossbowMapleU", 1, 1, 1, "Fletching", 40, 45));
            toAdd.Add(new("stockAcadia", "limbsRune", "crossbowAcadiaU", 1, 1, 1, "Fletching", 50, 60));
            toAdd.Add(new("stockMahogany", "limbsOrichalcum", "crossbowMahoganyU", 1, 1, 1, "Fletching", 60, 75));
            toAdd.Add(new("stockYew", "limbsNecrite", "crossbowYewU", 1, 1, 1, "Fletching", 70, 90));
            toAdd.Add(new("stockMagic", "limbsBanite", "crossbowMagicU", 1, 1, 1, "Fletching", 80, 105));
            toAdd.Add(new("stockElder", "limbsElderRune", "crossbowElderU", 1, 1, 1, "Fletching", 90, 120));
             
            toAdd.Add(new("crossbowString", "crossbowPineU", "crossbowPine", 1, 1, 1, "Fletching", 1, 3));
            toAdd.Add(new("crossbowString", "crossbowOakU", "crossbowOak", 1, 1, 1, "Fletching", 10, 5));
            toAdd.Add(new("crossbowString", "crossbowWillowU", "crossbowWillow", 1, 1, 1, "Fletching", 20, 8));
            toAdd.Add(new("crossbowString", "crossbowTeakU", "crossbowTeak", 1, 1, 1, "Fletching", 30, 15));
            toAdd.Add(new("crossbowString", "crossbowMapleU", "crossbowMaple", 1, 1, 1, "Fletching", 40, 23));
            toAdd.Add(new("crossbowString", "crossbowAcadiaU", "crossbowAcadia", 1, 1, 1, "Fletching", 50, 30));
            toAdd.Add(new("crossbowString", "crossbowMahoganyU", "crossbowMahogany", 1, 1, 1, "Fletching", 60, 38));
            toAdd.Add(new("crossbowString", "crossbowYewU", "crossbowYew", 1, 1, 1, "Fletching", 70, 45));
            toAdd.Add(new("crossbowString", "crossbowMagicU", "crossbowMagic", 1, 1, 1, "Fletching", 80, 53));
            toAdd.Add(new("crossbowString", "crossbowElderU", "crossbowElder", 1, 1, 1, "Fletching", 90, 60));

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
             
            toAdd.Add(new("grappleUnf", "rope", "grapple", 1, 1, 1, "Fletching", 20, 0));  

            // Herblore
            // // Unfinished Potions
            toAdd.Add(new("vialWater", "herbCleanGuam", "potionUnfGuam", 1, 1, 1, "Herblore", 1, 0));  
            toAdd.Add(new("vialWater", "herbCleanTarromin", "potionUnfTarromin", 1, 1, 1, "Herblore", 5, 0)); 
            toAdd.Add(new("vialWater", "herbCleanMarrentill", "potionUnfMarrentill", 1, 1, 1, "Herblore", 9, 0)); 
            toAdd.Add(new("vialWater", "herbCleanHarralander", "potionUnfHarralander", 1, 1, 1, "Herblore", 18, 0)); 
            toAdd.Add(new("vialWater", "herbCleanRanarr", "potionUnfRanarr", 1, 1, 1, "Herblore", 25, 0)); 
            toAdd.Add(new("vialWater", "herbCleanToadflax", "potionUnfToadflax", 1, 1, 1, "Herblore", 30, 0)); 
            toAdd.Add(new("vialWater", "herbCleanSpiritweed", "potionUnfSpiritweed", 1, 1, 1, "Herblore", 35, 0)); 
            toAdd.Add(new("vialWater", "herbCleanIrit", "potionUnfIrit", 1, 1, 1, "Herblore", 40, 0)); 
            toAdd.Add(new("vialWater", "herbCleanWergali", "potionUnfWergali", 1, 1, 1, "Herblore", 41, 0)); 
            toAdd.Add(new("vialWater", "herbCleanAvantoe", "potionUnfAvantoe", 1, 1, 1, "Herblore", 48, 0)); 
            toAdd.Add(new("vialWater", "herbCleanKwuarm", "potionUnfKwuarm", 1, 1, 1, "Herblore", 54, 0)); 
            toAdd.Add(new("vialWater", "herbCleanBloodweed", "potionUnfBloodweed", 1, 1, 1, "Herblore", 57, 0)); 
            toAdd.Add(new("vialWater", "herbCleanSnapdragon", "potionUnfSnapdragon", 1, 1, 1, "Herblore", 63, 0)); 
            toAdd.Add(new("vialWater", "herbCleanCadantine", "potionUnfCadantine", 1, 1, 1, "Herblore", 65, 0)); 
            toAdd.Add(new("vialWater", "herbCleanLantadyme", "potionUnfLantadyme", 1, 1, 1, "Herblore", 67, 0)); 
            toAdd.Add(new("vialWater", "herbCleanDwarfweed", "potionUnfDwarfweed", 1, 1, 1, "Herblore", 70, 0)); 
            toAdd.Add(new("vialWater", "herbCleanTorstol", "potionUnfTorstol", 1, 1, 1, "Herblore", 75, 0)); 
            toAdd.Add(new("vialWater", "herbCleanArbuck", "potionUnfArbuck", 1, 1, 1, "Herblore", 77, 0)); 
            toAdd.Add(new("vialWater", "herbCleanFellstalk", "potionUnfFellstalk", 1, 1, 1, "Herblore", 91, 0));  
              
            toAdd.Add(new("potionUnfGuam", "eyeNewt", "potionAttack", 1, 1, 1, "Herblore", 1, 25));
            toAdd.Add(new("potionUnfGuam", "redberry", "potionRanging", 1, 1, 1, "Herblore", 3, 30));

            toAdd.Add(new("potionUnfTarromin", "beadRed", "potionMagic", 1, 1, 1, "Herblore", 5, 35));
            toAdd.Add(new("potionUnfTarromin", "beadWhite", "potionMagic", 1, 1, 1, "Herblore", 5, 35));
            toAdd.Add(new("potionUnfTarromin", "beadBlack", "potionMagic", 1, 1, 1, "Herblore", 5, 35));
            toAdd.Add(new("potionUnfTarromin", "beadYellow", "potionMagic", 1, 1, 1, "Herblore", 5, 35));
            toAdd.Add(new("potionUnfTarromin", "limpwurt", "potionStrength", 1, 1, 1, "Herblore", 7, 40));

            toAdd.Add(new("potionUnfMarrentill", "bearFur", "potionDefense", 1, 1, 1, "Herblore", 9, 45));
            toAdd.Add(new("potionUnfMarrentill", "unicornHornDust", "potionAntipoison", 1, 1, 1, "Herblore", 13, 50));  
             
            toAdd.Add(new("potionUnfHarralander", "goatHornDust", "potionCombat", 1, 1, 1, "Herblore", 36, 84));  
            toAdd.Add(new("potionUnfHarralander", "fishCookedSwordfish", "potionCooking", 1, 1, 1, "Herblore", 55, 125)); 
            toAdd.Add(new("potionUnfHarralander", "chocolateDust", "potionEnergy", 1, 1, 1, "Herblore", 30, 74));
            toAdd.Add(new("potionUnfHarralander", "spiderEggsRed", "potionRestore", 1, 1, 1, "Herblore", 22, 63));     
             
            toAdd.Add(new("pestleMortar", "unicornHorn", "unicornHornDust", 0, 1, 1, "")); 
            toAdd.Add(new("pestleMortar", "chocolateBar", "chocolateDust", 0, 1, 1, "")); 


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

            // Crafting
            List<MaterialDef> Jewels = new() {
                new("Gold", Color.Goldenrod, 0, 5, 400, "Gold"),
                new("Opal", Color.AntiqueWhite, 1, 7, 15, "Opal"),
                new("Jade", Color.PaleGreen, 1, 27, 20, "Jade"),
                new("Red topaz", Color.Magenta, 1, 49, 25, "RedTopaz"),
                new("Sapphire", Color.DeepSkyBlue, 2, 7, 50, "Sapphire"),
                new("Emerald", Color.Lime, 3, 27, 68, "Emerald"),
                new("Ruby", Color.Crimson, 4, 49, 85, "Ruby"),
                new("Diamond", Color.White, 5, 57, 108, "Diamond"),
                new("Dragonstone", Color.Purple, 6, 68, 138, "Dragonstone"),
                new("Onyx", Color.DimGray, 7, 87, 180, "Onyx"),
                new("Zenyte", Color.Orange, 8, 93, 200, "Zenyte")
            };

            foreach (var mat in Jewels) { 
                toAdd.Add(new("amulet" + mat.Descriptor + "U", "woolBall", "amulet" + mat.Descriptor, 1, 1, 1, "Crafting", mat.Level, 4)); 
                if (mat.Name != "Gold") {
                    toAdd.Add(new("uncut" + mat.Descriptor, "chisel", "cut" + mat.Descriptor, 1, 0, 1, "Crafting", mat.Level, mat.CostMultiplier)); 
                }
            }
             
            toAdd.Add(new("bodyHardleather", "studsSteel", "bodyStudded", 1, 1, 1, "Crafting", 20, 40)); 
            toAdd.Add(new("coifHardleather", "studsSteel", "coifStudded", 1, 1, 1, "Crafting", 20, 40)); 
            toAdd.Add(new("chapsHardleather", "studsSteel", "chapsStudded", 1, 1, 1, "Crafting", 20, 40)); 
            toAdd.Add(new("vambracesHardleather", "studsSteel", "vambracesStudded", 1, 1, 1, "Crafting", 20, 40)); 
            toAdd.Add(new("bootsHardleather", "studsSteel", "bootsStudded", 1, 1, 1, "Crafting", 20, 40)); 

            
            toAdd.Add(new("candle", "candleLanternEmpty", "candleLantern"));
            toAdd.Add(new("candleLit", "candleLanternEmpty", "candleLanternLit")); 
            toAdd.Add(new("oilLamp", "oilLanternFrame", "oilLantern", s: "Crafting", lv: 26, exp: 50));
            toAdd.Add(new("oilLampLit", "oilLanternFrame", "oilLanternLit", s: "Crafting", lv: 26, exp: 50));
            
            toAdd.Add(new("kharidianHeadpiece", "beardFake", "desertDisguise"));
            toAdd.Add(new("knife", "fruitBanana", "fruitBananaSlices", 0));  
            toAdd.Add(new("knife", "fruitOrange", "fruitOrangeSlices", 0)); 
            toAdd.Add(new("knife", "fruitOrangeSlices", "fruitOrangeChunks", 0)); 
            toAdd.Add(new("knife", "fruitPineapple", "fruitPineappleRing", 0, oQ: 4)); 
            toAdd.Add(new("knife", "fruitPineappleRing", "fruitPineappleChunks", 0)); 
            toAdd.Add(new("hammer", "fruitCoconut", "fruitCoconutHalf", 0)); 
            toAdd.Add(new("vialEmpty", "fruitCoconutHalf", "fruitCoconutMilk", returns: ["fruitCoconutShell"]));    

            for (int i = 0; i < toAdd.Count; i++) {
                TwoWayString ID = new(toAdd[i].FirstItem, toAdd[i].SecondItem);
                RecipeLib.Add(ID, toAdd[i]);
            }
        }
    }
}
