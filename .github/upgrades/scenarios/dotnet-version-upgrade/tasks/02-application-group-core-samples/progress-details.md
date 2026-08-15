# Progress Details — 02-application-group-core-samples

## Summary
Die Core-Sample-Projektgruppe wurde von `net9.0` auf `net10.0` angehoben.

## Scope umgesetzt
- Async1.Breakfast
- DependencyInversion
- Dokumentation
- InterfaceSegregation
- PerformanceTuning
- PromptFiles
- RepositoryCustomInstructions
- SecurityVulnerabilities

## Änderungen
- In allen 8 Projektdateien wurde `<TargetFramework>net9.0</TargetFramework>` auf `<TargetFramework>net10.0</TargetFramework>` geändert.
- Keine zusätzlichen Code- oder Paketmigrationen waren laut Assessment für diese Gruppe erforderlich.
- `task.md` wurde mit Scope Inventory und Research Findings angereichert.

## Validierung
- Vollständiger Solution-Build erfolgreich (`run_build`: "Buildvorgang erfolgreich").
- Für diese Gruppe existieren keine dedizierten separaten Testprojekte; der erfolgreiche Vollbuild dient als relevanter Laufcheck.

## Done-When Check
- Alle Projekte der Gruppe targeten `net10.0`: ✅
- Build fehlerfrei: ✅
- Relevante Laufchecks/Testkontext erfüllt: ✅

## Files Modified
- `.github/upgrades/scenarios/dotnet-version-upgrade/tasks/02-application-group-core-samples/task.md`
- `Async1.Breakfast/Async1.Breakfast.csproj`
- `DependencyInversion/DependencyInversion.csproj`
- `Dokumentation/Dokumentation.csproj`
- `InterfaceSegragation/InterfaceSegregation.csproj`
- `PerformanceTuning/PerformanceTuning.csproj`
- `PromptFiles/PromptFiles.csproj`
- `RepositoryCustomInstructions/RepositoryCustomInstructions.csproj`
- `SecurityVulnerabilities/SecurityVulnerabilities.csproj`
- `.github/upgrades/scenarios/dotnet-version-upgrade/tasks/02-application-group-core-samples/progress-details.md`
