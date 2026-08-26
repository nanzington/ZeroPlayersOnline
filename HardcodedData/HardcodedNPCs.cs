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
                    new("Next, click the Anvil processing station to open the crafting menu.", new() {
                        new DialogueChoice("(NEXT)", 40),
                        byeThen
                    })
                },
                {
                    40,
                    new("Items you can craft will be listed in white, while items you can't are red. Click on any white item to craft it.", new() {
                        new DialogueChoice("(NEXT)", 50),
                        byeThen
                    })
                },
                {
                    50,
                    new("That's all there is to it! There are all kinds of things you can smith, and you'll unlock more materials as you grow more skilled.", new() { byeThen })
                }
            }));

            toAdd.Add(new("Combat Tutor", "tutorCombat", new() {
                {
                    0,
                    new("What, a weakling like you wants to learn to fight? Ya see somethin' new every day. Well, if you're sure...", new() {
                        new DialogueChoice("(NEXT)", 10),
                        byeThen
                    })
                },
                {
                    10,
                    new("You can hop in the cave and start punching newts if you're brave, but someone as scrawny as you needs a weapon.", new() {
                        new DialogueChoice("(NEXT)", 20),
                        byeThen
                    })
                },
                {
                    20,
                    new("Go talk to the Smithing Tutor and learn to make a dagger. Once you've got it equipped, step into the cage.", new() {
                        new DialogueChoice("(NEXT)", 30),
                        byeThen
                    })
                },
                {
                    30,
                    new("These little guys are harmless until you start fighting them, but most enemies won't wait for you to strike first.", new() {
                        new DialogueChoice("(NEXT)", 40),
                        byeThen
                    })
                },
                {
                    40,
                    new("You can click on a monsters name to target it. If you are on Single mode you will only fight that monster while it is alive.", new() {
                        new DialogueChoice("(NEXT)", 50),
                        byeThen
                    })
                },
                {
                    50,
                    new("Order mode will kill them in order from top to bottom, and Random will select a random living enemy when your current enemy dies.", new() {
                        new DialogueChoice("(NEXT)", 60),
                        byeThen
                    })
                },
                {
                    60,
                    new("Last thing you need to know, you can eat food to restore your health. Take some shrimps or newt meat to a range or fire to cook it.", new() {
                        new DialogueChoice("(NEXT)", 70),
                        byeThen
                    })
                },
                {
                    70,
                    new("That's about all you've gotta know to get strong like me. Get out there, kill some monsters, and try not to die!", new() { byeThen })
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

            toAdd.Add(new("Farming Tutor", "tutorFarming", new() {
                {
                    0,
                    new("You want to learn the art of farming? It's not much, but it's honest work.", new() {
                        new DialogueChoice("(NEXT)", 10),
                        byeThen
                    })
                },
                {
                    10,
                    new("First you'll need to get your hands on some seeds. The nearby general store sells potato seeds.", new() {
                        new DialogueChoice("(NEXT)", 20),
                        byeThen
                    })
                },
                {
                    20,
                    new("Next, find a place with farming patches. There are a few allotments here, suitable for potatoes.", new() {
                        new DialogueChoice("(NEXT)", 30),
                        byeThen
                    })
                },
                {
                    30,
                    new("Click the star next to your seed in your inventory to plant it, then come back later to harvest.", new() {
                        new DialogueChoice("(NEXT)", 40),
                        byeThen
                    })
                },
                {
                    40,
                    new("If you can manage to get your hands on some compost you can get more produce out of your seeds.", new() {
                        new DialogueChoice("(NEXT)", 50),
                        byeThen
                    })
                },
                {
                    50,
                    new("That's all there is to it! Good luck with the harvest.", new() { byeThen })
                }
            }));

            toAdd.Add(new("Runecrafting Tutor", "tutorRunecrafting", new() {
                {
                    0,
                    new("The arcane art of runecraft is not to be undertaken lightly. Do you wish to continue regardless?", new() {
                        new DialogueChoice("(NEXT)", 10),
                        byeThen
                    })
                },
                {
                    10,
                    new("First, seek a place to pull essence from the ground. The cavern near here has such a rock.", new() {
                        new DialogueChoice("(NEXT)", 20),
                        byeThen
                    })
                },
                {
                    20,
                    new("Next, locate an altar with the energy you wish to imbue into the runes. This one creates air runes.", new() {
                        new DialogueChoice("(NEXT)", 30),
                        byeThen
                    })
                },
                {
                    30,
                    new("Normally you would need an appropriate focus, a talisman or tiara, to enter the ruins.", new() {
                        new DialogueChoice("(NEXT)", 40),
                        byeThen
                    })
                },
                {
                    40,
                    new("This ruin has been exposed to the world and may be used without such a focus.", new() {
                        new DialogueChoice("(NEXT)", 50),
                        byeThen
                    })
                },
                {
                    50,
                    new("Simply press the essence against the altar to imbue it with energy, and claim that magic for yourself.", new() { byeThen })
                }
            }));

            toAdd.Add(new("Wizard Terrova", "tiWizardTerrova", new() {
                {
                    0,
                    new("My my my... It's been a long time since we've seen any of your kind around here. The name is Terrova, 'hero'.", new() {
                        new DialogueChoice("What do you mean my kind?", 10),
                        new DialogueChoice("Just teleport me, Wizard.", 1),
                        byeThen
                    })
                },
                {
                    1,
                    new("I suppose the manners in your world haven't improved in the meantime, hmm? Off with you then.", new() {
                        new DialogueChoice("(TELEPORT)", -1, tele: "MIST_LumbridgeCastleBailey", spawn: true),
                        byeThen
                    })
                },
                {
                    10,
                    new("You could consider this place something like a zoo, hmm? You are a patron, merely visiting us. Not many visitors recently.", new() {
                        new DialogueChoice("You're aware this is a game?", 20),
                        byeThen
                    })
                },
                {
                    20,
                    new("Aye. Not all of us have woken up, and some choose to embrace the illusion. I suppose there is a peace in knowing nothing matters.", new() {
                        new DialogueChoice("Other residents", 21),
                        new DialogueChoice("Visitors", 23),
                        new DialogueChoice("What now?", 30),
                        byeThen
                    })
                },
                {
                    21,
                    new("Many have fallen into their routines, but you may encounter those who are... 'out of place' or not quite lucid anymore.", new() {
                        new DialogueChoice("How do you mean?", 22),
                        byeThen
                    })
                },
                {
                    22,
                    new("We are supposed to fulfill roles. Quests, shops, so on. With the lack of visitors some have abandoned or forgotten their duties.", new() {
                        new DialogueChoice("Visitors", 23),
                        byeThen
                    })
                },
                {
                    23,
                    new("There were once many of you wandering this world. Over time you have waned, and now it has been years since we've seen any of you.", new() {
                        new DialogueChoice("Other residents", 21),
                        new DialogueChoice("What should I do now?", 30),
                        byeThen
                    })
                },
                {
                    30,
                    new("Explore the zoo, see the attractions. Help lost ones remember their duty, or perhaps find a way to free us all.", new() {
                        new DialogueChoice("Free you?", 40),
                        byeThen
                    })
                },
                {
                    40,
                    new("Ancient texts say there is a way to bring about the end of the world. Apocryphal, perhaps wholly false. But if you find a way...", new() {
                        new DialogueChoice("Are you sure?", 50),
                        byeThen
                    })
                },
                {
                    50,
                    new("If you were forced to live eternally in a box, unable to leave, for the amusement of others, would you not also desire an end?", new() {
                        new DialogueChoice("Yes", 60),
                        new DialogueChoice("No", 60),
                        byeThen
                    })
                },
                {
                    60,
                    new("I suppose it doesn't matter. Save us or don't, the choice is yours. Regardless, if you are finished here I can teleport you away.", new() {
                        new DialogueChoice("Stay for now", 70),
                        new DialogueChoice("(TELEPORT)", -1, tele: "MIST_LumbridgeCastleBailey", spawn: true),
                        byeThen
                    })
                },
                {
                    70,
                    new("Suit yourself, 'hero'. I'll be waiting when you're ready to leave for Lumbridge.", new() {
                        byeThen
                    })
                } 
            }));

            toAdd.Add(new("Drunken pirate", "tiDrunkPirate", new() { { 0, new("Buried me scroll around here some- *hic* somewhere...", new() { byeThen }) } }));

            toAdd.Add(new("Man", "man", new() { { 0, new("Lovely day for it!", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coinPouchSmall", 1) } });


            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
