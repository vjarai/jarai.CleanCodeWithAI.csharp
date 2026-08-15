# 03.03-gildedrose: GildedRose-Projekte und Tests auf net10.0 upgraden

## Objective
Upgrade der GildedRose-Projekte (Original, TestDriven) inklusive Tests auf net10.0.

## Scope
- 06_GildedRose/A_Original/GildedRoseKata.Original.csproj
- 06_GildedRose/A_Original.Tests/GildedRoseKata.Original.Tests.csproj
- GildedRoseKata.TestDriven/GildedRoseKata.TestDriven.csproj
- GildedRoseKata.TestDriven.Tests/GildedRoseKata.TestDriven.Tests.csproj

## Done when
- Alle Scope-Projekte targeten net10.0
- Build für Scope und Solution erfolgreich
- Relevante Tests für den Scope laufen erfolgreich

## Scope Inventory
- **Projekte**: 2 Produktionsprojekte + 2 Testprojekte im GildedRose-Cluster.
- **Concerns**: reine TFM-Anhebung auf `net10.0` und anschließende Build-/Testvalidierung.
- **Assessment-Signale**:
  - `Project.0002` in allen 4 Projekten
  - `NuGet.0005` optional in den Testprojekten (kompatibel, kein Blocker)

## Research Findings
- Alle vier Projekte sind SDK-Style und nun auf `net10.0`.
- Keine `NuGet.0003`-Entfernungen erforderlich; Paketstand bleibt für diesen Subtask unverändert.
- Gemäß Benutzerentscheidung wird der fehlschlagende Conjured-Test temporär per `Skip` markiert, um den Upgrade-Flow fortzusetzen.
- Tests werden gezielt pro Testprojekt via `dotnet test` validiert.
