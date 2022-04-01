# Basic Service Index

&nbsp;  

## Operations

### Namespace Wrapper:  [Namespace](../AccelByte.Sdk/Api/Basic/Wrapper/Namespace.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/basic/v1/admin/namespaces` | GET | GetNamespaces | [GetNamespaces](../AccelByte.Sdk/Api/Basic/Operation/Namespace/GetNamespaces.cs) |
| `/basic/v1/admin/namespaces` | POST | CreateNamespace | [CreateNamespace](../AccelByte.Sdk/Api/Basic/Operation/Namespace/CreateNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}` | GET | GetNamespace | [GetNamespace](../AccelByte.Sdk/Api/Basic/Operation/Namespace/GetNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}` | DELETE | DeleteNamespace | [DeleteNamespace](../AccelByte.Sdk/Api/Basic/Operation/Namespace/DeleteNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}/basic` | PATCH | UpdateNamespace | [UpdateNamespace](../AccelByte.Sdk/Api/Basic/Operation/Namespace/UpdateNamespace.cs) |
| `/basic/v1/admin/namespaces/{namespace}/publisher` | GET | GetNamespacePublisher | [GetNamespacePublisher](../AccelByte.Sdk/Api/Basic/Operation/Namespace/GetNamespacePublisher.cs) |
| `/basic/v1/admin/namespaces/{namespace}/status` | PATCH | ChangeNamespaceStatus | [ChangeNamespaceStatus](../AccelByte.Sdk/Api/Basic/Operation/Namespace/ChangeNamespaceStatus.cs) |
| `/basic/v1/public/namespaces` | GET | PublicGetNamespaces | [PublicGetNamespaces](../AccelByte.Sdk/Api/Basic/Operation/Namespace/PublicGetNamespaces.cs) |
| `/basic/v1/public/namespaces/{namespace}/publisher` | GET | PublicGetNamespacePublisher | [PublicGetNamespacePublisher](../AccelByte.Sdk/Api/Basic/Operation/Namespace/PublicGetNamespacePublisher.cs) |

### UserAction Wrapper:  [UserAction](../AccelByte.Sdk/Api/Basic/Wrapper/UserAction.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/actions` | GET | GetActions | [GetActions](../AccelByte.Sdk/Api/Basic/Operation/UserAction/GetActions.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/ban` | POST | BanUsers | [BanUsers](../AccelByte.Sdk/Api/Basic/Operation/UserAction/BanUsers.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/banned` | GET | GetBannedUsers | [GetBannedUsers](../AccelByte.Sdk/Api/Basic/Operation/UserAction/GetBannedUsers.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/report` | POST | ReportUser | [ReportUser](../AccelByte.Sdk/Api/Basic/Operation/UserAction/ReportUser.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/status` | GET | GetUserStatus | [GetUserStatus](../AccelByte.Sdk/Api/Basic/Operation/UserAction/GetUserStatus.cs) |
| `/basic/v1/admin/namespaces/{namespace}/actions/unban` | POST | UnBanUsers | [UnBanUsers](../AccelByte.Sdk/Api/Basic/Operation/UserAction/UnBanUsers.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/actions/report` | POST | PublicReportUser | [PublicReportUser](../AccelByte.Sdk/Api/Basic/Operation/UserAction/PublicReportUser.cs) |

### EQU8Config Wrapper:  [EQU8Config](../AccelByte.Sdk/Api/Basic/Wrapper/EQU8Config.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/equ8/config` | GET | GetConfig | [GetConfig](../AccelByte.Sdk/Api/Basic/Operation/EQU8Config/GetConfig.cs) |
| `/basic/v1/admin/namespaces/{namespace}/equ8/config` | DELETE | DeleteConfig | [DeleteConfig](../AccelByte.Sdk/Api/Basic/Operation/EQU8Config/DeleteConfig.cs) |
| `/basic/v1/admin/namespaces/{namespace}/equ8/config` | PATCH | UpdateConfig | [UpdateConfig](../AccelByte.Sdk/Api/Basic/Operation/EQU8Config/UpdateConfig.cs) |

### FileUpload Wrapper:  [FileUpload](../AccelByte.Sdk/Api/Basic/Wrapper/FileUpload.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/folders/{folder}/files` | POST | GeneratedUploadUrl | [GeneratedUploadUrl](../AccelByte.Sdk/Api/Basic/Operation/FileUpload/GeneratedUploadUrl.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/files` | POST | GeneratedUserUploadContentUrl | [GeneratedUserUploadContentUrl](../AccelByte.Sdk/Api/Basic/Operation/FileUpload/GeneratedUserUploadContentUrl.cs) |
| `/basic/v1/public/namespaces/{namespace}/folders/{folder}/files` | POST | PublicGeneratedUploadUrl | [PublicGeneratedUploadUrl](../AccelByte.Sdk/Api/Basic/Operation/FileUpload/PublicGeneratedUploadUrl.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/files` | POST | PublicGeneratedUserUploadContentUrl | [PublicGeneratedUserUploadContentUrl](../AccelByte.Sdk/Api/Basic/Operation/FileUpload/PublicGeneratedUserUploadContentUrl.cs) |

### Misc Wrapper:  [Misc](../AccelByte.Sdk/Api/Basic/Wrapper/Misc.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/misc/countries` | GET | GetCountries | [GetCountries](../AccelByte.Sdk/Api/Basic/Operation/Misc/GetCountries.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups` | GET | GetCountryGroups | [GetCountryGroups](../AccelByte.Sdk/Api/Basic/Operation/Misc/GetCountryGroups.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups` | POST | AddCountryGroup | [AddCountryGroup](../AccelByte.Sdk/Api/Basic/Operation/Misc/AddCountryGroup.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}` | PUT | UpdateCountryGroup | [UpdateCountryGroup](../AccelByte.Sdk/Api/Basic/Operation/Misc/UpdateCountryGroup.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}` | DELETE | DeleteCountryGroup | [DeleteCountryGroup](../AccelByte.Sdk/Api/Basic/Operation/Misc/DeleteCountryGroup.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/languages` | GET | GetLanguages | [GetLanguages](../AccelByte.Sdk/Api/Basic/Operation/Misc/GetLanguages.cs) |
| `/basic/v1/admin/namespaces/{namespace}/misc/timezones` | GET | GetTimeZones | [GetTimeZones](../AccelByte.Sdk/Api/Basic/Operation/Misc/GetTimeZones.cs) |
| `/basic/v1/public/misc/time` | GET | PublicGetTime | [PublicGetTime](../AccelByte.Sdk/Api/Basic/Operation/Misc/PublicGetTime.cs) |
| `/basic/v1/public/namespaces/{namespace}/misc/countries` | GET | PublicGetCountries | [PublicGetCountries](../AccelByte.Sdk/Api/Basic/Operation/Misc/PublicGetCountries.cs) |
| `/basic/v1/public/namespaces/{namespace}/misc/languages` | GET | PublicGetLanguages | [PublicGetLanguages](../AccelByte.Sdk/Api/Basic/Operation/Misc/PublicGetLanguages.cs) |
| `/basic/v1/public/namespaces/{namespace}/misc/timezones` | GET | PublicGetTimeZones | [PublicGetTimeZones](../AccelByte.Sdk/Api/Basic/Operation/Misc/PublicGetTimeZones.cs) |

### UserProfile Wrapper:  [UserProfile](../AccelByte.Sdk/Api/Basic/Wrapper/UserProfile.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/profiles/public` | POST | AdminGetUserProfilePublicInfoByIds | [AdminGetUserProfilePublicInfoByIds](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/AdminGetUserProfilePublicInfoByIds.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles` | GET | GetUserProfileInfo | [GetUserProfileInfo](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/GetUserProfileInfo.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles` | PUT | UpdateUserProfile | [UpdateUserProfile](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/UpdateUserProfile.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles` | DELETE | DeleteUserProfile | [DeleteUserProfile](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/DeleteUserProfile.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | GET | GetCustomAttributesInfo | [GetCustomAttributesInfo](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/GetCustomAttributesInfo.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | PUT | UpdateCustomAttributesPartially | [UpdateCustomAttributesPartially](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/UpdateCustomAttributesPartially.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/privateCustomAttributes` | GET | GetPrivateCustomAttributesInfo | [GetPrivateCustomAttributesInfo](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/GetPrivateCustomAttributesInfo.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/privateCustomAttributes` | PUT | UpdatePrivateCustomAttributesPartially | [UpdatePrivateCustomAttributesPartially](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/UpdatePrivateCustomAttributesPartially.cs) |
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/profiles/status` | PATCH | UpdateUserProfileStatus | [UpdateUserProfileStatus](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/UpdateUserProfileStatus.cs) |
| `/basic/v1/public/namespaces/{namespace}/profiles/public` | GET | PublicGetUserProfilePublicInfoByIds | [PublicGetUserProfilePublicInfoByIds](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicGetUserProfilePublicInfoByIds.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles` | GET | GetMyProfileInfo | [GetMyProfileInfo](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/GetMyProfileInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles` | PUT | UpdateMyProfile | [UpdateMyProfile](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/UpdateMyProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles` | POST | CreateMyProfile | [CreateMyProfile](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/CreateMyProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles/zipCode` | GET | GetMyZipCode | [GetMyZipCode](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/GetMyZipCode.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/me/profiles/zipCode` | PATCH | UpdateMyZipCode | [UpdateMyZipCode](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/UpdateMyZipCode.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles` | GET | PublicGetUserProfileInfo | [PublicGetUserProfileInfo](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicGetUserProfileInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles` | PUT | PublicUpdateUserProfile | [PublicUpdateUserProfile](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicUpdateUserProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles` | POST | PublicCreateUserProfile | [PublicCreateUserProfile](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicCreateUserProfile.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | GET | PublicGetCustomAttributesInfo | [PublicGetCustomAttributesInfo](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicGetCustomAttributesInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/customAttributes` | PUT | PublicUpdateCustomAttributesPartially | [PublicUpdateCustomAttributesPartially](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicUpdateCustomAttributesPartially.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/public` | GET | PublicGetUserProfilePublicInfo | [PublicGetUserProfilePublicInfo](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicGetUserProfilePublicInfo.cs) |
| `/basic/v1/public/namespaces/{namespace}/users/{userId}/profiles/status` | PATCH | PublicUpdateUserProfileStatus | [PublicUpdateUserProfileStatus](../AccelByte.Sdk/Api/Basic/Operation/UserProfile/PublicUpdateUserProfileStatus.cs) |

### Anonymization Wrapper:  [Anonymization](../AccelByte.Sdk/Api/Basic/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| `/basic/v1/admin/namespaces/{namespace}/users/{userId}/anonymization/profiles` | DELETE | AnonymizeUserProfile | [AnonymizeUserProfile](../AccelByte.Sdk/Api/Basic/Operation/Anonymization/AnonymizeUserProfile.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| `A DTO for unban user API call.` | [ADTOForUnbanUserAPICall](../AccelByte.Sdk/Api/Basic/Model/ADTOForUnbanUserAPICall.cs) |
| `A DTO for update equ8 config API call.` | [ADTOForUpdateEqu8ConfigAPICall](../AccelByte.Sdk/Api/Basic/Model/ADTOForUpdateEqu8ConfigAPICall.cs) |
| `A DTO object for equ8 user ban status` | [ADTOObjectForEqu8UserBanStatus](../AccelByte.Sdk/Api/Basic/Model/ADTOObjectForEqu8UserBanStatus.cs) |
| `A DTO object for equ8 user status` | [ADTOObjectForEqu8UserStatus](../AccelByte.Sdk/Api/Basic/Model/ADTOObjectForEqu8UserStatus.cs) |
| `Action` | [Action](../AccelByte.Sdk/Api/Basic/Model/Action.cs) |
| `AddCountryGroupRequest` | [AddCountryGroupRequest](../AccelByte.Sdk/Api/Basic/Model/AddCountryGroupRequest.cs) |
| `AddCountryGroupResponse` | [AddCountryGroupResponse](../AccelByte.Sdk/Api/Basic/Model/AddCountryGroupResponse.cs) |
| `CountryGroupObject` | [CountryGroupObject](../AccelByte.Sdk/Api/Basic/Model/CountryGroupObject.cs) |
| `CountryObject` | [CountryObject](../AccelByte.Sdk/Api/Basic/Model/CountryObject.cs) |
| `Equ8Config` | [Equ8Config](../AccelByte.Sdk/Api/Basic/Model/Equ8Config.cs) |
| `ErrorEntity` | [ErrorEntity](../AccelByte.Sdk/Api/Basic/Model/ErrorEntity.cs) |
| `FieldValidationError` | [FieldValidationError](../AccelByte.Sdk/Api/Basic/Model/FieldValidationError.cs) |
| `FileUploadUrlInfo` | [FileUploadUrlInfo](../AccelByte.Sdk/Api/Basic/Model/FileUploadUrlInfo.cs) |
| `NamespaceCreate` | [NamespaceCreate](../AccelByte.Sdk/Api/Basic/Model/NamespaceCreate.cs) |
| `NamespaceInfo` | [NamespaceInfo](../AccelByte.Sdk/Api/Basic/Model/NamespaceInfo.cs) |
| `NamespacePublisherInfo` | [NamespacePublisherInfo](../AccelByte.Sdk/Api/Basic/Model/NamespacePublisherInfo.cs) |
| `NamespaceStatusUpdate` | [NamespaceStatusUpdate](../AccelByte.Sdk/Api/Basic/Model/NamespaceStatusUpdate.cs) |
| `NamespaceUpdate` | [NamespaceUpdate](../AccelByte.Sdk/Api/Basic/Model/NamespaceUpdate.cs) |
| `RetrieveCountryGroupResponse` | [RetrieveCountryGroupResponse](../AccelByte.Sdk/Api/Basic/Model/RetrieveCountryGroupResponse.cs) |
| `RetrieveTimeResponse` | [RetrieveTimeResponse](../AccelByte.Sdk/Api/Basic/Model/RetrieveTimeResponse.cs) |
| `UpdateCountryGroupRequest` | [UpdateCountryGroupRequest](../AccelByte.Sdk/Api/Basic/Model/UpdateCountryGroupRequest.cs) |
| `UserBanRequest` | [UserBanRequest](../AccelByte.Sdk/Api/Basic/Model/UserBanRequest.cs) |
| `UserProfileAdmin` | [UserProfileAdmin](../AccelByte.Sdk/Api/Basic/Model/UserProfileAdmin.cs) |
| `UserProfileBulkRequest` | [UserProfileBulkRequest](../AccelByte.Sdk/Api/Basic/Model/UserProfileBulkRequest.cs) |
| `UserProfileCreate` | [UserProfileCreate](../AccelByte.Sdk/Api/Basic/Model/UserProfileCreate.cs) |
| `UserProfileInfo` | [UserProfileInfo](../AccelByte.Sdk/Api/Basic/Model/UserProfileInfo.cs) |
| `UserProfilePrivateCreate` | [UserProfilePrivateCreate](../AccelByte.Sdk/Api/Basic/Model/UserProfilePrivateCreate.cs) |
| `UserProfilePrivateInfo` | [UserProfilePrivateInfo](../AccelByte.Sdk/Api/Basic/Model/UserProfilePrivateInfo.cs) |
| `UserProfilePrivateUpdate` | [UserProfilePrivateUpdate](../AccelByte.Sdk/Api/Basic/Model/UserProfilePrivateUpdate.cs) |
| `UserProfilePublicInfo` | [UserProfilePublicInfo](../AccelByte.Sdk/Api/Basic/Model/UserProfilePublicInfo.cs) |
| `UserProfileStatusUpdate` | [UserProfileStatusUpdate](../AccelByte.Sdk/Api/Basic/Model/UserProfileStatusUpdate.cs) |
| `UserProfileUpdate` | [UserProfileUpdate](../AccelByte.Sdk/Api/Basic/Model/UserProfileUpdate.cs) |
| `UserReportRequest` | [UserReportRequest](../AccelByte.Sdk/Api/Basic/Model/UserReportRequest.cs) |
| `UserZipCode` | [UserZipCode](../AccelByte.Sdk/Api/Basic/Model/UserZipCode.cs) |
| `UserZipCodeUpdate` | [UserZipCodeUpdate](../AccelByte.Sdk/Api/Basic/Model/UserZipCodeUpdate.cs) |
| `ValidationErrorEntity` | [ValidationErrorEntity](../AccelByte.Sdk/Api/Basic/Model/ValidationErrorEntity.cs) |
