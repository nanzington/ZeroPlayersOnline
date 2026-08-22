using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.HardcodedData {
    public static class HardcodedPrayers {
        public static void InitPrayers(Dictionary<string, Prayer> PrayerLib) {
            List<Prayer> toAdd = new();

            toAdd.Add(new Prayer("Defense I", "Normal", 1, "Boosts Defense by 1 level.", "Defense"));
            toAdd.Add(new Prayer("Strength I", "Normal", 1, "Boosts Strength by 1 level.", "Strength"));
            toAdd.Add(new Prayer("Attack I", "Normal", 1, "Boosts Attack by 1 level.", "Attack"));
            toAdd.Add(new Prayer("Ranged I", "Normal", 1, "Boosts Ranged by 1 level.", "Ranged"));
            toAdd.Add(new Prayer("Magic I", "Normal", 1, "Boosts Magic by 1 level.", "Magic")); 

            toAdd.Add(new Prayer("Defense II", "Normal", 10, "Boosts Defense by 5 levels.", "Defense"));
            toAdd.Add(new Prayer("Strength II", "Normal", 10, "Boosts Strength by 5 levels.", "Strength"));
            toAdd.Add(new Prayer("Attack II", "Normal", 10, "Boosts Attack by 5 levels.", "Attack"));
            toAdd.Add(new Prayer("Ranged II", "Normal", 10, "Boosts Ranged by 5 levels.", "Ranged"));
            toAdd.Add(new Prayer("Magic II", "Normal", 10, "Boosts Magic by 5 levels.", "Magic"));

            toAdd.Add(new Prayer("Defense III", "Normal", 20, "Boosts Defense by 10 levels.", "Defense"));
            toAdd.Add(new Prayer("Strength III", "Normal", 20, "Boosts Strength by 10 levels.", "Strength"));
            toAdd.Add(new Prayer("Attack III", "Normal", 20, "Boosts Attack by 10 levels.", "Attack"));
            toAdd.Add(new Prayer("Ranged III", "Normal", 20, "Boosts Ranged by 10 levels.", "Ranged"));
            toAdd.Add(new Prayer("Magic III", "Normal", 20, "Boosts Magic by 10 levels.", "Magic"));

            toAdd.Add(new Prayer("Defense IV", "Normal", 40, "Boosts Defense by 20 levels.", "Defense"));
            toAdd.Add(new Prayer("Strength IV", "Normal", 40, "Boosts Strength by 20 levels.", "Strength"));
            toAdd.Add(new Prayer("Attack IV", "Normal", 40, "Boosts Attack by 20 levels.", "Attack"));
            toAdd.Add(new Prayer("Ranged IV", "Normal", 40, "Boosts Ranged by 20 levels.", "Ranged"));
            toAdd.Add(new Prayer("Magic IV", "Normal", 40, "Boosts Magic by 20 levels.", "Magic"));
             
            toAdd.Add(new Prayer("Good Fortune", "Normal", 40, "A second chance at drops.")); // If a drop roll is failed, roll it again
            toAdd.Add(new Prayer("Enduring Nature", "Normal", 40, "Gathering spots last longer.")); // If a gathering spot fails the chance to avoid depletion, roll again
            toAdd.Add(new Prayer("Cornucopia", "Normal", 40, "20% to not consume consumables.")); // 20% chance for a consumable to not be consumed on use (includes potion sips)

            toAdd.Add(new Prayer("Protect from Magic", "Normal", 50, "Cuts magic damage by half."));
            toAdd.Add(new Prayer("Protect from Melee", "Normal", 50, "Cuts melee damage by half."));
            toAdd.Add(new Prayer("Protect from Range", "Normal", 50, "Cuts range damage by half."));


            for (int i = 0; i < toAdd.Count; i++) {
                PrayerLib.Add(toAdd[i].Name, toAdd[i]);
            }
        }
    }
}
