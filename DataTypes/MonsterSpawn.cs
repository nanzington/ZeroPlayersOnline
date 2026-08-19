using Newtonsoft.Json; 

namespace ZeroPlayersOnline.DataTypes { 
    public class MonsterSpawn {
        public string MonsterID = "";
        public int RespawnTime = 1;
        public int InternalID = 0; // Used for multiple of the same monster in one area

        [JsonIgnore]
        public double TimeLastKilled = 0;
          
    }
}
