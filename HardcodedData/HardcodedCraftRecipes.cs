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
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 2, ["bar" + Metals[i].Name + "," + 2], "spear" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 4, ["bar" + Metals[i].Name + "," + 4], "sword2h" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 4, ["bar" + Metals[i].Name + "," + 4], "warhammer" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 4, ["bar" + Metals[i].Name + "," + 4], "battleaxe" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "hatchet" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "pickaxe" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 2, ["bar" + Metals[i].Name + "," + 2], "helm" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 5, ["bar" + Metals[i].Name + "," + 5], "platebody" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 5, ["bar" + Metals[i].Name + "," + 5], "chainmail" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 3, ["bar" + Metals[i].Name + "," + 3], "platelegs" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 3, ["bar" + Metals[i].Name + "," + 3], "plateskirt" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "boots" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "gauntlets" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "arrowheads" + Metals[i].Name, 15, "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "boltsUnf" + Metals[i].Name, 15, "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier, ["bar" + Metals[i].Name + "," + 1], "knives" + Metals[i].Name, 5, "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 2, ["bar" + Metals[i].Name + "," + 2], "sqShield" + Metals[i].Name, tool: "hammer"));
                toAdd.Add(new("Anvil", "Smithing", Metals[i].Level, Metals[i].CostMultiplier * 3, ["bar" + Metals[i].Name + "," + 3], "kiteshield" + Metals[i].Name, tool: "hammer"));
            }
            
            toAdd.Add(new("Anvil", "Smithing", 20, 50, ["barMithril" + "," + 1], "grappleUnf", tool: "hammer"));
            toAdd.Add(new("Anvil", "Smithing", 20, 75, ["barSteel" + "," + 1], "studsSteel", tool: "hammer"));

            List<MaterialDef> Leathers = new() {
                new("Leather", 205, 127, 50, 255, 1, 1, 15, "leatherSoft"), 
                new("Hardleather", 175, 97, 20, 255, 2, 10, 25, "leatherHard"),
                new("Snakeskin", Color.DarkOliveGreen, 4, 30, 30, "leatherSnakeskin"), 
                new("Green dragonhide", Color.ForestGreen, 5, 40, 62, "leatherDragonGreen"),
                new("Blue dragonhide", Color.CadetBlue, 6, 50, 70, "leatherDragonBlue"),
                new("Red dragonhide", Color.Crimson, 6, 55, 78, "leatherDragonRed"),
                new("Black dragonhide", Color.DimGray, 7, 60, 86, "leatherDragonBlack")
            };

            foreach (var leather in Leathers) {
                toAdd.Add(new("Needle", "Crafting", leather.Level, leather.CostMultiplier, [leather.Descriptor + "," + 1], "coif" + leather.Name, tool: "needle"));
                toAdd.Add(new("Needle", "Crafting", leather.Level, leather.CostMultiplier * 5, [leather.Descriptor + "," + 5], "body" + leather.Name, tool: "needle"));
                toAdd.Add(new("Needle", "Crafting", leather.Level, leather.CostMultiplier * 3, [leather.Descriptor + "," + 3], "chaps" + leather.Name, tool: "needle"));
                toAdd.Add(new("Needle", "Crafting", leather.Level, leather.CostMultiplier, [leather.Descriptor + "," + 1], "vambraces" + leather.Name, tool: "needle"));
                toAdd.Add(new("Needle", "Crafting", leather.Level, leather.CostMultiplier, [leather.Descriptor + "," + 1], "boots" + leather.Name, tool: "needle"));
            }


            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "arrowshaft", 15, "knife"));
            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "shortbowPineU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "longbowPineU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 1, 5, ["logPine" + "," + 1], "stockPine", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 10, 10, ["logOak" + "," + 1], "arrowshaft", 30, "knife"));
            toAdd.Add(new("Knife", "Fletching", 10, 10, ["logOak" + "," + 1], "shortbowOakU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 10, 10, ["logOak" + "," + 1], "longbowOakU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 10, 10, ["logOak" + "," + 1], "stockOak", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 20, 15, ["logWillow" + "," + 1], "arrowshaft", 45, "knife"));
            toAdd.Add(new("Knife", "Fletching", 20, 15, ["logWillow" + "," + 1], "shortbowWillowU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 20, 15, ["logWillow" + "," + 1], "longbowWillowU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 20, 15, ["logWillow" + "," + 1], "stockWillow", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 30, 20, ["logTeak" + "," + 1], "arrowshaft", 60, "knife"));
            toAdd.Add(new("Knife", "Fletching", 30, 30, ["logTeak" + "," + 1], "shortbowTeakU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 30, 30, ["logTeak" + "," + 1], "longbowTeakU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 30, 30, ["logTeak" + "," + 1], "stockTeak", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 40, 25, ["logMaple" + "," + 1], "arrowshaft", 75, "knife"));
            toAdd.Add(new("Knife", "Fletching", 40, 45, ["logMaple" + "," + 1], "shortbowMapleU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 40, 45, ["logMaple" + "," + 1], "longbowMapleU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 40, 45, ["logMaple" + "," + 1], "stockMaple", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 50, 30, ["logAcadia" + "," + 1], "arrowshaft", 90, "knife"));
            toAdd.Add(new("Knife", "Fletching", 50, 60, ["logAcadia" + "," + 1], "shortbowAcadiaU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 50, 60, ["logAcadia" + "," + 1], "longbowAcadiaU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 50, 60, ["logAcadia" + "," + 1], "stockAcadia", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 60, 35, ["logMahogany" + "," + 1], "arrowshaft", 105, "knife"));
            toAdd.Add(new("Knife", "Fletching", 60, 75, ["logMahogany" + "," + 1], "shortbowMahoganyU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 60, 75, ["logMahogany" + "," + 1], "longbowMahoganyU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 60, 75, ["logMahogany" + "," + 1], "stockMahogany", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 70, 40, ["logYew" + "," + 1], "arrowshaft", 120, "knife"));
            toAdd.Add(new("Knife", "Fletching", 70, 90, ["logYew" + "," + 1], "shortbowYewU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 70, 90, ["logYew" + "," + 1], "longbowYewU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 70, 90, ["logYew" + "," + 1], "stockYew", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 80, 45, ["logMagic" + "," + 1], "arrowshaft", 135, "knife"));
            toAdd.Add(new("Knife", "Fletching", 80, 105, ["logMagic" + "," + 1], "shortbowMagicU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 80, 105, ["logMagic" + "," + 1], "longbowMagicU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 80, 105, ["logMagic" + "," + 1], "stockMagic", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 90, 50, ["logElder" + "," + 1], "arrowshaft", 150, "knife"));
            toAdd.Add(new("Knife", "Fletching", 90, 120, ["logElder" + "," + 1], "shortbowElderU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 90, 120, ["logElder" + "," + 1], "longbowElderU", tool: "knife"));
            toAdd.Add(new("Knife", "Fletching", 90, 120, ["logElder" + "," + 1], "stockElder", tool: "knife"));



            toAdd.Add(new("Pottery Wheel", "Crafting", 1, 7, ["claySoft" + "," +  1], "unfiredPot"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 3, 9, ["claySoft" + "," +  1], "unfiredCup", 4));
            toAdd.Add(new("Pottery Wheel", "Crafting", 7, 15, ["claySoft" + "," +  1], "unfiredPieDish"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 8, 18, ["claySoft" + "," +  1], "unfiredBowl"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 19, 20, ["claySoft" + "," +  1], "unfiredPlantPot"));
            toAdd.Add(new("Pottery Wheel", "Crafting", 25, 30, ["claySoft" + "," +  1], "unfiredPotLid")); 


            // Jewellery
            List<MaterialDef> Jewels = new() {
                new("Gold", Color.Goldenrod, 0, 5, 34, "Gold"),
                new("Opal", Color.AntiqueWhite, 1, 7, 19, "Opal"),
                new("Jade", Color.PaleGreen, 1, 27, 24, "Jade"),
                new("Red topaz", Color.Magenta, 1, 49, 34, "RedTopaz"),
                new("Sapphire", Color.DeepSkyBlue, 2, 7, 69, "Sapphire"),
                new("Emerald", Color.Lime, 3, 27, 74, "Emerald"),
                new("Ruby", Color.Crimson, 4, 49, 89, "Ruby"),
                new("Diamond", Color.White, 5, 57, 104, "Diamond"),
                new("Dragonstone", Color.Purple, 6, 68, 154, "Dragonstone"),
                new("Onyx", Color.DimGray, 7, 87, 169, "Onyx"),
                new("Zenyte", Color.Orange, 8, 93, 200, "Zenyte")
            };

            foreach (var mat in Jewels) {
                List<string> mats = new(); 
                if (mat.Name == "Opal" || mat.Name == "Jade" || mat.Name == "Red topaz") {
                    mats.Add("barSilver,1");
                } else {
                    mats.Add("barGold,1");
                }

                if (mat.Name != "Gold") {
                    mats.Add("cut" + mat.Descriptor + ",1");
                }

                
                toAdd.Add(new("Casting", "Crafting", mat.Level, mat.CostMultiplier, mats, "amulet" + mat.Descriptor + "U", 1, "mouldAmulet")); 
                toAdd.Add(new("Casting", "Crafting", mat.Level, mat.CostMultiplier, mats, "ring" + mat.Descriptor, 1, "mouldRing")); 
                toAdd.Add(new("Casting", "Crafting", mat.Level, mat.CostMultiplier, mats, "bracelet" + mat.Descriptor, 1, "mouldBracelet")); 
                toAdd.Add(new("Casting", "Crafting", mat.Level, mat.CostMultiplier, mats, "necklace" + mat.Descriptor, 1, "mouldNecklace")); 
            }



            for (int i = 0; i < toAdd.Count; i++) {
                if (!CraftLib.ContainsKey(toAdd[i].Station))
                    CraftLib.Add(toAdd[i].Station, new());
                CraftLib[toAdd[i].Station].Add(toAdd[i]);
            }
        }
    }
}
