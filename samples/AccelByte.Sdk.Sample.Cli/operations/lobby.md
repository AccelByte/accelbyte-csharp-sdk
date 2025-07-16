## C# Extend SDK CLI Sample App Operation Index for Lobby service.

### Operation GetUserFriendsUpdated
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getuserfriendsupdated \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserIncomingFriends
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getuserincomingfriends \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserIncomingFriendsWithTime
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getuserincomingfriendswithtime \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserOutgoingFriends
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getuseroutgoingfriends \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserOutgoingFriendsWithTime
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getuseroutgoingfriendswithtime \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetUserFriendsWithPlatform
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getuserfriendswithplatform \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation UserRequestFriend
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op userrequestfriend \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UserAcceptFriendRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op useracceptfriendrequest \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UserCancelFriendRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op usercancelfriendrequest \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UserRejectFriendRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op userrejectfriendrequest \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UserGetFriendshipStatus
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op usergetfriendshipstatus \
    --friendId <friendId value> \
    --namespace <namespace value>
```

### Operation UserUnfriendRequest
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op userunfriendrequest \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AddFriendsWithoutConfirmation
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op addfriendswithoutconfirmation \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation BulkDeleteFriends
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op bulkdeletefriends \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncNativeFriends
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op syncnativefriends \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SyncNativeBlockedUser
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op syncnativeblockeduser \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAllConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op admingetallconfigv1 \

```

### Operation AdminGetLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op admingetlogconfig \

```

### Operation AdminPatchUpdateLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op adminpatchupdatelogconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op admingetconfigv1 \
    --namespace <namespace value>
```

### Operation AdminUpdateConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op adminupdateconfigv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminExportConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op adminexportconfigv1 \
    --namespace <namespace value>
```

### Operation AdminImportConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op adminimportconfigv1 \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation GetListOfFriends
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getlistoffriends \
    --namespace <namespace value> \
    --userId <userId value> \
    --friendId <friendId value - optional> \
    --friendIds <friendIds value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation GetIncomingFriendRequests
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getincomingfriendrequests \
    --namespace <namespace value> \
    --userId <userId value> \
    --friendId <friendId value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminListFriendsOfFriends
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op adminlistfriendsoffriends \
    --namespace <namespace value> \
    --userId <userId value> \
    --friendId <friendId value - optional> \
    --limit <limit value - optional> \
    --nopaging <nopaging value - optional> \
    --offset <offset value - optional>
```

### Operation GetOutgoingFriendRequests
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getoutgoingfriendrequests \
    --namespace <namespace value> \
    --userId <userId value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation SendMultipleUsersFreeformNotificationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op sendmultipleusersfreeformnotificationv1admin \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SendUsersFreeformNotificationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op sendusersfreeformnotificationv1admin \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetAllNotificationTemplatesV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getallnotificationtemplatesv1admin \
    --namespace <namespace value>
```

### Operation CreateNotificationTemplateV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op createnotificationtemplatev1admin \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SendUsersTemplatedNotificationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op senduserstemplatednotificationv1admin \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetTemplateSlugLocalizationsTemplateV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op gettemplatesluglocalizationstemplatev1admin \
    --namespace <namespace value> \
    --templateSlug <templateSlug value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation DeleteNotificationTemplateSlugV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op deletenotificationtemplateslugv1admin \
    --namespace <namespace value> \
    --templateSlug <templateSlug value>
```

### Operation GetSingleTemplateLocalizationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getsingletemplatelocalizationv1admin \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value>
```

### Operation UpdateTemplateLocalizationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op updatetemplatelocalizationv1admin \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteTemplateLocalizationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op deletetemplatelocalizationv1admin \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value>
```

### Operation PublishTemplateLocalizationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op publishtemplatelocalizationv1admin \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value>
```

### Operation GetAllNotificationTopicsV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getallnotificationtopicsv1admin \
    --namespace <namespace value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation CreateNotificationTopicV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op createnotificationtopicv1admin \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetNotificationTopicV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getnotificationtopicv1admin \
    --namespace <namespace value> \
    --topicName <topicName value>
```

### Operation UpdateNotificationTopicV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op updatenotificationtopicv1admin \
    --namespace <namespace value> \
    --topicName <topicName value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteNotificationTopicV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op deletenotificationtopicv1admin \
    --namespace <namespace value> \
    --topicName <topicName value>
```

### Operation SendSpecificUserFreeformNotificationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op sendspecificuserfreeformnotificationv1admin \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation SendSpecificUserTemplatedNotificationV1Admin
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op sendspecificusertemplatednotificationv1admin \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetLobbyCCU
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op admingetlobbyccu \
    --namespace <namespace value>
```

### Operation AdminGetBulkPlayerBlockedPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op admingetbulkplayerblockedplayersv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetPlayerBlockedPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op admingetplayerblockedplayersv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminGetPlayerBlockedByPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op admingetplayerblockedbyplayersv1 \
    --namespace <namespace value> \
    --userId <userId value>
```

### Operation AdminBulkBlockPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op adminbulkblockplayersv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminBulkUnblockPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op adminbulkunblockplayersv1 \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetMessages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op publicgetmessages \

```

### Operation PublicPlayerBlockPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op publicplayerblockplayersv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicGetPlayerBlockedPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op publicgetplayerblockedplayersv1 \
    --namespace <namespace value>
```

### Operation PublicGetPlayerBlockedByPlayersV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op publicgetplayerblockedbyplayersv1 \
    --namespace <namespace value>
```

### Operation PublicUnblockPlayerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op publicunblockplayerv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation UsersPresenceHandlerV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op userspresencehandlerv1 \
    --namespace <namespace value> \
    --countOnly <countOnly value - optional> \
    --userIds <userIds value>
```

### Operation UsersPresenceHandlerV2
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op userspresencehandlerv2 \
    --namespace <namespace value> \
    --countOnly <countOnly value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation FreeFormNotification
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op freeformnotification \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetMyNotifications
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getmynotifications \
    --namespace <namespace value> \
    --endTime <endTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startTime <startTime value - optional>
```

### Operation GetMyOfflineNotifications
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getmyofflinenotifications \
    --namespace <namespace value> \
    --endTime <endTime value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --startTime <startTime value - optional>
```

### Operation NotificationWithTemplate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op notificationwithtemplate \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetGameTemplate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getgametemplate \
    --namespace <namespace value>
```

### Operation CreateTemplate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op createtemplate \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetSlugTemplate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getslugtemplate \
    --namespace <namespace value> \
    --templateSlug <templateSlug value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation DeleteTemplateSlug
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op deletetemplateslug \
    --namespace <namespace value> \
    --templateSlug <templateSlug value>
```

### Operation GetLocalizationTemplate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op getlocalizationtemplate \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value>
```

### Operation UpdateLocalizationTemplate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op updatelocalizationtemplate \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteTemplateLocalization
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op deletetemplatelocalization \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value>
```

### Operation PublishTemplate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op publishtemplate \
    --namespace <namespace value> \
    --templateLanguage <templateLanguage value> \
    --templateSlug <templateSlug value>
```

### Operation GetTopicByNamespace
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op gettopicbynamespace \
    --namespace <namespace value> \
    --after <after value - optional> \
    --before <before value - optional> \
    --limit <limit value - optional>
```

### Operation CreateTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op createtopic \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation GetTopicByTopicName
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op gettopicbytopicname \
    --namespace <namespace value> \
    --topic <topic value>
```

### Operation UpdateTopicByTopicName
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op updatetopicbytopicname \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation DeleteTopicByTopicName
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op deletetopicbytopicname \
    --namespace <namespace value> \
    --topic <topic value>
```

### Operation FreeFormNotificationByUserID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op freeformnotificationbyuserid \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation NotificationWithTemplateByUserID
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn lobby \
    --op notificationwithtemplatebyuserid \
    --namespace <namespace value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

