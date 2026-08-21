using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.HardcodedData {
    public static class HardcodedPrayers {
        public static void InitPrayers(Dictionary<string, Prayer> PrayerLib) {
            List<Prayer> toAdd = new();

            toAdd.Add(new Prayer("Thick Skin", "Normal", 1, 1, 1, "Defense"));


            for (int i = 0; i < toAdd.Count; i++) {
                PrayerLib.Add(toAdd[i].Name, toAdd[i]);
            }
        }
    }
}
