using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedFarmPatches {
        public static void InitPatches(Dictionary<string, FarmingPatch> playerPatchData) {
            List<FarmingPatch> toAdd = new();

            // Tutorial Island
            toAdd.Add(new FarmingPatch("TI_allotment1", "Allotment"));
            toAdd.Add(new FarmingPatch("TI_allotment2", "Allotment"));
            toAdd.Add(new FarmingPatch("TI_allotment3", "Allotment"));

            // Misthalin
            toAdd.Add(new FarmingPatch("MIST_LumbTree", "Tree"));


            for (int i = 0; i < toAdd.Count; i++) {
                playerPatchData.TryAdd(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
