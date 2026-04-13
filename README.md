# Ensamma Vargen – Karaktärsblad

A digital, editable character sheet for the Swedish gamebook series *Ensamma Vargen* (Lone Wolf), built as a Blazor WebAssembly app.

## Features

- Two-tab layout: character sheet (front) and combat page (back)
- All values persist across page reloads via `localStorage`
- Checkboxes for selecting active Kai disciplines and weapons
- Die roller (0–9) accessible from the header
- Reset button to clear and regenerate the sheet

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download)

## Running locally

```bash
dotnet watch --project src
```

Opens at `http://localhost:5050` with hot reload.

## Building

```bash
dotnet build
```

## License

MIT
