<a name="v0.59.0"></a>
## [v0.59.0] - 2024-04-16

### BREAKING CHANGE

### AMS
- Model `AccelByte.Sdk.Api.Ams.Model.ApiDevelopmentServerConfigurationCreateRequest`
    - field `CommandLine ` renamed to `commandLineArguments`.
- Model `AccelByte.Sdk.Api.Ams.Model.ApiDevelopmentServerConfigurationGetResponse`
    - field `CommandLine ` renamed to `commandLineArguments`.
- Operation `AccelByte.Sdk.Api.Ams.Operation.DevelopmentServerConfigurationList`
    - response changed from `List<Model.ApiDevelopmentServerConfigurationGetResponse>?` to `ApiDevelopmentServerConfigurationListResponse?`

### Chat
- Model `AccelByte.Sdk.Api.Chat.Model.ModelsCategoryHook`
    - field `Driver ` type changed from `ModelsCategoryHookDriver?` to `string?`

[v0.59.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.58.0...v0.59.0