using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public class HardcodedLocations {
        public static void InitLocs(Dictionary<string, Location> Atlas, Dictionary<string, GatheringTile> Gathers, Dictionary<string, AreaMonster> Monsters) {
            List<Location> locsToAdd = new();

            // Tutorial Island locations
            {
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
            }


            // Misthalin Locations
            {
                // // Lumbridge
                {
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
                            NPCsHere = new() { "mistLumHans", "man", "man", "man", "woman", "woman" },
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
                        },
                        GatheringSpots = { "clueCrates" }
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
                        ProcessingStations = new() { "Spinning Wheel" },
                        GatheringSpots = new() { "clueChest" }
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
                            new Connection("MIST_LumbridgeCastleDiningHall"),
                            new Connection("MIST_LumbridgeCastleCellar", alt: "(Climb Ladder)")
                        },
                        ItemSpawns = new List<ItemSpot>() {
                            new ItemSpot("potEmpty", 1),
                            new ItemSpot("jugEmpty", 1),
                            new ItemSpot("bowlEmpty", 1),
                            new ItemSpot("knife", 1)
                        },
                        ProcessingStations = new() { "Range", "Sink" },
                        NPCsHere = new() { "mistLumCook" }
                    }); 

                    locsToAdd.Add(new Location("MIST_LumbridgeCastleDiningHall", "Lumbridge - Castle Dining Hall", "Misthalin") {
                        Description = "An ornately, bordering on gaudily, decorated dining hall. Well, there's only ten chairs, so it's not really much of a 'hall', but it's certainly a place to eat in a castle. The walls are decorated with tapestries and portraits. Suits of armor and standing candelabras line the walls. There's a fireplace on the west side of the room with candles on the mantle and a painting above it. It, inexplicably, has a fire roaring in it despite the room being empty. There's a plush red rug covering most of the floor, and the center of the room is occupied by a rectangular table with ten chairs around it.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeCastleFoyer"),
                            new Connection("MIST_LumbridgeCastleKitchen")
                        }
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
                            new Connection("MIST_LumbridgeAcrossLum"),
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
                            new Connection("MIST_LumbridgeSwamp5")
                        },
                        NPCsHere = new() { "mistLumXenia", "mistLumRestlessGhost" },
                        GatheringSpots = new() { "treeYew", "mistLumCoffin" }
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
                        NPCsHere = new() { "mistLumVictoria" },
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
                            new Connection("MIST_LumbridgeCommunalForge"),
                            new Connection("MIST_GroatsFarm")
                        },
                        NPCsHere = new() { "mistLumDoomsayer", "man", "man", "man", "man" },
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
                        ProcessingStations = new() { "Casting", "Furnace", "Anvil" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeGeneralStore", "General Store", "Misthalin") {
                        Description = "An assortment of products one could almost mistake for knick-knacks line the shelves of this small building. Most of it doesn't appear to be too useful, but there are a few items of interest. Seems like business here isn't quite as good since the market and fishing store moved in.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeNorth")
                        },
                        ShopItemsHere = new() { "potEmpty", "jugEmpty", "shears", "knife", "bucketEmpty", "bowlEmpty", "tinCakeEmpty", "tinderbox", "chisel", "shovel", "hammer", "plantPotEmpty", "rope", "candle" }, // TODO: Once actual places to get candle and rope exist, remove them from here
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
                        GatheringSpots = new() { "clueChest", "treePine", "treePine", "treePine", "sheep", "sheep", "sheep", "plantPotato", "plantPotato", "plantPotato", "plantOnion", "plantOnion", "plantGrain", "plantGrain", "plantGrain"},
                        ProcessingStations = new() { "Windmill" },
                        NPCsHere = new() { "mistLumFred", "farmer" }
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
                            new Connection("MIST_LumbridgeCastleBailey"), 
                            new Connection("MIST_LumbridgeTowardsDraynor")
                        },
                        GatheringSpots = new() { "treeOak", "treeOak", "treeYew", "treePine", "treePine", "treePine", "sheep", "sheep" },
                        FarmingPatchesHere = new() { "MIST_LumbTree" },
                        AreaMonsters = new() { "rat", "rat", "rat", "ratGiant", "ratGiant" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeTowardsDraynor", "Between Lumbridge and Draynor", "Misthalin") {
                        Description = "Just outside Lumbridge on the path leading from there to Draynor Village. The path winds back and forth between the small hills of the countryside. A small smattering of monsters and trees can be found here, and a crumbling ruin of a building, but not a lot else of interest. There's a suspicious locked trapdoor in the ruin.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeNorth"),
                            new Connection("MIST_LumbridgeBehindCastle"),
                            new Connection("MIST_HamHideout", new() { new("Skill", 5, "Thieving") }, false, 5, "Thieving", "(Pick-lock Trapdoor)"),
                            new Connection("MIST_DraynorOutskirtsSouth")
                        },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine" },
                        AreaMonsters = new() { "spiderGiant", "spiderGiant", "goblin", "goblin", "goblin" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeAcrossLum", "Across the River Lum", "Misthalin") {
                        Description = "There is a small ruined shack here surrounded by goblins and a couple giant spiders. A signpost here says 'North: farms and Varrock', 'East: Al Kharid toll gate', 'South: the River Lum', 'West: Lumbridge'.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_GroatsFarm"),
                            new Connection("DES_AlKharidOutskirts", new() { new("QuestAt", 100, "DES_PrinceAliRescue"), new("Item", 10, "Gold", true) }, true), // TODO: When Prince Ali Rescue is implemented, update this to the actual complete stage
                            new Connection("MIST_Lumbridge"),
                            new Connection("MIST_VarrockMineWest", null, false, 30, "Woodcutting", "(Canoe to the Champion's Guild)", false, 12),
                            new Connection("MIST_BarbarianVillage", null, false, 60, "Woodcutting", "(Canoe to Barbarian Village)", false, 27),
                            new Connection("MIST_Edgeville", null, false, 90, "Woodcutting", "(Canoe to Edgeville)", false, 42),
                            new Connection("WILD_FeroxEnclave", null, false, 150, "Woodcutting", "(Canoe to Ferox Enclave)", false, 57),
                            new Connection("WILD_WildernessPond", null, false, 150, "Woodcutting", "(Canoe to Wilderness Pond)", false, 57)
                        },
                        ItemSpawns = new List<ItemSpot>() {
                            new ItemSpot("daggerIron", 1)
                        },
                        NPCsHere = new() { "desBorderGuard" },
                        GatheringSpots = new() { "clueBoxes", "treeOak", "treeOak", "treePine", "treePine", "treePine", "treeDead", "treeDead", "treeDead" },
                        AreaMonsters = new() { "goblin", "goblin", "goblin", "goblin", "goblin", "spiderGiant", "spiderGiant" }
                    });

                    locsToAdd.Add(new Location("MIST_GroatsFarm", "Groats' Farm", "Misthalin") {
                        Description = "A sprawling farmstead on the banks of the River Lum, just east of Lumbridge. There are a variety of trees here, a small potato field, a chicken coop, and a modest house where Seth and his daughter live. Some farmhands walk around managing the chores. There's a cow field taking up the east half of the farm, and a farm patch suitable for growing hops.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockCrossroadsSouth"),
                            new Connection("MIST_GroatsFarmCows"),
                            new Connection("MIST_LumbridgeNorth"),
                            new Connection("MIST_LumbridgeAcrossLum")
                        },
                        ItemSpawns = new List<ItemSpot>() {
                            new ItemSpot("eggChicken", 1)
                        },
                        NPCsHere = new() { "mistLumGroatsSeth", "mistLumGroatsGillie" },
                        ProcessingStations = new() { "Range", "Dairy Churn" },
                        FarmingPatchesHere = new() { "MIST_LumbHops" },
                        GatheringSpots = new() { "treeWillow", "treeWillow", "treeWillow", "treeOak", "treeOak", "treePine", "treePine", "treePine", "plantPotato", "plantPotato", "plantPotato" },
                        AreaMonsters = new() { "farmer", "farmer", "farmer", "chicken", "chicken", "chicken", "chicken", "chicken" }
                    });

                    locsToAdd.Add(new Location("MIST_GroatsFarmCows", "Groats' Farm - Cow Pen", "Misthalin") {
                        Description = "A spacious pen holding many cows, which are grazing passively on the short grass coating the ground of the pen. It is surrounded by a wooden fence, with the Lum and Groats' Farm to the west and a spot north of Al Kharid to the east.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_GroatsFarm"),
                            new Connection("MIST_GroatsFarmBrutus") // TODO: Block entry until Ides of Milk is progressed enough
                        },
                        ItemSpawns = new List<ItemSpot>() {
                            new ItemSpot("bucketEmpty", 1)
                        },
                        ProcessingStations = new() { "Dairy Cow" }, 
                        AreaMonsters = new() { "cow", "cow", "cow", "cow", "cow", "cow", "cow", "cow" }
                    });

                    locsToAdd.Add(new Location("MIST_GroatsFarmBrutus", "Groats' Farm - Brutus", "Misthalin") {
                        Description = "This part of the field has a huge angry-looking bull with huge horns and red eyes whose name seems to be Brutus. He snorts and stomps around like he owns the place which, at least by the standards of animals, he essentially does. Brutus looks a bit intimidating. Definitely doesn't skip leg day.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_GroatsFarmCows"), 
                        },
                        BossHere = "bossBrutus"
                    });

                    locsToAdd.Add(new Location("MIST_HamHideout", "H.A.M. Hideout", "Misthalin") {
                        Description = "This is a surprisingly large cavern lit by braziers and torches. Banners are hung haphazardly everywhere bearing a logo consisting of the letters 'HAM' stylized in purple, green, and red. A handful of wooden benches are facing a small stage that a fanatic is preaching about the evils of 'monsters' on. Other fanatics are scattered around the cavern speaking energetically with eachother. They are all dressed in nearly identical magenta clothing.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeTowardsDraynor", alt: "(Climb Ladder)"),
                            new Connection("MIST_HamHideoutCells")
                        }, 
                        NPCsHere = new() { "hamFemale", "hamFemale", "hamFemale", "hamMale", "hamMale", "hamMale" },
                        AreaMonsters = new() { "hamGuard", "hamGuard", "hamGuard", "hamGuard", "hamGuard" }
                    });

                    locsToAdd.Add(new Location("MIST_HamHideoutCells", "H.A.M. Hideout - Cells", "Misthalin") {
                        Description = "This small branch off the main hideout is less populated but still lit by braziers and torches. Banners are hung haphazardly everywhere bearing a logo consisting of the letters 'HAM' stylized in purple, green, and red. A few small jail cells are set up with the metal bars sunk into the floor of the cavern.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_HamHideout")
                        }, 
                        NPCsHere = new() { "mistHamJimmy", "hamFemale" },
                        AreaMonsters = new() { "hamGuard", "hamGuard" }
                    });
                }

                // Lumbridge Swamp
                {
                    int index = 0;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the water is the Wizard Tower island, the tower spearing up into the clouds. The path out to just south of Draynor Village is clearly visible from this part of the swamp.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorOutskirtsSouth"),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant" }
                    });

                    index = 1;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close. A small fence separates the swamp from the area behind Lumbridge Castle to the north.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "goblin", "frogBig", "frogBig" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 2;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close. A small fence separates the swamp from the area behind Lumbridge Castle to the north.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frogBig", "frogBig" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 3;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close. A small fence separates the swamp from the area behind Lumbridge Castle to the north.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frogBig", "frogBig", "frogGiant" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 4;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close. A small fence separates the swamp from the area behind Lumbridge Castle to the north.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frog" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 5;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the river is the desert town of Al Kharid, and there are trees such that you could probably grapple across here with the right tools and skills.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeGraveyard"),
                            new Connection("DES_AlKharidBank", new() { new("Item", 1, "grapple", false), new("Skill", 37, "Ranged"), new("Skill", 8, "Agility"), new("Skill", 19, "Strength") }, alt: "(Grapple Across River)"),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        }
                    });

                    index = 6;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the water is the Wizard Tower island, the tower spearing up into the clouds.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "frog", "frog", "frog" }
                    });

                    index = 7;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close. There is a tree here with a dark hole at the base. With a rope you could climb down, but you should probably also have a light of some kind.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveEntrance", new() { new("Item", 1, "rope", true), new("Data", 1, "SwampCaveRope", false, "equals", "Already attached rope.") }, true) { WorldStateChange = "set", WorldStateID = "SwampCaveRope", WorldStateNum = 1 },
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frog" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) },
                        NPCsHere = new() { "mistLumCandles" }
                    });

                    index = 8;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frog" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 9;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close. There's a small wooden shed here.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwampShed"),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frogGiant", "frogGiant" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 10;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frog", "frogBig", "frogBig" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 11;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the river is the desert town of Al Kharid. Fish seem to be gathering at a few spots along the banks.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "fishNetSmall", "fishNetSmall", "fishBaitLow", "fishBaitLow" } 
                    });

                    index = 12;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the water is the Wizard Tower island, the tower spearing up into the clouds.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead" }
                    });

                    index = 13;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        AreaMonsters = new() { "ratGiant", "ratGiant" }
                    });

                    index = 14;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close. An ancient stone altar emits a mysterious blue light here, surrounded by some crumbling stone pillars.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("RunecraftAltarWater", new() { new("Item", 1, "talismanWater", false) }),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead", "treeDead" }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frog", "frogBig", "frogBig" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 15;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {  
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frog" },
                        ItemSpawns = new() { new("swampTar", 1, null, 3) }
                    });

                    index = 16;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp", "Misthalin") {
                        Description = "The ground here is spongy and the footing unstable due to all the moisture. A constant shroud of fog and darkness hangs over this place, making it very hard to see where you're going. Puddles of stagnant water are everywhere and the trees press close.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {  
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant", "frog", "frog", "frog", "frogBig", "frogBig" }
                    });

                    index = 17;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the river is the desert town of Al Kharid. Fish seem to be gathering at a few spots along the banks.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "treeDead", "treeDead", "treeDead", "treeDead", "fishNetSmall", "fishNetSmall", "fishBaitLow", "fishBaitLow" } 
                    });

                    index = 18;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the water is the Wizard Tower island, the tower spearing up into the clouds. There's a small mine here offering a few useful ore nodes.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "oreIron", "oreIron", "oreIron", "oreCoal", "oreCoal", "oreCoal", "oreMithril", "oreMithril", "oreAdamant", "oreAdamant" },
                        ItemSpawns = new() { new("seaweed", 1) }
                    });

                    index = 19;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. This part of the coast borders a bay, and both the Wizard Tower and part of the desert to the south are visible here.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        ItemSpawns = new() { new("seaweed", 1) }
                    });

                    index = 20;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. This part of the coast borders a bay, and both the Wizard Tower and part of the desert to the south are visible here.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        ItemSpawns = new() { new("seaweed", 1) }
                    });

                    index = 21;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. This part of the coast borders a bay, and both the Wizard Tower and part of the desert to the south are visible here. A small wooden shack is on the coast. Seems like a terrible place to live, unless you're seeking isolation from anyone who might pass by.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwampUrhney"),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        ItemSpawns = new() { new("seaweed", 1) }
                    });

                    index = 22;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. This part of the coast borders a bay, and both the Wizard Tower and part of the desert to the south are visible here.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        }, 
                        AreaMonsters = new() { "ratGiant", "ratGiant" },
                        ItemSpawns = new() { new("seaweed", 1) }
                    });
                 
                    index = 23;
                    locsToAdd.Add(new Location("MIST_LumbridgeSwamp" + index, "Lumbridge Swamp Coast", "Misthalin") {
                        Description = "The marshy ground of the swamp fades to the sand and harder packed dirt of the river banks here. Across the water is the Wizard Tower island, the tower spearing up into the clouds. There's a small mine here offering a few useful ore nodes.",
                        MazeTile = index, MazeMap = "Lumbridge Swamp", MazeLandmark = true,
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 0, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -1, 0, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, -1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, 2, 1, 6, 4)),
                            new Connection("MIST_LumbridgeSwamp" + Helper.MapSpot(index, -2, 1, 6, 4)),
                        },
                        GatheringSpots = new() { "oreCopper", "oreCopper", "oreCopper", "oreTin", "oreTin", "oreTin", "rockClay", "rockClay" },
                        ItemSpawns = new() { new("seaweed", 1) }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampUrhney", "Father Urhney's Shack", "Misthalin") {
                        Description = "Despite being located in a swamp, the inside of this shack is very cozy. It is well lit by torches with a nice rug spread on the floor. There are some crates and barrels stacked against the walls. One bookshelf holds various dishes and cooking implements, while two others are stuffed with ragged books. There's a desk with a spare pair of leather gloves on it and a padded chair to sit while you work, plus a rocking chair in the corner and a small but comfortable cot in another corner. A portrait of a mysterious figure hangs on one wall.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp21")
                        },
                        ItemSpawns = new() { new("vambracesLeather", 1) }, 
                        NPCsHere = new() { "mistLumUrhney" },
                        GatheringSpots = new() { "clueBookcase" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampShed", "Swamp Shed", "Misthalin") {
                        Description = "There's not really much in this shed, which appears to have been used to hold farming tools at some point. There's still a spade here among the empty crates, barrels, and sacks. A shelf is pushed up against one wall but holds nothing. A few windows look out onto the... beautiful... surroundings and let in all that lovely swampy air.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_LumbridgeSwamp9"),
                            new Connection("MIST_Zanaris")
                        },
                        ItemSpawns = new() { new("shovel", 1) },
                        GatheringSpots = new() { "clueCrates" }
                    });
                }

                // Lumbridge Swamp Cave
                {
                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveEntrance", "Lumbridge Swamp Cave Entrance", "Misthalin") {
                        Description = "A very dim and disgusting underground cave. There aren't any pools of muck or monsters here but you can already smell the swamp gas getting stronger. There's a narrow passage you can squeeze through to get into a larger cavern, and your rope is dangling down from the surface. The hole is so far up that what little light it provides isn't illuminating anything down here.",
                        DungeoneeringLevel = 20, Dark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp7"),
                            new Connection("MIST_LumbridgeSwampCaveCavern") // TODO: Add wall beasts that hurt you if you aren't wearing a spiky helm or whatever
                        }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveCavern", "Lumbridge Swamp Cavern", "Misthalin") {
                        Description = "This part of the cavern branches off with tunnels in a few directions, the monsters that reside here largely leaving eachothers territory alone. There are a few pools of stagnant muck you need to avoid falling in, for the good of your equipment. One passage leading off the cavern - little more than a crack - leads towards the entrance of the caves.",
                        DungeoneeringLevel = 20, Dark = true, Hazard = "Gas",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveEntrance"),
                            new Connection("MIST_LumbridgeSwampCaveFrog"),
                            new Connection("MIST_LumbridgeSwampCaveBug"),
                            new Connection("MIST_LumbridgeSwampCaveSlime"),
                            new Connection("MIST_LumbridgeSwampCaveCrawler"),
                            new Connection("MIST_LumbridgeSwampCaveSlug"),
                            new Connection("MIST_LumbridgeSwampCaveSecondary")
                        }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveFrog", "Lumbridge Swamp Cave - Spawning Ground", "Misthalin") {
                        Description = "A small dank part of the cavern system largely dominated by a large pond that the hordes of frogs here appear to be spawning in. Their croaks bounce off the walls and echo to create a deafening cacophany that is quite unpleasant.",
                        DungeoneeringLevel = 20, Dark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveCavern")
                        },
                        AreaMonsters = new() { "frog", "frog", "frogBig24", "frogBig24", "frogBig24", "frogBig24", "frogGiant99" },
                        GatheringSpots = new() { "fishNetSmallCave", "fishNetSmallCave" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveBug", "Lumbridge Swamp Cave - Bug Hive", "Misthalin") {
                        Description = "This part of the cave is crawling with cave bugs roaming around on every surface, periodically coming out of or going into a big pile that looks sort of like an anthill. In addition to the passage leading back to the main cavern, there is a smaller passage leading to part of a mine.",
                        DungeoneeringLevel = 20, Dark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveCavern"),
                            new Connection("MIST_DorgeshuunMine")
                        },
                        AreaMonsters = new() { "caveBug", "caveBug", "caveBug", "caveBug", "caveBug" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveSlime", "Lumbridge Swamp Cave - Slime Pit", "Misthalin") {
                        Description = "Less of a room or cavern or even a tunnel, this is more of a dent in the ground swarming with living blobs of slime oozing around. The smell of swamp gas is particularly strong here, giving you a feeling that these slimes may be at least partially responsible for the miasma.",
                        DungeoneeringLevel = 20, Dark = true, Hazard = "Gas",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveCavern")
                        },
                        AreaMonsters = new() { "caveSlime", "caveSlime", "caveSlime", "caveSlime", "caveSlime" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveCrawler", "Lumbridge Swamp Cave - Crawler Den", "Misthalin") {
                        Description = "The cave crawlers appear to have laid claim to one of the larger ponds in the area, sliding in and out of it as they patrol their territory. Even without getting close you can see the poison dripping from their slavering maws, and the barbed spines coming from their backs seem like they'd hurt to get stuck with.",
                        DungeoneeringLevel = 20, Dark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveCavern")
                        },
                        AreaMonsters = new() { "caveBug", "caveBug", "caveBug" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveSlug", "Lumbridge Swamp Cave - Crawler Den", "Misthalin") {
                        Description = "This territory in the caves is at least slightly cleaner than the others, by virtue of a lack of water features and the resident monster being slugs composed mostly of rocks. You still can't fathom why Father Urhney would want to live anywhere near this, but it's a nice reprieve from how disgusting the rest of the cave has been. Besides the large passage leading to the main cavern, there is a smaller passage leading somewhere deeper in the caves.",
                        DungeoneeringLevel = 20, Dark = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveCavern")
                        },
                        AreaMonsters = new() { "rockSlug", "rockSlug", "rockSlug" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeSwampCaveSecondary", "Lumbridge Swamp Cave - Secondary Cavern", "Misthalin") {
                        Description = "This farther back section of the cave is quite distant from the exit at this point, and a cave goblin seems to be here minding a writhing pool of eels. The smell of swamp gas is quite strong back here.",
                        DungeoneeringLevel = 20, Dark = true, Hazard = "Gas",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwampCaveCavern")
                        },
                        AreaMonsters = new() { "goblinCave", "caveSlime" },
                        GatheringSpots = new() { "fishBaitLowCave", "fishBaitLowCave" }
                    });
                }

                // Draynor Village
                {
                    locsToAdd.Add(new Location("MIST_DraynorOutskirtsSouth", "Between Draynor and Lumbridge", "Misthalin") {
                        Description = "Just outside Draynor Village on the path leading from there to Lumbridge. The path winds back and forth between the small hills of the countryside. A smaller path branches off and leads towards the Wizard's Tower. Closer to Draynor, just off the path, is the old jail building. There are a few willow trees here and some fish swarming near the coast.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorVillage"),
                            new Connection("MIST_DraynorJail"),
                            new Connection("MIST_WizardTowerBridge"),
                            new Connection("MIST_LumbridgeTowardsDraynor"),
                            new Connection("MIST_LumbridgeSwamp0")
                        },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine" },
                        AreaMonsters = new() { "spiderGiant", "spiderGiant", "goblin", "goblin", "goblin" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTowerBridge", "Wizard's Tower Bridge", "Misthalin") {
                        Description = "On the large wide path from the Wizard Tower island to mainland Misthalin. There are a few banners hanging from poles, and some crates left partway down the bridge. The marble Wizard Tower spears into the sky above you, visible from far and wide.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTowerIsland"),
                            new Connection("MIST_DraynorOutskirtsSouth")
                        },
                        GatheringSpots = new() { "clueCrates" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTowerIsland", "Wizard's Tower Island", "Misthalin") {
                        Description = "This island holds the Wizard's Tower, towering high above you. Two statues of famous wizards of old stand guard at the bridge entrance, while a fountain is just off the path into the tower. There is some sparse tree and shrub coverage on the island but otherwise not a lot of interest.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower"),
                            new Connection("MIST_WizardTowerBridge")
                        },
                        GatheringSpots = new() { "treePine", "treePine" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTower", "Wizard's Tower", "Misthalin") {
                        Description = "Wizards bustle about in here in the midst of completing various magical research projects. There are a few small rooms here on the first floor, plus a staircase up to the next floor and a ladder down to the basement. One of the rooms contains a library with some bookshelves containing various books that are probably very interesting if you're a wizard doing research.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower2F"),
                            new Connection("MIST_WizardTowerBasement", alt: "(Climb Ladder)"),
                            new Connection("MIST_WizardTowerIsland")
                        },
                        GatheringSpots = new() { "bookshelfWizard", "bookshelfWizard", "bookshelfWizard" },
                        NPCsHere = new() { "mistWizOnglewip" },
                        ItemSpawns = new() { new("bootsLeather", 1), new("logPine", 1) },
                        AreaMonsters = new() { "wizard", "wizard", "wizard", "wizard" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTower2F", "Wizard's Tower - Second Floor", "Misthalin") {
                        Description = "This floor of the tower seems to be more of a sleeping area than the research areas below or above, with some cots placed in the rooms for weary wizards. There's not much else in here except a nice view through the windows looking out onto the surrounding landscape.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower3F"),
                            new Connection("MIST_WizardTower")
                        },
                        NPCsHere = new() { "mistWizTraiborn", "mistWizJalarast" },
                        AreaMonsters = new() { "wizard", "wizard" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTower3F", "Wizard's Tower - Third Floor", "Misthalin") {
                        Description = "A decent portion of this floor is taken up by a large cage holding a lesser demon captive inside it. Though you can't reach it with melee attacks, you could probably hit it with ranged and magic attacks without it being able to retaliate. Slightly cruel, but it's a demon, so it's probably okay? There are also some high-ranking wizards up here busying themselves in their offices with various works. Illegible research notes cover a few of the tables up here.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower2F")
                        },
                        NPCsHere = new() { "mistWizMizgog", "mistWizGrayzag" },
                        AreaMonsters = new() { "wizDemonLesser", "wizard", "wizard" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTowerBasement", "Wizard's Tower - Third Floor", "Misthalin") {
                        Description = "A decent portion of this floor is taken up by a large cage holding a lesser demon captive inside it. Though you can't reach it with melee attacks, you could probably hit it with ranged and magic attacks without it being able to retaliate. Slightly cruel, but it's a demon, so it's probably okay? There are also some high-ranking wizards up here busying themselves in their offices with various works. Illegible research notes cover a few of the tables up here.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower2F")
                        },
                        NPCsHere = new() { "mistWizSedridor" },
                        AreaMonsters = new() { "chicken", "mistWizSkeleton" },
                        GatheringSpots = new() { "mistWizAltar" }
                    });
                }


                // Varrock Locations
                {
                    locsToAdd.Add(new Location("MIST_VarrockCrossroadsSouth", "Varrock - South Crossroads", "Misthalin") {
                        Description = "A crossroads leading between Varrock, Lumbridge, Al Kharid, and the Digsite. There's a broken cart of a traveling trader here, but it seems to contain suspiciously little of value for a traveling trader. A few tables are placed haphazardly near the crossroads for some reason but there is otherwise little here besides some trees and grass.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockOutskirtsSouth"),
                            new Connection("MIST_VarrockGowerFarm"),
                            new Connection("MIST_VarrockMineEast"),
                            new Connection("MIST_VarrockCrossroadsEast"),
                            new Connection("DES_AlKharidMineOutside"),
                            new Connection("MIST_GroatsFarm")
                        },
                        NPCsHere = new() { "mistVarBurgiss", "mistVarAliLeaflet" },
                        AreaMonsters = new() { "goblin", "unicorn", "unicorn" },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine", "treePine", "treePine" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockGowerFarm", "Varrock - Gower Farm", "Misthalin") {
                        Description = "This is a small fenced in farmstead with a... giant rat pen? And a pond with some swans in it. There are a handful of troughs placed around the pen and a small grove of trees growing on the north side of the farmhouse. A path up the side of the farm leads to the Varrock East Mine.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockMineEast"),
                            new Connection("MIST_VarrockOutskirtsSouth"),
                            new Connection("MIST_VarrockCrossroadsSouth")
                        },
                        NPCsHere = new() { "farmerMaster" },
                        AreaMonsters = new() { "ratGiant", "ratGiant", "ratGiant", "ratGiant" },
                        GatheringSpots = new() { "treeWillow", "treeWillow", "treeMaple", "treeMaple", "treeMaple", "treeMaple", "treeYew", "treeElder", "plantCabbage", "plantCabbage" },
                        ProcessingStations = new() { "Sink", "Spinning Wheel", "Dairy Churn" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockMineEast", "Varrock - East Mine", "Misthalin") {
                        Description = "A small divot in the ground fenced in on three sides by a wooden fence. There are a few types of ores available here, plus a giant rat and a black bear wandering around a little outside the fence. A path passes by one side leading south to the Varrock South Crossroads and north to the Varrock East Crossroads.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockOutskirtsSouth"),
                            new Connection("MIST_VarrockCrossroadsEast"),
                            new Connection("MIST_VarrockGowerFarm"),
                            new Connection("MIST_VarrockCrossroadsSouth")
                        }, 
                        AreaMonsters = new() { "ratGiant", "bearBlack" },
                        GatheringSpots = new() { "oreCopper", "oreCopper", "oreTin", "oreTin", "oreIron", "oreIron", "oreMithril", "oreMithril", "oreMithril", "oreAdamant" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockOutskirtsSouth", "Varrock - Outskirts South", "Misthalin") {
                        Description = "Just outside the southern gates into the city of Varrock. For some reason some dark wizards are allowed to congregate at a small ritual stite, consisting of some stone pillars around a low table that might be a sacrificial altar. The stone walls surrounding the city are imposing, giving a feeling of security and civilization. You could enter through the gate, or skirt up around the west side of the city walls by passing through the mine.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_VarrockMineWest"),
                            new Connection("MIST_VarrockMineEast"),
                            new Connection("MIST_VarrockGuildChampions"),
                            new Connection("MIST_VarrockGowerFarm"),
                            new Connection("MIST_VarrockCrossroadsSouth")
                        }, 
                        NPCsHere = new() { "guard", "guard", "guard" },
                        AreaMonsters = new() { "guard", "guard", "guard", "wizardDark7", "wizardDark7", "wizardDark7", "wizardDark20", "wizardDark20" },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine", "treeOak", "treeOak", "plantNettles" }
                    }); 

                    locsToAdd.Add(new Location("MIST_VarrockMineWest", "Varrock - West Mine", "Misthalin") {
                        Description = "A small mine dug into the side of a hill, exposing some ores. There's a canoe station here to travel up and down the River Lum, the Champion's Guild, and a patch to grow bushes in. You could skirt up around the west side of the city walls.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockCrossroadsWest"), 
                            new Connection("MIST_VarrockGuildChampions"),
                            new Connection("MIST_VarrockOutskirtsSouth"),
                            new Connection("MIST_LumbridgeAcrossLum", null, false, 30, "Woodcutting", "(Canoe to Lumbridge)", false, 12),
                            new Connection("MIST_BarbarianVillage", null, false, 30, "Woodcutting", "(Canoe to Barbarian Village)", false, 12),
                            new Connection("MIST_Edgeville", null, false, 60, "Woodcutting", "(Canoe to Edgeville)", false, 27),
                            new Connection("WILD_FeroxEnclave", null, false, 150, "Woodcutting", "(Canoe to Ferox Enclave)", false, 57),
                            new Connection("WILD_WildernessPond", null, false, 150, "Woodcutting", "(Canoe to Wilderness Pond)", false, 57)
                        }, 
                        FarmingPatchesHere = new() { "MIST_VarBush" },
                        GatheringSpots = new() { "oreCopper", "oreCopper", "oreCopper", "oreTin", "oreTin", "oreIron", "oreIron", "oreIron", "oreIron", "oreMithril", "oreMithril", "oreMithril" }
                    }); 

                    locsToAdd.Add(new Location("MIST_VarrockCrossroadsWest", "Varrock - West Crossroads", "Misthalin") {
                        Description = "Just outside the western gates into the city of Varrock. There are a variety of buildings outside the walls here, including the Cook's Guild and a path to the Grand Exchange. Gertrude also lives here, across the road from the Leptoc Mansion, and there's a small locked shack. A bridge to the west leads to Barbarian Village. You could also pass through the gates into Varrock proper.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockWest"),
                            new Connection("MIST_VarrockGuildCooks", new() { new("Wearing", 1, "chefHat", false), new("Skill", 32, "Cooking") }),
                            new Connection("MIST_VarrockGrandExchange"),
                            new Connection("MIST_VarrockGertrude"),
                            new Connection("MIST_VarrockLeptocMansion"),
                            new Connection("MIST_VarrockGiantShack", new() { new("Item", 1, "keyVarrockShack", false) }),
                            new Connection("MIST_VarrockOutlawCamp"),
                            new Connection("MIST_BarbarianVillage"),
                            new Connection("MIST_VarrockMineWest")
                            // TODO: There can be a portal to Puro Puro in the wheat field here, add that later when Puro Puro is added
                        }, 
                        NPCsHere = new() { "guard", "guard", "guard", "dogStray" },
                        AreaMonsters = new() { "guard", "guard", "guard" },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine", "treeOak", "treeOak", "plantGrain", "plantGrain" }
                    });  

                    locsToAdd.Add(new Location("MIST_VarrockGuildCooks", "Cook's Guild", "Misthalin") {
                        Description = "A guild for master chefs... or at least chefs with a proper hat. The upper floors extend up to a windmill gearing system, allowing you to grind grain to flour inside the building. There are numerous free items for chefs to use, and some facilities to help with the cooking process. Romily Weaklax offers a selection of pies in his shop, and the Head Chef could sell you the Cooking Cape of Accomplishment if you have truly mastered the art of cooking.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockGuildCooksVIP", new() { new("Skill", 99, "Cooking"), new("DiaryComplete", 1, "Varrock", misc3: "Hard") }, true),
                            new Connection("MIST_VarrockCrossroadsWest")
                        },
                        ItemSpawns = new() { new("chocolateBar", 5), new("pieEmpty", 1), new("tinCakeEmpty", 1), new("bowlEmpty", 1), new("fruitApple", 3, count: 3), new("grapes", 5), new("potEmpty", 1), new("jugEmpty", 1) },
                        ProcessingStations = new() { "Windmill", "Sink", "Dairy Churn" },
                        NPCsHere = new() { "mistVarRomily", "mistVarHeadChef" },
                        ShopItemsHere = new() { "bookRecipesPie", "pieRedberry", "pieMeat", "pieMud", "pieApple", "pieGarden", "pieFish", "pieAdmiral", "pieWild", "pieSummer" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockGuildCooksVIP", "Cook's Guild - VIP Area", "Misthalin") {
                        Description = "A luxury VIP area for true master chefs, or anyone to have earned the privilege by completing many tasks around Varrock. Okay it's not actually that luxurious, this is really just a small extra room off the main Guild room where there's a range and a bank.",
                        IsBank = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockGuildCooks")
                        },
                        ProcessingStations = new() { "Range" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockCrossroadsEast", "Varrock - East Crossroads", "Misthalin") {
                        Description = "Just outside the eastern gates into the city of Varrock. There are a variety of buildings outside the walls here, including the Cook's Guild and a path to the Grand Exchange. Gertrude also lives here, across the road from the Leptoc Mansion, and there's a small locked shack. A bridge to the west leads to Barbarian Village. You could also pass through the gates into Varrock proper.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockEast"),
                            new Connection("MIST_VarrockJollyBoar"),
                            new Connection("MIST_VarrockLumberyard"),
                            new Connection("RunecraftAltarEarth", new() { new("Item", 1, "talismanEarth", false) }),
                            new Connection("MIST_VarrockChaosTunnel", new() { new("Quest", 10, "MI_WhatLiesBelow", false) }),
                            new Connection("MIST_Silvarea"),
                            new Connection("MIST_Digsite"),
                            new Connection("MIST_VarrockMineEast"),
                            new Connection("MIST_VarrockCrossroadsSouth")
                        }, 
                        NPCsHere = new() { "mistVarAnnaJones", "guard", "guard", "guard" },
                        AreaMonsters = new() { "guard", "guard", "guard", "imp" },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine", "treeOak", "treeOak", "treeYew", "treeYew" }
                    });
                }

                // Barbarian Village and Stronghold of Security
                {
                    locsToAdd.Add(new Location("MIST_BarbarianVillage", "Barbarian Village", "Misthalin") {
                        Description = "Sometimes also called Grunnarsgrunn, or Gunnar's Ground, this is a village inhabited by barbarians just south of Edgeville and west of Varrock on the River Lum. Outside the crude palisade is a lookout tower, and a perpetual fire next to the fishing spots on the river. Inside the walls are a few buildings, including a helmet shop, a pottery studio, a storage hut, and a longhall. Surrounded by ore rocks in the center of the village is a hole leading down into the Stronghold of Security.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_BetweenEdgevilleBarbarian"),
                            new Connection("MIST_BarbarianLonghall"),
                            new Connection("MIST_BarbarianPeksa"),
                            new Connection("MIST_BarbarianLookout"),
                            new Connection("MIST_StrongholdSecurity1Entrance"),
                            new Connection("MIST_VarrockCrossroadsWest"),
                            new Connection("MIST_BetweenBarbarianDraynor"),
                            new Connection("MIST_LumbridgeAcrossLum", null, false, 60, "Woodcutting", "(Canoe to Lumbridge)", false, 27),
                            new Connection("MIST_VarrockMineWest", null, false, 30, "Woodcutting", "(Canoe to the Champion's Guild)", false, 12),
                            new Connection("MIST_Edgeville", null, false, 30, "Woodcutting", "(Canoe to Edgeville)", false, 12),
                            new Connection("WILD_FeroxEnclave", null, false, 150, "Woodcutting", "(Canoe to Ferox Enclave)", false, 57),
                            new Connection("WILD_WildernessPond", null, false, 150, "Woodcutting", "(Canoe to Wilderness Pond)", false, 57)
                        }, 
                        ItemSpawns = new() { new("pickaxeBronze", 1) },
                        AreaMonsters = new() { "barbarian9", "barbarian9", "barbarian9", "barbarian10", "barbarian10", "unicorn" },
                        ProcessingStations = new() { "Spinning Wheel", "Pottery Wheel", "Pottery Kiln" },
                        GatheringSpots = new() { "clueChest", "treePine", "treePine", "treeOak", "oreTin", "oreTin", "oreCoal", "oreCoal", "fishBaitLow", "fishBaitLow", "fishLure", "fishLure" }
                    }); 

                    locsToAdd.Add(new Location("MIST_BarbarianPeksa", "Peksa's Helmet Shop", "Misthalin") {
                        Description = "A small storefront with a variety of helmets on sale, some of them hanging on the wall for display. There's a fire burning in the middle of the room, plus some shelves and tables stacked with goods against the walls. There are a couple crates stacked in one corner.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_BarbarianVillage")
                        }, 
                        ShopItemsHere = new() { "helmBronze", "helmIron", "helmSteel", "helmMithril", "helmAdamant" },
                        ItemSpawns = new() { new("potEmpty", 1) },
                        ProcessingStations = new() { "Fire" },
                        NPCsHere = new() { "mistBarbPeksa" },
                        GatheringSpots = new() { "clueCrates" }
                    });

                    locsToAdd.Add(new Location("MIST_BarbarianLonghall", "The Long Hall", "Misthalin") {
                        Description = "A longhall - or maybe a tavern called 'The Long Hall'? - filled with barbarians. There are two long rows of tables with some stools placed haphazardly next to them. At the very back of the hall are two fires you could cook with, and some crates in one corner. Some unattended bits of meat and beer are on the tables. A stuffed bull's head hangs above the fires, and there's a keg full of beer in another corner of the hall.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_BarbarianVillage")
                        },  
                        AreaMonsters = new() { "barbarian15", "barbarian15", "barbarian15", "barbarian17", "barbarian17", "barbarianGunthor" },
                        ItemSpawns = new() { new("beer", 3, count: 3), new("meatCookedBeef", 3, count: 2) },
                        ProcessingStations = new() { "Fire", "Beer Keg" }
                    });

                    locsToAdd.Add(new Location("MIST_BarbarianLookout", "Barbarian Village - Lookout Tower", "Misthalin") {
                        Description = "The view from up here is excellent, allowing you to see Edgeville in the north, Varrock in the east, Draynor manor and village in the south, and Falador distantly in the west. Inside the tower are a bunch of crates and a few ominous jail cells, plus some chests behind a locked grate.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_BarbarianVillage")
                        },
                        NPCsHere = new() { "mistBarbHunding" }
                    });
                }
            }


            // Desert Locations
            {
                // Al Kharid / North of Shantay Pass
                {
                    locsToAdd.Add(new Location("DES_AlKharidBank", "Al Kharid Bank", "Desert") {
                        Description = "A nice white stone building on the banks of the River Lum containing the Al Kharid bank. There are some palm trees and cacti outside the building, while the inside is crowded with bank booths, chairs, and a table. Behind the row of bank booths stand tellers ready to assist customers, plus a few desks covered in ledgers and scales.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeSwamp5", new() { new("Item", 1, "grapple", false), new("Skill", 37, "Ranged"), new("Skill", 8, "Agility"), new("Skill", 19, "Strength") }, alt: "(Grapple Across River)"),
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidSouth")
                        },
                        IsBank = true
                    });

                    locsToAdd.Add(new Location("DES_AlKharid", "Al Kharid", "Desert") {
                        Description = "A sort of plaza, relatively centrally located in front of the palace. There are a variety of useful stores and services offered here, in addition to a set of handholds to climb up onto the roofs to train agility. The ground here is fairly hard packed sand, with a more defined path leading from the palace through the plaza and off to the north. There are a few stalls offering goods, but they are being watched too closely to be stolen from.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharidOutskirts"),
                            new Connection("DES_AlKharidAgility1", new() { new("Skill", 20, "Agility") }, false, 12, "Agility"),
                            new Connection("DES_AlKharidBank"),
                            new Connection("DES_AlKharidZeke"),
                            new Connection("DES_AlKharidDommik"),
                            new Connection("DES_AlKharidGeneralStore"),
                            new Connection("DES_AlKharidLouie"),
                            new Connection("DES_AlKharidRanael"),
                            new Connection("DES_AlKharidKebab"),
                            new Connection("DES_AlKharidAli1"),
                            new Connection("DES_AlKharidTanner"),
                            new Connection("DES_AlKharidHouse"),
                            new Connection("DES_AlKharidTent"), 
                            new Connection("DES_AlKharidPalaceCourtyard"),
                            new Connection("DES_AlKharidSouth")
                        },
                        ProcessingStations = new() { "Sand" },
                        NPCsHere = new() { "desAlKharidAyesha", "man", "man", "man", "man", "woman", "woman", "woman" },
                        ShopItemsHere = new() { "bucketCompost", "plantPotEmpty", "uncutSapphire", "uncutEmerald", "uncutRuby", "uncutDiamond", "cutSapphire", "cutEmerald", "cutRuby", "cutDiamond", "clothSilk" }, 
                        FarmingPatchesHere = new() { "DES_AlKharidCactus" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidZeke", "Zeke's Superior Scimitars", "Desert") {
                        Description = "A cramped storefront owned and operated by Zeke. There are a few small rugs on the floor and some potted plants to make the place feel a little more inviting. Some crates are stacked against one wall, with a shelf holding boxes of scimitars against another wall. A table is placed a little off the center of the room but appears to be unused.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "desAlKharidZeke" },
                        ShopItemsHere = new() { "scimitarBronze", "scimitarIron", "scimitarSteel", "scimitarBlack", "scimitarMithril", "scimitarAdamant" },
                        GatheringSpots = new() { "clueCrates" },
                        ItemSpawns = new() { new("runeBody", 1) }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidDommik", "Dommik's Crafting Store", "Desert") {
                        Description = "A cramped storefront owned and operated by Dommik. There are a few small rugs on the floor and some potted plants to make the place feel a little more inviting. Many shelves line the walls filled with various crafting bits and bobs. A table is placed a little off the center of the room and acts as both the store counter and a place for Dommik to work on projects.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "desAlKharidDommik" },
                        ShopItemsHere = new() { "glassblowingPipe", "chisel", "mouldRing", "mouldNecklace", "mouldAmulet", "needle", "mouldHoly", "mouldSickle", "mouldTiara", "mouldBolt", "mouldBracelet" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidGeneralStore", "Al Kharid General Store", "Desert") {
                        Description = "A cramped storefront owned and operated by Dommik. There are a few small rugs on the floor and some potted plants to make the place feel a little more inviting. Many shelves line the walls filled with various goods and sundry. There are a few stacks of crates holding even more inventory. A table is placed a little off the center of the room and acts as the store counter.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "desAlKharidShopkeeper" },
                        ShopItemsHere = new() { "potEmpty", "jugEmpty", "shears", "bucketEmpty", "bowlEmpty", "tinCakeEmpty", "tinderbox", "chisel", "hammer" },
                        GatheringSpots = new() { "clueCrates" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidLouie", "Louie's Armoured Legs Bazaar", "Desert") {
                        Description = "There is nothing more than a few shelves and stacks of crates in this very small building. This operation seems... more than a little sketchy.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "desAlKharidLouie" },
                        ShopItemsHere = new() { "platelegsBronze", "platelegsIron", "platelegsSteel", "platelegsBlack", "platelegsMithril", "platelegsAdamant" },
                        GatheringSpots = new() { "clueCrates" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidRanael", "Ranael's Super Skirt Store", "Desert") {
                        Description = "This is a lovely little shop with the inside covered in greenery, and some nice statues outside the door. The floor is actual stone, and there are some benches for customers waiting to purchase from Ranael. There's a nice large rug in front of the stone table that serves as the counter for the store.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidSouth")
                        },
                        NPCsHere = new() { "desAlKharidRanael" },
                        ShopItemsHere = new() { "plateskirtBronze", "plateskirtIron", "plateskirtSteel", "plateskirtBlack", "plateskirtMithril", "plateskirtAdamant" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidKebab", "Kebab Shop", "Desert") {
                        Description = "This shop is little more than a kitchen with barely enough room for Karim and yourself to stand in without being crowded. The kebabs he has on offer smell good, but some of them look a bit dodgy. You could probably use his range if you wanted.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "desAlKharidKarim" },
                        ProcessingStations = new() { "Range" },
                        ShopItemsHere = new() { "kebab" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidTanner", "Al Kharid Tannery", "Desert") {
                        Description = "The smell of the vats in here is absolutely dreadful. There are a few barrels, likely holding tanning chemicals, and some drying lines. Also a mangle, the vats, a table, and a chair in the corner of the room. There are some potted plants around the room in an attempt to lighten the place up but they're wilting in the miasma of the tanning process. ",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "desAlKharidEllis" },
                        ProcessingStations = new() { "Tannery" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAli1", "Ali's Discount Wares", "Desert") {
                        Description = "This is more of a stall than a dedicated storefront, but the way Ali Morrisane can draw and hold your attention with his rapid speech and sales tactics make the environment seem to fade away. He has a couple crates full of a variety of very different things of questionable use.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "desAlKharidAli" },
                        ProcessingStations = new() { "Sand" },
                        ShopItemsHere = new() { "potEmpty", "jugEmpty", "waterskin3", "desertShirt", "desertBoots", "bucketEmpty", "beardFake", "kharidianHeadpiece", "papyrus", "knife", "tinderbox", "pickaxeBronze", "meatRawChicken" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidHouse", "A House in Al Kharid", "Desert") {
                        Description = "A cozy little house with a bearskin rug on the floor. There are a few crates to store the man's belongings, along with a table and chairs to eat at. The only other things in the house are a range and a bedroll on the ground. There are a weirdly large number of windows opening to the outside. This building is not large enough to justify the eight windows it has.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        NPCsHere = new() { "man" },
                        ProcessingStations = new() { "Range" },
                        GatheringSpots = new() { "clueCrates" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidTent", "A Tent in Al Kharid", "Desert") {
                        Description = "Seems to be some kind of storage tent for one of the nearby vendors, or possible a shared storage space. There are some crates, boxes, a small table with two stools, an a couple potted plants. Also for some reason there's a chaise lounge. Looks comfortable.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid")
                        },
                        GatheringSpots = new() { "clueCrates", "clueBoxes" },
                        ItemSpawns = new() { new("bucketEmpty", 1) }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidSouth", "Al Kharid South", "Desert") {
                        Description = "Just south of the palace in Al Kharid. There's not a lot back here except sand, cacti, rocks, dead bushes, and more sand. ",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidBank"),
                            new Connection("DES_AlKharidRanael"),
                            new Connection("DES_AlKharidSorceress"),
                            new Connection("DES_GiantsPlateau"), // Should go to citharede abbey and emir's arena side entrance
                            new Connection("DES_ShantayPass")
                        },
                        NPCsHere = new() { "desAlKharidFerrymanSathwood" }, // TODO: Make this dude when wanting to implement Tempeross
                        ProcessingStations = new() { "Sand" },
                        AreaMonsters = new() { "scorpion" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidOutskirts", "Al Kharid Outskirts", "Desert") {
                        Description = "Just north of the town of Al Kharid. There are a few small ponds with trees and rocks surrounding them, and some cacti and dead bushes scattered around. To the north is the Al Kharid mine, to the east is the Emir's Arena, to the west is the gate to Lumbridge.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("MIST_LumbridgeAcrossLum"),
                            new Connection("DES_AlKharidMineOutside"),
                            new Connection("DES_AlKharidEmirsArena")
                        },
                        ProcessingStations = new() { "Sand" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidMineOutside", "Outside the Al Kharid Mine", "Desert") {
                        Description = "This is as close as you can safely get to the Al Kharid mine without potentially enraging the scorpions within. North from here is the crossroads just south of Varrock, while to the east is the Mage Training Arena. South leads to the outskirts of Al Kharid itself. There are many cacti, rocks, and dead bushes here. There's also a strange stone altar surrounded by crumbling pillars emitting a red light.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockCrossroadsSouth"),
                            new Connection("DES_MageTrainingArena"),
                            new Connection("DES_AlKharidMine"),
                            new Connection("DES_AlKharidOutskirts"),
                            new Connection("RunecraftAltarFire", new() { new("Item", 1, "talismanFire", false) })
                        },
                        ProcessingStations = new() { "Sand" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidMine", "Al Kharid Mine", "Desert") {
                        Description = "This place is crawling with scorpions, but there are a wide variety of ores available here. If it was harder to get out of the mine to the surrounding area, some of the rockslides on the sides of the mine would make for convenient handholds to climb out. ",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharidMineOutside")
                        },
                        AreaMonsters = new() { "scorpion", "scorpion", "scorpion", "scorpion", "scorpion", "scorpion" },
                        GatheringSpots = new() { "oreCopper", "oreCopper", "oreTin", "oreTin", "oreIron", "oreIron", "oreSilver", "oreSilver", "oreCoal", "oreCoal", "oreMithril", "oreMithril", "oreGold", "oreGold", "oreAdamant", "oreAdamant", "rockGemCommon", "rockGemCommon", "rockGemUncommon", "rockGemUncommon" },
                        ItemSpawns = new() { new("runeWater", 1), new("runeFire", 1) },
                        ProcessingStations = new() { "Sand" }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAgility1", "Al Kharid - Rooftop Agility Start", "Desert") {
                        Description = "The start of the Al Kharid Rooftop Agility Course, on top of the tannery. There is a tightrope leading over to the roof of the bank but it looks a little sketchy. If you fall off you could get hurt.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidAgility2", null, false, 36, "Agility", "(Walk Tightrope)", true, 20, "DES_AlKharid", 1, 5)
                        }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAgility2", "Al Kharid - Bank Roof", "Desert") {
                        Description = "Atop the Al Kharid bank. The view here is somewhat nice, overlooking the town of Al Kharid but also across the Lum into the swamp. There is a dubious looking rope swing that is supposed to somehow get you over to the roof of the palace.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidAgility3", null, false, 48, "Agility", "(Swing Rope)")
                        }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAgility3", "Al Kharid - Palace Roof", "Desert") {
                        Description = "Atop the Al Kharid palace. You get the feeling that you are probably not supposed to be up here, for the security of the Emir. On the other side of the building from where you landed with the rope swing is a zip line down to the roof of Ranael's Super Skirt Store.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidAgility4", null, false, 48, "Agility", "(Slide Down Zip Line)", true, 20, "DES_AlKharid", 1, 5)
                        }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAgility4", "Al Kharid - Ranael's Roof", "Desert") {
                        Description = "That zip line did *not* feel like it's been checked for safety by some kind of health inspector. You're on top of Ranael's Super Skirt Store right now, and there's yet another suspicious agility obstacle ahead. A palm tree with fronds that you hope are strong enough to swing across to Louie's Legs.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidAgility5", null, false, 12, "Agility", "(Tarzan It)")
                        }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAgility5", "Al Kharid - Louie's Roof", "Desert") {
                        Description = "Okay, that was actually pretty cool. You wonder for a second if anyone saw, but then remember nobody else is online. There are some beams sticking out of the adjoining roof to get up onto the General Store's part of the building.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidAgility6", null, false, 12, "Agility", "(Climb Beams)")
                        }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAgility6", "Al Kharid - General Store Roof", "Desert") {
                        Description = "Not quite as exciting as the other bits of the course, but the end is in sight. There's a tightrope across to the roof of a residential home. This one looks significantly safer than the earlier tightrope.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharidAgility7", null, false, 18, "Agility", "(Walk Tightrope)")
                        }
                    });

                    locsToAdd.Add(new Location("DES_AlKharidAgility7", "Al Kharid - House Roof", "Desert") {
                        Description = "The finish line! There's a small arrow-shaped sign here at the edge of the roof pointing down to the ground, indicating a spot near Zeke's Superior Scimitars as the landing spot.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharid"),
                            new Connection("DES_AlKharid", null, false, 36, "Agility", "(Hop Down)")
                        }
                    });

                    locsToAdd.Add(new Location("DES_MageTrainingArena", "Mage Training Arena", "Desert") {
                        Description = "This place certainly looks magical. There are a number of books and golems and brooms moving about the hall, and on the walls the paintings slowly move up and down. A huge white rug with an elaborate pattern covers much of the floor and there are some candelabras providing light. There are portals to the different training areas here.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_AlKharidMineOutside"),
                            new Connection("DES_MageTrainingArenaTelekinetic"),
                            new Connection("DES_MageTrainingArenaGraveyard"),
                            new Connection("DES_MageTrainingArenaEnchanting"),
                            new Connection("DES_MageTrainingArenaAlchemist")
                        },
                        NPCsHere = new() { "desMTAGuardianRewards" }
                    });

                    locsToAdd.Add(new Location("DES_MageTrainingArenaTelekinetic", "Telekinetic Theater", "Desert") {
                        Description = "The Telekinetic Theater is a large mostly empty room, with the center containing a fenced-in maze of walls. There is a statue you can cast Telekinetic Grab on to move in cardinal directions, and a clearly indicated tile that you need to move the statue onto. The Telekinetic Guardian stands observing the proceedings from opposite the portal.",
                        MinigameID = "MageTelekinetic",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_MageTrainingArena")
                        },
                        NPCsHere = new() { "desMTAGuardianTelekinetic" }
                    });

                    locsToAdd.Add(new Location("DES_MageTrainingArenaGraveyard", "Creature Graveyard", "Desert") {
                        Description = "The Creature Graveyard has four piles of bones, one in each corner of the square room. Strange bones, odd bones, weird bones, and unusual bones. No matter how many bones you take from the piles there always seems to be more available. Every five seconds bones fall from the ceiling and will damage you. The Graveyard Guardian stands observing the proceedings from opposite the portal.",
                        MinigameID = "MageGraveyard",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_MageTrainingArena", new() { new("NotItem", 1, "fruitBanana"), new("NotItem", 1, "fruitPeach"), new("NotItem", 1, "mtaBone1"), new("NotItem", 1, "mtaBone2"), new("NotItem", 1, "mtaBone3"), new("NotItem", 1, "mtaBone4") })
                        },
                        NPCsHere = new() { "desMTAGuardianGraveyard" },
                        ProcessingStations = new() { "Fruit Chute" },
                        GatheringSpots = new() { "mtaGraveyardStrange", "mtaGraveyardOdd", "mtaGraveyardWeird", "mtaGraveyardUnusual" }
                    });

                    locsToAdd.Add(new Location("DES_MageTrainingArenaEnchanting", "Enchanting Chamber", "Desert") {
                        Description = "The Enchanting Chamber has four piles of objects, one in each corner of the square room. Blue icosahedrons, yellow cubes, red pentamids, and green cylinders. No matter how many shapes you take from the piles there always seems to be more available. Every five seconds or so a dragonstone appears on the ground, or teleports to another place if you haven't picked it up. The Enchantment Guardian stands observing the proceedings from opposite the portal.",
                        MinigameID = "MageEnchanting",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_MageTrainingArena")
                        },
                        NPCsHere = new() { "desMTAGuardianEnchanting" },
                        ItemSpawns = new() { new("mtaDragonstone", 5) },
                        ProcessingStations = new() { "Orb Depository" },
                        GatheringSpots = new() { "mtaEnchantIcosahedron", "mtaEnchantCube", "mtaEnchantPentamid", "mtaEnchantCylinder" }
                    });

                    locsToAdd.Add(new Location("DES_MageTrainingArenaAlchemist", "Alchemist's Playground", "Desert") {
                        Description = "The Alchemist's Playground has five shelves of items, arranged in a loose circle around the center of the room. Leather boots, adamant kiteshields, adamant helmets, emeralds, and rune swords. No matter how many items you take from the shelves there always seems to be more available. The feeling of value you get from each item seems to change periodically. The Alchemy Guardian stands observing the proceedings from opposite the portal.",
                        MinigameID = "MageAlchemist",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("DES_MageTrainingArena", new() { new("NotItem", 1, "mtaAlchCoin"), new("NotItem", 1, "mtaAlch1"), new("NotItem", 1, "mtaAlch2"), new("NotItem", 1, "mtaAlch3"), new("NotItem", 1, "mtaAlch4"), new("NotItem", 1, "mtaAlch5") })
                        },
                        NPCsHere = new() { "desMTAGuardianAlchemy" },
                        ProcessingStations = new() { "Coin Slot" },
                        GatheringSpots = new() { "mtaAlchemyBoots", "mtaAlchemyShield", "mtaAlchemyHelmet", "mtaAlchemyEmerald", "mtaAlchemySword" }
                    });
                }
            }


            // Runecraft Altars
            {
                locsToAdd.Add(new Location("RunecraftAltarWater", "Altar of Water", "Elsewhere") { 
                    Description = "This appears to be some kind of strange pocket dimension contained outside of the normal plane of existence. A series of small inaccessible bits of land fill the water around the main island you're standing on, though the space appears to end not too far out from this main island. Four stone arches and four pillars with an orb emitting soft light circle a stone altar engraved with the symbol for water.",
                    ConnectedLocations = new List<Connection>() {
                        new Connection("MIST_LumbridgeSwamp14")
                    },
                    ProcessingStations = new List<string>() { "Water Altar" }
                });

                locsToAdd.Add(new Location("RunecraftAltarFire", "Altar of Fire", "Elsewhere") { 
                    Description = "This appears to be some kind of strange pocket dimension contained outside of the normal plane of existence. A series of small inaccessible bits of blasted rock fill the lava around the main island you're standing on, though the space appears to end not too far out from this main island. Four stone arches and four pillars with an orb emitting soft light circle a stone altar engraved with the symbol for fire.",
                    ConnectedLocations = new List<Connection>() {
                        new Connection("DES_AlKharidMineOutside")
                    },
                    ProcessingStations = new List<string>() { "Fire Altar" }
                });

                locsToAdd.Add(new Location("RunecraftAltarEarth", "Altar of Earth", "Elsewhere") { 
                    Description = "This appears to be some kind of strange pocket dimension contained outside of the normal plane of existence. It takes the form of a moderately sized cavern full of rocks of various shapes and sizes. Four stone arches and four pillars with an orb emitting soft light circle a stone altar engraved with the symbol for earth.",
                    ConnectedLocations = new List<Connection>() {
                        new Connection("MIST_VarrockCrossroadsEast")
                    },
                    ProcessingStations = new List<string>() { "Earth Altar" }
                });
            }


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
