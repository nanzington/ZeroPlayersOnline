using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCsVarrock {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();
             
            toAdd.Add(new("Treznor", "mistVarTreznor", new() { { 0, new("Feel free to grow a tree here if you like!", new() { byeThen }) } })); 
                     
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

            toAdd.Add(new("Rat Burgiss", "mistVarBurgiss", new() { 
                { 0, new("Oh, hello. I'd love to chat right now, but I'm a bit busy. Perhaps you could come back and chat another time?", new() { byeThen }) }
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

            toAdd.Add(new("Reldo", "mistVarReldo", new() { 
                { 0, new("Hello there. How can I help you today?", new() { 
                        new DialogueChoice("Tell me about yourself.", 1), 
                        new DialogueChoice("I'm in search of a quest.", 30, [ new("QuestAt", -1, "MI_ShieldOfArrav")]), 
                        new DialogueChoice("About that book... Where is it again?", 36, [ new("QuestAt", 0, "MI_ShieldOfArrav"), new("ItemNotOwned", 1, "bookArrav") ]), 
                        new DialogueChoice("I found that book.", 37, [ new("QuestAt", 0, "MI_ShieldOfArrav"), new("ItemOwned", 1, "bookArrav") ]), 
                        new DialogueChoice("Okay, I've read that book about the Shield of Arrav.", 38, [ new("QuestAt", 5, "MI_ShieldOfArrav") ]), 
                        byeThen 
                }) }, // TODO: Reldo is part of the Varrock tasks thing so some space was left before quest dialogue to slot it in later
                { 1, new("Me? What do you want to know?", new() { new DialogueChoice("What do you do?", 2), new DialogueChoice("Do you have anything to trade?", 6), new DialogueChoice("Do you know any heroic stories?", 8), new DialogueChoice("That's enough about you.", 0), byeThen }) }, 
                { 2, new("I am the palace librarian.", new() { new DialogueChoice("Ah, so that's why you're in the library, then.", 3), byeThen }) },
                { 3, new("Yes.", new() { new DialogueChoice("(NEXT)", 4), byeThen }) },
                { 4, new("Although I would probably be in here even if I didn't work here. I like reading.", new() { new DialogueChoice("(NEXT)", 5), byeThen }) },
                { 5, new("Some day, I hope to catalogue all of the information stored in these books, so all may read it.", new() { new DialogueChoice("(BACK)", 1), byeThen }) },
                { 6, new("Only knowledge.", new() { new DialogueChoice("How much do you want for that, then?", 7), byeThen }) },
                { 7, new("No, sorry, that was just my little joke. I'm not the trading type.", new() { new DialogueChoice("Oh well.", 1), byeThen }) },
                { 8, new("Yes, I do.", new() { new DialogueChoice("(NEXT)", 9), byeThen }) },
                { 9, new("Years ago, a terrible creature slew King Roald's betrothed and terrorized the people. Varrock sent an embassy to Morytania to open a dialogue with Drakan about it.", new() { new DialogueChoice("What happened?", 10), byeThen }) },
                { 10, new("It didn't end happily. Poor Gar'rth, we didn't know he was... Well, it would be unfair for me to say. That's his secret, not mine.", new() { new DialogueChoice("What about the terrible creature?", 11), byeThen }) },
                { 11, new("It was brought to justice, but not before claiming many innocents.", new() { new DialogueChoice("Go on, tell me about Gar'rth.", 12), byeThen }) },
                { 12, new("Another time, perhaps? I have work to do.", new() { new DialogueChoice("Hmpf!", 1), byeThen }) },
                { 30, new("Hmmm, I don't... believe there are any here...", new() { new DialogueChoice("(NEXT)", 31), byeThen }) },
                { 31, new("Let me think.", new() { new DialogueChoice("(NEXT)", 32), byeThen }) },
                { 32, new("Actually...", new() { new DialogueChoice("(NEXT)", 33), byeThen }) },
                { 33, new("Ah, yes. I think I have something, if you're definitely interested?", new() { new DialogueChoice("[Q+] Of course.", 34), new DialogueChoice("Actually, I don't think I am. Goodbye.", -1), byeThen }) },
                { 34, new("Well, if you look around for a book called 'The Shield of Arrav', you'll find a quest in there.", new() { new DialogueChoice("(NEXT)", 35), byeThen }, "MI_ShieldOfArrav", 0) },
                { 35, new("I'm not sure where the book is mind you... but I'm sure it's around here somewhere.", new() { new DialogueChoice("Great! Thank you.", -1), byeThen }) },
                { 36, new("I'm not sure exactly... but I'm sure it's around here somewhere.", new() { byeThen }) },
                { 37, new("Very good. I suggest you give it a read.", new() { byeThen }) },
                { 38, new("Then perhaps you have your quest?", new() { new DialogueChoice("I think I do. Do you know where I can find the Phoenix Gang or the Black Arm Gang?", 39), byeThen }) },
                { 39, new("No, I don't. However, I hear Baraek, the fur trader in the market, has had connections with the Phoenix Gang.", new() { new DialogueChoice("And the Black Arm Gang?", 40), byeThen }, "MI_ShieldOfArrav", 10) },
                { 40, new("There are rumors that they are based in the south west corner of the city. Charlie the Tramp might be able to tell you more. He knows that part of Varrock well.", new() { new DialogueChoice("Thanks! I'll get to it!", -1), byeThen }) }
            }));

            toAdd.Add(new("Charlie the Tramp", "mistVarCharlie", new() { 
                { 0, new("Spare some change guv?", new() { 
                    new DialogueChoice("Who are you?", 1), 
                    new DialogueChoice("Sorry, I haven't got any.", 2, [ new("NotItem", 1, "Gold") ]), 
                    new DialogueChoice("Sorry, I haven't got any. (lie)", 2, [ new("Item", 1, "Gold") ]), 
                    new DialogueChoice("Ok. Here you go.", 3, [ new("Item", 1, "Gold", true) ]),
                    new DialogueChoice("Is there anything down this alleyway?", 5),  
                    byeThen
                }) },
                { 1, new("Charles. Charles E. Trampin' at your service. Now, about that change you were going to give me...", new() { new DialogueChoice("(BACK)", 0), byeThen }) },
                { 2, new("Thanks anyway.", new() { byeThen }) },
                { 3, new("Hey, thanks a lot!", new() { new DialogueChoice("No problem.", -1), new DialogueChoice("Don't I get some sort of quest hint or something now?", 4), byeThen }) },
                { 4, new("Huh? What do you mean? That wasn't why I asked you for money. I just need to eat...", new() { byeThen }) },
                { 5, new("Funny you should mention that... there is actually.", new() { new DialogueChoice("(NEXT)", 6), byeThen }) },
                { 6, new("The ruthless and notorious criminal gang known as the Black Arm Gang have their headquarters down there.", new() { 
                    new DialogueChoice("Thanks for the warning!", 7),  
                    new DialogueChoice("Do you think they would let me join?", 8, [ new("Data", 0, "ArravGangStatus", false, "equals") ]), // Not in a gang
                    new DialogueChoice("Do you think they would let me join?", 9, [ new("Data", 1, "ArravGangStatus", false, "equals") ]), // In Black Arm Gang already
                    new DialogueChoice("Do you think they would let me join?", 10, [ new("Data", 2, "ArravGangStatus", false, "equals") ]), // In Phoenix Gang
                    byeThen 
                }) },
                { 7, new("Don't worry about it.", new() { 
                    new DialogueChoice("Do you think they would let me join?", 8, [ new("Data", 0, "ArravGangStatus", false, "equals") ]), // Not in a gang
                    new DialogueChoice("Do you think they would let me join?", 9, [ new("Data", 1, "ArravGangStatus", false, "equals") ]), // In Black Arm Gang already
                    new DialogueChoice("Do you think they would let me join?", 10, [ new("Data", 2, "ArravGangStatus", false, "equals") ]), // In Phoenix Gang
                    byeThen 
                }) },
                { 8, new("You never know. You'll find a lady down there called Katrine, speak to her. But don't upset her - she's pretty dangerous.", new() { byeThen }) },
                { 9, new("I was under the impression you were already a member...", new() { byeThen }) },
                { 10, new("You're a collaborator with the Phoenix gang, unless you forsake your ties to them then the Black Arm gang probably won't let you in.", new() { byeThen }) }
            }));

            toAdd.Add(new("Baraek", "mistVarBaraek", new() { 
                { 0, new("Mighty fine furs here, you interested?", new() { 
                    new DialogueChoice("Hello! I am in search of a quest.", 5, [ new("QuestBelow", 10, "MI_ShieldOfArrav") ]), 
                    new DialogueChoice("Remind me where I can find the Phoenix Gang.", 11, [ new("QuestPast", 10, "MI_ShieldOfArrav"), new("Data", 1, "ToldAboutPhoenixGang", false, "equals") ]), 
                    new DialogueChoice("Can you tell me where I can find the Phoenix Gang?.", 6, [ new("QuestPast", 10, "MI_ShieldOfArrav"), new("Data", 0, "ToldAboutPhoenixGang", false, "equals") ]), 
                    new DialogueChoice("Can you sell me some furs?", 1),
                    new DialogueChoice("Would you like to buy my fur?", 3, [ new("Item", 1, "fur") ]),
                    byeThen 
                }) }, 
                { 1, new("Yeah, sure. They're 20 gold coins each.", new() { new DialogueChoice("Yeah, okay, here you go.", 2, [ new("Item", 20, "Gold", true) ]), byeThen }) }, 
                { 2, new("(Baraek sells you a fur)", new() { new DialogueChoice("I'll take another, actually.", 2, [ new("Item", 20, "Gold", true) ]), byeThen }, items: [ "fur,1" ], altSpeaker: "-") },
                { 3, new("Let's have a look at it... It's not in the best condition. I guess I could give you 12 coins for it.", new() { new DialogueChoice("Yeah, that'll do.", 4, [ new("Item", 1, "fur", true)]), byeThen }) },
                { 4, new("(Baraek buys your fur)", new() { new DialogueChoice("Here, take another.", 4, [ new("Item", 1, "fur", true) ]), byeThen }, items: [ "Gold,12" ], altSpeaker: "-") },
                { 5, new("Sorry kiddo, I'm a fur trader not a damsel in distress.", new() { byeThen }) },
                { 6, new("Sh sh sh, not so loud! You don't want to get me in trouble!", new() { new DialogueChoice("So DO you know where they are?", 7), byeThen }) },
                { 7, new("I may do. But I don't want to get into trouble for revealing their hideout.", new() { new DialogueChoice("(NEXT)", 8), byeThen }) },
                { 8, new("Of course, if I was, say 10 gold coins richer I may happen to be more inclined to take that sort of risk.", new() { new DialogueChoice("Alright. Have 10 gold coins.", 11, [ new("Item", 10, "Gold") ], true), new DialogueChoice("Yes, I'd like to be 10 gold coins richer.", 9), new DialogueChoice("No, I don't like things like bribery.", 10), byeThen }) },
                { 9, new("What? You're meant to bribe me, not the other way around... Oh, forget it!", new() { byeThen }) },
                { 10, new("Heh. And you want to deal with the Phoenix Gang? They're involved in much worse than a bit of bribery.", new() { byeThen }) },
                { 11, new("To get to the gang hideout, enter Varrock through the south gate. Then, if you take the first turning east, somewhere along there is an alleyway to the south.", new() { new DialogueChoice("(NEXT)", 12), byeThen }, acts: [ new("Data", "ToldAboutPhoenixGang", "set", 1) ]) },
                { 12, new("The door at the end of there is the entrance to the Phoenix Gang. They're operating there under the name of the VTAM Corporation. Be careful. The Phoenixes ain't the types to be messed about.", new() { new DialogueChoice("You're really bad at giving directions.", 13), byeThen }) },
                { 13, new("Hey now... the Phoenix Gang make it their business to not be easy to find.", new() { byeThen }) }
            }));

                toAdd.Add(new("Straven", "mistVarStraven", new() { 
                { 0, new(
                        new List<TextReq> { 
                        new("", [new("Data", 0, "ArravGangStatus", false, "equals")]),
                        new("Black Arm dog! How dare you show your face?", [ new("Data", 1, "ArravGangStatus", false, "equals") ]),
                        new("Black Arm dog! How dare you show your face? I trusted you. I welcomed you into our organization. It's not too late. Return to use. Forsake the Black Arm Gang, and arise like the glorious phoenix that is our namesake.", [ new("Data", 1, "ArravGangStatus", false, "equals"), new("Data", 2, "PhoenixTask", false, "equals") ]),
                        new("Greetings, fellow gang member.", [new("Data", 2, "ArravGangStatus", false, "equals")]),
                        }, new() { 
                        new DialogueChoice("What's through that door?", 1, [ new("Data", 0, "ArravGangStatus", false, "equals")]),
                        new DialogueChoice("I know who you are!", 4, [ new("Data", 1, "ToldAboutPhoenixGang", false, "equals"), new("Data", 2, "ArravGangStatus", false, "notEquals")]),
                        new DialogueChoice("What did you want me to do, again?", 18, [ new("Data", 1, "PhoenixTask", false, "equals"), new("ItemNotOwned", 1, "arravIntel") ]),
                        new DialogueChoice("I have that intelligence report!", 19, [ new("Data", 1, "PhoenixTask", false, "equals"), new("ItemOwned", 1, "arravIntel") ]),
                        new DialogueChoice("I've heard you've got some cool treasures in this place.", 25, [ new("Data", 2, "ArravGangStatus", false, "equals") ]),
                        new DialogueChoice("Any suggestions for where I can go thieving?", 31, [ new("Data", 2, "ArravGangStatus", false, "equals") ]),
                        new DialogueChoice("(REJOIN GANG)", 31, [ new("Data", 1, "ArravGangStatus", false, "equals"), new("Data", 2, "PhoenixTask", false, "equals") ]),
                        byeThen 
                }) }, 
                { 1, new("Hey! You can't come in here. Only authorized personnel of the VTAM Corporation are allowed beyond this point.", new() { new("How do I get a job with the VTAM Corporation?", 2), new("Why not?", 3), new("Farewell.", -1), byeThen }) },
                { 2, new("Get a copy of the Varrock Herald. If we have any positions right now, they'll be advertised in there.", new() { new("(BACK)", 0), byeThen }) },
                { 3, new("Sorry. That's classified information.", new() { new("(BACK)", 0), byeThen }) },
                { 4, new("Really.", new() { new("(NEXT)", 5), byeThen }) },
                { 5, new("Well?", new() { new("(NEXT)", 6), byeThen }) },
                { 6, new("Who are we then?", new() { new("This is the headquarters of the Phoenix Gang, the most powerful crime syndicate this city has ever seen!", 7), byeThen }) },
                { 7, new("No, this is a legitimate business run by legitimate businessmen.", new() { new("(NEXT)", 8), byeThen }) },
                { 8, new("Supposing we were this 'Phoenix Gang', however, what would you want with us?", new() { 
                    new("I'd like to offer you my services.", 10), 
                    new("I want nothing. I was just making sure you were them.", 9), 
                    byeThen 
                }) },
                { 9, new("Well, then get lost and stop wasting my time... if you know what's good for you.", new() { byeThen }) },
                { 10, new("You mean you'd like to join the Phoenix Gang?", new() { new("(NEXT)", 11), byeThen }) },
                { 11, new("Well, obviously I can't speak for them, but the Phoenix Gang doesn't let people join just like that.", new() { new("(NEXT)", 12), byeThen }) },
                { 12, new("You can't be too careful, you understand.", new() { new("(NEXT)", 13), byeThen }) },
                { 13, new("Generally someone has to prove their loyalty before they can join.", new() { new("How would I go about doing that?", 14), byeThen }) },
                { 14, new("Obviously, I would have no idea about that.", new() { new("(NEXT)", 15), byeThen }) },
                { 15, new("Although having said that, a rival gang of ours, er, theirs, called the Black Arm Gang is supposedly meeting a contact from Port Sarim today in the Blue Moon Inn.", new() { new("(NEXT)", 16), byeThen }) },
                { 16, new("The Blue Moon inn is just by the south entrance to this city, and supposedly the name of the contact is Jonny the Beard.", new() { new("(NEXT)", 17), byeThen }) },
                { 17, new("OBVIOUSLY I know NOTHING about the dealings of the Phoenix Gang, but I bet if SOMEBODY were to kill him and bring back his intelligence report, they would be considered loyal enough to join.", new() { new("I'll get right on it.", -1), byeThen }, acts: [ new("Data", "PhoenixTask", "set", 1) ]) },
                { 18, new("You need to kill Jonny the Beard, who should be in the Blue Moon Inn... I would guess. Not being a member of the Phoenix Gang and all.", new() { byeThen }) },
                { 19, new("Let's see it then.", new() { 
                    new("Let me go get it.", 20, [ new("NotItem", 1, "arravIntel")]), 
                    new("Here you go.", 21, [ new("Item", 1, "arravIntel", true)]), 
                    byeThen 
                }) },
                { 20, new("I'll wait here.", new() { byeThen }) },
                { 21, new("(You hand over the report. Straven reads it)", new() { new("(NEXT)", 22), byeThen }, acts: [ new("Data", "PhoenixTask", "set", 2), new("Data", "ArravGangStatus", "set", 2)], altSpeaker: "-") },
                { 22, new("Yes. Yes, this is very good.", new() { new("(NEXT)", 23), byeThen }) },
                { 23, new("Very well, then! You can join the Phoenix Gang! I am Straven, one of the gang leaders.", new() { new("Nice to meet you.", 24), byeThen }) },
                { 24, new("You now have access to the inner sanctum of our subterranean hideout, and our weapons supply depot round the front of this building.", new() { byeThen }) },
                { 25, new("Oh yeah, we've all stolen some stuff in our time. Those candlesticks down here, for example, were quite a challenge to get out of the palace.", new() { new("And the shield of Arrav? I heard you got that!", 26), byeThen }) },
                { 26, new("Whoa... that's a blast from the past! We stole that years and years ago! We don't even have all the shield anymore.", new() { new("(NEXT)", 27), byeThen }) },
                { 27, new("About five years ago we had a massive fight in our gang and the shield got broken in half during that fight.", new() { new("(NEXT)", 28), byeThen }) },
                { 28, new("Shortly after the fight some gang members decided they didn't want to be part of our gang anymore. So they split off to form their own gang.", new() { new("(NEXT)", 29), byeThen }) },
                { 29, new("The Black Arm Gang.", new() { new("(NEXT)", 30), byeThen }) },
                { 30, new("On their way out they looted what treasures they could from us - which included one of the halves of the shield. We've been rivals with the Black Arms ever since.", new() { new("(BACK)", 0), byeThen }) },
                { 31, new("You can always try the marketplace in Ardougne. LOTS of opportunity there!", new() { new("(BACK)", 0), byeThen }) }
            }));

            toAdd.Add(new("Weaponmaster", "mistVarWeaponmaster", new() { 
                { 0, new(
                        new List<TextReq> { 
                        new("Hello, fellow Phoenix! What do you seek?", [new("Data", 2, "ArravGangStatus", false, "equals")]),
                        new("Only members of the Phoenix Gang are allowed up here. Find your own weapon stash.") 
                        }, new() { 
                        new DialogueChoice("I'm after a weapon or two.", 1, [ new("Data", 2, "ArravGangStatus", false, "equals")]),  
                        new DialogueChoice("I'm looking for treasure.", 2, [ new("Data", 2, "ArravGangStatus", false, "equals")]),
                        byeThen 
                }) }, 
                { 1, new("No problem. Feel free to look around.", new() { byeThen }) },
                { 2, new("Aren't we all? We've not got any in here. Go mug someone somewhere if you want some treasure.", new() { byeThen }) }
            }));

            toAdd.Add(new("Katrine", "mistVarKatrine", new() { 
                { 0, new( new List<TextReq> {
                        new("Have you got those crossbows for me yet?", [ new("Data", 1, "BlackArmTask", false, "equals") ]),
                        new("Hey.", [ new("Data", 1, "ArravGangStatus", false, "equals") ]),
                        new("You've got some guts coming here, Phoenix scum!", [ new("Data", 2, "ArravGangStatus", false, "equals"), new("Data", 2, "BlackArmTask", false, "equals") ]),
                        new("(Katrine says nothing. She just stands there... menacingly)")
                    }, new() { 
                    new DialogueChoice("What is this place?", 1, [ new("Data", 0, "BlackArmTask", false, "equals") ]), 
                    new DialogueChoice("No, I haven't yet found them.", 17, [ new("Data", 1, "BlackArmTask", false, "equals"), new("ItemNotOwned", 1, "crossbowPhoenix")]), 
                    new DialogueChoice("Yes, I have.", 18, [ new("Data", 1, "BlackArmTask", false, "equals"), new("Item", 2, "crossbowPhoenix", true) ]), 
                    new DialogueChoice("Who are all those people in there?", 19, [ new("Data", 1, "ArravGangStatus", false, "equals") ]),  
                    new DialogueChoice("Teach me to be a top class criminal!", 21, [ new("Data", 1, "ArravGangStatus", false, "equals") ]), 
                    new DialogueChoice("(NEXT)", 22, [ new("Data", 2, "ArravGangStatus", false, "equals"), new("Data", 2, "BlackArmTask", false, "equals") ]), 
                    byeThen 
                }) },
                { 1, new("It's a private business. Can I help you at all?", new() { new DialogueChoice("I've heard you're the Black Arm Gang.", 2), byeThen }) },
                { 2, new("Who told you that?", new() { new DialogueChoice("I'd rather not reveal my sources.", 3), byeThen }) },
                { 3, new("Hmm... I suppose I can understand that. So, say we were the Black Arm Gang, what would you want with us?", new() { new DialogueChoice("I want to become a member of your gang.", 6), new DialogueChoice("I want some hints on becoming a thief.", 5), new DialogueChoice("I'm looking for the door out of here.", 4), byeThen }) },
                { 4, new("Try... the one you just came through?", new() { byeThen }) },
                { 5, new("Do you now? And what makes you think I'll provide anything like that in return?", new() { new DialogueChoice("Well, how about I become a member of your gang in return?", 6), byeThen }) },
                { 6, new("How unusual... Okay, let's say we are who you believe we are. Do you think we'd be recruiting people who just waltz in here saying 'hello, I'd like to play'?", new() { new DialogueChoice("I don't know. What would be the alternative?", 7), byeThen }) },
                { 7, new("Watching local thugs and thieves in action, perhaps? How do I know I can just trust someone who's wandered in here.", new() { new DialogueChoice("Well, you can give me a try can't you?", 8), new DialogueChoice("Well, people tell me I have an honest face.", 9), byeThen }) },
                { 8, new("I'm not so sure...", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                { 9, new("Someone honest wanting to join a gang of thieves? Excuse me if I remain unconvinced...", new() { new DialogueChoice("(NEXT)", 10), byeThen }) },
                { 10, new("Thinking about it... I may have a solution actually. You may have heard of the Phoenix Gang. I hear they have a very nice weapons stash not too far from here.", new() { new DialogueChoice("(NEXT)", 11), byeThen }) },
                { 11, new("We're fresh out of crossbows, but apparently they have plenty. If someone were to acquire a couple for us, it would be very much appreciated.", new() { new DialogueChoice("Sounds simple enough. Any particular reason you need them?", 12), byeThen }) },
                { 12, new("Let's just say there's a local merchant who is refusing to pay some very reasonable 'keep-your-life-pleasant' insurance rates.", new() { new DialogueChoice("So you're planning to murder him?", 13), byeThen }) },
                { 13, new("Him? No. However, I hear that the local law might soon be finding a crossbow belonging to the Phoenix Gang in his home...", new() { new DialogueChoice("(NEXT)", 14), byeThen }) },
                { 14, new("I also hear a similar type of crossbow might soon be used in a murder on the other side of the city...", new() { new DialogueChoice("(NEXT)", 15), byeThen }) },
                { 15, new("Now, are you going to keep asking questions, or are you going to get those crossbows?", new() { new DialogueChoice("Okay, no problem.", 16), byeThen }) },
                { 16, new("Great! Apparently the Phoenix Gang's weapons stash is somewhere to the east. ", new() { byeThen }, acts: [ new("Data", "BlackArmTask", "set", 1) ]) },
                { 17, new("I need two crossbows from the Phoenix Gang weapons stash, which if you had east for a bit, is a building on the south side of the road. Come back when you got 'em.", new() { byeThen }) },
                { 18, new("You're now a Black Arm Gang member. Feel free to enter any of the rooms of the ganghouse.", new() { byeThen }, acts: [ new("Data", "BlackArmTask", "set", 2), new("Data", "ArravGangStatus", "set", 1)]) },
                { 19, new("They're just various rogues and thieves.", new() { new DialogueChoice("They don't say a lot...", 20), byeThen }) },
                { 20, new("Nope.", new() { new("(BACK)", 0), byeThen }) },
                { 21, new("Teach yourself.", new() { new("(BACK)", 0), byeThen }) },
                { 22, new("(Katrine spits)", new() { new("(NEXT)", 23), byeThen }, altSpeaker: "-") },
                { 23, new("You got me the phoenix crossbows. You passed your initiation. And then you betrayed the Black Arm Gang. What's the matter with you?", new() { new("(NEXT)", 24), byeThen }) },
                { 24, new("It's not too late for you. Return to the open... arm of the Black Arm Gang, and all shall be forgiven.", new() { new("(REJOIN GANG)", 25), byeThen }) },
                { 25, new("Alright. I forgive you. Welcome back to the Black Arm Gang. Don't let it happen again.", new() { byeThen }, acts: [ new("Data", "ArravGangStatus", "set", 1) ]) }
            }));

            toAdd.Add(new("Aubury", "mistVarAubury", new() { 
                { 0, new("Do you want to buy some runes?", new() { 
                    new DialogueChoice("Yes please!", -1),
                    new DialogueChoice("Oh, it's a rune shop. No thank you, then.", 1), 
                    new DialogueChoice("Can you tell me about your cape?", 2), 
                    new DialogueChoice("I've been sent here with a package for you.", 6, [ new("QuestAt", 20, "MI_RuneMysteries") ]), 
                    new DialogueChoice("Anything useful in that package I gave you?", 9, [ new("QuestAt", 30, "MI_RuneMysteries") ]),
                    new DialogueChoice("Sorry, I lost those notes you gave me.", 15, [ new("QuestAt", 40, "MI_RuneMysteries"), new("ItemNotOwned", 1, "rmNotes") ]),  
                    new DialogueChoice("Could you teleport me to the essence mine?", 16, [ new("QuestAt", 60, "MI_RuneMysteries")], tele: "RunecraftEssenceMine"), 
                    byeThen 
                }) },
                { 1, new("Well, if you find someone who does want runes, please send them my way.", new() { byeThen }) },
                { 2, new("Certainly! Skillcapes are a symbol of achievement. Only people who have mastered a skill and reached level 99 can get their hands on them and gain the benefits they carry.", new() { new DialogueChoice("(NEXT)", 3),byeThen }) },
                { 3, new("The Cape of Runecrafting has been upgraded with each talisman, allowing you to access all altars.", new() { new DialogueChoice("I'd like to buy one!", 4, [ new("Item", 99000, "Gold", true), new("Skill", 99, "Runecrafting")], true), byeThen }) },
                { 4, new("Excellent choice! Welcome to an elite club, my friend. Just don't open a competing rune store with all those runes you can make!", new() { new("(NEXT)", 5), byeThen }, items: [ "capeSkillRunecrafting" ]) },
                { 5, new("...No, really. I get so few customers as it is.", new() { byeThen }) },
                { 6, new("A package? From who?", new() { new("From Sedridor, at the Wizards' Tower.", 7), byeThen }) },
                { 7, new("From Sedridor? But... surely he can't have? Please, let me have it. It must be extremely important for him to have sent a stranger.", new() { 
                    new("Sure, here you go.", 9, [ new("Item", 1, "rmPackage", true)]), 
                    new("Uh... yeah... about that... I kind of don't have it with me...", 8, [ new("NotItem", 1, "rmPackage", true)]), 
                    byeThen
                }) },
                { 8, new("What kind of person says they have a delivery for me, but not with them? Honestly. Come back when you have it.", new() { byeThen }) },
                { 9, new("Now, let's have a look...", new() { new("(NEXT)", 10), byeThen }, "MI_RuneMysteries", 30) },
                { 10, new("(Aubury goes through the package of research notes)", new() { new("(NEXT)", 11), byeThen }, altSpeaker: "-") },
                { 11, new("My gratitude to you adventurer for bringing me these research notes. Thanks to you, I think we finally have it.", new() { new("You mean the incantation?", 12), byeThen }) },
                { 12, new("Well when we combine my own research with this latest discovery, I think we might just...", new() { new("(NEXT)", 13), byeThen }) },
                { 13, new("No, no, I'm getting ahead of myself. The signs are promising, but let's not jump to any conclusions just yet.", new() { new("(NEXT)", 14), byeThen }) },
                { 14, new("Here, take these notes back to Sedridor. They should hopefully give him everything he needs.", new() { byeThen }, "MI_RuneMysteries", 40, [ "rmNotes"]) },
                { 15, new("Well, luckily I have duplicates. It's a good thing they are written in code. I wouldn't want the wrong kind of person to get access to the information contained within.", new() { byeThen }, "MI_RuneMysteries", 40, [ "rmNotes"]) },
                { 16, new("Seventior disthine molenko!", new() { byeThen }, acts: [ new("Data", "LastTeleportToEssenceMine", "set", 2) ] ) }
            }));

            toAdd.Add(new("Dr. Harlow", "mistVarHarlow", new() { 
                { 0, new("Buy me a drink pleassh...", new() { new("I think you've had enough.", -1), byeThen }) }
            }));

            toAdd.Add(new("Bartender", "mistVarBlueBartender", new() { 
                { 0, new("What can I do yer for?", new() { new("A glass of your finest ale please.", 1), new("Can you recommend where an adventurer might make his fortune?", 3), new("Do you know where I can get some good equipment?", 7), byeThen }) },
                { 1, new("No problemo. That'll be 2 coins.", new() { new("(PAY)", 2, [ new("Item", 2, "Gold") ]), byeThen }) },
                { 2, new("Here ya go.", new() { new("Another round, barkeep!", 2, [ new("Item", 2, "Gold") ]), byeThen }, items: [ "beer" ]) },
                { 3, new("Ooh I don't know if I should be giving away information, makes the game too easy.", new() { new("Oh ah well...", -1), new("Game? What are you talking about?", 4), new("Just a small clue?", 6), byeThen }) },
                { 4, new("This world around us... is an online game... called RuneScape.", new() { new("Nope, still don't understand what you are talking about. What does 'online' mean?", 5), byeThen }) },
                { 5, new("It's a sort of connection between magic boxes across the world, big boxes on people's desktops and little ones people can carry. They can talk to eachother to play games.", new() { new("I give up. You're obviously completely mad!", -1), byeThen }) },
                { 6, new("Go and talk to the bartender at the Jolly Boar Inn, he doesn't seem to mind giving away clues.", new() { byeThen }) },
                { 7, new("Well, there's the sword shop across the road, or there's also all sorts of shops up around the market.", new() { byeThen }) }
            }));

            toAdd.Add(new("Cook", "mistVarBlueCook", new() { 
                { 0, new("What do you want? I'm a little busy here, so make it quick!", new() { new("Can you sell me any food?", 1), new("Can you give me any free food?", 4), new("I don't want anything from this horrible kitchen.", 6), byeThen }) },
                { 1, new("I suppose I could sell you some cabbage, if you're willing to pay for it. Cabbage is good for you.", new() { new("Alright, I'll buy a cabbage.", 2, [ new("Item", 1, "Gold") ]), new("No thanks, I don't like cabbage.", 3), byeThen }) },
                { 2, new("It's a deal. Now, make sure you eat it all up. Cabbage is good for you.", new() { byeThen }, items: [ "cabbage" ]) },
                { 3, new("Bah! People these days only appreciate junk food.", new() { byeThen }) },
                { 4, new("Can you give me any free money?", new() { new("Why should I give you free money?", 5), byeThen }) },
                { 5, new("Why should I give you free food?", new() { new("Oh, forget it.", -1), byeThen }) },
                { 6, new("How dare you? I put a lot of effort into cleaning this kitchen. My daily sweat and elbow-grease keep this kitchen clean!", new() { new("Ewww!", 7), byeThen }) },
                { 7, new("Oh, just leave me alone.", new() { byeThen }) }
            }));

            toAdd.Add(new("King Roald", "mistVarKingRoald", new() { 
                { 0, new("(The King appears to be a very busy man)", new() { 
                    new("Greetings, your majesty.", 1), 
                    new("Your majesty, I have recovered the Shield of Arrav; I would like to claim the reward.", 3, [ new("QuestAt", 30, "MI_ShieldOfArrav"), new("Item", 1, "arravShieldLeft"), new("Item", 1, "arravSHieldRight") ]), 
                    new("Your majesty, I have come to claim the reward for the return of the Shield of Arrav.", 5, [ new("QuestAt", 40, "MI_ShieldOfArrav"), new("Item", 1, "arravShield") ]), 
                    byeThen 
                }) },
                { 1, new("Do you have anything of importance to say?", new() { new("...Not really.", 2), byeThen }) },
                { 2, new("You will have to excuse me, then. I am very busy as I have a kingdom to run!", new() { byeThen }) },
                { 3, new("The Shield of Arrav, eh? Yes, I do recall my father, King Roald, put a reward out for that.", new() { new("(NEXT)", 4), byeThen }) },
                { 4, new("The Shield of Arrav is broken, however. I cannot accept it in its current state.", new() { byeThen }) },
                { 5, new("My goodness! My father set a bounty on this shield many years ago!", new() { new("(NEXT)", 6), byeThen }) },
                { 6, new("I never thought I would live to see the day when someone came forward to claim it.", new() { new("(NEXT)", 7), byeThen }) },
                { 7, new("1,200 coins was a fortune in my father's day. I hope it serves you well in your adventures.", new() { new("(GIVE SHIELD)", 8, [ new("Item", 1, "arravShield", true) ]), byeThen }) },
                { 8, new("The museum of Varrock shall proudly display the Shield of Arrav once again.", new() { byeThen }, "MI_ShieldOfArrav", 50) }
            })); 
            
            toAdd.Add(new("Gertrude", "mistVarGertrude", new() { 
                { 0, new(new List<TextReq>() {
                    new("(Gertrude looks quite distressed)", [ new("QuestAt", -1, "MI_GertrudesCat")]), 
                    new("Have you seen my poor Fluffs?", [ new("QuestAt", 0, "MI_GertrudesCat")]),
                    new("Hello again, did you manage to find Shilop? I can't keep an eye on him for the life of me.", [ new("QuestAt", 10, "MI_GertrudesCat")]),
                    new("Hello. How's it going? Any luck?", [ new("QuestPast", 20, "MI_GertrudesCat"), new("QuestBelow", 80, "MI_GertrudesCat")]),
                    new("Hello! Is there anything I can do for you?")
                }, new() { 
                    new("Hello, are you okay?", 1, [ new("QuestAt", -1, "MI_GertrudesCat")]),
                    new("I'm afraid not.", 8, [ new("QuestAt", 0, "MI_GertrudesCat")]),
                    new("He does seem quite a handful.", 10, [ new("QuestAt", 10, "MI_GertrudesCat")]),
                    new("Yes, I've found Fluffs!", 12, [ new("QuestPast", 20, "MI_GertrudesCat"), new("QuestBelow", 60, "MI_GertrudesCat")]),
                    new("Hello Gertrude. Fluffs ran off with her kitten.", 17, [ new("QuestAt", 70, "MI_GertrudesCat")]),
                    byeThen 
                }) },
                { 1, new("Do I look okay? Those kids drive me crazy.", new() { new("(NEXT)", 2), byeThen }) },
                { 2, new("I'm sorry. It's just that I've lost her.", new() { new("Lost who?", 3), byeThen }) },
                { 3, new("Fluffs, poor Fluffs. She never hurt anyone.", new() { new("Who's Fluffs?", 4), byeThen }) },
                { 4, new("My beloved feline friend Fluffs. She's been purring by my side for almost a decade. Please, could you go search for her while I look over the kids?", new() { new("[Q+] Well, I suppose I could.", 6), new("Sorry, I'm too busy to play pet rescue.", 5), byeThen }) },
                { 5, new("Well, okay then. I'll have to find someone else.", new() { byeThen }) },
                { 6, new("Really? Thank you so much! I really have no idea where she could be!", new() { new("(NEXT)", 7), byeThen }) },
                { 7, new("I think my sons, Shilop and Wilough, saw the cat last. They'll be out in the plaza.", new() { new("Alright then, I'll see what I can do.", -1), byeThen }, "MI_GertrudesCat", 0) },
                { 8, new("What about Shilop?", new() { new("No sign of him either.", 9), byeThen }) },
                { 9, new("Hmmm... strange, he should be at the market.", new() { byeThen }) },
                { 10, new("You have no idea! Did he help at all?", new() { new("I think so, I'm just going to look now.", 11), byeThen }) },
                { 11, new("Thanks again, adventurer.", new() { byeThen }) },
                { 12, new("Well well, you are clever! Did you bring her back?", new() { 
                    new("Well, that's the thing, she refuses to leave.", 13, [new("QuestAt", 20, "MI_GertrudesCat")]),
                    new("Well, that's the thing, she refuses to leave.", 14, [new("QuestAt", 40, "MI_GertrudesCat")]),
                    new("Well, that's the thing, she refuses to leave.", 16, [new("QuestAt", 60, "MI_GertrudesCat")]),
                    byeThen 
                }) },
                { 13, new("Oh dear, oh dear! Maybe she's just thirsty. She loves milk! I haven't got any but it can't be too hard to get some!", new() { byeThen }) },
                { 14, new("Oh dear, oh dear! Maybe she's just hungry. She loves doogle sardines but I'm all out.", new() { new("Doogle sardines?", 15), byeThen }) },
                { 15, new("Yes, raw sardines seasoned with doogle leaves. Unfortunately I've used all my doogle leaves, but you can get some from the bushes out back.", new() { byeThen }) },
                { 16, new("Well that is strange, there must be a reason. Maybe look around nearby?", new() { byeThen }) },
                { 17, new("You're back! Thank you! Thank you! Fluffs just came back! I think she was just upset as she couldn't find her kitten.", new() { new("(NEXT)", 18), byeThen }) },
                { 18, new("(Gertrude gives you a hug)", new() { new("NEXT", 19), byeThen }, altSpeaker: "-") },
                { 19, new("If you hadn't found her kitten it would have died out there!", new() { new("That's okay, I like to do my bit.", 20), byeThen }) },
                { 20, new("I don't know how to thank you. I have no real material possessions. I do have kittens! I can only really look after one.", new() { new("Well, if it needs a home.", 21), byeThen }) },
                { 21, new("I would sell it to my cousin in West Ardougne. I hear there's a rat epidemic out there. But it's too far.", new() { new("(NEXT)", 22), byeThen }) },
                { 22, new("Here you go, look after her and thank you again!", new() { new("(NEXT)", 23), byeThen }) },
                { 23, new("Oh by the way, the kitten can live in your backpack, but to make it grow you must take it out and feed it and stroke it often.", new() { new("(NEXT)", 24), byeThen }) },
                { 24, new("(Gertrude gives you a kitten... and some food!)", new() { byeThen }, "MI_GertrudesCat", 80, altSpeaker: "-") }
            }));

            toAdd.Add(new("Shilop", "mistVarShilop", new() { 
                { 0, new("(Shilop and his brother are playing in the plaza)", new() { 
                    new("Hello youngster!", 1, [ new("QuestAt", -1, "MI_GertrudesCat")]), 
                    new("Hello there, I've been looking for you.", 3, [ new("QuestAt", 0, "MI_GertrudesCat")]), 
                    new("Where did you say you saw Fluffs?", 18, [ new("QuestAt", 10, "MI_GertrudesCat")]), 
                    byeThen 
                }, altSpeaker: "-") },
                { 1, new("I don't talk to strange old people.", new() { new("Hey who you calling old?! And strange?!", 2), byeThen }) },
                { 2, new("You obviously. Old, strange, and stupid.", new() { new("Whatever.", -1), byeThen }) },
                { 3, new("I didn't mean to take it! I just forgot to pay.", new() { new("What? I'm trying to help your mum find Fluffs.", 4), byeThen }) },
                { 4, new("I might be able to help. Fluffs followed me to my secret play area, I haven't seen her since.", new() { new("Where is this play area?", 5), byeThen }, altSpeaker: "Wilough") },
                { 5, new("If I told you that, it wouldn't be a secret.", new() { new("Tell me sonny, or I will hurt you.", 6), new("What will make you tell me?", 7), byeThen }, altSpeaker: "Wilough") },
                { 6, new("W..wh..what?! Y..you wouldn't! A young lad like me! I'd have you behind bars before nightfall!", new() { new("(You decided it's best not to hurt the boy.)", -1), byeThen }, altSpeaker: "Wilough") },
                { 7, new("Well... now you ask, I am a bit short on cash.", new() { new("How much?", 8), byeThen }) },
                { 8, new("10 coins.", new() { new("(NEXT)", 9), byeThen }) },
                { 9, new("10 coins?!", new() { new("(NEXT)", 10), byeThen }, altSpeaker: "Wilough") },
                { 10, new("I'll handle this.", new() { new("(NEXT)", 11), byeThen }, altSpeaker: "Wilough") },
                { 11, new("100 coins should cover it.", new() { new("100 coins! Why should I pay you?", 12), byeThen }, altSpeaker: "Wilough") },
                { 12, new("You shouldn't, but we won't help otherwise. We never liked that cat anyway, so what do you say?", new() { new("I'm not paying you a penny.", 13), new("Okay then, I'll pay.", 14, [ new("Item", 100, "Gold", true) ], true), new("Well never mind, it's Fluffs' loss.", 17), byeThen }, altSpeaker: "Wilough") },
                { 13, new("Okay then, I'll find another way to make money.", new() { byeThen }, altSpeaker: "Wilough") },
                { 14, new("", new() { new("There you go, now where did you see Fluffs?", 15), byeThen }, altSpeaker: "Wilough") },
                { 15, new("I play at the lumber mill to the north east. Just go out the east gate then north. I saw Fluffs running around in there.", new() { new("Anything else?", 16), byeThen }, "MI_GertrudesCat", 10, altSpeaker: "Wilough") },
                { 16, new("Well, you'll have to find the broken fence to get in. I'm sure you can manage that.", new() { byeThen }, altSpeaker: "Wilough") },
                { 17, new("I'm sure my mum will get over it.", new() { byeThen }, altSpeaker: "Wilough") },
                { 18, new("Weren't you listening? I saw the flea bag in the old lumber mill just north east of here. Just go out the east gate and north and you should find it.", new() { byeThen }, altSpeaker: "Wilough") }
            }));

            toAdd.Add(new("Wilough", "mistVarWilough", new() { 
                { 0, new("(Wilough and his brother are playing in the plaza)", new() { 
                    new("Hello youngster!", 1, [ new("QuestAt", -1, "MI_GertrudesCat")]), 
                    new("Hello there, I've been looking for you.", 3, [ new("QuestAt", 0, "MI_GertrudesCat")]), 
                    new("Where did you say you saw Fluffs?", 18, [ new("QuestAt", 10, "MI_GertrudesCat")]), 
                    byeThen 
                }, altSpeaker: "-") },
                { 1, new("I don't talk to strange old people.", new() { new("Hey who you calling old?! And strange?!", 2), byeThen }) },
                { 2, new("You obviously. Old, strange, and stupid.", new() { new("Whatever.", -1), byeThen }) },
                { 3, new("I didn't mean to take it! I just forgot to pay.", new() { new("What? I'm trying to help your mum find Fluffs.", 4), byeThen }) },
                { 4, new("Ohh... well, in that case I might be able to help. Fluffs followed me to my secret play area, I haven't seen her since.", new() { new("Where is this play area?", 5), byeThen }) },
                { 5, new("If I told you that, it wouldn't be a secret.", new() { new("Tell me sonny, or I will hurt you.", 6), new("What will make you tell me?", 7), byeThen }) },
                { 6, new("W..wh..what?! Y..you wouldn't! A young lad like me! I'd have you behind bars before nightfall!", new() { new("(You decided it's best not to hurt the boy.)", -1), byeThen }) },
                { 7, new("Well... now you ask, I am a bit short on cash.", new() { new("How much?", 8), byeThen }, altSpeaker: "Shilop") },
                { 8, new("10 coins.", new() { new("(NEXT)", 9), byeThen }, altSpeaker: "Shilop") },
                { 9, new("10 coins?!", new() { new("(NEXT)", 10), byeThen }) },
                { 10, new("I'll handle this.", new() { new("(NEXT)", 11), byeThen }) },
                { 11, new("100 coins should cover it.", new() { new("100 coins! Why should I pay you?", 12), byeThen }) },
                { 12, new("You shouldn't, but we won't help otherwise. We never liked that cat anyway, so what do you say?", new() { new("I'm not paying you a penny.", 13), new("Okay then, I'll pay.", 14, [ new("Item", 100, "Gold", true) ], true), new("Well never mind, it's Fluffs' loss.", 17), byeThen }) },
                { 13, new("Okay then, I'll find another way to make money.", new() { byeThen }) },
                { 14, new("", new() { new("There you go, now where did you see Fluffs?", 15), byeThen }) },
                { 15, new("I play at the lumber mill to the north east. Just go out the east gate then north. I saw Fluffs running around in there.", new() { new("Anything else?", 16), byeThen }, "MI_GertrudesCat", 10) },
                { 16, new("Well, you'll have to find the broken fence to get in. I'm sure you can manage that.", new() { byeThen }) },
                { 17, new("I'm sure my mum will get over it.", new() { byeThen }) },
                { 18, new("Weren't you listening? I saw the flea bag in the old lumber mill just north east of here. Just go out the east gate and north and you should find it.", new() { byeThen }) }
            }));

            toAdd.Add(new("Fluffs the Cat", "mistVarFluffs", new() { 
                { 0, new("Mioaww", new() { 
                    new("(Try to pick up)", 1, [ new("QuestAt", 10, "MI_GertrudesCat") ]), 
                    new("(Give some milk)", 2, [ new("QuestAt", 20, "MI_GertrudesCat"), new("Item", 1, "bucketMilk", true) ]), 
                    new("(Try to pick up)", 3, [ new("QuestAt", 30, "MI_GertrudesCat") ]),  
                    new("(Give a seasoned sardine)", 4, [ new("QuestAt", 40, "MI_GertrudesCat"), new("Item", 1, "sardineSeasoned", true) ]),
                    new("(Try to pick up)", 5, [ new("QuestAt", 50, "MI_GertrudesCat") ]),
                    new("(Return kitten)", 6, [ new("QuestAt", 60, "MI_GertrudesCat"), new("Item", 1, "kittenFluffs", true) ]),
                    byeThen 
                }) },
                { 1, new("Hisss!", new() { new("Maybe the cat is thirsty?", -1), byeThen }, "MI_GertrudesCat", 20) },
                { 2, new("Mew!", new() { new("(Try to pick up)", 3), byeThen }, "MI_GertrudesCat", 30) },
                { 3, new("Hisss!", new() { new("(Maybe the cat is hungry?)", -1), byeThen }, "MI_GertrudesCat", 40) },
                { 4, new("Mew!", new() { new("(Try to pick up)", 5), byeThen }, "MI_GertrudesCat", 50) },
                { 5, new("Hisss!", new() { new("(The cat seems afraid to leave. In the distance you can hear kittens mewing...)", -1), byeThen }, "MI_GertrudesCat", 60) },
                { 6, new("Purr...", new() { new("(Fluffs has run off home with her offspring)", -1), byeThen }, "MI_GertrudesCat", 70) }
            }));
             
            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
