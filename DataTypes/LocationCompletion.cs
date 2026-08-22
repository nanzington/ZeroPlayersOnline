namespace ZeroPlayersOnline.DataTypes {
    public class LocationCompletion {
        public bool Completed = false;
        public List<string> RequiredFeats = new();



        public void CheckCompletion(Player p) {
            if (Completed)
                return;

            if (RequiredFeats.Count == 0) {
                Completed = true;
                return;
            }

            for (int i = 0; i < RequiredFeats.Count; i++) {
                if (!p.CompletedFeats.Contains(RequiredFeats[i])) {
                    return;
                }
            }

            Completed = true;
            p.LocationPoints++;
        }
    }
}
