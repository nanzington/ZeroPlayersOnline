namespace ZeroPlayersOnline.DataTypes {
    public class CompendiumResult {
        public string Display = "";
        public string Category = "";
        public string SubCategory = "";
        public string ViewID = "";
        public string ViewID2 = "";
        public int ViewIndex = 0;
        public int ViewIndex2 = 0;

        public CompendiumResult(string disp, string cat, string subcat, string view, string view2, int index, int index2 = 0) {
            Display = disp;
            Category = cat;
            SubCategory = subcat;
            ViewID = view;
            ViewID2 = view2;
            ViewIndex = index;
            ViewIndex2 = index2;
        }
    }
}
