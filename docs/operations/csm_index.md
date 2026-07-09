# Csm Service Index

&nbsp;  

## Operations

### App UI Wrapper:  [AppUI](../../AccelByte.Sdk/Api/Csm/Wrapper/AppUI.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v1/admin/namespaces/{namespace}/app-ui` | GET | ListAppUI | [ListAppUI](../../AccelByte.Sdk/Api/Csm/Operation/AppUI/ListAppUI.cs) | [ListAppUI](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppUI/ListAppUI.cs) |
| `/csm/v1/admin/namespaces/{namespace}/app-ui` | POST | CreateAppUI | [CreateAppUI](../../AccelByte.Sdk/Api/Csm/Operation/AppUI/CreateAppUI.cs) | [CreateAppUI](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppUI/CreateAppUI.cs) |
| `/csm/v1/admin/namespaces/{namespace}/app-ui/{appUiName}` | DELETE | DeleteAppUI | [DeleteAppUI](../../AccelByte.Sdk/Api/Csm/Operation/AppUI/DeleteAppUI.cs) | [DeleteAppUI](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppUI/DeleteAppUI.cs) |
| `/csm/v1/admin/namespaces/{namespace}/app-ui/{appUiName}/files/upload` | POST | UploadAppUIFile | [UploadAppUIFile](../../AccelByte.Sdk/Api/Csm/Operation/AppUI/UploadAppUIFile.cs) | [UploadAppUIFile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppUI/UploadAppUIFile.cs) |

### App Wrapper:  [App](../../AccelByte.Sdk/Api/Csm/Wrapper/App.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps` | POST | GetAppListV1 | [GetAppListV1](../../AccelByte.Sdk/Api/Csm/Operation/App/GetAppListV1.cs) | [GetAppListV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/GetAppListV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}` | GET | GetAppV1 | [GetAppV1](../../AccelByte.Sdk/Api/Csm/Operation/App/GetAppV1.cs) | [GetAppV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/GetAppV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}` | PUT | CreateAppV1 | [CreateAppV1](../../AccelByte.Sdk/Api/Csm/Operation/App/CreateAppV1.cs) | [CreateAppV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/CreateAppV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}` | DELETE | DeleteAppV1 | [DeleteAppV1](../../AccelByte.Sdk/Api/Csm/Operation/App/DeleteAppV1.cs) | [DeleteAppV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/DeleteAppV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}` | PATCH | UpdateAppV1 | [UpdateAppV1](../../AccelByte.Sdk/Api/Csm/Operation/App/UpdateAppV1.cs) | [UpdateAppV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/UpdateAppV1.cs) |
| `/csm/v1/admin/namespaces/{namespace}/apps/{app}/release` | GET | GetAppReleaseV1 | [GetAppReleaseV1](../../AccelByte.Sdk/Api/Csm/Operation/App/GetAppReleaseV1.cs) | [GetAppReleaseV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/GetAppReleaseV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/start` | PUT | StartAppV1 | [StartAppV1](../../AccelByte.Sdk/Api/Csm/Operation/App/StartAppV1.cs) | [StartAppV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/StartAppV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/stop` | PUT | StopAppV1 | [StopAppV1](../../AccelByte.Sdk/Api/Csm/Operation/App/StopAppV1.cs) | [StopAppV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/App/StopAppV1.cs) |

### Deployment Wrapper:  [Deployment](../../AccelByte.Sdk/Api/Csm/Wrapper/Deployment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/deployments` | POST | CreateDeploymentV1 | [CreateDeploymentV1](../../AccelByte.Sdk/Api/Csm/Operation/Deployment/CreateDeploymentV1.cs) | [CreateDeploymentV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Deployment/CreateDeploymentV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/deployments` | POST | GetListOfDeploymentV1 | [GetListOfDeploymentV1](../../AccelByte.Sdk/Api/Csm/Operation/Deployment/GetListOfDeploymentV1.cs) | [GetListOfDeploymentV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Deployment/GetListOfDeploymentV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/deployments/{deploymentId}` | GET | GetDeploymentV1 | [GetDeploymentV1](../../AccelByte.Sdk/Api/Csm/Operation/Deployment/GetDeploymentV1.cs) | [GetDeploymentV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Deployment/GetDeploymentV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/deployments/{deploymentId}` | DELETE | DeleteDeploymentV1 | [DeleteDeploymentV1](../../AccelByte.Sdk/Api/Csm/Operation/Deployment/DeleteDeploymentV1.cs) | [DeleteDeploymentV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Deployment/DeleteDeploymentV1.cs) |

### Image Wrapper:  [Image](../../AccelByte.Sdk/Api/Csm/Wrapper/Image.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/images` | GET | GetAppImageListV1 | [GetAppImageListV1](../../AccelByte.Sdk/Api/Csm/Operation/Image/GetAppImageListV1.cs) | [GetAppImageListV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Image/GetAppImageListV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/images` | DELETE | DeleteAppImagesV1 | [DeleteAppImagesV1](../../AccelByte.Sdk/Api/Csm/Operation/Image/DeleteAppImagesV1.cs) | [DeleteAppImagesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Image/DeleteAppImagesV1.cs) |

### Configuration Wrapper:  [Configuration](../../AccelByte.Sdk/Api/Csm/Wrapper/Configuration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets` | GET | GetListOfSecretsV1 | [GetListOfSecretsV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/GetListOfSecretsV1.cs) | [GetListOfSecretsV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/GetListOfSecretsV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets` | POST | SaveSecretV1 | [SaveSecretV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/SaveSecretV1.cs) | [SaveSecretV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/SaveSecretV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets/{configId}` | PUT | UpdateSecretV1 | [UpdateSecretV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/UpdateSecretV1.cs) | [UpdateSecretV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/UpdateSecretV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/secrets/{configId}` | DELETE | DeleteSecretV1 | [DeleteSecretV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/DeleteSecretV1.cs) | [DeleteSecretV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/DeleteSecretV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/variables` | GET | GetListOfVariablesV1 | [GetListOfVariablesV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/GetListOfVariablesV1.cs) | [GetListOfVariablesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/GetListOfVariablesV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/variables` | POST | SaveVariableV1 | [SaveVariableV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/SaveVariableV1.cs) | [SaveVariableV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/SaveVariableV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/variables/{configId}` | PUT | UpdateVariableV1 | [UpdateVariableV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/UpdateVariableV1.cs) | [UpdateVariableV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/UpdateVariableV1.cs) |
| [DEPRECATED] `/csm/v1/admin/namespaces/{namespace}/apps/{app}/variables/{configId}` | DELETE | DeleteVariableV1 | [DeleteVariableV1](../../AccelByte.Sdk/Api/Csm/Operation/Configuration/DeleteVariableV1.cs) | [DeleteVariableV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Configuration/DeleteVariableV1.cs) |

### Extend Files Wrapper:  [ExtendFiles](../../AccelByte.Sdk/Api/Csm/Wrapper/ExtendFiles.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v1/admin/namespaces/{namespace}/files/{filePath}` | GET | GetExtendFile | [GetExtendFile](../../AccelByte.Sdk/Api/Csm/Operation/ExtendFiles/GetExtendFile.cs) | [GetExtendFile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ExtendFiles/GetExtendFile.cs) |

### Messages Wrapper:  [Messages](../../AccelByte.Sdk/Api/Csm/Wrapper/Messages.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../AccelByte.Sdk/Api/Csm/Operation/Messages/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Messages/PublicGetMessages.cs) |

### App V2 Wrapper:  [AppV2](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps` | POST | GetAppListV2 | [GetAppListV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/GetAppListV2.cs) | [GetAppListV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/GetAppListV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | GET | GetAppV2 | [GetAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/GetAppV2.cs) | [GetAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/GetAppV2.cs) |
| [DEPRECATED] `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | POST | CreateAppV2 | [CreateAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/CreateAppV2.cs) | [CreateAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/CreateAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | DELETE | DeleteAppV2 | [DeleteAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/DeleteAppV2.cs) | [DeleteAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/DeleteAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | PATCH | UpdateAppV2 | [UpdateAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/UpdateAppV2.cs) | [UpdateAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/UpdateAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/apply` | POST | ApplyAppConfigV2 | [ApplyAppConfigV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/ApplyAppConfigV2.cs) | [ApplyAppConfigV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/ApplyAppConfigV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/resources` | PATCH | UpdateAppResourcesV2 | [UpdateAppResourcesV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/UpdateAppResourcesV2.cs) | [UpdateAppResourcesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/UpdateAppResourcesV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/resources/form` | POST | UpdateAppResourcesResourceLimitFormV2 | [UpdateAppResourcesResourceLimitFormV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/UpdateAppResourcesResourceLimitFormV2.cs) | [UpdateAppResourcesResourceLimitFormV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/UpdateAppResourcesResourceLimitFormV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/start` | PUT | StartAppV2 | [StartAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/StartAppV2.cs) | [StartAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/StartAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/stop` | PUT | StopAppV2 | [StopAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/StopAppV2.cs) | [StopAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/StopAppV2.cs) |

### Async Messaging Wrapper:  [AsyncMessaging](../../AccelByte.Sdk/Api/Csm/Wrapper/AsyncMessaging.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/asyncmessaging/topics/subscriptions` | POST | CreateSubscriptionHandler | [CreateSubscriptionHandler](../../AccelByte.Sdk/Api/Csm/Operation/AsyncMessaging/CreateSubscriptionHandler.cs) | [CreateSubscriptionHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AsyncMessaging/CreateSubscriptionHandler.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/asyncmessaging/topics/{topicName}/subscriptions` | DELETE | UnsubscribeTopicHandler | [UnsubscribeTopicHandler](../../AccelByte.Sdk/Api/Csm/Operation/AsyncMessaging/UnsubscribeTopicHandler.cs) | [UnsubscribeTopicHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AsyncMessaging/UnsubscribeTopicHandler.cs) |
| `/csm/v2/admin/namespaces/{namespace}/asyncmessaging/topics` | GET | ListTopicsHandler | [ListTopicsHandler](../../AccelByte.Sdk/Api/Csm/Operation/AsyncMessaging/ListTopicsHandler.cs) | [ListTopicsHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AsyncMessaging/ListTopicsHandler.cs) |
| `/csm/v2/admin/namespaces/{namespace}/asyncmessaging/topics` | POST | CreateTopicHandler | [CreateTopicHandler](../../AccelByte.Sdk/Api/Csm/Operation/AsyncMessaging/CreateTopicHandler.cs) | [CreateTopicHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AsyncMessaging/CreateTopicHandler.cs) |
| `/csm/v2/admin/namespaces/{namespace}/asyncmessaging/topics/{topicName}` | DELETE | DeleteTopicHandler | [DeleteTopicHandler](../../AccelByte.Sdk/Api/Csm/Operation/AsyncMessaging/DeleteTopicHandler.cs) | [DeleteTopicHandler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AsyncMessaging/DeleteTopicHandler.cs) |

### Deployment V2 Wrapper:  [DeploymentV2](../../AccelByte.Sdk/Api/Csm/Wrapper/DeploymentV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/deployments` | POST | CreateDeploymentV2 | [CreateDeploymentV2](../../AccelByte.Sdk/Api/Csm/Operation/DeploymentV2/CreateDeploymentV2.cs) | [CreateDeploymentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/DeploymentV2/CreateDeploymentV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/deployments` | POST | GetListOfDeploymentV2 | [GetListOfDeploymentV2](../../AccelByte.Sdk/Api/Csm/Operation/DeploymentV2/GetListOfDeploymentV2.cs) | [GetListOfDeploymentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/DeploymentV2/GetListOfDeploymentV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/deployments/{deploymentId}` | GET | GetDeploymentV2 | [GetDeploymentV2](../../AccelByte.Sdk/Api/Csm/Operation/DeploymentV2/GetDeploymentV2.cs) | [GetDeploymentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/DeploymentV2/GetDeploymentV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/deployments/{deploymentId}` | DELETE | DeleteDeploymentV2 | [DeleteDeploymentV2](../../AccelByte.Sdk/Api/Csm/Operation/DeploymentV2/DeleteDeploymentV2.cs) | [DeleteDeploymentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/DeploymentV2/DeleteDeploymentV2.cs) |

### Image V2 Wrapper:  [ImageV2](../../AccelByte.Sdk/Api/Csm/Wrapper/ImageV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/images` | GET | GetAppImageListV2 | [GetAppImageListV2](../../AccelByte.Sdk/Api/Csm/Operation/ImageV2/GetAppImageListV2.cs) | [GetAppImageListV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ImageV2/GetAppImageListV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/images` | DELETE | DeleteAppImagesV2 | [DeleteAppImagesV2](../../AccelByte.Sdk/Api/Csm/Operation/ImageV2/DeleteAppImagesV2.cs) | [DeleteAppImagesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ImageV2/DeleteAppImagesV2.cs) |

### Managed Resources - KeyValue Wrapper:  [ManagedResourcesKeyValue](../../AccelByte.Sdk/Api/Csm/Wrapper/ManagedResourcesKeyValue.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/keyvalue/credentials` | POST | CreateKeyValueCredentialV2 | [CreateKeyValueCredentialV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/CreateKeyValueCredentialV2.cs) | [CreateKeyValueCredentialV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/CreateKeyValueCredentialV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/keyvalue/integrations` | GET | GetIntegrationAppKeyValueClusterV2 | [GetIntegrationAppKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/GetIntegrationAppKeyValueClusterV2.cs) | [GetIntegrationAppKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/GetIntegrationAppKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/keyvalue/integrations` | POST | IntegrateAppKeyValueClusterV2 | [IntegrateAppKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/IntegrateAppKeyValueClusterV2.cs) | [IntegrateAppKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/IntegrateAppKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/keyvalue/integrations` | DELETE | RemoveIntegrationAppKeyValueClusterV2 | [RemoveIntegrationAppKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/RemoveIntegrationAppKeyValueClusterV2.cs) | [RemoveIntegrationAppKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/RemoveIntegrationAppKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/keyvalue/cluster/{resourceId}` | GET | GetKeyValueClusterV2 | [GetKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/GetKeyValueClusterV2.cs) | [GetKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/GetKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/keyvalue/clusters` | GET | ListKeyValueClusterV2 | [ListKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/ListKeyValueClusterV2.cs) | [ListKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/ListKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/keyvalue/clusters` | POST | CreateKeyValueClusterV2 | [CreateKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/CreateKeyValueClusterV2.cs) | [CreateKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/CreateKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/keyvalue/clusters/limitconfig` | GET | GetKeyValueClusterLimitConfigV2 | [GetKeyValueClusterLimitConfigV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/GetKeyValueClusterLimitConfigV2.cs) | [GetKeyValueClusterLimitConfigV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/GetKeyValueClusterLimitConfigV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/keyvalue/clusters/{resourceId}` | PUT | UpdateKeyValueClusterV2 | [UpdateKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/UpdateKeyValueClusterV2.cs) | [UpdateKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/UpdateKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/keyvalue/clusters/{resourceId}` | DELETE | DeleteKeyValueClusterV2 | [DeleteKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/DeleteKeyValueClusterV2.cs) | [DeleteKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/DeleteKeyValueClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/keyvalue/{resourceId}/integrations` | GET | GetListIntegratedAppKeyValueClusterV2 | [GetListIntegratedAppKeyValueClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesKeyValue/GetListIntegratedAppKeyValueClusterV2.cs) | [GetListIntegratedAppKeyValueClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesKeyValue/GetListIntegratedAppKeyValueClusterV2.cs) |

### Managed Resources Wrapper:  [ManagedResources](../../AccelByte.Sdk/Api/Csm/Wrapper/ManagedResources.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/nosql/credentials` | POST | CreateNewNoSQLDatabaseCredentialV2 | [CreateNewNoSQLDatabaseCredentialV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/CreateNewNoSQLDatabaseCredentialV2.cs) | [CreateNewNoSQLDatabaseCredentialV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/CreateNewNoSQLDatabaseCredentialV2.cs) |
| [DEPRECATED] `/csm/v2/admin/namespaces/{namespace}/apps/{app}/nosql/crendentials` | POST | CreateNoSQLDatabaseCredentialV2 | [CreateNoSQLDatabaseCredentialV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/CreateNoSQLDatabaseCredentialV2.cs) | [CreateNoSQLDatabaseCredentialV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/CreateNoSQLDatabaseCredentialV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/nosql/databases` | GET | GetNoSQLDatabaseV2 | [GetNoSQLDatabaseV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/GetNoSQLDatabaseV2.cs) | [GetNoSQLDatabaseV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/GetNoSQLDatabaseV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/nosql/databases` | POST | CreateNoSQLDatabaseV2 | [CreateNoSQLDatabaseV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/CreateNoSQLDatabaseV2.cs) | [CreateNoSQLDatabaseV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/CreateNoSQLDatabaseV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/nosql/databases` | DELETE | DeleteNoSQLDatabaseV2 | [DeleteNoSQLDatabaseV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/DeleteNoSQLDatabaseV2.cs) | [DeleteNoSQLDatabaseV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/DeleteNoSQLDatabaseV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/nosql/clusters` | GET | GetNoSQLClusterV2 | [GetNoSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/GetNoSQLClusterV2.cs) | [GetNoSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/GetNoSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/nosql/clusters` | PUT | UpdateNoSQLClusterV2 | [UpdateNoSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/UpdateNoSQLClusterV2.cs) | [UpdateNoSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/UpdateNoSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/nosql/clusters` | POST | CreateNoSQLClusterV2 | [CreateNoSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/CreateNoSQLClusterV2.cs) | [CreateNoSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/CreateNoSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/nosql/clusters` | DELETE | DeleteNoSQLClusterV2 | [DeleteNoSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/DeleteNoSQLClusterV2.cs) | [DeleteNoSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/DeleteNoSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/nosql/clusters/start` | PUT | StartNoSQLClusterV2 | [StartNoSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/StartNoSQLClusterV2.cs) | [StartNoSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/StartNoSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/nosql/clusters/stop` | PUT | StopNoSQLClusterV2 | [StopNoSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/StopNoSQLClusterV2.cs) | [StopNoSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/StopNoSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/nosql/tunnels` | GET | GetNoSQLAccessTunnelV2 | [GetNoSQLAccessTunnelV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/GetNoSQLAccessTunnelV2.cs) | [GetNoSQLAccessTunnelV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/GetNoSQLAccessTunnelV2.cs) |
| `/csm/v2/admin/namespaces/{studioName}/nosql/{resourceId}/apps` | GET | GetNoSQLAppListV2 | [GetNoSQLAppListV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResources/GetNoSQLAppListV2.cs) | [GetNoSQLAppListV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResources/GetNoSQLAppListV2.cs) |

### Configuration V2 Wrapper:  [ConfigurationV2](../../AccelByte.Sdk/Api/Csm/Wrapper/ConfigurationV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/secrets` | GET | GetListOfSecretsV2 | [GetListOfSecretsV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/GetListOfSecretsV2.cs) | [GetListOfSecretsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/GetListOfSecretsV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/secrets` | POST | SaveSecretV2 | [SaveSecretV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/SaveSecretV2.cs) | [SaveSecretV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/SaveSecretV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/secrets/{configId}` | PUT | UpdateSecretV2 | [UpdateSecretV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/UpdateSecretV2.cs) | [UpdateSecretV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/UpdateSecretV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/secrets/{configId}` | DELETE | DeleteSecretV2 | [DeleteSecretV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/DeleteSecretV2.cs) | [DeleteSecretV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/DeleteSecretV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/variables` | GET | GetListOfVariablesV2 | [GetListOfVariablesV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/GetListOfVariablesV2.cs) | [GetListOfVariablesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/GetListOfVariablesV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/variables` | POST | SaveVariableV2 | [SaveVariableV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/SaveVariableV2.cs) | [SaveVariableV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/SaveVariableV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/variables/{configId}` | PUT | UpdateVariableV2 | [UpdateVariableV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/UpdateVariableV2.cs) | [UpdateVariableV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/UpdateVariableV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/variables/{configId}` | DELETE | DeleteVariableV2 | [DeleteVariableV2](../../AccelByte.Sdk/Api/Csm/Operation/ConfigurationV2/DeleteVariableV2.cs) | [DeleteVariableV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ConfigurationV2/DeleteVariableV2.cs) |

### Managed Resources - SQL Wrapper:  [ManagedResourcesSQL](../../AccelByte.Sdk/Api/Csm/Wrapper/ManagedResourcesSQL.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/sql/credentials` | POST | CreateSQLDatabaseCredentialV2 | [CreateSQLDatabaseCredentialV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/CreateSQLDatabaseCredentialV2.cs) | [CreateSQLDatabaseCredentialV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/CreateSQLDatabaseCredentialV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/sql/databases` | GET | GetSQLDatabaseV2 | [GetSQLDatabaseV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/GetSQLDatabaseV2.cs) | [GetSQLDatabaseV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/GetSQLDatabaseV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/sql/databases` | POST | CreateSQLDatabaseV2 | [CreateSQLDatabaseV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/CreateSQLDatabaseV2.cs) | [CreateSQLDatabaseV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/CreateSQLDatabaseV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/sql/databases` | DELETE | DeleteSQLDatabaseV2 | [DeleteSQLDatabaseV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/DeleteSQLDatabaseV2.cs) | [DeleteSQLDatabaseV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/DeleteSQLDatabaseV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/sql/clusters` | GET | GetSQLClusterV2 | [GetSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/GetSQLClusterV2.cs) | [GetSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/GetSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/sql/clusters` | PUT | UpdateSQLClusterV2 | [UpdateSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/UpdateSQLClusterV2.cs) | [UpdateSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/UpdateSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/sql/clusters` | POST | CreateSQLClusterV2 | [CreateSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/CreateSQLClusterV2.cs) | [CreateSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/CreateSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/sql/clusters` | DELETE | DeleteSQLClusterV2 | [DeleteSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/DeleteSQLClusterV2.cs) | [DeleteSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/DeleteSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/sql/clusters/start` | PUT | StartSQLClusterV2 | [StartSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/StartSQLClusterV2.cs) | [StartSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/StartSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/sql/clusters/stop` | PUT | StopSQLClusterV2 | [StopSQLClusterV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/StopSQLClusterV2.cs) | [StopSQLClusterV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/StopSQLClusterV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/sql/{resourceId}/apps` | GET | GetSQLAppListV2 | [GetSQLAppListV2](../../AccelByte.Sdk/Api/Csm/Operation/ManagedResourcesSQL/GetSQLAppListV2.cs) | [GetSQLAppListV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ManagedResourcesSQL/GetSQLAppListV2.cs) |

### Notification Subscription Wrapper:  [NotificationSubscription](../../AccelByte.Sdk/Api/Csm/Wrapper/NotificationSubscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions` | GET | GetNotificationSubscriberListV2 | [GetNotificationSubscriberListV2](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/GetNotificationSubscriberListV2.cs) | [GetNotificationSubscriberListV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/GetNotificationSubscriberListV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions` | PUT | BulkSaveSubscriptionAppNotificationV2 | [BulkSaveSubscriptionAppNotificationV2](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/BulkSaveSubscriptionAppNotificationV2.cs) | [BulkSaveSubscriptionAppNotificationV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/BulkSaveSubscriptionAppNotificationV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions` | POST | SubscribeAppNotificationV2 | [SubscribeAppNotificationV2](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/SubscribeAppNotificationV2.cs) | [SubscribeAppNotificationV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/SubscribeAppNotificationV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions/me` | GET | GetSubscriptionV2Handler | [GetSubscriptionV2Handler](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/GetSubscriptionV2Handler.cs) | [GetSubscriptionV2Handler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/GetSubscriptionV2Handler.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions/me` | POST | SubscribeV2Handler | [SubscribeV2Handler](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/SubscribeV2Handler.cs) | [SubscribeV2Handler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/SubscribeV2Handler.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions/me` | DELETE | UnsubscribeV2Handler | [UnsubscribeV2Handler](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/UnsubscribeV2Handler.cs) | [UnsubscribeV2Handler](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/UnsubscribeV2Handler.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions/users/{userId}` | DELETE | DeleteSubscriptionAppNotificationByUserIDV2 | [DeleteSubscriptionAppNotificationByUserIDV2](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/DeleteSubscriptionAppNotificationByUserIDV2.cs) | [DeleteSubscriptionAppNotificationByUserIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/DeleteSubscriptionAppNotificationByUserIDV2.cs) |
| [DEPRECATED] `/csm/v2/admin/namespaces/{namespace}/apps/{app}/subscriptions/{subscriptionId}` | DELETE | DeleteSubscriptionAppNotificationV2 | [DeleteSubscriptionAppNotificationV2](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscription/DeleteSubscriptionAppNotificationV2.cs) | [DeleteSubscriptionAppNotificationV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscription/DeleteSubscriptionAppNotificationV2.cs) |

### Resources Limits Wrapper:  [ResourcesLimits](../../AccelByte.Sdk/Api/Csm/Wrapper/ResourcesLimits.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/resources/limits` | GET | GetResourcesLimits | [GetResourcesLimits](../../AccelByte.Sdk/Api/Csm/Operation/ResourcesLimits/GetResourcesLimits.cs) | [GetResourcesLimits](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/ResourcesLimits/GetResourcesLimits.cs) |

### Notification Subscription V3 Wrapper:  [NotificationSubscriptionV3](../../AccelByte.Sdk/Api/Csm/Wrapper/NotificationSubscriptionV3.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v3/admin/namespaces/{namespace}/apps/{app}/subscriptions` | GET | GetNotificationSubscriberListV3 | [GetNotificationSubscriberListV3](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscriptionV3/GetNotificationSubscriberListV3.cs) | [GetNotificationSubscriberListV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscriptionV3/GetNotificationSubscriberListV3.cs) |
| `/csm/v3/admin/namespaces/{namespace}/apps/{app}/subscriptions` | DELETE | DeleteSubscriptionAppNotificationV3 | [DeleteSubscriptionAppNotificationV3](../../AccelByte.Sdk/Api/Csm/Operation/NotificationSubscriptionV3/DeleteSubscriptionAppNotificationV3.cs) | [DeleteSubscriptionAppNotificationV3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/NotificationSubscriptionV3/DeleteSubscriptionAppNotificationV3.cs) |

### App V4 Wrapper:  [AppV4](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV4.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v4/admin/namespaces/{namespace}/apps/{app}/debuginfo` | GET | GetAppDebugInfoV4 | [GetAppDebugInfoV4](../../AccelByte.Sdk/Api/Csm/Operation/AppV4/GetAppDebugInfoV4.cs) | [GetAppDebugInfoV4](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV4/GetAppDebugInfoV4.cs) |
| `/csm/v4/admin/namespaces/{namespace}/apps/{app}/debugmode` | PUT | UpdateAppDebugModeV4 | [UpdateAppDebugModeV4](../../AccelByte.Sdk/Api/Csm/Operation/AppV4/UpdateAppDebugModeV4.cs) | [UpdateAppDebugModeV4](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV4/UpdateAppDebugModeV4.cs) |

### App Status Progress V4 Wrapper:  [AppStatusProgressV4](../../AccelByte.Sdk/Api/Csm/Wrapper/AppStatusProgressV4.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v4/admin/namespaces/{namespace}/apps/{app}/status-progress` | GET | GetAppStatusProgressV4 | [GetAppStatusProgressV4](../../AccelByte.Sdk/Api/Csm/Operation/AppStatusProgressV4/GetAppStatusProgressV4.cs) | [GetAppStatusProgressV4](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppStatusProgressV4/GetAppStatusProgressV4.cs) |

### App V5 Wrapper:  [AppV5](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV5.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v5/admin/namespaces/{namespace}/apps/{app}` | POST | CreateAppV5 | [CreateAppV5](../../AccelByte.Sdk/Api/Csm/Operation/AppV5/CreateAppV5.cs) | [CreateAppV5](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV5/CreateAppV5.cs) |


&nbsp;  

## Operations with Generic Response

### App UI Wrapper:  [AppUI](../../AccelByte.Sdk/Api/Csm/Wrapper/AppUI.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### App Wrapper:  [App](../../AccelByte.Sdk/Api/Csm/Wrapper/App.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Deployment Wrapper:  [Deployment](../../AccelByte.Sdk/Api/Csm/Wrapper/Deployment.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Image Wrapper:  [Image](../../AccelByte.Sdk/Api/Csm/Wrapper/Image.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Configuration Wrapper:  [Configuration](../../AccelByte.Sdk/Api/Csm/Wrapper/Configuration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Extend Files Wrapper:  [ExtendFiles](../../AccelByte.Sdk/Api/Csm/Wrapper/ExtendFiles.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Messages Wrapper:  [Messages](../../AccelByte.Sdk/Api/Csm/Wrapper/Messages.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### App V2 Wrapper:  [AppV2](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Async Messaging Wrapper:  [AsyncMessaging](../../AccelByte.Sdk/Api/Csm/Wrapper/AsyncMessaging.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Deployment V2 Wrapper:  [DeploymentV2](../../AccelByte.Sdk/Api/Csm/Wrapper/DeploymentV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Image V2 Wrapper:  [ImageV2](../../AccelByte.Sdk/Api/Csm/Wrapper/ImageV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Managed Resources - KeyValue Wrapper:  [ManagedResourcesKeyValue](../../AccelByte.Sdk/Api/Csm/Wrapper/ManagedResourcesKeyValue.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Managed Resources Wrapper:  [ManagedResources](../../AccelByte.Sdk/Api/Csm/Wrapper/ManagedResources.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Configuration V2 Wrapper:  [ConfigurationV2](../../AccelByte.Sdk/Api/Csm/Wrapper/ConfigurationV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Managed Resources - SQL Wrapper:  [ManagedResourcesSQL](../../AccelByte.Sdk/Api/Csm/Wrapper/ManagedResourcesSQL.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Notification Subscription Wrapper:  [NotificationSubscription](../../AccelByte.Sdk/Api/Csm/Wrapper/NotificationSubscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Resources Limits Wrapper:  [ResourcesLimits](../../AccelByte.Sdk/Api/Csm/Wrapper/ResourcesLimits.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Notification Subscription V3 Wrapper:  [NotificationSubscriptionV3](../../AccelByte.Sdk/Api/Csm/Wrapper/NotificationSubscriptionV3.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### App V4 Wrapper:  [AppV4](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV4.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### App Status Progress V4 Wrapper:  [AppStatusProgressV4](../../AccelByte.Sdk/Api/Csm/Wrapper/AppStatusProgressV4.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### App V5 Wrapper:  [AppV5](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV5.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `apimodel.AppDebugInfoResponse` | [ApimodelAppDebugInfoResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAppDebugInfoResponse.cs) |
| `apimodel.AppItem` | [ApimodelAppItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAppItem.cs) |
| `apimodel.AppItemV5` | [ApimodelAppItemV5](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAppItemV5.cs) |
| `apimodel.AppStatusProgressStep` | [ApimodelAppStatusProgressStep](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAppStatusProgressStep.cs) |
| `apimodel.AppUIResponse` | [ApimodelAppUIResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAppUIResponse.cs) |
| `apimodel.ApplyAppConfigRequest` | [ApimodelApplyAppConfigRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelApplyAppConfigRequest.cs) |
| `apimodel.ApplyConfigItem` | [ApimodelApplyConfigItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelApplyConfigItem.cs) |
| `apimodel.ApplyPermissionItem` | [ApimodelApplyPermissionItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelApplyPermissionItem.cs) |
| `apimodel.AutoscalingRequest` | [ApimodelAutoscalingRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAutoscalingRequest.cs) |
| `apimodel.AutoscalingResponse` | [ApimodelAutoscalingResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAutoscalingResponse.cs) |
| `apimodel.BulkSubscribeItem` | [ApimodelBulkSubscribeItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelBulkSubscribeItem.cs) |
| `apimodel.BulkSubscribeRequest` | [ApimodelBulkSubscribeRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelBulkSubscribeRequest.cs) |
| `apimodel.CPURequest` | [ApimodelCPURequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCPURequest.cs) |
| `apimodel.CPUResponse` | [ApimodelCPUResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCPUResponse.cs) |
| `apimodel.CSMAppLimitsResponse` | [ApimodelCSMAppLimitsResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCSMAppLimitsResponse.cs) |
| `apimodel.CreateAppUIRequest` | [ApimodelCreateAppUIRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateAppUIRequest.cs) |
| `apimodel.CreateAppV2Request` | [ApimodelCreateAppV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateAppV2Request.cs) |
| `apimodel.CreateAppV5Request` | [ApimodelCreateAppV5Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateAppV5Request.cs) |
| `apimodel.CreateDeploymentV2Request` | [ApimodelCreateDeploymentV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateDeploymentV2Request.cs) |
| `apimodel.CreateDeploymentV2Response` | [ApimodelCreateDeploymentV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateDeploymentV2Response.cs) |
| `apimodel.CreateKeyValueCredentialRequest` | [ApimodelCreateKeyValueCredentialRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateKeyValueCredentialRequest.cs) |
| `apimodel.CreateKeyValueCredentialResponse` | [ApimodelCreateKeyValueCredentialResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateKeyValueCredentialResponse.cs) |
| `apimodel.CreateNoSQLAppDatabaseRequest` | [ApimodelCreateNoSQLAppDatabaseRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateNoSQLAppDatabaseRequest.cs) |
| `apimodel.CreateNoSQLDatabaseCredentialRequest` | [ApimodelCreateNoSQLDatabaseCredentialRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateNoSQLDatabaseCredentialRequest.cs) |
| `apimodel.CreateSQLAppDatabaseRequest` | [ApimodelCreateSQLAppDatabaseRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateSQLAppDatabaseRequest.cs) |
| `apimodel.CreateSQLDatabaseCredentialRequest` | [ApimodelCreateSQLDatabaseCredentialRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateSQLDatabaseCredentialRequest.cs) |
| `apimodel.CreateSubscriptionRequest` | [ApimodelCreateSubscriptionRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateSubscriptionRequest.cs) |
| `apimodel.CreateSubscriptionResponse` | [ApimodelCreateSubscriptionResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateSubscriptionResponse.cs) |
| `apimodel.CreateTopicRequest` | [ApimodelCreateTopicRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateTopicRequest.cs) |
| `apimodel.DeleteNoSQLResourceResponse` | [ApimodelDeleteNoSQLResourceResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelDeleteNoSQLResourceResponse.cs) |
| `apimodel.DeleteSQLResourceResponse` | [ApimodelDeleteSQLResourceResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelDeleteSQLResourceResponse.cs) |
| `apimodel.GetAppImageListV2DataItem` | [ApimodelGetAppImageListV2DataItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2DataItem.cs) |
| `apimodel.GetAppImageListV2DataItemImageScanResult` | [ApimodelGetAppImageListV2DataItemImageScanResult](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2DataItemImageScanResult.cs) |
| `apimodel.GetAppImageListV2DataItemImageScanStatus` | [ApimodelGetAppImageListV2DataItemImageScanStatus](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2DataItemImageScanStatus.cs) |
| `apimodel.GetAppImageListV2Response` | [ApimodelGetAppImageListV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2Response.cs) |
| `apimodel.GetAppListV2Request` | [ApimodelGetAppListV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppListV2Request.cs) |
| `apimodel.GetAppListV2Response` | [ApimodelGetAppListV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppListV2Response.cs) |
| `apimodel.GetAppStatusProgressResponse` | [ApimodelGetAppStatusProgressResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppStatusProgressResponse.cs) |
| `apimodel.GetDeploymentListV2DataItem` | [ApimodelGetDeploymentListV2DataItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetDeploymentListV2DataItem.cs) |
| `apimodel.GetDeploymentListV2Request` | [ApimodelGetDeploymentListV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetDeploymentListV2Request.cs) |
| `apimodel.GetDeploymentListV2Response` | [ApimodelGetDeploymentListV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetDeploymentListV2Response.cs) |
| `apimodel.GetIntegrationAppKeyValueResponse` | [ApimodelGetIntegrationAppKeyValueResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetIntegrationAppKeyValueResponse.cs) |
| `apimodel.GetListOfConfigurationsV2DataItem` | [ApimodelGetListOfConfigurationsV2DataItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetListOfConfigurationsV2DataItem.cs) |
| `apimodel.GetListOfConfigurationsV2Response` | [ApimodelGetListOfConfigurationsV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetListOfConfigurationsV2Response.cs) |
| `apimodel.GetNotificationSubscriberItem` | [ApimodelGetNotificationSubscriberItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberItem.cs) |
| `apimodel.GetNotificationSubscriberItemV2` | [ApimodelGetNotificationSubscriberItemV2](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberItemV2.cs) |
| `apimodel.GetNotificationSubscriberListResponse` | [ApimodelGetNotificationSubscriberListResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberListResponse.cs) |
| `apimodel.GetNotificationSubscriberListResponseV2` | [ApimodelGetNotificationSubscriberListResponseV2](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberListResponseV2.cs) |
| `apimodel.GetNotificationSubscriberStatusResponse` | [ApimodelGetNotificationSubscriberStatusResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberStatusResponse.cs) |
| `apimodel.IncreaseLimitFormRequest` | [ApimodelIncreaseLimitFormRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelIncreaseLimitFormRequest.cs) |
| `apimodel.IntegrateAppKeyValueRequest` | [ApimodelIntegrateAppKeyValueRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelIntegrateAppKeyValueRequest.cs) |
| `apimodel.IntegrateAppKeyValueResponse` | [ApimodelIntegrateAppKeyValueResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelIntegrateAppKeyValueResponse.cs) |
| `apimodel.IntegrationCredentialInfo` | [ApimodelIntegrationCredentialInfo](../../AccelByte.Sdk/Api/Csm/Model/ApimodelIntegrationCredentialInfo.cs) |
| `apimodel.IntegrationListItem` | [ApimodelIntegrationListItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelIntegrationListItem.cs) |
| `apimodel.KeyValueCredentialAcknowledgements` | [ApimodelKeyValueCredentialAcknowledgements](../../AccelByte.Sdk/Api/Csm/Model/ApimodelKeyValueCredentialAcknowledgements.cs) |
| `apimodel.KeyValueResourceListResponse` | [ApimodelKeyValueResourceListResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelKeyValueResourceListResponse.cs) |
| `apimodel.KeyValueResourceResponse` | [ApimodelKeyValueResourceResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelKeyValueResourceResponse.cs) |
| `apimodel.ListAppUIResponse` | [ApimodelListAppUIResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelListAppUIResponse.cs) |
| `apimodel.ListIntegratedAppsKeyValueResponse` | [ApimodelListIntegratedAppsKeyValueResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelListIntegratedAppsKeyValueResponse.cs) |
| `apimodel.ListTopicsResponse` | [ApimodelListTopicsResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelListTopicsResponse.cs) |
| `apimodel.MemoryRequest` | [ApimodelMemoryRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelMemoryRequest.cs) |
| `apimodel.MemoryResponse` | [ApimodelMemoryResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelMemoryResponse.cs) |
| `apimodel.NoSQLAppListResponse` | [ApimodelNoSQLAppListResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNoSQLAppListResponse.cs) |
| `apimodel.NoSQLAppResponse` | [ApimodelNoSQLAppResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNoSQLAppResponse.cs) |
| `apimodel.NoSQLDatabaseAcknowledgements` | [ApimodelNoSQLDatabaseAcknowledgements](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNoSQLDatabaseAcknowledgements.cs) |
| `apimodel.NoSQLDatabaseCredentialResponse` | [ApimodelNoSQLDatabaseCredentialResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNoSQLDatabaseCredentialResponse.cs) |
| `apimodel.NoSQLDatabaseDeleteResponse` | [ApimodelNoSQLDatabaseDeleteResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNoSQLDatabaseDeleteResponse.cs) |
| `apimodel.NoSQLDatabaseResponse` | [ApimodelNoSQLDatabaseResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNoSQLDatabaseResponse.cs) |
| `apimodel.NoSQLResourceResponse` | [ApimodelNoSQLResourceResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNoSQLResourceResponse.cs) |
| `apimodel.NotificationType` | [ApimodelNotificationType](../../AccelByte.Sdk/Api/Csm/Model/ApimodelNotificationType.cs) |
| `apimodel.PaginationResponse` | [ApimodelPaginationResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelPaginationResponse.cs) |
| `apimodel.PublicIAMClientResponse` | [ApimodelPublicIAMClientResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelPublicIAMClientResponse.cs) |
| `apimodel.ReplicaRequest` | [ApimodelReplicaRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelReplicaRequest.cs) |
| `apimodel.ReplicaResponse` | [ApimodelReplicaResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelReplicaResponse.cs) |
| `apimodel.SQLAppListResponse` | [ApimodelSQLAppListResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSQLAppListResponse.cs) |
| `apimodel.SQLAppResponse` | [ApimodelSQLAppResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSQLAppResponse.cs) |
| `apimodel.SQLDatabaseAcknowledgements` | [ApimodelSQLDatabaseAcknowledgements](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSQLDatabaseAcknowledgements.cs) |
| `apimodel.SQLDatabaseCredentialResponse` | [ApimodelSQLDatabaseCredentialResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSQLDatabaseCredentialResponse.cs) |
| `apimodel.SQLDatabaseDeleteResponse` | [ApimodelSQLDatabaseDeleteResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSQLDatabaseDeleteResponse.cs) |
| `apimodel.SQLDatabaseResponse` | [ApimodelSQLDatabaseResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSQLDatabaseResponse.cs) |
| `apimodel.SQLResourceResponse` | [ApimodelSQLResourceResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSQLResourceResponse.cs) |
| `apimodel.SaveConfigurationV2Request` | [ApimodelSaveConfigurationV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSaveConfigurationV2Request.cs) |
| `apimodel.SaveConfigurationV2Response` | [ApimodelSaveConfigurationV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSaveConfigurationV2Response.cs) |
| `apimodel.SaveSecretConfigurationV2Request` | [ApimodelSaveSecretConfigurationV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSaveSecretConfigurationV2Request.cs) |
| `apimodel.SelfSubscribeNotificationRequest` | [ApimodelSelfSubscribeNotificationRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSelfSubscribeNotificationRequest.cs) |
| `apimodel.SubscribeNotificationRequest` | [ApimodelSubscribeNotificationRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscribeNotificationRequest.cs) |
| `apimodel.SubscribeNotificationResponse` | [ApimodelSubscribeNotificationResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscribeNotificationResponse.cs) |
| `apimodel.SubscriberItemRequest` | [ApimodelSubscriberItemRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscriberItemRequest.cs) |
| `apimodel.SubscriberItemResponse` | [ApimodelSubscriberItemResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscriberItemResponse.cs) |
| `apimodel.TopicDetailResponse` | [ApimodelTopicDetailResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelTopicDetailResponse.cs) |
| `apimodel.TopicResponse` | [ApimodelTopicResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelTopicResponse.cs) |
| `apimodel.TopicSubscription` | [ApimodelTopicSubscription](../../AccelByte.Sdk/Api/Csm/Model/ApimodelTopicSubscription.cs) |
| `apimodel.TunnelInfoResponse` | [ApimodelTunnelInfoResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelTunnelInfoResponse.cs) |
| `apimodel.UpdateAppResourceRequest` | [ApimodelUpdateAppResourceRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateAppResourceRequest.cs) |
| `apimodel.UpdateAppV2Request` | [ApimodelUpdateAppV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateAppV2Request.cs) |
| `apimodel.UpdateConfigurationV2Request` | [ApimodelUpdateConfigurationV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateConfigurationV2Request.cs) |
| `apimodel.UpdateConfigurationV2Response` | [ApimodelUpdateConfigurationV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateConfigurationV2Response.cs) |
| `apimodel.UpdateDebugModeRequest` | [ApimodelUpdateDebugModeRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateDebugModeRequest.cs) |
| `apimodel.UpdateSecretConfigurationV2Request` | [ApimodelUpdateSecretConfigurationV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateSecretConfigurationV2Request.cs) |
| `apimodel.UploadFileResponse` | [ApimodelUploadFileResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUploadFileResponse.cs) |
| `createappparams.AutoscalingRequest` | [CreateappparamsAutoscalingRequest](../../AccelByte.Sdk/Api/Csm/Model/CreateappparamsAutoscalingRequest.cs) |
| `createappparams.CPURequest` | [CreateappparamsCPURequest](../../AccelByte.Sdk/Api/Csm/Model/CreateappparamsCPURequest.cs) |
| `createappparams.MemoryRequest` | [CreateappparamsMemoryRequest](../../AccelByte.Sdk/Api/Csm/Model/CreateappparamsMemoryRequest.cs) |
| `createappparams.ReplicaRequest` | [CreateappparamsReplicaRequest](../../AccelByte.Sdk/Api/Csm/Model/CreateappparamsReplicaRequest.cs) |
| `domain.AllowedInterceptedPort` | [DomainAllowedInterceptedPort](../../AccelByte.Sdk/Api/Csm/Model/DomainAllowedInterceptedPort.cs) |
| `domain.DebugPod` | [DomainDebugPod](../../AccelByte.Sdk/Api/Csm/Model/DomainDebugPod.cs) |
| `domain.ExposedService` | [DomainExposedService](../../AccelByte.Sdk/Api/Csm/Model/DomainExposedService.cs) |
| `domain.KeyValueClusterConfig` | [DomainKeyValueClusterConfig](../../AccelByte.Sdk/Api/Csm/Model/DomainKeyValueClusterConfig.cs) |
| `domain.KeyValueResourceConfiguration` | [DomainKeyValueResourceConfiguration](../../AccelByte.Sdk/Api/Csm/Model/DomainKeyValueResourceConfiguration.cs) |
| `domain.KeyValueUpdateConfiguration` | [DomainKeyValueUpdateConfiguration](../../AccelByte.Sdk/Api/Csm/Model/DomainKeyValueUpdateConfiguration.cs) |
| `generated.CreateAppV1Request` | [GeneratedCreateAppV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedCreateAppV1Request.cs) |
| `generated.CreateAppV1Response` | [GeneratedCreateAppV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedCreateAppV1Response.cs) |
| `generated.CreateDeploymentV1Request` | [GeneratedCreateDeploymentV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedCreateDeploymentV1Request.cs) |
| `generated.CreateDeploymentV1Response` | [GeneratedCreateDeploymentV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedCreateDeploymentV1Response.cs) |
| `generated.DeleteAppImagesV1Request` | [GeneratedDeleteAppImagesV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedDeleteAppImagesV1Request.cs) |
| `generated.GetAppImageListV1DataItem` | [GeneratedGetAppImageListV1DataItem](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppImageListV1DataItem.cs) |
| `generated.GetAppImageListV1DataItemImageScanStatus` | [GeneratedGetAppImageListV1DataItemImageScanStatus](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppImageListV1DataItemImageScanStatus.cs) |
| `generated.GetAppImageListV1Response` | [GeneratedGetAppImageListV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppImageListV1Response.cs) |
| `generated.GetAppListV1DataItem` | [GeneratedGetAppListV1DataItem](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppListV1DataItem.cs) |
| `generated.GetAppListV1Request` | [GeneratedGetAppListV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppListV1Request.cs) |
| `generated.GetAppListV1Response` | [GeneratedGetAppListV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppListV1Response.cs) |
| `generated.GetAppReleaseV1Response` | [GeneratedGetAppReleaseV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppReleaseV1Response.cs) |
| `generated.GetAppV1Response` | [GeneratedGetAppV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetAppV1Response.cs) |
| `generated.GetDeploymentListV1DataItem` | [GeneratedGetDeploymentListV1DataItem](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetDeploymentListV1DataItem.cs) |
| `generated.GetDeploymentListV1Request` | [GeneratedGetDeploymentListV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetDeploymentListV1Request.cs) |
| `generated.GetDeploymentListV1Response` | [GeneratedGetDeploymentListV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetDeploymentListV1Response.cs) |
| `generated.GetDeploymentV1Response` | [GeneratedGetDeploymentV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetDeploymentV1Response.cs) |
| `generated.GetListOfConfigurationsV1DataItem` | [GeneratedGetListOfConfigurationsV1DataItem](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetListOfConfigurationsV1DataItem.cs) |
| `generated.GetListOfConfigurationsV1Response` | [GeneratedGetListOfConfigurationsV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedGetListOfConfigurationsV1Response.cs) |
| `generated.Pagination` | [GeneratedPagination](../../AccelByte.Sdk/Api/Csm/Model/GeneratedPagination.cs) |
| `generated.SaveConfigurationV1Request` | [GeneratedSaveConfigurationV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedSaveConfigurationV1Request.cs) |
| `generated.SaveConfigurationV1Response` | [GeneratedSaveConfigurationV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedSaveConfigurationV1Response.cs) |
| `generated.StartAppV1Request` | [GeneratedStartAppV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedStartAppV1Request.cs) |
| `generated.StartAppV1Response` | [GeneratedStartAppV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedStartAppV1Response.cs) |
| `generated.StopAppV1Request` | [GeneratedStopAppV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedStopAppV1Request.cs) |
| `generated.StopAppV1Response` | [GeneratedStopAppV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedStopAppV1Response.cs) |
| `generated.UpdateAppV1Request` | [GeneratedUpdateAppV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedUpdateAppV1Request.cs) |
| `generated.UpdateAppV1Response` | [GeneratedUpdateAppV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedUpdateAppV1Response.cs) |
| `generated.UpdateConfigurationV1Request` | [GeneratedUpdateConfigurationV1Request](../../AccelByte.Sdk/Api/Csm/Model/GeneratedUpdateConfigurationV1Request.cs) |
| `generated.UpdateConfigurationV1Response` | [GeneratedUpdateConfigurationV1Response](../../AccelByte.Sdk/Api/Csm/Model/GeneratedUpdateConfigurationV1Response.cs) |
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../AccelByte.Sdk/Api/Csm/Model/LogAppMessageDeclaration.cs) |
| `model.CSMAutoscalingDefaults` | [ModelCSMAutoscalingDefaults](../../AccelByte.Sdk/Api/Csm/Model/ModelCSMAutoscalingDefaults.cs) |
| `model.ImageScanFinding` | [ModelImageScanFinding](../../AccelByte.Sdk/Api/Csm/Model/ModelImageScanFinding.cs) |
| `nosqlresource.NoSQLResourceConfiguration` | [NosqlresourceNoSQLResourceConfiguration](../../AccelByte.Sdk/Api/Csm/Model/NosqlresourceNoSQLResourceConfiguration.cs) |
| `resourceaccesstunnel.TunnelInfo` | [ResourceaccesstunnelTunnelInfo](../../AccelByte.Sdk/Api/Csm/Model/ResourceaccesstunnelTunnelInfo.cs) |
| `response.ErrorResponse` | [ResponseErrorResponse](../../AccelByte.Sdk/Api/Csm/Model/ResponseErrorResponse.cs) |
| `sqlresource.SQLResourceConfiguration` | [SqlresourceSQLResourceConfiguration](../../AccelByte.Sdk/Api/Csm/Model/SqlresourceSQLResourceConfiguration.cs) |
