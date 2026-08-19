namespace ZeroPlayersOnline.DataTypes {
    public class DialogueChoice {
        public string Text = "";
        public int LeadsToStage = 0;

        public string RequiredQuest = "";
        public int RequiredQuestStage = 0;


        public DialogueChoice(string t, int stage, string reqQuest = "", int reqQuestStage = 0) {
            Text = t;
            LeadsToStage = stage;

            RequiredQuest = reqQuest;
            RequiredQuestStage = reqQuestStage;
        }
    }
}
