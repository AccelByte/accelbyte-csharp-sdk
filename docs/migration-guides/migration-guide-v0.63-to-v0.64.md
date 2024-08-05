<a name="v0.64.0"></a>
## [v0.64.0] - 2024-08-05

### BREAKING CHANGE

### Challenge

- Model `AccelByte.Sdk.Api.Challenge.Model.ModelUserReward`
    - field `Status` type changed from `string?` to `ModelUserRewardStatus?` enum.
    - field `Type` type changed from `string?` to `ModelUserRewardType?` enum.

### Dslogmanager

- Model `AccelByte.Sdk.Api.Dslogmanager.Model.ModelsNotifPayloadServerStatusChange` renamed to `AccelByte.Sdk.Api.Dslogmanager.Model.ModelsNotifPayloadServerStatusChangeResponse `
    - field `Server` type changed from `ModelsServer?` to `ModelsServerResponse?`.
- Model `AccelByte.Sdk.Api.Dslogmanager.Model.ModelsListTerminatedServersResponse`
    - field `Data` type changed from `List<ModelsNotifPayloadServerStatusChange>?` to `List<ModelsNotifPayloadServerStatusChangeResponse>?` enum.

### DSMC

- Model `AccelByte.Sdk.Api.Dsmc.Model.ModelsImageRecord` renamed to `AccelByte.Sdk.Api.Dsmc.Model.ModelsImageRecordResponse`.

- Model `AccelByte.Sdk.Api.Dsmc.Model.ModelsListImagePatchesResponse`
    - field `Images` type change from `List<ModelsPatchImageRecord>?` to `List<ModelsPatchImageRecordResponse>?`.

- Model `AccelByte.Sdk.Api.Dsmc.Model.ModelsListImageResponse`
    - field `Images` type change from `List<ModelsImageRecord>?` to `List<ModelsImageRecordResponse>?`.

- Model `AccelByte.Sdk.Api.Dsmc.Model.ModelsListServerResponse`
    - field `Images` type change from `List<ModelsServer>?` to `List<ModelsServerDetailsResponse>?`.

- Operation `AccelByte.Sdk.Api.Dsmc.Operation.ImportImages` is **removed**.

- Operation `AccelByte.Sdk.Api.Dsmc.Operation.ExportImages` is **removed**.

- Operation `AccelByte.Sdk.Api.Dsmc.Operation.GetServer`
    - response type changed from `ModelsServer?` to `ModelsServerDetailsResponse?`.

### IAM

- Model `AccelByte.Sdk.Api.Iam.Model.AccountcommonAllowedPermission`
    - field `AllowedActions` type change from `List<long>?` to `List<int>?`.

- Model `AccelByte.Sdk.Api.Iam.Model.AccountcommonClientSelectedGroup`
    - field `SelectedActions` type change from `List<long>?` to `List<int>?`.

### Session History

- Model `AccelByte.Sdk.Api.Sessionhistory.Model.ModelsMatch`
    - field `Tickets ` type change from `List<ModelsTicket>?` to `List<ModelsMatchTicket>?`.


[v0.64.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.63.0...v0.64.0