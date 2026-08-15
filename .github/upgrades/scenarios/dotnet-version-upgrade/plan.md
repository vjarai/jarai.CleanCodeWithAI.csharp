# .NET Version Upgrade Plan

## Overview

**Target**: Gesamte Solution auf .NET 10 (net10.0) anheben.
**Scope**: Große Solution mit 43 Projekten (net8.0/net9.0), inklusive Testprojekten und einzelnen API-/NuGet-Risiken.

### Selected Strategy
**Top-Down (Application-First)** — Anwendungen und zugehörige Tests zuerst, mit anschließender Konsolidierung.
**Rationale**: Bei 43 Projekten ist ein inkrementelles, gruppiertes Vorgehen stabiler als ein Big-Bang-Upgrade.

## Tasks

### 01-prerequisites: SDK- und Build-Voraussetzungen auf .NET 10 absichern
Vor den eigentlichen Projektänderungen wird die Toolchain für net10.0 validiert und die Repository-Basis auf konsistente Build-Bedingungen gebracht. Dazu gehört die Prüfung von SDK-Verfügbarkeit und global.json-Kompatibilität sowie eine Baseline-Validierung für den aktuellen Zustand auf dem Arbeitsbranch.

Dieser Task reduziert Folgerisiken in allen nachgelagerten Upgradeschritten, weil Infrastrukturprobleme früh erkannt werden.

**Done when**: .NET 10 SDK ist validiert, ggf. globale SDK-Pins sind kompatibel, und die Baseline-Validierung ist dokumentiert.

---

### 02-application-group-core-samples: Kernbeispiele und einfache Einzelprojekte auf net10.0 upgraden
Diese Taskgruppe umfasst unabhängige oder gering gekoppelte Beispielprojekte mit niedrigerem Migrationsrisiko (z. B. Async1.Breakfast, DependencyInversion, Dokumentation, InterfaceSegregation, PerformanceTuning, PromptFiles, RepositoryCustomInstructions, SecurityVulnerabilities).

Fokus ist ein mechanisches TFM-Upgrade mit Package-Updates und schneller Stabilisierung, damit ein belastbarer net10.0-Bestand für weitere Gruppen entsteht.

**Done when**: Alle Projekte der Gruppe targeten net10.0, bauen fehlerfrei, und relevante Tests/Laufchecks sind grün.

---

### 03-application-group-domain-katas: Domänen-Katas inklusive zugehöriger Tests upgraden
Diese Aufgabe behandelt gekoppelte Kata-Paare und ihre Tests (u. a. TicTacToe, Telefon, GildedRose, Kniffel, OpenClosed, Liskov, MarsRover, Routenplaner). Die Bewertung zeigt in diesen Clustern wiederkehrende Paket- und TFM-Anpassungen.

Die Durchführung erfolgt clusterweise, damit Fehlerbilder lokal bleiben und jede Gruppe vor dem nächsten Cluster abgeschlossen validiert werden kann.

**Done when**: Alle betroffenen Kata-Projekte und Testprojekte laufen auf net10.0, Build ist stabil, und Testausführung ist pro Cluster erfolgreich.

---

### 04-application-group-integration: Integrations- und Spezialprojekte auf net10.0 heben
Diese Gruppe deckt höher-riskante Projekte mit zusätzlichen Findings ab, insbesondere IbanValidation (Api.0002) und OpenApiAutomation (Api.0003) sowie Datenbank, ModelContextProtocol und MarsroverKata.Final.

Neben dem TFM-Upgrade werden hier API-Kompatibilitätsanpassungen und Package-Updates direkt im jeweiligen Projekt mit umgesetzt (Fix Inline), um keine technischen Schulden zu verschieben.

**Done when**: Alle Integrations-/Spezialprojekte targeten net10.0, identifizierte API-Brüche sind behoben, und projektbezogene Tests/Builds sind erfolgreich.

---

### 05-library-consolidation-and-cleanup: Konsolidierung und projektweite Bereinigung abschließen
Nach den Projektgruppen werden verbleibende Inkonsistenzen über die Solution bereinigt: vereinheitlichte Package-Stände, Entfernen obsoleter Paketreferenzen (z. B. NuGet.0003-Fälle) und finale Harmonisierung von Build-Einstellungen.

Diese Phase sichert, dass keine halb migrierten Konfigurationen zurückbleiben.

**Done when**: Obsolete Paketverwendungen sind bereinigt, Package-Stände konsistent, und alle migrierten Projektdateien sind auf finalem net10.0-Zustand.

---

### 06-final-validation: Vollständige Endvalidierung der Solution durchführen
Zum Abschluss wird die gesamte Solution mit net10.0 vollständig gebaut und getestet. Offene Restpunkte aus der Bewertung werden gegen den finalen Stand geprüft.

Dieser Task ist die Freigabeschranke, bevor die Migration als abgeschlossen gilt.

**Done when**: Gesamte Solution baut ohne Fehler, relevante Tests laufen erfolgreich, und keine blockierenden Upgrade-Issues sind mehr offen.
