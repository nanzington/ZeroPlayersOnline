using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroPlayersOnline.DataTypes {
    public class MTA_Map {
        public string Map = "";
        public int Width = 0;
        public int StartIdx = 0;
        public int GoalIdx = 0;

        public MTA_Map(int width, int start, int goal, string map) {
            Map = map;
            Width = width;
            StartIdx = start;
            GoalIdx = goal;
        }

        public string TileAt(int x, int y) {
            return TileAt(x + (y * Width));
        }

        public string TileAt(int index) {
            if (index >= 0 & index < Map.Length)
                return Map[index].ToString();
            return "x";
        }
    }
}
