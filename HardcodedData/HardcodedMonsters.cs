using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedMonsters {
        public static void InitMonsters(Dictionary<string, AreaMonster> MonsterLib) {
            List<AreaMonster> toAdd = new();

            toAdd.Add(new("Giant Newt", "newt", 1, 3, 0, 0, false, "1d2-1", "Slash", 5, "Melee") { DropTable = new() { new("eyeNewt", 1, 4, 1, 1), new("bonesRegular", 1, 1, 1, 1), new("meatRawNewt", 1, 1, 1, 1) } }); 


            for (int i = 0; i < toAdd.Count; i++) { 
                MonsterLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
