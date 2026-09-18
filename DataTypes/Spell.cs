using Newtonsoft.Json;
using ZeroPlayersOnline.Managers;

namespace ZeroPlayersOnline.DataTypes {
    public class Spell {
        public string ID = "";
        public string Name = "";
        public string Book = "";
        public string Category = "";
        public string Description = "";

        public int Level = 0;
        public int ExpOnCast = 0;

        public int Tier = 1;
        public string MiscString = "";


        public double CooldownInMS = 0; 
        
        public List<string> Runes = new();

        public List<Requirement> ToCast = new();

        
        [JsonIgnore]
        public double TimeLastCast = 0;


        public Spell(string id, string name, string book, int level, int exp, List<string> runes, string desc = "", string cat = "", int tier = 1, string misc = "", double cd = 0, List<Requirement>? reqs = null) {
            ID = id;
            Name = name;
            Book = book;
            Level = level;
            ExpOnCast = exp;
            Runes = runes;
            Category = cat;
            Tier = tier;
            MiscString = misc;
            Description = desc;

            CooldownInMS = cd;

            if (reqs != null)
                ToCast = reqs;
        }

        public void Cast(Player p, MessageLog Log, List<Skill> RecentlyTrained) {
            p.ConsumeItems(Runes);
            if (Category == "Tele" && MiscString != "" && GameLoop.ZPO.Atlas.ContainsKey(MiscString)) { 
                p.NavLoc = MiscString; // TODO: Check to make sure the player is allowed in that region
            } 
            TimeLastCast = Helper.Time();
            p.TryGrantExp("Magic", ExpOnCast, Log, RecentlyTrained);
        }

    }
}
