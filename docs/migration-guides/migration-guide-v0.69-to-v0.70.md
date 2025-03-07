<a name="v0.70.0"></a>
## [0.70.0] - 2025-03-07

### BREAKING CHANGE

### ams

- Model `AccelByte.Sdk.Api.Ams.Model.ApiFleetServerConnectionInfoResponse`
    - field `ExpiresAt` type changed from `ApiTime?` to `DateTime?`.
- Model `AccelByte.Sdk.Api.Ams.Model.ApiTime` is removed.
- Model `AccelByte.Sdk.Api.Ams.Model.TimeLocation` is removed.
- Model `AccelByte.Sdk.Api.Ams.Model.TimeZone` is removed.
- Model `AccelByte.Sdk.Api.Ams.Model.TimeZoneTrans` is removed.

- Operation `AccelByte.Sdk/Api/Ams/Operation/FleetList`
    - parameter `Desc` is removed.
    - new parameter `sortDirection` is introduced.

### social

- Operation `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicQueryUserStatItems`
    - is switched with `AccelByte.Sdk/Api/Social/Operation/UserStatistic/PublicQueryUserStatItems1`

### platform

- Operation `AccelByte.Sdk/Api/Platform/Operation/Item/DisableItem`
    - request body is now required.

### session

- Model `AccelByte.Sdk.Api.Session.Model.ApimodelsUpdateGamesessionDSInformationRequest
    - field `ClientVersion` is removed.
    - field `GameMode` is removed.