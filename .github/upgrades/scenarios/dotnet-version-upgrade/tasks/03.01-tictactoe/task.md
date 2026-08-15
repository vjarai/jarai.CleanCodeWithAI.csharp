# 03.01-tictactoe: TicTacToe-Projekte und Tests auf net10.0 upgraden

## Objective
Upgrade der TicTacToe-Varianten (Original, Testable, Final) inklusive Testprojekten auf net10.0 mit stabiler Build- und Testbasis.

## Scope
- 02_TicTacToe/A_Original/TicTacToe.Original.csproj
- 02_TicTacToe/B_Testable/TicTacToe.Testable.csproj
- 02_TicTacToe/B_Testable.Tests/TicTacToe.Testable.Tests.csproj
- 02_TicTacToe/D_Final/TicTacToe.Final.csproj
- 02_TicTacToe/D_Final.Tests/TicTacToe.Final.Tests.csproj

## Done when
- Alle Scope-Projekte targeten net10.0
- Build für Scope und Solution erfolgreich
- Relevante Tests für den Scope laufen erfolgreich

## Scope Inventory
- **Projekte**: 3 Produktionsprojekte + 2 Testprojekte im TicTacToe-Cluster.
- **Concerns**: TFM-Upgrade auf `net10.0`, Entfernung überflüssiger Paket-Referenzen (`NuGet.0003`) in den Produktionsprojekten, Build-/Testvalidierung.
- **Assessment-Signale**:
  - `Project.0002` in allen 5 Projekten
  - `NuGet.0003` in `A_Original`, `B_Testable`, `D_Final`
  - `NuGet.0005` (optional) in den Testprojekten, aktuell kompatibel

## Research Findings
- Alle 5 Projekte sind SDK-Style und aktuell auf `net9.0`.
- `Microsoft.CSharp` und `System.Data.DataSetExtensions` sind laut Assessment in den drei Produktionsprojekten als im Framework enthalten markiert und werden entfernt.
- Testpakete sind kompatibel und werden in diesem Subtask nicht erzwungen aktualisiert.
