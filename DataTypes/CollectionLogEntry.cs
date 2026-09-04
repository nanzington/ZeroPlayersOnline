namespace ZeroPlayersOnline.DataTypes {
    public class CollectionLogEntry {
        public string MonsterID = "";
        public int KillCount = 0;

        public Dictionary<string, int> DropsObtained = new();

        public CollectionLogEntry(string id) {
            MonsterID = id;
        }


        public bool DryProtection(string itemID, int dropRate) {
            if (KillCount >= dropRate) {
                if (!DropsObtained.ContainsKey(itemID)) {
                    return true;
                }
            }

            return false;
        }

        public bool NoRNGDrop(string itemID, int dropRate) {
            if (KillCount % dropRate == 0)
                return true;
            return false;
        }
    }
}
