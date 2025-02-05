<a name="v0.69.0"></a>
## [v0.69.0] - 2025-02-05

### BREAKING CHANGE

### AMS

- Model `AccelByte.Sdk.Api.Ams.Model.ApiInstanceTypeForNamespaceResponse `
    - Renamed to `ApiInstanceType`.
- Model `AccelByte.Sdk.Api.Ams.Model.ApiInstanceTypesForNamespaceResponse `
    - Renamed to `ApiInstanceTypesResponse`.

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Ams/Operation/AMSInfo/InfoSupportedInstances`
    - response type changed from `ApiInstanceTypesForNamespaceResponse?` to `ApiInstanceTypesResponse`.

### Challenge

- Model `AccelByte.Sdk.Api.Challenge.Model.ModelCreateGoalRequest`
    - field `Schedule` type changed from `ModelGoalSchedule?` to `ModelGoalScheduleRequest?`.
- Model `AccelByte.Sdk.Api.Challenge.Model.ModelUpdateGoalRequest`
    - field `Schedule` type changed from `ModelGoalSchedule?` to `ModelGoalScheduleRequest?`.

### Chat

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityCreateBulk`
    - response type changed from `ModelsDictionary?` to `void`.

### GDPR

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminGeneratePersonalDataURL`
    - parameter `password` is changed from required to optional.

### IAM

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Iam/Operation/UsersV4/PublicUpgradeHeadlessWithCodeV4Forward`
    - request body type changed from `AccountUpgradeHeadlessAccountWithVerificationCodeRequestV4 ` to `AccountUpgradeHeadlessAccountWithVerificationCodeForwardRequestV4`.

[v0.69.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.68.0...v0.69.0