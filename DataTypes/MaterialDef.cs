namespace ZeroPlayersOnline.DataTypes {
    public class MaterialDef {
        public string Name = "";
        public int R = 255;
        public int G = 255;
        public int B = 255;
        public int A = 255;

        public int Tier = 1;
        public int Level = 1;

        public int CostMultiplier = 1;
        public string Descriptor = "";

        public MaterialDef(string name, int r, int g, int b, int a, int tier, int lv, int cost, string desc) {
            Name = name;
            R = r;
            G = g;
            B = b;
            A = a;
            Tier = tier;
            Level = lv;

            CostMultiplier = cost;
            Descriptor = desc;
        } 
    }
}
