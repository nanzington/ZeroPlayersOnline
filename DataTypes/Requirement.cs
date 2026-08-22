namespace ZeroPlayersOnline.DataTypes {
    public class Requirement {
        public string RequirementType = "";
        public int MiscInt = 0;
        public string MiscString = "";

        public Requirement(string ty, int misc1 = 0, string misc2 = "") {
            RequirementType = ty;
            MiscInt = misc1;
            MiscString = misc2;
        }

    }
}
