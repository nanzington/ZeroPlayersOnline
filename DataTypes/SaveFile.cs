using Newtonsoft.Json; 

namespace ZeroPlayersOnline.DataTypes {
    [JsonObject(MemberSerialization.OptOut)]
    [Serializable]
    public class SaveFile {
        public float MusicVolume = 0.05f;
        public float SfxVolume = 0.15f; 

        public Player zpoPlayer = new();


        public void ApplySaves() {  
            /* Reimplement saves now that things are different
            if (GameLoop.UIManager.zpoWrap.Game is ZeroPlayersOnline zpo) {
                zpo.player = zpoPlayer.Clone();
                zpo.TryAddSkills();
            }
            */
        }
    }
}
