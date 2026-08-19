namespace ZeroPlayersOnline.DataTypes {
    public class DialogueStage {
        public string Text = "";

        public string SetsQuest = "";
        public int SetsQuestStageTo = 0;

        public List<DialogueChoice> Choices = new();

        public DialogueStage(string t, List<DialogueChoice> choices, string quest = "", int questStage = 0) {
            Text = t;
            Choices = choices;

            SetsQuest = quest;
            SetsQuestStageTo = questStage;
        }
    }
}
