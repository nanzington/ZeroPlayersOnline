namespace ZeroPlayersOnline.DataTypes {
    public class CollectionLogEntry {
        public string MonsterID = "";
        public int KillCount = 0;

        public Dictionary<string, int> DropsObtained = new();

        public CollectionLogEntry(string id) {
            MonsterID = id;
        }
    }
}
