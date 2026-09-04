using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public class HardcodedLocations {
        public static void InitLocs(Dictionary<string, Location> Atlas, Dictionary<string, GatheringTile> Gathers, Dictionary<string, AreaMonster> Monsters) {
            List<Location> locsToAdd = new();

            // Tutorial Island locations

            locsToAdd.Add(new Location() {
                DisplayName = "Tutorial Island",
                Region = "Tutorial Island",
                Description = "You stand on a small island in a bay. There are a few scattered buildings here, designed to help teach some basic activities. There is a bank, a temple, a building that new people appear in, a shack housing a ladder to the cavern below, and the home of a local wizard. There is a pond near the new player building at the center of the island, and the island itself is lightly forested with paths between the buildings.",
                ID = "TI_Main",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_AirAltar"),
                    new Connection("TI_AnimalPen"),
                    new Connection("TI_Bank"),
                    new Connection("TI_Cavern"),
                    new Connection("TI_GeneralStore"),
                    new Connection("TI_Kitchen"),
                    new Connection("TI_Temple"),
                    new Connection("TI_WizardHut")
                },
                GatheringSpots = new List<string>() { "treePine", "treePine", "treePine", "treePine", "treePine", "treePine", "treePine", "fishNetSmall", "fishNetSmall" },
                NPCsHere = new List<string>() { "tutorFarming", "tutorFishing", "man", "man", "man", "tiForlornGhost2" },
                FarmingPatchesHere = new List<string>() { "TI_allotment1", "TI_allotment2", "TI_allotment3" }, 
                DigItem = "clueScrollTutorial",
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("TI_HI_CrumpledNote", 1, new("QuestAt", 10, "TI_HauntedIsland"))
                }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Air Altar",
                Region = "Tutorial Island",
                Description = "In a small clearing off to one side of a path lies a cracked stone altar engraved with the symbol for Air. A few crumbling pillars circle the altar, and a soft light pulses from the cracks in the altar itself. Planted near the bases of the pillars are a few sprigs of wild flax.",
                ID = "TI_AirAltar",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                ProcessingStations = new List<string>() { "Air Altar" },
                NPCsHere = new() { "tutorRunecrafting" },
                GatheringSpots = new List<string>() { "plantFlax", "plantFlax", "plantFlax", "plantFlax" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Bank",
                Region = "Tutorial Island",
                Description = "The floor in here is tiled, with a row of wooden bankstands dividing the room in two. Behind the counter stands a row of bank tellers in matching grey suits, ready to serve any patrons that enter.",
                ID = "TI_Bank",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main") 
                },
                NPCsHere = new List<string>() { "tutorBanking" },
                IsBank = true
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Temple",
                Region = "Tutorial Island",
                Description = "Rows of wooden pews with red cushions line the room to either stand of the center path. A small altar is at the far end of the room, overlooked by a stained glass window depicting Saradomin, god of order.",
                ID = "TI_Temple",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main")
                },
                NPCsHere = new() { "tiFatherGuy" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Cavern",
                Region = "Tutorial Island",
                Description = "The cramped cavern holds a small smithing area next to some copper and tin ore rocks, and a metal fenced area holding a few newts the size of golden retrievers. Their silence feels unnatural when compared to how quickly they dart about. It looks like there used to be a path off to another cavern, but at some point part of the ceiling collapsed and mostly blocked it. You could probably squeeze through the cracks to get through still.",
                ID = "TI_Cavern",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main"),
                    new Connection("TI_Newts"),
                    new Connection("TI_DungeonEntrance", exp: 5, skill: "Agility") 
                },
                ProcessingStations = new List<string>() { "Furnace", "Anvil" },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("TI_HI_RustedSword", 1, new("QuestAt", 0, "TI_HauntedIsland"))
                },
                GatheringSpots = new List<string>() { "oreCopper", "oreCopper", "oreCopper", "oreCopper", "oreTin", "oreTin", "oreTin", "oreTin", "rockEssence", "rockEssence", "rockEssence", "rockClay", "rockClay", "rockClay" },
                NPCsHere = new() { "tutorSmithing", "tutorCombat", "tiForlornGhost1" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Animal Pen",
                Region = "Tutorial Island",
                Description = "Some cows and chickens wander around aimlessly in the pen, staring blankly off to the horizon when they aren't chewing on grass. ",
                ID = "TI_AnimalPen",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                AreaMonsters = new() { "cow", "cow", "cow", "chicken", "chicken", "chicken" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Newt Cage",
                Region = "Tutorial Island",
                Description = "The newts scurry around you on the ground, largely ignoring your presence. A metal fence separates this area from the rest of the cavern, filled with mining and smithing supplies. The combat tutor stands outside the fence supervising you.",
                ID = "TI_Newts",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Cavern") 
                },
                AreaMonsters = new() { "newt", "newt", "newt" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Abandoned Agility Course - Entrance",
                Region = "Tutorial Island",
                Description = "The dimly lit cavern contains a rickety old agility course, along with overgrown vegetation and shambling hordes of zombies in the pit below. In the center of the pit is a tunnel that the zombies are coming out of. It seems like failing any of the obstacles will result in falling down to the zombies. The first bit of the course involves swinging across some monkey bars, but you could also simply jump down into the pit if you wanted.",
                ID = "TI_DungeonEntrance",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Cavern", exp: 5, skill: "Agility"),
                    new Connection("TI_Agility1", exp: 5, skill: "Agility", alt: "(Cross Monkey Bars)", check: true, checkFailDest: "TI_AgilityPit"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)") 
                }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Abandoned Agility Course - Pit",
                Region = "Tutorial Island",
                Description = "The pit has many zombies in it, any that happen to end up near you taking swipes in your direction. On one side of the pit are some grooves in the wall that you could use to climb back up to the entrance of the course. In the center is a tunnel that gives you an ominous feeling as you stand near it. Something powerful may be waiting inside.",
                ID = "TI_AgilityPit",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_DungeonEntrance", alt: "(Climb to Entrance)"),
                    new Connection("TI_BossCave", alt: "(Enter Ominous Tunnel)")
                },
                AreaMonsters = new() { "tiZombie", "tiZombie", "tiZombie", "tiZombie", "tiZombie", "tiZombie" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Abandoned Agility Course - Past the Monkey Bars",
                Region = "Tutorial Island",
                Description = "A few small herb bushes cling to the wall, crowding the already thin walkway. The next obstacle is a series of small poles you must jump across the tops of to reach the next ledge.",
                ID = "TI_Agility1",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Agility2", exp: 5, skill: "Agility", alt: "(Hop Across Poles)", check: true, checkFailDest: "TI_AgilityPit"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)")
                },
                GatheringSpots = new List<string>() { "plantGuam", "plantGuam", "plantGuam" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Abandoned Agility Course - Past the Poles",
                Region = "Tutorial Island",
                Description = "You are most of the way around the agility course now. This walkway is a little wider than the last, and uncrowded by vegetation. There are a few ore veins in the wall that you could mine. The obstacle leading to the next ledge is an old rotting balance beam.",
                ID = "TI_Agility2",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Agility3", exp: 5, skill: "Agility", alt: "(Cross Balance Beam)", check: true, checkFailDest: "TI_AgilityPit"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)")
                },
                GatheringSpots = new List<string>() { "oreCopper", "oreCopper", "oreCopper", "oreTin", "oreTin", "oreTin" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Abandoned Agility Course - Past the Balance Beam",
                Region = "Tutorial Island",
                Description = "The end of the agility course is just up ahead, across a rolling log obstacle. Some roots from the trees above hang down from the ceiling here and could be chopped.",
                ID = "TI_Agility3",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_DungeonEntrance", exp: 20, skill: "Agility", alt: "(Cross Rolling Log)", check: true, checkFailDest: "TI_AgilityPit"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)")
                },
                GatheringSpots = new List<string>() { "rootsPine", "rootsPine", "rootsPine" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Abandoned Agility Course - Zombie Lair",
                Region = "Tutorial Island",
                Description = "A short way into the tunnel it widens out into a small cavern. The smell of rotten flesh has grown overwhelming and you can finally see the source, a hulking zombie so large it can barely fit in this small cavern. It definitely could not fit through the tunnel to get out to the Agility Course. The huge zombie seems like it won't attack you until you approach, it's just walking in small circles dragging its huge club along the ground.",
                ID = "TI_BossCave",
                DungeoneeringLevel = 1,
                BossHere = "bossZombie",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_AgilityPit")
                }
            });



            locsToAdd.Add(new Location() {
                DisplayName = "Kitchen",
                Region = "Tutorial Island",
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
                DisplayName = "General Store",
                Region = "Tutorial Island",
                Description = "An assortment of products one could almost mistake for knick-knacks line the shelves of this small building. Most of it doesn't appear to be too useful, but there are a few items of interest. There doesn't seem to be a shopkeeper around, but a jar on the counter indicates that the store is running on an honor system.",
                ID = "TI_GeneralStore",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                ShopItemsHere = new() { "tinderbox", "seedPotato", "shovel", "hammer", "needle", "knife", "hatchetBronze", "pickaxeBronze", "fishingNetSmall", "vialEmpty", "runeAir", "runeEarth", "runeFire", "runeWater", "runeMind", "runeBody" },
                GatheringSpots = new List<string>() { "clueCrates" },
                ProcessingStations = new List<string>() { "Tannery", "Pottery Kiln", "Pottery Wheel" },
                NPCsHere = new() { "tiDrunkPirate" }
            });

            locsToAdd.Add(new Location() {
                DisplayName = "Wizard Hut",
                Region = "Tutorial Island",
                Description = "The inside of the shack is cramped and full of various knick-knacks and doodads. Some might call the mess 'homey' or 'cozy', but the most accurate descriptor might be 'eccentric'. Piles of books are placed haphazardly on the floor, leaving only narrow paths leading to each of the important spots in the room. An elderly wizard with a long flowing beard and classic blue robes sits at a small desk near a window, looking outside as he smokes from a pipe. A spinning wheel is tucked into a corner near the foot of the bed.",
                ID = "TI_WizardHut",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                NPCsHere = new() { "tiWizardTerrova", "tiForlornGhost3" },
                ProcessingStations = new List<string>() { "Spinning Wheel" }
            });


            // Misthalin Locations

            // // Lumbridge

            locsToAdd.Add(new Location() {
                DisplayName = "Lumbridge - Castle Bailey",
                Region = "Misthalin", 
                Description = "A simple but elegant bailey surrounding a castle, encircled by a stone wall with a large gate set into the east wall, flanked by two guard towers. Around the back of a castle is a smaller tower with a door leading out to the west. To either side of the path leading from the castle doors out of the gate is a beautiful fountain burbling water endlessly. Neatly manicured bushes and flowers line the paths and edges of the walls.",
                ID = "MIST_LumbridgeCastleBailey",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                }
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
