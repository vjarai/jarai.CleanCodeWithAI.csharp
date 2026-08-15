# 03.02-telefon: Telefon-Projekte und Tests auf net10.0 upgraden

## Objective
Upgrade der Telefon-Varianten (Original, Refactored) inklusive Testprojekten auf net10.0.

## Scope
- 03_Telefon/A_Original/Telefon.Original.csproj
- 03_Telefon/A_Original.Tests/Telefon.Original.Tests.csproj
- 03_Telefon/C_Refactored/Telefon.Refactored.csproj
- 03_Telefon/C_Refactored.Tests/Telefon.Refactored.Tests.csproj

## Done when
- Alle Scope-Projekte targeten net10.0
- Build für Scope und Solution erfolgreich
- Relevante Tests für den Scope laufen erfolgreich

## Scope Inventory
- **Projekte**: 2 Bibliotheksprojekte + 2 Testprojekte im Telefon-Cluster.
- **Concerns**: TFM-Upgrade auf `net10.0`, Entfernung der vom Framework abgedeckten Pakete (`NuGet.0003`) in beiden Bibliotheken, Build- und Testvalidierung.
- **Assessment-Signale**:
  - `Project.0002` in allen 4 Projekten
  - `NuGet.0003` in `A_Original` und `C_Refactored`
  - `NuGet.0005` optional in Testprojekten, aktuell kompatibel

## Research Findings
- Alle Scope-Projekte sind SDK-Style und auf `net9.0` konfiguriert.
- `Microsoft.CSharp` und `System.Data.DataSetExtensions` werden in den Bibliotheken entfernt (Framework enthält die Funktionalität).
- Testpakete bleiben unverändert, da kompatibel mit `net10.0`.
