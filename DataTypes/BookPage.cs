namespace ZeroPlayersOnline.DataTypes {
    public class BookPage {
        public string Name = ""; // Used to build table of contents

        public string Text = ""; // 30ish characters wide multiline
         
        public List<Requirement> Requirements = new(); // Requirements to do the action
        public List<RunAction> Actions = new();

        public BookPage(string name, string text, List<RunAction>? acts = null, List<Requirement>? reqs = null) {
            Name = name;
            Text = text;

            if (reqs != null) {
                Requirements = reqs;
            }

            if (acts != null) {
                Actions = acts;
            }
        }

        public void Reached() {
            foreach (var req in Requirements) {
                if (!req.CheckRequirement(GameLoop.ZPO.player, false, true)) {
                    return;
                }
            }

            foreach (var act in Actions) {
                act.Execute();
            }
        }
    }
}
