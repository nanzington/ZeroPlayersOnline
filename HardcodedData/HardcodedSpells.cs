using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedSpells {
        public static void InitSpells(Dictionary<string, Spell> SpellLib) {
            List<Spell> toAdd = new();

            // // Standard Spellbook

            // Combat Spells
            toAdd.Add(new("strikeWind", "Wind Strike", "Standard", 1, 6, [ "runeAir,1", "runeMind,1" ], "A simple air spell.", "Combat", 1, "Air"));
            toAdd.Add(new("strikeWater", "Water Strike", "Standard", 5, 8, [ "runeAir,1", "runeWater,1", "runeMind,1" ], "A simple water spell.", "Combat", 1, "Water"));
            toAdd.Add(new("strikeEarth", "Earth Strike", "Standard", 9, 10, [ "runeAir,1", "runeEarth,2", "runeMind,1" ], "A simple earth spell.", "Combat", 1, "Earth"));
            toAdd.Add(new("strikeFire", "Fire Strike", "Standard", 13, 12, [ "runeAir,2", "runeFire,3", "runeMind,1" ], "A simple fire spell.", "Combat", 1, "Fire"));
            
            toAdd.Add(new("boltWind", "Wind Bolt", "Standard", 17, 14, [ "runeAir,2", "runeChaos,1" ], "A basic air spell.", "Combat", 2, "Air"));
            toAdd.Add(new("boltWater", "Water Bolt", "Standard", 23, 17, [ "runeAir,2", "runeWater,2", "runeChaos,1" ], "A basic water spell.", "Combat", 2, "Water"));
            toAdd.Add(new("boltEarth", "Earth Bolt", "Standard", 29, 20, [ "runeAir,2", "runeEarth,3", "runeChaos,1" ], "A basic earth spell.", "Combat", 2, "Earth"));
            toAdd.Add(new("boltFire", "Fire Bolt", "Standard", 35, 23, [ "runeAir,3", "runeFire,4", "runeChaos,1" ], "A basic fire spell.", "Combat", 2, "Fire"));
             
            toAdd.Add(new("crumbleUndead", "Crumble Undead", "Standard", 39, 25, [ "runeAir,2", "runeEarth,2", "runeChaos,1" ], "A powerful spell against undead.", "Combat", 3, "Undead")); // TODO: Make sure this can only hit undeads
            
            toAdd.Add(new("blastWind", "Wind Blast", "Standard", 41, 26, [ "runeAir,3", "runeDeath,1" ], "A standard air spell.", "Combat", 3, "Air"));
            toAdd.Add(new("blastWater", "Water Blast", "Standard", 47, 29, [ "runeAir,3", "runeWater,3", "runeDeath,1" ], "A standard water spell.", "Combat", 3, "Water"));
            toAdd.Add(new("blastEarth", "Earth Blast", "Standard", 53, 32, [ "runeAir,3", "runeEarth,4", "runeDeath,1" ], "A standard earth spell.", "Combat", 3, "Earth"));
            toAdd.Add(new("blastFire", "Fire Blast", "Standard", 59, 35, [ "runeAir,4", "runeFire,5", "runeDeath,1" ], "A standard fire spell.", "Combat", 3, "Fire"));


            // Teleport Spells
            toAdd.Add(new("teleLumbyHome", "Lumbridge Home Teleport", "Standard", 0, 0, [ ], "Home Teleport to Lumbridge. 30 minute cooldown.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 1800000));
            toAdd.Add(new("teleTaverly", "Taverly Teleport", "Standard", 19, 38, [ "runeAir,3", "runeFire,1", "runeLaw,1" ], "Teleport to Taverly.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 250)); // TODO: Change this to somewhere in Taverly
            toAdd.Add(new("teleVarrock", "Varrock Teleport", "Standard", 25, 35, [ "runeAir,3", "runeFire,1", "runeLaw,1" ], "Teleport to Varrock square.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 250)); // TODO: Change this to varrock square
            toAdd.Add(new("teleLumbridge", "Lumbridge Teleport", "Standard", 31, 41, [ "runeAir,3", "runeEarth,1", "runeLaw,1" ], "Teleport to Lumbridge Castle.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 250));
            toAdd.Add(new("teleFalador", "Falador Teleport", "Standard", 37, 48, [ "runeAir,3", "runeWater,1", "runeLaw,1" ], "Teleport to Lumbridge Castle.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 250)); // TODO: Change this to falador square
            toAdd.Add(new("teleHome", "Teleport to House", "Standard", 40, 30, [ "runeAir,1", "runeEarth,1", "runeLaw,1" ], "Teleport to your home.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 250)); // TODO: Change this to teleport to portal in house
            toAdd.Add(new("teleCamelot", "Camelot Teleport", "Standard", 45, 56, [ "runeAir,5", "runeLaw,1" ], "Teleport to your home.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 250)); // TODO: Change this to teleport to camelot castle gates
            toAdd.Add(new("teleArdougne", "Ardougne Teleport", "Standard", 51, 61, [ "runeWater,2", "runeLaw,2" ], "Teleport to Ardougne market.", "Tele", misc: "MIST_LumbridgeCastleBailey", cd: 250)); // TODO: Change this to teleport to Ardougne, also make it require Plague City
            
            // Utility Spells
            toAdd.Add(new("utilBonesBananas", "Bones to Bananas", "Standard", 15, 25, [ "runeEarth,2", "runeWater,2", "runeNature,1" ], "Converts all normal bones in your inventory into bananas.", "Utility")); 
            toAdd.Add(new("utilAlchemyLow", "Low Level Alchemy", "Standard", 21, 31, [ "runeFire,3", "runeNature,1" ], "Gives coins equal to 35% of the value of the item the spell was cast on.", "Utility")); 
            toAdd.Add(new("utilSuperheat", "Superheat Item", "Standard", 21, 31, [ "runeFire,4", "runeNature,1" ], "Smelts the first ore mix in the inventory into the equivalent bar, as if using a furnace.", "Utility")); 
            toAdd.Add(new("utilAlchemyHigh", "High Level Alchemy", "Standard", 55, 65, [ "runeFire,5", "runeNature,1" ], "Gives coins equal to 70%% of the value of the item the spell was cast on.", "Utility")); 
            toAdd.Add(new("utilBonesPeaches", "Bones to Peaches", "Standard", 60, 36, [ "runeEarth,2", "runeWater,4", "runeNature,1" ], "Converts all normal bones in your inventory into peaches.", "Utility", reqs: new() { new("Data", 1, "UnlockedBonesToPeaches", misc3: "equals", summ: "Must be unlocked at the Mage Training Arena.")})); 
            
            toAdd.Add(new("utilEnchant1", "Lvl 1 Enchant (Sapphire/Opal)", "Standard", 7, 18, [ "runeWater,1", "runeCosmic,1" ], "Enchants jewellery made from sapphire or opal.", "Utility"));
            toAdd.Add(new("utilEnchant2", "Lvl 2 Enchant (Emerald/Jade)", "Standard", 27, 37, [ "runeAir,3", "runeCosmic,1" ], "Enchants jewellery made from emerald or jade.", "Utility")); 
            toAdd.Add(new("utilEnchant3", "Lvl 3 Enchant (Ruby/Red Topaz)", "Standard", 49, 59, [ "runeFire,5", "runeCosmic,1" ], "Enchants jewellery made from ruby or red topaz.", "Utility")); 
            toAdd.Add(new("utilEnchant4", "Lvl 4 Enchant (Diamond)", "Standard", 57, 67, [ "runeEarth,10", "runeCosmic,1" ], "Enchants jewellery made from diamond.", "Utility")); 
            toAdd.Add(new("utilEnchant5", "Lvl 5 Enchant (Dragonstone)", "Standard", 68, 78, [ "runeEarth,15", "runeWater,15", "runeCosmic,1" ], "Enchants jewellery made from dragonstone.", "Utility")); 
            toAdd.Add(new("utilEnchant6", "Lvl 6 Enchant (Onyx)", "Standard", 87, 97, [ "runeEarth,20", "runeFire,20", "runeCosmic,1" ], "Enchants jewellery made from onyx.", "Utility")); 
            toAdd.Add(new("utilEnchant7", "Lvl 7 Enchant (Zenyte)", "Standard", 93, 110, [ "runeBlood,20", "runeCosmic,1", "runeSoul,20" ], "Enchants jewellery made from zenyte.", "Utility"));  
            
            toAdd.Add(new("utilTelegrab", "Telekinetic Grab", "Standard", 33, 43, [ "runeAir,1", "runeLaw,1" ], "Allows you to pick up otherwise inaccessible items.", "Utility"));  
            toAdd.Add(new("utilMonsterInspect", "Monster Inspect", "Standard", 42, 31, [ "runeBody,2", "runeMind,2" ], "Displays information about the monster the spell is cast upon.", "Utility"));  
            

            /* Can't implement these really until the Taverly and Edgeville dungeons are added
            toAdd.Add(new("utilOrbWater", "Charge Water Orb", "Standard", 56, 56, [ "runeWater,30", "runeCosmic,3" ], "Enchants an unpowered orb into a water orb when cast at the Obelisk of Water.")); // TODO: Make these only work if you're at the place where the obelisk is
            toAdd.Add(new("utilOrbEarth", "Charge Earth Orb", "Standard", 56, 56, [ "runeEarth,30", "runeCosmic,3" ], "Enchants an unpowered orb into an earth orb when cast at the Obelisk of Earth.")); // TODO: Make these only work if you're at the place where the obelisk is
            toAdd.Add(new("utilOrbFire", "Charge Fire Orb", "Standard", 56, 56, [ "runeFire,30", "runeCosmic,3" ], "Enchants an unpowered orb into a fire orb when cast at the Obelisk of Fire.")); // TODO: Make these only work if you're at the place where the obelisk is
            toAdd.Add(new("utilOrbAir", "Charge Air Orb", "Standard", 56, 56, [ "runeAir,30", "runeCosmic,3" ], "Enchants an unpowered orb into an air orb when cast at the Obelisk of Air.")); // TODO: Make these only work if you're at the place where the obelisk is
            */

            for (int i = 0; i < toAdd.Count; i++) { 
                SpellLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
