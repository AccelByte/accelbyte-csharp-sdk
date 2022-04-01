# Dsmc Service Index

&nbsp;  

## Operations

### Config Wrapper:  [Config](../AccelByte.Sdk/Api/Dsmc/Wrapper/Config.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/admin/configs | GET | ListConfig | [ListConfig](../AccelByte.Sdk/Api/Dsmc/Operation//ListConfig.cs) |
| /dsmcontroller/admin/configs | POST | SaveConfig | [SaveConfig](../AccelByte.Sdk/Api/Dsmc/Operation//SaveConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs | GET | GetConfig | [GetConfig](../AccelByte.Sdk/Api/Dsmc/Operation//GetConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs | POST | CreateConfig | [CreateConfig](../AccelByte.Sdk/Api/Dsmc/Operation//CreateConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs | DELETE | DeleteConfig | [DeleteConfig](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs | PATCH | UpdateConfig | [UpdateConfig](../AccelByte.Sdk/Api/Dsmc/Operation//UpdateConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/cache | DELETE | ClearCache | [ClearCache](../AccelByte.Sdk/Api/Dsmc/Operation//ClearCache.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/ports/{name} | POST | AddPort | [AddPort](../AccelByte.Sdk/Api/Dsmc/Operation//AddPort.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/ports/{name} | DELETE | DeletePort | [DeletePort](../AccelByte.Sdk/Api/Dsmc/Operation//DeletePort.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/ports/{name} | PATCH | UpdatePort | [UpdatePort](../AccelByte.Sdk/Api/Dsmc/Operation//UpdatePort.cs) |
| /dsmcontroller/admin/v1/namespaces/{namespace}/configs/export | GET | ExportConfigV1 | [ExportConfigV1](../AccelByte.Sdk/Api/Dsmc/Operation//ExportConfigV1.cs) |
| /dsmcontroller/admin/v1/namespaces/{namespace}/configs/import | POST | ImportConfigV1 | [ImportConfigV1](../AccelByte.Sdk/Api/Dsmc/Operation//ImportConfigV1.cs) |

### Image Config Wrapper:  [ImageConfig](../AccelByte.Sdk/Api/Dsmc/Wrapper/ImageConfig.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/admin/images | PUT | UpdateImage | [UpdateImage](../AccelByte.Sdk/Api/Dsmc/Operation//UpdateImage.cs) |
| /dsmcontroller/admin/images | POST | CreateImage | [CreateImage](../AccelByte.Sdk/Api/Dsmc/Operation//CreateImage.cs) |
| /dsmcontroller/admin/images/import | POST | ImportImages | [ImportImages](../AccelByte.Sdk/Api/Dsmc/Operation//ImportImages.cs) |
| /dsmcontroller/admin/images/patches | POST | CreateImagePatch | [CreateImagePatch](../AccelByte.Sdk/Api/Dsmc/Operation//CreateImagePatch.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images | GET | ListImages | [ListImages](../AccelByte.Sdk/Api/Dsmc/Operation//ListImages.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images | DELETE | DeleteImage | [DeleteImage](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteImage.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images/export | GET | ExportImages | [ExportImages](../AccelByte.Sdk/Api/Dsmc/Operation//ExportImages.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images/limit | GET | GetImageLimit | [GetImageLimit](../AccelByte.Sdk/Api/Dsmc/Operation//GetImageLimit.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images/patches | DELETE | DeleteImagePatch | [DeleteImagePatch](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteImagePatch.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images/versions/{version} | GET | GetImageDetail | [GetImageDetail](../AccelByte.Sdk/Api/Dsmc/Operation//GetImageDetail.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches | GET | GetImagePatches | [GetImagePatches](../AccelByte.Sdk/Api/Dsmc/Operation//GetImagePatches.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/images/versions/{version}/patches/{versionPatch} | GET | GetImagePatchDetail | [GetImagePatchDetail](../AccelByte.Sdk/Api/Dsmc/Operation//GetImagePatchDetail.cs) |
| /dsmcontroller/namespaces/{namespace}/images/versions/{version} | GET | ImageDetailClient | [ImageDetailClient](../AccelByte.Sdk/Api/Dsmc/Operation//ImageDetailClient.cs) |

### Deployment Config Wrapper:  [DeploymentConfig](../AccelByte.Sdk/Api/Dsmc/Wrapper/DeploymentConfig.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments | GET | GetAllDeployment | [GetAllDeployment](../AccelByte.Sdk/Api/Dsmc/Operation//GetAllDeployment.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} | GET | GetDeployment | [GetDeployment](../AccelByte.Sdk/Api/Dsmc/Operation//GetDeployment.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} | POST | CreateDeployment | [CreateDeployment](../AccelByte.Sdk/Api/Dsmc/Operation//CreateDeployment.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} | DELETE | DeleteDeployment | [DeleteDeployment](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteDeployment.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment} | PATCH | UpdateDeployment | [UpdateDeployment](../AccelByte.Sdk/Api/Dsmc/Operation//UpdateDeployment.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} | POST | CreateRootRegionOverride | [CreateRootRegionOverride](../AccelByte.Sdk/Api/Dsmc/Operation//CreateRootRegionOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} | DELETE | DeleteRootRegionOverride | [DeleteRootRegionOverride](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteRootRegionOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/regions/{region} | PATCH | UpdateRootRegionOverride | [UpdateRootRegionOverride](../AccelByte.Sdk/Api/Dsmc/Operation//UpdateRootRegionOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/version/{version} | POST | CreateDeploymentOverride | [CreateDeploymentOverride](../AccelByte.Sdk/Api/Dsmc/Operation//CreateDeploymentOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version} | DELETE | DeleteDeploymentOverride | [DeleteDeploymentOverride](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteDeploymentOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version} | PATCH | UpdateDeploymentOverride | [UpdateDeploymentOverride](../AccelByte.Sdk/Api/Dsmc/Operation//UpdateDeploymentOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} | POST | CreateOverrideRegionOverride | [CreateOverrideRegionOverride](../AccelByte.Sdk/Api/Dsmc/Operation//CreateOverrideRegionOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} | DELETE | DeleteOverrideRegionOverride | [DeleteOverrideRegionOverride](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteOverrideRegionOverride.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/deployments/{deployment}/overrides/versions/{version}/regions/{region} | PATCH | UpdateOverrideRegionOverride | [UpdateOverrideRegionOverride](../AccelByte.Sdk/Api/Dsmc/Operation//UpdateOverrideRegionOverride.cs) |

### Pod Config Wrapper:  [PodConfig](../AccelByte.Sdk/Api/Dsmc/Wrapper/PodConfig.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/admin/namespaces/{namespace}/configs/pods | GET | GetAllPodConfig | [GetAllPodConfig](../AccelByte.Sdk/Api/Dsmc/Operation//GetAllPodConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name} | GET | GetPodConfig | [GetPodConfig](../AccelByte.Sdk/Api/Dsmc/Operation//GetPodConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name} | POST | CreatePodConfig | [CreatePodConfig](../AccelByte.Sdk/Api/Dsmc/Operation//CreatePodConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name} | DELETE | DeletePodConfig | [DeletePodConfig](../AccelByte.Sdk/Api/Dsmc/Operation//DeletePodConfig.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/configs/pods/{name} | PATCH | UpdatePodConfig | [UpdatePodConfig](../AccelByte.Sdk/Api/Dsmc/Operation//UpdatePodConfig.cs) |

### Admin Wrapper:  [Admin](../AccelByte.Sdk/Api/Dsmc/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/admin/namespaces/{namespace}/servers | GET | ListServer | [ListServer](../AccelByte.Sdk/Api/Dsmc/Operation//ListServer.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/servers/count | GET | CountServer | [CountServer](../AccelByte.Sdk/Api/Dsmc/Operation//CountServer.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/servers/count/detailed | GET | CountServerDetailed | [CountServerDetailed](../AccelByte.Sdk/Api/Dsmc/Operation//CountServerDetailed.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/servers/local | GET | ListLocalServer | [ListLocalServer](../AccelByte.Sdk/Api/Dsmc/Operation//ListLocalServer.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/servers/local/{name} | DELETE | DeleteLocalServer | [DeleteLocalServer](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteLocalServer.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/servers/{podName} | GET | GetServer | [GetServer](../AccelByte.Sdk/Api/Dsmc/Operation//GetServer.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/servers/{podName} | DELETE | DeleteServer | [DeleteServer](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteServer.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/servers/{podName}/logs | GET | GetServerLogs | [GetServerLogs](../AccelByte.Sdk/Api/Dsmc/Operation//GetServerLogs.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/sessions | GET | ListSession | [ListSession](../AccelByte.Sdk/Api/Dsmc/Operation//ListSession.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/sessions/count | GET | CountSession | [CountSession](../AccelByte.Sdk/Api/Dsmc/Operation//CountSession.cs) |
| /dsmcontroller/admin/namespaces/{namespace}/sessions/{sessionID} | DELETE | DeleteSession | [DeleteSession](../AccelByte.Sdk/Api/Dsmc/Operation//DeleteSession.cs) |

### Server Wrapper:  [Server](../AccelByte.Sdk/Api/Dsmc/Wrapper/Server.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/namespaces/{namespace}/servers/local/deregister | POST | DeregisterLocalServer | [DeregisterLocalServer](../AccelByte.Sdk/Api/Dsmc/Operation//DeregisterLocalServer.cs) |
| /dsmcontroller/namespaces/{namespace}/servers/local/register | POST | RegisterLocalServer | [RegisterLocalServer](../AccelByte.Sdk/Api/Dsmc/Operation//RegisterLocalServer.cs) |
| /dsmcontroller/namespaces/{namespace}/servers/register | POST | RegisterServer | [RegisterServer](../AccelByte.Sdk/Api/Dsmc/Operation//RegisterServer.cs) |
| /dsmcontroller/namespaces/{namespace}/servers/shutdown | POST | ShutdownServer | [ShutdownServer](../AccelByte.Sdk/Api/Dsmc/Operation//ShutdownServer.cs) |
| /dsmcontroller/namespaces/{namespace}/servers/{podName}/session | GET | GetServerSession | [GetServerSession](../AccelByte.Sdk/Api/Dsmc/Operation//GetServerSession.cs) |

### Session Wrapper:  [Session](../AccelByte.Sdk/Api/Dsmc/Wrapper/Session.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/namespaces/{namespace}/sessions | POST | CreateSession | [CreateSession](../AccelByte.Sdk/Api/Dsmc/Operation//CreateSession.cs) |
| /dsmcontroller/namespaces/{namespace}/sessions/claim | POST | ClaimServer | [ClaimServer](../AccelByte.Sdk/Api/Dsmc/Operation//ClaimServer.cs) |
| /dsmcontroller/namespaces/{namespace}/sessions/{sessionID} | GET | GetSession | [GetSession](../AccelByte.Sdk/Api/Dsmc/Operation//GetSession.cs) |

### Public Wrapper:  [Public](../AccelByte.Sdk/Api/Dsmc/Wrapper/Public.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/public/provider/default | GET | GetDefaultProvider | [GetDefaultProvider](../AccelByte.Sdk/Api/Dsmc/Operation//GetDefaultProvider.cs) |
| /dsmcontroller/public/providers | GET | ListProviders | [ListProviders](../AccelByte.Sdk/Api/Dsmc/Operation//ListProviders.cs) |
| /dsmcontroller/public/providers/regions/{region} | GET | ListProvidersByRegion | [ListProvidersByRegion](../AccelByte.Sdk/Api/Dsmc/Operation//ListProvidersByRegion.cs) |

### Operations Wrapper:  [Operations](../AccelByte.Sdk/Api/Dsmc/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /dsmcontroller/v1/messages | GET | PublicGetMessages | [PublicGetMessages](../AccelByte.Sdk/Api/Dsmc/Operation//PublicGetMessages.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| log.AppMessageDeclaration | [LogAppMessageDeclaration](../AccelByte.Sdk/Api/Dsmc/Model/LogAppMessageDeclaration.cs) |
| models.ClaimSessionRequest | [ModelsClaimSessionRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsClaimSessionRequest.cs) |
| models.CountServerResponse | [ModelsCountServerResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCountServerResponse.cs) |
| models.CountSessionResponse | [ModelsCountSessionResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCountSessionResponse.cs) |
| models.CreateDSMConfigRequest | [ModelsCreateDSMConfigRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreateDSMConfigRequest.cs) |
| models.CreateDeploymentOverrideRequest | [ModelsCreateDeploymentOverrideRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreateDeploymentOverrideRequest.cs) |
| models.CreateDeploymentRequest | [ModelsCreateDeploymentRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreateDeploymentRequest.cs) |
| models.CreateImagePatchRequest | [ModelsCreateImagePatchRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreateImagePatchRequest.cs) |
| models.CreateImageRequest | [ModelsCreateImageRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreateImageRequest.cs) |
| models.CreatePodConfigRequest | [ModelsCreatePodConfigRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreatePodConfigRequest.cs) |
| models.CreatePortRequest | [ModelsCreatePortRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreatePortRequest.cs) |
| models.CreateRegionOverrideRequest | [ModelsCreateRegionOverrideRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreateRegionOverrideRequest.cs) |
| models.CreateSessionRequest | [ModelsCreateSessionRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsCreateSessionRequest.cs) |
| models.DSMConfigExport | [ModelsDSMConfigExport](../AccelByte.Sdk/Api/Dsmc/Model/ModelsDSMConfigExport.cs) |
| models.DSMConfigRecord | [ModelsDSMConfigRecord](../AccelByte.Sdk/Api/Dsmc/Model/ModelsDSMConfigRecord.cs) |
| models.DefaultProvider | [ModelsDefaultProvider](../AccelByte.Sdk/Api/Dsmc/Model/ModelsDefaultProvider.cs) |
| models.DeploymentConfigOverride | [ModelsDeploymentConfigOverride](../AccelByte.Sdk/Api/Dsmc/Model/ModelsDeploymentConfigOverride.cs) |
| models.DeploymentWithOverride | [ModelsDeploymentWithOverride](../AccelByte.Sdk/Api/Dsmc/Model/ModelsDeploymentWithOverride.cs) |
| models.DeregisterLocalServerRequest | [ModelsDeregisterLocalServerRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsDeregisterLocalServerRequest.cs) |
| models.DetailedCountServerResponse | [ModelsDetailedCountServerResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsDetailedCountServerResponse.cs) |
| models.GetImageDetailResponse | [ModelsGetImageDetailResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsGetImageDetailResponse.cs) |
| models.GetImageLimitResponse | [ModelsGetImageLimitResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsGetImageLimitResponse.cs) |
| models.GetImageLimitResponseData | [ModelsGetImageLimitResponseData](../AccelByte.Sdk/Api/Dsmc/Model/ModelsGetImageLimitResponseData.cs) |
| models.GetImagePatchDetailResponse | [ModelsGetImagePatchDetailResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsGetImagePatchDetailResponse.cs) |
| models.ImageRecord | [ModelsImageRecord](../AccelByte.Sdk/Api/Dsmc/Model/ModelsImageRecord.cs) |
| models.ImageRecordUpdate | [ModelsImageRecordUpdate](../AccelByte.Sdk/Api/Dsmc/Model/ModelsImageRecordUpdate.cs) |
| models.ImportResponse | [ModelsImportResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsImportResponse.cs) |
| models.ListConfigResponse | [ModelsListConfigResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsListConfigResponse.cs) |
| models.ListDeploymentResponse | [ModelsListDeploymentResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsListDeploymentResponse.cs) |
| models.ListImagePatchesResponse | [ModelsListImagePatchesResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsListImagePatchesResponse.cs) |
| models.ListImageResponse | [ModelsListImageResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsListImageResponse.cs) |
| models.ListPodConfigResponse | [ModelsListPodConfigResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsListPodConfigResponse.cs) |
| models.ListServerResponse | [ModelsListServerResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsListServerResponse.cs) |
| models.ListSessionResponse | [ModelsListSessionResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsListSessionResponse.cs) |
| models.MatchResult.notification_payload | [ModelsMatchResultNotificationPayload](../AccelByte.Sdk/Api/Dsmc/Model/ModelsMatchResultNotificationPayload.cs) |
| models.PagingCursor | [ModelsPagingCursor](../AccelByte.Sdk/Api/Dsmc/Model/ModelsPagingCursor.cs) |
| models.PatchImageRecord | [ModelsPatchImageRecord](../AccelByte.Sdk/Api/Dsmc/Model/ModelsPatchImageRecord.cs) |
| models.PodConfigRecord | [ModelsPodConfigRecord](../AccelByte.Sdk/Api/Dsmc/Model/ModelsPodConfigRecord.cs) |
| models.PodCountConfigOverride | [ModelsPodCountConfigOverride](../AccelByte.Sdk/Api/Dsmc/Model/ModelsPodCountConfigOverride.cs) |
| models.RegisterLocalServerRequest | [ModelsRegisterLocalServerRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsRegisterLocalServerRequest.cs) |
| models.RegisterServerRequest | [ModelsRegisterServerRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsRegisterServerRequest.cs) |
| models.RequestMatchMember | [ModelsRequestMatchMember](../AccelByte.Sdk/Api/Dsmc/Model/ModelsRequestMatchMember.cs) |
| models.RequestMatchParty | [ModelsRequestMatchParty](../AccelByte.Sdk/Api/Dsmc/Model/ModelsRequestMatchParty.cs) |
| models.RequestMatchingAlly | [ModelsRequestMatchingAlly](../AccelByte.Sdk/Api/Dsmc/Model/ModelsRequestMatchingAlly.cs) |
| models.Server | [ModelsServer](../AccelByte.Sdk/Api/Dsmc/Model/ModelsServer.cs) |
| models.ServerLogs | [ModelsServerLogs](../AccelByte.Sdk/Api/Dsmc/Model/ModelsServerLogs.cs) |
| models.ServerSessionResponse | [ModelsServerSessionResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsServerSessionResponse.cs) |
| models.Session | [ModelsSession](../AccelByte.Sdk/Api/Dsmc/Model/ModelsSession.cs) |
| models.SessionResponse | [ModelsSessionResponse](../AccelByte.Sdk/Api/Dsmc/Model/ModelsSessionResponse.cs) |
| models.ShutdownServerRequest | [ModelsShutdownServerRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsShutdownServerRequest.cs) |
| models.StatusHistory | [ModelsStatusHistory](../AccelByte.Sdk/Api/Dsmc/Model/ModelsStatusHistory.cs) |
| models.UpdateDSMConfigRequest | [ModelsUpdateDSMConfigRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsUpdateDSMConfigRequest.cs) |
| models.UpdateDeploymentOverrideRequest | [ModelsUpdateDeploymentOverrideRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsUpdateDeploymentOverrideRequest.cs) |
| models.UpdateDeploymentRequest | [ModelsUpdateDeploymentRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsUpdateDeploymentRequest.cs) |
| models.UpdatePodConfigRequest | [ModelsUpdatePodConfigRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsUpdatePodConfigRequest.cs) |
| models.UpdatePortRequest | [ModelsUpdatePortRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsUpdatePortRequest.cs) |
| models.UpdateRegionOverrideRequest | [ModelsUpdateRegionOverrideRequest](../AccelByte.Sdk/Api/Dsmc/Model/ModelsUpdateRegionOverrideRequest.cs) |
| response.Error | [ResponseError](../AccelByte.Sdk/Api/Dsmc/Model/ResponseError.cs) |
