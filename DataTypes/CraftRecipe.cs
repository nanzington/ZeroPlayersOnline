namespace ZeroPlayersOnline.DataTypes {
    public class CraftRecipe {
        public string Station = "";
        public string Skill = "";
        public int Level = 1;
        public int ExpGranted = 0;

        public string NeededItem = "";
        public int NeededQty = 1;
        public string ExtraTool = "";

        public string OutputItem = "";
        public int OutputQty = 1;

        public CraftRecipe(string st, string sk, int lv, int exp, string inId, int inQty, string outId, int outQty = 1, string tool = "") {
            Station = st;
            Skill = sk;
            Level = lv;
            ExpGranted = exp;

            NeededItem = inId;
            NeededQty = inQty;

            OutputItem = outId;
            OutputQty = outQty;

            ExtraTool = tool;
        }
    }
}
