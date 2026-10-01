using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCs {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();
            
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
                // Wizards' Tower
                {
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
                         { 0, new("Welcome adventurer, to the world renowned Wizards' Tower, home to the Order of Wizards. We are the oldest and most prestigious group of wizards around. Now, how may I help you?", new() { 
                             new DialogueChoice("I'm just looking around.", 1), 
                             new DialogueChoice("The Duke of Lumbridge sent me to find you. I have this talisman he found, he said you'd be interested.", 2, [ new("QuestAt", 0, "MI_RuneMysteries", summ: "Must have started Rune Mysteries but not yet given Sedridor the talisman.")]),
                             new DialogueChoice("So is that talisman of any use to you?", 6, [ new("QuestAt", 10, "MI_RuneMysteries", summ: "Must have started Rune Mysteries and given Sedridor the talisman.")]), 
                             new DialogueChoice("I lost that package you gave me.", 32, [ new("QuestAt", 20, "MI_RuneMysteries"), new("ItemNotOwned", 1, "rmPackage")]), 
                             new DialogueChoice("I delivered your research to Aubury, and he gave me these notes for you.", 33, [ new("QuestAt", 40, "MI_RuneMysteries")]), 
                             new DialogueChoice("What came of those notes from Aubury?", 36, [ new("QuestAt", 50, "MI_RuneMysteries")]),  
                             new DialogueChoice("Could you teleport me to the essence mine?", 44, [ new("QuestAt", 60, "MI_RuneMysteries")], tele: "RunecraftEssenceMine"), 
                             byeThen 
                            }) }, 
                         { 1, new("Well, take care adventurer. You stand in the ruins of the old destroyed Wizards' Tower. Strange and powerful magicks lurk here.", new() { byeThen }) }, 
                         { 2, new("Did he now? Well hand it over then, and we'll see what the hubbub is all about.", new() { new DialogueChoice("Okay, here you are.", 6, [ new("Item", 1, "talismanAir", true)]), new DialogueChoice("Okay, here you are.", 3, [ new("NotItem", 1, "talismanAir")]), byeThen }) }, 
                         { 3, new("...", new() { new DialogueChoice("...", 4), byeThen }) }, 
                         { 4, new("Well?", new() { new DialogueChoice("I don't seem to have it with me.", 5), byeThen }) }, 
                         { 5, new("Hmm? You are a very odd person. Come back gain when you have it.", new() { byeThen }) }, 
                         { 6, new("Hmm... Doesn't seem to be anything too special. Just a normal air talisman by the looks of things. Still, looks can be deceiving. Let me take a closer look...", new() { new DialogueChoice("(NEXT)", 7), byeThen }, "MI_RuneMysteries", 10) },
                         { 7, new("(Sedridor murmurs some sort of incantation and the talisman glows slightly)", new() { new DialogueChoice("(NEXT)", 8), byeThen }, altSpeaker: "-") }, 
                         { 8, new("How interesting... it would appear I spoke too soon. There's more to this talisman than meets the eye. In fact, it may well be the last piece of the puzzle.", new() { new DialogueChoice("Puzzle?", 9), byeThen }) },
                         { 9, new("Indeed! The lost legacy of the first tower. This talisman may in fact be key to finding the forgotten essence mine!", new() { new DialogueChoice("First tower? Forgotten essence mine? What are you on about?", 10), byeThen }) }, 
                         { 10, new("Ah, my apologies, adventurer. Allow me to fill you in.", new() { new DialogueChoice("Go ahead.", 15), new DialogueChoice("Actually, I'm not interested.", 11), byeThen }) }, 
                         { 11, new("Oh... Well I guess the short of it is that this talisman could be key to helping us rediscover an important teleportation incantation.", new() { new DialogueChoice("(NEXT)", 12), byeThen }) }, 
                         { 12, new("With it, we'll be able to access a hidden essence mine, our lost source of rune essence.", new() { new DialogueChoice("(NEXT)", 26), byeThen }) }, 
                         { 15, new("As you are likely aware, when we cast spells, we do so using the power of runes.", new() { new DialogueChoice("(NEXT)", 16), byeThen }) }, 
                         { 16, new("These runes are crafted from a highly unique material, and then imbued with magical power from various runic altars. Different altars create different runes with different magical effects.", new() { new DialogueChoice("(NEXT)", 17), byeThen }) }, 
                         { 17, new("The process of imbuing runes is called runecrafting. Legend has it that this was once a common art, but the secrets of how to do it were lost until just under two hundred years ago.", new() { new DialogueChoice("(NEXT)", 18), byeThen }) }, 
                         { 18, new("The rediscovery of runecrafting had such a large impact on the world, that it marked down the dawn of the Fifth Age. It also resulted in the birth of our order, and the construction of the first Wizards' Tower.", new() { new DialogueChoice("If it was the first tower, I'm guessing it doesn't exist anymore? What happened?", 19), byeThen }) }, 
                         { 19, new("It was burnt down by traitorous members of our own order. They followed the evil god of chaos, Zamorak, and they wished to claim our magical discoveries in his name.", new() { new DialogueChoice("(NEXT)", 20), byeThen }) }, 
                         { 20, new("When the tower burnt down, much was lost, including an important incantation. A spell that could be used to teleport to a hidden essence mine.", new() { new DialogueChoice("The essence mine you mentioned earlier, I assume?", 21), byeThen }) }, 
                         { 21, new("Precisely. Rune essence is the material used to make runes, but it is incredibly rare. That essence mine was the only place it could be found that our order knew of.", new() { new DialogueChoice("(NEXT)", 22), byeThen }) }, 
                         { 22, new("Since the incantation was lost, we have struggled to maintain our stocks of rune essence.", new() { new DialogueChoice("(NEXT)", 23), byeThen }) }, 
                         { 23, new("There are seemingly those out there that still know where to find some, but while they have been willing to sell essence to us, they have refused to share knowledge on how to find it ourselves.", new() { new DialogueChoice("I'm starting to see why this is so important. So you think this talisman can help you rediscover that incantation?", 24), byeThen }) }, 
                         { 24, new("I do! All magic leaves traces, and from what I can tell, this talisman was used heavily during the time of the first tower.", new() { new DialogueChoice("(NEXT)", 25), byeThen }) }, 
                         { 25, new("It would have been taken to the essence mine many times, and the magical energies there will have left an imprint on it. To think it was hidden in Lumbridge all this time!", new() { new DialogueChoice("So what happens now?", 26), byeThen }) }, 
                         { 26, new("It is critical I share this discovery with my associate, Aubury, as soon as possible. He's not much of a wizard, but he's an expert on runecrafting, and his insight will be essential.", new() { new DialogueChoice("(NEXT)", 27), byeThen }) }, 
                         { 27, new("Would you be willing to visit him for me? I would go myself, but I wish to study this talisman some more.", new() { new DialogueChoice("Yes, certainly.", 29), new DialogueChoice("No, I'm busy.", 28), byeThen }) }, 
                         { 28, new("As you wish adventurer. I will continue to study this talisman you have brought me. Return here if you find yourself with some spare time to help me.", new() { byeThen }) }, 
                         { 29, new("He runs a rune shop in the south east of Varrock. Please, take this package of research notes to him. If all goes well, the secrets of the essence mine may soon be ours once more!", new() { new DialogueChoice("(NEXT)", 30), byeThen }, "MI_RuneMysteries", 20, [ "rmPackage" ]) }, 
                         { 30, new("Best of luck, @.", new() { new DialogueChoice("I don't remember telling you my name... How do you know it?", 31), byeThen }) },
                         { 31, new("Really now? I am the Archmage, you know.", new() { byeThen }) },
                         { 32, new("Well, it's a good job I have copies of everything. Try not to lose it this time.", new() { byeThen }, items: [ "rmPackage" ]) },
                         { 33, new("Excellent! Let me see them.", new() { new DialogueChoice("Okay, here you are.", 36, [ new("Item", 1, "rmNotes", true)]), new DialogueChoice("Err, you're not going to believe this...", 34, [ new("NotItem", 1, "rmNotes")]), byeThen }) },
                         { 34, new("What?", new() { new("I don't have them.", 35), byeThen }) },
                         { 35, new("Right... you're rather careless, aren't you. I suggest you go and speak to Aubury once more. With luck he will have made copies.", new() { byeThen }) },
                         { 36, new("Alright, let's see what Aubury has for us...", new() { new("(NEXT)", 37), byeThen }, "MI_RuneMysteries", 50) },
                         { 37, new("Yes, this is it! The lost incantation!", new() { new("So you'll be able to access that essence mine now?", 38), byeThen }) },
                         { 38, new("That's right! Because of you, our order finally has a proper source of rune essence again! Thank you, friend.", new() { new("(NEXT)", 39), byeThen }) },
                         { 39, new("If you ever want to access the essence mine yourself, just let me know. It's the least I can do.", new() { new("(NEXT)", 40), byeThen }) },
                         { 40, new("I will also share the incantation with others, including Aubury. When I do, I'll let them know you are to be given unlimited access to the mine.", new() { new("(NEXT)", 41), byeThen }) },
                         { 41, new("Oh, and you can also have the air talisman back as well. I have no further need of it, and I'm sure you will find it useful.", new() { new("(NEXT)", 42), byeThen }) },
                         { 42, new("In case you didn't know, the talisman can be used to craft air runes. Just take it to the Air Altar south of Falador along with some rune essence.", new() { new("Great, thanks!", 43), byeThen }) },
                         { 43, new("My pleasure!", new() { byeThen }, "MI_RuneMysteries", 60, [ "talismanAir" ]) },
                         { 44, new("Seventior disthine molenko!", new() { byeThen }, acts: [ new("Data", "LastTeleportToEssenceMine", "set", 1) ] ) }
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
                }

                // Barbarian Village
                {
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
                }

            }

            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
