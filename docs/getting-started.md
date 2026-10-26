# Getting started with Zero Players Online

This is a short, practical guide.

Zero Players Online is a single-player, text-heavy RuneScape-inspired game framed as a long-dead MUD. It runs on **SadConsole** + **MonoGame**, with game data mostly hardcoded in C# rather than external JSON/DB files.

---

## Requirements

- .NET SDK that can target `net10.0` (see `ZeroPlayersOnline.csproj`)
- The NuGet packages listed in the csproj (SadConsole, MonoGame DesktopGL, GoRogue, etc.)
- `irrKlang.NET4.dll` is referenced locally and copied to the output directory

This is a **WinExe**-style desktop app. Expect a windowed SadConsole host, not a web client.

---

## Opening the solution

```text
ZeroPlayersOnline.slnx
ZeroPlayersOnline.csproj
```

Build and run from your IDE or:

```bash
dotnet restore
dotnet build
dotnet run --project ZeroPlayersOnline.csproj
```

Fonts under `fonts/` and `loginbg.xp` are marked `CopyToOutputDirectory`, so a normal build should pick them up.

---

## Where things live

| `ZeroPlayersOnline.cs` - Main game class: libraries, tick loop hooks, input (F1 guidebook, F2 compendium, etc.) |
| `GameLoop.cs` - Thin static access / loop wiring |
| `Helper.cs` - Shared UI helpers, timing, string/layout utilities |
| `DataTypes/` - Core types: `Player`, `Location`, `Item`, bosses, quests, recipes, … |
| `HardcodedData/` - Static content: items, monsters, locations, NPCs, prayers, spells, quests |
| `HardcodedData/Locations/` - Region-specific (Lumbridge, Varrock, …) |
| `HardcodedData/NPCs/` - Region-specific NPC packs |
| `HardcodedData/Items/` - Item packs split by theme (cooking, clues, pets, …) |
| `UI/` - Screen pieces; `UI_LocCombat.cs` is combat drawing + attack resolution |
| `Managers/` - Windows and systems: guidebook, quests, crafting, sound, clues, item-use |
| `docs/` - info |

Content is registered into dictionaries on the main `ZeroPlayersOnline` instance (`Atlas`, `ItemLibrary`, `MonsterLibrary`, `BossLibrary`, …) via `RebuildLibraries()` and related setup. If you add a new location or item, wire it into the existing hardcoded loaders the same way neighboring entries are — don’t invent a parallel system.

---

## Controls worth knowing in-game

- **F1** - Guidebook (`Managers/ExtraWindows.cs` -> `Guide` / `GuideDraw`)
- **F2** - Compendium
- **TAB** - Cycle the activity panel tab (resources, items, NPCs, shops, processing, …)
- Click connections on the left to travel; click monsters/bosses to attack; click activity entries to gather, talk, buy, or process

---

## Combat

- **UI + resolution:** `UI/UI_LocCombat.cs` - `DrawCombat`, targeting, boss lanes, hits, exp grants
- **Player stats / dice / prayers:** `DataTypes/Player.cs` - `GetCombatLevel`, `SimpleDamageDice`, `TakeDamage`, `TryTogglePrayer`
- **Prayer definitions:** `HardcodedData/HardcodedPrayers.cs`
- **Boss data:** `HardcodedData/HardcodedBosses.cs` + `DataTypes/BossFight.cs` / phases / attacks
- **Monsters on a tile:** location `AreaMonsters` -> `MonsterLibrary`

Combat level is `(Attack + Strength + Defense + Constitution + Ranged + Magic + Prayer/2) / 4`. Aggro colour in the UI uses that number against the monster/boss aggro settings.

---

## Saving and “security”

This is offline single-player. There is no account server in-tree. Treat save data as local and untrusted if you ever add import paths - don’t assume a file on disk is well-formed. Prefer the existing rebuild/soft-reset paths in `Player` / `ZeroPlayersOnline` when handling death modes or corrupt state rather than inventing new wipe logic.

---

## Making changes

1. Prefer extending an existing `Hardcoded*.cs` list over new frameworks.
2. Keep IDs stable - locations, items, quests, and collection log keys are string IDs referenced from many places.
3. Match nearby style: plain C#, small helper methods, clickable UI via SadConsole print helpers in `Helper`.

---

## Changes in this contribution

Documentation*

- **Guidebook:** Combat (and short Skilling / Shops / NPC Dialogue) text filled in under `ExtraWindows.GuideDraw` so those tabs are not empty. `UI_LocCombat` + `Player` behaviour.
- **Comments:** A few short notes in `UI_LocCombat.cs` (targeting + idle timeout) and `DataTypes/Player.cs` (`GetCombatLevel`) explaining *why* those bits sit where they do.
- **Docs:** Added this `docs/getting-started.md`.

You can take any of this in a PR **with or without credit**. Just wanted to help out.

