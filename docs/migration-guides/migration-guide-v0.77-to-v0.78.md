<a name="v0.78.0"></a>
## [0.78.0] - 2026-01-12

### BREAKING CHANGE

### Cloudsave

The following operation(s) has been updated following to the OpenAPI spec changes.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.PublicGameRecord.PostGameRecordHandlerV1`
  - Request body parameter type changed from `ModelsGameRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.PublicGameRecord.PutGameRecordHandlerV1`
  - Request body parameter type changed from `ModelsGameRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.PublicPlayerRecord.PostPlayerRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.PublicPlayerRecord.PutPlayerRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.PublicPlayerRecord.PostPlayerPublicRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.PublicPlayerRecord.PutPlayerPublicRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminGameRecord.AdminPostGameRecordHandlerV1`
  - Request body parameter type changed from `ModelsGameRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminGameRecord.AdminPutGameRecordHandlerV1`
  - Request body parameter type changed from `ModelsGameRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPlayerRecord.AdminPostPlayerRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPlayerRecord.AdminPutPlayerRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPlayerRecord.AdminPostPlayerPublicRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminPlayerRecord.AdminPutPlayerPublicRecordHandlerV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminRecord.AdminPostAdminGameRecordV1`
  - Request body parameter type changed from `ModelsGameRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminRecord.AdminPutAdminGameRecordV1`
  - Request body parameter type changed from `ModelsGameRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminRecord.AdminPostPlayerAdminRecordV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

- Operation `AccelByte.Sdk.Api.Cloudsave.Operation.AdminRecord.AdminPutAdminPlayerRecordV1`
  - Request body parameter type changed from `ModelsPlayerRecordRequest` to `Dictionary<string, object>`.

### Platform

The following operation(s) has been updated following to the OpenAPI spec changes.

- Operation `AccelByte.Sdk.Api.Platform.Operation.Item.GetEstimatedPrice`
  - Response type changed from `EstimatedPriceInfo?` to `List<EstimatedPriceInfo>?`.

- Operation `AccelByte.Sdk.Api.Platform.Operation.IAP.QueryAbnormalTransactions`
  - Response type changed from `SteamAbnormalTransactionPagingSlicedResult?` to `Dictionary<string, object>?`.

- Operation `AccelByte.Sdk.Api.Platform.Operation.IAP.QuerySteamReportHistories`
  - Response type changed from `SteamReportInfoPagingSlicedResult?` to `Dictionary<string, object>?`.

- Operation `AccelByte.Sdk.Api.Platform.Operation.IAPNotification.QueryThirdPartyNotifications`
  - Response type changed from `NotificationPagingSlicedResult?` to `Dictionary<string, object>?`.

- Operation `AccelByte.Sdk.Api.Platform.Operation.PaymentStation.PublicGetQRCode`
  - Response type changed from `BinarySchema?` to `Dictionary<string, object>?`.

### Chat

The following operation(s) has been updated following to the OpenAPI spec changes.

- Operation `AccelByte.Sdk.Api.Chat.Operation.Inbox.AdminSendInboxMessage`
  - Request body parameter type changed from `ModelsSendInboxMessageRequest` to `Dictionary<string, object>`.
  - Response type changed from `ModelsSendInboxMessageResponse?` to `Dictionary<string, object>?`.

- Operation `AccelByte.Sdk.Api.Chat.Operation.Inbox.AdminGetCategorySchema`
  - Response type changed from `ModelsJSONSchemaType?` to `Dictionary<string, object>?`.

- Operation `AccelByte.Sdk.Api.Chat.Operation.Inbox.AdminUnsendInboxMessage`
  - Response type changed from `ModelsUnsendInboxMessageResponse?` to `Dictionary<string, object>?`.
