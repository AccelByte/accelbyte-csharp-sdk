# AccelByte C# Extend SDK Title Matchmaking Client Sample

## Requirements

- .NET SDK 6.0
- Visual Studio 2022 or VS Code with C# extensions
- Deployed Title Matchmaking AWS Lambda sample or running local server sample.

## How-To

### Set up environment variables and configuration
You have to declare these environment variables below:

`AB_BASE_URL` (required)

`AB_CLIENT_ID` (required)

`AB_CLIENT_SECRET` (required for private OAuth client only)

`AB_NAMESPACE` (required)

`AB_APP_NAME` (required, you can define you own)

In Visual Studio 2022 you can setup those variables in Debug Properties window.

Another way to configure required variables is via JSON configuration file. You can run the application with `--sdk-config <json_file>` option.

### Build Projects

#### DotNet CLI
You can use `dotnet build` to build all the projects within the solution.

#### Visual Studio 2022
Just hit Build in the main menu, or right click in "AccelByte.Sdk.Sample.Cli", then click "Build".

### Run the CLI application

- Run with default configurations (AccelByte Gaming Services configuration will retrieved from environment variables):

    `AccelByte.Sdk.Sample.TitleMatchmaking.Client.exe`

- Run with AccelByte Gaming Services configuration provided via JSON file and use default for other configurations. JSON sample file available [here](ab_config_sample.json).

    `AccelByte.Sdk.Sample.TitleMatchmaking.Client.exe --sdk-config <json_file>`

- Run with user credentials provided via JSON file. JSON sample file available [here](credential_sample.json)

    `AccelByte.Sdk.Sample.TitleMatchmaking.Client.exe --credential <json_file>`

- Run with specified title matchmaking server url

    `AccelByte.Sdk.Sample.TitleMatchmaking.Client.exe --server <server_url>`

- Run with specifed username and password

    `AccelByte.Sdk.Sample.TitleMatchmaking.Client.exe --user <username> --pass <password>`

After you run the application, make sure you select option number 1 first (login) before attempting to do matchmaking.