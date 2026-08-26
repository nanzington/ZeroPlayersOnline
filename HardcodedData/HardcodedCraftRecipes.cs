using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedCraftRecipes {
        public static void InitCrafts(Dictionary<string, List<CraftRecipe>> CraftLib) {
            List<CraftRecipe> toAdd = new();

            toAdd.Add(new("Anvil", "Smithing", 1, 15, "barBronze", 1, "daggerBronze", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 15, "barBronze", 1, "swordBronze", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 15, "barBronze", 1, "maceBronze", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 30, "barBronze", 2, "scimitarBronze", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 30, "barBronze", 2, "helmBronze", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 75, "barBronze", 5, "platebodyBronze", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 45, "barBronze", 3, "platelegsBronze", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 15, "barBronze", 1, "arrowheadsBronze", 15, "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 1, 15, "barBronze", 1, "knivesBronze", 5, "hammer"));


            toAdd.Add(new("Needle", "Crafting", 1, 15, "leatherSoft", 1, "leatherCowl", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 75, "leatherSoft", 5, "leatherBody", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 45, "leatherSoft", 3, "leatherChaps", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 15, "leatherSoft", 1, "leatherGloves", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 15, "leatherSoft", 1, "leatherBoots", tool: "needle"));


            toAdd.Add(new("Knife", "Fletching", 1, 5, "logPine", 1, "arrowshaft", 15, "knife"));
            toAdd.Add(new("Knife", "Fletching", 1, 5, "logPine", 1, "shortbowPineU", tool: "knife"));



            for (int i = 0; i < toAdd.Count; i++) {
                if (!CraftLib.ContainsKey(toAdd[i].Station))
                    CraftLib.Add(toAdd[i].Station, new());
                CraftLib[toAdd[i].Station].Add(toAdd[i]);
            }
        }
    }
}
