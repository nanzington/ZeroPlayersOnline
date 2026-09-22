using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroPlayersOnline.DataTypes {
    public class HotColdResult {
        public string MapID = "";
        public int Depth = -1;

        public HotColdResult(string id, int depth) {
            MapID = id;
            Depth = depth;
        }
    }
}
