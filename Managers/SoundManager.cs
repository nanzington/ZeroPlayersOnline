using ZeroPlayersOnline.UI;
using IrrKlang;

namespace ZeroPlayersOnline.Managers {
    public class SoundManager {
        // This uses IrrKlang - there are probably other sound solutions that work just as well, but this is the one I got working.
        // Download it here: https://www.ambiera.com/irrklang/downloads.html , Go into the zip/bin/dotnet-4 , move irrKlang.NET4.dll into your project directory
        // In VisualStudio set it to always copy when compiling, right click Dependencies and click Add Project Reference. Browse to the dll (in your project folder),
        // then add click okay. It should work using the rest of this code now.
        
        public ISoundEngine engine = new();
        public ISoundEngine Music = new();

        public Dictionary<string, ISound> PlayingSounds = new();
        public string CurrentSong = "None";
        public bool MusicEnabled = true; 
        
        public SoundManager() {
            engine.SoundVolume = 0.15f;
            Music.SoundVolume = 0.05f; 
        }


        public void PlaySound(string name) {
            if (File.Exists("./sounds/" + name + ".ogg")) {
                var test = engine.Play2D("./sounds/" + name + ".ogg");
                if (!PlayingSounds.ContainsKey(name))
                    PlayingSounds.Add(name, test);
            }
        }

        public void StopSound(string name) {
            if (PlayingSounds.ContainsKey(name)) {
                PlayingSounds[name].Stop();
                PlayingSounds.Remove(name);
            }
        }

        public void UpdateSounds() {
            foreach (KeyValuePair<string, ISound> kv in PlayingSounds) {
                if (kv.Value.Finished)
                    PlayingSounds.Remove(kv.Key);
            }
        }


        public void PickMusic(string selection = "") {
            string NewSong = CurrentSong;
            if (MusicEnabled) {
                // come up with some stuff to pick a song
            }
            else {
                Music.StopAllSounds();
                CurrentSong = "None";
            }
        }
    }
}
