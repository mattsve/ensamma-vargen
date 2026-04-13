# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

Run from the repo root (solution file at root, project under `src/`):

```bash
dotnet build          # compile
dotnet watch --project src  # dev server with hot reload at http://localhost:5050
dotnet run --project src    # run without hot reload
```

There are no tests.

## Architecture

Blazor WebAssembly (client-side only, no server). Single page at `/` — no routing beyond that.

**Persistence:** All character data is serialized to JSON and stored in `localStorage` under the key `ev_character` via a JS interop shim (`window.storageInterop`) defined in `wwwroot/index.html`. Loading happens in `OnAfterRenderAsync(firstRender)` and saving on every `@oninput` via `OnChange()`.

**Data model** (`Models/CharacterData.cs`): Plain mutable classes (`CharacterData`, `DisciplinEntry`, `WeaponEntry`, `BackpackItem`, `SpecialItem`, `CombatRow`). `CharacterData` is the root object that gets serialized. `MergeLoaded()` in `Home.razor` handles deserialization carefully — fixed discipline/weapon names are never overwritten from storage, only `Bonus`, `Selected`, and `Extra` fields are restored.

**UI** (`Pages/Home.razor`): Two tabs (Karaktärsblad / Stridssida) toggled via `activeTab` int and `display:none`. No routing, no components — everything is in the single page file.

**Styling** (`wwwroot/css/app.css`): Custom CSS only — no scoped `.razor.css` files. Brown/tan gamebook aesthetic. `row-selected` class highlights checked discipline/weapon rows green.
