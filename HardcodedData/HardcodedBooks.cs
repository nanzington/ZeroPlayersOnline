using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.HardcodedData {
    public static class HardcodedBooks {
        public static void InitBooks(Dictionary<string, Book> BookLib) {
            List<Book> toAdd = new();

            toAdd.Add(new("Pie recipe book", "recipesPie", 1, new() {
                new("Redberry pie", "Pour a handful of Redberries into an empty Pie Shell, bake until the berries are soft and serve warm."),
                new("Meat pie", "Line a fresh Pie Shell with Cooked Meat and heat until the pastry starts to bronze, serve with a selection of sauces."),
                new("Mud pie", "Start with a Pie Shell and add a Bucket of Compost, then pour in a Bucket of Water to keep the consistency gooey. To finish, cover with Clay and bake until a good shell forms. Serve at maximum speed with a good over-arm throw!"),
                new("Apple pie", "Take a Pie Shell and layer in Apple, cook until the juices start to bubble and leave to cool before serving."),
                new("Garden pie", "Fill a Pie Shell with Tomato, then add Onion and top with Cabbage. Bake golden brown and serve with a steak."),
                new("Fish pie", "Take one Pie Shell and fill with Trout, add a Cod for flavor, and then top with Potato for texture. Cook well until the potato turns golden and serve."),
                new("Botanical pie", "Line a Pie Shell with a Golovanova fruit. Bake until the fruit has become crispy on the top. Best served with cream and some milk."),
                new("Mushroom pie", "If you are looking for an acquired taste, fill your Pie Shell with a Sulliuscep cap and bake until the Pie Shell starts to take on the Sulliuscep's color."),
                new("Admiral pie", "For a more upperclass fish pie, fill your Pie Shell with Salmon and then add Tuna for color. Top with Potato and cook until golden."),
                new("Dragonfruit pie", "If you're looking for an exotic pie, fill your Pie Shell with a single Dragonfruit cut into chunks. Cook until the crust starts to glow."),
                new("Wild pie", "Line a Pie Shell with Raw Bear Meat, then add Raw Chompy for substance, and top with fresh Rabbit Meat. Bake until the juices start to bubble and serve."),
                new("Summer pie", "Into a Pie Shell, put Strawberry, then a layer of Watermelon, and top with Apple. Cook well and leave to cool before serving.")
            }));

            toAdd.Add(new("Scrumpled paper", "paperScrumpled", 0, new() {
                new("Delicious Ugthanki Kebab", "Ingredients: Cooked Ugthanki meat, Flour, Water, Onion, Tomato. The Ugthanki meat should be nicely grilled. "),
                new("Delicious Ugthanki Kebab", "Next take the flour and water and make some Pitta Bread. You'll need a range to do this. Take an onion and chop it into a bowl. Take a tomato and chop it into the onion mixture."),
                new("Delicious Ugthanki Kebab", "Chop the meat into the Onion and Tomato mixture. Finally fill the pitta bread with the Ugthanki, Onion, and Tomato mixture to make your delicious Ugthanki Kebab.")
            }));

            toAdd.Add(new("Shield of Arrav", "bookArrav", 1, new() {
                new("", ""),
                new("", "/n /n /n /n    The Shield of Arrav /n /n       by A. R. Wright"),
                new("Shield of Arrav", "Arrav is probably the best known hero of the 4th Age. Many legends are told of his heroics. /n /n One surviving artefact from the 4th Age is a fabulous shield. This shield is believed to have once belonged to Arrav and is now indeed known as the Shield of Arrav. /n /n For over 150 years it was the prize piece in the royal museum of Varrock."),
                new("Shield of Arrav", "However, in the year 143 of the fifth age a gang of thieves called the Phoenix Gang broke into the museum and stole the shield in a daring raid.  /n /n As a result, the current ruler, King Roald, put a 1200 gold bounty (a massive sum of money in those days) on the return of the shield, hoping that one of the culprits would betray his fellows out of greed."),
                new("Shield of Arrav", "This tactic did not work however, and the thieves who stole the shield have since gone on to become the most powerful crime gang in Varrock, despite making an enemy of the Royal Family many years ago. /n /n The reward for the return of the shield still stands.")
            }));


            for (int i = 0; i < toAdd.Count; i++) {
                BookLib.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
