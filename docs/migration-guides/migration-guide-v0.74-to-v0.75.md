<a name="v0.75.0"></a>
## [0.75.0] - 2025-09-23

### BREAKING CHANGE

### platform

- Fix wrong operation ids naming involving `QueryEntitlements` and `QueryEntitlements1`

    - Operation `AccelByte.Sdk.Api.Platform.Operation.QueryEntitlements` is now `AccelByte.Sdk.Api.Platform.Operation.QueryEntitlementsByItemIds`
    - Operation `AccelByte.Sdk.Api.Platform.Operation.QueryEntitlements1` is now `AccelByte.Sdk.Api.Platform.Operation.QueryEntitlements`
