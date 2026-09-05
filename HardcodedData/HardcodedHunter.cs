using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedHunter {
        public static void InitHunter(Dictionary<string, HunterCreature> HunterLib) {
            List<HunterCreature> toAdd = new();

            toAdd.Add(new("Crimson swift", "birdSwift", 1, 34, "trapBird", "", 5, 220, 20, 60, new() {
                new("meatRawBird", 1, 1, 1, 1), new("bonesRegular", 1, 1, 1, 1), new("feather", 1, 1, 5, 10)
            }));
            

            for (int i = 0; i < toAdd.Count; i++) { 
                HunterLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
