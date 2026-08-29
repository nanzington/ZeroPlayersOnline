using ZeroPlayersOnline.DataTypes;
using Newtonsoft.Json;
using SadConsole;
using SadConsole.Input;
using SadRogue.Primitives;
using System.ComponentModel;
using System.Globalization;
using System.IO.Compression;
using System.Text; 
using System.Text.RegularExpressions;
using Rectangle = SadRogue.Primitives.Rectangle;
using GoRogue;

namespace ZeroPlayersOnline {
    public static class Helper {
        public static bool ProcessedClick = false;
        public static double CursorTicked = 0;
        public static bool CursorVisible = true; 

        public static double Time() {
            return Game.Instance.GameRunningTotalTime.TotalMilliseconds;
        }

        public static ColoredString Checkmark(bool condition) {
            ColoredString check = new ColoredString(256.AsString(), Color.Lime, Color.Black);

            if (!condition)
                check = new ColoredString(257.AsString(), Color.Red, Color.Black);

            return check;
        }

        public static bool IsEven(int num) {
            bool even = true; 

            for (int i = 0; i < Math.Abs(num); i++) {
                even = !even;
            }

            return even;
        }


        public static string Truncate(string input, int len) {
            if (input.Length < len)
                return input;
            return input[0..(len - 1)];
        }

        public static bool EitherShift() {
            if (GameHost.Instance.Keyboard.IsKeyDown(Keys.LeftShift) || GameHost.Instance.Keyboard.IsKeyDown(Keys.RightShift))
                return true;
            return false;
        }
         
        public static bool EitherControl() {
            if (GameHost.Instance.Keyboard.IsKeyDown(Keys.LeftControl) || GameHost.Instance.Keyboard.IsKeyDown(Keys.RightControl))
                return true;
            return false;
        }


        public static bool KeyPressed(Keys key) {
            return GameHost.Instance.Keyboard.IsKeyPressed(key);
        }

        public static bool KeyDown(Keys key) {
            return GameHost.Instance.Keyboard.IsKeyDown(key);
        }

        static HashSet<Keys> TriggeredHotkeys = new();
        static HashSet<Keys> SecondaryList = new();
        public static bool HotkeyDown(Keys key) {
            if (!TriggeredHotkeys.Contains(key) && GameHost.Instance.Keyboard.IsKeyPressed(key)) {
                TriggeredHotkeys.Add(key);
                return true;
            }

            return false;
        }

        public static void ClearKeys() {
            SecondaryList.Clear();
            foreach (Keys key in TriggeredHotkeys) {
                if (GameHost.Instance.Keyboard.IsKeyDown(key)) {
                    SecondaryList.Add(key);
                }
            }
            TriggeredHotkeys.Clear();

            foreach (Keys key in SecondaryList) {
                TriggeredHotkeys.Add(key);
            }
        } 

        public static bool ScrolledUp() {
            if (GameHost.Instance.Mouse.ScrollWheelValueChange < 0) {
                return true;
            }
            return false;
        }

        public static bool ScrolledDown() {
            if (GameHost.Instance.Mouse.ScrollWheelValueChange > 0) {
                return true;
            }
            return false;
        }

         
        public static T Clone<T>(this T source) {
            if (Object.ReferenceEquals(source, null)) {
                return default(T);
            } 

            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };
            var serializeSettings = new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore };

            T output = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source, serializeSettings), deserializeSettings);
              
            return output;
        }

        public static void PrintCombinedLetters(this Console con, int X, int Y, string text, Color col) {
            int firstChar = 1;
            int secondChar = 1;

            if (text[0] >= 'A' && text[0] <= 'Z') {
                firstChar = 1024 + (text[0] - 'A');
            } else if (text[0] >= 'a' && text[0] <= 'z') {
                firstChar = 1088 + (text[0] - 'a');
            }

            if (text[1] >= 'A' && text[1] <= 'Z') {
                secondChar = 1056 + (text[1] - 'A');
            }
            else if (text[1] >= 'a' && text[1] <= 'z') {
                secondChar = 1120 + (text[1] - 'a');
            }

            con.Print(X, Y, firstChar.AsString(), col);
            con.SetDecorator(X, Y, 1, new CellDecorator(col, secondChar, Mirror.None));
        }

        public static void DrawBox(Console con, int LeftX, int TopY, int w, int h, int r = 255, int g = 255, int b = 255, int mode = 0, bool clearInside = false) {
            int LeftXin = LeftX + 1;
            int TopYin = TopY + 1;
            int RightXin = LeftX + w;
            int BottomYin = TopY + h;
            int BottomY = TopY + h + 1;
            int RightX = LeftX + w + 1;
             
            Color fg = new Color(r, g, b);

            if (mode == 0) {
                con.DrawLine(new Point(LeftXin, TopY), new Point(RightXin, TopY), 320, fg, Color.Black);
                con.DrawLine(new Point(LeftXin, BottomY), new Point(RightXin, BottomY), 320, fg, Color.Black);
                con.DrawLine(new Point(LeftX, TopYin), new Point(LeftX, BottomYin), 321, fg, Color.Black);
                con.DrawLine(new Point(RightX, TopYin), new Point(RightX, BottomYin), 321, fg, Color.Black);
                con.Print(LeftX, BottomY, 322.AsString(), fg, Color.Black);
                con.Print(RightX, BottomY, 323.AsString(), fg, Color.Black);
                con.Print(LeftX, TopY, 324.AsString(), fg, Color.Black); 
                con.Print(RightX, TopY, 325.AsString(), fg, Color.Black);
            } else if (mode == 1) {
                con.DrawLine(new Point(LeftXin, TopY), new Point(RightXin, TopY), 190, fg);
                con.DrawLine(new Point(LeftXin, BottomY), new Point(RightXin, BottomY), 190, fg);
                con.DrawLine(new Point(LeftX, TopYin), new Point(LeftX, BottomYin), 191, fg);
                con.DrawLine(new Point(RightX, TopYin), new Point(RightX, BottomYin), 191, fg);
                con.Print(LeftX, TopY, 188.AsString(), fg);
                con.Print(RightX, BottomY, 187.AsString(), fg);
                con.Print(LeftX, BottomY, 186.AsString(), fg);
                con.Print(RightX, TopY, 189.AsString(), fg);
            }

            if (clearInside) { 
                for (int y = TopY + 1; y <= TopY + h; y++) {
                    int width = Math.Clamp(w, 0, con.Width - LeftX - 1);

                    con.Print(LeftX + 1, y, new ColoredString("".PadLeft(width, ' '), Color.White, Color.Black));
                }
            }
        }


        public static string Italicize(this string instance) {
            string newStr = "";

            for (int i = 0; i < instance.Length; i++) {
                if ((instance[i] >= 'A' && instance[i] <= 'Z') || (instance[i] >= 'a' && instance[i] <= 'z') || (instance[i] >= '0' && instance[i] <= '9')) {
                    newStr += (instance[i] + 799).AsString();
                } else {
                    newStr += instance[i];
                }
            }

            return newStr;
        }

        public static void Shuffle<T>(this Stack<T> stack) {
            var values = stack.ToArray();
            stack.Clear();
            foreach (var value in values.OrderBy(x => GameLoop.rand.Next()))
                stack.Push(value);
        } 

        /* This might be useful for a minigame later so not deleting it yet
        public static List<PlayingCard> GenerateDeck(bool hiddenByDefault = false) {
            List<PlayingCard> Deck = new();
            for (int i = 0; i < 13; i++) {
                for (int s = 0; s < 4; s++) {
                    string num = i == 0 ? "A" : i == 10 ? "J" : i == 11 ? "Q" : i == 12 ? "K" : (i + 1).ToString();
                    string suit = s == 0 ? "H" : s == 1 ? "D" : s == 2 ? "C" : "S";
                    PlayingCard newCard = new(num, suit);
                    newCard.RevealedToAll = !hiddenByDefault;

                    Deck.Add(newCard);
                }
            }

            Deck.Shuffle();

            return Deck;
        }*/

        public static T Pop<T>(this List<T> instance) {
            T popped = instance[0];
            instance.RemoveAt(0);
            return popped;
        }


        public static ColoredString ToColoredString(this List<Color> instance, string text) {
            ColoredString build = new();

            for (int i = 0; i < instance.Count && i < text.Length; i++) {
                build += new ColoredString(text.Substring(i, 1), instance[i], Color.Black);
            }

            return build;
        }

        public static string AsString(this int instance) {
            return new string((char)instance, 1);
        }

        public static void Shuffle<T>(this IList<T> list) {
            int n = list.Count;
            while (n > 1) {
                n--;
                int k = GameLoop.rand.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }


        public static ColoredString GetDarker(this ColoredString instance) {

            for (int i = 0; i < instance.Length; i++) {
                instance[i].Foreground = instance[i].Foreground.GetDarker();
            }

            return instance;
        }

        public static ColoredString GetGrayscale(this ColoredString instance) {
            for (int i = 0; i < instance.Length; i++) {
                int colF = (int) Math.Floor((instance[i].Foreground.R + instance[i].Foreground.G + instance[i].Foreground.B) / 3f);
                int colB= (int)Math.Floor((instance[i].Background.R + instance[i].Background.G + instance[i].Background.B) / 3f);
                instance[i].Foreground = new Color(colF, colF, colF);
                instance[i].Background = new Color(colB, colB, colB);
            }

            return instance;
        }

        public static ColoredString GetAlternating(this string instance, Color first, Color second) {
            ColoredString output = new();
            for (int i = 0; i < instance.Length; i++) {
                if (i % 2 == 0)
                    output += new ColoredString(instance[i].ToString(), first, Color.Black);
                else
                    output += new ColoredString(instance[i].ToString(), second, Color.Black);
            }

            return output;
        }

        public static CellDecorator AsDecorator(this ColoredString instance) {
            return new CellDecorator(instance[0].Foreground, (int)instance.String[0], Mirror.None);
        }

        public static void Flip(this ref bool instance) {
            instance = !instance;
        }

        public static void PrintScrollableInteger(this Console instance, int x, int y, string prefaceText, ref int number, bool asString = false, int min = int.MinValue, int max = int.MaxValue, int baseStep = 1, int shiftStep = 5, int controlStep = 10, bool onlyPreface = false, int r = 255, int g = 255, int b = 255) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;
            string numString = number.ToString();

            if (asString)
                numString = number.AsString();


            Rectangle clickableArea = new Rectangle(new Point(x, y), new Point(x + numString.Length + prefaceText.Length - 1, y));

            if (onlyPreface)
                clickableArea = new Rectangle(new Point(x, y), new Point(x + prefaceText.Length - 1, y));

            int mod = baseStep;
            if (EitherShift())
                mod *= shiftStep;
            if (EitherControl())
                mod *= controlStep;


            if (clickableArea.Contains(mousePos)) {
                if (GameHost.Instance.Mouse.ScrollWheelValueChange > 0 || GameHost.Instance.Mouse.RightClicked) {
                    number = Math.Clamp(number - mod, min, max);
                }
                else if (GameHost.Instance.Mouse.ScrollWheelValueChange < 0 || GameHost.Instance.Mouse.LeftClicked) {
                    number = Math.Clamp(number + mod, min, max);
                }
            }


            instance.Print(x, y, prefaceText);

            if (!onlyPreface)
                instance.Print(x + prefaceText.Length, y, numString, new Color(r, g, b));
        }

        public static void PrintStringField(this Console instance, int x, int y, string prefaceText, ref string field, ref string selected, string plainName, bool onlyPreface = false, bool censored = false) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;
            if (field == null)
                field = "";

            if (field != null) {
                Rectangle clickableArea = new Rectangle(new Point(x, y), new Point(x + field.Length + prefaceText.Length - 1, y));

                if (onlyPreface)
                    clickableArea = new Rectangle(new Point(x, y), new Point(x + prefaceText.Length - 1, y));

                int end = x + field.Length;
                if (field.Length == 0) {
                    clickableArea = new Rectangle(new Point(x, y), new Point(x + prefaceText.Length + "(blank)".Length - 1, y));
                    end = x + "(blank)".Length;
                    instance.Print(x, y, prefaceText, selected == plainName ? Color.Green : clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);

                    if (!onlyPreface)
                        instance.Print(x + prefaceText.Length, y, "(blank)", clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);
                }
                else {
                    instance.Print(x, y, prefaceText, selected == plainName ? Color.Green : clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);

                    if (!onlyPreface) {
                        if (censored) {
                            instance.Print(x + prefaceText.Length, y, new ColoredString("*").Repeat(field.Length).String, clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);
                        }
                        else {
                            instance.Print(x + prefaceText.Length, y, field, clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);
                        }
                    }
                }

                if (GameHost.Instance.Mouse.LeftClicked) {
                    if (clickableArea.Contains(mousePos))
                        selected = plainName;
                }

                if (selected == plainName) {
                    if (CursorTicked + 200 < Time()) {
                        CursorTicked = Time();
                        CursorVisible = !CursorVisible;
                    }

                    if (!onlyPreface)
                        instance.Print(end + prefaceText.Length, y, Helper.CursorVisible ? "_" : " ");

                    foreach (var key in GameHost.Instance.Keyboard.KeysPressed) {
                        if ((key.Character >= 'A' && key.Character <= 'z') || (key.Character >= '0' && key.Character <= '9'
                            || key.Character == ';' || key.Character == ':' || key.Character == '|' || key.Character == '-' || key.Character == '+'
                            || key.Character == '.' || key.Character == ',' || key.Character == '(' || key.Character == ')' || key.Character == '\''
                            || key.Character == '!' || key.Character == '?')) {
                            field += key.Character;
                        }

                        if (key.Character == '$') {
                            field += (char)15;
                        }
                    }

                    if (GameHost.Instance.Keyboard.IsKeyPressed(Keys.Space)) {
                        field += " ";
                    }

                    if (GameHost.Instance.Keyboard.IsKeyPressed(Keys.Back)) {
                        if (field.Length > 0)
                            field = field[0..^1];
                    }

                    if (GameHost.Instance.Keyboard.IsKeyPressed(Keys.Enter)) {
                        selected = "none";
                    }
                }
            }
        }

        public static void PrintScrollingStringField(this Console instance, int x, int y, int width, string prefaceText, ref string fielda, ref string selected, string plainName, bool onlyPreface = false) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;
            if (fielda == null)
                fielda = "";

            if (fielda != null) {
                string field = Helper.Clone(fielda);
                if (field.Length > width) {
                    field = field.Substring(Math.Clamp(field.Length - width - 1, 0, field.Length));
                }


                Rectangle clickableArea = new Rectangle(new Point(x, y), new Point(x + field.Length + prefaceText.Length - 1, y));

                if (onlyPreface)
                    clickableArea = new Rectangle(new Point(x, y), new Point(x + prefaceText.Length - 1, y));

                int end = x + field.Length;
                if (field.Length == 0) {
                    clickableArea = new Rectangle(new Point(x, y), new Point(x + prefaceText.Length + "(blank)".Length - 1, y));
                    end = x + "(blank)".Length;
                    instance.Print(x, y, prefaceText, selected == plainName ? Color.Green : clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);

                    if (!onlyPreface)
                        instance.Print(x + prefaceText.Length, y, "(blank)", clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);
                }
                else {
                    instance.Print(x, y, prefaceText, selected == plainName ? Color.Green : clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);

                    if (!onlyPreface)
                        instance.Print(x + prefaceText.Length, y, field, clickableArea.Contains(mousePos) ? Color.Yellow : Color.White);
                }

                if (GameHost.Instance.Mouse.LeftClicked) {
                    if (clickableArea.Contains(mousePos))
                        selected = plainName;
                }

                if (selected == plainName) {
                    if (CursorTicked + 200 < Time()) {
                        CursorTicked = Time();
                        CursorVisible = !CursorVisible;
                    }

                    if (!onlyPreface)
                        instance.Print(end + prefaceText.Length, y, Helper.CursorVisible ? "_" : " ");

                    foreach (var key in GameHost.Instance.Keyboard.KeysPressed) {
                        if ((key.Character >= 'A' && key.Character <= 'z') || (key.Character >= '0' && key.Character <= '9'
                            || key.Character == ';' || key.Character == ':' || key.Character == '|' || key.Character == '-' || key.Character == '+'
                            || key.Character == '.' || key.Character == ',' || key.Character == '(' || key.Character == ')' || key.Character == '\''
                            || key.Character == '!' || key.Character == '?')) {
                            fielda += key.Character;
                        }

                        if (key.Character == '$') {
                            fielda += (char)15;
                        }
                    }

                    if (GameHost.Instance.Keyboard.IsKeyPressed(Keys.Space)) {
                        fielda += " ";
                    }

                    if (GameHost.Instance.Keyboard.IsKeyPressed(Keys.Back)) {
                        if (field.Length > 0)
                            fielda = fielda[0..^1];
                    }

                    if (GameHost.Instance.Keyboard.IsKeyPressed(Keys.Enter)) {
                        selected = "none";
                    }
                }
            }
        }

        public static void PrintAdjustableInt(this Console instance, int x, int y, int width, ref int target, int min, int max) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;
            Point minusPos = new Point(x, y);
            Point plusPos = new Point(x + 3 + width, y);

            if (width > 0) {
                instance.Print(x, y, "-", mousePos == minusPos ? Color.Yellow : Color.White);
                instance.Print(x + 2, y, target.ToString().PadLeft(width));
                instance.Print(x + 3 + width, y, "+", mousePos == plusPos ? Color.Yellow : Color.White);
            }
            else {
                plusPos = new Point(x + 3 + target.ToString().Length, y);
                instance.Print(x, y, "-", mousePos == minusPos ? Color.Yellow : Color.White);
                instance.Print(x + 2, y, target.ToString());
                instance.Print(x + 3 + target.ToString().Length, y, "+", mousePos == plusPos ? Color.Yellow : Color.White);
            }

            int mod = 1;

            if (EitherShift())
                mod *= 5;

            if (EitherControl())
                mod *= 10;

            if (GameHost.Instance.Mouse.LeftClicked && mousePos == minusPos) {
                target = Math.Clamp(target - mod, min, max);
            }

            if (GameHost.Instance.Mouse.LeftClicked && mousePos == plusPos) {
                target = Math.Clamp(target + mod, min, max);
            }
        }

        public static void PrintAdjustableDouble(this Console instance, int x, int y, int width, ref double target, double min, double max) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;
            Point minusPos = new Point(x, y);
            Point plusPos = new Point(x + 3 + width, y);

            if (width > 0) {
                instance.Print(x, y, "-", mousePos == minusPos ? Color.Yellow : Color.White);
                instance.Print(x + 2, y, target.ToString().PadLeft(width));
                instance.Print(x + 3 + width, y, "+", mousePos == plusPos ? Color.Yellow : Color.White);
            }
            else {
                plusPos = new Point(x + 3 + target.ToString().Length, y);
                instance.Print(x, y, "-", mousePos == minusPos ? Color.Yellow : Color.White);
                instance.Print(x + 2, y, target.ToString());
                instance.Print(x + 3 + target.ToString().Length, y, "+", mousePos == plusPos ? Color.Yellow : Color.White);
            }

            double mod = 0.01;

            if (EitherShift())
                mod *= 50;

            if (EitherControl())
                mod *= 100;

            if (GameHost.Instance.Mouse.LeftClicked && mousePos == minusPos) {
                target = Math.Round(Math.Clamp(target - mod, min, max), 2);
            }

            if (GameHost.Instance.Mouse.LeftClicked && mousePos == plusPos) {
                target = Math.Round(Math.Clamp(target + mod, min, max), 2);
            }
        }

        public static void PrintVertical(this Console instance, int x, int y, string str, bool down = true) {
            instance.PrintVertical(x, y, new ColoredString(str), down);
        }

        public static void PrintVertical(this Console instance, int x, int y, ColoredString str, bool down = true) {
            for (int i = 0; i < str.Length; i++) {
                int printY = y + (down ? i : -i);
                if (printY >= 0 && printY < instance.Height) {
                    instance.Print(x, printY, str[i].Glyph.AsString(), str[i].Foreground, str[i].Background);
                }
            }
        }

        public static void PrintClickableBool(this SadConsole.Console instance, int x, int y, string input, ref bool toggler) {
            instance.PrintClickableBool(x, y, new ColoredString(input), ref toggler);
        }

        public static void PrintClickableBool(this SadConsole.Console instance, int x, int y, ColoredString input, ref bool toggler) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;

            ColoredString str = input + Helper.Checkmark(toggler);

            if (mousePos.X >= x && mousePos.X < x + str.Length && mousePos.Y == y) {
                instance.Print(x, y, str.GetDarker());
            }
            else {
                instance.Print(x, y, str);
            }

            if (GameHost.Instance.Mouse.LeftClicked) {
                if (mousePos.X >= x && mousePos.X < x + str.Length && mousePos.Y == y) {
                    toggler.Flip();
                }
            }
        }  

        public static void PrintClickable(this SadConsole.Console instance, int x, int y, string str, Action OnClick) {
            instance.PrintClickable(x, y, new ColoredString(str), OnClick);
        }

        public static void PrintClickable(this SadConsole.Console instance, int x, int y, ColoredString str, Action OnClick) {
            MouseScreenObjectState mouse = new MouseScreenObjectState(instance, GameHost.Instance.Mouse);
            Point mousePos = mouse.CellPosition;
            bool mouseOn = mouse.IsOnScreenObject;
            int length = str.Length - 1;

            instance.Print(x, y, mousePos.X >= x && mousePos.X <= x + length && mousePos.Y == y ? str.GetDarker() : str);

            if ((GameLoop.ZPO.Guide.IsVisible && instance != GameLoop.ZPO.Guide) 
                || (GameLoop.ZPO.CollectionLog.IsVisible && instance != GameLoop.ZPO.CollectionLog)
                || (GameLoop.ZPO.CraftingMenu.IsVisible && instance != GameLoop.ZPO.CraftingMenu)
                || (GameLoop.ZPO.Quests.IsVisible && instance != GameLoop.ZPO.Quests)) {
                return;
            }

            if (GameHost.Instance.Mouse.LeftClicked) {
                if (mousePos.X >= x && mousePos.X <= x + length && mousePos.Y == y && mouseOn) {
                    OnClick();
                }
            }
        }

        public static ColoredString Repeat(this ColoredString instance, int repeats) {
            ColoredString output = new ColoredString();

            for (int i = 0; i < repeats; i++) {
                output += instance;
            }

            return output;
        }

        public static Coord ToCoord(this Point instance) {
            return new Coord(instance.X, instance.Y);
        }

        public static Point ToPoint(this Coord instance) {
            return new Point(instance.X, instance.Y);
        }

        public static bool VowelStart(string str) {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(str[0]))
                return true;
            return false;
        }

        static string jsonString;

        public static void SerializeToFile(object value, string path, JsonSerializerSettings settings = null) { 
            using StreamWriter output = new StreamWriter(path); 
            jsonString = JsonConvert.SerializeObject(value, Formatting.Indented);
            output.WriteLine(jsonString);
            output.Close();  
        }

        public static T DeserializeFromFile<T>(string path) {
            using StreamReader read = new StreamReader(path);
            T output = JsonConvert.DeserializeObject<T>(read.ReadToEnd());
            read.Close();
            return output;
        }

        public static void SerializeToFileCompressed(object value, string path) {
            File.WriteAllBytes(path, value.ToByteArray());
        }

        public static T DeserializeFromFileCompressed<T>(string path) { 
            return File.ReadAllBytes(path).FromByteArray<T>();
        } 

        public static byte[] ToByteArray(this object instance, JsonSerializerSettings settings = null) {
            MemoryStream stream = new();
            using (var writer = new StreamWriter(stream)) {
                var serializer = JsonSerializer.CreateDefault(settings);
                serializer.Serialize(writer, instance);
                writer.Close();
                stream.Close();
            }

            return stream.ToArray();
        }

        public static T FromByteArray<T>(this byte[] input, JsonSerializerSettings settings = null) {
            MemoryStream stream = new(input);
            T output;  

            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader)) {
                var serializer = JsonSerializer.CreateDefault(settings);
                
                output = serializer.Deserialize<T>(jsonReader);
                stream.Close();
                reader.Close();
            }

            return output;
        } 

        public static int PrintMultiLine(this Console instance, int x, int y, string str, int width, int colR = 255, int colG = 255, int colB = 255) {
            List<string> words = str.Split(" ").ToList();
            Color col = new Color(colR, colG, colB);

            int cX = x;
            int cY = y;

            foreach (string word in words) {
                if (cX + word.Length + 1 < x + width && word != "/n") {
                    instance.Print(cX, cY, word + " ", col, Color.Black);
                    cX += word.Length + 1;
                }
                else {
                    cX = x;
                    cY++;
                    if (word != "/n") {
                        instance.Print(cX, cY, word + " ", col, Color.Black);
                        cX += word.Length + 1;
                    }
                }
            }

            return cY;
        }

        public static void PrintMultilineClickable(this SadConsole.Console instance, int x, int y, int height, ColoredString str, Action OnClick) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;

            if (mousePos.X >= x && mousePos.X < x + str.Length && mousePos.Y >= y && mousePos.Y < y + height) {
                str.GetDarker();
                for (int i = 0; i < height; i++) {
                    instance.Print(x, y + i, str);
                }
            }
            else {
                for (int i = 0; i < height; i++) {
                    instance.Print(x, y + i, str);
                }
            }

            if (GameHost.Instance.Mouse.LeftClicked) {
                if (mousePos.X >= x && mousePos.X < x + str.Length && mousePos.Y >= y && mousePos.Y < y + height) {
                    OnClick();
                }
            }
        }

        public static void PrintMultilineClickable(this SadConsole.Console instance, int x, int y, int height, ColoredString str, Action<string> OnClick, string ID) {
            Point mousePos = new MouseScreenObjectState(instance, GameHost.Instance.Mouse).CellPosition;

            if (mousePos.X >= x && mousePos.X < x + str.Length && mousePos.Y >= y && mousePos.Y < y + height) {
                str.GetDarker();
                for (int i = 0; i < height; i++) { 
                    instance.Print(x, y + i, str);
                } 
            }
            else {
                for (int i = 0; i < height; i++) {
                    instance.Print(x, y + i, str);
                }
            }

            if (GameHost.Instance.Mouse.LeftClicked) {
                if (mousePos.X >= x && mousePos.X < x + str.Length && mousePos.Y >= y && mousePos.Y < y + height) {
                    OnClick(ID);
                }
            }
        }

        public static List<Color> GradientList(int stepsOneWay, Color first, Color second) {
            float perStep = 1f / ((float)stepsOneWay); 

            List<Color> steps = new();
            for (int i = 0; i < stepsOneWay; i++) {
                steps.Add(Color.Lerp(first, second, (float)i * perStep));
            }

            for (int i = stepsOneWay; i > 0; i--) {
                steps.Add(Color.Lerp(first, second, (float)i * perStep));
            } 

            return steps;
        } 
         

        public static T ChooseWeighted<T>(List<T> list) where T : IWeighted {
            int totalWeight = list.Sum(c => c.Weight);
            int currentCount = 0;
            int targetWeight = GameLoop.rand.Next(0, totalWeight);

            foreach (T item in list) {
                currentCount += item.Weight;

                if (currentCount > targetWeight) {
                    return item;
                }
            }

            return default(T);
        }

        public static ColoredString GoldString(int geltValue, bool shop) {
            if (geltValue > 0 || !shop) {
                ColoredString GeltString = new(geltValue + "gp", Color.Gold, Color.Black);
                return GeltString;
            } else {
                return new ColoredString("FREE", Color.Lime, Color.Black);
            }
        } 
    }

      
    public class PointConverter : TypeConverter {
        static string typeKey;
        static string[] typeParts;

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            //=> sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
            => sourceType == typeof(string);

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
            //var key = Convert.ToString(value)!.Trim('(').Trim(')');
            //var parts = Regex.Split(key, ",");

            typeKey = value.ToString().Trim('(').Trim(')');
            typeParts = typeKey.Split(",");

            return new Point(int.Parse(typeParts[0]), int.Parse(typeParts[1]));
        }
    }  
}
