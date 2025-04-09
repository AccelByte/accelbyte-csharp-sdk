# AccelByte C# Extend SDK Sample CLI

## Requirements

- .NET SDK 8.0
- Visual Studio 2022 or VS Code with C# extensions

## How-To

### Set up environment variables
You have to declare these environment variables below:

`AB_BASE_URL`

`AB_CLIENT_ID`

`AB_CLIENT_SECRET`

In Visual Studio 2022 you can setup those variables in Debug Properties window.


### Build Projects

#### DotNet CLI
Go to `samples/AccelByte.Sdk.Sample.Cli` and then use this command to build the cli app.
```sh
$ dotnet build
```

#### Visual Studio 2022
Open solution explorer side panel and right click on "samples/AccelByte.Sdk.Sample.Cli" project, then click "Build".

### Run the CLI application

There are two different methods to running the cli application.

- First, build and/or publish the executable. In linux the resulting binary will be named `AccelByte.Sdk.Sample.Cli`, while in Windows, the binary name is `AccelByte.Sdk.Sample.Cli.exe`.
- Or, use `dotnet run` command inside `samples/AccelByte.Sdk.Sample.Cli` directory. Add ` -- ` between `dotnet run` and first argument. For example `dotnet run -- --op login`.

Below are few examples of using this cli application. Replace `AccelByte.Sdk.Sample.Cli.exe` with correct binary name or `dotnet run -- `.

1. To login:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --op login --user <username> --pass <password>
    ```
    For client type login (environment var `AB_CLIENT_SECRET` is required), use this command:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --op login --lt client
    ```

2. After successful login, then you can execute available commands, for example:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name>    
    ```
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name>
    ```

3. For any operation that requires request body:
    
    Use json file as request body:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --reqfile "<path_to_json_file>"
    ```
    or use json string as request body:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --reqbody "<json_content>"
    ```
    > :warning: Use either `--reqfile` or `--reqbody` to set request body. **Do not** use both of them at the same time.


4. For any operation that requires a file to be uploaded:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --namespace <namespace_name> --upload "<path_to_file>"
    ```

5. To shows usage help:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe
    ```

6. To shows usage help for specific operation:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --op <operation_name> --help
    ```

7. To list all API service names:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --list-ops
    ```

8. To list all operations in an API service:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --list-ops
    ```    

9. To list all operations in all services:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --list-all
    ```

10. Listen to web socket service:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --ws --ws-listen
    ```
    > :warning: `--ws-listen` argument cannot be mixed with `--interactive`, `--ws-payload`, or `--ws-payload-file`.

11. Sending web socket message:

    Use json file as payload:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --ws --ws-payload-file <path_to_json_file>
    ```
    or use json string as payload:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --ws --ws-payload "<json_content>"    
    ```
    > :warning: Use either `--ws-payload` or `--ws-payload-file`. **Do not** use both of them at the same time. Also do not use these together with either `--ws-listen` and/or `--interactive`.


12. Use interactive mode to send web socket message:
    ```sh
    AccelByte.Sdk.Sample.Cli.exe --sn <service_name> --ws --interactive
    ```
    > :warning: `--interactive` argument cannot be mixed with `--ws-listen`, `--ws-payload`, or `--ws-payload-file`.


Optional arguments:

- `--enable-log` , enable logging for http requests. Log file (`http_log.txt`) will be stored in current directory.


### List of operations

Please go to this [index](./operations/index.md) to see the list of supported operations.