# 02-application-group-core-samples: Kernbeispiele und einfache Einzelprojekte auf net10.0 upgraden

Diese Taskgruppe umfasst unabhängige oder gering gekoppelte Beispielprojekte mit niedrigerem Migrationsrisiko (z. B. Async1.Breakfast, DependencyInversion, Dokumentation, InterfaceSegregation, PerformanceTuning, PromptFiles, RepositoryCustomInstructions, SecurityVulnerabilities).

Fokus ist ein mechanisches TFM-Upgrade mit Package-Updates und schneller Stabilisierung, damit ein belastbarer net10.0-Bestand für weitere Gruppen entsteht.

**Done when**: Alle Projekte der Gruppe targeten net10.0, bauen fehlerfrei, und relevante Tests/Laufchecks sind grün.

## Scope Inventory
- **Projekte in Scope**: Async1.Breakfast, DependencyInversion, Dokumentation, InterfaceSegregation, PerformanceTuning, PromptFiles, RepositoryCustomInstructions, SecurityVulnerabilities.
- **Distinct concerns**: TFM-Anhebung auf `net10.0`, Build-Validierung der Solution, keine API-Migrationen in dieser Gruppe.
- **Change signals aus Assessment**: Für alle 8 Projekte nur `Project.0002` (TargetFramework umstellen); keine zusätzlichen package-/API-Blocker in dieser Gruppe.

## Research Findings
- Alle 8 Projektdateien sind SDK-Style und aktuell single-targeted auf `net9.0`.
- Keine Multi-Targeting-Anforderung für diese Gruppe; direkter Replace von `TargetFramework` ist ausreichend.
- In dieser Gruppe ist nur in `SecurityVulnerabilities` ein explizites Paket (`Microsoft.Data.SqlClient 5.1.6`) vorhanden, laut Assessment kompatibel.
