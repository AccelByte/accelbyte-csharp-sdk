<a name="v0.41.0"></a>
## [v0.41.0] - 2023-08-15

### BREAKING CHANGE

### IAM
Operation's namespace changed for following endpoints:

- AccelByte.Sdk/Api/Iam/Operation/ { InputValidations → InputValidationsPublic } /PublicGetInputValidationByField
- AccelByte.Sdk/Api/Iam/Operation/ { InputValidations → InputValidationsPublic } /PublicGetInputValidations
- AccelByte.Sdk/Api/Iam/Operation/ { OAuth20 → OAuth20Public } /GetJWKSV3
- AccelByte.Sdk/Api/Iam/Operation/ { Users → UsersPublic } /CreateUserFromInvitationV3
- AccelByte.Sdk/Api/Iam/Operation/ { Users → UsersPublic } /GetAdminInvitationV3
- AccelByte.Sdk/Api/Iam/Operation/ { Users → UsersPublic } /PublicBulkGetUsers
- AccelByte.Sdk/Api/Iam/Operation/ { Users → UsersPublic } /PublicCreateUserV3
- AccelByte.Sdk/Api/Iam/Operation/ { Users → UsersPublic } /PublicForgotPasswordV3
- AccelByte.Sdk/Api/Iam/Operation/ { Users → UsersPublic } /PublicGetUserByUserIdV3
- AccelByte.Sdk/Api/Iam/Operation/ { Users → UsersPublic } /PublicVerifyRegistrationCode

[v0.41.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.40.0...v0.41.0
