# Gdpr Service Index

&nbsp;  

## Operations

### Data Deletion Wrapper:  [DataDeletion](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataDeletion.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/gdpr/admin/namespaces/{namespace}/deletions` | GET | AdminGetListDeletionDataRequest | [AdminGetListDeletionDataRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminGetListDeletionDataRequest.cs) | [AdminGetListDeletionDataRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/AdminGetListDeletionDataRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions` | GET | AdminGetUserAccountDeletionRequest | [AdminGetUserAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminGetUserAccountDeletionRequest.cs) | [AdminGetUserAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/AdminGetUserAccountDeletionRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions` | POST | AdminSubmitUserAccountDeletionRequest | [AdminSubmitUserAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminSubmitUserAccountDeletionRequest.cs) | [AdminSubmitUserAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/AdminSubmitUserAccountDeletionRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions` | DELETE | AdminCancelUserAccountDeletionRequest | [AdminCancelUserAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminCancelUserAccountDeletionRequest.cs) | [AdminCancelUserAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/AdminCancelUserAccountDeletionRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/deletions` | POST | PublicSubmitUserAccountDeletionRequest | [PublicSubmitUserAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicSubmitUserAccountDeletionRequest.cs) | [PublicSubmitUserAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/PublicSubmitUserAccountDeletionRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/deletions` | DELETE | PublicCancelUserAccountDeletionRequest | [PublicCancelUserAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicCancelUserAccountDeletionRequest.cs) | [PublicCancelUserAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/PublicCancelUserAccountDeletionRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/deletions/status` | GET | PublicGetUserAccountDeletionStatus | [PublicGetUserAccountDeletionStatus](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicGetUserAccountDeletionStatus.cs) | [PublicGetUserAccountDeletionStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/PublicGetUserAccountDeletionStatus.cs) |
| `/gdpr/public/users/me/deletions` | POST | PublicSubmitMyAccountDeletionRequest | [PublicSubmitMyAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicSubmitMyAccountDeletionRequest.cs) | [PublicSubmitMyAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/PublicSubmitMyAccountDeletionRequest.cs) |
| `/gdpr/public/users/me/deletions` | DELETE | PublicCancelMyAccountDeletionRequest | [PublicCancelMyAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicCancelMyAccountDeletionRequest.cs) | [PublicCancelMyAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/PublicCancelMyAccountDeletionRequest.cs) |
| `/gdpr/public/users/me/deletions/status` | GET | PublicGetMyAccountDeletionStatus | [PublicGetMyAccountDeletionStatus](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicGetMyAccountDeletionStatus.cs) | [PublicGetMyAccountDeletionStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletion/PublicGetMyAccountDeletionStatus.cs) |

### Configuration Wrapper:  [Configuration](../../AccelByte.Sdk/Api/Gdpr/Wrapper/Configuration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | GET | GetAdminEmailConfiguration | [GetAdminEmailConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/GetAdminEmailConfiguration.cs) | [GetAdminEmailConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/GetAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | PUT | UpdateAdminEmailConfiguration | [UpdateAdminEmailConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/UpdateAdminEmailConfiguration.cs) | [UpdateAdminEmailConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/UpdateAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | POST | SaveAdminEmailConfiguration | [SaveAdminEmailConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/SaveAdminEmailConfiguration.cs) | [SaveAdminEmailConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/SaveAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | DELETE | DeleteAdminEmailConfiguration | [DeleteAdminEmailConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/DeleteAdminEmailConfiguration.cs) | [DeleteAdminEmailConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/DeleteAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/services/configurations` | GET | AdminGetServicesConfiguration | [AdminGetServicesConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/AdminGetServicesConfiguration.cs) | [AdminGetServicesConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/AdminGetServicesConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/services/configurations` | PUT | AdminUpdateServicesConfiguration | [AdminUpdateServicesConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/AdminUpdateServicesConfiguration.cs) | [AdminUpdateServicesConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/AdminUpdateServicesConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/services/configurations/reset` | DELETE | AdminResetServicesConfiguration | [AdminResetServicesConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/AdminResetServicesConfiguration.cs) | [AdminResetServicesConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/AdminResetServicesConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/services/platforms/closure/config` | GET | AdminGetPlatformAccountClosureServicesConfiguration | [AdminGetPlatformAccountClosureServicesConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/AdminGetPlatformAccountClosureServicesConfiguration.cs) | [AdminGetPlatformAccountClosureServicesConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/AdminGetPlatformAccountClosureServicesConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/services/platforms/closure/config` | PUT | AdminUpdatePlatformAccountClosureServicesConfiguration | [AdminUpdatePlatformAccountClosureServicesConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/AdminUpdatePlatformAccountClosureServicesConfiguration.cs) | [AdminUpdatePlatformAccountClosureServicesConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/AdminUpdatePlatformAccountClosureServicesConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/services/platforms/closure/config` | DELETE | AdminResetPlatformAccountClosureServicesConfiguration | [AdminResetPlatformAccountClosureServicesConfiguration](../../AccelByte.Sdk/Api/Gdpr/Operation/Configuration/AdminResetPlatformAccountClosureServicesConfiguration.cs) | [AdminResetPlatformAccountClosureServicesConfiguration](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/Configuration/AdminResetPlatformAccountClosureServicesConfiguration.cs) |

### Platform Account Closure Client Wrapper:  [PlatformAccountClosureClient](../../AccelByte.Sdk/Api/Gdpr/Wrapper/PlatformAccountClosureClient.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/gdpr/admin/namespaces/{namespace}/platforms/{platform}/closure/client` | GET | AdminGetPlatformAccountClosureClient | [AdminGetPlatformAccountClosureClient](../../AccelByte.Sdk/Api/Gdpr/Operation/PlatformAccountClosureClient/AdminGetPlatformAccountClosureClient.cs) | [AdminGetPlatformAccountClosureClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/PlatformAccountClosureClient/AdminGetPlatformAccountClosureClient.cs) |
| `/gdpr/admin/namespaces/{namespace}/platforms/{platform}/closure/client` | POST | AdminUpdatePlatformAccountClosureClient | [AdminUpdatePlatformAccountClosureClient](../../AccelByte.Sdk/Api/Gdpr/Operation/PlatformAccountClosureClient/AdminUpdatePlatformAccountClosureClient.cs) | [AdminUpdatePlatformAccountClosureClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/PlatformAccountClosureClient/AdminUpdatePlatformAccountClosureClient.cs) |
| `/gdpr/admin/namespaces/{namespace}/platforms/{platform}/closure/client` | DELETE | AdminDeletePlatformAccountClosureClient | [AdminDeletePlatformAccountClosureClient](../../AccelByte.Sdk/Api/Gdpr/Operation/PlatformAccountClosureClient/AdminDeletePlatformAccountClosureClient.cs) | [AdminDeletePlatformAccountClosureClient](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/PlatformAccountClosureClient/AdminDeletePlatformAccountClosureClient.cs) |

### Data Retrieval Wrapper:  [DataRetrieval](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataRetrieval.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/gdpr/admin/namespaces/{namespace}/requests` | GET | AdminGetListPersonalDataRequest | [AdminGetListPersonalDataRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminGetListPersonalDataRequest.cs) | [AdminGetListPersonalDataRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/AdminGetListPersonalDataRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests` | GET | AdminGetUserPersonalDataRequests | [AdminGetUserPersonalDataRequests](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminGetUserPersonalDataRequests.cs) | [AdminGetUserPersonalDataRequests](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/AdminGetUserPersonalDataRequests.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests` | POST | AdminRequestDataRetrieval | [AdminRequestDataRetrieval](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminRequestDataRetrieval.cs) | [AdminRequestDataRetrieval](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/AdminRequestDataRetrieval.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests/{requestDate}` | DELETE | AdminCancelUserPersonalDataRequest | [AdminCancelUserPersonalDataRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminCancelUserPersonalDataRequest.cs) | [AdminCancelUserPersonalDataRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/AdminCancelUserPersonalDataRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests/{requestDate}/generate` | POST | AdminGeneratePersonalDataURL | [AdminGeneratePersonalDataURL](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminGeneratePersonalDataURL.cs) | [AdminGeneratePersonalDataURL](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/AdminGeneratePersonalDataURL.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests` | GET | PublicGetUserPersonalDataRequests | [PublicGetUserPersonalDataRequests](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicGetUserPersonalDataRequests.cs) | [PublicGetUserPersonalDataRequests](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/PublicGetUserPersonalDataRequests.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests` | POST | PublicRequestDataRetrieval | [PublicRequestDataRetrieval](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicRequestDataRetrieval.cs) | [PublicRequestDataRetrieval](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/PublicRequestDataRetrieval.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests/{requestDate}` | DELETE | PublicCancelUserPersonalDataRequest | [PublicCancelUserPersonalDataRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicCancelUserPersonalDataRequest.cs) | [PublicCancelUserPersonalDataRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/PublicCancelUserPersonalDataRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests/{requestDate}/generate` | POST | PublicGeneratePersonalDataURL | [PublicGeneratePersonalDataURL](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicGeneratePersonalDataURL.cs) | [PublicGeneratePersonalDataURL](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrieval/PublicGeneratePersonalDataURL.cs) |

### Platform Account Closure History Wrapper:  [PlatformAccountClosureHistory](../../AccelByte.Sdk/Api/Gdpr/Wrapper/PlatformAccountClosureHistory.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/gdpr/admin/namespaces/{namespace}/users/platforms/closure/histories` | GET | AdminGetUserPlatformAccountClosureHistories | [AdminGetUserPlatformAccountClosureHistories](../../AccelByte.Sdk/Api/Gdpr/Operation/PlatformAccountClosureHistory/AdminGetUserPlatformAccountClosureHistories.cs) | [AdminGetUserPlatformAccountClosureHistories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/PlatformAccountClosureHistory/AdminGetUserPlatformAccountClosureHistories.cs) |

### Data Deletion (S2S) Wrapper:  [DataDeletionS2S](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataDeletionS2S.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/gdpr/s2s/namespaces/{namespace}/deletions/finished` | GET | S2SGetListFinishedAccountDeletionRequest | [S2SGetListFinishedAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletionS2S/S2SGetListFinishedAccountDeletionRequest.cs) | [S2SGetListFinishedAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletionS2S/S2SGetListFinishedAccountDeletionRequest.cs) |
| `/gdpr/s2s/namespaces/{namespace}/users/{userId}/deletions` | POST | S2SSubmitUserAccountDeletionRequest | [S2SSubmitUserAccountDeletionRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletionS2S/S2SSubmitUserAccountDeletionRequest.cs) | [S2SSubmitUserAccountDeletionRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataDeletionS2S/S2SSubmitUserAccountDeletionRequest.cs) |

### Data Retrieval (S2S) Wrapper:  [DataRetrievalS2S](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataRetrievalS2S.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/gdpr/s2s/namespaces/{namespace}/requests/finished` | GET | S2SGetListFinishedPersonalDataRequest | [S2SGetListFinishedPersonalDataRequest](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrievalS2S/S2SGetListFinishedPersonalDataRequest.cs) | [S2SGetListFinishedPersonalDataRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrievalS2S/S2SGetListFinishedPersonalDataRequest.cs) |
| `/gdpr/s2s/namespaces/{namespace}/users/{userId}/requests` | POST | S2SRequestDataRetrieval | [S2SRequestDataRetrieval](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrievalS2S/S2SRequestDataRetrieval.cs) | [S2SRequestDataRetrieval](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrievalS2S/S2SRequestDataRetrieval.cs) |
| `/gdpr/s2s/namespaces/{namespace}/users/{userId}/requests/{requestDate}/generate` | POST | S2SGeneratePersonalDataURL | [S2SGeneratePersonalDataURL](../../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrievalS2S/S2SGeneratePersonalDataURL.cs) | [S2SGeneratePersonalDataURL](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Gdpr/DataRetrievalS2S/S2SGeneratePersonalDataURL.cs) |


&nbsp;  

## Operations with Generic Response

### Data Deletion Wrapper:  [DataDeletion](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataDeletion.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Configuration Wrapper:  [Configuration](../../AccelByte.Sdk/Api/Gdpr/Wrapper/Configuration.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Platform Account Closure Client Wrapper:  [PlatformAccountClosureClient](../../AccelByte.Sdk/Api/Gdpr/Wrapper/PlatformAccountClosureClient.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Data Retrieval Wrapper:  [DataRetrieval](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataRetrieval.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Platform Account Closure History Wrapper:  [PlatformAccountClosureHistory](../../AccelByte.Sdk/Api/Gdpr/Wrapper/PlatformAccountClosureHistory.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Data Deletion (S2S) Wrapper:  [DataDeletionS2S](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataDeletionS2S.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Data Retrieval (S2S) Wrapper:  [DataRetrievalS2S](../../AccelByte.Sdk/Api/Gdpr/Wrapper/DataRetrievalS2S.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `dto.ExtendConfigDTO` | [DtoExtendConfigDTO](../../AccelByte.Sdk/Api/Gdpr/Model/DtoExtendConfigDTO.cs) |
| `dto.FinishedDataDeletion` | [DtoFinishedDataDeletion](../../AccelByte.Sdk/Api/Gdpr/Model/DtoFinishedDataDeletion.cs) |
| `dto.FinishedDataRequest` | [DtoFinishedDataRequest](../../AccelByte.Sdk/Api/Gdpr/Model/DtoFinishedDataRequest.cs) |
| `dto.ListFinishedDataDeletion` | [DtoListFinishedDataDeletion](../../AccelByte.Sdk/Api/Gdpr/Model/DtoListFinishedDataDeletion.cs) |
| `dto.ListFinishedDataRequests` | [DtoListFinishedDataRequests](../../AccelByte.Sdk/Api/Gdpr/Model/DtoListFinishedDataRequests.cs) |
| `dto.PlatformAccountClosureClientRequest` | [DtoPlatformAccountClosureClientRequest](../../AccelByte.Sdk/Api/Gdpr/Model/DtoPlatformAccountClosureClientRequest.cs) |
| `dto.PlatformAccountClosureClientResponse` | [DtoPlatformAccountClosureClientResponse](../../AccelByte.Sdk/Api/Gdpr/Model/DtoPlatformAccountClosureClientResponse.cs) |
| `dto.ServiceConfigDTO` | [DtoServiceConfigDTO](../../AccelByte.Sdk/Api/Gdpr/Model/DtoServiceConfigDTO.cs) |
| `dto.ServiceConfigurationDTO` | [DtoServiceConfigurationDTO](../../AccelByte.Sdk/Api/Gdpr/Model/DtoServiceConfigurationDTO.cs) |
| `dto.ServiceConfigurationUpdateRequest` | [DtoServiceConfigurationUpdateRequest](../../AccelByte.Sdk/Api/Gdpr/Model/DtoServiceConfigurationUpdateRequest.cs) |
| `dto.ServicesConfigurationResponse` | [DtoServicesConfigurationResponse](../../AccelByte.Sdk/Api/Gdpr/Model/DtoServicesConfigurationResponse.cs) |
| `dto.UserPlatformAccountClosureHistoriesResponse` | [DtoUserPlatformAccountClosureHistoriesResponse](../../AccelByte.Sdk/Api/Gdpr/Model/DtoUserPlatformAccountClosureHistoriesResponse.cs) |
| `dto.UserPlatformAccountClosureHistory` | [DtoUserPlatformAccountClosureHistory](../../AccelByte.Sdk/Api/Gdpr/Model/DtoUserPlatformAccountClosureHistory.cs) |
| `models.DataRetrievalResponse` | [ModelsDataRetrievalResponse](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsDataRetrievalResponse.cs) |
| `models.DeletionData` | [ModelsDeletionData](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsDeletionData.cs) |
| `models.DeletionStatus` | [ModelsDeletionStatus](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsDeletionStatus.cs) |
| `models.ListDeletionDataResponse` | [ModelsListDeletionDataResponse](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsListDeletionDataResponse.cs) |
| `models.ListPersonalDataResponse` | [ModelsListPersonalDataResponse](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsListPersonalDataResponse.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsPagination.cs) |
| `models.PersonalData` | [ModelsPersonalData](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsPersonalData.cs) |
| `models.RequestDeleteResponse` | [ModelsRequestDeleteResponse](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsRequestDeleteResponse.cs) |
| `models.S2SDataRetrievalResponse` | [ModelsS2SDataRetrievalResponse](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsS2SDataRetrievalResponse.cs) |
| `models.S2SRequestDeleteResponse` | [ModelsS2SRequestDeleteResponse](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsS2SRequestDeleteResponse.cs) |
| `models.S2SUserDataURL` | [ModelsS2SUserDataURL](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsS2SUserDataURL.cs) |
| `models.UserDataURL` | [ModelsUserDataURL](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsUserDataURL.cs) |
| `models.UserPersonalData` | [ModelsUserPersonalData](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsUserPersonalData.cs) |
| `models.UserPersonalDataResponse` | [ModelsUserPersonalDataResponse](../../AccelByte.Sdk/Api/Gdpr/Model/ModelsUserPersonalDataResponse.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Gdpr/Model/ResponseError.cs) |
