namespace ZeroPlayersOnline.DataTypes {
    public class QuestReward {
        public string RewardType = "";
        public string MiscString = "";
        public int MiscInt = 0;

        public QuestReward(string ty, string misc, int num) {
            RewardType = ty;
            MiscString = misc;
            MiscInt = num;
        }

        public string GetSummary() {
            string build = "";

            if (RewardType == "Experience") {
                build = MiscInt + " " + MiscString + " experience";
            }

            if (RewardType == "Item") {
                build = (MiscInt > 1 ? MiscInt + "x " : "") + GameLoop.ZPO.ResolveItemName(MiscString);
            }

            return build;
        }
    }
}
