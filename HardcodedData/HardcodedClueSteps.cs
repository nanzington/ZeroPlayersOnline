using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedClueSteps {
        public static void InitClues(Dictionary<string, ClueStep> clueLib) {
            List<ClueStep> toAdd = new();

            // Tutorial Steps
            toAdd.Add(new ClueStep("T_SpeakWizard", "Tutorial", "Speak", "TI_WizardHut", "What do you think he's smoking in that pipe?", "tiWizardTerrova"));
            toAdd.Add(new ClueStep("T_SpeakFarmingTutor", "Tutorial", "Speak", "TI_Main", "How honest can the work really be with only three plots of land?", "tutorFarming"));
            toAdd.Add(new ClueStep("T_DigNewts", "Tutorial", "Dig", "TI_Newts", "Dig somewhere allegedly being 'supervised'."));
            toAdd.Add(new ClueStep("T_DigAltar", "Tutorial", "Dig", "TI_AirAltar", "Dig where the magic is made.")); 
            toAdd.Add(new ClueStep("T_EmoteBank", "Tutorial", "Emote", "TI_Bank", "Cry in the bank. Equip a bronze helm, leather chaps, and a pine shortbow.", "Cry", "helmBronze", "chapsLeather", "shortbowPine"));
            toAdd.Add(new ClueStep("T_EmoteTemple", "Tutorial", "Emote", "TI_Temple", "Yawn in the temple. Equip a leather coif, bronze platebody, and bronze dagger.", "Yawn", "coifLeather", "platebodyBronze", "daggerBronze"));
            toAdd.Add(new ClueStep("T_AnagramCombatTutor", "Tutorial", "Anagram", "TI_Cavern", "The anagram reveals who to speak to next: TOMCAT TO RUB", "tutorCombat"));
            toAdd.Add(new ClueStep("T_AnagramRunecraftTutor", "Tutorial", "Anagram", "TI_AirAltar", "The anagram reveals who to speak to next: UNFORGET RUIN TRACT", "tutorRunecrafting"));
            toAdd.Add(new ClueStep("T_GatherCrates", "Tutorial", "Gather", "TI_GeneralStore", "Am I allowed to rummage through these? I guess there's no employee around to stop me!", "clueCrates"));
            toAdd.Add(new ClueStep("T_GatherShrimp", "Tutorial", "Gather", "TI_Main", "Look for a really strange shrimp.", "fishNetSmall"));

            // Beginner Steps 
            toAdd.Add(new ClueStep("B_SpeakHans", "Beginner", "Speak", "MIST_LumbridgeCastleBailey", "Always walking around the castle grounds and somehow knows everyones age.", "mistLumHans"));
            toAdd.Add(new ClueStep("B_SpeakCook", "Beginner", "Speak", "MIST_LumbridgeCastleKitchen", "In the place Duke Horacio calls home, talk to a man with a hat dropped by goblins.", "mistLumCook"));
            toAdd.Add(new ClueStep("B_SpeakHunding", "Beginner", "Speak", "MIST_BarbarianLookout", "In a village of barbarians, I am the one who guards the village from up high.", "mistBarbHunding"));
            toAdd.Add(new ClueStep("B_EmoteBobs", "Beginner", "Emote", "MIST_LumbridgeBobsAxes", "Clap at Bob's Brilliant Axes. Equip a bronze hatchet and leather boots.", "Clap", "hatchetBronze", "bootsLeather"));
            toAdd.Add(new ClueStep("B_EmoteAKMine", "Beginner", "Emote", "DES_AlKharidMine", "Panic at Al Kharid Mine.", "Panic"));
            toAdd.Add(new ClueStep("B_AnagramSedridor", "Beginner", "Anagram", "MIST_WizardTowerBasement", "The anagram reveals who to speak to next: CHAR GAME DISORDER", "mistWizSedridor"));
            toAdd.Add(new ClueStep("B_AnagramRanael", "Beginner", "Anagram", "DES_AlKharidRanael", "The anagram reveals who to speak to next: AN EARL", "desAlKharidRanael"));
            toAdd.Add(new ClueStep("B_MapWizardTowerIsland", "Beginner", "Map", "MIST_WizardTowerIsland", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("B_MapDraynorOutskirtsSouth", "Beginner", "Map", "MIST_DraynorOutskirtsSouth", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("B_MapVarrockMineWest", "Beginner", "Map", "MIST_VarrockMineWest", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("B_MapVarrockMineEast", "Beginner", "Map", "MIST_VarrockMineEast", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("B_HotColdCows", "Beginner", "HotCold", "MIST_LumbridgeFredsFarmCows", "There is a device attached to the clue that tells you how close you are to the treasure...", ""));
            toAdd.Add(new ClueStep("B_HotColdAlKharidMine", "Beginner", "HotCold", "DES_AlKharidMineOutside", "There is a device attached to the clue that tells you how close you are to the treasure...", ""));

            // Easy Steps
            toAdd.Add(new ClueStep("E_DigLumbridgeBailey", "Easy", "Dig", "MIST_LumbridgeCastleBailey", "Dig where only the skilled, the wealthy, or the brave can choose not to visit again."));
            
            toAdd.Add(new ClueStep("E_GatherLumbridgeUrhney", "Easy", "Gather", "MIST_LumbridgeSwampUrhney", "Search a bookcase in the Lumbridge Swamp.", "clueBookcase"));
            toAdd.Add(new ClueStep("E_GatherWizardTower", "Easy", "Gather", "MIST_WizardTower", "Search a bookcase in the Wizards' Tower.", "bookshelfWizard"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeShed", "Easy", "Gather", "MIST_LumbridgeSwampShed", "Search a crate in the Lumbridge Swamp.", "clueCrates")); 
            toAdd.Add(new ClueStep("E_GatherLumbridgeFred", "Easy", "Gather", "MIST_LumbridgeFredsFarm", "Search the chest in Fred the Farmer's bedroom.", "clueChest"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeGoblins", "Easy", "Gather", "MIST_LumbridgeAcrossLum", "Search the boxes in the goblin house near Lumbridge.", "clueBoxes"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeDuke", "Easy", "Gather", "MIST_LumbridgeCastleFloor2", "Search the chest in the Duke of Lumbridge's bedroom.", "clueChest"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeTower", "Easy", "Gather", "MIST_LumbridgeCastleGatehouse2", "Search the crates in the tower of Lumbridge castle.", "clueCrates"));
            toAdd.Add(new ClueStep("E_GatherAlKharidHouse", "Easy", "Gather", "DES_AlKharidHouse", "Search the crates in a home in Al Kharid.", "clueCrates"));
            toAdd.Add(new ClueStep("E_GatherAlKharidTent", "Easy", "Gather", "DES_AlKharidTent", "Search the boxes in a tent in Al Kharid.", "clueBoxes"));
            toAdd.Add(new ClueStep("E_GatherBarbVillage", "Easy", "Gather", "MIST_BarbarianVillage", "Search the chest in Barbarian Village.", "clueChest"));
            toAdd.Add(new ClueStep("E_GatherBarbVillagePeksa", "Easy", "Gather", "MIST_BarbarianPeksa", "Search the creates in the Barbarian Village helmet shop.", "clueCrates"));
            
            toAdd.Add(new ClueStep("E_SpeakEllis", "Easy", "Speak", "DES_AlKharidTanner", "Speak to Ellis in Al Kharid.", "desAlKharidEllis"));
            toAdd.Add(new ClueStep("E_SpeakHans", "Easy", "Speak", "MIST_LumbridgeCastleBailey", "Speak to Hans to solve the clue.", "mistLumHans"));
            toAdd.Add(new ClueStep("E_SpeakAliLeaflet", "Easy", "Speak", "MIST_VarrockCrossroadsSouth", "Talk to Ali the Leaflet Dropper north of the Al Kharid mine.", "mistVarAliLeaflet"));
            toAdd.Add(new ClueStep("E_SpeakDoomsayer", "Easy", "Speak", "MIST_LumbridgeNorth", "Talk to the Doomsayer", "mistLumDoomsayer"));
            toAdd.Add(new ClueStep("E_SpeakZeke", "Easy", "Speak", "DES_AlKharidZeke", "Talk to Zeke in Al Kharid.", "desAlKharidZeke"));
            
            toAdd.Add(new ClueStep("E_EmoteWizard", "Easy", "Emote", "MIST_WizardTowerBridge", "Clap on the causeway to the Wizards' Tower. Equip an iron helmet, emerald ring, and a white apron.", "Clap", "helmIron", "ringEmerald", "whiteApron"));
            toAdd.Add(new ClueStep("E_EmoteShed", "Easy", "Emote", "MIST_LumbridgeSwampShed", "Dance in the shed in Lumbridge Swamp. Equip a bronze dagger, iron helmet, and gold ring.", "Dance", "helmIron", "ringGold", "daggerBronze"));
            toAdd.Add(new ClueStep("E_EmoteAKMine", "Easy", "Emote", "DES_AlKharidMine", "Headbang in the mine north of Al Kharid. Equip a desert shirt, leather gloves, and leather boots.", "Dance", "desertShirt", "vambracesLeather", "bootsLeather"));
            // toAdd.Add(new ClueStep("E_EmoteLumWheat", "Easy", "Emote", "MIST_LumbridgeFredsFarm", "Think in the middle of the wheat field by the Lumbridge mill. Equip a blue gnome robetop, a turquoise gnome robe bottom, and an oak shortbow.", "Think", "gnomeTopBlue", "gnomeBottomTurquoise", "shortbowOak"));
            
            toAdd.Add(new ClueStep("E_MapAKMine", "Easy", "Map", "DES_AlKharidMine", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("E_MapWizardTowerIsland", "Easy", "Map", "MIST_WizardTowerIsland", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("E_MapVarrockMineWest", "Easy", "Map", "MIST_VarrockMineWest", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("E_MapVarrockMineEast", "Easy", "Map", "MIST_VarrockMineEast", "Seems like you have to find the location that matches the description of the clue.", ""));
            

            // Medium Steps
            toAdd.Add(new ClueStep("M_AnagramAereck", "Medium", "Anagram", "MIST_LumbridgeChurch", "The anagram reveals who to speak to next: AREA CHEF TREK", "mistLumAereck"));
            toAdd.Add(new ClueStep("M_AnagramCook", "Medium", "Anagram", "MIST_LumbridgeCastleKitchen", "The anagram reveals who to speak to next: OK CO", "mistLumCook"));
            toAdd.Add(new ClueStep("M_AnagramKarim", "Medium", "Anagram", "DES_AlKharidKebab", "The anagram reveals who to speak to next: R AK MI", "desAlKharidKarim"));
            
            toAdd.Add(new ClueStep("M_CipherTraiborn", "Medium", "Anagram", "MIST_LumbridgeCastleBailey", "The cipher reveals who to speak to next: CHEEHBTKSX STSNQ", "mistLumDifficultyTutor"));
            toAdd.Add(new ClueStep("M_CipherTraiborn", "Medium", "Anagram", "MIST_WizardTower2F", "The cipher reveals who to speak to next: XJABSE USBJCPSO", "mistWizTraiborn"));
            
            toAdd.Add(new ClueStep("M_HotColdSwamp", "Medium", "HotCold", "MIST_LumbridgeSwamp20", "There is a device attached to the clue that tells you how close you are to the treasure...", ""));
            toAdd.Add(new ClueStep("M_HotColdSwamp2", "Medium", "HotCold", "MIST_LumbridgeSwamp4", "There is a device attached to the clue that tells you how close you are to the treasure...", ""));
            toAdd.Add(new ClueStep("M_HotColdHAM", "Medium", "HotCold", "MIST_LumbridgeTowardsDraynor", "There is a device attached to the clue that tells you how close you are to the treasure...", ""));
            toAdd.Add(new ClueStep("M_HotColdHAM", "Medium", "HotCold", "MIST_BetweenBarbarianDraynor", "There is a device attached to the clue that tells you how close you are to the treasure...", ""));
            
            toAdd.Add(new ClueStep("M_CrypticWizard", "Medium", "Gather", "MIST_WizardTowerBasement", "Probably filled with wizards socks.", ""));
            

            // Hard Steps
            toAdd.Add(new ClueStep("H_SpeakHeadChef", "Hard", "Speak", "MIST_VarrockGuildCooks", "In the city where merchants are said to have lived, talk to a man with a splendid cape but a hat dropped by goblins.", "mistVarHeadChef"));
            

            for (int i = 0; i < toAdd.Count; i++) {
                clueLib.TryAdd(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
