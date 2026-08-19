namespace ZeroPlayersOnline.DataTypes {
    public class WeightedItem : IWeighted {
        public string Item = "";
        public int Weight = 1;

        int IWeighted.Weight { get => Weight; set => Weight = value; }

        public WeightedItem(string i, int w) {
            Item = i;
            Weight = w;
        }
    }
}
