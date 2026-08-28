# S1eepeng.NuGetOidcReplayLab

A minimal calculator library used to study NuGet.org Trusted Publishing, GitHub OIDC token exchange, temporary API keys, and replay behavior.

```csharp
using S1eepeng.NuGetOidcReplayLab;

decimal total = Calculator.Add(12.5m, 7.5m);       // 20.0
decimal ratio = Calculator.Divide(total, 4m);      // 5.0
```

The package exposes `Add`, `Subtract`, `Multiply`, and `Divide`. Division by zero throws `DivideByZeroException`.

This repository is intentionally small so the authentication and HTTP evidence remain the focus of the experiment.

