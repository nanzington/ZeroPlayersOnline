namespace ZeroPlayersOnline.DataTypes {
    public class SpecificPosition {
        public int X;
        public int Y;
        public int mX;
        public int mY;
        public int Depth = 0;
        public string WorldArea = "Overworld"; 

        public SpecificPosition(int x, int y, int mx, int my, string wa, int d = 0) {
            X = x;
            Y = y;
            mX = mx;
            mY = my;
            WorldArea = wa;
            Depth = d;
        }

        public Point GetPos() { return new Point(X, Y); }
        public Point GetMapPos() { return new Point(mX, mY); }

        public bool SameMap(int mx, int my, int d, string wa) {
            return mx == mX && my == mY && d == Depth && wa == WorldArea;
        }

        public bool SameMap(SpecificPosition other) {
            return SameMap(other.mX, other.mY, other.Depth, other.WorldArea);
        }

        public SpecificPosition But(string what, string where = "") {
            SpecificPosition output = Helper.Clone(this);

            if (what == "mup") {
                output.mY -= 1;
            } else if (what == "mdown") {
                output.mY += 1;
            } else if (what == "mleft") {
                output.mX -= 1;
            } else if (what == "mright") {
                output.mX += 1;
            }
            else if (what == "up") {
                output.Y -= 1;
            } else if (what == "down") {
                output.Y += 1;
            } else if (what == "left") {
                output.X -= 1;
            } else if (what == "right") {
                output.X += 1;
            }

            else if (what == "world") {
                output.WorldArea = where;
            }

            return output;
        }
    }
}
