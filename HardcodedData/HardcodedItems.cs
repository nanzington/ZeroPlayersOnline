using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItems {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();
            itemsToAdd.Add(new Item("Pine log", "A bundle of pine logs.", "logPine", ColorLib.Pine, 4));
            itemsToAdd.Add(new Item("Oak log", "A bundle of oak logs.", "logOak", ColorLib.Oak, 20));
            itemsToAdd.Add(new Item("Willow log", "A bundle of willow logs.", "logWillow", ColorLib.Willow, 40));
            itemsToAdd.Add(new Item("Teak log", "A bundle of teak logs.", "logTeak", ColorLib.Teak, 30));
            itemsToAdd.Add(new Item("Maple log", "A bundle of maple logs.", "logMaple", ColorLib.Maple, 80));
            itemsToAdd.Add(new Item("Acadia log", "A bundle of acadia logs.", "logAcadia",ColorLib.Acadia, 85));
            itemsToAdd.Add(new Item("Mahogany log", "A bundle of mahogany logs.", "logMahogany", ColorLib.Mahogany, 50));
            itemsToAdd.Add(new Item("Yew log", "A bundle of yew logs.", "logYew", ColorLib.Yew, 160));
            itemsToAdd.Add(new Item("Magic log", "A bundle of magic logs.", "logMagic", ColorLib.Magic, 320));
            itemsToAdd.Add(new Item("Elder log", "A bundle of elder logs.", "logElder", ColorLib.Elder, 480));



            itemsToAdd.Add(new Item("Tinderbox", "An arsonist's best friend.", "tinderbox", 255, 255, 255, 1));
            itemsToAdd.Add(new Item("Ashes", "A pile of wood ash.", "ashes", 200, 200, 200, 2));
            itemsToAdd.Add(new Item("Hammer", "Good for hitting things!", "hammer", 150, 150, 150, 1));
            itemsToAdd.Add(new Item("Knife", "Good for chopping or whittling, not so much for stabbing.", "knife", 150, 150, 150, 1) { UseString = "Knife", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Needle", "Now to get a camel through eye of this thing...", "needle", 200, 200, 200, 1) { UseString = "Needle", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Feather", "I could probably make arrows with this. Or put one in my cap!", "feather", 255, 255, 255, 2, true));
            
            itemsToAdd.Add(new Item("Bird snare", "Snares the leg of any bird that lands on it wrong.", "trapBird", 237, 202, 161, 5));
            
            itemsToAdd.Add(new Item("Small fishing net", "Useful for catching small fish.", "fishingNetSmall", 50, 50, 50, 5, misc: "Small net"));
            itemsToAdd.Add(new Item("Big fishing net", "Useful for catching lots of fish.", "fishingNetBig", 50, 50, 50, 20, misc: "Big net"));
            itemsToAdd.Add(new Item("Fishing rod", "Useful for catching sardine or herring.", "fishingRod", 139, 69, 19, 5, misc: "Fishing rod")); 
            itemsToAdd.Add(new Item("Fish bait", "For use with a fishing rod.", "baitFish", 233, 185, 93, 3, true));
            itemsToAdd.Add(new Item("Fly fishing rod", "Like a fishing rod, but with cool glasses and a sick haircut.", "fishingRodFly", 139, 69, 19, 5, misc: "Fly fishing rod"));
            itemsToAdd.Add(new Item("Harpoon", "Useful for catching really big fish.", "fishingHarpoon", 139, 69, 19, 45, misc: "Harpoon"));
            itemsToAdd.Add(new Item("Lobster pot", "Useful for catching lobsters.", "fishingPotLobster", 139, 69, 19, 20, misc: "Lobster pot"));
            itemsToAdd.Add(new Item("Shears", "Necessary to de-wool sheep.", "shears", 200, 200, 200, 1, misc: "Shears"));

            
            itemsToAdd.Add(new Item("Wool", "Nice and fluffy.", "woolRaw", 255, 255, 255, 5));
            itemsToAdd.Add(new Item("Ball of wool", "Spun from wool.", "woolBall", 255, 255, 255, 7)); 
            itemsToAdd.Add(new Item("Chisel", "Good for detailed crafting.", "chisel", Color.SaddleBrown, 14));

            itemsToAdd.Add(new Item("Ammo mould", "Used to make cannon ammunition.", "mouldAmmo", Color.Gray, 5));
            itemsToAdd.Add(new Item("Amulet mould", "Used to make amulets.", "mouldAmulet", Color.White, 5));
            itemsToAdd.Add(new Item("Bracelet mould", "Used to make bracelets and anklets.", "mouldBracelet", Color.White, 5));
            itemsToAdd.Add(new Item("Bolt mould", "Used to make silver crossbow bolts.", "mouldBolt", Color.White, 25)); 
            itemsToAdd.Add(new Item("Chain link mould", "Used to make chain links.", "mouldChainlink", Color.Gray, 3));
            itemsToAdd.Add(new Item("Conductor mould", "Used to make silver lightning conductors.", "mouldConductor", Color.White, 3));
            itemsToAdd.Add(new Item("Demonic sigil mould", "Used to make the sigil of the demon Agrith Naar.", "mouldDemonicSigil", Color.White, 5));
            itemsToAdd.Add(new Item("Gnomebowl mould", "A large ovenproof bowl.", "mouldGnomebowl", Color.White, 10));
            itemsToAdd.Add(new Item("Holy mould", "Used to make holy symbols of Saradomin.", "mouldHoly", Color.White, 5));
            itemsToAdd.Add(new Item("Key mould", "A key mould, made from a ragged book.", "mouldKey", Color.White, 1));
            itemsToAdd.Add(new Item("Lens mould", "An unusual mould in the shape of a disc.", "mouldLens", Color.Gray, 1));
            itemsToAdd.Add(new Item("Monkeyspeak amulet mould", "It's an amulet mould shaped like a monkey head.", "mouldAmuletMonkeyspeak", Color.White, 10));
            itemsToAdd.Add(new Item("Necklace mould", "Used to make necklaces.", "mouldNecklacec", Color.White, 5));
            itemsToAdd.Add(new Item("Ring mould", "Used to make rings.", "mouldRing", Color.White, 5));
            itemsToAdd.Add(new Item("Rod clay mould", "Rod of Ivandis mould.", "mouldRodClay", Color.SandyBrown, 5));
            itemsToAdd.Add(new Item("Sickle mould", "Used to make sickles.", "mouldSickle", Color.White, 10));
            itemsToAdd.Add(new Item("Tiara mould", "A mould for tiaras.", "mouldTiara", Color.SaddleBrown, 100));
            itemsToAdd.Add(new Item("Unholy mould", "Used to make unholy symbols.", "mouldUnholy", Color.White, 200));

            itemsToAdd.Add(new Item("Cowhide", "This should be tanned before I can use it.", "cowhide", 255, 255, 255, 10));
            itemsToAdd.Add(new Item("Soft leather", "Suitable for craftworks now.", "leatherSoft", 165, 42, 42, 10));
            itemsToAdd.Add(new Item("Hard leather", "Might offer some real protection if made into armor.", "leatherHard", 139, 69, 19, 20));
             

            itemsToAdd.Add(new Item("Arrow shaft", "The most important part of an arrow.", "arrowshaft", 139, 69, 19, 2, true));
            itemsToAdd.Add(new Item("Headless shafts", "An arrow shaft with a feather attached. Needs to be tipped.", "headlessShaft", 139, 69, 19, 2, true));


            // Fletching Factory
            List<MaterialDef> Woods = new() {
                new("Pine", ColorLib.Pine, 1, 1, 5, "pine"),
                new("Oak", ColorLib.Oak, 2, 10, 20, "oak"),
                new("Willow", ColorLib.Willow, 3, 20, 40, "willow"),
                new("Teak", ColorLib.Teak, 4, 30, 30, "teak"),
                new("Maple", ColorLib.Maple, 5, 40, 80, "maple"),
                new("Acadia", ColorLib.Acadia, 6, 50, 85, "acadia"),
                new("Mahogany", ColorLib.Mahogany, 7, 60, 50, "mahogany"),
                new("Yew", ColorLib.Yew, 8, 70, 160, "yew"),
                new("Magic", ColorLib.Magic, 9, 80, 320, "magic"),
                new("Elder", ColorLib.Elder, 10, 90, 480, "elder")
            };

            foreach (var mat in Woods) { 
                itemsToAdd.Add(new Item(mat.Name + " shortbow (u)", "A shortbow stave fletched from " + mat.Descriptor + ".", "shortbow" + mat.Name + "U", mat.R, mat.G, mat.B, mat.CostMultiplier));
                itemsToAdd.Add(new Item(mat.Name + " shortbow", "A shortbow fletched from " + mat.Descriptor + ".", "shortbow" + mat.Name, mat.R, mat.G, mat.B, mat.CostMultiplier + 15) {
                    EquipSlot = "Weapon",
                    EquipTier = mat.Tier,
                    EquipLevel = mat.Level, 
                    EquipDamageType = "Arrow",
                    EquipSkill = "Ranged",
                    EquipAmmo = "Arrow",
                    AttackSpeed = 1, 
                    TwoHanded = true
                });
            }  

            itemsToAdd.Add(new Item("Shovel", "Could be used to dig for buried treasure.", "shovel", 200, 200, 200, 3) { UseString = "Dig", ConsumedOnUse = false });


            // Clue scroll stuff
            {
                // Tutorial Clues
                itemsToAdd.Add(new Item("Clue scroll (tutorial)", "A treasure hunt taking place entirely on Tutorial Island.", "clueScrollTutorial", 207, 185, 151, 0, false, false) {
                    UseString = "ClueTutorial", 
                    ConsumedOnUse = false,
                    DestroyOnDrop = true
                });

                itemsToAdd.Add(new Item("Clue casket (tutorial)", "The treasure at the end of the hunt! What could be inside?", "casketTutorial", 218, 165, 32, 0, true, false) {
                    UseString = "Casket",
                    UseString2 = "Tutorial",
                    UseInt = 100,
                    DropTable = {
                        new ItemDrop("clueCatEars", 1, 20, 1, 1),
                        new ItemDrop("clueCornyApron", 1, 20, 1, 1),
                        new ItemDrop("clueKilt", 1, 20, 1, 1),
                        new ItemDrop("cluePowerGlove", 1, 20, 1, 1),
                        new ItemDrop("clueProgrammerSocks", 1, 20, 1, 1),
                        new ItemDrop("helmTutorial", 1, 20, 1, 1), 
                        new ItemDrop("platebodyTutorial", 1, 20, 1, 1), 
                        new ItemDrop("platelegsTutorial", 1, 20, 1, 1), 
                        new ItemDrop("gauntletsTutorial", 1, 20, 1, 1), 
                        new ItemDrop("swordTutorial", 1, 20, 1, 1), 
                        new ItemDrop("maceTutorial", 1, 20, 1, 1), 
                        new ItemDrop("daggerTutorial", 1, 20, 1, 1), 
                        new ItemDrop("scimitarTutorial", 1, 20, 1, 1), 
                        new ItemDrop("pickaxeTutorial", 1, 20, 1, 1), 
                        new ItemDrop("hatchetTutorial", 1, 20, 1, 1),      
                        new ItemDrop("bootsTutorial", 1, 20, 1, 1),
                        new ItemDrop("clueSilkHood", 1, 20, 1, 1),
                        new ItemDrop("clueSilkRobes", 1, 20, 1, 1),
                        new ItemDrop("clueSilkUnderwear", 1, 20, 1, 1),
                        new ItemDrop("clueSilkGloves", 1, 20, 1, 1),
                        new ItemDrop("clueSilkSocks", 1, 20, 1, 1),
                        new ItemDrop("clueNewtskinCoif", 1, 20, 1, 1),
                        new ItemDrop("clueNewtskinBody", 1, 20, 1, 1),
                        new ItemDrop("clueNewtskinChaps", 1, 20, 1, 1),
                        new ItemDrop("clueNewtskinVambraces", 1, 20, 1, 1),
                        new ItemDrop("clueNewtskinBoots", 1, 20, 1, 1),
                        new ItemDrop("clueNewtbow", 1, 20, 1, 1),
                        new ItemDrop("staffAir", 1, 10, 1, 1), 
                        new ItemDrop("staffWater", 1, 10, 1, 1), 
                        new ItemDrop("staffEarth", 1, 10, 1, 1), 
                        new ItemDrop("staffFire", 1, 10, 1, 1), 
                        new ItemDrop("runeAir", 1, 4, 100, 200), 
                        new ItemDrop("runeWater", 1, 4, 100, 200), 
                        new ItemDrop("runeEarth", 1, 4, 100, 200), 
                        new ItemDrop("runeFire", 1, 4, 100, 200), 
                        new ItemDrop("arrowsBronze", 1, 4, 100, 200), 
                        new ItemDrop("arrowsTutorial", 1, 4, 50, 100),
                        new ItemDrop("knivesBronze", 1, 4, 200, 400),
                        new ItemDrop("knivesTutorial", 1, 4, 100, 200)
                    }
                });

                // Clue (Tutorial) Uniques
                itemsToAdd.Add(new Item("Cat ear headband", "A cute headband that makes you look like you have cat ears.", "clueCatEars", 255, 105, 180, 500) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Corny apron", "An apron reading 'Kiss the Cook'.", "clueCornyApron", 255, 255, 255, 500) { EquipSlot = "Torso", Cosmetic = true });
                itemsToAdd.Add(new Item("Kilt", "A bit breezy but quite comfortable.", "clueKilt", 34, 139, 34, 500) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Power glove", "A gauntlet with a bunch of buttons on it. Seems wildly impractical.", "cluePowerGlove", 150, 150, 150, 500) { EquipSlot = "Hands", Cosmetic = true });
                itemsToAdd.Add(new Item("Programmer socks", "Thigh-high socks with blue stripes.", "clueProgrammerSocks", 135, 206, 235, 500) { EquipSlot = "Feet", Cosmetic = true });
            
                itemsToAdd.Add(new Item("Silky hood", "A silk hood. Slightly magical, very comfortable.", "clueSilkHood", 147, 112, 219, 500) { EquipSlot = "Head", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky robes", "A set of silk robes. Slightly magical, very comfortable.", "clueSilkRobes", 147, 112, 219, 500) { EquipSlot = "Torso", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky underwear", "A pair of silk underwear. Slightly magical, very comfortable.", "clueSilkUnderwear", 147, 112, 219, 500) { EquipSlot = "Legs", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky gloves", "A pair of silk gloves. Slightly magical, very comfortable.", "clueSilkGloves", 147, 112, 219, 500) { EquipSlot = "Hands", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky socks", "A pair of silk socks. Slightly magical, very comfortable.", "clueSilkSocks", 147, 112, 219, 500) { EquipSlot = "Feet", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });

                itemsToAdd.Add(new Item("Newtskin coif", "A coif made of newtskin, which seems to have been removed from the game at some point.", "clueNewtskinCoif", 255, 165, 0, 500) { EquipSlot = "Head", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseRange" });
                itemsToAdd.Add(new Item("Newtskin body", "A body made of newtskin, which seems to have been removed from the game at some point.", "clueNewtskinBody", 255, 165, 0, 500) { EquipSlot = "Torso", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseRange" });
                itemsToAdd.Add(new Item("Newtskin chaps", "Chaps made of newtskin, which seems to have been removed from the game at some point.", "clueNewtskinChaps", 255, 165, 0, 500) { EquipSlot = "Legs", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseRange" });
                itemsToAdd.Add(new Item("Newtskin vambraces", "Vambraces made of newtskin, which seems to have been removed from the game at some point.", "clueNewtskinVambraces", 255, 165, 0, 500) { EquipSlot = "Hands", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseRange" });
                itemsToAdd.Add(new Item("Newtskin boots", "Boots made of newtskin, which seems to have been removed from the game at some point.", "clueNewtskinBoots", 255, 165, 0, 500) { EquipSlot = "Feet", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseRange" });
                itemsToAdd.Add(new Item("Newtbone shortbow", "Did someone hate newts or something? Why is all the ranger gear made of newt bits?", "clueNewtbow", 255, 255, 255, 500) { EquipSlot = "Weapon", EquipTier = 1, EquipDamageType = "Arrow", EquipSkill = "Ranged", EquipLevel = 1, EquipAmmo = "Arrow", AttackSpeed = 1, TwoHanded = true });
            
                
                // Beginner Clues
                itemsToAdd.Add(new Item("Clue scroll (beginner)", "Hopefully leads to treasure.", "clueScrollBeginner", 207, 185, 151, 0, false, false) {
                    UseString = "ClueBeginner", 
                    ConsumedOnUse = false,
                    DestroyOnDrop = true
                });

                itemsToAdd.Add(new Item("Clue casket (beginner)", "The treasure at the end of the hunt! What could be inside?", "casketBeginner", 218, 165, 32, 0, true, false) {
                    UseString = "Casket",
                    UseString2 = "Beginner",
                    UseInt = 100,
                    DropTable = {
                        new ItemDrop("clueCatEars", 1, 20, 1, 1),
                        new ItemDrop("clueCornyApron", 1, 20, 1, 1)
                    }
                });

            }

            itemsToAdd.Add(new Item("Tutorial Island cape", "A cape signifying you completed all challenges on Tutorial Island. Congratulations!", "capeCompTI", 135, 206, 235, 0) { EquipSlot = "Cape", EquipTier = 1, MiscString = "OmniBoost" });
            itemsToAdd.Add(new Item("Defense skillcape", "The cape worn by masters of the art of Defense.", "capeSkillDefense", Color.CornflowerBlue, 0) { EquipSlot = "Cape", EquipTier = 2, MiscString = "OmniBoost" });

            itemsToAdd.Add(new Item("Blue wizard hat", "A silly pointed hat.", "wizardBlueHat", 0, 157, 196, 2) { EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
            itemsToAdd.Add(new Item("Chef's hat", "What a silly hat.", "chefHat", 255, 255, 255, 2) { EquipSlot = "Head", Cosmetic = true });



            // Farming - Seeds, Products, Direct Cooked Product
            {
                // // Farming - Allotments
                {
                    itemsToAdd.Add(new Item("Potato seed", "Aren't potatoes potato seeds?", "seedPotato", 205, 127, 50, 5, true) {
                        UseString = "PlantSeed", UseString2 = "Allotment", UseString3 = "potato",
                        UseInt = 1 /* Level */, UseInt2 = 10 /* Exp on Harvest */, UseInt3 = 2400 /* Growth time in seconds */

                    });
                    itemsToAdd.Add(new Item("Potato", "A tuber most versatile.", "potato", 205, 127, 50, 5) { UseString = "Heal", UseInt = 1 });
                    itemsToAdd.Add(new Item("Baked potato", "It'd taste even better with some toppings", "potatoBaked", 225, 147, 70, 10) { UseString = "Heal", UseInt = 4 });

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

                    itemsToAdd.Add(new Item("Snape grass seed", "A snape grass seed - plant in an allotment. (38)", "seedSnapeGrass", 0, 255, 0, 20, true) {
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
                    itemsToAdd.Add(new Item("Grimy guam leaf", "It needs cleaning.", "herbGrimyGuam", Color.ForestGreen, 13) { UseString = "CleanHerb", UseString2 = "herbCleanGuam", UseInt = 1, UseInt2 = 3 }); 
                    itemsToAdd.Add(new Item("Guam leaf", "A bitter green herb.", "herbCleanGuam", Color.ForestGreen.GetBright(), 13)); 
                 
                    // Tarromin
                    itemsToAdd.Add(new Item("Tarromin seed", "A tarromin seed - plant in an herb patch. (5)", "seedTarromin", Color.Lime, 10, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyTarromin",
                        UseInt = 5 /* Level */,  UseInt2 = 30 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy tarromin", "It needs cleaning.", "herbGrimyTarromin", Color.SeaGreen.GetDark(), 13) { UseString = "CleanHerb", UseString2 = "herbCleanTarromin", UseInt = 5, UseInt2 = 4 }); 
                    itemsToAdd.Add(new Item("Tarromin", "A fresh herb.", "herbCleanTarromin", Color.SeaGreen, 13)); 
                 
                    // Marrentill
                    itemsToAdd.Add(new Item("Marrentill seed", "A marrentill seed - plant in an herb patch. (7)", "seedMarrentill", Color.Green, 11, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyMarrentill",
                        UseInt = 9 /* Level */,  UseInt2 = 40 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy marrentill", "It needs cleaning.", "herbGrimyMarrentill", Color.SeaGreen.GetDark(), 13) { UseString = "CleanHerb", UseString2 = "herbCleanMarrentill", UseInt = 9, UseInt2 = 5 }); 
                    itemsToAdd.Add(new Item("Marrentill", "A fresh herb.", "herbCleanMarrentill", Color.SeaGreen, 13)); 

                    // Harralander
                    itemsToAdd.Add(new Item("Harralander seed", "A harralander seed - plant in an herb patch. (20)", "seedHarralander", Color.SeaGreen, 15, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyHarralander",
                        UseInt = 20 /* Level */,  UseInt2 = 50 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy harralander", "It needs cleaning.", "herbGrimyHarralander", Color.MediumSpringGreen.GetDark(), 13) { UseString = "CleanHerb", UseString2 = "herbCleanHarralander", UseInt = 20, UseInt2 = 6 }); 
                    itemsToAdd.Add(new Item("Harralander", "A fresh herb.", "herbCleanHarralander", Color.MediumSpringGreen, 13));

                    // Ranarr
                    itemsToAdd.Add(new Item("Ranarr seed", "A ranarr seed - plant in an herb patch. (25)", "seedRanarr", Color.DarkOliveGreen, 15, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyRanarr",
                        UseInt = 25 /* Level */,  UseInt2 = 60 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy ranarr", "It needs cleaning.", "herbGrimyRanarr", Color.MediumSpringGreen.GetDark(), 25) { UseString = "CleanHerb", UseString2 = "herbCleanRanarr", UseInt = 25, UseInt2 = 7 }); 
                    itemsToAdd.Add(new Item("Ranarr", "A fresh herb.", "herbCleanRanarr", Color.MediumSpringGreen, 25));

                    // Toadflax
                    itemsToAdd.Add(new Item("Toadflax seed", "A toadflax seed - plant in an herb patch. (30)", "seedToadflax", Color.Green, 34, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyToadflax",
                        UseInt = 30 /* Level */,  UseInt2 = 70 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy toadflax", "It needs cleaning.", "herbGrimyToadflax", Color.Green.GetDark(), 25) { UseString = "CleanHerb", UseString2 = "herbCleanToadflax", UseInt = 30, UseInt2 = 8 }); 
                    itemsToAdd.Add(new Item("Toadflax", "A fresh herb.", "herbCleanToadflax", Color.Green, 25));

                    // Spirit weed
                    itemsToAdd.Add(new Item("Spirit weed seed", "A spirit weed seed - plant in an herb patch. (35)", "seedSpiritweed", Color.LawnGreen, 18, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimySpiritWeed",
                        UseInt = 35 /* Level */,  UseInt2 = 80 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy spirit weed", "It needs cleaning.", "herbGrimySpiritWeed", Color.LawnGreen.GetDark(), 25) { UseString = "CleanHerb", UseString2 = "herbCleanSpiritWeed", UseInt = 35, UseInt2 = 9 }); 
                    itemsToAdd.Add(new Item("Spirit weed", "A fresh herb.", "herbCleanSpiritWeed", Color.LawnGreen, 25));

                    // Irit
                    itemsToAdd.Add(new Item("Irit seed", "An irit seed - plant in an herb patch. (40)", "seedIrit", Color.LawnGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyIrit",
                        UseInt = 40 /* Level */,  UseInt2 = 90 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy irit", "It needs cleaning.", "herbGrimyIrit", Color.Lime.GetDark(), 40) { UseString = "CleanHerb", UseString2 = "herbCleanIrit", UseInt = 40, UseInt2 = 9 }); 
                    itemsToAdd.Add(new Item("Irit", "A fresh herb.", "herbCleanIrit", Color.Lime, 40));

                    // Wergali
                    itemsToAdd.Add(new Item("Wergali seed", "A wergali seed - plant in an herb patch. (41)", "seedWergali", Color.Crimson, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyWergali",
                        UseInt = 41 /* Level */,  UseInt2 = 100 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy wergali", "It needs cleaning.", "herbGrimyWergali", Color.Crimson.GetDark(), 44) { UseString = "CleanHerb", UseString2 = "herbCleanWergali", UseInt = 41, UseInt2 = 9 }); 
                    itemsToAdd.Add(new Item("Wergali", "A fresh herb.", "herbCleanWergali", Color.Crimson, 44));

                    // Avantoe
                    itemsToAdd.Add(new Item("Avantoe seed", "A avantoe seed - plant in an herb patch. (48)", "seedAvantoe", Color.SpringGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyAvantoe",
                        UseInt = 48 /* Level */,  UseInt2 = 110 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy avantoe", "It needs cleaning.", "herbGrimyAvantoe", Color.SpringGreen.GetDark(), 48) { UseString = "CleanHerb", UseString2 = "herbCleanAvantoe", UseInt = 48, UseInt2 = 10 }); 
                    itemsToAdd.Add(new Item("Avantoe", "A fresh herb.", "herbCleanAvantoe", Color.SpringGreen, 48));

                    // Kwuarm
                    itemsToAdd.Add(new Item("Kwuarm seed", "A kwuarm seed - plant in an herb patch. (54)", "seedKwuarm", Color.Olive, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyKwuarm",
                        UseInt = 54 /* Level */,  UseInt2 = 120 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy kwuarm", "It needs cleaning.", "herbGrimyKwuarm", Color.Olive.GetDark(), 48) { UseString = "CleanHerb", UseString2 = "herbCleanKwuarm", UseInt = 54, UseInt2 = 11 }); 
                    itemsToAdd.Add(new Item("Kwuarm", "A fresh herb.", "herbCleanKwuarm", Color.Olive, 48));

                    // Bloodweed
                    itemsToAdd.Add(new Item("Bloodweed seed", "A bloodweed seed - plant in an herb patch. (57)", "seedBloodweed", Color.Crimson, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyBloodweed",
                        UseInt = 57 /* Level */,  UseInt2 = 130 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy bloodweed", "It needs cleaning.", "herbGrimyBloodweed", Color.Crimson.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanBloodweed", UseInt = 57, UseInt2 = 12 }); 
                    itemsToAdd.Add(new Item("Bloodweed", "A fresh herb.", "herbCleanBloodweed", Color.Crimson, 100));

                    // Snapdragon
                    itemsToAdd.Add(new Item("Snapdragon seed", "A snapdragon seed - plant in an herb patch. (59)", "seedSnapdragon", Color.Orange, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimySnapdragon",
                        UseInt = 59 /* Level */,  UseInt2 = 150 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy snapdragon", "It needs cleaning.", "herbGrimySnapdragon", Color.Orange.GetDark(), 60) { UseString = "CleanHerb", UseString2 = "herbCleanSnapdragon", UseInt = 59, UseInt2 = 12 }); 
                    itemsToAdd.Add(new Item("Snapdragon", "A fresh herb.", "herbCleanSnapdragon", Color.Orange, 60));

                    // Cadantine
                    itemsToAdd.Add(new Item("Cadantine seed", "A cadantine seed - plant in an herb patch. (65)", "seedCadantine", Color.YellowGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyCadantine",
                        UseInt = 65 /* Level */,  UseInt2 = 180 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy cadantine", "It needs cleaning.", "herbGrimyCadantine", Color.YellowGreen.GetDark(), 65) { UseString = "CleanHerb", UseString2 = "herbCleanCadantine", UseInt = 65, UseInt2 = 13 }); 
                    itemsToAdd.Add(new Item("Cadantine", "A fresh herb.", "herbCleanCadantine", Color.YellowGreen, 65));

                    // Lantadyme
                    itemsToAdd.Add(new Item("Lantadyme seed", "A lantadyme seed - plant in an herb patch. (67)", "seedLantadyme", Color.Teal, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyLantadyme",
                        UseInt = 67 /* Level */,  UseInt2 = 220 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy lantadyme", "It needs cleaning.", "herbGrimyLantadyme", Color.Teal.GetDark(), 70) { UseString = "CleanHerb", UseString2 = "herbCleanLantadyme", UseInt = 67, UseInt2 = 13 }); 
                    itemsToAdd.Add(new Item("Lantadyme", "A fresh herb.", "herbCleanLantadyme", Color.Teal, 70));

                    // Dwarf weed
                    itemsToAdd.Add(new Item("Dwarf weed seed", "A dwarf weed seed - plant in an herb patch. (70)", "seedDwarfweed", Color.ForestGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyDwarfweed",
                        UseInt = 70 /* Level */,  UseInt2 = 220 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy dwarf weed", "It needs cleaning.", "herbGrimyDwarfweed", Color.ForestGreen.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanDwarfweed", UseInt = 70, UseInt2 = 14 }); 
                    itemsToAdd.Add(new Item("Dwarf weed", "A fresh herb.", "herbCleanDwarfweed", Color.ForestGreen, 150));

                    // Torstol
                    itemsToAdd.Add(new Item("Torstol seed", "A torstol seed - plant in an herb patch. (75)", "seedTorstol", Color.DarkGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyTorstol",
                        UseInt = 75 /* Level */,  UseInt2 = 270 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy torstol", "It needs cleaning.", "herbGrimyTorstol", Color.DarkGreen.GetDark(), 75) { UseString = "CleanHerb", UseString2 = "herbCleanTorstol", UseInt = 75, UseInt2 = 15 }); 
                    itemsToAdd.Add(new Item("Torstol", "A fresh herb.", "herbCleanTorstol", Color.DarkGreen, 75));

                    // Arbuck
                    itemsToAdd.Add(new Item("Arbuck seed", "An arbuck seed - plant in an herb patch. (77)", "seedArbuck", Color.Orange, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyArbuck",
                        UseInt = 77 /* Level */,  UseInt2 = 350 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy arbuck", "It needs cleaning.", "herbGrimyArbuck", Color.Orange.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanArbuck", UseInt = 77, UseInt2 = 14 }); 
                    itemsToAdd.Add(new Item("Arbuck", "A fresh herb.", "herbCleanArbuck", Color.Orange, 150));

                    // Fellstalk
                    itemsToAdd.Add(new Item("Fellstalk seed", "A fellstalk seed - plant in an herb patch. (91)", "seedFellstalk", Color.AntiqueWhite, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyFellstalk",
                        UseInt = 91 /* Level */,  UseInt2 = 500 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy fellstalk", "It needs cleaning.", "herbGrimyFellstalk", Color.AntiqueWhite.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanFellstalk", UseInt = 91, UseInt2 = 17 }); 
                    itemsToAdd.Add(new Item("Fellstalk", "A fresh herb.", "herbCleanFellstalk", Color.AntiqueWhite, 150));
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
                    itemsToAdd.Add(new Item("Banana", "Mmm banana.", "fruitBanana", Color.Yellow, 10));

                    // Orange Tree
                    itemsToAdd.Add(new Item("Orange tree seed", "An orange tree seed - use on a plant pot to make a sapling. (39)", "seedTreeOrange", Color.AntiqueWhite, 30, true));
                    itemsToAdd.Add(new Item("Plant pot (orange)", "An orange tree sapling in a pot. Plant in a fruit tree patch. (39)", "plantPotOrange", Color.AntiqueWhite, 30) {
                        UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitOrange",
                        UseInt = 39 /* Level */,  UseInt2 = 600 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                    });
                    itemsToAdd.Add(new Item("Orange", "A common fruit.", "fruitOrange", Color.MonoGameOrange, 70));

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

                    // Papaya Tree
                    itemsToAdd.Add(new Item("Papaya tree seed", "A papaya tree seed - use on a plant pot to make a sapling. (57)", "seedTreePapaya", Color.DimGray, 120, true));
                    itemsToAdd.Add(new Item("Plant pot (papaya)", "A papaya tree sapling in a pot. Plant in a fruit tree patch. (57)", "plantPotPapaya", Color.DimGray, 120) {
                        UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitPapaya",
                        UseInt = 57 /* Level */,  UseInt2 = 750 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                    });
                    itemsToAdd.Add(new Item("Papaya", "Papaya, papaya, pa-paya-paya!", "fruitPapaya", Color.YellowGreen, 64));

                    // Palm Tree
                    itemsToAdd.Add(new Item("Palm tree seed", "A palm tree seed - use on a plant pot to make a sapling. (68)", "seedTreePalm", Color.Wheat, 250, true));
                    itemsToAdd.Add(new Item("Plant pot (coconut)", "A palm tree sapling in a pot. Plant in a fruit tree patch. (68)", "plantPotPalm", Color.Wheat, 250) {
                        UseString = "PlantSeed", UseString2 = "Fruit Tree", UseString3 = "fruitCoconut",
                        UseInt = 68 /* Level */,  UseInt2 = 800 /* Exp On Harvest */, UseInt3 = 57600 /* Growth time in seconds */, UseInt4 = 2400 /* Regrowth time in seconds */
                    });
                    itemsToAdd.Add(new Item("Coconut", "It's a coconut.", "fruitCoconut", Color.SaddleBrown, 90));
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
            }

            // Crafting - Clay
            itemsToAdd.Add(new Item("Clay dust", "Some hard dry clay.", "clayDust", 207, 185, 151, 1));
            itemsToAdd.Add(new Item("Soft clay", "Clay soft enough to mould.", "claySoft", 205, 127, 50, 2));
            itemsToAdd.Add(new Item("Unfired pot", "I need to put this in a pottery kiln.", "unfiredPot", 205, 127, 50, 1));
            itemsToAdd.Add(new Item("Unfired cup", "I need to put this in a pottery kiln.", "unfiredCup", 205, 127, 50, 2));
            itemsToAdd.Add(new Item("Unfired pie dish", "I need to put this in a pottery kiln.", "unfiredPieDish", 205, 127, 50, 3));
            itemsToAdd.Add(new Item("Unfired bowl", "I need to put this in a pottery kiln.", "unfiredBowl", 205, 127, 50, 2));
            itemsToAdd.Add(new Item("Unfired plant pot", "I need to put this in a pottery kiln.", "unfiredPlantPot", 205, 127, 50, 1));
            itemsToAdd.Add(new Item("Unfired pot lid", "I need to put this in a pottery kiln.", "unfiredPotLid", 205, 127, 50, 10));
            itemsToAdd.Add(new Item("Pot", "This pot is empty.", "potEmpty", 207, 185, 151, 1));
            itemsToAdd.Add(new Item("Empty cup", "An empty cup.", "cupEmpty", 255, 255, 255, 2));
            itemsToAdd.Add(new Item("Pie dish", "Deceptively pie shaped.", "pieEmpty", 207, 185, 151, 3));
            itemsToAdd.Add(new Item("Bowl", "Useful for mixing things.", "bowlEmpty", 207, 185, 151, 4));
            itemsToAdd.Add(new Item("Empty plant pot", "An empty plant pot.", "plantPotEmpty", 207, 185, 151, 1) { UseString = "FillPot" });
            itemsToAdd.Add(new Item("Pot lid", "This should fit on a normal-sized pot.", "potLid", 207, 185, 151, 15));
            itemsToAdd.Add(new Item("Airtight pot", "This is pretty well sealed.", "potAirtight", 207, 185, 151, 10));


            itemsToAdd.Add(new Item("Grain", "Some wheat hands.", "grain", 207, 185, 151, 2));
            itemsToAdd.Add(new Item("Flax", "I should use this with a spinning wheel.", "flax", 189, 246, 254, 5));
            itemsToAdd.Add(new Item("Bow string", "I need a bow stave to attach this to.", "bowstring", 207, 185, 151, 10));
              

            // Ranged Armor Factory
            List<MaterialDef> Leathers = new() {
                new("Leather", 205, 127, 50, 255, 1, 1, 20, "minimal"), 
                new("Hardleather", 175, 97, 20, 255, 2, 10, 40, "slight"), 
                new("Studded", 175, 97, 20, 255, 3, 20, 110, "adequate"), 
                new("Snakeskin", 105, 97, 18, 255, 4, 30, 200, "decent"), 
                new("Green dragonhide", 34, 140, 34, 255, 5, 40, 500, "good")
            };

             for (int i = 0; i < Leathers.Count; i++) {
                int fullMult = Leathers[i].CostMultiplier;

                Item coif = new Item(Leathers[i].Name + " coif", "Provides " + Leathers[i].Descriptor + " ranged protection for the head.", "coif" + Leathers[i].Name, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 2) {
                    EquipSlot = "Head",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(coif);

                Item body = new Item(Leathers[i].Name + " body", "Provides " + Leathers[i].Descriptor + " ranged protection for the torso.", "body" + Leathers[i].Name, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(body);

                Item chaps = new Item(Leathers[i].Name + " chaps", "Provides " + Leathers[i].Descriptor + " ranged protection for the legs.", "chaps" + Leathers[i].Name, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(chaps);

                Item boots = new Item(Leathers[i].Name + " boots", "Provides " + Leathers[i].Descriptor + " ranged protection for the feet.", "boots" + Leathers[i].Name, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult) {
                    EquipSlot = "Feet",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(boots);

                Item vambraces = new Item(Leathers[i].Name + " vambraces", "Provides " + Leathers[i].Descriptor + " ranged protection for the hands.", "vambraces" + Leathers[i].Name, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult) {
                    EquipSlot = "Hands",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(vambraces);
            }
            ////
            
            itemsToAdd.Add(new Item("Air talisman", "A mysterious power emanates from the talisman...", "talismanAir", 200, 200, 200, 4));
            itemsToAdd.Add(new Item("Mind talisman", "A mysterious power emanates from the talisman...", "talismanMind", 231, 60, 0, 4)); 
            itemsToAdd.Add(new Item("Earth talisman", "A mysterious power emanates from the talisman...", "talismanEarth", Color.SaddleBrown, 4)); 
            itemsToAdd.Add(new Item("Fire talisman", "A mysterious power emanates from the talisman...", "talismanFire", Color.Firebrick, 4)); 
            itemsToAdd.Add(new Item("Water talisman", "A mysterious power emanates from the talisman...", "talismanWater", Color.CadetBlue, 4)); 

            itemsToAdd.Add(new Item("Pure essence", "An unimbued rune.", "pureEssence", 200, 200, 200, 4));
            itemsToAdd.Add(new Item("Air rune", "One of the 4 basic elemental runes.", "runeAir", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Earth rune", "One of the 4 basic elemental runes.", "runeEarth", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Fire rune", "One of the 4 basic elemental runes.", "runeFire", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Water rune", "One of the 4 basic elemental runes.", "runeWater", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Mind rune", "Used for basic level missile spells.", "runeMind", 200, 200, 200, 3, true, true));
            itemsToAdd.Add(new Item("Body rune", "Used for curse spells.", "runeBody", 200, 200, 200, 3, true, true));
            itemsToAdd.Add(new Item("Chaos rune", "Used for low level missile spells.", "runeChaos", 200, 200, 200, 90, true, true));
            itemsToAdd.Add(new Item("Law rune", "Used for teleport spells.", "runeLaw", 200, 200, 200, 240, true, true));


            itemsToAdd.Add(new Item("Staff of air", "A magical staff. Provides unlimited air runes.", "staffAir", 255, 255, 255, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", MiscString = "CountsAs", UseString2 = "runeAir", UseInt = -1, TwoHanded = true, MustBeEquipped = true
            });

            itemsToAdd.Add(new Item("Staff of water", "A magical staff. Provides unlimited water runes.", "staffWater", 30, 144, 255, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", MiscString = "CountsAs", UseString2 = "runeWater", UseInt = -1, TwoHanded = true, MustBeEquipped = true
            }); 

            itemsToAdd.Add(new Item("Staff of earth", "A magical staff. Provides unlimited earth runes.", "staffEarth", 165, 42, 42, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", MiscString = "CountsAs", UseString2 = "runeEarth", UseInt = -1, TwoHanded = true, MustBeEquipped = true
            }); 

            itemsToAdd.Add(new Item("Staff of fire", "A magical staff. Provides unlimited fire runes.", "staffFire", 220, 20, 60, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", MiscString = "CountsAs", UseString2 = "runeFire", UseInt = -1, TwoHanded = true, MustBeEquipped = true
            });


            // Pickpocket Loot
            itemsToAdd.Add(new Item("Small coin pouch", "Has a few coins in it.", "coinPouchSmall", 111, 66, 33, 5, true, true) { UseString = "GetGold", UseInt = 5 });
            itemsToAdd.Add(new Item("Medium coin pouch", "Has a few more coins in it.", "coinPouchMedium", 111, 66, 33, 5, true, true) { UseString = "GetGold", UseInt = 20 });

            itemsToAdd.Add(new Item("Seed pouch (farmer)", "A small bag of seeds that a farmer had in his pocket.", "seedPouchFarmer", 111, 66, 33, 0, true, false) {
                UseString = "SeedPouch",
                DropTable = {
                    new ItemDrop("seedBarley", 1, 25, 1, 4),
                    new ItemDrop("seedHammerstone", 1, 26, 1, 4),
                    new ItemDrop("seedPotato", 1, 28, 1, 3),
                    new ItemDrop("seedOnion", 1, 32, 1, 3),
                    new ItemDrop("seedAsgarnian", 1, 32, 1, 4),
                    new ItemDrop("seedCabbage", 1, 35, 1, 3),
                    new ItemDrop("seedYanillian", 1, 42, 1, 4),
                    new ItemDrop("seedTomato", 1, 46, 1, 3),
                    new ItemDrop("seedJute", 1, 46, 1, 3),
                    new ItemDrop("seedSweetcorn", 1, 60, 1, 3),
                    new ItemDrop("seedMarigold", 1, 60, 1, 1),
                    new ItemDrop("seedKrandorian", 1, 60, 1, 4),
                    new ItemDrop("seedStrawberry", 1, 70, 1, 3),
                    new ItemDrop("seedTreePine", 1, 70, 1, 1),
                    new ItemDrop("seedGuam", 1, 70, 1, 1),
                    new ItemDrop("seedRedberry", 1, 84, 1, 1),
                    new ItemDrop("seedRosemary", 1, 84, 1, 1),
                    new ItemDrop("seedMarrentill", 1, 84, 1, 1),
                    new ItemDrop("seedTarromin", 1, 84, 1, 1),
                    new ItemDrop("seedWildblood", 1, 84, 1, 4),
                    new ItemDrop("seedCadava", 1, 105, 1, 1),
                    new ItemDrop("seedNasturtium", 1, 105, 1, 1),
                    new ItemDrop("seedWoad", 1, 105, 1, 1),
                    new ItemDrop("seedTreeOak", 1, 105, 1, 1),
                    new ItemDrop("seedLimpwurt", 1, 139, 1, 1),
                    new ItemDrop("seedTreeApple", 1, 139, 1, 1),
                    new ItemDrop("seedHarralander", 1, 139, 1, 1),
                    new ItemDrop("seedTreeWillow", 1, 139, 1, 1),
                    new ItemDrop("seedDwellberry", 1, 209, 1, 1),
                    new ItemDrop("seedTreeTeak", 1, 209, 1, 1),
                    new ItemDrop("seedTreeBanana", 1, 209, 1, 1),
                    new ItemDrop("seedRanarr", 1, 209, 1, 1), 
                    new ItemDrop("seedTreeMaple", 1, 418, 1, 1),
                    new ItemDrop("seedTreeOrange", 1, 418, 1, 1),
                    new ItemDrop("seedSpiritweed", 1, 418, 1, 1),
                    new ItemDrop("seedToadflax", 1, 418, 1, 1)
                }
            });





            itemsToAdd.Add(new Item("Slayer gem", "A pretty blue gem that can tell you your current slayer task.", "gemSlayer", 102, 205, 170, 1) { UseString = "SlayerGem", ConsumedOnUse = false });
            
            itemsToAdd.Add(new Item("Bones", "The remains of some creature or person.", "bonesRegular", 255, 255, 255, 1, false, true) { UseString = "Bones", UseInt = 5 });
            itemsToAdd.Add(new Item("Big bones", "The remains of some huge creature or person.", "bonesBig", 255, 255, 255, 1, false, true) { UseString = "Bones", UseInt = 15 });
            
            itemsToAdd.Add(new Item("Fiendish ashes", "A heap of ashes.", "ashesFiendish", 122, 104, 127, 1, false) { UseString = "Ashes", UseInt = 10 });
            

            itemsToAdd.Add(new Item("Raw newt meat", "A cut of meat taken from a newt.", "meatRawNewt", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Cooked newt meat", "A cooked newt steak.", "meatCookedNewt", 150, 100, 50, 4) { UseString = "Heal", UseInt = 3 }); 
            itemsToAdd.Add(new Item("Raw beef", "A cut of meat taken from a cow.", "meatRawBeef", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Raw rat meat", "A cut of meat taken from a rat.", "meatRawRat", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Cooked steak", "A cooked steak.", "meatCookedBeef", 150, 100, 50, 4) { UseString = "Heal", UseInt = 3 }); 
            itemsToAdd.Add(new Item("Raw chicken", "A whole chicken, currently very inedible.", "meatRawChicken", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Cooked chicken", "A cooked chicken.", "meatCookedChicken", 150, 100, 50, 4) { UseString = "Heal", UseInt = 3 }); 
            itemsToAdd.Add(new Item("Raw bird meat", "This certainly needs cooking!", "meatRawBird", 138, 3, 3, 15));
            itemsToAdd.Add(new Item("Roast bird meat", "A nicely roasted bird.", "meatCookedBird", 150, 100, 50, 4) { UseString = "Heal", UseInt = 5 }); 
            itemsToAdd.Add(new Item("Raw shrimps", "A few raw shrimp.", "fishRawShrimp", 138, 3, 3, 5));
            itemsToAdd.Add(new Item("Cooked shrimps", "Some cooked shrimp.", "fishCookedShrimp", 150, 100, 50, 5) { UseString = "Heal", UseInt = 3 }); 
            itemsToAdd.Add(new Item("Raw anchovies", "A few raw anchovies.", "fishRawAnchovies", 173, 216, 230, 15));
            itemsToAdd.Add(new Item("Cooked anchovies", "Some cooked anchovies.", "fishCookedAnchovies", 143, 186, 200, 15) { UseString = "Heal", UseInt = 1 });
            itemsToAdd.Add(new Item("Raw sardine", "I should try cooking this.", "fishRawSardine", 50, 205, 50, 10));
            itemsToAdd.Add(new Item("Cooked sardine", "Some nicely cooked sardines.", "fishCookedSardine", 30, 185, 30, 10) { UseString = "Heal", UseInt = 4 }); 
            itemsToAdd.Add(new Item("Raw herring", "I should try cooking this.", "fishRawHerring", 255, 255, 255, 10));
            itemsToAdd.Add(new Item("Cooked herring", "Some nicely cooked herring.", "fishCookedHerring", 178, 144, 144, 10) { UseString = "Heal", UseInt = 5 }); 
            itemsToAdd.Add(new Item("Raw pike", "I should try cooking this.", "fishRawPike", 50, 205, 50, 20));
            itemsToAdd.Add(new Item("Cooked pike", "Some nicely cooked pike.", "fishCookedPike", 30, 185, 30, 20) { UseString = "Heal", UseInt = 8 }); 
            itemsToAdd.Add(new Item("Raw trout", "I should try cooking this.", "fishRawTrout", 255, 255, 255, 10));
            itemsToAdd.Add(new Item("Cooked trout", "Some nicely cooked trout.", "fishCookedTrout", 178, 144, 144, 10) { UseString = "Heal", UseInt = 7 }); 
            itemsToAdd.Add(new Item("Raw salmon", "I should try cooking this.", "fishRawSalmon", 255, 20, 147, 30));
            itemsToAdd.Add(new Item("Cooked salmon", "Some nicely cooked salmon.", "fishCookedSalmon", 255, 165, 0, 30) { UseString = "Heal", UseInt = 9 }); 
            itemsToAdd.Add(new Item("Raw lobster", "I should try cooking this.", "fishRawLobster", 255, 140, 0, 70));
            itemsToAdd.Add(new Item("Cooked lobster", "This looks tricky to eat.", "fishCookedLobster", 255, 165, 0, 70) { UseString = "Heal", UseInt = 12 }); 
            itemsToAdd.Add(new Item("Raw tuna", "I should try cooking this.", "fishRawTuna", 255, 255, 255, 40));
            itemsToAdd.Add(new Item("Cooked tuna", "Wow, this is a big fish.", "fishCookedTuna", 178, 144, 144, 40) { UseString = "Heal", UseInt = 10 });
            itemsToAdd.Add(new Item("Raw swordfish", "I should try cooking this.", "fishRawSwordfish", 147, 112, 219, 80));
            itemsToAdd.Add(new Item("Cooked swordfish", "I'd better be careful eating this!", "fishCookedSwordfish", 117, 82, 189, 80) { UseString = "Heal", UseInt = 14 }); 
            itemsToAdd.Add(new Item("Raw bass", "I should try cooking this.", "fishRawBass", 255, 20, 147, 40));
            itemsToAdd.Add(new Item("Cooked bass", "Wow, this is a big fish.", "fishCookedBass", 255, 165, 0, 40) { UseString = "Heal", UseInt = 13 });
            itemsToAdd.Add(new Item("Raw cod", "I should try cooking this.", "fishRawCod", 173, 216, 230, 10));
            itemsToAdd.Add(new Item("Cooked cod", "Some nicely cooked cod.", "fishCookedCod", 143, 186, 200, 10) { UseString = "Heal", UseInt = 7 });
            itemsToAdd.Add(new Item("Raw mackerel", "I should try cooking this.", "fishRawMackerel", 255, 255, 0, 15));
            itemsToAdd.Add(new Item("Cooked mackerel", "Some nicely cooked mackerel.", "fishCookedMackerel", 218, 165, 32, 15) { UseString = "Heal", UseInt = 6 });  
             
            itemsToAdd.Add(new Item("Beer glass", "I need to fill this with beer.", "beerGlass", 200, 200, 200, 2));
            itemsToAdd.Add(new Item("Beer", "A glass of frothy ale.", "beer", 255, 255, 0, 2) { UseString = "Potion", UseInt4 = 1, Potion = new() { new("Heal", 1), new("Attack", -2), new("Strength", 2) } });
            
            itemsToAdd.Add(new Item("Garlic", "Deters vampires.", "garlic", Color.AntiqueWhite, 3));
            
            itemsToAdd.Add(new Item("Pot of flour", "A pot full of flour.", "potFlour", 207, 185, 151, 10));
            itemsToAdd.Add(new Item("Bread dough", "Some uncooked dough.", "doughBread", 221, 199, 160, 4));
            itemsToAdd.Add(new Item("Bread", "Nice crispy bread.", "bread", 233, 185, 93, 12) { UseString = "Heal", UseInt = 5 });
            itemsToAdd.Add(new Item("Egg", "An egg from a chicken. Could be fried or scrambled, perhaps.", "eggChicken", 233, 185, 93, 4));
            itemsToAdd.Add(new Item("Cake", "A plain sponge cake.", "cake", 255, 255, 255, 50) { UseString = "Heal", UseInt = 9 });
            itemsToAdd.Add(new Item("Chocolate cake", "This looks very tasty.", "cakeChocolate", Color.Brown, 70) { UseString = "Heal", UseInt = 15 });
            itemsToAdd.Add(new Item("Chocolate cake (2/3)", "This looks very tasty.", "cakeChocolate1", Color.Brown, 45) { UseString = "Heal", UseInt = 10 });
            itemsToAdd.Add(new Item("Chocolate cake slice", "I'd rather have a full cake.", "cakeChocolate2", Color.Brown, 20) { UseString = "Heal", UseInt = 5 });


            itemsToAdd.Add(new Item("Empty bucket", "An empty bucket. Could probably hold something.", "bucketEmpty", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Bucket of water", "A bucket filled with water.", "bucketWater", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Bucket of milk", "A bucket filled with milk.", "bucketMilk", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Empty jug", "An empty jug. Could probably hold something.", "jugEmpty", 200, 200, 200, 1));
            itemsToAdd.Add(new Item("Jug of water", "A jug filled with water.", "jugWater", 200, 200, 200, 1));
            itemsToAdd.Add(new Item("Jug of wine", "A jug filled with wine.", "jugWine", 200, 200, 200, 100) { UseString = "Potion", UseInt4 = 1, Potion = new() { new("Attack", -2), new("Heal", 11) } });
            itemsToAdd.Add(new Item("Bottle of wine", "A very good vintage.", "bottleWine", Color.IndianRed, 500) { UseString = "Potion", UseInt4 = 1, Potion = new() { new("Attack", -3), new("Heal", 14) } });
            itemsToAdd.Add(new Item("Bowl of water", "A bowl filled with water.", "bowlWater", 207, 185, 151, 4));
            itemsToAdd.Add(new Item("Cake tin", "Useful for baking cakes.", "tinCakeEmpty", 100, 100, 100, 10));
            itemsToAdd.Add(new Item("Cake tin (egg)", "A cake tin with an egg cracked into it. Needs flour and milk.", "tinCakeEgg", 100, 100, 100, 13));
            itemsToAdd.Add(new Item("Cake tin (egg, flour)", "A cake tin with an egg and some flour. Still needs milk.", "tinCakeFlour", 100, 100, 100, 16));
            itemsToAdd.Add(new Item("Cake tin (batter)", "A tin full of cake batter, ready for cooking.", "tinCakeBatter", 100, 100, 100, 20));

            
            itemsToAdd.Add(new Item("Copper ore", "A pile of copper ore nuggets.", "oreCopper", Color.Orange, 3));
            itemsToAdd.Add(new Item("Tin ore", "A pile of tin ore nuggets.", "oreTin", Color.DarkGray, 3)); 
            itemsToAdd.Add(new Item("Bronze ore mix", "A mix of copper and tin ore nuggets.", "oreMixBronze", ColorLib.Bronze, 6)); 
            itemsToAdd.Add(new Item("Bronze bar", "It's a bar of bronze.", "barBronze", ColorLib.Bronze, 8));
            itemsToAdd.Add(new Item("Iron ore", "A pile of iron ore nuggets.", "oreIron", ColorLib.Bronze, 15)); 
            itemsToAdd.Add(new Item("Iron ore mix", "A mix iron ore nuggets with the impurities sifted out.", "oreMixIron", ColorLib.Bronze, 25)); 
            itemsToAdd.Add(new Item("Iron bar", "It's a bar of iron.", "barIron", ColorLib.Iron, 30));
            itemsToAdd.Add(new Item("Coal", "A lump of raw coal.", "oreCoal", Color.DimGray, 30)); 
            itemsToAdd.Add(new Item("Steel ore mix", "A mix of iron ore nuggets and coal.", "oreMixSteel", ColorLib.Bronze, 45)); 
            itemsToAdd.Add(new Item("Steel bar", "It's a bar of iron.", "barSteel", ColorLib.Steel, 60)); 
            itemsToAdd.Add(new Item("Mithril ore", "A pile of mithril ore nuggets.", "oreMithril", ColorLib.Mithril, 60)); 
            itemsToAdd.Add(new Item("Mithril ore mix", "A mix of mithril ore nuggets and coal.", "oreMixMithril", ColorLib.Mithril, 90)); 
            itemsToAdd.Add(new Item("Mithril bar", "It's a bar of mithril.", "barMithril", ColorLib.Mithril, 120));
            itemsToAdd.Add(new Item("Luminite", "A lump of raw luminite.", "oreLuminite", Color.Yellow, 60));  
            itemsToAdd.Add(new Item("Adamant ore", "A pile of adamant ore nuggets.", "oreAdamant", ColorLib.Adamant, 120)); 
            itemsToAdd.Add(new Item("Adamant ore mix", "A mix of adamant ore nuggets and luminite.", "oreMixAdamant", ColorLib.Adamant, 180)); 
            itemsToAdd.Add(new Item("Adamant bar", "It's a bar of adamant.", "barAdamant", ColorLib.Adamant, 240));

            // Smithing Factory
            List<MaterialDef> Metals = new() {
                new("Tutorial", Color.White, 2, 1, 1000, "slight"), 
                new("Bronze", ColorLib.Bronze, 1, 1, 15, "minimal"), 
                new("Iron", ColorLib.Iron, 2, 10, 45, "slight"), 
                new("Steel", ColorLib.Steel, 3, 20, 90, "adequate"), 
                new("Mithril", ColorLib.Mithril, 4, 30, 180, "good"), 
                new("Adamant", ColorLib.Adamant, 3, 40, 360, "great")
            }; 

            for (int i = 0; i < Metals.Count; i++) {
                int fullMult = Metals[i].CostMultiplier;

                Item helm = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head.", "helm" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(helm);

                Item platebody = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso.", "platebody" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(platebody);

                Item platelegs = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs.", "platelegs" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(platelegs);

                Item boots = new Item(Metals[i].Name + " boots", "Provides " + Metals[i].Descriptor + " melee protection for the feet.", "boots" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Feet",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(boots);

                Item gauntlets = new Item(Metals[i].Name + " gauntlets", "Provides " + Metals[i].Descriptor + " melee protection for the hands.", "gauntlets" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Hands",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(gauntlets);

                Item arrows = new Item(Metals[i].Name + " arrows", "Time flies like an arrow. Fruit flies like a banana.", "arrows" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true) {
                    EquipSlot = "Ammo",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedStandard"
                };
                itemsToAdd.Add(arrows);

                Item unfbolts = new Item(Metals[i].Name + " bolts (unf)", Metals[i].Name + " crossbow bolts, sans feathers.", "boltsUnf" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true);
                itemsToAdd.Add(unfbolts);

                Item bolts = new Item(Metals[i].Name + " bolts", Metals[i].Name + " crossbow bolts.", "bolts" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true) {
                    EquipSlot = "Ammo",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedHeavy"
                };
                itemsToAdd.Add(bolts);

                Item knives = new Item(Metals[i].Name + " knives", "A finely balanced throwing knife.", "knives" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 5, true) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedLight", EquipAmmo = "Self"
                };
                itemsToAdd.Add(knives);

                Item arrowheads = new Item(Metals[i].Name + " arrowheads", "I can make some arrows with these.", "arrowheads" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true);
                itemsToAdd.Add(arrowheads);

                Item hatchet = new Item(Metals[i].Name + " hatchet", "Good for chopping trees.", "hatchet" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult, misc: "Hatchet") {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash"
                };
                itemsToAdd.Add(hatchet);

                Item pickaxe = new Item(Metals[i].Name + " pickaxe", "Good for mining.", "pickaxe" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult, misc: "Pickaxe") {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab", AttackSpeed = 1.5
                };
                itemsToAdd.Add(pickaxe);

                Item dagger = new Item(Metals[i].Name + " dagger", "Good for stabbing.", "dagger" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab"
                };
                itemsToAdd.Add(dagger);

                Item sword = new Item(Metals[i].Name + " sword", "Good for slashing.", "sword" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash"
                };
                itemsToAdd.Add(sword);

                Item mace = new Item(Metals[i].Name + " mace", "Good for crushing.", "mace" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Crush"
                };
                itemsToAdd.Add(mace);

                 Item scimitar = new Item(Metals[i].Name + " scimitar", "Good for slashing.", "scimitar" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash", AttackSpeed = 0.75
                };
                itemsToAdd.Add(scimitar);

                Item battleaxe = new Item(Metals[i].Name + " battleaxe", "Powerful slashes but slow.", "battleaxe" + Metals[i].Name, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash", AttackSpeed = 1.5, TwoHanded = true
                };
                itemsToAdd.Add(battleaxe);
            }
             
            itemsToAdd.Add(new Item("Huge club", "Upon closer inspection this is actually a huge femur.", "clubHuge", 255, 255, 255, 1000) {
                EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 10, EquipDamageType = "Crush", AttackSpeed = 1.5
            });itemsToAdd.Add(new Item("Huger club", "Where did that zombie even get such a large bone? You can barely move this thing.", "clubHuger", 255, 255, 255, 5000) {
                EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Attack", EquipLevel = 10, EquipDamageType = "Crush", AttackSpeed = 3
            });  
            itemsToAdd.Add(new Item("Baby zombie plush", "Despite being a zombie, kinda cute? It even has a little chicken that it's riding on.", "petBabyZombie", 34, 140, 34, 1000) {
                EquipSlot = "Pet",  Cosmetic = true, PetBlurbs = new() { "The baby zombie gurgles a bit.", "The zombie's chicken clucks loudly.", "The baby zombie runs in a small circle quickly.", "CHICKEN JOCKEY!"}
            });  
            itemsToAdd.Add(new Item("Rotten flesh", "This doesn't really seem edible...", "fleshRotten", 150, 100, 50, 4) { UseString = "Heal", UseInt = 2, Potion = new() { new("Attack", -3) } });
            
            
            
            itemsToAdd.Add(new Item("Eye of newt", "A basic herblore ingredient and only slightly gross.", "eyeNewt", 255, 255, 255, 3));
            itemsToAdd.Add(new Item("Vial", "A glass vial, currently empty.", "vialEmpty", 200, 200, 200, 2) { colA = 150 });
            itemsToAdd.Add(new Item("Vial of water", "A glass vial full of water.", "vialWater", 14, 129, 205, 2) { colA = 150 });
            itemsToAdd.Add(new Item("Guam potion (unf)", "I need another ingredient to finish this Guam potion.", "potionUnfGuam", 0, 128, 128, 3) { colA = 150 });
            itemsToAdd.Add(new Item("Attack potion", "Temporarily boosts your Attack level by 5.", "potionAttack", 0, 255, 255, 15) { UseString = "Potion", UseInt4 = 3, Potion = new() { new("Attack", 5) } });


            itemsToAdd.Add(new Item("Rusted sword [Q]", "The sword is useless now. You notice someone has scratched something into the handle: 'PlayerOne'.", "TI_HI_RustedSword", 205, 127, 50, 0, trade: false));
            itemsToAdd.Add(new Item("Crumpled note [Q]", "A torn note. It reads 'okay this is actually pretty cool', and 'how do i save the game'.", "TI_HI_CrumpledNote", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Bank record [Q]", "A bank record. It reads 'ACCOUNT: PlayerOne', 'LAST ACCESS: [DATA UNAVAILABLE]'.", "TI_HI_BankRecord", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Strange rune [Q]", "You have absolutely no idea what this could be for. Someone might know more.", "TI_HI_StrangeRune", 147, 112, 219, 0, trade: false) {
                UseString = "SecondExamine",
                MiscString = "ERROR: SPELL SYSTEM NOT FOUND.",
                ConsumedOnUse = false
            });
            itemsToAdd.Add(new Item("White bead [Q]", "A small round white bead.", "MIST_IC_White", 255, 255, 255, 4));
            itemsToAdd.Add(new Item("Red bead [Q]", "A small round red bead.", "MIST_IC_Red", 255, 0, 0, 4));
            itemsToAdd.Add(new Item("Black bead [Q]", "A small round black bead.", "MIST_IC_Black", 50, 50, 50, 4));
            itemsToAdd.Add(new Item("Yellow bead [Q]", "A small round yellow bead.", "MIST_IC_Yellow", 255, 255, 0, 4));
            


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
