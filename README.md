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

`AB_APP_NAME` (Required) Provide your application name.

`AB_TRACEID_VERSION` (Optional) Default to '1'.

`AB_ENABLE_TRACEID` (Optional) Default to 1 (true). Put 0 to disable trace id information in request header.


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
```csharp
bool logout = sdk.Logout();
if (!logout) {
    // unsuccessful logout handling ...
}
```

## WebSocket Service
```csharp
//use config object from Sdk initialization.
LobbyService service = new LobbyService(config);


//Connect to the lobby service.
await connectTask service.Connect(false);


//Start listener task.
Task listenTask = Task.Run(() => service.Listen());


//Send message example using string data.
string example = "type: listIncomingFriendsRequest\nid:1234567890\ncode: 0";
await service.Send(example);


//Send message exampe using model object.
ListIncomingFriendsRequest modelObject = new ListIncomingFriendsRequest()
{
    Id: "1234567890"
};
await service.Send(modelObject, 0);


//To receive message, attach handler function to spesific event
service.OnListIncomingFriendsResponse = (response) =>
{
    //handle the response...
};


//Disconnect from service.
await service.Disconnect();
```

## API Covered

All REST API from AccelByte services are included.

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