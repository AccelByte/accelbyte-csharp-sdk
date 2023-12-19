<a name="v0.50.0"></a>
## [v0.50.0] - 2023-12-19

### BREAKING CHANGE

### AMS
The following model(s) are renamed.
```
- AccelByte.Sdk.Api.Ams.Model.{ ApiArtifactSamplingRuleResponse -> ApiArtifactSamplingRule }
- AccelByte.Sdk.Api.Ams.Model.{ ApiArtifactTypeSamplingRulesResponse.cs -> ApiArtifactTypeSamplingRules }
- AccelByte.Sdk.Api.Ams.Model.{ ApiFleetArtifactsSampleRulesResponse.cs -> ApiFleetArtifactsSampleRules }
```

The following operations are moved to a different package and the corresponding wrapper methods follows.
```
- AccelByte.Sdk/Api/Ams/Operation/{ Images -> Artifacts }/FleetArtifactSamplingRulesGet
```

### Platform
The following model(s) are renamed.
```
- AccelByte.Sdk.Api.Platform.Model.{ CatalogChangePagingSlicedResult.cs -> TradeActionPagingSlicedResult.cs }
```

The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Platform.Operation.QueryChanges`
    - Return type changed from `CatalogChangePagingSlicedResult?` to `CatalogChangePagingResult?`
- Operation `AccelByte.Sdk.Api.Platform.Operation.DebitByWalletPlatform`
    - Request data moved from `body` to `request`.

### Session
The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Session.Operation.GetSessionServerSecret`
    - Request body is removed.

### Social
The following operations are moved to a different package and the corresponding wrapper methods follows.
```
- AccelByte.Sdk/Api/Social/Operation/{ StatConfiguration -> StatCycleConfiguration }/ImportStatCycle
```

[v0.50.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.49.0...v0.50.0
