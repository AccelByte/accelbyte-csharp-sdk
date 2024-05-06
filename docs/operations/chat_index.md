# Chat Service Index

&nbsp;  

## Operations

### topic Wrapper:  [Topic](../../AccelByte.Sdk/Api/Chat/Wrapper/Topic.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/admin/namespaces/{namespace}/chat/filter` | POST | AdminFilterChatMessage | [AdminFilterChatMessage](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminFilterChatMessage.cs) | [AdminFilterChatMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminFilterChatMessage.cs) |
| `/chat/admin/namespaces/{namespace}/chats` | GET | AdminChatHistory | [AdminChatHistory](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminChatHistory.cs) | [AdminChatHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminChatHistory.cs) |
| `/chat/admin/namespaces/{namespace}/namespace-topic` | POST | AdminCreateNamespaceTopic | [AdminCreateNamespaceTopic](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminCreateNamespaceTopic.cs) | [AdminCreateNamespaceTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminCreateNamespaceTopic.cs) |
| `/chat/admin/namespaces/{namespace}/topic` | GET | AdminTopicList | [AdminTopicList](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminTopicList.cs) | [AdminTopicList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminTopicList.cs) |
| `/chat/admin/namespaces/{namespace}/topic` | POST | AdminCreateTopic | [AdminCreateTopic](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminCreateTopic.cs) | [AdminCreateTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminCreateTopic.cs) |
| `/chat/admin/namespaces/{namespace}/topic/channel` | GET | AdminChannelTopicList | [AdminChannelTopicList](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminChannelTopicList.cs) | [AdminChannelTopicList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminChannelTopicList.cs) |
| `/chat/admin/namespaces/{namespace}/topic/channel/summary` | GET | AdminChannelTopicSummary | [AdminChannelTopicSummary](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminChannelTopicSummary.cs) | [AdminChannelTopicSummary](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminChannelTopicSummary.cs) |
| `/chat/admin/namespaces/{namespace}/topic/log` | GET | AdminQueryTopicLog | [AdminQueryTopicLog](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminQueryTopicLog.cs) | [AdminQueryTopicLog](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminQueryTopicLog.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}` | PUT | AdminUpdateTopic | [AdminUpdateTopic](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminUpdateTopic.cs) | [AdminUpdateTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminUpdateTopic.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}` | DELETE | AdminDeleteTopic | [AdminDeleteTopic](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminDeleteTopic.cs) | [AdminDeleteTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminDeleteTopic.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/ban-members` | POST | AdminBanTopicMembers | [AdminBanTopicMembers](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminBanTopicMembers.cs) | [AdminBanTopicMembers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminBanTopicMembers.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/channel` | GET | AdminChannelTopicInfo | [AdminChannelTopicInfo](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminChannelTopicInfo.cs) | [AdminChannelTopicInfo](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminChannelTopicInfo.cs) |
| [DEPRECATED] `/chat/admin/namespaces/{namespace}/topic/{topic}/chats` | GET | AdminTopicChatHistory | [AdminTopicChatHistory](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminTopicChatHistory.cs) | [AdminTopicChatHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminTopicChatHistory.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/chats` | POST | AdminSendChat | [AdminSendChat](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminSendChat.cs) | [AdminSendChat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminSendChat.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/chats/{chatId}` | DELETE | AdminDeleteChat | [AdminDeleteChat](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminDeleteChat.cs) | [AdminDeleteChat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminDeleteChat.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/members` | GET | AdminTopicMembers | [AdminTopicMembers](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminTopicMembers.cs) | [AdminTopicMembers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminTopicMembers.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/shards` | GET | AdminTopicShards | [AdminTopicShards](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminTopicShards.cs) | [AdminTopicShards](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminTopicShards.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/unban-members` | POST | AdminUnbanTopicMembers | [AdminUnbanTopicMembers](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminUnbanTopicMembers.cs) | [AdminUnbanTopicMembers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminUnbanTopicMembers.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/user/{userId}` | POST | AdminAddTopicMember | [AdminAddTopicMember](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminAddTopicMember.cs) | [AdminAddTopicMember](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminAddTopicMember.cs) |
| `/chat/admin/namespaces/{namespace}/topic/{topic}/user/{userId}` | DELETE | AdminRemoveTopicMember | [AdminRemoveTopicMember](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminRemoveTopicMember.cs) | [AdminRemoveTopicMember](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminRemoveTopicMember.cs) |
| `/chat/admin/namespaces/{namespace}/topics` | GET | AdminQueryTopic | [AdminQueryTopic](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminQueryTopic.cs) | [AdminQueryTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminQueryTopic.cs) |
| `/chat/admin/namespaces/{namespace}/users/{userId}/topics` | GET | AdminQueryUsersTopic | [AdminQueryUsersTopic](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminQueryUsersTopic.cs) | [AdminQueryUsersTopic](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminQueryUsersTopic.cs) |
| `/chat/public/namespaces/{namespace}/muted` | GET | PublicGetMutedTopics | [PublicGetMutedTopics](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicGetMutedTopics.cs) | [PublicGetMutedTopics](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicGetMutedTopics.cs) |
| `/chat/public/namespaces/{namespace}/topic` | GET | PublicTopicList | [PublicTopicList](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicTopicList.cs) | [PublicTopicList](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicTopicList.cs) |
| `/chat/public/namespaces/{namespace}/topic/{topic}/ban-members` | POST | PublicBanTopicMembers | [PublicBanTopicMembers](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicBanTopicMembers.cs) | [PublicBanTopicMembers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicBanTopicMembers.cs) |
| `/chat/public/namespaces/{namespace}/topic/{topic}/chats` | GET | PublicChatHistory | [PublicChatHistory](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicChatHistory.cs) | [PublicChatHistory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicChatHistory.cs) |
| `/chat/public/namespaces/{namespace}/topic/{topic}/chats/{chatId}` | DELETE | PublicDeleteChat | [PublicDeleteChat](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicDeleteChat.cs) | [PublicDeleteChat](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicDeleteChat.cs) |
| `/chat/public/namespaces/{namespace}/topic/{topic}/mute` | PUT | PublicMuteUser | [PublicMuteUser](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicMuteUser.cs) | [PublicMuteUser](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicMuteUser.cs) |
| `/chat/public/namespaces/{namespace}/topic/{topic}/unban-members` | POST | PublicUnbanTopicMembers | [PublicUnbanTopicMembers](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicUnbanTopicMembers.cs) | [PublicUnbanTopicMembers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicUnbanTopicMembers.cs) |
| `/chat/public/namespaces/{namespace}/topic/{topic}/unmute` | PUT | PublicUnmuteUser | [PublicUnmuteUser](../../AccelByte.Sdk/Api/Chat/Operation/Topic/PublicUnmuteUser.cs) | [PublicUnmuteUser](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/PublicUnmuteUser.cs) |

### config Wrapper:  [Config](../../AccelByte.Sdk/Api/Chat/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/v1/admin/config` | GET | AdminGetAllConfigV1 | [AdminGetAllConfigV1](../../AccelByte.Sdk/Api/Chat/Operation/Config/AdminGetAllConfigV1.cs) | [AdminGetAllConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Config/AdminGetAllConfigV1.cs) |
| `/chat/v1/admin/config/namespaces/{namespace}` | GET | AdminGetConfigV1 | [AdminGetConfigV1](../../AccelByte.Sdk/Api/Chat/Operation/Config/AdminGetConfigV1.cs) | [AdminGetConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Config/AdminGetConfigV1.cs) |
| `/chat/v1/admin/config/namespaces/{namespace}` | PUT | AdminUpdateConfigV1 | [AdminUpdateConfigV1](../../AccelByte.Sdk/Api/Chat/Operation/Config/AdminUpdateConfigV1.cs) | [AdminUpdateConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Config/AdminUpdateConfigV1.cs) |
| `/chat/v1/admin/config/namespaces/{namespace}/export` | GET | ExportConfig | [ExportConfig](../../AccelByte.Sdk/Api/Chat/Operation/Config/ExportConfig.cs) | [ExportConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Config/ExportConfig.cs) |
| `/chat/v1/admin/config/namespaces/{namespace}/import` | POST | ImportConfig | [ImportConfig](../../AccelByte.Sdk/Api/Chat/Operation/Config/ImportConfig.cs) | [ImportConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Config/ImportConfig.cs) |
| `/chat/v1/public/config/namespaces/{namespace}` | GET | PublicGetConfigV1 | [PublicGetConfigV1](../../AccelByte.Sdk/Api/Chat/Operation/Config/PublicGetConfigV1.cs) | [PublicGetConfigV1](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Config/PublicGetConfigV1.cs) |

### inbox Wrapper:  [Inbox](../../AccelByte.Sdk/Api/Chat/Wrapper/Inbox.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/v1/admin/inbox/namespaces/{namespace}/categories` | GET | AdminGetInboxCategories | [AdminGetInboxCategories](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminGetInboxCategories.cs) | [AdminGetInboxCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminGetInboxCategories.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/categories` | POST | AdminAddInboxCategory | [AdminAddInboxCategory](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminAddInboxCategory.cs) | [AdminAddInboxCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminAddInboxCategory.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}` | DELETE | AdminDeleteInboxCategory | [AdminDeleteInboxCategory](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminDeleteInboxCategory.cs) | [AdminDeleteInboxCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminDeleteInboxCategory.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}` | PATCH | AdminUpdateInboxCategory | [AdminUpdateInboxCategory](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminUpdateInboxCategory.cs) | [AdminUpdateInboxCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminUpdateInboxCategory.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/categories/{category}/schema.json` | GET | AdminGetCategorySchema | [AdminGetCategorySchema](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminGetCategorySchema.cs) | [AdminGetCategorySchema](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminGetCategorySchema.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/message/{messageId}` | DELETE | AdminDeleteInboxMessage | [AdminDeleteInboxMessage](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminDeleteInboxMessage.cs) | [AdminDeleteInboxMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminDeleteInboxMessage.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/messages` | GET | AdminGetInboxMessages | [AdminGetInboxMessages](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminGetInboxMessages.cs) | [AdminGetInboxMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminGetInboxMessages.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/messages` | POST | AdminSaveInboxMessage | [AdminSaveInboxMessage](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminSaveInboxMessage.cs) | [AdminSaveInboxMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminSaveInboxMessage.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/messages/{inbox}/unsend` | POST | AdminUnsendInboxMessage | [AdminUnsendInboxMessage](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminUnsendInboxMessage.cs) | [AdminUnsendInboxMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminUnsendInboxMessage.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/messages/{inbox}/users` | GET | AdminGetInboxUsers | [AdminGetInboxUsers](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminGetInboxUsers.cs) | [AdminGetInboxUsers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminGetInboxUsers.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/messages/{messageId}` | PATCH | AdminUpdateInboxMessage | [AdminUpdateInboxMessage](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminUpdateInboxMessage.cs) | [AdminUpdateInboxMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminUpdateInboxMessage.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/messages/{messageId}/send` | POST | AdminSendInboxMessage | [AdminSendInboxMessage](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminSendInboxMessage.cs) | [AdminSendInboxMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminSendInboxMessage.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/stats` | GET | AdminGetInboxStats | [AdminGetInboxStats](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminGetInboxStats.cs) | [AdminGetInboxStats](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminGetInboxStats.cs) |

### moderation Wrapper:  [Moderation](../../AccelByte.Sdk/Api/Chat/Wrapper/Moderation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/v1/admin/namespaces/{namespace}/snapshot/{chatId}` | GET | AdminGetChatSnapshot | [AdminGetChatSnapshot](../../AccelByte.Sdk/Api/Chat/Operation/Moderation/AdminGetChatSnapshot.cs) | [AdminGetChatSnapshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Moderation/AdminGetChatSnapshot.cs) |
| `/chat/v1/admin/namespaces/{namespace}/snapshot/{chatId}` | DELETE | AdminDeleteChatSnapshot | [AdminDeleteChatSnapshot](../../AccelByte.Sdk/Api/Chat/Operation/Moderation/AdminDeleteChatSnapshot.cs) | [AdminDeleteChatSnapshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Moderation/AdminDeleteChatSnapshot.cs) |
| `/chat/v1/public/namespaces/{namespace}/topic/{topic}/snapshot/{chatId}` | GET | PublicGetChatSnapshot | [PublicGetChatSnapshot](../../AccelByte.Sdk/Api/Chat/Operation/Moderation/PublicGetChatSnapshot.cs) | [PublicGetChatSnapshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Moderation/PublicGetChatSnapshot.cs) |

### profanity Wrapper:  [Profanity](../../AccelByte.Sdk/Api/Chat/Wrapper/Profanity.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary` | GET | AdminProfanityQuery | [AdminProfanityQuery](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityQuery.cs) | [AdminProfanityQuery](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityQuery.cs) |
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary` | POST | AdminProfanityCreate | [AdminProfanityCreate](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityCreate.cs) | [AdminProfanityCreate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityCreate.cs) |
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/bulk` | POST | AdminProfanityCreateBulk | [AdminProfanityCreateBulk](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityCreateBulk.cs) | [AdminProfanityCreateBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityCreateBulk.cs) |
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/export` | GET | AdminProfanityExport | [AdminProfanityExport](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityExport.cs) | [AdminProfanityExport](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityExport.cs) |
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/group` | GET | AdminProfanityGroup | [AdminProfanityGroup](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityGroup.cs) | [AdminProfanityGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityGroup.cs) |
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/import` | POST | AdminProfanityImport | [AdminProfanityImport](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityImport.cs) | [AdminProfanityImport](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityImport.cs) |
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/{id}` | PUT | AdminProfanityUpdate | [AdminProfanityUpdate](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityUpdate.cs) | [AdminProfanityUpdate](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityUpdate.cs) |
| `/chat/v1/admin/profanity/namespaces/{namespace}/dictionary/{id}` | DELETE | AdminProfanityDelete | [AdminProfanityDelete](../../AccelByte.Sdk/Api/Chat/Operation/Profanity/AdminProfanityDelete.cs) | [AdminProfanityDelete](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Profanity/AdminProfanityDelete.cs) |

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Chat/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/v1/messages` | GET | PublicGetMessages | [PublicGetMessages](../../AccelByte.Sdk/Api/Chat/Operation/Operations/PublicGetMessages.cs) | [PublicGetMessages](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Operations/PublicGetMessages.cs) |


&nbsp;  

## Operations with Generic Response

### topic Wrapper:  [Topic](../../AccelByte.Sdk/Api/Chat/Wrapper/Topic.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/admin/namespaces/{namespace}/chat/filter` | POST | AdminFilterChatMessage | [AdminFilterChatMessage](../../AccelByte.Sdk/Api/Chat/Operation/Topic/AdminFilterChatMessage.cs) | [AdminFilterChatMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Topic/AdminFilterChatMessage.cs) |

### config Wrapper:  [Config](../../AccelByte.Sdk/Api/Chat/Wrapper/Config.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### inbox Wrapper:  [Inbox](../../AccelByte.Sdk/Api/Chat/Wrapper/Inbox.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/chat/v1/admin/inbox/namespaces/{namespace}/categories` | GET | AdminGetInboxCategories | [AdminGetInboxCategories](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminGetInboxCategories.cs) | [AdminGetInboxCategories](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminGetInboxCategories.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/categories` | POST | AdminAddInboxCategory | [AdminAddInboxCategory](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminAddInboxCategory.cs) | [AdminAddInboxCategory](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminAddInboxCategory.cs) |
| `/chat/v1/admin/inbox/namespaces/{namespace}/messages` | POST | AdminSaveInboxMessage | [AdminSaveInboxMessage](../../AccelByte.Sdk/Api/Chat/Operation/Inbox/AdminSaveInboxMessage.cs) | [AdminSaveInboxMessage](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Chat/Inbox/AdminSaveInboxMessage.cs) |

### moderation Wrapper:  [Moderation](../../AccelByte.Sdk/Api/Chat/Wrapper/Moderation.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### profanity Wrapper:  [Profanity](../../AccelByte.Sdk/Api/Chat/Wrapper/Profanity.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Operations Wrapper:  [Operations](../../AccelByte.Sdk/Api/Chat/Wrapper/Operations.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `api.AddMemberParams` | [ApiAddMemberParams](../../AccelByte.Sdk/Api/Chat/Model/ApiAddMemberParams.cs) |
| `api.CreateNamespaceTopicParams` | [ApiCreateNamespaceTopicParams](../../AccelByte.Sdk/Api/Chat/Model/ApiCreateNamespaceTopicParams.cs) |
| `api.CreateTopicParams` | [ApiCreateTopicParams](../../AccelByte.Sdk/Api/Chat/Model/ApiCreateTopicParams.cs) |
| `api.CreateTopicResponse` | [ApiCreateTopicResponse](../../AccelByte.Sdk/Api/Chat/Model/ApiCreateTopicResponse.cs) |
| `api.MuteUserRequest` | [ApiMuteUserRequest](../../AccelByte.Sdk/Api/Chat/Model/ApiMuteUserRequest.cs) |
| `api.MutedTopicResponse` | [ApiMutedTopicResponse](../../AccelByte.Sdk/Api/Chat/Model/ApiMutedTopicResponse.cs) |
| `api.SendChatParams` | [ApiSendChatParams](../../AccelByte.Sdk/Api/Chat/Model/ApiSendChatParams.cs) |
| `api.UnmuteUserRequest` | [ApiUnmuteUserRequest](../../AccelByte.Sdk/Api/Chat/Model/ApiUnmuteUserRequest.cs) |
| `api.UpdateTopicParams` | [ApiUpdateTopicParams](../../AccelByte.Sdk/Api/Chat/Model/ApiUpdateTopicParams.cs) |
| `log.AppMessageDeclaration` | [LogAppMessageDeclaration](../../AccelByte.Sdk/Api/Chat/Model/LogAppMessageDeclaration.cs) |
| `message.ActionAddUserToTopicResult` | [MessageActionAddUserToTopicResult](../../AccelByte.Sdk/Api/Chat/Model/MessageActionAddUserToTopicResult.cs) |
| `message.ActionDeleteTopicResult` | [MessageActionDeleteTopicResult](../../AccelByte.Sdk/Api/Chat/Model/MessageActionDeleteTopicResult.cs) |
| `models.AddInboxCategoryRequest` | [ModelsAddInboxCategoryRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsAddInboxCategoryRequest.cs) |
| `models.AddInboxCategoryResponse` | [ModelsAddInboxCategoryResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsAddInboxCategoryResponse.cs) |
| `models.BanTopicMemberParam` | [ModelsBanTopicMemberParam](../../AccelByte.Sdk/Api/Chat/Model/ModelsBanTopicMemberParam.cs) |
| `models.BanTopicMemberResult` | [ModelsBanTopicMemberResult](../../AccelByte.Sdk/Api/Chat/Model/ModelsBanTopicMemberResult.cs) |
| `models.CategoryHook` | [ModelsCategoryHook](../../AccelByte.Sdk/Api/Chat/Model/ModelsCategoryHook.cs) |
| `models.ChannelTopicResponse` | [ModelsChannelTopicResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsChannelTopicResponse.cs) |
| `models.ChannelTopicSummaryResponse` | [ModelsChannelTopicSummaryResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsChannelTopicSummaryResponse.cs) |
| `models.ChannelTopicWithPaginationResponse` | [ModelsChannelTopicWithPaginationResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsChannelTopicWithPaginationResponse.cs) |
| `models.ChatMessageResponse` | [ModelsChatMessageResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsChatMessageResponse.cs) |
| `models.ChatMessageWithPaginationResponse` | [ModelsChatMessageWithPaginationResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsChatMessageWithPaginationResponse.cs) |
| `models.ChatSnapshotMessage` | [ModelsChatSnapshotMessage](../../AccelByte.Sdk/Api/Chat/Model/ModelsChatSnapshotMessage.cs) |
| `models.ChatSnapshots` | [ModelsChatSnapshots](../../AccelByte.Sdk/Api/Chat/Model/ModelsChatSnapshots.cs) |
| `models.Config` | [ModelsConfig](../../AccelByte.Sdk/Api/Chat/Model/ModelsConfig.cs) |
| `models.ConfigExport` | [ModelsConfigExport](../../AccelByte.Sdk/Api/Chat/Model/ModelsConfigExport.cs) |
| `models.ConfigList` | [ModelsConfigList](../../AccelByte.Sdk/Api/Chat/Model/ModelsConfigList.cs) |
| `models.ConfigResponse` | [ModelsConfigResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsConfigResponse.cs) |
| `models.Dictionary` | [ModelsDictionary](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionary.cs) |
| `models.DictionaryChild` | [ModelsDictionaryChild](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryChild.cs) |
| `models.DictionaryExport` | [ModelsDictionaryExport](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryExport.cs) |
| `models.DictionaryExportItem` | [ModelsDictionaryExportItem](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryExportItem.cs) |
| `models.DictionaryGroup` | [ModelsDictionaryGroup](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryGroup.cs) |
| `models.DictionaryImportResult` | [ModelsDictionaryImportResult](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryImportResult.cs) |
| `models.DictionaryInsertBulkRequest` | [ModelsDictionaryInsertBulkRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryInsertBulkRequest.cs) |
| `models.DictionaryInsertRequest` | [ModelsDictionaryInsertRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryInsertRequest.cs) |
| `models.DictionaryQueryResult` | [ModelsDictionaryQueryResult](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryQueryResult.cs) |
| `models.DictionaryUpdateRequest` | [ModelsDictionaryUpdateRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryUpdateRequest.cs) |
| `models.DictionaryWithChildren` | [ModelsDictionaryWithChildren](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryWithChildren.cs) |
| `models.DictionaryWordChanges` | [ModelsDictionaryWordChanges](../../AccelByte.Sdk/Api/Chat/Model/ModelsDictionaryWordChanges.cs) |
| `models.GetInboxCategoriesResponseItem` | [ModelsGetInboxCategoriesResponseItem](../../AccelByte.Sdk/Api/Chat/Model/ModelsGetInboxCategoriesResponseItem.cs) |
| `models.GetInboxMessagesResponse` | [ModelsGetInboxMessagesResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsGetInboxMessagesResponse.cs) |
| `models.GetInboxMessagesResponseData` | [ModelsGetInboxMessagesResponseData](../../AccelByte.Sdk/Api/Chat/Model/ModelsGetInboxMessagesResponseData.cs) |
| `models.GetInboxStatsResponse` | [ModelsGetInboxStatsResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsGetInboxStatsResponse.cs) |
| `models.GetInboxUsersResponse` | [ModelsGetInboxUsersResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsGetInboxUsersResponse.cs) |
| `models.ImportConfigResponse` | [ModelsImportConfigResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsImportConfigResponse.cs) |
| `models.JSONSchemaType` | [ModelsJSONSchemaType](../../AccelByte.Sdk/Api/Chat/Model/ModelsJSONSchemaType.cs) |
| `models.MessageRequest` | [ModelsMessageRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsMessageRequest.cs) |
| `models.MessageResultWithAttributes` | [ModelsMessageResultWithAttributes](../../AccelByte.Sdk/Api/Chat/Model/ModelsMessageResultWithAttributes.cs) |
| `models.MessageStats` | [ModelsMessageStats](../../AccelByte.Sdk/Api/Chat/Model/ModelsMessageStats.cs) |
| `models.Pagination` | [ModelsPagination](../../AccelByte.Sdk/Api/Chat/Model/ModelsPagination.cs) |
| `models.PublicBanTopicMembersRequest` | [ModelsPublicBanTopicMembersRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsPublicBanTopicMembersRequest.cs) |
| `models.PublicBanTopicMembersResponse` | [ModelsPublicBanTopicMembersResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsPublicBanTopicMembersResponse.cs) |
| `models.PublicConfigResponse` | [ModelsPublicConfigResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsPublicConfigResponse.cs) |
| `models.PublicUnbanTopicMembersRequest` | [ModelsPublicUnbanTopicMembersRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsPublicUnbanTopicMembersRequest.cs) |
| `models.PublicUnbanTopicMembersResponse` | [ModelsPublicUnbanTopicMembersResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsPublicUnbanTopicMembersResponse.cs) |
| `models.SaveInboxMessageRequest` | [ModelsSaveInboxMessageRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsSaveInboxMessageRequest.cs) |
| `models.SaveInboxMessageResponse` | [ModelsSaveInboxMessageResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsSaveInboxMessageResponse.cs) |
| `models.SendInboxMessageRequest` | [ModelsSendInboxMessageRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsSendInboxMessageRequest.cs) |
| `models.SendInboxMessageResponse` | [ModelsSendInboxMessageResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsSendInboxMessageResponse.cs) |
| `models.TopicInfo` | [ModelsTopicInfo](../../AccelByte.Sdk/Api/Chat/Model/ModelsTopicInfo.cs) |
| `models.TopicLogItem` | [ModelsTopicLogItem](../../AccelByte.Sdk/Api/Chat/Model/ModelsTopicLogItem.cs) |
| `models.TopicLogWithPaginationResponse` | [ModelsTopicLogWithPaginationResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsTopicLogWithPaginationResponse.cs) |
| `models.TopicMemberResponse` | [ModelsTopicMemberResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsTopicMemberResponse.cs) |
| `models.TopicMemberWithPaginationResponse` | [ModelsTopicMemberWithPaginationResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsTopicMemberWithPaginationResponse.cs) |
| `models.TopicResponse` | [ModelsTopicResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsTopicResponse.cs) |
| `models.UnbanTopicMemberParam` | [ModelsUnbanTopicMemberParam](../../AccelByte.Sdk/Api/Chat/Model/ModelsUnbanTopicMemberParam.cs) |
| `models.UnbanTopicMemberResult` | [ModelsUnbanTopicMemberResult](../../AccelByte.Sdk/Api/Chat/Model/ModelsUnbanTopicMemberResult.cs) |
| `models.UnsendInboxMessageRequest` | [ModelsUnsendInboxMessageRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsUnsendInboxMessageRequest.cs) |
| `models.UnsendInboxMessageResponse` | [ModelsUnsendInboxMessageResponse](../../AccelByte.Sdk/Api/Chat/Model/ModelsUnsendInboxMessageResponse.cs) |
| `models.UpdateInboxCategoryRequest` | [ModelsUpdateInboxCategoryRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsUpdateInboxCategoryRequest.cs) |
| `models.UpdateInboxMessageRequest` | [ModelsUpdateInboxMessageRequest](../../AccelByte.Sdk/Api/Chat/Model/ModelsUpdateInboxMessageRequest.cs) |
| `models.UserInbox` | [ModelsUserInbox](../../AccelByte.Sdk/Api/Chat/Model/ModelsUserInbox.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Chat/Model/ResponseError.cs) |
| `restapi.ErrorResponseBody` | [RestapiErrorResponseBody](../../AccelByte.Sdk/Api/Chat/Model/RestapiErrorResponseBody.cs) |
| `topic.InfoMember` | [TopicInfoMember](../../AccelByte.Sdk/Api/Chat/Model/TopicInfoMember.cs) |
