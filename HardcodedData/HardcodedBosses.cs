using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedBosses {
        public static void InitBosses(Dictionary<string, BossFight> BossLib) {
            List<BossFight> toAdd = new();

            toAdd.Add(new("Huge Zombie", "bossZombie", 10, 20, "Slash", 0, 5, "1d3", "Melee", 2000, 3, 3, true) { 
                CountsAsSlayer = ["zombie", "undead"],
                Specials = new() {
                    new("The huge zombie roars and rears back, preparing to slam the huge club into the ground.", "1d6+2", "Melee", [ 1 ]),
                    new("The huge zombie groans angrily and prepares to swipe to either side.", "1d6+2", "Melee", [ 0, 2 ])
                },
                DropTable = new() { 
                    new("petBabyZombie", 1, 50, 1, 1),
                    new("clubHuger", 1, 20, 1, 1), 
                    new("clubHuge", 1, 10, 1, 1),
                    new("runeMind", 1, 4, 10, 20),  
                    new("runeAir", 1, 4, 10, 20), 
                    new("runeWater", 1, 4, 10, 20), 
                    new("runeEarth", 1, 4, 10, 20), 
                    new("runeFire", 1, 4, 10, 20),  
                    new("arrowsBronze", 1, 4, 10, 20), 
                    new("fleshRotten", 1, 1, 1, 1),
                    new("bonesBig", 1, 1, 1, 1) 
                }
            });

            toAdd.Add(new("Brutus", "bossBrutus", 30, 58, "Slash", 0, 20, "1d3", "Melee", 3000, 3, 5, true) { 
                CountsAsSlayer = [ "cow" ],
                Specials = new() {
                    new("Brutus growls. Move out of the highlighted lanes, quickly!", "1d4+15", "Melee", [ 1, 2, 3 ]),
                    new("Brutus snorts. Move out of the highlighted lanes, quickly!", "1d4+15", "Melee", [ -1, 0, 1 ], true)
                },
                DropTable = new() { 
                    new("idesNameTag", 1, 1, 1, 1, req: new("QuestAt", 90, "MI_IdesOfMilk")),
                    new("meatRawTbone", 1, 1, 1, 1),
                    new("bonesBull", 1, 1, 1, 1), 
                    new("mooleta", 1, 30, 1, 1), 
                    new("bucketMilkBottomless", 1, 37.5, 1, 1), 
                    new("slippersCow", 1, 150, 1, 1), 
                    new("helmIron", 1, 40.5, 1, 1), 
                    new("platebodyIron", 1, 40.5, 1, 1), 
                    new("platelegsIron", 1, 81, 1, 1),
                    new("plateskirtIron", 1, 81, 1, 1),  
                    new("arrowsIron", 1, 8.1, 14, 14),
                    new("runeAir", 1, 8.1, 29, 29),
                    new("runeMind", 1, 10.13, 18, 18),
                    new("runeChaos", 1, 40.5, 12, 12),  
                    new("seedPotato", 1, 8.1, 3, 3),
                    new("seedTreePine", 1, 8.1, 2, 2),
                    new("seedTreeOak", 1, 16.2, 2, 2),
                    new("meatRawTbone", 1, 8.1, 3, 3, true),
                    new("cowhide", 1, 8.1, 1, 1),
                    new("logOak", 1, 16.2, 2, 2),
                    new("logPine", 1, 16.2, 2, 2),
                    new("coins", 1, 5.4, 60, 80),
                    new("coins", 1, 16.2, 80, 100),
                    new("coins", 1, 16.2, 100, 120),
                    new("clueScrollBeginner", 1, 15, 1, 1), 
                    new("clueScrollEasy", 1, 40, 1, 1), 
                    new("petBeef", 1, 1000, 1, 1) 
                }
            });
            

            for (int i = 0; i < toAdd.Count; i++) { 
                BossLib.TryAdd(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
