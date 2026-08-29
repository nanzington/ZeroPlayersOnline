namespace ZeroPlayersOnline.DataTypes {
    public class QuestStage {
        public string Description = "";
        public int LeadsToStage = 0;

        public string ProgressType = "";
        public string MiscString = "";
        public int MiscInt = 0;


        public QuestStage(string desc, int toStage, string prog = "", string misc = "", int num = 0) {
            Description = desc;
            LeadsToStage = toStage;

            ProgressType = prog;
            MiscString = misc;
            MiscInt = num;
        } 
    }
}
