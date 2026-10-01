using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedNPCsAlKharid {
        public static void InitNPCs(Dictionary<string, NPC> NPCLib) {
            DialogueChoice byeThen = new("Goodbye", -1);

            List<NPC> toAdd = new();
             
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


            // Mage Training Arena
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
             
            for (int i = 0; i < toAdd.Count; i++) { 
                NPCLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
