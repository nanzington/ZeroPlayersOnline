using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.HardcodedData;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedCraftRecipes {
        public static void InitCrafts(Dictionary<string, List<CraftRecipe>> CraftLib) {
            List<CraftRecipe> toAdd = new();
            
            List<MaterialDef> Metals = new() { 
                new("Bronze", ColorLib.Bronze, 1, 1, 15, "minimal"), 
                new("Iron", ColorLib.Iron, 2, 10, 40, "slight"), 
                new("Steel", ColorLib.Steel, 3, 20, 75, "adequate"), 
                new("Mithril", ColorLib.Mithril, 4, 30, 120, "good"), 
                new("Adamant", ColorLib.Adamant, 3, 40, 170, "great")
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
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "boltsUnf" + Metals[i].Name, 15, "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "knives" + Metals[i].Name, 5, "hammer"));
            }


            toAdd.Add(new("Needle", "Crafting", 1, 15, ["leatherSoft" + "," + 1], "coifLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 75, ["leatherSoft" + "," + 5], "bodyLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 45, ["leatherSoft" + "," + 3], "chapsLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 15, ["leatherSoft" + "," + 1], "vambracesLeather", tool: "needle"));
            toAdd.Add(new("Needle", "Crafting", 1, 15, ["leatherSoft" + "," + 1], "bootsLeather", tool: "needle"));


            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "arrowshaft", 15, "knife"));
            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "shortbowPineU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 10, 10, ["logOak" + "," + 1], "arrowshaft", 30, "knife"));
            toAdd.Add(new("Knife", "Fletching", 10, 10, ["logOak" + "," + 1], "shortbowOakU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 20, 15, ["logWillow" + "," + 1], "arrowshaft", 45, "knife"));
            toAdd.Add(new("Knife", "Fletching", 20, 15, ["logWillow" + "," + 1], "shortbowWillowU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 30, 20, ["logTeak" + "," + 1], "arrowshaft", 60, "knife"));
            toAdd.Add(new("Knife", "Fletching", 30, 30, ["logTeak" + "," + 1], "shortbowTeakU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 40, 25, ["logMaple" + "," + 1], "arrowshaft", 75, "knife"));
            toAdd.Add(new("Knife", "Fletching", 40, 45, ["logMaple" + "," + 1], "shortbowMapleU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 50, 30, ["logAcadia" + "," + 1], "arrowshaft", 90, "knife"));
            toAdd.Add(new("Knife", "Fletching", 50, 60, ["logAcadia" + "," + 1], "shortbowAcadiaU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 60, 35, ["logMahogany" + "," + 1], "arrowshaft", 105, "knife"));
            toAdd.Add(new("Knife", "Fletching", 60, 75, ["logMahogany" + "," + 1], "shortbowMahoganyU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 70, 40, ["logYew" + "," + 1], "arrowshaft", 120, "knife"));
            toAdd.Add(new("Knife", "Fletching", 70, 90, ["logYew" + "," + 1], "shortbowYewU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 80, 45, ["logMagic" + "," + 1], "arrowshaft", 135, "knife"));
            toAdd.Add(new("Knife", "Fletching", 80, 105, ["logMagic" + "," + 1], "shortbowMagicU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 90, 50, ["logElder" + "," + 1], "arrowshaft", 150, "knife"));
            toAdd.Add(new("Knife", "Fletching", 90, 120, ["logElder" + "," + 1], "shortbowElderU", tool: "knife"));



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
