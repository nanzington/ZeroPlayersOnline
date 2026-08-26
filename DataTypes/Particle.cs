namespace ZeroPlayersOnline.DataTypes {
    public class Particle {
        public int X = 0;
        public int Y = 0;

        public int Glyph = 0;
        public int R = 0;
        public int G = 0;
        public int B = 0;

        public double LastMoved = 0;


        public Particle(int x, int y, int gly, int r, int g, int b) {
            X = x;
            Y = y;
            Glyph = gly;
            R = r;
            G = g;
            B = b;
        }
    }
}
