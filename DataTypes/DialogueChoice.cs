namespace ZeroPlayersOnline.DataTypes {
    public class DialogueChoice {
        public string Text = "";
        public int LeadsToStage = 0;
         
        public Requirement? ClickReq = null;
        public bool ShowAnyways = false;

        public string TeleportTo = "";
        public bool SetSpawnToo = false;


        public DialogueChoice(string t, int stage, Requirement? req = null, bool showAnyways = false, string tele = "", bool spawn = false) {
            Text = t;
            LeadsToStage = stage;
             
            TeleportTo = tele;
            SetSpawnToo = spawn;

            ClickReq = req;
            ShowAnyways = showAnyways; 
        }

        public bool CanClick() {
            if (ClickReq != null) {
                return ClickReq.CheckRequirement(GameLoop.ZPO.player);
            }

            return true;
        }
    }
}
