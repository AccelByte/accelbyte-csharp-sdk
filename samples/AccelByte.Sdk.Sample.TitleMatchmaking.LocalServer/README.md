# AccelByte C# Extend SDK Title Matchmaking Local Server Sample

## Requirements

- .NET SDK 6.0
- Visual Studio 2022 or VS Code with C# extensions

## How-To

### Set up environment variables and configuration
You have to declare these environment variables below:

`AB_BASE_URL` (required)

`AB_CLIENT_ID` (required)

`AB_CLIENT_SECRET` (required for private OAuth client only)

`AB_NAMESPACE` (required)

`AB_APP_NAME` (required, you can define you own)

In Visual Studio 2022 you can setup those variables in Debug Properties window.

Another way to configure required variables is via JSON configuration file. You can run the application with `--sdk-config <json_file>` option. JSON sample file available [here](../AccelByte.Sdk.Sample.TitleMatchmaking.Client/ab_config_sample.json)

### Build Projects

#### DotNet CLI
You can use `dotnet build` to build all the projects within the solution.

#### Visual Studio 2022
Just hit Build in the main menu, or right click in "AccelByte.Sdk.Sample.Cli", then click "Build".

### Run the CLI application

Run `AccelByte.Sdk.Sample.TitleMatchmaking.LocalServer.exe`

Title matchmaking API will be available on `http://localhost:9090`.

Use `AccelByte.Sdk.Sample.TitleMatchmaking.Client` application to test this local server.
