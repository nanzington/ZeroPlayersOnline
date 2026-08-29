using Newtonsoft.Json; 

namespace ZeroPlayersOnline.DataTypes {
    public class ItemSpot {
        public int X;
        public int Y;

        public string ItemID = "";

        public int RespawnTimer = 1; // in game-minutes, aka real seconds

        public Requirement? ReqToSpawn = null;


        [JsonIgnore]
        public double LastPickedUp = 0;

        // Probably should add a way to control when it spawns like by season or year 

        public ItemSpot(string id, int respawn, Requirement? req = null) {
            ItemID = id;
            RespawnTimer = respawn;

            ReqToSpawn = req;
        }
    }
}
