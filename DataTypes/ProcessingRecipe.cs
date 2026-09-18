namespace ZeroPlayersOnline.DataTypes {
    public class ProcessingRecipe { 
        public string InputID = "";
        public string SecondaryIn = "";
        public string OutputID = "";
        public string SecondaryOut = "";
        public string TertiaryIn = ""; // Essentially only so that talismans can be consumed when making combination runes

        public string SkillUsed = "";
        public int SkillLevel = 0;
        public int SkillEXP = 0;

        public string SoundPlayed = "";
        public bool HighSkillExtraOutputs = false;

        public ProcessingRecipe(string i, string o, string s = "", int l = 0, int exp = 0, string sound = "", bool extra = false, string secondaryIn = "", string secondaryOut = "", string tertiaryIn = "") {
            InputID = i;
            OutputID = o;
            SkillUsed = s;
            SkillLevel = l;
            SkillEXP = exp;

            SoundPlayed = sound;
            HighSkillExtraOutputs = extra;

            SecondaryIn = secondaryIn;
            SecondaryOut = secondaryOut;

            TertiaryIn = tertiaryIn;
        }
    }
}
