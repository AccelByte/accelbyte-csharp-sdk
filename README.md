# AccelByte .NET (C#) SDK

A software development kit (SDK) for interacting with AccelByte Gaming Services written in C#.

This SDK was generated from OpenAPI spec included in the [spec](spec) directory.

## Setup

This SDK requires .NET 6.0 SDK to be installed.

## Adding to Your Project

```
cd /path/to/your_solution/your_project
dotnet add package AccelByte.Sdk
```

## Usage

### Environment Variables

The following environment variables need to be set when using `DefaultConfigRepository`.

| Name               | Required                                         | Example                          |
|--------------------|--------------------------------------------------|----------------------------------|
| `AB_BASE_URL`      | Yes                                              | https://demo.accelbyte.io        |
| `AB_CLIENT_ID`     | Yes                                              | abcdef0123456789abcdef0123456789 |
| `AB_CLIENT_SECRET` | Yes, but only if you use a private `AB_CLIENT_ID`| ab#c,d)ef(ab#c,d)ef(ab#c,d)ef(ab |
| `AB_NAMESPACE`     | Yes                                              | accelbyte                        |

### Instantiation
    
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository() // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultTokenRepository()
    .Build();
```

## Login

### Login Using Username and Password

```csharp
bool login = sdk.LoginUser("myUsername", "myPassword");
if (!login)
{
    // Login failed  
}
```

### Login Using OAuth Client

```csharp
bool login = sdk.LoginClient();
if (!login)
{
    // Login failed  
}
```

> :warning: **Please use LoginClient() function with confidential OAuth client:** Using LoginClient() function with public OAuth client is not supported.

## Interacting with a Service Endpoint

As an example, we will get current user profile info using [getMyProfileInfo](https://demo.accelbyte.io/basic/apidocs/#/UserProfile/getMyProfileInfo) endpoint available in [basic](https://demo.accelbyte.io/basic/apidocs) service.

```csharp
//Add basic service model namespace
using AccelByte.Sdk.Api.Basic.Model;

// Login using username and password

bool login = sdk.LoginUser("myUsername", "myPassword");
if (!login)
{
    Console.WriteLine("Login failed");
}

// Instantiate UserProfile wrapper class which is part of basic service

UserProfile userProfile = new UserProfile(sdk);

try
{
    // Make a call to getMyProfileInfo endpoint
    UserProfilePrivateInfo? response = userProfile.GetMyProfileInfo(
        GetMyProfileInfo.Builder
        .Build(sdk.Namespace));

    Console.WriteLine(response.UserId); // Success response
}
catch (HttpResponseException e)
{
    Console.WriteLine(e.Message);
}
```

## Interacting with a Service Endpoint (alternative)

As an example, we will get current user profile info using [getMyProfileInfo](https://demo.accelbyte.io/basic/apidocs/#/UserProfile/getMyProfileInfo) endpoint available in [basic](https://demo.accelbyte.io/basic/apidocs) service with fluent interface.

```csharp
//Add api namespace
using AccelByte.Sdk.Api;

//Add basic service model namespace
using AccelByte.Sdk.Api.Basic.Model;

// Login using username and password

bool login = sdk.LoginUser("myUsername", "myPassword");
if (!login)
{
    Console.WriteLine("Login failed");
}

// Instantiate UserProfile wrapper class which is part of basic service

UserProfile userProfile = new UserProfile(sdk);

try
{
    // Make a call to getMyProfileInfo endpoint
    UserProfilePrivateInfo? response = sdk.Basic.UserProfile.GetMyProfileInfoOp.Execute(sdk.Namespace);

    /*
    
    // If you need to modify operation object, first you can build the operation object
    GetMyProfileInfo operation = sdk.Basic.UserProfile.GetMyProfileInfoOp
        .Build(sdk.Namespace);

    // then
    UserProfilePrivateInfo? response = sdk.Basic.UserProfile.GetMyProfileInfo(operation);

    */

    Console.WriteLine(response.UserId); // Success response
}
catch (HttpResponseException e)
{
    Console.WriteLine(e.Message);
}
```

## Logout
```csharp
bool logout = sdk.Logout();
if (!logout)
{
    // Logout failed
}
```

## Enable HTTP Logging
To enable http logging feature, build the sdk with `EnableLog()`.
```csharp
using AccelByte.Sdk.Core;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()
    .EnableLog()
    .Build();
```

## HTTP Retry Example
If retry feature is required, instantiate the sdk with `ReliableHttpClient` object.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Client;

//Using default retry policy 
HttpClientPolicy policy = HttpClientPolicy.Default;

AccelByteSDK sdk = AccelByteSDK.Builder
    .SetHttpClient(ReliableHttpClient.Builder
        .SetDefaultPolicy(policy)                    
        .Build())    
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()
    .Build();
```

For `HttpClientPolicy` properties, refer to [this code](AccelByte.Sdk/Core/Client//HttpClientPolicy.cs).

## Automatically Refresh Access Token
To enable automatic access token refresh, include `AccelByte.Sdk.Feature.AutoRefreshToken` and instantiate the sdk with following code.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the feature
    .UseAutoTokenRefresh()
    .Build();
```
Then when login, use the extension method provided.
```csharp
using AccelByte.Sdk.Feature.AutoRefreshToken;

//pass true to the third parameter
bool login = sdk.LoginUser("myUsername", "myPassword", true);
if (!login)
{
    Console.WriteLine("Login failed");
}

//Or simply pass true to the first parameter if username and password are stored and retrieved by credential repository
bool login = sdk.LoginUser(true);
if (!login)
{
    Console.WriteLine("Login failed");
}

Alternative to automatic access token refresh is scheduled access token refresh. Scheduled access tokend refresh is using a timer that periodically refresh the access token. To enable it, instead of using `.UseAutoTokenRefresh()`, use `.UseScheduledTokenRefresh()` while instantiate the sdk.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the scheduled access token refresh
    .UseScheduledTokenRefresh()
    .Build();
```
NOTE: Do not use `.UseAutoTokenRefresh()` together with `.UseScheduledTokenRefresh()`. It will introduce unnecessary overhead and possibility of unexpected behaviour.

## On-Demand Refresh Token
The on-demand refresh token is intended to be used in environment where automatic refresh token cannot work property (e.g. AWS Lambda). To enable it, instantiate the sdk with `UseRefreshIfPossible`.
```csharp
AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()    
    .UseDefaultCredentialRepository()
    //use this method while building the sdk to enable on-demand refresh token
    .UseRefreshIfPossible()
    .Build();
```
Then you can use `LoginUser`, `LoginClient`, and/or `LoginPlatform` as usual. With on-demand refresh token, any call to these methods will first check whether the token is expired or not. If it is expired, then it will call refresh token method. If not, then these methods will just return true without executing the actual login process.

NOTE: `LoginClient` does not have refresh token, instead it will execute actual login process if the token is expired.

Working example code for on-demand refresh token is available in this [sample app](samples/AccelByte.Sdk.Sample.OnDemandTokenRefresh).


## Local Token Validation
Local token validation is available since version 0.27. Currently only support for oauth client token.
To enable it, include `AccelByte.Sdk.Feature.LocalTokenValidation` and instantiate the sdk with following code.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.LocalTokenValidation;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the feature
    .UseLocalTokenValidator()
    // call this to enable auto refresh for token revocation list
    .UseAutoRefreshForTokenRevocationList()
    .Build();
```

And then use following method to validate access token.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr);
```
Or, if you need to validate permission and action, use following method.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr, permissionStr, actionInt);
```

Since version 0.42, `ParseAccessToken` function added to get the access token payload. This function requires 2 parameters. First, is the access token itself. Second, is to set whether the function will validate the access token or not. Set `true` if validation is required.
To use it, just include `AccelByte.Sdk.Feature.LocalTokenValidation`. If validation is required, instantiate the sdk with following code.
```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.LocalTokenValidation;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    // Using DefaultConfigRepository, make sure the required environment variables are set
    .UseDefaultConfigRepository()
    // Credential repository is required for auto refresh token to works
    .UseDefaultCredentialRepository()
    // call this to enable the feature
    .UseLocalTokenValidator()
    // call this to enable auto refresh for token revocation list
    .UseAutoRefreshForTokenRevocationList()
    .Build();
```

And to use it.
```csharp
var payload = sdk.ParseAccessToken('<access token>', false);

//or, if validation is required
var payload = sdk.ParseAccessToken('<access token>', true);
```
`ParseAccessToken` will return null if the access token is invalid.

## Operation with Generic Response
Since 0.28, C# Extend SDK enable overloaded `ParseOperation` method with generic data type that applies to almost all operations with response model which has one or more object data type in it.
For example:
```csharp
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Api.Cloudsave.Operation;

GameRecordExample myGameRecord = new GameRecordExample()
{
    MyStatus = "ALIVE",
    Location = "MOUNTAIN",
    Character = new GameRecordExample.CharacterClass()
    {
        Name = "Character",
        Strength = 10,
        Agility = 15,
        Intelligence = 20
    }
};

ModelsGameRecordResponse<GameRecordExample>? response = sdk.Cloudsave.PublicGameRecord.PostGameRecordHandlerV1Op
    .Execute<GameRecordExample>(myGameRecord, "test_record", sdk.Namespace);
```
The list of which endpoints that support it can be found in [here](docs/operations/)

## Samples

See common use cases [here](docs/common_use_cases.md).

Sample apps are available in the [samples](samples) directory.

## Migration Guides
See [here](docs/migration-guides) for migration guides.

## Documentation
Reference about AccelByte Gaming Services endpoints and their corresponding SDK API is available in [docs/operations](docs/operations) directory.

Sample app documentations are available in the [docs/samples](docs/samples/) directory.

For documentation about AccelByte Gaming Services and SDK, see [docs.accelbyte.io](https://docs-old.accelbyte.io/)
