using Newtonsoft.Json;

namespace ZeroPlayersOnline.DataTypes {
    public class HunterCreature {
        public string ID = "";
        public string Name = "";

        public int CatchLevel = 1;
        public int CatchEXP = 0;

        public string CatchID = "";
        public string LureID = "";


        public int SecondsToDisappear = -1;
        public int RespawnTime = 1;

        public int R = 255;
        public int G = 255;
        public int B = 255;

        public List<ItemDrop> Drops = new();
        
        [JsonIgnore]
        public double TimeSpawned = 0;
        [JsonIgnore]
        public double TimeLastMoved = 0;
        [JsonIgnore]
        public double TimeLastCaught = 0;
        [JsonIgnore]
        public int CurrentLane = 0;

        public HunterCreature(string name, string id, int lv, int exp, string catchTool, string lureTool, int respawn, int r, int g, int b, List<ItemDrop>? drops = null, int disappear = -1) {
            Name = name;
            ID = id;
            CatchLevel = lv;
            CatchEXP = exp;
            CatchID = catchTool;
            LureID = lureTool;

            R = r;
            G = g;
            B = b;

            RespawnTime = respawn;

            if (drops != null)
                Drops = drops;

            SecondsToDisappear = disappear;
        }

        public Color GetColor() {
            return new Color(R, G, B);
        }
    }
}
