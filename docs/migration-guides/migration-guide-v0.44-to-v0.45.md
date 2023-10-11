<a name="v0.45.0"></a>
## [v0.45.0] - 2023-10-11

## BREAKING CHANGE

### GDPR
The following operations are moved to a different package and the corresponding wrapper methods follows.
```
- AccelByte.Sdk/Api/Gdpr/Operation/ { DataRetrieval → Configuration } /DeleteAdminEmailConfiguration
- AccelByte.Sdk/Api/Gdpr/Operation/ { DataRetrieval → Configuration } /GetAdminEmailConfiguration
- AccelByte.Sdk/Api/Gdpr/Operation/ { DataRetrieval → Configuration } /SaveAdminEmailConfiguration
- AccelByte.Sdk/Api/Gdpr/Operation/ { DataRetrieval → Configuration } /UpdateAdminEmailConfiguration
```

[v0.45.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.44.0...v0.45.0