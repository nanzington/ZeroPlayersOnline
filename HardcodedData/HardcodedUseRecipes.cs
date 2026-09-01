using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedUseRecipes {
        public static void InitUseRecipes(Dictionary<TwoWayString, Recipe> RecipeLib) {
            List<Recipe> toAdd = new();


            toAdd.Add(new("tinderbox", "logPine", "_fire", 0, 1, 1, "Firemaking", 1, 40, miscStr: "ashes")); 

            toAdd.Add(new("oreCopper", "oreTin", "oreMixBronze", 1, 1, 1, "Smithing", 1, 2));
            toAdd.Add(new("oreIron", "oreIron", "oreMixIron", 1, 1, 1, "Smithing", 10, 4));
            toAdd.Add(new("oreIron", "oreCoal", "oreMixSteel", 1, 1, 1, "Smithing", 20, 8));

            toAdd.Add(new("bowstring", "shortbowPineU", "shortbowPine", 1, 1, 1, "Fletching", 1, 5));
            toAdd.Add(new("arrowshaft", "feather", "headlessShaft", 15, 15, 15, "Fletching", 1, 15)); 
            toAdd.Add(new("headlessShaft", "arrowheadsBronze", "arrowsBronze", 15, 15, 15, "Fletching", 1, 20)); 



            for (int i = 0; i < toAdd.Count; i++) {
                TwoWayString ID = new(toAdd[i].FirstItem, toAdd[i].SecondItem);
                RecipeLib.Add(ID, toAdd[i]);
            }
        }
    }
}
