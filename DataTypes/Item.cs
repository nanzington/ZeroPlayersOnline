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
        public bool Noted = false;

        public string EquipSlot = "";
        public string MiscString = ""; 

        public int Value;
        public int HighAlch;
        public int LowAlch; 

        public int EquipTier = 0;
        public string EquipDamageType = "";
        public int EquipLevel = 0;
        public string EquipSkill = "";
        public double AttackSpeed = 1; // Speed in seconds between attacks
        public string EquipAmmo = "";

        public List<PotionStat> Potion = new();

        public bool ConsumedOnUse = true;
        public string UseString = "";
        public string UseString2 = "";
        public string UseString3 = "";
        public int UseInt = 0;
        public int UseInt2 = 0;
        public int UseInt3 = 0;
        public int UseInt4 = 0;
        public List<ItemDrop> DropTable = new();

        public bool DestroyOnDrop = false;
        public bool Cosmetic = false;

        public Item() { }

        public Item(string n, string ex, string id, int r, int g, int b, int v, int ha, int la, bool stack = false, bool trade = true, string equip = "", string misc = "") {
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

            EquipSlot = equip;
            MiscString = misc; 
        } 

        public int ColorSum() {
            return colR + colG + colB;
        }

        public Color GetColor() {
            return new Color(colR, colG, colB);
        }
    }
}
