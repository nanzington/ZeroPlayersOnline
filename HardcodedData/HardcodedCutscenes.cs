using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedCutscenes {
        public static void InitCutscenes(Dictionary<string, Cutscene> lib) {
            List<Cutscene> toAdd = new();

            toAdd.Add(new("MI_BloodPact1", "Ahead of you in the Catacombs...", new() {
                new("The inside of the catacombs are surprisingly spacious. There are two main rows of sarcophagi in the middle of the hall, and various pots of offerings and remains everywhere. Set into some of the walls are more stone coffins, and there are Saradomin banners hanging from the walls. /n /n The cultists are dragging Ilona, bound with ropes, through the catacombs while bickering amongst themselves.",
                new() {
                    "Reese: Come on, Kayle! We don't have forever!",
                    "Kayle gestures to Reese. /n /n Kayle: Look, Reese; are you sure about this? There must be some other way we can...",
                    "Reese nods firmly at Kayle. /n /n Reese: We made a blood pact, Kayle! The three of us are in this all the way.",
                    "Kayle runs his hand down his face. /n /n Kayle: Yes, but...",
                    "Caitlin clenches her fist. /n /n Caitlin: Do we have to take this idiot?",
                    "Reese nods to Caitlin. /n /n Reese: Yes! The blood pact! You read the book!",
                    "Ilona: Let me go! I didn't make any blood pact with-",
                    "Reese barely manages to restrain his anger. /n /n Reese: Shut up!",
                    "Reese: Kayle, you stay here. Guard the door.",
                    "Reese: You, come on.",
                    "The screen fades out and back in. You enter the catacombs with Xenia.",
                    "Xenia: Looks like there's a guard in the room ahead. I think we should be able to overpower him. Speak to me if you have any questions."
                })
            }, new() { new("Quest", "MI_BloodPact", "", 10) }, null, new() { new("QuestAt", 0, "MI_BloodPact") } ));

            toAdd.Add(new("MI_BloodPact2", "Approaching the first Cultist", new() {
                new("The inside of the catacombs are surprisingly spacious. There are two main rows of sarcophagi in the middle of the hall, and various pots of offerings and remains everywhere. Set into some of the walls are more stone coffins, and there are Saradomin banners hanging from the walls. /n /n The cultist Kayle, an archer, is standing guard.",
                new() {
                    "As you lead Xenia to Kayle, he fires an arrow. You swiftly duck, but the arrow injures Xenia. The two of you retreat quickly back to the entrance.",
                    "Xenia: Ah... It looks like I'm too old for this after all. You'll have to do the rest without me.",
                    "Xenia: I'll follow you, but I'll stay out of combat. Return to me if you're wounded. I have some food to share.",
                    "Xenia: The first cultist is using a ranged weapon, so you should attack him with a melee weapon. Here's my spare dagger."
                })
            }, new() { new("Quest", "MI_BloodPact", "", 20) }, new() { "daggerBronze" }, new() { new("QuestAt", 10, "MI_BloodPact") } ));

            toAdd.Add(new("MI_BloodPact3", "Choosing Kayle's Fate", new() {
                new("The inside of the catacombs are surprisingly spacious. There are two main rows of sarcophagi in the middle of the hall, and various pots of offerings and remains everywhere. Set into some of the walls are more stone coffins, and there are Saradomin banners hanging from the walls. /n /n The cultist Kayle lies dead on the floor, his chargebow dropped beside him.",
                new() {
                    "Xenia: It's a pity you had to kill that man... but I'm not questioning your judgement.",
                    "Xenia: I think the second cultist was using magic. You should use a ranged weapon to defeat magic-users. Grab that chargebow if you haven't got one. Ask me if you need any help."
                })
            }, new() { new("Quest", "MI_BloodPact", "", 40), new("Data", "KayleSpared", "set", -1) }, null, new() { new("QuestAt", 30, "MI_BloodPact") } ));

            toAdd.Add(new("MI_BloodPact3a", "Choosing Kayle's Fate", new() {
                new("The inside of the catacombs are surprisingly spacious. There are two main rows of sarcophagi in the middle of the hall, and various pots of offerings and remains everywhere. Set into some of the walls are more stone coffins, and there are Saradomin banners hanging from the walls. /n /n Needing no further prompting, Kayle stands up and runs out of the catacombs, leaving his chargebow behind.",
                new() {
                    "Xenia: I don't think that cultist will be any more trouble. I'm glad you didn't have to kill him.",
                    "Xenia: I think the second cultist was using magic. You should use a ranged weapon to defeat magic-users. Grab that chargebow if you haven't got one. Ask me if you need any help."
                })
            }, new() { new("Quest", "MI_BloodPact", "", 40), new("Data", "KayleSpared", "set", 1) }, null, new() { new("QuestAt", 30, "MI_BloodPact") } ));

            toAdd.Add(new("MI_BloodPact4", "Choosing Caitlin's Fate", new() {
                new("This side room of the catacombs is, for some reason, essentially two large balconies facing eachother with a pit across the middle of the room. There are railings on either side of the hole that leads down, and the two halves of the room are connected by a walkway with a gate. You are on the far side from the entrance. /n /n The cultist Caitlin lies dead on the floor, her staff dropped beside her.",
                new() {
                    "Xenia: I heard you killed the second cultist. It's a pity it had to come to that... but I'm not questioning your judgement.",
                    "Xenia: I think the third cultist was a swordsman. Magic is the best thing to use against melee fighters. Grab that staff and speak to me if you need any help."
                })
            }, new() { new("Quest", "MI_BloodPact", "", 60), new("Data", "CaitlinSpared", "set", -1) }, null, new() { new("QuestAt", 50, "MI_BloodPact") } ));

            toAdd.Add(new("MI_BloodPact4a", "Choosing Caitlin's Fate", new() {
                new("This side room of the catacombs is, for some reason, essentially two large balconies facing eachother with a pit across the middle of the room. There are railings on either side of the hole that leads down, and the two halves of the room are connected by a walkway with a gate. You are on the far side from the entrance. /n /n Caitlin stands and leaves the catacombs, leaving her staff on the floor.",
                new() {
                    "Xenia: The second cultist passed me on her way out. I don't think she'll be anymore trouble. I'm glad you didn't have to kill her.",
                    "Xenia: I think the third cultist was a swordsman. Magic is the best thing to use against melee fighters. Grab that staff and speak to me if you need any help."
                })
            }, new() { new("Quest", "MI_BloodPact", "", 60), new("Data", "CaitlinSpared", "set", 1) }, null, new() { new("QuestAt", 50, "MI_BloodPact") } ));

            toAdd.Add(new("MI_BloodPact5", "Confronting the Final Cultist", new() {
                new("A large room supported by pillars, with banners hanging from the walls and more urns spread around the room in piles. One large sarcophagus, the resting place of Dragith Nurn, rests at the south end of the hall. Beneath a grate in the floor, some water flows through the center of the room.",
                new() {
                    "Reese: The potion is complete. Where are they? The whole group should be present.",
                    "Ilona: Let me go, you-",
                    "Reese: Shut up!",
                    "The camera cuts to you, walking towards Reese.",
                    "Reese: Who are you? What are you doing here?",
                    "You: I'm an adventurer. Don't worry, Ilona, I'm here to rescue you.",
                    "Ilona: Thank Saradomin! He's insane! He's going to kill me!",
                    "Reese: Maybe you can take her place as the sacrifice, adventurer. Stand and fight!",
                    "You: I defeated both your lackeys. Think you can do better?",
                    "Reese: They were weak. Zamorak will turn his face from them - but he will smile on me when I offer him your blood!"
                })
            }, null, null, new() { new("QuestAt", 60, "MI_BloodPact") } ));

            toAdd.Add(new("MI_BloodPact6", "Choosing Reese's Fate", new() {
                new("A large room supported by pillars, with banners hanging from the walls and more urns spread around the room in piles. One large sarcophagus, the resting place of Dragith Nurn, rests at the south end of the hall. Beneath a grate in the floor, some water flows through the center of the room.",
                new() {
                    "With one final blow, you slay Reese where he kneels.",
                    "Seemingly triggered by some kind of magic, the catacombs shake around you.",
                    "The fake tomb of Dragith Nurn crumbles, revealing stairs to the last level of the catacombs.",
                    "Ilona: Help! Untie me so we can get out of here!"
                })
            }, new() { new("Quest", "MI_BloodPact", "", 80) }, null, new() { new("QuestAt", 70, "MI_BloodPact") } ));

             toAdd.Add(new("MI_BloodPact6a", "Choosing Reese's Fate", new() {
                new("A large room supported by pillars, with banners hanging from the walls and more urns spread around the room in piles. One large sarcophagus, the resting place of Dragith Nurn, rests at the south end of the hall. Beneath a grate in the floor, some water flows through the center of the room.",
                new() {
                    "Reese: No! There must be a death! The blood pact must be complete!",
                    "Before you can stop him, Reese pulls out a poisonous potion and drinks it, dying in moments.",
                    "Seemingly triggered by some kind of magic, the catacombs shake around you.",
                    "The fake tomb of Dragith Nurn crumbles - revealing stairs to the last level of the catacombs.",
                    "Ilona: Help! Untie me so we can get out of here!"
                })
            }, new() { new("Quest", "MI_BloodPact", "", 80) }, null, new() { new("QuestAt", 70, "MI_BloodPact") } ));

            for (int i = 0; i < toAdd.Count; i++) {
                lib.TryAdd(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
