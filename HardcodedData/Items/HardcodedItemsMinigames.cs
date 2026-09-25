using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsMinigames {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();
             
            itemsToAdd.Add(new Item("Icosahedron [M]", "A blue icosahedron. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaIcosahedron", Color.DodgerBlue, 0, trade: false));
            itemsToAdd.Add(new Item("Cube [M]", "A yellow cube. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaCube", Color.Yellow, 0, trade: false));
            itemsToAdd.Add(new Item("Pentamid [M]", "A red pentamid. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaPentamid", Color.Crimson, 0, trade: false));
            itemsToAdd.Add(new Item("Cylinder [M]", "A green cylinder. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaCylinder", Color.ForestGreen, 0, trade: false));
            itemsToAdd.Add(new Item("Dragonstone [M]", "A purple dragonstone. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaDragonstone", Color.Purple, 0, trade: false));
            itemsToAdd.Add(new Item("Orb [M]", "A white orb. Used in the Enchanting Chamber of the Mage Training Arena.", "mtaOrb", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Strange bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone1", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Odd bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone2", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Weird bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone3", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Unusual bones [M]", "A set of bones. Used in the Creature Graveyard of the Mage Training Arena.", "mtaBone4", Color.White, 0, trade: false));
            itemsToAdd.Add(new Item("Leather boots [M]", "Leather boots. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch1", Color.SaddleBrown, 3, trade: false));
            itemsToAdd.Add(new Item("Adamant kiteshield [M]", "An adamant kiteshield. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch2", ColorLib.Adamant, 3, trade: false));
            itemsToAdd.Add(new Item("Adamant helmet [M]", "An adamant helmet. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch3", ColorLib.Adamant, 3, trade: false));
            itemsToAdd.Add(new Item("Emerald [M]", "An emerald. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch4", Color.Lime, 3, trade: false));
            itemsToAdd.Add(new Item("Rune sword [M]", "A rune sword. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlch5", ColorLib.Rune, 3, trade: false));
            itemsToAdd.Add(new Item("Coins [M]", "Coins. Used in the Alchemist's Playground of the Mage Training Arena.", "mtaAlchCoin", Color.Goldenrod, 0, true, false));
            


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
