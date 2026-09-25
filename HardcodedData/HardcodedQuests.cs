using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedQuests {
        public static void InitQuests(Dictionary<string, Quest> QuestLib) {
            List<Quest> toAdd = new();

            toAdd.Add(new("TI_HauntedIsland", "The Haunted Island", "Very Short", "Novice", "Strange things keep happening around the island. Noises without a source and resources harvested when nobody is around. Are there actually zero players online? Maybe Father Guy would know more.", 90, new() { "Misthalin" }) {
                StartNPC = "tiFatherGuy",
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

            toAdd.Add(new("MI_ShieldOfArrav", "Shield of Arrav", "Medium", "Novice", "Varrockian literature tells of a valuable shield, stolen long ago from the Museum of Varrock by a gang of professional thieves. See if you can track down this shield and return it to the Museum. Reldo, in the Varrock Palace Library, may know more.", 1000, new() { "Misthalin" }) {
                DateFullyImplemented = 20260913,
                Rewards = { new("Item", "Gold", 1200) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("I found a book describing the shield and the bounty for retrieving it. I should ask Reldo if he knows anything about the gangs that were involved in stealing it.", 10)
                    },
                    {
                        10,
                        new("Reldo suggested that I go and speak with Baraek, the fur trader in ", 20)
                    }
                }
            });

            for (int i = 0; i < toAdd.Count; i++) {
                QuestLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
