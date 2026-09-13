using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroPlayersOnline.DataTypes {
    public class QuestStatus {
        public string QuestID = "";
        public int CurrentStage = -1;
          
        public QuestStatus(string id, int stage) {
            QuestID = id;
            CurrentStage = stage;
        }
    }
}
