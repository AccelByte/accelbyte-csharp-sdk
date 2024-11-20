# Csm Service Index

&nbsp;  

## Operations

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

### Messages Wrapper:  [Messages](../../AccelByte.Sdk/Api/Csm/Wrapper/Messages.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../AccelByte.Sdk/Api/Csm/Operation/Messages/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/Messages/PublicGetMessages.cs) |

### App V2 Wrapper:  [AppV2](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/csm/v2/admin/namespaces/{namespace}/apps` | POST | GetAppListV2 | [GetAppListV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/GetAppListV2.cs) | [GetAppListV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/GetAppListV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | GET | GetAppV2 | [GetAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/GetAppV2.cs) | [GetAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/GetAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | POST | CreateAppV2 | [CreateAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/CreateAppV2.cs) | [CreateAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/CreateAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | DELETE | DeleteAppV2 | [DeleteAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/DeleteAppV2.cs) | [DeleteAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/DeleteAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}` | PATCH | UpdateAppV2 | [UpdateAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/UpdateAppV2.cs) | [UpdateAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/UpdateAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/resources` | PATCH | UpdateAppResourcesV2 | [UpdateAppResourcesV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/UpdateAppResourcesV2.cs) | [UpdateAppResourcesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/UpdateAppResourcesV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/resources/form` | POST | UpdateAppResourcesResourceLimitFormV2 | [UpdateAppResourcesResourceLimitFormV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/UpdateAppResourcesResourceLimitFormV2.cs) | [UpdateAppResourcesResourceLimitFormV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/UpdateAppResourcesResourceLimitFormV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/start` | PUT | StartAppV2 | [StartAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/StartAppV2.cs) | [StartAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/StartAppV2.cs) |
| `/csm/v2/admin/namespaces/{namespace}/apps/{app}/stop` | PUT | StopAppV2 | [StopAppV2](../../AccelByte.Sdk/Api/Csm/Operation/AppV2/StopAppV2.cs) | [StopAppV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Csm/AppV2/StopAppV2.cs) |

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


&nbsp;  

## Operations with Generic Response

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

### Messages Wrapper:  [Messages](../../AccelByte.Sdk/Api/Csm/Wrapper/Messages.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### App V2 Wrapper:  [AppV2](../../AccelByte.Sdk/Api/Csm/Wrapper/AppV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Deployment V2 Wrapper:  [DeploymentV2](../../AccelByte.Sdk/Api/Csm/Wrapper/DeploymentV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Image V2 Wrapper:  [ImageV2](../../AccelByte.Sdk/Api/Csm/Wrapper/ImageV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Configuration V2 Wrapper:  [ConfigurationV2](../../AccelByte.Sdk/Api/Csm/Wrapper/ConfigurationV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Notification Subscription Wrapper:  [NotificationSubscription](../../AccelByte.Sdk/Api/Csm/Wrapper/NotificationSubscription.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Resources Limits Wrapper:  [ResourcesLimits](../../AccelByte.Sdk/Api/Csm/Wrapper/ResourcesLimits.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `apimodel.AppItem` | [ApimodelAppItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAppItem.cs) |
| `apimodel.AutoscalingRequest` | [ApimodelAutoscalingRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAutoscalingRequest.cs) |
| `apimodel.AutoscalingResponse` | [ApimodelAutoscalingResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelAutoscalingResponse.cs) |
| `apimodel.BulkSubscribeItem` | [ApimodelBulkSubscribeItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelBulkSubscribeItem.cs) |
| `apimodel.BulkSubscribeRequest` | [ApimodelBulkSubscribeRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelBulkSubscribeRequest.cs) |
| `apimodel.CPURequest` | [ApimodelCPURequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCPURequest.cs) |
| `apimodel.CPUResponse` | [ApimodelCPUResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCPUResponse.cs) |
| `apimodel.CSMAppLimitsResponse` | [ApimodelCSMAppLimitsResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCSMAppLimitsResponse.cs) |
| `apimodel.CreateAppV2Request` | [ApimodelCreateAppV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateAppV2Request.cs) |
| `apimodel.CreateDeploymentV2Request` | [ApimodelCreateDeploymentV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateDeploymentV2Request.cs) |
| `apimodel.CreateDeploymentV2Response` | [ApimodelCreateDeploymentV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelCreateDeploymentV2Response.cs) |
| `apimodel.GetAppImageListV2DataItem` | [ApimodelGetAppImageListV2DataItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2DataItem.cs) |
| `apimodel.GetAppImageListV2DataItemImageScanResult` | [ApimodelGetAppImageListV2DataItemImageScanResult](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2DataItemImageScanResult.cs) |
| `apimodel.GetAppImageListV2DataItemImageScanStatus` | [ApimodelGetAppImageListV2DataItemImageScanStatus](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2DataItemImageScanStatus.cs) |
| `apimodel.GetAppImageListV2Response` | [ApimodelGetAppImageListV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppImageListV2Response.cs) |
| `apimodel.GetAppListV2Request` | [ApimodelGetAppListV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppListV2Request.cs) |
| `apimodel.GetAppListV2Response` | [ApimodelGetAppListV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetAppListV2Response.cs) |
| `apimodel.GetDeploymentListV2DataItem` | [ApimodelGetDeploymentListV2DataItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetDeploymentListV2DataItem.cs) |
| `apimodel.GetDeploymentListV2Request` | [ApimodelGetDeploymentListV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetDeploymentListV2Request.cs) |
| `apimodel.GetDeploymentListV2Response` | [ApimodelGetDeploymentListV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetDeploymentListV2Response.cs) |
| `apimodel.GetListOfConfigurationsV2DataItem` | [ApimodelGetListOfConfigurationsV2DataItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetListOfConfigurationsV2DataItem.cs) |
| `apimodel.GetListOfConfigurationsV2Response` | [ApimodelGetListOfConfigurationsV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetListOfConfigurationsV2Response.cs) |
| `apimodel.GetNotificationSubscriberItem` | [ApimodelGetNotificationSubscriberItem](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberItem.cs) |
| `apimodel.GetNotificationSubscriberListResponse` | [ApimodelGetNotificationSubscriberListResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberListResponse.cs) |
| `apimodel.GetNotificationSubscriberStatusResponse` | [ApimodelGetNotificationSubscriberStatusResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelGetNotificationSubscriberStatusResponse.cs) |
| `apimodel.IncreaseLimitFormRequest` | [ApimodelIncreaseLimitFormRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelIncreaseLimitFormRequest.cs) |
| `apimodel.MemoryRequest` | [ApimodelMemoryRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelMemoryRequest.cs) |
| `apimodel.MemoryResponse` | [ApimodelMemoryResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelMemoryResponse.cs) |
| `apimodel.ReplicaRequest` | [ApimodelReplicaRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelReplicaRequest.cs) |
| `apimodel.ReplicaResponse` | [ApimodelReplicaResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelReplicaResponse.cs) |
| `apimodel.SaveConfigurationV2Request` | [ApimodelSaveConfigurationV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSaveConfigurationV2Request.cs) |
| `apimodel.SaveConfigurationV2Response` | [ApimodelSaveConfigurationV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSaveConfigurationV2Response.cs) |
| `apimodel.SelfSubscribeNotificationRequest` | [ApimodelSelfSubscribeNotificationRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSelfSubscribeNotificationRequest.cs) |
| `apimodel.SubscribeNotificationRequest` | [ApimodelSubscribeNotificationRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscribeNotificationRequest.cs) |
| `apimodel.SubscribeNotificationResponse` | [ApimodelSubscribeNotificationResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscribeNotificationResponse.cs) |
| `apimodel.SubscriberItemRequest` | [ApimodelSubscriberItemRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscriberItemRequest.cs) |
| `apimodel.SubscriberItemResponse` | [ApimodelSubscriberItemResponse](../../AccelByte.Sdk/Api/Csm/Model/ApimodelSubscriberItemResponse.cs) |
| `apimodel.UpdateAppResourceRequest` | [ApimodelUpdateAppResourceRequest](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateAppResourceRequest.cs) |
| `apimodel.UpdateAppV2Request` | [ApimodelUpdateAppV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateAppV2Request.cs) |
| `apimodel.UpdateConfigurationV2Request` | [ApimodelUpdateConfigurationV2Request](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateConfigurationV2Request.cs) |
| `apimodel.UpdateConfigurationV2Response` | [ApimodelUpdateConfigurationV2Response](../../AccelByte.Sdk/Api/Csm/Model/ApimodelUpdateConfigurationV2Response.cs) |
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
| `response.ErrorResponse` | [ResponseErrorResponse](../../AccelByte.Sdk/Api/Csm/Model/ResponseErrorResponse.cs) |
