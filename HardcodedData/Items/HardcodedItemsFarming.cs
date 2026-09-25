using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsFarming {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();
             
            // // Farming - Allotments
            {
                itemsToAdd.Add(new Item("Potato seed", "Aren't potatoes potato seeds?", "seedPotato", 205, 127, 50, 5, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "potato",
                    UseInt = 1 /* Level */, UseInt2 = 10 /* Exp on Harvest */, UseInt3 = 2400 /* Growth time in seconds */

                });
                itemsToAdd.Add(new Item("Potato", "A tuber most versatile.", "potato", 205, 127, 50, 5) { UseString = "Heal", UseInt = 1 });

                itemsToAdd.Add(new Item("Onion seed", "An onion seed - plant in an allotment. (5)", "seedOnion", 240, 234, 214, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "onion",
                    UseInt = 7 /* Level */,  UseInt2 = 20 /* Exp On Harvest */, UseInt3 = 2400 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Onion", "A strong smelling onion.", "onion", 240, 234, 214, 12));

                itemsToAdd.Add(new Item("Cabbage seed", "A cabbage seed - plant in an allotment. (7)", "seedCabbage", 175, 97, 20, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "cabbage",
                    UseInt = 7 /* Level */,  UseInt2 = 21 /* Exp On Harvest */, UseInt3 = 2400 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Cabbage", "Yuck, I don't like cabbage.", "cabbage", 34, 139, 34, 15) { UseString = "Heal", UseInt = 1 });

                itemsToAdd.Add(new Item("Tomato seed", "A tomato seed - plant in an allotment. (12)", "seedTomato", 255, 255, 0, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "tomato",
                    UseInt = 12 /* Level */,  UseInt2 = 27 /* Exp On Harvest */, UseInt3 = 2400 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Tomato", "This would make good ketchup.", "tomato", 220, 20, 60, 14) { UseString = "Heal", UseInt = 2 });

                itemsToAdd.Add(new Item("Sweetcorn seed", "A sweetcorn seed - plant in an allotment. (20)", "seedSweetcorn", 255, 255, 0, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "sweetcorn",
                    UseInt = 20 /* Level */,  UseInt2 = 36 /* Exp On Harvest */, UseInt3 = 3600 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Sweetcorn", "Raw sweetcorn.", "sweetcorn", 255, 255, 0, 20));

                itemsToAdd.Add(new Item("Strawberry seed", "A strawberry seed - plant in an allotment. (31)", "seedStrawberry", 255, 255, 0, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "strawberry",
                    UseInt = 31 /* Level */,  UseInt2 = 55 /* Exp On Harvest */, UseInt3 = 3600 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Strawberry", "A freshly picked strawberry.", "strawberry", 220, 20, 60, 20) { UseString = "Heal", UseInt = 4 });

                itemsToAdd.Add(new Item("Watermelon seed", "A watermelon seed - plant in an allotment. (47)", "seedWatermelon", 50, 50, 50, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "watermelon",
                    UseInt = 47 /* Level */,  UseInt2 = 102 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Watermelon", "A juicy watermelon.", "watermelon", 34, 139, 34, 20) { UseString = "Heal", UseInt = 10 });

                itemsToAdd.Add(new Item("Snape grass seed", "A snape grass seed - plant in an allotment. (38)", "seedSnapegrass", 0, 255, 0, 20, true) {
                    UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "snapegrass",
                    UseInt = 38 /* Level */,  UseInt2 = 80 /* Exp On Harvest */, UseInt3 = 12000 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Snape grass", "Strange spiky grass.", "snapegrass", 46, 139, 87, 10));
            }

            // // Farming - Flowers
            {
                itemsToAdd.Add(new Item("Marigold seed", "A marigold seed - plant in a flower patch. (2)", "seedMarigold", 245, 245, 220, 85, true) {
                    UseString = "PlantSeed", UseString2 = "Flower", UseString3 = "marigold",
                    UseInt = 2 /* Level */,  UseInt2 = 55 /* Exp On Harvest */, UseInt3 = 1200 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Marigold", "A bunch of marigolds.", "marigold", 255, 165, 0, 1));
                
                itemsToAdd.Add(new Item("Rosemary seed", "A rosemary seed - plant in a flower patch. (11)", "seedRosemary", 85, 107, 47, 98, true) {
                    UseString = "PlantSeed", UseString2 = "Flower", UseString3 = "rosemary",
                    UseInt = 11 /* Level */,  UseInt2 = 79 /* Exp On Harvest */, UseInt3 = 1200 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Rosemary", "Some rosemary.", "rosemary", 255, 165, 0, 2)); 

                itemsToAdd.Add(new Item("Nasturtium seed", "A nasturtium seed - plant in a flower patch. (24)", "seedNasturtium", 245, 245, 220, 11, true) {
                    UseString = "PlantSeed", UseString2 = "Flower", UseString3 = "nasturtium",
                    UseInt = 24 /* Level */,  UseInt2 = 130 /* Exp On Harvest */, UseInt3 = 1200 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Nasturtium", "A bunch of nasturtiums.", "nasturtium", 255, 0, 0, 4));

                itemsToAdd.Add(new Item("Woad seed", "A woad seed - plant in a flower patch. (25)", "seedWoad", Color.Beige, 11, true) {
                    UseString = "PlantSeed", UseString2 = "Flower", UseString3 = "woad",
                    UseInt = 25 /* Level */,  UseInt2 = 135 /* Exp On Harvest */, UseInt3 = 1200 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Woad leaf", "A slightly bluish leaf.", "woad", ColorLib.Magic, 4, true));

                itemsToAdd.Add(new Item("Limpwurt seed", "A limpwurt seed - plant in a flower patch. (7)", "seedLimpwurt", Color.SandyBrown, 11, true) {
                    UseString = "PlantSeed", UseString2 = "Flower", UseString3 = "limpwurt",
                    UseInt = 7 /* Level */,  UseInt2 = 70 /* Exp On Harvest */, UseInt3 = 1200 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Limpwurt root", "The root of a limpwurt plant.", "limpwurt", Color.SandyBrown, 4, true));

                itemsToAdd.Add(new Item("White lily seed", "A white lily seed - plant in a flower patch. (52)", "seedWhiteLily", ColorLib.Mithril, 1250, true) {
                    UseString = "PlantSeed", UseString2 = "Flower", UseString3 = "ashes",
                    UseInt = 52 /* Level */,  UseInt2 = 300 /* Exp On Harvest */, UseInt3 = 9600 /* Growth time in seconds */ 

                }); 
            }

            // // Farming - Herbs
            {
                // Guam
                itemsToAdd.Add(new Item("Guam seed", "A guam seed - plant in an herb patch.", "seedGuam", Color.ForestGreen, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyGuam",
                    UseInt = 1 /* Level */,  UseInt2 = 20 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 

                });
                itemsToAdd.Add(new Item("Grimy guam leaf", "It needs cleaning.", "herbGrimyGuam", ColorLib.Guam, 13) { UseString = "CleanHerb", ItemReturned = "herbCleanGuam", UseInt = 1, UseInt2 = 3 }); 
                itemsToAdd.Add(new Item("Guam leaf", "A bitter green herb.", "herbCleanGuam", ColorLib.Guam.GetBright(), 13)); 
                 
                // Tarromin
                itemsToAdd.Add(new Item("Tarromin seed", "A tarromin seed - plant in an herb patch. (5)", "seedTarromin", Color.Lime, 10, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyTarromin",
                    UseInt = 5 /* Level */,  UseInt2 = 30 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy tarromin", "It needs cleaning.", "herbGrimyTarromin", ColorLib.Tarromin.GetDark(), 13) { UseString = "CleanHerb", ItemReturned = "herbCleanTarromin", UseInt = 5, UseInt2 = 4 }); 
                itemsToAdd.Add(new Item("Tarromin", "A fresh herb.", "herbCleanTarromin", ColorLib.Tarromin, 13)); 
                 
                // Marrentill
                itemsToAdd.Add(new Item("Marrentill seed", "A marrentill seed - plant in an herb patch. (7)", "seedMarrentill", Color.Green, 11, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyMarrentill",
                    UseInt = 9 /* Level */,  UseInt2 = 40 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy marrentill", "It needs cleaning.", "herbGrimyMarrentill", ColorLib.Marrentill.GetDark(), 13) { UseString = "CleanHerb", ItemReturned = "herbCleanMarrentill", UseInt = 9, UseInt2 = 5 }); 
                itemsToAdd.Add(new Item("Marrentill", "A fresh herb.", "herbCleanMarrentill", ColorLib.Marrentill, 13)); 

                // Harralander
                itemsToAdd.Add(new Item("Harralander seed", "A harralander seed - plant in an herb patch. (20)", "seedHarralander", Color.SeaGreen, 15, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyHarralander",
                    UseInt = 20 /* Level */,  UseInt2 = 50 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy harralander", "It needs cleaning.", "herbGrimyHarralander", ColorLib.Harralander.GetDark(), 13) { UseString = "CleanHerb", ItemReturned = "herbCleanHarralander", UseInt = 20, UseInt2 = 6 }); 
                itemsToAdd.Add(new Item("Harralander", "A fresh herb.", "herbCleanHarralander", ColorLib.Harralander, 13));

                // Ranarr
                itemsToAdd.Add(new Item("Ranarr seed", "A ranarr seed - plant in an herb patch. (25)", "seedRanarr", Color.DarkOliveGreen, 15, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyRanarr",
                    UseInt = 25 /* Level */,  UseInt2 = 60 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy ranarr", "It needs cleaning.", "herbGrimyRanarr", ColorLib.Ranarr.GetDark(), 25) { UseString = "CleanHerb", ItemReturned = "herbCleanRanarr", UseInt = 25, UseInt2 = 7 }); 
                itemsToAdd.Add(new Item("Ranarr", "A fresh herb.", "herbCleanRanarr", ColorLib.Ranarr, 25));

                // Toadflax
                itemsToAdd.Add(new Item("Toadflax seed", "A toadflax seed - plant in an herb patch. (30)", "seedToadflax", Color.Green, 34, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyToadflax",
                    UseInt = 30 /* Level */,  UseInt2 = 70 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy toadflax", "It needs cleaning.", "herbGrimyToadflax", ColorLib.Toadflax.GetDark(), 25) { UseString = "CleanHerb", ItemReturned = "herbCleanToadflax", UseInt = 30, UseInt2 = 8 }); 
                itemsToAdd.Add(new Item("Toadflax", "A fresh herb.", "herbCleanToadflax", ColorLib.Toadflax, 25));

                // Spirit weed
                itemsToAdd.Add(new Item("Spirit weed seed", "A spirit weed seed - plant in an herb patch. (35)", "seedSpiritweed", Color.LawnGreen, 18, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimySpiritweed",
                    UseInt = 35 /* Level */,  UseInt2 = 80 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy spirit weed", "It needs cleaning.", "herbGrimySpiritweed", ColorLib.Spiritweed.GetDark(), 25) { UseString = "CleanHerb", ItemReturned = "herbCleanSpiritweed", UseInt = 35, UseInt2 = 9 }); 
                itemsToAdd.Add(new Item("Spirit weed", "A fresh herb.", "herbCleanSpiritweed", ColorLib.Spiritweed, 25));

                // Irit
                itemsToAdd.Add(new Item("Irit seed", "An irit seed - plant in an herb patch. (40)", "seedIrit", Color.LawnGreen, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyIrit",
                    UseInt = 40 /* Level */,  UseInt2 = 90 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy irit", "It needs cleaning.", "herbGrimyIrit", ColorLib.Irit.GetDark(), 40) { UseString = "CleanHerb", ItemReturned = "herbCleanIrit", UseInt = 40, UseInt2 = 9 }); 
                itemsToAdd.Add(new Item("Irit", "A fresh herb.", "herbCleanIrit", ColorLib.Irit, 40));

                // Wergali
                itemsToAdd.Add(new Item("Wergali seed", "A wergali seed - plant in an herb patch. (41)", "seedWergali", Color.Crimson, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyWergali",
                    UseInt = 41 /* Level */,  UseInt2 = 100 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy wergali", "It needs cleaning.", "herbGrimyWergali", ColorLib.Wergali.GetDark(), 44) { UseString = "CleanHerb", ItemReturned = "herbCleanWergali", UseInt = 41, UseInt2 = 9 }); 
                itemsToAdd.Add(new Item("Wergali", "A fresh herb.", "herbCleanWergali", ColorLib.Wergali, 44));

                // Avantoe
                itemsToAdd.Add(new Item("Avantoe seed", "A avantoe seed - plant in an herb patch. (48)", "seedAvantoe", Color.SpringGreen, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyAvantoe",
                    UseInt = 48 /* Level */,  UseInt2 = 110 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy avantoe", "It needs cleaning.", "herbGrimyAvantoe", ColorLib.Avantoe.GetDark(), 48) { UseString = "CleanHerb", ItemReturned = "herbCleanAvantoe", UseInt = 48, UseInt2 = 10 }); 
                itemsToAdd.Add(new Item("Avantoe", "A fresh herb.", "herbCleanAvantoe", ColorLib.Avantoe, 48));

                // Kwuarm
                itemsToAdd.Add(new Item("Kwuarm seed", "A kwuarm seed - plant in an herb patch. (54)", "seedKwuarm", Color.Olive, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyKwuarm",
                    UseInt = 54 /* Level */,  UseInt2 = 120 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy kwuarm", "It needs cleaning.", "herbGrimyKwuarm", ColorLib.Kwuarm.GetDark(), 48) { UseString = "CleanHerb", ItemReturned = "herbCleanKwuarm", UseInt = 54, UseInt2 = 11 }); 
                itemsToAdd.Add(new Item("Kwuarm", "A fresh herb.", "herbCleanKwuarm", ColorLib.Kwuarm, 48));

                // Bloodweed
                itemsToAdd.Add(new Item("Bloodweed seed", "A bloodweed seed - plant in an herb patch. (57)", "seedBloodweed", Color.Crimson, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyBloodweed",
                    UseInt = 57 /* Level */,  UseInt2 = 130 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy bloodweed", "It needs cleaning.", "herbGrimyBloodweed", ColorLib.Bloodweed.GetDark(), 100) { UseString = "CleanHerb", ItemReturned = "herbCleanBloodweed", UseInt = 57, UseInt2 = 12 }); 
                itemsToAdd.Add(new Item("Bloodweed", "A fresh herb.", "herbCleanBloodweed", ColorLib.Bloodweed, 100));

                // Snapdragon
                itemsToAdd.Add(new Item("Snapdragon seed", "A snapdragon seed - plant in an herb patch. (59)", "seedSnapdragon", Color.Orange, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimySnapdragon",
                    UseInt = 59 /* Level */,  UseInt2 = 150 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy snapdragon", "It needs cleaning.", "herbGrimySnapdragon", ColorLib.Snapdragon.GetDark(), 60) { UseString = "CleanHerb", ItemReturned = "herbCleanSnapdragon", UseInt = 59, UseInt2 = 12 }); 
                itemsToAdd.Add(new Item("Snapdragon", "A fresh herb.", "herbCleanSnapdragon", ColorLib.Snapdragon, 60));

                // Cadantine
                itemsToAdd.Add(new Item("Cadantine seed", "A cadantine seed - plant in an herb patch. (65)", "seedCadantine", Color.YellowGreen, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyCadantine",
                    UseInt = 65 /* Level */,  UseInt2 = 180 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy cadantine", "It needs cleaning.", "herbGrimyCadantine", ColorLib.Cadantine.GetDark(), 65) { UseString = "CleanHerb", ItemReturned = "herbCleanCadantine", UseInt = 65, UseInt2 = 13 }); 
                itemsToAdd.Add(new Item("Cadantine", "A fresh herb.", "herbCleanCadantine", ColorLib.Cadantine, 65));

                // Lantadyme
                itemsToAdd.Add(new Item("Lantadyme seed", "A lantadyme seed - plant in an herb patch. (67)", "seedLantadyme", Color.Teal, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyLantadyme",
                    UseInt = 67 /* Level */,  UseInt2 = 220 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy lantadyme", "It needs cleaning.", "herbGrimyLantadyme", ColorLib.Lantadyme.GetDark(), 70) { UseString = "CleanHerb", ItemReturned = "herbCleanLantadyme", UseInt = 67, UseInt2 = 13 }); 
                itemsToAdd.Add(new Item("Lantadyme", "A fresh herb.", "herbCleanLantadyme", ColorLib.Lantadyme, 70));

                // Dwarf weed
                itemsToAdd.Add(new Item("Dwarf weed seed", "A dwarf weed seed - plant in an herb patch. (70)", "seedDwarfweed", Color.ForestGreen, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyDwarfweed",
                    UseInt = 70 /* Level */,  UseInt2 = 220 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy dwarf weed", "It needs cleaning.", "herbGrimyDwarfweed", ColorLib.Dwarfweed.GetDark(), 100) { UseString = "CleanHerb", ItemReturned = "herbCleanDwarfweed", UseInt = 70, UseInt2 = 14 }); 
                itemsToAdd.Add(new Item("Dwarf weed", "A fresh herb.", "herbCleanDwarfweed", ColorLib.Dwarfweed, 150));

                // Torstol
                itemsToAdd.Add(new Item("Torstol seed", "A torstol seed - plant in an herb patch. (75)", "seedTorstol", Color.DarkGreen, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyTorstol",
                    UseInt = 75 /* Level */,  UseInt2 = 270 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy torstol", "It needs cleaning.", "herbGrimyTorstol", ColorLib.Torstol.GetDark(), 75) { UseString = "CleanHerb", ItemReturned = "herbCleanTorstol", UseInt = 75, UseInt2 = 15 }); 
                itemsToAdd.Add(new Item("Torstol", "A fresh herb.", "herbCleanTorstol", ColorLib.Torstol, 75));

                // Arbuck
                itemsToAdd.Add(new Item("Arbuck seed", "An arbuck seed - plant in an herb patch. (77)", "seedArbuck", Color.Orange, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyArbuck",
                    UseInt = 77 /* Level */,  UseInt2 = 350 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy arbuck", "It needs cleaning.", "herbGrimyArbuck", ColorLib.Arbuck.GetDark(), 100) { UseString = "CleanHerb", ItemReturned = "herbCleanArbuck", UseInt = 77, UseInt2 = 14 }); 
                itemsToAdd.Add(new Item("Arbuck", "A fresh herb.", "herbCleanArbuck", ColorLib.Arbuck, 150));

                // Fellstalk
                itemsToAdd.Add(new Item("Fellstalk seed", "A fellstalk seed - plant in an herb patch. (91)", "seedFellstalk", Color.AntiqueWhite, 64, true) {
                    UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyFellstalk",
                    UseInt = 91 /* Level */,  UseInt2 = 500 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grimy fellstalk", "It needs cleaning.", "herbGrimyFellstalk", ColorLib.Fellstalk.GetDark(), 100) { UseString = "CleanHerb", ItemReturned = "herbCleanFellstalk", UseInt = 91, UseInt2 = 17 }); 
                itemsToAdd.Add(new Item("Fellstalk", "A fresh herb.", "herbCleanFellstalk", ColorLib.Fellstalk, 150));
            }

            // // Farming - Hops
            {
                // Barley
                itemsToAdd.Add(new Item("Barley seed", "A barley seed - plant in a hops patch. (3)", "seedBarley", Color.Wheat, 15, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "hopsBarley",
                    UseInt = 3 /* Level */,  UseInt2 = 18 /* Exp On Harvest */, UseInt3 = 2400 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Barley", "A handful of barley.", "hopsBarley", Color.Wheat, 5));

                // Hammerstone
                itemsToAdd.Add(new Item("Hammerstone seed", "A hammerstone hops seed - plant in a hops patch. (4)", "seedHammerstone", Color.DarkOliveGreen, 20, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "hopsHammerstone",
                    UseInt = 4 /* Level */,  UseInt2 = 20 /* Exp On Harvest */, UseInt3 = 2400 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Hammerstone hops", "A handful of Hammerstone hops.", "hopsHammerstone", Color.DarkOliveGreen, 8));

                // Asgarnian
                itemsToAdd.Add(new Item("Asgarnian seed", "An asgarnian hops seed - plant in a hops patch. (8)", "seedAsgarnian", Color.DarkOliveGreen, 30, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "hopsAsgarnian",
                    UseInt = 8 /* Level */,  UseInt2 = 24 /* Exp On Harvest */, UseInt3 = 2400 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Asgarnian hops", "A handful of Asgarnian hops.", "hopsAsgarnian", Color.DarkOliveGreen, 10));

                // Wendlewick
                itemsToAdd.Add(new Item("Wendlewick seed", "A wendlewick hops seed - plant in a hops patch. (11)", "seedWendlewick", Color.ForestGreen, 40, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "hopsWendlewick",
                    UseInt = 11 /* Level */,  UseInt2 = 26 /* Exp On Harvest */, UseInt3 = 3000 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Wendlewick hops", "A handful of Wendlewick hops.", "hopsWendlewick", Color.ForestGreen, 15));

                // Jute
                itemsToAdd.Add(new Item("Jute seed", "A jute plant seed - plant in a hops patch. (13)", "seedJute", Color.SandyBrown, 40, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "jute",
                    UseInt = 13 /* Level */,  UseInt2 = 28 /* Exp On Harvest */, UseInt3 = 3000 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Jute fiber", "I can weave this to make sacks.", "jute", Color.SandyBrown, 15));
                 
                // Yanillian
                itemsToAdd.Add(new Item("Yanillian seed", "A yanillian hops seed - plant in a hops patch. (16)", "seedYanillian", Color.Goldenrod, 50, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "hopsYanillian",
                    UseInt = 16 /* Level */,  UseInt2 = 31 /* Exp On Harvest */, UseInt3 = 3600 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Yanillian hops", "A handful of Yanillian hops.", "hopsYanillian", Color.Goldenrod, 20));

                // Krandorian
                itemsToAdd.Add(new Item("Krandorian seed", "A yanillian hops seed - plant in a hops patch. (21)", "seedKrandorian", Color.SandyBrown, 60, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "hopsKrandorian",
                    UseInt = 21 /* Level */,  UseInt2 = 37 /* Exp On Harvest */, UseInt3 = 4200 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Krandorian hops", "A handful of Krandorian hops.", "hopsKrandorian", Color.SandyBrown, 25));

                // Wildblood
                itemsToAdd.Add(new Item("Wildblood seed", "A wildblood hops seed - plant in a hops patch. (28)", "seedWildblood", Color.IndianRed, 70, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "hopsWildblood",
                    UseInt = 28 /* Level */,  UseInt2 = 49 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Wildblood hops", "A handful of Wildblood hops.", "hopsWildblood", Color.IndianRed, 30));

                // Grapevine
                itemsToAdd.Add(new Item("Grapevine seed", "A grapevine seed - plant in a hops patch. (49)", "seedGrapevine", Color.DimGray, 100, true) {
                    UseString = "PlantSeed", UseString2 = "Hops", UseString3 = "grapes",
                    UseInt = 49 /* Level */,  UseInt2 = 92 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Grapes", "Good grapes for winemaking.", "grapes", Color.Purple, 40));
            }

            // // Farming - Bush
            {
                // Redberry
                itemsToAdd.Add(new Item("Redberry seed", "A redberry bush seed - plant in a bush patch. (10)", "seedRedberry", Color.PaleVioletRed, 5, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "redberry",
                    UseInt = 10 /* Level */,  UseInt2 = 15 /* Exp On Harvest */, UseInt3 = 6000 /* Growth time in seconds */, UseInt4 = 1200 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Redberries", "Very bright red berries.", "redberry", Color.Red, 3));

                // Cadava
                itemsToAdd.Add(new Item("Cadava seed", "A cadavaberry bush seed - plant in a bush patch. (22)", "seedCadava", Color.MediumPurple, 9, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "redberry",
                    UseInt = 22 /* Level */,  UseInt2 = 40 /* Exp On Harvest */, UseInt3 = 7200 /* Growth time in seconds */, UseInt4 = 1200 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Cadava berries", "Poisonous berries.", "cadava", Color.Magenta, 2));

                // Dwellberry
                itemsToAdd.Add(new Item("Dwellberry seed", "A dwellberry bush seed - plant in a bush patch. (36)", "seedDwellberry", ColorLib.Magic, 25, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "dwellberry",
                    UseInt = 36 /* Level */,  UseInt2 = 60 /* Exp On Harvest */, UseInt3 = 7800 /* Growth time in seconds */, UseInt4 = 1200 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Dwellberries", "Some rather pretty blue berries picked from a dwellberry bush.", "dwellberry", ColorLib.Mithril, 8));

                // Jangerberry
                itemsToAdd.Add(new Item("Jangerberry seed", "A jangerberry bush seed - plant in a bush patch. (48)", "seedJangerberry", Color.Olive, 40, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "jangerberry",
                    UseInt = 48 /* Level */,  UseInt2 = 90 /* Exp On Harvest */, UseInt3 = 9600 /* Growth time in seconds */, UseInt4 = 1200 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Jangerberries", "They don't look very ripe.", "jangerberry", Color.Olive, 5));

                // Whiteberry
                itemsToAdd.Add(new Item("Whiteberry seed", "A whiteberry bush seed - plant in a bush patch. (59)", "seedWhiteberry", Color.White, 80, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "whiteberry",
                    UseInt = 59 /* Level */,  UseInt2 = 120 /* Exp On Harvest */, UseInt3 = 9600 /* Growth time in seconds */, UseInt4 = 1200 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Whiteberries", "Sour berries, used in potions.", "whiteberry", Color.White, 20));

                // Poison ivy
                itemsToAdd.Add(new Item("Poison ivy seed", "A poison ivy bush seed - plant in a bush patch. (70)", "seedPoisonIvy", Color.White, 200, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "poisonivy",
                    UseInt = 70 /* Level */,  UseInt2 = 200 /* Exp On Harvest */, UseInt3 = 9600 /* Growth time in seconds */, UseInt4 = 1200 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Poison ivy berries", "They look sweet and juicy, but only a fool would eat them.", "poisonivy", Color.AntiqueWhite, 65));

                // Barberry
                itemsToAdd.Add(new Item("Barberry seed", "A barberry bush seed - plant in a bush patch. (77)", "seedBarberry", Color.Crimson, 280, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "_Agility",
                    UseInt = 77 /* Level */,  UseInt2 = 300 /* Exp On Harvest */, UseInt3 = 12000 /* Growth time in seconds */
                });

                // Avocado
                itemsToAdd.Add(new Item("Avocado seed", "An avocado seed - plant in a bush patch. (99)", "seedAvocado", Color.SaddleBrown, 500, true) {
                    UseString = "PlantSeed", UseString2 = "Bush", UseString3 = "avocado",
                    UseInt = 99 /* Level */,  UseInt2 = 700 /* Exp On Harvest */, UseInt3 = 24000 /* Growth time in seconds */, UseInt4 = 4800 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Avocado", "A tasty fruit grown from a primal bush. Free shavoca do.", "avocado", Color.SaddleBrown, 1400));
            }

            // // Farming - Special
            {
                // Belladonna / Nightshade
                itemsToAdd.Add(new Item("Belladonna seed", "A belladonna seed - plant in a belladonna patch. (63)", "seedBelladonna", Color.MediumPurple, 177, true) {
                    UseString = "PlantSeed", UseString2 = "Belladonna", UseString3 = "nightshade",
                    UseInt = 63 /* Level */,  UseInt2 = 400 /* Exp On Harvest */, UseInt3 = 320 /* Growth time in seconds */ 
                });
                itemsToAdd.Add(new Item("Nightshade", "Deadly but compact.", "nightshade", Color.MediumPurple, 30));
            }
            
            itemsToAdd.Add(new Item("Plant pot", "A plant pot filled with soil.", "plantPot", 207, 185, 151, 1));
            // // Farming - Trees
            {
                // Pine
                itemsToAdd.Add(new Item("Pinecone", "A pine seed - use on a plant pot to make a sapling.", "seedTreePine", ColorLib.Pine, 25, true));
                itemsToAdd.Add(new Item("Plant pot (pine)", "A pine sapling in a pot. Plant in a tree patch.", "plantPotPine", ColorLib.Pine, 25) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logPine",
                    UseInt = 1 /* Level */,  UseInt2 = 100 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Oak
                itemsToAdd.Add(new Item("Acorn", "An oak seed - use on a plant pot to make a sapling. (10)", "seedTreeOak", ColorLib.Oak, 50, true));
                itemsToAdd.Add(new Item("Plant pot (oak)", "An oak sapling in a pot. Plant in a tree patch. (10)", "plantPotOak", ColorLib.Oak, 50) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logOak",
                    UseInt = 10 /* Level */,  UseInt2 = 200 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Willow
                itemsToAdd.Add(new Item("Willow seed", "A willow seed - use on a plant pot to make a sapling. (20)", "seedTreeWillow", ColorLib.Willow, 75, true));
                itemsToAdd.Add(new Item("Plant pot (willow)", "A willow sapling in a pot. Plant in a tree patch. (20)", "plantPotWillow", ColorLib.Willow, 75) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logWillow",
                    UseInt = 20 /* Level */,  UseInt2 = 300 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Teak
                itemsToAdd.Add(new Item("Teak seed", "A teak seed - use on a plant pot to make a sapling. (30)", "seedTreeTeak", ColorLib.Teak, 100, true));
                itemsToAdd.Add(new Item("Plant pot (teak)", "A teak sapling in a pot. Plant in a tree patch. (30)", "plantPotTeak", ColorLib.Teak, 100) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logTeak",
                    UseInt = 30 /* Level */,  UseInt2 = 400 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Maple
                itemsToAdd.Add(new Item("Maple seed", "A maple seed - use on a plant pot to make a sapling. (40)", "seedTreeMaple", ColorLib.Maple, 125, true));
                itemsToAdd.Add(new Item("Plant pot (maple)", "A maple sapling in a pot. Plant in a tree patch. (40)", "plantPotMaple", ColorLib.Maple, 125) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logMaple",
                    UseInt = 40 /* Level */,  UseInt2 = 500 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Acadia
                itemsToAdd.Add(new Item("Acadia seed", "An acadia seed - use on a plant pot to make a sapling. (50)", "seedTreeAcadia", ColorLib.Acadia, 150, true));
                itemsToAdd.Add(new Item("Plant pot (acadia)", "An acadia sapling in a pot. Plant in a tree patch. (50)", "plantPotAcadia", ColorLib.Acadia, 150) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logAcadia",
                    UseInt = 50 /* Level */,  UseInt2 = 600 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Mahogany
                itemsToAdd.Add(new Item("Mahogany seed", "A mahogany seed - use on a plant pot to make a sapling. (60)", "seedTreeMahogany", ColorLib.Mahogany, 175, true));
                itemsToAdd.Add(new Item("Plant pot (mahogany)", "A mahogany sapling in a pot. Plant in a tree patch. (60)", "plantPotMahogany", ColorLib.Mahogany, 175) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logMahogany",
                    UseInt = 60 /* Level */,  UseInt2 = 700 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Yew
                itemsToAdd.Add(new Item("Yew seed", "A yew seed - use on a plant pot to make a sapling. (70)", "seedTreeYew", ColorLib.Yew, 200, true));
                itemsToAdd.Add(new Item("Plant pot (yew)", "A yew sapling in a pot. Plant in a tree patch. (70)", "plantPotYew", ColorLib.Yew, 200) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logYew",
                    UseInt = 70 /* Level */,  UseInt2 = 800 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Magic
                itemsToAdd.Add(new Item("Magic seed", "A magic seed - use on a plant pot to make a sapling. (80)", "seedTreeMagic", ColorLib.Magic, 300, true));
                itemsToAdd.Add(new Item("Plant pot (magic)", "A magic sapling in a pot. Plant in a tree patch. (80)", "plantPotMagic", ColorLib.Magic, 300) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logMagic",
                    UseInt = 80 /* Level */,  UseInt2 = 900 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });

                // Elder
                itemsToAdd.Add(new Item("Elder seed", "An elder seed - use on a plant pot to make a sapling. (90)", "seedTreeElder", ColorLib.Elder, 500, true));
                itemsToAdd.Add(new Item("Plant pot (elder)", "An elder sapling in a pot. Plant in a tree patch. (90)", "plantPotElder", ColorLib.Elder, 500) {
                    UseString = "PlantSeed", UseString2 = "Tree", UseString3 = "logElder",
                    UseInt = 90 /* Level */,  UseInt2 = 1000 /* Exp On Harvest */, UseInt3 = 960 /* Growth time in seconds */, UseInt4 = 960 /* Regrowth time in seconds */
                });
            }

            // // Farming - Fruit Trees
            {  
                // Apple Tree
                itemsToAdd.Add(new Item("Apple tree seed", "An apple tree seed - use on a plant pot to make a sapling. (27)", "seedTreeApple", ColorLib.Willow, 20, true));
                itemsToAdd.Add(new Item("Plant pot (apple)", "An apple tree sapling in a pot. Plant in a fruit tree patch. (27)", "plantPotApple", ColorLib.Willow, 20) {
                    UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitApple",
                    UseInt = 27 /* Level */,  UseInt2 = 500 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Apple", "Keeps the doctor away.", "fruitApple", Color.Lime, 36));

                // Banana Tree
                itemsToAdd.Add(new Item("Banana tree seed", "A banana tree seed - use on a plant pot to make a sapling. (33)", "seedTreeBanana", Color.AntiqueWhite, 30, true));
                itemsToAdd.Add(new Item("Plant pot (banana)", "A banana tree sapling in a pot. Plant in a fruit tree patch. (33)", "plantPotBanana", Color.AntiqueWhite, 30) {
                    UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitBanana",
                    UseInt = 33 /* Level */,  UseInt2 = 550 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Banana", "Mmm banana.", "fruitBanana", Color.Yellow, 10) { UseString = "Heal", UseInt = 2 });
                itemsToAdd.Add(new Item("Sliced banana", "You swear you had more than three slices before.", "fruitBananaSlices", Color.Yellow, 10) { UseString = "Heal", UseInt = 2 });
                itemsToAdd.Add(new Item("Peach", "A tasty fruit.", "fruitPeach", Color.Yellow, 10) { UseString = "Heal", UseInt = 8 });

                // Orange Tree
                itemsToAdd.Add(new Item("Orange tree seed", "An orange tree seed - use on a plant pot to make a sapling. (39)", "seedTreeOrange", Color.AntiqueWhite, 30, true));
                itemsToAdd.Add(new Item("Plant pot (orange)", "An orange tree sapling in a pot. Plant in a fruit tree patch. (39)", "plantPotOrange", Color.AntiqueWhite, 30) {
                    UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitOrange",
                    UseInt = 39 /* Level */,  UseInt2 = 600 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Orange", "A common fruit.", "fruitOrange", Color.MonoGameOrange, 70) { UseString = "Heal", UseInt = 2 });
                itemsToAdd.Add(new Item("Orange slices", "Fresh orange slices.", "fruitOrangeSlices", Color.MonoGameOrange, 70) { UseString = "Heal", UseInt = 2 });
                itemsToAdd.Add(new Item("Orange chunks", "Fresh chunks of orange.", "fruitOrangeChunks", Color.MonoGameOrange, 70) { UseString = "Heal", UseInt = 2 });

                // Curry Tree
                itemsToAdd.Add(new Item("Curry tree seed", "A curry tree seed - use on a plant pot to make a sapling. (42)", "seedTreeCurry", Color.Orange, 40, true));
                itemsToAdd.Add(new Item("Plant pot (curry)", "A curry tree sapling in a pot. Plant in a fruit tree patch. (42)", "plantPotCurry", Color.Orange, 40) {
                    UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "curryLeaf",
                    UseInt = 42 /* Level */,  UseInt2 = 650 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Curry leaf", "I could make a spicy curry with this.", "curryLeaf", Color.SandyBrown, 20));

                // Pineapple
                itemsToAdd.Add(new Item("Pineapple seed", "A pineapple seed - use on a plant pot to make a sapling. (51)", "seedTreePineapple", Color.SaddleBrown, 75, true));
                itemsToAdd.Add(new Item("Plant pot (pineapple)", "A pineapple seedling in a pot. Plant in a fruit tree patch. (51)", "plantPotPineapple", Color.SaddleBrown, 75) {
                    UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitPineapple",
                    UseInt = 51 /* Level */,  UseInt2 = 700 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Pineapple", "It can be cut up into something more manageable with a knife.", "fruitPineapple", Color.Yellow, 20));
                itemsToAdd.Add(new Item("Pineapple chunks", "Fresh chunks of pineapple.", "fruitPineappleChunks", Color.Yellow, 5) { UseString = "Heal", UseInt = 2 });
                itemsToAdd.Add(new Item("Pineapple ring", "Exotic fruit.", "fruitPineappleRing", Color.Yellow, 5) { UseString = "Heal", UseInt = 2 });

                // Papaya Tree
                itemsToAdd.Add(new Item("Papaya tree seed", "A papaya tree seed - use on a plant pot to make a sapling. (57)", "seedTreePapaya", Color.DimGray, 120, true));
                itemsToAdd.Add(new Item("Plant pot (papaya)", "A papaya tree sapling in a pot. Plant in a fruit tree patch. (57)", "plantPotPapaya", Color.DimGray, 120) {
                    UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitPapaya",
                    UseInt = 57 /* Level */,  UseInt2 = 750 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Papaya", "Papaya, papaya, pa-paya-paya!", "fruitPapaya", Color.YellowGreen, 64) { UseString = "Heal", UseInt = 8 });

                // Palm Tree
                itemsToAdd.Add(new Item("Palm tree seed", "A palm tree seed - use on a plant pot to make a sapling. (68)", "seedTreePalm", Color.Wheat, 250, true));
                itemsToAdd.Add(new Item("Plant pot (coconut)", "A palm tree sapling in a pot. Plant in a fruit tree patch. (68)", "plantPotPalm", Color.Wheat, 250) {
                    UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitCoconut",
                    UseInt = 68 /* Level */,  UseInt2 = 800 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Coconut", "It's a coconut.", "fruitCoconut", Color.SaddleBrown, 90));
                itemsToAdd.Add(new Item("Half coconut", "It's a coconut.", "fruitCoconutHalf", Color.SaddleBrown, 90));
                itemsToAdd.Add(new Item("Coconut milk", "A vial filled with coconut milk.", "fruitCoconutMilk", Color.White, 90));
                itemsToAdd.Add(new Item("Coconut shell", "All the milk has been removed.", "fruitCoconutShell", Color.SaddleBrown, 90));
            }

            // // Farming - Cactus
            {
                // Cactus 
                itemsToAdd.Add(new Item("Cactus seed", "A cactus seed. Plant in a cactus patch. (55)", "seedCactus", Color.SpringGreen, 100, true) {
                    UseString = "PlantSeed", UseString2 = "Cactus", UseString3 = "cactusSpine",
                    UseInt = 55 /* Level */,  UseInt2 = 100 /* Exp On Harvest */, UseInt3 = 33600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Cactus spine", "Don't prick yourself with this.", "cactusSpine", Color.SandyBrown, 30));

                // Prickly pear 
                itemsToAdd.Add(new Item("Prickly pear seed", "A prickly pear seed. Plant in a cactus patch. Grants defense experience. (76)", "seedPricklyPear", Color.Olive, 150, true) {
                    UseString = "PlantSeed", UseString2 = "Cactus", UseString3 = "_Defense",
                    UseInt = 76 /* Level */,  UseInt2 = 450 /* Exp On Harvest */, UseInt3 = 33600 /* Growth time in seconds */
                });

                // Potato cactus seed 
                itemsToAdd.Add(new Item("Potato cactus seed", "A potato cactus seed. Plant in a cactus patch. (76)", "seedPotatoCactus", Color.SandyBrown, 300, true) {
                    UseString = "PlantSeed", UseString2 = "Cactus", UseString3 = "cactusPotato",
                    UseInt = 76 /* Level */,  UseInt2 = 500 /* Exp On Harvest */, UseInt3 = 33600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Potato cactus", "How am I supposed to eat that?", "cactusPotato", Color.ForestGreen, 100));

                // Dragonfruit seed 
                itemsToAdd.Add(new Item("Dragonfruit seed", "A dragonfruit seed. Plant in a cactus patch. (95)", "seedDragonfruit", Color.Crimson.GetDark(), 500, true) {
                    UseString = "PlantSeed", UseString2 = "Cactus", UseString3 = "fruitDragonfruit",
                    UseInt = 95 /* Level */,  UseInt2 = 1100 /* Exp On Harvest */, UseInt3 = 33600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                });
                itemsToAdd.Add(new Item("Dragonfruit", "A tasty fruit grown from a primal cactus.", "fruitDragonfruit", Color.Crimson.GetDark(), 1400));
            }

            // // Farming - Mushroom
            {
                // Bittercap seed 
                itemsToAdd.Add(new Item("Bittercap mushroom spore", "A bittercap mushroom spore. Plant in a mushroom patch. (53)", "seedBittercap", Color.AntiqueWhite, 85, true) {
                    UseString = "PlantSeed", UseString2 = "Mushroom", UseString3 = "bittercap",
                    UseInt = 53 /* Level */,  UseInt2 = 100 /* Exp On Harvest */, UseInt3 = 14400 /* Growth time in seconds */
                });
                itemsToAdd.Add(new Item("Bittercap mushroom", "A bittercap mushroom.", "bittercap", Color.AntiqueWhite, 40));

                // Morchella seed 
                itemsToAdd.Add(new Item("Morchella mushroom spore", "A morchella mushroom spore. Plant in a mushroom patch. (74)", "seedMorchella", Color.AntiqueWhite, 85, true) {
                    UseString = "PlantSeed", UseString2 = "Mushroom", UseString3 = "morchella",
                    UseInt = 74 /* Level */,  UseInt2 = 230 /* Exp On Harvest */, UseInt3 = 14400 /* Growth time in seconds */
                });
                itemsToAdd.Add(new Item("Morchella mushroom", "They have miraculous properties.", "morchella", Color.SaddleBrown, 100));
            } 


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
