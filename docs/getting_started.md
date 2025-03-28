# Getting Started Guide for AccelByte C# (.NET) Extend SDK

This guide will show you how to create a project which uses C# (.NET) Extend SDK from scratch.


## Prerequisites
* AccelByte Gaming Services (demo environment):
	* Use your environment base URL for `AB_BASE_URL` environment variable e.g. https://test.accelbyte.io
	* [Create an OAuth Client](https://docs.accelbyte.io/gaming-services/services/access/reference/authorization/manage-access-control-for-applications/#create-an-iam-client) with client type `Confidential`.
		* Use `Client ID` value for `AB_CLIENT_ID` environment variable.
		* Use `Client Secret` value for `AB_CLIENT_SECRET` environment variable.
* Git
* .NET SDK 6.0
* C# IDE e.g. Visual Studio Code, Visual Studio 2022, etc


## Tutorial

### 1. Create a C# Project

Create a new solution and a new console project inside it using `dotnet` CLI.

```bash
$ mkdir -p /path/to/mysolution
$ cd /path/to/mysolution
$ dotnet new sln --name mysolution      # Create a new solution: mysolution
$ dotnet new console -o myproject       # Create a new console project myproject
$ dotnet sln add myproject/myproject.csproj     # Add myproject to mysolution
```

### 2. Add to Project Dependency

Get a release version of [AccelByte C# Extend SDK](https://github.com/AccelByte/accelbyte-csharp-sdk) and add it as C# project dependency. 

Replace `{VERSION}` with a specific release version tag from [releases](https://github.com/AccelByte/accelbyte-csharp-sdk/releases).

It is recommended to use the matching C# (.NET) Extend SDK version for the given AccelByte Gaming Services version.

```bash
$ cd /path/to/mysolution/myproject
$ dotnet add package AccelByte.Sdk -v {VERSION}      # Add AccelByte C# Extend SDK Package from Nuget
```

### 3. Use in Code

Create an SDK instance, login using user credentials, and call an AccelByte Basic API in `program.cs`.

The `DefaultConfigRepository` gets its values from `AB_BASE_URL`, `AB_CLIENT_ID`, and `AB_CLIENT_SECRET` environment variables.

```csharp
using System;
using System.Collections.Generic;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;
using AccelByte.Sdk.Api.Legal.Model;

namespace AccelByteExample
{
    internal class Program
    {
        static int Main(string[] args)
        {
            AccelByteSDK sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .UseDefaultTokenRepository()
                .Build();

            bool login = sdk.LoginUser("myUsername", "myPassword");
            if (!login)
            {
                Console.WriteLine("Login failed");
                return 1;
            }

            try
            {
                List<RetrieveAcceptedAgreementResponse>? response = sdk.Legal.Agreement.RetrieveAgreementsPublicOp.Execute();
                if (response == null)
                    throw new Exception("Response is null");

                foreach (var aggreement in response)
                    Console.WriteLine(aggreement.PolicyName);
            }
            catch (HttpResponseException e)
            {
                Console.WriteLine(e.Message);
                return 2;
            }

            bool logout = sdk.Logout();
            if (!logout)
            {
                Console.WriteLine("Logout failed");
                return 1;
            }

            return 0;
        }
    }
}
```

### 4. Run the Code

Set the required environment variables and run the code using `dotnet run`.

```bash
$ export AB_BASE_URL="https://test.accelbyte.io"              # AccelByte Gaming Services Base URL
$ export AB_CLIENT_ID="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"      # AccelByte Gaming Services OAuth Client ID
$ export AB_CLIENT_SECRET="xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"  # AccelByte Gaming Services OAuth Client Secret
$ cd /path/to/mysolution/myproject
$ dotnet run
```

## Follow Up Resources

* C# (.NET) Extend SDK [README.md](https://github.com/AccelByte/accelbyte-csharp-sdk/blob/main/README.md)
* Reference documentation on AccelByte Gaming Services endpoints, their corresponding C# (.NET) Extend SDK API, and short examples on how to use them is available in [docs](https://github.com/AccelByte/accelbyte-csharp-sdk/blob/main/docs)
* Sample apps which show some practical usage of C# (.NET) Extend SDK are available in [samples](https://github.com/AccelByte/accelbyte-csharp-sdk/blob/main/samples)

## FAQ

### 1. Can I customize the default token repository and/or the default config repository?

Yes. You just need to implement the interface accordingly.

### 2. How can I use more advanced features of C# (.NET) Extend SDK e.g. HTTP retry and automatic token refresh? 

See [README.md](https://github.com/AccelByte/accelbyte-csharp-sdk/blob/main/README.md)