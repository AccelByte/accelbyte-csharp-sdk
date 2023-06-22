# Use Custom JsonSerializationOptions

## Background
Majority of C# Extend SDK codes are generated using codegen tools. These codes are using default json serialization/deserialization options. In some cases, there are need to specify custom serialization/deserialization options to suite user's requirements.
These cases can be achieved without modifying generated codes.

## How to Set JsonSerializationOptions object to Operation.

Initialize AccelByteSDK object as usual.
While building an operation object, one can specify the `JsonSerializationOptions` to request using `SetRequestJsonOptions` method.
```csharp
var response = sdk.Cloudsave.PublicGameRecord.PostGameRecordHandlerV1Op
    .SetRequestJsonOptions(new JsonSerializerOptions()
    {
        ...
    })
    .Execute(gameRecordObject, "record_key", sdk.Namespace);
```
While building an operation object, one can specify the `JsonSerializationOptions` for response using `SetResponseJsonOptions` method.
```csharp
var response = sdk.Cloudsave.PublicGameRecord.GetGameRecordHandlerV1Op
    .SetResponseJsonOptions(new JsonSerializerOptions()
    {
        ...
    })
    .Execute("record_key", sdk.Namespace);
```
Or, if the same `JsonSerializationOptions` object is used for both request and response, one can use `SetJsonOptions` method.
```csharp
var response = sdk.Cloudsave.PublicGameRecord.PutGameRecordHandlerV1Op
    .SetJsonOptions(new JsonSerializerOptions()
    {
        ...
    })
    .Execute(gameRecordObject, "record_key", sdk.Namespace);
```

## References
Full code example [here](../AccelByte.Sdk.Tests/Services/CloudSaveTests.cs).
