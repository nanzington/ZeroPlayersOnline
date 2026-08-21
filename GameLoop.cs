using ZeroPlayersOnline.DataTypes;
using ZeroPlayersOnline.Managers;
using ZeroPlayersOnline.UI;
using SadConsole;
using SadRogue.Primitives;
using System.ComponentModel;
using ZeroPlayersOnline; 

namespace ZeroPlayersOnline {
    class GameLoop {
        public const int GameWidth = 150;
        public const int GameHeight = 50;

#pragma warning disable CS8618
        public static SadFont SquareFont;
        public static UIManager UIManager;
        public static Random rand;
        public static SoundManager SoundManager; 
        public static SaveFile SaveFile;

        public static ZeroPlayersOnline ZPO;
#pragma warning restore CS8618  

        static void Main(string[] args) {
            Game.Create(GameWidth, GameHeight, "./fonts/ThinExtended.font", Init); 
            Game.Instance.FrameUpdate += GlobalUpdate;

            Game.Instance.Run();
            Game.Instance.Dispose();
        }

        private static void Init(object? sender, GameHost e) {
            SquareFont = (SadFont)GameHost.Instance.LoadFont("./fonts/CheepicusExtended.font");
            Game.Instance.MonoGameInstance.Window.Title = "Zero Players Online";
            rand = new();
            TypeDescriptor.AddAttributes(typeof(Point), new TypeConverterAttribute(typeof(PointConverter)));


            UIManager = new();
            SoundManager = new();

            UIManager.Init();
        }

        private static void GlobalUpdate(object? sender, GameHost e) {  
            if (!GameHost.Instance.Mouse.LeftButtonDown) {
                Helper.ProcessedClick = false;
            }
        }
    }
}
