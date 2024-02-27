<a name="v0.55.0"></a>
## [v0.55.0] - 2024-02-27

### BREAKING CHANGE

### Cloudsave
The following operations are moved to a different package and the corresponding wrapper methods follows.
```
- AccelByte.Sdk/Api/Cloudsave/Operation/{ Tags -> AdminTags }/AdminDeleteTagHandlerV1
- AccelByte.Sdk/Api/Cloudsave/Operation/{ Tags -> AdminTags }/AdminListTagsHandlerV1
- AccelByte.Sdk/Api/Cloudsave/Operation/{ Tags -> AdminTags }/AdminPostTagHandlerV1
- AccelByte.Sdk/Api/Cloudsave/Operation/{ Tags -> AdminTags }/PublicListTagsHandlerV1
```

### IAM
- Operation `AccelByte.Sdk.Api.Iam.Operation.PublicPartialUpdateUserV3`
    - body type changed from `ModelUserUpdateRequestV3 ?` to `ModelPublicUserUpdateRequestV3 ?`
- Operation `AccelByte.Sdk.Api.Iam.Operation.UpdateUserV3`
    - body type changed from `ModelUserUpdateRequestV3 ?` to `ModelPublicUserUpdateRequestV3 ?`
- Operation `AccelByte.Sdk.Api.Iam.Operation.PublicUpdateUserV4`
    - body type changed from `ModelUserUpdateRequestV3 ?` to `ModelPublicUserUpdateRequestV3 ?`

[v0.55.0]: https://github.com/AccelByte/accelbyte-csharp-sdk/compare/v0.54.0...v0.55.0