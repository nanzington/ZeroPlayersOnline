namespace ZeroPlayersOnline.DataTypes {
    public class DialogueStage {
        public string Text = "";

        public string SetsQuest = "";
        public int SetsQuestStageTo = 0;

        public List<DialogueChoice> Choices = new();

        public List<string> ItemsGiven;

        public string ActionWhenChosen = "";

        public string DataID = "";
        public string DataHow = "";
        public int DataNum = 0;
        

        public DialogueStage(string t, List<DialogueChoice> choices, string quest = "", int questStage = 0, List<string> items = null, string action = "") {
            Text = t;
            Choices = choices;

            SetsQuest = quest;
            SetsQuestStageTo = questStage;

            ItemsGiven = items;
            ActionWhenChosen = action;
        } 
    }
}
