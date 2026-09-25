namespace ZeroPlayersOnline.DataTypes {
    public class CutsceneScene {
        public string Description = "";
        public List<string> DialogueLines = new();

        public CutsceneScene(string desc, List<string> lines) {
            Description = desc;
            DialogueLines = lines;
        }
    }
}
