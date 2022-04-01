# Lobby Service Index

&nbsp;  

## Operations

### friends Wrapper:  [Friends](../AccelByte.Sdk/Api/Lobby/Wrapper/Friends.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /friends/namespaces/{namespace}/me | GET | GetUserFriendsUpdated | [GetUserFriendsUpdated](../AccelByte.Sdk/Api/Lobby/Operation//GetUserFriendsUpdated.cs) |
| /friends/namespaces/{namespace}/me/incoming | GET | GetUserIncomingFriends | [GetUserIncomingFriends](../AccelByte.Sdk/Api/Lobby/Operation//GetUserIncomingFriends.cs) |
| /friends/namespaces/{namespace}/me/outgoing | GET | GetUserOutgoingFriends | [GetUserOutgoingFriends](../AccelByte.Sdk/Api/Lobby/Operation//GetUserOutgoingFriends.cs) |
| /friends/namespaces/{namespace}/me/request | POST | UserRequestFriend | [UserRequestFriend](../AccelByte.Sdk/Api/Lobby/Operation//UserRequestFriend.cs) |
| /friends/namespaces/{namespace}/me/request/accept | POST | UserAcceptFriendRequest | [UserAcceptFriendRequest](../AccelByte.Sdk/Api/Lobby/Operation//UserAcceptFriendRequest.cs) |
| /friends/namespaces/{namespace}/me/request/cancel | POST | UserCancelFriendRequest | [UserCancelFriendRequest](../AccelByte.Sdk/Api/Lobby/Operation//UserCancelFriendRequest.cs) |
| /friends/namespaces/{namespace}/me/request/reject | POST | UserRejectFriendRequest | [UserRejectFriendRequest](../AccelByte.Sdk/Api/Lobby/Operation//UserRejectFriendRequest.cs) |
| /friends/namespaces/{namespace}/me/status/{friendId} | GET | UserGetFriendshipStatus | [UserGetFriendshipStatus](../AccelByte.Sdk/Api/Lobby/Operation//UserGetFriendshipStatus.cs) |
| /friends/namespaces/{namespace}/me/unfriend | POST | UserUnfriendRequest | [UserUnfriendRequest](../AccelByte.Sdk/Api/Lobby/Operation//UserUnfriendRequest.cs) |
| /friends/namespaces/{namespace}/users/{userId}/add/bulk | POST | AddFriendsWithoutConfirmation | [AddFriendsWithoutConfirmation](../AccelByte.Sdk/Api/Lobby/Operation//AddFriendsWithoutConfirmation.cs) |
| /lobby/v1/admin/friend/namespaces/{namespace}/users/{userId} | GET | GetListOfFriends | [GetListOfFriends](../AccelByte.Sdk/Api/Lobby/Operation//GetListOfFriends.cs) |

### chat Wrapper:  [Chat](../AccelByte.Sdk/Api/Lobby/Wrapper/Chat.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/chat/namespaces/{namespace}/users/{userId}/friend/{friendId} | GET | PersonalChatHistory | [PersonalChatHistory](../AccelByte.Sdk/Api/Lobby/Operation//PersonalChatHistory.cs) |
| /lobby/v1/admin/chat/namespaces/{namespace}/users/{userId}/friends/{friendId} | GET | AdminChatHistory | [AdminChatHistory](../AccelByte.Sdk/Api/Lobby/Operation//AdminChatHistory.cs) |
| /lobby/v1/public/chat/namespaces/{namespace}/users/me/friends/{friendId} | GET | GetPersonalChatHistoryV1Public | [GetPersonalChatHistoryV1Public](../AccelByte.Sdk/Api/Lobby/Operation//GetPersonalChatHistoryV1Public.cs) |

### config Wrapper:  [Config](../AccelByte.Sdk/Api/Lobby/Wrapper/Config.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/admin/config | GET | AdminGetAllConfigV1 | [AdminGetAllConfigV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetAllConfigV1.cs) |
| /lobby/v1/admin/config/namespaces/{namespace} | GET | AdminGetConfigV1 | [AdminGetConfigV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetConfigV1.cs) |
| /lobby/v1/admin/config/namespaces/{namespace} | PUT | AdminUpdateConfigV1 | [AdminUpdateConfigV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminUpdateConfigV1.cs) |
| /lobby/v1/admin/config/namespaces/{namespace}/export | GET | AdminExportConfigV1 | [AdminExportConfigV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminExportConfigV1.cs) |
| /lobby/v1/admin/config/namespaces/{namespace}/import | POST | AdminImportConfigV1 | [AdminImportConfigV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminImportConfigV1.cs) |

### notification Wrapper:  [Notification](../AccelByte.Sdk/Api/Lobby/Wrapper/Notification.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/admin/notification/namespaces/{namespace}/bulkUsers/freeform/notify | POST | SendMultipleUsersFreeformNotificationV1Admin | [SendMultipleUsersFreeformNotificationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//SendMultipleUsersFreeformNotificationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/freeform/notify | POST | SendUsersFreeformNotificationV1Admin | [SendUsersFreeformNotificationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//SendUsersFreeformNotificationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/freeform/notify | POST | SendPartyFreeformNotificationV1Admin | [SendPartyFreeformNotificationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//SendPartyFreeformNotificationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/templates/notify | POST | SendPartyTemplatedNotificationV1Admin | [SendPartyTemplatedNotificationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//SendPartyTemplatedNotificationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates | GET | GetAllNotificationTemplatesV1Admin | [GetAllNotificationTemplatesV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//GetAllNotificationTemplatesV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates | POST | CreateNotificationTemplateV1Admin | [CreateNotificationTemplateV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//CreateNotificationTemplateV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates/notify | POST | SendUsersTemplatedNotificationV1Admin | [SendUsersTemplatedNotificationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//SendUsersTemplatedNotificationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug} | GET | GetTemplateSlugLocalizationsTemplateV1Admin | [GetTemplateSlugLocalizationsTemplateV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//GetTemplateSlugLocalizationsTemplateV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug} | DELETE | DeleteNotificationTemplateSlugV1Admin | [DeleteNotificationTemplateSlugV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//DeleteNotificationTemplateSlugV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage} | GET | GetSingleTemplateLocalizationV1Admin | [GetSingleTemplateLocalizationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//GetSingleTemplateLocalizationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage} | PUT | UpdateTemplateLocalizationV1Admin | [UpdateTemplateLocalizationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//UpdateTemplateLocalizationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage} | DELETE | DeleteTemplateLocalizationV1Admin | [DeleteTemplateLocalizationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//DeleteTemplateLocalizationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish | POST | PublishTemplateLocalizationV1Admin | [PublishTemplateLocalizationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//PublishTemplateLocalizationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/topics | GET | GetAllNotificationTopicsV1Admin | [GetAllNotificationTopicsV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//GetAllNotificationTopicsV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/topics | POST | CreateNotificationTopicV1Admin | [CreateNotificationTopicV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//CreateNotificationTopicV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName} | GET | GetNotificationTopicV1Admin | [GetNotificationTopicV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//GetNotificationTopicV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName} | PUT | UpdateNotificationTopicV1Admin | [UpdateNotificationTopicV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//UpdateNotificationTopicV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName} | DELETE | DeleteNotificationTopicV1Admin | [DeleteNotificationTopicV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//DeleteNotificationTopicV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/freeform/notify | POST | SendSpecificUserFreeformNotificationV1Admin | [SendSpecificUserFreeformNotificationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//SendSpecificUserFreeformNotificationV1Admin.cs) |
| /lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/templates/notify | POST | SendSpecificUserTemplatedNotificationV1Admin | [SendSpecificUserTemplatedNotificationV1Admin](../AccelByte.Sdk/Api/Lobby/Operation//SendSpecificUserTemplatedNotificationV1Admin.cs) |
| /notification/namespaces/{namespace}/freeform | POST | FreeFormNotification | [FreeFormNotification](../AccelByte.Sdk/Api/Lobby/Operation//FreeFormNotification.cs) |
| /notification/namespaces/{namespace}/templated | POST | NotificationWithTemplate | [NotificationWithTemplate](../AccelByte.Sdk/Api/Lobby/Operation//NotificationWithTemplate.cs) |
| /notification/namespaces/{namespace}/templates | GET | GetGameTemplate | [GetGameTemplate](../AccelByte.Sdk/Api/Lobby/Operation//GetGameTemplate.cs) |
| /notification/namespaces/{namespace}/templates | POST | CreateTemplate | [CreateTemplate](../AccelByte.Sdk/Api/Lobby/Operation//CreateTemplate.cs) |
| /notification/namespaces/{namespace}/templates/{templateSlug} | GET | GetSlugTemplate | [GetSlugTemplate](../AccelByte.Sdk/Api/Lobby/Operation//GetSlugTemplate.cs) |
| /notification/namespaces/{namespace}/templates/{templateSlug} | DELETE | DeleteTemplateSlug | [DeleteTemplateSlug](../AccelByte.Sdk/Api/Lobby/Operation//DeleteTemplateSlug.cs) |
| /notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage} | GET | GetLocalizationTemplate | [GetLocalizationTemplate](../AccelByte.Sdk/Api/Lobby/Operation//GetLocalizationTemplate.cs) |
| /notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage} | PUT | UpdateLocalizationTemplate | [UpdateLocalizationTemplate](../AccelByte.Sdk/Api/Lobby/Operation//UpdateLocalizationTemplate.cs) |
| /notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage} | DELETE | DeleteTemplateLocalization | [DeleteTemplateLocalization](../AccelByte.Sdk/Api/Lobby/Operation//DeleteTemplateLocalization.cs) |
| /notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish | POST | PublishTemplate | [PublishTemplate](../AccelByte.Sdk/Api/Lobby/Operation//PublishTemplate.cs) |
| /notification/namespaces/{namespace}/topics | GET | GetTopicByNamespace | [GetTopicByNamespace](../AccelByte.Sdk/Api/Lobby/Operation//GetTopicByNamespace.cs) |
| /notification/namespaces/{namespace}/topics | POST | CreateTopic | [CreateTopic](../AccelByte.Sdk/Api/Lobby/Operation//CreateTopic.cs) |
| /notification/namespaces/{namespace}/topics/{topic} | GET | GetTopicByTopicName | [GetTopicByTopicName](../AccelByte.Sdk/Api/Lobby/Operation//GetTopicByTopicName.cs) |
| /notification/namespaces/{namespace}/topics/{topic} | PUT | UpdateTopicByTopicName | [UpdateTopicByTopicName](../AccelByte.Sdk/Api/Lobby/Operation//UpdateTopicByTopicName.cs) |
| /notification/namespaces/{namespace}/topics/{topic} | DELETE | DeleteTopicByTopicName | [DeleteTopicByTopicName](../AccelByte.Sdk/Api/Lobby/Operation//DeleteTopicByTopicName.cs) |
| /notification/namespaces/{namespace}/users/{userId}/freeform | POST | FreeFormNotificationByUserID | [FreeFormNotificationByUserID](../AccelByte.Sdk/Api/Lobby/Operation//FreeFormNotificationByUserID.cs) |
| /notification/namespaces/{namespace}/users/{userId}/templated | POST | NotificationWithTemplateByUserID | [NotificationWithTemplateByUserID](../AccelByte.Sdk/Api/Lobby/Operation//NotificationWithTemplateByUserID.cs) |

### party Wrapper:  [Party](../AccelByte.Sdk/Api/Lobby/Wrapper/Party.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId} | GET | AdminGetPartyDataV1 | [AdminGetPartyDataV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetPartyDataV1.cs) |
| /lobby/v1/admin/party/namespaces/{namespace}/users/{userId}/party | GET | AdminGetUserPartyV1 | [AdminGetUserPartyV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetUserPartyV1.cs) |
| /lobby/v1/public/party/namespaces/{namespace}/parties/{partyId} | GET | PublicGetPartyDataV1 | [PublicGetPartyDataV1](../AccelByte.Sdk/Api/Lobby/Operation//PublicGetPartyDataV1.cs) |
| /lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/attributes | PUT | PublicUpdatePartyAttributesV1 | [PublicUpdatePartyAttributesV1](../AccelByte.Sdk/Api/Lobby/Operation//PublicUpdatePartyAttributesV1.cs) |

### Operations Wrapper:  [Operations](../AccelByte.Sdk/Api/Lobby/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/attributes | PUT | AdminUpdatePartyAttributesV1 | [AdminUpdatePartyAttributesV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminUpdatePartyAttributesV1.cs) |
| /lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/join/{userId} | POST | AdminJoinPartyV1 | [AdminJoinPartyV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminJoinPartyV1.cs) |
| /lobby/v1/messages | GET | PublicGetMessages | [PublicGetMessages](../AccelByte.Sdk/Api/Lobby/Operation//PublicGetMessages.cs) |

### player Wrapper:  [Player](../AccelByte.Sdk/Api/Lobby/Wrapper/Player.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/admin/player/namespaces/{namespace}/ccu | GET | AdminGetLobbyCCU | [AdminGetLobbyCCU](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetLobbyCCU.cs) |
| /lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes | GET | AdminGetAllPlayerSessionAttribute | [AdminGetAllPlayerSessionAttribute](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetAllPlayerSessionAttribute.cs) |
| /lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes | PUT | AdminSetPlayerSessionAttribute | [AdminSetPlayerSessionAttribute](../AccelByte.Sdk/Api/Lobby/Operation//AdminSetPlayerSessionAttribute.cs) |
| /lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes/{attribute} | GET | AdminGetPlayerSessionAttribute | [AdminGetPlayerSessionAttribute](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetPlayerSessionAttribute.cs) |
| /lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked | GET | AdminGetPlayerBlockedPlayersV1 | [AdminGetPlayerBlockedPlayersV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetPlayerBlockedPlayersV1.cs) |
| /lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked-by | GET | AdminGetPlayerBlockedByPlayersV1 | [AdminGetPlayerBlockedByPlayersV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetPlayerBlockedByPlayersV1.cs) |
| /lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/bulk/block | POST | AdminBulkBlockPlayersV1 | [AdminBulkBlockPlayersV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminBulkBlockPlayersV1.cs) |
| /lobby/v1/public/player/namespaces/{namespace}/users/me/blocked | GET | PublicGetPlayerBlockedPlayersV1 | [PublicGetPlayerBlockedPlayersV1](../AccelByte.Sdk/Api/Lobby/Operation//PublicGetPlayerBlockedPlayersV1.cs) |
| /lobby/v1/public/player/namespaces/{namespace}/users/me/blocked-by | GET | PublicGetPlayerBlockedByPlayersV1 | [PublicGetPlayerBlockedByPlayersV1](../AccelByte.Sdk/Api/Lobby/Operation//PublicGetPlayerBlockedByPlayersV1.cs) |

### profanity Wrapper:  [Profanity](../AccelByte.Sdk/Api/Lobby/Wrapper/Profanity.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/admin/profanity/namespaces/{namespace}/filters/debug | POST | AdminDebugProfanityFilters | [AdminDebugProfanityFilters](../AccelByte.Sdk/Api/Lobby/Operation//AdminDebugProfanityFilters.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters | GET | AdminGetProfanityListFiltersV1 | [AdminGetProfanityListFiltersV1](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetProfanityListFiltersV1.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters | POST | AdminAddProfanityFilterIntoList | [AdminAddProfanityFilterIntoList](../AccelByte.Sdk/Api/Lobby/Operation//AdminAddProfanityFilterIntoList.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk | POST | AdminAddProfanityFilters | [AdminAddProfanityFilters](../AccelByte.Sdk/Api/Lobby/Operation//AdminAddProfanityFilters.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk-file | POST | AdminImportProfanityFiltersFromFile | [AdminImportProfanityFiltersFromFile](../AccelByte.Sdk/Api/Lobby/Operation//AdminImportProfanityFiltersFromFile.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/delete | POST | AdminDeleteProfanityFilter | [AdminDeleteProfanityFilter](../AccelByte.Sdk/Api/Lobby/Operation//AdminDeleteProfanityFilter.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/lists | GET | AdminGetProfanityLists | [AdminGetProfanityLists](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetProfanityLists.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/lists | POST | AdminCreateProfanityList | [AdminCreateProfanityList](../AccelByte.Sdk/Api/Lobby/Operation//AdminCreateProfanityList.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list} | POST | AdminUpdateProfanityList | [AdminUpdateProfanityList](../AccelByte.Sdk/Api/Lobby/Operation//AdminUpdateProfanityList.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list} | DELETE | AdminDeleteProfanityList | [AdminDeleteProfanityList](../AccelByte.Sdk/Api/Lobby/Operation//AdminDeleteProfanityList.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/rule | GET | AdminGetProfanityRule | [AdminGetProfanityRule](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetProfanityRule.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/rule | POST | AdminSetProfanityRuleForNamespace | [AdminSetProfanityRuleForNamespace](../AccelByte.Sdk/Api/Lobby/Operation//AdminSetProfanityRuleForNamespace.cs) |
| /lobby/v1/admin/profanity/namespaces/{namespace}/verify | POST | AdminVerifyMessageProfanityResponse | [AdminVerifyMessageProfanityResponse](../AccelByte.Sdk/Api/Lobby/Operation//AdminVerifyMessageProfanityResponse.cs) |

### thirdParty Wrapper:  [ThirdParty](../AccelByte.Sdk/Api/Lobby/Wrapper/ThirdParty.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam | GET | AdminGetThirdPartyConfig | [AdminGetThirdPartyConfig](../AccelByte.Sdk/Api/Lobby/Operation//AdminGetThirdPartyConfig.cs) |
| /lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam | PUT | AdminUpdateThirdPartyConfig | [AdminUpdateThirdPartyConfig](../AccelByte.Sdk/Api/Lobby/Operation//AdminUpdateThirdPartyConfig.cs) |
| /lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam | POST | AdminCreateThirdPartyConfig | [AdminCreateThirdPartyConfig](../AccelByte.Sdk/Api/Lobby/Operation//AdminCreateThirdPartyConfig.cs) |
| /lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam | DELETE | AdminDeleteThirdPartyConfig | [AdminDeleteThirdPartyConfig](../AccelByte.Sdk/Api/Lobby/Operation//AdminDeleteThirdPartyConfig.cs) |

### presence Wrapper:  [Presence](../AccelByte.Sdk/Api/Lobby/Wrapper/Presence.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /lobby/v1/public/presence/namespaces/{namespace}/users/presence | GET | UsersPresenceHandlerV1 | [UsersPresenceHandlerV1](../AccelByte.Sdk/Api/Lobby/Operation//UsersPresenceHandlerV1.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| handlers.GetUsersPresenceResponse | [HandlersGetUsersPresenceResponse](../AccelByte.Sdk/Api/Lobby/Model/HandlersGetUsersPresenceResponse.cs) |
| handlers.UserPresence | [HandlersUserPresence](../AccelByte.Sdk/Api/Lobby/Model/HandlersUserPresence.cs) |
| log.AppMessageDeclaration | [LogAppMessageDeclaration](../AccelByte.Sdk/Api/Lobby/Model/LogAppMessageDeclaration.cs) |
| model.BulkAddFriendsRequest | [ModelBulkAddFriendsRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelBulkAddFriendsRequest.cs) |
| model.BulkUsersFreeFormNotificationRequestV1 | [ModelBulkUsersFreeFormNotificationRequestV1](../AccelByte.Sdk/Api/Lobby/Model/ModelBulkUsersFreeFormNotificationRequestV1.cs) |
| model.ChatMessageResponse | [ModelChatMessageResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelChatMessageResponse.cs) |
| model.CreateTemplateRequest | [ModelCreateTemplateRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelCreateTemplateRequest.cs) |
| model.CreateTopicRequest | [ModelCreateTopicRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelCreateTopicRequest.cs) |
| model.CreateTopicRequestV1 | [ModelCreateTopicRequestV1](../AccelByte.Sdk/Api/Lobby/Model/ModelCreateTopicRequestV1.cs) |
| model.FreeFormNotificationRequest | [ModelFreeFormNotificationRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelFreeFormNotificationRequest.cs) |
| model.FreeFormNotificationRequestV1 | [ModelFreeFormNotificationRequestV1](../AccelByte.Sdk/Api/Lobby/Model/ModelFreeFormNotificationRequestV1.cs) |
| model.GetAllNotificationTemplateSlugResp | [ModelGetAllNotificationTemplateSlugResp](../AccelByte.Sdk/Api/Lobby/Model/ModelGetAllNotificationTemplateSlugResp.cs) |
| model.GetAllNotificationTopicsResponse | [ModelGetAllNotificationTopicsResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelGetAllNotificationTopicsResponse.cs) |
| model.GetFriendsResponse | [ModelGetFriendsResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelGetFriendsResponse.cs) |
| model.GetUserFriendsResponse | [ModelGetUserFriendsResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelGetUserFriendsResponse.cs) |
| model.GetUserIncomingFriendsResponse | [ModelGetUserIncomingFriendsResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelGetUserIncomingFriendsResponse.cs) |
| model.GetUserOutgoingFriendsResponse | [ModelGetUserOutgoingFriendsResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelGetUserOutgoingFriendsResponse.cs) |
| model.Localization | [ModelLocalization](../AccelByte.Sdk/Api/Lobby/Model/ModelLocalization.cs) |
| model.NotificationTemplateResponse | [ModelNotificationTemplateResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationTemplateResponse.cs) |
| model.NotificationTopicResponse | [ModelNotificationTopicResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationTopicResponse.cs) |
| model.NotificationTopicResponseV1 | [ModelNotificationTopicResponseV1](../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationTopicResponseV1.cs) |
| model.NotificationWithTemplateRequest | [ModelNotificationWithTemplateRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationWithTemplateRequest.cs) |
| model.NotificationWithTemplateRequestV1 | [ModelNotificationWithTemplateRequestV1](../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationWithTemplateRequestV1.cs) |
| model.Pagination | [ModelPagination](../AccelByte.Sdk/Api/Lobby/Model/ModelPagination.cs) |
| model.RequestFriendsRequest | [ModelRequestFriendsRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelRequestFriendsRequest.cs) |
| model.TemplateContent | [ModelTemplateContent](../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateContent.cs) |
| model.TemplateLocalization | [ModelTemplateLocalization](../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateLocalization.cs) |
| model.TemplateLocalizationResponse | [ModelTemplateLocalizationResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateLocalizationResponse.cs) |
| model.TemplateResponse | [ModelTemplateResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateResponse.cs) |
| model.TopicByNamespacesResponse | [ModelTopicByNamespacesResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelTopicByNamespacesResponse.cs) |
| model.UpdateTemplateRequest | [ModelUpdateTemplateRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelUpdateTemplateRequest.cs) |
| model.UpdateTopicRequest | [ModelUpdateTopicRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelUpdateTopicRequest.cs) |
| model.UserAcceptFriendRequest | [ModelUserAcceptFriendRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelUserAcceptFriendRequest.cs) |
| model.UserCancelFriendRequest | [ModelUserCancelFriendRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelUserCancelFriendRequest.cs) |
| model.UserGetFriendshipStatusResponse | [ModelUserGetFriendshipStatusResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelUserGetFriendshipStatusResponse.cs) |
| model.UserRejectFriendRequest | [ModelUserRejectFriendRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelUserRejectFriendRequest.cs) |
| model.UserUnfriendRequest | [ModelUserUnfriendRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelUserUnfriendRequest.cs) |
| models.AdminAddProfanityFilterIntoListRequest | [ModelsAdminAddProfanityFilterIntoListRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminAddProfanityFilterIntoListRequest.cs) |
| models.AdminAddProfanityFiltersFilterRequest | [ModelsAdminAddProfanityFiltersFilterRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminAddProfanityFiltersFilterRequest.cs) |
| models.AdminAddProfanityFiltersRequest | [ModelsAdminAddProfanityFiltersRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminAddProfanityFiltersRequest.cs) |
| models.AdminCreateProfanityListRequest | [ModelsAdminCreateProfanityListRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminCreateProfanityListRequest.cs) |
| models.AdminDeleteProfanityFilterRequest | [ModelsAdminDeleteProfanityFilterRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminDeleteProfanityFilterRequest.cs) |
| models.AdminGetProfanityListFiltersV1Response | [ModelsAdminGetProfanityListFiltersV1Response](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminGetProfanityListFiltersV1Response.cs) |
| models.AdminGetProfanityListsListResponse | [ModelsAdminGetProfanityListsListResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminGetProfanityListsListResponse.cs) |
| models.AdminSetProfanityRuleForNamespaceRequest | [ModelsAdminSetProfanityRuleForNamespaceRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminSetProfanityRuleForNamespaceRequest.cs) |
| models.AdminUpdateProfanityList | [ModelsAdminUpdateProfanityList](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminUpdateProfanityList.cs) |
| models.AdminVerifyMessageProfanityRequest | [ModelsAdminVerifyMessageProfanityRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminVerifyMessageProfanityRequest.cs) |
| models.AdminVerifyMessageProfanityResponse | [ModelsAdminVerifyMessageProfanityResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminVerifyMessageProfanityResponse.cs) |
| models.BlockedByPlayerData | [ModelsBlockedByPlayerData](../AccelByte.Sdk/Api/Lobby/Model/ModelsBlockedByPlayerData.cs) |
| models.BlockedPlayerData | [ModelsBlockedPlayerData](../AccelByte.Sdk/Api/Lobby/Model/ModelsBlockedPlayerData.cs) |
| models.Config | [ModelsConfig](../AccelByte.Sdk/Api/Lobby/Model/ModelsConfig.cs) |
| models.ConfigExport | [ModelsConfigExport](../AccelByte.Sdk/Api/Lobby/Model/ModelsConfigExport.cs) |
| models.ConfigList | [ModelsConfigList](../AccelByte.Sdk/Api/Lobby/Model/ModelsConfigList.cs) |
| models.ConfigReq | [ModelsConfigReq](../AccelByte.Sdk/Api/Lobby/Model/ModelsConfigReq.cs) |
| models.CreateConfigRequest | [ModelsCreateConfigRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsCreateConfigRequest.cs) |
| models.CreateConfigResponse | [ModelsCreateConfigResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsCreateConfigResponse.cs) |
| models.DebugProfanityFilterRequest | [ModelsDebugProfanityFilterRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsDebugProfanityFilterRequest.cs) |
| models.GetAllPlayerBlockedByUsersResponse | [ModelsGetAllPlayerBlockedByUsersResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsGetAllPlayerBlockedByUsersResponse.cs) |
| models.GetAllPlayerBlockedUsersResponse | [ModelsGetAllPlayerBlockedUsersResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsGetAllPlayerBlockedUsersResponse.cs) |
| models.GetAllPlayerSessionAttributeResponse | [ModelsGetAllPlayerSessionAttributeResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsGetAllPlayerSessionAttributeResponse.cs) |
| models.GetConfigResponse | [ModelsGetConfigResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsGetConfigResponse.cs) |
| models.GetLobbyCcuResponse | [ModelsGetLobbyCcuResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsGetLobbyCcuResponse.cs) |
| models.GetPlayerSessionAttributeResponse | [ModelsGetPlayerSessionAttributeResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsGetPlayerSessionAttributeResponse.cs) |
| models.ImportConfigResponse | [ModelsImportConfigResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsImportConfigResponse.cs) |
| models.ListBlockedPlayerRequest | [ModelsListBlockedPlayerRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsListBlockedPlayerRequest.cs) |
| models.PartyData | [ModelsPartyData](../AccelByte.Sdk/Api/Lobby/Model/ModelsPartyData.cs) |
| models.PartyPUTCustomAttributesRequest | [ModelsPartyPUTCustomAttributesRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsPartyPUTCustomAttributesRequest.cs) |
| models.ProfanityFilter | [ModelsProfanityFilter](../AccelByte.Sdk/Api/Lobby/Model/ModelsProfanityFilter.cs) |
| models.ProfanityRule | [ModelsProfanityRule](../AccelByte.Sdk/Api/Lobby/Model/ModelsProfanityRule.cs) |
| models.SetPlayerSessionAttributeRequest | [ModelsSetPlayerSessionAttributeRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsSetPlayerSessionAttributeRequest.cs) |
| models.UpdateConfigRequest | [ModelsUpdateConfigRequest](../AccelByte.Sdk/Api/Lobby/Model/ModelsUpdateConfigRequest.cs) |
| models.UpdateConfigResponse | [ModelsUpdateConfigResponse](../AccelByte.Sdk/Api/Lobby/Model/ModelsUpdateConfigResponse.cs) |
| response.Error | [ResponseError](../AccelByte.Sdk/Api/Lobby/Model/ResponseError.cs) |
| restapi.ErrorResponseBody | [RestapiErrorResponseBody](../AccelByte.Sdk/Api/Lobby/Model/RestapiErrorResponseBody.cs) |
| restapi.ErrorResponseV1 | [RestapiErrorResponseV1](../AccelByte.Sdk/Api/Lobby/Model/RestapiErrorResponseV1.cs) |
