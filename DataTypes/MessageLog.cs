using SadConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroPlayersOnline.DataTypes {
    public class MessageLog { 
        public List<LogEntry> Log = new();
        public int TopIndex = 0;

        public void AddMessage(string msg) {
            AddMessage(new ColoredString(msg));
        }

        public void AddMessage(string msg, Color col) {
            AddMessage(new ColoredString(msg, col, Color.Black));
        }

        public void AddMessage(ColoredString msg) {
            if (Log.Count > 0) {
                if (Log[^1].Message.String == msg.String) {
                    Log[^1].Count++;
                }
                else {
                    Log.Add(new(msg));
                }
            }
            else {
                Log.Add(new(msg));
            }

            TopIndex = Math.Clamp(Log.Count - 12, 0, Log.Count);
        }
    }
}
