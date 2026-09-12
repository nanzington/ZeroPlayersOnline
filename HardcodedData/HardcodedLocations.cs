using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public class HardcodedLocations {
        public static void InitLocs(Dictionary<string, Location> Atlas, Dictionary<string, GatheringTile> Gathers, Dictionary<string, AreaMonster> Monsters) {
            List<Location> locsToAdd = new();

            // Tutorial Island locations

            locsToAdd.Add(new Location("TI_Main", "Tutorial Island", "Tutorial Island") { 
                Description = "You stand on a small island in a bay. There are a few scattered buildings here, designed to help teach some basic activities. There is a bank, a temple, a building that new people appear in, a shack housing a ladder to the cavern below, and the home of a local wizard. There is a pond near the new player building at the center of the island, and the island itself is lightly forested with paths between the buildings.",
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
                NPCsHere = new List<string>() { "tutorFarming", "tutorFishing", "tutorSlayer", "man", "man", "man", "tiForlornGhost2" },
                FarmingPatchesHere = new List<string>() { "TI_allotment1", "TI_allotment2", "TI_allotment3" }, 
                DigItem = "clueScrollTutorial",
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("TI_HI_CrumpledNote", 1, new("QuestAt", 10, "TI_HauntedIsland"))
                }
            });

            locsToAdd.Add(new Location("TI_AirAltar", "Air Altar", "Tutorial Island") { 
                Description = "In a small clearing off to one side of a path lies a cracked stone altar engraved with the symbol for Air. A few crumbling pillars circle the altar, and a soft light pulses from the cracks in the altar itself. Planted near the bases of the pillars are a few sprigs of wild flax.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                ProcessingStations = new List<string>() { "Air Altar" },
                NPCsHere = new() { "tutorRunecrafting" },
                GatheringSpots = new List<string>() { "plantFlax", "plantFlax", "plantFlax", "plantFlax" }
            });

            locsToAdd.Add(new Location("TI_Bank", "Bank", "Tutorial Island") {
                Description = "The floor in here is tiled, with a row of wooden bankstands dividing the room in two. Behind the counter stands a row of bank tellers in matching grey suits, ready to serve any patrons that enter.",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main") 
                },
                NPCsHere = new List<string>() { "tutorBanking" },
                IsBank = true
            });

            locsToAdd.Add(new Location("TI_Temple", "Temple", "Tutorial Island") {
                Description = "Rows of wooden pews with red cushions line the room to either stand of the center path. A small altar is at the far end of the room, overlooked by a stained glass window depicting Saradomin, god of order.",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main")
                },
                NPCsHere = new() { "tiFatherGuy" }
            });

            locsToAdd.Add(new Location("TI_Cavern", "Cavern", "Tutorial Island") {
                Description = "The cramped cavern holds a small smithing area next to some copper and tin ore rocks, and a metal fenced area holding a few newts the size of golden retrievers. Their silence feels unnatural when compared to how quickly they dart about. It looks like there used to be a path off to another cavern, but at some point part of the ceiling collapsed and mostly blocked it. You could probably squeeze through the cracks to get through still.",
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

            locsToAdd.Add(new Location("TI_AnimalPen", "Animal Pen", "Tutorial Island") {
                Description = "Some cows and chickens wander around aimlessly in the pen, staring blankly off to the horizon when they aren't chewing on grass. There are some crimson swifts darting about in and around the pen that could be caught fairly easily with a bird snare.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                AreaMonsters = new() { "cow", "cow", "cow", "chicken", "chicken", "chicken" },
                HunterSpots = new() { "birdSwift", "birdSwift", "birdSwift", "birdSwift" },
                NPCsHere = new() { "tutorHunter" }
            });

            locsToAdd.Add(new Location("TI_Newts", "Newt Cage", "Tutorial Island") {
                Description = "The newts scurry around you on the ground, largely ignoring your presence. A metal fence separates this area from the rest of the cavern, filled with mining and smithing supplies. The combat tutor stands outside the fence supervising you.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Cavern") 
                },
                AreaMonsters = new() { "newt", "newt", "newt" }
            });

            locsToAdd.Add(new Location("TI_DungeonEntrance", "Old Agility Course - Entrance", "Tutorial Island") {
                Description = "The dimly lit cavern contains a rickety old agility course, along with overgrown vegetation and shambling hordes of zombies in the pit below. In the center of the pit is a tunnel that the zombies are coming out of. It seems like failing any of the obstacles will result in falling down to the zombies. The first bit of the course involves swinging across some monkey bars, but you could also simply jump down into the pit if you wanted.",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Cavern", exp: 5, skill: "Agility"),
                    new Connection("TI_Agility1", exp: 5, skill: "Agility", alt: "(Cross Monkey Bars)"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)") 
                }
            });

            locsToAdd.Add(new Location("TI_AgilityPit", "Old Agility Course - Pit", "Tutorial Island") {
                Description = "The pit has many zombies in it, any that happen to end up near you taking swipes in your direction. On one side of the pit are some grooves in the wall that you could use to climb back up to the entrance of the course. In the center is a tunnel that gives you an ominous feeling as you stand near it. Something powerful may be waiting inside.",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_DungeonEntrance", alt: "(Climb to Entrance)"),
                    new Connection("TI_BossCave", alt: "(Enter Ominous Tunnel)")
                },
                AreaMonsters = new() { "tiZombie", "tiZombie", "tiZombie", "tiZombie", "tiZombie", "tiZombie" }
            });

            locsToAdd.Add(new Location("TI_Agility1", "Old Agility Course - Past the Monkey Bars", "Tutorial Island") {
                Description = "A few small herb bushes cling to the wall, crowding the already thin walkway. The next obstacle is a series of small poles you must jump across the tops of to reach the next ledge.",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Agility2", exp: 5, skill: "Agility", alt: "(Hop Across Poles)"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)")
                },
                GatheringSpots = new List<string>() { "plantGuam", "plantGuam", "plantGuam" }
            });

            locsToAdd.Add(new Location("TI_Agility2", "Old Agility Course - Past the Poles", "Tutorial Island") {
                Description = "You are most of the way around the agility course now. This walkway is a little wider than the last, and uncrowded by vegetation. There are a few ore veins in the wall that you could mine. The obstacle leading to the next ledge is an old rotting balance beam.",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Agility3", exp: 5, skill: "Agility", alt: "(Cross Balance Beam)"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)")
                },
                GatheringSpots = new List<string>() { "oreCopper", "oreCopper", "oreCopper", "oreTin", "oreTin", "oreTin" }
            });

            locsToAdd.Add(new Location("TI_Agility3", "Old Agility Course - Past the Balance Beam", "Tutorial Island") {
                Description = "The end of the agility course is just up ahead, across a rolling log obstacle. Some roots from the trees above hang down from the ceiling here and could be chopped.",
                DungeoneeringLevel = 1,
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_DungeonEntrance", exp: 20, skill: "Agility", alt: "(Cross Rolling Log)"),
                    new Connection("TI_AgilityPit", alt: "(Jump in Pit)")
                },
                GatheringSpots = new List<string>() { "rootsPine", "rootsPine", "rootsPine" }
            });

            locsToAdd.Add(new Location("TI_BossCave", "Old Agility Course - Zombie Lair", "Tutorial Island") {
                Description = "A short way into the tunnel it widens out into a small cavern. The smell of rotten flesh has grown overwhelming and you can finally see the source, a hulking zombie so large it can barely fit in this small cavern. It definitely could not fit through the tunnel to get out to the Agility Course. The huge zombie seems like it won't attack you until you approach, it's just walking in small circles dragging its huge club along the ground.",
                DungeoneeringLevel = 1,
                BossHere = "bossZombie",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_AgilityPit")
                }
            }); 

            locsToAdd.Add(new Location("TI_Kitchen", "Kitchen", "Tutorial Island") {
                Description = "The small building holds little more than a cooking range and a sink. The floor is checkered tiles, and some cooking implements hang from the walls. There's a bucket next to the sink.",
                ConnectedLocations = new List<Connection>() { 
                    new Connection("TI_Main") 
                },
                ProcessingStations = new List<string>() { "Range", "Sink" },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("bucketEmpty", 1)
                },
                NPCsHere = new() { "tutorCooking" }
            });

            locsToAdd.Add(new Location("TI_GeneralStore", "General Store", "Tutorial Island") {
                Description = "An assortment of products one could almost mistake for knick-knacks line the shelves of this small building. Most of it doesn't appear to be too useful, but there are a few items of interest. There doesn't seem to be a shopkeeper around, but a jar on the counter indicates that the store is running on an honor system.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                ShopItemsHere = new() { "tinderbox", "seedPotato", "shovel", "hammer", "needle", "knife", "hatchetBronze", "pickaxeBronze", "fishingNetSmall", "vialEmpty", "trapBird", "runeAir", "runeEarth", "runeFire", "runeWater", "runeMind", "runeBody" },
                GatheringSpots = new List<string>() { "clueCrates" },
                ProcessingStations = new List<string>() { "Tannery", "Pottery Kiln", "Pottery Wheel" },
                NPCsHere = new() { "tiDrunkPirate" }
            });

            locsToAdd.Add(new Location("TI_WizardHut", "Wizard Hut", "Tutorial Island") {
                Description = "The inside of the shack is cramped and full of various knick-knacks and doodads. Some might call the mess 'homey' or 'cozy', but the most accurate descriptor might be 'eccentric'. Piles of books are placed haphazardly on the floor, leaving only narrow paths leading to each of the important spots in the room. An elderly wizard with a long flowing beard and classic blue robes sits at a small desk near a window, looking outside as he smokes from a pipe. A spinning wheel is tucked into a corner near the foot of the bed.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("TI_Main")
                },
                NPCsHere = new() { "tiWizardTerrova", "tiForlornGhost3" },
                ProcessingStations = new List<string>() { "Spinning Wheel" }
            });


            // Misthalin Locations

            // // Lumbridge
            
            if (GameLoop.DemoMode) {
                locsToAdd.Add(new Location("MIST_LumbridgeCastleBailey", "Lumbridge - Castle Bailey", "Misthalin") {
                    Description = "That's the end of the demo! Thank you for taking the time to try out 'my' game. I hope you enjoyed your time, and if you encountered any bugs, want to make suggestions for future content or tweaks to existing content, want to follow the development progress as I continue working my way into mainland Gielinor, or even just want to talk about the game feel free to join the discord linked on itch! /n /n If you wish to continue playing this character, a teleport back to Tutorial Island is provided for your convenience. /n /n Thanks again!",
                    ConnectedLocations = new List<Connection>() {
                        new Connection("TI_Main")
                    }
                });
            } else {
                locsToAdd.Add(new Location("MIST_LumbridgeCastleBailey", "Lumbridge - Castle Bailey", "Misthalin") {
                    Description = "A simple but elegant bailey surrounding a castle, encircled by a stone wall with a large gate set into the east wall, flanked by two guard towers. Around the back of a castle is a smaller tower with a door leading out to the west. To either side of the path leading from the castle doors out of the gate is a beautiful fountain burbling water endlessly. Neatly manicured bushes and flowers line the paths and edges of the walls.",
                    ConnectedLocations = new List<Connection>() {
                        new Connection("MIST_LumbridgeCastleFoyer"),
                        new Connection("MIST_LumbridgeCastleGatehouse"),
                        new Connection("MIST_Lumbridge"),
                        new Connection("MIST_LumbridgeBehindCastle")
                    },
                    NPCsHere = new() { "mistLumHans", "mistLumGee", "man", "man", "man", "woman", "woman" },
                    AreaMonsters = new() { "rat", "rat", "rat", "imp" },
                    GatheringSpots = new() { "treeOak", "treePine", "treePine" }
                }); 
            } 

            locsToAdd.Add(new Location("MIST_LumbridgeCastleGatehouse", "Lumbridge - Castle Gatehouse", "Misthalin") {
                Description = "There's not really much in this gatehouse except for some crates, mostly full of spare guard equipment. There's a ladder going up to the next floor.",
                    ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleBailey"),
                    new Connection("MIST_LumbridgeCastleGatehouse2", alt: "(Climb Ladder)")
                }
            });
            
            locsToAdd.Add(new Location("MIST_LumbridgeCastleGatehouse2", "Lumbridge - Castle Gatehouse Second Floor", "Misthalin") {
                Description = "This floor of the gatehouse is even more stuffed full of crates of spare and old equipment, which seems impractical given you'd have to carry things up a ladder to get here. There's a ladder going up to the roof and back down to the ground floor.",
                    ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleGatehouse", alt: "(Climb Ladder Down)"),
                    new Connection("MIST_LumbridgeCastleGatehouse3", alt: "(Climb Ladder Up)")
                }
            });
            
            locsToAdd.Add(new Location("MIST_LumbridgeCastleGatehouse3", "Lumbridge - Castle Gatehouse Roof", "Misthalin") {
                Description = "Climbing the leader leads you to the roof, where there are a few more barrels stacked up. Some flags are flying banners bearing the Lumbridge colors. For some reason there are a couple cannons up here, though they wouldn't really be able to aim at much. There's a bronze pickaxe up here that seems out of place, so you could probably take it without issue. You have a decent view of the surroundings from up here of the nearby farms to the north, the swamp to the south, and Al Kharid to the east.",
                    ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleGatehouse2", alt: "(Climb Ladder Down)")
                },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("pickaxeBronze", 1)
                }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeCastleFoyer", "Lumbridge - Castle Foyer", "Misthalin") {
                Description = "The castle foyer is well lit by torches and windows. A couple paintings hang on the wall, one of a former King and one of Ice Mountain. Some banners and tapestries bearing the Lumbridge heraldry also adorn the walls, a blue-and-white rug edged with gold covers part of the floor, and a few decorative suits of armor are strategically placed along the edge of the room. There are staircases on the north and south sides of the castle, but the one to the south seems much more heavily trafficked.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleBailey"),
                    new Connection("MIST_LumbridgeCastleKitchen"),
                    new Connection("MIST_LumbridgeCastleFloor2"), 
                    new Connection("MIST_LumbridgeCastleDiningHall")
                },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("runeMind", 1),
                    new ItemSpot("arrowsBronze", 1)
                }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeCastleFloor2", "Lumbridge - Castle Second Floor", "Misthalin") {
                Description = "There are two rooms on this floor of the Castle. The northern room is the bedroom of the Lumbridge Duke, Duke Horacio. It is elegantly furnished as befitting his status, the four-posted bed and other furniture in the room of exquisite construction. The other room is home to the Duke's advisor, Sigmund, and is much more modest. Sigmund's room is fairly sparse other than a bed, set of drawers, spinning wheel, and a fairly nice rug spread across the floor.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleFoyer"),
                    new Connection("MIST_LumbridgeCastleFloor3")
                },
                NPCsHere = new() { "mistLumDukeHoracio", "mistLumSigmund" },
                ProcessingStations = new() { "Spinning Wheel" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeCastleFloor3", "Lumbridge - Castle Third Floor", "Misthalin") {
                Description = "There is little up here except for, strangely, a free-standing building on top of the Castle containing a bank. The inside of the bank is fairly nice, though spartan by necessity due to the small size of the room. Besides the bank booths it has a small desk and a couple chairs, plus another Saradomin rug spread on the floor. There's a ladder leaning against one side of the bank building allowing you to climb up even higher if desired.",
                IsBank = true,
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleFloor2"),
                    new Connection("MIST_LumbridgeCastleFloor4", alt: "(Climb Ladder)")
                }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeCastleFloor4", "Lumbridge - Top of the Castle", "Misthalin") {
                Description = "It's quite breezy up here, but you've reached the absolute highest point in Lumbridge. You can see the windmill and the city of Varrock to the north, Al Kharid to the west, and Draynor Village to the east. There is a small flagpole here with a crank to raise the flag.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleFloor3", alt: "(Climb Ladder)")
                },
                GatheringSpots = new() { "lumbridgeFlag" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeCastleKitchen", "Lumbridge - Castle Kitchen", "Misthalin") {
                Description = "A surprisingly humble kitchen, considering it's in a castle. There are a couple tables and crates scattered around almost haphazardly, along with a sink, range, and pile of pots and pans. Various cooking implements hang from racks on the walls, and a trapdoor set into the floor leads to the basement. A door to the side of the kitchen leads directly into the Dining Hall.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleFoyer"),
                    new Connection("MIST_LumbridgeCastleCellar", alt: "(Climb Ladder)"),
                    new Connection("MIST_LumbridgeCastleDiningHall")
                },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("potEmpty", 1),
                    new ItemSpot("jugEmpty", 1),
                    new ItemSpot("bowlEmpty", 1),
                    new ItemSpot("knife", 1)
                },
                ProcessingStations = new() { "Range", "Sink" }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeCastleCellar", "Lumbridge - Castle Cellar", "Misthalin") {
                Description = "Yet more cookery items litter the shelves down here, and for some reason there's another sink. A few items are strewn about on the ground that you could take, but otherwise there isn't much interesting going on in this dark and dank basement.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleKitchen", alt: "(Climb Ladder)")
                },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("bootsLeather", 1),
                    new ItemSpot("knife", 1),
                    new ItemSpot("cabbage", 1),
                    new ItemSpot("jugEmpty", 1),
                    new ItemSpot("bucketEmpty", 1)
                },
                ProcessingStations = new() { "Sink" },
                GatheringSpots = new() { "clueCrates" }
            }); 

            locsToAdd.Add(new Location("MIST_Lumbridge", "Lumbridge", "Misthalin") {
                Description = "A quaint town along the banks of the River Lum. A street meanders through the town, past the castle, ending in a small cul-de-sac with the graveyard. A small church is across the street from the castle, adjacent the graveyard. Nearby at the end of the road are a few houses and Bob's Brilliant Axes. There's a bridge across the Lum, and farther north lies the rest of Lumbridge.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleBailey"),
                    new Connection("MIST_LumbridgeNorth"),
                    new Connection("MIST_LumbridgeChurch"),
                    new Connection("MIST_LumbridgeGraveyard"),
                    new Connection("MIST_LumbridgeBobsAxes"),
                    new Connection("MIST_LumbridgeVictoria"),
                    new Connection("MIST_LumbridgeEmptyHouse")
                },
                GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine" }
            });
            
            locsToAdd.Add(new Location("MIST_LumbridgeBobsAxes", "Bob's Brilliant Axes", "Misthalin") {
                Description = "A cozy little storefront with shelves of various types of axes on display. There's a clock ticking in one corner but the hands don't actually appear to be moving at all. A few crates and barrels are stacked in the corners of the rooms, and a small painting of a port hangs on the wall. Bob, the proprietor, stands nearly motionless behind the counter.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_Lumbridge")
                },
                ShopItemsHere = new() { "pickaxeBronze", "pickaxeIron", "pickaxeSteel", "pickaxeMithril", "pickaxeAdamant", "hatchetBronze", "hatchetIron", "hatchetSteel", "hatchetMithril", "hatchetAdamant", "battleaxeBronze", "battleaxeIron", "battleaxeSteel", "battleaxeMithril", "battleaxeAdamant" }
            });
            
            locsToAdd.Add(new Location("MIST_LumbridgeChurch", "Lumbridge Church", "Misthalin") {
                Description = "The church is decorated simply but expertly in dedication to Saradomin, God of Order. Two rows of cushioned wooden pews face the altar and the walls are lined with stained glass windows. Against the wall behind the altar are a few stands of candles and a pipe organ. A couple plush rugs coat the floor, though strangely in red instead of the traditional blue of Saradomin.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_Lumbridge")
                },
                NPCsHere = new() { "mistLumAereck", "tutorPrayer", "woman" }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeGraveyard", "Lumbridge Graveyard", "Misthalin") {
                Description = "A low fog clings to the ground around the headstones here. The graveyard is enclosed by a short wrought-iron fence, grass and weeds growing slightly rampant due to the lack of a gardener. An imposing building holds a mausoleum and the stairs down to the catacombs.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_Lumbridge"),
                    new Connection("MIST_LumbridgeCatacombs"),
                    new Connection("MIST_LumbridgeSwamp")
                },
                NPCsHere = new() { "mistLumbXenia" },
                GatheringSpots = new() { "treeYew" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeEmptyHouse", "Empty House", "Misthalin") {
                Description = "It seems like someone used to live here, but they aren't around anymore. There are a couple shelves up against one wall, some more shelves hanging on another wall with cooking implements stacked on them, and a small table with two chairs in the middle of the room. A bed stuffed in one corner of the room and a couple brown rugs make the shack feel a little more homely. The last thing in the house is a range that still seems functional.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_Lumbridge")
                },
                ProcessingStations = new() { "Range" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeVictoria", "Victoria's Home", "Misthalin") {
                Description = "A cozy little cramped house just off bustling downtown Lumbridge! For just a few hundred thousand gold a month this home could be yours!... If Victoria wasn't already living here, and looking somewhat displeased with you having barged in. There's a bookshelf up against one wall, some shelves holding various knick-knacks, a small table and chair, a bed, and a sink. Also one adventurer, and one woman who would prefer there was not an adventurer.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_Lumbridge")
                },
                NPCsHere = new() { "mistLumbVictoria" },
                ProcessingStations = new() { "Sink" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeNorth", "North Lumbridge", "Misthalin") {
                Description = "The more active part of Lumbridge, north of the castle. The main town road extends through this section farther north to Farmer Fred's farm, and south past the castle. There is a market, general store, forge, fishing shop, and tavern here. ",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_Lumbridge"),
                    new Connection("MIST_LumbridgeTowardsDraynor"),
                    new Connection("MIST_LumbridgeFredsFarm"),
                    new Connection("MIST_LumbridgeGeneralStore"),
                    new Connection("MIST_LumbridgeMarket"),
                    new Connection("MIST_LumbridgeFishingStore"),
                    new Connection("MIST_LumbridgeShearedRam"),
                    new Connection("MIST_LumbridgeCommunalForge")
                },
                NPCsHere = new() { "man", "man", "man", "man" },
                GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine", "treeWillow", "treeWillow", "fishBaitLow", "fishBaitLow", "fishBaitLow", "fishLure", "fishLure", "fishLure" }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeMarket", "Lumbridge Market", "Misthalin") {
                Description = "The small market is bustling, people wandering from stall to stall to peruse the goods on sale. A few sets of tables and chairs allow people to take a break and eat the things they've purchased. Some guards are walking around to guard the stalls but aren't doing a particularly good job, and an enterprising individual could easily steal without their notice.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeNorth"),
                    new Connection("MIST_LumbridgeFishingStore")
                },
                NPCsHere = new() { "mistLumHarlan", "man", "man", "woman", "woman", "woman", "woman" },
                GatheringSpots = new() { "stallVegetable", "stallVegetable", "stallBakery", "stallBakery", "stallCrafting", "stallCrafting", "stallWine", "stallWine", "stallSeed", "stallSeed"}
                // TODO: Add some shop items here? It IS a market
            });

            locsToAdd.Add(new Location("MIST_LumbridgeShearedRam", "The Sheared Ram", "Misthalin") {
                Description = "This small bar is fairly cozy, with windows looking out over the River Lum and rustic decorations around the room. There are a small handful of tables available, or you could take a seat at the bar. The occupants are a little rowdy but the bar is not overly full in such a small town.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeNorth")
                },
                NPCsHere = new() { "mistLumBartender", "mistLumVeos", "clueArthur", "man", "man", "man" },
                ShopItemsHere = new() { "beer" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeCommunalForge", "Communal Forge", "Misthalin") {
                Description = "This small shack isn't even really enclosed, more of a stone canopy. It has some of the basic tools for smelting and smithing. A few small workbenches with stools are pushed up against the few walls the canopy does have, and a dirty brown rug covers part of the floor. Most of the floorspace is taken up by the furnace and anvil.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeNorth")
                },
                ProcessingStations = new() { "Furnace", "Anvil" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeGeneralStore", "General Store", "Misthalin") {
                Description = "An assortment of products one could almost mistake for knick-knacks line the shelves of this small building. Most of it doesn't appear to be too useful, but there are a few items of interest. Seems like business here isn't quite as good since the market and fishing store moved in.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeNorth")
                },
                ShopItemsHere = new() { "potEmpty", "jugEmpty", "shears", "knife", "bucketEmpty", "bowlEmpty", "tinCakeEmpty", "tinderbox", "chisel", "shovel", "hammer", "plantPotEmpty"  },
                NPCsHere = new() { "man", "man" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeFishingStore", "Fishing Store", "Misthalin") {
                Description = "There's a fishy smell lingering in here, permeating the walls and floors. A cooler has a variety of fish available, and the tools to catch your own fish line the shelves while the disgruntled store owner lounges in a chair behind the counter.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeNorth")
                },
                ShopItemsHere = new() { "baitFish", "feather", "fishingNetSmall", "fishingNetBig", "fishingRod", "fishingRodFly", "fishingPotLobster", "fishingHarpoon", "fishRawShrimp", "fishRawAnchovies", "fishRawSardine", "fishRawHerring", "fishRawTrout", "fishRawPike", "fishRawSalmon", "fishRawTuna", "fishRawSwordfish" },
                NPCsHere = new() { "man", "man" }
            });

            locsToAdd.Add(new Location("MIST_LumbridgeFredsFarm", "Fred's Farm", "Misthalin") {
                Description = "A fairly large farmstead owned and operated by Fred the Farmer. There are some sheep here, plus a cow pen and chicken coop that you could get into. A huge windmill spins endlessly atop a small hill, and there are wheat and potato fields here. An axe in front of Fred's house has a bronze hatchet stuck in it.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeNorth"),
                    new Connection("MIST_DraynorCrossroads"),
                    new Connection("MIST_LumbridgeFredsFarmChickens"),
                    new Connection("MIST_LumbridgeFredsFarmCows")
                },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("hatchetBronze", 1)
                },
                GatheringSpots = new() { "treePine", "treePine", "treePine", "sheep", "sheep", "sheep", "plantPotato", "plantPotato", "plantPotato", "plantGrain", "plantGrain", "plantGrain"},
                ProcessingStations = new() { "Windmill" },
                NPCsHere = new() { "farmerFred", "farmer" }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeFredsFarmChickens", "Fred's Chicken Coop", "Misthalin") {
                Description = "It's a little cramped inside this coop, what with all the chickens wandering around and the sacks of seed and grain. One of Fred's farmhands is here keeping an eye on the chickens, but apparently isn't being paid enough to stop you from harming them.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeFredsFarm")
                },
                ItemSpawns = new List<ItemSpot>() {
                    new ItemSpot("eggChicken", 1)
                },
                AreaMonsters = new() { "chicken", "chicken", "chicken", "chicken" },
                NPCsHere = new() { "farmer" }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeFredsFarmCows", "Fred's Cow Pen", "Misthalin") {
                Description = "This is a spacious pen full of cows and their calves right on the banks of the River Lum. A few thistles grow around the pen, occasionally being eaten by the cows and then reappearing a few seconds later.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeFredsFarm")
                },
                AreaMonsters = new() { "cow", "cow", "cow", "cow" },
                ProcessingStations = new() { "Dairy Cow" },
                NPCsHere = new() { "farmer" }
            }); 

            locsToAdd.Add(new Location("MIST_LumbridgeBehindCastle", "Lumbridge - Behind the Castle", "Misthalin") {
                Description = "The area behind Lumbridge Castle is lightly forested. For some reason there's an unlocked door leading inside the walls, and nobody is guarding it. A few more poles hang the Lumbridge banner back here. There are a few stray sheep, some rodents of unusual size, some rodents of usual size, and a farming patch to grow trees as well.",
                ConnectedLocations = new List<Connection>() {
                    new Connection("MIST_LumbridgeCastleBailey")
                },
                GatheringSpots = new() { "treeOak", "treeOak", "treeYew", "treePine", "treePine", "treePine", "sheep", "sheep" },
                FarmingPatchesHere = new() { "MIST_LumbTree" },
                AreaMonsters = new() { "rat", "rat", "rat", "ratGiant", "ratGiant" }
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
