# AccelByte C# Server SDK

## Setup

### 1. Add AcceByte C# Server SDK to your solution and project

```
cd /path/to/your_solution
dotnet sln add AccelByte.Sdk/AccelByte.Sdk.csproj
```

```
cd /path/to/your_solution/your_project
dotnet add reference ../AccelByte.Sdk/AccelByte.Sdk.csproj
```

### 2. Set the environment variables

You have to declare these environment variables below:

`AB_BASE_URL` (Required)

`AB_CLIENT_ID` (Required)

`AB_CLIENT_SECRET` (Required if you use private OAuth client only)


## Initializing SDK

You'll have to create an instance if AccelByteConfig and AccelByteSDK object.
    
```csharp
var httpClient = new DefaultHttpClient();
var tokenRepository = DefaultTokenRepository.getInstance();
var configRepository = new DefaultConfigRepository();

var config = new AccelByteConfig(httpClient, tokenRepository, configRepository);
var sdk = new AccelByteSDK(config);
```

## Logging In

### LoginUser

```csharp
bool login = sdk.LoginUser("myUsername", "myPassword");
if (!login) {
    // unsuccessful login handling ...  
}
```


### LoginClient (client credentials type)

```csharp
bool login = sdk.LoginClient();
if (!login) {
    // unsuccessful login handling ...  
}
```

## Logging Out
```java
bool logout = sdk.Logout();
if (!logout) {
    // unsuccessful logout handling ...
}
```

## API Covered

All REST API from AccelByte services are included, except websocket on lobby service.

1. achievement
2. basic
3. cloudsave
4. dslogmanager
5. dsmc
6. eventlog
7. gametelemetry
8. gdpr
9. group
10. iam
11. leaderboard
12. legal
13. lobby
14. matchmaking
15. platform
16. qosm
17. season pass
18. sessionbrowser
19. social
20. ugc
