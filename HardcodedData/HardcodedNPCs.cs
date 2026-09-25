using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCs {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();
            // Tutorial Island
            { 
                toAdd.Add(new("Slayer Tutor", "tutorSlayer", new() {
                    {
                        0,
                        new("Regular combat not exciting enough for ya? I've got something that might wet your whistle, hero.", new() {
                            new DialogueChoice("(NEXT)", 1),
                            byeThen
                        })
                    },
                    {
                        1,
                        new("Slayer as a skill is dead simple. Click the S next to the name of a Slayer Master in the chat list to get a task.", new() {
                            new DialogueChoice("(NEXT)", 2),
                            byeThen
                        })
                    },
                    {
                        2,
                        new("Then simply go find the monster they want you to kill, kill as many as they say, then come back for another task.", new() {
                            new DialogueChoice("(NEXT)", 3),
                            byeThen
                        })
                    },
                    {
                        3,
                        new("That's all there is to it! Now get out there and kill, kill, kill!", new() {
                            byeThen
                        }, items: [ "gemSlayer,1" ])
                    }
                }) {
                    SlayerLevel = 1,
                    SlayerTasks = new() {
                        new("cow", 5, 10, 2),
                        new("chicken", 10, 20, 5),
                        new("tiZombie", 5, 10, 1),
                        new("newt", 5, 10, 2)
                    }
                });

                toAdd.Add(new("Father Guy", "tiFatherGuy", new() {
                    {
                        0,
                        new("Welcome, child. Blessings of Saradomin upon you.", new() {
                            new DialogueChoice("[Q] The Haunted Island", 10, [ new("QuestAt", -1, "TI_HauntedIsland") ]),
                            new DialogueChoice("[Q] The Haunted Island", 13, [ new("QuestAt", 20, "TI_HauntedIsland") ]),
                            new DialogueChoice("[Q] The Haunted Island", 16, [ new("QuestAt", 80, "TI_HauntedIsland") ]),
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
                            new DialogueChoice("[Q] The Haunted Island", 10, [ new("QuestAt", 30, "TI_HauntedIsland") ]),
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
                            new DialogueChoice("[Q] The Haunted Island", 10, [ new("QuestAt", 40, "TI_HauntedIsland") ]),
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

                toAdd.Add(new("Hunter Tutor", "tutorHunter", new() {
                    {
                        0,
                        new("Looking to train Hunter? You've come to the right place!", new() {
                            new DialogueChoice("(NEXT)", 1),
                            byeThen
                        })
                    },
                    {
                        1,
                        new("First, you'll need to head to the General Store to pick up some bird snares. Go ahead and get three of them.", new() {
                            new DialogueChoice("(NEXT)", 2),
                            byeThen
                        })
                    },
                    {
                        2,
                        new("While you're at a location with creatures to trap, switch to the (H) tab and (U) the trap in your inventory on a hunter spot.", new() {
                            new DialogueChoice("(NEXT)", 3),
                            byeThen
                        })
                    },
                    {
                        3,
                        new("Hunter creatures will move around the spots periodically. If they move to a trapped spot, there's a chance that you will catch them.", new() {
                            new DialogueChoice("(NEXT)", 4),
                            byeThen
                        })
                    },
                    {
                        4,
                        new("The trap will automatically be returned to your inventory, catch or fail, to be placed again. Drops will be left on the ground.", new() {
                            new DialogueChoice("(NEXT)", 5),
                            byeThen
                        })
                    },
                    {
                        5,
                        new("That's all there is to it! Happy hunting, adventurer!", new() {
                            byeThen
                        })
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
                            new DialogueChoice("[Q] The Haunted Island", 10, [ new("QuestAt", 60, "TI_HauntedIsland") ]),
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

                toAdd.Add(new("Prayer Tutor", "tutorPrayer", new() {
                    {
                        0,
                        new("Greetings, fellow child of Saradomin! Would you like to learn how to harness the power of the Orderly One?", new() {
                            new DialogueChoice("(NEXT)", 10),
                            byeThen
                        })
                    },
                    {
                        10,
                        new("The easiest way to gain prayer experience is to honor the dead by burying their bones. Offering them at some altars may grant more.", new() {
                            new DialogueChoice("(NEXT)", 20),
                            byeThen
                        })
                    },
                    {
                        20,
                        new("If you navigate to the 'PRA'yer menu on the left, you can view all prayers in your currently selected prayer book.", new() {
                            new DialogueChoice("(NEXT)", 30),
                            byeThen
                        })
                    },
                    {
                        30,
                        new("Each prayer can be turned on or off at will, taking up points equal to the level needed to use it and granting their effects while on.", new() {
                            new DialogueChoice("(NEXT)", 40),
                            byeThen
                        })
                    },
                    {
                        40,
                        new("The maximum number of points you can use at once is equal to your Prayer level. But you can boost that by 5 by praying at an altar!", new() {
                            new DialogueChoice("(NEXT)", 50),
                            byeThen
                        })
                    },
                    {
                        50,
                        new("That's all there is to it! Good luck, and may Saradomin be with you.", new() { byeThen })
                    }
                }));

                toAdd.Add(new("Wizard Terrova", "tiWizardTerrova", new() {
                    {
                        0,
                        new("My my my... It's been a long time since we've seen any of your kind around here. The name is Terrova, 'hero'.", new() {
                            new DialogueChoice("What do you mean my kind?", 10),
                            new DialogueChoice("[Q] The Haunted Island", 100, [ new("QuestAt", 70, "TI_HauntedIsland") ], false),
                            new DialogueChoice("Just teleport me, Wizard.", 1, [ new("QuestAt", 90, "TI_HauntedIsland") ], true),
                            new DialogueChoice("I did everything here!", 2, [ 
                                new("Skill", 10, "All"),
                                new("CollectionLogComplete", 0, "bossZombie"),
                                new("CollectionLogComplete", 0, "Tutorial clue"),
                                new("QuestAt", 90, "TI_HauntedIsland")
                            ], true),
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
                        2,
                        new("Have you now? Well it looks like you have! Quite an achievement! Take this cape and my sincere congratulations.", new() {
                            byeThen
                        }, items: ["capeCompTI,1"])
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
                            new DialogueChoice("(TELEPORT)", -1, [ new("QuestAt", 90, "TI_HauntedIsland") ], true, "MIST_LumbridgeCastleBailey", true),
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
        }
            
            toAdd.Add(new("Man", "man", new() { { 0, new("Lovely day for it!", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coins", 1, 1, 5, 5) } });
            toAdd.Add(new("Woman", "woman", new() { { 0, new("Lovely day for it!", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coins", 1, 1, 5, 5) } });
            toAdd.Add(new("Guard", "guard", new() { { 0, new("Keep it moving, adventurer.", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coins", 1, 1, 30, 30) } });
            toAdd.Add(new("Farmer", "farmer", new() { { 0, new("Have you seen m'chickens?", new() { byeThen }) } }, 10, 15) { 
                PickpocketLoot = new() { 
                    new ItemDrop("seedBarley", 1, 25, 1, 4),
                    new ItemDrop("seedHammerstone", 1, 26, 1, 4),
                    new ItemDrop("seedPotato", 1, 28, 1, 3),
                    new ItemDrop("seedOnion", 1, 32, 1, 3),
                    new ItemDrop("seedAsgarnian", 1, 32, 1, 4),
                    new ItemDrop("seedCabbage", 1, 35, 1, 3),
                    new ItemDrop("seedYanillian", 1, 42, 1, 4),
                    new ItemDrop("seedTomato", 1, 46, 1, 3),
                    new ItemDrop("seedJute", 1, 46, 1, 3),
                    new ItemDrop("seedSweetcorn", 1, 60, 1, 3),
                    new ItemDrop("seedMarigold", 1, 60, 1, 1),
                    new ItemDrop("seedKrandorian", 1, 60, 1, 4),
                    new ItemDrop("seedStrawberry", 1, 70, 1, 3),
                    new ItemDrop("seedTreePine", 1, 70, 1, 1),
                    new ItemDrop("seedGuam", 1, 70, 1, 1),
                    new ItemDrop("seedRedberry", 1, 84, 1, 1),
                    new ItemDrop("seedRosemary", 1, 84, 1, 1),
                    new ItemDrop("seedMarrentill", 1, 84, 1, 1),
                    new ItemDrop("seedTarromin", 1, 84, 1, 1),
                    new ItemDrop("seedWildblood", 1, 84, 1, 4),
                    new ItemDrop("seedCadava", 1, 105, 1, 1),
                    new ItemDrop("seedNasturtium", 1, 105, 1, 1),
                    new ItemDrop("seedWoad", 1, 105, 1, 1),
                    new ItemDrop("seedTreeOak", 1, 105, 1, 1),
                    new ItemDrop("seedLimpwurt", 1, 139, 1, 1),
                    new ItemDrop("seedTreeApple", 1, 139, 1, 1),
                    new ItemDrop("seedHarralander", 1, 139, 1, 1),
                    new ItemDrop("seedTreeWillow", 1, 139, 1, 1),
                    new ItemDrop("seedDwellberry", 1, 209, 1, 1),
                    new ItemDrop("seedTreeTeak", 1, 209, 1, 1),
                    new ItemDrop("seedTreeBanana", 1, 209, 1, 1),
                    new ItemDrop("seedRanarr", 1, 209, 1, 1), 
                    new ItemDrop("seedTreeMaple", 1, 418, 1, 1),
                    new ItemDrop("seedTreeOrange", 1, 418, 1, 1),
                    new ItemDrop("seedSpiritweed", 1, 418, 1, 1),
                    new ItemDrop("seedToadflax", 1, 418, 1, 1)
                } 
            });
            toAdd.Add(new("Master Farmer", "farmerMaster", new() { { 0, new("Hello there! Nice weather we've been having. Perfect for a day outdoors!", new() { byeThen }) } }, 38, 43, 3) { 
                PickpocketLoot = new() { 
                    DropTables.AllotmentSeeds.But(1000.0/485.0),
                    DropTables.HopSeeds.But(1000.0/243.0),
                    DropTables.FlowerSeeds.But(1000.0/122.0),
                    DropTables.BushSeeds.But(1000.0/97.0),
                    DropTables.SpecialSeeds.But(1000.0/5.0),
                    DropTables.HerbSeeds.But(1000.0/48.0)
                } 
            });

            // Misthalin 
            { 
                toAdd.Add(new("Jacquelyn", "mistLumJacquelyn", new() { { 0, new("Need a slayer task, hero?", new() { new("Could I see the slayer equipment shop?", 1), new("Could I see the slayer rewards shop?", 2), byeThen }) }, { 1, new("Sure thing!", new() { byeThen }, acts: [ new("OpenUI", "Shop", "Slayer Equipment", 0), new("EndDialogue", "", "", 0) ]) }, { 2, new("Sure thing!", new() { byeThen }, acts: [ new("OpenUI", "Shop", "Slayer Rewards", 0), new("EndDialogue", "", "", 0) ]) }
                }) {
                    SlayerLevel = 1,
                    SlayerTasks = new() {
                        new("bat", 15, 30, 10, new() { new("CombatAtLeast", 15), new("QuestAt", 100, "MI_BloodPact") }),
                        new("bird", 15, 30, 10),
                        new("caveBug", 15, 30, 10, new() { new("CombatAtLeast", 15), new("Skill", 7, "Slayer") }),
                        new("caveSlime", 10, 25, 10, new() { new("CombatAtLeast", 25), new("Skill", 17, "Slayer") }),
                        new("cow", 15, 30, 15),
                        new("frog", 15, 30, 10),
                        new("ghost", 15, 25, 10, new() { new("CombatAtLeast", 20) }),
                        new("goblin", 15, 30, 15),
                        new("rat", 15, 30, 10),
                        new("skeleton", 15, 25, 15, new() { new("CombatAtLeast", 15), new("QuestAt", 100, "MI_BloodPact") }),
                        new("spider", 15, 25, 10),
                        new("zombie", 15, 30, 15, new() { new("CombatAtLeast", 9), new("QuestAt", 100, "MI_BloodPact") })
                    }
                });

                toAdd.Add(new("Bartender", "mistLumBartender", new() { 
                    { 0, new("Welcome to the Sheared Ram. What can I do for you?", new() {  new DialogueChoice("I'll have a beer please?", 1, new() { new("Item", 2, "Gold", true)}, true), new DialogueChoice("Heard any rumors?", 2), byeThen }) },
                    { 1, new("That'll be two coins, please.", new() { new DialogueChoice("Another round, barkeep!", 1, new() { new("Item", 2, "Gold", true)}, true), byeThen }, items: new() { "beer,1" }) },
                    { 2, new("One of the patrons here is looking for treasure, apparently. A chap by the name of Veos.", new() { byeThen }) }
                }));

                 toAdd.Add(new("Candle seller", "mistLumCandles", new() { 
                    { 0, new("Do you want a lit candle for 1000 gold?", new() {  new DialogueChoice("Yes please.", 1, new() { new("Item", 1000, "Gold", true)}, true), new DialogueChoice("One thousand gold?!", 2), new("No thanks, I'd rather curse the darkness.", -1), byeThen }) },
                    { 1, new("Here you go then. I should warn you, though, it can be dangerous to take a naked flame down there. You'd be better off making a lantern.", new() { new("What's so dangerous about a naked flame?", 12), new("How do you make lanterns?", 5), byeThen }, items: new() { "candleLit,1" }) },
                    { 2, new("Look, you're not going to be able to survive down that hole without a light source.", new() { new("(NEXT)", 3), byeThen }) },
                    { 3, new("So you could go off to the candle shop to buy one more cheaply. You could even make your own lantern, which is a lot better.", new() { new("(NEXT)", 4), byeThen }) },
                    { 4, new("But I bet you want to find out what's down there right now, don't you? And you can pay me 1000 gold for the privilege!", new() { new DialogueChoice("Alright, you win, I'll buy a candle.", 1, new() { new("Item", 1000, "Gold", true)}, true), new("No way.", -1), new("How do you make lanterns?", 5), byeThen }) },
                    { 5, new("Out of glass. The more advanced lanterns have a metal component as well.", new() { new("(NEXT)", 6), byeThen }) },
                    { 6, new("Firstly you can make a simple candle lantern out of glass. It's just like a candle, but the flame isn't exposed, so it's safer.", new() { new("(NEXT)", 7), byeThen }) },
                    { 7, new("Then you can make an oil lam, which is brighter but has an exposed flame. But if you make an iron frame for it you can turn it into an oil lantern.", new() { new("(NEXT)", 8), byeThen }) },
                    { 8, new("Finally there's the bullseye lantern. You'll need to make a frame out of steel and add a glass lens.", new() { new("(NEXT)", 9), byeThen }) },
                    { 9, new("Once you've made your lamp or lantern, you'll need to make lamp oil for it. The chemist near Rimmington has a machine for that.", new() { new("(NEXT)", 10), byeThen }) },
                    { 10, new("For any light source, you'll need a tinderbox to light it. Keep your tinderbox handy in case it goes out!", new() { new("(NEXT)", 11), byeThen }) },
                    { 11, new("But if all that's too complicated, you can buy a candle right here for 1000 gold!", new() { new DialogueChoice("Alright, you win, I'll buy a candle.", 1, new() { new("Item", 1000, "Gold", true)}, true), new("No thanks, I'd rather curse the darkness.", -1), byeThen }) },
                    { 12, new("Heh heh... you'll find out.", new() { byeThen }) }
                }));

                toAdd.Add(new("Captain Harlan", "mistLumHarlan", new() { 
                    { 0, new("Greetings adventurer, I am the Melee combat tutor. Is there anything I can do for you?", new() {  new DialogueChoice("Tell me about skillcapes", 1), byeThen }) },
                    { 1, new("Skillcapes are a symbol of achievement. Only people who have reached level 99 can use them.", new() { new DialogueChoice("(NEXT)", 2), byeThen }) },
                    { 2, new("I am the Defense Skill Master, and if you have reached 99 Defense you can buy a cape from me for just 99,000 coins.", new() { new DialogueChoice("That's a bit expensive.", 3), new DialogueChoice("(BUY CAPE)", 4, new() { new("Item", 99000, "Gold", true), new("Skill", 99, "Defense")}, true), byeThen }) },
                    { 3, new("Is it, to demonstrate your mastery of the field of Defense? Perhaps you are not dedicated enough to deserve the cape.", new() { new DialogueChoice("(BUY CAPE)", 4, new() { new("Item", 99000, "Gold", true), new("Skill", 99, "Defense")}, true), byeThen }) },
                    { 4, new("Excellent choice, my friend. Wear it with pride.", new() { byeThen }, items: new() { "capeSkillDefense,1" }) },
                }));
                toAdd.Add(new("Victoria", "mistLumVictoria", new() { { 0, new("...Do you mind? I'm busy. Please leave.", new() { byeThen }) } }));
            
                toAdd.Add(new("Arthur the Clue Hunter", "clueArthur", new() { 
                     { 0, new("How can I help you?", new() { new DialogueChoice("Ask about tutorial clues", 10), new DialogueChoice("Ask about beginner clues", 20), new DialogueChoice("Ask about easy clues", 30), new DialogueChoice("Ask about medium clues", 40), new DialogueChoice("Ask about hard clues", 50), new DialogueChoice("Ask about elite clues", 60), new DialogueChoice("Ask about master clues", 70), new DialogueChoice("Ask for help with your clues", 100), byeThen }) }, 
                     { 10, new("Tutorial clues? I can't say I'm very familiar with them, but they can only be found and solved on Tutorial Island.", new() { new DialogueChoice("More help?", 0), byeThen }) },
                     { 20, new("Beginner clues are generally simple, requiring only up to level 10 in skills but no quests.", new() { new DialogueChoice("More help?", 0), byeThen }) },
                     { 30, new("Easy clues are generally, well, easy, requiring up to level 20 in skills and novice quests.", new() { new DialogueChoice("More help?", 0), byeThen }) },
                     { 40, new("Medium clues are where it begins to get tricky, requiring up to level 40 in skills and 'Intermediate' quests.", new() { new DialogueChoice("More help?", 0), byeThen }) },
                     { 50, new("Hard clues are difficult, and may require up to level 60 in skills and 'Experienced' quests.", new() { new DialogueChoice("More help?", 0), byeThen }) },
                     { 60, new("Elite clues are very difficult, and may require up to level 80 in skills and 'Master' quests.", new() { new DialogueChoice("More help?", 0), byeThen }) },
                     { 70, new("Master clues are as hard as it gets. They may require up to level 99 in skills and 'Grandmaster' quests.", new() { new DialogueChoice("More help?", 0), byeThen }) },
                     { 100, new("Righto, let me take a look here...", new() { new DialogueChoice("More help?", 0), byeThen }, acts: [ new("ClueHelp", "", "", 0) ]) }
                 }));

                toAdd.Add(new("Hans", "mistLumHans", new() { 
                     { 0, new("Hello. What are you doing here?", new() { new DialogueChoice("Who runs this place?", 10), new DialogueChoice("I have come to kill everyone!", 20), new DialogueChoice("I don't know, I'm lost.", 30), new DialogueChoice("How long have I been here?", 40), byeThen }) }, 
                     { 10, new("That'd be Duke. He's in his study, on the second floor.", new() { byeThen }) },
                     { 20, new("Guards! Help! Help!", new() { byeThen }) },
                     { 30, new("Well consider yourself found! This is Lumbridge Castle, second in Misthalin only to Varrock Castle.", new() { new DialogueChoice("How many castles in Misthalin?", 31), byeThen }) },
                     { 31, new("Just the two, I suppose. I hadn't really thought about it before.", new() { byeThen }) },
                     { 40, new("Righto, let me take a look here...", new() { byeThen }, acts: [ new("HansTime", "", "", 0) ]) }
                 }));

                toAdd.Add(new("Fred the Farmer", "mistLumFred", new() { 
                     { 0, new("What are you doing on my land? You're not the one leaving the gates open so the animals can get out, are you?", new() { new DialogueChoice("I'm looking for a quest.", 10), new DialogueChoice("Got those balls of wool.", 20, new() { new("QuestAt", 0, "MI_SheepShearer") }), new DialogueChoice("Got some more wool!", 23, new() { new("QuestAt", 10, "MI_SheepShearer"), new("Item", 1, "woolBall", true) }), byeThen }) }, 
                     { 10, new("Oh? Well, I could do with a bit of help.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                     { 11, new("My sheep are getting mighty wooly. I'd be much obliged if you could shear them and spin the wool for me.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                     { 12, new("Yes, that's it. Bring me 15 balls of wool. I'm sure I could sort out some sort of payment.", new() { new DialogueChoice("[Q+] Sheep Shearer", 13), byeThen }) },
                     { 13, new("Excellent! Do you actually know how to shear a sheep?", new() { new DialogueChoice("Of course!", 16), new DialogueChoice("Well, now that you mention it...", 14), byeThen }, "MI_SheepShearer", 0) }, 
                     { 14, new("Well all you've got to do is find some shears, find some sheep like the ones here, then just... shear them.", new() { new DialogueChoice("That's not very helpful.", 15), byeThen }) }, 
                     { 15, new("It's not a very complicated process, you'll figure it out.", new() { new DialogueChoice("(NEXT)", 16), byeThen }) },
                     { 16, new("Now, do you know how to spin the wool into balls after you've sheared it off?", new() { new DialogueChoice("Of course!", 19), new DialogueChoice("Well, not quite...", 17), byeThen }) },
                     { 17, new("Just take the wool you get from the sheep to a spinning wheel and run them through that.", new() { new DialogueChoice("Is there a spinning wheel nearby?", 18), byeThen }) },
                     { 18, new("Aye, there's one upstairs in Lumbridge Castle. It's open for anyone to use.", new() { new DialogueChoice("(NEXT)", 19), byeThen }) },
                     { 19, new("Well what're you waiting for then? Go shear those sheep and bring me the wool.", new() { byeThen }) },
                     { 20, new("Right, hand them over then.", new() { new DialogueChoice("(GIVE WOOL)", 22, new() { new("Item", 15, "woolBall", true) }, true), new DialogueChoice("Actually, I haven't got them yet.", 21), byeThen }) },
                     { 21, new("... Do you need a reminder of how to do it, or are you just wasting my time for fun?", new() { new DialogueChoice("Please explain again.", 13), byeThen }) },
                     { 22, new("Thanks for the help, friend! Here's a bit of gold for your time. If you want to do more, I'll pay 25 gold per wool from now on.", new() { byeThen }, "MI_SheepShearer", 10) },
                     { 23, new("Thanks for the help, friend! Here's a bit of gold for your time.", new() { new DialogueChoice("Got some more wool!", 23, new() { new("QuestAt", 10, "MI_SheepShearer"), new("Item", 1, "woolBall", true) }), byeThen }, items: new() { "Gold,25" }) }
                 }));

                toAdd.Add(new("Cook", "mistLumCook", new() { 
                     { 0, new("Have you got the ingredients?", new() { new DialogueChoice("What ingredients?", 10), new DialogueChoice("Here they are.", 20, new() { new("QuestAt", 0, "MI_CooksAssistant") }), new DialogueChoice("Here they are.", 23, new() { new("QuestAt", -1, "MI_CooksAssistant"), new("Item", 1, "eggChicken", true), new("Item", 1, "potFlour", true), new("Item", 1, "bucketMilk", true) }), byeThen }) }, 
                     { 10, new("The... the ingredients. Everyone brings me the ingredients. Well, not anymore, but usually.", new() { new DialogueChoice("What are they for?", 11), byeThen }) },
                     { 11, new("I don't... remember... It's been so long. All I can remember is that I need an egg, a pot of flour, and a bucket of milk.", new() { new DialogueChoice("Sounds like you're making a cake.", 12), byeThen }) },
                     { 12, new("Does it? I suppose that could be right... Either way, have you got them? Can you get them?", new() { new DialogueChoice("[Q+] Cook's Assistant", 13), byeThen }) },
                     { 13, new("Excellent!", new() { new DialogueChoice("(NEXT)", 14), byeThen }, "MI_CooksAssistant", 0) }, 
                     { 14, new("...You're still here. Don't tell me you don't know how to find them?", new() { new DialogueChoice("Chicken egg", 15), new DialogueChoice("Pot of flour", 16), new DialogueChoice("Bucket of milk", 18), byeThen }) }, 
                     { 15, new("I haven't left the castle in... I haven't left the castle. But I suppose an egg might be found at a chicken farm, no?", new() { new DialogueChoice("Pot of flour", 16), new DialogueChoice("Bucket of milk", 18), byeThen }) }, 
                     { 16, new("Is there a mill nearby? You might be able to take some, what's that yellow stuff called? Grows in the ground?", new() { new DialogueChoice("... Wheat?", 17), byeThen }) }, 
                     { 17, new("Wheat, that's the stuff! Grab a handful of that from a field somewhere and take it to a mill. Take a pot too.", new() { new DialogueChoice("Chicken egg", 15), new DialogueChoice("Bucket of milk", 18), byeThen }) },  
                     { 18, new("Milk seems pretty easy. Comes in a bucket, right? Probably grows on trees, those are made of bucket.", new() { new DialogueChoice("Chicken egg", 15), new DialogueChoice("Pot of flour", 16), byeThen }) },
                     { 20, new("Right, hand them over then.", new() { new DialogueChoice("(GIVE ITEMS)", 22, new() { new("Item", 1, "eggChicken", true), new("Item", 1, "potFlour", true), new("Item", 1, "bucketMilk", true) }, true), new DialogueChoice("Actually, I haven't got them yet.", 21), byeThen }) },
                     { 21, new("Come back when you have them, then. Do you need a reminder of where you can find each item?", new() { new DialogueChoice("Please explain again.", 14), byeThen }) },
                     { 22, new("Thank you for the help! Now I just have to figure out how to bake a cake... and what it was for.", new() { byeThen }, "MI_CooksAssistant", 10) },
                     { 23, new("Thank you for the help! Now I just have to remember what I needed these for...", new() { byeThen }, "MI_CooksAssistant", 10) }
                }));

            
                toAdd.Add(new("H.A.M. Member (female)", "hamFemale", new() { { 0, new("Kill all monsters!", new() { byeThen }) } }, 15, 22) { PickpocketLoot = new() { 
                    new("coinPouchSmall", 1, 1, 1, 1), new("coinPouchSmall", 1, 6, 1, 1),
                    new("hatchetBronze", 1, 34, 1, 1), new("daggerBronze", 1, 34, 1, 1), new("pickaxeBronze", 1, 34, 1, 1), new("hatchetIron", 1, 34, 1, 1), new("daggerIron", 1, 34, 1, 1), new("pickaxeIron", 1, 34, 1, 1), new("bodyLeather", 1, 34, 1, 1),  new("hatchetSteel", 1, 51, 1, 1), new("daggerSteel", 1, 51, 1, 1), new("pickaxeSteel", 1, 51, 1, 1),
                    new("hamGloves", 1, 102, 1, 1), new("hamBoots", 1, 102, 1, 1), new("hamShirt", 1, 102, 1, 1), new("hamSkirt", 1, 102, 1, 1), new("hamLogo", 1, 102, 1, 1), new("hamHood", 1, 102, 1, 1), new("hamCloak", 1, 102, 1, 1),
                    new("arrowsBronze", 1, 34, 1, 13), new("arrowsSteel", 1, 51, 1, 13),
                    new("spiritHerb", 1, 94, 1, 1), new("spiritHerb", 1, 187, 1, 1), new("spiritHerb", 1, 280, 1, 1), new("spiritFish", 1, 51, 1, 1),  new("spiritOreIron", 1, 51, 1, 1), new("spiritOreCoal", 1, 51, 1, 1),  new("spiritWoodPine", 1, 34, 1, 1),
                    new("cowhide", 1, 34, 1, 1), new("uncutOpal", 1, 51, 1, 1), new("uncutJade", 1, 51, 1, 1), new("meatRawChicken", 1, 51, 1, 3), new("feather", 1, 34, 1, 7), new("knife", 1, 51, 1, 1), new("needle", 1, 51, 1, 1), new("tinderbox", 1, 51, 1, 1),
                    new("clueScrollEasy", 1, 50, 1, 1)
                }});

                toAdd.Add(new("H.A.M. Member (male)", "hamMale", new() { { 0, new("Death to all monsters!", new() { byeThen }) } }, 15, 22) { PickpocketLoot = new() { 
                    new("coinPouchSmall", 1, 1, 1, 1), new("coinPouchSmall", 1, 6, 1, 1),
                    new("hatchetBronze", 1, 34, 1, 1), new("daggerBronze", 1, 34, 1, 1), new("pickaxeBronze", 1, 34, 1, 1), new("hatchetIron", 1, 34, 1, 1), new("daggerIron", 1, 34, 1, 1), new("pickaxeIron", 1, 34, 1, 1), new("bodyLeather", 1, 34, 1, 1),  new("hatchetSteel", 1, 51, 1, 1), new("daggerSteel", 1, 51, 1, 1), new("pickaxeSteel", 1, 51, 1, 1),
                    new("hamGloves", 1, 102, 1, 1), new("hamBoots", 1, 102, 1, 1), new("hamShirt", 1, 102, 1, 1), new("hamSkirt", 1, 102, 1, 1), new("hamLogo", 1, 102, 1, 1), new("hamHood", 1, 102, 1, 1), new("hamCloak", 1, 102, 1, 1),
                    new("arrowsBronze", 1, 34, 1, 13), new("arrowsSteel", 1, 51, 1, 13),
                    new("spiritHerb", 1, 94, 1, 1), new("spiritHerb", 1, 187, 1, 1), new("spiritHerb", 1, 280, 1, 1), new("spiritFish", 1, 51, 1, 1),  new("spiritOreIron", 1, 51, 1, 1), new("spiritOreCoal", 1, 51, 1, 1),  new("spiritWoodPine", 1, 34, 1, 1),
                    new("cowhide", 1, 34, 1, 1), new("uncutOpal", 1, 51, 1, 1), new("uncutJade", 1, 51, 1, 1), new("meatRawChicken", 1, 51, 1, 3), new("feather", 1, 34, 1, 7), new("knife", 1, 51, 1, 1), new("needle", 1, 51, 1, 1), new("tinderbox", 1, 51, 1, 1),
                    new("clueScrollEasy", 1, 50, 1, 1)
                }});

                 toAdd.Add(new("Border Guard", "desBorderGuard", new() { 
                     { 0, new("(The guard says nothing)", new() { new DialogueChoice("Can I come through this gate?", 10, new() { new("QuestBelow", 100, "DES_PrinceAliRescue")}), new DialogueChoice("Can I come through this gate?", 100, new() { new("QuestAt", 100, "DES_PrinceAliRescue")}), byeThen }) }, 
                     { 10, new("You must pay a toll of 10 gold coins to pass.", new() { new DialogueChoice("No thank you, I'll walk around.", 11), new DialogueChoice("Who does my money go to?", 12), new DialogueChoice("Yes, okay.", 13, new() { new("Item", 10, "Gold", true) }, true, "DES_AlKharidOutskirts"), byeThen }) },
                     { 11, new("Suit yourself.", new() { byeThen }) },
                     { 12, new("The money goes to the city of Al Kharid.", new() { byeThen }) },
                     { 20, new("You may pass for free, you are a friend of Al Kharid.", new() { new DialogueChoice("Yes, okay.", 13, tele: "DES_AlKharidOutskirts"), byeThen }) }
                 }));

                toAdd.Add(new("Seth Groats", "mistLumGroatsSeth", new() { 
                     { 0, new("M'arnin'... going to milk me cowsies!", new() { byeThen }) }, 
                }));

                toAdd.Add(new("Cassius", "mistLumCassius", new() { // TODO: Fill this out once implementing Ides of Milk
                     { 0, new("You! You steal mens souls!", new() { byeThen }) }, 
                }));

                toAdd.Add(new("Wizard Traiborn", "mistWizTraiborn", new() { 
                     { 0, new("Ello young thingummywut.", new() { new DialogueChoice("What's a thingummywut?", 1), new DialogueChoice("Teach me to be a mighty wizard.", 9), byeThen }) }, 
                     { 1, new("A thingummywut? Where? Where?!", new() { new DialogueChoice("(NEXT)", 2),  byeThen }) }, 
                     { 2, new("Those pesky thingummywuts. They get everywhere. THey leave a terrible mess too.", new() { new DialogueChoice("You just called me a thingummywut.", 3), new DialogueChoice("Tell me what they look like and I'll mash 'em.", 7), byeThen }) },
                     { 3, new("You're a thingummywut? I've never seen one up close before. They said I was mad!", new() { new DialogueChoice("(NEXT)", 4),  byeThen }) }, 
                     { 4, new("Now you are my proof! There ARE thingummywuts in this tower! Now where can I find a cage big enough to keep you?", new() { new DialogueChoice("I'd better be off...", 5), new DialogueChoice("They're right, you are mad.", 6),  byeThen }) },  
                     { 5, new("Oh, okay, have a good time, and watch out for sheep! They're more cunning than they look.", new() { byeThen }) }, 
                     { 6, new("That's a pity. I thought maybe they were winding me up.", new() { byeThen }) },  
                     { 7, new("Don't be ridiculous. No-one has ever seen one.", new() { new DialogueChoice("(NEXT)", 8), byeThen }) }, 
                     { 8, new("They're invisible, or a myth, or a figment of my imagination. Can't remember which right now.", new() { byeThen }) }, 
                     { 9, new("Wizard eh? You don't want any truck with that sort. They're not to be trusted. That's what I've heard anyways.", new() { new DialogueChoice("Aren't you a wizard?", 10), new DialogueChoice("I'd better stop talking to you then.", 11), byeThen }) }, 
                     { 10, new("How dare you? Of course I'm a wizard. Now don't be so cheeky or I'll turn you into a frog.", new() { byeThen }) },
                     { 11, new("Cheerio then. It was nice chatting to you.", new() { byeThen }) } 
                }));

                toAdd.Add(new("Wizard Jalarast", "mistWizJalarast", new() { 
                     { 0, new("Hello there, can I help you?", new() { new DialogueChoice("What do you do here?", 1), new DialogueChoice("What's that you're wearing?", 3), new DialogueChoice("Can you make me some armour please?", 8), byeThen }) }, 
                     { 1, new("I've been studying the practice of making split-bark armour.", new() { new DialogueChoice("Split-bark armour, what's that?", 2), new DialogueChoice("Can you make me some?", 4), byeThen }) },
                     { 2, new("Split-bark armour is special armour for mages. It's much mroe resistant to physical attacks than normal robes.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) }, 
                     { 3, new("It's actually very easy for me to make, but I've been having trouble getting hold of the pieces.", new() { new DialogueChoice("Well good luck with that.", -1), new DialogueChoice("Can you make me some?", 4), byeThen }) }, 
                     { 4, new("I need bark from a hollow tree and some fine cloth. Unfortunately both of these can only be found in Morytania.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },  
                     { 5, new("Of course I'd happily sell you some at a discounted price if you bring me those items.", new() { new DialogueChoice("Okay, guess I'll go looking then!", -1), new DialogueChoice("Okay, how much do I need?", 6), byeThen }) }, 
                     { 6, new("I need 1 piece of each for either gloves or boots, 2 pieces for a hat, 3 for leggings, and 4 of each for a top.", new() { new DialogueChoice("(NEXT)", 7), byeThen }) }, 
                     { 7, new("I'll charge you 1000 coins for boots and gloves, 6000 for a hat, 32000 for leggings, and 37000 for a top.", new() { new DialogueChoice("Okay, guess I'll go looking then!", -1), byeThen }) },
                     { 8, new("Certainly, what would you like me to make?", new() { 
                         new DialogueChoice("Split-bark gauntlets", 9, new() { new("Item", 1, "bark", true), new("Item", 1, "clothFine", true), new("Item", 1000, "Gold", true)}, true), 
                         new DialogueChoice("Split-bark boots", 10, new() { new("Item", 1, "bark", true), new("Item", 1, "clothFine", true), new("Item", 1000, "Gold", true)}, true),
                         new DialogueChoice("Split-bark helm", 11, new() { new("Item", 2, "bark", true), new("Item", 2, "clothFine", true), new("Item", 6000, "Gold", true)}, true), 
                         new DialogueChoice("Split-bark legs", 12, new() { new("Item", 3, "bark", true), new("Item", 3, "clothFine", true), new("Item", 32000, "Gold", true)}, true), 
                         new DialogueChoice("Split-bark body", 13, new() { new("Item", 4, "bark", true), new("Item", 4, "clothFine", true), new("Item", 37000, "Gold", true)}, true),   
                         byeThen 
                     }) },
                     { 9, new("Great, here you go! Do you want more?", new() { new DialogueChoice("(RETURN)", 8), byeThen }, items: new() { "gauntletsSplitbark,1" }) },
                     { 10, new("Great, here you go! Do you want more?", new() { new DialogueChoice("(RETURN)", 8), byeThen }, items: new() { "bootsSplitbark,1" }) },
                     { 11, new("Great, here you go! Do you want more?", new() { new DialogueChoice("(RETURN)", 8), byeThen }, items: new() { "helmSplitbark,1" }) },
                     { 12, new("Great, here you go! Do you want more?", new() { new DialogueChoice("(RETURN)", 8), byeThen }, items: new() { "legsSplitbark,1" }) },
                     { 13, new("Great, here you go! Do you want more?", new() { new DialogueChoice("(RETURN)", 8), byeThen }, items: new() { "bodySplitbark,1" }) }
                }));

                toAdd.Add(new("Professor Onglewip", "mistWizOnglewip", new() { 
                     { 0, new("(Professor Onglewip is busy with his work)", new() { new DialogueChoice("Do you live here too?", 1), byeThen }) }, 
                     { 1, new("Oh no, I come from the Gnome Stronghold. I've been sent here by King Narnode to learn about human magics.", new() { new DialogueChoice("Where's this Gnome Stronghold?", 2), byeThen }) }, 
                     { 2, new("It's in the North West of the continent - a long way away. You should visit us there some time.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) },
                     { 3, new("The food's great and the company's delightful.", new() { new DialogueChoice("I'll try and make time for it. Sounds like a nice place.", 4), byeThen }) },
                     { 4, new("Well, it's full of gnomes. How much nicer could it be?", new() { byeThen }) } 
                }));

                toAdd.Add(new("Wizard Grayzag", "mistWizGrayzag", new() { { 0, new("Not now, I'm trying to concentrate on a very difficult spell!", new() { byeThen }) } }));

                toAdd.Add(new("Archmage Sedridor", "mistWizSedridor", new() { 
                     { 0, new("Welcome adventurer, to the world renowned Wizards' Tower, home to the Order of Wizards. How may I help you?", new() { new DialogueChoice("I'm just looking around.", 1), byeThen }) }, 
                     { 1, new("Well, take care adventurer. You stand in the ruins of the old destroyed Wizards' Tower. Strange and powerful magicks lurk here.", new() { byeThen }) }, 
                 
                }));

                toAdd.Add(new("Wizard Mizgog", "mistWizMizgog", new() { 
                     { 0, new("(Wizard Mizgog is distractedly rifling through this things looking for something)", new() { new DialogueChoice("Give me a quest!", 1, new() { new("QuestAt", -1, "MI_ImpCatcher")}), new DialogueChoice("I have all your beads.", 20, new() { new("QuestAt", 0, "MI_ImpCatcher"), new("Item", 1, "beadRed", true), new("Item", 1, "beadYellow", true), new("Item", 1, "beadWhite", true), new("Item", 1, "beadBlack", true)}), new DialogueChoice("I have some more beads for you.", 21, new() { new("QuestAt", 10, "MI_ImpCatcher"), new("Item", 1, "beadRed", true), new("Item", 1, "beadYellow", true), new("Item", 1, "beadWhite", true), new("Item", 1, "beadBlack", true)}), byeThen }) }, 
                     { 1, new("Give me a quest what?", new() { new DialogueChoice("Give me a quest please.", 10), new DialogueChoice("Give me a quest or else!", 2), new DialogueChoice("Just stop messing around and give me a quest!", 3), byeThen }) }, 
                     { 2, new("Or else what? You'll attack me? Hahaha!", new() { byeThen }) },
                     { 3, new("Ah now you're assuming I have one to give.", new() { byeThen }) },
                     { 10, new("Well seeing as you asked nicely... I could do with some help.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                     { 11, new("Wizard Grayzag next door decided he didn't like me so he enlisted an army of hundreds of imps.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                     { 12, new("The imps stole all sorts of my things. Mostly things I don't care about, just eggs and balls of string and such.", new() { new DialogueChoice("(NEXT)", 13), byeThen }) },
                     { 13, new("But they stole my four magical beads. There was a red one, a yellow one, a black one, and a white one.", new() { new DialogueChoice("(NEXT)", 14), byeThen }) },
                     { 14, new("These imps have now spread out all over the kingdom. Could you get my beads back for me?", new() { new DialogueChoice("[Q+] Imp Catcher: I'll try.", 15), new DialogueChoice("[Q+] Imp Catcher: Well this is a surprising turn of events!", 16, new() { new("Item", 1, "beadRed", false), new("Item", 1, "beadYellow", false), new("Item", 1, "beadWhite", false), new("Item", 1, "beadBlack", false) }), byeThen }) },
                     { 15, new("That's great, thank you.", new() { byeThen }, "MI_ImpCatcher", 0) },
                     { 16, new("What?", new() { new DialogueChoice("Well I just so happen to have all of those beads on me!", 17), byeThen }) },
                     { 17, new("Are you saying that you stole my beads all this time and I've been blaming these imps!?", new() { new DialogueChoice("No, not at all! I just found them throughout my travels and presumed somebody would need them at some point.", 18), byeThen }) },
                     { 18, new("Bah! Fine. Give them here.", new() { new DialogueChoice("(GIVE ITEMS)", 20, new() { new("Item", 1, "beadRed", true), new("Item", 1, "beadYellow", true), new("Item", 1, "beadWhite", true), new("Item", 1, "beadBlack", true) }), byeThen }) },
                     { 20, new("Excellent, these are my beads! If you happen to find them again bring them back and I'll give you another amulet.", new() { byeThen }, "MI_ImpCatcher", 10) },
                     { 21, new("Pesky imps, always taking my beads. Here's another amulet for your trouble, adventurer.", new() { byeThen }, items: new() { new("amuletAccuracy,1") }) }
                }));

                toAdd.Add(new("Father Aereck", "mistLumAereck", new() { 
                     { 0, new("Welcome to the church of holy Saradomin.", new() { new DialogueChoice("Who's Saradomin?", 1), new DialogueChoice("Nice place you've got here.", 11), new DialogueChoice("I'm looking for a quest!", 12), new DialogueChoice("I've lost the map of the swamps.", 19, new() { new("QuestPast", 0, "MI_RestlessGhost")}), new DialogueChoice("[Q] The Restless Ghost", 20, new() { new("QuestAt", 20, "MI_RestlessGhost"), new("NotItem", 1, "mistWizGhostSkull", false)}), new DialogueChoice("[Q] The Restless Ghost", 23, new() { new("QuestAt", 20, "MI_RestlessGhost"), new("Item", 1, "mistWizGhostSkull", false)}), byeThen }) }, 
                     { 1, new("Surely you have heard of the god, Saradomin?", new() { new DialogueChoice("(NEXT)", 2), byeThen }) }, 
                     { 2, new("He who creates the forces of goodness and purity in this world? I cannot believe your ignorance!", new() { new DialogueChoice("(NEXT)", 3), byeThen }) }, 
                     { 3, new("This is the god with more followers than any other! ... At least in this part of the world.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) }, 
                     { 4, new("He who created this world along with his brothers Guthix and Zamorak?", new() { new DialogueChoice("Oh, THAT Saradomin...", 5), new DialogueChoice("Oh, sorry. I'm not from this world.", 6), byeThen }) },  
                     { 5, new("There... is only one Saradomin...", new() { new DialogueChoice("Yeah... I, uh, thought you said something else.", -1), byeThen }) }, 
                     { 6, new("...", new() { new DialogueChoice("(NEXT)", 7), byeThen }) }, 
                     { 7, new("That's... strange.", new() { new DialogueChoice("(NEXT)", 8), byeThen }) }, 
                     { 8, new("I thought things not from this world were all.. You know. Slime and tentacles.", new() { new DialogueChoice("You don't understand. This is an online game!", 9), new DialogueChoice("I am - do you like my disguise?", 10), byeThen }) }, 
                     { 9, new("I... beg your pardon?", new() { new DialogueChoice("Nevermind.", -1), byeThen }) },
                     { 10, new("Aargh! Avaunt foul creature from another dimension! Avaunt! Begone in the name of Saradomin!", new() { new DialogueChoice("Ok, ok, I was only joking...", -1), byeThen }) }, 
                     { 11, new("It is, isn't it? It was built over 230 years ago.", new() { byeThen }) },    
                     { 12, new("That's lucky, I need someone to do a quest for me.", new() { new DialogueChoice("[Q+] The Restless Ghost", 13), byeThen }) }, 
                     { 13, new("Thank you. The problem is, there is a ghost in the church graveyard. I would like you to get rid of it.", new() { new DialogueChoice("(NEXT)", 14), byeThen }) }, 
                     { 14, new("If you need any help, my friend Father Urhney is an expert on ghosts.", new() { new DialogueChoice("(NEXT)", 15), byeThen }) },
                     { 15, new("I believe he is currently living as a hermit in Lumbridge swamp. He has a little shack in the south of the swamps.", new() { new DialogueChoice("(NEXT)", 16), byeThen }) }, 
                     { 16, new("Exit the graveyard through the south to reach the swamp. I'm sure if you told him I sent you, he'd help.", new() { new DialogueChoice("(NEXT)", 17), byeThen }) },  
                     { 17, new("My name is Father Aereck by the way. Pleased to meet you.", new() { new DialogueChoice("Likewise.", 18), byeThen }) }, 
                     { 18, new("Take care travelling through the swamps, I have heard they can be dangerous and confusing. Take this map to navigate.", new() { byeThen }, "MI_RestlessGhost", 0, new() { new("mapLumbridgeSwamp,1") }) }, 
                     { 19, new("Fortunately I can draw them from memory, so that isn't much of a problem. Here's another map for you.", new() { byeThen }, items: new() { new("mapLumbridgeSwamp,1") }) }, 
      
                     { 20, new("Have you got rid of the ghost yet?", new() { new DialogueChoice("I've found out that the ghost's corpse has lots its skull. If I can find the skull, the ghost should leave.", 21), byeThen }) }, 
                     { 21, new("That WOULD explain it. Hmmmmmm. Well, I haven't seen any skulls.", new() { new DialogueChoice("Yes, I think a warlock has stolen it.", 22), byeThen }) }, 
                     { 22, new("I hate warlocks. Ah well, good luck!", new() { byeThen }) }, 
                  
                     { 23, new("Have you got rid of the ghost yet?", new() { new DialogueChoice("I've finally found the ghost's skull!", 24), byeThen }) }, 
                     { 24, new("Great! Put it in the ghost's coffin and see what happens!", new() { byeThen }) }
                }));

                toAdd.Add(new("Father Urhney", "mistLumUrhney", new() { 
                     { 0, new("Go away! I'm meditating!", new() { new DialogueChoice("Well, that's friendly.", 1), new DialogueChoice("I've come to repossess your house.", 2), new DialogueChoice("Father Aereck sent me to talk to you.", 6), new DialogueChoice("I've lost the amulet of Ghostspeak.", 19, new() { new("QuestPast", 10, "MI_RestlessGhost")}), byeThen }) }, 
                     { 1, new("I SAID go AWAY!", new() { new DialogueChoice("Okay, okay... sheesh, what a grouch.", -1), byeThen }) }, 
                     { 2, new("Under what grounds???", new() { new DialogueChoice("Repeated failure on mortgage repayments.", 3), new DialogueChoice("I don't know. I just wanted this house.", 5), byeThen }) },
                     { 3, new("What? But... I don't have a mortgage! I built this house myself!", new() { new DialogueChoice("Sorry. I must have got the wrong address. All the houses look the same around here.", 4), byeThen }) }, 
                     { 4, new("What? What houses? What ARE you talking about???", new() { new DialogueChoice("Nevermind.", -1), byeThen }) }, 
                     { 5, new("Oh... go away and stop wasting my time!", new() { byeThen }) }, 
                     { 6, new("I suppose I'd better talk to you then. What problems has he got himself into this time?", new() { new DialogueChoice("He's got a ghost haunting his graveyard.", 9), new DialogueChoice("You mean he gets himself into lots of problems?", 7), byeThen }) },
                     { 7, new("Yeah. For example, when we were trainee priests he kept on getting stuck up bell ropes.", new() { new DialogueChoice("(NEXT)", 8), byeThen }) },
                     { 8, new("Anyway. I don't have time for chitchat. What's his problem THIS time?", new() { new DialogueChoice("He's got a ghost haunting his graveyard.", 9), byeThen }) },
                     { 9, new("Oh, the silly fool.", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                     { 10, new("I leave town for just five months, and ALREADY he can't manage.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                     { 11, new("(sigh)", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                     { 12, new("Well, I can't go back and exorcise it. I voewed not to leave this place until I had done two full years of prayer and meditation.", new() { new DialogueChoice("(NEXT)", 13), byeThen }) },
                     { 13, new("Tell you what I can do though; take this amulet.", new() { new DialogueChoice("(NEXT)", 14), byeThen }) },
                     { 14, new("It is an amulet of ghostspeak.", new() { new DialogueChoice("(NEXT)", 15), byeThen }) },
                     { 15, new("So called, because when you wear it you can speak to ghosts.", new() { new DialogueChoice("(NEXT)", 16), byeThen }) },
                     { 16, new("A lot of ghosts are doomed to be ghosts because they have left some important task uncompleted.", new() { new DialogueChoice("(NEXT)", 17), byeThen }) },
                     { 17, new("Maybe if you know what this task is, you can get rid of the ghost.", new() { new DialogueChoice("(NEXT)", 18), byeThen }) },
                     { 18, new("I'm not making any guarantees mind you, but it is the best I can do right now.", new() { new DialogueChoice("Thank you, I'll give it a try!", -1), byeThen }, "MI_RestlessGhost", 10, new() { new("amuletGhostspeak,1") }) },
                     { 19, new("How careless can you get? Those things aren't easy to come by you know! It's a good job I've got a spare.", new() { byeThen }, items: new() { new("amuletGhostspeak,1") }) }
                }));

                toAdd.Add(new("Restless ghost", "mistLumRestlessGhost", new() { 
                     { 0, new("(The ghost watches you but says nothing)", new() { new DialogueChoice("Hello ghost, how are you?", 1, new() { new("NotWearing", 1, "amuletGhostspeak") }), new DialogueChoice("Hello ghost, how are you?", 20, new() { new("Wearing", 1, "amuletGhostspeak"), new("QuestAt", 10, "MI_RestlessGhost") }), new DialogueChoice("Hello ghost, how are you?", 37, new() { new("Wearing", 1, "amuletGhostspeak"), new("QuestAt", 20, "MI_RestlessGhost"), new("NotItem", 1, "mistWizGhostSkull", false) }), new DialogueChoice("Hello ghost, how are you?", 41, new() { new("Wearing", 1, "amuletGhostspeak"), new("QuestAt", 20, "MI_RestlessGhost"), new("Item", 1, "mistWizGhostSkull", false) }), byeThen }) }, 
                     { 1, new("Wooo wooo wooooo!", new() { new DialogueChoice("Sorry, I don't speak ghost.", 2), new DialogueChoice("Ooh, THAT'S interesting.", 4), new DialogueChoice("Any hints where I can find some treasure?", 13), byeThen }) }, 
                     { 2, new("Woo woo?", new() { new DialogueChoice("Nope, still don't understand you.", 3), byeThen }) }, 
                     { 3, new("WOOOOOOOOO!", new() { new DialogueChoice("Nevermind.", -1), byeThen }) }, 
                     { 4, new("Woo wooo. Woooooooooooooooooo!", new() { new DialogueChoice("Did he really?", 5), new DialogueChoice("Yeah, that's what I thought.", 12), byeThen }) }, 
                     { 5, new("Woo.", new() { new DialogueChoice("My brother had EXACTLY the same problem.", 6), byeThen }) }, 
                     { 6, new("Woo Wooooo!", new() { new DialogueChoice("(NEXT)", 7), byeThen }) }, 
                     { 7, new("Wooooo Woo woo woo!", new() { new DialogueChoice("Goodbye. Thanks for the chat.", 15), new DialogueChoice("You'll have to give me the recipe some time...", 8), byeThen }) }, 
                     { 8, new("Wooooooo woo woooooooo.", new() { new DialogueChoice("Goodbye. Thanks for the chat.", 15), new DialogueChoice("Hmm... I'm not so sure about that.", 9), byeThen }) },
                     { 9, new("Wooo woo?", new() { new DialogueChoice("Well, if you INSIST.", 10), byeThen }) },
                     { 10, new("Wooooooooo!", new() { new DialogueChoice("Ah well, better be off now...", 11), byeThen }) },
                     { 11, new("Woo.", new() { new DialogueChoice("Bye", -1), byeThen }) },
                     { 12, new("Wooo woooooooooooooo...", new() { new DialogueChoice("Goodbye. Thanks for the chat.", 15), new DialogueChoice("Hmm... I'm not so sure about that.", 9), byeThen }) },
                     { 13, new("Wooooooo woo! Wooooo woo wooooo woowoowoo woo Woo wooo. Wooooo woo woo? Woooooooooooooooooo!", new() { new DialogueChoice("Sorry, I don't speak ghost.", 2), new DialogueChoice("Thank you. You've been very helpful.", 14), byeThen }) },
                     { 14, new("Wooooooo.", new() { byeThen }) },
                     { 15, new("Wooo wooo?", new() { byeThen }) },
                     // Okay that was all super dumb but included for posterity, on to the actual important dialogue
                     { 20, new("Not very good actually.", new() { new DialogueChoice("What's the problem then?", 21), byeThen }) },
                     { 21, new("Did you just understand what I said???", new() { new DialogueChoice("Yep, now tell me what the problem is.", 31), new DialogueChoice("No, you sound like you're speaking nonsense to me.", 23), new DialogueChoice("Wow, this amulet works!", 22), byeThen }) },
                     { 22, new("Oh! It's your amulet that's doing it! I did wonder. I don't suppose you can help me? I don't like being a ghost.", new() { new DialogueChoice("Yes, okay. DO you know why you're a ghost?", 27), new DialogueChoice("No, you're scary!", 28), byeThen }) },
                     { 23, new("Oh that's a pity. You got my hopes up there.", new() { new DialogueChoice("Yeah, it is a pity. Sorry about that.", 24), byeThen }) },
                     { 24, new("Hang on a second... you CAN understand me!", new() { new DialogueChoice("No I can't.", 25), new DialogueChoice("Yep, clever aren't I?", 26), byeThen }) },
                     { 25, new("Great. The first person I can speak to in ages... and they're a moron.", new() { byeThen }) },
                     { 26, new("I'm impressed. You must be very powerful. I don't suppose you can stop me being a ghost?", new() { new DialogueChoice("Yes, okay. Do you know WHY you're a ghost?", 27), byeThen }) },
                     { 27, new("Nope! I just know I can't do much of anything like this!", new() { byeThen }) },
                     { 28, new("Great.", new() { new DialogueChoice("(NEXT)", 29), byeThen }) },
                     { 29, new("The first person I can speak to in ages...", new() { new DialogueChoice("(NEXT)", 30), byeThen }) },
                     { 30, new("...and they're an idiot.", new() { byeThen }) },
                     { 31, new("WOW! This is INCREDIBLE! I didn't expect anyone to ever understand me again!", new() { new DialogueChoice("Okay, okay, I can understand you! But have you any idea WHY you're doomed to be a ghost?", 32), byeThen }) },
                     { 32, new("Well, to be honest... I'm not sure.", new() { new DialogueChoice("I've been told a certain task may need to be completed so you can rest in peace.", 33), byeThen }) },
                     { 33, new("I should think it is probably because a warlock has come along and stolen my skull.", new() { new DialogueChoice("(NEXT)", 34), byeThen }) },
                     { 34, new("If you look inside my coffin there, you'll find my corpse without a head on it.", new() { new DialogueChoice("Do you know where this warlock might be now?", 35), byeThen }) },
                     { 35, new("I think it was one of the warlocks who lives in the big tower by the sea south-west from here.", new() { new DialogueChoice("Okay. I will try to get the skull back for you, then you can rest in peace.", 36), byeThen }) },
                     { 36, new("Ooh, thank you. That would be such a great relief! It is so dull being a ghost...", new() { byeThen }, "MI_RestlessGhost", 20) },
                 
                     { 37, new("How are you doing finding my skull?", new() { new DialogueChoice("Sorry, I can't find it at the moment.", 38), byeThen }) },
                     { 38, new("Ah well. Keep on looking.", new() { new DialogueChoice("(NEXT)", 39), byeThen }) },
                     { 39, new("I'm pretty sure it's somewhere in the tower south-west from here.", new() { new DialogueChoice("(NEXT)", 40), byeThen }) },
                     { 40, new("There's a lot of levels to the tower, though. I suppose it might take a while to find.", new() { byeThen }) },

                     { 41, new("How are you doing finding my skull?", new() { new DialogueChoice("I have found it!", 42), byeThen }) },
                     { 42, new("Hurrah! Now I can stop being a ghost! You just need to put it in my coffin there, then I'll be free!", new() { byeThen }) }
                }) {
                    ReqToSee = new("QuestBelow", 30, "MI_RestlessGhost")
                });

                toAdd.Add(new("Doomsayer", "mistLumDoomsayer", new() { 
                    { 0, new("Dooooooom!", new() { new DialogueChoice("Where?", 1), byeThen }) },
                    { 1, new("All around us! I can feel it in the air, hear it on the wind, smell it... also in the air!", new() { new DialogueChoice("Is there anything we can do about this doom?", 2), byeThen }) },
                    { 2, new("This is nothing you need to do my friend! I am the Doomsayer, although my real title could be something like the Danger Tutor.", new() { new DialogueChoice("Danger Tutor?", 3), byeThen }) },
                    { 3, new("Yes! I roam the world sensing danger.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                    { 4, new("If I find a dangerous area, then I put up warning signs that will tell you what is so dangerous about that area.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                    { 5, new("Simply keep an eye out for the signs and the other eye out for DOOOOOOM!", new() { byeThen }) },
                }));

                toAdd.Add(new("Xenia", "mistLumXenia", new() { 
                    { 0, new("I'm glad you've come by. I need some help.", new() { new DialogueChoice("What help do you need?", 1), new DialogueChoice("Who are you?", 10), new DialogueChoice("How did you know who I am?", 13), byeThen }) },
                    { 1, new("Some cultists of Zamorak have gone into the catacombs with a prisoner. I don't know what they're planning, but I'm pretty sure it's not a tea party.", new() { new DialogueChoice("(NEXT)", 2), byeThen }) },
                    { 2, new("There are three of them, and I'm not as young as I was the last time I was here. I don't want to go down there without backup.", new() { new DialogueChoice("I'll help you.", 3), new DialogueChoice("I need to know more before I help you.", 4), new DialogueChoice("Who are you?", 10), new DialogueChoice("How did you know who I am?", 13), byeThen }) },
                    { 3, new("I knew you would! We've got not time to lose. You head down the stairs, and I'll follow.", new() { byeThen }, "MI_BloodPact", 0) },
                    { 4, new("Very wise. I got into a lot of trouble in my youth by rushing in without knowing a situation.", new() { new DialogueChoice("Tell me more about these cultists.", 5), new DialogueChoice("Who did they kidnap?", 6), new DialogueChoice("What's down there?", 7), new DialogueChoice("Is there a reward if I help you?", 8), new DialogueChoice("Enough questions.", 9), byeThen }) },
                    { 5, new("Lumbridge is a Saradominist town, but there will always be some people drawn to worship Zamorak. They must have found some ritual that they think will give them power over other people.", new() { new DialogueChoice("(BACK)", 4), byeThen }) },
                    { 6, new("A young woman named Ilona. She had just left Lumbridge to apprentice at the Wizards' Tower. They grabbed her on the road. Without training she didn't have a chance.", new() { new DialogueChoice("(BACK)", 4), byeThen }) },
                    { 7, new("The catacombs of Lumbridge Church. The dead of Lumbridge have been buried there since... well, for about forty years now.", new() { new DialogueChoice("(BACK)", 4), byeThen }) },
                    { 8, new("The cultists all have weapons, and you'll be able to keep them if we succeed. This adventure will also help to train your combat skills.", new() { new DialogueChoice("(BACK)", 4), byeThen }) },
                    { 9, new("So, will you help me, adventurer?", new() { new DialogueChoice("I'll help you.", 3), byeThen }) },
                    { 10, new("My name is Xenia. I'm an adventurer.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("I'm one of the old guard, I suppose. I helped found the Champions' Guild, and I've done a fair few quests in my time.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                    { 12, new("Now I'm starting to get a bit old for action, which is why I need your help.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 13, new("Oh, I have my ways. I get the feeling that you're one to watch; you could be quite the hero some day.", new() { new DialogueChoice("(BACK)", 0), byeThen }) }
                }, req: new("QuestAt", -1, "MI_BloodPact")));

                toAdd.Add(new("Xenia", "mistLumXenia1", new() { { 0, new("When you're ready, head down into the catacombs and I'll follow.", new() { byeThen }) } }, req: new("QuestAt", 0, "MI_BloodPact")));
                toAdd.Add(new("Xenia", "mistLumXenia2", new() { 
                    { 0, new("There's a guard in the room ahead. Together we should be able to take him out.", new() { new DialogueChoice("What's the plan of attack?", 1), new DialogueChoice("What's a blood pact?", 2), new DialogueChoice("Let's get on with this.", -1), byeThen }) },
                    { 1, new("It looks like the cultist has a bow. The best way to deal with someone with a ranged weapon is to get close to them and attack with melee.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 2, new("It's something Zamorakian cults do sometimes; a way of swearing loyalty to their leader.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) },
                    { 3, new("A blood pact doesn't have any real magical power, but that kind of thing can have great power over a person if they believe strongly enough.", new() { new DialogueChoice("(BACK)", 0), byeThen }) }    
                }, req: new("QuestAt", 10, "MI_BloodPact")));

                toAdd.Add(new("Xenia", "mistLumXenia3", new() { 
                    { 0, new("I'll follow you, but I'll stay out of combat. Return to me if you're wounded. I have some food to share.", new() { new DialogueChoice("Could I have some food?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), new DialogueChoice("What's a blood pact?", 10), new DialogueChoice("Are you going to be alright?", 12), byeThen }) },
                    { 9, new("Of course, here you go.", new() { new DialogueChoice("Could I have another?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), byeThen }, items: [ "meatCookedBeef" ]) },
                    { 10, new("It's something Zamorakian cults do sometimes; a way of swearing loyalty to their leader.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("A blood pact doesn't have any real magical power, but that kind of thing can have great power over a person if they believe strongly enough.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 12, new("Don't worry about me. I've survived worse wounds than this. I'm going to hang back from combat, but I'll be here to give you advice if you need it. I'm sure you can beat these cultists on your own.", new() { new DialogueChoice("(BACK)", 0), byeThen }) }    
                }, req: new("QuestAt", 20, "MI_BloodPact")));

                toAdd.Add(new("Xenia", "mistLumXenia4", new() {
                    { 0, new("The first cultist is defeated, but not dead. I'll leave it up to you how to deal with him.", new() { new DialogueChoice("Could I have some food?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), new DialogueChoice("What's a blood pact?", 10), new DialogueChoice("Are you going to be alright?", 12), byeThen }) },
                    { 9, new("Of course, here you go.", new() { new DialogueChoice("Could I have another?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), byeThen }, items: [ "meatCookedBeef" ]) },
                    { 10, new("It's something Zamorakian cults do sometimes; a way of swearing loyalty to their leader.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("A blood pact doesn't have any real magical power, but that kind of thing can have great power over a person if they believe strongly enough.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 12, new("Don't worry about me. I've survived worse wounds than this. I'm going to hang back from combat, but I'll be here to give you advice if you need it. I'm sure you can beat these cultists on your own.", new() { new DialogueChoice("(BACK)", 0), byeThen }) }    
                }, req: new("QuestAt", 30, "MI_BloodPact")));

                toAdd.Add(new("Xenia", "mistLumXenia5", new() { 
                    { 0, new("You'll need a ranged weapon before you can attack the second cultist.", new() { new DialogueChoice("Tell me more about ranged combat.", 1), new DialogueChoice("What's a blood pact?", 10), new DialogueChoice("Are you going to be alright?", 12), new DialogueChoice("I can handle this.", -1), byeThen }) },
                    { 1, new("In order to use ranged combat, you'll need to wield a ranged weapon.", new() { new DialogueChoice("(NEXT)", 2), byeThen }) },
                    { 2, new("For most weapons you'll also need ammunition, but if you use a chargebow you'll always be able to fire low power magical arrows.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) },
                    { 3, new("After that it's easy; just attack your enemy.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                    { 4, new("Ranged combat is good against magic users. It's not so good against melee fighters, since projectiles have trouble getting through heavy armor.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 10, new("It's something Zamorakian cults do sometimes; a way of swearing loyalty to their leader.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("A blood pact doesn't have any real magical power, but that kind of thing can have great power over a person if they believe strongly enough.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 12, new("Don't worry about me. I've survived worse wounds than this. I'm going to hang back from combat, but I'll be here to give you advice if you need it. I'm sure you can beat these cultists on your own.", new() { new DialogueChoice("(BACK)", 0), byeThen }) }    
                }, req: new("QuestAt", 40, "MI_BloodPact")));

                toAdd.Add(new("Xenia", "mistLumXenia6", new() { 
                    { 0, new("You'll need to deal with the second cultist. You should be able to get to the other side of the gallery by operating that winch.", new() { new DialogueChoice("Could I have some food?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), new DialogueChoice("What's a blood pact?", 10), new DialogueChoice("Are you going to be alright?", 12), byeThen }) },
                    { 9, new("Of course, here you go.", new() { new DialogueChoice("Could I have another?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), byeThen }, items: [ "meatCookedBeef" ]) },
                    { 10, new("It's something Zamorakian cults do sometimes; a way of swearing loyalty to their leader.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("A blood pact doesn't have any real magical power, but that kind of thing can have great power over a person if they believe strongly enough.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 12, new("Don't worry about me. I've survived worse wounds than this. I'm going to hang back from combat, but I'll be here to give you advice if you need it. I'm sure you can beat these cultists on your own.", new() { new DialogueChoice("(BACK)", 0), byeThen }) }    
                }, req: new("QuestAt", 50, "MI_BloodPact")));

                toAdd.Add(new("Xenia", "mistLumXenia7", new() { 
                    { 0, new("To cast combat spells, you need runes, and optionally a magic weapon to improve your power.", new() { new DialogueChoice("Tell me more about magic.", 1), new DialogueChoice("Could I have some mind runes?", 8, new() { new("NotItem", 10, "runeMind" )}, true), new DialogueChoice("Could I have some food?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), new DialogueChoice("What's a blood pact?", 10), new DialogueChoice("Are you going to be alright?", 12), new DialogueChoice("Who was Dragith Nurn?", 13), byeThen }) },
                    { 1, new("Magic is based on runes. The runes contain magical power, and you can cast spells by combining them in specific ways.", new() { new DialogueChoice("(NEXT)", 2), byeThen }) },
                    { 2, new("It's like cooking: the runes are ingredients, and a spell is a recipe.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) },
                    { 3, new("Most combat spells require elemental runes and catalytic runes. A simple spell like Air Strike uses air and mind runes, while Water Strike needs air, mind, *and* water runes.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                    { 4, new("Some magical staves act as an infinite supply of a certain type of rune. For example, casting Air Strike normally requires an air rune, but if you're holding an Air staff you can cast it with only a mind rune.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                    { 5, new("This cultist's staff is one such staff, providing unlimited air runes. If you haven't got any mind runes, I can give you some.", new() { new DialogueChoice("(NEXT)", 6), byeThen }) },
                    { 6, new("Magic is very useful against melee fighters. Watch out for rangers, though; arrows go straight through mage robes.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 8, new("Of course, here you go.", new() { new DialogueChoice("(BACK)", 0), byeThen }, items: [ "runeMind,20" ]) },
                    { 9, new("Of course, here you go.", new() { new DialogueChoice("Could I have another?", 9, new() { new("NotItem", 1, "meatCookedBeef" )}, true), byeThen }, items: [ "meatCookedBeef" ]) },
                    { 10, new("It's something Zamorakian cults do sometimes; a way of swearing loyalty to their leader.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("A blood pact doesn't have any real magical power, but that kind of thing can have great power over a person if they believe strongly enough.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 12, new("Don't worry about me. I've survived worse wounds than this. I'm going to hang back from combat, but I'll be here to give you advice if you need it. I'm sure you can beat these cultists on your own.", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                    { 13, new("Dragith Nurn? I was hoping he wouldn't come into this.", new() { new DialogueChoice("(NEXT)", 14), byeThen }) },
                    { 14, new("Listen... I met Dragith Nurn once. I was just starting out as an adventurer, and he was an old man. I discovered his secret...", new() { new DialogueChoice("(BACK)", 0), byeThen }) }
                }, req: new("QuestAt", 60, "MI_BloodPact")));

                toAdd.Add(new("Xenia", "mistLumXenia8", new() { 
                    { 0, new("Thank the gods. We're out. I thought I was going to die down there.", new() { new DialogueChoice("(NEXT)", 1), byeThen }, altSpeaker: "Ilona") },
                    { 1, new("You saved my life, whoever you are. Thank you.", new() { new DialogueChoice("(NEXT)", 2), byeThen }, altSpeaker: "Ilona") },
                    { 2, new("Well, adventurer, it looks like you have prevailed. You should keep the cultists' weapons as a reward.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) },
                    { 3, new("Is there anything you want to ask before you go to seek out new adventures?", new() { new DialogueChoice("I'm ready for my reward.", 4), new DialogueChoice("What should I do now?", 5), new DialogueChoice("You weren't really wounded, were you?", 7), new DialogueChoice("What will happen in the catacombs now?", 11), byeThen }) },
                    { 4, new("Farewell, adventurer.", new() { byeThen }, acts: [ new("Quest", "MI_BloodPact", "", 100) ] ) },
                    { 5, new("The cultists' ritual opened the lower level of the catacombs, which is swarming with undead creatures. If you want to practice your combat skills, you could go down there.", new() { new DialogueChoice("(NEXT)", 6), byeThen }) },
                    { 6, new("Alternatively, if you explore the world I'm sure you'll find other quests to do.", new() { new DialogueChoice("(BACK)", 3), byeThen }) },
                    { 7, new("Very perceptive, adventurer. I was wounded, but not as badly as I looked. I took the opportunity to see how you would fare.", new() { new DialogueChoice("You risked that woman's life for the sake of a test?", 8), new DialogueChoice("You risked my life for the sake of a test?", 9), new DialogueChoice("So how did I do?", 10), new DialogueChoice("(BACK)", 3), byeThen }) },
                    { 8, new("I was prepared to step in and rescue her if you failed. You are more than capable. The world needs heroes. I was a hero, once, but I'm not getting any younger. I need to make sure the new generation has its own heroes.", new() { new DialogueChoice("(BACK)", 7), byeThen }) },
                    { 9, new("You're a born adventurer. I can practically smell it on you. People like you have a habit of coming back from things that would kill an ordinary person.", new() { new DialogueChoice("(BACK)", 7), byeThen }) },
                    { 10, new("Very well indeed. You're a hero. You're exactly the sort of person the world needs. I'm glad I met you.", new() { new DialogueChoice("(BACK)", 7), byeThen }) },
                    { 11, new("Reese managed to complete the ritual with his own death. He's opened the staircase to the nest of undead creatures in the lower level of the catacombs.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                    { 12, new("Without a necromancer to control them, the creatures won't leave the tomb. I'll warn Father Aereck not to let people go down there.", new() { new DialogueChoice("(NEXT)", 13), byeThen }) },
                    { 13, new("You're an adventurer, though. If you want to, you can venture into the tomb and fight the creatures.", new() { new DialogueChoice("(BACK)", 3), byeThen }) }
                }, req: new("QuestAt", 90, "MI_BloodPact")));
                
                toAdd.Add(new("Xenia", "mistLumXenia9", new() { 
                    { 0, new("Hello again, adventurer.", new() { 
                        new DialogueChoice("I've got a question about my adventure in the catacombs...", 6), 
                        new DialogueChoice("I lost Kayle's chargebow", 20, [ new("ItemNotOwned", 1, "chargebowKayle") ]), 
                        new DialogueChoice("I lost Caitlin's staff", 21, [ new("ItemNotOwned", 1, "staffCaitlin") ]), 
                        new DialogueChoice("I lost Reese's sword", 22, [ new("ItemNotOwned", 1, "swordReese") ]), 
                        new DialogueChoice("I found a jade statuette", 23, [ new("Item", 1, "statuetteJade", true), new("Data", 0, "SoldJadeStatuette", misc3: "equals", summ: "Have not already sold a jade statuette.") ], true), 
                        new DialogueChoice("I found a topaz statuette", 24, [ new("Item", 1, "statuetteTopaz", true), new("Data", 0, "SoldTopazStatuette", misc3: "equals", summ: "Have not already sold a topaz statuette.") ], true),  
                        new DialogueChoice("I found a sapphire statuette", 25, [ new("Item", 1, "statuetteSapphire", true), new("Data", 0, "SoldSapphireStatuette", misc3: "equals", summ: "Have not already sold a sapphire statuette.") ], true),  
                        new DialogueChoice("I found an emerald statuette", 26, [ new("Item", 1, "statuetteEmerald", true), new("Data", 0, "SoldEmeraldStatuette", misc3: "equals", summ: "Have not already sold an emerald statuette.") ], true),  
                        new DialogueChoice("I found a ruby statuette", 27, [ new("Item", 1, "statuetteRuby", true), new("Data", 0, "SoldRubyStatuette", misc3: "equals", summ: "Have not already sold a ruby statuette.") ], true), 
                        new DialogueChoice("I found a diamond statuette", 28, [ new("Item", 1, "statuetteDiamond", true), new("Data", 0, "SoldDiamondStatuette", misc3: "equals", summ: "Have not already sold a diamond statuette.") ], true), 
                        byeThen 
                    }) },
                    { 4, new("It's something Zamorakian cults do sometimes; a way of swearing loyalty to their leader.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                    { 5, new("A blood pact doesn't have any real magical power, but that kind of thing can have great power over a person if they believe strongly enough.", new() { new DialogueChoice("(BACK)", 6), byeThen }) },
                    { 6, new("Is there anything you want to ask before you go to seek out new adventures?", new() { new DialogueChoice("You weren't really wounded, were you?", 7), new DialogueChoice("What will happen in the catacombs now?", 11), new DialogueChoice("What is a blood pact?", 4), new DialogueChoice("Who was Dragith Nurn?", 14), byeThen }) },
                    { 7, new("Very perceptive, adventurer. I was wounded, but not as badly as I looked. I took the opportunity to see how you would fare.", new() { new DialogueChoice("You risked that woman's life for the sake of a test?", 8), new DialogueChoice("You risked my life for the sake of a test?", 9), new DialogueChoice("So how did I do?", 10), new DialogueChoice("(BACK)", 6), byeThen }) },
                    { 8, new("I was prepared to step in and rescue her if you failed. You are more than capable. The world needs heroes. I was a hero, once, but I'm not getting any younger. I need to make sure the new generation has its own heroes.", new() { new DialogueChoice("(BACK)", 7), byeThen }) },
                    { 9, new("You're a born adventurer. I can practically smell it on you. People like you have a habit of coming back from things that would kill an ordinary person.", new() { new DialogueChoice("(BACK)", 6), byeThen }) },
                    { 10, new("Very well indeed. You're a hero. You're exactly the sort of person the world needs. I'm glad I met you.", new() { new DialogueChoice("(BACK)", 7), byeThen }) },
                    { 11, new("Reese managed to complete the ritual with his own death. He's opened the staircase to the nest of undead creatures in the lower level of the catacombs.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                    { 12, new("Without a necromancer to control them, the creatures won't leave the tomb. I'll warn Father Aereck not to let people go down there.", new() { new DialogueChoice("(NEXT)", 13), byeThen }) },
                    { 13, new("You're an adventurer, though. If you want to, you can venture into the tomb and fight the creatures.", new() { new DialogueChoice("(BACK)", 6), byeThen }) },
                    { 14, new("Dragith Nurn was a wizard. He studied at the Wizards' Tower, but he also studied the dark art, necromancy, on his own.", new() { new DialogueChoice("(NEXT)", 15), byeThen }) },
                    { 15, new("He had a secret magical workshop beneath Lumbridge. He would steal bodies from the graveyard and perform experiments on them.", new() { new DialogueChoice("(NEXT)", 16), byeThen }) },
                    { 16, new("Necromancy was like an addiction for him. When I met him he was very troubled; very conflicted. I convinced him to put an end to it all.", new() { new DialogueChoice("(NEXT)", 17), byeThen }) },
                    { 17, new("He couldn't destroy all the undead he had created - not permanently - so he trapped them all in the lower level of his workshop and sealed it off. He coverted the upperlevel into these catacombs.", new() { new DialogueChoice("(NEXT)", 18), byeThen }) },
                    { 18, new("Everyone thinks Dragith Nurn is buried here in this tomb, but he isn't. He built the tomb to hide the entrance to the lower level.", new() { new DialogueChoice("(NEXT)", 19), byeThen }) },
                    { 19, new("Dragith Nurn is still down there. He knew that when he died he would rise again as a monster, so he sealed himself in with his creatures.", new() { new DialogueChoice("(BACK)", 6), byeThen }) },
                    { 20, new("Yes, one of my contacts in the Champions' Guild found it and returned it to me. Here you go.", new() { byeThen }, items: [ "chargebowKayle" ]) },
                    { 21, new("Yes, one of my contacts in the Champions' Guild found it and returned it to me. Here you go.", new() { byeThen }, items: [ "staffCaitlin" ]) },
                    { 22, new("Yes, one of my contacts in the Champions' Guild found it and returned it to me. Here you go.", new() { byeThen }, items: [ "swordReese" ]) },
                    { 23, new("Excellent find! Here's a hundred gold for your trouble.", new() { byeThen }, items: [ "coins,100" ], acts: [ new("Data", "SoldJadeStatuette", "set", 1 )] )},
                    { 24, new("Excellent find! Here's two hundred gold for your trouble.", new() { byeThen }, items: [ "coins,200" ], acts: [ new("Data", "SoldTopazStatuette", "set", 1 )] )},
                    { 25, new("Excellent find! Here's three hundred gold for your trouble.", new() { byeThen }, items: [ "coins,300" ], acts: [ new("Data", "SoldSapphireStatuette", "set", 1 )] )},
                    { 26, new("Excellent find! Here's four hundred gold for your trouble.", new() { byeThen }, items: [ "coins,400" ], acts: [ new("Data", "SoldEmeraldStatuette", "set", 1 )] )},
                    { 27, new("Excellent find! Here's five hundred gold for your trouble.", new() { byeThen }, items: [ "coins,500" ], acts: [ new("Data", "SoldRubyStatuette", "set", 1 )] )},
                    { 28, new("Excellent find! Here's a thousand gold for your trouble.", new() { byeThen }, items: [ "coins,1000" ], acts: [ new("Data", "SoldDiamondStatuette", "set", 1 )] )}
                }, req: new("QuestAt", 100, "MI_BloodPact")));

                toAdd.Add(new("Kayle (defeated)", "mistLumKayle", new() { 
                    { 0, new("Are - are you going to kill me?", new() { new DialogueChoice("I have some questions.", 1), new DialogueChoice("Yes. Now die!", -1) { Cutscenes = [ "MI_BloodPact3" ]}, new DialogueChoice("No. Just give me your stuff and get out of here.", -1) { Cutscenes = [ "MI_BloodPact3a" ]},  byeThen }) },
                    { 1, new("Y-yes! I'll tell you anything!", new() { new DialogueChoice("Who are you?", 2), new DialogueChoice("Who are the others?", 3), new DialogueChoice("What were you planning to do down here?", 5), new DialogueChoice("Enough questions.", 0), byeThen }) },
                    { 2, new("I- My name's Kayle. I'm a ranger. Well, I'd been practicing the chargebow... I guess I wasn't as good as I'd thought.", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                    { 3, new("Reese is the leader. All this, the blood pact, it was his idea. He doesn't know magic but he's a strong fighter.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                    { 4, new("Caitlin is a wizard. She was a student at the Wizards' Tower, but she left. She wanted to study dark magic.", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                    { 5, new("I- I don't know! Honestly!", new() { new DialogueChoice("(NEXT)", 6), byeThen }) },
                    { 6, new("Listen... Reese used to be an acolyte at the church here. He discovered something about these catacombs; I don't know what. Something about how they were built, I think.", new() { new DialogueChoice("(NEXT)", 7), byeThen }) },
                    { 7, new("Caitlin was a student at the Wizards' Tower. She found something too, in the ruins of the old tower, from back when Zamorakian wizards used it.", new() { new DialogueChoice("(NEXT)", 8), byeThen }) },
                    { 8, new("Caitlin and Reese put what they'd found together. They said they'd discovered a ritual they could perform, something that could give them power over life and death.", new() { new DialogueChoice("(NEXT)", 9), byeThen }) },
                    { 9, new("We made a blood pact, the three of us. So that we'd be in it together, whatever happened.", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                    { 10, new("Then we kidnapped Ilona. She was another apprentice from the Wizards' Tower, someone Caitlin had known there.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("Reese and Caitlin are going down there to perform the ritual. I don't - I don't know what it involves.", new() { new DialogueChoice("And you just went along with this?", 12), byeThen }) },
                    { 12, new("The blood pact! We'd made a blood pact, and Reese said that bound me to him. It meant I had to do anything he said. He... he said he could curse me.", new() { new DialogueChoice("(BACK)", 1), byeThen }) }
                }, req: new("QuestAt", 30, "MI_BloodPact")));

                toAdd.Add(new("Caitlin (defeated)", "mistLumCaitlin", new() { 
                    { 0, new("What are you waiting for? Finish me!", new() { new DialogueChoice("I have some questions.", 1), new DialogueChoice("Time for you to die!", -1) { Cutscenes = [ "MI_BloodPact4" ]}, new DialogueChoice("I'm not killing you. Just give me your stuff and get out of here.", -1) { Cutscenes = [ "MI_BloodPact4a" ]},  byeThen }) },
                    { 1, new("What?", new() { new DialogueChoice("Who are you?", 2), new DialogueChoice("Who are the others?", 3), new DialogueChoice("What were you planning to do down here?", 6), new DialogueChoice("Enough questions.", 0), byeThen }) },
                    { 2, new("I am the wizard Caitlin.", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                    { 3, new("Reese used to be an acolyte at Lumbridge Church. He and I came up with this whole idea.", new() { new DialogueChoice("(NEXT)", 4, new() { new("Data", 1, "KayleSpared", misc3: "equals")}), new DialogueChoice("(NEXT)", 5, new() { new("Data", -1, "KayleSpared", misc3: "equals")}), byeThen }) },
                    { 4, new("Kayle's just some idiot Reese roped into helping us. I heard you let him go. It's more than he deserved. He's useless.", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                    { 5, new("Kayle was just some idiot Reese roped into helping us. I heard you killed him and I can't say I mind. If I'd had my way we'd have used him as the sacrifice.", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                    { 6, new("Idiot hero! You don't even know what this place is, do you?", new() { new DialogueChoice("(NEXT)", 7), byeThen }) },
                    { 7, new("This is the tomb of Dragith Nurn!", new() { new DialogueChoice("(NEXT)", 8), byeThen }) },
                    { 8, new("Dragith Nurn was a necromancer. He lived in Lumbridge decades ago.", new() { new DialogueChoice("(NEXT)", 9), byeThen }) },
                    { 9, new("He kept his necromancy secret. Everyone thought he was just a wealthy nobleman and wizard. He paid for these catacombs to be built, and he's interred here in a special tomb.", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                    { 10, new("Reese was an acolyte here at the church. He learned the Dragith Nurn was buried here.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                    { 11, new("I was a student at the Wizards' Tower. In the library, I discovered a note left by Dragith Nurn.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                    { 12, new("The body of a necromancer contains powerful magic. We learned we could perform a ritual on his tomb to unlock the secrets of his work.", new() { new DialogueChoice("(NEXT)", 13), byeThen }) },
                    { 13, new("We would have gained mastery over life and death!", new() { new DialogueChoice("(BACK)", 1), byeThen }) }
                }, req: new("QuestAt", 50, "MI_BloodPact")));

                 toAdd.Add(new("Reese (defeated)", "mistLumReese", new() { 
                    { 0, new("You've beaten me, adventurer. Now strike the final blow! End the blood pact in this tomb.", new() { new DialogueChoice("I have some questions.", 1), new DialogueChoice("Time for you to die!", -1) { Cutscenes = [ "MI_BloodPact6" ]}, new DialogueChoice("I'm not killing you. Give me your stuff and get out of here.", -1) { Cutscenes = [ "MI_BloodPact6a" ]},  byeThen }) },
                    { 1, new("Ask your questions.", new() { new DialogueChoice("Who are you?", 2), new DialogueChoice("Who are the others?", 3), new DialogueChoice("What were you planning to do down here?", 4), new DialogueChoice("Enough questions.", 0), byeThen }) },
                    { 2, new("I am Reese! Warrior of Zamorak and leader of the blood pact!", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                    { 3, new("Faithful servants of Zamorak! He is the god of chaos and destruction. We bound ourselves to his service!", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                    { 4, new("End Saradomin's dominance over Lumbridge! The tyrant god shall fall.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                    { 5, new("With the blood pact, and the power of the tomb of Dragith Nurn, we would send an army of the dead to claim this town for Zamorak!!", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                }, req: new("QuestAt", 70, "MI_BloodPact")));


                toAdd.Add(new("Olivia", "mistDrayOlivia", new() { 
                    { 0, new("Would you like to trade in seeds?", new() { new DialogueChoice("Yes", -1), new DialogueChoice("No, thanks.", -1), new DialogueChoice("Where do I get rarer seeds from?", 1), byeThen }) } ,
                    { 1, new("The Master Farmers usually carry a few rare seeds around with them, although I don't know if they'd want to part with them for any price to be honest.", new() { byeThen }) }
                }));

                toAdd.Add(new("Diango", "mistDrayDiango", new() { { 0, new("Howdy there partner! Could I interest you in some trinkets?", new() { new DialogueChoice("Yes", -1), new DialogueChoice("No, thanks.", -1), byeThen }) } }));
                
                toAdd.Add(new("A Tree?", "mistDrayTree", new() { 
                    { 0, new("(While at first it seemed like just a tree, there is clearly a man visible in the branches)", new() { new DialogueChoice("Hello?", 1, [ new("NotItem", 1, "stew", true) ]), new DialogueChoice("Hello?", 11, [ new("Item", 1, "stew", false) ]), byeThen }) } ,
                    { 1, new("Sshhh! What do you want?", new() { new DialogueChoice("Well, it's not every day you see a man up a tree.", 1), byeThen }, altSpeaker: "Guard") },
                    { 2, new("I'm trying to observe a suspect. Leave me alone!", new() { new DialogueChoice("What's all this about?", 3, [ new("Data", 0, "KnowsAboutBankRobbery", false, "equals", "Has not learned about the Draynor Village Bank Robbery.")]), new DialogueChoice("This is about the bank robbery, right?", 5, [ new("Data", 1, "KnowsAboutBankRobbery", false, "equals", "Has learned about the Draynor Village Bank Robbery.")]), new DialogueChoice("You're not being very subtle up there.", 7, [ new("Data", 1, "KnowsAboutBankRobbery", false, "equals", "Has learned about the Draynor Village Bank Robbery.")]), new DialogueChoice("Can I do anything to help?", 9, [ new("Data", 1, "KnowsAboutBankRobbery", false, "equals", "Has learned about the Draynor Village Bank Robbery.")]), byeThen }, altSpeaker: "Guard") },
                    { 3, new("Hadn't you heard? you'd better go and talk to the other guard, the one by the bank door. He'll tell you all about it.", new() { new DialogueChoice("(NEXT)", 4), byeThen }, altSpeaker: "Guard") },
                    { 4, new("Go on, ask him what's wrong with the bank wall. He loves when people ask him that.", new() { new DialogueChoice("Okay, if you say so...", -1), byeThen }, altSpeaker: "Guard") },
                    { 5, new("Yes, that's right. We're keeping the suspect under tight observation for the moment.", new() { new DialogueChoice("Can't you just... I dunno... arrest him?", 6), byeThen }, altSpeaker: "Guard") },
                    { 6, new("I'm not meant to discuss the case. You know what confidentiality rules are like.", new() { new DialogueChoice("Fair enough.", -1), byeThen }, altSpeaker: "Guard") },
                    { 7, new("I'd be doing a lot better if nits like you didn't come crowding around me all day!", new() { new DialogueChoice("But your legs are hanging down!", 8), byeThen }, altSpeaker: "Guard") },
                    { 8, new("Go away!", new() { new DialogueChoice("Please yourself!", -1), byeThen }, altSpeaker: "Guard") },
                    { 9, new("That's very kind of you. I'd rather like a nice bowl of stew, if you could fetch me one. I don't get many meal breaks.", new() { new DialogueChoice("You want a bowl of stew?", 10), byeThen }, altSpeaker: "Guard") },
                    { 10, new("If you wouldn't mind...", new() { new DialogueChoice("I'll think about it!", -1), byeThen }, altSpeaker: "Guard") },
                    { 11, new("Yes, what do you... I say, is that stew for me?", new() { new DialogueChoice("Ok, take the stew!", 12, [ new("Item", 1, "stew", true)]), new DialogueChoice("No, I want to keep this stew!", 13), byeThen }, altSpeaker: "Guard") },
                    { 12, new("Gosh, that's very kind of you! Here, have a few coins for your trouble...", new() { byeThen }, items: [ "Gold,30"], altSpeaker: "Guard") },
                    { 13, new("Fair enough. But if you change your mind, I'll probably still be up here.", new() { byeThen }, altSpeaker: "Guard") }
                }));

                toAdd.Add(new("Fortunato", "mistDrayFortunato", new() { 
                    { 0, new("Can I help you at all?", new() { new DialogueChoice("Yes, what are you selling?", -1), new DialogueChoice("Not at the moment.", 1), byeThen }) },
                    { 1, new("Then move along, you filthy ragamuffin, I have customers to serve!", new() { byeThen }) }
                }));

                toAdd.Add(new("Town Crier", "townCrier", new() { 
                    { 0, new("Hello citizen!", new() { new DialogueChoice("Yes", 1), new DialogueChoice("See you later.", -1), byeThen }) } ,
                    { 1, new("I'm a Town Crier. It's my job to let people know of any recent news. After all, there's all sorts of things happening around here.", new() { new DialogueChoice("I see. See you later.", -1), byeThen }) }
                }));

                toAdd.Add(new("Martin the Master Gardener", "mistDrayMartin", new() { 
                    { 0, new("Hello there! Nice weather we've been having. Perfect for a day outdoors!", new() { new DialogueChoice("Can I buy a Skillcape of Farming from you?", 1, [ new("Skill", 99, "Farming") ]), byeThen }) },
                    { 1, new("Of course, fellow farmer. If you wear this cape you'll receive increased yields when you harvest plants. That'll be 99,000 coins.", new() { new DialogueChoice("I'm not paying that!", 2), new DialogueChoice("Sure, not many people own one.", 3, [ new("Item", 99000, "Gold") ]), byeThen }) } ,
                    { 2, new("No skin off my teeth, but if you change your mind, the price will still be the same.", new() { byeThen }) },
                    { 3, new("That's true; us Master Farmers are a unique breed.", new() {  byeThen }, items: [ "capeSkillFarming" ]) }  
                }, 38, 43, 3) { 
                    PickpocketLoot = new() { 
                        DropTables.AllotmentSeeds.But(1000.0/485.0),
                        DropTables.HopSeeds.But(1000.0/243.0),
                        DropTables.FlowerSeeds.But(1000.0/122.0),
                        DropTables.BushSeeds.But(1000.0/97.0),
                        DropTables.SpecialSeeds.But(1000.0/5.0),
                        DropTables.HerbSeeds.But(1000.0/48.0)
                    } 
                });

                toAdd.Add(new("Ned", "mistDrayNed1", new() { 
                    { 0, new("Why, hello there, young'un! Me friends call me Ned. I was a man of the sea, but it's past me now. Could I be making or selling you some rope?", new() { new DialogueChoice("Yes, one rope please. (16 gp)", 1, [ new("Item", 16, "Gold") ]), new DialogueChoice("Could you make me a rope with these? (4 balls of wool)", 1, [ new("Item", 4, "woolBall") ]), new DialogueChoice("Actually, could you make me a wig? (3 balls of wool)", 1, [ new("Item", 3, "woolBall") ]), byeThen }) },
                    { 1, new("Certainly! Here ye go.", new() { new DialogueChoice("Another, please. (16 gp)", 1, [ new("Item", 16, "Gold") ]), byeThen }, items: [ "rope" ]) },
                    { 2, new("Certainly! Here ye go.", new() { new DialogueChoice("Another, please. (4 balls of wool)", 2, [ new("Item", 4, "woolBall") ]), byeThen }, items: [ "rope" ]) },
                    { 3, new("Bit of a strange request, but nothing I can't manage! Here ye go.", new() { new DialogueChoice("Another, please. (3 balls of wool)", 3, [ new("Item", 4, "woolBall") ]), byeThen }, items: [ "princeAliWig" ]) }
                }));

                toAdd.Add(new("Treznor", "mistVarTreznor", new() { { 0, new("Feel free to grow a tree here if you like!", new() { byeThen }) } })); 


                toAdd.Add(new("Rat Burgiss", "mistVarBurgiss", new() { 
                    { 0, new("Oh, hello. I'd love to chat right now, but I'm a bit busy. Perhaps you could come back and chat another time?", new() { byeThen }) }
                }));

                toAdd.Add(new("Ali the Leaflet Dropper", "mistVarAliLeaflet", new() { 
                     { 0, new("I don't have time to talk right now! Ali Morrisane is paying me to hand out these flyers.", new() { new DialogueChoice("Who is Ali Morrisane?", 1), new DialogueChoice("What are the flyers for?", 3), new DialogueChoice("What is there to do round here, boy?", 9), byeThen }) }, 
                     { 1, new("Ali Morrisane is the greatest merchant in the east!", new() { new DialogueChoice("Were you paid to say that?", 2), byeThen }) },
                     { 2, new("Of course I was! You can find him on the north edge of town.", new() { byeThen }) },
                     { 3, new("Well, Ali Morrisane isn't too popular with the other traders in Al Kharid, mainly because he's from Pollnivneach and they feel he has no business trading in their town.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                     { 4, new("I think they're just sour because he's better at making money than them.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                     { 5, new("The flyer advertises the different shops you can find in Al Kharid.", new() { new DialogueChoice("(NEXT)", 6), byeThen }) },
                     { 6, new("It also entitles you to money off your next purchase in any of the shops listed on it. It's Ali's way of getting on the good side of the traders.", new() { new DialogueChoice("Which shops?", 7), byeThen }) },
                     { 7, new("Here! Take one and let me get back to work.", new() { new DialogueChoice("(NEXT)", 8), byeThen }, items: new() { "flyerAli,1" }) },
                     { 8, new("I still have hundreds of these flyers to hang out, I wonder if my boss would notice if I quietly dumped them somewhere?", new() { byeThen }) },
                     { 9, new("I'm very busy, so listen carefully! I shall say this only once.", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                     { 10, new("Apart from a busy and wonderous market place in Al Kharid to the south, there is the Emir's Arena to the south-east where you can challenge other players to a fight.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                     { 11, new("If you're here to make money, there is a mine to the south.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                     { 12, new("Watch out for scorpions though, they'll take a pop at you if you go too near them. To avoid them just follow the western fence as you travel south.", new() { new DialogueChoice("(NEXT)", 13), byeThen }) },
                     { 13, new("If you're in the mood for a little rest and relaxation, there are a couple of nice fishing spots south of the town.", new() { new DialogueChoice("Thanks for the help!", -1), byeThen }) }           
                }));

                toAdd.Add(new("Hunding", "mistBarbHunding", new() { 
                     { 0, new("(Hunding is standing vigil, looking out over the River Lum towards Varrock)", new() { new DialogueChoice("Hello.", 1), byeThen }) }, 
                     { 1, new("What are you doing in our village, outlander?", new() { new DialogueChoice("Nothing much.", 2), new DialogueChoice("I'm exploring.", 4), new DialogueChoice("I came to kill you all!", 3), byeThen }) },
                     { 2, new("Bah! Go down to the longhall, and there you will find excitement aplenty! Our finest warrior, Gunthor the Brave, will give you a rousing welcome!", new() { new DialogueChoice("I'll bear it in mind.", -1), byeThen }) },
                     { 3, new("Ho ho! Brave words indeed from an outerlander! Go down to the longhall and try it!", new() { byeThen }) }, 
                     { 4, new("Bah! You cannot hope to learn anything of us just by strolling through our village! We are an ancient tribe, our ways date back to the time before Avarrocka was founded!", new() { new DialogueChoice("Would you care to tell me more?", 6), new DialogueChoice("You look like a load of primitive savages.", 5), new DialogueChoice("I'm bored.", 2), byeThen }) },  
                     { 5, new("And you look like an arrogant fool. And you smell like a raccoon's bottom.", new() { byeThen }) },
                     { 6, new("Oh? You are not so ignorant as I thought. Very well, I shall speak of our tribe...", new() { new DialogueChoice("(NEXT)", 7), byeThen }) },
                     { 7, new("Our elders remember that about a century ago we were living in the lands far to the west. We were a large nomadic mountain tribe, settling wherever there was food, moving on when it had run out.", new() { new DialogueChoice("(NEXT)", 8), byeThen }) },
                     { 8, new("As the tribe grew larger, it was hard to find enough food for everyone, and we were forced to shift our camp more and more often.", new() { new DialogueChoice("(NEXT)", 9), byeThen }) },
                     { 9, new("In time, a warrior called Gunnar took his friends and their families and left the larger tribe, moving south in search of new places.", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                     { 10, new("They eventually settled here and built this village, finding that the old nomadic traditions were no longer needed.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                     { 11, new("Our current chieftain, Gunthor the Brave, is a direct-line descendent of Gunnar.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) },
                     { 12, new("However, our ways have changed little in the last century. Although more and more people use magical powers, we do not believe it is wise to take upon oneself the power of the gods in this way.", new() { new DialogueChoice("(NEXT)", 13), byeThen }) },
                     { 13, new("To this day, we fight with the mighty sword, the vicious axe, and the swift arrow on the wind.", new() { new DialogueChoice("(NEXT)", 14), byeThen }) },
                     { 14, new("Some of our young, wishing to try so-called 'civilization' and the softness of city life, abandon the tribe and move to the cities.", new() { new DialogueChoice("(NEXT)", 15), byeThen }) },
                     { 15, new("It is sad to see them go, but we do not prevent them; we live here in our village because we love this life - we do not force it on those whom it does not suit.", new() { new DialogueChoice("(NEXT)", 16), byeThen }) }, 
                     { 16, new("There, I have said enough.", new() { new DialogueChoice("Thank you", -1), byeThen }) }
                }));

                toAdd.Add(new("Peksa", "mistBarbPeksa", new() { 
                    { 0, new("Are you interested in buying or selling a helmet?", new() { new DialogueChoice("I could be, yes.", -1), new DialogueChoice("No, I'll pass on that.", 1), byeThen }) },
                    { 1, new("Well, come back if you change your mind.", new() { byeThen }) }
                }));

                toAdd.Add(new("Head Chef", "mistVarHeadChef", new() { 
                    { 0, new("Hello, welcome to the Cooking Guild. Only accomplished chefs and cooks are allowed in here. Feel free to use any of our facilities.", new() {  new DialogueChoice("Nice cape you're wearing!", 1), byeThen }) },
                    { 1, new("Thank you! It's my most prized possession, a Skillcape of Cooking; it shows that I've achieved level 99 Cooking an am one of the best chefs in the land!", new() { new DialogueChoice("Can I buy a Skillcape of Cooking from you?", 2, new() { new("Skill", 99, "Cooking")}, true), byeThen }) },
                    { 2, new("Most certainly, by wearing this cape you'll never burn any food. I will have to ask for 99,000 gold for such a privilege.", new() { new DialogueChoice("That's a bit expensive.", 3), new DialogueChoice("(BUY CAPE)", 4, new() { new("Item", 99000, "Gold", true), new("Skill", 99, "Cooking")}, true), byeThen }) },
                    { 3, new("I'm sorry you feel that way.", new() { byeThen }) },
                    { 4, new("Now you can use the title Master Chef.", new() { byeThen }, items: new() { "capeSkillCooking,1" }) },
                }));

                toAdd.Add(new("Bartender", "mistVarJollyBartender", new() { 
                    { 0, new("Can I help you?", new() {  new DialogueChoice("I'll have a beer please?", 1, new() { new("Item", 2, "Gold", true)}, true), new DialogueChoice("Any hints where I can go adventuring?", 2), new DialogueChoice("Heard any good gossip?", 4), byeThen }) },
                    { 1, new("That'll be two coins, please.", new() { new DialogueChoice("Another round, barkeep!", 1, new() { new("Item", 2, "Gold", true)}, true), byeThen }, items: new() { "beer,1" }) },
                    { 2, new("Ooh, now. Let me see... Well there is the Varrock sewers. There are tales of untold horrors coming out at night and stealing babies from houses.", new() { new DialogueChoice("Sounds perfect! Where's the entrance?", 3),byeThen }) },
                    { 3, new("It's just to the east of the palace.", new() { byeThen }) },
                    { 4, new("I'm not that well up on the gossip out here. I've heard that the bartender of the Blue Moon Inn has gone a little crazy, he keeps claiming he is part of something called an online game.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                    { 5, new("What that means, I don't know. That's probably old news by now though.", new() { byeThen }) }
                }));

                toAdd.Add(new("Cook", "mistVarJollyCook", new() { 
                    { 0, new("What do you want? I'm busy!", new() { new DialogueChoice("Can you cook me something?", 1), new DialogueChoice("Why do you work here?", 5), new DialogueChoice("Can you tell me any good jokes?", 9), byeThen }) },
                    { 1, new("What? No! Go away.", new() { new DialogueChoice("Well you're meant to be a cook. Why can't you cook something for me?", 2), byeThen }) },
                    { 2, new("I don't want to, that's why! Now leave me alone.", new() { new DialogueChoice("You're not a very nice man.", 3), byeThen }) },
                    { 3, new("Yet you keep talking to me!", new() { new DialogueChoice("Good point. I should stop that.", 4), byeThen }) },
                    { 4, new("Yes, do us both a favor.", new() { byeThen }) },
                    { 5, new("Why do you think i work in a disreputable inn filled with rough scoundrels on the very edge of the Wilderness? I work here because I need the job!", new() { new DialogueChoice("Do you like it?", 6), byeThen }) },
                    { 6, new("Like it? It's sucked the warmth and humanity out of me, and I've become a hollow shell holding nothing but anger, misery, and gourmet recipes.", new() { new DialogueChoice("Oh.", 7), byeThen }) },
                    { 7, new("What did you expect to hear? I suppose you expected me to tell you an inspiring story about how working here can teach you to find hope in the darkest places, or how to see the best in everything?", new() { new DialogueChoice("Maybe you should think about moving to a different inn.", 8), byeThen }) },
                    { 8, new("Bah! I'm not letting it defeat me. Now, let me concentrate on my cooking.", new() { new DialogueChoice("Okay.", -1), byeThen }) },
                    { 9, new("Ohhh, if you insist...", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                    { 10, new("What did the half-wit say to the cook?", new() { new DialogueChoice("I don't know.", 11), byeThen }) },
                    { 11, new("They said 'Can you tell me any good jokes?' Got ya! Hahahaha!", new() { new DialogueChoice("Whatever.", -1), byeThen }) },
                }));

                
                toAdd.Add(new("Shopkeeper", "mistVarShopkeeperSword", new() { { 0, new("Hello, bold adventurer. Can I interest you in some swords?", new() { byeThen }) } })); 
                toAdd.Add(new("Stray dog", "dogStray", new() { 
                    { 0, new("(The dog approaches you with a hopeful look in its eyes)", new() { new DialogueChoice("(PET)", 1), new DialogueChoice("(SHOO)", 2), new DialogueChoice("(GIVE BONE)", 3, new() { new("Item", 1, "bonesRegular", true) }), new DialogueChoice("(GIVE MEAT)", 4, new() { new("Item", 1, "meatRawBeef", true) }), byeThen }) }, 
                    { 1, new("(The dog woofs happily and follows you around for a bit)", new() { byeThen }) },
                    { 2, new("(The dog whines and backs away from you)", new() { byeThen }) },
                    { 3, new("(The dog woofs and gnaws happily on the bones)", new() { byeThen }) },
                    { 4, new("(The dog gobbles up the piece of meat eagerly)", new() { byeThen }) }
                })); 
            }
            
            // Desert
            {
                // Al Kharid
                {
                    toAdd.Add(new("Ayesha", "desAlKharidAyesha", new() { { 0, new("Feel free to grow some cacti here if you like!", new() { byeThen }) } })); 

                    toAdd.Add(new("Zeke", "desAlKharidZeke", new() { 
                        { 0, new("A thousand greetings, sir.", new() { new DialogueChoice("Do you want to trade?", 1), new DialogueChoice("Nice cloak.", 2), new DialogueChoice("Could you sell me a dragon scimitar?", 3), new DialogueChoice("Hi! I have this money-off voucher!", 7), byeThen }) }, // TODO: More dialogue after Rogue Trader is added
                        { 1, new("Yes, certainly. I deal in scimitars.", new() { byeThen }) },
                        { 2, new("Thank you.", new() { byeThen }) }, 
                        { 3, new("A dragon scimitar? A DRAGON scimitar?", new() { new DialogueChoice("(NEXT)", 4), byeThen }) }, 
                        { 4, new("The banana-brained nitwits who make them would never dream of selling any to me.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                        { 5, new("Seriously, you'll be a monkey's uncle before you'll ever hold a dragon scimitar.", new() { new DialogueChoice("Oh well, thanks anyway.", 7), byeThen }) }, // TODO: If Monkey Madness ever gets implemented the dialogue should branch a tiny bit here
                        { 6, new("Perhaps you'd like to take a look at my stock?", new() { new DialogueChoice("Yes please, Zeke.", -1), new DialogueChoice("Not today, thank you.", -1), byeThen }) }, // The illusion of free will
                        { 7, new("So I see! Unfortunately, it seems to have expired yesterday! Nevermind.", new() { new DialogueChoice("But I only just got it!", 8), byeThen }) },
                        { 8, new("I'm sorry, there's nothing I can do. Goodbye.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Dommik", "desAlKharidDommik", new() { 
                        { 0, new("Would you like to buy some crafting equipment?", new() { new DialogueChoice("No thanks; I've got all the crafting equipment I need.", 1), new DialogueChoice("Let's see what you've got, then.", -1), new DialogueChoice("Hi! I have this money-off voucher!", 2), byeThen }) }, // TODO: More dialogue after Rogue Trader is added
                        { 1, new("Okay. Fare well on your travels.", new() { byeThen }) },
                        { 2, new("So I see! Unfortunately, it seems to have expired yesterday! Nevermind.", new() { new DialogueChoice("But I only just got it!", 3), byeThen }) },
                        { 3, new("I'm sorry, there's nothing I can do. Goodbye.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Shopkeeper", "desAlKharidShopkeeper", new() { 
                        { 0, new("Can I help you at all?", new() { new DialogueChoice("Yes please. What are you selling?", -1), new DialogueChoice("No thanks.", -1), byeThen }) }, // TODO: More dialogue after Rogue Trader is added
                    }));

                    toAdd.Add(new("Louie Legs", "desAlKharidLouie", new() { 
                        { 0, new("Hey, wanna buy some armour?", new() { new DialogueChoice("What have you got?", 1), new DialogueChoice("No, thank you.", -1), new DialogueChoice("Hi! I have this money-off voucher!", 2), byeThen }) }, // TODO: More dialogue after Rogue Trader is added
                        { 1, new("I provide items to help you keep your legs!", new() { byeThen }) },
                        { 2, new("So I see! Unfortunately, it seems to have expired yesterday! Nevermind.", new() { new DialogueChoice("But I only just got it!", 3), byeThen }) },
                        { 3, new("I'm sorry, there's nothing I can do. Goodbye.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Ranael", "desAlKharidRanael", new() { 
                        { 0, new("Do you want to buy any armoured skirts? Designed especially for ladies who like to fight.", new() { new DialogueChoice("Yes please", -1), new DialogueChoice("No thank you, that's not my scene.", -1), new DialogueChoice("Hi! I have this money-off voucher!", 2), byeThen }) }, // TODO: More dialogue after Rogue Trader is added
                        { 2, new("So I see! Unfortunately, it seems to have expired yesterday! Nevermind.", new() { new DialogueChoice("But I only just got it!", 3), byeThen }) },
                        { 3, new("I'm sorry, there's nothing I can do. Goodbye.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Karim", "desAlKharidKarim", new() { 
                        { 0, new("Would you like to buy a nice kebab? Only five gold.", new() { new DialogueChoice("Yes please", -1), new DialogueChoice("I think I'll give it a miss.", -1), byeThen }) }, // TODO: More dialogue after Rogue Trader is added
                    }));

                    toAdd.Add(new("Ellis", "desAlKharidEllis", new() { 
                        { 0, new("Greetings, friend. I am a manufacturer of leather.", new() { new DialogueChoice("Can I buy some leather then?", 1), new DialogueChoice("Leather is rather weak stuff.", 2), byeThen }) }, // TODO: More dialogue after Rogue Trader is added
                        { 1, new("I make leather from animal hides. Bring some here, say some cowhide or snakeskin, and I'll tan them for you.", new() { byeThen }) }, 
                        { 2, new("Normal leather may be quite weak, but it's very cheap and easy to work with.", new() { new DialogueChoice("(NEXT)", 3),byeThen }) },
                        { 3, new("Alternatively you could try hard leather. It makes sturdier armor, and you get it by tanning soft leather again.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) }, 
                        { 4, new("I can also tan snake hides and dragonhides, suitable for crafting into the highest quality armour for rangers.", new() { byeThen }) },  
                    }));
                }

                // Mage Training Arena
                {
                    toAdd.Add(new("Enchantment Guardian", "desMTAGuardianEnchanting", new() { 
                        { 0, new("(The guardian stands unmoving, appearing to look at you curiously)", new() { new DialogueChoice("Hello.", 1), byeThen }) },
                        { 1, new("Greetings young one. How can I enlighten you?", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("What are the rewards?", 6), new DialogueChoice("Got any tips that may help me?", 7), new DialogueChoice("Thanks, bye!", 8), byeThen }) },
                        { 2, new("In this chamber you will see various piles of shapes. You can pick up these shapes and enchant them using enchanting spells.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) },
                        { 3, new("By enchanting these shapes, you convert them to orbs which can be deposited using your Processing menu.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                        { 4, new("You will get Enchantment Pizazz Points for each shape you convert, and bonus points every ten, based on what level of spell you cast.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                        { 5, new("At any given time there is a specific shape that you can enchant to get double points, visible in the Minigame menu.", new() { new DialogueChoice("What are the rewards?", 6), new DialogueChoice("Got any tips that may help me?", 7), new DialogueChoice("Thanks, bye!", 8), byeThen }) },
                        { 6, new("The pizazz points you earn can be spent for rewards at the Rewards Guardian. Every ten orbs deposited also grant some runes.", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("Got any tips that may help me?", 7), new DialogueChoice("Thanks, bye!", 8), byeThen }) },
                        { 7, new("Pay attention to the special shape as it changes, and collect dragonstones. They can be enchanted for extra points!", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("What are the rewards?", 6), new DialogueChoice("Thanks, bye!", 8), byeThen }) },
                        { 8, new("Use what you've learned, young one.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Graveyard Guardian", "desMTAGuardianGraveyard", new() { 
                        { 0, new("(The guardian stands unmoving, appearing to look at you curiously)", new() { new DialogueChoice("Hello.", 1), byeThen }) },
                        { 1, new("Greetings young one. What knowledge do you seek?", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("What are the rewards?", 5), new DialogueChoice("Got any tips that may help me?", 6), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 2, new("You have to collect bones and cast the appropriate spell to turn them into bananas or peaches.", new() { new DialogueChoice("(NEXT)", 3), byeThen }) },
                        { 3, new("Unfortunately you will take damage from falling bones periodically, so you may need to eat some fruit to stay alive.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                        { 4, new("Any fruit you don't need to eat can be placed into the Fruit Chute to earn Graveyard Pizazz points.", new() { new DialogueChoice("What are the rewards?", 5), new DialogueChoice("Got any tips that may help me?", 6), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 5, new("You will get experience from casting the spells, and pizazz points for depositing the fruit.", new() { new DialogueChoice("Got any tips that may help me?", 6), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 6, new("Different bones will give different numbers of fruit, so pay attention. If you get enough pizazz points you can purchase the 'Bones to Peaches' spell from the Rewards Guardian, allowing you to earn points even faster.", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("What are the rewards?", 5), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 7, new("Use what you've learned, young one.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Alchemy Guardian", "desMTAGuardianAlchemy", new() { 
                        { 0, new("(The guardian stands unmoving, appearing to look at you curiously)", new() { new DialogueChoice("Hello.", 1), byeThen }) },
                        { 1, new("Greetings young one. What wisdom do you seek?", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("What are the rewards?", 5), new DialogueChoice("Got any tips that may help me?", 6), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 2, new("You must search the cabinets for items, and then turn them into gold with your alchemy spells. Then deposit the coins in the slot to receive Alchemist Pizazz points.", new() { new DialogueChoice("What are the rewards?", 5), new DialogueChoice("Got any tips that may help me?", 6), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 5, new("You get experience from casting the spells, as well as 1 Alchemist Pizazz point for every 100 coins you deposit.", new() { new DialogueChoice("Got any tips that may help me?", 6), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 6, new("Remembe to keep an eye on the values of the items in your Minigame menu, as they change every minute.", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("What are the rewards?", 5), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 7, new("Use what you've learned, young one.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Telekinetic Guardian", "desMTAGuardianTelekinetic", new() { 
                        { 0, new("(The guardian stands unmoving, appearing to look at you curiously)", new() { new DialogueChoice("Hello.", 1), byeThen }) },
                        { 1, new("Greetings young one. What is it you wish to know?", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("What are the rewards?", 4), new DialogueChoice("Got any tips that may help me?", 5), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 2, new("In this room you will see a maze without which one of my fellow Guardians has been turned to stone for the purposes of this exercise.", new() { new DialogueChoice("(NEXT).", 3), byeThen }) },
                        { 3, new("You must move the statue using your telekinetic grab spell to the exit square, highlighted in green.", new() { new DialogueChoice("What are the rewards?", 4), new DialogueChoice("Got any tips that may help me?", 5), new DialogueChoice("Thanks, bye!", 7), byeThen }) }, 
                        { 4, new("As well as the experience from casting spells, you will receive Telekinetic Pizazz points for each maze successfully solved and bonus points for completing five in a row.", new() { new DialogueChoice("What do I have to do in this room?", 2), new DialogueChoice("Got any tips that may help me?", 5), new DialogueChoice("Thanks, bye!", 7), byeThen }) },
                        { 5, new("Have a good luck at the maze before you try to solve it, because this can save you time and runes. All mazes can be solved in ten moves or less.", new() { new DialogueChoice("(NEXT).", 3), byeThen }) },
                        { 7, new("Use what you've learned, young one.", new() { byeThen }) }
                    }));

                    toAdd.Add(new("Rewards Guardian", "desMTAGuardianRewards", new() { 
                        { 0, new("(The guardian stands unmoving, appearing to look at you curiously)", new() { new DialogueChoice("Hi.", 1), new DialogueChoice("I'd like to view the rewards shop.", 3), byeThen }) },
                        { 1, new("Greetings. What wisdom do you seek?", new() { new DialogueChoice("Who are you?", 2), new DialogueChoice("Can I trade my Pizazz Points please?", 3), byeThen }) },
                        { 2, new("Me? I'm here to grant you rewards for any of the Pizazz Points you may have earned in this training arena.", new() { new DialogueChoice("Can I trade my Pizazz Points please?", 3), byeThen }) },
                        { 3, new("These are the items available.", new() { 
                            new DialogueChoice("Infinity Gloves", 4, new() { new("Pizazz", 175, "Telekinetic"), new("Pizazz", 225, "Alchemist"), new("Pizazz", 1500, "Enchantment"), new("Pizazz", 175, "Graveyard")}, true),
                            new DialogueChoice("Infinity Hat", 5, new() { new("Pizazz", 350, "Telekinetic"), new("Pizazz", 400, "Alchemist"), new("Pizazz", 3000, "Enchantment"), new("Pizazz", 350, "Graveyard")}, true),
                            new DialogueChoice("Infinity Top", 6, new() { new("Pizazz", 400, "Telekinetic"), new("Pizazz", 450, "Alchemist"), new("Pizazz", 4000, "Enchantment"), new("Pizazz", 400, "Graveyard")}, true),
                            new DialogueChoice("Infinity Bottoms", 7, new() { new("Pizazz", 450, "Telekinetic"), new("Pizazz", 500, "Alchemist"), new("Pizazz", 5000, "Enchantment"), new("Pizazz", 450, "Graveyard")}, true),
                            new DialogueChoice("Infinity Boots", 8, new() { new("Pizazz", 120, "Telekinetic"), new("Pizazz", 120, "Alchemist"), new("Pizazz", 1200, "Enchantment"), new("Pizazz", 120, "Graveyard")}, true),
                            new DialogueChoice("Beginner Wand", 9, new() { new("Pizazz", 30, "Telekinetic"), new("Pizazz", 30, "Alchemist"), new("Pizazz", 300, "Enchantment"), new("Pizazz", 30, "Graveyard")}, true),
                            new DialogueChoice("Apprentice Wand", 10, new() { new("Pizazz", 60, "Telekinetic"), new("Pizazz", 60, "Alchemist"), new("Pizazz", 600, "Enchantment"), new("Pizazz", 60, "Graveyard"), new("Item", 1, "wandBeginner", true)}, true),
                            new DialogueChoice("Teacher Wand", 11, new() { new("Pizazz", 150, "Telekinetic"), new("Pizazz", 200, "Alchemist"), new("Pizazz", 1500, "Enchantment"), new("Pizazz", 150, "Graveyard"), new("Item", 1, "wandApprentice", true)}, true),
                            new DialogueChoice("Master Wand", 12, new() { new("Pizazz", 240, "Telekinetic"), new("Pizazz", 240, "Alchemist"), new("Pizazz", 2400, "Enchantment"), new("Pizazz", 240, "Graveyard"), new("Item", 1, "wandTeacher", true)}, true),
                            new DialogueChoice("Mage's Book", 13, new() { new("Pizazz", 500, "Telekinetic"), new("Pizazz", 550, "Alchemist"), new("Pizazz", 6000, "Enchantment"), new("Pizazz", 500, "Graveyard")}, true),
                            new DialogueChoice("Bones to Peaches Spell", 14, new() { new("Pizazz", 200, "Telekinetic"), new("Pizazz", 300, "Alchemist"), new("Pizazz", 2000, "Enchantment"), new("Pizazz", 200, "Graveyard"), new("Data", 0, "UnlockedBonesToPeaches", misc3: "equals", summ: "Bones to Peaches not already unlocked.")}, true),
                            new DialogueChoice("Rune Pouch", 15, new() { new("Pizazz", 150, "Telekinetic"), new("Pizazz", 200, "Alchemist"), new("Pizazz", 1500, "Enchantment"), new("Pizazz", 150, "Graveyard"), new("ItemNotOwned", 1, "pouchRune")}, true),
                            byeThen
                        }) },
                        { 4, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "infinityGloves" }) },
                        { 5, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "infinityHat" }) },
                        { 6, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "infinityRobeTop" }) },
                        { 7, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "infinityRobeBottom" }) },
                        { 8, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "infinityBoots" }) },
                        { 9, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "wandBeginner" }) },
                        { 10, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "wandApprentice" }) },
                        { 11, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "wandTeacher" }) },
                        { 12, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "wandMaster" }) },
                        { 13, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "magesBook" }) },
                        { 14, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, acts: [ new("Data", "UnlockedBonesToPeaches", "set", 1) ]) },
                        { 15, new("Here you go.", new() { new DialogueChoice("(Back to Shop)", 3), byeThen }, items: new() { "pouchRune" }) },
                        
                    }));
                }
            }

            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
