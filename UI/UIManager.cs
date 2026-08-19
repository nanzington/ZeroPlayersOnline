using SadConsole;
using SadConsole.UI;
using SadRogue.Primitives;
using Key = SadConsole.Input.Keys;  

namespace ZeroPlayersOnline.UI {
    public class UIManager : ScreenObject {
        public SadConsole.UI.Colors? CustomColors;
        public Dictionary<string, InstantUI> Interfaces = new();

        public UI_EmbeddedMini zpoWrap; 

        public UIManager() {
            IsVisible = true;
            IsFocused = true;
            UseMouse = true;
            Parent = GameHost.Instance.Screen; 
        }

        public InstantUI? GetUI(string name) {
            if (Interfaces.ContainsKey(name))
                return Interfaces[name];
            return null;
        }

        public void ToggleUI(string name) {
            if (Interfaces.ContainsKey(name)) {
                Interfaces[name].Win.IsVisible = !Interfaces[name].Win.IsVisible; 
                
                if (Interfaces[name].Win.IsVisible) {
                    Interfaces[name].Win.IsFocused = true;
                } 
            }
        }

        public override void Update(TimeSpan timeElapsed) {
            // Handle some music selection stuff
            /*
            if (!GameLoop.SoundManager.Music.IsCurrentlyPlaying("./sounds/music/" + GameLoop.SoundManager.CurrentSong + ".ogg"))
                GameLoop.SoundManager.PickMusic();
            */
            foreach (KeyValuePair<string, InstantUI> kv in Interfaces) {
                if (kv.Value.Win.IsVisible) {
                    kv.Value.Update();
                    kv.Value.Input();
                    kv.Value.Win.IsFocused = true; 
                }
            }

            if (GameHost.Instance.Keyboard.KeysDown.Count == 0)
                Helper.ClearKeys();

            base.Update(timeElapsed);
        }

        public void Init() {
            SetupCustomColors(); 

            zpoWrap = new UI_EmbeddedMini(150, 50, "ZeroPlayersOnline", new ZeroPlayersOnline()); 
            zpoWrap.Win.IsVisible = true;
        }


        private void SetupCustomColors() {
            CustomColors = Colors.CreateAnsi();
            CustomColors.ControlHostBackground = new AdjustableColor(Color.Black, "Black");
            CustomColors.Lines = new AdjustableColor(Color.White, "White");
            CustomColors.Title = new AdjustableColor(Color.White, "White");

            CustomColors.RebuildAppearances(); 
            Colors.Default = CustomColors;
        }
    }
}
