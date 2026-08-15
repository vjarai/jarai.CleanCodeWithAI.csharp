# 01-prerequisites: SDK- und Build-Voraussetzungen auf .NET 10 absichern

Vor den eigentlichen Projektänderungen wird die Toolchain für net10.0 validiert und die Repository-Basis auf konsistente Build-Bedingungen gebracht. Dazu gehört die Prüfung von SDK-Verfügbarkeit und global.json-Kompatibilität sowie eine Baseline-Validierung für den aktuellen Zustand auf dem Arbeitsbranch.

Dieser Task reduziert Folgerisiken in allen nachgelagerten Upgradeschritten, weil Infrastrukturprobleme früh erkannt werden.

**Done when**: .NET 10 SDK ist validiert, ggf. globale SDK-Pins sind kompatibel, und die Baseline-Validierung ist dokumentiert.
