using Key = SadConsole.Input.Keys;

namespace ZeroPlayersOnline.UI {
    public interface MiniDream { 
        public virtual void Update(UI_EmbeddedMini mini) { 
            //Point mousePos = new MouseScreenObjectState(mini.Con, GameHost.Instance.Mouse).CellPosition;  
        }

        public virtual void Input(UI_EmbeddedMini mini) {
            if (Helper.HotkeyDown(Key.Escape)) {
                Close(mini);
            }
        }

        public virtual void Close(UI_EmbeddedMini mini) { 
            Reset();
            mini.Toggle();
        }

        public abstract void Reset();
    }
}
