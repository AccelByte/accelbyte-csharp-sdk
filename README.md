# AccelByte .NET (C#) SDK

A software development kit (SDK) for interacting with AccelByte services written in C#.

This SDK was generated from OpenAPI spec included in the [spec](spec) directory.

## Setup
This SDK requires .NET 6.0 SDK to be installed.

### Import SDK Project

```
cd /path/to/your_solution
dotnet sln add AccelByte.Sdk/AccelByte.Sdk.csproj
```

```
cd /path/to/your_solution/your_project
dotnet add reference ../AccelByte.Sdk/AccelByte.Sdk.csproj
```

Or open the solution and build the project, then use the compiled binary in your project.

### Environment Variables

The following environment variables need to be set when using `DefaultConfigRepository`.

| Name               | Required                                         | Example                          |
|--------------------|--------------------------------------------------|----------------------------------|
| `AB_BASE_URL`      | Yes                                              | https://demo.accelbyte.io        |
| `AB_CLIENT_ID`     | Yes                                              | abcdef0123456789abcdef0123456789 |
| `AB_CLIENT_SECRET` | Yes, but only if you use a private `AB_CLIENT_ID`| ab#c,d)ef(ab#c,d)ef(ab#c,d)ef(ab |
| `AB_NAMESPACE`     | Yes                                              | accelbyte                        |

## Usage

### Instantiation
    
```csharp
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

### Login Using OAuth Client (Public or Private)

```csharp
bool login = sdk.LoginClient();
if (!login)
{
    // Login failed  
}
```

## Interacting with a Service Endpoint

As an example, we will get current user profile info using [getMyProfileInfo](https://demo.accelbyte.io/basic/apidocs/#/UserProfile/getMyProfileInfo) endpoint available in [basic](https://demo.accelbyte.io/basic/apidocs) service.

```csharp
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

## Logout
```csharp
bool logout = sdk.Logout();
if (!logout)
{
    // Logout failed
}
```

## Samples

Sample apps are available in the [samples](samples) directory

## Documentation
Reference about AccelByte service endpoints and their corresponding SDK API is available in [docs](docs) directory.
For documentation about AccelByte services and SDK, see [docs.accelbyte.io](https://docs.accelbyte.io/)