# Upgrade Options — jarai.CleanCodeWithAI.csharp

Assessment: 43 Projekte (net8.0/net9.0), 82 Findings, API-Breaking-Changes erkannt.

## Strategy

### Upgrade Strategy
Die Solution hat 43 Projekte; für moderne .NET-Upgrades mit hoher Projektanzahl ist ein inkrementelles Vorgehen robuster.

| Value | Description |
|-------|-------------|
| **Top-Down** (selected) | Zuerst Einstiegspunkte/Apps upgraden, Shared Libraries temporär kompatibel halten und danach konsolidieren. |
| All-at-Once | Alle Projekte in einem einzigen Durchlauf upgraden; schnell, aber mit höherem Risiko für längere Build-Break-Phasen. |

## Compatibility

### Unsupported API Handling
Die Bewertung enthält API-Änderungen (u. a. Api.0002/Api.0003), daher ist eine explizite Behandlung komplexer API-Ersetzungen relevant.

| Value | Description |
|-------|-------------|
| **Fix Inline** (selected) | Alle API-Änderungen direkt im jeweiligen Task beheben, ohne Stub-Nacharbeit. |
| Defer Complex Changes | Komplexe API-Änderungen per kompilierbarem Stub verschieben und später separat auflösen. |
