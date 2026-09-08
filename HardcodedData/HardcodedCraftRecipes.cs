using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedCraftRecipes {
        public static void InitCrafts(Dictionary<string, List<CraftRecipe>> CraftLib) {
            List<CraftRecipe> toAdd = new();
            
            List<MaterialDef> Metals = new() { 
                new("Bronze", 205, 127, 50, 255, 1, 1, 15, "minimal"), 
                new("Iron", 75, 75, 75, 255, 2, 10, 40, "slight"), 
                new("Steel", 150, 150, 150, 255, 3, 20, 75, "adequate")
            };

            for (int i = 0; i < Metals.Count; i++) {
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "dagger" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "sword" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "mace" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 2, ["bar" + Metals[i].Name + "," + 2], "scimitar" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "hatchet" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "pickaxe" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 2, ["bar" + Metals[i].Name + "," + 2], "helm" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 5, ["bar" + Metals[i].Name + "," + 5], "platebody" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 3, ["bar" + Metals[i].Name + "," + 3], "platelegs" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "boots" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "gauntlets" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "arrowheads" + Metals[i].Name, 15, "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "knives" + Metals[i].Name, 5, "hammer"));
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
