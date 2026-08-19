using Newtonsoft.Json; 

namespace ZeroPlayersOnline.DataTypes {
    public class ItemSpot {
        public int X;
        public int Y;

        public string ItemID = "";

        public int RespawnTimer = 1; // in game-minutes, aka real seconds


        [JsonIgnore]
        public double LastPickedUp = 0;

        // Probably should add a way to control when it spawns like by season or year

        public ItemSpot() { }

        public ItemSpot(string id, int respawn) {
            ItemID = id;
            RespawnTimer = respawn;
        }
    }
}
