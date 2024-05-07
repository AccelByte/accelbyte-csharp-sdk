<a name="v0.61.0"></a>
## [v0.61.0] - 2024-05-07

### BREAKING CHANGE

### Basic
The following operations are moved to a different package and the corresponding wrapper methods follows.
```
- AccelByte.Sdk/Api/Basic/Operation/{ EQU8Config -> Config }/DeleteConfig
```

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Basic/Operation/Config/GetConfig1`
    - renamed to `GetConfig`
- Operation `AccelByte.Sdk/Api/Basic/Operation/Config/UpdateConfig1`
    - renamed to `UpdateConfig`

All operation(s) under `AccelByte.Sdk/Api/Basic/Operation/EQU8Config` have been removed.
All operation(s) under `AccelByte.Sdk/Api/Basic/Operation/UserAction` have been removed.

### Legal
The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Legal/Operation/AgreementWithNamespace/DownloadExportedAgreementsInCSV`
    - parameter `policyVersionId` is removed
- Operation `AccelByte.Sdk/Api/Legal/Operation/AgreementWithNamespace/InitiateExportAgreementsToCSV`
    - parameter `policyVersionId` is removed

[v0.61.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.60.0...v0.61.0