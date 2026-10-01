using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedQuests {
        public static void InitQuests(Dictionary<string, Quest> QuestLib) {
            List<Quest> toAdd = new();

            toAdd.Add(new("TI_HauntedIsland", "The Haunted Island", "Very Short", "Novice", "Strange things keep happening around the island. Noises without a source and resources harvested when nobody is around. Are there actually zero players online? Maybe Father Guy would know more.", 90, new() { "Misthalin" }) {
                StartNPC = "tiFatherGuy",
                StartLoc = "TI_Temple",
                DateFullyImplemented = 20260828,
                Rewards = { new("Experience", "Prayer", 500) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("Father Guy has suggested I take a look around the island to find places the ghost lingers, and see if there are any suspicious items around that might help him move on.", 10, "ExamineItem", "TI_HI_RustedSword")
                    },
                    {
                        10,
                        new("I found a rusted sword in the caverns with 'PlayerOne' etched into the hilt. I should look for more clues before returning to Father Guy with my findings.", 20, "ExamineItem", "TI_HI_CrumpledNote")
                    },
                    {
                        20,
                        new("A crumpled note on the ground at the main hub of the island has some text indicating the ghost might have been a player at some point. I should go speak with Father Guy to ask him about this.", 30, "SpeakToNPC", "tiFatherGuy")
                    },
                    {
                        30,
                        new("Father Guy has confirmed my suspicion that this ghost, PlayerOne, was one of the earliest players of the game. Unfortunately the good Father was only added in an update after the ghost was already here. I'll have to find someone who has been around long enough to have some information.", 40, "SpeakToNPC", "tutorFishing")
                    },
                    {
                        40,
                        new("The Old Fisherman told me that PlayerOne was, as the name might suggest, the very first player to join the game. They seem to have been unable to leave the island and got trapped here somehow. He suggested I go ask the bank for any record they have of PlayerOne.", 50, "SpeakToNPC", "tutorBanking")
                    },
                    {
                        50,
                        new("PlayerOne's account with the bank was closed out due to an error and I was given their items. I should inspect the items to see what I can find.", 60, "ExamineItem", "TI_HI_StrangeRune")
                    },
                    {
                        60,
                        new("One of the items from PlayerOne's bank was a rune with a strange symbol on it that I don't recognize. Someone knowledgeable about runes may know more.", 70, "SpeakToNPC", "tutorRunecrafting")
                    },
                    {
                        70,
                        new("The Runecrafting Tutor says the strange rune was used for an old magic system before the game was updated, part of a spell to leave the island. Wizard Terrova teleports people on now, so he might know enough for me to finish this quest and let PlayerOne finally leave.", 80, "SpeakToNPC", "tiWizardTerrova")
                    },
                    {
                        80,
                        new("Wizard Terrova cast the spell to teleport a player to Lumbridge on PlayerOne, causing them to fade away. Given the apparent lack of effects that would normally accompany the spell, Terrova speculated that the automated login system of the game might have finally noticed PlayerOne's broken avatar and logged it out properly. All that's left to do is go bring Father Guy up to speed. ", 90, "ExamineItem", "tiFatherGuy")
                    },
                    {
                        90,
                        new("Father Guy has confirmed that he no longer feels the presence of PlayerOne on the island.", 90)
                    }
                }
            });

            toAdd.Add(new("MI_SheepShearer", "Sheep Shearer", "Very Short", "Novice", "Farmer Fred's sheep are getting mighty woolly. He will pay you to shear them.", 10, new() { "Misthalin" }) {
                StartNPC = "mistLumFred",
                StartLoc = "MIST_LumbridgeFredsFarm",
                DateFullyImplemented = 20260913,
                Rewards = { new("Experience", "Crafting", 300), new("Item", "Gold", 2000) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("Fred the Farmer has tasked me with shearing his overly wooly sheep. I need to get 15 wool from his sheep, then spin it into balls at any spinning wheel. There's one nearby in Lumbridge Castle.", 10)
                    },
                    {
                        10,
                        new("I sheared the sheep and handed in the wool. Didn't really feel like much of a 'quest', but job done I suppose.", 10)
                    }
                }
            });

            toAdd.Add(new("MI_CooksAssistant", "Cook's Assistant", "Very Short", "Novice", "The Lumbridge Castle cook is in a mess. It is the Duke of Lumbridge's birthday and the cook is making the cake. He needs a lot of ingredients and doesn't have much time.", 10, new() { "Misthalin" }) {
                StartNPC = "mistLumCook",
                StartLoc = "MIST_LumbridgeCastleKitchen",
                DateFullyImplemented = 20260913,
                Rewards = { new("Experience", "Cooking", 300) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("After so long without any players around, the cook appears to have forgotten what he needed the ingredients for. He wasn't much help when asking where the ingredients could be found either, suggesting I find a 'milk bucket tree'. There are probably some farms nearby to find everything.", 10)
                    },
                    {
                        10,
                        new("Ingredients delivered to the cook, and the Duke's birthday saved. Assuming the cook remembers how to make a cake. And that it's the Duke's birthday. Maybe I should've told him what the quest log said it was for?", 10)
                    }
                }
            });

            toAdd.Add(new("MI_ImpCatcher", "Imp Catcher", "Short", "Novice", "The Wizard Grayzag has summoned hundreds of little imps. They have stolen a lot of things belonging to the Wizard Mizgog including his magic beads.", 10, new() { "Misthalin" }) {
                StartNPC = "mistWizMizgog",
                StartLoc = "MIST_WizardTower3F",
                DateFullyImplemented = 20260915,
                Rewards = { new("Experience", "Magic", 875), new("Item", "amuletAccuracy", 1) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("Wizard Mizgog has tasked me with finding his stolen beads, which were taken by imps. I think I remember seeing some imps near Lumbridge Castle, so I'll just have to kill them until I get all four colors of bead.", 10)
                    },
                    {
                        10,
                        new("The lost beads have been returning to Wizard Mizgog and he has awarded me with an amulet of accuracy. If I ever get a full set of beads again I can take them to him for another amulet.", 10)
                    }
                }
            });

            toAdd.Add(new("MI_RestlessGhost", "The Restless Ghost", "Short", "Novice", "A ghost is haunting Lumbridge graveyard. The priest of Lumbridge church of Saradomin wants you to find out how to get rid of it.", 30, new() { "Misthalin" }) {
                StartNPC = "mistLumAereck",
                StartLoc = "MIST_LumbridgeChurch",
                DateFullyImplemented = 20260916,
                Rewards = { new("Experience", "Prayer", 1125) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("I have spoken to Father Aereck and he suggested I go talk to Father Urhney, who lives in the south of the Lumbridge swamps, about getting rid of the ghost. He gave me a map to help navigate the confusing swamps. If I lose it, I can probably speak to him to get another.", 10)
                    },
                    {
                        10,
                        new("I found and spoke to Father Urhney. After explaining I was sent by Father Aereck he was willing to help, and suggested that ghosts may linger when they have unfinished business to attend to. He gave me an amulet of ghostspeak, which should allow me to speak to ghosts, so that I can go talk to the ghost and ask what might be keeping it from moving on.", 20)
                    },
                    {
                        20,
                        new("The ghost didn't really seem to know exactly why they're a ghost, but said that a 'warlock' had taken the skull from their coffin and returning it might let them move on. I think the 'warlocks' in question might actually be the wizards at the Wizards' Tower near Draynor, so I should go take a look around there and see what I can turn up.", 30, "Gather", "mistLumCoffin", 1)
                    },
                    {
                        30,
                        new("I found the skull in the basement of the Wizards' Tower and returned it to the coffin, causing the ghost to fade away. Nobody asked for the amulet of ghostspeak back, so I'll hold onto it. Could be useful in the future.", 30)
                    }
                }
            });

            toAdd.Add(new("MI_BloodPact", "The Blood Pact", "Short", "Novice", "Dire deeds are afoot in Lumbridge Graveyard. A tomb lies defiled and rumours of baleful cults and profane rituals are whispered throughout the town. /n /n The veteran adventurer Xenia has come in search of talented heroes to accompany her into the depths of Lumbridge Catacombs. Together, you will uncover a plot to awaken a slumbering evil. Can you save the citizens of Lumbridge from a fate worse than death?", 100, new() { "Misthalin" }) {
                StartNPC = "mistLumXenia",
                StartLoc = "MIST_LumbridgeGraveyard",
                DateFullyImplemented = 20260922,
                Rewards = { new("Item", "combatLampTiny", 1) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("Xenia, an old adventurer, said she had seen some Zamorakian cultists entering the catacombs beneath Lumbridge Church. She asked me to go with her into the catacombs to deal with them.", 10)
                    },
                    {
                        10,
                        new("Inside the catacombs, Xenia and I overheard the cultists talking about a blood pact. I should accompany Xenia to fight the first cultist.", 20)
                    },
                    {
                        20,
                        new("The first cultist shot Xenia, wounding her badly. She will not be able to fight. I need to defeat the first cultist myself.", 30, "Kill", "questBloodPactKayle", 1)
                    },
                    {
                        30,
                        new("I should either kill or spare the first cultist.", 40)
                    },
                    {
                        40,
                        new("I have dealt with the first cultist, Kayle. I need to defeat the second cultist.", 50, "Kill", "questBloodPactCaitlin", 1)
                    },
                    {
                        50,
                        new("I must choose whether to kill or spare the second cultist.", 60)
                    },
                    {
                        60,
                        new("I have dealt with the second cultist, Caitlin. Only one cultist is left.", 70, "Kill", "questBloodPactReese", 1)
                    },
                    {
                        70,
                        new("I should either kill or spare the final cultist, Reese.", 80)
                    },
                    {
                        80,
                        new("I should untie the prisoner and escape.", 90)
                    },
                    {
                        90,
                        new("With the cultists' plan foiled, I need to go speak to Xenia again.", 100)
                    },
                    {
                        100,
                        new("Xenia thanked me for my help stopping the cultists.", 100)
                    }
                }
            });

            toAdd.Add(new("MI_ShieldOfArrav", "Shield of Arrav", "Medium", "Novice", "Varrockian literature tells of a valuable shield, stolen long ago from the Museum of Varrock by a gang of professional thieves. See if you can track down this shield and return it to the Museum. Reldo, in the Varrock Palace Library, may know more.", 50, new() { "Misthalin" }) {
                StartNPC = "mistVarReldo",
                StartLoc = "MIST_VarrockPalaceLibrary",
                DateFullyImplemented = 20260929,
                Rewards = { new("Item", "Gold", 1200) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("I spoke to Reldo in the Varrock Palace Library and asked him if he had any quests for me. He suggested I find and read a book called The Shield of Arrav. The book should be somewhere in the Library.", 5)
                    },
                    {
                        5,
                        new("I found and read the book titled The Shield of Arrav. The book detailed the theft of the legendary Shield of Arrav and the reward on offer to anyone able to recover it. I should discuss this with Reldo.", 10)
                    },
                    {
                        10,
                        new("Reldo gave me details about the missing Shield of Arrav. He told me about the Phoenix Gang and Black Arm Gang, the two groups suspected of being in possession of the shield. Apparently, Baraek in Varrock Plaza can give me details on the Phoenix Gang and Charlie the Tramp near the Varrock South Gate can do the same for the Black Arm Gang.", 20)
                    },
                    {
                        20,
                        new("I managed to find one half of the now-broken shield of Arrav. Now I just have to get my hands on the other...", 30)
                    },
                    {
                        30,
                        new("I've got both halves of the shield of Arrav! Just have to combine them back into the shield itself.", 40)
                    },
                    {
                        40,
                        new("I've put the shield of Arrav back together, all that remains is to turn it in to King Roald for my reward.", 50)
                    },
                    {
                        50,
                        new("I found and turned in the stolen shield of Arrav for a nice reward.", 50)
                    }
                }
            });

            toAdd.Add(new("MI_RuneMysteries", "Rune Mysteries", "Short", "Novice", "After the first Wizards' Tower burned down a hundred years ago, the incantation allowing teleportation to the rune essence mine was lost. However, after much research from the Order of Wizards, the incantation is on the verge of rediscovery...", 60, new() { "Misthalin" }) {
                StartNPC = "mistLumDukeHoracio",
                StartLoc = "MIST_LumbridgeCastleFloor2",
                DateFullyImplemented = 20260928,
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("I spoke to Duke Horacio in Lumbridge Castle. He told me that he'd found a strange talisman in the Castle which might be of use to the Order of Wizards at the Wizards' Tower. He asked me to take it there and give it to a wizard called Sedridor. I can find the Wizards' Tower south west of Lumbridge, across the bridge from Draynor Village. If I lose the talisman, I'll need to ask Duke Horacio for another.", 10)
                    },
                    {
                        10,
                        new("I delivered the strange talisman to Sedridor in the basement of the Wizards' Tower. I should see what he can tell me about it.", 20)
                    },
                    {
                        20,
                        new("Sedridor believes the talisman might be the key to discovered a teleportation incantation to the lost Rune Essence Mine. He has asked me to help confirm this by delivering a package to Aubury, an expert on Runecrafting. I can find him in his Rune Shop in south east Varrock. If I lose the package, I'll need to ask Sedridor for another.", 30)
                    },
                    {
                        30,
                        new("I delivered the package to Aubury. I should talk to him about his findings.", 40)
                    },
                    {
                        40,
                        new("Aubury confirmed Sedridor's suspicions and asked me to take some research notes back to him. I can find Sedridor in the basement of the Wizards' Tower. If I lose the research notes, I'll need to ask Aubury for some more.", 50)
                    },
                    {
                        50,
                        new("I gave the research notes to Sedridor. I should see what he has learnt from them.", 60)
                    },
                    {
                        60,
                        new("Sedridor and Aubury have figured out the incantation to teleport me to the Rune Essence Mine, and may now do so any time I wish.", 60)
                    }
                }
            });

            toAdd.Add(new("MI_IdesOfMilk", "The Ides of Milk", "Short", "Novice", "Lumbridge, the iconic city for all the fresh-faced arrivals and budding adventurers. Home to regular citizens of Gielinor, they chop the trees, work the fields, and tend to the animals of the realm, except there has been a disturbance in the nearby cow pen and the steaks have never been higher! Distress runs through the herd and while they have always feared adventurers claiming their lives, a new threat has entered their domain bringing the beef...", 110, new() { "Misthalin" }) {
                StartNPC = "mistLumCassius",
                StartLoc = "MIST_DraynorFarm",
                DateFullyImplemented = 20260930,
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("I spoke to Cassius and he has roped me into helping him build a... milk empire...? He wants me to go speak to Seth and Gillie Groats to learn about animal husbandry.", 10)
                    },
                    {
                        10,
                        new("I spoke with the Groatses and they both confirmed that the secret to good high volume product is the animals being happy. I got a book from Seth Groats detailing his farm philosophy, and should take my findings to Cassius.", 20)
                    },
                    {
                        20,
                        new("I gave the book to Cassius and should see what he has to say about it.", 25)
                    },
                    {
                        25,
                        new("For my hard work getting the book, Cassius has repaid me with a milk sample that smells vile. He insists I taste it.", 30)
                    },
                    {
                        30,
                        new("Well, that was terrible. I'm not sure I have the heart to tell Cassius just how bad it is, so I suppose I'll humor him for now.", 40)
                    },
                    {
                        40,
                        new("Cassius has given me a second sample to try to convince the Duke to grant a permit to sell milk. It smells even worse than the first. I fear for the Duke's life.", 50)
                    },
                    {
                        50,
                        new("The Duke has inexplicably shifted responsibility for handing out a permit to Gillie Groats and insisted I go speak to her about it instead.", 60)
                    },
                    {
                        60,
                        new("Gillie has refused to try the milk... for good reason, I suppose, and insists that I try it instead so she can gauge my reaction. Here we go again.", 70)
                    },
                    {
                        70,
                        new("I've tried the milk and should speak to Gillie to see if it has convinced her to issue a permit.", 80)
                    },
                    {
                        80,
                        new("I drank the milk for nothing. Gillie says that an aggressive bull has been bothering her herd though, and will give me the permit in exchange for killing it.", 90, "Kill", "bossBrutus", 1)
                    },
                    {
                        90,
                        new("Good news: I met Cassius' mysterious business partner. Bad news: he was a bull and I killed him. I should tell Gillie *her* problem is solved before going back to Cassius.", 100)
                    },
                    {
                        100,
                        new("Time to break the bad news to Cassius. Maybe he won't take it badly?", 110)
                    },
                    {
                        110,
                        new("He took it badly. At least I can go get a reward from Gillie.", 110)
                    }
                }
            });

            toAdd.Add(new("MI_GertrudesCat", "Gertrude's Cat", "Very Short", "Novice", "Gertrude has lost her cat Fluffs and desperately wants to find her. Can you help bring her home?", 80, new() { "Misthalin" }) {
                StartNPC = "mistVarGertrude",
                StartLoc = "MIST_VarrockGertrude",
                DateFullyImplemented = 20261001,
                Rewards = { new("Item", "stew", 1), new("Item", "cakeChocolate", 1), new("RandomItem", "kitten", 1) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("I've been recruited by Gertrude to help find her cat, Fluffs. She said that her sons Shilop and Wilough were the last to see the cat. They can be found in Varrock Plaza.", 10)
                    },
                    {
                        10,
                        new("I got hustled by Shilop and Wilough but they've told me that they last saw Fluffs skulking around the Lumberyard, out the east gate of Varrock and north.", 20)
                    },
                    {
                        20,
                        new("I found Fluffs but she won't come with me. She seems thirsty, maybe she'd like some milk?", 30)
                    },
                    {
                        30,
                        new("I gave Fluffs some milk. Maybe she'll come with me now?", 40)
                    },
                    {
                        40,
                        new("No dice. She seems to be hungry. Maybe Gertrude has an idea of what Fluffs might like to eat.", 50)
                    },
                    {
                        50,
                        new("I seasoned a sardine with doogle leaves and gave it to Fluffs, who seemed to enjoy it. Time to see if she'll come with me. Third try's the charm!", 60)
                    },
                    {
                        60,
                        new("Still nothing. I heard some meowing coming from nearby though, maybe I should take a look around the lumberyard.", 60)
                    },
                    {
                        70,
                        new("I found a kitten in one of the crates near Fluffs and returned it to her, then they ran off back home. I should go check in with Gertrude to make sure they made it.", 80)
                    },
                    {
                        80,
                        new("Looks like Fluffs made it home okay. Another citizen saved!", 80)
                    }
                }
            });

            for (int i = 0; i < toAdd.Count; i++) {
                QuestLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
