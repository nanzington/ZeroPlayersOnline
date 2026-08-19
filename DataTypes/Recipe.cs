namespace ZeroPlayersOnline.DataTypes {
    public class Recipe { 
        public string FirstItem = "";
        public int FirstQty = 1;
        public string SecondItem = "";
        public int SecondQty = 1;

        public string OutputItem = "";
        public int OutputQty = 1;

        public string SkillUsed = "";
        public int SkillLevelReq = 1;
        public int ExpGranted = 0;

        public string SoundPlayed = "";

        public Recipe(string fI, string sI, string oI, int fQ = 1, int sQ = 1, int oQ = 1, string s = "", int lv = 1, int exp = 0, string sound = "") {
            FirstItem = fI;
            SecondItem = sI;
            OutputItem = oI;

            FirstQty = fQ;
            SecondQty = sQ;
            OutputQty = oQ;

            SkillUsed = s;
            SkillLevelReq = lv;
            ExpGranted = exp;

            SoundPlayed = sound;
        }
    }
}
