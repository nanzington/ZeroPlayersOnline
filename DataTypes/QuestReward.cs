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
    }
}
