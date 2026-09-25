using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsHoliday {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();
             
            itemsToAdd.Add(new Item("Chronicle", "The legends of RuneScape.", "chronicle", Color.DodgerBlue, 200, trade: false) { EquipSlot = "Offhand", ConsumedOnUse = false, UsesCharges = true, UseString = "Teleport", UseString2 = "MIST_VarrockMineWest", ChargeItem = "cardTeleport" });
            itemsToAdd.Add(new Item("Teleport card", "A card which has magical properties.", "cardTeleport", Color.White, 100));
            


            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
