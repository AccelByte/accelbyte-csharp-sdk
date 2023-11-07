<a name="v0.47.0"></a>
## [v0.47.0] - 2023-11-07

## BREAKING CHANGE

Added new method signature to `ITokenValidator` interface.
```
bool Validate(AccelByteSDK sdk, string accessToken, string permission, int action, string? aNamespace, string? userId);
```
This change will affect anyone who use `ITokenValidator` to create custom token validator.

`Platform Api` has new model named `Operation`. This will conflict with `Operation` class under `AccelByte.Sdk.Core` namespace. For those who explicitly use this class together with Platform Api's model namespace, please use full-qualified class name.

### IAM
The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Iam.Operation.RequestGameTokenResponseV3` is renamed to `AccelByte.Sdk.Api.Iam.Operation.RequestTargetTokenResponseV3`
- Operation `AccelByte.Sdk.Api.Iam.Operation.RequestGameTokenCodeResponseV3`
    - is renamed to `AccelByte.Sdk.Api.Iam.Operation.RequestTokenExchangeCodeV3`
    - response changed from `OauthmodelGameTokenCodeResponse` to `OauthmodelTargetTokenCodeResponse`

### AMS
The following model(s) has been renamed.
- `AccelByte.Sdk.Api.Ams.Model.ApiQOSServer` to `AccelByte.Sdk.Api.Ams.Model.ApiQoSServer`

The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Ams.Operation.InfoRegions`
    - response changed from `ApiRegionsResponse` to `ApiAMSRegionsResponse`

[v0.47.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.46.0...v0.47.0