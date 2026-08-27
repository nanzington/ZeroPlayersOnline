using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItems {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();
            itemsToAdd.Add(new Item("Pine log", "A bundle of pine logs.", "logPine", 237, 202, 161, 4, 2, 1));
            itemsToAdd.Add(new Item("Tinderbox", "An arsonist's best friend.", "tinderbox", 255, 255, 255, 1, 0, 0));
            itemsToAdd.Add(new Item("Ashes", "A pile of wood ash.", "ashes", 200, 200, 200, 2, 1, 0));
            itemsToAdd.Add(new Item("Hammer", "Good for hitting things!", "hammer", 150, 150, 150, 1, 0, 0));
            itemsToAdd.Add(new Item("Knife", "Good for chopping or whittling, not so much for stabbing.", "knife", 150, 150, 150, 1, 0, 0) { UseString = "Knife", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Needle", "Now to get a camel through eye of this thing...", "needle", 200, 200, 200, 1, 0, 0) { UseString = "Needle", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Feather", "I could probably make arrows with this. Or put one in my cap!", "feather", 255, 255, 255, 2, 1, 0, true));

            itemsToAdd.Add(new Item("Cowhide", "This should be tanned before I can use it.", "cowhide", 255, 255, 255, 10, 5, 2));
            itemsToAdd.Add(new Item("Soft Leather", "Suitable for craftworks now.", "leatherSoft", 165, 42, 42, 10, 5, 2));
            itemsToAdd.Add(new Item("Hard Leather", "Might offer some real protection if made into armor.", "leatherHard", 139, 69, 19, 10, 5, 2));
             

            itemsToAdd.Add(new Item("Arrow shaft", "The most important part of an arrow.", "arrowshaft", 139, 69, 19, 2, 1, 0, true));
            itemsToAdd.Add(new Item("Headless shafts", "An arrow shaft with a feather attached. Needs to be tipped.", "headlessShaft", 139, 69, 19, 2, 1, 0, true));
            itemsToAdd.Add(new Item("Pine shortbow (u)", "A shortbow stave fletched from pine.", "shortbowPineU", 237, 202, 161, 4, 2, 1));
            itemsToAdd.Add(new Item("Pine shortbow", "A shortbow fletched from pine.", "shortbowPine", 237, 202, 161, 4, 2, 1) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Arrow",
                EquipSkill = "Ranged",
                EquipAmmo = "Arrow",
                AttackSpeed = 1
            });


            itemsToAdd.Add(new Item("Shovel", "Could be used to dig for buried treasure.", "shovel", 200, 200, 200, 3, 1, 1) {
                UseString = "Dig",
                ConsumedOnUse = false
            });

            itemsToAdd.Add(new Item("Clue scroll (tutorial)", "A treasure hunt taking place entirely on Tutorial Island.", "clueScrollTutorial", 207, 185, 151, 0, 0, 0, false, false) {
                UseString = "ClueTutorial", 
                ConsumedOnUse = false,
                DestroyOnDrop = true
            });

            itemsToAdd.Add(new Item("Clue casket (tutorial)", "The treasure at the end of the hunt! What could be inside?", "casketTutorial", 218, 165, 32, 0, 0, 0, true, false) {
                UseString = "Casket",
                UseString2 = "Tutorial",
                UseInt = 100,
                DropTable = {
                    new ItemDrop("clueCatEars", 1, 1, 1, 1)
                }
            });

            // Clue (Tutorial) Uniques
            itemsToAdd.Add(new Item("Cat ear headband", "A cute headband that makes you look like you have cat ears.", "clueCatEars", 255, 105, 180, 500, 300, 200, equip: "Head") {  Cosmetic = true });
            




            itemsToAdd.Add(new Item("Potato seed", "Aren't potatoes potato seeds?", "seedPotato", 205, 127, 50, 5, 2, 1, true) {
                UseString = "PlantSeed",
                UseString2 = "Allotment", // Type of patch to plant in
                UseString3 = "potato", // Output when grown
                UseInt = 1, // Farming level to plant
                UseInt2 = 10, // Exp on harvest
                UseInt3 = 2400 // Time to grow in seconds

            });
            itemsToAdd.Add(new Item("Potato", "A tuber most versatile.", "potato", 205, 127, 50, 5, 2, 1));
            itemsToAdd.Add(new Item("Baked potato", "It'd taste even better with some toppings", "potatoBaked", 225, 147, 70, 10, 2, 1) {
                UseString = "Heal",
                UseInt = 4
            });


            itemsToAdd.Add(new Item("Clay dust", "Some hard dry clay.", "clayDust", 207, 185, 151, 1, 0, 0));
            itemsToAdd.Add(new Item("Soft clay", "Clay soft enough to mould.", "claySoft", 205, 127, 50, 2, 1, 0) { UseString = "Clay", ConsumedOnUse = false });


            itemsToAdd.Add(new Item("Flax", "I should use this with a spinning wheel.", "flax", 189, 246, 254, 5, 3, 2));
            itemsToAdd.Add(new Item("Bow string", "I need a bow stave to attach this to.", "bowstring", 207, 185, 151, 10, 6, 4));
              
            itemsToAdd.Add(new Item("Leather cowl", "Better than no armor!", "leatherCowl", 205, 127, 50, 20, 12, 8) {
                EquipSlot = "Head",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseRange"
            });

            itemsToAdd.Add(new Item("Leather body", "Better than no armor!", "leatherBody", 205, 127, 50, 20, 12, 8) {
                EquipSlot = "Body",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseRange"
            });

            itemsToAdd.Add(new Item("Leather chaps", "Better than no armor!", "leatherChaps", 205, 127, 50, 20, 12, 8) {
                EquipSlot = "Legs",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseRange"
            });

            itemsToAdd.Add(new Item("Leather gloves", "Better than no armor!", "leatherGloves", 205, 127, 50, 20, 12, 8) {
                EquipSlot = "Hands",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseRange"
            });

            itemsToAdd.Add(new Item("Leather boots", "Better than no armor!", "leatherBoots", 205, 127, 50, 20, 12, 8) {
                EquipSlot = "Feet",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseRange"
            });

            itemsToAdd.Add(new Item("Pure essence", "An unimbued rune.", "pureEssence", 200, 200, 200, 4, 2, 1));
            itemsToAdd.Add(new Item("Air rune", "One of the 4 basic elemental runes.", "runeAir", 200, 200, 200, 4, 2, 1, true, true));

            itemsToAdd.Add(new Item("Copper ore", "A pile of copper ore nuggets.", "oreCopper", 184, 115, 51, 3, 1, 1));
            itemsToAdd.Add(new Item("Tin ore", "A pile of tin ore nuggets.", "oreTin", 170, 170, 170, 3, 1, 1)); 
            itemsToAdd.Add(new Item("Bronze ore mix", "A mix of copper and tin ore nuggets.", "oreMixBronze", 205, 127, 50, 6, 2, 2)); 
            itemsToAdd.Add(new Item("Bronze bar", "It's a bar of bronze.", "barBronze", 205, 127, 50, 8, 4, 3));

            itemsToAdd.Add(new Item("Small Coin Pouch", "Has a few coins in it.", "coinPouchSmall", 111, 66, 33, 5, 3, 1, true, true) {
                UseString = "GetGold",
                UseInt = 5 
            });

            itemsToAdd.Add(new Item("Bones", "The remains of some creature or person.", "bonesRegular", 255, 255, 255, 1, 0, 0, false, true) {
                UseString = "Bones",
                UseInt = 5 
            });
             
            itemsToAdd.Add(new Item("Raw newt meat", "A cut of meat taken from a newt.", "meatRawNewt", 138, 3, 3, 1, 0, 0));
            itemsToAdd.Add(new Item("Cooked newt meat", "A cooked newt steak.", "meatCookedNewt", 150, 100, 50, 4, 2, 1) {
                UseString = "Heal",
                UseInt = 3 
            });

            itemsToAdd.Add(new Item("Raw beef", "A cut of meat taken from a cow.", "meatRawBeef", 138, 3, 3, 1, 0, 0));
            itemsToAdd.Add(new Item("Cooked steak", "A cooked steak.", "meatCookedBeef", 150, 100, 50, 4, 2, 1) {
                UseString = "Heal",
                UseInt = 3
            });

            itemsToAdd.Add(new Item("Raw chicken", "A cut of meat taken from a newt.", "meatRawChicken", 138, 3, 3, 1, 0, 0));
            itemsToAdd.Add(new Item("Cooked chicken", "A cooked chicken.", "meatCookedChicken", 150, 100, 50, 4, 2, 1) {
                UseString = "Heal",
                UseInt = 3
            });

            itemsToAdd.Add(new Item("Raw shrimps", "A few raw shrimp.", "fishRawShrimp", 138, 3, 3, 5, 3, 2));
            itemsToAdd.Add(new Item("Cooked shrimps", "Some cooked shrimp.", "fishCookedShrimp", 150, 100, 50, 5, 3, 2) {
                UseString = "Heal",
                UseInt = 3
            });

            itemsToAdd.Add(new Item("Raw anchovies", "A few raw anchovies.", "fishRawAnchovies", 173, 216, 230, 15, 9, 6));
            itemsToAdd.Add(new Item("Cooked anchovies", "Some cooked anchovies.", "fishCookedAnchovies", 143, 186, 200, 15, 9, 6) {
                UseString = "Heal",
                UseInt = 1
            });


            itemsToAdd.Add(new Item("Empty Bucket", "An empty bucket. Could probably hold something.", "bucketEmpty", 111, 66, 33, 2, 1, 0));
            itemsToAdd.Add(new Item("Bucket of Water", "A bucket filled with water.", "bucketWater", 111, 66, 33, 2, 1, 0)); 
             
            itemsToAdd.Add(new Item("Bronze helmet", "Provides minimal protection.", "helmBronze", 205, 127, 50, 44, 26, 17) {
                EquipSlot = "Head",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseMelee"
            });

            itemsToAdd.Add(new Item("Bronze platebody", "Provides minimal protection.", "platebodyBronze", 205, 127, 50, 44, 26, 17) {
                EquipSlot = "Body",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseMelee"
            });

            itemsToAdd.Add(new Item("Bronze platelegs", "Provides minimal protection.", "platelegsBronze", 205, 127, 50, 44, 26, 17) {
                EquipSlot = "Legs",
                EquipTier = 1,
                EquipSkill = "Defense",
                EquipLevel = 1,
                UseInt = 1,
                MiscString = "DefenseMelee"
            });

            itemsToAdd.Add(new Item("Bronze arrows", "Time flies like an arrow. Fruit flies like a banana.", "arrowsBronze", 205, 127, 50, 44, 26, 17, true) {
                EquipSlot = "Ammo",
                EquipTier = 1,
                EquipSkill = "Ranged",
                EquipDamageType = "Arrow",
                EquipLevel = 1,
                UseInt = 1
            });
            itemsToAdd.Add(new Item("Bronze arrowheads", "I can make some arrows with these.", "arrowheadsBronze", 205, 127, 50, 44, 26, 17, true));
            itemsToAdd.Add(new Item("Bronze knives", "A finely balanced throwing knife.", "knivesBronze", 205, 127, 50, 44, 26, 17, true) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Stab",
                EquipSkill = "Ranged",
                AttackSpeed = 0.5,
                EquipAmmo = "Self"
            });

            itemsToAdd.Add(new Item("Bronze dagger", "Good for stabbing.", "daggerBronze", 205, 127, 50, 10, 6, 4) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Stab",
                EquipSkill = "Attack"
            });

            itemsToAdd.Add(new Item("Bronze sword", "Good for slashing.", "swordBronze", 205, 127, 50, 10, 6, 4) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Slash",
                EquipSkill = "Attack"
            });

            itemsToAdd.Add(new Item("Bronze scimitar", "Good for slashing quickly.", "scimitarBronze", 205, 127, 50, 10, 6, 4) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Slash",
                EquipSkill = "Attack",
                AttackSpeed = 0.75
            });

            itemsToAdd.Add(new Item("Bronze mace", "Good for bashing.", "maceBronze", 205, 127, 50, 10, 6, 4) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Crush",
                EquipSkill = "Attack"
            });



            itemsToAdd.Add(new Item("Eye of newt", "A basic herblore ingredient and only slightly gross.", "eyeNewt", 255, 255, 255, 3, 1, 1));


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
