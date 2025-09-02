# AccelByte .NET (C#) SDK

A software development kit (SDK) for interacting with AccelByte Gaming Services written in C#.

This SDK was generated from OpenAPI spec included in the [spec](spec) directory.

## Setup

This SDK requires .NET 8.0 SDK or at minimum .NET 6.0 to be installed.

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
| `AB_BASE_URL`      | Yes                                              | https://test.accelbyte.io        |
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

### Login Using Username and Password with Defined Scopes

```csharp
bool login = sdk.LoginUser("myUsername", "myPassword", "<selected scopes>", null);
if (!login)
{
    // Login failed  
}
```

### Login Using Username and Password without Scopes

```csharp
bool login = sdk.LoginUser("myUsername", "myPassword", null, null);
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

As an example, we will get current user profile info using [getMyProfileInfo](https://docs.accelbyte.io/api-explorer/#Basic/getMyProfileInfo) endpoint available in [basic](https://docs.accelbyte.io/api-explorer/#Basic) service.

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

To enable automatic access token refresh, include the `AccelByte.Sdk.Feature.AutoRefreshToken` namespace and instantiate the SDK using the following code.

```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    // Use DefaultConfigRepository: ensure the required environment variables are set
    .UseDefaultConfigRepository()    
    // Call this to enable background token refresh
    .UseBackgroundTokenRefresh()
    .Build();
```

To configure background token refresh, set following environment variables.

| Name                             | Required | Description                                                                                    |
|----------------------------------|--------- |------------------------------------------------------------------------------------------------|
| `AB_REFRESH_RATE`                | No       | Fraction of token lifetime before it is refreshed. Value between`0.0` to `1.0`. Default: `0.8` |
| `AB_REFRESH_MAX_RETRY`           | No       | Maximum number of retries for refresh token requests before failing. Default: `2`              |
| `AB_REFRESH_BACKGROUND_INTERVAL` | No       | Timer interval (in seconds) to check token expiry. Default: `10`                               |
| `AB_REFRESH_BACKGROUND_ENABLED`  | No       | Enables background token refresh. Default: `true`                                              |

NOTE: The `AB_REFRESH_RATE` uses a float value between `0` and `1` representing the fraction of the token's lifetime. For example, if a token is valid for 1 hour (3600 seconds), and `AB_REFRESH_RATE` is set to `0.5`, the SDK will attempt to refresh the token after it has less than 1800 seconds remaining (3600 x 0.5).

Background token refresh runs on a timer at a specified interval to check for token expiry. If the token is nearing its expiration time (as determined by the `AB_REFRESH_RATE` value), it will be refreshed automatically.

If a periodic background process is not preferred, use .UseOnDemandTokenRefresh() instead. This method triggers automatic token refresh whenever the SDK calls any AGS endpoint.
Please note that this type of token refresh is recommended only for OAuth client logins (using the LoginClient method), as it relies solely on the configured client ID and client secret values. It can be used for other login types, but once the refresh token expires, any subsequent calls will be unauthorized.

```csharp
//Add core namespace
using AccelByte.Sdk.Core;

//Add feature namespace
using AccelByte.Sdk.Feature.AutoRefreshToken;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    // Use DefaultConfigRepository: ensure the required environment variables are set
    .UseDefaultConfigRepository()
    // call this to enable the feature
    .UseOnDemandTokenRefresh()
    .Build();
```

To configure on-demand token refresh, set the following environment variables.

| Name                          | Required | Description                                                                                    |
|-------------------------------|--------- |------------------------------------------------------------------------------------------------|
| `AB_REFRESH_RATE`             | No       | Fraction of token lifetime before it is refreshed. Value between`0.0` to `1.0`. Default: `0.8` |
| `AB_REFRESH_MAX_RETRY`        | No       | Maximum number of retries for refresh token requests before failing. Default: `2`              |
| `AB_REFRESH_ONDEMAND_ENABLED` | No       | Enables token refresh. Default: `true`                                                         |

NOTE: Avoid using both `.UseOnDemandTokenRefresh()` and `.UseBackgroundTokenRefresh()` together, as it introduces unnecessary overhead and may lead to unexpected behavior.

If any login method is expected to be called multiple times (e.g., in a serverless environment), use `.UseRefreshIfPossible()` when building the SDK:
```csharp
AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()    
    .UseDefaultCredentialRepository()
    // Use this to enable conditional refresh before login
    .UseRefreshIfPossible()
    .Build();
```

Then, use `LoginUser`, `LoginClient`, and/or `LoginPlatform` as usual. With this setup, any call to these methods will first check if the current token is expired:
- If expired, it will attempt to refresh the token.
- If still valid, it will return true without re-executing the login process.

## Token Validation
Token validation is available since version 0.27.

Use following method to validate access token.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr);
```

Permission validation is available only for OAuth Client token before version 0.47. From version 0.47 onwards, permission validation can accept user token.
To validate permission from user token, you need to instantiate the SDK with OAuth Client that has `ADMIN:ROLE [READ]` permission assigned to it.

To validate permission and action, use following method.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr, permissionStr, actionInt);
```

To validate permission and action with specified namespace and/or userid, use following method.
```csharp
bool isValid = sdk.ValidateToken(accessTokenStr, permissionStr, actionInt, namespaceId, userId);
```

## Local Token Validation
Local token validation is available since version 0.27.
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
    // call this to enable auto cache clear for token validator
    .UseTokenValidatorAutoClearCache()
    .Build();
```
Then use the usual `ValidateToken` methods.

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
    // call this to enable auto cache clear for token validator
    .UseTokenValidatorAutoClearCache()
    .Build();
```

And to use it.
```csharp
var payload = sdk.ParseAccessToken('<access token>', false);

//or, if validation is required
var payload = sdk.ParseAccessToken('<access token>', true);
```
`ParseAccessToken` will return null if the access token is invalid.

Since version 0.54, both permission and namespace context cache can be cleared manually or automatically with set interval.
- To use it manually, call `sdk.Configuration.TokenValidator.InvalidateCache()`.
- to enable auto clear, instantiate the sdk with `UseTokenValidatorAutoClearCache(<interval in seconds>)` method.

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

## FlightID
Since 0.53, C# Extend SDK enable support for FlightID transmission during Http request. By default, new flight id will be generated when the sdk is loaded. There will be some case that this default value need to be updated with new value.
-   To update default flight id globally, use following code:
    ```csharp
    AccelByteConfig.UpdateDefaultFlightId("<new flight id value>");
    ```
    This will update the default flight id, and will be used by newly created sdk object (won't affect existing sdk object created before this code get executed).

-   To update flight id value in sdk object, use following code:
    ```csharp
    sdk.UpdateFlightId("<new flight id value>");
    ```
    This will update the flight id value stored inside the sdk object. Will be used for all operations executed by the sdk object.

-   To update flight id value for specific operation, use `UpdateFlightId` method when building the operation object.
    ```csharp
    // Make a call to getMyProfileInfo endpoint
    UserProfilePrivateInfo? response = sdk.Basic.UserProfile.GetMyProfileInfoOp
        .UpdateFlightId("<new flight id value>")
        .Execute(sdk.Namespace);
    ```

## Web Socket Service

C# Extend SDK is able to connect to Lobby Web Socket Service. Following code demonstrate on how to use it.
```csharp

using AccelByte.Sdk.Core;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .Build();

// do login first

var lobbyWs = new LobbyService(sdk.Configuration);

//start connect
await lobbyWs.Connect(false);

//listen to message, this will block the execution
await lobbyWs.Listen();

//disconnect
await lobbyWs.Disconnect();
```

By default, web socket service is allowed to reconnect when not normal closure is received. To disable it, set `AllowReconnect` to false.
```csharp
lobbyWs.AllowReconnect = false;
```

To handle message, register the event on which message type. For example:
```csharp
lobbyWs.OnFriendsStatusResponse = (data) =>
{

};
```

In some cases, it is probably desired to handle all incoming message in single handler. To do this, set `RedirectAllReceivedMessagesToMessageReceivedEvent` to true and register an action to `OnMessageReceived`.
```csharp
lobbyWs.RedirectAllReceivedMessagesToMessageReceivedEvent = true;
lobbyWs.OnMessageReceived = (message) =>
{
    
};
```

## Samples

See common use cases [here](docs/common_use_cases.md).

Sample apps are available in the [samples](samples) directory.

## Migration Guides
See [here](docs/migration-guides) for migration guides.

## Documentation
Reference about AccelByte Gaming Services endpoints and their corresponding SDK API is available in [docs/operations](docs/operations) directory.

Sample app documentations are available in the [docs/samples](docs/samples/) directory.

For documentation about AccelByte Gaming Services and SDK, see [docs.accelbyte.io](https://docs.accelbyte.io/)
