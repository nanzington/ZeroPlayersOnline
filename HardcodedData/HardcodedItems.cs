using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItems {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();
            itemsToAdd.Add(new Item("Pine log", "A bundle of pine logs.", "logPine", 237, 202, 161, 4));
            itemsToAdd.Add(new Item("Tinderbox", "An arsonist's best friend.", "tinderbox", 255, 255, 255, 1));
            itemsToAdd.Add(new Item("Ashes", "A pile of wood ash.", "ashes", 200, 200, 200, 2));
            itemsToAdd.Add(new Item("Hammer", "Good for hitting things!", "hammer", 150, 150, 150, 1));
            itemsToAdd.Add(new Item("Knife", "Good for chopping or whittling, not so much for stabbing.", "knife", 150, 150, 150, 1) { UseString = "Knife", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Needle", "Now to get a camel through eye of this thing...", "needle", 200, 200, 200, 1) { UseString = "Needle", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Feather", "I could probably make arrows with this. Or put one in my cap!", "feather", 255, 255, 255, 2, true));
            
            itemsToAdd.Add(new Item("Bird snare", "Snares the leg of any bird that lands on it wrong.", "trapBird", 237, 202, 161, 5));
            
            itemsToAdd.Add(new Item("Small fishing net", "Useful for catching small fish.", "fishingNetSmall", 50, 50, 50, 5, misc: "Small net"));

            itemsToAdd.Add(new Item("Cowhide", "This should be tanned before I can use it.", "cowhide", 255, 255, 255, 10));
            itemsToAdd.Add(new Item("Soft Leather", "Suitable for craftworks now.", "leatherSoft", 165, 42, 42, 10));
            itemsToAdd.Add(new Item("Hard Leather", "Might offer some real protection if made into armor.", "leatherHard", 139, 69, 19, 20));
             

            itemsToAdd.Add(new Item("Arrow shaft", "The most important part of an arrow.", "arrowshaft", 139, 69, 19, 2, true));
            itemsToAdd.Add(new Item("Headless shafts", "An arrow shaft with a feather attached. Needs to be tipped.", "headlessShaft", 139, 69, 19, 2, true));
            itemsToAdd.Add(new Item("Pine shortbow (u)", "A shortbow stave fletched from pine.", "shortbowPineU", 237, 202, 161, 4));
            itemsToAdd.Add(new Item("Pine shortbow", "A shortbow fletched from pine.", "shortbowPine", 237, 202, 161, 4) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Arrow",
                EquipSkill = "Ranged",
                EquipAmmo = "Arrow",
                AttackSpeed = 1, 
                TwoHanded = true
            });


            itemsToAdd.Add(new Item("Shovel", "Could be used to dig for buried treasure.", "shovel", 200, 200, 200, 3) { UseString = "Dig", ConsumedOnUse = false });

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
            itemsToAdd.Add(new Item("Power Glove", "A gauntlet with a bunch of buttons on it. Seems wildly impractical.", "cluePowerGlove", 150, 150, 150, 500) { EquipSlot = "Hands", Cosmetic = true });
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
            itemsToAdd.Add(new Item("Newtbone shortbow", "Did someone hate newts or something? Why is all the ranger gear made of newt bits?", "clueNewtbow", 255, 255, 255, 500) { EquipSlot = "Weapon", EquipTier = 1, EquipDamageType = "Arrow", EquipSkill = "Ranged", EquipAmmo = "Arrow", AttackSpeed = 1, TwoHanded = true });
            
            itemsToAdd.Add(new Item("Tutorial Island Cape", "A cape signifying you completed all challenges on Tutorial Island. Congratulations!", "capeCompTI", 135, 206, 235, 0) { EquipSlot = "Cape", EquipTier = 1, MiscString = "OmniBoost" });



            itemsToAdd.Add(new Item("Potato seed", "Aren't potatoes potato seeds?", "seedPotato", 205, 127, 50, 5, true) {
                UseString = "PlantSeed",
                UseString2 = "Allotment", // Type of patch to plant in
                UseString3 = "potato", // Output when grown
                UseInt = 1, // Farming level to plant
                UseInt2 = 10, // Exp on harvest
                UseInt3 = 2400 // Time to grow in seconds

            });
            itemsToAdd.Add(new Item("Potato", "A tuber most versatile.", "potato", 205, 127, 50, 5));
            itemsToAdd.Add(new Item("Baked potato", "It'd taste even better with some toppings", "potatoBaked", 225, 147, 70, 10) {
                UseString = "Heal",
                UseInt = 4
            });


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
            itemsToAdd.Add(new Item("Empty plant pot", "An empty plant pot.", "plantPotEmpty", 207, 185, 151, 1));
            itemsToAdd.Add(new Item("Pot lid", "This should fit on a normal-sized pot.", "potLid", 207, 185, 151, 15));
            itemsToAdd.Add(new Item("Airtight pot", "This is pretty well sealed.", "potAirtight", 207, 185, 151, 10));


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

            itemsToAdd.Add(new Item("Pure essence", "An unimbued rune.", "pureEssence", 200, 200, 200, 4));
            itemsToAdd.Add(new Item("Air rune", "One of the 4 basic elemental runes.", "runeAir", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Earth rune", "One of the 4 basic elemental runes.", "runeEarth", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Fire rune", "One of the 4 basic elemental runes.", "runeFire", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Water rune", "One of the 4 basic elemental runes.", "runeWater", 200, 200, 200, 4, true, true));
            itemsToAdd.Add(new Item("Mind rune", "Used for basic level missile spells.", "runeMind", 200, 200, 200, 3, true, true));
            itemsToAdd.Add(new Item("Body rune", "Used for curse spells.", "runeBody", 200, 200, 200, 3, true, true));


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

            itemsToAdd.Add(new Item("Small Coin Pouch", "Has a few coins in it.", "coinPouchSmall", 111, 66, 33, 5, true, true) {
                UseString = "GetGold",
                UseInt = 5 
            });

            itemsToAdd.Add(new Item("Slayer gem", "A pretty blue gem that can tell you your current slayer task.", "gemSlayer", 102, 205, 170, 1) { UseString = "SlayerGem", ConsumedOnUse = false });
            itemsToAdd.Add(new Item("Bones", "The remains of some creature or person.", "bonesRegular", 255, 255, 255, 1, false, true) { UseString = "Bones", UseInt = 5 });
            itemsToAdd.Add(new Item("Big bones", "The remains of some huge creature or person.", "bonesBig", 255, 255, 255, 1, false, true) { UseString = "Bones", UseInt = 15 });
             
            itemsToAdd.Add(new Item("Raw newt meat", "A cut of meat taken from a newt.", "meatRawNewt", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Cooked newt meat", "A cooked newt steak.", "meatCookedNewt", 150, 100, 50, 4) {
                UseString = "Heal",
                UseInt = 3 
            });

            itemsToAdd.Add(new Item("Raw beef", "A cut of meat taken from a cow.", "meatRawBeef", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Cooked steak", "A cooked steak.", "meatCookedBeef", 150, 100, 50, 4) {
                UseString = "Heal",
                UseInt = 3
            });

            itemsToAdd.Add(new Item("Raw chicken", "A whole chicken, currently very inedible.", "meatRawChicken", 138, 3, 3, 1));
            itemsToAdd.Add(new Item("Cooked chicken", "A cooked chicken.", "meatCookedChicken", 150, 100, 50, 4) { UseString = "Heal", UseInt = 3 });

            itemsToAdd.Add(new Item("Raw bird meat", "This certainly needs cooking!", "meatRawBird", 138, 3, 3, 15));
            itemsToAdd.Add(new Item("Roast bird meat", "A nicely roasted bird.", "meatCookedBird", 150, 100, 50, 4) { UseString = "Heal", UseInt = 5 });

            itemsToAdd.Add(new Item("Raw shrimps", "A few raw shrimp.", "fishRawShrimp", 138, 3, 3, 5));
            itemsToAdd.Add(new Item("Cooked shrimps", "Some cooked shrimp.", "fishCookedShrimp", 150, 100, 50, 5) {
                UseString = "Heal",
                UseInt = 3
            });

            itemsToAdd.Add(new Item("Raw anchovies", "A few raw anchovies.", "fishRawAnchovies", 173, 216, 230, 15));
            itemsToAdd.Add(new Item("Cooked anchovies", "Some cooked anchovies.", "fishCookedAnchovies", 143, 186, 200, 15) {
                UseString = "Heal",
                UseInt = 1
            });


            itemsToAdd.Add(new Item("Empty Bucket", "An empty bucket. Could probably hold something.", "bucketEmpty", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Bucket of Water", "A bucket filled with water.", "bucketWater", 111, 66, 33, 2));

            
            itemsToAdd.Add(new Item("Copper ore", "A pile of copper ore nuggets.", "oreCopper", 184, 115, 51, 3));
            itemsToAdd.Add(new Item("Tin ore", "A pile of tin ore nuggets.", "oreTin", 170, 170, 170, 3)); 
            itemsToAdd.Add(new Item("Bronze ore mix", "A mix of copper and tin ore nuggets.", "oreMixBronze", 205, 127, 50, 6)); 
            itemsToAdd.Add(new Item("Bronze bar", "It's a bar of bronze.", "barBronze", 205, 127, 50, 8));
            itemsToAdd.Add(new Item("Iron ore", "A pile of iron ore nuggets.", "oreIron", 205, 127, 50, 15)); 
            itemsToAdd.Add(new Item("Iron ore mix", "A mix iron ore nuggets with the impurities sifted out.", "oreMixIron", 205, 127, 50, 25)); 
            itemsToAdd.Add(new Item("Iron bar", "It's a bar of iron.", "barIron", 75, 75, 75, 30));
            itemsToAdd.Add(new Item("Coal", "A lump of raw coal.", "oreCoal", 50, 50, 50, 30)); 
            itemsToAdd.Add(new Item("Steel ore mix", "A mix of iron ore nuggets and coal.", "oreMixSteel", 205, 127, 50, 45)); 
            itemsToAdd.Add(new Item("Steel bar", "It's a bar of iron.", "barSteel", 150, 150, 150, 60));

            // Smithing Factory
            List<MaterialDef> Metals = new() {
                new("Tutorial", 255, 255, 255, 255, 2, 1, 1000, "slight"), 
                new("Bronze", 205, 127, 50, 255, 1, 1, 15, "minimal"), 
                new("Iron", 75, 75, 75, 255, 2, 10, 45, "slight"), 
                new("Steel", 150, 150, 150, 255, 3, 20, 90, "adequate")
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
            
            
            itemsToAdd.Add(new Item("Grimy guam leaf", "It needs cleaning.", "herbGrimyGuam", 34, 139, 34, 13) { UseString = "CleanHerb", UseString2 = "herbCleanGuam", UseInt = 1, UseInt2 = 3 }); 
            itemsToAdd.Add(new Item("Guam leaf", "A bitter green herb.", "herbCleanGuam", 34, 170, 34, 13)); 
            itemsToAdd.Add(new Item("Eye of newt", "A basic herblore ingredient and only slightly gross.", "eyeNewt", 255, 255, 255, 3));
            itemsToAdd.Add(new Item("Vial", "A glass vial, currently empty.", "vialEmpty", 200, 200, 200, 2) { colA = 150 });
            itemsToAdd.Add(new Item("Vial of water", "A glass vial full of water.", "vialWater", 14, 129, 205, 2) { colA = 150 });
            itemsToAdd.Add(new Item("Guam potion (unf)", "I need another ingredient to finish this Guam potion.", "potionUnfGuam", 0, 128, 128, 3) { colA = 150 });
            itemsToAdd.Add(new Item("Attack potion", "Temporarily boosts your Attack level by 5.", "potionAttack", 0, 255, 255, 3) { UseString = "Potion", UseInt4 = 3, Potion = new() { new("Attack", 5) } });


            itemsToAdd.Add(new Item("Rusted sword [Q]", "The sword is useless now. You notice someone has scratched something into the handle: 'PlayerOne'.", "TI_HI_RustedSword", 205, 127, 50, 0, trade: false));
            itemsToAdd.Add(new Item("Crumpled note [Q]", "A torn note. It reads 'okay this is actually pretty cool', and 'how do i save the game'.", "TI_HI_CrumpledNote", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Bank record [Q]", "A bank record. It reads 'ACCOUNT: PlayerOne', 'LAST ACCESS: [DATA UNAVAILABLE]'.", "TI_HI_BankRecord", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Strange rune [Q]", "You have absolutely no idea what this could be for. Someone might know more.", "TI_HI_StrangeRune", 147, 112, 219, 0, trade: false) {
                UseString = "SecondExamine",
                MiscString = "ERROR: SPELL SYSTEM NOT FOUND.",
                ConsumedOnUse = false
            });


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
