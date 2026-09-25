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
        public int colA = 255; 

        public int Quantity = 1;
        public bool Stackable = false;
        public bool Tradeable = true;
        public bool Noteable = true;
        public bool Noted = false;
        public bool OnlyOneOwnable = false;

        public string EquipSlot = "";
        public string MiscString = ""; 

        public int Value; 

        public double EquipTier = 0;
        public string EquipDamageType = "";
        public string EquipSecondaryDamage = "";
        public int EquipLevel = 0;
        public string EquipSkill = "";
        public double AttackSpeed = 1; // Speed in seconds between attacks
        public string EquipAmmo = "";
        public bool TwoHanded = false;

        public List<PotionStat> Potion = new();

        public bool ConsumedOnUse = true;
        public string UseString = "";
        public string UseString2 = "";
        public string UseString3 = "";
        public int UseInt = 0;
        public int UseInt2 = 0;
        public int UseInt3 = 0;
        public int UseInt4 = 0;
        public string ChargeItem = "";
        public bool MustBeEquipped = false;
        public bool UsesCharges = false;
        public string ItemReturned = "";
        public List<ItemDrop> DropTable = new();

        public bool DestroyOnDrop = false;
        public bool Cosmetic = false;

        public List<string> PetBlurbs = new();

        public Requirement? EquipReq = null;

        public List<string> TeleportLocations = new();
        public bool ShattersAtZeroCharges = true;
        public string CosmeticNote = "";

        public List<string> CountsAsIDs = new();

        public bool ExposedFlame = false;
        public bool ProvidesLight = false;

        public int ContainerSlots = 0;
        public bool ContainerStacksUnstackable = false;
        public int ContainerMaxStack = -1;
        public List<ItemWrapper> Containing = new();
        public List<string> ContainableIDs = new(); 

        [JsonIgnore]
        public bool Inaccessible = false;

        public Item() { }

        public Item(string n, string ex, string id, Color c, int v, bool stack = false, bool trade = true, string misc = "") : this(n, ex, id, c.R, c.G, c.B, v, stack, trade, misc) { } 

        public Item(string n, string ex, string id, int r, int g, int b, int v, bool stack = false, bool trade = true, string misc = "") {
            Name = n;
            ID = id;
            ExamineText = ex;

            colR = r;
            colG = g;
            colB = b;

            Value = v; 

            Stackable = stack;
            Tradeable = trade; 

            MiscString = misc; 
        }

        public Item(Item other) {
            Name = other.Name;
            ExamineText = other.ExamineText;
            ID = other.ID;
            colR = other.colR;
            colG = other.colG;
            colB = other.colB;
            Quantity = other.Quantity;  
            Stackable = other.Stackable;
            Tradeable = other.Tradeable;
            Noteable = other.Noteable;
            Noted = other.Noted;
            OnlyOneOwnable = other.OnlyOneOwnable;

            MiscString = other.MiscString;
            EquipSlot = other.EquipSlot; 
            Value = other.Value;
            EquipTier = other.EquipTier;
            EquipDamageType = other.EquipDamageType;
            EquipSecondaryDamage = other.EquipSecondaryDamage;
            EquipLevel = other.EquipLevel;
            EquipSkill = other.EquipSkill;
            AttackSpeed = other.AttackSpeed;
            EquipAmmo = other.EquipAmmo;
            TwoHanded = other.TwoHanded;

            for (int i = 0; i < other.Potion.Count; i++) {
                Potion.Add(new(other.Potion[i].Stat, other.Potion[i].Change));
            } 

            ConsumedOnUse = other.ConsumedOnUse;
            UseString = other.UseString;
            UseString2 = other.UseString2;
            UseString3 = other.UseString3;
            UseInt = other.UseInt;
            UseInt2 = other.UseInt2;
            UseInt3 = other.UseInt3;
            UseInt4 = other.UseInt4; 
            ChargeItem = other.ChargeItem;
            ItemReturned = other.ItemReturned;
            UsesCharges = other.UsesCharges;
            ExposedFlame = other.ExposedFlame;
            ProvidesLight = other.ProvidesLight;

            MustBeEquipped = other.MustBeEquipped;

            if (other.DropTable != null && other.DropTable.Count > 0) {
                DropTable = new();
                foreach (var d in other.DropTable) {
                    Requirement? req = null;
                    if (d.Requirement != null) {
                        req = new(d.Requirement.RequirementType, d.Requirement.MiscInt, d.Requirement.MiscString, d.Requirement.ConsumeItem, d.Requirement.MiscString2, d.Requirement.CustomSummary);
                    }

                    DropTable.Add(new(d.ItemID, d.DropX, d.InY, d.QuantityMin, d.QuantityMax, d.Noted, d.EvenAt0x, req, d.AltLog));
                }
            } 

            DestroyOnDrop = other.DestroyOnDrop;
            Cosmetic = other.Cosmetic;
            CosmeticNote = other.CosmeticNote;

            if (other.PetBlurbs.Count > 0) {
                for (int i = 0; i < other.PetBlurbs.Count; i++) {
                    PetBlurbs.Add(other.PetBlurbs[i]);
                }
            }

            if (other.TeleportLocations.Count > 0) {
                for (int i = 0; i < other.TeleportLocations.Count; i++) {
                    TeleportLocations.Add(other.TeleportLocations[i]);
                }
            }
            ShattersAtZeroCharges = other.ShattersAtZeroCharges;

            if (other.CountsAsIDs.Count > 0) {
                for (int i = 0; i < other.CountsAsIDs.Count; i++) {
                    CountsAsIDs.Add(other.CountsAsIDs[i]);
                }
            }

            if (other.EquipReq != null) {
                EquipReq = new(other.EquipReq.RequirementType, other.EquipReq.MiscInt, other.EquipReq.MiscString, other.EquipReq.ConsumeItem, other.EquipReq.MiscString2, other.EquipReq.CustomSummary);
            }

            Inaccessible = other.Inaccessible; 

            ContainerSlots = other.ContainerSlots;
            ContainerStacksUnstackable = other.ContainerStacksUnstackable;
            ContainerMaxStack = other.ContainerMaxStack;

            for (int i = 0; i < other.Containing.Count; i++) {
                Containing.Add(new(other.Containing[i]));
            }

            for (int i = 0; i < other.ContainableIDs.Count; i++) {
                ContainableIDs.Add(other.ContainableIDs[i]);
            } 
        }

        public int ColorSum() {
            return colR + colG + colB;
        }

        public Color GetColor() {
            return new Color(colR, colG, colB, colA);
        }

        public int HighAlchVal() {
            return (int) Math.Ceiling(Value * 0.70);
        }

        public int LowAlchVal() {
            return (int) Math.Ceiling(Value * 0.35);
        }

        public bool CanEquip(Player p) {
            if (EquipReq != null) {
                return EquipReq.CheckRequirement(p, false);
            }

            return true;
        }

        public ColoredString GetNameCS(int qty = 1, int shop = 0, int charges = 0, bool noted = false) {
            ColoredString build = qty > 1 ? new ColoredString(qty + "x ") : new ColoredString("");
            build += new ColoredString(Name, GetColor(), ColorSum() > 50 ? Color.Black : Color.White);
             
            if (Name.Contains("potion") && charges != 0) {
                build += new ColoredString(" (" + charges + " doses)", Color.White, Color.Black);
            } else if (charges > 0 && !ID.Contains("seed") && !ID.Contains("plant")) { 
                build += new ColoredString(" (" + charges + ")", Color.White, Color.Black);
            }

            if (CosmeticNote != "") {
                if (CosmeticNote == "t") { build += new ColoredString(" (t)", Color.White, Color.Black); } 
                if (CosmeticNote == "g") { build += new ColoredString(" (g)", Color.Yellow, Color.Black); }
                if (CosmeticNote == "h") { build += new ColoredString(" (h)", Color.Turquoise, Color.Black); }
            }

            if (noted) {
                build += new ColoredString(" (n)", Color.Khaki, Color.Black);
            }

            if (shop > 0) { 
                int sellValue = Value;

                if (charges != 0 && UseString == "Potion") {
                    sellValue *= charges;
                }

                if (GameLoop.ZPO.Atlas.TryGetValue(GameLoop.ZPO.player.NavLoc, out Location? curr)) {
                    if (curr.ShopPriceMultiplier != 1.0) {
                        sellValue = (int) (sellValue * curr.ShopPriceMultiplier);
                    }
                }

                                        
                if (!GameLoop.ZPO.player.ShopsAlwaysFullPrice && shop == 1) {
                    sellValue = (int) (Math.Floor(sellValue / 2.0));
                }

                build += new ColoredString(" [" + sellValue + " gp]", Color.Goldenrod, Color.Black);
            }

            return build;
        }

        public string GetName(int qty = 1, int shop = 0, int charges = 0, bool noted = false) {
            string build = qty > 1 ? qty + "x " : "";
            build += Name;
             
            if (Name.Contains("potion") && charges != 0) {
                build += " (" + charges + " doses)";
            } else if (charges > 0 && !ID.Contains("seed") && !ID.Contains("plant")) { 
                build += " (" + charges + ")";
            }

            if (CosmeticNote != "") {
                if (CosmeticNote == "t") { build += " (t)"; } 
                if (CosmeticNote == "g") { build += " (g)"; }
                if (CosmeticNote == "h") { build += " (h)"; }
            }

            if (noted) {
                build += " (n)";
            }

            if (shop > 0) { 
                int sellValue = Value;

                if (charges != 0 && UseString == "Potion") {
                    sellValue *= charges;
                }
                                        
                if (!GameLoop.ZPO.player.ShopsAlwaysFullPrice && shop == 1) {
                    sellValue = (int) (Math.Floor(sellValue / 2.0));
                }

                build += " [" + sellValue + " gp]";
            }

            return build;
        }
    }
}
