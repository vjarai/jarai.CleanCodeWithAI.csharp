# 03.04-kniffel: Kniffel-Projekte und Tests auf net10.0 upgraden

## Objective
Upgrade der Kniffel-Projekte (Original, Refactored) inklusive Testprojekt auf net10.0.

## Scope
- 07_Kniffel/Kniffel.Original/Kniffel.Original.csproj
- 07_Kniffel/Kniffel.Original.Tests/Kniffel.Original.Tests.csproj
- 07_Kniffel/Kniffel.Refactored/Kniffel.Refactored.csproj

## Done when
- Alle Scope-Projekte targeten net10.0
- Build für Scope und Solution erfolgreich
- Relevante Tests für den Scope laufen erfolgreich

## Scope Inventory
- **Projekte**: 2 Produktionsprojekte + 1 Testprojekt.
- **Concerns**: TFM-Anhebung auf `net10.0`, Entfernung von `NuGet.0003`-Paketen im Original-Projekt, Build-/Testvalidierung.
- **Assessment-Signale**:
  - `Project.0002` in allen drei Projekten
  - `NuGet.0003` in `Kniffel.Original`
  - `NuGet.0005` optional im Testprojekt (kompatibel)

## Research Findings
- Alle drei Projekte sind SDK-Style und aktuell auf `net9.0`.
- Im Projekt `Kniffel.Original` werden `Microsoft.CSharp` und `System.Data.DataSetExtensions` als Framework-funktional ersetzt und entfernt.
- Testpakete im Testprojekt bleiben unverändert, da kompatibel.
