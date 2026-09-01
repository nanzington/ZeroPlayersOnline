using Newtonsoft.Json;

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

        
        [JsonIgnore]
        public double TimeLastCast = 0;


        public Spell(string id, string name, string book, int level, int exp, List<string> runes, string desc = "", string cat = "", int tier = 1, string misc = "", double cd = 0) {
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
        }

    }
}
