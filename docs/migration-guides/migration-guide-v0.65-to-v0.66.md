<a name="v0.66.0"></a>
## [v0.66.0] - 2024-10-10

### BREAKING CHANGE

### AMS

- Model `AccelByte.Sdk.Api.Ams.Model.ApiInstanceTypeDescriptionResponse`
    - Renamed to `ApiAvailableInstanceType`.
- Model `AccelByte.Sdk.Api.Ams.Model.ApiFleetParameters`
    - field `DsHostConfiguration` type changed from `ApiDSHostConfiguration` to `ApiDSHostConfigurationParameters`.

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetServers`
    - parameter `Count ` type change from `string?` to `long?`.

### Challenge

- Model `AccelByte.Sdk.Api.Challenge.Model.ModelUserReward`
    - String enum value `CLAIM` renamed to `CLAIMED` in `ModelUserRewardStatus`.

### Cloudsave

- Model `AccelByte.Sdk.Api.Cloudsave.Model.ModelsAdminConcurrentRecordRequest`
    - field `UpdatedAt` type changed from `string?` to `DateTime?`.
- Model `AccelByte.Sdk.Api.Cloudsave.Model.ModelsAdminGameConcurrentRecordRequest`
    - field `UpdatedAt` type changed from `string?` to `DateTime?`.
- Model `AccelByte.Sdk.Api.Cloudsave.Model.ModelsAdminPlayerConcurrentRecordRequest`
    - field `UpdatedAt` type changed from `string?` to `DateTime?`.
- Model `AccelByte.Sdk.Api.Cloudsave.Model.ModelsConcurrentRecordRequest`
    - field `UpdatedAt` type changed from `string?` to `DateTime?`.

### Legal

- Model `AccelByte.Sdk.Api.Legal.Model.RetrieveUserEligibilitiesResponse`
    - field `HiddenPublic` is removed.

### Platform

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Platform/Operation/Entitlement/QueryEntitlements`
    - is switched with `QueryEntitlements1`.
- Operation `AccelByte.Sdk/Api/Platform/Operation/Fulfillment/QueryFulfillments`
    - response type changed from `FulfillmentHistoryPagingSlicedResult?` to `FulfillmentPagingSlicedResult?`.
- Operation `AccelByte.Sdk/Api/Platform/Operation/PaymentStation/PublicGetQRCode`
    - response type changed from `byte[]?` to `BinarySchema?`.

### Session

All operation(s) under `AccelByte.Sdk/Api/Session/Operation/Operations` have been removed.

### Session History

- Model `AccelByte.Sdk.Api.Sessionhistory.Model.ApimodelsXRayTicketObservabilityRequest`
    - field `PartyID` is removed.

[v0.66.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.65.0...v0.66.0