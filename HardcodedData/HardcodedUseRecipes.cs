using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedUseRecipes {
        public static void InitUseRecipes(Dictionary<TwoWayString, Recipe> RecipeLib) {
            List<Recipe> toAdd = new();


            toAdd.Add(new("tinderbox", "logPine", "_fire", 0, 1, 1, "Firemaking", 1, 40, miscStr: "ashes"));

            toAdd.Add(new("oreCopper", "oreTin", "oreMixBronze", 1, 1, 1, "Smithing", 1, 2));

            toAdd.Add(new("plansHelmet", "barBronze", "progHelmBronze1", 0, 1, 1, "Smithing", 1, 0));
            toAdd.Add(new("progHelmBronze1", "barBronze", "progHelmBronze2", 1, 1, 1, "Smithing", 1, 0));

            toAdd.Add(new("plansDagger", "barBronze", "progDaggerBronze", 0, 1, 1, "Smithing", 1, 0));


            for (int i = 0; i < toAdd.Count; i++) {
                TwoWayString ID = new(toAdd[i].FirstItem, toAdd[i].SecondItem);
                RecipeLib.Add(ID, toAdd[i]);
            }
        }
    }
}
