using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsCooking {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();

            itemsToAdd.Add(new Item("Burnt meat", "Oh dear, it's totally burnt!", "burntMeat", Color.DimGray, 1));
            itemsToAdd.Add(new Item("Burnt food", "Completely inedible now, whatever it was supposed to be.", "burntFood", Color.DimGray, 1));
            itemsToAdd.Add(new Item("Burnt food bowl", "Completely inedible now, whatever it was. At least the bowl is salvageable.", "burntBowl", Color.DimGray, 1) { UseString = "Transform", UseString2 = "bowlEmpty" });
            itemsToAdd.Add(new Item("Burnt pie", "Completely inedible now, whatever it was. At least the dish is salvageable.", "burntPie", Color.DimGray, 1) { UseString = "Transform", UseString2 = "pieEmpty" });
            
            itemsToAdd.Add(new Item("Baked potato", "It'd taste even better with some toppings.", "potatoBaked", Color.SaddleBrown, 5) { UseString = "Heal", UseInt = 4 });
            itemsToAdd.Add(new Item("Cooked sweetcorn", "A nice cob of cooked sweetcorn.", "sweetcornCooked", Color.Goldenrod, 9) { UseString = "Heal", UseInt = 2 }); 
            itemsToAdd.Add(new Item("Golovanova fruit top", "The top of a Golovanova fruit - edible once cooked and full of Vitamin G.", "fruitGolovanovaTop", Color.ForestGreen, 3));
            itemsToAdd.Add(new Item("Sulliuscep cap", "A Sulliuscep mushroom cap. Edible? Probably...", "sulliuscepCap", Color.Crimson, 3));
            
            itemsToAdd.Add(new Item("Raw newt meat", "A cut of meat taken from a newt.", "meatRawNewt", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Raw beef", "A cut of meat taken from a cow.", "meatRawBeef", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Raw rat meat", "A cut of meat taken from a rat.", "meatRawRat", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Raw bear meat", "A cut of meat taken from a rat.", "meatRawBear", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Raw chicken", "A whole chicken, currently very inedible.", "meatRawChicken", 242, 209, 209, 1));
            itemsToAdd.Add(new Item("Raw rabbit", "Might taste better cooked.", "meatRawRabbit", 242, 209, 209, 20));
            itemsToAdd.Add(new Item("Raw chompy", "I need to cook this first.", "meatRawChompy", Color.GreenYellow, 85));
            itemsToAdd.Add(new Item("Raw bird meat", "This certainly needs cooking!", "meatRawBird", 242, 209, 209, 15));
            itemsToAdd.Add(new Item("Raw shrimps", "A few raw shrimp.", "fishRawShrimp", 138, 3, 3, 5)); 
            itemsToAdd.Add(new Item("Raw anchovies", "A few raw anchovies.", "fishRawAnchovies", 173, 216, 230, 15)); 
            itemsToAdd.Add(new Item("Raw sardine", "I should try cooking this.", "fishRawSardine", 50, 205, 50, 10)); 
            itemsToAdd.Add(new Item("Raw herring", "I should try cooking this.", "fishRawHerring", 255, 255, 255, 10)); 
            itemsToAdd.Add(new Item("Raw pike", "I should try cooking this.", "fishRawPike", 50, 205, 50, 20));
            itemsToAdd.Add(new Item("Raw trout", "I should try cooking this.", "fishRawTrout", 255, 255, 255, 10));
            itemsToAdd.Add(new Item("Raw salmon", "I should try cooking this.", "fishRawSalmon", 255, 20, 147, 30)); 
            itemsToAdd.Add(new Item("Raw lobster", "I should try cooking this.", "fishRawLobster", 255, 140, 0, 70));
            itemsToAdd.Add(new Item("Raw tuna", "I should try cooking this.", "fishRawTuna", 255, 255, 255, 40));
            itemsToAdd.Add(new Item("Raw swordfish", "I should try cooking this.", "fishRawSwordfish", 147, 112, 219, 80));
            itemsToAdd.Add(new Item("Raw bass", "I should try cooking this.", "fishRawBass", 255, 20, 147, 40));
            itemsToAdd.Add(new Item("Raw cod", "I should try cooking this.", "fishRawCod", 173, 216, 230, 10));
            itemsToAdd.Add(new Item("Raw mackerel", "I should try cooking this.", "fishRawMackerel", 255, 255, 0, 15));
            itemsToAdd.Add(new Item("Raw slimy eel", "I should try cooking this.", "fishRawEelSlimy", 173, 216, 230, 10));
            itemsToAdd.Add(new Item("Raw cave eel", "I should try cooking this.", "fishRawEelCave", 255, 255, 0, 15));
             
            itemsToAdd.Add(new Item("Cooked meat", "A cooked cut of meat.", "meatCookedBeef", 150, 100, 50, 4) { UseString = "Heal", UseInt = 3 }); 
            itemsToAdd.Add(new Item("Cooked shrimps", "Some cooked shrimp.", "fishCookedShrimp", 150, 100, 50, 5) { UseString = "Heal", UseInt = 3 }); 
            itemsToAdd.Add(new Item("Cooked chicken", "A cooked chicken.", "meatCookedChicken", 150, 100, 50, 4) { UseString = "Heal", UseInt = 3 });
            itemsToAdd.Add(new Item("Cooked rabbit", "Mmm this looks tasty.", "meatCookedRabbit", 150, 100, 50, 4) { UseString = "Heal", UseInt = 5 });
            itemsToAdd.Add(new Item("Cooked anchovies", "Some cooked anchovies.", "fishCookedAnchovies", 143, 186, 200, 15) { UseString = "Heal", UseInt = 1 }); 
            itemsToAdd.Add(new Item("Cooked sardine", "Some nicely cooked sardines.", "fishCookedSardine", 30, 185, 30, 10) { UseString = "Heal", UseInt = 4 }); 
            itemsToAdd.Add(new Item("Poison karambwan", "Cooked octopus. It looks poorly cooked and quite dangerous.", "fishKarambwanPoison", Color.SeaGreen, 250) { UseString = "Hurt", UseInt = 5 });
            itemsToAdd.Add(new Item("Cooked ugthanki", "Freshly cooked ugthanki meat.", "meatCookedUgthanki", 150, 100, 50, 5) { UseString = "Heal", UseInt = 3 }); 
            itemsToAdd.Add(new Item("Cooked herring", "Some nicely cooked herring.", "fishCookedHerring", 178, 144, 144, 10) { UseString = "Heal", UseInt = 5 });
            itemsToAdd.Add(new Item("Cooked mackerel", "Some nicely cooked mackerel.", "fishCookedMackerel", 218, 165, 32, 15) { UseString = "Heal", UseInt = 6 }); 
            itemsToAdd.Add(new Item("Roast bird meat", "A nicely roasted bird.", "meatCookedBird", 150, 100, 50, 17) { UseString = "Heal", UseInt = 6 });  
            itemsToAdd.Add(new Item("Thin snail meat", "A succulently slime slice of sumptuous snail.", "meatCookedSnailThin", Color.Olive, 10) { UseString = "Heal", UseInt = 6 });
            itemsToAdd.Add(new Item("Cooked trout", "Some nicely cooked trout.", "fishCookedTrout", 178, 144, 144, 10) { UseString = "Heal", UseInt = 7 });
            itemsToAdd.Add(new Item("Lean snail meat", "A succulently slime slice of sumptuous snail.", "meatCookedSnailLean", Color.Orange, 20) { UseString = "Heal", UseInt = 7 });
            itemsToAdd.Add(new Item("Cooked cod", "Some nicely cooked cod.", "fishCookedCod", 143, 186, 200, 10) { UseString = "Heal", UseInt = 7 });    
            itemsToAdd.Add(new Item("Cooked pike", "Some nicely cooked pike.", "fishCookedPike", 30, 185, 30, 20) { UseString = "Heal", UseInt = 8 }); 
            itemsToAdd.Add(new Item("Fat snail meat", "A succulently slime slice of sumptuous snail.", "meatCookedSnailFat", Color.Orange, 30) { UseString = "Heal", UseInt = 8 });
            itemsToAdd.Add(new Item("Cooked salmon", "Some nicely cooked salmon.", "fishCookedSalmon", 255, 165, 0, 30) { UseString = "Heal", UseInt = 9 });
            itemsToAdd.Add(new Item("Cooked slimy eel", "A cooked slimy eel - not delicious, but pretty nutritious.", "fishCookedEelSlimy", 143, 186, 200, 10) { UseString = "Heal", UseInt = 8 });
            itemsToAdd.Add(new Item("Cooked tuna", "Wow, this is a big fish.", "fishCookedTuna", 178, 144, 144, 40) { UseString = "Heal", UseInt = 10 });
            itemsToAdd.Add(new Item("Cooked karambwan", "Cooked octopus. It looks very nutritious.", "fishKarambwanCooked", Color.White, 250) { UseString = "Heal", UseInt = 18 }); 
            itemsToAdd.Add(new Item("Cooked cave eel", "It's a bit slimy.", "fishCookedEelCave", 218, 165, 32, 15) { UseString = "Heal", UseInt = 10 }); 
            itemsToAdd.Add(new Item("Cooked lobster", "This looks tricky to eat.", "fishCookedLobster", 255, 165, 0, 70) { UseString = "Heal", UseInt = 12 });
            itemsToAdd.Add(new Item("Cooked swordfish", "I'd better be careful eating this!", "fishCookedSwordfish", 117, 82, 189, 80) { UseString = "Heal", UseInt = 14 });
            itemsToAdd.Add(new Item("Cooked bass", "Wow, this is a big fish.", "fishCookedBass", 255, 165, 0, 40) { UseString = "Heal", UseInt = 13 });  
             
            itemsToAdd.Add(new Item("Spinach roll", "A home made spinach thing.", "rollSpinach", Color.SpringGreen, 5) { UseString = "Heal", UseInt = 2 });
            itemsToAdd.Add(new Item("Frog spawn", "That's disgusting!", "frogSpawn", Color.SpringGreen, 5) { UseString = "Heal", UseInt = 4 });
            itemsToAdd.Add(new Item("Giant frog legs", "This could feed a family of gnomes for a week!", "frogLegsGiant", Color.ForestGreen, 100) { UseString = "Heal", UseInt = 6 }); 
            
            itemsToAdd.Add(new Item("Pie shell", "I need to find a filling for this pie.", "pieShell", Color.SandyBrown, 4)); 
            itemsToAdd.Add(new Item("Uncooked berry pie", "This would be much more appetizing cooked.", "pieRedberryUncooked", Color.SandyBrown, 6)); 
            itemsToAdd.Add(new Item("Redberry pie", "Looks tasty.", "pieRedberry", Color.SandyBrown, 6) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Uncooked meat pie", "This would be much healthier cooked.", "pieMeatUncooked", Color.SandyBrown, 8)); 
            itemsToAdd.Add(new Item("Meat pie", "Not for vegetarians.", "pieMeat", Color.SandyBrown, 8) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 6) } }); 
            itemsToAdd.Add(new Item("Uncooked apple pie", "This would be much tastier cooked.", "pieAppleUncooked", Color.SandyBrown, 16)); 
            itemsToAdd.Add(new Item("Apple pie", "Mmm apple pie.", "pieApple", Color.SandyBrown, 16) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 7) } }); 
            itemsToAdd.Add(new Item("Part mud pie (compost)", "Still needs two more ingredients.", "pieMudCompost", Color.SaddleBrown, 27)); 
            itemsToAdd.Add(new Item("Part mud pie (water)", "Still needs one more ingredient.", "pieMudWater", Color.SaddleBrown, 27)); 
            itemsToAdd.Add(new Item("Uncooked mud pie", "This would be much more appetizing cooked.", "pieMudUncooked", Color.SaddleBrown, 27)); 
            itemsToAdd.Add(new Item("Mud pie", "Looks tasty.", "pieMud", Color.SaddleBrown, 54)); 
            itemsToAdd.Add(new Item("Part garden pie (tomato)", "Still needs two more ingredients.", "pieGardenTomato", Color.SandyBrown, 12)); 
            itemsToAdd.Add(new Item("Part garden pie (onion)", "Still needs one more ingredient.", "pieGardenOnion", Color.SandyBrown, 12)); 
            itemsToAdd.Add(new Item("Uncooked garden pie", "Needs cooking before I eat it.", "pieGardenUncooked", Color.SandyBrown, 12)); 
            itemsToAdd.Add(new Item("Garden pie", "What I wouldn't give for a good steak about now...", "pieGarden", Color.SandyBrown, 12) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 6), new("Farming", 3) } }); 
            itemsToAdd.Add(new Item("Part fish pie (trout)", "Still needs two more ingredients.", "pieFishTrout", Color.SandyBrown, 24)); 
            itemsToAdd.Add(new Item("Part fish pie (cod)", "Still needs one more ingredient.", "pieFishCod", Color.SandyBrown, 49)); 
            itemsToAdd.Add(new Item("Uncooked fish pie", "Raw fish is risky, better cook it.", "pieFishUncooked", Color.SandyBrown, 50)); 
            itemsToAdd.Add(new Item("Fish pie", "Bounty of the sea.", "pieFish", Color.SandyBrown, 50) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 6), new("Fishing", 3) } }); 
            itemsToAdd.Add(new Item("Uncooked botanical pie", "This would be much tastier cooked.", "pieBotanicalUncooked", Color.SandyBrown, 16)); 
            itemsToAdd.Add(new Item("Botanical pie", "Mmm botanical pie.", "pieBotanical", Color.SandyBrown, 15) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 7), new("Herblore", 4) } }); 
            itemsToAdd.Add(new Item("Uncooked mushroom pie", "This would be much tastier cooked.", "pieMushroomUncooked", Color.SandyBrown, 16)); 
            itemsToAdd.Add(new Item("Mushroom pie", "Mmm mushroom pie.", "pieMushroom", Color.SandyBrown, 16) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 8), new("Crafting", 4) } }); 
            itemsToAdd.Add(new Item("Part admiral pie (salmon)", "Still needs two more ingredients.", "pieAdmiralSalmon", Color.SandyBrown, 54)); 
            itemsToAdd.Add(new Item("Part admiral pie (tuna)", "Still needs one more ingredient.", "pieAdmiralTuna", Color.SandyBrown, 154)); 
            itemsToAdd.Add(new Item("Uncooked admiral pie", "This would taste a lot better cooked.", "pieAdmiralUncooked", Color.SandyBrown, 155)); 
            itemsToAdd.Add(new Item("Admiral pie", "Much tastier than a normal fish pie.", "pieAdmiral", Color.SandyBrown, 155) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 8), new("Fishing", 5) } }); 
            itemsToAdd.Add(new Item("Uncooked dragonfruit pie", "This would be much tastier cooked.", "pieDragonfruitUncooked", Color.SandyBrown, 40)); 
            itemsToAdd.Add(new Item("Dragonfruit pie", "Mmm dragonfruit pie.", "pieDragonfruit", Color.SandyBrown, 40) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 10), new("Fletching", 4) } }); 
            itemsToAdd.Add(new Item("Part wild pie (bear)", "Still needs two more ingredients.", "pieWildBear", Color.SandyBrown, 5)); 
            itemsToAdd.Add(new Item("Part wild pie (chompy)", "Still needs one more ingredient.", "pieWildChompy", Color.SandyBrown, 90)); 
            itemsToAdd.Add(new Item("Uncooked wild pie", "Good as it looks, I'd better cook it.", "pieWildUncooked", Color.SandyBrown, 91)); 
            itemsToAdd.Add(new Item("Wild pie", "A triumph of man over nature.", "pieWild", Color.SandyBrown, 91) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 11), new("Slayer", 5), new("Ranged", 4) } }); 
            itemsToAdd.Add(new Item("Part summer pie (bear)", "Still needs two more ingredients.", "pieSummerStrawberry", Color.SandyBrown, 21)); 
            itemsToAdd.Add(new Item("Part summer pie (chompy)", "Still needs one more ingredient.", "pieSummerWatermelon", Color.SandyBrown, 69)); 
            itemsToAdd.Add(new Item("Uncooked summer pie", "Fresh fruit may be good for you, but I should really cook this.", "pieSummerUncooked", Color.SandyBrown, 70)); 
            itemsToAdd.Add(new Item("Summer pie", "All the fruits of a very small forest.", "pieSummer", Color.SandyBrown, 70) { UseString = "Potion", UseInt4 = 2, ItemReturned = "pieEmpty", Potion = new() { new("Heal", 11), new("Agility", 5) } }); 
            
            itemsToAdd.Add(new Item("Incomplete pizza", "I need to add some cheese next.", "pizzaIncomplete", Color.Crimson, 25)); 
            itemsToAdd.Add(new Item("Uncooked pizza", "This needs cooking.", "pizzaUncooked", Color.Yellow, 25)); 
            itemsToAdd.Add(new Item("Plain pizza", "A cheese and tomato pizza.", "pizzaPlain", Color.Yellow, 70) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 7) } }); 
            itemsToAdd.Add(new Item("Meat pizza", "A pizza with bits of meat on it.", "pizzaMeat", Color.Yellow, 80) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 8) } }); 
            itemsToAdd.Add(new Item("Anchovy pizza", "A pizza with anchovies.", "pizzaAnchovy", Color.Yellow, 80) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 9) } }); 
            itemsToAdd.Add(new Item("Pineapple pizza", "A tropicana pizza.", "pizzaPineapple", Color.Yellow, 100) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 11) } }); 
            
            itemsToAdd.Add(new Item("Incomplete stew", "I need to add some potato too.", "stewIncompleteMeat", Color.SandyBrown, 4)); 
            itemsToAdd.Add(new Item("Incomplete stew", "I need to add some meat too.", "stewIncompletePotato", Color.SandyBrown, 4)); 
            itemsToAdd.Add(new Item("Uncooked stew", "I need to cook this.", "stewUncooked", Color.SandyBrown, 10)); 
            itemsToAdd.Add(new Item("Stew", "It's a meat and potato stew.", "stew", Color.SaddleBrown, 20) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 11) } }); 
            itemsToAdd.Add(new Item("Uncooked curry", "I need to cook this.", "curryUncooked", Color.SandyBrown, 10)); 
            itemsToAdd.Add(new Item("Curry", "It's a spicy hot curry.", "curry", Color.SaddleBrown, 20) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 19) } }); 
            
            itemsToAdd.Add(new Item("Chopped garlic", "A bowl of chopped garlic.", "bowlGarlic", Color.White, 7)); 
            itemsToAdd.Add(new Item("Spicy sauce", "A bowl of spicy sauce.", "sauceSpicy", Color.Crimson, 9) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 2) } }); 
            itemsToAdd.Add(new Item("Chili con carne", "A bowl of meat in chili con carne sauce.", "chiliConCarne", Color.Crimson, 9) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Gnome spice", "It's Aluft Gianne's secret mix of spices.", "spiceGnome", ColorLib.Iron, 2)); 
            
            itemsToAdd.Add(new Item("Potato with butter", "A baked potato with butter.", "potatoButter", 225, 147, 70, 8) { UseString = "Heal", UseInt = 14 });
            itemsToAdd.Add(new Item("Chili potato", "A baked potato with chili con carne.", "potatoChili", 225, 147, 70, 13) { UseString = "Heal", UseInt = 14 });
            itemsToAdd.Add(new Item("Potato with cheese", "A baked potato with butter and cheese.", "potatoCheese", 225, 147, 70, 8) { UseString = "Heal", UseInt = 16 });
            itemsToAdd.Add(new Item("Egg potato", "A baked potato with egg and tomato.", "potatoEgg", 225, 147, 70, 12) { UseString = "Heal", UseInt = 16 });
            itemsToAdd.Add(new Item("Mushroom potato", "A baked potato with mushroom and onions.", "potatoMushroom", 225, 147, 70, 45) { UseString = "Heal", UseInt = 20 });
            itemsToAdd.Add(new Item("Tuna potato", "A baked potato with tuna and sweetcorn.", "potatoTuna", 225, 147, 70, 113) { UseString = "Heal", UseInt = 22 });
            itemsToAdd.Add(new Item("Bowl of sweetcorn", "A bowl of cooked sweetcorn.", "bowlCorn", Color.SandyBrown, 113) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 2) } });
            itemsToAdd.Add(new Item("Chopped tuna", "A bowl of finely chopped tuna.", "bowlTuna", Color.SandyBrown, 113) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 10) } });
            itemsToAdd.Add(new Item("Tuna and corn", "A bowl of cooked tuna and sweetcorn.", "bowlTunaCorn", Color.SandyBrown, 113)  { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 13) } });
            
            itemsToAdd.Add(new Item("Chopped tomato", "A mixture of tomatoes in a bowl..", "bowlTomato", Color.White, 3) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 2) } }); 
            itemsToAdd.Add(new Item("Chopped onion", "A bowl of chopped onions.", "bowlOnions", Color.White, 3) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 1) } }); 
            itemsToAdd.Add(new Item("Ugthanki & tomato", "A mixture of chopped tomatoes and ugthanki meat in a bowl.", "bowlUgthankiTomato", Color.Crimson, 7));
            itemsToAdd.Add(new Item("Ugthanki & onion", "A mixture of chopped onion and ugthanki meat in a bowl.", "bowlUgthankiOnions", Color.Crimson, 7));  
            itemsToAdd.Add(new Item("Onion & tomato", "A mixture of chopped onions and tomatoes in a bowl.", "bowlOnionTomato", Color.White, 3) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Mushroom & onion", "A bowl of fried mushroom and onions.", "bowlMushroomOnion", Color.Beige, 45) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 11) } }); 
            itemsToAdd.Add(new Item("Kebab mix", "A mixture of chopped tomatoes, onions, and ugthanki meat in a bowl.", "bowlKebabMix", Color.White, 3)); 
            itemsToAdd.Add(new Item("Ugthanki kebab", "A fresh kebab made from ugthanki meat.", "kebabUgthanki", Color.White, 3) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 19) } }); 
            itemsToAdd.Add(new Item("Ugthanki kebab (bad)", "A strange smelling kebab made from ugthanki meat.", "kebabUgthankiBad", Color.White, 3) { UseString = "KebabBad" }); 
            itemsToAdd.Add(new Item("Fried onions", "A bowl of sliced, fried onions.", "onionsFried", Color.SaddleBrown, 7) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Sliced mushrooms", "A bowl of sliced bittercap mushrooms.", "bowlMushrooms", Color.White, 42)); 
            itemsToAdd.Add(new Item("Fried mushrooms", "A bowl of fried bittercap mushrooms.", "mushroomsFried", Color.SaddleBrown, 42) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Bowl of raw egg", "A bowl of raw eggs.", "bowlEggs", Color.Yellow, 8)); 
            itemsToAdd.Add(new Item("Scrambled egg", "A bowl of scrambled egg.", "eggsScrambled", Color.Goldenrod, 8) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Egg and tomato", "A bowl of scrambled eggs and tomato.", "eggsTomato", Color.Crimson, 12) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 8) } }); 
            itemsToAdd.Add(new Item("Nettles", "A handful of nettles.", "nettles", Color.ForestGreen, 3)); 
            itemsToAdd.Add(new Item("Nettle water", "A bowl of water with nettles in it.", "bowlNettleWater", Color.SeaGreen, 10)); 
            itemsToAdd.Add(new Item("Nettle tea", "It's a bowl of nettle tea.", "bowlNettleTea", Color.SeaGreen, 12) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Nettle tea (milky)", "It's a bowl of milky nettle tea.", "bowlNettleTeaMilky", Color.SeaGreen.GetBrighter(), 12) { UseString = "Potion", UseInt4 = 1, ItemReturned = "bowlEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Cup of nettle tea", "It's a cup of nettle tea.", "cupNettleTea", Color.White, 12) { UseString = "Potion", UseInt4 = 1, ItemReturned = "cupEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Cup of nettle tea (milky)", "It's a cup of milky nettle tea.", "cupNettleTeaMilky", Color.White, 12) { UseString = "Potion", UseInt4 = 1, ItemReturned = "cupEmpty", Potion = new() { new("Heal", 3) } }); 
            

            itemsToAdd.Add(new Item("Beer glass", "I need to fill this with beer.", "beerGlass", 200, 200, 200, 2));
            itemsToAdd.Add(new Item("Beer", "A glass of frothy ale.", "beer", 255, 255, 0, 2) { UseString = "Potion", UseInt4 = 1, ItemReturned = "beerGlass", Potion = new() { new("Heal", 1), new("Attack", -2), new("Strength", 2) } });
            itemsToAdd.Add(new Item("Dwarven stout", "A pint of thick dark beer.", "dwarvenStout", Color.DimGray, 2) { UseString = "Potion", UseInt4 = 1, ItemReturned = "beerGlass", Potion = new() { new("Heal", 1), new("Attack", -3), new("Strength", -3), new("Defense", -3), new("Mining", 1), new("Smithing", 1) } });
            
            itemsToAdd.Add(new Item("Garlic", "Deters vampires.", "garlic", Color.AntiqueWhite, 3));

            itemsToAdd.Add(new Item("Pot of flour", "A pot full of flour.", "potFlour", 207, 185, 151, 10));
            itemsToAdd.Add(new Item("Bread dough", "Some uncooked dough.", "doughBread", 221, 199, 160, 4) { UseString = "Baking" });
            itemsToAdd.Add(new Item("Pizza base", "I need to add some tomato next.", "doughPizza", 221, 199, 160, 4) { UseString = "Baking" });
            itemsToAdd.Add(new Item("Pitta dough", "Some uncooked dough.", "doughPitta", 221, 199, 160, 4) { UseString = "Baking" });
            itemsToAdd.Add(new Item("Pitta bread", "Nice baked pitta bread. Needs more ingredients to make a kebab.", "breadPitta", 233, 185, 93, 10));
            itemsToAdd.Add(new Item("Pastry dough", "Some uncooked dough.", "doughPastry", 221, 199, 160, 4) { UseString = "Baking" });
            itemsToAdd.Add(new Item("Gianne dough", "Some uncooked gnomish dough.", "doughGianne", 221, 199, 160, 4) { UseString = "Baking" });
            itemsToAdd.Add(new Item("Bread", "Nice crispy bread.", "bread", 233, 185, 93, 12) { UseString = "Heal", UseInt = 5 });
            itemsToAdd.Add(new Item("Egg", "An egg from a chicken. Could be fried or scrambled, perhaps.", "eggChicken", 233, 185, 93, 4));
            itemsToAdd.Add(new Item("Cake", "A plain sponge cake.", "cake", 255, 255, 255, 50) { UseString = "Heal", UseInt = 9 });
            itemsToAdd.Add(new Item("Chocolate cake", "This looks very tasty.", "cakeChocolate", Color.Brown, 70) { UseString = "Heal", UseInt = 15 });
            itemsToAdd.Add(new Item("Chocolate cake (2/3)", "This looks very tasty.", "cakeChocolate1", Color.Brown, 45) { UseString = "Heal", UseInt = 10 });
            itemsToAdd.Add(new Item("Chocolate cake slice", "I'd rather have a full cake.", "cakeChocolate2", Color.Brown, 20) { UseString = "Heal", UseInt = 5 });
            itemsToAdd.Add(new Item("Kebab", "A meaty kebab.", "kebab", Color.Lime, 5) { UseString = "Kebab"});
              
            itemsToAdd.Add(new Item("Bucket of water", "A bucket filled with water.", "bucketWater", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Bucket of milk", "A bucket filled with milk.", "bucketMilk", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Pot of cream", "Fresh cream.", "cream", Color.White, 4));
            itemsToAdd.Add(new Item("Pat of butter", "A pat of freshly churned butter.", "butter", Color.LightYellow, 8));
            itemsToAdd.Add(new Item("Cheese", "Cheese, Gromit! Cheese!", "cheese", Color.Yellow, 12));
            itemsToAdd.Add(new Item("Jug of water", "A jug filled with water.", "jugWater", 200, 200, 200, 1));
            itemsToAdd.Add(new Item("Jug of vinegar", "This wine clearly did not age well.", "jugVinegar", 200, 200, 200, 1, trade: false));
            itemsToAdd.Add(new Item("Pot of vinegar", "Well, this pot is certainly full of vinegar and no mistake.", "potVinegar", 200, 200, 200, 1, trade: false));
            itemsToAdd.Add(new Item("Jug of wine", "A jug filled with wine.", "jugWine", 200, 200, 200, 100) { UseString = "Potion", ItemReturned = "jugEmpty", UseInt4 = 1, Potion = new() { new("Attack", -2), new("Heal", 11) } });
            itemsToAdd.Add(new Item("Bottle of wine", "A very good vintage.", "bottleWine", Color.IndianRed, 500) { UseString = "Potion", ItemReturned = "bottleEmpty", UseInt4 = 1, Potion = new() { new("Attack", -3), new("Heal", 14) } });
            itemsToAdd.Add(new Item("Empty wine bottle", "The one has clearly been taken down and passed around.", "bottleEmpty", Color.White, 2));
            itemsToAdd.Add(new Item("Bowl of water", "A bowl filled with water.", "bowlWater", 207, 185, 151, 4));
            itemsToAdd.Add(new Item("Cake tin", "Useful for baking cakes.", "tinCakeEmpty", 100, 100, 100, 10));
            itemsToAdd.Add(new Item("Cake tin (egg)", "A cake tin with an egg cracked into it. Needs flour and milk.", "tinCakeEgg", 100, 100, 100, 13));
            itemsToAdd.Add(new Item("Cake tin (egg, flour)", "A cake tin with an egg and some flour. Still needs milk.", "tinCakeFlour", 100, 100, 100, 16));
            itemsToAdd.Add(new Item("Cake tin (batter)", "A tin full of cake batter, ready for cooking.", "tinCakeBatter", 100, 100, 100, 20));


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
