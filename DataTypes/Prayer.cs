namespace ZeroPlayersOnline.DataTypes {
    public class Prayer {
        public string Name = "";
        public string Book = "";
        public string Description = "";
        public int Level = 0; 

        public string SkillBuffed = "";

        public bool Active = false;

        public Prayer(string name, string book, int lev, string desc, string buffed = "") {
            Name = name;
            Book = book;
            Level = lev; 
            SkillBuffed = buffed;
            Description = desc;
        }
    }
}
