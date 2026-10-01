namespace ZeroPlayersOnline.DataTypes {
    public class TextReq {
        public string Text = "";
        public List<Requirement>? Reqs = null;

        public TextReq(string text, List<Requirement>? reqs = null) {
            Text = text;
            Reqs = reqs;
        }

        public bool CheckReq() {
            if (Reqs != null) {
                foreach (var kv in Reqs) {
                    if (!kv.CheckRequirement(GameLoop.ZPO.player, false, true)) {
                        return false;
                    }
                } 
            }
            return true;
        }
    }
}
