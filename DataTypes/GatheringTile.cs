using Newtonsoft.Json;
using SadConsole;
using SadRogue.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroPlayersOnline.Managers;

namespace ZeroPlayersOnline.DataTypes {
    public class GatheringTile {
        public string Name = "";
        public string ID = "";

        public string Skill = "";
        public int Level = 1;
        public int ExpGranted = 0;
        public int ExpOnFail = 0;

        public string InteractVerb = "";
        public int SuccessChance = 100;
        public int DepleteChance = 100;

        public int RestockTime = 1;

        public int DepletedGlyph;

        public int DamageOnFail = 0;

        public bool LevelBasedSuccess = false;


        public List<WeightedItem> PossibleItems = new();


        [JsonIgnore]
        public double LastGathered = 0;


        public string PickItem() {
            if (PossibleItems != null && PossibleItems.Count > 0)
                return Helper.ChooseWeighted<WeightedItem>(PossibleItems).Item;
            return "";
        }

        public void Gather(Player p, MessageLog log, Dictionary<string, Item> itemLibrary, Location currentLoc, List<Skill> Recents) {
            if (CanGather(p)) {
                ClueLogic.GenericStep(p, log, "Gather", ID);

                int success = GameLoop.rand.Next(100) + 1;

                if (LevelBasedSuccess && p.Skills.ContainsKey(Skill))
                    success += (p.GetEffectiveSkillLevel(Skill) - Level);

                if (success <= SuccessChance) {
                    string output = PickItem(); 
                    if (itemLibrary.ContainsKey(output)) {
                        Item receive = Helper.Clone(itemLibrary[output]);
                        if (p.TryPickup(receive)) {
                            log.AddMessage(new ColoredString("You get " + receive.Name.ToLower() + " from the " + Name + ".", Color.Green, Color.Black));
                        } else {
                            log.AddMessage(new ColoredString("Your inventory is full so the " + receive.Name.ToLower() + " falls to the ground.", Color.Goldenrod, Color.Black));
                            currentLoc.ItemsHere.Add(receive);
                        }

                        p.TryGrantExp(Skill, ExpGranted, log, Recents);
                    } else {
                        if (output != "") {
                            log.AddMessage(new ColoredString("You " + InteractVerb.ToLower() + " the " + Name.ToLower() + ", but output item doesn't exist.", Color.Firebrick, Color.Black));
                        } else {
                            log.AddMessage(new ColoredString("You " + InteractVerb.ToLower() + " the " + Name.ToLower() + ", but get nothing.", Color.Firebrick, Color.Black));
                        }
                        p.TryGrantExp(Skill, ExpGranted, log, Recents);
                    }

                    int deplete = GameLoop.rand.Next(100) + 1;

                    if (deplete <= DepleteChance) {

                        if (p.PrayerActive("Enduring Nature")) {
                            deplete = GameLoop.rand.Next(100) + 1;

                            if (deplete <= DepleteChance) { 
                                LastGathered = Helper.Time();
                            }
                        } else {
                            LastGathered = Helper.Time();
                        }
                    }
                } else {
                    log.AddMessage(new ColoredString("You failed to " + InteractVerb.ToLower() + " the " + Name.ToLower() + ".", Color.Red, Color.Black));

                    if (ExpOnFail > 0) {
                        p.TryGrantExp(Skill, ExpOnFail, log, Recents);
                    }
                }
            }
        } 

        public bool CanGather(Player p) { 
            if (p.Skills.ContainsKey(Skill) && p.Skills[Skill].Level < Level)
                return false;
            if (LastGathered + (RestockTime * 1000) > Helper.Time() && LastGathered != 0)
                return false;
            if (!p.Skills.ContainsKey(Skill) && Level > 0)
                return false;
            return true;
        }
    }
}
