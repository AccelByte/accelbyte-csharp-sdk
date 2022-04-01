# Gdpr Service Index

&nbsp;  

## Operations

### Data Deletion Wrapper:  [DataDeletion](../AccelByte.Sdk/Api/Gdpr/Wrapper/DataDeletion.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/gdpr/admin/namespaces/{namespace}/deletions` | GET | AdminGetListDeletionDataRequest | [AdminGetListDeletionDataRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminGetListDeletionDataRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions` | GET | AdminGetUserAccountDeletionRequest | [AdminGetUserAccountDeletionRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminGetUserAccountDeletionRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions` | POST | AdminSubmitUserAccountDeletionRequest | [AdminSubmitUserAccountDeletionRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminSubmitUserAccountDeletionRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/deletions` | DELETE | AdminCancelUserAccountDeletionRequest | [AdminCancelUserAccountDeletionRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/AdminCancelUserAccountDeletionRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/deletions` | POST | PublicSubmitUserAccountDeletionRequest | [PublicSubmitUserAccountDeletionRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicSubmitUserAccountDeletionRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/deletions` | DELETE | PublicCancelUserAccountDeletionRequest | [PublicCancelUserAccountDeletionRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicCancelUserAccountDeletionRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/deletions/status` | GET | PublicGetUserAccountDeletionStatus | [PublicGetUserAccountDeletionStatus](../AccelByte.Sdk/Api/Gdpr/Operation/DataDeletion/PublicGetUserAccountDeletionStatus.cs) |

### Data Retrieval Wrapper:  [DataRetrieval](../AccelByte.Sdk/Api/Gdpr/Wrapper/DataRetrieval.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | GET | GetAdminEmailConfiguration | [GetAdminEmailConfiguration](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/GetAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | PUT | UpdateAdminEmailConfiguration | [UpdateAdminEmailConfiguration](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/UpdateAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | POST | SaveAdminEmailConfiguration | [SaveAdminEmailConfiguration](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/SaveAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/emails/configurations` | DELETE | DeleteAdminEmailConfiguration | [DeleteAdminEmailConfiguration](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/DeleteAdminEmailConfiguration.cs) |
| `/gdpr/admin/namespaces/{namespace}/requests` | GET | AdminGetListPersonalDataRequest | [AdminGetListPersonalDataRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminGetListPersonalDataRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests` | GET | AdminGetUserPersonalDataRequests | [AdminGetUserPersonalDataRequests](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminGetUserPersonalDataRequests.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests` | POST | AdminRequestDataRetrieval | [AdminRequestDataRetrieval](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminRequestDataRetrieval.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests/{requestDate}` | DELETE | AdminCancelUserPersonalDataRequest | [AdminCancelUserPersonalDataRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminCancelUserPersonalDataRequest.cs) |
| `/gdpr/admin/namespaces/{namespace}/users/{userId}/requests/{requestDate}/generate` | POST | AdminGeneratePersonalDataURL | [AdminGeneratePersonalDataURL](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/AdminGeneratePersonalDataURL.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests` | GET | PublicGetUserPersonalDataRequests | [PublicGetUserPersonalDataRequests](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicGetUserPersonalDataRequests.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests` | POST | PublicRequestDataRetrieval | [PublicRequestDataRetrieval](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicRequestDataRetrieval.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests/{requestDate}` | DELETE | PublicCancelUserPersonalDataRequest | [PublicCancelUserPersonalDataRequest](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicCancelUserPersonalDataRequest.cs) |
| `/gdpr/public/namespaces/{namespace}/users/{userId}/requests/{requestDate}/generate` | POST | PublicGeneratePersonalDataURL | [PublicGeneratePersonalDataURL](../AccelByte.Sdk/Api/Gdpr/Operation/DataRetrieval/PublicGeneratePersonalDataURL.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.DataRetrievalResponse` | [ModelsDataRetrievalResponse](../AccelByte.Sdk/Api/Gdpr/Model/ModelsDataRetrievalResponse.cs) |
| `models.DeletionData` | [ModelsDeletionData](../AccelByte.Sdk/Api/Gdpr/Model/ModelsDeletionData.cs) |
| `models.DeletionStatus` | [ModelsDeletionStatus](../AccelByte.Sdk/Api/Gdpr/Model/ModelsDeletionStatus.cs) |
| `models.ListDeletionDataResponse` | [ModelsListDeletionDataResponse](../AccelByte.Sdk/Api/Gdpr/Model/ModelsListDeletionDataResponse.cs) |
| `models.ListPersonalDataResponse` | [ModelsListPersonalDataResponse](../AccelByte.Sdk/Api/Gdpr/Model/ModelsListPersonalDataResponse.cs) |
| `models.Pagination` | [ModelsPagination](../AccelByte.Sdk/Api/Gdpr/Model/ModelsPagination.cs) |
| `models.PersonalData` | [ModelsPersonalData](../AccelByte.Sdk/Api/Gdpr/Model/ModelsPersonalData.cs) |
| `models.RequestDeleteResponse` | [ModelsRequestDeleteResponse](../AccelByte.Sdk/Api/Gdpr/Model/ModelsRequestDeleteResponse.cs) |
| `models.UserDataURL` | [ModelsUserDataURL](../AccelByte.Sdk/Api/Gdpr/Model/ModelsUserDataURL.cs) |
| `models.UserPersonalData` | [ModelsUserPersonalData](../AccelByte.Sdk/Api/Gdpr/Model/ModelsUserPersonalData.cs) |
| `models.UserPersonalDataResponse` | [ModelsUserPersonalDataResponse](../AccelByte.Sdk/Api/Gdpr/Model/ModelsUserPersonalDataResponse.cs) |
| `response.Error` | [ResponseError](../AccelByte.Sdk/Api/Gdpr/Model/ResponseError.cs) |
