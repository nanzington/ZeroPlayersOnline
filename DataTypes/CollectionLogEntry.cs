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
                if (!DropsObtained.ContainsKey(itemID) || DropsObtained[itemID] == 0) {
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


        public int TryFindTotal() {
            if (GameLoop.ZPO.MonsterLibrary.TryGetValue(MonsterID, out AreaMonster? mon) && mon != null) {
                return mon.DropTable.Count;
            }

            if (GameLoop.ZPO.BossLibrary.TryGetValue(MonsterID, out BossFight? boss) && boss != null) {
                return boss.DropTable.Count;
            }

            if (GameLoop.ZPO.ItemLibrary.TryGetValue(MonsterID, out Item? cask) && cask != null) {
                return cask.DropTable.Count;
            }

            return -1;
        }

        public int ActualObtained() {
            int actualObtained = 0;
            foreach (var kv in DropsObtained) {
                if (kv.Value > 0) {
                    actualObtained++;
                }
            }
            return actualObtained;
        }

        public bool LogComplete() {
            int target = TryFindTotal();

            if (target > 0) { 
                return ActualObtained() == target;
            }

            return false;
        }
    }
}
