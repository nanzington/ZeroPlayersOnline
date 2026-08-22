using ZeroPlayersOnline.DataTypes;

namespace ZeroPlayersOnline.Hardcodes {
    public static class HardcodedFarmPatches {
        public static void InitPatches(Dictionary<string, FarmingPatch> playerPatchData) {
            List<FarmingPatch> toAdd = new();

            toAdd.Add(new FarmingPatch("TI_allotment1", "Allotment"));
            toAdd.Add(new FarmingPatch("TI_allotment2", "Allotment"));
            toAdd.Add(new FarmingPatch("TI_allotment3", "Allotment"));


            for (int i = 0; i < toAdd.Count; i++) {
                playerPatchData.Add(toAdd[i].ID, toAdd[i]);
            }
        }
    }
}
