namespace ZeroPlayersOnline.DataTypes {
    public class ProcessingStation {
        public string Name = ""; 

        public List<ProcessingRecipe> Recipes = new();

        public string OpensUI = "";

        public ProcessingStation(string n, string ui = "") {
            Name = n;  
            OpensUI = ui;
        }

        public void TryProcessItem(Player p, MessageLog log, Dictionary<string, Item> ItemLibrary, List<Skill> RecentSkills) {
            for (int i = 0; i < p.Inventory.Count; i++) {
                bool changedInv = false;
                for (int j = 0; j < Recipes.Count; j++) {
                    if (p.Inventory[i].ID == Recipes[j].InputID) {
                        if (Recipes[j].SkillUsed != "") {
                            if (p.Skills.ContainsKey(Recipes[j].SkillUsed) && p.Skills[Recipes[j].SkillUsed].Level < Recipes[j].SkillLevel) {
                                log.AddMessage(new ColoredString("You get the feeling you should have " + Recipes[j].SkillLevel + " " + Recipes[j].SkillUsed + " to try that.", Color.Crimson, Color.Black));
                                return;
                            } 
                        } 

                        p.Inventory[i].Quantity -= 1;
                        if (p.Inventory[i].Quantity <= 0) {
                            p.Inventory.RemoveAt(i);
                            changedInv = true;
                        }

                        if (ItemLibrary.ContainsKey(Recipes[j].OutputID)) {
                            Item item = Helper.Clone(ItemLibrary[Recipes[j].OutputID]);
                            p.TryPickup(item);
                        }

                        p.TryGrantExp(Recipes[j].SkillUsed, Recipes[j].SkillEXP, log, RecentSkills); 
                    }
                    if (changedInv)
                        break;
                }
                if (changedInv)
                    break;
            }
        }
    }
}
