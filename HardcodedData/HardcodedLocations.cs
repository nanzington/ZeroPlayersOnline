using ZeroPlayersOnline.DataTypes; 

namespace ZeroPlayersOnline.Hardcodes {
    public class HardcodedLocations {
        public static void InitLocs(Dictionary<string, Location> Atlas, Dictionary<string, GatheringTile> Gathers, Dictionary<string, AreaMonster> Monsters) {
            List<Location> locsToAdd = new();

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
                            NPCsHere = new() { "mistLumHans", "mistLumJacquelyn", "man", "man", "man", "woman", "woman" },
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
                        NPCsHere = new() { "mistLumAereck", "tutorPrayer", "woman" },
                        AreaMonsters = new() { "woman" }
                    }); 

                    locsToAdd.Add(new Location("MIST_LumbridgeGraveyard", "Lumbridge Graveyard", "Misthalin") {
                        Description = "A low fog clings to the ground around the headstones here. The graveyard is enclosed by a short wrought-iron fence, grass and weeds growing slightly rampant due to the lack of a gardener. An imposing building holds a mausoleum and the stairs down to the catacombs.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_Lumbridge"),
                            new Connection("MIST_LumbridgeCatacombsUpper", new() { new("QuestPast", 0, "MI_BloodPact", summ: "Must have started The Blood Pact.") }) { CutscenesOnTraverse = new() { "MI_BloodPact1" } },
                            new Connection("MIST_LumbridgeSwamp5")
                        },
                        NPCsHere = new() { "mistLumXenia", "mistLumXenia1", "mistLumXenia8", "mistLumXenia9", "mistLumRestlessGhost" },
                        GatheringSpots = new() { "treeYew", "mistLumCoffin" }
                    });

                    // Lumbridge Catacombs Maps
                    {
                        locsToAdd.Add(new Location("MIST_LumbridgeCatacombsUpper", "Catacombs - Upper Main Room", "Misthalin") {
                            Description = "The inside of the catacombs are surprisingly spacious. There are two main rows of sarcophagi in the middle of the hall, and various pots of offerings and remains everywhere. Set into some of the walls are more stone coffins, and there are Saradomin banners hanging from the walls.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_LumbridgeGraveyard"),
                                new Connection("MIST_LumbridgeCatacombsUpper", new() { new("QuestAt", 10, "MI_BloodPact") }, hideIfNoReqs: true) { CutscenesOnTraverse = new() { "MI_BloodPact2" } },
                                new Connection("MIST_LumbridgeCatacombsUpper1", new() { new("QuestPast", 20, "MI_BloodPact") }, hideIfNoReqs: true),
                                new Connection("MIST_CatacombsEntrance", new() { new("QuestPast", 80, "MI_BloodPact") }, hideIfNoReqs: true)
                            },
                            NPCsHere = new() { "mistLumXenia2", "mistLumXenia3" }
                        });

                        locsToAdd.Add(new Location("MIST_LumbridgeCatacombsUpper1", "Catacombs - Upper Main Room", "Misthalin") {
                            Description = "The inside of the catacombs are surprisingly spacious. There are two main rows of sarcophagi in the middle of the hall, and various pots of offerings and remains everywhere. Set into some of the walls are more stone coffins, and there are Saradomin banners hanging from the walls.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_LumbridgeGraveyard"),
                                new Connection("MIST_LumbridgeCatacombsUpper"),
                                new Connection("MIST_LumbridgeCatacombsUpper2", new() { new("QuestPast", 40, "MI_BloodPact", summ: "You must deal with the ranger before you advance further into the catacombs.") })
                            },
                            NPCsHere = new() { "mistLumXenia4", "mistLumXenia5", "mistLumKayle" },
                            AreaMonsters = new() { "questBloodPactKayle" },
                            ItemSpawns = new() { new("chargebowKayle", 1, new("QuestAt", 40, "MI_BloodPact")) }
                        });

                        locsToAdd.Add(new Location("MIST_LumbridgeCatacombsUpper2", "Catacombs - Upper Side Room", "Misthalin") {
                            Description = "This side room of the catacombs is, for some reason, essentially two large balconies facing eachother with a pit across the middle of the room. There are railings on either side of the hole that leads down, and the two halves of the room are connected by a walkway with a gate. ",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_LumbridgeCatacombsUpper1"),
                                new Connection("MIST_LumbridgeCatacombsUpper3", new() { new("Data", 1, "CatacombsWinch", misc3: "equals", summ: "You have to use the winch to get to the other side of the room.") })
                            },
                            NPCsHere = new() { "mistLumXenia6" },
                            GatheringSpots = new() { "mistLumWinch" },
                            AreaMonsters = new() { "questBloodPactCaitlin" }
                        });

                        locsToAdd.Add(new Location("MIST_LumbridgeCatacombsUpper3", "Catacombs - Upper Side Room - Across", "Misthalin") {
                            Description = "This side room of the catacombs is, for some reason, essentially two large balconies facing eachother with a pit across the middle of the room. There are railings on either side of the hole that leads down, and the two halves of the room are connected by a walkway with a gate. You are on the far side from the entrance.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_LumbridgeCatacombsUpper1"),
                                new Connection("MIST_LumbridgeCatacombsUpper2"),
                                new Connection("MIST_LumbridgeCatacombsLower", new() { new("QuestAt", 60, "MI_BloodPact", summ: "You should deal with the wizard before going downstairs.") }) { CutscenesOnTraverse = new() { "MI_BloodPact5" } },
                            },
                            NPCsHere = new() { "mistLumXenia7", "mistLumCaitlin" },
                            ItemSpawns = new() { new("staffCaitlin", 1, new("QuestAt", 60, "MI_BloodPact")) }
                        });

                        locsToAdd.Add(new Location("MIST_LumbridgeCatacombsLower", "Catacombs - Lower", "Misthalin") {
                            Description = "A large room supported by pillars, with banners hanging from the walls and more urns spread around the room in piles. One large sarcophagus, the resting place of Dragith Nurn, rests at the south end of the hall. Beneath a grate in the floor, some water flows through the center of the room.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_LumbridgeCatacombsUpper1"),
                                new Connection("MIST_LumbridgeCatacombsUpper2"),
                                new Connection("MIST_LumbridgeCatacombsUpper3"),
                                new Connection("MIST_CatacombsEntrance", new() { new("QuestPast", 100, "MI_BloodPact", summ: "You should take Ilona back to the surface and speak to Xenia before venturing into the dungeon.")})
                            },
                            NPCsHere = new() { "mistLumReese" },
                            GatheringSpots = new() { "mistLumIlona" },
                            ItemSpawns = new() { new("swordReese", 1, new("QuestAt", 80, "MI_BloodPact")) },
                            AreaMonsters = new() { "questBloodPactReese" }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsEntrance", "Catacombs - Dungeon Entrance", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The entrance to the catacombs, all clean stone tiles with torches to provide light. There's nothing here but the stairs back up and the path forward.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_LumbridgeGraveyard"),
                                new Connection("MIST_LumbridgeCatacombsUpper1"),
                                new Connection("MIST_LumbridgeCatacombsLower"),
                                new Connection("MIST_CatacombsRoom1")
                            }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom1", "Catacombs - Warped Cockroaches", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The first room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by some warped cockroaches that skitter about unpleasantly.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsEntrance"),
                                new Connection("MIST_CatacombsRoom2")
                            },
                            AreaMonsters = new() { "warpedCockroach", "warpedCockroach", "warpedCockroach", "warpedCockroach", "warpedCockroach" }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom2", "Catacombs - Corpse Spiders", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The second room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by some corpse spiders skittering about. The cockroachers really weren't so bad compared to these nasty things.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom1"),
                                new Connection("MIST_CatacombsRoom3")
                            },
                            AreaMonsters = new() { "spiderCorpse", "spiderCorpse", "spiderCorpse", "spiderCorpse", "spiderCorpse" }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom3", "Catacombs - Warped Flies", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The third room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by some warped flies buzzing back and forth through the air. There is a plinth here that looks like it could have a jade demon statuette on it.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom2"),
                                new Connection("MIST_CatacombsRoom4")
                            },
                            AreaMonsters = new() { "warpedFly", "warpedFly", "warpedFly", "warpedFly", "warpedFly" },
                            ItemSpawns = new() { new("statuetteJade", 1, new("NotItem", 1, "statuetteJade")) }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom4", "Catacombs - Corpse Torsos", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The fourth room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by the torsos of corpses dragging themselves along the ground.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom3"),
                                new Connection("MIST_CatacombsRoom5")
                            },
                            AreaMonsters = new() { "corpseTorso", "corpseTorso", "corpseTorso", "corpseTorso", "corpseTorso" }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom5", "Catacombs - Warped Rats", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The fifth room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by a bunch of chittering warped rats.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom4"),
                                new Connection("MIST_CatacombsRoom6")
                            },
                            AreaMonsters = new() { "warpedRat", "warpedRat", "warpedRat", "warpedRat", "warpedRat" }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom6", "Catacombs - Skeletons", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The sixth room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by some fairly normal skeletons, just the animated decayed remains of former Lumbridge citizens. There is a plinth here that looks like it could have a topaz demon statuette on it.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom5"),
                                new Connection("MIST_CatacombsRoom7")
                            },
                            AreaMonsters = new() { "cataSkeleton", "cataSkeleton", "cataSkeleton", "cataSkeleton", "cataSkeleton" },
                            ItemSpawns = new() { new("statuetteTopaz", 1, new("NotItem", 1, "statuetteTopaz")) }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom7", "Catacombs - Warped Bats", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The seventh room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by many warped bats flapping and screeching.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom6"),
                                new Connection("MIST_CatacombsRoom8")
                            },
                            AreaMonsters = new() { "warpedBat", "warpedBat", "warpedBat", "warpedBat", "warpedBat" }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom8", "Catacombs - Corpse Archers", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The eighth room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by shambling corpses of former archers, still holding and using their bows. There is a plinth here that looks like it could have a sapphire demon statuette on it.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom7"),
                                new Connection("MIST_CatacombsRoom9")
                            },
                            AreaMonsters = new() { "warpedBat", "warpedBat", "warpedBat", "warpedBat", "warpedBat" },
                            ItemSpawns = new() { new("statuetteSapphire", 1, new("NotItem", 1, "statuetteSapphire")) }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom9", "Catacombs - Skoblins", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The ninth room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by skeletal goblins. I guess Dragith Nurn didn't just reanimate human remains. There is a plinth here that looks like it could have an emerald demon statuette on it.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom8"),
                                new Connection("MIST_CatacombsRoom10")
                            },
                            AreaMonsters = new() { "skoblin", "skoblin", "skoblin", "skoblin", "skoblin" },
                            ItemSpawns = new() { new("statuetteEmerald", 1, new("NotItem", 1, "statuetteEmerald")) }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom10", "Catacombs - Corpse Mages", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The tenth room of the catacombs, all clean stone tiles with torches to provide light. This room is inhabited by shambling corpses that have an aura of magic about them. There is a plinth here that looks like it could have a ruby demon statuette on it.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom9"),
                                new Connection("MIST_CatacombsRoom11")
                            },
                            AreaMonsters = new() { "corpseMage", "corpseMage", "corpseMage", "corpseMage", "corpseMage" },
                            ItemSpawns = new() { new("statuetteRuby", 1, new("NotItem", 1, "statuetteRuby")) }
                        });

                        locsToAdd.Add(new Location("MIST_CatacombsRoom11", "Catacombs - Dragith Nurn", "Misthalin") {
                            DungeoneeringLevel = 1,
                            Description = "The final room of the catacombs, all clean stone tiles with torches to provide light. There is a plinth here that looks like it could have a diamond demon statuette on it.",
                            ConnectedLocations = new List<Connection>() {
                                new Connection("MIST_CatacombsRoom10")
                            },
                            AreaMonsters = new() { "dragithNurn" },
                            ItemSpawns = new() { new("statuetteDiamond", 1, new("NotItem", 1, "statuetteDiamond")) }
                        });
                    }

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
                        AreaMonsters = new() { "man", "man", "man", "man" },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine", "treeWillow", "treeWillow", "fishBaitLow", "fishBaitLow", "fishBaitLow", "fishLure", "fishLure", "fishLure" }
                    }); 

                    locsToAdd.Add(new Location("MIST_LumbridgeMarket", "Lumbridge Market", "Misthalin") {
                        Description = "The small market is bustling, people wandering from stall to stall to peruse the goods on sale. A few sets of tables and chairs allow people to take a break and eat the things they've purchased. Some guards are walking around to guard the stalls but aren't doing a particularly good job, and an enterprising individual could easily steal without their notice.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeNorth"),
                            new Connection("MIST_LumbridgeFishingStore")
                        },
                        NPCsHere = new() { "mistLumHarlan", "man", "man", "woman", "woman", "woman", "woman" },
                        AreaMonsters = new() { "man", "man", "woman", "woman", "woman", "woman" },
                        GatheringSpots = new() { "stallVegetable", "stallVegetable", "stallBakery", "stallBakery", "stallCrafting", "stallCrafting", "stallWine", "stallWine", "stallSeed", "stallSeed"}
                        // TODO: Add some shop items here? It IS a market
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeShearedRam", "The Sheared Ram", "Misthalin") {
                        Description = "This small bar is fairly cozy, with windows looking out over the River Lum and rustic decorations around the room. There are a small handful of tables available, or you could take a seat at the bar. The occupants are a little rowdy but the bar is not overly full in such a small town.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeNorth")
                        },
                        NPCsHere = new() { "mistLumBartender", "mistLumVeos", "clueArthur", "man", "man", "man" },
                        AreaMonsters = new() { "man", "man", "man" },
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
                        ShopItemsHere = new() { "potEmpty", "jugEmpty", "shears", "knife", "bucketEmpty", "bowlEmpty", "tinCakeEmpty", "tinderbox", "chisel", "shovel", "hammer", "plantPotEmpty", "candle" }, // TODO: Once actual places to get candles exist, remove them from here
                        NPCsHere = new() { "man", "man" },
                        AreaMonsters = new() { "man", "man" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeFishingStore", "Fishing Store", "Misthalin") {
                        Description = "There's a fishy smell lingering in here, permeating the walls and floors. A cooler has a variety of fish available, and the tools to catch your own fish line the shelves while the disgruntled store owner lounges in a chair behind the counter.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeNorth")
                        },
                        ShopItemsHere = new() { "baitFish", "feather", "fishingNetSmall", "fishingNetBig", "fishingRod", "fishingRodFly", "fishingPotLobster", "fishingHarpoon", "fishRawShrimp", "fishRawAnchovies", "fishRawSardine", "fishRawHerring", "fishRawTrout", "fishRawPike", "fishRawSalmon", "fishRawTuna", "fishRawSwordfish" },
                        NPCsHere = new() { "man", "man" },
                        AreaMonsters = new() { "man", "man" }
                    });

                    locsToAdd.Add(new Location("MIST_LumbridgeFredsFarm", "Fred's Farm", "Misthalin") {
                        Description = "A fairly large farmstead owned and operated by Fred the Farmer. There are some sheep here, plus a cow pen and chicken coop that you could get into. A huge windmill spins endlessly atop a small hill, and there are wheat and potato fields here. An axe in front of Fred's house has a bronze hatchet stuck in it.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeNorth"),
                            new Connection("MIST_DraynorCrossroads"),
                            new Connection("MIST_DraynorFarm"),
                            new Connection("MIST_LumbridgeFredsFarmChickens"),
                            new Connection("MIST_LumbridgeFredsFarmCows")
                        },
                        ItemSpawns = new List<ItemSpot>() {
                            new ItemSpot("hatchetBronze", 1)
                        },
                        GatheringSpots = new() { "clueChest", "treePine", "treePine", "treePine", "sheep", "sheep", "sheep", "plantOnion", "plantOnion", "plantGrain", "plantGrain", "plantGrain"},
                        ProcessingStations = new() { "Windmill" },
                        NPCsHere = new() { "mistLumFred", "farmer" },
                        AreaMonsters = new() { "farmer" }
                    }); 

                    locsToAdd.Add(new Location("MIST_LumbridgeFredsFarmChickens", "Fred's Chicken Coop", "Misthalin") {
                        Description = "It's a little cramped inside this coop, what with all the chickens wandering around and the sacks of seed and grain. One of Fred's farmhands is here keeping an eye on the chickens, but apparently isn't being paid enough to stop you from harming them.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeFredsFarm")
                        },
                        ItemSpawns = new List<ItemSpot>() {
                            new ItemSpot("eggChicken", 1)
                        },
                        AreaMonsters = new() { "farmer", "chicken", "chicken", "chicken", "chicken" },
                        NPCsHere = new() { "farmer" }
                    }); 

                    locsToAdd.Add(new Location("MIST_LumbridgeFredsFarmCows", "Fred's Cow Pen", "Misthalin") {
                        Description = "This is a spacious pen full of cows and their calves right on the banks of the River Lum. A few thistles grow around the pen, occasionally being eaten by the cows and then reappearing a few seconds later.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_LumbridgeFredsFarm")
                        },
                        AreaMonsters = new() { "farmer", "cow", "cow", "cow", "cow" },
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
                        NPCsHere = new() { "mistDrayTwiggyOKorn" }, // TODO: Achievement diary cape, also gives a chocolate bar 1/50 when talked to
                        ItemSpawns = new() { new("hatchetBronze", 30) },
                        GatheringSpots = new() { "treeWillow", "treeWillow", "treeWillow", "treeOak", "treeOak", "treePine", "treePine", "treePine", "fishNetSmall", "fishNetSmall", "fishBaitLow", "fishBaitLow" },
                        AreaMonsters = new() { "knightBlackNA", "wizardDark7NA"  }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorVillage", "Draynor Village", "Misthalin") {
                        Description = "A small, somewhat creepy, village on the border between Misthalin and Asgarnia. It has a small market, a bank, and a few houses for the residents. To the north there's the crossroads, Draynor Farm, and Draynor Manor, while to the east is the jail.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorCrossroads"), 
                            new Connection("MIST_DraynorFarm"),
                            new Connection("MIST_DraynorAgility1"), 
                            new Connection("MIST_DraynorNorthEast"), 
                            new Connection("MIST_DraynorMarket"),
                            new Connection("MIST_DraynorBank"),
                            new Connection("MIST_DraynorAggie"),
                            new Connection("MIST_DraynorNed"), 
                            new Connection("MIST_DraynorMorgan"),
                            new Connection("MIST_DraynorSpria"),
                            new Connection("MIST_DraynorWiseOldMan"),
                            new Connection("MIST_DraynorJail"), 
                            new Connection("MIST_DraynorOutskirtsSouth")
                        },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine" },
                        AreaMonsters = new() { "man", "man", "man", "woman", "woman" }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorMarket", "Draynor Market", "Misthalin") {
                        Description = "A surprisingly busy market, given how small the village is. There are a couple seed stalls and a wine stall here, plus a toy stall with nothing worth stealing - I mean, buying. There's a small pig pen adjacent to the market with some very cute piglets waddling around in it.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorNorthEast"), 
                            new Connection("MIST_DraynorVillage"), 
                            new Connection("MIST_DraynorOutskirtsSouth"), 
                            new Connection("ASG_PortSarimNorth", skill: "Agility", lv: 42)
                        },
                        NPCsHere = new() { "mistDrayOlivia", "mistDrayDiango", "mistDrayFortunato", "mistDrayMartin", "farmerMaster", "townCrier", "mistDrayTree", "mistDrayBankGuard" },
                        ShopItemsHere = new() { "seedPotato", "seedOnion", "seedCabbage", "seedTomato", "seedSweetcorn", "seedStrawberry", "seedSnapegrass", "seedWatermelon", "seedBarley", "seedJute", "seedRosemary", "seedMarigold", "seedHammerstone", "seedAsgarnian", "seedYanillian", "seedKrandorian", "seedWildblood", "jugWine", "jugEmpty", "bottleWine", "jugVinegar", "chronicle", "cardTeleport"},
                        GatheringSpots = new() { "stallSeed", "stallSeed", "stallWine", "treeOak", "treePine", "treePine" },
                        AreaMonsters = new() { "guardMarket", "guardMarket", "man", "man", "man", "woman", "imp" }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorBank", "Draynor Bank", "Misthalin") {
                        Description = "A cozy little bank building right next to the main road through Draynor. There's a row of bank booths cutting off a third of the room. In the accessible part of the building is a poll booth, a small bearskin rug on the floor, and a bank deposit box plus some noticeboards that haven't been updated in a long time. In the sectioned off area there's a part of the wall that looks different than the rest, like it had to be repaired recently.",
                        IsBank = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorVillage")
                        }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorNed", "Ned's House", "Misthalin") {
                        Description = "The inside of the house is stuffed fill of things, to the point that you consider Ned may have a hoarding problem. There are a bunch of chairs and nautical themed decorations all over the place, and a couple tables with ropes in the progress of being woven on them. A nice painting of White Wolf Mountain hangs on the wall. There are some crates full of even more junk, and a fireplace with a roaring fire in it.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorVillage")
                        },
                        NPCsHere = new() { "mistDrayNed1" },
                        ShopItemsHere = new() { "rope" }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorCrossroads", "Draynor Crossroads", "Misthalin") {
                        Description = "The atmosphere feels particularly ominous here, as you near Draynor Manor. The crossroads go north to the manor grounds, west towards Falador, east to Draynor Farm and the Lumbridge windmill, and south to Draynor Village. There's a highwayman here looking for easy prey, and a very lost goblin who got separated from his squad at Draynor Farm.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorManorGate"),
                            new Connection("MIST_DraynorManorWest"),
                            new Connection("MIST_DraynorManorEast"),
                            new Connection("ASG_FaladorFarm"),  
                            new Connection("MIST_DraynorFarm"),
                            new Connection("MIST_LumbridgeFredsFarm"), 
                            new Connection("MIST_DraynorNorthEast"), 
                            new Connection("MIST_DraynorVillage")
                        },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine" },
                        AreaMonsters = new() { "highwayman", "goblin" }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorNorthEast", "Northeast of Draynor", "Misthalin") {
                        Description = "A small area crammed between the market and the road to Falador. There's nothing really here except some trees and a trapdoor down to the Draynor sewers.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("ASG_FaladorFarm"),
                            new Connection("MIST_DraynorCrossroads"),
                            new Connection("MIST_DraynorSewersEnd", alt: "(Climb Down Trapdoor)"),
                            new Connection("MIST_DraynorMarket"), 
                            new Connection("MIST_DraynorVillage")
                        },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine", "treePine" }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorFarm", "Draynor Farm", "Misthalin") {
                        Description = "A nice large field of wheat and potatoes near a run-down barn. It still provides most of the food for Draynor, though it is significantly less frequented since a band of goblins moved in. Now the goblins handle most of the farmwork and charge for the food that the Draynor citizens own anyways.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorCrossroads"),
                            new Connection("MIST_LumbridgeFredsFarm"),
                            new Connection("MIST_DraynorVillage")
                        },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine", "plantPotato", "plantPotato", "plantPotato", "plantGrain", "plantGrain", "plantGrain" },
                        AreaMonsters = new() { "goblin", "goblin", "goblin", "goblin", "goblin", "goblin" },
                        NPCsHere = new() { "mistDrayLeela" }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorJail", "Draynor Jail", "Misthalin") {
                        Description = "An old jail building, hardly used anymore. There are some very hostile guards patrolling around outside the building. A few nettle bushes are around the back, but you'll need gloves of some kind to harvest them.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_DraynorVillage"),
                            new Connection("MIST_DraynorOutskirtsSouth"), 
                            new Connection("MIST_DraynorJailInterior"), 
                            new Connection("MIST_DraynorSewersStart", alt: "(Climb Down Trapdoor)")
                        },
                        GatheringSpots = new() { "treeOak", "treeOak", "treePine", "treePine", "treePine", "plantNettles", "plantNettles", "plantNettles" },
                        AreaMonsters = new() { "guardJail", "guardJail", "guardJail", "guardJail" }
                    });

                    locsToAdd.Add(new Location("MIST_DraynorIsland", "Draynor Island", "Misthalin") {
                        Description = "This is a tiny island just off the coast Misthalin, near Draynor Village and the Wizards' Tower. There is literally nothing here but a patch of land and the fairy ring you used to arrive.",
                        ConnectedLocations = new List<Connection>() {
                            // TODO: Add a fairy ring here when they get added, code CLP
                        }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTowerBridge", "Wizards' Tower Bridge", "Misthalin") {
                        Description = "On the large wide path from the Wizard Tower island to mainland Misthalin. There are a few banners hanging from poles, and some crates left partway down the bridge. The marble Wizard Tower spears into the sky above you, visible from far and wide.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTowerIsland"),
                            new Connection("MIST_DraynorOutskirtsSouth")
                        },
                        GatheringSpots = new() { "clueCrates" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTowerIsland", "Wizards' Tower Island", "Misthalin") {
                        Description = "This island holds the Wizard's Tower, towering high above you. Two statues of famous wizards of old stand guard at the bridge entrance, while a fountain is just off the path into the tower. There is some sparse tree and shrub coverage on the island but otherwise not a lot of interest.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower"),
                            new Connection("MIST_WizardTowerBridge")
                        },
                        GatheringSpots = new() { "treePine", "treePine" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTower", "Wizards' Tower", "Misthalin") {
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

                    locsToAdd.Add(new Location("MIST_WizardTower2F", "Wizards' Tower - Second Floor", "Misthalin") {
                        Description = "This floor of the tower seems to be more of a sleeping area than the research areas below or above, with some cots placed in the rooms for weary wizards. There's not much else in here except a nice view through the windows looking out onto the surrounding landscape.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower3F"),
                            new Connection("MIST_WizardTower")
                        },
                        NPCsHere = new() { "mistWizTraiborn", "mistWizJalarast" },
                        AreaMonsters = new() { "wizard", "wizard" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTower3F", "Wizards' Tower - Third Floor", "Misthalin") {
                        Description = "A decent portion of this floor is taken up by a large cage holding a lesser demon captive inside it. Though you can't reach it with melee attacks, you could probably hit it with ranged and magic attacks without it being able to retaliate. Slightly cruel, but it's a demon, so it's probably okay? There are also some high-ranking wizards up here busying themselves in their offices with various works. Illegible research notes cover a few of the tables up here.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower2F")
                        },
                        NPCsHere = new() { "mistWizMizgog", "mistWizGrayzag" },
                        AreaMonsters = new() { "wizDemonLesser", "wizard", "wizard" }
                    });

                    locsToAdd.Add(new Location("MIST_WizardTowerBasement", "Wizards' Tower - Basement", "Misthalin") {
                        Description = "Supposedly this basement is the ruins of the old Wizards' Tower, from back when it was inhabited by Zamorakian wizards. Now though it's just a dirty and messy basement with a few crumbling walls. Archmage Sedridor has set up office down here. There's a set of locked drawers down here, and a suspicious looking altar. Also a chicken... for some reason.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_WizardTower2F")
                        },
                        NPCsHere = new() { "mistWizSedridor" },
                        AreaMonsters = new() { "chicken", "mistWizSkeleton" },
                        GatheringSpots = new() { "mistWizAltar", "clueDrawersLocked" }
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
                            new Connection("MIST_VarrockSouth"),
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
                        NPCsHere = new() { "mistVarHeadChef" },
                        ShopItemsHere = new() { "bookRecipesPie", "potFlour", "pieEmpty", "pieRedberry", "pieMeat", "pieMud", "pieApple", "pieGarden", "pieFish", "pieAdmiral", "pieWild", "pieSummer" }
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
                        Description = "Just outside the eastern gates into the city of Varrock. There are a variety of buildings outside the walls here, including the Lumberyard and a path to the Digsite. There's also a secluded bar with a depressing atmosphere, a path to Silvarea, and a strange stone ruin emitting a soft brown light. You could also pass through the gates into Varrock proper.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockEast"),
                            new Connection("MIST_VarrockCrossroadsNorth"),
                            new Connection("MIST_VarrockJollyBoar"),
                            new Connection("MIST_VarrockLumberyard"),
                            new Connection("RunecraftAltarEarth", new() { new("Item", 1, "talismanEarth", false) }),
                            new Connection("MIST_VarrockChaosTunnel", new() { new("Quest", 10, "MI_WhatLiesBelow", false) }, hideIfNoReqs: true),
                            new Connection("MIST_Silvarea"),
                            new Connection("MIST_Digsite"),
                            new Connection("MIST_VarrockMineEast"),
                            new Connection("MIST_VarrockCrossroadsSouth")
                        }, 
                        NPCsHere = new() { "mistVarAnnaJones", "guard", "guard", "guard" },
                        AreaMonsters = new() { "guard", "guard", "guard", "imp" },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine", "treeOak", "treeOak", "treeYew", "treeYew" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockCrossroadsNorth", "Varrock - North Crossroads", "Misthalin") {
                        Description = "Squeezed between the northern wall of Varrock and the border into the Wilderness, there's not much room for anything of interest here. If not entering Varrock through the gates or going to the Wilderness, the only other real options are to skirt around the city walls to the west or south-east, or to visit the Jolly Boar.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockAlongNorthWall"), 
                            new Connection("MIST_VarrockNorth"), 
                            new Connection("MIST_VarrockJollyBoar"),   
                            new Connection("MIST_VarrockCrossroadsEast")
                        }, 
                        NPCsHere = new() { "guard", "guard", "guard" },
                        AreaMonsters = new() { "guard", "guard", "guard", "knightBlackNA", "knightBlackNA" },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine", "treeOak", "treeOak" },
                        ItemSpawns = new() { new("runeEarth", 1) }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockJollyBoar", "Jolly Boar", "Misthalin") {
                        Description = "Given how out of the way it is and the general atmosphere of grime and sadness, it's not hard to see why the Jolly Boar sees so little foot traffic. The common room is fairly spacious, all things considered, with a lot of empty tables and chairs scattered around. A bored bartender is on duty behind the bar, one of the few places largely free of dust in the establishment. Despite them not offering food of any kind, there's a kitchen with a cook who claims to be perpetually busy.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_VarrockCrossroadsNorth"),
                            new Connection("MIST_VarrockCrossroadsEast"),
                            new Connection("MIST_VarrockJollyBoarKitchen")
                        }, 
                        NPCsHere = new() { "mistVarJollyBartender", "man", "woman", "woman" },
                        AreaMonsters = new() { "knightBlackNA", "thiefNA", "man", "woman", "woman" },
                        ShopItemsHere = new() { "beer" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockJollyBoarKitchen", "Jolly Boar Kitchen", "Misthalin") {
                        Description = "...Okay, having seen the kitchen it's probably a good thing they don't offer food here. The room is small, cramped, dirty, and too hot from the two ovens running constantly. A handful of shelves are bolted to the walls and stacked with dishes and cutlery, dubious spice jars, and a small vase of wilted flowers and dirty water.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_VarrockJollyBoar")
                        }, 
                        NPCsHere = new() { "mistVarJollyCook" },
                        ProcessingStations = new() { "Range" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPalaceBailey", "Varrock Palace Bailey", "Misthalin") {
                        Description = "The bailey is spacious, containing a small path around back and a tree patch. Trees line the path up to the palace courtyard, and a few benches are off to the side to sit and enjoy the view. There's a broken cart off to one side of the bailey with some crates next to it. Banners bearing the Varrock heraldry hang everywhere.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalaceCourtyard"),
                            new Connection("MIST_VarrockPalaceBaileyBack"),
                            //new Connection("MIST_VarrockPalaceGarden", [ new("Skill", 35, "Agility")]), TODO: After Garden of Tranquility is implemented which is ages away
                            new Connection("MIST_VarrockNorth"),
                            new Connection("MIST_VarrockGrandExchange"),
                            new Connection("MIST_VarrockPlaza")
                        },
                        GatheringSpots = new() { "treePine", "treePine", "treeOak", "clueCrates" },
                        ProcessingStations = new() { "Fountain" },
                        NPCsHere = new() { "mistVarTreznor" },
                        FarmingPatchesHere = new() { "MIST_VarTree" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPalaceBaileyBack", "Behind Varrock Palace", "Misthalin") {
                        Description = "Around back behind the Varrock Palace, within the bailey. There are just a few yew trees here, plus an enclosure containing a grizzly bear. There's a human skeleton in the enclosure... hopefully just decorative.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalaceBailey"),
                            new Connection("MIST_VarrockPalaceGarden"),
                            new Connection("MIST_VarrockGrandExchange")
                        },
                        GatheringSpots = new() { "treeYew", "treeYew", "treeYew" },
                        ProcessingStations = new() { "Fountain" },
                        AreaMonsters = new() { "imp", "bearZoo" },
                        ItemSpawns = new() { new("coins", 1, null, 10, true), new("runeBody", 1) }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPalaceCourtyard", "Varrock Palace Courtyard", "Misthalin") {
                        Description = "A small courtyard enclosed by stone walls attached to the front of the palace, with a couple fountains and a bunch of barrels and crates in it. Some guards patrol the area on the lookout for intruders. There's a small staircase up to the palace itself, with an overhang held up by stone pillars. Banners bearing the Varrock heraldry hang everywhere.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalaceGroundFloor"),
                            new Connection("MIST_VarrockPalaceBailey")
                        },
                        GatheringSpots = new() { "clueCrates" },
                        ProcessingStations = new() { "Fountain" },
                        AreaMonsters = new() { "guard", "guard", "guard", "guard" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPalaceGroundFloor", "Varrock Palace - Ground Floor", "Misthalin") {
                        Description = "The layout of this floor is... very strange. It's a long curving hallway leading around the palace, touching each room except the banquet hall. Right in front of the entrance is a staircase up to the second floor, behind which is a door to the inner courtyard. There's not even a guard blocking the door into the throne room, besides the ones out in the main courtyard. The hallway is adorned with many suits of armor and sets of swords and shields in the Varrock colors, black and yellow.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalace2F"),
                            new Connection("MIST_VarrockPalaceCourtyardInner"),
                            new Connection("MIST_VarrockPalaceThroneRoom"),
                            new Connection("MIST_VarrockPalaceBunkRoom"),
                            new Connection("MIST_VarrockPalaceRoom"),
                            new Connection("MIST_VarrockPalacePrysin"),
                            new Connection("MIST_VarrockPalaceStairwell1F"),
                            new Connection("MIST_VarrockPalaceLibrary"),
                            new Connection("MIST_VarrockPalaceKitchen"),
                            new Connection("MIST_VarrockPalaceCourtyard")
                        },
                        AreaMonsters = new() { "monkZamorakVarrock" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPalaceCourtyardInner", "Varrock Palace - Inner Courtyard", "Misthalin") {
                        Description = "A lovely little courtyard inside Varrock Palace. It just has a few small plants and a magic tree in the middle, with some narrow windows looking into the hallway of the ground floor of the palace.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalaceGroundFloor")
                        },
                        GatheringSpots = new() { "treeMagic" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPalaceRoom", "Varrock Palace - Room", "Misthalin") {
                        Description = "A small room with a single bed and a couple chests. There are paintings of a water mill and the moon rising over a river hanging on the wall, and some shelves holding various knick-knacks. A sword and shield bearing the Varrock colors hang on the walls above the bed. There's a nice fur rug dyed green spread on the floor that really ties the room together.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalaceGroundFloor")
                        },
                        GatheringSpots = new() { "clueChest" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPalaceLibrary", "Varrock Palace - Library", "Misthalin") {
                        Description = "A small room with a single bed and a couple chests. There are paintings of a water mill and the moon rising over a river hanging on the wall, and some shelves holding various knick-knacks. A sword and shield bearing the Varrock colors hang on the walls above the bed. There's a nice fur rug dyed green spread on the floor that really ties the room together.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalaceGroundFloor")
                        },
                        GatheringSpots = new() { "bookshelfWizard", "bookshelfWizard", "bookshelfArrav", "bookshelfWizard" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockPlaza", "Varrock Plaza", "Misthalin") {
                        Description = "The beating heart of the kindom of Misthalin! The plaza has a nice fountain with a statue looking in each ordinal direction, and a number of small stalls hawk various goods that they won't actually let you buy.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockPalaceBailey"),
                            new Connection("MIST_VarrockWest"),
                            new Connection("MIST_VarrockZaff"),
                            new Connection("MIST_VarrockFortuneTeller"),
                            new Connection("MIST_VarrockGeneralStore"),
                            new Connection("MIST_VarrockThessalia"),
                            new Connection("MIST_VarrockEast"),
                            new Connection("MIST_VarrockSouth")
                        }, 
                        NPCsHere = new() { "mistVarRomeo", "mistVarBaraek", "mistVarBenny", "mistVarShilop", "mistVarWilough", "mistVarToby" },
                        GatheringSpots = new() { "treePine", "treePine", "treeOak" },
                        ProcessingStations = new() { "Fountain" }
                    });
                     
                    locsToAdd.Add(new Location("MIST_VarrockNorth", "Varrock North", "Misthalin") {
                        Description = "Really more of the north-east of Varrock, this is a small section of the city just east of the palace. The salon and Saradominist chapel are found here, along with a real estate agent for those looking to purchase a home. There's a manhole leading down into the sewer system, which is infested with monsters, for the adventurous. Also Bob lives here.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_VarrockCrossroadsNorth"),
                            new Connection("MIST_VarrockHouseBob"),
                            new Connection("MIST_VarrockChapel"),
                            new Connection("MIST_VarrockEstateAgent"),
                            new Connection("MIST_VarrockSalon"),
                            new Connection("MIST_VarrockPalaceBailey"),
                            new Connection("MIST_VarrockSewerEntrance"),
                            new Connection("MIST_VarrockEast")
                        }, 
                        NPCsHere = new() { "guard", "man", "man", "woman", "woman" },
                        AreaMonsters = new() { "guard", "man", "man", "woman", "woman", "imp" },
                        GatheringSpots = new() { "treePine", "treePine", "treePine", "treePine", "treePine", "treeYew" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockEast", "Varrock East", "Misthalin") {
                        Description = "The bustling eastern district of Varrock, home to the bank, Horvik's Armor Shop, Lowe's Archery Emporium, and Jeff's house. Perhaps most notably though is the presence of the Varrock Museum, housing a number of fascinating exhibits. There's even a small fountain here, and a mostly useless training hall. So many sights to see!",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_VarrockNorth"),
                            new Connection("MIST_VarrockPlaza"),
                            new Connection("MIST_VarrockHouseJeff"),
                            new Connection("MIST_VarrockHorvik"),
                            new Connection("MIST_VarrockLowe"),
                            new Connection("MIST_VarrockMuseum"),
                            new Connection("MIST_VarrockMuseumWorkers"),
                            new Connection("MIST_VarrockTrainingHall"),
                            new Connection("MIST_VarrockBankEast"),
                            new Connection("MIST_VarrockSouthEast"),
                            new Connection("MIST_VarrockCrossroadsEast")
                        }, 
                        NPCsHere = new() { "guard", "man", "man", "woman", "woman", "woman", "woman", "streetCleaner", "townCrier" },
                        AreaMonsters = new() { "guard", "man", "man", "woman", "woman", "woman", "woman" },
                        GatheringSpots = new() { "treePine", "treePine", "treePine" },
                        ProcessingStations = new() { "Fountain" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockBankEast", "Varrock East Bank", "Misthalin") {
                        Description = "Nobody is quite sure why Varrock needs two banks so close to eachother, but they do both exist. This one is a bit smaller than the West bank, though perhaps a little more upscale. There's a line of bank booths you can use, plus a staircase up to the second floor, which contains an area enclosed by iron bars holding a bunch of gold and chests.",
                        IsBank = true,
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockEast")
                        }, 
                        GatheringSpots = new() { "clueDrawers" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockHorvik", "Horvik's Armor Shop", "Misthalin") {
                        Description = "This open-air building, more of a stone canopy than an enclosed room, is really more of a forge than a storefront. A variety of smithing tools hang on the walls and there's a drill in the back corner of the shop, along with a workbench and some anvils towards the front. A few stacked crates hold the store stock, which consists of all of the main pieces of metal armor up to adamant. Horvik does charge a premium over what other shops would charge, but the convenience of having all the pieces in one place may be worth the price increase.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockEast")
                        }, 
                        NPCsHere = new() { "mistVarHorvik" },
                        ShopPriceMultiplier = 1.2,
                        ShopItemsHere = new() { "helmBronze", "platebodyBronze", "platelegsBronze", "bootsBronze", "gauntletsBronze", "sqShieldBronze", "kiteshieldBronze",
                                                "helmIron", "platebodyIron", "platelegsIron", "bootsIron", "gauntletsIron", "sqShieldIron", "kiteshieldIron",
                                                "helmSteel", "platebodySteel", "platelegsSteel", "bootsSteel", "gauntletsSteel", "sqShieldSteel", "kiteshieldSteel",
                                                "helmBlack", "platebodyBlack", "platelegsBlack", "bootsBlack", "gauntletsBlack", "sqShieldBlack", "kiteshieldBlack",
                                                "helmMithril", "platebodyMithril", "platelegsMithril", "bootsMithril", "gauntletsMithril", "sqShieldMithril", "kiteshieldMithril",
                                                "helmAdamant", "platebodyAdamant", "platelegsAdamant", "bootsAdamant", "gauntletsAdamant", "sqShieldAdamant", "kiteshieldAdamant" },
                        ProcessingStations = new() { "Anvil" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockLowe", "Lowe's Archery Emporium", "Misthalin") {
                        Description = "The inside of this shop is filled with displays of various bows and arrows. Some posters hang on the wall depicting the best spots to shoot rabbits and deer, and there's a mannequin wearing some nice looking ranger clothing. The building has some lovely green stained glass windows looking out to the street. There's a small side room containing a workshop and a ladder up to the second floor, which is largely filled with crates of inventory.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockEast")
                        }, 
                        NPCsHere = new() { "mistVarLowe" },
                        ShopItemsHere = new() { "arrowsBronze", "arrowsIron", "arrowsSteel", "arrowsMithril", "arrowsAdamant",
                                                "boltsBronze",
                                                "shortbowPine", "shortbowOak", "shortbowWillow", "shortbowTeak", "shortbowMaple", "shortbowAcadia",
                                                "longbowPine", "longbowOak", "longbowWillow", "longbowTeak", "longbowMaple", "longbowAcadia",
                                                "coifLeather", "bodyLeather", "chapsLeather", "bootsLeather", "vambracesLeather", "shieldLeather",
                                                "coifHardleather", "bodyHardleather", "chapsHardleather", "bootsHardleather", "vambracesHardleather", "shieldHardleather",
                                                "coifStudded", "bodyStudded", "chapsStudded", "bootsStudded", "vambracesStudded", "shieldStudded",
                                                "coifCarapace", "bodyCarapace", "chapsCarapace", "bootsCarapace", "vambracesCarapace", "shieldCarapace",
                                                "coifGreenDragonhide", "bodyGreenDragonhide", "chapsGreenDragonhide", "bootsGreenDragonhide", "vambracesGreenDragonhide", "shieldGreenDragonhide" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockSouthEast", "Varrock Southeast", "Misthalin") {
                        Description = "In a larger city this part of town might be called the slums, but that feels like overkill when it's really just a cluster of buildings you're likely to get stabbed as you walk past. Interestingly there's also a sort of gated community in the corner of the city. You know, next to the Zamorakian temple and the run-down houses and the crumbling ruins of former run-down houses. Prime real estate.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_VarrockEast"),
                            new Connection("MIST_VarrockFencedArea"),
                            new Connection("MIST_VarrockAubury"),
                            new Connection("MIST_VarrockHouseAbandoned"),
                            new Connection("MIST_VarrockHouseRundown"), // the one with two men and a range
                            new Connection("MIST_VarrockHouseRundown2"), // adjoining above but with no resident
                            new Connection("MIST_VarrockHouseRundown3"), // next to temple, one man
                            new Connection("MIST_VarrockHouseYarlo"),
                            new Connection("MIST_VarrockZamorakTemple"),
                            new Connection("MIST_VarrockPhoenixGang"),
                            new Connection("MIST_VarrockPhoenixGangSide"), // that little room to the east of the main phoenix building between it and the temple
                            new Connection("MIST_VarrockSouth")
                        }, 
                        NPCsHere = new() { "dogStray", "man" },
                        AreaMonsters = new() { "man", "mugger", "thief" },
                        GatheringSpots = new() { "treeDead", "treeDead" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockAubury", "Aubury's Rune Shop", "Misthalin") {
                        Description = "A tiny cramped room with barely any room to walk around. There are some shelves on the walls with containers, though the labels are illegible, and other knick-knacks. There are also a couple chairs and a small table, a crate and chest, some kind of gray fur rug covering the floor. The store is, in a word, the very essence of 'disreputable'. That said it's essentially the only place in Misthalin that sells runes, so you don't have much choice.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockSouthEast")
                        }, 
                        NPCsHere = new() { "mistVarAubury" },
                        ShopItemsHere = new() { "runeAir", "runeFire", "runeWater", "runeEarth", "runeMind", "runeBody", "runeChaos", "runeDeath" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockSouth", "Varrock South", "Misthalin") {
                        Description = "The southern entrance to Varrock, home to the sword shop and the Blue Moon Inn, the best inn in all of Misthalin! Or so they say. Probably not really anyone verifying claims like that around here. There's also a lovely little house with a cabbage patch, and a back alley west of the gate being frequented by some suspicious looking people.",
                        ConnectedLocations = new List<Connection>() { 
                            new Connection("MIST_VarrockPlaza"),
                            new Connection("MIST_VarrockBlueMoon"),
                            new Connection("MIST_VarrockSwordShop"),
                            new Connection("MIST_VarrockHouseLovely"), // one right next to the south gate, on the right with the cabbage patch
                            new Connection("MIST_VarrockHouseClue"), // across the street from above, has a clue step here and not much else
                            new Connection("MIST_VarrockBlackArmGang"),
                            new Connection("MIST_VarrockSouthEast"),
                            new Connection("MIST_VarrockOutskirtsSouth")
                        }, 
                        NPCsHere = new() { "guard", "man", "man", "woman", "woman", "woman", "woman", "streetCleaner", "trampCharlie" },
                        AreaMonsters = new() { "guard", "man", "man", "woman", "woman", "woman", "woman" },
                        GatheringSpots = new() { "plantCabbage", "plantCabbage", "plantCabbage" }
                    });

                    locsToAdd.Add(new Location("MIST_VarrockSwordShop", "Varrock - Sword Shop", "Misthalin") {
                        Description = "A fine establishment offering a variety of swords and daggers. The walls and tables are absolutely covered in display cases and weapon racks showing off a multitude of weaponry, a vast majority of which cannot be purchased at this store. In a small backroom there are a bunch of crates stacked up to store excess inventory. The front of the building, facing the main thoroughfare, has pleasant green stained glass windows letting in plenty of light.",
                        ConnectedLocations = new List<Connection>() {
                            new Connection("MIST_VarrockSouth")
                        }, 
                        NPCsHere = new() { "mistVarShopkeeperSword" },
                        ShopItemsHere = new() { "daggerBronze", "daggerIron", "daggerSteel", "daggerBlack", "daggerMithril", "daggerAdamant", "swordBronze", "swordIron", "swordSteel", "swordBlack", "swordMithril", "swordAdamant" },
                        GatheringSpots = new() { "clueCrates" }
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
