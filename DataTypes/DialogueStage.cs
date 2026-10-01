namespace ZeroPlayersOnline.DataTypes {
    public class DialogueStage {
        public List<TextReq> Text = new();
        //public string Text = "";
        public string AltSpeaker = "";

        public string SetsQuest = "";
        public int SetsQuestStageTo = 0;

        public List<DialogueChoice> Choices = new();

        public List<string> ItemsGiven = new();

        public List<RunAction> Actions = new();
        

        public DialogueStage(string t, List<DialogueChoice> choices, string quest = "", int questStage = 0, List<string>? items = null, List<RunAction>? acts = null, string altSpeaker = "") {
            Text = new() { new(t) };
            Choices = choices;
            AltSpeaker = altSpeaker;

            SetsQuest = quest;
            SetsQuestStageTo = questStage;

            if (items != null)
                ItemsGiven = items;
            if (acts != null)
                Actions = acts;
        } 

        public DialogueStage(List<TextReq> texts, List<DialogueChoice> choices, string quest = "", int questStage = 0, List<string>? items = null, List<RunAction>? acts = null, string altSpeaker = "") {
            Text = texts;
            Choices = choices;
            AltSpeaker = altSpeaker;

            SetsQuest = quest;
            SetsQuestStageTo = questStage;

            if (items != null)
                ItemsGiven = items;
            if (acts != null)
                Actions = acts;
        } 
    }
}
