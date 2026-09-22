using GoRogue.GameFramework;
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
             
            itemsToAdd.Add(new Item("Pine wood spirit", "When chopping pine logs, this is consumed and you will receive an extra log.", "spiritWoodPine", ColorLib.Pine, 20, true) { MiscString = "Spirit", UseString2 = "logPine" });
            itemsToAdd.Add(new Item("Oak wood spirit", "When chopping oak logs, this is consumed and you will receive an extra log.", "spiritWoodOak", ColorLib.Oak, 20, true) { MiscString = "Spirit", UseString2 = "logOak" });
            itemsToAdd.Add(new Item("Willow wood spirit", "When chopping willow logs, this is consumed and you will receive an extra log.", "spiritWoodWillow", ColorLib.Willow, 20, true) { MiscString = "Spirit", UseString2 = "logWillow" });
            itemsToAdd.Add(new Item("Teak wood spirit", "When chopping teak logs, this is consumed and you will receive an extra log.", "spiritWoodTeak", ColorLib.Teak, 20, true) { MiscString = "Spirit", UseString2 = "logTeak" });
            itemsToAdd.Add(new Item("Maple wood spirit", "When chopping maple logs, this is consumed and you will receive an extra log.", "spiritWoodMaple", ColorLib.Maple, 20, true) { MiscString = "Spirit", UseString2 = "logMaple" });
            itemsToAdd.Add(new Item("Acadia wood spirit", "When chopping acadia logs, this is consumed and you will receive an extra log.", "spiritWoodAcadia",ColorLib.Acadia, 20, true) { MiscString = "Spirit", UseString2 = "logAcadia" });
            itemsToAdd.Add(new Item("Mahogany wood spirit", "When chopping mahogany logs, this is consumed and you will receive an extra log.", "spiritWoodMahogany", ColorLib.Mahogany, 20, true) { MiscString = "Spirit", UseString2 = "logMahogany" });
            itemsToAdd.Add(new Item("Yew wood spirit", "When chopping yew logs, this is consumed and you will receive an extra log.", "spiritWoodYew", ColorLib.Yew, 20, true) { MiscString = "Spirit", UseString2 = "logYew" });
            itemsToAdd.Add(new Item("Magic wood spirit", "When chopping magic logs, this is consumed and you will receive an extra log.", "spiritWoodMagic", ColorLib.Magic, 20, true) { MiscString = "Spirit", UseString2 = "logMagic" });
            itemsToAdd.Add(new Item("Elder wood spirit", "When chopping elder logs, this is consumed and you will receive an extra log.", "spiritWoodElder", ColorLib.Elder, 20, true) { MiscString = "Spirit", UseString2 = "logElder" });




            itemsToAdd.Add(new Item("Tinderbox", "An arsonist's best friend.", "tinderbox", 255, 255, 255, 1));
            itemsToAdd.Add(new Item("Ashes", "A pile of wood ash.", "ashes", 200, 200, 200, 2));
            itemsToAdd.Add(new Item("Hammer", "Good for hitting things!", "hammer", 150, 150, 150, 1));
            itemsToAdd.Add(new Item("Knife", "Good for chopping or whittling, not so much for stabbing.", "knife", 150, 150, 150, 1) { UseString = "Knife", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Needle", "Now to get a camel through eye of this thing...", "needle", 200, 200, 200, 1) { UseString = "Needle", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Glassblowing pipe", "Used to form molten glass into useful items.", "glassblowingPipe", ColorLib.Steel, 2) { UseString = "Glassblowing Pipe", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Feather", "I could probably make arrows with this. Or put one in my cap!", "feather", 255, 255, 255, 2, true)); 
            itemsToAdd.Add(new Item("Steel studs", "A set of studs for leather armour.", "studsSteel", ColorLib.Steel, 45)); 
            itemsToAdd.Add(new Item("Shears", "Necessary to de-wool sheep.", "shears", 200, 200, 200, 1, misc: "Shears"));
            itemsToAdd.Add(new Item("Papyrus", "Used for making notes.", "papyrus", Color.Khaki, 10));
            itemsToAdd.Add(new Item("Waterskin (0)", "A completely empty waterskin - you'll need to fill it up.", "waterskin0", Color.Khaki, 15));
            itemsToAdd.Add(new Item("Waterskin (1)", "A nearly empty waterskin with one portion of water.", "waterskin1", Color.Khaki, 18));
            itemsToAdd.Add(new Item("Waterskin (2)", "A half empty waterskin with two portions of water.", "waterskin2", Color.Khaki, 24));
            itemsToAdd.Add(new Item("Waterskin (3)", "A nearly full waterskin with three portions of water.", "waterskin3", Color.Khaki, 27));
            itemsToAdd.Add(new Item("Waterskin (4)", "A full waterskin with four portions of water.", "waterskin4", Color.Khaki, 30));
            itemsToAdd.Add(new Item("Rope", "A coil of rope.", "rope", Color.SaddleBrown, 18));
             
            itemsToAdd.Add(new Item("Mithril grapple (unf)", "An unfinished mithril grapple. Needs a rope to be useful.", "grappleUnf", ColorLib.Mithril, 1000)); 
            itemsToAdd.Add(new Item("Mithril grapple", "A mithril grapple with a rope. Useful for some shortcuts.", "grapple", ColorLib.Mithril, 1500)); 
            
            itemsToAdd.Add(new Item("Bird snare", "Snares the leg of any bird that lands on it wrong.", "trapBird", 237, 202, 161, 5));
            
            itemsToAdd.Add(new Item("Small fishing net", "Useful for catching small fish.", "fishingNetSmall", 50, 50, 50, 5, misc: "Small net"));
            itemsToAdd.Add(new Item("Big fishing net", "Useful for catching lots of fish.", "fishingNetBig", 50, 50, 50, 20, misc: "Big net"));
            itemsToAdd.Add(new Item("Fishing rod", "Useful for catching sardine or herring.", "fishingRod", 139, 69, 19, 5, misc: "Fishing rod")); 
            itemsToAdd.Add(new Item("Fish bait", "For use with a fishing rod.", "baitFish", 233, 185, 93, 3, true));
            itemsToAdd.Add(new Item("Fly fishing rod", "Like a fishing rod, but with cool glasses and a sick haircut.", "fishingRodFly", 139, 69, 19, 5, misc: "Fly fishing rod"));
            itemsToAdd.Add(new Item("Harpoon", "Useful for catching really big fish.", "fishingHarpoon", 139, 69, 19, 45, misc: "Harpoon"));
            itemsToAdd.Add(new Item("Lobster pot", "Useful for catching lobsters.", "fishingPotLobster", 139, 69, 19, 20, misc: "Lobster pot"));

            
            
             

            itemsToAdd.Add(new Item("Arrow shaft", "The most important part of an arrow.", "arrowshaft", 139, 69, 19, 2, true));
            itemsToAdd.Add(new Item("Headless shafts", "An arrow shaft with a feather attached. Needs to be tipped.", "headlessShaft", 139, 69, 19, 2, true));
            itemsToAdd.Add(new Item("Flax", "I should use this with a spinning wheel.", "flax", 189, 246, 254, 5));
            itemsToAdd.Add(new Item("Bow string", "I need a bow stave to attach this to.", "bowstring", 207, 185, 151, 10));
            itemsToAdd.Add(new Item("Sinew", "I can use this to make a crossbow string.", "sinew", 207, 185, 151, 10));
            itemsToAdd.Add(new Item("Crossbow string", "A string for a crossbow.", "crossbowString", 207, 185, 151, 10));


            // Fletching Factory
            List<MaterialDef> Woods = new() {
                new("Pine", ColorLib.Pine, 1, 1, 5, "bronze"),
                new("Oak", ColorLib.Oak, 2, 10, 20, "iron"),
                new("Willow", ColorLib.Willow, 3, 20, 40, "steel"),
                new("Teak", ColorLib.Teak, 4, 30, 30, "mithril"),
                new("Maple", ColorLib.Maple, 5, 40, 80, "adamant"),
                new("Acadia", ColorLib.Acadia, 6, 50, 85, "rune"),
                new("Mahogany", ColorLib.Mahogany, 7, 60, 50, "orichalcum"),
                new("Yew", ColorLib.Yew, 8, 70, 160, "necrite"),
                new("Magic", ColorLib.Magic, 9, 80, 320, "banite"),
                new("Elder", ColorLib.Elder, 10, 90, 480, "elder rune")
            };

            foreach (var mat in Woods) { 
                itemsToAdd.Add(new Item(mat.Name + " shortbow (u)", "A shortbow stave fletched from " + mat.Name.ToLower() + ".", "shortbow" + mat.Name + "U", mat.R, mat.G, mat.B, mat.CostMultiplier));
                itemsToAdd.Add(new Item(mat.Name + " shortbow", "A shortbow fletched from " + mat.Name.ToLower() + ".", "shortbow" + mat.Name, mat.R, mat.G, mat.B, mat.CostMultiplier + 15) {
                    EquipSlot = "Weapon",
                    EquipTier = mat.Tier,
                    EquipLevel = mat.Level, 
                    EquipDamageType = "RangedStandard",
                    EquipSkill = "Ranged",
                    EquipAmmo = "RangedStandard",
                    AttackSpeed = 0.75, 
                    TwoHanded = true
                });

                itemsToAdd.Add(new Item(mat.Name + " longbow (u)", "A longbow stave fletched from " + mat.Name.ToLower() + ".", "longbow" + mat.Name + "U", mat.R, mat.G, mat.B, mat.CostMultiplier));
                itemsToAdd.Add(new Item(mat.Name + " longbow", "A longbow fletched from " + mat.Name.ToLower() + ".", "longbow" + mat.Name, mat.R, mat.G, mat.B, mat.CostMultiplier + 15) {
                    EquipSlot = "Weapon",
                    EquipTier = mat.Tier + 1,
                    EquipLevel = mat.Level, 
                    EquipDamageType = "RangedStandard",
                    EquipSkill = "Ranged",
                    EquipAmmo = "RangedStandard",
                    AttackSpeed = 1.25, 
                    TwoHanded = true
                });

                itemsToAdd.Add(new Item(mat.Name + " composite bow", "A composite bow fletched from " + mat.Name.ToLower() + ".", "compbow" + mat.Name, mat.R, mat.G, mat.B, mat.CostMultiplier * 10) {
                    EquipSlot = "Weapon",
                    EquipTier = mat.Tier + 1,
                    EquipLevel = mat.Level, 
                    EquipDamageType = "RangedStandard",
                    EquipSkill = "Ranged",
                    EquipAmmo = "RangedStandard",
                    AttackSpeed = 1, 
                    TwoHanded = true
                });

                itemsToAdd.Add(new Item(mat.Name + " stock", "A crossbow stock fletched from " + mat.Name.ToLower() + ". Could be attached to " + mat.Descriptor + " limbs.", "stock" + mat.Name, mat.R, mat.G, mat.B, mat.CostMultiplier));
                itemsToAdd.Add(new Item(mat.Name + " crossbow (u)", "An unstrung crossbow stock fletched from " + mat.Name.ToLower() + " attached to " + mat.Descriptor + " limbs.", "crossbow" + mat.Name + "U", mat.R, mat.G, mat.B, mat.CostMultiplier));
                itemsToAdd.Add(new Item(mat.Name + " crossbow", "A crossbow made from " + mat.Name.ToLower() + " and " + mat.Descriptor + ". Fires bolts.", "crossbow" + mat.Name, mat.R, mat.G, mat.B, mat.CostMultiplier * 2) {
                    EquipSlot = "Weapon",
                    EquipTier = mat.Tier,
                    EquipLevel = mat.Level, 
                    EquipDamageType = "RangedHeavy",
                    EquipSkill = "Ranged",
                    EquipAmmo = "RangedHeavy",
                    AttackSpeed = 1
                });
            }   

            itemsToAdd.Add(new Item("Shovel", "Could be used to dig for buried treasure.", "shovel", 200, 200, 200, 3) { UseString = "Dig", ConsumedOnUse = false });
            itemsToAdd.Add(new Item("Map (Lumbridge Swamp)", "Useful for navigating a confusing swamp.", "mapLumbridgeSwamp", Color.Khaki, 3) { Noteable = false, EquipSlot = "Pocket", UseString = "Map", UseString2 = "Lumbridge Swamp", UseInt = 6, UseInt2 = 4, ConsumedOnUse = false });
            itemsToAdd.Add(new Item("Candle (lit)", "A lit candle.", "candleLit", Color.Yellow, 3) { UseString = "Extinguish", UseString2 = "candle", ConsumedOnUse = false, ExposedFlame = true, ProvidesLight = true });
            itemsToAdd.Add(new Item("Candle", "A candle.", "candle", Color.White, 3) { UseString = "Light", UseString2 = "candleLit", ConsumedOnUse = false });
            itemsToAdd.Add(new Item("Candle lantern (lit)", "A flickering candle in a glass cage.", "candleLanternLit", Color.Yellow, 15) { UseString = "Extinguish", UseString2 = "candleLantern", ConsumedOnUse = false, ProvidesLight = true });
            itemsToAdd.Add(new Item("Candle lantern", "A candle in a glass cage.", "candleLantern", ColorLib.Steel, 15) { UseString = "Light", UseString2 = "candleLanternLit", ConsumedOnUse = false });
            itemsToAdd.Add(new Item("Torch (lit)", "A lit torch.", "torchLit", Color.Yellow, 3) { UseString = "Extinguish", UseString2 = "torch", ConsumedOnUse = false, ExposedFlame = true, ProvidesLight = true });
            itemsToAdd.Add(new Item("Torch", "A torch.", "torch", Color.SaddleBrown, 3) { UseString = "Light", UseString2 = "torchLit", ConsumedOnUse = false });
            itemsToAdd.Add(new Item("Oil lantern frame", "Add the oil lamp to complete.", "oilLanternFrame", ColorLib.Steel, 90)); 
            itemsToAdd.Add(new Item("Empty oil lamp", "An oil lamp with no oil in it.", "oilLampEmpty", ColorLib.Steel, 25)); 
            itemsToAdd.Add(new Item("Oil lamp (lit)", "Not the genie sort.", "oilLampLit", Color.Yellow, 28) { UseString = "Extinguish", UseString2 = "oilLamp", ConsumedOnUse = false, ExposedFlame = true, ProvidesLight = true });
            itemsToAdd.Add(new Item("Oil lamp", "Not the genie sort.", "oilLamp", ColorLib.Steel, 28) { UseString = "Light", UseString2 = "oilLampLit", ConsumedOnUse = false });
            itemsToAdd.Add(new Item("Empty oil lantern", "An oil lantern with no oil in it.", "oilLanternEmpty", ColorLib.Steel, 125)); 
            itemsToAdd.Add(new Item("Oil lantern (lit)", "It lights your way through the dark places of the earth.", "oilLanternLit", Color.Yellow, 125) { UseString = "Extinguish", UseString2 = "oilLantern", ConsumedOnUse = false, ProvidesLight = true });
            itemsToAdd.Add(new Item("Oil lantern", "An unlit oil lantern.", "oilLantern", ColorLib.Steel, 125) { UseString = "Light", UseString2 = "oilLanternLit", ConsumedOnUse = false });
            

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
                    UseInt = 10,
                    DropTable = {
                        new ItemDrop("clueCatEars", 1, 20, 1, 1),
                        new ItemDrop("clueCornyApron", 1, 20, 1, 1),
                        new ItemDrop("clueKilt", 1, 20, 1, 1),
                        new ItemDrop("cluePowerGlove", 1, 20, 1, 1),
                        new ItemDrop("clueProgrammerSocks", 1, 20, 1, 1),
                        new ItemDrop("helmTutorial", 1, 20, 1, 1), 
                        new ItemDrop("platebodyTutorial", 1, 20, 1, 1), 
                        new ItemDrop("chainmailTutorial", 1, 20, 1, 1),
                        new ItemDrop("platelegsTutorial", 1, 20, 1, 1),
                        new ItemDrop("plateskirtTutorial", 1, 20, 1, 1),  
                        new ItemDrop("gauntletsTutorial", 1, 20, 1, 1), 
                        new ItemDrop("swordTutorial", 1, 20, 1, 1), 
                        new ItemDrop("spearTutorial", 1, 20, 1, 1),  
                        new ItemDrop("battleaxeTutorial", 1, 20, 1, 1), 
                        new ItemDrop("sword2hTutorial", 1, 20, 1, 1), 
                        new ItemDrop("warhammerTutorial", 1, 20, 1, 1), 
                        new ItemDrop("sqShieldTutorial", 1, 20, 1, 1), 
                        new ItemDrop("kiteshieldTutorial", 1, 20, 1, 1),  
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
                        new ItemDrop("boltsTutorial", 1, 4, 50, 100),
                        new ItemDrop("knivesBronze", 1, 4, 200, 400),
                        new ItemDrop("knivesTutorial", 1, 4, 100, 200)
                    }
                });

                // Clue (Tutorial) Uniques
                itemsToAdd.Add(new Item("Cat ear headband", "A cute headband that makes you look like you have cat ears.", "clueCatEars", 255, 105, 180, 500) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Corny apron", "An apron reading 'Kiss the Cook'.", "clueCornyApron", 255, 255, 255, 500) { EquipSlot = "Body", Cosmetic = true, CountsAsIDs = ["whiteApron"] });
                itemsToAdd.Add(new Item("Kilt", "A bit breezy but quite comfortable.", "clueKilt", 34, 139, 34, 500) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Power glove", "A gauntlet with a bunch of buttons on it. Seems wildly impractical.", "cluePowerGlove", 150, 150, 150, 500) { EquipSlot = "Hands", Cosmetic = true });
                itemsToAdd.Add(new Item("Programmer socks", "Thigh-high socks with blue stripes.", "clueProgrammerSocks", 135, 206, 235, 500) { EquipSlot = "Feet", Cosmetic = true });
            
                itemsToAdd.Add(new Item("Silky hood", "A silk hood. Slightly magical, very comfortable.", "clueSilkHood", 147, 112, 219, 500) { EquipSlot = "Head", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky robes", "A set of silk robes. Slightly magical, very comfortable.", "clueSilkRobes", 147, 112, 219, 500) { EquipSlot = "Body", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky underwear", "A pair of silk underwear. Slightly magical, very comfortable.", "clueSilkUnderwear", 147, 112, 219, 500) { EquipSlot = "Legs", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky gloves", "A pair of silk gloves. Slightly magical, very comfortable.", "clueSilkGloves", 147, 112, 219, 500) { EquipSlot = "Hands", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Silky socks", "A pair of silk socks. Slightly magical, very comfortable.", "clueSilkSocks", 147, 112, 219, 500) { EquipSlot = "Feet", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                 
                itemsToAdd.Add(new Item("Newtskin coif", "A coif made of newtskin, which seems to have been removed from the game at some point.", "clueNewtskinCoif", 255, 165, 0, 500) { EquipSlot = "Head", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseRange" });
                itemsToAdd.Add(new Item("Newtskin body", "A body made of newtskin, which seems to have been removed from the game at some point.", "clueNewtskinBody", 255, 165, 0, 500) { EquipSlot = "Body", EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseRange" });
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
                        new ItemDrop("clueFeetMole", 1, 360, 1, 1), new ItemDrop("clueFeetFrog", 1, 360, 1, 1), new ItemDrop("clueFeetBear", 1, 360, 1, 1), new ItemDrop("clueFeetDemon", 1, 360, 1, 1),
                        new ItemDrop("clueCapeJester", 1, 360, 1, 1), new ItemDrop("clueCapeParrot", 1, 360, 1, 1),
                        new ItemDrop("clueTopMonkT", 1, 360, 1, 1), new ItemDrop("clueBottomMonkT", 1, 360, 1, 1),
                        new ItemDrop("clueAmuletDefenseT", 1, 360, 1, 1),
                        new ItemDrop("clueHeadSandwich", 1, 360, 1, 1),  new ItemDrop("clueTopSandwich", 1, 360, 1, 1),  new ItemDrop("clueBottomSandwich", 1, 360, 1, 1),
                        new ItemDrop("clueOrnamentRuneScimG", 1, 360, 1, 1), new ItemDrop("clueOrnamentRuneScimS", 1, 360, 1, 1), new ItemDrop("clueOrnamentRuneScimZ", 1, 360, 1, 1),
                        new ItemDrop("sword2hBlack", 1, 805, 1, 1), new ItemDrop("hatchetBlack", 1, 805, 1, 1), new ItemDrop("battleaxeBlack", 1, 805, 1, 1),
                        new ItemDrop("chainmailBlack", 1, 805, 1, 1), new ItemDrop("daggerBlack", 1, 805, 1, 1), new ItemDrop("helmBlack", 1, 805, 1, 1),
                        new ItemDrop("kiteshieldBlack", 1, 805, 1, 1), new ItemDrop("swordBlack", 1, 805, 1, 1), new ItemDrop("maceBlack", 1, 805, 1, 1),
                        new ItemDrop("spearBlack", 1, 805, 1, 1), new ItemDrop("pickaxeBlack", 1, 805, 1, 1), new ItemDrop("platebodyBlack", 1, 805, 1, 1),
                        new ItemDrop("platelegsBlack", 1, 805, 1, 1), new ItemDrop("plateskirtBlack", 1, 805, 1, 1), new ItemDrop("sqShieldBlack", 1, 805, 1, 1),
                        new ItemDrop("scimitarBlack", 1, 805, 1, 1), new ItemDrop("warhammerBlack", 1, 805, 1, 1),
                        new ItemDrop("shortbowPine", 1, 45, 1, 1), new ItemDrop("longbowPine", 1, 45, 1, 1),
                        new ItemDrop("shortbowOak", 1, 45, 1, 1), new ItemDrop("longbowOak", 1, 45, 1, 1),
                        new ItemDrop("pickaxeIron", 1, 45, 1, 1),
                        new ItemDrop("staffAir", 1, 45, 1, 1), new ItemDrop("staffWater", 1, 45, 1, 1), new ItemDrop("staffEarth", 1, 45, 1, 1), new ItemDrop("staffFire", 1, 45, 1, 1),
                        new ItemDrop("helmSteel", 1, 45, 1, 1), new ItemDrop("platebodySteel", 1, 45, 1, 1), new ItemDrop("platelegsSteel", 1, 45, 1, 1),
                        new ItemDrop("swordSteel", 1, 45, 1, 1), new ItemDrop("daggerSteel", 1, 45, 1, 1), new ItemDrop("hatchetSteel", 1, 45, 1, 1),
                        new ItemDrop("battleaxeSteel", 1, 45, 1, 1),
                        new ItemDrop("coifLeather", 1, 45, 1, 1), new ItemDrop("bodyLeather", 1, 45, 1, 1), new ItemDrop("chapsLeather", 1, 45, 1, 1),
                        new ItemDrop("vambracesLeather", 1, 45, 1, 1), new ItemDrop("bodyHardleather", 1, 45, 1, 1),
                        new ItemDrop("wizardBlueHat", 1, 45, 1, 1), new ItemDrop("wizardBlueRobe", 1, 45, 1, 1),
                        new ItemDrop("wizardBlackHat", 1, 45, 1, 1), new ItemDrop("wizardBlackRobe", 1, 45, 1, 1),
                        new ItemDrop("runeAir", 1, 45, 15, 35), new ItemDrop("runeMind", 1, 45, 15, 35), new ItemDrop("runeWater", 1, 45, 15, 35), new ItemDrop("runeEarth", 1, 45, 15, 35), new ItemDrop("runeFire", 1, 45, 15, 35),
                        new ItemDrop("runeBody", 1, 45, 15, 35), new ItemDrop("runeChaos", 1, 45, 2, 7), new ItemDrop("runeNature", 1, 45, 2, 7), new ItemDrop("runeLaw", 1, 45, 2, 7),
                        new ItemDrop("arrowsBronze", 1, 45, 15, 30), new ItemDrop("arrowsIron", 1, 45, 7, 15)
                    }
                });

                // Beginner Clue Uniques
                itemsToAdd.Add(new Item("Mole slippers", "Cute mole slippers.", "clueFeetMole", Color.SaddleBrown, 1000) { EquipSlot = "Feet", Cosmetic = true });
                itemsToAdd.Add(new Item("Frog slippers", "Cute frog slippers.", "clueFeetFrog", Color.LawnGreen, 1000) { EquipSlot = "Feet", Cosmetic = true });
                itemsToAdd.Add(new Item("Bear slippers", "Vicious bear slippers.", "clueFeetBear", Color.SandyBrown, 1000) { EquipSlot = "Feet", Cosmetic = true });
                itemsToAdd.Add(new Item("Demon slippers", "Vicious demon slippers.", "clueFeetDemon", Color.Crimson, 1000) { EquipSlot = "Feet", Cosmetic = true });
                itemsToAdd.Add(new Item("Jester cape", "A jester cape", "clueCapeJester", Color.Yellow, 1000) { EquipSlot = "Cape", Cosmetic = true });
                itemsToAdd.Add(new Item("Shoulder parrot", "Polly want a cracker?", "clueCapeParrot", Color.Green, 1000) { EquipSlot = "Cape", Cosmetic = true });
                itemsToAdd.Add(new Item("Monk's robe top", "I feel the gods don't enjoy my materialistic obsessions.", "clueTopMonkT", Color.SaddleBrown, 500) { CosmeticNote = "t", EquipSlot = "Body", MiscString = "PrayerBoost", EquipTier = 2 });
                itemsToAdd.Add(new Item("Monk's robe", "I feel the gods don't enjoy my materialistic obsessions.", "clueBottomMonkT", Color.SaddleBrown, 500) { CosmeticNote = "t", EquipSlot = "Legs", MiscString = "PrayerBoost", EquipTier = 2 });
                itemsToAdd.Add(new Item("Amulet of defense", "An enchanted emerald amulet of protection that looks good.", "clueAmuletDefenseT", Color.Lime, 1275) { CosmeticNote = "t", EquipSlot = "Amulet", MiscString = "DefenseAll", EquipTier = 5 });
                itemsToAdd.Add(new Item("Sandwich lady hat", "A hat worn by a sandwich lady.", "clueHeadSandwich", Color.White, 200) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Sandwich lady top", "A top worn by a sandwich lady.", "clueTopSandwich", Color.LightPink, 200) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Sandwich lady skirt", "A skirt worn by a sandwich lady.", "clueBottomSandwich", Color.LightPink, 200) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Rune scimitar ornament (Guthix)", "Use on a rune scimitar to make it look fancier!", "clueOrnamentRuneScimG", Color.Green, 5000));
                itemsToAdd.Add(new Item("Rune scimitar ornament (Saradomin)", "Use on a rune scimitar to make it look fancier!", "clueOrnamentRuneScimS", Color.Turquoise, 5000));
                itemsToAdd.Add(new Item("Rune scimitar ornament (Zamorak)", "Use on a rune scimitar to make it look fancier!", "clueOrnamentRuneScimZ", Color.Crimson, 5000));


                // Easy Clues
                itemsToAdd.Add(new Item("Clue scroll (easy)", "Hopefully leads to treasure.", "clueScrollEasy", 207, 185, 151, 0, false, false) {
                    UseString = "ClueEasy", 
                    ConsumedOnUse = false,
                    DestroyOnDrop = true
                });

                itemsToAdd.Add(new Item("Clue casket (easy)", "The treasure at the end of the hunt! What could be inside?", "casketEasy", 218, 165, 32, 0, true, false) {
                    UseString = "Casket",
                    UseString2 = "Easy",
                    UseInt = 1000,
                    DropTable = {
                        new ItemDrop("compbowWillow", 1, 360, 1, 1),
                        new ItemDrop("clueAmuletMagicT", 1, 360, 1, 1),
                        new ItemDrop("helmBlackT", 1, 1404, 1, 1),
                        new ItemDrop("platebodyBlackT", 1, 1404, 1, 1),
                        new ItemDrop("platelegsBlackT", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtBlackT", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldBlackT", 1, 1404, 1, 1),
                        new ItemDrop("helmBlackG", 1, 1404, 1, 1),
                        new ItemDrop("platebodyBlackG", 1, 1404, 1, 1),
                        new ItemDrop("platelegsBlackG", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtBlackG", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldBlackG", 1, 1404, 1, 1),
                        new ItemDrop("helmBlackH", 1, 1404, 1, 1),
                        new ItemDrop("platebodyBlackH", 1, 1404, 1, 1),
                        new ItemDrop("platelegsBlackH", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtBlackH", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldBlackH", 1, 1404, 1, 1),
                        new ItemDrop("helmSteelT", 1, 1404, 1, 1),
                        new ItemDrop("platebodySteelT", 1, 1404, 1, 1),
                        new ItemDrop("platelegsSteelT", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtSteelT", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldSteelT", 1, 1404, 1, 1),
                        new ItemDrop("helmSteelG", 1, 1404, 1, 1),
                        new ItemDrop("platebodySteelG", 1, 1404, 1, 1),
                        new ItemDrop("platelegsSteelG", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtSteelG", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldSteelG", 1, 1404, 1, 1),
                        new ItemDrop("helmSteelH", 1, 1404, 1, 1),
                        new ItemDrop("platebodySteelH", 1, 1404, 1, 1),
                        new ItemDrop("platelegsSteelH", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtSteelH", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldSteelH", 1, 1404, 1, 1),
                        new ItemDrop("helmIronT", 1, 1404, 1, 1),
                        new ItemDrop("platebodyIronT", 1, 1404, 1, 1),
                        new ItemDrop("platelegsIronT", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtIronT", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldIronT", 1, 1404, 1, 1),
                        new ItemDrop("helmIronH", 1, 1404, 1, 1),
                        new ItemDrop("platebodyIronH", 1, 1404, 1, 1),
                        new ItemDrop("platelegsIronH", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtIronH", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldIronH", 1, 1404, 1, 1),
                        new ItemDrop("helmIronG", 1, 1404, 1, 1),
                        new ItemDrop("platebodyIronG", 1, 1404, 1, 1),
                        new ItemDrop("platelegsIronG", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtIronG", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldIronG", 1, 1404, 1, 1), 
                        new ItemDrop("helmBronzeT", 1, 1404, 1, 1),
                        new ItemDrop("platebodyBronzeT", 1, 1404, 1, 1),
                        new ItemDrop("platelegsBronzeT", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtBronzeT", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldBronzeT", 1, 1404, 1, 1),
                        new ItemDrop("helmBronzeH", 1, 1404, 1, 1),
                        new ItemDrop("platebodyBronzeH", 1, 1404, 1, 1),
                        new ItemDrop("platelegsBronzeH", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtBronzeH", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldBronzeH", 1, 1404, 1, 1),
                        new ItemDrop("helmBronzeG", 1, 1404, 1, 1),
                        new ItemDrop("platebodyBronzeG", 1, 1404, 1, 1),
                        new ItemDrop("platelegsBronzeG", 1, 1404, 1, 1),
                        new ItemDrop("plateskirtBronzeG", 1, 1404, 1, 1),
                        new ItemDrop("kiteshieldBronzeG", 1, 1404, 1, 1),
                        new ItemDrop("bodyStuddedG", 1, 1404, 1, 1),
                        new ItemDrop("chapsStuddedG", 1, 1404, 1, 1),
                        new ItemDrop("bodyStuddedT", 1, 1404, 1, 1),
                        new ItemDrop("chapsStuddedT", 1, 1404, 1, 1),
                        new ItemDrop("bodyLeatherG", 1, 1404, 1, 1),
                        new ItemDrop("chapsLeatherG", 1, 1404, 1, 1),
                        new ItemDrop("bodyLeatherT", 1, 1404, 1, 1),
                        new ItemDrop("chapsLeatherT", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlueHatG", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlueRobeG", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlueBottomG", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlueHatT", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlueRobeT", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlueBottomT", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlackHatG", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlackRobeG", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlackBottomG", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlackHatT", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlackRobeT", 1, 1404, 1, 1),
                        new ItemDrop("wizardBlackBottomT", 1, 1404, 1, 1),
                        new ItemDrop("clueSaradominTop", 1, 1404, 1, 1),
                        new ItemDrop("clueSaradominBottom", 1, 1404, 1, 1),
                        new ItemDrop("clueGuthixTop", 1, 1404, 1, 1),
                        new ItemDrop("clueGuthixBottom", 1, 1404, 1, 1),
                        new ItemDrop("clueZamorakTop", 1, 1404, 1, 1),
                        new ItemDrop("clueZamorakBottom", 1, 1404, 1, 1),
                        new ItemDrop("clueAncientTop", 1, 1404, 1, 1),
                        new ItemDrop("clueAncientBottom", 1, 1404, 1, 1),
                        new ItemDrop("clueArmadylTop", 1, 1404, 1, 1),
                        new ItemDrop("clueArmadylBottom", 1, 1404, 1, 1),
                        new ItemDrop("clueBandosTop", 1, 1404, 1, 1),
                        new ItemDrop("clueBandosBottom", 1, 1404, 1, 1),
                        new ItemDrop("clueBobShirtRed", 1, 1404, 1, 1),
                        new ItemDrop("clueBobShirtGreen", 1, 1404, 1, 1),
                        new ItemDrop("clueBobShirtBlue", 1, 1404, 1, 1),
                        new ItemDrop("clueBobShirtBlack", 1, 1404, 1, 1),
                        new ItemDrop("clueBobShirtPurple", 1, 1404, 1, 1),
                        new ItemDrop("clueHighwaymanMask", 1, 1404, 1, 1),
                        new ItemDrop("clueBeretBlue", 1, 1404, 1, 1),
                        new ItemDrop("clueBeretBlack", 1, 1404, 1, 1),
                        new ItemDrop("clueBeretRed", 1, 1404, 1, 1),
                        new ItemDrop("clueBeretWhite", 1, 1404, 1, 1),
                        new ItemDrop("cluePowderedWig", 1, 1404, 1, 1),
                        new ItemDrop("clueBeanie", 1, 1404, 1, 1),
                        new ItemDrop("clueMaskImp", 1, 1404, 1, 1),
                        new ItemDrop("clueMaskGoblin", 1, 1404, 1, 1),
                        new ItemDrop("clueSleepingCap", 1, 1404, 1, 1),
                        new ItemDrop("clueFlaredTrousers", 1, 1404, 1, 1),
                        new ItemDrop("cluePantaloons", 1, 1404, 1, 1),
                        new ItemDrop("clueCaneBlack", 1, 1404, 1, 1),
                        new ItemDrop("clueStaffBob", 1, 1404, 1, 1),
                        new ItemDrop("clueAmuletPowerT", 1, 1404, 1, 1),
                        new ItemDrop("clueHamJoint", 1, 1404, 1, 1),
                        new ItemDrop("clueRainbow", 1, 1404, 1, 1),
                        new ItemDrop("clueGoldenChefHat", 1, 2808, 1, 1),
                        new ItemDrop("clueGoldenChefApron", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantShirtRed", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantBlouseRed", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantLegsRed", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantSkirtRed", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantShirtGreen", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantBlouseGreen", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantLegsGreen", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantSkirtGreen", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantShirtBlue", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantBlouseBlue", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantLegsBlue", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantSkirtBlue", 1, 2808, 1, 1),
                        new ItemDrop("clueCapeTeamZero", 1, 5616, 1, 1),
                        new ItemDrop("clueCapeTeamI", 1, 5616, 1, 1),
                        new ItemDrop("clueCapeTeamX", 1, 5616, 1, 1),
                        new ItemDrop("clueCapeSkulls", 1, 5616, 1, 1),
                        new ItemDrop("clueTopMonkG", 1, 14040, 1, 1),
                        new ItemDrop("clueBottomMonkG", 1, 14040, 1, 1),
                        new ItemDrop("helmBlack", 1, 36, 1, 1),
                        new ItemDrop("platebodyBlack", 1, 36, 1, 1),
                        new ItemDrop("platelegsBlack", 1, 36, 1, 1),
                        new ItemDrop("swordBlack", 1, 36, 1, 1),
                        new ItemDrop("battleaxeBlack", 1, 36, 1, 1),
                        new ItemDrop("hatchetBlack", 1, 36, 1, 1),
                        new ItemDrop("daggerBlack", 1, 36, 1, 1),
                        new ItemDrop("pickaxeSteel", 1, 36, 1, 1),
                        new ItemDrop("pickaxeBlack", 1, 36, 1, 1),
                        new ItemDrop("coifStudded", 1, 36, 1, 1),
                        new ItemDrop("bodyStudded", 1, 36, 1, 1),
                        new ItemDrop("chapsStudded", 1, 36, 1, 1),
                        new ItemDrop("shortbowWillow", 1, 36, 1, 1),
                        new ItemDrop("staffAir", 1, 36, 1, 1),
                        new ItemDrop("longbowWillow", 1, 36, 1, 1),
                        new ItemDrop("amuletMagic", 1, 36, 1, 1),
                        new ItemDrop("runeAir", 1, 36, 30, 50),
                        new ItemDrop("runeMind", 1, 36, 30, 50),
                        new ItemDrop("runeWater", 1, 36, 30, 50),
                        new ItemDrop("runeEarth", 1, 36, 30, 50),
                        new ItemDrop("runeFire", 1, 36, 30, 50),
                        new ItemDrop("runeBody", 1, 36, 30, 50),
                        new ItemDrop("runeChaos", 1, 36, 5, 10),
                        new ItemDrop("runeNature", 1, 36, 5, 10),
                        new ItemDrop("runeLaw", 1, 36, 5, 10),
                        new ItemDrop("cluePurpleSweets", 1, 36, 2, 6, altlog: "General"),
                        new ItemDrop("clueFirelighterRed", 1, 180, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterGreen", 1, 180, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterBlue", 1, 180, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterPurple", 1, 180, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterWhite", 1, 180, 3, 5, altlog: "General"),
                        new ItemDrop("clueChargeDragonstoneScroll", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportNardah", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportMosLeHarmless", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportMortton", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportFeldipHills", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportLunar", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportDigsite", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportPiscatoris", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportPestControl", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportTaiBwoWannai", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportLumberyard", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportIorwerthCamp", 1, 453, 5, 15, altlog: "General"),
                        new ItemDrop("clueMasterScrollBook", 1, 793, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin1", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin2", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin3", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin4", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak1", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak2", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak3", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak4", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix1", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix2", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix3", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix4", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos1", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos2", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos3", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos4", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl1", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl2", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl3", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl4", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient1", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient2", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient3", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient4", 1, 864, 1, 1, altlog: "General"),
                        new ItemDrop("clueHolyBlessing", 1, 2160, 1, 1, altlog: "General"),
                        new ItemDrop("clueUnholyBlessing", 1, 2160, 1, 1, altlog: "General"),
                        new ItemDrop("cluePeacefulBlessing", 1, 2160, 1, 1, altlog: "General"),
                        new ItemDrop("clueWarBlessing", 1, 2160, 1, 1, altlog: "General"),
                        new ItemDrop("clueHonourableBlessing", 1, 2160, 1, 1, altlog: "General"),
                        new ItemDrop("clueAncientBlessing", 1, 2160, 1, 1, altlog: "General"),
                        new ItemDrop("clueScrollMaster", 1, 50, 1, 1, altlog: "General")
                    }
                });

                // Easy Clue Uniques
                itemsToAdd.Add(new Item("Amulet of magic", "An enchanted sapphire amulet of magic.", "clueAmuletMagicT", Color.DeepSkyBlue, 900) { CosmeticNote = "t", EquipSlot = "Amulet", MiscString = "MagicBoost", EquipTier = 5 });
                itemsToAdd.Add(new Item("Bob's red shirt", "'Bob says: Never give your password out to anyone.'", "clueBobShirtRed", Color.Crimson, 3) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Bob's green shirt", "'Bob says: Never trade in the wilderness!'", "clueBobShirtGreen", Color.Green, 3) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Bob's blue shirt", "'Bob says: Always check the second trade screen.'", "clueBobShirtBlue", Color.Turquoise, 3) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Bob's black shirt", "'Bob says: A bank pin will keep your items secure.'", "clueBobShirtBlack", Color.DimGray, 3) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Bob's purple shirt", "'Bob says: Keep your computer keylogger free and virus scanned.'", "clueBobShirtPurple", Color.MediumPurple, 3) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Highwayman mask", "Your money or your life!", "clueHighwaymanMask", Color.DimGray, 40) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Blue beret", "Parlez-vous francais?", "clueBeretBlue", Color.CadetBlue, 80) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Black beret", "Parlez-vous francais?", "clueBeretBlack", Color.DimGray, 80) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Red beret", "Parlez-vous francais?", "clueBeretRed", Color.Crimson, 80) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("White beret", "Parlez-vous francais?", "clueBeretWhite", Color.White, 80) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("A powdered wig", "A big do about nothing.", "cluePowderedWig", Color.White, 2000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Beanie", "Weeeeeee!", "clueBeanie", Color.Yellow, 600) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Imp mask", "What mischief can I get up to with this?", "clueMaskImp", Color.Crimson, 2000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Goblin mask", "Let's start a flash mob!", "clueMaskGoblin", Color.ForestGreen, 2000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Sleeping cap", "A cap for wearing whilzzzzzzzzzz.", "clueSleepingCap", Color.SkyBlue, 2000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Flared trousers", "These'll help me stay alive.", "clueFlaredTrousers", Color.White, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Pantaloons", "Alas, someone has slashed my pantaloons.", "cluePantaloons", Color.Purple, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Black cane", "A ruby topped cane.", "clueCaneBlack", Color.DimGray, 600) { EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 10, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Staff of Bob the Cat", "A staff styled after the elusive cat.", "clueStaffBob", Color.DimGray, 600) { EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Amulet of power", "An enchanted diamond amulet of magic.", "clueAmuletPowerT", Color.White, 7200) { CosmeticNote = "t", EquipSlot = "Amulet", MiscString = "OffenseBoost", EquipTier = 2 });
                itemsToAdd.Add(new Item("Ham joint", "A delicious joint of ham.", "clueHamJoint", Color.Pink, 1500) { EquipSlot = "Weapon",  EquipTier = 0, EquipSkill = "Attack", EquipLevel = 0, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Rain bow", "Short but effective and very colorful.", "clueRainbow", Color.White, 500) {
                    EquipSlot = "Weapon",
                    EquipTier = 1,
                    EquipLevel = 1, 
                    EquipDamageType = "RangedStandard",
                    EquipSkill = "Ranged",
                    EquipAmmo = "RangedStandard",
                    AttackSpeed = 0.75, 
                    TwoHanded = true
                });
                itemsToAdd.Add(new Item("Golden chef's hat", "What a perfectly reasonable hat.", "clueGoldenChefHat", Color.Goldenrod, 2) { EquipSlot = "Head", Cosmetic = true, CountsAsIDs = [ "chefHat" ] });
                itemsToAdd.Add(new Item("Golden chef's apron", "What a perfectly reasonable hat.", "clueGoldenChefApron", Color.Goldenrod, 2) { EquipSlot = "Body", Cosmetic = true, CountsAsIDs = [ "brownApron" ] });
                itemsToAdd.Add(new Item("Red elegant shirt", "A well made elegant men's red shirt.", "clueElegantShirtRed", Color.Maroon, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Red elegant blouse", "A well made elegant ladies' red blouse.", "clueElegantBlouseRed", Color.Maroon, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Red elegant legs", "A rather elegant pair of men's red pantaloons.", "clueElegantLegsRed", Color.Maroon, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Red elegant skirt", "A rather elegant red skirt.", "clueElegantSkirtRed", Color.Maroon, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Green elegant shirt", "A well made elegant men's green shirt.", "clueElegantShirtGreen", Color.SpringGreen, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Green elegant blouse", "A well made elegant ladies' green blouse.", "clueElegantBlouseGreen", Color.SpringGreen, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Green elegant legs", "A rather elegant pair of men's green pantaloons.", "clueElegantLegsGreen", Color.SpringGreen, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Green elegant skirt", "A rather elegant green skirt.", "clueElegantSkirtGreen", Color.SpringGreen, 2000) { EquipSlot = "Legs", Cosmetic = true }); 
                itemsToAdd.Add(new Item("Blue elegant shirt", "A well made elegant men's blue shirt.", "clueElegantShirtBlue", Color.SkyBlue, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Blue elegant blouse", "A well made elegant ladies' blue blouse.", "clueElegantBlouseBlue", Color.SkyBlue, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Blue elegant legs", "A rather elegant pair of men's blue pantaloons.", "clueElegantLegsBlue", Color.SkyBlue, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Blue elegant skirt", "A rather elegant blue skirt.", "clueElegantSkirtBlue", Color.SkyBlue, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Team cape zero", "Ooohhh look at the dirty colours...", "clueCapeTeamZero", Color.SlateGray, 50) { EquipSlot = "Cape", Cosmetic = true });
                itemsToAdd.Add(new Item("Team cape i", "Ooohhh look at the dirty colours...", "clueCapeTeamI", Color.SlateGray, 50) { EquipSlot = "Cape", Cosmetic = true });
                itemsToAdd.Add(new Item("Team cape x", "Ooohhh look at the dirty colours...", "clueCapeTeamX", Color.SlateGray, 50) { EquipSlot = "Cape", Cosmetic = true });
                itemsToAdd.Add(new Item("Cape of skulls", "Lets the person behind you know that you mean business.", "clueCapeSkulls", Color.SlateGray, 5000) { EquipSlot = "Cape", EquipTier = 5, MiscString = "DefenseAll" });
                itemsToAdd.Add(new Item("Monk's robe top", "I feel the gods don't enjoy my materialistic obsessions.", "clueTopMonkG", Color.SaddleBrown, 500) { CosmeticNote = "g", EquipSlot = "Body", MiscString = "PrayerBoost", EquipTier = 2 });
                itemsToAdd.Add(new Item("Monk's robe", "I feel the gods don't enjoy my materialistic obsessions.", "clueBottomMonkG", Color.SaddleBrown, 500) { CosmeticNote = "g", EquipSlot = "Legs", MiscString = "PrayerBoost", EquipTier = 2 });
                

                // Medium Clues
                itemsToAdd.Add(new Item("Clue scroll (medium)", "Hopefully leads to treasure.", "clueScrollMedium", 207, 185, 151, 0, false, false) {
                    UseString = "ClueMedium", 
                    ConsumedOnUse = false,
                    DestroyOnDrop = true
                });

                itemsToAdd.Add(new Item("Clue casket (medium)", "The treasure at the end of the hunt! What could be inside?", "casketMedium", 218, 165, 32, 0, true, false) {
                    UseString = "Casket",
                    UseString2 = "Medium",
                    UseInt = 10000,
                    DropTable = {
                        new ItemDrop("gnomishFirelighter", 1, 341, 1, 1),
                        new ItemDrop("compbowYew", 1, 341, 1, 1),
                        new ItemDrop("clueAmuletStrengthT", 1, 341, 1, 1),
                        new ItemDrop("clueBootsRanger", 1, 1133, 1, 1),
                        new ItemDrop("clueBootsWizard", 1, 1133, 1, 1),
                        new ItemDrop("clueSandalsHoly", 1, 1133, 1, 1),
                        new ItemDrop("clueSpikedManacles", 1, 1133, 1, 1),
                        new ItemDrop("clueBootsClimbingG", 1, 1133, 1, 1),
                        new ItemDrop("helmAdamantT", 1, 1133, 1, 1), new ItemDrop("helmAdamantG", 1, 1133, 1, 1), new ItemDrop("helmAdamantH", 1, 1133, 1, 1),
                        new ItemDrop("platebodyAdamantT", 1, 1133, 1, 1), new ItemDrop("kiteshieldAdamantT", 1, 1133, 1, 1),
                        new ItemDrop("platelegsAdamantT", 1, 1133, 1, 1), new ItemDrop("plateskirtAdamantT", 1, 1133, 1, 1),  
                        new ItemDrop("platebodyAdamantG", 1, 1133, 1, 1), new ItemDrop("kiteshieldAdamantG", 1, 1133, 1, 1),
                        new ItemDrop("platelegsAdamantG", 1, 1133, 1, 1), new ItemDrop("plateskirtAdamantG", 1, 1133, 1, 1),  
                        new ItemDrop("platebodyAdamantH", 1, 1133, 1, 1), new ItemDrop("kiteshieldAdamantH", 1, 1133, 1, 1), 
                        new ItemDrop("platelegsAdamantH", 1, 1133, 1, 1), new ItemDrop("plateskirtAdamantH", 1, 1133, 1, 1),
                        new ItemDrop("helmMithrilT", 1, 1133, 1, 1), new ItemDrop("helmMithrilG", 1, 1133, 1, 1), new ItemDrop("helmMithrilH", 1, 1133, 1, 1),
                        new ItemDrop("platebodyMithrilT", 1, 1133, 1, 1), new ItemDrop("kiteshieldMithrilT", 1, 1133, 1, 1),
                        new ItemDrop("platelegsMithrilT", 1, 1133, 1, 1), new ItemDrop("plateskirtMithrilT", 1, 1133, 1, 1),  
                        new ItemDrop("platebodyMithrilG", 1, 1133, 1, 1), new ItemDrop("kiteshieldMithrilG", 1, 1133, 1, 1),
                        new ItemDrop("platelegsMithrilG", 1, 1133, 1, 1), new ItemDrop("plateskirtMithrilG", 1, 1133, 1, 1),  
                        new ItemDrop("platebodyMithrilH", 1, 1133, 1, 1), new ItemDrop("kiteshieldMithrilH", 1, 1133, 1, 1), 
                        new ItemDrop("platelegsMithrilH", 1, 1133, 1, 1), new ItemDrop("plateskirtMithrilH", 1, 1133, 1, 1),
                        new ItemDrop("bodyGreenDragonhideT", 1, 1133, 1, 1), new ItemDrop("chapsGreenDragonhideT", 1, 1133, 1, 1),
                        new ItemDrop("bodyGreenDragonhideG", 1, 1133, 1, 1), new ItemDrop("chapsGreenDragonhideG", 1, 1133, 1, 1),
                        new ItemDrop("clueSaradominMitre", 1, 1133, 1, 1), new ItemDrop("clueSaradominCloak", 1, 1133, 1, 1),
                        new ItemDrop("clueGuthixMitre", 1, 1133, 1, 1), new ItemDrop("clueGuthixCloak", 1, 1133, 1, 1),
                        new ItemDrop("clueZamorakMitre", 1, 1133, 1, 1), new ItemDrop("clueZamorakCloak", 1, 1133, 1, 1),
                        new ItemDrop("clueAncientMitre", 1, 1133, 1, 1), new ItemDrop("clueAncientCloak", 1, 1133, 1, 1), new ItemDrop("clueAncientStole", 1, 1133, 1, 1), new ItemDrop("clueAncientCrozier", 1, 1133, 1, 1),
                        new ItemDrop("clueArmadylMitre", 1, 1133, 1, 1), new ItemDrop("clueArmadylCloak", 1, 1133, 1, 1), new ItemDrop("clueArmadylStole", 1, 1133, 1, 1), new ItemDrop("clueArmadylCrozier", 1, 1133, 1, 1),
                        new ItemDrop("clueBandosMitre", 1, 1133, 1, 1), new ItemDrop("clueBandosCloak", 1, 1133, 1, 1), new ItemDrop("clueBandosStole", 1, 1133, 1, 1), new ItemDrop("clueBandosCrozier", 1, 1133, 1, 1),
                        new ItemDrop("clueBoaterRed", 1, 1133, 1, 1), new ItemDrop("clueBoaterGreen", 1, 1133, 1, 1), new ItemDrop("clueBoaterOrange", 1, 1133, 1, 1), new ItemDrop("clueBoaterBlack", 1, 1133, 1, 1),
                        new ItemDrop("clueBoaterBlue", 1, 1133, 1, 1), new ItemDrop("clueBoaterPink", 1, 1133, 1, 1), new ItemDrop("clueBoaterPurple", 1, 1133, 1, 1), new ItemDrop("clueBoaterWhite", 1, 1133, 1, 1),
                        new ItemDrop("clueHeadbandRed", 1, 1133, 1, 1), new ItemDrop("clueHeadbandGreen", 1, 1133, 1, 1), new ItemDrop("clueHeadbandOrange", 1, 1133, 1, 1), new ItemDrop("clueHeadbandBlack", 1, 1133, 1, 1),
                        new ItemDrop("clueHeadbandBlue", 1, 1133, 1, 1), new ItemDrop("clueHeadbandPink", 1, 1133, 1, 1), new ItemDrop("clueHeadbandPurple", 1, 1133, 1, 1), new ItemDrop("clueHeadbandWhite", 1, 1133, 1, 1),
                        new ItemDrop("clueCrierHat", 1, 1133, 1, 1), new ItemDrop("clueCrierCoat", 1, 1133, 1, 1), new ItemDrop("clueCrierBell", 1, 1133, 1, 1), new ItemDrop("clueCaneAdamant", 1, 1133, 1, 1),
                        new ItemDrop("clueBannerArceuus", 1, 1133, 1, 1), new ItemDrop("clueBannerPiscarilius", 1, 1133, 1, 1), new ItemDrop("clueBannerHosidius", 1, 1133, 1, 1), new ItemDrop("clueBannerShayzien", 1, 1133, 1, 1), new ItemDrop("clueBannerLovakengj", 1, 1133, 1, 1),
                        new ItemDrop("clueShieldCabbage", 1, 1133, 1, 1),
                        new ItemDrop("clueMaskCat", 1, 1133, 1, 1), new ItemDrop("clueMaskPenguin", 1, 1133, 1, 1), new ItemDrop("clueMaskWolf", 1, 1133, 1, 1),
                        new ItemDrop("clueHatLeprechaun", 1, 1133, 1, 1), new ItemDrop("clueHatLeprechaunBlack", 1, 1133, 1, 1), new ItemDrop("clueCloakWolf", 1, 1133, 1, 1),
                        new ItemDrop("clueMaskUnicorn", 1, 2266, 1, 1), new ItemDrop("clueMaskUnicornBlack", 1, 2266, 1, 1), 
                        new ItemDrop("clueElegantShirtPurple", 1, 2266, 1, 1), new ItemDrop("clueElegantBlousePurple", 1, 2266, 1, 1), new ItemDrop("clueElegantLegsPurple", 1, 2266, 1, 1), new ItemDrop("clueElegantSkirtPurple", 1, 2266, 1, 1),
                        new ItemDrop("clueElegantShirtBlack", 1, 2266, 1, 1), new ItemDrop("clueElegantBlouseWhite", 1, 2266, 1, 1), new ItemDrop("clueElegantLegsBlack", 1, 2266, 1, 1), new ItemDrop("clueElegantSkirtWhite", 1, 2266, 1, 1),
                        new ItemDrop("clueElegantShirtPink", 1, 2266, 1, 1), new ItemDrop("clueElegantBlousePink", 1, 2266, 1, 1), new ItemDrop("clueElegantLegsPink", 1, 2266, 1, 1), new ItemDrop("clueElegantSkirtPink", 1, 2808, 1, 1),
                        new ItemDrop("clueElegantShirtGold", 1, 2266, 1, 1), new ItemDrop("clueElegantBlouseGold", 1, 2266, 1, 1), new ItemDrop("clueElegantLegsGold", 1, 2266, 1, 1), new ItemDrop("clueElegantSkirtGold", 1, 2808, 1, 1),
                        new ItemDrop("helmAdamant", 1, 34, 1, 1), new ItemDrop("platebodyAdamant", 1, 34, 1, 1), new ItemDrop("platelegsAdamant", 1, 34, 1, 1), new ItemDrop("swordAdamant", 1, 34, 1, 1),
                        new ItemDrop("daggerAdamant", 1, 34, 1, 1), new ItemDrop("battleaxeAdamant", 1, 34, 1, 1), new ItemDrop("hatchetAdamant", 1, 34, 1, 1), new ItemDrop("pickaxeAdamant", 1, 34, 1, 1),
                        new ItemDrop("bodyGreenDragonhide", 1, 34, 1, 1), new ItemDrop("chapsGreenDragonhide", 1, 34, 1, 1),
                        new ItemDrop("shortbowYew", 1, 34, 1, 1), new ItemDrop("battlestaffFire", 1, 34, 1, 1), new ItemDrop("longbowYew", 1, 38, 1, 1), new ItemDrop("amuletPower", 1, 38, 1, 1),
                        new ItemDrop("runeAir", 1, 34, 50, 100), new ItemDrop("runeMind", 1, 34, 50, 100), new ItemDrop("runeWater", 1, 34, 50, 100), new ItemDrop("runeEarth", 1, 34, 50, 100), new ItemDrop("runeFire", 1, 34, 50, 100),
                        new ItemDrop("runeChaos", 1, 34, 10, 20), new ItemDrop("runeNature", 1, 34, 10, 20), new ItemDrop("runeLaw", 1, 34, 10, 20), new ItemDrop("runeDeath", 1, 34, 10, 20),
                        new ItemDrop("cluePurpleSweets", 1, 34, 2, 6, altlog: "General"),
                        new ItemDrop("clueFirelighterRed", 1, 189, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterGreen", 1, 189, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterBlue", 1, 189, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterPurple", 1, 189, 3, 5, altlog: "General"),
                        new ItemDrop("clueFirelighterWhite", 1, 189, 3, 5, altlog: "General"),
                        new ItemDrop("clueChargeDragonstoneScroll", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportNardah", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportMosLeHarmless", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportMortton", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportFeldipHills", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportLunar", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportDigsite", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportPiscatoris", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportPestControl", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportTaiBwoWannai", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportLumberyard", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueTeleportIorwerthCamp", 1, 429, 5, 15, altlog: "General"),
                        new ItemDrop("clueMasterScrollBook", 1, 750, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin1", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin2", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin3", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageSaradomin4", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak1", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak2", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak3", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageZamorak4", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix1", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix2", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix3", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageGuthix4", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos1", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos2", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos3", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageBandos4", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl1", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl2", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl3", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageArmadyl4", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient1", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient2", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient3", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("cluePageAncient4", 1, 818, 1, 1, altlog: "General"),
                        new ItemDrop("clueHolyBlessing", 1, 682, 1, 1, altlog: "General"),
                        new ItemDrop("clueUnholyBlessing", 1, 682, 1, 1, altlog: "General"),
                        new ItemDrop("cluePeacefulBlessing", 1, 682, 1, 1, altlog: "General"),
                        new ItemDrop("clueWarBlessing", 1, 682, 1, 1, altlog: "General"),
                        new ItemDrop("clueHonourableBlessing", 1, 682, 1, 1, altlog: "General"),
                        new ItemDrop("clueAncientBlessing", 1, 682, 1, 1, altlog: "General"),
                        new ItemDrop("clueScrollMaster", 1, 30, 1, 1, altlog: "General")
                    }
                });

                // Medium Uniques
                itemsToAdd.Add(new Item("Gnomish firelighter", "A tinderbox of the highest gnomish craftsmanship.", "gnomishFirelighter", Color.SaddleBrown, 2000) { CountsAsIDs = ["tinderbox"] });
                
                itemsToAdd.Add(new Item("Purple elegant shirt", "A well made elegant men's purple shirt.", "clueElegantShirtPurple", Color.MediumPurple, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Purple elegant blouse", "A well made elegant ladies' purple blouse.", "clueElegantBlousePurple", Color.MediumPurple, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Purple elegant legs", "A rather elegant pair of men's purple pantaloons.", "clueElegantLegsPurple", Color.MediumPurple, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Purple elegant skirt", "A rather elegant purple skirt.", "clueElegantSkirtPurple", Color.MediumPurple, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Black elegant shirt", "A well made elegant men's black shirt.", "clueElegantShirtBlack", Color.DimGray, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("White elegant blouse", "A well made elegant ladies' white blouse.", "clueElegantBlouseWhite", Color.White, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Black elegant legs", "A rather elegant pair of men's black pantaloons.", "clueElegantLegsBlack", Color.DimGray, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("White elegant skirt", "A rather elegant white skirt.", "clueElegantSkirtWhite", Color.White, 2000) { EquipSlot = "Legs", Cosmetic = true }); 
                itemsToAdd.Add(new Item("Pink elegant shirt", "A well made elegant men's pink shirt.", "clueElegantShirtPink", Color.HotPink, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Pink elegant blouse", "A well made elegant ladies' pink blouse.", "clueElegantBlousePink", Color.HotPink, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Pink elegant legs", "A rather elegant pair of men's pink pantaloons.", "clueElegantLegsPink", Color.HotPink, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Pink elegant skirt", "A rather elegant pink skirt.", "clueElegantSkirtPink", Color.HotPink, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Gold elegant shirt", "A well made elegant men's gold shirt.", "clueElegantShirtGold", Color.Goldenrod, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Gold elegant blouse", "A well made elegant ladies' gold blouse.", "clueElegantBlouseGold", Color.Goldenrod, 2000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Gold elegant legs", "A rather elegant pair of men's gold pantaloons.", "clueElegantLegsGold", Color.Goldenrod, 2000) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Gold elegant skirt", "A rather elegant gold skirt.", "clueElegantSkirtGold", Color.Goldenrod, 2000) { EquipSlot = "Legs", Cosmetic = true });
                
                itemsToAdd.Add(new Item("Ranger boots", "Lightweight boots ideal for rangers.", "clueBootsRanger", Color.ForestGreen, 1000000) { EquipSlot = "Feet", EquipSkill = "Ranged", EquipLevel = 40, EquipTier = 5, MiscString = "PowerRange" });
                itemsToAdd.Add(new Item("Wizard boots", "Slightly magical boots.", "clueBootsWizard",  0, 157, 196, 1000000) { EquipSlot = "Feet", EquipSkill = "Magic", EquipLevel = 40, EquipTier = 5, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Holy sandals", "Holy footwear!", "clueSandalsHoly",  Color.White, 1000000) { EquipSlot = "Feet", EquipSkill = "Prayer", EquipLevel = 31, EquipTier = 2, MiscString = "PrayerBoost" });
                itemsToAdd.Add(new Item("Holy moleys", "The lesser spotted Talpidae Saradominus.", "clueHolyMoleys",  Color.SaddleBrown, 2000000) { EquipSlot = "Feet", EquipSkill = "Prayer", EquipLevel = 31, EquipTier = 2, MiscString = "PrayerBoost" });
                itemsToAdd.Add(new Item("Spiked manacles", "Some very spiky metal bands, better make sure I don't cut myself while walking.", "clueSpikedManacles",  Color.DimGray, 1000000) { EquipSlot = "Feet", EquipTier = 4, MiscString = "StrengthBoost" });
                itemsToAdd.Add(new Item("Climbing boots", "Boots made for climbing. Nice Trim!", "clueBootsClimbingG",  Color.Gray, 75000) { CosmeticNote = "g", EquipSlot = "Feet", EquipTier = 2, MiscString = "StrengthBoost" });
                
                itemsToAdd.Add(new Item("Red boater", "Stylish!", "clueBoaterRed",  Color.Crimson, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Green boater", "Stylish!", "clueBoaterGreen",  Color.Lime, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Orange boater", "Stylish!", "clueBoaterOrange",  Color.Orange, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Black boater", "Stylish!", "clueBoaterBlack",  Color.DimGray, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Blue boater", "Stylish!", "clueBoaterBlue",  Color.CadetBlue, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Pink boater", "Stylish!", "clueBoaterPink",  Color.HotPink, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Purple boater", "Stylish!", "clueBoaterPurple",  Color.Purple, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("White boater", "Stylish!", "clueBoaterWhite",  Color.White, 5000) { EquipSlot = "Head", Cosmetic = true });
                
                itemsToAdd.Add(new Item("Red headband", "Stylish!", "clueHeadbandRed",  Color.Crimson, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Green headband", "Stylish!", "clueHeadbandGreen",  Color.Lime, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Orange headband", "Stylish!", "clueHeadbandOrange",  Color.Orange, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Black headband", "Stylish!", "clueHeadbandBlack",  Color.DimGray, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Blue headband", "Stylish!", "clueHeadbandBlue",  Color.CadetBlue, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Pink headband", "Stylish!", "clueHeadbandPink",  Color.HotPink, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Purple headband", "Stylish!", "clueHeadbandPurple",  Color.Purple, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("White headband", "Stylish!", "clueHeadbandWhite",  Color.White, 5000) { EquipSlot = "Head", Cosmetic = true });
                 
                itemsToAdd.Add(new Item("Crier hat", "Hear ye! Hear ye!", "clueCrierHat",  Color.SkyBlue, 5000) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Crier coat", "Don't shoot the messenger!", "clueCrierCoat",  Color.SkyBlue, 5000) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Crier bell", "For whom?", "clueCrierBell",  Color.Goldenrod, 5000) { EquipSlot = "Weapon", Cosmetic = true, UseString = "Bell", ConsumedOnUse = false });
                itemsToAdd.Add(new Item("Adamant cane", "A diamond topped cane.", "clueCaneAdamant", ColorLib.Adamant, 1440) { EquipSlot = "Weapon",  EquipTier = 5, EquipSkill = "Attack", EquipLevel = 40, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Arceuus banner", "An ancient banner bearing the mark of the Arceuus Elders.", "clueBannerArceuus", Color.CadetBlue, 10000) { EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 1, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Piscarilius banner", "A stained glass banner displaying the Piscarilius sigil.", "clueBannerPiscarilius", Color.Yellow, 10000) { EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 1, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Hosidius banner", "A banned made of redwood bearing the Hosidius sigil.", "clueBannerHosidius", Color.Purple, 10000) { EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 1, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Shayzien banner", "A war torn banner bearing the Shayzien sigil.", "clueBannerShayzien", Color.Crimson, 10000) { EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 1, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Arceuus banner", "A lovekite banner bearing the Lovakengj sigil.", "clueBannerLovakengj", Color.Orange, 10000) { EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 1, EquipDamageType = "Crush" });
                itemsToAdd.Add(new Item("Cabbage roung shield", "An adamant shield shaped like a cabbage.", "clueShieldCabbage",  Color.Lime, 5000) { EquipSlot = "Offhand", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "DefenseMelee" });
                itemsToAdd.Add(new Item("Cat mask", "Miaow!", "clueMaskCat", Color.DarkGray, 2400) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Penguin mask", "Thankfully this doesn't reset every week.", "clueMaskPenguin", Color.DimGray, 2400) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Leprechaun hat", "Top o' the morning!", "clueHatLeprechaun", Color.ForestGreen, 2400) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Black leprechaun hat", "Try as they will, and try as they might, who steals me gold won't live through the night.", "clueHatLeprechaunBlack", Color.DimGray, 2400) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Wolf mask", "Howwwallll!", "clueMaskWolf", Color.Gray, 2400) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Wolf cloak", "A very warm wolf cloak.", "clueCloakWolf", Color.Gray, 2400) { EquipSlot = "Cape", Cosmetic = true });
                itemsToAdd.Add(new Item("Black unicorn mask", "Point shadows.", "clueMaskUnicornBlack", Color.DimGray, 2400) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Unicorn mask", "Point rainbows.", "clueMaskUnicorn", Color.DimGray, 2400) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Amulet of strength", "An enchanted ruby amulet of strength.", "clueAmuletStrengthT", Color.Crimson, 4600) { CosmeticNote = "t", EquipSlot = "Amulet", MiscString = "StrengthBoost", EquipTier = 5 });
                
                
                
                List<MaterialDef> Gods = new() {
                    new("Saradomin", Color.Turquoise, 3, 20, 5, "Holy"),
                    new("Guthix", Color.Green, 3, 10, 20, "Peaceful"),
                    new("Zamorak", Color.Crimson, 3, 20, 40, "Unholy"),
                    new("Ancient", Color.MediumPurple, 3, 20, 30, "Ancient"),
                    new("Armadyl", Color.White, 3, 20, 80, "Honourable"),
                    new("Bandos", Color.DarkGoldenrod, 6, 20, 85, "War")
                };

                foreach (var god in Gods) {
                    itemsToAdd.Add(new Item(god.Name + " robe top", god.Name + " vestments.", "clue" + god.Name + "Top", god.R, god.G, god.B, 7000) { EquipSlot = "Body", MiscString = "PrayerBoost", EquipTier = 2, EquipSkill = "Prayer", EquipLevel = 20 });
                    itemsToAdd.Add(new Item(god.Name + " robe legs", "Leggings from the " + god.Name + " vestments.", "clue" + god.Name + "Bottom", god.R, god.G, god.B, 7000) { EquipSlot = "Legs", MiscString = "PrayerBoost", EquipTier = 2, EquipSkill = "Prayer", EquipLevel = 20 });
                     
                    itemsToAdd.Add(new Item(god.Name + " mitre", "A" + (Helper.VowelStart(god.Name) ? "n " : "") + god.Name + " mitre.", "clue" + god.Name + "Mitre", god.R, god.G, god.B, 5000) { EquipSlot = "Head", MiscString = "PrayerBoost", EquipTier = 2, EquipSkill = "Prayer", EquipLevel = 40 });
                    itemsToAdd.Add(new Item(god.Name + " cloak", "A" + (Helper.VowelStart(god.Name) ? "n " : "") + god.Name + " cloak.", "clue" + god.Name + "Cloak", god.R, god.G, god.B, 2000) { EquipSlot = "Cape", MiscString = "PrayerBoost", EquipTier = 2, EquipSkill = "Prayer", EquipLevel = 40 });
                    itemsToAdd.Add(new Item(god.Name + " stole", "A" + (Helper.VowelStart(god.Name) ? "n " : "") + god.Name + " stole.", "clue" + god.Name + "Stole", god.R, god.G, god.B, 2500) { EquipSlot = "Amulet", MiscString = "PrayerBoost", EquipTier = 2, EquipSkill = "Prayer", EquipLevel = 60 });
                    
                    itemsToAdd.Add(new Item(god.Name + " crozier", "A" + (Helper.VowelStart(god.Name) ? "n " : "") + god.Name + " crozier.", "clue" + god.Name + "Crozier", god.R, god.G, god.B, 5000) { EquipSlot = "Weapon", MiscString = "PrayerBoost", EquipTier = 2, EquipSkill = "Prayer", EquipLevel = 60, EquipDamageType = "Crush" });
                    
                    
                    itemsToAdd.Add(new Item(god.Name + " page 1", "This seems to have been torn from a book...", "cluePage" + god.Name + "1", god.R, god.G, god.B, 200));
                    itemsToAdd.Add(new Item(god.Name + " page 2", "This seems to have been torn from a book...", "cluePage" + god.Name + "2", god.R, god.G, god.B, 200));
                    itemsToAdd.Add(new Item(god.Name + " page 3", "This seems to have been torn from a book...", "cluePage" + god.Name + "3", god.R, god.G, god.B, 200));
                    itemsToAdd.Add(new Item(god.Name + " page 4", "This seems to have been torn from a book...", "cluePage" + god.Name + "4", god.R, god.G, god.B, 200));
                    
                    itemsToAdd.Add(new Item(god.Descriptor + " blessing", "A" + (Helper.VowelStart(god.Descriptor) ? "n " : "") + god.Descriptor + " blessing.", "clue" + god.Descriptor + "Blessing", god.R, god.G, god.B, 80) { EquipSlot = "Ammo", MiscString = "PrayerBoost", EquipTier = 1, EquipSkill = "Prayer" });
                } 


                // General clue table 
                itemsToAdd.Add(new Item("Purple sweets", "Remember to brush after eating!", "cluePurpleSweets", Color.MediumPurple, 15, true) { UseString = "Heal", UseInt = 2 }); 
                itemsToAdd.Add(new Item("Red firelighter", "Makes firelighting a lot easier.", "clueFirelighterRed", Color.Maroon, 15, true)); 
                itemsToAdd.Add(new Item("Green firelighter", "Makes firelighting a lot easier.", "clueFirelighterGreen", ColorLib.Adamant, 15, true));  
                itemsToAdd.Add(new Item("Blue firelighter", "Makes firelighting a lot easier.", "clueFirelighterBlue", ColorLib.Mithril, 15, true));  
                itemsToAdd.Add(new Item("Purple firelighter", "Makes firelighting a lot easier.", "clueFirelighterPurple", Color.Purple, 15, true));  
                itemsToAdd.Add(new Item("White firelighter", "Makes firelighting a lot easier.", "clueFirelighterWhite", Color.White, 15, true));
                  
                itemsToAdd.Add(new Item("Charge dragonstone jewellery scroll", "A scroll for charging dragonstone jewellery.", "clueChargeDragonstoneScroll", Color.White, 200, true) { UseString = "ChargeDragonstone" });
                itemsToAdd.Add(new Item("Nardah teleport", "Teleports you to Nardah.", "clueTeleportNardah", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Mos le'harmless teleport", "Teleports you to Mos Le'Harmless.", "clueTeleportMosLeHarmless", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Mort'ton teleport", "Teleports you to Mort'ton.", "clueTeleportMortton", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Feldip hills teleport", "Teleports you to Feldip Hills.", "clueTeleportFeldipHills", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Lunar isle teleport", "Teleports you to Lunar isle.", "clueTeleportLunar", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Digsite teleport", "Teleports you to the Digsite.", "clueTeleportDigsite", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Piscatoris teleport", "Teleports you to Piscatoris.", "clueTeleportPiscatoris", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Pest control teleport", "Teleports you to Pest control.", "clueTeleportPestControl", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Tai bwo wannai teleport", "Teleports you to Tai bwo wannai.", "clueTeleportTaiBwoWannai", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Lumberyard teleport", "Teleports you to the Lumberyard.", "clueTeleportLumberyard", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Iorwerth camp teleport", "Teleports you to the Iorwerth Camp.", "clueTeleportIorwerthCamp", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
                itemsToAdd.Add(new Item("Master scroll book", "I can store my teleport scrolls in this.", "clueMasterScrollBook", Color.Khaki, 5000, true)); 
            }

            itemsToAdd.Add(new Item("Tutorial Island cape", "A cape signifying you completed all challenges on Tutorial Island. Congratulations!", "capeCompTI", 135, 206, 235, 0) { EquipSlot = "Cape", EquipTier = 1, MiscString = "OmniBoost" });
            itemsToAdd.Add(new Item("Defense skillcape", "The cape worn by masters of the art of Defense.", "capeSkillDefense", Color.CornflowerBlue, 0) { EquipSlot = "Cape", EquipTier = 2, MiscString = "OmniBoost" });
            itemsToAdd.Add(new Item("Cooking skillcape", "The cape worn by masters of the art of Cooking.", "capeSkillCooking", Color.Purple, 0) { EquipSlot = "Cape", EquipTier = 2, MiscString = "OmniBoost" });

            {
                // ordinary wizard
                itemsToAdd.Add(new Item("Blue wizard hat", "A silly pointed hat.", "wizardBlueHat", 0, 157, 196, 2) { EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard shirt", "I can do better magic in this.", "wizardBlueRobe", 0, 157, 196, 15) { EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard skirt", "I can do better magic in this.", "wizardBlueBottom", 0, 157, 196, 15) { EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard hat", "A silly pointed hat.", "wizardBlackHat", Color.DimGray, 2) { EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard shirt", "I can do better magic in this.", "wizardBlackRobe", Color.DimGray, 15) { EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard skirt", "I can do better magic in this.", "wizardBlackBottom", Color.DimGray, 15) { EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                
                // Desert robes
                itemsToAdd.Add(new Item("Fake beard", "Makes me itch.", "beardFake", Color.White, 1));
                itemsToAdd.Add(new Item("Kharidian headpiece", "Wear it on your head.", "kharidianHeadpiece", Color.White, 1));
                itemsToAdd.Add(new Item("Desert disguise", "A disguise suitable for the desert.", "desertDisguise", Color.White, 1) { EquipSlot = "Head", Cosmetic = true });
                itemsToAdd.Add(new Item("Desert shirt", "A cool, light desert shirt.", "desertShirt", Color.White, 40) { EquipSlot = "Body", Cosmetic = true });
                itemsToAdd.Add(new Item("Desert robe", "A cool, light desert robe.", "desertRobe", Color.White, 40) { EquipSlot = "Legs", Cosmetic = true });
                itemsToAdd.Add(new Item("Desert boots", "Comfortable desert shoes.", "desertBoots", Color.White, 20) { EquipSlot = "Feet", Cosmetic = true });
                
                // mystic (blue)
                itemsToAdd.Add(new Item("Mystic hat", "A magical hat.", "mysticHat", Color.Turquoise, 15000) { EquipSlot = "Head", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic robe top", "The upper half of a magical robe.", "mysticRobeTop", Color.Turquoise, 120000) { EquipSlot = "Body", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic robe bottom", "The lower half of a magical robe.", "mysticRobeBottom", Color.Turquoise, 80000) { EquipSlot = "Legs", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic gloves", "Magical gloves.", "mysticGloves", Color.Turquoise, 10000) { EquipSlot = "Hands", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic boots", "Magical boots.", "mysticBoots", Color.Turquoise, 10000) { EquipSlot = "Feet", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                // mystic (light)
                itemsToAdd.Add(new Item("Mystic hat (light)", "A bright magical hat.", "mysticHatLight", Color.White, 15000) { EquipSlot = "Head", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic robe top (light)", "The upper half of a bright magical robe.", "mysticRobeTopLight", Color.White, 120000) { EquipSlot = "Body", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic robe bottom (light)", "The lower half of a bright magical robe.", "mysticRobeBottomLight", Color.White, 80000) { EquipSlot = "Legs", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic gloves (light)", "Bright magical gloves.", "mysticGlovesLight", Color.White, 10000) { EquipSlot = "Hands", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic boots (light)", "Bright magical boots.", "mysticBootsLight", Color.White, 10000) { EquipSlot = "Feet", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                // mystic (dark)
                itemsToAdd.Add(new Item("Mystic hat (dark)", "A dark magical hat.", "mysticHatDark", Color.DimGray, 15000) { EquipSlot = "Head", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic robe top (dark)", "The upper half of a dark magical robe.", "mysticRobeTopDark", Color.DimGray, 120000) { EquipSlot = "Body", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic robe bottom (dark)", "The lower half of a dark magical robe.", "mysticRobeBottomDark", Color.DimGray, 80000) { EquipSlot = "Legs", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic gloves (dark)", "Dark magical gloves.", "mysticGlovesDark", Color.DimGray, 10000) { EquipSlot = "Hands", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Mystic boots (dark)", "Dark magical boots.", "mysticBootsDark", Color.DimGray, 10000) { EquipSlot = "Feet", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "PowerMagic" });
                 
                // infinity / mage arena reward
                itemsToAdd.Add(new Item("Infinity hat", "A magical hat.", "infinityHat", Color.Magenta, 17000) { EquipSlot = "Head", EquipTier = 6, EquipSkill = "Defense", EquipLevel = 50, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Infinity robe top", "The upper half of a magical robe.", "infinityRobeTop", Color.Magenta, 140000) { EquipSlot = "Body", EquipTier = 6, EquipSkill = "Defense", EquipLevel = 50, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Infinity robe bottom", "The lower half of a magical robe.", "infinityRobeBottom", Color.Magenta, 90000) { EquipSlot = "Legs", EquipTier = 6, EquipSkill = "Defense", EquipLevel = 50, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Infinity gloves", "Magical gloves.", "infinityGloves", Color.Magenta, 12000) { EquipSlot = "Hands", EquipTier = 6, EquipSkill = "Defense", EquipLevel = 50, MiscString = "PowerMagic" });
                itemsToAdd.Add(new Item("Infinity boots", "Magical boots.", "infinityBoots", Color.Magenta, 12000) { EquipSlot = "Feet", EquipTier = 6, EquipSkill = "Defense", EquipLevel = 50, MiscString = "PowerMagic" });
                

                // Splitbark
                itemsToAdd.Add(new Item("Split-bark helm", "A wooden helmet.", "helmSplitbark", Color.Khaki, 10000) { EquipSlot = "Head", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Split-bark body", "Provides good protection.", "bodySplitbark", Color.Khaki, 45000) { EquipSlot = "Body", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Split-bark legs", "These should protect my legs.", "legsSplitbark", Color.Khaki, 40000) { EquipSlot = "Legs", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Split-bark gauntlets", "These should keep my hands safe.", "gauntletsSplitbark", Color.Khaki, 5000) { EquipSlot = "Hands", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Split-bark boots", "Wooden foot protection.", "bootsSplitbark", Color.Khaki, 5000) { EquipSlot = "Feet", EquipTier = 5, EquipSkill = "Defense", EquipLevel = 40, MiscString = "DefenseMagic" });
                 
                // Trimmed regular wizard
                itemsToAdd.Add(new Item("Blue wizard hat", "A silly pointed hat. Trimmed.", "wizardBlueHatT", 0, 157, 196, 4) { CosmeticNote = "t", EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard shirt", "I can do better magic in this. Trimmed.", "wizardBlueRobeT", 0, 157, 196, 30) { CosmeticNote = "t", EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard skirt", "I can do better magic in this. Trimmed.", "wizardBlueBottomT", 0, 157, 196, 30) { CosmeticNote = "t", EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard hat", "A silly pointed hat. Trimmed.", "wizardBlackHatT", Color.DimGray, 4) { CosmeticNote = "t", EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard shirt", "I can do better magic in this. Trimmed.", "wizardBlackRobeT", Color.DimGray, 30) { CosmeticNote = "t", EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard skirt", "I can do better magic in this. Trimmed.", "wizardBlackBottomT", Color.DimGray, 30) { CosmeticNote = "t", EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                
                // Gold trimmed regular wizard
                itemsToAdd.Add(new Item("Blue wizard hat", "A silly pointed hat. Trimmed with gold.", "wizardBlueHatG", 0, 157, 196, 4) { CosmeticNote = "g", EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard shirt", "I can do better magic in this. Trimmed with gold.", "wizardBlueRobeG", 0, 157, 196, 30) { CosmeticNote = "g", EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard skirt", "I can do better magic in this. Trimmed with gold.", "wizardBlueBottomG", 0, 157, 196, 30) { CosmeticNote = "g", EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard hat", "A silly pointed hat. Trimmed with gold.", "wizardBlackHatG", Color.DimGray, 4) { CosmeticNote = "g", EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard shirt", "I can do better magic in this. Trimmed with gold.", "wizardBlackRobeG", Color.DimGray, 30) { CosmeticNote = "g", EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard skirt", "I can do better magic in this. Trimmed with gold.", "wizardBlackBottomG", Color.DimGray, 30) { CosmeticNote = "g", EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
            }

            itemsToAdd.Add(new Item("Staff", "It's a slightly magical stick.", "staff", Color.BurlyWood, 15) { EquipSlot = "Weapon",  EquipTier = 0, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Magic staff", "It's a slightly magical stick.", "staffMagic", Color.BurlyWood, 200) { EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Beginner wand", "A beginner level wand.", "wandBeginner", Color.BurlyWood, 1200) { EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Magic", EquipLevel = 30, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Apprentice wand", "An apprentice level wand.", "wandApprentice", Color.BurlyWood, 2400) { EquipSlot = "Weapon",  EquipTier = 5, EquipSkill = "Magic", EquipLevel = 40, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Teacher wand", "A teacher level wand.", "wandTeacher", Color.BurlyWood, 4800) { EquipSlot = "Weapon",  EquipTier = 6, EquipSkill = "Magic", EquipLevel = 50, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Master wand", "A master level wand.", "wandMaster", Color.BurlyWood, 100000) { EquipSlot = "Weapon",  EquipTier = 7, EquipSkill = "Magic", EquipLevel = 60, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Mage's book", "The magical book of a mage.", "magesBook", Color.Crimson, 100000) { EquipSlot = "Offhand",  EquipTier = 3, EquipSkill = "Magic", EquipLevel = 60, EquipDamageType = "Crush" });
            
            itemsToAdd.Add(new Item("Rune pouch", "You can store runes in here.", "pouchRune", Color.SaddleBrown, 100000, trade: false) { EquipSlot = "Pocket", EquipSkill = "Magic", EquipLevel = 66, UseString = "ViewInventory", ConsumedOnUse = false, ContainerSlots = 3, ContainableIDs = [ "runeAir","runeWater","runeEarth","runeFire","runeMind","runeBody","runeCosmic","runeChaos","runeAstral","runeNature","runeLaw","runeDeath","runeBlood","runeSoul","runeWrath","runeMist","runeDust","runeMud","runeSmoke","runeSteam","runeLava" ] });
            

            itemsToAdd.Add(new Item("Chef's hat", "What a silly hat.", "chefHat", 255, 255, 255, 2) { EquipSlot = "Head", Cosmetic = true });
            itemsToAdd.Add(new Item("White apron", "What a silly hat.", "whiteApron", 255, 255, 255, 2) { EquipSlot = "Body", Cosmetic = true });
            itemsToAdd.Add(new Item("Brown apron", "A mostly clean apron.", "brownApron", Color.SaddleBrown, 2) { EquipSlot = "Body", Cosmetic = true });
            itemsToAdd.Add(new Item("Goblin mail", "Some brown armor designed to fit goblins.", "goblinMail", Color.SaddleBrown, 40));
            itemsToAdd.Add(new Item("Goblin book", "A tattered goblin holy book.", "goblinBook", Color.SaddleBrown, 1) { UseString = "Book", UseString2 = "Goblin", ConsumedOnUse = false });


            // Farming - Seeds, Products, Direct Cooked Product
            {
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
                    itemsToAdd.Add(new Item("Grimy guam leaf", "It needs cleaning.", "herbGrimyGuam", ColorLib.Guam, 13) { UseString = "CleanHerb", UseString2 = "herbCleanGuam", UseInt = 1, UseInt2 = 3 }); 
                    itemsToAdd.Add(new Item("Guam leaf", "A bitter green herb.", "herbCleanGuam", ColorLib.Guam.GetBright(), 13)); 
                 
                    // Tarromin
                    itemsToAdd.Add(new Item("Tarromin seed", "A tarromin seed - plant in an herb patch. (5)", "seedTarromin", Color.Lime, 10, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyTarromin",
                        UseInt = 5 /* Level */,  UseInt2 = 30 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy tarromin", "It needs cleaning.", "herbGrimyTarromin", ColorLib.Tarromin.GetDark(), 13) { UseString = "CleanHerb", UseString2 = "herbCleanTarromin", UseInt = 5, UseInt2 = 4 }); 
                    itemsToAdd.Add(new Item("Tarromin", "A fresh herb.", "herbCleanTarromin", ColorLib.Tarromin, 13)); 
                 
                    // Marrentill
                    itemsToAdd.Add(new Item("Marrentill seed", "A marrentill seed - plant in an herb patch. (7)", "seedMarrentill", Color.Green, 11, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyMarrentill",
                        UseInt = 9 /* Level */,  UseInt2 = 40 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy marrentill", "It needs cleaning.", "herbGrimyMarrentill", ColorLib.Marrentill.GetDark(), 13) { UseString = "CleanHerb", UseString2 = "herbCleanMarrentill", UseInt = 9, UseInt2 = 5 }); 
                    itemsToAdd.Add(new Item("Marrentill", "A fresh herb.", "herbCleanMarrentill", ColorLib.Marrentill, 13)); 

                    // Harralander
                    itemsToAdd.Add(new Item("Harralander seed", "A harralander seed - plant in an herb patch. (20)", "seedHarralander", Color.SeaGreen, 15, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyHarralander",
                        UseInt = 20 /* Level */,  UseInt2 = 50 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy harralander", "It needs cleaning.", "herbGrimyHarralander", ColorLib.Harralander.GetDark(), 13) { UseString = "CleanHerb", UseString2 = "herbCleanHarralander", UseInt = 20, UseInt2 = 6 }); 
                    itemsToAdd.Add(new Item("Harralander", "A fresh herb.", "herbCleanHarralander", ColorLib.Harralander, 13));

                    // Ranarr
                    itemsToAdd.Add(new Item("Ranarr seed", "A ranarr seed - plant in an herb patch. (25)", "seedRanarr", Color.DarkOliveGreen, 15, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyRanarr",
                        UseInt = 25 /* Level */,  UseInt2 = 60 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy ranarr", "It needs cleaning.", "herbGrimyRanarr", ColorLib.Ranarr.GetDark(), 25) { UseString = "CleanHerb", UseString2 = "herbCleanRanarr", UseInt = 25, UseInt2 = 7 }); 
                    itemsToAdd.Add(new Item("Ranarr", "A fresh herb.", "herbCleanRanarr", ColorLib.Ranarr, 25));

                    // Toadflax
                    itemsToAdd.Add(new Item("Toadflax seed", "A toadflax seed - plant in an herb patch. (30)", "seedToadflax", Color.Green, 34, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyToadflax",
                        UseInt = 30 /* Level */,  UseInt2 = 70 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy toadflax", "It needs cleaning.", "herbGrimyToadflax", ColorLib.Toadflax.GetDark(), 25) { UseString = "CleanHerb", UseString2 = "herbCleanToadflax", UseInt = 30, UseInt2 = 8 }); 
                    itemsToAdd.Add(new Item("Toadflax", "A fresh herb.", "herbCleanToadflax", ColorLib.Toadflax, 25));

                    // Spirit weed
                    itemsToAdd.Add(new Item("Spirit weed seed", "A spirit weed seed - plant in an herb patch. (35)", "seedSpiritweed", Color.LawnGreen, 18, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimySpiritweed",
                        UseInt = 35 /* Level */,  UseInt2 = 80 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy spirit weed", "It needs cleaning.", "herbGrimySpiritweed", ColorLib.Spiritweed.GetDark(), 25) { UseString = "CleanHerb", UseString2 = "herbCleanSpiritweed", UseInt = 35, UseInt2 = 9 }); 
                    itemsToAdd.Add(new Item("Spirit weed", "A fresh herb.", "herbCleanSpiritweed", ColorLib.Spiritweed, 25));

                    // Irit
                    itemsToAdd.Add(new Item("Irit seed", "An irit seed - plant in an herb patch. (40)", "seedIrit", Color.LawnGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyIrit",
                        UseInt = 40 /* Level */,  UseInt2 = 90 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy irit", "It needs cleaning.", "herbGrimyIrit", ColorLib.Irit.GetDark(), 40) { UseString = "CleanHerb", UseString2 = "herbCleanIrit", UseInt = 40, UseInt2 = 9 }); 
                    itemsToAdd.Add(new Item("Irit", "A fresh herb.", "herbCleanIrit", ColorLib.Irit, 40));

                    // Wergali
                    itemsToAdd.Add(new Item("Wergali seed", "A wergali seed - plant in an herb patch. (41)", "seedWergali", Color.Crimson, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyWergali",
                        UseInt = 41 /* Level */,  UseInt2 = 100 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy wergali", "It needs cleaning.", "herbGrimyWergali", ColorLib.Wergali.GetDark(), 44) { UseString = "CleanHerb", UseString2 = "herbCleanWergali", UseInt = 41, UseInt2 = 9 }); 
                    itemsToAdd.Add(new Item("Wergali", "A fresh herb.", "herbCleanWergali", ColorLib.Wergali, 44));

                    // Avantoe
                    itemsToAdd.Add(new Item("Avantoe seed", "A avantoe seed - plant in an herb patch. (48)", "seedAvantoe", Color.SpringGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyAvantoe",
                        UseInt = 48 /* Level */,  UseInt2 = 110 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy avantoe", "It needs cleaning.", "herbGrimyAvantoe", ColorLib.Avantoe.GetDark(), 48) { UseString = "CleanHerb", UseString2 = "herbCleanAvantoe", UseInt = 48, UseInt2 = 10 }); 
                    itemsToAdd.Add(new Item("Avantoe", "A fresh herb.", "herbCleanAvantoe", ColorLib.Avantoe, 48));

                    // Kwuarm
                    itemsToAdd.Add(new Item("Kwuarm seed", "A kwuarm seed - plant in an herb patch. (54)", "seedKwuarm", Color.Olive, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyKwuarm",
                        UseInt = 54 /* Level */,  UseInt2 = 120 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy kwuarm", "It needs cleaning.", "herbGrimyKwuarm", ColorLib.Kwuarm.GetDark(), 48) { UseString = "CleanHerb", UseString2 = "herbCleanKwuarm", UseInt = 54, UseInt2 = 11 }); 
                    itemsToAdd.Add(new Item("Kwuarm", "A fresh herb.", "herbCleanKwuarm", ColorLib.Kwuarm, 48));

                    // Bloodweed
                    itemsToAdd.Add(new Item("Bloodweed seed", "A bloodweed seed - plant in an herb patch. (57)", "seedBloodweed", Color.Crimson, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyBloodweed",
                        UseInt = 57 /* Level */,  UseInt2 = 130 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy bloodweed", "It needs cleaning.", "herbGrimyBloodweed", ColorLib.Bloodweed.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanBloodweed", UseInt = 57, UseInt2 = 12 }); 
                    itemsToAdd.Add(new Item("Bloodweed", "A fresh herb.", "herbCleanBloodweed", ColorLib.Bloodweed, 100));

                    // Snapdragon
                    itemsToAdd.Add(new Item("Snapdragon seed", "A snapdragon seed - plant in an herb patch. (59)", "seedSnapdragon", Color.Orange, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimySnapdragon",
                        UseInt = 59 /* Level */,  UseInt2 = 150 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy snapdragon", "It needs cleaning.", "herbGrimySnapdragon", ColorLib.Snapdragon.GetDark(), 60) { UseString = "CleanHerb", UseString2 = "herbCleanSnapdragon", UseInt = 59, UseInt2 = 12 }); 
                    itemsToAdd.Add(new Item("Snapdragon", "A fresh herb.", "herbCleanSnapdragon", ColorLib.Snapdragon, 60));

                    // Cadantine
                    itemsToAdd.Add(new Item("Cadantine seed", "A cadantine seed - plant in an herb patch. (65)", "seedCadantine", Color.YellowGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyCadantine",
                        UseInt = 65 /* Level */,  UseInt2 = 180 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy cadantine", "It needs cleaning.", "herbGrimyCadantine", ColorLib.Cadantine.GetDark(), 65) { UseString = "CleanHerb", UseString2 = "herbCleanCadantine", UseInt = 65, UseInt2 = 13 }); 
                    itemsToAdd.Add(new Item("Cadantine", "A fresh herb.", "herbCleanCadantine", ColorLib.Cadantine, 65));

                    // Lantadyme
                    itemsToAdd.Add(new Item("Lantadyme seed", "A lantadyme seed - plant in an herb patch. (67)", "seedLantadyme", Color.Teal, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyLantadyme",
                        UseInt = 67 /* Level */,  UseInt2 = 220 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy lantadyme", "It needs cleaning.", "herbGrimyLantadyme", ColorLib.Lantadyme.GetDark(), 70) { UseString = "CleanHerb", UseString2 = "herbCleanLantadyme", UseInt = 67, UseInt2 = 13 }); 
                    itemsToAdd.Add(new Item("Lantadyme", "A fresh herb.", "herbCleanLantadyme", ColorLib.Lantadyme, 70));

                    // Dwarf weed
                    itemsToAdd.Add(new Item("Dwarf weed seed", "A dwarf weed seed - plant in an herb patch. (70)", "seedDwarfweed", Color.ForestGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyDwarfweed",
                        UseInt = 70 /* Level */,  UseInt2 = 220 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy dwarf weed", "It needs cleaning.", "herbGrimyDwarfweed", ColorLib.Dwarfweed.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanDwarfweed", UseInt = 70, UseInt2 = 14 }); 
                    itemsToAdd.Add(new Item("Dwarf weed", "A fresh herb.", "herbCleanDwarfweed", ColorLib.Dwarfweed, 150));

                    // Torstol
                    itemsToAdd.Add(new Item("Torstol seed", "A torstol seed - plant in an herb patch. (75)", "seedTorstol", Color.DarkGreen, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyTorstol",
                        UseInt = 75 /* Level */,  UseInt2 = 270 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy torstol", "It needs cleaning.", "herbGrimyTorstol", ColorLib.Torstol.GetDark(), 75) { UseString = "CleanHerb", UseString2 = "herbCleanTorstol", UseInt = 75, UseInt2 = 15 }); 
                    itemsToAdd.Add(new Item("Torstol", "A fresh herb.", "herbCleanTorstol", ColorLib.Torstol, 75));

                    // Arbuck
                    itemsToAdd.Add(new Item("Arbuck seed", "An arbuck seed - plant in an herb patch. (77)", "seedArbuck", Color.Orange, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyArbuck",
                        UseInt = 77 /* Level */,  UseInt2 = 350 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy arbuck", "It needs cleaning.", "herbGrimyArbuck", ColorLib.Arbuck.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanArbuck", UseInt = 77, UseInt2 = 14 }); 
                    itemsToAdd.Add(new Item("Arbuck", "A fresh herb.", "herbCleanArbuck", ColorLib.Arbuck, 150));

                    // Fellstalk
                    itemsToAdd.Add(new Item("Fellstalk seed", "A fellstalk seed - plant in an herb patch. (91)", "seedFellstalk", Color.AntiqueWhite, 64, true) {
                        UseString = "PlantSeed", UseString2 = "Herb", UseString3 = "herbGrimyFellstalk",
                        UseInt = 91 /* Level */,  UseInt2 = 500 /* Exp On Harvest */, UseInt3 = 4800 /* Growth time in seconds */ 
                    });
                    itemsToAdd.Add(new Item("Grimy fellstalk", "It needs cleaning.", "herbGrimyFellstalk", ColorLib.Fellstalk.GetDark(), 100) { UseString = "CleanHerb", UseString2 = "herbCleanFellstalk", UseInt = 91, UseInt2 = 17 }); 
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
            }

            // Crafting
            {
                itemsToAdd.Add(new Item("Wool", "Nice and fluffy.", "woolRaw", 255, 255, 255, 5));
                itemsToAdd.Add(new Item("Bark", "Bark from a hollow tree.", "bark", Color.SaddleBrown, 50));
                itemsToAdd.Add(new Item("Fine cloth", "Amazingly untouched by time.", "clothFine", Color.SaddleBrown, 500)); 
                itemsToAdd.Add(new Item("Silk", "It's a sheet of silk.", "clothSilk", Color.AntiqueWhite, 30)); 
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
                itemsToAdd.Add(new Item("M'speak amulet mould", "It's an amulet mould shaped like a monkey head.", "mouldAmuletMonkeyspeak", Color.White, 10));
                itemsToAdd.Add(new Item("Necklace mould", "Used to make necklaces.", "mouldNecklace", Color.White, 5));
                itemsToAdd.Add(new Item("Ring mould", "Used to make rings.", "mouldRing", Color.White, 5));
                itemsToAdd.Add(new Item("Rod clay mould", "Rod of Ivandis mould.", "mouldRodClay", Color.SandyBrown, 5));
                itemsToAdd.Add(new Item("Sickle mould", "Used to make sickles.", "mouldSickle", Color.White, 10));
                itemsToAdd.Add(new Item("Tiara mould", "A mould for tiaras.", "mouldTiara", Color.SaddleBrown, 100));
                itemsToAdd.Add(new Item("Unholy mould", "Used to make unholy symbols.", "mouldUnholy", Color.White, 200));

                // Jewellery Factory
                List<MaterialDef> Jewels = new() {
                    new("Gold", Color.Goldenrod, 0, 5, 400, "Gold"),
                    new("Opal", Color.AntiqueWhite, 1, 7, 350, "Opal"),
                    new("Jade", Color.PaleGreen, 1, 27, 400, "Jade"),
                    new("Red topaz", Color.Magenta, 1, 49, 450, "RedTopaz"),
                    new("Sapphire", Color.DeepSkyBlue, 2, 7, 1000, "Sapphire"),
                    new("Emerald", Color.Lime, 3, 27, 1500, "Emerald"),
                    new("Ruby", Color.Crimson, 4, 49, 2200, "Ruby"),
                    new("Diamond", Color.White, 5, 57, 3500, "Diamond"),
                    new("Dragonstone", Color.Purple, 6, 68, 18000, "Dragonstone"),
                    new("Onyx", Color.DimGray, 7, 87, 1000000, "Onyx"),
                    new("Zenyte", Color.Orange, 8, 93, 15000000, "Zenyte")
                };

                foreach (var mat in Jewels) {
                    if (mat.Name != "Gold") {
                        itemsToAdd.Add(new Item("Uncut " + mat.Name.ToLower(), "An uncut " + mat.Name.ToLower() + ". Used in Crafting (" + mat.Level + ").", "uncut" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier - 300));
                        itemsToAdd.Add(new Item(mat.Name, "This looks valuable.", "cut" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier));
                    }
                    itemsToAdd.Add(new Item(mat.Name + " ring", "A ring made from " + mat.Name.ToLower() + ".", "ring" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Ring" });
                    itemsToAdd.Add(new Item(mat.Name + " amulet", "An amulet made from " + mat.Name.ToLower() + ".", "amulet" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Amulet" });
                    itemsToAdd.Add(new Item(mat.Name + " amulet (u)", "An unstrung amulet made from " + mat.Name.ToLower() + ". Can be strung with a ball of wool.", "amulet" + mat.Descriptor + "U", mat.R, mat.G, mat.B, mat.CostMultiplier));
                    itemsToAdd.Add(new Item(mat.Name + " necklace", "A necklace made from " + mat.Name.ToLower() + ".", "necklace" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Amulet" });
                    itemsToAdd.Add(new Item(mat.Name + " bracelet", "A bracelet made from " + mat.Name.ToLower() + ".", "bracelet" + mat.Descriptor, mat.R, mat.G, mat.B, mat.CostMultiplier) { EquipSlot = "Hands" });
                }

                itemsToAdd.Add(new Item("Brass necklace", "I'd prefer a gold one.", "necklaceBrass", ColorLib.Bronze.GetBright(), 30) { EquipSlot = "Amulet" });
                itemsToAdd.Add(new Item("Amulet of accuracy", "It increases my aim.", "amuletAccuracy", Color.Orange, 100) { EquipSlot = "Amulet", MiscString = "HitChance", EquipTier = 10 });
                
                itemsToAdd.Add(new Item("Amulet of magic", "An enchanted sapphire amulet of magic.", "amuletMagic", Color.DeepSkyBlue, 1100) { EquipSlot = "Amulet", MiscString = "MagicBoost", EquipTier = 5 });
                itemsToAdd.Add(new Item("Ring of recoil", "Reflects part of damage taken back to the attacker.", "ringRecoil", Color.DeepSkyBlue, 1100) { EquipSlot = "Ring", UseInt4 = 40 });
                itemsToAdd.Add(new Item("Games necklace", "An enchanted sapphire necklace.", "necklaceGames", Color.DeepSkyBlue, 1100) { EquipSlot = "Amulet", UseInt4 = 8, UseString = "TeleportMenuCost", TeleportLocations = ["ASG_Burthorpe", "KAN_BarbOutpost", "WILD_CorpLair", "MIST_TearsOfGuthix", "KOUR_WintertodtCamp", "DES_GiantsPlateau", "DES_MageTrainingArena", "KAN_CastleWarsLobby"] });
                itemsToAdd.Add(new Item("Bracelet of clay", "Now I can become a potter.", "braceletClay", Color.DeepSkyBlue, 1100) { EquipSlot = "Hands", UseInt4 = 20 });
                
                itemsToAdd.Add(new Item("Amulet of bounty", "25% chance to not consume a seed when planting.", "amuletBounty", Color.AntiqueWhite, 450) { EquipSlot = "Amulet", UseInt4 = 10 });
                itemsToAdd.Add(new Item("Ring of pursuit", "This ring increases your chance to catch hunter creatures in traps.", "ringPursuit", Color.AntiqueWhite, 450) { EquipSlot = "Ring", UseInt4 = 20 });
                itemsToAdd.Add(new Item("Dodgy necklace", "25% chance to avoid damage from failed pickpocketing.", "necklaceDodgy", Color.AntiqueWhite, 450) { EquipSlot = "Amulet", UseInt4 = 10 });
                itemsToAdd.Add(new Item("Expeditious bracelet", "25% chance for one slayer kill to count as two.", "braceletExpeditious", Color.AntiqueWhite, 450) { EquipSlot = "Hands", UseInt4 = 30 });
                
                itemsToAdd.Add(new Item("Amulet of defense", "An enchanted emerald amulet of defense.", "amuletDefense", Color.Lime, 1600) { EquipSlot = "Amulet", MiscString = "DefenseAll", EquipTier = 5 });
                itemsToAdd.Add(new Item("Ring of dueling", "An enchanted emerald ring.", "ringDueling", Color.Lime, 1600) { EquipSlot = "Ring", UseInt4 = 8, UseString = "TeleportMenuCost", TeleportLocations = ["DES_AlKharidEmirsArena", "KAN_CastleWarsLobby", "WILD_FeroxEnclave", "VAR_FortisColosseum" ] });
                itemsToAdd.Add(new Item("Binding necklace", "A necklace embedded with mystical power.", "necklaceBinding", Color.Lime, 1600) { EquipSlot = "Amulet", UseInt4 = 16 });
                itemsToAdd.Add(new Item("Castle wars bracelet", "Must be worn as you enter the game to receive the bonus for that game.", "braceletCastleWars", Color.Lime, 1600) { EquipSlot = "Hands", UseInt4 = 3 }); // TODO: If Castle Wars ever gets implemented, make this work
                
                itemsToAdd.Add(new Item("Amulet of chemistry", "An enchanted emerald amulet of defense.", "amuletChemistry", Color.PaleGreen, 500) { EquipSlot = "Amulet", UseInt4 = 5 });
                itemsToAdd.Add(new Item("Ring of returning", "This ring returns you to your spawn point.", "ringReturning", Color.PaleGreen, 500) { EquipSlot = "Ring", UseInt4 = 5, UseString = "TeleSpawn" });
                itemsToAdd.Add(new Item("Necklace of passage", "This necklace can really take you places.", "necklacePassage", Color.PaleGreen, 500) { EquipSlot = "Amulet", UseInt4 = 5, UseString = "TeleportMenuCost", TeleportLocations = ["MIST_WizardTowerBridge", "KAN_Outpost", "DES_Eagles", "SEA_Wyrmscraig"] });
                itemsToAdd.Add(new Item("Flaemtaer bracelet", "Helps when building the Shades of Mort'ton temple.", "braceletFlamtaer", Color.PaleGreen, 500) { EquipSlot = "Hands", UseInt4 = 80 }); // TODO: If Shades of Mort'ton ever gets implemented, make this work
                
                itemsToAdd.Add(new Item("Amulet of strength", "An enchanted ruby amulet of strength.", "amuletStrength", Color.Crimson, 2300) { EquipSlot = "Amulet", MiscString = "StrengthBoost", EquipTier = 5 });
                itemsToAdd.Add(new Item("Ring of forging", "An enchanted ruby ring. Allows you to smelt primary ores directly into bars.", "ringForging", Color.Crimson, 2300) { EquipSlot = "Ring", UseInt4 = 140 });
                itemsToAdd.Add(new Item("Digsite pendant", "Can teleport you to archaeologically significant areas.", "necklaceDigsite", Color.Crimson, 2300) { EquipSlot = "Amulet", UseInt4 = 5, UseString = "TeleportMenuCost", TeleportLocations = ["MIST_Digsite", "MIST_FossilIsland", "MIST_Lithkren"] });
                itemsToAdd.Add(new Item("Inoculation bracelet", "It eases diseases!", "braceletInoculation", Color.Crimson, 2300) { EquipSlot = "Hands", UseInt4 = 275 }); // TODO: Once disease damage is implemented make this work, also should require Zogre Flesh Eaters completion to equip
                
                itemsToAdd.Add(new Item("Burning amulet", "Useful teleports around the wilderness.", "amuletBurning", Color.Magenta, 550) { EquipSlot = "Amulet", UseInt4 = 5, UseString = "TeleportMenuCost", TeleportLocations = ["WILD_ChaosTemple", "WILD_BanditCampEntrance", "WILD_LavaMazeEntrance"] });
                itemsToAdd.Add(new Item("Efaritay's aid", "Aids the user against vampires.", "ringEfaritay", Color.Magenta, 550) { EquipSlot = "Ring", UseInt4 = 200 });
                itemsToAdd.Add(new Item("Necklace of faith", "While worn, if you are below half health, boosts your effective Prayer level by 25%.", "necklaceFaith", Color.Magenta, 550) { EquipSlot = "Amulet" });
                itemsToAdd.Add(new Item("Bracelet of slaughter", "Occasionally prevents slayer kill count being decremented.", "braceletSlaughter", Color.Magenta, 550) { EquipSlot = "Hands", UseInt4 = 30 });
                
                itemsToAdd.Add(new Item("Amulet of power", "An enchanted diamond amulet of magic.", "amuletPower", Color.White, 3600) { EquipSlot = "Amulet", MiscString = "OffenseBoost", EquipTier = 2 });
                itemsToAdd.Add(new Item("Ring of life", "Aids the user against vampires.", "ringLife", Color.White, 3600) { EquipSlot = "Ring" });
                itemsToAdd.Add(new Item("Phoenix necklace", "If you drop below 20% health, restores 30% of your max health.", "necklacePhoenix", Color.White, 3600) { EquipSlot = "Amulet" });
                itemsToAdd.Add(new Item("Abyssal bracelet", "Makes using the Abyss just slightly safer.", "braceletAbyssal", Color.White, 3600) { EquipSlot = "Hands", UseInt4 = 30 }); // TODO: When the Abyss is implemented, make this teleport you to the inner ring on entry since the skulling thing is pointless
                
                itemsToAdd.Add(new Item("Amulet of glory", "A very powerful dragonstone amulet.", "amuletGlory", Color.Purple, 18100) { EquipSlot = "Amulet", MiscString = "OffenseBoost", EquipTier = 3, UseString = "TeleportMenuCost", TeleportLocations = ["MIST_Edgeville", "KAR_MusaPoint", "MIST_DraynorVillage", "DES_AlKharidPalace" ] });
                itemsToAdd.Add(new Item("Ring of wealth", "An enchanted dragonstone ring that can teleport you.", "ringWealth", Color.Purple, 18100) { EquipSlot = "Ring", UseString = "TeleportMenuCost", TeleportLocations = ["FREM_Miscellania", "MIST_GrandExchange", "ASG_FaladorPark", "FREM_KeldagrimMineSouthwest" ] });
                itemsToAdd.Add(new Item("Skills necklace", "This will help me travel.", "necklaceSkills", Color.Purple, 18100) { EquipSlot = "Amulet", UseString = "TeleportMenuCost", TeleportLocations = ["KAN_FishingGuildOutside", "ASG_MiningGuild", "ASG_CraftingGuild", "MIST_VarrockGuildCooks", "KOUR_WoodcuttingGuild", "KOUR_FarmingGuild" ] });
                itemsToAdd.Add(new Item("Combat bracelet", "A handy way to get around.", "braceletCombat", Color.Purple, 18100) { EquipSlot = "Hands", MiscString = "OmniBoost", EquipTier = 1, UseString = "TeleportMenuCost", TeleportLocations = ["ASG_WarriorsGuild", "MIST_VarrockMineEast", "ASG_EdgevilleMonastery", "KAN_RangingGuild" ] });
                
                itemsToAdd.Add(new Item("Amulet of fury", "A very powerful onyx amulet.", "amuletFury", Color.DimGray, 1000100) { EquipSlot = "Amulet", MiscString = "OmniBoost", EquipTier = 4 });
                itemsToAdd.Add(new Item("Ring of fortune", "A lucky ring that enhances your chance to receive rare drops.", "ringFortune", Color.DimGray, 1000100) { EquipSlot = "Ring", UseString = "TeleportMenuFree", TeleportLocations = ["FREM_Miscellania", "MIST_GrandExchange", "ASG_FaladorPark", "FREM_KeldagrimMineSouthwest" ] });
                itemsToAdd.Add(new Item("Berserker necklace", "Makes obsidian weapons even stronger!", "necklaceBerserker", Color.DimGray, 1000100) { EquipSlot = "Amulet", MiscString = "DefenseAll", EquipTier = -2 }); // TODO: Make this actually make obsidian weapons stronger once they get added
                itemsToAdd.Add(new Item("Regen bracelet", "Helps to restore health.", "braceletRegen", Color.DimGray, 1000100) { EquipSlot = "Hands" });
                
                

                itemsToAdd.Add(new Item("Cowhide", "This should be tanned before I can use it.", "cowhide", 255, 255, 255, 10));
                itemsToAdd.Add(new Item("Soft leather", "Suitable for craftworks now.", "leatherSoft", 165, 42, 42, 10));
                itemsToAdd.Add(new Item("Hard leather", "Might offer some real protection if made into armor.", "leatherHard", 139, 69, 19, 20));
                itemsToAdd.Add(new Item("Snake hide", "This should be tanned before I can use it.", "hideSnake", Color.DarkOliveGreen.GetBrightest(), 100));
                itemsToAdd.Add(new Item("Snakeskin", "Scaly but not slimy! Used in Crafting (30).", "leatherSnakeskin", Color.DarkOliveGreen, 100));
                itemsToAdd.Add(new Item("Green dragonhide", "The scaly rough hide from a green dragon.", "hideDragonGreen", Color.ForestGreen.GetBrightest(), 250));
                itemsToAdd.Add(new Item("Green dragon leather", "A piece of prepared green dragonhide. Used in Crafting (40).", "leatherDragonGreen", Color.ForestGreen, 250));
                itemsToAdd.Add(new Item("Blue dragonhide", "The scaly rough hide from a green dragon.", "hideDragonBlue", Color.CadetBlue.GetBrightest(), 375));
                itemsToAdd.Add(new Item("Blue dragon leather", "A piece of prepared blue dragonhide. Used in Crafting (50).", "leatherDragonBlue", Color.CadetBlue, 375));
                itemsToAdd.Add(new Item("Red dragonhide", "The scaly rough hide from a red dragon.", "hideDragonRed", Color.Crimson.GetBrightest(), 500));
                itemsToAdd.Add(new Item("Red dragon leather", "A piece of prepared red dragonhide. Used in Crafting (55).", "leatherDragonRed", Color.Crimson, 500));
                itemsToAdd.Add(new Item("Black dragonhide", "The scaly rough hide from a black dragon.", "hideDragonBlack", Color.DimGray.GetBrightest(), 625));
                itemsToAdd.Add(new Item("Black dragon leather", "A piece of prepared black dragonhide. Used in Crafting (60).", "leatherDragonBlack", Color.DimGray, 625));
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
                
                itemsToAdd.Add(new Item("Bucket of sand", "A bucket filled with sand. One of the ingredients for making glass.", "bucketSand", 111, 66, 33, 2));
                itemsToAdd.Add(new Item("Seaweed", "Slightly damp seaweed.", "seaweed", Color.SeaGreen, 2));
                itemsToAdd.Add(new Item("Swamp weed", "Swamp weed found in the caves near Dorgesh-Kaan.", "weedSwamp", Color.ForestGreen, 2));
                itemsToAdd.Add(new Item("Soda ash", "One of the ingredients for making glass.", "ashSoda", Color.White, 2));
                itemsToAdd.Add(new Item("Molten glass", "Hot glass ready to be blown into useful objects.", "glassMolten", Color.Orange, 2));
                itemsToAdd.Add(new Item("Lantern lens", "A roughly circular disc of glass.", "glassLens", ColorLib.Steel, 70)); 
                itemsToAdd.Add(new Item("Empty candle lantern", "A candle in a glass cage.", "candleLanternEmpty", ColorLib.Steel, 15));
                itemsToAdd.Add(new Item("Fishbowl", "An empty fishbowl.", "fishbowlEmpty", Color.White, 1));
                itemsToAdd.Add(new Item("Unpowered orb", "Could be imbued with elemental energy.", "orbUnpowered", ColorLib.Steel, 100));
             
                itemsToAdd.Add(new Item("Grain", "Some wheat hands.", "grain", 207, 185, 151, 2));
            }

            // Ranged Armor Factory
            List<MaterialDef> Leathers = new() {
                new("Leather", 205, 127, 50, 255, 1, 1, 20, "minimal"), 
                new("Hardleather", 175, 97, 20, 255, 2, 10, 40, "slight"), 
                new("Studded", 175, 97, 20, 255, 3, 20, 110, "adequate"), 
                new("Snakeskin", Color.DarkOliveGreen, 4, 30, 200, "decent"), 
                new("Green dragonhide", Color.ForestGreen, 5, 40, 500, "good"),
                new("Blue dragonhide", Color.CadetBlue, 6, 50, 750, "great"),
                new("Red dragonhide", Color.Crimson, 6, 55, 1000, "greater"),
                new("Black dragonhide", Color.DimGray, 6, 55, 1250, "greater")
            };

             for (int i = 0; i < Leathers.Count; i++) {
                int fullMult = Leathers[i].CostMultiplier;

                string tempName = Leathers[i].Name;

                if (tempName.Contains(" d")) { tempName = tempName.Replace(" d", "D"); }

                Item coif = new Item(Leathers[i].Name + " coif", "Provides " + Leathers[i].Descriptor + " ranged protection for the head.", "coif" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 2) {
                    EquipSlot = "Head",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(coif);

                Item body = new Item(Leathers[i].Name + " body", "Provides " + Leathers[i].Descriptor + " ranged protection for the torso.", "body" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(body);

                Item chaps = new Item(Leathers[i].Name + " chaps", "Provides " + Leathers[i].Descriptor + " ranged protection for the legs.", "chaps" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(chaps);

                Item boots = new Item(Leathers[i].Name + " boots", "Provides " + Leathers[i].Descriptor + " ranged protection for the feet.", "boots" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult) {
                    EquipSlot = "Feet",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(boots);

                Item vambraces = new Item(Leathers[i].Name + " vambraces", "Provides " + Leathers[i].Descriptor + " ranged protection for the hands.", "vambraces" + tempName, Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult) {
                    EquipSlot = "Hands",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(vambraces);

                // Trimmed body and chaps
                Item bodyT = new Item(Leathers[i].Name + " body", "Provides " + Leathers[i].Descriptor + " ranged protection for the torso. Trimmed.", "body" + tempName + "T", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 10) {
                    CosmeticNote = "t", EquipSlot = "Body",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(bodyT);

                Item chapsT = new Item(Leathers[i].Name + " chaps", "Provides " + Leathers[i].Descriptor + " ranged protection for the legs. Trimmed.", "chaps" + tempName + "T", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 6) {
                    CosmeticNote = "t", EquipSlot = "Legs",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(chapsT);

                // Gold trimmed body and chaps
                Item bodyG = new Item(Leathers[i].Name + " body", "Provides " + Leathers[i].Descriptor + " ranged protection for the torso. Trimmed with gold.", "body" + tempName + "G", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 10) {
                    CosmeticNote = "g", EquipSlot = "Body",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(bodyG);

                Item chapsG = new Item(Leathers[i].Name + " chaps", "Provides " + Leathers[i].Descriptor + " ranged protection for the legs. Trimmed with gold.", "chaps" + tempName + "G", Leathers[i].R, Leathers[i].G, Leathers[i].B, fullMult * 6) {
                    CosmeticNote = "g", EquipSlot = "Legs",  EquipTier = Leathers[i].Tier, EquipSkill = "Defense", EquipLevel = Leathers[i].Level, MiscString = "DefenseRange"
                };
                itemsToAdd.Add(chapsG);
            }
            ////
            
            itemsToAdd.Add(new Item("Air talisman", "A mysterious power emanates from the talisman...", "talismanAir", 200, 200, 200, 200));
            itemsToAdd.Add(new Item("Mind talisman", "A mysterious power emanates from the talisman...", "talismanMind", 231, 60, 0, 200)); 
            itemsToAdd.Add(new Item("Earth talisman", "A mysterious power emanates from the talisman...", "talismanEarth", Color.SaddleBrown, 200)); 
            itemsToAdd.Add(new Item("Fire talisman", "A mysterious power emanates from the talisman...", "talismanFire", Color.Firebrick, 200)); 
            itemsToAdd.Add(new Item("Water talisman", "A mysterious power emanates from the talisman...", "talismanWater", Color.CadetBlue, 200)); 
            itemsToAdd.Add(new Item("Chaos talisman", "A mysterious power emanates from the talisman...", "talismanChaos", Color.Orange, 200)); 
            itemsToAdd.Add(new Item("Nature talisman", "A mysterious power emanates from the talisman...", "talismanNature", Color.Green, 200)); 
            itemsToAdd.Add(new Item("Body talisman", "A mysterious power emanates from the talisman...", "talismanBody", Color.PowderBlue, 200)); 
            itemsToAdd.Add(new Item("Death talisman", "A mysterious power emanates from the talisman...", "talismanDeath", Color.White, 200)); 
            itemsToAdd.Add(new Item("Cosmic talisman", "A mysterious power emanates from the talisman...", "talismanCosmic", Color.White, 200)); 
            itemsToAdd.Add(new Item("Law talisman", "A mysterious power emanates from the talisman...", "talismanLaw", Color.White, 200));
            itemsToAdd.Add(new Item("Blood talisman", "A mysterious power emanates from the talisman...", "talismanBlood", Color.White, 200));  

            itemsToAdd.Add(new Item("Tiara", "Makes me feel like a Princess.", "tiara", ColorLib.Steel, 100) { EquipSlot = "Head", Cosmetic = true });
            itemsToAdd.Add(new Item("Air tiara", "A tiara infused with the properties of air.", "tiaraAir", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanAir"], UseInt4 = -1 });
            itemsToAdd.Add(new Item("Blood tiara", "A tiara infused with the properties of blood.", "tiaraBlood", ColorLib.Steel, 500) { EquipSlot = "Head", CountsAsIDs = ["talismanBlood"], UseInt4 = -1 });
            itemsToAdd.Add(new Item("Body tiara", "A tiara infused with the properties of body.", "tiaraBody", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanBody"], UseInt4 = -1 });
            itemsToAdd.Add(new Item("Chaos tiara", "A tiara infused with the properties of chaos.", "tiaraChaos", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanChaos"], UseInt4 = -1 });
            itemsToAdd.Add(new Item("Cosmic tiara", "A tiara infused with the properties of the cosmos.", "tiaraCosmic", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanCosmic"], UseInt4 = -1 });
            itemsToAdd.Add(new Item("Death tiara", "A tiara infused with the properties of death.", "tiaraDeath", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanDeath"], UseInt4 = -1 });
            itemsToAdd.Add(new Item("Earth tiara", "A tiara infused with the properties of earth.", "tiaraEarth", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanEarth"], UseInt4 = -1});
            itemsToAdd.Add(new Item("Fire tiara", "A tiara infused with the properties of fire.", "tiaraFire", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanFire"], UseInt4 = -1});
            itemsToAdd.Add(new Item("Law tiara", "A tiara infused with the properties of law.", "tiaraLaw", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanLaw"], UseInt4 = -1});
            itemsToAdd.Add(new Item("Mind tiara", "A tiara infused with the properties of the mind.", "tiaraMind", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanMind"], UseInt4 = -1});
            itemsToAdd.Add(new Item("Nature tiara", "A tiara infused with the properties of nature.", "tiaraNature", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanNature"], UseInt4 = -1});
            itemsToAdd.Add(new Item("Water tiara", "A tiara infused with the properties of water.", "tiaraWater", ColorLib.Steel, 100) { EquipSlot = "Head", CountsAsIDs = ["talismanWater"], UseInt4 = -1});
            itemsToAdd.Add(new Item("Wrath tiara", "A tiara infused with the properties of wrath.", "tiaraWrath", ColorLib.Steel, 500) { EquipSlot = "Head", CountsAsIDs = ["talismanWrath"], UseInt4 = -1});
                
            
            itemsToAdd.Add(new Item("Rune essence", "An unimbued rune.", "runeEssence", Color.DarkGray, 2));
            itemsToAdd.Add(new Item("Pure essence", "An unimbued rune.", "pureEssence", Color.LightGray, 4));
            itemsToAdd.Add(new Item("Air rune", "One of the 4 basic elemental runes.", "runeAir", Color.LightGray, 4, true));
            itemsToAdd.Add(new Item("Earth rune", "One of the 4 basic elemental runes.", "runeEarth", Color.LightGray, 4, true));
            itemsToAdd.Add(new Item("Fire rune", "One of the 4 basic elemental runes.", "runeFire", Color.LightGray, 4, true));
            itemsToAdd.Add(new Item("Water rune", "One of the 4 basic elemental runes.", "runeWater", Color.LightGray, 4, true));
            itemsToAdd.Add(new Item("Mind rune", "Used for basic level missile spells.", "runeMind", Color.LightGray, 3, true));
            itemsToAdd.Add(new Item("Body rune", "Used for curse spells.", "runeBody", Color.LightGray, 3, true));
            itemsToAdd.Add(new Item("Nature rune", "Used for alchemy spells.", "runeNature", Color.LightGray, 180, true));
            itemsToAdd.Add(new Item("Chaos rune", "Used for low level missile spells.", "runeChaos", Color.LightGray, 90, true));
            itemsToAdd.Add(new Item("Law rune", "Used for teleport spells.", "runeLaw", Color.LightGray, 240, true));
            itemsToAdd.Add(new Item("Death rune", "Used for medium level missile spells.", "runeDeath", Color.LightGray, 180, true));
            itemsToAdd.Add(new Item("Blood rune", "Used for high level missile spells.", "runeBlood", Color.LightGray, 400, true));
            itemsToAdd.Add(new Item("Cosmic rune", "Used for enchant spells.", "runeCosmic", Color.LightGray, 50, true));
            itemsToAdd.Add(new Item("Soul rune", "Used for high level curse spells.", "runeSoul", Color.LightGray, 300, true));
            itemsToAdd.Add(new Item("Astral rune", "Used for Lunar spells.", "runeAstral", Color.LightGray, 50, true));
            itemsToAdd.Add(new Item("Mist rune", "A combined Air and Water Rune.", "runeMist", Color.LightGray, 20, true) { CountsAsIDs = ["runeAir", "runeWater"] });
            itemsToAdd.Add(new Item("Dust rune", "A combined Air and Earth Rune.", "runeDust", Color.LightGray, 20, true) { CountsAsIDs = ["runeAir", "runeEarth"] });
            itemsToAdd.Add(new Item("Mud rune", "A combined Earth and Water Rune.", "runeMud", Color.LightGray, 20, true) { CountsAsIDs = ["runeEarth", "runeWater"] });
            itemsToAdd.Add(new Item("Smoke rune", "A combined Air and Fire Rune.", "runeSmoke", Color.LightGray, 20, true) { CountsAsIDs = ["runeAir", "runeFire"] });
            itemsToAdd.Add(new Item("Steam rune", "A combined Water and Fire Rune.", "runeSteam", Color.LightGray, 20, true) { CountsAsIDs = ["runeFire", "runeWater"] });
            itemsToAdd.Add(new Item("Lava rune", "A combined Earth and Fire Rune.", "runeLava", Color.LightGray, 20, true) { CountsAsIDs = ["runeEarth", "runeFire"] });


            itemsToAdd.Add(new Item("Staff of air", "A magical staff. Provides unlimited air runes.", "staffAir", 255, 255, 255, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", CountsAsIDs = [ "runeAir" ], UseInt4 = -1, MustBeEquipped = true
            });

            itemsToAdd.Add(new Item("Staff of water", "A magical staff. Provides unlimited water runes.", "staffWater", 30, 144, 255, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", CountsAsIDs = [ "runeWater" ],  UseInt4 = -1, MustBeEquipped = true
            }); 

            itemsToAdd.Add(new Item("Staff of earth", "A magical staff. Provides unlimited earth runes.", "staffEarth", 165, 42, 42, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", CountsAsIDs = [ "runeEarth" ],  UseInt4 = -1, MustBeEquipped = true
            }); 

            itemsToAdd.Add(new Item("Staff of fire", "A magical staff. Provides unlimited fire runes.", "staffFire", 220, 20, 60, 1500) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", CountsAsIDs = [ "runeFire" ],  UseInt4 = -1, MustBeEquipped = true
            });

            itemsToAdd.Add(new Item("Battlestaff", "It's a slightly magical stick.", "battlestaff", Color.BurlyWood, 7000) { EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Magic", EquipLevel = 30, EquipDamageType = "Crush" });

            itemsToAdd.Add(new Item("Air battlestaff", "A magical staff. Provides unlimited air runes.", "battlestaffAir", 255, 255, 255, 15500) { EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Magic", EquipLevel = 30, EquipDamageType = "Crush", CountsAsIDs = [ "runeAir" ], UseInt4 = -1, MustBeEquipped = true });
            itemsToAdd.Add(new Item("Water battlestaff", "A magical staff. Provides unlimited water runes.", "battlestaffWater", 30, 144, 255, 15500) { EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Magic", EquipLevel = 30, EquipDamageType = "Crush", CountsAsIDs = [ "runeWater" ],  UseInt4 = -1, MustBeEquipped = true }); 
            itemsToAdd.Add(new Item("Earth battlestaff", "A magical staff. Provides unlimited earth runes.", "battlestaffEarth", 165, 42, 42, 15500) { EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Magic", EquipLevel = 30, EquipDamageType = "Crush", CountsAsIDs = [ "runeEarth" ],  UseInt4 = -1, MustBeEquipped = true }); 
            itemsToAdd.Add(new Item("Fire battlestaff", "A magical staff. Provides unlimited fire runes.", "battlestaffFire", 220, 20, 60, 15500) { EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Magic", EquipLevel = 30, EquipDamageType = "Crush", CountsAsIDs = [ "runeFire" ],  UseInt4 = -1, MustBeEquipped = true });


            // Pickpocket Loot
            itemsToAdd.Add(new Item("Small coin pouch", "Has a few coins in it.", "coinPouchSmall", 111, 66, 33, 5, true, false) { UseString = "GetGold", UseInt = 5 });
            itemsToAdd.Add(new Item("Medium coin pouch", "Has a few more coins in it.", "coinPouchMedium", 111, 66, 33, 5, true, false) { UseString = "GetGold", UseInt = 20 });

            itemsToAdd.Add(new Item("Slayer gem", "A pretty blue gem that can tell you your current slayer task.", "gemSlayer", 102, 205, 170, 1) { UseString = "SlayerGem", ConsumedOnUse = false });
            
            itemsToAdd.Add(new Item("Bones", "The remains of some creature or person.", "bonesRegular", 255, 255, 255, 20) { UseString = "Bones", UseInt = 5 });
            itemsToAdd.Add(new Item("Big bones", "The remains of some huge creature or person.", "bonesBig", 255, 255, 255, 100) { UseString = "Bones", UseInt = 15 });
            itemsToAdd.Add(new Item("Long bone", "A Construction bone.", "boneLong", 255, 255, 255, 100, trade: false) { UseString = "Bones", UseInt = 15 });
            itemsToAdd.Add(new Item("Curved bone", "A curved Construction bone.", "boneCurved", 255, 255, 255, 100, trade: false) { UseString = "Bones", UseInt = 15 });
            
            itemsToAdd.Add(new Item("Fiendish ashes", "A heap of ashes.", "ashesFiendish", 122, 104, 127, 1) { UseString = "Ashes", UseInt = 10 });
            itemsToAdd.Add(new Item("Vile ashes", "A heap of ashes.", "ashesVile", 122, 104, 127, 1) { UseString = "Ashes", UseInt = 25 });
            
            
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
            itemsToAdd.Add(new Item("Redberry pie", "Looks tasty.", "pieRedberry", Color.SandyBrown, 6) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Uncooked meat pie", "This would be much healthier cooked.", "pieMeatUncooked", Color.SandyBrown, 8)); 
            itemsToAdd.Add(new Item("Meat pie", "Not for vegetarians.", "pieMeat", Color.SandyBrown, 8) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 6) } }); 
            itemsToAdd.Add(new Item("Uncooked apple pie", "This would be much tastier cooked.", "pieAppleUncooked", Color.SandyBrown, 16)); 
            itemsToAdd.Add(new Item("Apple pie", "Mmm apple pie.", "pieApple", Color.SandyBrown, 16) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 7) } }); 
            itemsToAdd.Add(new Item("Part mud pie (compost)", "Still needs two more ingredients.", "pieMudCompost", Color.SaddleBrown, 27)); 
            itemsToAdd.Add(new Item("Part mud pie (water)", "Still needs one more ingredient.", "pieMudWater", Color.SaddleBrown, 27)); 
            itemsToAdd.Add(new Item("Uncooked mud pie", "This would be much more appetizing cooked.", "pieMudUncooked", Color.SaddleBrown, 27)); 
            itemsToAdd.Add(new Item("Mud pie", "Looks tasty.", "pieMud", Color.SaddleBrown, 54)); 
            itemsToAdd.Add(new Item("Part garden pie (tomato)", "Still needs two more ingredients.", "pieGardenTomato", Color.SandyBrown, 12)); 
            itemsToAdd.Add(new Item("Part garden pie (onion)", "Still needs one more ingredient.", "pieGardenOnion", Color.SandyBrown, 12)); 
            itemsToAdd.Add(new Item("Uncooked garden pie", "Needs cooking before I eat it.", "pieGardenUncooked", Color.SandyBrown, 12)); 
            itemsToAdd.Add(new Item("Garden pie", "What I wouldn't give for a good steak about now...", "pieGarden", Color.SandyBrown, 12) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 6), new("Farming", 3) } }); 
            itemsToAdd.Add(new Item("Part fish pie (trout)", "Still needs two more ingredients.", "pieFishTrout", Color.SandyBrown, 24)); 
            itemsToAdd.Add(new Item("Part fish pie (cod)", "Still needs one more ingredient.", "pieFishCod", Color.SandyBrown, 49)); 
            itemsToAdd.Add(new Item("Uncooked fish pie", "Raw fish is risky, better cook it.", "pieFishUncooked", Color.SandyBrown, 50)); 
            itemsToAdd.Add(new Item("Fish pie", "Bounty of the sea.", "pieFish", Color.SandyBrown, 50) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 6), new("Fishing", 3) } }); 
            itemsToAdd.Add(new Item("Uncooked botanical pie", "This would be much tastier cooked.", "pieBotanicalUncooked", Color.SandyBrown, 16)); 
            itemsToAdd.Add(new Item("Botanical pie", "Mmm botanical pie.", "pieBotanical", Color.SandyBrown, 15) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 7), new("Herblore", 4) } }); 
            itemsToAdd.Add(new Item("Uncooked mushroom pie", "This would be much tastier cooked.", "pieMushroomUncooked", Color.SandyBrown, 16)); 
            itemsToAdd.Add(new Item("Mushroom pie", "Mmm mushroom pie.", "pieMushroom", Color.SandyBrown, 16) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 8), new("Crafting", 4) } }); 
            itemsToAdd.Add(new Item("Part admiral pie (salmon)", "Still needs two more ingredients.", "pieAdmiralSalmon", Color.SandyBrown, 54)); 
            itemsToAdd.Add(new Item("Part admiral pie (tuna)", "Still needs one more ingredient.", "pieAdmiralTuna", Color.SandyBrown, 154)); 
            itemsToAdd.Add(new Item("Uncooked admiral pie", "This would taste a lot better cooked.", "pieAdmiralUncooked", Color.SandyBrown, 155)); 
            itemsToAdd.Add(new Item("Admiral pie", "Much tastier than a normal fish pie.", "pieAdmiral", Color.SandyBrown, 155) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 8), new("Fishing", 5) } }); 
            itemsToAdd.Add(new Item("Uncooked dragonfruit pie", "This would be much tastier cooked.", "pieDragonfruitUncooked", Color.SandyBrown, 40)); 
            itemsToAdd.Add(new Item("Dragonfruit pie", "Mmm dragonfruit pie.", "pieDragonfruit", Color.SandyBrown, 40) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 10), new("Fletching", 4) } }); 
            itemsToAdd.Add(new Item("Part wild pie (bear)", "Still needs two more ingredients.", "pieWildBear", Color.SandyBrown, 5)); 
            itemsToAdd.Add(new Item("Part wild pie (chompy)", "Still needs one more ingredient.", "pieWildChompy", Color.SandyBrown, 90)); 
            itemsToAdd.Add(new Item("Uncooked wild pie", "Good as it looks, I'd better cook it.", "pieWildUncooked", Color.SandyBrown, 91)); 
            itemsToAdd.Add(new Item("Wild pie", "A triumph of man over nature.", "pieWild", Color.SandyBrown, 91) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 11), new("Slayer", 5), new("Ranged", 4) } }); 
            itemsToAdd.Add(new Item("Part summer pie (bear)", "Still needs two more ingredients.", "pieSummerStrawberry", Color.SandyBrown, 21)); 
            itemsToAdd.Add(new Item("Part summer pie (chompy)", "Still needs one more ingredient.", "pieSummerWatermelon", Color.SandyBrown, 69)); 
            itemsToAdd.Add(new Item("Uncooked summer pie", "Fresh fruit may be good for you, but I should really cook this.", "pieSummerUncooked", Color.SandyBrown, 70)); 
            itemsToAdd.Add(new Item("Summer pie", "All the fruits of a very small forest.", "pieSummer", Color.SandyBrown, 70) { UseString = "Potion", UseInt4 = 2, UseString3 = "pieEmpty", Potion = new() { new("Heal", 11), new("Agility", 5) } }); 
            
            itemsToAdd.Add(new Item("Incomplete pizza", "I need to add some cheese next.", "pizzaIncomplete", Color.Crimson, 25)); 
            itemsToAdd.Add(new Item("Uncooked pizza", "This needs cooking.", "pizzaUncooked", Color.Yellow, 25)); 
            itemsToAdd.Add(new Item("Plain pizza", "A cheese and tomato pizza.", "pizzaPlain", Color.Yellow, 70) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 7) } }); 
            itemsToAdd.Add(new Item("Meat pizza", "A pizza with bits of meat on it.", "pizzaMeat", Color.Yellow, 80) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 8) } }); 
            itemsToAdd.Add(new Item("Anchovy pizza", "A pizza with anchovies.", "pizzaAnchovy", Color.Yellow, 80) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 9) } }); 
            itemsToAdd.Add(new Item("Pineapple pizza", "A tropicana pizza.", "pizzaPineapple", Color.Yellow, 100) { UseString = "Potion", UseInt4 = 2, Potion = new() { new("Heal", 11) } }); 
            
            itemsToAdd.Add(new Item("Incomplete stew", "I need to add some potato too.", "stewIncompleteMeat", Color.SandyBrown, 4)); 
            itemsToAdd.Add(new Item("Incomplete stew", "I need to add some meat too.", "stewIncompletePotato", Color.SandyBrown, 4)); 
            itemsToAdd.Add(new Item("Uncooked stew", "I need to cook this.", "stewUncooked", Color.SandyBrown, 10)); 
            itemsToAdd.Add(new Item("Stew", "It's a meat and potato stew.", "stew", Color.SaddleBrown, 20) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 11) } }); 
            itemsToAdd.Add(new Item("Uncooked curry", "I need to cook this.", "curryUncooked", Color.SandyBrown, 10)); 
            itemsToAdd.Add(new Item("Curry", "It's a spicy hot curry.", "curry", Color.SaddleBrown, 20) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 19) } }); 
            
            itemsToAdd.Add(new Item("Chopped garlic", "A bowl of chopped garlic.", "bowlGarlic", Color.White, 7)); 
            itemsToAdd.Add(new Item("Spicy sauce", "A bowl of spicy sauce.", "sauceSpicy", Color.Crimson, 9) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 2) } }); 
            itemsToAdd.Add(new Item("Chili con carne", "A bowl of meat in chili con carne sauce.", "chiliConCarne", Color.Crimson, 9) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Gnome spice", "It's Aluft Gianne's secret mix of spices.", "spiceGnome", ColorLib.Iron, 2)); 
            
            itemsToAdd.Add(new Item("Potato with butter", "A baked potato with butter.", "potatoButter", 225, 147, 70, 8) { UseString = "Heal", UseInt = 14 });
            itemsToAdd.Add(new Item("Chili potato", "A baked potato with chili con carne.", "potatoChili", 225, 147, 70, 13) { UseString = "Heal", UseInt = 14 });
            itemsToAdd.Add(new Item("Potato with cheese", "A baked potato with butter and cheese.", "potatoCheese", 225, 147, 70, 8) { UseString = "Heal", UseInt = 16 });
            itemsToAdd.Add(new Item("Egg potato", "A baked potato with egg and tomato.", "potatoEgg", 225, 147, 70, 12) { UseString = "Heal", UseInt = 16 });
            itemsToAdd.Add(new Item("Mushroom potato", "A baked potato with mushroom and onions.", "potatoMushroom", 225, 147, 70, 45) { UseString = "Heal", UseInt = 20 });
            itemsToAdd.Add(new Item("Tuna potato", "A baked potato with tuna and sweetcorn.", "potatoTuna", 225, 147, 70, 113) { UseString = "Heal", UseInt = 22 });
            itemsToAdd.Add(new Item("Bowl of sweetcorn", "A bowl of cooked sweetcorn.", "bowlCorn", Color.SandyBrown, 113) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 2) } });
            itemsToAdd.Add(new Item("Chopped tuna", "A bowl of finely chopped tuna.", "bowlTuna", Color.SandyBrown, 113) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 10) } });
            itemsToAdd.Add(new Item("Tuna and corn", "A bowl of cooked tuna and sweetcorn.", "bowlTunaCorn", Color.SandyBrown, 113)  { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 13) } });
            
            itemsToAdd.Add(new Item("Chopped tomato", "A mixture of tomatoes in a bowl..", "bowlTomato", Color.White, 3) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 2) } }); 
            itemsToAdd.Add(new Item("Chopped onion", "A bowl of chopped onions.", "bowlOnions", Color.White, 3) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 1) } }); 
            itemsToAdd.Add(new Item("Ugthanki & tomato", "A mixture of chopped tomatoes and ugthanki meat in a bowl.", "bowlUgthankiTomato", Color.Crimson, 7));
            itemsToAdd.Add(new Item("Ugthanki & onion", "A mixture of chopped onion and ugthanki meat in a bowl.", "bowlUgthankiOnions", Color.Crimson, 7));  
            itemsToAdd.Add(new Item("Onion & tomato", "A mixture of chopped onions and tomatoes in a bowl.", "bowlOnionTomato", Color.White, 3) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Mushroom & onion", "A bowl of fried mushroom and onions.", "bowlMushroomOnion", Color.Beige, 45) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 11) } }); 
            itemsToAdd.Add(new Item("Kebab mix", "A mixture of chopped tomatoes, onions, and ugthanki meat in a bowl.", "bowlKebabMix", Color.White, 3)); 
            itemsToAdd.Add(new Item("Ugthanki kebab", "A fresh kebab made from ugthanki meat.", "kebabUgthanki", Color.White, 3) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 19) } }); 
            itemsToAdd.Add(new Item("Ugthanki kebab (bad)", "A strange smelling kebab made from ugthanki meat.", "kebabUgthankiBad", Color.White, 3) { UseString = "KebabBad" }); 
            itemsToAdd.Add(new Item("Fried onions", "A bowl of sliced, fried onions.", "onionsFried", Color.SaddleBrown, 7) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Sliced mushrooms", "A bowl of sliced bittercap mushrooms.", "bowlMushrooms", Color.White, 42)); 
            itemsToAdd.Add(new Item("Fried mushrooms", "A bowl of fried bittercap mushrooms.", "mushroomsFried", Color.SaddleBrown, 42) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Bowl of raw egg", "A bowl of raw eggs.", "bowlEggs", Color.Yellow, 8)); 
            itemsToAdd.Add(new Item("Scrambled egg", "A bowl of scrambled egg.", "eggsScrambled", Color.Goldenrod, 8) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 5) } }); 
            itemsToAdd.Add(new Item("Egg and tomato", "A bowl of scrambled eggs and tomato.", "eggsTomato", Color.Crimson, 12) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 8) } }); 
            itemsToAdd.Add(new Item("Nettles", "A handful of nettles.", "nettles", Color.ForestGreen, 3)); 
            itemsToAdd.Add(new Item("Nettle water", "A bowl of water with nettles in it.", "bowlNettleWater", Color.SeaGreen, 10)); 
            itemsToAdd.Add(new Item("Nettle tea", "It's a bowl of nettle tea.", "bowlNettleTea", Color.SeaGreen, 12) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Nettle tea (milky)", "It's a bowl of milky nettle tea.", "bowlNettleTeaMilky", Color.SeaGreen.GetBrighter(), 12) { UseString = "Potion", UseInt4 = 1, UseString3 = "bowlEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Cup of nettle tea", "It's a cup of nettle tea.", "cupNettleTea", Color.White, 12) { UseString = "Potion", UseInt4 = 1, UseString3 = "cupEmpty", Potion = new() { new("Heal", 3) } }); 
            itemsToAdd.Add(new Item("Cup of nettle tea (milky)", "It's a cup of milky nettle tea.", "cupNettleTeaMilky", Color.White, 12) { UseString = "Potion", UseInt4 = 1, UseString3 = "cupEmpty", Potion = new() { new("Heal", 3) } }); 
            

            itemsToAdd.Add(new Item("Fish spirit", "When you catch a fish, this is consumed and you will receive an extra fish.", "spiritFish", Color.Turquoise, 20, true) { MiscString = "Spirit", UseString2 = "fish" });
            itemsToAdd.Add(new Item("Herb spirit", "When you brew a potion, this is consumed and your potion will have an extra dose.", "spiritHerb", Color.Lime, 20, true) { MiscString = "Spirit", UseString2 = "herb" });
            
             
            itemsToAdd.Add(new Item("Beer glass", "I need to fill this with beer.", "beerGlass", 200, 200, 200, 2));
            itemsToAdd.Add(new Item("Beer", "A glass of frothy ale.", "beer", 255, 255, 0, 2) { UseString = "Potion", UseInt4 = 1, UseString3 = "beerGlass", Potion = new() { new("Heal", 1), new("Attack", -2), new("Strength", 2) } });
            itemsToAdd.Add(new Item("Dwarven stout", "A pint of thick dark beer.", "dwarvenStout", Color.DimGray, 2) { UseString = "Potion", UseInt4 = 1, UseString3 = "beerGlass", Potion = new() { new("Heal", 1), new("Attack", -3), new("Strength", -3), new("Defense", -3), new("Mining", 1), new("Smithing", 1) } });
            
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


            itemsToAdd.Add(new Item("Empty bucket", "An empty bucket. Could probably hold something.", "bucketEmpty", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Bucket of water", "A bucket filled with water.", "bucketWater", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Bucket of milk", "A bucket filled with milk.", "bucketMilk", 111, 66, 33, 2));
            itemsToAdd.Add(new Item("Bucket of compost", "Good for plants, helps them grow.", "bucketCompost", 111, 66, 33, 2) { UseString = "Compost", UseInt = 1 });
            itemsToAdd.Add(new Item("Pot of cream", "Fresh cream.", "cream", Color.White, 4));
            itemsToAdd.Add(new Item("Pat of butter", "A pat of freshly churned butter.", "butter", Color.LightYellow, 8));
            itemsToAdd.Add(new Item("Cheese", "Cheese, Gromit! Cheese!", "cheese", Color.Yellow, 12));
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
            itemsToAdd.Add(new Item("Copper ore spirit", "When mining copper, this is consumed and you will receive an extra ore.", "spiritOreCopper", Color.Orange, 20, true) { MiscString = "Spirit", UseString2 = "oreCopper" });
            itemsToAdd.Add(new Item("Tin ore", "A pile of tin ore nuggets.", "oreTin", Color.DarkGray, 3)); 
            itemsToAdd.Add(new Item("Tin ore spirit", "When mining tin, this is consumed and you will receive an extra ore.", "spiritOreTin", Color.DarkGray, 20, true) { MiscString = "Spirit", UseString2 = "oreTin" });
            itemsToAdd.Add(new Item("Bronze ore mix", "A mix of copper and tin ore nuggets.", "oreMixBronze", ColorLib.Bronze, 6)); 
            itemsToAdd.Add(new Item("Bronze bar", "It's a bar of bronze.", "barBronze", ColorLib.Bronze, 8));
            itemsToAdd.Add(new Item("Iron ore", "A pile of iron ore nuggets.", "oreIron", ColorLib.Bronze, 15)); 
            itemsToAdd.Add(new Item("Iron ore spirit", "When mining iron, this is consumed and you will receive an extra ore.", "spiritOreIron", ColorLib.Bronze, 20, true) { MiscString = "Spirit", UseString2 = "oreIron" });
            itemsToAdd.Add(new Item("Iron ore mix", "A mix iron ore nuggets with the impurities sifted out.", "oreMixIron", ColorLib.Bronze, 25)); 
            itemsToAdd.Add(new Item("Iron bar", "It's a bar of iron.", "barIron", ColorLib.Iron, 30));
            itemsToAdd.Add(new Item("Coal", "A lump of raw coal.", "oreCoal", Color.DimGray, 30)); 
            itemsToAdd.Add(new Item("Coal spirit", "When mining coal, this is consumed and you will receive an extra lump.", "spiritOreCoal", Color.DimGray, 20, true) { MiscString = "Spirit", UseString2 = "oreCoal" });
            itemsToAdd.Add(new Item("Steel ore mix", "A mix of iron ore nuggets and coal.", "oreMixSteel", ColorLib.Bronze, 45)); 
            itemsToAdd.Add(new Item("Steel bar", "It's a bar of iron.", "barSteel", ColorLib.Steel, 60)); 
            itemsToAdd.Add(new Item("Mithril ore", "A pile of mithril ore nuggets.", "oreMithril", ColorLib.Mithril, 60)); 
            itemsToAdd.Add(new Item("Mithril ore spirit", "When mining mithril, this is consumed and you will receive an extra ore.", "spiritOreMithril", ColorLib.Mithril, 20, true) { MiscString = "Spirit", UseString2 = "oreMithril" });
            itemsToAdd.Add(new Item("Mithril ore mix", "A mix of mithril ore nuggets and coal.", "oreMixMithril", ColorLib.Mithril, 90)); 
            itemsToAdd.Add(new Item("Mithril bar", "It's a bar of mithril.", "barMithril", ColorLib.Mithril, 120));
            itemsToAdd.Add(new Item("Luminite", "A lump of raw luminite.", "oreLuminite", Color.Yellow, 60));  
            itemsToAdd.Add(new Item("Luminite spirit", "When mining luminite, this is consumed and you will receive an extra lump.", "spiritOreLuminite", Color.Yellow, 20, true) { MiscString = "Spirit", UseString2 = "oreLuminite" });
            itemsToAdd.Add(new Item("Adamant ore", "A pile of adamant ore nuggets.", "oreAdamant", ColorLib.Adamant, 120)); 
            itemsToAdd.Add(new Item("Adamant ore spirit", "When mining adamant, this is consumed and you will receive an extra ore.", "spiritOreAdamant", ColorLib.Adamant, 20, true) { MiscString = "Spirit", UseString2 = "oreAdamant" });
            itemsToAdd.Add(new Item("Adamant ore mix", "A mix of adamant ore nuggets and luminite.", "oreMixAdamant", ColorLib.Adamant, 180)); 
            itemsToAdd.Add(new Item("Adamant bar", "It's a bar of adamant.", "barAdamant", ColorLib.Adamant, 240));
            itemsToAdd.Add(new Item("Runite ore", "A pile of runite ore nuggets.", "oreRunite", ColorLib.Rune, 300)); 
            itemsToAdd.Add(new Item("Runite ore spirit", "When mining runite, this is consumed and you will receive an extra ore.", "spiritOreRunite", ColorLib.Rune, 20, true) { MiscString = "Spirit", UseString2 = "oreRunite" });
            itemsToAdd.Add(new Item("Runite ore mix", "A mix of runite ore nuggets and luminite.", "oreMixRunite", ColorLib.Rune, 360)); 
            itemsToAdd.Add(new Item("Rune bar", "It's a bar of rune.", "barRune", ColorLib.Rune, 480));
            itemsToAdd.Add(new Item("Drakolith", "A lump of raw drakolith.", "oreDrakolith", Color.Yellow, 250));  
            itemsToAdd.Add(new Item("Drakolith spirit", "When mining drakolith, this is consumed and you will receive an extra lump.", "spiritOreDrakolith", Color.Yellow, 20, true) { MiscString = "Spirit", UseString2 = "oreDrakolith" });
            itemsToAdd.Add(new Item("Orichalcum ore", "A pile of orichalcum ore nuggets.", "oreOrichalcum", Color.Crimson, 500)); 
            itemsToAdd.Add(new Item("Orichalcum ore spirit", "When mining orichalcum, this is consumed and you will receive an extra ore.", "spiritOreOrichalcum", Color.Crimson, 20, true) { MiscString = "Spirit", UseString2 = "oreOrichalcum" });
            itemsToAdd.Add(new Item("Orichalcum ore mix", "A mix of orichalcum ore nuggets and drakolith.", "oreMixOrichalcum", Color.Crimson, 750)); 
            itemsToAdd.Add(new Item("Orichalcum bar", "It's a bar of orichalcum.", "barOrichalcum", Color.Crimson, 1000));
            itemsToAdd.Add(new Item("Phasmatite", "A lump of raw phasmatite.", "orePhasmatite", Color.SpringGreen, 500));  
            itemsToAdd.Add(new Item("Phasmatite spirit", "When mining phasmatite, this is consumed and you will receive an extra lump.", "spiritOrePhasmatite", Color.SpringGreen, 20, true) { MiscString = "Spirit", UseString2 = "orePhasmatite" });
            itemsToAdd.Add(new Item("Necrite ore", "A pile of necrite ore nuggets.", "oreNecrite", Color.ForestGreen, 1000)); 
            itemsToAdd.Add(new Item("Necrite ore spirit", "When mining necrite, this is consumed and you will receive an extra ore.", "spiritOreNecrite", Color.ForestGreen, 20, true) { MiscString = "Spirit", UseString2 = "oreNecrite" });
            itemsToAdd.Add(new Item("Necrite ore mix", "A mix of necrite ore nuggets and phasmatite.", "oreMixNecrite", Color.ForestGreen, 1500)); 
            itemsToAdd.Add(new Item("Necronium bar", "It's a bar of necronium.", "barNecronium", Color.ForestGreen, 2000)); 
            itemsToAdd.Add(new Item("Banite ore", "A pile of banite ore nuggets.", "oreBanite", Color.MediumSlateBlue, 1500)); 
            itemsToAdd.Add(new Item("Banite ore spirit", "When mining banite, this is consumed and you will receive an extra ore.", "spiritOreBanite", Color.MediumSlateBlue, 20, true) { MiscString = "Spirit", UseString2 = "oreBanite" });
            itemsToAdd.Add(new Item("Banite ore mix", "A mix of banite ore nuggets and phasmatite.", "oreMixBanite", Color.MediumSlateBlue, 3000)); 
            itemsToAdd.Add(new Item("Bane bar", "It's a bar of bane.", "barBane", Color.MediumSlateBlue, 4000)); 
            itemsToAdd.Add(new Item("Light animica", "The power of light condensed into an ore.", "oreAnimicaLight", Color.Turquoise, 3750, true));
            itemsToAdd.Add(new Item("Dark animica", "The power of darkness condensed into an ore.", "oreAnimicaDark", Color.Purple, 3750, true));
            itemsToAdd.Add(new Item("Animica mix", "A mix of light and dark animica.", "oreMixAnimica", Color.White, 7500)); 
            itemsToAdd.Add(new Item("Light animica ore spirit", "When mining light animica, this is consumed and you will receive an extra ore.", "spiritOreAnimicaLight", Color.Turquoise, 20, true) { MiscString = "Spirit", UseString2 = "oreAnimicaLight" });
            itemsToAdd.Add(new Item("Dark animica ore spirit", "When mining dark animica, this is consumed and you will receive an extra ore.", "spiritOreAnimicaDark", Color.Purple, 20, true) { MiscString = "Spirit", UseString2 = "oreAnimicaDark" });
            itemsToAdd.Add(new Item("Elder rune bar", "It's a bar of elder rune.", "barElderRune", ColorLib.Rune.GetBrighter(), 8000));
             
            itemsToAdd.Add(new Item("Silver ore", "A pile of silver ore nuggets.", "oreSilver", ColorLib.Steel, 50)); 
            itemsToAdd.Add(new Item("Silver ore spirit", "When mining silver, this is consumed and you will receive an extra ore.", "spiritOreSilver", ColorLib.Steel, 20, true) { MiscString = "Spirit", UseString2 = "oreSilver" });
            itemsToAdd.Add(new Item("Silver ore mix", "A mix silver ore nuggets with the impurities sifted out.", "oreMixSilver", ColorLib.Steel, 100)); 
            itemsToAdd.Add(new Item("Silver bar", "It's a bar of silver.", "barSilver", ColorLib.Steel, 150)); 
            itemsToAdd.Add(new Item("Gold ore", "A pile of gold ore nuggets.", "oreGold", Color.Goldenrod, 100)); 
            itemsToAdd.Add(new Item("Gold ore spirit", "When mining gold, this is consumed and you will receive an extra ore.", "spiritOreGold", Color.Goldenrod, 20, true) { MiscString = "Spirit", UseString2 = "oreGold" });
            itemsToAdd.Add(new Item("Gold ore mix", "A mix gold ore nuggets with the impurities sifted out.", "oreMixGold", Color.Goldenrod, 200)); 
            itemsToAdd.Add(new Item("Gold bar", "It's a bar of gold.", "barGold", Color.Goldenrod, 300));

            // Smithing Factory
            List<MaterialDef> Metals = new() {
                new("Tutorial", Color.White, 2, 1, 100, "slight"), 
                new("Bronze", ColorLib.Bronze, 1, 1, 15, "minimal"), 
                new("Iron", ColorLib.Iron, 2, 10, 45, "slight"),
                new("Black", Color.DimGray, 3, 10, 500, "sinister"),  
                new("Steel", ColorLib.Steel, 3, 20, 90, "adequate"), 
                new("Mithril", ColorLib.Mithril, 4, 30, 180, "good"),
                new("Adamant", ColorLib.Adamant, 5, 40, 360, "great"), 
                new("Rune", ColorLib.Rune, 6, 50, 720, "proprietary"), 
                new("Dragon", Color.Crimson.GetBrighter(), 8, 60, 1500, "draconic"),
                new("Orichalcum", Color.Crimson, 7, 60, 1500, "excellent"), 
                new("Necronium", Color.ForestGreen, 8, 70, 3000, "incredible"), 
                new("Bane", Color.MediumSlateBlue, 9, 80, 6000, "amazing"),
                new("Elder rune", ColorLib.Rune.GetBrighter(), 10, 90, 12000, "unbelievable")
            }; 

            for (int i = 0; i < Metals.Count; i++) {
                int fullMult = Metals[i].CostMultiplier;

                string tempName = Metals[i].Name == "Elder rune" ? "ElderRune" : Metals[i].Name;

                Item helm = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head.", "helm" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(helm);

                Item platebody = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso.", "platebody" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(platebody);

                Item chainmail = new Item(Metals[i].Name + " chainmail", "Provides " + Metals[i].Descriptor + " melee protection for the torso.", "chainmail" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 5) {
                    EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(chainmail);

                Item platelegs = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs.", "platelegs" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(platelegs);

                Item plateskirt = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs.", "plateskirt" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 3) {
                    EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(plateskirt);

                Item boots = new Item(Metals[i].Name + " boots", "Provides " + Metals[i].Descriptor + " melee protection for the feet.", "boots" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Feet",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(boots);

                Item gauntlets = new Item(Metals[i].Name + " gauntlets", "Provides " + Metals[i].Descriptor + " melee protection for the hands.", "gauntlets" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Hands",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(gauntlets);

                Item arrows = new Item(Metals[i].Name + " arrows", "Time flies like an arrow. Fruit flies like a banana.", "arrows" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true) {
                    EquipSlot = "Ammo",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedStandard"
                };
                itemsToAdd.Add(arrows);

                Item unfbolts = new Item(Metals[i].Name + " bolts (unf)", tempName + " crossbow bolts, sans feathers.", "boltsUnf" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true);
                itemsToAdd.Add(unfbolts);

                Item bolts = new Item(Metals[i].Name + " bolts", tempName + " crossbow bolts.", "bolts" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true) {
                    EquipSlot = "Ammo",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedHeavy"
                };
                itemsToAdd.Add(bolts);

                Item knives = new Item(Metals[i].Name + " knives", "A finely balanced throwing knife.", "knives" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 5, true) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Ranged", EquipLevel = Metals[i].Level, EquipDamageType = "RangedLight", EquipAmmo = "Self"
                };
                itemsToAdd.Add(knives);

                Item arrowheads = new Item(Metals[i].Name + " arrowheads", "I can make some arrows with these.", "arrowheads" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult / 15, true);
                itemsToAdd.Add(arrowheads);

                Item hatchet = new Item(Metals[i].Name + " hatchet", "Good for chopping trees.", "hatchet" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult, misc: "Hatchet") {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash"
                };
                itemsToAdd.Add(hatchet);

                Item pickaxe = new Item(Metals[i].Name + " pickaxe", "Good for mining.", "pickaxe" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult, misc: "Pickaxe") {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab", AttackSpeed = 1.5
                };
                itemsToAdd.Add(pickaxe);

                Item dagger = new Item(Metals[i].Name + " dagger", "Good for stabbing.", "dagger" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab"
                };
                itemsToAdd.Add(dagger);

                Item sword = new Item(Metals[i].Name + " sword", "Good for slashing.", "sword" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash"
                };
                itemsToAdd.Add(sword);

                Item mace = new Item(Metals[i].Name + " mace", "Good for crushing.", "mace" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Crush"
                };
                itemsToAdd.Add(mace); 

                Item scimitar = new Item(Metals[i].Name + " scimitar", "Good for slashing quickly.", "scimitar" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash", AttackSpeed = 0.75
                };
                itemsToAdd.Add(scimitar);

                Item spear = new Item(Metals[i].Name + " spear", "Good for stabbing quickly.", "spear" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab", AttackSpeed = 0.75, TwoHanded = true
                };
                itemsToAdd.Add(spear);

                Item battleaxe = new Item(Metals[i].Name + " battleaxe", "Powerful slashes but slow.", "battleaxe" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Slash", AttackSpeed = 1.5, TwoHanded = true
                };
                itemsToAdd.Add(battleaxe);
                 
                Item sword2h = new Item(Metals[i].Name + " 2h sword", "Powerful stabs but slow.", "sword2h" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Stab", AttackSpeed = 1.5, TwoHanded = true
                };
                itemsToAdd.Add(sword2h);

                Item warhammer = new Item(Metals[i].Name + " warhammer", "Powerful crushing but slow.", "warhammer" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                    EquipSlot = "Weapon",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Attack", EquipLevel = Metals[i].Level, EquipDamageType = "Crush", AttackSpeed = 1.5, TwoHanded = true
                };
                itemsToAdd.Add(warhammer);

                Item sqshield = new Item(Metals[i].Name + " square shield", "A medium square shield.", "sqShield" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 2) {
                    EquipSlot = "Offhand",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(sqshield);

                Item kiteshield = new Item(Metals[i].Name + " kiteshield", "A large metal shield.", "kiteshield" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 3) {
                    EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                };
                itemsToAdd.Add(kiteshield);

                itemsToAdd.Add(new Item(Metals[i].Name + " crossbow limbs", "Can be combined with a crossbow stock to make an unstrung crossbow.", "limbs" + tempName, Metals[i].R, Metals[i].G, Metals[i].B, fullMult));

                if (tempName == "Bronze" || tempName == "Bronze" || tempName == "Iron" || tempName == "Steel" || tempName == "Black" || tempName == "Mithril" || tempName == "Adamant") {
                    // Trimmed
                    Item helmT = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head. Trimmed.", "helm" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                        CosmeticNote = "t", EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(helmT); 

                    Item platebodyT = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso. Trimmed.", "platebody" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 10) {
                        CosmeticNote = "t", EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platebodyT);

                    Item platelegsT = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed.", "platelegs" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "t", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platelegsT);

                    Item plateskirtT = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed.", "plateskirt" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "t", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(plateskirtT);

                    Item kiteshieldT = new Item(Metals[i].Name + " kiteshield", "A large metal shield. Trimmed.", "kiteshield" + tempName + "T", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "t", EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(kiteshieldT);

                    // Gold trimmed
                    Item helmG = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head. Trimmed with gold.", "helm" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                        CosmeticNote = "g", EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(helmG); 

                    Item platebodyG = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso. Trimmed with gold.", "platebody" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 10) {
                        CosmeticNote = "g", EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platebodyG);

                    Item platelegsG = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed with gold.", "platelegs" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "g", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platelegsG);

                    Item plateskirtG = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Trimmed with gold.", "plateskirt" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "g", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(plateskirtG);

                    Item kiteshieldG = new Item(Metals[i].Name + " kiteshield", "A large metal shield. Trimmed with gold.", "kiteshield" + tempName + "G", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "g", EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(kiteshieldG);

                    // Heraldric
                    Item helmH = new Item(Metals[i].Name + " helmet", "Provides " + Metals[i].Descriptor + " melee protection for the head. Bears a heraldric design.", "helm" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 4) {
                        CosmeticNote = "h", EquipSlot = "Head",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(helmH); 

                    Item platebodyH = new Item(Metals[i].Name + " platebody", "Provides " + Metals[i].Descriptor + " melee protection for the torso. Bears a heraldric design.", "platebody" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 10) {
                        CosmeticNote = "h", EquipSlot = "Body",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platebodyH);

                    Item platelegsH = new Item(Metals[i].Name + " platelegs", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Bears a heraldric design.", "platelegs" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "h", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(platelegsH);

                    Item plateskirtH = new Item(Metals[i].Name + " plateskirt", "Provides " + Metals[i].Descriptor + " melee protection for the legs. Bears a heraldric design.", "plateskirt" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "h", EquipSlot = "Legs",  EquipTier = Metals[i].Tier, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(plateskirtH);

                    Item kiteshieldH = new Item(Metals[i].Name + " kiteshield", "A large metal shield. Bears a heraldric design.", "kiteshield" + tempName + "H", Metals[i].R, Metals[i].G, Metals[i].B, fullMult * 6) {
                        CosmeticNote = "h", EquipSlot = "Offhand",  EquipTier = Metals[i].Tier + 1, EquipSkill = "Defense", EquipLevel = Metals[i].Level, MiscString = "DefenseMelee"
                    };
                    itemsToAdd.Add(kiteshieldH);
                }
            } 
             
            itemsToAdd.Add(new Item("Shield left half", "The left half of a dragon square shield.", "shieldLeftHalf", Color.Crimson.GetBrighter(), 110000));
            itemsToAdd.Add(new Item("Shield right half", "The right half of a dragon square shield.", "shieldRightHalf", Color.Crimson.GetBrighter(), 500000));
            



            itemsToAdd.Add(new Item("Huge club", "Upon closer inspection this is actually a huge femur.", "clubHuge", 255, 255, 255, 1000) {
                EquipSlot = "Weapon",  EquipTier = 3, EquipSkill = "Attack", EquipLevel = 10, EquipDamageType = "Crush", AttackSpeed = 1.5
            });itemsToAdd.Add(new Item("Huger club", "Where did that zombie even get such a large bone? You can barely move this thing.", "clubHuger", 255, 255, 255, 5000) {
                EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Attack", EquipLevel = 10, EquipDamageType = "Crush", AttackSpeed = 3
            });  
            itemsToAdd.Add(new Item("Baby zombie plush", "Despite being a zombie, kinda cute? It even has a little chicken that it's riding on.", "petBabyZombie", 34, 140, 34, 1000) {
                EquipSlot = "Pet",  Cosmetic = true, PetBlurbs = new() { "The baby zombie gurgles a bit.", "The zombie's chicken clucks loudly.", "The baby zombie runs in a small circle quickly.", "CHICKEN JOCKEY!"}
            });  
            itemsToAdd.Add(new Item("Rotten flesh", "This doesn't really seem edible...", "fleshRotten", 150, 100, 50, 4) { UseString = "Heal", UseInt = 2, Potion = new() { new("Attack", -3) } });
            
            
            
            itemsToAdd.Add(new Item("Swamp tar", "A foul smelling thick tar-like substance.", "swampTar", 50, 50, 50, 1, true));
            
            itemsToAdd.Add(new Item("Pestle and mortar", "I can grind things for potions in this.", "pestleMortar", Color.White, 4));
            itemsToAdd.Add(new Item("Eye of newt", "A basic herblore ingredient and only slightly gross.", "eyeNewt", 255, 255, 255, 3));
            itemsToAdd.Add(new Item("Unicorn horn", "This horn has restorative properties.", "unicornHorn", Color.SandyBrown, 20));
            itemsToAdd.Add(new Item("Unicorn horn dust", "Finely ground horn of Unicorn.", "unicornHornDust", Color.SandyBrown, 25));
            itemsToAdd.Add(new Item("Chocolate bar", "Mmmmmmmm chocolate.", "chocolateBar", Color.Chocolate, 10));
            itemsToAdd.Add(new Item("Unicorn horn dust", "It's ground up chocolate.", "chocolateDust", Color.Chocolate, 10));
            itemsToAdd.Add(new Item("Bear fur", "This would make warm clothing.", "bearFur", Color.SandyBrown, 10));
            itemsToAdd.Add(new Item("Red spiders' eggs", "Ewww!", "spiderEggsRed", Color.Crimson, 7));
            itemsToAdd.Add(new Item("Goat horn", "Not much good for blowing.", "goatHorn", Color.AntiqueWhite, 12));
            itemsToAdd.Add(new Item("Goat horn dust", "Finely ground goat horn.", "goatHornDust", Color.AntiqueWhite, 12));

            itemsToAdd.Add(new Item("Vial", "A glass vial, currently empty.", "vialEmpty", 200, 200, 200, 2) { colA = 150 });
            itemsToAdd.Add(new Item("Vial of water", "A glass vial full of water.", "vialWater", 14, 129, 205, 2) { colA = 150 });
            itemsToAdd.Add(new Item("Guam potion (unf)", "I need another ingredient to finish this Guam potion.", "potionUnfGuam", ColorLib.Guam.SetAlpha(150), 3));
            itemsToAdd.Add(new Item("Marrentill potion (unf)", "I need another ingredient to finish this Marrentill potion.", "potionUnfMarrentill", ColorLib.Marrentill.SetAlpha(150), 5));
            itemsToAdd.Add(new Item("Tarromin potion (unf)", "I need another ingredient to finish this Tarromin potion.", "potionUnfTarromin", ColorLib.Tarromin.SetAlpha(150), 11));
            itemsToAdd.Add(new Item("Harralander potion (unf)", "I need another ingredient to finish this Harralander potion.", "potionUnfHarralander", ColorLib.Harralander.SetAlpha(150), 20));
            itemsToAdd.Add(new Item("Ranarr potion (unf)", "I need another ingredient to finish this Ranarr potion.", "potionUnfRanarr", ColorLib.Ranarr.SetAlpha(150), 25));
            itemsToAdd.Add(new Item("Toadflax potion (unf)", "I need another ingredient to finish this Toadflax potion.", "potionUnfToadflax", ColorLib.Toadflax.SetAlpha(150), 48));
            itemsToAdd.Add(new Item("Irit potion (unf)", "I need another ingredient to finish this Irit potion.", "potionUnfIrit", ColorLib.Irit.SetAlpha(150), 40));
            itemsToAdd.Add(new Item("Avantoe potion (unf)", "I need another ingredient to finish this Avantoe potion.", "potionUnfAvantoe", ColorLib.Avantoe.SetAlpha(150), 48));
            itemsToAdd.Add(new Item("Snapdragon potion (unf)", "I need another ingredient to finish this Snapdragon potion.", "potionUnfSnapdragon", ColorLib.Snapdragon.SetAlpha(150), 59));
            itemsToAdd.Add(new Item("Cadantine potion (unf)", "I need another ingredient to finish this Cadantine potion.", "potionUnfCadantine", ColorLib.Cadantine.SetAlpha(150), 65));
            itemsToAdd.Add(new Item("Lantadyme potion (unf)", "I need another ingredient to finish this Lantadyme potion.", "potionUnfLantadyme", ColorLib.Lantadyme.SetAlpha(150), 68));
            itemsToAdd.Add(new Item("Dwarf weed potion (unf)", "I need another ingredient to finish this Dwarf weed potion.", "potionUnfDwarfweed", ColorLib.Dwarfweed.SetAlpha(150), 70));
            itemsToAdd.Add(new Item("Torstol potion (unf)", "I need another ingredient to finish this Torstol potion.", "potionUnfTorstol", ColorLib.Torstol.SetAlpha(150), 25));
            itemsToAdd.Add(new Item("Spirit weed potion (unf)", "I need another ingredient to finish this Spirit weed potion.", "potionUnfSpiritweed", ColorLib.Spiritweed.SetAlpha(150), 54));
            itemsToAdd.Add(new Item("Fellstalk potion (unf)", "I need another ingredient to finish this Fellstalk potion.", "potionUnfFellstalk", ColorLib.Fellstalk.SetAlpha(150), 150));
            itemsToAdd.Add(new Item("Arbuck potion (unf)", "I need another ingredient to finish this Arbuck potion.", "potionUnfArbuck", ColorLib.Arbuck.SetAlpha(150), 100));
            itemsToAdd.Add(new Item("Bloodweed potion (unf)", "I need another ingredient to finish this Bloodweed potion.", "potionUnfBloodweed", ColorLib.Bloodweed.SetAlpha(150), 70));
            itemsToAdd.Add(new Item("Wergali potion (unf)", "I need another ingredient to finish this Wergali potion.", "potionUnfWergali", ColorLib.Wergali.SetAlpha(150), 45));
            itemsToAdd.Add(new Item("Kwuarm potion (unf)", "I need another ingredient to finish this Kwuarm potion.", "potionUnfKwuarm", ColorLib.Kwuarm.SetAlpha(150), 54));
            
            
            itemsToAdd.Add(new Item("Attack potion", "Temporarily boosts your Attack level by 5.", "potionAttack", 0, 255, 255, 5) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Attack", 5) } });
            itemsToAdd.Add(new Item("Strength potion", "Temporarily boosts your Strength level by 5.", "potionStrength", Color.Yellow, 5) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Strength", 5) } });
            itemsToAdd.Add(new Item("Magic potion", "Temporarily boosts your Magic level by 5.", "potionMagic", Color.CadetBlue, 80) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Magic", 5) } });
            itemsToAdd.Add(new Item("Defense potion", "Temporarily boosts your Defense level by 5.", "potionDefense", Color.Lime, 50) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Defense", 5) } });
            itemsToAdd.Add(new Item("Combat potion", "Temporarily boosts your Attack and Strength levels by 5 each.", "potionCombat", Color.SpringGreen, 70) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Attack", 5), new("Strength", 5) } });
            itemsToAdd.Add(new Item("Cooking potion", "Temporarily boosts your Cooking level by 5.", "potionCooking", Color.Orange, 50) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Cooking", 5) } });
            itemsToAdd.Add(new Item("Ranging potion", "Temporarily boosts your Ranged level by 5.", "potionRanging", Color.Cyan, 90) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Ranged", 5) } });
            itemsToAdd.Add(new Item("Energy potion", "Energizes you to receive up to 5% additional experience from all actions.", "potionEnergy", Color.DeepPink.GetDark(), 50) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Experience", 5) } });
            itemsToAdd.Add(new Item("Restore potion", "Restores reduced stats by up to 5 levels per sip.", "potionRestore", Color.Salmon, 30) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Restore", 5) } });
            itemsToAdd.Add(new Item("Antipoison", "Cures poison and provides immunity to poison for two minutes.", "potionAntipoison", Color.Lime, 90) { UseString = "Potion", UseInt4 = 3, UseString3 = "vialEmpty", Potion = new() { new("Antipoison", 2) } });
            

            itemsToAdd.Add(new Item("Rusted sword [Q]", "The sword is useless now. You notice someone has scratched something into the handle: 'PlayerOne'.", "TI_HI_RustedSword", 205, 127, 50, 0, trade: false));
            itemsToAdd.Add(new Item("Crumpled note [Q]", "A torn note. It reads 'okay this is actually pretty cool', and 'how do i save the game'.", "TI_HI_CrumpledNote", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Bank record [Q]", "A bank record. It reads 'ACCOUNT: PlayerOne', 'LAST ACCESS: [DATA UNAVAILABLE]'.", "TI_HI_BankRecord", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Strange rune [Q]", "You have absolutely no idea what this could be for. Someone might know more.", "TI_HI_StrangeRune", 147, 112, 219, 0, trade: false) {
                UseString = "SecondExamine",
                MiscString = "ERROR: SPELL SYSTEM NOT FOUND.",
                ConsumedOnUse = false
            });
            itemsToAdd.Add(new Item("White bead [Q]", "A small round white bead.", "beadWhite", 255, 255, 255, 4));
            itemsToAdd.Add(new Item("Red bead [Q]", "A small round red bead.", "beadRed", 255, 0, 0, 4));
            itemsToAdd.Add(new Item("Black bead [Q]", "A small round black bead.", "beadBlack", 50, 50, 50, 4));
            itemsToAdd.Add(new Item("Yellow bead [Q]", "A small round yellow bead.", "beadYellow", 255, 255, 0, 4));
            
            itemsToAdd.Add(new Item("Ghostspeak amulet [Q]", "It lets me talk to ghosts.", "amuletGhostspeak", 255, 255, 0, 4, trade: false) { EquipSlot = "Amulet" });
            itemsToAdd.Add(new Item("Ghost's skull [Q]", "Ooooh spooky!", "mistWizGhostSkull", 255, 255, 255, 4, trade: false) { UseString = "SecondExamine", MiscString = "It's the skull of the ghost that is haunting Lumbridge graveyard. Maybe I should return this back to the ghost's coffin.", ConsumedOnUse = false});
            itemsToAdd.Add(new Item("Al Kharid flyer", "The money off voucher has expired.", "flyerAli", Color.Khaki, 1) { UseString = "SecondExamine", MiscString = "'Come to the Al Kharid Market place! High quality produce at low, low prices! Show this flyer to a merchant for money off your next purchase, courtesy of Ali Morrisane!'", ConsumedOnUse = false});

            itemsToAdd.Add(new Item("Ham hood", "Light-weight head protection and eye shield.", "hamHood", Color.HotPink, 75) { EquipSlot = "Head" });
            itemsToAdd.Add(new Item("Ham shirt", "The label says 'Vivid Crimson' but it looks pink to me!", "hamShirt", Color.HotPink, 75) { EquipSlot = "Torso" });
            itemsToAdd.Add(new Item("Ham skirt", "The label says 'Vivid Crimson' but it looks pink to me!", "hamSkirt", Color.HotPink, 75) { EquipSlot = "Legs" });
            itemsToAdd.Add(new Item("Ham gloves", "HAM gloves as worn by the Humans Against Monsters group.", "hamGloves", Color.HotPink, 75) { EquipSlot = "Hands" });
            itemsToAdd.Add(new Item("Ham boots", "HAM boots as worn by the Humans Against Monsters group.", "hamBoots", Color.HotPink, 75) { EquipSlot = "Feet" });
            itemsToAdd.Add(new Item("Ham cloak", "A HAM cape.", "hamCloak", Color.HotPink, 75) { EquipSlot = "Cape" });
            itemsToAdd.Add(new Item("Ham logo", "A badge for the HAM cult.", "hamLogo", Color.HotPink, 75) { EquipSlot = "Pocket" });
                 
            
            itemsToAdd.Add(new Item("Goblin champion scroll", "It's a challenge from the Goblin Champion!", "scrollChampionGoblin", Color.ForestGreen, 1, trade: false));
            itemsToAdd.Add(new Item("Lesser demon champion scroll", "It's a challenge from the Lesser Demon Champion!", "scrollChampionLesserDemon", Color.Crimson, 1, trade: false));
            itemsToAdd.Add(new Item("Imp champion scroll", "It's a challenge from the Imp Champion!", "scrollChampionImp", Color.Crimson.GetBrighter(), 1, trade: false));
            itemsToAdd.Add(new Item("Zombie champion scroll", "It's a challenge from the Zombie Champion!", "scrollChampionZombie", Color.Teal, 1, trade: false));
            itemsToAdd.Add(new Item("Skeleton champion scroll", "It's a challenge from the Skeleton Champion!", "scrollChampionSkeleton", Color.White, 1, trade: false));

            
            itemsToAdd.Add(new Item("Icosahedron [M]", "A blue icosahedron. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaIcosahedron", Color.DodgerBlue, 0, trade: false));
            itemsToAdd.Add(new Item("Cube [M]", "A yellow cube. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaCube", Color.Yellow, 0, trade: false));
            itemsToAdd.Add(new Item("Pentamid [M]", "A red pentamid. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaPentamid", Color.Crimson, 0, trade: false));
            itemsToAdd.Add(new Item("Cylinder [M]", "A green cylinder. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaCylinder", Color.ForestGreen, 0, trade: false));
            itemsToAdd.Add(new Item("Dragonstone [M]", "A purple dragonstone. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaDragonstone", Color.Purple, 0, trade: false));
            itemsToAdd.Add(new Item("Orb [M]", "A white orb. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaOrb", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Strange bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone1", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Odd bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone2", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Weird bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone3", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Unusual bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone4", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Leather boots [M]", "Leather boots. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch1", Color.SaddleBrown, 3, trade: false));
            itemsToAdd.Add(new Item("Adamant kiteshield [M]", "An adamant kiteshield. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch2", ColorLib.Adamant, 3, trade: false));
            itemsToAdd.Add(new Item("Adamant helmet [M]", "An adamant helmet. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch3", ColorLib.Adamant, 3, trade: false));
            itemsToAdd.Add(new Item("Emerald [M]", "An emerald. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch4", Color.Lime, 3, trade: false));
            itemsToAdd.Add(new Item("Rune sword [M]", "A rune sword. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch5", ColorLib.Rune, 3, trade: false));
            itemsToAdd.Add(new Item("Coins [M]", "Coins. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlchCoin", Color.Goldenrod, 0, true, false));
            
            itemsToAdd.Add(new Item("Coins", "Filthy lucre. Activate to add to your coin pouch.", "coins", Color.Goldenrod, 1, true) { UseString = "Gold" });
            itemsToAdd.Add(new Item("Key (Varrock shack)", "This key opens the door of the shack at the Varrock West Crossroads.", "keyVarrockShack", Color.Goldenrod, 1));
            itemsToAdd.Add(new Item("Key (clue step)", "Used to open the container you need to access for your clue step.", "keyClue", Color.Goldenrod, 0, trade: false));

            itemsToAdd.Add(new Item("Pie recipe book", "Lots of pie recipes for me to try.", "bookRecipesPie", Color.Crimson, 5) { ConsumedOnUse = false, UseString = "Book", UseString2 = "recipesPie"});
            itemsToAdd.Add(new Item("Scrumpled paper", "A piece of paper with barely legible writing - looks like a recipe!", "paperScrumpled", Color.White, 10) { ConsumedOnUse = false, UseString = "Book", UseString2 = "paperScrumpled" });


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
