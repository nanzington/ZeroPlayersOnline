namespace ZeroPlayersOnline.DataTypes {
    public class Location {
        public string DisplayName = "";
        public string ID = "";
        public string Region = "";

        public string Description = "";
        public bool IsBank = false;

        public string DigItem = "";
        public int DungeoneeringLevel = 0; // If above 0, you have to have at least this level of Dungeoneering to skill or combat here, but gain exp for doing so.

        public List<Connection> ConnectedLocations = new();

        public List<string> GatheringSpots = new();
        public List<GatheringTile> LocalGathers = new();

        public List<string> ProcessingStations = new();
        public List<ProcessingStation> TempStations = new();

        public List<ItemSpot> ItemSpawns = new();

        public List<Item> ItemsHere = new();

        public List<MonsterSpawn> MonsterSpawns = new();

        public List<string> AreaMonsters = new();
        public List<AreaMonster> MonstersHere = new();

        public List<string> NPCsHere = new();

        public List<string> ShopItemsHere = new();

        public List<string> FarmingPatchesHere = new();
    }
}
