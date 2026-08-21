namespace ZeroPlayersOnline.DataTypes {
    public class Prayer {
        public string Name = "";
        public string Book = "";
        public int Level = 0;
        public int ActiveCost = 0;

        public string SkillBuffed = "";
        public int MiscInt = 0;

        public Prayer(string name, string book, int lev, int cost, int misc = 0, string buffed = "") {
            Name = name;
            Book = book;
            Level = lev;
            ActiveCost = cost;
            MiscInt = misc;
            SkillBuffed = buffed;
        }
    }
}
