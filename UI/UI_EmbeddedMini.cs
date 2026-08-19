
using Key = SadConsole.Input.Keys;
using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.UI {
    public class UI_EmbeddedMini : InstantUI {
        public Console SingleSquare;
        public Console DoubleSquare;
        public Console QuadSquare; 

        public string ID = "";

        public MiniDream Game;

        public UI_EmbeddedMini(int width, int height, string game, MiniDream what) : base(width, height, "Mini_" + game, "") {
            Con = new(width - 2, height - 2);
            Con.Position = new(1, 1);

            SingleSquare = new Console(new CellSurface(86, 48), GameLoop.SquareFont); 
            SingleSquare.UsePixelPositioning = true;
            SingleSquare.Position = new Point(9, 12);
            Win.Children.Add(SingleSquare); 

            DoubleSquare = new Console(new CellSurface(43, 24), GameLoop.SquareFont);
            DoubleSquare.UsePixelPositioning = true;
            DoubleSquare.Position = new Point(9, 12);
            DoubleSquare.FontSize = new Point(24, 24);
            Win.Children.Add(DoubleSquare);

            QuadSquare = new Console(new CellSurface(21, 12), GameLoop.SquareFont);
            QuadSquare.UsePixelPositioning = true;
            QuadSquare.Position = new Point(9, 12);
            QuadSquare.FontSize = new Point(48, 48);
            Win.Children.Add(QuadSquare);

            Win.CanDrag = false;
            Helper.DrawBox(Win, 0, 0, width - 2, height - 2);

            Win.Title = "".Align(HorizontalAlignment.Center, width - 2, (char)196);
            Win.Position = new Point(0, 0);


            Win.Children.Add(Con);
            GameLoop.UIManager.Children.Add(Win);

            Win.Show();
            Win.IsVisible = false;

            ID = "Mini_" + game;
            Game = what;
        }

        public override void Update() {
            Game.Update(this);
        }

        public override void Input() {
            Game.Input(this);
        }

        public void Toggle() { 
            GameLoop.UIManager.ToggleUI(ID);
        }
    }
}
