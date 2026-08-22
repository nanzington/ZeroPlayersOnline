using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public class HardcodedLocations {
        public static void InitLocs(Dictionary<string, Location> Atlas, Dictionary<string, GatheringTile> Gathers, Dictionary<string, AreaMonster> Monsters) {
            List<Location> locsToAdd = new();

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island",
                Description = "You stand on a small island in a bay. There are a few scattered buildings here, designed to help teach some basic activities. There is a bank, a temple, a building that new people appear in, a shack housing a ladder to the cavern below, and the home of a local wizard. There is a pond near the new player building at the center of the island, and the island itself is lightly forested with paths between the buildings.",
                ID = "TI_Main",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Bank"),
                    new Connection("TI_Cavern"),
                    new Connection("TI_GeneralStore"),
                    new Connection("TI_Kitchen"),
                    new Connection("TI_Temple"),
                    new Connection("TI_WizardHut")
                },
                GatheringSpots = new List<string>() { "treePine", "treePine", "treePine", "treePine", "treePine", "treePine", "treePine", "fishNetSmall", "fishNetSmall" },
                NPCsHere = new List<string>() { "man", "man", "man" },
                FarmingPatchesHere = new List<string>() { "TI_allotment1", "TI_allotment2", "TI_allotment3" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island - Bank",
                Description = "The floor in here is tiled, with a row of wooden bankstands dividing the room in two. Behind the counter stands a row of bank tellers in matching grey suits, ready to serve any patrons that enter.",
                ID = "TI_Bank",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main") 
                },
                IsBank = true
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island - Temple",
                Description = "Rows of wooden pews with red cushions line the room to either stand of the center path. A small altar is at the far end of the room, overlooked by a stained glass window depicting Saradomin, god of order.",
                ID = "TI_Temple",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main")
                }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island - Cavern",
                Description = "The cramped cavern holds a small smithing area next to some copper and tin ore rocks, and a metal fenced area holding a few newts the size of golden retrievers. Their silence feels unnatural when compared to how quickly they dart about.",
                ID = "TI_Cavern",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main"),
                    new Connection("TI_Newts") 
                },
                ProcessingStations = new List<string>() { "Furnace", "Anvil" },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("plansDagger", 1)
                },
                GatheringSpots = new List<string>() { "oreCopper", "oreCopper", "oreCopper", "oreCopper", "oreTin", "oreTin", "oreTin", "oreTin" },
                NPCsHere = new() { "tutorSmithing" },
                ShopItemsHere = new() { "plansHelmet", "plansPlatebody", "plansLeggings", "plansShield", "plansSword" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island - Newt Cage",
                Description = "The newts scurry around you on the ground, largely ignoring your presence. A metal fence separates this area from the rest of the cavern, filled with mining and smithing supplies. The combat tutor stands outside the fence supervising you.",
                ID = "TI_Newts",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Cavern") 
                },
                AreaMonsters = new() { "newt", "newt", "newt" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island - Kitchen",
                Description = "The small building holds little more than a cooking range and a sink. The floor is checkered tiles, and some cooking implements hang from the walls. There's a bucket next to the sink.",
                ID = "TI_Kitchen",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main") 
                },
                ProcessingStations = new List<string>() { "Range", "Sink" },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("bucketEmpty", 1)
                },
                NPCsHere = new() { "tutorCooking" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island - General Store",
                Description = "An assortment of products one could almost mistake for knick-knacks line the shelves of this small building. Most of it doesn't appear to be too useful, but there are a few items of interest. There doesn't seem to be a shopkeeper around, but a jar on the counter indicates that the store is running on an honor system.",
                ID = "TI_GeneralStore",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                ShopItemsHere = new() { "tinderbox", "seedPotato" }
            });


            for (int i = 0; i < locsToAdd.Count; i++) {
                for (int j = 0; j < locsToAdd[i].GatheringSpots.Count; j++) {
                    if (Gathers.ContainsKey(locsToAdd[i].GatheringSpots[j])) {
                        locsToAdd[i].LocalGathers.Add(Helper.Clone(Gathers[locsToAdd[i].GatheringSpots[j]]));
                    }
                }

                for (int j = 0; j < locsToAdd[i].AreaMonsters.Count; j++) {
                    if (Monsters.ContainsKey(locsToAdd[i].AreaMonsters[j])) {
                        locsToAdd[i].MonstersHere.Add(Helper.Clone(Monsters[locsToAdd[i].AreaMonsters[j]]));
                    }
                }


                Atlas.Add(locsToAdd[i].ID, locsToAdd[i]);
            }
        }
    }
}
