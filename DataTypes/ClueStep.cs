namespace ZeroPlayersOnline.DataTypes {
    public class ClueStep {
        public string ID = "";
        public string Difficulty = "";

        public string HintText = "";

        public string ClueType = "";
        public string SolveLoc = "";
        public string EmoteOrNpc = "";

        public string Equip1 = "";
        public string Equip2 = "";
        public string Equip3 = "";


        public ClueStep(string id, string diff, string cluetype, string loc, string hint, string emote = "", string eq1 = "", string eq2 = "", string eq3 = "") {
            ID = id;
            Difficulty = diff;
            ClueType = cluetype;
            SolveLoc = loc;
            HintText = hint;

            EmoteOrNpc = emote;
            Equip1 = eq1;
            Equip2 = eq2;
            Equip3 = eq3;
        }
    }
}
