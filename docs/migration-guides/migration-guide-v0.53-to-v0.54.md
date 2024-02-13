<a name="v0.54.0"></a>
## [v0.54.0] - 2024-02-13

### BREAKING CHANGE

### AMS
The following model(s) has been updated.
    - Model `AccelByte.Sdk.Api.Ams.Model.ApiDSHistoryEvent`
        - field `GameSession` is removed

The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Ams.Operation.ArtifactGet`
    - Return type changed from `List<ApiArtifactResponse>?` to `ApiArtifactListResponse?`

### Cloudsave
The following operation(s) has been updated.
- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminGetGameBinaryRecordV1`
    - Return type changed from `ModelsGameBinaryRecordResponse?` to `ModelsGameBinaryRecordAdminResponse?`
- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminListGameBinaryRecordsV1`
    - Return type changed from `ModelsListGameBinaryRecordsResponse?` to `ModelsListGameBinaryRecordsAdminResponse?`
- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutGameBinaryRecordV1`
    - Return type changed from `ModelsGameBinaryRecordResponse?` to `ModelsGameBinaryRecordAdminResponse?`
- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutGameBinaryRecorMetadataV1`
    - Return type changed from `ModelsGameBinaryRecordResponse?` to `ModelsGameBinaryRecordAdminResponse?`
- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminGetGameRecordHandlerV1`
    - Return type changed from `ModelsGameRecordResponse?` to `ModelsGameRecordAdminResponse?`
- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPostGameRecordHandlerV1`
    - Return type changed from `ModelsGameRecordResponse?` to `ModelsGameRecordAdminResponse?`
- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPutGameRecordHandlerV1`
    - Return type changed from `ModelsGameRecordResponse?` to `ModelsGameRecordAdminResponse?`

### IAM
- Operation `AccelByte.Sdk.Api.Iam.Operation.CreateUserFromInvitationV3`
    - body type changed from `ModelUserCreateFromInvitationRequestV3?` to `ModelUserCreateRequestV3?`
- Operation `AccelByte.Sdk.Api.Iam.Operation.CreateUserFromInvitationV4`
    - body type changed from `ModelUserCreateFromInvitationRequestV4?` to `AccountCreateUserRequestV4?`


[v0.54.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.53.0...v0.54.0
