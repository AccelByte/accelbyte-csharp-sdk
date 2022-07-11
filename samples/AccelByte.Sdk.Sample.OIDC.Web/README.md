# AccelByte C# SDK OIDC Web Sample

## Requirements

- .NET SDK 6.0
- Visual Studio 2022 or VS Code with C# extensions

## How-To

### Set up environment variables and configuration
You have to declare these environment variables below:

`AB_BASE_URL` (required)

`AB_CLIENT_ID` (required)

`AB_NAMESPACE` (required)

`AB_APP_NAME` (required, you can define you own)

`AB_CLIENT_SECRET` (required for private OAuth client only)

In Visual Studio 2022 you can setup those variables in Debug Properties window.

To configure OpenID providers, you need to copy `providers.json.sample` into `providers.json` and then add or modify the content.
As a starter, [Phantauth](https://www.phantauth.net/) is provided to test the functionality. But you can add other provider as needed.

### Build Projects

#### DotNet CLI
You can use `dotnet build` to build all the projects within the solution.

#### Visual Studio 2022
Just hit Build in the main menu, or right click in "AccelByte.Sdk.Sample.Cli", then click "Build".

### Run the CLI application

Make sure you already have `providers.json` file.

Run `AccelByte.Sdk.Sample.OIDC.Web.exe`

Then open your browser and point it to `http://localhost:9090`.
