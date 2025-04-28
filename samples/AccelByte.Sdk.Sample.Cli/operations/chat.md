## C# Extend SDK CLI Sample App Operation Index for Chat service.

### Operation AdminFilterChatMessage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminfilterchatmessage \
    --namespace <namespace value> \
    --detail <detail value - optional> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminChatHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminchathistory \
    --namespace <namespace value> \
    --chatId <chatId value - optional> \
    --endCreatedAt <endCreatedAt value - optional> \
    --keyword <keyword value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --senderUserId <senderUserId value - optional> \
    --shardId <shardId value - optional> \
    --startCreatedAt <startCreatedAt value - optional> \
    --topic <topic value - optional> \
    --unfiltered <unfiltered value - optional>
```

### Operation AdminCreateNamespaceTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admincreatenamespacetopic \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminTopicList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admintopiclist \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --topicType <topicType value - optional>
```

### Operation AdminCreateTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admincreatetopic \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminChannelTopicList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminchanneltopiclist \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --topicName <topicName value - optional>
```

### Operation AdminChannelTopicSummary
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminchanneltopicsummary \
    --namespace <namespace value>
```

### Operation AdminQueryTopicLog
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminquerytopiclog \
    --namespace <namespace value> \
    --endCreatedAt <endCreatedAt value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --senderUserId <senderUserId value - optional> \
    --startCreatedAt <startCreatedAt value - optional> \
    --topicId <topicId value - optional> \
    --topicIds <topicIds value - optional> \
    --userId <userId value - optional>
```

### Operation AdminUpdateTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminupdatetopic \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admindeletetopic \
    --namespace <namespace value> \
    --topic <topic value>
```

### Operation AdminBanTopicMembers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminbantopicmembers \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminChannelTopicInfo
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminchanneltopicinfo \
    --namespace <namespace value> \
    --topic <topic value>
```

### Operation AdminSendChat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminsendchat \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteChat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admindeletechat \
    --chatId <chatId value> \
    --namespace <namespace value> \
    --topic <topic value>
```

### Operation AdminTopicMembers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admintopicmembers \
    --namespace <namespace value> \
    --topic <topic value> \
    --isBanned <isBanned value - optional> \
    --isModerator <isModerator value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --shardId <shardId value - optional>
```

### Operation AdminTopicShards
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admintopicshards \
    --namespace <namespace value> \
    --topic <topic value>
```

### Operation AdminUnbanTopicMembers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminunbantopicmembers \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminAddTopicMember
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminaddtopicmember \
    --namespace <namespace value> \
    --topic <topic value> \
    --userId <userId value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminRemoveTopicMember
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminremovetopicmember \
    --namespace <namespace value> \
    --topic <topic value> \
    --userId <userId value>
```

### Operation AdminQueryTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminquerytopic \
    --namespace <namespace value> \
    --includeMembers <includeMembers value - optional> \
    --includePastMembers <includePastMembers value - optional> \
    --includePastTopics <includePastTopics value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --topic <topic value - optional> \
    --topicSubType <topicSubType value - optional> \
    --topicType <topicType value - optional> \
    --userId <userId value - optional>
```

### Operation AdminQueryUsersTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminqueryuserstopic \
    --namespace <namespace value> \
    --userId <userId value> \
    --includePastTopics <includePastTopics value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --topicSubType <topicSubType value - optional> \
    --topicType <topicType value - optional>
```

### Operation PublicGetMutedTopics
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicgetmutedtopics \
    --namespace <namespace value>
```

### Operation PublicTopicList
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publictopiclist \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --topicType <topicType value - optional>
```

### Operation PublicBanTopicMembers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicbantopicmembers \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicChatHistory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicchathistory \
    --namespace <namespace value> \
    --topic <topic value> \
    --limit <limit value - optional> \
    --order <order value - optional> \
    --startCreatedAt <startCreatedAt value - optional>
```

### Operation PublicDeleteChat
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicdeletechat \
    --chatId <chatId value> \
    --namespace <namespace value> \
    --topic <topic value>
```

### Operation PublicMuteUser
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicmuteuser \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUnbanTopicMembers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicunbantopicmembers \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation PublicUnmuteUser
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicunmuteuser \
    --namespace <namespace value> \
    --topic <topic value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetAllConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetallconfigv1 \

```

### Operation AdminGetLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetlogconfig \

```

### Operation AdminPatchUpdateLogConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminpatchupdatelogconfig \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetconfigv1 \
    --namespace <namespace value>
```

### Operation AdminUpdateConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminupdateconfigv1 \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation ExportConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op exportconfig \
    --namespace <namespace value>
```

### Operation ImportConfig
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op importconfig \
    --namespace <namespace value> \
    --upload file <file to upload>
```

### Operation AdminGetInboxCategories
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetinboxcategories \
    --namespace <namespace value>
```

### Operation AdminAddInboxCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminaddinboxcategory \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminDeleteInboxCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admindeleteinboxcategory \
    --category <category value> \
    --namespace <namespace value>
```

### Operation AdminUpdateInboxCategory
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminupdateinboxcategory \
    --category <category value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetCategorySchema
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetcategoryschema \
    --category <category value> \
    --namespace <namespace value>
```

### Operation AdminListKafkaTopic
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminlistkafkatopic \
    --namespace <namespace value>
```

### Operation AdminDeleteInboxMessage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admindeleteinboxmessage \
    --messageId <messageId value> \
    --namespace <namespace value> \
    --force <force value - optional>
```

### Operation AdminGetInboxMessages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetinboxmessages \
    --namespace <namespace value> \
    --activeOnly <activeOnly value - optional> \
    --endCreatedAt <endCreatedAt value - optional> \
    --limit <limit value - optional> \
    --messageId <messageId value - optional> \
    --offset <offset value - optional> \
    --order <order value - optional> \
    --scope <scope value - optional> \
    --startCreatedAt <startCreatedAt value - optional> \
    --status <status value - optional> \
    --transient <transient value - optional>
```

### Operation AdminSaveInboxMessage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminsaveinboxmessage \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminUnsendInboxMessage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminunsendinboxmessage \
    --inbox <inbox value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetInboxUsers
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetinboxusers \
    --inbox <inbox value> \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --status <status value - optional> \
    --userId <userId value - optional>
```

### Operation AdminUpdateInboxMessage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminupdateinboxmessage \
    --messageId <messageId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminSendInboxMessage
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminsendinboxmessage \
    --messageId <messageId value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminGetInboxStats
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetinboxstats \
    --namespace <namespace value> \
    --messageId <messageId value - optional>
```

### Operation AdminGetChatSnapshot
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admingetchatsnapshot \
    --chatId <chatId value> \
    --namespace <namespace value>
```

### Operation AdminDeleteChatSnapshot
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op admindeletechatsnapshot \
    --chatId <chatId value> \
    --namespace <namespace value>
```

### Operation AdminProfanityQuery
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanityquery \
    --namespace <namespace value> \
    --filterMask <filterMask value - optional> \
    --includeChildren <includeChildren value - optional> \
    --limit <limit value - optional> \
    --offset <offset value - optional> \
    --parentId <parentId value - optional> \
    --startWith <startWith value - optional> \
    --wordType <wordType value - optional>
```

### Operation AdminProfanityCreate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanitycreate \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminProfanityCreateBulk
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanitycreatebulk \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminProfanityExport
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanityexport \
    --namespace <namespace value>
```

### Operation AdminProfanityGroup
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanitygroup \
    --namespace <namespace value> \
    --limit <limit value - optional> \
    --offset <offset value - optional>
```

### Operation AdminProfanityImport
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanityimport \
    --namespace <namespace value> \
    --action <action value - optional> \
    --showResult <showResult value - optional> \
    --upload file <file to upload>
```

### Operation AdminProfanityUpdate
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanityupdate \
    --id <id value> \
    --namespace <namespace value> \
    --reqbody <json string for request body>
```
To set request body using JSON file, replace `--reqbody` argument with `--reqfile <json file>`.

### Operation AdminProfanityDelete
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op adminprofanitydelete \
    --id <id value> \
    --namespace <namespace value>
```

### Operation PublicGetMessages
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicgetmessages \

```

### Operation PublicGetConfigV1
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicgetconfigv1 \
    --namespace <namespace value>
```

### Operation PublicGetChatSnapshot
```sh
$ AccelByte.Sdk.Sample.Cli.exe \
    --sn chat \
    --op publicgetchatsnapshot \
    --chatId <chatId value> \
    --namespace <namespace value> \
    --topic <topic value>
```

