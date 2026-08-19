using ZeroPlayersOnline.DataTypes;
using SadConsole;
using SadRogue.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItems {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();
            itemsToAdd.Add(new Item("Pine log", "A bundle of pine logs.", "logPine", 237, 202, 161, 4, 2, 1));

            itemsToAdd.Add(new Item("Copper ore", "A pile of copper ore nuggets.", "oreCopper", 184, 115, 51, 3, 1, 1));
            itemsToAdd.Add(new Item("Tin ore", "A pile of tin ore nuggets.", "oreTin", 170, 170, 170, 3, 1, 1)); 
            itemsToAdd.Add(new Item("Bronze ore mix", "A mix of copper and tin ore nuggets.", "oreMixBronze", 205, 127, 50, 6, 2, 2)); 
            itemsToAdd.Add(new Item("Bronze bar", "It's a bar of bronze.", "barBronze", 205, 127, 50, 8, 4, 3));

            itemsToAdd.Add(new Item("Small Coin Pouch", "Has a few coins in it.", "coinPouchSmall", 111, 66, 33, 5, 3, 1, true, true, false) {
                UseString = "GetGold",
                UseInt = 5 
            });

            itemsToAdd.Add(new Item("Bones", "The remains of some creature or person.", "bonesRegular", 255, 255, 255, 1, 0, 0, false, true, true) {
                UseString = "Bones",
                UseInt = 5 
            });
             
            itemsToAdd.Add(new Item("Raw newt meat", "A cut of meat taken from a newt.", "meatRawNewt", 138, 3, 3, 1, 0, 0));
            itemsToAdd.Add(new Item("Cooked newt meat", "A cooked newt steak.", "meatCookedNewt", 150, 100, 50, 4, 2, 1) {
                UseString = "Heal",
                UseInt = 3 
            });

            itemsToAdd.Add(new Item("Raw shrimps", "A few raw shrimp.", "fishRawShrimp", 138, 3, 3, 5, 3, 2));
            itemsToAdd.Add(new Item("Cooked shrimps", "Some cooked shrimp.", "fishCookedShrimp", 150, 100, 50, 5, 3, 2) {
                UseString = "Heal",
                UseInt = 3
            });

            itemsToAdd.Add(new Item("Raw anchovies", "A few raw anchovies.", "fishRawAnchovies", 173, 216, 230, 15, 9, 6));
            itemsToAdd.Add(new Item("Cooked anchovies", "Some cooked anchovies.", "fishCookedAnchovies", 143, 186, 200, 15, 9, 6) {
                UseString = "Heal",
                UseInt = 1
            });


            itemsToAdd.Add(new Item("Empty Bucket", "An empty bucket. Could probably hold something.", "bucketEmpty", 111, 66, 33, 2, 1, 0));
            itemsToAdd.Add(new Item("Bucket of Water", "A bucket filled with water.", "bucketWater", 111, 66, 33, 2, 1, 0));


            itemsToAdd.Add(new Item("Helmet plans", "Plans for smithing a helmet.", "plansHelmet", 255, 255, 255, 10, 4, 2));
            itemsToAdd.Add(new Item("Platebody plans", "Plans for smithing a platebody.", "plansPlatebody", 255, 255, 255, 10, 4, 2));
            itemsToAdd.Add(new Item("Leggings plans", "Plans for smithing leggings.", "plansLeggings", 255, 255, 255, 10, 4, 2));
            itemsToAdd.Add(new Item("Shield plans", "Plans for smithing a shield.", "plansShield", 255, 255, 255, 10, 4, 2)); 
            itemsToAdd.Add(new Item("Dagger plans", "Plans for smithing a dagger.", "plansDagger", 255, 255, 255, 10, 4, 2));
            itemsToAdd.Add(new Item("Sword plans", "Plans for smithing a sword.", "plansSword", 255, 255, 255, 10, 4, 2));


            itemsToAdd.Add(new Item("in-progress bronze helm (1/2)", "Materials for a bronze helmet. Needs one more bar.", "progHelmBronze1", 205, 127, 50, 0, 0, 0));
            itemsToAdd.Add(new Item("in-progress bronze helm (2/2)", "Materials for a bronze helmet. Ready for smithing.", "progHelmBronze2", 205, 127, 50, 0, 0, 0));
            itemsToAdd.Add(new Item("Bronze helmet", "A bronze helmet.", "helmBronze", 205, 127, 50, 44, 26, 17));
             
            itemsToAdd.Add(new Item("in-progress bronze dagger (1/1)", "Materials for a bronze dagger. Ready for smithing.", "progDaggerBronze", 205, 127, 50, 0, 0, 0));
            itemsToAdd.Add(new Item("Bronze dagger", "A bronze dagger.", "daggerBronze", 205, 127, 50, 10, 6, 4) {
                EquipSlot = "Weapon",
                EquipTier = 1,
                EquipDamageType = "Stab"
            });



            itemsToAdd.Add(new Item("Eye of newt", "A basic herblore ingredient and only slightly gross.", "eyeNewt", 255, 255, 255, 3, 1, 1));


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
