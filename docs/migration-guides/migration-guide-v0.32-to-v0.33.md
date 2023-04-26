<a name="v0.32.0"></a>
## [v0.33.0] - 2023-04-27

### BREAKING CHANGE

### Lobby
The following operation(s) has been removed.
- `AccelByte.Sdk.Api.Lobby.Operation.Chat.AdminChatHistory`
- `AccelByte.Sdk.Api.Lobby.Operation.Chat.GetPersonalChatHistoryV1Public`
- `AccelByte.Sdk.Api.Lobby.Operation.Chat.PersonalChatHistory`


### Platform
The following model(s) has been updated.
- Model `AccelByte.Sdk.Api.Platform.Model.ItemCreate`
    - field `RegionData` has its type changed from `Dictionary<string, List<RegionDataItem>>?` to `Dictionary<string, List<RegionDataItemDTO>>?`

The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Platform.Operation.GetUserDLC`
    - Return type changed from `UserDLC?` to `List<UserDLCRecord>?`

### UGC
The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Ugc.Operation.AdminUpdateContentS3`
    - Body param changed from `ModelsUpdateContentRequest` to `ModelsAdminUpdateContentRequest`
- Operation `AccelByte.Sdk.Api.Ugc.Operation.SingleAdminUpdateContentS3`
    - Body param changed from `ModelsUpdateContentRequest` to `ModelsAdminUpdateContentRequest`

[v0.33.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.32.0...v0.33.0