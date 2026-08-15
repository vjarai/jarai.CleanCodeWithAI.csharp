# 04.01-datenbank-modelcontext: Datenbank und ModelContextProtocol auf net10.0 upgraden

## Objective
TFM-Upgrade und notwendige Paketanpassungen für Datenbank und ModelContextProtocol auf net10.0.

## Scope
- Datenbank/Datenbank.csproj
- ModelContextProtocol/ModelContextProtocol.csproj

## Done when
- Beide Projekte targeten net10.0
- Build erfolgreich
- Relevante projektnahe Tests/Checks erfolgreich

## Scope Inventory
- **Projekte**: Datenbank, ModelContextProtocol.
- **Concerns**: TFM-Anhebung beider Projekte auf `net10.0`, EF-Core-Paketanhebung in Datenbank gemäß Assessment (`NuGet.0002`).
- **Assessment-Signale**:
  - `Datenbank`: `Project.0002` + `NuGet.0002` (EF Core 9.0.8 → 10.0.11)
  - `ModelContextProtocol`: `Project.0002`

## Research Findings
- Beide Projekte sind SDK-Style und derzeit auf `net9.0`.
- Für `Datenbank` sind `Microsoft.EntityFrameworkCore` und `Microsoft.EntityFrameworkCore.SqlServer` auf `10.0.11` anzuheben.
- Für `ModelContextProtocol` ist nur die TFM-Anhebung erforderlich.
