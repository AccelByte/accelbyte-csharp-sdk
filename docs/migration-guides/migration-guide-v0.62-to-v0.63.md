<a name="v0.63.0"></a>
## [v0.63.0] - 2024-06-20

### BREAKING CHANGE

### Challenge

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Challenge/Operation/ChallengeConfiguration/AdminUpdateChallenge`
    - `body` is changed from `ModelsUpdateChallengeRequest` to `ModelUpdateChallengeRequest`

### IAM

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Iam/Operation/UsersV4/AdminDisableMyAuthenticatorV4`
    - `body` is now required
- Operation `AccelByte.Sdk/Api/Iam/Operation/UsersV4/AdminDisableMyBackupCodesV4`
    - `body` is now required
- Operation `AccelByte.Sdk/Api/Iam/Operation/UsersV4/AdminDisableMyEmailV4`
    - `body` is now required
- Operation `AccelByte.Sdk/Api/Iam/Operation/UsersV4/PublicDisableMyAuthenticatorV4`
    - `body` is now required
- Operation `AccelByte.Sdk/Api/Iam/Operation/UsersV4/PublicDisableMyBackupCodesV4`
    - `body` is now required
- Operation `AccelByte.Sdk/Api/Iam/Operation/UsersV4/PublicDisableMyEmailV4`
    - `body` is now required

### Inventory

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Inventory/Operation/PublicItems/PublicListItems`
    - parameter `QtyGte` is removed

### Platform

The following operation(s) has been updated.
- Operation `AccelByte.Sdk/Api/Platform/Operation/Item/QueryItems1`
    - renamed to `QueryItemsV2`
- Operation `AccelByte.Sdk/Api/Platform/Operation/Item/GetPaymentMerchantConfig`
    - parameter `id` is replaced by `namespace_`
    - `GetPaymentMerchantConfig1` is available as an alternative operation if `id` parameter is required.

[v0.63.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.62.0...v0.63.0