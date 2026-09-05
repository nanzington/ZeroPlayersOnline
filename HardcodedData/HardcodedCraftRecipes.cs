using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedCraftRecipes {
        public static void InitCrafts(Dictionary<string, List<CraftRecipe>> CraftLib) {
            List<CraftRecipe> toAdd = new();

            List<string> Metals = ["Bronze", "Iron", "Steel" ];

            for (int i = 0; i < Metals.Count; i++) {
                toAdd.Add(new("Anvil", "Smithing", 1, 15, ["bar" + Metals[i] + "," + 1], "dagger" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 15, ["bar" + Metals[i] + "," + 1], "sword" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 15, ["bar" + Metals[i] + "," + 1], "mace" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 30, ["bar" + Metals[i] + "," + 2], "scimitar" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 30, ["bar" + Metals[i] + "," + 1], "hatchet" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 30, ["bar" + Metals[i] + "," + 1], "pickaxe" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 30, ["bar" + Metals[i] + "," + 2], "helm" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 75, ["bar" + Metals[i] + "," + 5], "platebody" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 45, ["bar" + Metals[i] + "," + 3], "platelegs" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 15, ["bar" + Metals[i] + "," + 1], "boots" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 15, ["bar" + Metals[i] + "," + 1], "gauntlets" + Metals[i], tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 15, ["bar" + Metals[i] + "," + 1], "arrowheads" + Metals[i], 15, "hammer"));
                toAdd.Add(new("Anvil", "Smithing", 1, 15, ["bar" + Metals[i] + "," + 1], "knives" + Metals[i], 5, "hammer"));
            }


            toAdd.Add(new("Needle", "Crafting", 1, 15, ["leatherSoft" + "," + 1], "coifLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 75, ["leatherSoft" + "," + 5], "bodyLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 45, ["leatherSoft" + "," + 3], "chapsLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 15, ["leatherSoft" + "," + 1], "vambracesLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 15, ["leatherSoft" + "," + 1], "bootsLeather", tool: "needle"));


            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "arrowshaft", 15, "knife"));
            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "shortbowPineU", tool: "knife"));



            toAdd.Add(new("Pottery Wheel", "Crafting", 1, 7, ["claySoft" + "," +  1], "unfiredPot"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 3, 9, ["claySoft" + "," +  1], "unfiredCup", 4));
            toAdd.Add(new("Pottery Wheel", "Crafting", 7, 15, ["claySoft" + "," +  1], "unfiredPieDish"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 8, 18, ["claySoft" + "," +  1], "unfiredBowl"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 19, 20, ["claySoft" + "," +  1], "unfiredPlantPot"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 25, 30, ["claySoft" + "," +  1], "unfiredPotLid"));



            for (int i = 0; i < toAdd.Count; i++) {
                if (!CraftLib.ContainsKey(toAdd[i].Station))
                    CraftLib.Add(toAdd[i].Station, new());
                CraftLib[toAdd[i].Station].Add(toAdd[i]);
            }
        }
    }
}
