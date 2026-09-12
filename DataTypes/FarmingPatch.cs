namespace ZeroPlayersOnline.DataTypes {
    public class FarmingPatch {
        public string ID = "";
        public string PatchType = "Allotment";

        public int TimeLeft = 0; 
        public string SeedPlanted = "";
        public int Compost = 0;

        public int RegrowTime = 0;
        public int RegrowTimeLeft = 0;

        public bool Regrowing = false;
        public int Regrown = 0;

        public FarmingPatch(string id, string patch) {
            ID = id;
            PatchType = patch;
        }

        public void ClearPatch() {
            TimeLeft = 0; 
            SeedPlanted = "";
            Regrowing = false;
            Regrown = 0;
            RegrowTimeLeft = 0;
            RegrowTime = 0;
        }
    }
}
