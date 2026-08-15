# 04.02-ibanvalidation: IbanValidation inkl. Tests und API-Anpassungen auf net10.0

## Objective
Upgrade von IbanValidation inkl. IbanValidation.Tests auf net10.0 und Inline-Fix für gemeldete API-Kompatibilitätsänderungen (Api.0002).

## Scope
- IbanValidation/IbanValidation.csproj
- IbanValidation.Tests/IbanValidation.Tests.csproj

## Done when
- Beide Projekte targeten net10.0
- API-Kompatibilitätsanpassungen sind umgesetzt
- Build und Tests erfolgreich

## Scope Inventory
- **Projekte**: IbanValidation, IbanValidation.Tests.
- **Concerns**: TFM-Anhebung beider Projekte und API-Update für `Api.0002` (`System.Numerics.BigInteger` in `IbanValidationService.cs`).
- **Assessment-Signale**:
  - `IbanValidation`: `Project.0002` + `Api.0002` in `IbanValidationService.cs` (Zeile 44)
  - `IbanValidation.Tests`: `Project.0002`, optionale `NuGet.0005` ohne Inkompatibilität

## Research Findings
- Beide Projekte sind SDK-Style und aktuell auf `net9.0`.
- Für die API-Stelle wird der BigInteger-basierte Modulo-Check durch ein chunked Mod-97-Verfahren ersetzt, um Kompatibilitätsrisiko zu eliminieren.
- Testpakete bleiben unverändert, da kompatibel.
