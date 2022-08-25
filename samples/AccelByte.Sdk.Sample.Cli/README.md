# AccelByte C# SDK CLI

## Requirements

- .NET SDK 6.0
- Visual Studio 2022 or VS Code with C# extensions

## How-To

### Set up environment variables
You have to declare these environment variables below:

`AB_BASE_URL` (required)

`AB_CLIENT_ID` (required)

`AB_CLIENT_SECRET` (required for private OAuth client only)

In Visual Studio 2022 you can setup those variables in Debug Properties window.

### Build Projects

#### DotNet CLI
You can use `dotnet build` to build all the projects within the solution.

#### Visual Studio 2022
Just hit Build in the main menu, or right click in "AccelByte.Sdk.Sample.Cli", then click "Build".

### Run the CLI application

1. You need to login first with this command:

    `AccelByte.Sdk.Sample.Cli.exe --op login --user <username> --pass <password>`

    For client type login (environment var `AB_CLIENT_SECRET` is required), use this command:

    `AccelByte.Sdk.Sample.Cli.exe --op login --lt client`

2. After successful login, then you can execute available commands, for example:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name>`

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name>`

3. For any operation that requires request body:

    Use json file as request body:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --reqfile "<path_to_json_file>"`

    Use json string as request body:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --reqbody "<json_content>"`

4. For any operation that requires a file to be uploaded:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --upload "<path_to_file>"`

5. To shows usage help:

    `AccelByte.Sdk.Sample.Cli.exe`

6. To shows usage help for specific operation:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --help`

7. To list all API service names:

    `AccelByte.Sdk.Sample.Cli.exe --list-ops`

8. To list all operations in an API service:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --list-ops`

9. To list all operations in all services:

    `AccelByte.Sdk.Sample.Cli.exe --list-all`

10. Listen to web socket service:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --ws --ws-listen`

11. Sending web socket message using JSON file payload:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --ws --ws-payload-file <path_to_json_file>`

12. Use interactive mode to send web socket message:

    `AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --ws --interactive`

Other optional arguments:
- `--enable-log` , enable logging for http requests. Log file (`http_log.txt`) will be stored in current directory.
- `--ws` , enable web socket mode. Put this option first before using any web socket related options.
- `--ws-listen` , enable web socket listening mode.
- `--ws-payload "<json_content>"` , put web socket request payload using this option.
- `--ws-payload-file "<path_to_json_file>"`, upload a file as web socket request payload.
- `--interactive`, use interactive mode to send web socket message.

Notes:
- You cannot mix `--ws-listen` with `--ws-payload`, `--ws-payload-file`, or `--interactive`.
- You cannot use `--reqfile` and `--reqbody` together. Choose only one.
- You cannot use `--ws-payload`, `--ws-payload-file`, and/or `--interactive` together. Choose only one.
- For Visual Studio 2022 users, you can define multiple debug profiles in which each of the profiles can have different command-line arguments.
