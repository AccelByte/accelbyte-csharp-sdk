<a name="v0.47.0"></a>
## [v0.47.0] - 2023-11-07

## [DRAFT]

## BREAKING CHANGE

Added new method signature to `ITokenValidator` interface.
```
bool Validate(AccelByteSDK sdk, string accessToken, string permission, int action, string? aNamespace, string? userId);
```

This change will affect anyone who use `ITokenValidator` to create custom token validator.