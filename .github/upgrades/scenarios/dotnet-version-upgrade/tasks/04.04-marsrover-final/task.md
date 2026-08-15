# 04.04-marsrover-final: MarsroverKata.Final inkl. Tests von net8.0 auf net10.0

## Objective
Upgrade der MarsroverKata.Final-Projekte (App + Tests) von net8.0 auf net10.0 mit erforderlichen Paketanpassungen.

## Scope
- MarsroverKata.Final/MarsroverKata.Final/MarsroverKata.Final.csproj
- MarsroverKata.Final.Tests/MarsroverKata.Final.Tests.csproj

## Done when
- Beide Projekte targeten net10.0
- Build und Tests erfolgreich
- Keine blockierenden Upgrade-Issues im Scope

## Scope Inventory
- **Projekte**: MarsroverKata.Final, MarsroverKata.Final.Tests.
- **Concerns**: TFM-Anhebung von `net8.0` auf `net10.0` für App und Tests; Paketbereinigung gemäß Assessment (`NuGet.0002` für Newtonsoft.Json).
- **Assessment-Signale**:
  - `MarsroverKata.Final`: `Project.0002`, `NuGet.0002` (Newtonsoft.Json 13.0.4-beta1 → 13.0.4)
  - `MarsroverKata.Final.Tests`: `Project.0002`

## Research Findings
- Beide Projekte sind SDK-Style.
- Für `MarsroverKata.Final` wird `Newtonsoft.Json` auf stabile Version `13.0.4` gehoben.
- Optionale xUnit-v2-Hinweise (`NuGet.0005`) bleiben unverändert, da kompatibel und nicht blockierend.
