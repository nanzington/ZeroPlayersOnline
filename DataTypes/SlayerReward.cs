using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroPlayersOnline.DataTypes {
    public class SlayerReward {
        public string Name = "";
        public string Description = "";
        public int SlayerPointCost = 0;

        public List<RunAction> Actions = new();
        public List<Requirement> Reqs = new();

        public SlayerReward(string name, int cost, string desc = "", List<Requirement> reqs = null, List<RunAction> acts = null) {
            Name = name;
            SlayerPointCost = cost;
            Description = desc;

            if (reqs != null)
                Reqs = reqs;
            if (acts != null)
                Actions = acts;
        }

        public bool AllReqsMet() {
            foreach (var req in Reqs) {
                if (!req.CheckRequirement(GameLoop.ZPO.player, false, true)) {
                    return false;
                }
            }

            return true;
        }
    }
}
