namespace ZeroPlayersOnline.DataTypes {
    public class CraftRecipe {
        public string Station = "";
        public string Skill = "";
        public int Level = 1;
        public int ExpGranted = 0;
          
        public List<string> NeededItems = new();

        public string ExtraTool = "";

        public string OutputItem = "";
        public int OutputQty = 1;

        public CraftRecipe(string st, string sk, int lv, int exp, List<string> items, string outId, int outQty = 1, string tool = "") {
            Station = st;
            Skill = sk;
            Level = lv;
            ExpGranted = exp;

            NeededItems = items;

            OutputItem = outId;
            OutputQty = outQty;

            ExtraTool = tool;
        }
    }
}
