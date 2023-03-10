# AccelByte C# Extend SDK AWS Lambda Sample

The application uses several AWS resources, including Lambda functions and an API Gateway API. These resources are defined in the `serverless.template` file in this project. You can update the template to add AWS resources through the same deployment process that updates your application code.

If you prefer to use an integrated development environment (IDE) to build and test your application, you can use the AWS Toolkit.  
The AWS Toolkit is an open source plug-in for popular IDEs that uses the SAM CLI to build and deploy serverless applications on AWS. The AWS Toolkit also adds a simplified step-through debugging experience for Lambda function code. See the following links to get started.

* [Rider](https://docs.aws.amazon.com/toolkit-for-jetbrains/latest/userguide/welcome.html)
* [VS Code](https://docs.aws.amazon.com/toolkit-for-vscode/latest/userguide/welcome.html)
* [Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/welcome.html)

## Prerequisites

Before building this sample, make sure you already installed all the requirements listed below.

* SAM CLI - [Install the SAM CLI](https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/serverless-sam-cli-install.html)
* Docker - [Install Docker community edition](https://hub.docker.com/search/?type=edition&offering=community)
* .NET 6.0 - [Install .NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* [Postman](https://www.postman.com/downloads/) or any other tool for accessing API.


## Build the solution
```bash
$ dotnet build
```

SAM requires published version of all assemblies. Run dotnet publish.
```bash
$ dotnet publish -c Release
```

## Deployment setup

Navigate to AWS lambda sample src directory
```bash
$ cd samples/AccelByte.Sdk.Sample.Aws.Lambda/src/AccelByte.Sdk.Sample.Aws.Lambda
```

Copy `serverless.template.sample` to `serverless.template`
```base
cp serverless.template.sample serverless.template
```

Then, fill the required environment variables related to your AccelByte credentials inside `serverless.template` file.
Following env vars are required:
- AB_BASE_URL
- AB_CLIENT_ID
- AB_CLIENT_SECRET
- AB_APP_NAME -> fill with your test app name
- AB_NAMESPACE
- AB_REDIS_HOST -> fill with your redis instance IP/name.
- AB_REDIS_PORT -> fill with your redis instance port.

## Local Deployment

Create test request json file (or just use one already provided inside this directory)
```bash
$ sam local generate-event apigateway aws-proxy > testApiRequest.json
```

Invoking a function
```bash
$ sam local invoke "<function_name>" --event testApiRequest.json --template serverless.template
```

OR

Run local api server
```bash
$ sam local start-api --template serverless.template
```

## Deployment

Then run the following in your shell:

```bash
$ dotnet publish -c Release
$ sam deploy --guided --template serverless.template
```

The first command will build the source of your application. The second command will package and deploy your application to AWS, with a series of prompts:

* **Stack Name**: The name of the stack to deploy to CloudFormation. This should be unique to your account and region, and a good starting point would be something matching your project name.
* **AWS Region**: The AWS region you want to deploy your app to.
* **Confirm changes before deploy**: If set to yes, any change sets will be shown to you before execution for manual review. If set to no, the AWS SAM CLI will automatically deploy application changes.
* **Allow SAM CLI IAM role creation**: Many AWS SAM templates, including this example, create AWS IAM roles required for the AWS Lambda function(s) included to access AWS services. By default, these are scoped down to minimum required permissions. To deploy an AWS CloudFormation stack which creates or modifies IAM roles, the `CAPABILITY_IAM` value for `capabilities` must be provided. If permission isn't provided through this prompt, to deploy this example you must explicitly pass `--capabilities CAPABILITY_IAM` to the `sam deploy` command.
* **Save arguments to samconfig.toml**: If set to yes, your choices will be saved to a configuration file inside the project, so that in the future you can just re-run `sam deploy` without parameters to deploy changes to your application.

You can find your API Gateway Endpoint URL in the output values displayed after deployment.

## Usage
Use `AccelByte.Sdk.Sample.TitleMatchmaking.Client` application to test your deployment. Make sure to set matchmaking url to your AWS Lambda deployment.

## Resources

* [Developing .NET Core AWS Lambda functions](https://aws.amazon.com/blogs/compute/developing-net-core-aws-lambda-functions/)