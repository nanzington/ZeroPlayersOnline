using GoRogue.GameFramework;
using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedItemsQuests {
        public static void InitItems(Dictionary<string, Item> ItemLibrary) {
            List<Item> itemsToAdd = new();

            itemsToAdd.Add(new Item("Combat lamp (tiny)", "Grants 100 experience to each of Attack, Strength, Defense, Ranged, and Magic.", "combatLampTiny", Color.White, 1, trade: false) { UseString = "LampAll", UseString2 = "Attack,Strength,Defense,Ranged,Magic", UseInt = 100 });
            itemsToAdd.Add(new Item("Kayle's chargebow", "A brightly colored chargebow that fires magical arrows.", "chargebowKayle", ColorLib.Oak, 1, trade: false) {
                EquipSlot = "Weapon", EquipTier = 2, EquipLevel = 1, EquipDamageType = "RangedStandard", EquipSkill = "Ranged", EquipAmmo = "Chargebow", AttackSpeed = 1, TwoHanded = true
            });
            itemsToAdd.Add(new Item("Caitlin's staff", "A spell-casting aid. Provides unlimited air runes.", "staffCaitlin", Color.DarkGray, 1) {
                EquipSlot = "Weapon",  EquipTier = 1, EquipSkill = "Magic", EquipLevel = 1, EquipDamageType = "Crush", CountsAsIDs = [ "runeAir" ], UseInt4 = -1, MustBeEquipped = true
            });
            itemsToAdd.Add(new Item("Reese's sword", "Old, battered, and not very sharp.", "swordReese", Color.DarkGray, 1) {
                EquipSlot = "Weapon",  EquipTier = 2, EquipSkill = "Attack", EquipLevel = 1, EquipDamageType = "Slash"
            });

            itemsToAdd.Add(new Item("Chargebow", "A brightly colored chargebow that fires magical arrows.", "chargebow", ColorLib.Oak, 20) {
                EquipSlot = "Weapon", EquipTier = 1, EquipLevel = 1, EquipDamageType = "RangedStandard", EquipSkill = "Ranged", EquipAmmo = "Chargebow", AttackSpeed = 1, TwoHanded = true
            });

            itemsToAdd.Add(new Item("Mask part 1", "One of five parts of the Mask of Dragith Nurn.", "maskDragith1", Color.Gray, 1, trade: false) { ConsumedOnUse = false, UseString = "DragithNurn" });
            itemsToAdd.Add(new Item("Mask part 2", "One of five parts of the Mask of Dragith Nurn.", "maskDragith2", Color.Gray, 1, trade: false) { ConsumedOnUse = false, UseString = "DragithNurn" });
            itemsToAdd.Add(new Item("Mask part 3", "One of five parts of the Mask of Dragith Nurn.", "maskDragith3", Color.Gray, 1, trade: false) { ConsumedOnUse = false, UseString = "DragithNurn" });
            itemsToAdd.Add(new Item("Mask part 4", "One of five parts of the Mask of Dragith Nurn.", "maskDragith4", Color.Gray, 1, trade: false) { ConsumedOnUse = false, UseString = "DragithNurn" });
            itemsToAdd.Add(new Item("Mask part 5", "One of five parts of the Mask of Dragith Nurn.", "maskDragith5", Color.Gray, 1, trade: false) { ConsumedOnUse = false, UseString = "DragithNurn" });
            
            itemsToAdd.Add(new Item("Mask of Dragith Nurn", "The magic mask of the undead necromancer Dragith Nurn.", "maskDragith", Color.DarkGray, 1, trade: false) {
                EquipSlot = "Head",  EquipTier = 2, EquipSkill = "Defense", EquipLevel = 1, MiscString = "DefenseMelee"
            });

            itemsToAdd.Add(new Item("Jade demon statuette", "An ornate statuette of a demon holding a large jade gem.", "statuetteJade", Color.Crimson, 1, trade: false));
            itemsToAdd.Add(new Item("Topaz demon statuette", "An ornate statuette of a demon holding a large topaz gem.", "statuetteTopaz", Color.Crimson, 1, trade: false));
            itemsToAdd.Add(new Item("Sapphire demon statuette", "An ornate statuette of a demon holding a large sapphire gem.", "statuetteSapphire", Color.Crimson, 1, trade: false));
            itemsToAdd.Add(new Item("Emerald demon statuette", "An ornate statuette of a demon holding a large emerald gem.", "statuetteEmerald", Color.Crimson, 1, trade: false));
            itemsToAdd.Add(new Item("Ruby demon statuette", "An ornate statuette of a demon holding a large ruby gem.", "statuetteRuby", Color.Crimson, 1, trade: false));
            itemsToAdd.Add(new Item("Diamond demon statuette", "An ornate statuette of a demon holding a large diamond gem.", "statuetteDiamond", Color.Crimson, 1, trade: false));
            

            itemsToAdd.Add(new Item("Ham hood", "Light-weight head protection and eye shield.", "hamHood", Color.HotPink, 75) { EquipSlot = "Head" });
            itemsToAdd.Add(new Item("Ham shirt", "The label says 'Vivid Crimson' but it looks pink to me!", "hamShirt", Color.HotPink, 75) { EquipSlot = "Torso" });
            itemsToAdd.Add(new Item("Ham skirt", "The label says 'Vivid Crimson' but it looks pink to me!", "hamSkirt", Color.HotPink, 75) { EquipSlot = "Legs" });
            itemsToAdd.Add(new Item("Ham gloves", "HAM gloves as worn by the Humans Against Monsters group.", "hamGloves", Color.HotPink, 75) { EquipSlot = "Hands" });
            itemsToAdd.Add(new Item("Ham boots", "HAM boots as worn by the Humans Against Monsters group.", "hamBoots", Color.HotPink, 75) { EquipSlot = "Feet" });
            itemsToAdd.Add(new Item("Ham cloak", "A HAM cape.", "hamCloak", Color.HotPink, 75) { EquipSlot = "Cape" });
            itemsToAdd.Add(new Item("Ham logo", "A badge for the HAM cult.", "hamLogo", Color.HotPink, 75) { EquipSlot = "Pocket" });
            
            itemsToAdd.Add(new Item("Rusted sword [Q]", "The sword is useless now. You notice someone has scratched something into the handle: 'PlayerOne'.", "TI_HI_RustedSword", 205, 127, 50, 0, trade: false));
            itemsToAdd.Add(new Item("Crumpled note [Q]", "A torn note. It reads 'okay this is actually pretty cool', and 'how do i save the game'.", "TI_HI_CrumpledNote", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Bank record [Q]", "A bank record. It reads 'ACCOUNT: PlayerOne', 'LAST ACCESS: [DATA UNAVAILABLE]'.", "TI_HI_BankRecord", 255, 255, 255, 0, trade: false));
            itemsToAdd.Add(new Item("Strange rune [Q]", "You have absolutely no idea what this could be for. Someone might know more.", "TI_HI_StrangeRune", 147, 112, 219, 0, trade: false) {
                UseString = "SecondExamine",
                MiscString = "ERROR: SPELL SYSTEM NOT FOUND.",
                ConsumedOnUse = false
            });
            itemsToAdd.Add(new Item("White bead [Q]", "A small round white bead.", "beadWhite", 255, 255, 255, 4));
            itemsToAdd.Add(new Item("Red bead [Q]", "A small round red bead.", "beadRed", 255, 0, 0, 4));
            itemsToAdd.Add(new Item("Black bead [Q]", "A small round black bead.", "beadBlack", 50, 50, 50, 4));
            itemsToAdd.Add(new Item("Yellow bead [Q]", "A small round yellow bead.", "beadYellow", 255, 255, 0, 4));
            
            itemsToAdd.Add(new Item("Ghostspeak amulet [Q]", "It lets me talk to ghosts.", "amuletGhostspeak", 255, 255, 0, 4, trade: false) { EquipSlot = "Amulet" });
            itemsToAdd.Add(new Item("Ghost's skull [Q]", "Ooooh spooky! (The Restless Ghost)", "mistWizGhostSkull", 255, 255, 255, 4, trade: false) { UseString = "SecondExamine", MiscString = "It's the skull of the ghost that is haunting Lumbridge graveyard. Maybe I should return this back to the ghost's coffin.", ConsumedOnUse = false});
            
            itemsToAdd.Add(new Item("Wig [Q]", "A grey woollen wig. (Prince Ali Rescue)", "princeAliWig", 255, 255, 255, 30, trade: false));
            itemsToAdd.Add(new Item("Blonde wig [Q]", "A wig that has been dyed blonde. (Prince Ali Rescue)", "princeAliWigBlonde", Color.Yellow, 30, trade: false));
            
            itemsToAdd.Add(new Item("Shield of Arrav (book) [Q]", "'The Shield of Arrav' by A R Wright. (Shield of Arrav)", "bookArrav", Color.DodgerBlue, 5) { ConsumedOnUse = false, UseString = "Book", UseString2 = "bookArrav"});
            

            for (int i = 0; i < itemsToAdd.Count; i++) {
                ItemLibrary.Add(itemsToAdd[i].ID, itemsToAdd[i]);
            }
        }
    }
}
