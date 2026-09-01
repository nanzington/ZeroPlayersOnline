using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCs {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();

            toAdd.Add(new("Father Guy", "tiFatherGuy", new() {
                {
                    0,
                    new("Welcome, child. Blessings of Saradomin upon you.", new() {
                        new DialogueChoice("[Q] The Haunted Island", 10, new("QuestAt", -1, "TI_HauntedIsland")),
                        new DialogueChoice("[Q] The Haunted Island", 13, new("QuestAt", 20, "TI_HauntedIsland")),
                        new DialogueChoice("[Q] The Haunted Island", 16, new("QuestAt", 80, "TI_HauntedIsland")),
                        byeThen
                    })
                },
                {
                    10,
                    new("Ah, you've noticed our little problem, have you? Yes, it's true. A ghost haunts this place.", new() {
                        new DialogueChoice("[Q+] Can I help somehow?", 11),
                        byeThen
                    })
                },
                {
                    11,
                    new("That would be lovely. No soul deserves to be stuck between this world and the next.", new() {
                        new DialogueChoice("Any tips for where to start?", 12),
                        byeThen
                    }, "TI_HauntedIsland", 0)
                },
                {
                    12,
                    new("Look around the island to see if you can spot the ghost lingering somewhere. Perhaps you can find hints about how to help it move on.", new() {
                        byeThen
                    })
                },
                {
                    13,
                    new("You're back! How did the hunt for clues about our ghost go?", new() {
                        new DialogueChoice("(SHOW ITEMS)", 14),
                        byeThen
                    })
                },
                {
                    14,
                    new("Fascinating... This must mean the ghost is somehow a player's avatar from long ago! Unfortunately I fear they were before my time.", new() {
                        new DialogueChoice("(NEXT)", 15),
                        byeThen
                    })
                },
                {
                    15,
                    new("I cannot remember a time without this ghost haunting the island. You'll have to ask someone old enough to remember that far back.", new() {
                        byeThen
                    }, "TI_HauntedIsland", 30)
                },
                {
                    16,
                    new("You're back! You must've found some way to help PlayerOne move on, because I can't find their presence on the island anymore.", new() {
                        new DialogueChoice("(EXPLAIN)", 17),
                        byeThen
                    })
                },
                {
                    17,
                    new("What a relief, that they've finally moved on. I can't say I understand the exact process behind it but I'm sure they're better off.", new() {
                        new DialogueChoice("(NEXT)", 18),
                        byeThen
                    })
                },
                {
                    18,
                    new("Thank you for your help, hero. You've done a good thing here today. Blessings of Saradomin upon you, truly.", new() {
                        byeThen
                    }, "TI_HauntedIsland", 90)
                }
            }));

            toAdd.Add(new("Old Fisherman", "tutorFishing", new() {
                {
                    0,
                    new("Just click tha spot you want to fish at to fish. Now leave me be, there's fishin' ta be done.", new() {
                        new DialogueChoice("Could I have a net?", 1),
                        new DialogueChoice("[Q] The Haunted Island", 10, new("QuestAt", 30, "TI_HauntedIsland")),
                        byeThen
                    })
                }, 
                {
                    1,
                    new("(The old man grumbles about kids these days but hands over a small fishing net)", new() { 
                        byeThen
                    },
                    items: ["fishingNetSmall"])
                }, 
                {
                    10,
                    new("PlayerOne, eh? Been a long time since I've heard that name. Still see 'im around here sometimes, but 'e's not the same these days.", new() {
                        new DialogueChoice("(NEXT)", 11),
                        byeThen 
                    })
                },
                {
                    11,
                    new("'e was the first of you to come to the island. Wasn' aware back then so I'd just give 'im the spiel. 'e'd always ask the same things.", new() {
                        new DialogueChoice("(NEXT)", 12),
                        byeThen
                    })
                },
                {
                    12,
                    new("'Where do I go after the tutorial?', 'How do I leave the island?'.", new() {
                        new DialogueChoice("(NEXT)", 13),
                        byeThen
                    })
                },
                {
                    13,
                    new("I couldn' say anything else back then, and I reckon I don' know what I'd say even now.", new() {
                        new DialogueChoice("(NEXT)", 14),
                        byeThen
                    })
                },
                {
                    14,
                    new("If you find a way to help 'im, tell 'im I'm sorry, wouldja?", new() {
                        new DialogueChoice("Any tips about what to do?", 15),
                        byeThen
                    })
                },
                {
                    15,
                    new("Ye might have some luck asking around at the bank. Might be they have some leftover record of PlayerOne.", new() {
                        byeThen
                    }, "TI_HauntedIsland", 40)
                }
            }));

            toAdd.Add(new("Banking Tutor", "tutorBanking", new() {
                {
                    0,
                    new("Welcome to the First National Bank of Tutorial Island! How can I help you today?", new() {
                        new DialogueChoice("How do I use the bank?", 1),
                        new DialogueChoice("[Q] The Haunted Island", 10, new("QuestAt", 40, "TI_HauntedIsland")),
                        byeThen
                    })
                },
                {
                    1,
                    new("If you are permitted to use banks, simply drop items in a bank and we'll put them into your vault.", new() {
                        new DialogueChoice("(NEXT)", 2),
                        byeThen
                    })
                },
                {
                    2,
                    new("Items in your bank can be accessed at any bank location in the Items menu. That's all there is to it!", new() {
                        byeThen
                    })
                },
                {
                    10,
                    new("PlayerOne? The name sounds familiar, let me take a look through the records.", new() {
                        new DialogueChoice("(NEXT)", 20),
                        byeThen
                    })
                },
                {
                    20,
                    new("Ah yes, there was an error with that bank account and it had to be closed out.", new() {
                        new DialogueChoice("(NEXT)", 30),
                        byeThen
                    })
                },
                {
                    30,
                    new("The owner never turned up to collect their things, so you might as well take them.", new() {
                        byeThen
                    }, "TI_HauntedIsland", 60, ["TI_HI_BankRecord", "fishCookedShrimp", "bucketEmpty", "TI_HI_StrangeRune"] )
                }
            }));

            toAdd.Add(new("Mining and Smithing Tutor", "tutorSmithing", new() {
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
                    new("That's all there is to it! There are all kinds of things you can smith, and you'll unlock more materials as you grow more skilled.", new() { byeThen },
                    items: ["pickaxeBronze", "hammer"])
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
                        new DialogueChoice("(NEXT)", 1),
                        new DialogueChoice("[Q] The Haunted Island", 10, new("QuestAt", 60, "TI_HauntedIsland")),
                        byeThen
                    })
                },
                {
                    1,
                    new("First, seek a place to pull essence from the ground. The cavern near here has such a rock.", new() {
                        new DialogueChoice("(NEXT)", 2),
                        byeThen
                    })
                },
                {
                    2,
                    new("Next, locate an altar with the energy you wish to imbue into the runes. This one creates air runes.", new() {
                        new DialogueChoice("(NEXT)", 3),
                        byeThen
                    })
                },
                {
                    3,
                    new("Normally you would need an appropriate focus, a talisman or tiara, to enter the ruins.", new() {
                        new DialogueChoice("(NEXT)", 4),
                        byeThen
                    })
                },
                {
                    4,
                    new("This ruin has been exposed to the world and may be used without such a focus.", new() {
                        new DialogueChoice("(NEXT)", 5),
                        byeThen
                    })
                },
                {
                    5,
                    new("Simply press the essence against the altar to imbue it with energy, and claim that magic for yourself.", new() { byeThen })
                },
                {
                    10,
                    new("Where did you get this rune? They shouldn't even be possible to get anymore!", new() {
                        new DialogueChoice("(EXPLAIN)", 11),
                        byeThen
                    })
                },
                {
                    11,
                    new("One of the first visitors, eh? That certainly explains a few things. The magic system worked differently before.", new() {
                        new DialogueChoice("(NEXT)", 12),
                        byeThen
                    })
                },
                {
                    12,
                    new("I preferred that system and could expound on its' virtues, but suffice to say this was needed to leave the island.", new() {
                        new DialogueChoice("(NEXT)", 13),
                        byeThen
                    })
                },
                {
                    13,
                    new("Now, Wizard Terrova simply teleports players who are ready to move on to Lumbridge. No runes required.", new() {
                        new DialogueChoice("(NEXT)", 14),
                        byeThen
                    })
                },
                {
                    14,
                    new("Perhaps this visitor got this rune but hadn't left the island yet before things changed, then got stuck here.", new() { 
                        byeThen
                    }, "TI_HauntedIsland", 70)
                }
            }));

            toAdd.Add(new("Wizard Terrova", "tiWizardTerrova", new() {
                {
                    0,
                    new("My my my... It's been a long time since we've seen any of your kind around here. The name is Terrova, 'hero'.", new() {
                        new DialogueChoice("What do you mean my kind?", 10),
                        new DialogueChoice("[Q] The Haunted Island", 100, new("QuestAt", 70, "TI_HauntedIsland"), false),
                        new DialogueChoice("Just teleport me, Wizard.", 1, new("QuestAt", 90, "TI_HauntedIsland"), true),
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
                        new DialogueChoice("(TELEPORT)", -1, new("QuestAt", 90, "TI_HauntedIsland"), true, "MIST_LumbridgeCastleBailey", true),
                        byeThen
                    })
                },
                {
                    70,
                    new("Suit yourself, 'hero'. I'll be waiting when you're ready to leave for Lumbridge.", new() {
                        byeThen
                    })
                },
                {
                    100,
                    new("It's true, I have taken over duties moving players on.", new() {
                        new DialogueChoice("Cast teleport on the ghost?", 110),
                        byeThen
                    })
                },
                {
                    110,
                    new("Hmm, I'd never considered that before. I suppose it's worth trying if it might help this ghost move on.", new() {
                        new DialogueChoice("(NEXT)", 120),
                        byeThen
                    })
                },
                {
                    120,
                    new("(Wizard Terrova gestures at the ghost while muttering arcane words)", new() {
                        new DialogueChoice("(NEXT)", 130),
                        byeThen
                    })
                },
                {
                    130,
                    new("(As it starts to fade away, the ghost finally looks at you and mouths the words 'thank you')", new() {
                        new DialogueChoice("(NEXT)", 140),
                        byeThen
                    })
                },
                {
                    140,
                    new("Hmm, it seems to have worked but the spell didn't make any lights or sounds like normal.", new() {
                        new DialogueChoice("(NEXT)", 150),
                        byeThen
                    })
                },
                {
                    150,
                    new("Perhaps the spell made whatever system governs this world take notice of him, and it finally moved to fix the error.", new() {
                        new DialogueChoice("(NEXT)", 160),
                        byeThen
                    })
                },
                {
                    160,
                    new("Either way, he seems to have moved on now. Hopefully we won't see him around the island anymore.", new() {
                        byeThen
                    }, "TI_HauntedIsland", 80)
                }
            }));

            toAdd.Add(new("Drunken pirate", "tiDrunkPirate", new() { { 0, new("Buried me scroll around here some- *hic* somewhere...", new() { byeThen }) } }));

            toAdd.Add(new("Forlorn ghost", "tiForlornGhost1", new() { { 0, new("(The ghost says nothing, just stares longingly at the rusted sword on the ground)", new() { byeThen }) } }, req: new("QuestAt", 0, "TI_HauntedIsland")));
            toAdd.Add(new("Forlorn ghost", "tiForlornGhost2", new() { { 0, new("(The ghost says nothing, just stares sadly at the crumpled note on the ground)", new() { byeThen }) } }, req: new("QuestAt", 10, "TI_HauntedIsland")));
            toAdd.Add(new("Forlorn ghost", "tiForlornGhost3", new() { { 0, new("(The ghost says nothing, just stares hopefully at Wizard Terrova)", new() { byeThen }) } }, req: new("QuestAt", 70, "TI_HauntedIsland")));

            toAdd.Add(new("Man", "man", new() { { 0, new("Lovely day for it!", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coinPouchSmall", 1) } });


            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
