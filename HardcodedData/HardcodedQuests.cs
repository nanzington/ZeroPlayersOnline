using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedQuests {
        public static void InitQuests(Dictionary<string, Quest> QuestLib) {
            List<Quest> toAdd = new();

            toAdd.Add(new("TI_HauntedIsland", "The Haunted Island", "Very Short", "Novice", "Strange things keep happening around the island. Noises without a source and resources harvested when nobody is around. Are there actually zero players online? Maybe Father Guy would know more.", 90, new() { "Misthalin" }) {
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
                        new("A crumpled note on the ground at the main hub of the island has some text indicating the ghost might have been a player at some point. I should go speak with Father Guy to ask him about this.", 30)
                    },
                    {
                        30,
                        new("Father Guy has confirmed my suspicion that this ghost, PlayerOne, was one of the earliest players of the game. Unfortunately the good Father was only added in an update after the ghost was already here. I'll have to find someone who has been around long enough to have some information.", 40)
                    },
                    {
                        40,
                        new("The Old Fisherman told me that PlayerOne was, as the name might suggest, the very first player to join the game. They seem to have been unable to leave the island and got trapped here somehow. He suggested I go ask the bank for any record they have of PlayerOne.", 50)
                    },
                    {
                        50,
                        new("PlayerOne's account with the bank was closed out due to an error and I was given their items. I should inspect the items to see what I can find.", 60)
                    },
                    {
                        60,
                        new("One of the items from PlayerOne's bank was a rune with a strange symbol on it that I don't recognize. Someone knowledgeable about runes may know more.", 70)
                    },
                    {
                        70,
                        new("The Runecrafting Tutor says the strange rune was used for an old magic system before the game was updated, part of a spell to leave the island. Wizard Terrova teleports people on now, so he might know enough for me to finish this quest and let PlayerOne finally leave.", 80)
                    },
                    {
                        80,
                        new("Wizard Terrova cast the spell to teleport a player to Lumbridge on PlayerOne, causing them to fade away. Given the apparent lack of effects that would normally accompany the spell, Terrova speculated that the automated login system of the game might have finally noticed PlayerOne's broken avatar and logged it out properly. All that's left to do is go bring Father Guy up to speed. ", 90)
                    },
                    {
                        90,
                        new("Father Guy has confirmed that he no longer feels the presence of PlayerOne on the island.", 90)
                    }
                }
            });

            toAdd.Add(new("MI_CooksAssistant", "Cook's Assistant", "Very Short", "Novice", "The Lumbridge Castle cook is in a mess. It is the Duke of Lumbridge's birthday and the cook is making the cake. He needs a lot of ingredients and doesn't have much time.", 90, new() { "Misthalin" }) {
                DateFullyImplemented = 20260829,
                Rewards = { new("Experience", "Cooking", 300) },
                QuestPoints = 1,
                Stages = new() {
                    {
                        0,
                        new("The Lumbridge Castle cook has asked me to gather the ingredients for a cake to get him out of his bind.", 10, "ExamineItem", "TI_HI_RustedSword")
                    }
                }
            });

            for (int i = 0; i < toAdd.Count; i++) {
                QuestLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
