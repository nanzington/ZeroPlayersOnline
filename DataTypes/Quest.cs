using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroPlayersOnline.DataTypes {
    public class Quest {
        public string ID = "";
        public string Name = "";
        public string Length = "";
        public string Difficulty = "";
        public string Description = "";
        public List<string> RegionsNeeded = new();

        public int QuestPoints = 0;

        public int DateFullyImplemented = 0; // YYYYMMDD, ex 20260828 for August 28, 2026

        public int CurrentStage = -1;
        public int CompleteStage = 0;

        public List<Requirement> RequirementsToStart = new();

        public Dictionary<int, QuestStage> Stages = new();
        public List<QuestReward> Rewards = new();


        public Quest(string id, string name, string length, string diff, string desc, int complete, List<string> regions) {
            ID = id;
            Name = name;
            Length = length;
            Difficulty = diff;
            Description = desc;

            CompleteStage = complete;
            RegionsNeeded = regions;
        }


        public bool CanStartQuest(Player p) {
            bool allPassed = true;
            for (int i = 0; i < RequirementsToStart.Count; i++) {
                if (!RequirementsToStart[i].CheckRequirement(p)) {
                    allPassed = false;
                }
            }

            return allPassed;
        }


        public void CheckProgress(Player p, string type, string misc, int num) {
            if (CurrentStage == CompleteStage)
                return;

            if (Stages.TryGetValue(CurrentStage, out QuestStage? stage)) {
                if (stage != null) {
                    if (stage.ProgressType == type && stage.MiscString == misc && stage.MiscInt <= num) {
                        CurrentStage = stage.LeadsToStage;
                    }
                }
            }
        }


        public void ProcessRewards(Player p) {
            foreach (var kv in Rewards) {
                if (kv.RewardType == "Experience") {
                    p.TryGrantExp(kv.MiscString, kv.MiscInt, GameLoop.ZPO.Log, GameLoop.ZPO.RecentlyTrainedSkills);
                }

                if (kv.RewardType == "Item") {
                    if (GameLoop.ZPO.ResolveItem(kv.MiscString) is Item reward) {
                        Item pickup = Helper.Clone(reward);
                        pickup.Quantity = kv.MiscInt;
                    }
                }
            }
        }
    }
}
