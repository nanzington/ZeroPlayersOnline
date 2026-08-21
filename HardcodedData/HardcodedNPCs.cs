using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCs {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();

            toAdd.Add(new("Smithing Tutor", "tutorSmithing", new() {
                {
                    0,
                    new("To begin smithing, first collect the ores you wish to use. Start with some copper and tin.", new() {
                        new DialogueChoice("(NEXT)", 10),
                        byeThen
                    })
                },
                {
                    10,
                    new("Next, in your inventory, click the U on either ore, then click the U on the other ore to mix them.", new() {
                        new DialogueChoice("(NEXT)", 20),
                        byeThen
                    })
                },
                {
                    20,
                    new("Now change the dialogue on the right to Processing Stations, and click Furnace to smelt them.", new() {
                        new DialogueChoice("(NEXT)", 30),
                        byeThen
                    })
                },
                {
                    30,
                    new("Next, (U)se the bar on plans for the item you want to make. There's some dagger plans on the ground here.", new() {
                        new DialogueChoice("(NEXT)", 40),
                        byeThen
                    })
                },
                {
                    40,
                    new("Repeat this until the plans are full, indicated by the fraction at the end. Then use an Anvil station to complete it.", new() {
                        new DialogueChoice("(NEXT)", 50),
                        byeThen
                    })
                },
                {
                    50,
                    new("That's all there is to it! If you want to try other items, change to the (S) tab on the right and buy some other plans.", new() { byeThen })
                }
            }));

            toAdd.Add(new("Cooking Tutor", "tutorCooking", new() {
                {
                    0,
                    new("You want to learn cooking, eh? Well luckily it's dead simple.", new() {
                        new DialogueChoice("(NEXT)", 10),
                        byeThen
                    })
                },
                {
                    10,
                    new("First, have an uncooked item in your bag like some raw newt meat or raw fish.", new() {
                        new DialogueChoice("(NEXT)", 20),
                        byeThen
                    })
                },
                {
                    20,
                    new("Next switch to the (P)rocessing tab in your activity area, and click 'Range' once for each uncooked item.", new() {
                        new DialogueChoice("(NEXT)", 30),
                        byeThen
                    })
                },
                {
                    30,
                    new("You can also use this process to fill buckets with water at the 'Sink'. Many recipes can be done like this.", new() {
                        new DialogueChoice("(NEXT)", 40),
                        byeThen
                    })
                }, 
                {
                    40,
                    new("That's all there is to it! Enjoy your cooked food, it'll heal a few hitpoints when you eat it.", new() { byeThen })
                }
            }));

            toAdd.Add(new("Man", "man", new() { { 0, new("Lovely day for it!", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coinPouchSmall", 1) } });
             

            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
