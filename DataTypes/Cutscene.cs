namespace ZeroPlayersOnline.DataTypes {
    public class Cutscene {
        public string ID = "";
        public string DisplayTitle = "";

        public List<CutsceneScene> Scenes = new();

        public List<RunAction> Actions = new();

        public List<string> ItemsGiven = new();

        public List<Requirement> RequirementsToStart = new();

        public Cutscene(string id, string title, List<CutsceneScene> scenes, List<RunAction>? actions = null, List<string>? items = null, List<Requirement>? reqs = null) {
            ID = id;
            DisplayTitle = title;
            Scenes = scenes;

            if (actions != null) {
                Actions = actions;
            }

            if (items != null) {
                ItemsGiven = items;
            }

            if (reqs != null) {
                RequirementsToStart = reqs;
            }
        }
    }
}
