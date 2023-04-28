# Add Custom Operation into AccelByte SDK

## Background
Majority of C# Extend SDK codes are generated from [spec json files](../spec) using codegen tools. Any attemp to customize C# Extend SDK must avoid editing files that are marked as `DO NOT EDIT`.
Also it is best practice to extend the functionality of C# Extend SDK by inherit the base classes or add new implementation for partial classes to ensure less complications when upgrading C# Extend SDK.

## How to Create a Custom Operation
In this guide, we will explain on how to create a custom operation for custom endpoint and integrate it into SDK core.

### Preparation
Create a new .NET 6.0 class library project and include dependency to [AccelByte.Sdk](https://www.nuget.org/packages/AccelByte.Sdk/). Refer to these articles for more information on how to create new project.
- Create a class library [using Visual Studio](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-6-0).
- Create a class library [using Visual Studio Code](https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-6-0).

### Goal
Create an operation class and its wrapper for custom endpoint (for this guide, let's use `GET /achievement/v1/public/namespaces/{namespace}/tags` as an example of custom endpoint).
This endpoints requires `namespace` as path parameter and a few optional query parameters. Will returns HTTP 200 if success along with the data.
Let's use `SdkCustomization.CustomOp` as namespace. (Usually the namespace is the name of the project).
And let us name this custom operation `MyCustomOp`.

## Create Model classes
Our example endpoint has this output
```json
{
  "data": [
    {
      "createdAt": "2023-02-02T02:49:34.767Z",
      "name": "string",
      "namespace": "string"
    }
  ],
  "paging": {
    "next": "string",
    "previous": "string"
  }
}
```
We need to create model classes that reflect the output.
```csharp
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SdkCustomization.CustomOp
{
    public class MyCustomResponseModel
    {
        public class TagData
        {
            [JsonPropertyName("createdAt")]
            public DateTime? CreatedAt { get; set; }

            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("namespace")]
            public string? Namespace { get; set; }
        }

        public class Pagination
        {
            [JsonPropertyName("next")]
            public string? Next { get; set; }

            [JsonPropertyName("previous")]
            public string? Previous { get; set; }
        }



        [JsonPropertyName("data")]
        public List<TagData>? Data { get; set; }

        [JsonPropertyName("paging")]
        public Pagination? Paging { get; set; }
    }
}
```

## Create an Operation Class
You can create an operation class following this example
```csharp
using System;
using System.IO;
using System.Text.Json;
using System.Net;
using System.Net.Http;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace SdkCustomization.CustomOp
{
    public class MyCustomOp : Operation
    {
        public MyCustomOp(string namespace_, long? limit, string? name, long? offset, string? sortBy)
        {
            PathParams["namespace"] = namespace_;

            if (limit != null)
                QueryParams["limit"] = Convert.ToString(limit)!;

            if (name != null)
                QueryParams["name"] = name;

            if (offset != null)
                QueryParams["offset"] = Convert.ToString(offset)!;

            if (sortBy != null)
                QueryParams["sortBy"] = sortBy;

            //Use SECURITY_BEARER for endpoint that need authorization token,
            //or use SECURITY_BASIC for endpoint that only need basic auth using client id and secret._
            Securities.Add(Operation.SECURITY_BEARER);
        }

        public override string Path => "/achievement/v1/public/namespaces/{namespace}/tags";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        //Still need to implement this. set "Bearer" for SECURITY_BEARER, and "Basic" for SECURITY_BASIC.
        //This property requirement will be removed in future release.
        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public MyCustomResponseModel? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<MyCustomResponseModel>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<MyCustomResponseModel>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }
}
```

## Create a Wrapper Class
You can create a wrapper class following this example
```csharp
using System;
using AccelByte.Sdk.Core;

namespace SdkCustomization.CustomOp
{
    public class MyCustomWrapper
    {
        private readonly AccelByteSDK _sdk;

        public MyCustomWrapper(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }
        
        public MyCustomResponseModel? CallMyCustomOp(MyCustomOp input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}
```

## Use Custom Operation
After you create necessary classes, you can use itu with AccelByte Sdk.
```csharp
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using SdkCustomization.CustomOp;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()
    .Build();

MyCustomWrapper customWrapper = new MyCustomWrapper(sdk);

MyCustomOp newOp = new MyCustomOp(sdk.Namespace,null,null,null,null);
var response = customWrapper.CallMyCustomOp(newOp);
```

## Implement Builder Pattern for Custom Operation
As you can notice from the code above, to create `MyCustomOp` object, you will need to pass several null values.
This null values is optional parameter that will be pass as query parameter.
To make the operation class intuitive to use, you can implement builder pattern for `MyCustomOp` class.
See the modified code below as an example of builder pattern implementation.
```csharp
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace SdkCustomization.CustomOp
{
    public class MyCustomOp : Operation
    {
        #region Builder Part
        public static MyCustomOpBuilder Builder { get => new MyCustomOpBuilder(); }

        public class MyCustomOpBuilder : OperationBuilder<MyCustomOpBuilder>
        {
            public long? Limit { get; set; }

            public string? Name { get; set; }

            public long? Offset { get; set; }

            public string? SortBy { get; set; }

            public MyCustomOpBuilder() { }

            public MyCustomOpBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public MyCustomOpBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public MyCustomOpBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public MyCustomOpBuilder SetSortBy(string _sortBy)
            {
                SortBy = _sortBy;
                return this;
            }

            public MyCustomOp Build(
                string namespace_
            )
            {
                MyCustomOp op = new MyCustomOp(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private MyCustomOp(MyCustomOpBuilder builder, string namespace_)
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null)
                QueryParams["limit"] = Convert.ToString(builder.Limit)!;

            if (builder.Name is not null)
                QueryParams["name"] = builder.Name;

            if (builder.Offset != null)
                QueryParams["offset"] = Convert.ToString(builder.Offset)!;

            if (builder.SortBy is not null)
                QueryParams["sortBy"] = builder.SortBy;

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion


        public MyCustomOp(string namespace_, long? limit, string? name, long? offset, string? sortBy)

...
```

## Use Custom Operation with Builder Pattern
After you do modification to the operation class, you can leverage the builder pattern to instantiate your operation class.
```csharp
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Api;

using SdkCustomization.CustomOp;

AccelByteSDK sdk = AccelByteSDK.Builder
    .UseDefaultHttpClient()
    .UseDefaultConfigRepository()
    .UseDefaultTokenRepository()
    .Build();

MyCustomWrapper customWrapper = new MyCustomWrapper(sdk);

//No optional param specified...
MyCustomOp newOp = MyCustomOp.Builder.Build(sdk.Namespace);

//or, if you need to set the limit parameter..
MyCustomOp newOp = MyCustomOp.Builder
    .SetLimit(5)
    .Build(sdk.Namespace);

var response = customWrapper.CallMyCustomOp(newOp);
```

## Implement Fluent Interface for Custom Operation using Custom SDK
This section can be implemented using C# Extend SDK version v0.34.0 or above.

To further enchance intuitiveness while using the sdk, you can implement fluent interface for your custom operation.
See the modified code below as an example of fluent interface implementation.

- Modify custom operation class
```csharp
...
#region Builder Part
...
//Add this method inside the builder class
public MyCustomResponseModel? Execute(string namespace_)
{
    MyCustomOp op = Build(
        namespace_
    );

    return GetWrapperObject<MyCustomWrapper>().CallMyCustomOp(op);
}
#endregion
...
```

- Modify custom wrapper class
```csharp
public class MyCustomWrapper
{
    ...
    //add this method
    public MyCustomOp.MyCustomOpBuilder MyCustomOpOp
    {
        get { return MyCustomOp.Builder.SetWrapperObject(this); }
    }
}
```

- Create new custom sdk class inherited from `AccelByteSDK`
```csharp
using System;
using System.Collections.Generic;
using AccelByte.Sdk.Core;

namespace SdkCustomization.CustomOp
{
    public class MyCustomAccelByteSDK : AccelByteSDK
    {
        //Add your custom sdk builder
        public static new AccelByteSdkBuilder<MyCustomAccelByteSDK> Builder { get => new AccelByteSdkBuilder<MyCustomAccelByteSDK>(); }

        //Add custom wrapper property
        public MyCustomWrapper CustomWrapper
        {
            get
            {
                if (_CustomWrapper == null)
                    _CustomWrapper = new MyCustomWrapper(this);
                return _CustomWrapper;
            }
        }
        private MyCustomWrapper? _CustomWrapper = null;


        //Inherit default constructors
        public MyCustomAccelByteSDK(AccelByteConfig config)
            : base(config) { }

        public MyCustomAccelByteSDK(AccelByteConfig config, List<ISdkService> services)
            : base(config, services) { }
    }
}
```

Example code for testing can be found [here](../samples/AccelByte.Sdk.Sample.CustomOperation.Tests/CustomSdkTests.cs).


## Testing
Create a .NET 6 `NUnit Test Project` and include [AccelByte.Sdk](https://www.nuget.org/packages/AccelByte.Sdk/) dependency.
Add reference to your custom operation project inside this test project.

You can use the code template below to start your sdk test class.
```csharp
using System;
using NUnit.Framework;

using AccelByte.Sdk.Core;

namespace SdkCustomization.Test1
{
    public class Tests
    {
        private AccelByteSDK? _Sdk = null;

        [OneTimeSetUp]
        public void Setup()
        {
            _Sdk = AccelByteSDK.Builder
                .UseDefaultHttpClient()
                .UseDefaultConfigRepository()
                .UseDefaultTokenRepository()
                .UseDefaultCredentialRepository()
                .EnableLog()
                .Build();

            //Use LoginUser if there are one or more endpoint/operations that requires user's authorization token.
            _Sdk.LoginUser();

            //or use LoginClient if all the endpoints only use oauth client token.
            //_Sdk.LoginClient();
        }

        [OneTimeTearDown]
        public void Finish()
        {
            if (_Sdk != null)
                _Sdk.Logout();
        }

        [Test]
        public void DoSomeTest()
        {
            Assert.IsNotNull(_Sdk);
            if (_Sdk == null)
                return;



            //Fill with your test logic here

        }
    }
}
```

You will need environment variables mentioned in [README](https://github.com/AccelByte/accelbyte-csharp-sdk#readme) to run the tests.
If you are using Visual Studio, you can create `.runsettings` file. Here is the example
```xml
<?xml version="1.0" encoding="utf-8"?>
<RunSettings>
    <RunConfiguration>
        <EnvironmentVariables>
            <AB_BASE_URL>https://demo.accelbyte.io</AB_BASE_URL>
            <AB_CLIENT_ID>abcdef0123456789abcdef0123456789</AB_CLIENT_ID>
            <AB_CLIENT_SECRET>ab#c,d)ef(ab#c,d)ef(ab#c,d)ef(ab</AB_CLIENT_SECRET>
            <AB_NAMESPACE>accelbyte</AB_NAMESPACE>
            <AB_APP_NAME>CustomOpTest</AB_APP_NAME>
            <AB_APP_VERSION>0.1.0</AB_APP_VERSION>
            <AB_USERNAME>example_user@dummy.com</AB_USERNAME>
            <AB_PASSWORD>1234567890!!</AB_PASSWORD>
        </EnvironmentVariables>
    </RunConfiguration>
</RunSettings>
```
Replace the variables with any valid AccelByte credentials. If all of your tests did not use user's authorization token. You can skip `AB_USERNAME` and `AB_PASSWORD`.
Then go to `Test` -> `Configure Run Settings` -> `Select Solutions Wide runsettings File` and select your newly created  `.runsettings` file.

> You can use `.runsettings` file also for dotnet cli, in case you did not want to add environment variable in your system.
> You can use this command to execute dotnet cli test
> ```bash
> dotnet test -s ~/config.runsettings
> ```

## References
Please see [api](../AccelByte.Sdk/Api) for more examples on how to create custom operation from generated code.

Full code example [here](../samples/AccelByte.Sdk.Sample.CustomOperation) and its [test](../samples/AccelByte.Sdk.Sample.CustomOperation.Tests) project.