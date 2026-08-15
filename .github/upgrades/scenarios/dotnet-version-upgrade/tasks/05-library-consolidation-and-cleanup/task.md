# 05-library-consolidation-and-cleanup: Konsolidierung und projektweite Bereinigung abschließen

Nach den Projektgruppen werden verbleibende Inkonsistenzen über die Solution bereinigt: vereinheitlichte Package-Stände, Entfernen obsoleter Paketreferenzen (z. B. NuGet.0003-Fälle) und finale Harmonisierung von Build-Einstellungen.

Diese Phase sichert, dass keine halb migrierten Konfigurationen zurückbleiben.

**Done when**: Obsolete Paketverwendungen sind bereinigt, Package-Stände konsistent, und alle migrierten Projektdateien sind auf finalem net10.0-Zustand.

## Scope Inventory
- Verbleibende nicht-migrierte Projekte laut Repo-Scan:
  - `Charger.Original/Charger.Original.csproj`
  - `Charger.Final/Charger.Final.csproj`
  - `Charger.Final.Tests/Charger.Final.Tests.csproj`
  - `06_GildedRose/C_Refactored/GildedRoseKata.Refactored.csproj`
  - `06_GildedRose/C_Refactored.Tests/GildedRoseKata.Refactored.Tests.csproj`
  - `06_GildedRose/C_Refactored2/GildedRoseKata.Refactored2.csproj`
  - `06_GildedRose/C_Refactored2.Tests/GildedRoseKata.Refactored2.Tests.csproj`

## Research Findings
- Alle verbleibenden Projekte sind SDK-Style und können direkt auf `net10.0` retargeted werden.
- Für konsistente Paketstände werden `xunit.runner.visualstudio`-Versionen in den GildedRose-Testprojekten auf `3.1.4` harmonisiert.
- Die Konsolidierung wird mit vollständigem Build plus relevanten Testläufen validiert.
