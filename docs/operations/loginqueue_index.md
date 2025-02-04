# Loginqueue Service Index

&nbsp;  

## Operations

### Admin V1 Wrapper:  [AdminV1](../../AccelByte.Sdk/Api/Loginqueue/Wrapper/AdminV1.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/login-queue/v1/admin/namespaces/{namespace}/config` | GET | AdminGetConfiguration | [AdminGetConfiguration](../../AccelByte.Sdk/Api/Loginqueue/Operation/AdminV1/AdminGetConfiguration.cs) | [AdminGetConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Loginqueue/AdminV1/AdminGetConfiguration.cs) |
| `/login-queue/v1/admin/namespaces/{namespace}/config` | PUT | AdminUpdateConfiguration | [AdminUpdateConfiguration](../../AccelByte.Sdk/Api/Loginqueue/Operation/AdminV1/AdminUpdateConfiguration.cs) | [AdminUpdateConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Loginqueue/AdminV1/AdminUpdateConfiguration.cs) |
| `/login-queue/v1/admin/namespaces/{namespace}/status` | GET | AdminGetStatus | [AdminGetStatus](../../AccelByte.Sdk/Api/Loginqueue/Operation/AdminV1/AdminGetStatus.cs) | [AdminGetStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Loginqueue/AdminV1/AdminGetStatus.cs) |

### Ticket V1 Wrapper:  [TicketV1](../../AccelByte.Sdk/Api/Loginqueue/Wrapper/TicketV1.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/login-queue/v1/namespaces/{namespace}/ticket` | GET | RefreshTicket | [RefreshTicket](../../AccelByte.Sdk/Api/Loginqueue/Operation/TicketV1/RefreshTicket.cs) | [RefreshTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Loginqueue/TicketV1/RefreshTicket.cs) |
| `/login-queue/v1/namespaces/{namespace}/ticket` | DELETE | CancelTicket | [CancelTicket](../../AccelByte.Sdk/Api/Loginqueue/Operation/TicketV1/CancelTicket.cs) | [CancelTicket](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Loginqueue/TicketV1/CancelTicket.cs) |


&nbsp;  

## Operations with Generic Response

### Admin V1 Wrapper:  [AdminV1](../../AccelByte.Sdk/Api/Loginqueue/Wrapper/AdminV1.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Ticket V1 Wrapper:  [TicketV1](../../AccelByte.Sdk/Api/Loginqueue/Wrapper/TicketV1.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `apimodels.ConfigurationRequest` | [ApimodelsConfigurationRequest](../../AccelByte.Sdk/Api/Loginqueue/Model/ApimodelsConfigurationRequest.cs) |
| `apimodels.ConfigurationResponse` | [ApimodelsConfigurationResponse](../../AccelByte.Sdk/Api/Loginqueue/Model/ApimodelsConfigurationResponse.cs) |
| `apimodels.Link` | [ApimodelsLink](../../AccelByte.Sdk/Api/Loginqueue/Model/ApimodelsLink.cs) |
| `apimodels.QueueStatusResponse` | [ApimodelsQueueStatusResponse](../../AccelByte.Sdk/Api/Loginqueue/Model/ApimodelsQueueStatusResponse.cs) |
| `apimodels.RefreshTicketResponse` | [ApimodelsRefreshTicketResponse](../../AccelByte.Sdk/Api/Loginqueue/Model/ApimodelsRefreshTicketResponse.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Loginqueue/Model/ResponseError.cs) |
