using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCsLumbridgeDraynor {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();
            
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

            toAdd.Add(new("Border Guard", "desBorderGuard", new() { 
                { 0, new("(The guard says nothing)", new() { new DialogueChoice("Can I come through this gate?", 10, new() { new("QuestBelow", 100, "DES_PrinceAliRescue")}), new DialogueChoice("Can I come through this gate?", 100, new() { new("QuestAt", 100, "DES_PrinceAliRescue")}), byeThen }) }, 
                { 10, new("You must pay a toll of 10 gold coins to pass.", new() { new DialogueChoice("No thank you, I'll walk around.", 11), new DialogueChoice("Who does my money go to?", 12), new DialogueChoice("Yes, okay.", 13, new() { new("Item", 10, "Gold", true) }, true, "DES_AlKharidOutskirts"), byeThen }) },
                { 11, new("Suit yourself.", new() { byeThen }) },
                { 12, new("The money goes to the city of Al Kharid.", new() { byeThen }) },
                { 20, new("You may pass for free, you are a friend of Al Kharid.", new() { new DialogueChoice("Yes, okay.", 13, tele: "DES_AlKharidOutskirts"), byeThen }) }
            }));

            toAdd.Add(new("Seth Groats", "mistLumGroatsSeth", new() { 
                { 0, new( new List<TextReq>() {
                     new("Well well, what can I do for you?", [ new("QuestAt", 0, "MI_IdesOfMilk")]),
                     new("M'arnin'... going to milk me cowsies!") 
                }, new() { 
                     new("I was wondering if you could teach me a little about how you're so successful with your animals.", 1, [ new("Data", 0, "SpokeToSethGroats", false, "equals") ]),
                     new("I was wondering if you could teach me a little about how you're so successful with your animals.", 10, [ new("Data", 1, "SpokeToSethGroats", false, "equals") ]),
                     byeThen 
                }) }, 
                { 1, new("Lookin' to get into the business, eh?", new() { new("Something along those lines.", 2), byeThen }) }, 
                { 2, new("Well, always happy to help another budding farmer out!", new() { new("Great! So where do I start?", 3), byeThen }) }, 
                { 3, new("Would always recommend my Groats Principles as yer basics.", new() { new("Groats Principles?", 4), byeThen }) }, 
                { 4, new("Aye. First one is that happy animals makes happy farmers.", new() { new("(NEXT)", 5), byeThen }) }, 
                { 5, new("Second of me principles is to never take more than you need. Greed'll stop you in your tracks.", new() { new("(NEXT)", 6), byeThen }) }, 
                { 6, new("The last principle: never let the taxman know yer earnings. Money should be spent on the animals!", new() { new("I don't think I've ever paid any taxes.", 7), new("You've found a way to get around the taxes?", 8), byeThen }) }, 
                { 7, new("You're ahead of the game then!", new() { new("(NEXT)", 9), byeThen }) }, 
                { 8, new("A way or two.", new() { new("(NEXT)", 9), byeThen }) }, 
                { 9, new("Anyway, feel free to grab me book on the topic from the shelf over there.", new() { new("Okay, thank you for the help.", -1), byeThen }, acts: [ new("Data", "SpokeToSethGroats", "set", 1), new("Quest", "MI_IdesOfMilk", "", 10)]) }, 
                { 10, new("Mmm we already had this talk. Go read me book on the shelf over there.", new() { 
                    new("I'll go grab it, thanks.", -1, [ new("NotItem", 1, "bookGroats") ]), 
                    new("I've actually got it here, I'll take it away and give it a read somewhere a little more peaceful.", -1, [ new("Item", 1, "bookGroats") ]), 
                    byeThen 
                }, acts: [ new("Quest", "MI_IdesOfMilk", "", 10) ]) }
            }));

            toAdd.Add(new("Gillie Groats", "mistLumGroatsGillie", new() { 
                { 0, new( new List<TextReq>() {
                    new("Hiya, did you need something else from me?", [ new("QuestAt", 50, "MI_IdesOfMilk")]),
                    new("Have you tried that milk sample yet?", [ new("QuestAt", 60, "MI_IdesOfMilk")]),
                    new("That looked like a horrible experience.", [ new("QuestAt", 70, "MI_IdesOfMilk")]),
                    new("How are you getting on with the bull?", [ new("QuestAt", 80, "MI_IdesOfMilk")]),
                    new("You succeeded! I'll let the Duke know that you're all good to start a milk business.", [ new("QuestAt", 90, "MI_IdesOfMilk")]),
                    new("Thank you once again for handling Brutus, he was causing quite a problem for my herd.", [ new("QuestAt", 100, "MI_IdesOfMilk")]),
                    new("Oh, just the person I wanted to see! I have something for you.", [ new("QuestAt", 110, "MI_IdesOfMilk"), new("Data", 0, "CowbellAmuletGiven", false, "equals")]),
                    new("Hello, I'm Gillie the Milkmaid. What can I do for you?")
                }, new() { 
                    new("Who are you?", 1), 
                    new("Can you tell me how to milk a cow?", 3), 
                    new("Can you share what makes your cows so productive?", 8, [ new("QuestAt", 0, "MI_IdesOfMilk")]), 
                    new("I did. I've been trying to secure a business permit from the Duke, but he said that as it is a milk-related business venture I should speak to you instead.", 14, [ new("QuestAt", 50, "MI_IdesOfMilk")]), 
                    new("Not yet. I really don't want to, but I guess I must.", -1, [ new("QuestAt", 60, "MI_IdesOfMilk")]), 
                    new("It wasn't pleasant.", 21, [ new("QuestAt", 70, "MI_IdesOfMilk")]), 
                    new("I'm getting there! He looks quite tough though.", -1, [ new("QuestAt", 80, "MI_IdesOfMilk")]), 
                    new("I don't think that's going to be necessary anymore.", 29, [ new("QuestAt", 90, "MI_IdesOfMilk")]),
                    new("(NEXT)", 35, [ new("QuestAt", 100, "MI_IdesOfMilk")]),
                    new("A reward?", 36, [ new("QuestAt", 110, "MI_IdesOfMilk"), new("Data", 0, "CowbellAmuletGiven", false, "equals") ]),
                    new("I lost my amulet, could I have another?", 38, [ new("QuestAt", 110, "MI_IdesOfMilk"), new("Data", 1, "CowbellAmuletGiven", false, "equals"), new("ItemNotOwned", 1, "amuletCowbell") ]),
                    new("I'm fine, thanks.", -1), 
                    byeThen 
                }) }, 
                { 1, new("My name is Gillie Groats. My father is a farmer and I milk the cows for him.", new() { new("Do you have any buckets of milk spare?", 2), byeThen }) }, 
                { 2, new("I'm afraid not. We need all of our milk to sell to market, but you can milk the cow yourself if you need the milk.", new() { new("Thanks.", -1), byeThen }) }, 
                { 3, new("It's very easy. First you need an empty bucket to hold the milk.", new() { new("(NEXT)", 4), byeThen }) }, 
                { 4, new("Then find a dairy cow to milk - you can't milk just any cow.", new() { new("How do I find a dairy cow?", 5), byeThen }) }, 
                { 5, new("They are easy to spot - they'll look like a (R)esource rather than a monster.", new() { new("(NEXT)", 6), byeThen }) }, 
                { 6, new("There are a couple very near, in this field.", new() { new("(NEXT)", 7), byeThen }) }, 
                { 7, new("Then just milk the cow and your bucket will fill with tasty, nutritious milk.", new() { byeThen }) }, 
                { 8, new("Absolutely! The secret is happiness.", new() { new("Happiness?", 9), byeThen }) }, 
                { 9, new("Thw cows make the best milk when they're happy, and to be honest, they make too much!", new() { new("(NEXT)", 10), byeThen }) }, 
                { 10, new("I'm always glad that adventurers come by and help with milking them, I wouldn't be able to keep up otherwise.", new() { new("That can't be everything though, can it?", 11), byeThen }) }, 
                { 11, new("Come to think of it, I'm sure my father keeps a few tricks up his sleeve. Why don't you go and ask him?", new() { 
                    new("That would be Seth, wouldn't it?", 12, [ new("Data", 0, "SpokeToSethGroats", false, "equals") ]), 
                    new("I've already had a chance to talk to him. He did indeed have some tricks to share!", 13, [ new("Data", 1, "SpokeToSethGroats", false, "equals") ]), 
                    byeThen 
                }) }, 
                { 12, new("It would be! I'm sure he'll be happy to share some information with you.", new() { new("I'll go and speak to him now, thank you!", -1), byeThen }) }, 
                { 13, new("That's good. You must be ready to care for your own cows at this point!", new() { new("If you think so, then I must be. Thank you for your help, I'll make sure that knowledge is put to good use.", -1), byeThen }) }, 
                { 14, new("The Duke is a good man, directing you to me! I've been running the milk side of our farm for a while now.", new() { new("(NEXT)", 15), byeThen }) }, 
                { 15, new("Were you thinking of being a competitor to us then?", new() { 
                    new("I can prove we wouldn't be if you could just try this sample of...", 16, [ new("NotItem", 1, "sampleMilk2" )]), 
                    new("I think if you were to try this sample here you'd see we wouldn't be competing.", 17, [ new("Item", 1, "sampleMilk2" )]), 
                    byeThen 
                }) }, 
                { 16, new("Sample of?", new() { new("I seem to have misplaced my sample of milk. I'll be back when I have it.", -1), byeThen }) }, 
                { 17, new("You want me to drink a vial of mysterious liquid?", new() { new("Well, it's not mysterious, it's milk!", 18), byeThen }) }, 
                { 18, new("No, I think you should drink it, I'll know the quality of it from your reaction.", new() { new("(NEXT)", 19), byeThen }) }, 
                { 19, new("It is just milk after all.", new() { new("Would it convince you to help me with my permit?", 20), byeThen }) }, 
                { 20, new("It definitely won't hurt your chances.", new() { byeThen }, "MI_IdesOfMilk", 60) }, 
                { 21, new("Where did you even get that milk?", new() { new("My business partner, Cassius. I don't know where he gets it from originally though.", 22), byeThen }) }, 
                { 22, new("Cassius... I don't recognize the name. He's not mentioned anything about its source?", new() { new("Nothing, but he apparently has enough of a source to start a business. I'm mostly trying to be helpful.", 23), byeThen }) }, 
                { 23, new("", new() { new("If the milk's bad, you're not going to recommend us for a permit, are you?", 24), byeThen }) }, 
                { 24, new("With how bad it looks, you wouldn't be any competition to us.", new() { new("(NEXT)", 25), byeThen }) }, 
                { 25, new("However, I wonder if I'd be doing a public service by protecting anyone else from it.", new() { new("Is there anything more I could do to convince you?", 26), byeThen }) }, 
                { 26, new("Now that you mention it, I've had an incredibly aggressive bull disrupting my herd lately. I've got him caught in the pen over there.", new() { new("(NEXT)", 27), byeThen }) }, 
                { 27, new("Perhaps you'd be interested in dealing with him? I'd owe you a fairly large favor.", new() { new("A roughly permit sized favor?", 28), byeThen }) }, 
                { 28, new("Absolutely.", new() { byeThen }, "MI_IdesOfMilk", 80) },
                { 29, new("Oh? What happened in that field?", new() { new("That bull was Cassius' other business partner, Brutus.", 30), byeThen }) },
                { 30, new("", new() { new("I'm sure he won't be feeling particularly friendly once I let him know.", 31), byeThen }) },
                { 31, new("That bull was one of the business partners?", new() { new("(NEXT)", 32), byeThen }) },
                { 32, new("I wonder if his aggression is why Cassius' herd are producing such bad milk...", new() { new("I'm starting to think Cassius doesn't even have his own herd.", 33), byeThen }) },
                { 33, new("You think he's been stealing milk?", new() { new("I'm not sure where else he would've been getting it from.", 34), byeThen }) },
                { 34, new("Why don't you go and talk to him about it! He may appreciate knowing that Brutus was bad for business.", new() { byeThen }, "MI_IdesOfMilk", 100) },
                { 35, new("And, if you haven't yet spoken to Cassius, you should probably let him know what transpired. Come back after for a reward!", new() { byeThen }) },
                { 36, new("This is for helping out with that bull. Our cows are much happier these days.", new() { new("(NEXT)", 37), byeThen }) },
                { 37, new("One of our local milk enjoyers gave us some enchanted cow bells. They seem quite versatile, enjoy!", new() { new("Wow, thank you! I'll make sure to check it out!", -1), byeThen }, items: ["lampCombat1k", "amuletCowbell" ], acts: [ new("Data", "CowbellAmuletGiven", "set", 1)]) },
                { 38, new("Oh, no worries, here's another.", new() { new("Thank you so much!", -1), byeThen }, items: ["amuletCowbell"]) }
            }));

            toAdd.Add(new("Cassius", "mistLumCassius", new() { // TODO: Fill this out once implementing Ides of Milk
                { 0, new(new List<TextReq>() {
                        new("You!", [ new("QuestAt", -1, "MI_IdesOfMilk") ]),
                        new("How goes your mission, associate?", [ new("QuestAt", 0, "MI_IdesOfMilk") ]),
                        new("So, how did you get on?", [ new("QuestAt", 10, "MI_IdesOfMilk") ]),
                        new("Ah, you're back.", [ new("QuestAt", 20, "MI_IdesOfMilk") ]),
                        new("Have you given that sample a try yet?", [ new("QuestAt", 25, "MI_IdesOfMilk") ]),
                        new("So, what do you think? The milk is fantastic, isn't it?", [ new("QuestAt", 30, "MI_IdesOfMilk") ]),
                        new("Has the Duke given us our permit yet?", [ new("QuestPast", 40, "MI_IdesOfMilk"), new("QuestBelow", 110, "MI_IdesOfMilk") ]),
                        new("(Cassius makes a point of ignoring you)", [ new("QuestAt", 110, "MI_IdesOfMilk") ])
                        }, new List<DialogueChoice>() { 
                        new("Me?", 1, [ new("QuestAt", -1, "MI_IdesOfMilk")]),
                        new("What was it you needed me to do again?", 18, [ new("QuestAt", 0, "MI_IdesOfMilk")]),
                        new("I've learned a lot abut how the Groats family care for their animals. They say the secret is happiness!", 20, [ new("QuestAt", 10, "MI_IdesOfMilk")]),
                        new("Was there anything useful in that book?", 24, [ new("QuestAt", 20, "MI_IdesOfMilk")]),
                        new("I've managed to lose that sample of milk...", 29, [ new("QuestAt", 25, "MI_IdesOfMilk"), new("NotItem", 1, "sampleMilk")]),
                        new("It wasn't what I was expecting, certainly.", 30, [ new("QuestAt", 30, "MI_IdesOfMilk")]),
                        new("Not yet, no. I could do with another sample of milk though, if you have one spare?", 35, [ new("QuestAt", 40, "MI_IdesOfMilk"), new("NotItem", 1, "sampleMilk2")]),
                        new("Not yet, no, but I am working on it!", 36, [ new("QuestAt", 40, "MI_IdesOfMilk"), new("Item", 1, "sampleMilk2")]),
                        new("It's become rather complicated, but I am working it out!", -1, [ new("QuestPast", 50, "MI_IdesOfMilk"), new("QuestBelow", 100, "MI_IdesOfMilk")]),
                        new("Cassius, I don't think we'll be getting our business permit.", 36, [ new("QuestAt", 100, "MI_IdesOfMilk")]),
                        byeThen 
                }) },  
                { 1, new("Yes you!", new() { new("Can I... help you?", 2), byeThen }) },  
                { 2, new("That depends. Do you like making money?", new() { new("I'm not averse to making money.", 3), byeThen }) },  
                { 3, new("And do you enjoy... milk?", new() { new("Milk?", 4), byeThen }) },  
                { 4, new("Milk.", new() { new("I can't say I've thought much about it.", 5), byeThen }) },  
                { 5, new("Would you like to think more about it?", new() { new("[Q+] What am I going to get from thinking more about... milk?", 6), new("No, I'm not sure I would like that, thank you.", -1), byeThen }) },  
                { 6, new("Profit!", new() { new("(NEXT)", 7), byeThen }, "MI_IdesOfMilk", 0) },
                { 7, new("Ten to fifteen percent, performance depending.", new() { new("How are we going to be making that profit? And who even are you anyway?", 8), byeThen }) },  
                { 8, new("Ah, my name is Cassius. I got carried away.", new() { new("(NEXT)", 9), byeThen }) },  
                { 9, new("But we're going to construct an empire.", new() { new("Of milk?", 10), byeThen }) },  
                { 10, new("Of milk.", new() { new("How do you intend to make an empire of milk?", 11), byeThen }) },  
                { 11, new("So, the first step is going to involve you doing a little... research.", new() { new("Right...", 12), byeThen }) },  
                { 12, new("You're going to cross the River Lum, find Gillie and Seth Groats, and learn about animal husbandry.", new() { new("(NEXT)", 13), byeThen }) },  
                { 13, new("Then... then you're going to gross back to this side of the river, and tell me all about how they've made their animals so productive.", new() { new("(NEXT)", 14), byeThen }) },  
                { 14, new("It's a perfect plan!", new() { new("What use is it if I know everything and you don't? Couldn't I make my own... milk empire... with that information?", 15), byeThen }) },  
                { 15, new("", new() { new("If anything I should be cutting you in at ten to fifteen percent.", 16), byeThen }) },  
                { 16, new("Hey, I'm the one supplying the high-quality milk here.", new() { new("(NEXT)", 17), byeThen }) },  
                { 17, new("Not to mention, my associate Brutus is already embedded in the Groats operation to work a different angle. That will prove most lucrative.", new() { new("Right... I guess I'll go and see the Groatses then.", -1), byeThen }) },  
                { 18, new("I need you to speak to Gillie and Seth Groats. We need to learn everything we can.", new() { new("(NEXT)", 19), byeThen }) },  
                { 19, new("They live just across the River Lum. Head east from here and you should be able to find them.", new() { byeThen }) },
                { 20, new("Happiness?! That can't be the only trick they use! Surely you found something else?", new() { 
                    new("Now that you mention it, Seth did say he had a book that I... don't have on me right now.", 21, [ new("NotItem", 1, "bookGroats") ]), 
                    new("I have this book from Seth. He claims it's got his principles of animal husbandry in it, if that's of any use?", 22, [ new("Item", 1, "bookGroats") ]), 
                    byeThen 
                }) },  
                { 21, new("The legendary Groats book on milk cultivation? I'm most interested! Go fetch it!", new() { byeThen }) },  
                { 22, new("Hand it here, quickly!", new() { new("(NEXT)", 23, [ new("Item", 1, "bookGroats", true)]), byeThen }) },  
                { 23, new("(Cassius snatches the book from your hands)", new() { new("(NEXT)", 24), byeThen }, "MI_IdesOfMilk", 20, altSpeaker: "-") },  
                { 24, new("Now, this is most curious.", new() { new("(NEXT)", 25), byeThen }) },  
                { 25, new("The idea that a happy animal will do what you want is frankly absurd. What if they choose to not produce. Are you supposed to respect that?", new() { new("(NEXT)", 26), byeThen }) },  
                { 26, new("However, the writings on the systems of taxation are fascinating. I couldn't imagine Seth was smart enough to put this together.", new() { new("So, do you think this is enough to start our milk empire?", 27), byeThen }) },  
                { 27, new("No, no. Not quite yet. First of all, you haven't tried our milk yet, have you?", new() { new("I don't think I have, no. You already have some milk?", 28), byeThen }) },  
                { 28, new("Don't look so worried. Here, have a try.", new() { byeThen }, "MI_IdesOfMilk", 25, [ "sampleMilk,1" ]) },
                { 29, new("(Cassius glares as he hands you another sample of milk)", new() { byeThen }, items: [ "sampleMilk,1" ], altSpeaker: "-") },  
                { 30, new("We're going to change the lactic landscape! Before we do though, I have another task for you.", new() { new("Now what do you need?", 31), byeThen }) },  
                { 31, new("We need... a permit.", new() { new("Shouldn't you have got a permit before making milk?", 32), byeThen }) },  
                { 32, new("The permit is to sell milk, not to make milk!", new() { new("Fine, where are we going to get this permit?", 33), byeThen }) },  
                { 33, new("From the Duke of Lumbridge! Where else? You need to bring him our milk and I'm sure he'll give us our permit without fuss.", new() { new("Are you sure having the Duke drink our milk is a good idea?", 34), byeThen }) },  
                { 34, new("Of course! Soon the whole of Lumbridge will be drinking my, I mean our milk!", new() { byeThen }, "MI_IdesOfMilk", 40, [ "sampleMilk2" ]) },
                { 35, new("I should have one somewhere here. Just a moment.", new() { byeThen }, items: [ "sampleMilk2" ]) },
                { 36, new("Why? What's happened?", new() { new("Brutus is dead.", 37), byeThen }) },
                { 37, new("Dead?", new() { new("(NEXT)", 38), byeThen }) },
                { 38, new("How could this have happened?", new() { new("So the Duke asked me to... and then Gillie said that...", 39), byeThen }) },
                { 39, new("You?!", new() { new("(NEXT)", 40), byeThen }) },
                { 40, new("Don't tell me you killed Brutus and ruined my- our, plan?", new() { new("In my defense, I had no idea that was Brutus! You made it sound like he was a business partner.", 41), byeThen }) },
                { 41, new("", new() { new("Not to mention, apparently his aggression was ruining Seth's herd's milk! This should be a good thing!", 42), byeThen }) },
                { 42, new("Ruining the milk? The unique flavor was what I was trying to sell!", new() { new("(NEXT)", 43), byeThen }) },
                { 43, new("You should leave. I can't even look at you.", new() { byeThen }, "MI_IdesOfMilk", 110) }
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
                { 2, new("There are three of them, and I'm not as young as I was the last time I was here. I don't want to go down there without backup.", new() { new DialogueChoice("[Q+] I'll help you.", 3), new DialogueChoice("I need to know more before I help you.", 4), new DialogueChoice("Who are you?", 10), new DialogueChoice("How did you know who I am?", 13), byeThen }) },
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

            toAdd.Add(new("Duke Horacio", "mistLumDukeHoracio", new() { 
                { 0, new("Greetings. Welcome to my castle.", new() { 
                    new DialogueChoice("I seek a shield that will protect me from dragonbreath.", 1, [ new("ItemNotOwned", 1, "shieldAntidragon") ]), 
                    new DialogueChoice("Have you any quests for me?", 20, [ new("QuestAt", -1, "MI_RuneMysteries") ]),
                    new DialogueChoice("Have you any quests for me?", 23, [ new("QuestAt", 0, "MI_RuneMysteries"), new("ItemOwned", 1, "talismanAir") ]),  
                    new DialogueChoice("Have you any quests for me?", 24, [ new("QuestAt", 0, "MI_RuneMysteries"), new("ItemNotOwned", 1, "talismanAir") ]), 
                    new DialogueChoice("Have you any quests for me?", 27, [ new("QuestPast", 10, "MI_RuneMysteries") ]),   
                    new DialogueChoice("Greetings. I come seeking a business permit.", 28, [ new("QuestAt", 40, "MI_IdesOfMilk") ]),
                    new DialogueChoice("Hi, what did you want me to do for the permit again?", 37, [ new("QuestAt", 50, "MI_IdesOfMilk") ]),
                    new DialogueChoice("Where can I find money?", 13), 
                    byeThen 
                }) },
                { 1, new("A knight going on a dragon quest, hmm? What dragon do you intend to slay?", new() { 
                    new DialogueChoice("Elvarg, the dragon of Crandor island!", 2, [ new("QuestPast", 0, "MI_DragonSlayer")]), 
                    new DialogueChoice("Oh, no dragon in particular. I just feel like killing a dragon.", 12, [ new("QuestPast", 100, "MI_DragonSlayer")]), // TODO: adjust this to actual completion of Dragon Slayer later
                    new DialogueChoice("Oh, no dragon in particular. I just feel like killing a dragon.", 11, [ new("QuestBelow", 100, "MI_DragonSlayer")]),
                    byeThen 
                }) },
                { 2, new("Elvarg? Are you sure?", new() { new DialogueChoice("Yes.", 4), new DialogueChoice("No.", 3), byeThen }) },
                { 3, new("Very wise. There are some monsters that are best left alone.", new() { byeThen }) },
                { 4, new("Well, you're a braver person than I!", new() { new DialogueChoice("Why is everyone so scared of this dragon?", 5), byeThen }) },
                { 5, new("Back in my father's day, Crandor was an important city-state. Politically it was as important as Falador and Varrock and its ships traded with every port.", new() { new DialogueChoice("(NEXT)", 6), byeThen }) },
                { 6, new("But one day, when I was little, all contact was lost. The trading ships and the diplomatic envoys just stopped coming.", new() { new DialogueChoice("(NEXT)", 7), byeThen }) },
                { 7, new("I remember my father being very scared. He posted lookouts on the roof to warn if the dragon was approaching. All the city rulers worried that Elvarg would devastate the whole continent.", new() { new DialogueChoice("I'd better leave that dragon alone.", 8), new DialogueChoice("So are you going to give me that shield or not?", 9), byeThen }) },
                { 8, new("That's a relief. I would hate to see such a promising adventurer cut down in their prime.", new() { byeThen }) },
                { 9, new("If you really think you're up to it then perhaps you are the one who can kill this dragon.", new() { new DialogueChoice("(NEXT)", 10), byeThen }, items: [ "shieldAntidragon" ]) },
                { 10, new("Take care out there. If you kill it... if you kill it, for Saradomin's sake make sure it's really dead!", new() { byeThen }) },
                { 11, new("I don't have an infinite supply of these shields, you know. I'll only give one for a truly worthy cause.", new() { byeThen }) },
                { 12, new("Of course. Now you've slain Elvarg, you've earned the right to call the shield your own!", new() { byeThen }, items: [ "shieldAntidragon" ]) },
                { 13, new("I've heard that the blacksmiths are prosperous amongst the peasantry. Maybe you could try your hand at that?", new() { byeThen }) },
                { 20, new("Well, it's not really a quest but I recently discovered this strange talisman.", new() { new DialogueChoice("(NEXT)", 21), byeThen }) },
                { 21, new("It seems to be mystical and I have never seen anything like it before. Would you take it to the head wizard at the Wizards' Tower for me? It's just south-west of here and should not take you very long at all. I would be awfully grateful.", new() { new DialogueChoice("[Q+] Yes", 22), new DialogueChoice("Not right now.", 23), byeThen }) },
                { 22, new("Thank you very much, stranger. I am sure the head wizard will reward you for such an interesting find.", new() { byeThen }, "MI_RuneMysteries", 0, [ "talismanAir" ]) },
                { 23, new("The only task remotely approaching a quest is the delivery of that talisman I gave you to the head wizard of the Wizards' Tower. I suggest you deliver it to him as soon as possible. I have the oddest feeling that it is important...", new() { byeThen }) },
                { 24, new("Did you speak to the head wizard for me yet, adventurer?", new() { new DialogueChoice("No, I lost that air talisman you gave me.", 25), byeThen }) },
                { 25, new("Ah, that would explain it. One of my servants found this outside, and it seemed too much of a coincidence that more than one strange object would appear on my land in such a short period of time.", new() { new DialogueChoice("(NEXT)", 26), byeThen }) },
                { 26, new("Please take this to the head wizard at the Wizards' Tower, south-west of here, and don't lose it this time.", new() { byeThen }, items: [ "talismanAir" ]) },
                { 27, new("The only job I had was the delivery of that talisman, so I'm afraid not.", new() { byeThen }) },
                { 28, new("Oh wonderful! What sort of business are you looking to start?", new() { new("I'm looking to get into the milk trade!", 29), byeThen }) },
                { 29, new("Milk? Well, the Groats family still have their permit, and I can't start stepping on their toes.", new() { new("If you'd just try this milk...", 30), byeThen }) },
                { 30, new("I really couldn't possibly give you a permit without their approval. This is really their territory.", new() { new("(NEXT)", 31), byeThen }) },
                { 31, new("Why not speak to Gillie Groats? She seems to handle the milk side of the business now. Maybe she'll get you set up under their permit.", new() { new("You're the Duke. Couldn't you just grant a permit?", 32), byeThen }) },
                { 32, new("No, no. It's really quite important you speak to Gillie about this.", new() { new("Aren't you the highest power in this land?", 33), byeThen }) },
                { 33, new("Don't go digging too deeply into that. Even I have some... commitments that I have to keep to.", new() { new("But you're the duke, you shouldn't need the approval of a business entity to grant a permit.", 34), byeThen }) },
                { 34, new("", new() { new("Not to mention, can't they just refuse to have any competitors?", 35), byeThen }) },
                { 35, new("Well absolutely, but I'm sure you'll find they're more than reasonable about things.", new() { new("(NEXT)", 36), byeThen }) },
                { 36, new("Entirely. Completely reasonable.", new() { byeThen }, "MI_IdesOfMilk", 50) },
                { 37, new("Go speak to Gillie Groats. She seems to handle the milk business in Lumbridge. Maybe she'll get you set up under their permit.", new() { new("Thanks", -1), byeThen }) }
            }));  
             
            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
