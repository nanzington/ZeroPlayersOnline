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
            

            itemsToAdd.Add(new Item("Tutorial Island cape", "A cape signifying you completed all challenges on Tutorial Island. Congratulations!", "capeCompTI", 135, 206, 235, 0) { EquipSlot = "Cape", EquipTier = 1, MiscString = "OmniBoost" });
            itemsToAdd.Add(new Item("Defense skillcape", "The cape worn by masters of the art of Defense.", "capeSkillDefense", Color.CornflowerBlue, 0) { EquipSlot = "Cape", EquipTier = 2, MiscString = "OmniBoost" });
            itemsToAdd.Add(new Item("Cooking skillcape", "The cape worn by masters of the art of Cooking.", "capeSkillCooking", Color.Purple, 0) { EquipSlot = "Cape", EquipTier = 2, MiscString = "OmniBoost" });
            itemsToAdd.Add(new Item("Farming skillcape", "The cape worn by masters of the art of Farming.", "capeSkillFarming", Color.ForestGreen, 0) { EquipSlot = "Cape", EquipTier = 2, MiscString = "OmniBoost" });

            {
                // ordinary wizard
                itemsToAdd.Add(new Item("Blue wizard hat", "A silly pointed hat.", "wizardBlueHat", 0, 157, 196, 2) { EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard shirt", "I can do better magic in this.", "wizardBlueRobe", 0, 157, 196, 15) { EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Blue wizard skirt", "I can do better magic in this.", "wizardBlueBottom", 0, 157, 196, 15) { EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard hat", "A silly pointed hat.", "wizardBlackHat", Color.DimGray, 2) { EquipSlot = "Head", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard shirt", "I can do better magic in this.", "wizardBlackRobe", Color.DimGray, 15) { EquipSlot = "Body", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                itemsToAdd.Add(new Item("Black wizard skirt", "I can do better magic in this.", "wizardBlackBottom", Color.DimGray, 15) { EquipSlot = "Legs", EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMagic" });
                
                // Zamorak monk robes
                itemsToAdd.Add(new Item("Zamorak monk top", "A robe worn by worshippers of Zamorak.", "monkZamorakTop", Color.Crimson, 40) { EquipSlot = "Body", EquipTier = 1, MiscString = "PrayerBoost" });
                itemsToAdd.Add(new Item("Zamorak monk bottom", "A robe worn by worshippers of Zamorak.", "monkZamorakBottom", Color.Crimson, 30) { EquipSlot = "Legs", EquipTier = 1, MiscString = "PrayerBoost" });
               


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

            itemsToAdd.Add(new Item("Staff", "It's a slightly magical stick.", "staff", Color.BurlyWood, 15) { EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Magic staff", "It's a slightly magical stick.", "staffMagic", Color.BurlyWood, 200) { EquipSlot = "Weapon",  EquipTier = 2, EquipSkill = "Magic", EquipLevel = 10, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Beginner wand", "A beginner level wand.", "wandBeginner", Color.BurlyWood, 1200) { EquipSlot = "Weapon",  EquipTier = 4, EquipSkill = "Magic", EquipLevel = 30, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Apprentice wand", "An apprentice level wand.", "wandApprentice", Color.BurlyWood, 2400) { EquipSlot = "Weapon",  EquipTier = 5, EquipSkill = "Magic", EquipLevel = 40, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Teacher wand", "A teacher level wand.", "wandTeacher", Color.BurlyWood, 4800) { EquipSlot = "Weapon",  EquipTier = 6, EquipSkill = "Magic", EquipLevel = 50, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Master wand", "A master level wand.", "wandMaster", Color.BurlyWood, 100000) { EquipSlot = "Weapon",  EquipTier = 7, EquipSkill = "Magic", EquipLevel = 60, EquipDamageType = "Crush" });
            itemsToAdd.Add(new Item("Mage's book", "The magical book of a mage.", "magesBook", Color.Crimson, 100000) { EquipSlot = "Offhand",  EquipTier = 3, EquipSkill = "Magic", EquipLevel = 60, EquipDamageType = "Crush" });
            
            itemsToAdd.Add(new Item("Rune pouch note", "Can be exchanged for a rune pouch at any bank.", "pouchRuneNote", Color.SaddleBrown, 100000, trade: false) { UseString = "RedeemRunePouch" });
            itemsToAdd.Add(new Item("Rune pouch", "You can store runes in here.", "pouchRune", Color.SaddleBrown, 100000, trade: false) { OnlyOneOwnable = true, EquipSlot = "Pocket", EquipSkill = "Magic", EquipLevel = 66, UseString = "ViewInventory", ConsumedOnUse = false, ContainerSlots = 3, ContainableIDs = [ "runeAir","runeWater","runeEarth","runeFire","runeMind","runeBody","runeCosmic","runeChaos","runeAstral","runeNature","runeLaw","runeDeath","runeBlood","runeSoul","runeWrath","runeMist","runeDust","runeMud","runeSmoke","runeSteam","runeLava" ] });
            itemsToAdd.Add(new Item("Herb sack", "You can store grimy herbs in here, up to 30 of each kind.", "sackHerb", Color.SandyBrown, 1, trade: false) {  UseString = "ViewInventory", ConsumedOnUse = false, ContainerStacksUnstackable = true, ContainerMaxStack = 30, ContainerSlots = 30, ContainableIDs = [ "herbGrimyArbuck", "herbGrimyAvantoe", "herbGrimyBloodweed", "herbGrimyCadantine", "herbGrimyDwarfweed", "herbGrimyFellstalk", "herbGrimyGuam", "herbGrimyHarralander", "herbGrimyIrit", "herbGrimyKwuarm", "herbGrimyLantadyme", "herbGrimyMarrentill", "herbGrimyRanarr", "herbGrimySnapdragon", "herbGrimySpiritweed", "herbGrimyTarromin", "herbGrimyToadflax", "herbGrimyTorstol", "herbGrimyWergali" ] });
            

            itemsToAdd.Add(new Item("Chef's hat", "What a silly hat.", "chefHat", 255, 255, 255, 2) { EquipSlot = "Head", Cosmetic = true });
            itemsToAdd.Add(new Item("White apron", "What a silly hat.", "whiteApron", 255, 255, 255, 2) { EquipSlot = "Body", Cosmetic = true });
            itemsToAdd.Add(new Item("Brown apron", "A mostly clean apron.", "brownApron", Color.SaddleBrown, 2) { EquipSlot = "Body", Cosmetic = true });
            itemsToAdd.Add(new Item("Black cape", "A warm black cape.", "capeBlack", Color.DimGray, 7) { EquipSlot = "Cape", Cosmetic = true });
            itemsToAdd.Add(new Item("Goblin mail", "Some brown armor designed to fit goblins.", "goblinMail", Color.SaddleBrown, 40));
            itemsToAdd.Add(new Item("Goblin book", "A tattered goblin holy book.", "goblinBook", Color.SaddleBrown, 1) { UseString = "Book", UseString2 = "Goblin", ConsumedOnUse = false });


            
            itemsToAdd.Add(new Item("Air talisman", "A mysterious power emanates from the talisman...", "talismanAir", 200, 200, 200, 200));
            itemsToAdd.Add(new Item("Mind talisman", "A mysterious power emanates from the talisman...", "talismanMind", 231, 60, 0, 200)); 
            itemsToAdd.Add(new Item("Earth talisman", "A mysterious power emanates from the talisman...", "talismanEarth", Color.SaddleBrown, 200)); 
            itemsToAdd.Add(new Item("Fire talisman", "A mysterious power emanates from the talisman...", "talismanFire", Color.Firebrick, 200)); 
            itemsToAdd.Add(new Item("Water talisman", "A mysterious power emanates from the talisman...", "talismanWater", Color.CadetBlue, 200)); 
            itemsToAdd.Add(new Item("Chaos talisman", "A mysterious power emanates from the talisman...", "talismanChaos", Color.Orange, 200)); 
            itemsToAdd.Add(new Item("Nature talisman", "A mysterious power emanates from the talisman...", "talismanNature", Color.Green, 200)); 
            itemsToAdd.Add(new Item("Body talisman", "A mysterious power emanates from the talisman...", "talismanBody", Color.PowderBlue, 200)); 
            itemsToAdd.Add(new Item("Death talisman", "A mysterious power emanates from the talisman...", "talismanDeath", Color.White, 200)); 
            itemsToAdd.Add(new Item("Cosmic talisman", "A mysterious power emanates from the talisman...", "talismanCosmic", Color.Yellow, 200)); 
            itemsToAdd.Add(new Item("Law talisman", "A mysterious power emanates from the talisman...", "talismanLaw", Color.CadetBlue, 200));
            itemsToAdd.Add(new Item("Blood talisman", "A mysterious power emanates from the talisman...", "talismanBlood", Color.Crimson, 200)); 
            itemsToAdd.Add(new Item("Wrath talisman", "A mysterious power emanates from the talisman...", "talismanWrath", Color.DimGray, 500));   

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
            itemsToAdd.Add(new Item("Wrath rune", "Used for very high level missile spells.", "runeWrath", Color.LightGray, 500, true));
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


            // Slayer Items
            {
                itemsToAdd.Add(new Item("Slayer gem", "A pretty blue gem that can tell you your current slayer task.", "gemSlayer", 102, 205, 170, 1) { UseString = "SlayerGem", ConsumedOnUse = false });
                itemsToAdd.Add(new Item("Mirror shield", "I can just about see things in this shield's reflection.", "shieldMirror", Color.DarkGray, 5000) {
                    EquipSlot = "Offhand",  EquipTier = 3, EquipSkill = "Defense", EquipLevel = 20, MiscString = "DefenseAll", EquipReq = new("Skill", 25, "Slayer")
                });
                itemsToAdd.Add(new Item("Leaf-bladed spear", "A spear with a leaf-shaped point.", "spearLeafbladed", Color.DarkGray, 31000) {
                    EquipSlot = "Weapon",  EquipTier = 6, EquipSkill = "Attack", EquipLevel = 50, EquipReq = new("Skill", 55, "Slayer"), EquipDamageType = "Stab", EquipSecondaryDamage = "Leaf", AttackSpeed = 0.75, TwoHanded = true
                }); 
                itemsToAdd.Add(new Item("Broad arrows", "Arrows with a wider than normal tip.", "arrowsBroad", Color.DarkGray, 60, true) {
                    EquipSlot = "Ammo",  EquipTier = 6, EquipSkill = "Ranged", EquipLevel = 50, EquipDamageType = "RangedStandard", EquipSecondaryDamage = "Leaf", EquipReq = new("Skill", 55, "Slayer")
                }); 
                itemsToAdd.Add(new Item("Broad arrowheads", "Arrowheads with broad tips.", "arrowheadsBroad", Color.DarkGray, 55, true));

                itemsToAdd.Add(new Item("Broad bolts", "Bolts with a wider than normal tip.", "boltsBroad", Color.DarkGray, 60, true) {
                    EquipSlot = "Ammo",  EquipTier = 6, EquipSkill = "Ranged", EquipLevel = 50, EquipDamageType = "RangedHeavy", EquipSecondaryDamage = "Leaf", EquipReq = new("Skill", 55, "Slayer")
                });
                itemsToAdd.Add(new Item("Broad bolts (unf)", "Add feathers to make broad-tipped crossbow bolts.", "boltsUnfBroad", Color.DarkGray, 55, true));
                 
                itemsToAdd.Add(new Item("Rock hammer", "I can even smash stone with this.", "hammerRock", Color.Gray, 500, true));

                itemsToAdd.Add(new Item("Facemask", "Stops me breathing in too much dust.", "facemask", Color.SandyBrown, 200) { EquipSlot = "Head", EquipReq = new("Skill", 10, "Slayer") });
                itemsToAdd.Add(new Item("Earmuffs", "These will protect my ears from loud noise.", "earmuffs", Color.SaddleBrown, 200) { EquipSlot = "Head", EquipReq = new("Skill", 15, "Slayer") });
                itemsToAdd.Add(new Item("Nose peg", "Protects me from any bad smells.", "nosepeg", Color.BurlyWood, 200) { EquipSlot = "Head", EquipReq = new("Skill", 60, "Slayer") });
            
                itemsToAdd.Add(new Item("Slayer's staff", "An old and magical staff.", "staffSlayer", Color.DarkGray, 21000) {
                    EquipSlot = "Weapon",  EquipTier = 6, EquipSkill = "Magic", EquipLevel = 50, EquipReq = new("Skill", 55, "Slayer"), EquipDamageType = "Crush"
                });     
                
                itemsToAdd.Add(new Item("Spiny helmet", "You don't want to wear it inside-out.", "helmSpiny", Color.DarkGray, 650) { EquipSlot = "Head",  EquipTier = 2, EquipSkill = "Defense", EquipLevel = 10, MiscString = "DefenseAll" });
                 
                itemsToAdd.Add(new Item("Bag of salt", "A bag of salt.", "bagSalt", Color.White, 10, true));
                itemsToAdd.Add(new Item("Salt shaker", "Acts as unlimited salt.", "saltShaker", Color.White, 30000, true) { CountsAsIDs = ["bagSalt"], UseInt4 = -1 });
                itemsToAdd.Add(new Item("Fishing explosive", "The jar keeps shaking... I'm scared.", "explosiveFishing", Color.Gray, 60, true));
                itemsToAdd.Add(new Item("Explosive shaker", "Acts as unlimited fishing explosives.", "explosiveShaker", Color.Yellow, 50000, true) { CountsAsIDs = ["explosiveFishing"], UseInt4 = -1 });
                itemsToAdd.Add(new Item("Ice cooler", "Contains ice-cold water.", "iceCooler", Color.Turquoise, 1, true));
                itemsToAdd.Add(new Item("Ice shaker", "Acts as an unlimited ice cooler.", "iceShaker", Color.Turquoise, 40000, true) { CountsAsIDs = ["iceCooler"], UseInt4 = -1 });
                itemsToAdd.Add(new Item("Fungicide", "Does exactly what it says on the tin. (Kills fungi.)", "fungicide", Color.SkyBlue, 10, true));
                itemsToAdd.Add(new Item("Fungicide shaker", "Acts as unlimited fungicide.", "fungicideShaker", Color.SkyBlue, 60000, true) { CountsAsIDs = ["fungicide"], UseInt4 = -1 });
                
                
                itemsToAdd.Add(new Item("Slayer gloves", "Especially good against diseased arachnids.", "glovesSlayer", 205, 127, 50, 200) {
                    EquipSlot = "Hands",  EquipTier = 1, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMelee", EquipReq = new("Skill", 42, "Slayer")
                });
                
                itemsToAdd.Add(new Item("Bug lantern", "A lantern to aid attacking Harpie bugs.", "lanternBug", Color.Goldenrod, 130) {
                    EquipSlot = "Offhand", EquipReq = new("Skill", 33, "Slayer"), UseString = "Light", UseString2 = "lanternBugLit", ConsumedOnUse = false
                });

                itemsToAdd.Add(new Item("Bug lantern (lit)", "A lantern to aid attacking Harpie bugs.", "lanternBugLit", Color.Yellow, 130) {
                    EquipSlot = "Offhand", EquipReq = new("Skill", 33, "Slayer"), UseString = "Extinguish", UseString2 = "lanternBug", ConsumedOnUse = false
                });

                itemsToAdd.Add(new Item("Insulated boots", "They're heavily insulated wellies.", "bootsInsulated", Color.DimGray, 200) { EquipSlot = "Feet", EquipReq = new("Skill", 37, "Slayer") });
                itemsToAdd.Add(new Item("Witchwood icon", "A stick on a string... pure style.", "witchwood", Color.SaddleBrown, 900) { EquipSlot = "Amulet", EquipReq = new("Skill", 35, "Slayer"), MiscString = "PrayerBoost", EquipTier = 1 });
                itemsToAdd.Add(new Item("Slayer bell", "Don't make anyone jump when you ring this!", "bellSlayer", Color.Goldenrod, 900) { UseString = "Bell" });

                itemsToAdd.Add(new Item("Boots of stone", "A pair of heat resistant boots with rocky soles.", "bootsStone", Color.DimGray, 200) {
                    EquipSlot = "Feet", EquipReq = new("Skill", 44, "Slayer")
                });

                itemsToAdd.Add(new Item("Reinforced goggles", "A very sturdy-feeling pair of slayer goggles.", "gogglesReinforced", Color.Crimson, 100) { EquipSlot = "Head" });
                



            }


            // Enemy Remains - Bones, Ashes
            {
                itemsToAdd.Add(new Item("Bones", "The remains of some creature or person.", "bonesRegular", 255, 255, 255, 20) { UseString = "Bones", UseInt = 5 });
                itemsToAdd.Add(new Item("Big bones", "The remains of some huge creature or person.", "bonesBig", 255, 255, 255, 100) { UseString = "Bones", UseInt = 15 });
                itemsToAdd.Add(new Item("Long bone", "A Construction bone.", "boneLong", 255, 255, 255, 100, trade: false) { UseString = "Bones", UseInt = 15 });
                itemsToAdd.Add(new Item("Curved bone", "A curved Construction bone.", "boneCurved", 255, 255, 255, 100, trade: false) { UseString = "Bones", UseInt = 15 });
            
                itemsToAdd.Add(new Item("Fiendish ashes", "A heap of ashes.", "ashesFiendish", 122, 104, 127, 1) { UseString = "Ashes", UseInt = 10 });
                itemsToAdd.Add(new Item("Vile ashes", "A heap of ashes.", "ashesVile", 122, 104, 127, 1) { UseString = "Ashes", UseInt = 25 });
            }

            itemsToAdd.Add(new Item("Fish spirit", "When you catch a fish, this is consumed and you will receive an extra fish.", "spiritFish", Color.Turquoise, 20, true) { MiscString = "Spirit", UseString2 = "fish" });
            itemsToAdd.Add(new Item("Herb spirit", "When you brew a potion, this is consumed and your potion will have an extra dose.", "spiritHerb", Color.Lime, 20, true) { MiscString = "Spirit", UseString2 = "herb" });
            

            itemsToAdd.Add(new Item("Empty bucket", "An empty bucket. Could probably hold something.", "bucketEmpty", 111, 66, 33, 2)); 
            itemsToAdd.Add(new Item("Bucket of compost", "Good for plants, helps them grow.", "bucketCompost", 111, 66, 33, 2) { UseString = "Compost", UseInt = 1, ItemReturned = "bucketEmpty" });
            itemsToAdd.Add(new Item("Empty jug", "An empty jug. Could probably hold something.", "jugEmpty", 200, 200, 200, 1));
            


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
            
            
            itemsToAdd.Add(new Item("Attack potion", "Temporarily boosts your Attack level by 5.", "potionAttack", 0, 255, 255, 5) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Attack", 5) } });
            itemsToAdd.Add(new Item("Strength potion", "Temporarily boosts your Strength level by 5.", "potionStrength", Color.Yellow, 5) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Strength", 5) } });
            itemsToAdd.Add(new Item("Magic potion", "Temporarily boosts your Magic level by 5.", "potionMagic", Color.CadetBlue, 80) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Magic", 5) } });
            itemsToAdd.Add(new Item("Defense potion", "Temporarily boosts your Defense level by 5.", "potionDefense", Color.Lime, 50) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Defense", 5) } });
            itemsToAdd.Add(new Item("Combat potion", "Temporarily boosts your Attack and Strength levels by 5 each.", "potionCombat", Color.SpringGreen, 70) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Attack", 5), new("Strength", 5) } });
            itemsToAdd.Add(new Item("Cooking potion", "Temporarily boosts your Cooking level by 5.", "potionCooking", Color.Orange, 50) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Cooking", 5) } });
            itemsToAdd.Add(new Item("Ranging potion", "Temporarily boosts your Ranged level by 5.", "potionRanging", Color.Cyan, 90) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Ranged", 5) } });
            itemsToAdd.Add(new Item("Energy potion", "Energizes you to receive up to 5% additional experience from all actions.", "potionEnergy", Color.DeepPink.GetDark(), 50) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Experience", 5) } });
            itemsToAdd.Add(new Item("Restore potion", "Restores reduced stats by up to 5 levels per sip.", "potionRestore", Color.Salmon, 30) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Restore", 5) } });
            itemsToAdd.Add(new Item("Antipoison", "Cures poison and provides immunity to poison for two minutes.", "potionAntipoison", Color.Lime, 90) { UsesCharges = true, UseString = "Potion", UseInt4 = 3, ItemReturned = "vialEmpty", Potion = new() { new("Antipoison", 2) } });
            

            itemsToAdd.Add(new Item("Al Kharid flyer", "The money off voucher has expired.", "flyerAli", Color.Khaki, 1) { UseString = "SecondExamine", MiscString = "'Come to the Al Kharid Market place! High quality produce at low, low prices! Show this flyer to a merchant for money off your next purchase, courtesy of Ali Morrisane!'", ConsumedOnUse = false});

            itemsToAdd.Add(new Item("Goblin champion scroll", "It's a challenge from the Goblin Champion!", "scrollChampionGoblin", Color.ForestGreen, 1, trade: false));
            itemsToAdd.Add(new Item("Lesser demon champion scroll", "It's a challenge from the Lesser Demon Champion!", "scrollChampionLesserDemon", Color.Crimson, 1, trade: false));
            itemsToAdd.Add(new Item("Imp champion scroll", "It's a challenge from the Imp Champion!", "scrollChampionImp", Color.Crimson.GetBrighter(), 1, trade: false));
            itemsToAdd.Add(new Item("Zombie champion scroll", "It's a challenge from the Zombie Champion!", "scrollChampionZombie", Color.Teal, 1, trade: false));
            itemsToAdd.Add(new Item("Skeleton champion scroll", "It's a challenge from the Skeleton Champion!", "scrollChampionSkeleton", Color.White, 1, trade: false));

            
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
