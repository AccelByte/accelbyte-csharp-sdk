<a name="v0.51.0"></a>
## [v0.51.0] - 2024-01-03

### BREAKING CHANGE

### Platform
The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Platform.Operation.ConsumeUserEntitlement`
    - body type changed from `EntitlementDecrement?` to `AdminEntitlementDecrement?`
- Operation `AccelByte.Sdk.Api.Platform.Operation.SellUserEntitlement`
    - body type changed from `EntitlementSoldRequest?` to `AdminEntitlementSoldRequest?`.

### Session
The following model(s) are renamed.
```
- AccelByte.Sdk.Api.Session.Model.{ ModelsUserInfo -> ModelsUserInfoResponse }
```

[v0.51.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.50.0...v0.51.0
