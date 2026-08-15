# .NET Version Upgrade Progress

## Overview

Upgrade der gesamten Solution auf .NET 10 mit Top-Down-Strategie in mehreren Projektgruppen. Zuerst werden Voraussetzungen und risikoärmere Gruppen umgesetzt, danach Integrationsprojekte und finale Konsolidierung. Abschließend erfolgt eine vollständige Build- und Testvalidierung.

**Progress**: 1/6 tasks complete <progress value="17" max="100"></progress> 17%

## Tasks

- ✅ 01-prerequisites: SDK- und Build-Voraussetzungen auf .NET 10 absichern ([Content](tasks/01-prerequisites/task.md), [Progress](tasks/01-prerequisites/progress-details.md))
- 🔲 02-application-group-core-samples: Kernbeispiele und einfache Einzelprojekte auf net10.0 upgraden
- 🔲 03-application-group-domain-katas: Domänen-Katas inklusive zugehöriger Tests upgraden
- 🔲 04-application-group-integration: Integrations- und Spezialprojekte auf net10.0 heben
- 🔲 05-library-consolidation-and-cleanup: Konsolidierung und projektweite Bereinigung abschließen
- 🔲 06-final-validation: Vollständige Endvalidierung der Solution durchführen
