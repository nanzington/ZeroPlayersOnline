using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlayersOnline.DataTypes {
    public class ItemDrop {
        public string ItemID = "";
        public int DropX = 0;
        public int InY = 0;

        public int QuantityMin = 0;
        public int QuantityMax = 1;

        public ItemDrop(string id, int x, int y, int min, int max) {
            ItemID = id;
            DropX = x;
            InY = y;

            QuantityMin = min;
            QuantityMax = max;
        }

        // Rolls 0 to InY, if less than DropX, success
        // So if DropX is 1 and InY is 10, then on a roll of 0-9, landing on a 0 is a successful drop, giving 10% chance to drop
    }
}
