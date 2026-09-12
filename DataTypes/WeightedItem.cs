namespace ZeroPlayersOnline.DataTypes {
    public class WeightedItem : IWeighted {
        public string Item = "";
        public int Weight = 1;

        public string MiscString = "";
        public int MiscInt = 0;
        public int MiscInt2 = 0;

        int IWeighted.Weight { get => Weight; set => Weight = value; }

        public WeightedItem(string i, int w, string misc = "", int misc1 = 0, int misc2 = 0) {
            Item = i;
            Weight = w;

            MiscString = misc;
            MiscInt = misc1;
            MiscInt2 = misc2;
        }
    }
}
