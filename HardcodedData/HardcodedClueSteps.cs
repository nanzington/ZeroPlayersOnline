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
            toAdd.Add(new ClueStep("B_EmoteBobs", "Beginner", "Emote", "MIST_LumbridgeBobsAxes", "Clap at Bob's Brilliant Axes. Equip a bronze hatchet and leather boots.", "Clap", "hatchetBronze", "bootsLeather"));
            toAdd.Add(new ClueStep("B_AnagramSedridor", "Beginner", "Anagram", "MIST_WizardTowerBasement", "The anagram reveals who to speak to next: CHAR GAME DISORDER", "mistWizSedridor"));
            toAdd.Add(new ClueStep("B_AnagramRanael", "Beginner", "Anagram", "DES_AlKharidRanael", "The anagram reveals who to speak to next: AN EARL", "desAlKharidRanael"));
            toAdd.Add(new ClueStep("B_MapWizardTowerIsland", "Beginner", "Map", "MIST_WizardTowerIsland", "Seems like you have to find the location that matches the description of the clue.", ""));
            toAdd.Add(new ClueStep("B_MapDraynorOutskirtsSouth", "Beginner", "Map", "MIST_DraynorOutskirtsSouth", "Seems like you have to find the location that matches the description of the clue.", ""));

            // Easy Steps
            toAdd.Add(new ClueStep("E_DigLumbridgeBailey", "Easy", "Dig", "MIST_LumbridgeCastleBailey", "Dig where only the skilled, the wealthy, or the brave can choose not to visit again."));
            toAdd.Add(new ClueStep("E_GatherLumbridgeUrhney", "Easy", "Gather", "MIST_LumbridgeSwampUrhney", "Search a bookcase in the Lumbridge Swamp.", "clueBookcase"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeShed", "Easy", "Gather", "MIST_LumbridgeSwampShed", "Search a crate in the Lumbridge Swamp.", "clueCrates")); 
            toAdd.Add(new ClueStep("E_GatherLumbridgeFred", "Easy", "Gather", "MIST_LumbridgeFredsFarm", "Search the chest in Fred the Farmer's bedroom.", "clueChest"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeGoblins", "Easy", "Gather", "MIST_LumbridgeAcrossLum", "Search the boxes in the goblin house near Lumbridge.", "clueBoxes"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeDuke", "Easy", "Gather", "MIST_LumbridgeCastleFloor2", "Search the chest in the Duke of Lumbridge's bedroom.", "clueChest"));
            toAdd.Add(new ClueStep("E_GatherLumbridgeTower", "Easy", "Gather", "MIST_LumbridgeCastleGatehouse2", "Search the crates in the tower of Lumbridge castle.", "clueCrates"));
            toAdd.Add(new ClueStep("E_GatherAlKharidHouse", "Easy", "Gather", "DES_AlKharidHouse", "Search the crates in a home in Al Kharid.", "clueCrates"));
            toAdd.Add(new ClueStep("E_GatherAlKharidTent", "Easy", "Gather", "DES_AlKharidTent", "Search the boxes in a tent in Al Kharid.", "clueBoxes"));
            toAdd.Add(new ClueStep("E_CrypticEllis", "Easy", "Speak", "DES_AlKharidTanner", "Speak to Ellis in Al Kharid.", "desAlKharidEllis"));
            

            for (int i = 0; i < toAdd.Count; i++) {
                clueLib.TryAdd(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
