# 03.06-marsrover-routenplaner: MarsRover- und Routenplaner-Projekte inkl. Tests auf net10.0 upgraden

## Objective
Upgrade der MarsRover- und Routenplaner-Projekte inklusive Tests auf net10.0.

## Scope
- MarsRoverKata/MarsRoverKata.csproj
- MarsRoverKata.Tests/MarsRoverKata.Tests.csproj
- Routenplaner/Routenplaner.csproj
- RoutenplanerTests/Routenplaner.Tests.csproj

## Done when
- Alle Scope-Projekte targeten net10.0
- Build für Scope und Solution erfolgreich
- Relevante Tests für den Scope laufen erfolgreich

## Scope Inventory
- **Projekte**: 2 Produktionsprojekte + 2 Testprojekte.
- **Concerns**: primär TFM-Anhebung auf `net10.0` und nachgelagerte Build-/Testvalidierung.
- **Assessment-Signale**:
  - `Project.0002` in allen Scope-Projekten
  - `NuGet.0005` optional in beiden Testprojekten, keine Inkompatibilitäten

## Research Findings
- Alle vier Projekte sind SDK-Style und noch auf `net9.0`.
- Keine `NuGet.0003`-Bereinigungen nötig.
- Testvalidierung erfolgt gezielt über `MarsRoverKata.Tests` und `Routenplaner.Tests`.
