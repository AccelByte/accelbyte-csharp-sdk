# Legal Service Index

&nbsp;  

## Operations

### Agreement Wrapper:  [Agreement](../AccelByte.Sdk/Api/Legal/Wrapper/Agreement.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/agreements/localized-policy-versions/preferences/namespaces/{namespace}/userId/{userId}` | PATCH | ChangePreferenceConsent | [ChangePreferenceConsent](../AccelByte.Sdk/Api/Legal/Operation/Agreement/ChangePreferenceConsent.cs) | [ChangePreferenceConsent](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/ChangePreferenceConsent.cs) |
| `/agreement/admin/agreements/policies/users/{userId}` | GET | RetrieveAcceptedAgreements | [RetrieveAcceptedAgreements](../AccelByte.Sdk/Api/Legal/Operation/Agreement/RetrieveAcceptedAgreements.cs) | [RetrieveAcceptedAgreements](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/RetrieveAcceptedAgreements.cs) |
| `/agreement/admin/agreements/policy-versions/users` | GET | RetrieveAllUsersByPolicyVersion | [RetrieveAllUsersByPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/Agreement/RetrieveAllUsersByPolicyVersion.cs) | [RetrieveAllUsersByPolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/RetrieveAllUsersByPolicyVersion.cs) |
| `/agreement/public/agreements/localized-policy-versions/preferences` | PATCH | ChangePreferenceConsent1 | [ChangePreferenceConsent1](../AccelByte.Sdk/Api/Legal/Operation/Agreement/ChangePreferenceConsent1.cs) | [ChangePreferenceConsent1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/ChangePreferenceConsent1.cs) |
| `/agreement/public/agreements/localized-policy-versions/{localizedPolicyVersionId}` | POST | AcceptVersionedPolicy | [AcceptVersionedPolicy](../AccelByte.Sdk/Api/Legal/Operation/Agreement/AcceptVersionedPolicy.cs) | [AcceptVersionedPolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/AcceptVersionedPolicy.cs) |
| `/agreement/public/agreements/policies` | GET | RetrieveAgreementsPublic | [RetrieveAgreementsPublic](../AccelByte.Sdk/Api/Legal/Operation/Agreement/RetrieveAgreementsPublic.cs) | [RetrieveAgreementsPublic](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/RetrieveAgreementsPublic.cs) |
| `/agreement/public/agreements/policies` | POST | BulkAcceptVersionedPolicy | [BulkAcceptVersionedPolicy](../AccelByte.Sdk/Api/Legal/Operation/Agreement/BulkAcceptVersionedPolicy.cs) | [BulkAcceptVersionedPolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/BulkAcceptVersionedPolicy.cs) |
| `/agreement/public/agreements/policies/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId}` | POST | IndirectBulkAcceptVersionedPolicyV2 | [IndirectBulkAcceptVersionedPolicyV2](../AccelByte.Sdk/Api/Legal/Operation/Agreement/IndirectBulkAcceptVersionedPolicyV2.cs) | [IndirectBulkAcceptVersionedPolicyV2](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/IndirectBulkAcceptVersionedPolicyV2.cs) |
| `/agreement/public/agreements/policies/users/{userId}` | POST | IndirectBulkAcceptVersionedPolicy1 | [IndirectBulkAcceptVersionedPolicy1](../AccelByte.Sdk/Api/Legal/Operation/Agreement/IndirectBulkAcceptVersionedPolicy1.cs) | [IndirectBulkAcceptVersionedPolicy1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Agreement/IndirectBulkAcceptVersionedPolicy1.cs) |

### Base Legal Policies Wrapper:  [BaseLegalPolicies](../AccelByte.Sdk/Api/Legal/Wrapper/BaseLegalPolicies.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/base-policies` | GET | RetrieveAllLegalPolicies | [RetrieveAllLegalPolicies](../AccelByte.Sdk/Api/Legal/Operation/BaseLegalPolicies/RetrieveAllLegalPolicies.cs) | [RetrieveAllLegalPolicies](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/BaseLegalPolicies/RetrieveAllLegalPolicies.cs) |
| `/agreement/admin/base-policies` | POST | CreatePolicy | [CreatePolicy](../AccelByte.Sdk/Api/Legal/Operation/BaseLegalPolicies/CreatePolicy.cs) | [CreatePolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/BaseLegalPolicies/CreatePolicy.cs) |
| `/agreement/admin/base-policies/{basePolicyId}` | GET | RetrieveSinglePolicy | [RetrieveSinglePolicy](../AccelByte.Sdk/Api/Legal/Operation/BaseLegalPolicies/RetrieveSinglePolicy.cs) | [RetrieveSinglePolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/BaseLegalPolicies/RetrieveSinglePolicy.cs) |
| `/agreement/admin/base-policies/{basePolicyId}` | PATCH | PartialUpdatePolicy | [PartialUpdatePolicy](../AccelByte.Sdk/Api/Legal/Operation/BaseLegalPolicies/PartialUpdatePolicy.cs) | [PartialUpdatePolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/BaseLegalPolicies/PartialUpdatePolicy.cs) |
| `/agreement/admin/base-policies/{basePolicyId}/countries/{countryCode}` | GET | RetrievePolicyCountry | [RetrievePolicyCountry](../AccelByte.Sdk/Api/Legal/Operation/BaseLegalPolicies/RetrievePolicyCountry.cs) | [RetrievePolicyCountry](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/BaseLegalPolicies/RetrievePolicyCountry.cs) |
| `/agreement/admin/policy-types` | GET | RetrieveAllPolicyTypes | [RetrieveAllPolicyTypes](../AccelByte.Sdk/Api/Legal/Operation/BaseLegalPolicies/RetrieveAllPolicyTypes.cs) | [RetrieveAllPolicyTypes](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/BaseLegalPolicies/RetrieveAllPolicyTypes.cs) |

### Localized Policy Versions Wrapper:  [LocalizedPolicyVersions](../AccelByte.Sdk/Api/Legal/Wrapper/LocalizedPolicyVersions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/localized-policy-versions/versions/{policyVersionId}` | GET | RetrieveLocalizedPolicyVersions | [RetrieveLocalizedPolicyVersions](../AccelByte.Sdk/Api/Legal/Operation/LocalizedPolicyVersions/RetrieveLocalizedPolicyVersions.cs) | [RetrieveLocalizedPolicyVersions](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/LocalizedPolicyVersions/RetrieveLocalizedPolicyVersions.cs) |
| `/agreement/admin/localized-policy-versions/versions/{policyVersionId}` | POST | CreateLocalizedPolicyVersion | [CreateLocalizedPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/LocalizedPolicyVersions/CreateLocalizedPolicyVersion.cs) | [CreateLocalizedPolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/LocalizedPolicyVersions/CreateLocalizedPolicyVersion.cs) |
| `/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}` | GET | RetrieveSingleLocalizedPolicyVersion | [RetrieveSingleLocalizedPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/LocalizedPolicyVersions/RetrieveSingleLocalizedPolicyVersion.cs) | [RetrieveSingleLocalizedPolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/LocalizedPolicyVersions/RetrieveSingleLocalizedPolicyVersion.cs) |
| `/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}` | PUT | UpdateLocalizedPolicyVersion | [UpdateLocalizedPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/LocalizedPolicyVersions/UpdateLocalizedPolicyVersion.cs) | [UpdateLocalizedPolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/LocalizedPolicyVersions/UpdateLocalizedPolicyVersion.cs) |
| `/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/attachments` | POST | RequestPresignedURL | [RequestPresignedURL](../AccelByte.Sdk/Api/Legal/Operation/LocalizedPolicyVersions/RequestPresignedURL.cs) | [RequestPresignedURL](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/LocalizedPolicyVersions/RequestPresignedURL.cs) |
| `/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/default` | PATCH | SetDefaultPolicy | [SetDefaultPolicy](../AccelByte.Sdk/Api/Legal/Operation/LocalizedPolicyVersions/SetDefaultPolicy.cs) | [SetDefaultPolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/LocalizedPolicyVersions/SetDefaultPolicy.cs) |
| `/agreement/public/localized-policy-versions/{localizedPolicyVersionId}` | GET | RetrieveSingleLocalizedPolicyVersion1 | [RetrieveSingleLocalizedPolicyVersion1](../AccelByte.Sdk/Api/Legal/Operation/LocalizedPolicyVersions/RetrieveSingleLocalizedPolicyVersion1.cs) | [RetrieveSingleLocalizedPolicyVersion1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/LocalizedPolicyVersions/RetrieveSingleLocalizedPolicyVersion1.cs) |

### Admin User Agreement Wrapper:  [AdminUserAgreement](../AccelByte.Sdk/Api/Legal/Wrapper/AdminUserAgreement.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/namespaces/{namespace}/users/{userId}/agreements/policies` | POST | IndirectBulkAcceptVersionedPolicy | [IndirectBulkAcceptVersionedPolicy](../AccelByte.Sdk/Api/Legal/Operation/AdminUserAgreement/IndirectBulkAcceptVersionedPolicy.cs) | [IndirectBulkAcceptVersionedPolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/AdminUserAgreement/IndirectBulkAcceptVersionedPolicy.cs) |

### Admin User Eligibilities Wrapper:  [AdminUserEligibilities](../AccelByte.Sdk/Api/Legal/Wrapper/AdminUserEligibilities.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/namespaces/{namespace}/users/{userId}/eligibilities` | GET | AdminRetrieveEligibilities | [AdminRetrieveEligibilities](../AccelByte.Sdk/Api/Legal/Operation/AdminUserEligibilities/AdminRetrieveEligibilities.cs) | [AdminRetrieveEligibilities](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/AdminUserEligibilities/AdminRetrieveEligibilities.cs) |

### Policies Wrapper:  [Policies](../AccelByte.Sdk/Api/Legal/Wrapper/Policies.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/policies/countries/{countryCode}` | GET | RetrievePolicies | [RetrievePolicies](../AccelByte.Sdk/Api/Legal/Operation/Policies/RetrievePolicies.cs) | [RetrievePolicies](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Policies/RetrievePolicies.cs) |
| `/agreement/admin/policies/{policyId}` | PATCH | UpdatePolicy | [UpdatePolicy](../AccelByte.Sdk/Api/Legal/Operation/Policies/UpdatePolicy.cs) | [UpdatePolicy](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Policies/UpdatePolicy.cs) |
| `/agreement/admin/policies/{policyId}/default` | PATCH | SetDefaultPolicy1 | [SetDefaultPolicy1](../AccelByte.Sdk/Api/Legal/Operation/Policies/SetDefaultPolicy1.cs) | [SetDefaultPolicy1](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Policies/SetDefaultPolicy1.cs) |
| `/agreement/public/policies/countries/{countryCode}` | GET | RetrieveLatestPolicies | [RetrieveLatestPolicies](../AccelByte.Sdk/Api/Legal/Operation/Policies/RetrieveLatestPolicies.cs) | [RetrieveLatestPolicies](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Policies/RetrieveLatestPolicies.cs) |
| `/agreement/public/policies/namespaces/{namespace}` | GET | RetrieveLatestPoliciesPublic | [RetrieveLatestPoliciesPublic](../AccelByte.Sdk/Api/Legal/Operation/Policies/RetrieveLatestPoliciesPublic.cs) | [RetrieveLatestPoliciesPublic](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Policies/RetrieveLatestPoliciesPublic.cs) |
| `/agreement/public/policies/namespaces/{namespace}/countries/{countryCode}` | GET | RetrieveLatestPoliciesByNamespaceAndCountryPublic | [RetrieveLatestPoliciesByNamespaceAndCountryPublic](../AccelByte.Sdk/Api/Legal/Operation/Policies/RetrieveLatestPoliciesByNamespaceAndCountryPublic.cs) | [RetrieveLatestPoliciesByNamespaceAndCountryPublic](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Policies/RetrieveLatestPoliciesByNamespaceAndCountryPublic.cs) |

### Policy Versions Wrapper:  [PolicyVersions](../AccelByte.Sdk/Api/Legal/Wrapper/PolicyVersions.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/policies/versions/{policyVersionId}` | PATCH | UpdatePolicyVersion | [UpdatePolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/PolicyVersions/UpdatePolicyVersion.cs) | [UpdatePolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/PolicyVersions/UpdatePolicyVersion.cs) |
| `/agreement/admin/policies/versions/{policyVersionId}/latest` | PATCH | PublishPolicyVersion | [PublishPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/PolicyVersions/PublishPolicyVersion.cs) | [PublishPolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/PolicyVersions/PublishPolicyVersion.cs) |
| `/agreement/admin/policies/{policyId}/versions` | GET | RetrieveSinglePolicyVersion | [RetrieveSinglePolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/PolicyVersions/RetrieveSinglePolicyVersion.cs) | [RetrieveSinglePolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/PolicyVersions/RetrieveSinglePolicyVersion.cs) |
| `/agreement/admin/policies/{policyId}/versions` | POST | CreatePolicyVersion | [CreatePolicyVersion](../AccelByte.Sdk/Api/Legal/Operation/PolicyVersions/CreatePolicyVersion.cs) | [CreatePolicyVersion](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/PolicyVersions/CreatePolicyVersion.cs) |
| `/agreement/public/policies` | GET | RetrievePolicyVersions | [RetrievePolicyVersions](../AccelByte.Sdk/Api/Legal/Operation/PolicyVersions/RetrievePolicyVersions.cs) | [RetrievePolicyVersions](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/PolicyVersions/RetrievePolicyVersions.cs) |

### UserInfo Wrapper:  [UserInfo](../AccelByte.Sdk/Api/Legal/Wrapper/UserInfo.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/userInfo` | GET | GetUserInfoStatus | [GetUserInfoStatus](../AccelByte.Sdk/Api/Legal/Operation/UserInfo/GetUserInfoStatus.cs) | [GetUserInfoStatus](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/UserInfo/GetUserInfoStatus.cs) |
| `/agreement/admin/userInfo` | PUT | SyncUserInfo | [SyncUserInfo](../AccelByte.Sdk/Api/Legal/Operation/UserInfo/SyncUserInfo.cs) | [SyncUserInfo](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/UserInfo/SyncUserInfo.cs) |
| `/agreement/admin/userInfo` | DELETE | InvalidateUserInfoCache | [InvalidateUserInfoCache](../AccelByte.Sdk/Api/Legal/Operation/UserInfo/InvalidateUserInfoCache.cs) | [InvalidateUserInfoCache](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/UserInfo/InvalidateUserInfoCache.cs) |

### Anonymization Wrapper:  [Anonymization](../AccelByte.Sdk/Api/Legal/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/admin/users/{userId}/anonymization/agreements` | DELETE | AnonymizeUserAgreement | [AnonymizeUserAgreement](../AccelByte.Sdk/Api/Legal/Operation/Anonymization/AnonymizeUserAgreement.cs) | [AnonymizeUserAgreement](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Anonymization/AnonymizeUserAgreement.cs) |

### Eligibilities Wrapper:  [Eligibilities](../AccelByte.Sdk/Api/Legal/Wrapper/Eligibilities.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/public/eligibilities/namespaces/{namespace}` | GET | RetrieveEligibilitiesPublic | [RetrieveEligibilitiesPublic](../AccelByte.Sdk/Api/Legal/Operation/Eligibilities/RetrieveEligibilitiesPublic.cs) | [RetrieveEligibilitiesPublic](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Eligibilities/RetrieveEligibilitiesPublic.cs) |
| `/agreement/public/eligibilities/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId}` | GET | RetrieveEligibilitiesPublicIndirect | [RetrieveEligibilitiesPublicIndirect](../AccelByte.Sdk/Api/Legal/Operation/Eligibilities/RetrieveEligibilitiesPublicIndirect.cs) | [RetrieveEligibilitiesPublicIndirect](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Eligibilities/RetrieveEligibilitiesPublicIndirect.cs) |

### Utility Wrapper:  [Utility](../AccelByte.Sdk/Api/Legal/Wrapper/Utility.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/agreement/public/readiness` | GET | CheckReadiness | [CheckReadiness](../AccelByte.Sdk/Api/Legal/Operation/Utility/CheckReadiness.cs) | [CheckReadiness](../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Legal/Utility/CheckReadiness.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `AcceptAgreementRequest` | [AcceptAgreementRequest](../AccelByte.Sdk/Api/Legal/Model/AcceptAgreementRequest.cs) |
| `AcceptAgreementResponse` | [AcceptAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/AcceptAgreementResponse.cs) |
| `CreateBasePolicyRequest` | [CreateBasePolicyRequest](../AccelByte.Sdk/Api/Legal/Model/CreateBasePolicyRequest.cs) |
| `CreateBasePolicyResponse` | [CreateBasePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/CreateBasePolicyResponse.cs) |
| `CreateLocalizedPolicyVersionRequest` | [CreateLocalizedPolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/CreateLocalizedPolicyVersionRequest.cs) |
| `CreateLocalizedPolicyVersionResponse` | [CreateLocalizedPolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/CreateLocalizedPolicyVersionResponse.cs) |
| `CreatePolicyVersionRequest` | [CreatePolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/CreatePolicyVersionRequest.cs) |
| `CreatePolicyVersionResponse` | [CreatePolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/CreatePolicyVersionResponse.cs) |
| `ErrorEntity` | [ErrorEntity](../AccelByte.Sdk/Api/Legal/Model/ErrorEntity.cs) |
| `FieldValidationError` | [FieldValidationError](../AccelByte.Sdk/Api/Legal/Model/FieldValidationError.cs) |
| `LegalReadinessStatusResponse` | [LegalReadinessStatusResponse](../AccelByte.Sdk/Api/Legal/Model/LegalReadinessStatusResponse.cs) |
| `LocalizedPolicyVersionObject` | [LocalizedPolicyVersionObject](../AccelByte.Sdk/Api/Legal/Model/LocalizedPolicyVersionObject.cs) |
| `PagedRetrieveUserAcceptedAgreementResponse` | [PagedRetrieveUserAcceptedAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/PagedRetrieveUserAcceptedAgreementResponse.cs) |
| `Paging` | [Paging](../AccelByte.Sdk/Api/Legal/Model/Paging.cs) |
| `PolicyObject` | [PolicyObject](../AccelByte.Sdk/Api/Legal/Model/PolicyObject.cs) |
| `PolicyVersionObject` | [PolicyVersionObject](../AccelByte.Sdk/Api/Legal/Model/PolicyVersionObject.cs) |
| `PolicyVersionWithLocalizedVersionObject` | [PolicyVersionWithLocalizedVersionObject](../AccelByte.Sdk/Api/Legal/Model/PolicyVersionWithLocalizedVersionObject.cs) |
| `RetrieveAcceptedAgreementResponse` | [RetrieveAcceptedAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveAcceptedAgreementResponse.cs) |
| `RetrieveBasePolicyResponse` | [RetrieveBasePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveBasePolicyResponse.cs) |
| `RetrieveLocalizedPolicyVersionPublicResponse` | [RetrieveLocalizedPolicyVersionPublicResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveLocalizedPolicyVersionPublicResponse.cs) |
| `RetrieveLocalizedPolicyVersionResponse` | [RetrieveLocalizedPolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveLocalizedPolicyVersionResponse.cs) |
| `RetrievePolicyPublicResponse` | [RetrievePolicyPublicResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyPublicResponse.cs) |
| `RetrievePolicyResponse` | [RetrievePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyResponse.cs) |
| `RetrievePolicyTypeResponse` | [RetrievePolicyTypeResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyTypeResponse.cs) |
| `RetrievePolicyVersionResponse` | [RetrievePolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyVersionResponse.cs) |
| `RetrieveUserAcceptedAgreementResponse` | [RetrieveUserAcceptedAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserAcceptedAgreementResponse.cs) |
| `RetrieveUserEligibilitiesIndirectResponse` | [RetrieveUserEligibilitiesIndirectResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserEligibilitiesIndirectResponse.cs) |
| `RetrieveUserEligibilitiesResponse` | [RetrieveUserEligibilitiesResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserEligibilitiesResponse.cs) |
| `RetrieveUserInfoCacheStatusResponse` | [RetrieveUserInfoCacheStatusResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserInfoCacheStatusResponse.cs) |
| `UpdateBasePolicyRequest` | [UpdateBasePolicyRequest](../AccelByte.Sdk/Api/Legal/Model/UpdateBasePolicyRequest.cs) |
| `UpdateBasePolicyResponse` | [UpdateBasePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/UpdateBasePolicyResponse.cs) |
| `UpdateLocalizedPolicyVersionRequest` | [UpdateLocalizedPolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/UpdateLocalizedPolicyVersionRequest.cs) |
| `UpdateLocalizedPolicyVersionResponse` | [UpdateLocalizedPolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/UpdateLocalizedPolicyVersionResponse.cs) |
| `UpdatePolicyRequest` | [UpdatePolicyRequest](../AccelByte.Sdk/Api/Legal/Model/UpdatePolicyRequest.cs) |
| `UpdatePolicyVersionRequest` | [UpdatePolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/UpdatePolicyVersionRequest.cs) |
| `UpdatePolicyVersionResponse` | [UpdatePolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/UpdatePolicyVersionResponse.cs) |
| `UploadLocalizedPolicyVersionAttachmentResponse` | [UploadLocalizedPolicyVersionAttachmentResponse](../AccelByte.Sdk/Api/Legal/Model/UploadLocalizedPolicyVersionAttachmentResponse.cs) |
| `UploadPolicyVersionAttachmentRequest` | [UploadPolicyVersionAttachmentRequest](../AccelByte.Sdk/Api/Legal/Model/UploadPolicyVersionAttachmentRequest.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../AccelByte.Sdk/Api/Legal/Model/ValidationErrorEntity.cs) |
