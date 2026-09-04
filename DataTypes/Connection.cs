using ZeroPlayersOnline.Managers;

namespace ZeroPlayersOnline.DataTypes {
    public class Connection { 
        public string Destination = "";
        public string CheckFailDest = "";
        public string AltName = "";

        public List<Requirement>? Requirements = new();
        public bool OnlyNeedOneReq = false;

        public int ExpGranted = 0;
        public string ExpTo = "";

        public bool SkillCheck = false;
        public int Level = 1;

        public Connection(string dest, List<Requirement>? req = null, bool onlyOne = false, int exp = 0, string skill = "", string alt = "", bool check = false, int lv = 1, string checkFailDest = "") { 
            Destination = dest;

            if (req != null)
                Requirements = req;

            OnlyNeedOneReq = onlyOne;

            ExpGranted = exp;
            ExpTo = skill;

            AltName = alt;

            SkillCheck = check;
            Level = lv;
            CheckFailDest = checkFailDest;
        }


        public bool CanTraverse(Player p) {
            bool allPassed = true;
            bool anyPassed = false;

            if (Requirements != null) {
                for (int i = 0; i < Requirements.Count; i++) {
                    if (!Requirements[i].CheckRequirement(p)) {
                        allPassed = false;
                    } else {
                        anyPassed = true;
                    }
                }
            }

            if (OnlyNeedOneReq && anyPassed)
                return true;
            return allPassed;
        }

        public void Traverse(Player p) {
            if (Requirements != null) {
                for (int i = 0; i < Requirements.Count; i++) {
                    bool passed = false;

                    if (Requirements[i].CheckRequirement(p)) {
                        if (Requirements[i].RequirementType == "Item" && Requirements[i].ConsumeItem) {
                            p.ConsumeItems([Requirements[i].MiscString + "," + Requirements[i].MiscInt], false, true);
                        }

                        passed = true;
                    }

                    if (passed && OnlyNeedOneReq) {
                        break;
                    }
                }
            }

            if (SkillCheck && ExpTo != "") {
                int toBeat = 50 + (p.GetEffectiveSkillLevel(ExpTo) - Level);

                if (GameLoop.rand.Next(100) > toBeat) {
                    if (CheckFailDest != "") {
                        GameLoop.ZPO.Log.AddMessage("You fail the " + ExpTo + " check and end up somewhere else.", Color.Crimson);
                        p.NavLoc = CheckFailDest;
                    } else {
                        GameLoop.ZPO.Log.AddMessage("You fail the " + ExpTo + " check and gain no experience.", Color.Crimson);
                    }

                    return;
                }
            }


            if (ExpTo != "")
                p.TryGrantExp(ExpTo, ExpGranted, GameLoop.ZPO.Log, SidebarManager.RecentlyTrainedSkills, false); 
            p.NavLoc = Destination;
        }
    }
}
