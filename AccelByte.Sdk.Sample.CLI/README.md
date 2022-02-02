# AccelByte C# SDK CLI

## Requirements

- .NET SDK 6.0
- Visual Studio 2022 or VS Code with C# extensions

## How-To

### Set up environment variables
You have to declare these environment variables below:

`AB_BAE_URL` (required)

`AB_CLIENT_ID` (required)

`AB_CLIENT_SECRET` (required for private OAuth client only)

In Visual Studio 2022 you can setup those variables in Debug Properties window.

### Build Projects

#### DotNet CLI
You can use `dotnet build` to build all the projects within the solution.

#### Visual Studio 2022
Just hit Build in the main menu, or right click in "AccelByte.Sdk.Sample.CLI", then click "Build".

### Run the CLI application

1. You need to login first with this command:

    `AccelByte.Sdk.Sample.CLI.exe --op login --user <username> --password <password>`

    For client type login (environment var `AB_CLIENT_SECRET` is required), use this command:

    `AccelByte.Sdk.Sample.CLI.exe --op login --lt client`

2. After successful login, then you can execute available commands, for example:

    `AccelByte.Sdk.Sample.CLI.exe --sn <service_name> --op <operation_name>`

    `AccelByte.Sdk.Sample.CLI.exe --sn <service_name> --op <operation_name> --namespace <namespace_name>`

3. For any operation that requires request body:

    Use json file as request body:

    `AccelByte.Sdk.Sample.CLI.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --reqfile "<path_to_json_file>"`

    Use json string as request body:

    `AccelByte.Sdk.Sample.CLI.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --reqbody "<json_content>"`

4. For any operation that requires a file to be uploaded:

    `AccelByte.Sdk.Sample.CLI.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --upload "<path_to_file>"`

5. To shows usage help:

    `AccelByte.Sdk.Sample.CLI.exe`

6. To shows usage help for specific operation:

    `AccelByte.Sdk.Sample.CLI.exe --sn <service_name> --op <operation_name> --help`

7. To list all API service names:

    `AccelByte.Sdk.Sample.CLI.exe --list`

8. To list all operations in an API service:

    `AccelByte.Sdk.Sample.CLI.exe --sn <service_name> --list`

9. To list all operations in all services:

    `AccelByte.Sdk.Sample.CLI.exe --list-all`


For Visual Studio 2022 users, you can define multiple debug profiles in which each of the profiles can have different command-line arguments.
