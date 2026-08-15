# 04.03-openapiautomation: OpenApiAutomation auf net10.0 inkl. Verhalten-Änderungen (Api.0003)

## Objective
Upgrade von OpenApiAutomation auf net10.0 inklusive Behandlung gemeldeter Verhaltensänderungen (Api.0003) und ggf. Paketupdates.

## Scope
- OpenApiAutomation/OpenApiAutomation.csproj

## Done when
- Projekt targetet net10.0
- Relevante Api.0003-Anpassungen sind validiert
- Build und relevante Tests/Checks erfolgreich

## Scope Inventory
- **Projekt**: OpenApiAutomation.
- **Concerns**: TFM-Anhebung auf `net10.0` und Validierung der gemeldeten `Api.0003`-Hinweise in `Program.cs` (Uri-/HttpContent-Verwendung).
- **Assessment-Signale**:
  - `Project.0002` im Projektfile
  - `Api.0003` in `Program.cs` bei `Uri`-Initialisierung und `ReadAsStringAsync`

## Research Findings
- Projekt ist SDK-Style und aktuell auf `net9.0`.
- Uri-Verwendung wird explizit als absolute Uri (`UriKind.Absolute`) festgelegt, um Verhaltensspielräume zu minimieren.
- Keine weiteren Paket- oder API-Migrationen erforderlich; Validierung erfolgt über erfolgreichen Build und Code-Review der markierten Stellen.
