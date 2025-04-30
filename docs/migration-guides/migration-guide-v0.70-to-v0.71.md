<a name="v0.71.0"></a>
## [0.71.0] - 2025-05-02

### BREAKING CHANGE

### csm

- Operation `AccelByte.Sdk/Api/Csm/Operation/SaveSecretV2`
    - Request body changed from `ApimodelSaveConfigurationV2Request` to `ApimodelSaveSecretConfigurationV2Request`.
- Operation `AccelByte.Sdk/Api/Csm/Operation/UpdateSecretV2`
    - Request body changed from `ApimodelUpdateConfigurationV2Request` to `ApimodelUpdateSecretConfigurationV2Request`.

### iam

- Model `AccelByte.Sdk.Api.Iam.Model.ModelUserResponseV3
    - Data type for `Tags` field is changed from `List<string>?` to `List<ModelTagDetail>?`.

- Operation `AccelByte.Sdk/Api/Iam/Operation/Users/AdminListUserIDByUserIDsV3`
    - Request body changed from `ModelUserIDsRequest` to `ModelAdminBulkUserRequest`.