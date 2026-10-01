namespace ZeroPlayersOnline.DataTypes {
    public class GETransaction {
        public ItemWrapper Wrap;
        public bool Buying = false;
        public int ListPrice = 0;

        public bool Resolved = false;

        public GETransaction(ItemWrapper wrap, bool buy, int price) {
            Wrap = wrap;
            Buying = buy;
            ListPrice = price;
        }

        public int PerSecondDenom() {
            if (Wrap.GetRef() is Item item) {
                int val = item.Value;

                double tenPercent = (double) val / 10.0;
                int inPrice = (int) (ListPrice / tenPercent);

                if (Buying) {
                    //return inPrice;
                    if (ListPrice == 0) // no free items, gotta pay at least 1 coin
                        return 0;

                    if (inPrice < 10) { // buying for less than value
                        int odds = 50; 

                        for (int i = 10; i > inPrice; i--) {
                            odds *= 3;
                        }
                        
                        if (odds <= 0) {
                            return 0;
                        } 
                        return odds;
                    } else if (inPrice > 10) { // buying for more than value
                        if (inPrice >= 20) {
                            return 1;
                        }

                        return Math.Clamp(50 - ((inPrice - 10) * 5), 0, 50);
                    } else {
                        return 50;
                    }
                } else {
                    if (ListPrice == 0) // if you want to get rid of things for free then go ahead I guess
                        return 1;

                    if (inPrice > 10) { // selling for more than value
                        int odds = 50; 

                        for (int i = 0; i < inPrice - 10; i++) {
                            odds = Math.Clamp(odds * 3, 0, int.MaxValue);
                        }
                        
                        if (odds <= 0) {
                            return 0;
                        } 
                        return odds;
                    } else if (inPrice < 10) { // selling for less than value
                        if (inPrice <= 5) {
                            return 1;
                        }

                        return Math.Clamp(50 - ((10 - inPrice) * 5), 0, 50);
                    } else {
                        return 50;
                    }
                }
            }

            return 0;
        }
    }
}
