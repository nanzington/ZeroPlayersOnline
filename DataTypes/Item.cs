using Newtonsoft.Json;
using SadConsole;
using SadRogue.Primitives;

namespace ZeroPlayersOnline.DataTypes {
    public class Item {
        public string Name = "";
        public string ExamineText = "";
        public string ID = "";

        public int colR = 255;
        public int colG = 255;
        public int colB = 255;
        public int glyph = 1;

        public int Quantity = 1;
        public bool Stackable = false;
        public bool Tradeable = true;
        public bool Noteable = true;

        public string EquipSlot = "";
        public string MiscString = "";

        public int Value;
        public int HighAlch;
        public int LowAlch; 

        public string CooksInto = "";
        public int CookLevel = 0;
        public int CookExp = 0;

        public int EquipTier = 0;
        public string EquipDamageType = "";
        public int EquipLevel = 0;
        public string EquipSkill = ""; 

        public List<PotionStat> Potion = new();

        public bool ConsumedOnUse = true;
        public string UseString = "";
        public string UseString2 = "";
        public int UseInt = 0;

        [JsonIgnore]
        public int X = -2;
        [JsonIgnore]
        public int Y = -2;

        public Item() { }

        public Item(string n, string ex, string id, int r, int g, int b, int v, int ha, int la, bool stack = false, bool trade = true, bool note = true, string equip = "", string misc = "") {
            Name = n;
            ID = id;
            ExamineText = ex;

            colR = r;
            colG = g;
            colB = b;

            Value = v;
            HighAlch = ha;
            LowAlch = la; 

            Stackable = stack;
            Tradeable = trade;
            Noteable = note;

            EquipSlot = equip;
            MiscString = misc; 
        }

        public ColoredString GetAppearance() {
            return new ColoredString(glyph.AsString(), new Color(colR, colG, colB), Color.Black);
        }
    }
}
