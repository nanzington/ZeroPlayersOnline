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
            toAdd.Add(new ClueStep("T_EmoteBank", "Tutorial", "Emote", "TI_Bank", "Cry in the bank. Equip a bronze helm, leather chaps, and a pine shortbow.", "bronzeHelm", "leatherChaps", "pineShortbow"));
            toAdd.Add(new ClueStep("T_EmoteTemple", "Tutorial", "Emote", "TI_Temple", "Yawn in the temple. Equip a leather coif, bronze platebody, and bronze dagger.", "leatherCowl", "bronzePlatebody", "bronzeDagger"));
            toAdd.Add(new ClueStep("T_AnagramCombatTutor", "Tutorial", "Anagram", "TI_Cavern", "The anagram reveals who to speak to next: TOMCAT TO RUB", "tutorCombat"));
            toAdd.Add(new ClueStep("T_AnagramRunecraftTutor", "Tutorial", "Anagram", "TI_AirAltar", "The anagram reveals who to speak to next: UNFORGET RUIN TRACT", "tutorRunecrafting"));


            for (int i = 0; i < toAdd.Count; i++) {
                clueLib.TryAdd(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
