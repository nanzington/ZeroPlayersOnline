using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCs {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();

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
                    new("cow", 5, 10),
                    new("chicken", 10, 20),
                    new("tiZombie", 5, 10),
                    new("newt", 5, 10)
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

            toAdd.Add(new("Man", "man", new() { { 0, new("Lovely day for it!", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coinPouchSmall", 1, 1, 1, 1) } });
            toAdd.Add(new("Woman", "woman", new() { { 0, new("Lovely day for it!", new() { byeThen }) } }, 1, 10) { PickpocketLoot = new() { new("coinPouchSmall", 1, 1, 1, 1) } });
            toAdd.Add(new("Farmer", "farmer", new() { { 0, new("Have you seen m'chickens?", new() { byeThen }) } }, 10, 15) { PickpocketLoot = new() { new("coinPouchMedium", 1, 1, 1, 1), new("seedPouchFarmer", 1, 1, 1, 1) } });

            toAdd.Add(new("Bartender", "mistLumBartender", new() { 
                { 0, new("Welcome to the Sheared Ram. What can I do for you?", new() {  new DialogueChoice("I'll have a beer please?", 1, new() { new("Item", 2, "Gold", true)}, true), new DialogueChoice("Heard any rumors?", 2), byeThen }) },
                { 1, new("That'll be two coins, please.", new() { new DialogueChoice("Another round, barkeep!", 1, new() { new("Item", 2, "Gold", true)}, true), byeThen }, items: new() { "beer,1" }) },
                { 2, new("One of the patrons here is looking for treasure, apparently. A chap by the name of Veos.", new() { byeThen }) }
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
                 { 100, new("Righto, let me take a look here...", new() { new DialogueChoice("More help?", 0), byeThen }, action: "clueHelp") }
             }));

            toAdd.Add(new("Hans", "mistLumHans", new() { 
                 { 0, new("Hello. What are you doing here?", new() { new DialogueChoice("Who runs this place?", 10), new DialogueChoice("I have come to kill everyone!", 20), new DialogueChoice("I don't know, I'm lost.", 30), new DialogueChoice("How long have I been here?", 40), byeThen }) }, 
                 { 10, new("That'd be Duke. He's in his study, on the second floor.", new() { byeThen }) },
                 { 20, new("Guards! Help! Help!", new() { byeThen }) },
                 { 30, new("Well consider yourself found! This is Lumbridge Castle, second in Misthalin only to Varrock Castle.", new() { new DialogueChoice("How many castles in Misthalin?", 31), byeThen }) },
                 { 31, new("Just the two, I suppose. I hadn't really thought about it before.", new() { byeThen }) },
                 { 40, new("Righto, let me take a look here...", new() { byeThen }, action: "hansTime") }
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
                 { 10, new("I leave town for just five months, and ALRADY he can't manage.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
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

            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
