using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroPlayersOnline.DataTypes {
    public class ItemWrapper {
        public string ID = "";
        public int Quantity = 1;
        public int Charges = 1;
        public bool Noted = false; 

        [JsonIgnore]
        public Item? Library = null; 

        public ItemWrapper() { }

        public ItemWrapper(Item wrap) {
            ID = wrap.ID;
            Quantity = wrap.Quantity;
             
            Charges = wrap.UseInt4; 

            Noted = wrap.Noted;
        }

        public ItemWrapper(string id, int qty, bool note = false, int chg = 1) {
            ID = id;
            Quantity = qty;
            Noted = note;
            Charges = chg;
        }


        public Item? GetRef() {
            if (Library == null) {
                if (GameLoop.ZPO.ItemLibrary.TryGetValue(ID, out Item? lib) && lib != null) {
                    Item clone = Helper.Clone(lib);
                    clone.Quantity = Quantity;
                    clone.UseInt4 = Charges;
                    return clone;
                }
            }

            return Helper.Clone(Library);
        }

        public void TryConsume() {
            if (GameLoop.ZPO.player.PrayerActive("Cornucopia")) {
                if (GameLoop.rand.Next(5) != 0) { 
                    Quantity -= 1;
                } else { 
                    GameLoop.ZPO.Log.AddMessage(new ColoredString("The blessing of the cornucopia preserves your item.", Color.Goldenrod, Color.Black));
                }
            } else {
                Quantity -= 1;
            }
        }
    }
}
