# Legal Service Index

&nbsp;  

## Operations

### Agreement Wrapper:  [Agreement](../AccelByte.Sdk/Api/Legal/Wrapper/Agreement.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/agreements/localized-policy-versions/preferences/namespaces/{namespace}/userId/{userId} | PATCH | ChangePreferenceConsent | [ChangePreferenceConsent](../AccelByte.Sdk/Api/Legal/Operation//ChangePreferenceConsent.cs) |
| /agreement/admin/agreements/policies/users/{userId} | GET | RetrieveAcceptedAgreements | [RetrieveAcceptedAgreements](../AccelByte.Sdk/Api/Legal/Operation//RetrieveAcceptedAgreements.cs) |
| /agreement/admin/agreements/policy-versions/users | GET | RetrieveAllUsersByPolicyVersion | [RetrieveAllUsersByPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//RetrieveAllUsersByPolicyVersion.cs) |
| /agreement/public/agreements/localized-policy-versions/preferences | PATCH | ChangePreferenceConsent1 | [ChangePreferenceConsent1](../AccelByte.Sdk/Api/Legal/Operation//ChangePreferenceConsent1.cs) |
| /agreement/public/agreements/localized-policy-versions/{localizedPolicyVersionId} | POST | AcceptVersionedPolicy | [AcceptVersionedPolicy](../AccelByte.Sdk/Api/Legal/Operation//AcceptVersionedPolicy.cs) |
| /agreement/public/agreements/policies | GET | RetrieveAgreementsPublic | [RetrieveAgreementsPublic](../AccelByte.Sdk/Api/Legal/Operation//RetrieveAgreementsPublic.cs) |
| /agreement/public/agreements/policies | POST | BulkAcceptVersionedPolicy | [BulkAcceptVersionedPolicy](../AccelByte.Sdk/Api/Legal/Operation//BulkAcceptVersionedPolicy.cs) |
| /agreement/public/agreements/policies/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId} | POST | IndirectBulkAcceptVersionedPolicyV2 | [IndirectBulkAcceptVersionedPolicyV2](../AccelByte.Sdk/Api/Legal/Operation//IndirectBulkAcceptVersionedPolicyV2.cs) |
| /agreement/public/agreements/policies/users/{userId} | POST | IndirectBulkAcceptVersionedPolicy1 | [IndirectBulkAcceptVersionedPolicy1](../AccelByte.Sdk/Api/Legal/Operation//IndirectBulkAcceptVersionedPolicy1.cs) |

### Base Legal Policies Wrapper:  [BaseLegalPolicies](../AccelByte.Sdk/Api/Legal/Wrapper/BaseLegalPolicies.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/base-policies | GET | RetrieveAllLegalPolicies | [RetrieveAllLegalPolicies](../AccelByte.Sdk/Api/Legal/Operation//RetrieveAllLegalPolicies.cs) |
| /agreement/admin/base-policies | POST | CreatePolicy | [CreatePolicy](../AccelByte.Sdk/Api/Legal/Operation//CreatePolicy.cs) |
| /agreement/admin/base-policies/{basePolicyId} | GET | RetrieveSinglePolicy | [RetrieveSinglePolicy](../AccelByte.Sdk/Api/Legal/Operation//RetrieveSinglePolicy.cs) |
| /agreement/admin/base-policies/{basePolicyId} | PATCH | PartialUpdatePolicy | [PartialUpdatePolicy](../AccelByte.Sdk/Api/Legal/Operation//PartialUpdatePolicy.cs) |
| /agreement/admin/base-policies/{basePolicyId}/countries/{countryCode} | GET | RetrievePolicyCountry | [RetrievePolicyCountry](../AccelByte.Sdk/Api/Legal/Operation//RetrievePolicyCountry.cs) |
| /agreement/admin/policy-types | GET | RetrieveAllPolicyTypes | [RetrieveAllPolicyTypes](../AccelByte.Sdk/Api/Legal/Operation//RetrieveAllPolicyTypes.cs) |

### Localized Policy Versions Wrapper:  [LocalizedPolicyVersions](../AccelByte.Sdk/Api/Legal/Wrapper/LocalizedPolicyVersions.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/localized-policy-versions/versions/{policyVersionId} | GET | RetrieveLocalizedPolicyVersions | [RetrieveLocalizedPolicyVersions](../AccelByte.Sdk/Api/Legal/Operation//RetrieveLocalizedPolicyVersions.cs) |
| /agreement/admin/localized-policy-versions/versions/{policyVersionId} | POST | CreateLocalizedPolicyVersion | [CreateLocalizedPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//CreateLocalizedPolicyVersion.cs) |
| /agreement/admin/localized-policy-versions/{localizedPolicyVersionId} | GET | RetrieveSingleLocalizedPolicyVersion | [RetrieveSingleLocalizedPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//RetrieveSingleLocalizedPolicyVersion.cs) |
| /agreement/admin/localized-policy-versions/{localizedPolicyVersionId} | PUT | UpdateLocalizedPolicyVersion | [UpdateLocalizedPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//UpdateLocalizedPolicyVersion.cs) |
| /agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/attachments | POST | RequestPresignedURL | [RequestPresignedURL](../AccelByte.Sdk/Api/Legal/Operation//RequestPresignedURL.cs) |
| /agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/default | PATCH | SetDefaultPolicy | [SetDefaultPolicy](../AccelByte.Sdk/Api/Legal/Operation//SetDefaultPolicy.cs) |
| /agreement/public/localized-policy-versions/{localizedPolicyVersionId} | GET | RetrieveSingleLocalizedPolicyVersion1 | [RetrieveSingleLocalizedPolicyVersion1](../AccelByte.Sdk/Api/Legal/Operation//RetrieveSingleLocalizedPolicyVersion1.cs) |

### Admin User Agreement Wrapper:  [AdminUserAgreement](../AccelByte.Sdk/Api/Legal/Wrapper/AdminUserAgreement.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/namespaces/{namespace}/users/{userId}/agreements/policies | POST | IndirectBulkAcceptVersionedPolicy | [IndirectBulkAcceptVersionedPolicy](../AccelByte.Sdk/Api/Legal/Operation//IndirectBulkAcceptVersionedPolicy.cs) |

### Admin User Eligibilities Wrapper:  [AdminUserEligibilities](../AccelByte.Sdk/Api/Legal/Wrapper/AdminUserEligibilities.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/namespaces/{namespace}/users/{userId}/eligibilities | GET | AdminRetrieveEligibilities | [AdminRetrieveEligibilities](../AccelByte.Sdk/Api/Legal/Operation//AdminRetrieveEligibilities.cs) |

### Policies Wrapper:  [Policies](../AccelByte.Sdk/Api/Legal/Wrapper/Policies.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/policies/countries/{countryCode} | GET | RetrievePolicies | [RetrievePolicies](../AccelByte.Sdk/Api/Legal/Operation//RetrievePolicies.cs) |
| /agreement/admin/policies/{policyId} | PATCH | UpdatePolicy | [UpdatePolicy](../AccelByte.Sdk/Api/Legal/Operation//UpdatePolicy.cs) |
| /agreement/admin/policies/{policyId}/default | PATCH | SetDefaultPolicy1 | [SetDefaultPolicy1](../AccelByte.Sdk/Api/Legal/Operation//SetDefaultPolicy1.cs) |
| /agreement/public/policies/countries/{countryCode} | GET | RetrieveLatestPolicies | [RetrieveLatestPolicies](../AccelByte.Sdk/Api/Legal/Operation//RetrieveLatestPolicies.cs) |
| /agreement/public/policies/namespaces/{namespace} | GET | RetrieveLatestPoliciesPublic | [RetrieveLatestPoliciesPublic](../AccelByte.Sdk/Api/Legal/Operation//RetrieveLatestPoliciesPublic.cs) |
| /agreement/public/policies/namespaces/{namespace}/countries/{countryCode} | GET | RetrieveLatestPoliciesByNamespaceAndCountryPublic | [RetrieveLatestPoliciesByNamespaceAndCountryPublic](../AccelByte.Sdk/Api/Legal/Operation//RetrieveLatestPoliciesByNamespaceAndCountryPublic.cs) |

### Policy Versions Wrapper:  [PolicyVersions](../AccelByte.Sdk/Api/Legal/Wrapper/PolicyVersions.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/policies/versions/{policyVersionId} | PATCH | UpdatePolicyVersion | [UpdatePolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//UpdatePolicyVersion.cs) |
| /agreement/admin/policies/versions/{policyVersionId}/latest | PATCH | PublishPolicyVersion | [PublishPolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//PublishPolicyVersion.cs) |
| /agreement/admin/policies/{policyId}/versions | GET | RetrieveSinglePolicyVersion | [RetrieveSinglePolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//RetrieveSinglePolicyVersion.cs) |
| /agreement/admin/policies/{policyId}/versions | POST | CreatePolicyVersion | [CreatePolicyVersion](../AccelByte.Sdk/Api/Legal/Operation//CreatePolicyVersion.cs) |
| /agreement/public/policies | GET | RetrievePolicyVersions | [RetrievePolicyVersions](../AccelByte.Sdk/Api/Legal/Operation//RetrievePolicyVersions.cs) |

### UserInfo Wrapper:  [UserInfo](../AccelByte.Sdk/Api/Legal/Wrapper/UserInfo.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/userInfo | GET | GetUserInfoStatus | [GetUserInfoStatus](../AccelByte.Sdk/Api/Legal/Operation//GetUserInfoStatus.cs) |
| /agreement/admin/userInfo | PUT | SyncUserInfo | [SyncUserInfo](../AccelByte.Sdk/Api/Legal/Operation//SyncUserInfo.cs) |
| /agreement/admin/userInfo | DELETE | InvalidateUserInfoCache | [InvalidateUserInfoCache](../AccelByte.Sdk/Api/Legal/Operation//InvalidateUserInfoCache.cs) |

### Anonymization Wrapper:  [Anonymization](../AccelByte.Sdk/Api/Legal/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/admin/users/{userId}/anonymization/agreements | DELETE | AnonymizeUserAgreement | [AnonymizeUserAgreement](../AccelByte.Sdk/Api/Legal/Operation//AnonymizeUserAgreement.cs) |

### Eligibilities Wrapper:  [Eligibilities](../AccelByte.Sdk/Api/Legal/Wrapper/Eligibilities.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/public/eligibilities/namespaces/{namespace} | GET | RetrieveEligibilitiesPublic | [RetrieveEligibilitiesPublic](../AccelByte.Sdk/Api/Legal/Operation//RetrieveEligibilitiesPublic.cs) |
| /agreement/public/eligibilities/namespaces/{namespace}/countries/{countryCode}/clients/{clientId}/users/{userId} | GET | RetrieveEligibilitiesPublicIndirect | [RetrieveEligibilitiesPublicIndirect](../AccelByte.Sdk/Api/Legal/Operation//RetrieveEligibilitiesPublicIndirect.cs) |

### Utility Wrapper:  [Utility](../AccelByte.Sdk/Api/Legal/Wrapper/Utility.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /agreement/public/readiness | GET | CheckReadiness | [CheckReadiness](../AccelByte.Sdk/Api/Legal/Operation//CheckReadiness.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| AcceptAgreementRequest | [AcceptAgreementRequest](../AccelByte.Sdk/Api/Legal/Model/AcceptAgreementRequest.cs) |
| AcceptAgreementResponse | [AcceptAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/AcceptAgreementResponse.cs) |
| CreateBasePolicyRequest | [CreateBasePolicyRequest](../AccelByte.Sdk/Api/Legal/Model/CreateBasePolicyRequest.cs) |
| CreateBasePolicyResponse | [CreateBasePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/CreateBasePolicyResponse.cs) |
| CreateLocalizedPolicyVersionRequest | [CreateLocalizedPolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/CreateLocalizedPolicyVersionRequest.cs) |
| CreateLocalizedPolicyVersionResponse | [CreateLocalizedPolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/CreateLocalizedPolicyVersionResponse.cs) |
| CreatePolicyVersionRequest | [CreatePolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/CreatePolicyVersionRequest.cs) |
| CreatePolicyVersionResponse | [CreatePolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/CreatePolicyVersionResponse.cs) |
| ErrorEntity | [ErrorEntity](../AccelByte.Sdk/Api/Legal/Model/ErrorEntity.cs) |
| FieldValidationError | [FieldValidationError](../AccelByte.Sdk/Api/Legal/Model/FieldValidationError.cs) |
| LegalReadinessStatusResponse | [LegalReadinessStatusResponse](../AccelByte.Sdk/Api/Legal/Model/LegalReadinessStatusResponse.cs) |
| LocalizedPolicyVersionObject | [LocalizedPolicyVersionObject](../AccelByte.Sdk/Api/Legal/Model/LocalizedPolicyVersionObject.cs) |
| PagedRetrieveUserAcceptedAgreementResponse | [PagedRetrieveUserAcceptedAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/PagedRetrieveUserAcceptedAgreementResponse.cs) |
| Paging | [Paging](../AccelByte.Sdk/Api/Legal/Model/Paging.cs) |
| PolicyObject | [PolicyObject](../AccelByte.Sdk/Api/Legal/Model/PolicyObject.cs) |
| PolicyVersionObject | [PolicyVersionObject](../AccelByte.Sdk/Api/Legal/Model/PolicyVersionObject.cs) |
| PolicyVersionWithLocalizedVersionObject | [PolicyVersionWithLocalizedVersionObject](../AccelByte.Sdk/Api/Legal/Model/PolicyVersionWithLocalizedVersionObject.cs) |
| RetrieveAcceptedAgreementResponse | [RetrieveAcceptedAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveAcceptedAgreementResponse.cs) |
| RetrieveBasePolicyResponse | [RetrieveBasePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveBasePolicyResponse.cs) |
| RetrieveLocalizedPolicyVersionPublicResponse | [RetrieveLocalizedPolicyVersionPublicResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveLocalizedPolicyVersionPublicResponse.cs) |
| RetrieveLocalizedPolicyVersionResponse | [RetrieveLocalizedPolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveLocalizedPolicyVersionResponse.cs) |
| RetrievePolicyPublicResponse | [RetrievePolicyPublicResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyPublicResponse.cs) |
| RetrievePolicyResponse | [RetrievePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyResponse.cs) |
| RetrievePolicyTypeResponse | [RetrievePolicyTypeResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyTypeResponse.cs) |
| RetrievePolicyVersionResponse | [RetrievePolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/RetrievePolicyVersionResponse.cs) |
| RetrieveUserAcceptedAgreementResponse | [RetrieveUserAcceptedAgreementResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserAcceptedAgreementResponse.cs) |
| RetrieveUserEligibilitiesIndirectResponse | [RetrieveUserEligibilitiesIndirectResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserEligibilitiesIndirectResponse.cs) |
| RetrieveUserEligibilitiesResponse | [RetrieveUserEligibilitiesResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserEligibilitiesResponse.cs) |
| RetrieveUserInfoCacheStatusResponse | [RetrieveUserInfoCacheStatusResponse](../AccelByte.Sdk/Api/Legal/Model/RetrieveUserInfoCacheStatusResponse.cs) |
| UpdateBasePolicyRequest | [UpdateBasePolicyRequest](../AccelByte.Sdk/Api/Legal/Model/UpdateBasePolicyRequest.cs) |
| UpdateBasePolicyResponse | [UpdateBasePolicyResponse](../AccelByte.Sdk/Api/Legal/Model/UpdateBasePolicyResponse.cs) |
| UpdateLocalizedPolicyVersionRequest | [UpdateLocalizedPolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/UpdateLocalizedPolicyVersionRequest.cs) |
| UpdateLocalizedPolicyVersionResponse | [UpdateLocalizedPolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/UpdateLocalizedPolicyVersionResponse.cs) |
| UpdatePolicyRequest | [UpdatePolicyRequest](../AccelByte.Sdk/Api/Legal/Model/UpdatePolicyRequest.cs) |
| UpdatePolicyVersionRequest | [UpdatePolicyVersionRequest](../AccelByte.Sdk/Api/Legal/Model/UpdatePolicyVersionRequest.cs) |
| UpdatePolicyVersionResponse | [UpdatePolicyVersionResponse](../AccelByte.Sdk/Api/Legal/Model/UpdatePolicyVersionResponse.cs) |
| UploadLocalizedPolicyVersionAttachmentResponse | [UploadLocalizedPolicyVersionAttachmentResponse](../AccelByte.Sdk/Api/Legal/Model/UploadLocalizedPolicyVersionAttachmentResponse.cs) |
| UploadPolicyVersionAttachmentRequest | [UploadPolicyVersionAttachmentRequest](../AccelByte.Sdk/Api/Legal/Model/UploadPolicyVersionAttachmentRequest.cs) |
| ValidationErrorEntity | [ValidationErrorEntity](../AccelByte.Sdk/Api/Legal/Model/ValidationErrorEntity.cs) |
