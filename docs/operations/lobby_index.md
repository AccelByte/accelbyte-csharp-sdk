# Lobby Service Index

&nbsp;  

## Operations

### friends Wrapper:  [Friends](../../AccelByte.Sdk/Api/Lobby/Wrapper/Friends.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/friends/namespaces/{namespace}/me` | GET | GetUserFriendsUpdated | [GetUserFriendsUpdated](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetUserFriendsUpdated.cs) | [GetUserFriendsUpdated](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserFriendsUpdated.cs) |
| `/friends/namespaces/{namespace}/me/incoming` | GET | GetUserIncomingFriends | [GetUserIncomingFriends](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetUserIncomingFriends.cs) | [GetUserIncomingFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserIncomingFriends.cs) |
| `/friends/namespaces/{namespace}/me/incoming-time` | GET | GetUserIncomingFriendsWithTime | [GetUserIncomingFriendsWithTime](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetUserIncomingFriendsWithTime.cs) | [GetUserIncomingFriendsWithTime](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserIncomingFriendsWithTime.cs) |
| `/friends/namespaces/{namespace}/me/outgoing` | GET | GetUserOutgoingFriends | [GetUserOutgoingFriends](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetUserOutgoingFriends.cs) | [GetUserOutgoingFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserOutgoingFriends.cs) |
| `/friends/namespaces/{namespace}/me/outgoing-time` | GET | GetUserOutgoingFriendsWithTime | [GetUserOutgoingFriendsWithTime](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetUserOutgoingFriendsWithTime.cs) | [GetUserOutgoingFriendsWithTime](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserOutgoingFriendsWithTime.cs) |
| `/friends/namespaces/{namespace}/me/platforms` | GET | GetUserFriendsWithPlatform | [GetUserFriendsWithPlatform](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetUserFriendsWithPlatform.cs) | [GetUserFriendsWithPlatform](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetUserFriendsWithPlatform.cs) |
| `/friends/namespaces/{namespace}/me/request` | POST | UserRequestFriend | [UserRequestFriend](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/UserRequestFriend.cs) | [UserRequestFriend](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserRequestFriend.cs) |
| `/friends/namespaces/{namespace}/me/request/accept` | POST | UserAcceptFriendRequest | [UserAcceptFriendRequest](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/UserAcceptFriendRequest.cs) | [UserAcceptFriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserAcceptFriendRequest.cs) |
| `/friends/namespaces/{namespace}/me/request/cancel` | POST | UserCancelFriendRequest | [UserCancelFriendRequest](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/UserCancelFriendRequest.cs) | [UserCancelFriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserCancelFriendRequest.cs) |
| `/friends/namespaces/{namespace}/me/request/reject` | POST | UserRejectFriendRequest | [UserRejectFriendRequest](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/UserRejectFriendRequest.cs) | [UserRejectFriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserRejectFriendRequest.cs) |
| `/friends/namespaces/{namespace}/me/status/{friendId}` | GET | UserGetFriendshipStatus | [UserGetFriendshipStatus](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/UserGetFriendshipStatus.cs) | [UserGetFriendshipStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserGetFriendshipStatus.cs) |
| `/friends/namespaces/{namespace}/me/unfriend` | POST | UserUnfriendRequest | [UserUnfriendRequest](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/UserUnfriendRequest.cs) | [UserUnfriendRequest](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/UserUnfriendRequest.cs) |
| `/friends/namespaces/{namespace}/users/{userId}/add/bulk` | POST | AddFriendsWithoutConfirmation | [AddFriendsWithoutConfirmation](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/AddFriendsWithoutConfirmation.cs) | [AddFriendsWithoutConfirmation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/AddFriendsWithoutConfirmation.cs) |
| `/friends/namespaces/{namespace}/users/{userId}/delete/bulk` | POST | BulkDeleteFriends | [BulkDeleteFriends](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/BulkDeleteFriends.cs) | [BulkDeleteFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/BulkDeleteFriends.cs) |
| `/friends/sync/namespaces/{namespace}/me` | PATCH | SyncNativeFriends | [SyncNativeFriends](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/SyncNativeFriends.cs) | [SyncNativeFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/SyncNativeFriends.cs) |
| `/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}` | GET | GetListOfFriends | [GetListOfFriends](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetListOfFriends.cs) | [GetListOfFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetListOfFriends.cs) |
| `/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/incoming` | GET | GetIncomingFriendRequests | [GetIncomingFriendRequests](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetIncomingFriendRequests.cs) | [GetIncomingFriendRequests](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetIncomingFriendRequests.cs) |
| `/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/of-friends` | GET | AdminListFriendsOfFriends | [AdminListFriendsOfFriends](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/AdminListFriendsOfFriends.cs) | [AdminListFriendsOfFriends](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/AdminListFriendsOfFriends.cs) |
| `/lobby/v1/admin/friend/namespaces/{namespace}/users/{userId}/outgoing` | GET | GetOutgoingFriendRequests | [GetOutgoingFriendRequests](../../AccelByte.Sdk/Api/Lobby/Operation/Friends/GetOutgoingFriendRequests.cs) | [GetOutgoingFriendRequests](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Friends/GetOutgoingFriendRequests.cs) |

### blocks Wrapper:  [Blocks](../../AccelByte.Sdk/Api/Lobby/Wrapper/Blocks.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/sync/namespaces/{namespace}/me/block` | PATCH | SyncNativeBlockedUser | [SyncNativeBlockedUser](../../AccelByte.Sdk/Api/Lobby/Operation/Blocks/SyncNativeBlockedUser.cs) | [SyncNativeBlockedUser](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Blocks/SyncNativeBlockedUser.cs) |

### config Wrapper:  [Config](../../AccelByte.Sdk/Api/Lobby/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/config` | GET | AdminGetAllConfigV1 | [AdminGetAllConfigV1](../../AccelByte.Sdk/Api/Lobby/Operation/Config/AdminGetAllConfigV1.cs) | [AdminGetAllConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminGetAllConfigV1.cs) |
| `/lobby/v1/admin/config/log` | GET | AdminGetLogConfig | [AdminGetLogConfig](../../AccelByte.Sdk/Api/Lobby/Operation/Config/AdminGetLogConfig.cs) | [AdminGetLogConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminGetLogConfig.cs) |
| `/lobby/v1/admin/config/log` | PATCH | AdminPatchUpdateLogConfig | [AdminPatchUpdateLogConfig](../../AccelByte.Sdk/Api/Lobby/Operation/Config/AdminPatchUpdateLogConfig.cs) | [AdminPatchUpdateLogConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminPatchUpdateLogConfig.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}` | GET | AdminGetConfigV1 | [AdminGetConfigV1](../../AccelByte.Sdk/Api/Lobby/Operation/Config/AdminGetConfigV1.cs) | [AdminGetConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminGetConfigV1.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}` | PUT | AdminUpdateConfigV1 | [AdminUpdateConfigV1](../../AccelByte.Sdk/Api/Lobby/Operation/Config/AdminUpdateConfigV1.cs) | [AdminUpdateConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminUpdateConfigV1.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}/export` | GET | AdminExportConfigV1 | [AdminExportConfigV1](../../AccelByte.Sdk/Api/Lobby/Operation/Config/AdminExportConfigV1.cs) | [AdminExportConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminExportConfigV1.cs) |
| `/lobby/v1/admin/config/namespaces/{namespace}/import` | POST | AdminImportConfigV1 | [AdminImportConfigV1](../../AccelByte.Sdk/Api/Lobby/Operation/Config/AdminImportConfigV1.cs) | [AdminImportConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Config/AdminImportConfigV1.cs) |

### admin Wrapper:  [Admin](../../AccelByte.Sdk/Api/Lobby/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/lobby/v1/admin/global-configurations` | GET | AdminGetGlobalConfig | [AdminGetGlobalConfig](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/AdminGetGlobalConfig.cs) | [AdminGetGlobalConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/AdminGetGlobalConfig.cs) |
| [DEPRECATED] `/lobby/v1/admin/global-configurations` | PUT | AdminUpdateGlobalConfig | [AdminUpdateGlobalConfig](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/AdminUpdateGlobalConfig.cs) | [AdminUpdateGlobalConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/AdminUpdateGlobalConfig.cs) |
| [DEPRECATED] `/lobby/v1/admin/global-configurations` | DELETE | AdminDeleteGlobalConfig | [AdminDeleteGlobalConfig](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/AdminDeleteGlobalConfig.cs) | [AdminDeleteGlobalConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/AdminDeleteGlobalConfig.cs) |
| `/notification/namespaces/{namespace}/freeform` | POST | FreeFormNotification | [FreeFormNotification](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/FreeFormNotification.cs) | [FreeFormNotification](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/FreeFormNotification.cs) |
| `/notification/namespaces/{namespace}/templated` | POST | NotificationWithTemplate | [NotificationWithTemplate](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/NotificationWithTemplate.cs) | [NotificationWithTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/NotificationWithTemplate.cs) |
| `/notification/namespaces/{namespace}/templates` | GET | GetGameTemplate | [GetGameTemplate](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/GetGameTemplate.cs) | [GetGameTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/GetGameTemplate.cs) |
| `/notification/namespaces/{namespace}/templates` | POST | CreateTemplate | [CreateTemplate](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/CreateTemplate.cs) | [CreateTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/CreateTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}` | GET | GetSlugTemplate | [GetSlugTemplate](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/GetSlugTemplate.cs) | [GetSlugTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/GetSlugTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}` | DELETE | DeleteTemplateSlug | [DeleteTemplateSlug](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/DeleteTemplateSlug.cs) | [DeleteTemplateSlug](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/DeleteTemplateSlug.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | GET | GetLocalizationTemplate | [GetLocalizationTemplate](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/GetLocalizationTemplate.cs) | [GetLocalizationTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/GetLocalizationTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | PUT | UpdateLocalizationTemplate | [UpdateLocalizationTemplate](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/UpdateLocalizationTemplate.cs) | [UpdateLocalizationTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/UpdateLocalizationTemplate.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | DELETE | DeleteTemplateLocalization | [DeleteTemplateLocalization](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/DeleteTemplateLocalization.cs) | [DeleteTemplateLocalization](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/DeleteTemplateLocalization.cs) |
| `/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish` | POST | PublishTemplate | [PublishTemplate](../../AccelByte.Sdk/Api/Lobby/Operation/Admin/PublishTemplate.cs) | [PublishTemplate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Admin/PublishTemplate.cs) |

### notification Wrapper:  [Notification](../../AccelByte.Sdk/Api/Lobby/Wrapper/Notification.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/notification/namespaces/{namespace}/bulkUsers/freeform/notify` | POST | SendMultipleUsersFreeformNotificationV1Admin | [SendMultipleUsersFreeformNotificationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/SendMultipleUsersFreeformNotificationV1Admin.cs) | [SendMultipleUsersFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendMultipleUsersFreeformNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/freeform/notify` | POST | SendUsersFreeformNotificationV1Admin | [SendUsersFreeformNotificationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/SendUsersFreeformNotificationV1Admin.cs) | [SendUsersFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendUsersFreeformNotificationV1Admin.cs) |
| [DEPRECATED] `/lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/freeform/notify` | POST | SendPartyFreeformNotificationV1Admin | [SendPartyFreeformNotificationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/SendPartyFreeformNotificationV1Admin.cs) | [SendPartyFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendPartyFreeformNotificationV1Admin.cs) |
| [DEPRECATED] `/lobby/v1/admin/notification/namespaces/{namespace}/parties/{partyId}/templates/notify` | POST | SendPartyTemplatedNotificationV1Admin | [SendPartyTemplatedNotificationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/SendPartyTemplatedNotificationV1Admin.cs) | [SendPartyTemplatedNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendPartyTemplatedNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates` | GET | GetAllNotificationTemplatesV1Admin | [GetAllNotificationTemplatesV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetAllNotificationTemplatesV1Admin.cs) | [GetAllNotificationTemplatesV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetAllNotificationTemplatesV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates` | POST | CreateNotificationTemplateV1Admin | [CreateNotificationTemplateV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/CreateNotificationTemplateV1Admin.cs) | [CreateNotificationTemplateV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/CreateNotificationTemplateV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/notify` | POST | SendUsersTemplatedNotificationV1Admin | [SendUsersTemplatedNotificationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/SendUsersTemplatedNotificationV1Admin.cs) | [SendUsersTemplatedNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendUsersTemplatedNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}` | GET | GetTemplateSlugLocalizationsTemplateV1Admin | [GetTemplateSlugLocalizationsTemplateV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetTemplateSlugLocalizationsTemplateV1Admin.cs) | [GetTemplateSlugLocalizationsTemplateV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetTemplateSlugLocalizationsTemplateV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}` | DELETE | DeleteNotificationTemplateSlugV1Admin | [DeleteNotificationTemplateSlugV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/DeleteNotificationTemplateSlugV1Admin.cs) | [DeleteNotificationTemplateSlugV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteNotificationTemplateSlugV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | GET | GetSingleTemplateLocalizationV1Admin | [GetSingleTemplateLocalizationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetSingleTemplateLocalizationV1Admin.cs) | [GetSingleTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetSingleTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | PUT | UpdateTemplateLocalizationV1Admin | [UpdateTemplateLocalizationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/UpdateTemplateLocalizationV1Admin.cs) | [UpdateTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/UpdateTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}` | DELETE | DeleteTemplateLocalizationV1Admin | [DeleteTemplateLocalizationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/DeleteTemplateLocalizationV1Admin.cs) | [DeleteTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish` | POST | PublishTemplateLocalizationV1Admin | [PublishTemplateLocalizationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/PublishTemplateLocalizationV1Admin.cs) | [PublishTemplateLocalizationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/PublishTemplateLocalizationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics` | GET | GetAllNotificationTopicsV1Admin | [GetAllNotificationTopicsV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetAllNotificationTopicsV1Admin.cs) | [GetAllNotificationTopicsV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetAllNotificationTopicsV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics` | POST | CreateNotificationTopicV1Admin | [CreateNotificationTopicV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/CreateNotificationTopicV1Admin.cs) | [CreateNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/CreateNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}` | GET | GetNotificationTopicV1Admin | [GetNotificationTopicV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetNotificationTopicV1Admin.cs) | [GetNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}` | PUT | UpdateNotificationTopicV1Admin | [UpdateNotificationTopicV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/UpdateNotificationTopicV1Admin.cs) | [UpdateNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/UpdateNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/topics/{topicName}` | DELETE | DeleteNotificationTopicV1Admin | [DeleteNotificationTopicV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/DeleteNotificationTopicV1Admin.cs) | [DeleteNotificationTopicV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteNotificationTopicV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/freeform/notify` | POST | SendSpecificUserFreeformNotificationV1Admin | [SendSpecificUserFreeformNotificationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/SendSpecificUserFreeformNotificationV1Admin.cs) | [SendSpecificUserFreeformNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendSpecificUserFreeformNotificationV1Admin.cs) |
| `/lobby/v1/admin/notification/namespaces/{namespace}/users/{userId}/templates/notify` | POST | SendSpecificUserTemplatedNotificationV1Admin | [SendSpecificUserTemplatedNotificationV1Admin](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/SendSpecificUserTemplatedNotificationV1Admin.cs) | [SendSpecificUserTemplatedNotificationV1Admin](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/SendSpecificUserTemplatedNotificationV1Admin.cs) |
| `/notification/namespaces/{namespace}/me` | GET | GetMyNotifications | [GetMyNotifications](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetMyNotifications.cs) | [GetMyNotifications](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetMyNotifications.cs) |
| `/notification/namespaces/{namespace}/notification/offline/me` | GET | GetMyOfflineNotifications | [GetMyOfflineNotifications](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetMyOfflineNotifications.cs) | [GetMyOfflineNotifications](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetMyOfflineNotifications.cs) |
| `/notification/namespaces/{namespace}/topics` | GET | GetTopicByNamespace | [GetTopicByNamespace](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetTopicByNamespace.cs) | [GetTopicByNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetTopicByNamespace.cs) |
| `/notification/namespaces/{namespace}/topics` | POST | CreateTopic | [CreateTopic](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/CreateTopic.cs) | [CreateTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/CreateTopic.cs) |
| `/notification/namespaces/{namespace}/topics/{topic}` | GET | GetTopicByTopicName | [GetTopicByTopicName](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/GetTopicByTopicName.cs) | [GetTopicByTopicName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/GetTopicByTopicName.cs) |
| `/notification/namespaces/{namespace}/topics/{topic}` | PUT | UpdateTopicByTopicName | [UpdateTopicByTopicName](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/UpdateTopicByTopicName.cs) | [UpdateTopicByTopicName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/UpdateTopicByTopicName.cs) |
| `/notification/namespaces/{namespace}/topics/{topic}` | DELETE | DeleteTopicByTopicName | [DeleteTopicByTopicName](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/DeleteTopicByTopicName.cs) | [DeleteTopicByTopicName](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/DeleteTopicByTopicName.cs) |
| `/notification/namespaces/{namespace}/users/{userId}/freeform` | POST | FreeFormNotificationByUserID | [FreeFormNotificationByUserID](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/FreeFormNotificationByUserID.cs) | [FreeFormNotificationByUserID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/FreeFormNotificationByUserID.cs) |
| `/notification/namespaces/{namespace}/users/{userId}/templated` | POST | NotificationWithTemplateByUserID | [NotificationWithTemplateByUserID](../../AccelByte.Sdk/Api/Lobby/Operation/Notification/NotificationWithTemplateByUserID.cs) | [NotificationWithTemplateByUserID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Notification/NotificationWithTemplateByUserID.cs) |

### party Wrapper:  [Party](../../AccelByte.Sdk/Api/Lobby/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}` | GET | AdminGetPartyDataV1 | [AdminGetPartyDataV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/AdminGetPartyDataV1.cs) | [AdminGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetPartyDataV1.cs) |
| [DEPRECATED] `/lobby/v1/admin/party/namespaces/{namespace}/users/{userId}/party` | GET | AdminGetUserPartyV1 | [AdminGetUserPartyV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/AdminGetUserPartyV1.cs) | [AdminGetUserPartyV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetUserPartyV1.cs) |
| [DEPRECATED] `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetPartyDataV1 | [PublicGetPartyDataV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/PublicGetPartyDataV1.cs) | [PublicGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicGetPartyDataV1.cs) |
| [DEPRECATED] `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | PublicUpdatePartyAttributesV1 | [PublicUpdatePartyAttributesV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/PublicUpdatePartyAttributesV1.cs) | [PublicUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicUpdatePartyAttributesV1.cs) |
| [DEPRECATED] `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/limit` | PUT | PublicSetPartyLimitV1 | [PublicSetPartyLimitV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/PublicSetPartyLimitV1.cs) | [PublicSetPartyLimitV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicSetPartyLimitV1.cs) |

### Lobby Operations Wrapper:  [LobbyOperations](../../AccelByte.Sdk/Api/Lobby/Wrapper/LobbyOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | AdminUpdatePartyAttributesV1 | [AdminUpdatePartyAttributesV1](../../AccelByte.Sdk/Api/Lobby/Operation/LobbyOperations/AdminUpdatePartyAttributesV1.cs) | [AdminUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/AdminUpdatePartyAttributesV1.cs) |
| [DEPRECATED] `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/join/{userId}` | POST | AdminJoinPartyV1 | [AdminJoinPartyV1](../../AccelByte.Sdk/Api/Lobby/Operation/LobbyOperations/AdminJoinPartyV1.cs) | [AdminJoinPartyV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/AdminJoinPartyV1.cs) |
| `/lobby/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../AccelByte.Sdk/Api/Lobby/Operation/LobbyOperations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/PublicGetMessages.cs) |

### player Wrapper:  [Player](../../AccelByte.Sdk/Api/Lobby/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/admin/player/namespaces/{namespace}/ccu` | GET | AdminGetLobbyCCU | [AdminGetLobbyCCU](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminGetLobbyCCU.cs) | [AdminGetLobbyCCU](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetLobbyCCU.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/bulk/blocked` | POST | AdminGetBulkPlayerBlockedPlayersV1 | [AdminGetBulkPlayerBlockedPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminGetBulkPlayerBlockedPlayersV1.cs) | [AdminGetBulkPlayerBlockedPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetBulkPlayerBlockedPlayersV1.cs) |
| [DEPRECATED] `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes` | GET | AdminGetAllPlayerSessionAttribute | [AdminGetAllPlayerSessionAttribute](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminGetAllPlayerSessionAttribute.cs) | [AdminGetAllPlayerSessionAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetAllPlayerSessionAttribute.cs) |
| [DEPRECATED] `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes` | PUT | AdminSetPlayerSessionAttribute | [AdminSetPlayerSessionAttribute](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminSetPlayerSessionAttribute.cs) | [AdminSetPlayerSessionAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminSetPlayerSessionAttribute.cs) |
| [DEPRECATED] `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/attributes/{attribute}` | GET | AdminGetPlayerSessionAttribute | [AdminGetPlayerSessionAttribute](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminGetPlayerSessionAttribute.cs) | [AdminGetPlayerSessionAttribute](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetPlayerSessionAttribute.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked` | GET | AdminGetPlayerBlockedPlayersV1 | [AdminGetPlayerBlockedPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminGetPlayerBlockedPlayersV1.cs) | [AdminGetPlayerBlockedPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetPlayerBlockedPlayersV1.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/blocked-by` | GET | AdminGetPlayerBlockedByPlayersV1 | [AdminGetPlayerBlockedByPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminGetPlayerBlockedByPlayersV1.cs) | [AdminGetPlayerBlockedByPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminGetPlayerBlockedByPlayersV1.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/bulk/block` | POST | AdminBulkBlockPlayersV1 | [AdminBulkBlockPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminBulkBlockPlayersV1.cs) | [AdminBulkBlockPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminBulkBlockPlayersV1.cs) |
| `/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/bulk/unblock` | DELETE | AdminBulkUnblockPlayersV1 | [AdminBulkUnblockPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/AdminBulkUnblockPlayersV1.cs) | [AdminBulkUnblockPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/AdminBulkUnblockPlayersV1.cs) |
| `/lobby/v1/public/player/namespaces/{namespace}/users/me/block` | POST | PublicPlayerBlockPlayersV1 | [PublicPlayerBlockPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/PublicPlayerBlockPlayersV1.cs) | [PublicPlayerBlockPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/PublicPlayerBlockPlayersV1.cs) |
| `/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked` | GET | PublicGetPlayerBlockedPlayersV1 | [PublicGetPlayerBlockedPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/PublicGetPlayerBlockedPlayersV1.cs) | [PublicGetPlayerBlockedPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/PublicGetPlayerBlockedPlayersV1.cs) |
| `/lobby/v1/public/player/namespaces/{namespace}/users/me/blocked-by` | GET | PublicGetPlayerBlockedByPlayersV1 | [PublicGetPlayerBlockedByPlayersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/PublicGetPlayerBlockedByPlayersV1.cs) | [PublicGetPlayerBlockedByPlayersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/PublicGetPlayerBlockedByPlayersV1.cs) |
| `/lobby/v1/public/player/namespaces/{namespace}/users/me/unblock` | POST | PublicUnblockPlayerV1 | [PublicUnblockPlayerV1](../../AccelByte.Sdk/Api/Lobby/Operation/Player/PublicUnblockPlayerV1.cs) | [PublicUnblockPlayerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Player/PublicUnblockPlayerV1.cs) |

### profanity Wrapper:  [Profanity](../../AccelByte.Sdk/Api/Lobby/Wrapper/Profanity.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/filters/debug` | POST | AdminDebugProfanityFilters | [AdminDebugProfanityFilters](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminDebugProfanityFilters.cs) | [AdminDebugProfanityFilters](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminDebugProfanityFilters.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters` | GET | AdminGetProfanityListFiltersV1 | [AdminGetProfanityListFiltersV1](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminGetProfanityListFiltersV1.cs) | [AdminGetProfanityListFiltersV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminGetProfanityListFiltersV1.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters` | POST | AdminAddProfanityFilterIntoList | [AdminAddProfanityFilterIntoList](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminAddProfanityFilterIntoList.cs) | [AdminAddProfanityFilterIntoList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminAddProfanityFilterIntoList.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk` | POST | AdminAddProfanityFilters | [AdminAddProfanityFilters](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminAddProfanityFilters.cs) | [AdminAddProfanityFilters](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminAddProfanityFilters.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/bulk-file` | POST | AdminImportProfanityFiltersFromFile | [AdminImportProfanityFiltersFromFile](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminImportProfanityFiltersFromFile.cs) | [AdminImportProfanityFiltersFromFile](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminImportProfanityFiltersFromFile.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/list/{list}/filters/delete` | POST | AdminDeleteProfanityFilter | [AdminDeleteProfanityFilter](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminDeleteProfanityFilter.cs) | [AdminDeleteProfanityFilter](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminDeleteProfanityFilter.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/lists` | GET | AdminGetProfanityLists | [AdminGetProfanityLists](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminGetProfanityLists.cs) | [AdminGetProfanityLists](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminGetProfanityLists.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/lists` | POST | AdminCreateProfanityList | [AdminCreateProfanityList](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminCreateProfanityList.cs) | [AdminCreateProfanityList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminCreateProfanityList.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}` | POST | AdminUpdateProfanityList | [AdminUpdateProfanityList](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminUpdateProfanityList.cs) | [AdminUpdateProfanityList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminUpdateProfanityList.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/lists/{list}` | DELETE | AdminDeleteProfanityList | [AdminDeleteProfanityList](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminDeleteProfanityList.cs) | [AdminDeleteProfanityList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminDeleteProfanityList.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/rule` | GET | AdminGetProfanityRule | [AdminGetProfanityRule](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminGetProfanityRule.cs) | [AdminGetProfanityRule](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminGetProfanityRule.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/rule` | POST | AdminSetProfanityRuleForNamespace | [AdminSetProfanityRuleForNamespace](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminSetProfanityRuleForNamespace.cs) | [AdminSetProfanityRuleForNamespace](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminSetProfanityRuleForNamespace.cs) |
| [DEPRECATED] `/lobby/v1/admin/profanity/namespaces/{namespace}/verify` | POST | AdminVerifyMessageProfanityResponse | [AdminVerifyMessageProfanityResponse](../../AccelByte.Sdk/Api/Lobby/Operation/Profanity/AdminVerifyMessageProfanityResponse.cs) | [AdminVerifyMessageProfanityResponse](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Profanity/AdminVerifyMessageProfanityResponse.cs) |

### thirdParty Wrapper:  [ThirdParty](../../AccelByte.Sdk/Api/Lobby/Wrapper/ThirdParty.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | GET | AdminGetThirdPartyConfig | [AdminGetThirdPartyConfig](../../AccelByte.Sdk/Api/Lobby/Operation/ThirdParty/AdminGetThirdPartyConfig.cs) | [AdminGetThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminGetThirdPartyConfig.cs) |
| [DEPRECATED] `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | PUT | AdminUpdateThirdPartyConfig | [AdminUpdateThirdPartyConfig](../../AccelByte.Sdk/Api/Lobby/Operation/ThirdParty/AdminUpdateThirdPartyConfig.cs) | [AdminUpdateThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminUpdateThirdPartyConfig.cs) |
| [DEPRECATED] `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | POST | AdminCreateThirdPartyConfig | [AdminCreateThirdPartyConfig](../../AccelByte.Sdk/Api/Lobby/Operation/ThirdParty/AdminCreateThirdPartyConfig.cs) | [AdminCreateThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminCreateThirdPartyConfig.cs) |
| [DEPRECATED] `/lobby/v1/admin/thirdparty/namespaces/{namespace}/config/steam` | DELETE | AdminDeleteThirdPartyConfig | [AdminDeleteThirdPartyConfig](../../AccelByte.Sdk/Api/Lobby/Operation/ThirdParty/AdminDeleteThirdPartyConfig.cs) | [AdminDeleteThirdPartyConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/ThirdParty/AdminDeleteThirdPartyConfig.cs) |

### presence Wrapper:  [Presence](../../AccelByte.Sdk/Api/Lobby/Wrapper/Presence.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/lobby/v1/public/presence/namespaces/{namespace}/users/presence` | GET | UsersPresenceHandlerV1 | [UsersPresenceHandlerV1](../../AccelByte.Sdk/Api/Lobby/Operation/Presence/UsersPresenceHandlerV1.cs) | [UsersPresenceHandlerV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Presence/UsersPresenceHandlerV1.cs) |
| `/lobby/v1/public/presence/namespaces/{namespace}/users/presence` | POST | UsersPresenceHandlerV2 | [UsersPresenceHandlerV2](../../AccelByte.Sdk/Api/Lobby/Operation/Presence/UsersPresenceHandlerV2.cs) | [UsersPresenceHandlerV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Presence/UsersPresenceHandlerV2.cs) |


&nbsp;  

## Operations with Generic Response

### friends Wrapper:  [Friends](../../AccelByte.Sdk/Api/Lobby/Wrapper/Friends.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### blocks Wrapper:  [Blocks](../../AccelByte.Sdk/Api/Lobby/Wrapper/Blocks.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### config Wrapper:  [Config](../../AccelByte.Sdk/Api/Lobby/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### admin Wrapper:  [Admin](../../AccelByte.Sdk/Api/Lobby/Wrapper/Admin.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### notification Wrapper:  [Notification](../../AccelByte.Sdk/Api/Lobby/Wrapper/Notification.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### party Wrapper:  [Party](../../AccelByte.Sdk/Api/Lobby/Wrapper/Party.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}` | GET | AdminGetPartyDataV1 | [AdminGetPartyDataV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/AdminGetPartyDataV1.cs) | [AdminGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetPartyDataV1.cs) |
| [DEPRECATED] `/lobby/v1/admin/party/namespaces/{namespace}/users/{userId}/party` | GET | AdminGetUserPartyV1 | [AdminGetUserPartyV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/AdminGetUserPartyV1.cs) | [AdminGetUserPartyV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/AdminGetUserPartyV1.cs) |
| [DEPRECATED] `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}` | GET | PublicGetPartyDataV1 | [PublicGetPartyDataV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/PublicGetPartyDataV1.cs) | [PublicGetPartyDataV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicGetPartyDataV1.cs) |
| [DEPRECATED] `/lobby/v1/public/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | PublicUpdatePartyAttributesV1 | [PublicUpdatePartyAttributesV1](../../AccelByte.Sdk/Api/Lobby/Operation/Party/PublicUpdatePartyAttributesV1.cs) | [PublicUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/Party/PublicUpdatePartyAttributesV1.cs) |

### Lobby Operations Wrapper:  [LobbyOperations](../../AccelByte.Sdk/Api/Lobby/Wrapper/LobbyOperations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/lobby/v1/admin/party/namespaces/{namespace}/parties/{partyId}/attributes` | PUT | AdminUpdatePartyAttributesV1 | [AdminUpdatePartyAttributesV1](../../AccelByte.Sdk/Api/Lobby/Operation/LobbyOperations/AdminUpdatePartyAttributesV1.cs) | [AdminUpdatePartyAttributesV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Lobby/LobbyOperations/AdminUpdatePartyAttributesV1.cs) |

### player Wrapper:  [Player](../../AccelByte.Sdk/Api/Lobby/Wrapper/Player.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### profanity Wrapper:  [Profanity](../../AccelByte.Sdk/Api/Lobby/Wrapper/Profanity.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### thirdParty Wrapper:  [ThirdParty](../../AccelByte.Sdk/Api/Lobby/Wrapper/ThirdParty.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### presence Wrapper:  [Presence](../../AccelByte.Sdk/Api/Lobby/Wrapper/Presence.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `handlers.GetUsersPresenceResponse` | [HandlersGetUsersPresenceResponse](../../AccelByte.Sdk/Api/Lobby/Model/HandlersGetUsersPresenceResponse.cs) |
| `handlers.UserPresence` | [HandlersUserPresence](../../AccelByte.Sdk/Api/Lobby/Model/HandlersUserPresence.cs) |
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../AccelByte.Sdk/Api/Lobby/Model/LogAppMessageDeclaration.cs) |
| `logconfig.Configuration` | [LogconfigConfiguration](../../AccelByte.Sdk/Api/Lobby/Model/LogconfigConfiguration.cs) |
| `model.BulkFriendsRequest` | [ModelBulkFriendsRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelBulkFriendsRequest.cs) |
| `model.BulkFriendsResponse` | [ModelBulkFriendsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelBulkFriendsResponse.cs) |
| `model.BulkUsersFreeFormNotificationRequestV1` | [ModelBulkUsersFreeFormNotificationRequestV1](../../AccelByte.Sdk/Api/Lobby/Model/ModelBulkUsersFreeFormNotificationRequestV1.cs) |
| `model.CreateTemplateRequest` | [ModelCreateTemplateRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelCreateTemplateRequest.cs) |
| `model.CreateTopicRequest` | [ModelCreateTopicRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelCreateTopicRequest.cs) |
| `model.CreateTopicRequestV1` | [ModelCreateTopicRequestV1](../../AccelByte.Sdk/Api/Lobby/Model/ModelCreateTopicRequestV1.cs) |
| `model.FreeFormNotificationRequest` | [ModelFreeFormNotificationRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelFreeFormNotificationRequest.cs) |
| `model.FreeFormNotificationRequestV1` | [ModelFreeFormNotificationRequestV1](../../AccelByte.Sdk/Api/Lobby/Model/ModelFreeFormNotificationRequestV1.cs) |
| `model.FriendWithPlatform` | [ModelFriendWithPlatform](../../AccelByte.Sdk/Api/Lobby/Model/ModelFriendWithPlatform.cs) |
| `model.FriendshipConnection` | [ModelFriendshipConnection](../../AccelByte.Sdk/Api/Lobby/Model/ModelFriendshipConnection.cs) |
| `model.FriendshipConnectionResponse` | [ModelFriendshipConnectionResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelFriendshipConnectionResponse.cs) |
| `model.GetAllNotificationTemplateSlugResp` | [ModelGetAllNotificationTemplateSlugResp](../../AccelByte.Sdk/Api/Lobby/Model/ModelGetAllNotificationTemplateSlugResp.cs) |
| `model.GetAllNotificationTopicsResponse` | [ModelGetAllNotificationTopicsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelGetAllNotificationTopicsResponse.cs) |
| `model.GetFriendsResponse` | [ModelGetFriendsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelGetFriendsResponse.cs) |
| `model.GetUserFriendsResponse` | [ModelGetUserFriendsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelGetUserFriendsResponse.cs) |
| `model.GetUserIncomingFriendsResponse` | [ModelGetUserIncomingFriendsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelGetUserIncomingFriendsResponse.cs) |
| `model.GetUserOutgoingFriendsResponse` | [ModelGetUserOutgoingFriendsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelGetUserOutgoingFriendsResponse.cs) |
| `model.GlobalConfiguration` | [ModelGlobalConfiguration](../../AccelByte.Sdk/Api/Lobby/Model/ModelGlobalConfiguration.cs) |
| `model.IncomingFriendsWithTimeData` | [ModelIncomingFriendsWithTimeData](../../AccelByte.Sdk/Api/Lobby/Model/ModelIncomingFriendsWithTimeData.cs) |
| `model.ListBulkUserPlatformsResponse` | [ModelListBulkUserPlatformsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelListBulkUserPlatformsResponse.cs) |
| `model.LoadIncomingFriendsWithTimeResponse` | [ModelLoadIncomingFriendsWithTimeResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelLoadIncomingFriendsWithTimeResponse.cs) |
| `model.LoadOutgoingFriendsWithTimeResponse` | [ModelLoadOutgoingFriendsWithTimeResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelLoadOutgoingFriendsWithTimeResponse.cs) |
| `model.Localization` | [ModelLocalization](../../AccelByte.Sdk/Api/Lobby/Model/ModelLocalization.cs) |
| `model.NativeFriendRequest` | [ModelNativeFriendRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelNativeFriendRequest.cs) |
| `model.NativeFriendSyncResponse` | [ModelNativeFriendSyncResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelNativeFriendSyncResponse.cs) |
| `model.NativeUserBlockRequest` | [ModelNativeUserBlockRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelNativeUserBlockRequest.cs) |
| `model.NativeUserBlockResponse` | [ModelNativeUserBlockResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelNativeUserBlockResponse.cs) |
| `model.Notification` | [ModelNotification](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotification.cs) |
| `model.NotificationResponse` | [ModelNotificationResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationResponse.cs) |
| `model.NotificationTemplateResponse` | [ModelNotificationTemplateResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationTemplateResponse.cs) |
| `model.NotificationTopicResponse` | [ModelNotificationTopicResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationTopicResponse.cs) |
| `model.NotificationTopicResponseV1` | [ModelNotificationTopicResponseV1](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationTopicResponseV1.cs) |
| `model.NotificationWithTemplateRequest` | [ModelNotificationWithTemplateRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationWithTemplateRequest.cs) |
| `model.NotificationWithTemplateRequestV1` | [ModelNotificationWithTemplateRequestV1](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationWithTemplateRequestV1.cs) |
| `model.NotificationsResponse` | [ModelNotificationsResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelNotificationsResponse.cs) |
| `model.OutgoingFriendsWithTimeData` | [ModelOutgoingFriendsWithTimeData](../../AccelByte.Sdk/Api/Lobby/Model/ModelOutgoingFriendsWithTimeData.cs) |
| `model.Pagination` | [ModelPagination](../../AccelByte.Sdk/Api/Lobby/Model/ModelPagination.cs) |
| `model.PutGlobalConfigurationRequest` | [ModelPutGlobalConfigurationRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelPutGlobalConfigurationRequest.cs) |
| `model.RequestUserPresence` | [ModelRequestUserPresence](../../AccelByte.Sdk/Api/Lobby/Model/ModelRequestUserPresence.cs) |
| `model.TemplateContent` | [ModelTemplateContent](../../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateContent.cs) |
| `model.TemplateLocalization` | [ModelTemplateLocalization](../../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateLocalization.cs) |
| `model.TemplateLocalizationResponse` | [ModelTemplateLocalizationResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateLocalizationResponse.cs) |
| `model.TemplateResponse` | [ModelTemplateResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelTemplateResponse.cs) |
| `model.TopicByNamespacesResponse` | [ModelTopicByNamespacesResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelTopicByNamespacesResponse.cs) |
| `model.UpdateTemplateRequest` | [ModelUpdateTemplateRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelUpdateTemplateRequest.cs) |
| `model.UpdateTopicRequest` | [ModelUpdateTopicRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelUpdateTopicRequest.cs) |
| `model.UserAcceptFriendRequest` | [ModelUserAcceptFriendRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserAcceptFriendRequest.cs) |
| `model.UserCancelFriendRequest` | [ModelUserCancelFriendRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserCancelFriendRequest.cs) |
| `model.UserGetFriendshipStatusResponse` | [ModelUserGetFriendshipStatusResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserGetFriendshipStatusResponse.cs) |
| `model.UserPlatformInfo` | [ModelUserPlatformInfo](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserPlatformInfo.cs) |
| `model.UserRejectFriendRequest` | [ModelUserRejectFriendRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserRejectFriendRequest.cs) |
| `model.UserRequestFriendRequest` | [ModelUserRequestFriendRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserRequestFriendRequest.cs) |
| `model.UserUnfriendRequest` | [ModelUserUnfriendRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserUnfriendRequest.cs) |
| `model.UserWithPlatformInfo` | [ModelUserWithPlatformInfo](../../AccelByte.Sdk/Api/Lobby/Model/ModelUserWithPlatformInfo.cs) |
| `models.AdminAddProfanityFilterIntoListRequest` | [ModelsAdminAddProfanityFilterIntoListRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminAddProfanityFilterIntoListRequest.cs) |
| `models.AdminAddProfanityFiltersFilterRequest` | [ModelsAdminAddProfanityFiltersFilterRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminAddProfanityFiltersFilterRequest.cs) |
| `models.AdminAddProfanityFiltersRequest` | [ModelsAdminAddProfanityFiltersRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminAddProfanityFiltersRequest.cs) |
| `models.AdminCreateProfanityListRequest` | [ModelsAdminCreateProfanityListRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminCreateProfanityListRequest.cs) |
| `models.AdminDeleteProfanityFilterRequest` | [ModelsAdminDeleteProfanityFilterRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminDeleteProfanityFilterRequest.cs) |
| `models.AdminGetProfanityListFiltersV1Response` | [ModelsAdminGetProfanityListFiltersV1Response](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminGetProfanityListFiltersV1Response.cs) |
| `models.AdminGetProfanityListsListResponse` | [ModelsAdminGetProfanityListsListResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminGetProfanityListsListResponse.cs) |
| `models.AdminSetProfanityRuleForNamespaceRequest` | [ModelsAdminSetProfanityRuleForNamespaceRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminSetProfanityRuleForNamespaceRequest.cs) |
| `models.AdminUpdateProfanityList` | [ModelsAdminUpdateProfanityList](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminUpdateProfanityList.cs) |
| `models.AdminVerifyMessageProfanityRequest` | [ModelsAdminVerifyMessageProfanityRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminVerifyMessageProfanityRequest.cs) |
| `models.AdminVerifyMessageProfanityResponse` | [ModelsAdminVerifyMessageProfanityResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsAdminVerifyMessageProfanityResponse.cs) |
| `models.BlockPlayerRequest` | [ModelsBlockPlayerRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsBlockPlayerRequest.cs) |
| `models.BlockedByPlayerData` | [ModelsBlockedByPlayerData](../../AccelByte.Sdk/Api/Lobby/Model/ModelsBlockedByPlayerData.cs) |
| `models.BlockedPlayerData` | [ModelsBlockedPlayerData](../../AccelByte.Sdk/Api/Lobby/Model/ModelsBlockedPlayerData.cs) |
| `models.Config` | [ModelsConfig](../../AccelByte.Sdk/Api/Lobby/Model/ModelsConfig.cs) |
| `models.ConfigList` | [ModelsConfigList](../../AccelByte.Sdk/Api/Lobby/Model/ModelsConfigList.cs) |
| `models.ConfigReq` | [ModelsConfigReq](../../AccelByte.Sdk/Api/Lobby/Model/ModelsConfigReq.cs) |
| `models.CreateConfigRequest` | [ModelsCreateConfigRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsCreateConfigRequest.cs) |
| `models.CreateConfigResponse` | [ModelsCreateConfigResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsCreateConfigResponse.cs) |
| `models.DebugProfanityFilterRequest` | [ModelsDebugProfanityFilterRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsDebugProfanityFilterRequest.cs) |
| `models.GetAllPlayerBlockedByUsersResponse` | [ModelsGetAllPlayerBlockedByUsersResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetAllPlayerBlockedByUsersResponse.cs) |
| `models.GetAllPlayerBlockedUsersResponse` | [ModelsGetAllPlayerBlockedUsersResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetAllPlayerBlockedUsersResponse.cs) |
| `models.GetAllPlayerSessionAttributeResponse` | [ModelsGetAllPlayerSessionAttributeResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetAllPlayerSessionAttributeResponse.cs) |
| `models.GetBulkAllPlayerBlockedUsersRequest` | [ModelsGetBulkAllPlayerBlockedUsersRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetBulkAllPlayerBlockedUsersRequest.cs) |
| `models.GetBulkAllPlayerBlockedUsersResponse` | [ModelsGetBulkAllPlayerBlockedUsersResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetBulkAllPlayerBlockedUsersResponse.cs) |
| `models.GetConfigResponse` | [ModelsGetConfigResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetConfigResponse.cs) |
| `models.GetLobbyCcuResponse` | [ModelsGetLobbyCcuResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetLobbyCcuResponse.cs) |
| `models.GetPlayerSessionAttributeResponse` | [ModelsGetPlayerSessionAttributeResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsGetPlayerSessionAttributeResponse.cs) |
| `models.ImportConfigResponse` | [ModelsImportConfigResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsImportConfigResponse.cs) |
| `models.ListBlockedPlayerRequest` | [ModelsListBlockedPlayerRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsListBlockedPlayerRequest.cs) |
| `models.ListUnblockPlayerRequest` | [ModelsListUnblockPlayerRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsListUnblockPlayerRequest.cs) |
| `models.PartyData` | [ModelsPartyData](../../AccelByte.Sdk/Api/Lobby/Model/ModelsPartyData.cs) |
| `models.PartyPUTCustomAttributesRequest` | [ModelsPartyPUTCustomAttributesRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsPartyPUTCustomAttributesRequest.cs) |
| `models.PartyPUTLimitSizeRequest` | [ModelsPartyPUTLimitSizeRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsPartyPUTLimitSizeRequest.cs) |
| `models.ProfanityFilter` | [ModelsProfanityFilter](../../AccelByte.Sdk/Api/Lobby/Model/ModelsProfanityFilter.cs) |
| `models.ProfanityRule` | [ModelsProfanityRule](../../AccelByte.Sdk/Api/Lobby/Model/ModelsProfanityRule.cs) |
| `models.SetPlayerSessionAttributeRequest` | [ModelsSetPlayerSessionAttributeRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsSetPlayerSessionAttributeRequest.cs) |
| `models.UnblockPlayerRequest` | [ModelsUnblockPlayerRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsUnblockPlayerRequest.cs) |
| `models.UpdateConfigRequest` | [ModelsUpdateConfigRequest](../../AccelByte.Sdk/Api/Lobby/Model/ModelsUpdateConfigRequest.cs) |
| `models.UpdateConfigResponse` | [ModelsUpdateConfigResponse](../../AccelByte.Sdk/Api/Lobby/Model/ModelsUpdateConfigResponse.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Lobby/Model/ResponseError.cs) |
| `restapi.ErrorResponseBody` | [RestapiErrorResponseBody](../../AccelByte.Sdk/Api/Lobby/Model/RestapiErrorResponseBody.cs) |
| `restapi.ErrorResponseV1` | [RestapiErrorResponseV1](../../AccelByte.Sdk/Api/Lobby/Model/RestapiErrorResponseV1.cs) |
