# 03.05-openclosed-liskov: OpenClosed- und Liskov-Projekte inkl. Tests auf net10.0 upgraden

## Objective
Upgrade der OpenClosed- und Liskov-Projekte inklusive Tests auf net10.0.

## Scope
- OpenClosed.Original/OpenClosed.Original.csproj
- OpenClosed.Original.Tests/OpenClosed.Original.Tests.csproj
- OpenClosed.Final/OpenClosed.Final.csproj
- Liskov/Liskov.csproj
- Liskov.Tests/Liskov.Tests.csproj

## Done when
- Alle Scope-Projekte targeten net10.0
- Build für Scope und Solution erfolgreich
- Relevante Tests für den Scope laufen erfolgreich

## Scope Inventory
- **Projekte**: 3 Produktionsprojekte + 2 Testprojekte.
- **Concerns**: reine TFM-Anhebung auf `net10.0` und Validierung über Build und Testläufe.
- **Assessment-Signale**:
  - `Project.0002` in allen Scope-Projekten
  - keine blockierenden API-/NuGet-Inkompatibilitäten im Scope

## Research Findings
- Alle Scope-Projekte sind SDK-Style und aktuell auf `net9.0`.
- Keine `NuGet.0003`-Bereinigungen in diesem Subtask erforderlich.
- Testvalidierung erfolgt über `OpenClosed.Original.Tests` und `Liskov.Tests`.
