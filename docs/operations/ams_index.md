# Ams Service Index

&nbsp;  

## Operations

### Auth Wrapper:  [Auth](../../AccelByte.Sdk/Api/Ams/Wrapper/Auth.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/auth` | GET | AuthCheck | [AuthCheck](../../AccelByte.Sdk/Api/Ams/Operation/Auth/AuthCheck.cs) | [AuthCheck](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Auth/AuthCheck.cs) |

### Fleet Commander Wrapper:  [FleetCommander](../../AccelByte.Sdk/Api/Ams/Wrapper/FleetCommander.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/healthz` | GET | PortalHealthCheck | [PortalHealthCheck](../../AccelByte.Sdk/Api/Ams/Operation/FleetCommander/PortalHealthCheck.cs) | [PortalHealthCheck](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/FleetCommander/PortalHealthCheck.cs) |
| `/ams/version` | GET | Func1 | [Func1](../../AccelByte.Sdk/Api/Ams/Operation/FleetCommander/Func1.cs) | [Func1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/FleetCommander/Func1.cs) |
| `/healthz` | GET | BasicHealthCheck | [BasicHealthCheck](../../AccelByte.Sdk/Api/Ams/Operation/FleetCommander/BasicHealthCheck.cs) | [BasicHealthCheck](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/FleetCommander/BasicHealthCheck.cs) |

### Account Wrapper:  [Account](../../AccelByte.Sdk/Api/Ams/Wrapper/Account.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/account` | GET | AdminAccountGet | [AdminAccountGet](../../AccelByte.Sdk/Api/Ams/Operation/Account/AdminAccountGet.cs) | [AdminAccountGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AdminAccountGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/account` | POST | AdminAccountCreate | [AdminAccountCreate](../../AccelByte.Sdk/Api/Ams/Operation/Account/AdminAccountCreate.cs) | [AdminAccountCreate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AdminAccountCreate.cs) |
| `/ams/v1/admin/namespaces/{namespace}/account/link` | GET | AdminAccountLinkTokenGet | [AdminAccountLinkTokenGet](../../AccelByte.Sdk/Api/Ams/Operation/Account/AdminAccountLinkTokenGet.cs) | [AdminAccountLinkTokenGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AdminAccountLinkTokenGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/account/link` | POST | AdminAccountLinkTokenPost | [AdminAccountLinkTokenPost](../../AccelByte.Sdk/Api/Ams/Operation/Account/AdminAccountLinkTokenPost.cs) | [AdminAccountLinkTokenPost](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AdminAccountLinkTokenPost.cs) |
| `/ams/v1/namespaces/{namespace}/account` | GET | AccountGet | [AccountGet](../../AccelByte.Sdk/Api/Ams/Operation/Account/AccountGet.cs) | [AccountGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Account/AccountGet.cs) |

### Artifacts Wrapper:  [Artifacts](../../AccelByte.Sdk/Api/Ams/Wrapper/Artifacts.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/artifacts` | GET | ArtifactGet | [ArtifactGet](../../AccelByte.Sdk/Api/Ams/Operation/Artifacts/ArtifactGet.cs) | [ArtifactGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Artifacts/ArtifactGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/artifacts` | DELETE | ArtifactBulkDelete | [ArtifactBulkDelete](../../AccelByte.Sdk/Api/Ams/Operation/Artifacts/ArtifactBulkDelete.cs) | [ArtifactBulkDelete](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Artifacts/ArtifactBulkDelete.cs) |
| `/ams/v1/admin/namespaces/{namespace}/artifacts/usage` | GET | ArtifactUsageGet | [ArtifactUsageGet](../../AccelByte.Sdk/Api/Ams/Operation/Artifacts/ArtifactUsageGet.cs) | [ArtifactUsageGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Artifacts/ArtifactUsageGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/artifacts/{artifactID}` | DELETE | ArtifactDelete | [ArtifactDelete](../../AccelByte.Sdk/Api/Ams/Operation/Artifacts/ArtifactDelete.cs) | [ArtifactDelete](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Artifacts/ArtifactDelete.cs) |
| `/ams/v1/admin/namespaces/{namespace}/artifacts/{artifactID}/url` | GET | ArtifactGetURL | [ArtifactGetURL](../../AccelByte.Sdk/Api/Ams/Operation/Artifacts/ArtifactGetURL.cs) | [ArtifactGetURL](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Artifacts/ArtifactGetURL.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/artifacts-sampling-rules` | GET | FleetArtifactSamplingRulesGet | [FleetArtifactSamplingRulesGet](../../AccelByte.Sdk/Api/Ams/Operation/Artifacts/FleetArtifactSamplingRulesGet.cs) | [FleetArtifactSamplingRulesGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Artifacts/FleetArtifactSamplingRulesGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/artifacts-sampling-rules` | PUT | FleetArtifactSamplingRulesSet | [FleetArtifactSamplingRulesSet](../../AccelByte.Sdk/Api/Ams/Operation/Artifacts/FleetArtifactSamplingRulesSet.cs) | [FleetArtifactSamplingRulesSet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Artifacts/FleetArtifactSamplingRulesSet.cs) |

### Development Wrapper:  [Development](../../AccelByte.Sdk/Api/Ams/Wrapper/Development.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/development/server-configurations` | GET | DevelopmentServerConfigurationList | [DevelopmentServerConfigurationList](../../AccelByte.Sdk/Api/Ams/Operation/Development/DevelopmentServerConfigurationList.cs) | [DevelopmentServerConfigurationList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Development/DevelopmentServerConfigurationList.cs) |
| `/ams/v1/admin/namespaces/{namespace}/development/server-configurations` | POST | DevelopmentServerConfigurationCreate | [DevelopmentServerConfigurationCreate](../../AccelByte.Sdk/Api/Ams/Operation/Development/DevelopmentServerConfigurationCreate.cs) | [DevelopmentServerConfigurationCreate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Development/DevelopmentServerConfigurationCreate.cs) |
| `/ams/v1/admin/namespaces/{namespace}/development/server-configurations/{developmentServerConfigID}` | GET | DevelopmentServerConfigurationGet | [DevelopmentServerConfigurationGet](../../AccelByte.Sdk/Api/Ams/Operation/Development/DevelopmentServerConfigurationGet.cs) | [DevelopmentServerConfigurationGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Development/DevelopmentServerConfigurationGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/development/server-configurations/{developmentServerConfigID}` | DELETE | DevelopmentServerConfigurationDelete | [DevelopmentServerConfigurationDelete](../../AccelByte.Sdk/Api/Ams/Operation/Development/DevelopmentServerConfigurationDelete.cs) | [DevelopmentServerConfigurationDelete](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Development/DevelopmentServerConfigurationDelete.cs) |

### Fleets Wrapper:  [Fleets](../../AccelByte.Sdk/Api/Ams/Wrapper/Fleets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/fleets` | GET | FleetList | [FleetList](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetList.cs) | [FleetList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetList.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets` | POST | FleetCreate | [FleetCreate](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetCreate.cs) | [FleetCreate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetCreate.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}` | GET | FleetGet | [FleetGet](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetGet.cs) | [FleetGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}` | PUT | FleetUpdate | [FleetUpdate](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetUpdate.cs) | [FleetUpdate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetUpdate.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}` | DELETE | FleetDelete | [FleetDelete](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetDelete.cs) | [FleetDelete](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetDelete.cs) |
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/servers` | GET | FleetServers | [FleetServers](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetServers.cs) | [FleetServers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetServers.cs) |
| `/ams/v1/namespaces/{namespace}/fleets/{fleetID}/claim` | PUT | FleetClaimByID | [FleetClaimByID](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetClaimByID.cs) | [FleetClaimByID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetClaimByID.cs) |
| `/ams/v1/namespaces/{namespace}/servers/claim` | PUT | FleetClaimByKeys | [FleetClaimByKeys](../../AccelByte.Sdk/Api/Ams/Operation/Fleets/FleetClaimByKeys.cs) | [FleetClaimByKeys](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Fleets/FleetClaimByKeys.cs) |

### Servers Wrapper:  [Servers](../../AccelByte.Sdk/Api/Ams/Wrapper/Servers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/fleets/{fleetID}/servers/history` | GET | FleetServerHistory | [FleetServerHistory](../../AccelByte.Sdk/Api/Ams/Operation/Servers/FleetServerHistory.cs) | [FleetServerHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Servers/FleetServerHistory.cs) |
| `/ams/v1/admin/namespaces/{namespace}/servers/{serverID}` | GET | FleetServerInfo | [FleetServerInfo](../../AccelByte.Sdk/Api/Ams/Operation/Servers/FleetServerInfo.cs) | [FleetServerInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Servers/FleetServerInfo.cs) |
| `/ams/v1/admin/namespaces/{namespace}/servers/{serverID}/connectioninfo` | GET | FleetServerConnectionInfo | [FleetServerConnectionInfo](../../AccelByte.Sdk/Api/Ams/Operation/Servers/FleetServerConnectionInfo.cs) | [FleetServerConnectionInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Servers/FleetServerConnectionInfo.cs) |
| `/ams/v1/admin/namespaces/{namespace}/servers/{serverID}/history` | GET | ServerHistory | [ServerHistory](../../AccelByte.Sdk/Api/Ams/Operation/Servers/ServerHistory.cs) | [ServerHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Servers/ServerHistory.cs) |

### Images Wrapper:  [Images](../../AccelByte.Sdk/Api/Ams/Wrapper/Images.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/images` | GET | ImageList | [ImageList](../../AccelByte.Sdk/Api/Ams/Operation/Images/ImageList.cs) | [ImageList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImageList.cs) |
| `/ams/v1/admin/namespaces/{namespace}/images-storage` | GET | ImagesStorage | [ImagesStorage](../../AccelByte.Sdk/Api/Ams/Operation/Images/ImagesStorage.cs) | [ImagesStorage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImagesStorage.cs) |
| `/ams/v1/admin/namespaces/{namespace}/images/{imageID}` | GET | ImageGet | [ImageGet](../../AccelByte.Sdk/Api/Ams/Operation/Images/ImageGet.cs) | [ImageGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImageGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/images/{imageID}` | DELETE | ImageMarkForDeletion | [ImageMarkForDeletion](../../AccelByte.Sdk/Api/Ams/Operation/Images/ImageMarkForDeletion.cs) | [ImageMarkForDeletion](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImageMarkForDeletion.cs) |
| `/ams/v1/admin/namespaces/{namespace}/images/{imageID}` | PATCH | ImagePatch | [ImagePatch](../../AccelByte.Sdk/Api/Ams/Operation/Images/ImagePatch.cs) | [ImagePatch](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImagePatch.cs) |
| `/ams/v1/admin/namespaces/{namespace}/images/{imageID}/restore` | POST | ImageUnmarkForDeletion | [ImageUnmarkForDeletion](../../AccelByte.Sdk/Api/Ams/Operation/Images/ImageUnmarkForDeletion.cs) | [ImageUnmarkForDeletion](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Images/ImageUnmarkForDeletion.cs) |

### AMS QoS Wrapper:  [AMSQoS](../../AccelByte.Sdk/Api/Ams/Wrapper/AMSQoS.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/qos` | GET | QoSRegionsGet | [QoSRegionsGet](../../AccelByte.Sdk/Api/Ams/Operation/AMSQoS/QoSRegionsGet.cs) | [QoSRegionsGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/AMSQoS/QoSRegionsGet.cs) |
| `/ams/v1/admin/namespaces/{namespace}/qos/{region}` | PATCH | QoSRegionsUpdate | [QoSRegionsUpdate](../../AccelByte.Sdk/Api/Ams/Operation/AMSQoS/QoSRegionsUpdate.cs) | [QoSRegionsUpdate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/AMSQoS/QoSRegionsUpdate.cs) |

### AMS Info Wrapper:  [AMSInfo](../../AccelByte.Sdk/Api/Ams/Wrapper/AMSInfo.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/admin/namespaces/{namespace}/regions` | GET | InfoRegions | [InfoRegions](../../AccelByte.Sdk/Api/Ams/Operation/AMSInfo/InfoRegions.cs) | [InfoRegions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/AMSInfo/InfoRegions.cs) |
| `/ams/v1/admin/namespaces/{namespace}/supported-instances` | GET | InfoSupportedInstances | [InfoSupportedInstances](../../AccelByte.Sdk/Api/Ams/Operation/AMSInfo/InfoSupportedInstances.cs) | [InfoSupportedInstances](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/AMSInfo/InfoSupportedInstances.cs) |
| `/ams/v1/upload-url` | GET | UploadURLGet | [UploadURLGet](../../AccelByte.Sdk/Api/Ams/Operation/AMSInfo/UploadURLGet.cs) | [UploadURLGet](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/AMSInfo/UploadURLGet.cs) |

### Watchdogs Wrapper:  [Watchdogs](../../AccelByte.Sdk/Api/Ams/Wrapper/Watchdogs.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ams/v1/namespaces/{namespace}/local/{watchdogID}/connect` | GET | LocalWatchdogConnect | [LocalWatchdogConnect](../../AccelByte.Sdk/Api/Ams/Operation/Watchdogs/LocalWatchdogConnect.cs) | [LocalWatchdogConnect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Watchdogs/LocalWatchdogConnect.cs) |
| `/ams/v1/namespaces/{namespace}/watchdogs/{watchdogID}/connect` | GET | WatchdogConnect | [WatchdogConnect](../../AccelByte.Sdk/Api/Ams/Operation/Watchdogs/WatchdogConnect.cs) | [WatchdogConnect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ams/Watchdogs/WatchdogConnect.cs) |


&nbsp;  

## Operations with Generic Response

### Auth Wrapper:  [Auth](../../AccelByte.Sdk/Api/Ams/Wrapper/Auth.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Fleet Commander Wrapper:  [FleetCommander](../../AccelByte.Sdk/Api/Ams/Wrapper/FleetCommander.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Account Wrapper:  [Account](../../AccelByte.Sdk/Api/Ams/Wrapper/Account.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Artifacts Wrapper:  [Artifacts](../../AccelByte.Sdk/Api/Ams/Wrapper/Artifacts.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Development Wrapper:  [Development](../../AccelByte.Sdk/Api/Ams/Wrapper/Development.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Fleets Wrapper:  [Fleets](../../AccelByte.Sdk/Api/Ams/Wrapper/Fleets.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Servers Wrapper:  [Servers](../../AccelByte.Sdk/Api/Ams/Wrapper/Servers.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Images Wrapper:  [Images](../../AccelByte.Sdk/Api/Ams/Wrapper/Images.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### AMS QoS Wrapper:  [AMSQoS](../../AccelByte.Sdk/Api/Ams/Wrapper/AMSQoS.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### AMS Info Wrapper:  [AMSInfo](../../AccelByte.Sdk/Api/Ams/Wrapper/AMSInfo.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Watchdogs Wrapper:  [Watchdogs](../../AccelByte.Sdk/Api/Ams/Wrapper/Watchdogs.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `api.AMSRegionsResponse` | [ApiAMSRegionsResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiAMSRegionsResponse.cs) |
| `api.AccountCreateRequest` | [ApiAccountCreateRequest](../../AccelByte.Sdk/Api/Ams/Model/ApiAccountCreateRequest.cs) |
| `api.AccountCreateResponse` | [ApiAccountCreateResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiAccountCreateResponse.cs) |
| `api.AccountLimits` | [ApiAccountLimits](../../AccelByte.Sdk/Api/Ams/Model/ApiAccountLimits.cs) |
| `api.AccountLinkRequest` | [ApiAccountLinkRequest](../../AccelByte.Sdk/Api/Ams/Model/ApiAccountLinkRequest.cs) |
| `api.AccountLinkResponse` | [ApiAccountLinkResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiAccountLinkResponse.cs) |
| `api.AccountLinkTokenResponse` | [ApiAccountLinkTokenResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiAccountLinkTokenResponse.cs) |
| `api.AccountResponse` | [ApiAccountResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiAccountResponse.cs) |
| `api.ArtifactListResponse` | [ApiArtifactListResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiArtifactListResponse.cs) |
| `api.ArtifactResponse` | [ApiArtifactResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiArtifactResponse.cs) |
| `api.ArtifactSamplingRule` | [ApiArtifactSamplingRule](../../AccelByte.Sdk/Api/Ams/Model/ApiArtifactSamplingRule.cs) |
| `api.ArtifactTypeSamplingRules` | [ApiArtifactTypeSamplingRules](../../AccelByte.Sdk/Api/Ams/Model/ApiArtifactTypeSamplingRules.cs) |
| `api.ArtifactURLResponse` | [ApiArtifactURLResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiArtifactURLResponse.cs) |
| `api.ArtifactUsageResponse` | [ApiArtifactUsageResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiArtifactUsageResponse.cs) |
| `api.AvailableInstanceTypesResponse` | [ApiAvailableInstanceTypesResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiAvailableInstanceTypesResponse.cs) |
| `api.DSHistoryEvent` | [ApiDSHistoryEvent](../../AccelByte.Sdk/Api/Ams/Model/ApiDSHistoryEvent.cs) |
| `api.DSHistoryList` | [ApiDSHistoryList](../../AccelByte.Sdk/Api/Ams/Model/ApiDSHistoryList.cs) |
| `api.DSHostConfiguration` | [ApiDSHostConfiguration](../../AccelByte.Sdk/Api/Ams/Model/ApiDSHostConfiguration.cs) |
| `api.DevelopmentServerConfigurationCreateRequest` | [ApiDevelopmentServerConfigurationCreateRequest](../../AccelByte.Sdk/Api/Ams/Model/ApiDevelopmentServerConfigurationCreateRequest.cs) |
| `api.DevelopmentServerConfigurationCreateResponse` | [ApiDevelopmentServerConfigurationCreateResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiDevelopmentServerConfigurationCreateResponse.cs) |
| `api.DevelopmentServerConfigurationGetResponse` | [ApiDevelopmentServerConfigurationGetResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiDevelopmentServerConfigurationGetResponse.cs) |
| `api.DevelopmentServerConfigurationListResponse` | [ApiDevelopmentServerConfigurationListResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiDevelopmentServerConfigurationListResponse.cs) |
| `api.FleetArtifactsSampleRules` | [ApiFleetArtifactsSampleRules](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetArtifactsSampleRules.cs) |
| `api.FleetClaimByKeysReq` | [ApiFleetClaimByKeysReq](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetClaimByKeysReq.cs) |
| `api.FleetClaimReq` | [ApiFleetClaimReq](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetClaimReq.cs) |
| `api.FleetClaimResponse` | [ApiFleetClaimResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetClaimResponse.cs) |
| `api.FleetCreateResponse` | [ApiFleetCreateResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetCreateResponse.cs) |
| `api.FleetGetResponse` | [ApiFleetGetResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetGetResponse.cs) |
| `api.FleetListItemResponse` | [ApiFleetListItemResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetListItemResponse.cs) |
| `api.FleetListResponse` | [ApiFleetListResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetListResponse.cs) |
| `api.FleetParameters` | [ApiFleetParameters](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetParameters.cs) |
| `api.FleetRegionalServerCounts` | [ApiFleetRegionalServerCounts](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetRegionalServerCounts.cs) |
| `api.FleetServerConnectionInfoResponse` | [ApiFleetServerConnectionInfoResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetServerConnectionInfoResponse.cs) |
| `api.FleetServerHistoryEventResponse` | [ApiFleetServerHistoryEventResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetServerHistoryEventResponse.cs) |
| `api.FleetServerHistoryResponse` | [ApiFleetServerHistoryResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetServerHistoryResponse.cs) |
| `api.FleetServerInfoResponse` | [ApiFleetServerInfoResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetServerInfoResponse.cs) |
| `api.FleetServersResponse` | [ApiFleetServersResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiFleetServersResponse.cs) |
| `api.ImageDeploymentProfile` | [ApiImageDeploymentProfile](../../AccelByte.Sdk/Api/Ams/Model/ApiImageDeploymentProfile.cs) |
| `api.ImageDetails` | [ApiImageDetails](../../AccelByte.Sdk/Api/Ams/Model/ApiImageDetails.cs) |
| `api.ImageList` | [ApiImageList](../../AccelByte.Sdk/Api/Ams/Model/ApiImageList.cs) |
| `api.ImageListItem` | [ApiImageListItem](../../AccelByte.Sdk/Api/Ams/Model/ApiImageListItem.cs) |
| `api.ImageStorage` | [ApiImageStorage](../../AccelByte.Sdk/Api/Ams/Model/ApiImageStorage.cs) |
| `api.ImageUpdate` | [ApiImageUpdate](../../AccelByte.Sdk/Api/Ams/Model/ApiImageUpdate.cs) |
| `api.InstanceTypeDescriptionResponse` | [ApiInstanceTypeDescriptionResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiInstanceTypeDescriptionResponse.cs) |
| `api.PagingInfo` | [ApiPagingInfo](../../AccelByte.Sdk/Api/Ams/Model/ApiPagingInfo.cs) |
| `api.PortConfiguration` | [ApiPortConfiguration](../../AccelByte.Sdk/Api/Ams/Model/ApiPortConfiguration.cs) |
| `api.QoSEndpointResponse` | [ApiQoSEndpointResponse](../../AccelByte.Sdk/Api/Ams/Model/ApiQoSEndpointResponse.cs) |
| `api.QoSServer` | [ApiQoSServer](../../AccelByte.Sdk/Api/Ams/Model/ApiQoSServer.cs) |
| `api.ReferencingFleet` | [ApiReferencingFleet](../../AccelByte.Sdk/Api/Ams/Model/ApiReferencingFleet.cs) |
| `api.RegionConfig` | [ApiRegionConfig](../../AccelByte.Sdk/Api/Ams/Model/ApiRegionConfig.cs) |
| `api.Time` | [ApiTime](../../AccelByte.Sdk/Api/Ams/Model/ApiTime.cs) |
| `api.Timeout` | [ApiTimeout](../../AccelByte.Sdk/Api/Ams/Model/ApiTimeout.cs) |
| `api.UpdateServerRequest` | [ApiUpdateServerRequest](../../AccelByte.Sdk/Api/Ams/Model/ApiUpdateServerRequest.cs) |
| `response.ErrorResponse` | [ResponseErrorResponse](../../AccelByte.Sdk/Api/Ams/Model/ResponseErrorResponse.cs) |
| `time.Location` | [TimeLocation](../../AccelByte.Sdk/Api/Ams/Model/TimeLocation.cs) |
| `time.zone` | [TimeZone](../../AccelByte.Sdk/Api/Ams/Model/TimeZone.cs) |
| `time.zoneTrans` | [TimeZoneTrans](../../AccelByte.Sdk/Api/Ams/Model/TimeZoneTrans.cs) |
