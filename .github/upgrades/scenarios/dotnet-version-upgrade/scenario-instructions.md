# .NET Version Upgrade

## Upgrade Options
**Source**: .github/upgrades/scenarios/dotnet-version-upgrade/upgrade-options.md

### Strategy
- Upgrade Strategy: Top-Down

### Compatibility
- Unsupported API Handling: Fix Inline

## Strategy
**Selected**: Top-Down (Application-First)
**Rationale**: Große Lösung mit 43 Projekten auf modernem .NET; inkrementelles Vorgehen reduziert Risiko und hält die Migration steuerbar.

### Execution Constraints
- Anwendungen und deren Testprojekte zuerst upgraden; abhängige Bibliotheken nur bei Bedarf mitziehen.
- Keine vorzeitige breite Multi-Targeting-Einführung; nur wo ein Anwendungs-Upgrade es erzwingt.
- Phase „Konsolidierung“ erst starten, wenn alle Anwendungsgruppen auf net10.0 sind.
- Nach jedem Task vollständigen Build und relevante Tests validieren.
- API-Breaking-Changes (Api.0002/Api.0003) werden im jeweiligen Task direkt behoben (Fix Inline).

## Preferences
- **Flow Mode**: Automatic
- **Target Framework**: net10.0
- **Upgrade Scope**: Entire solution

## Source Control
- **Source Branch**: master
- **Working Branch**: upgrade-dotnet-10
- **Commit Strategy**: After Each Task
- **Branch Sync**: Auto (Merge)

## User Preferences
### Execution Style
- Fehlgeschlagene (rote) Tests dürfen für die Migration vorübergehend auf Skip gesetzt werden.

### Custom Instructions
#### 03.03-gildedrose
- Den fehlschlagenden Conjured-Test im Original-Testprojekt auf Skip setzen, um den Upgrade-Flow fortzusetzen.

## Key Decisions Log
- 2026-08-15: Für den blockierenden GildedRose-Test wurde entschieden, den roten Test auf Skip zu setzen statt Domänenlogik sofort anzupassen.
