using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedBosses {
        public static void InitBosses(Dictionary<string, BossFight> BossLib) {
            List<BossFight> toAdd = new();

            toAdd.Add(new("Huge Zombie", "bossZombie", 10, 20, "Slash", 0, 5, "1d3", "Melee", 2000, 3, 3, 10, false) { 
                Specials = new() {
                    new("The huge zombie roars and rears back, preparing to slam the huge club into the ground.", "1d6+2", "Melee", [ 1 ]),
                    new("The huge zombie groans angrily and prepares to swipe to either side.", "1d6+2", "Melee", [ 0, 2 ])
                },
                DropTable = new() { 
                    new("bonesBig", 1, 1, 1, 1),
                    new("clubHuge", 1, 10, 1, 1),
                    new("clubHuger", 1, 20, 1, 1),
                    new("petBabyZombie", 1, 50, 1, 1)
                } 
            });
            

            for (int i = 0; i < toAdd.Count; i++) { 
                BossLib.TryAdd(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
