using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsClues {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();

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
            itemsToAdd.Add(new Item("Digsite teleport", "Teleports you to the Digsite.", "clueTeleportDigsite", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_Digsite" });
            itemsToAdd.Add(new Item("Piscatoris teleport", "Teleports you to Piscatoris.", "clueTeleportPiscatoris", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
            itemsToAdd.Add(new Item("Pest control teleport", "Teleports you to Pest control.", "clueTeleportPestControl", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
            itemsToAdd.Add(new Item("Tai bwo wannai teleport", "Teleports you to Tai bwo wannai.", "clueTeleportTaiBwoWannai", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
            itemsToAdd.Add(new Item("Lumberyard teleport", "Teleports you to the Lumberyard.", "clueTeleportLumberyard", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_VarrockLumberyard" });
            itemsToAdd.Add(new Item("Iorwerth camp teleport", "Teleports you to the Iorwerth Camp.", "clueTeleportIorwerthCamp", Color.Khaki, 5000, true) { UseString = "Teleport", UseString2 = "MIST_LumbridgeCastleBailey" }); // TODO: Fix all these once their places are implemented
            itemsToAdd.Add(new Item("Master scroll book", "I can store my teleport scrolls in this.", "clueMasterScrollBook", Color.Khaki, 50000, true) { UseString = "ViewInventory", ConsumedOnUse = false, ContainerSlots = 11, ContainableIDs = [ "clueTeleportNardah", "clueTeleportMosLeHarmless", "clueTeleportMortton", "clueTeleportFeldipHills", "clueTeleportLunar", "clueTeleportDigsite", "clueTeleportPiscatoris", "clueTeleportPestControl", "clueTeleportTaiBwoWannai", "clueTeleportLumberyard", "clueTeleportIorwerthCamp" ]}); 
            



            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
