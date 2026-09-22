namespace ZeroPlayersOnline.DataTypes {
    public class Book {
        public string Name = "";
        public string ID = "";
        public int FrameType = 0;
        public List<BookPage> Pages = new();

        public Book(string name, string id, int frame, List<BookPage> pages) {
            Name = name;
            ID = id;
            FrameType = frame;

            Pages = pages;
        }
    }
}
