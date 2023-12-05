# Ugc Service Index

&nbsp;  

## Operations

### Admin Channel Wrapper:  [AdminChannel](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/channels` | GET | SingleAdminGetChannel | [SingleAdminGetChannel](../../AccelByte.Sdk/Api/Ugc/Operation/AdminChannel/SingleAdminGetChannel.cs) | [SingleAdminGetChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/SingleAdminGetChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels` | POST | AdminCreateChannel | [AdminCreateChannel](../../AccelByte.Sdk/Api/Ugc/Operation/AdminChannel/AdminCreateChannel.cs) | [AdminCreateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminCreateChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}` | PUT | SingleAdminUpdateChannel | [SingleAdminUpdateChannel](../../AccelByte.Sdk/Api/Ugc/Operation/AdminChannel/SingleAdminUpdateChannel.cs) | [SingleAdminUpdateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/SingleAdminUpdateChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}` | DELETE | SingleAdminDeleteChannel | [SingleAdminDeleteChannel](../../AccelByte.Sdk/Api/Ugc/Operation/AdminChannel/SingleAdminDeleteChannel.cs) | [SingleAdminDeleteChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/SingleAdminDeleteChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels` | GET | AdminGetChannel | [AdminGetChannel](../../AccelByte.Sdk/Api/Ugc/Operation/AdminChannel/AdminGetChannel.cs) | [AdminGetChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminGetChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}` | PUT | AdminUpdateChannel | [AdminUpdateChannel](../../AccelByte.Sdk/Api/Ugc/Operation/AdminChannel/AdminUpdateChannel.cs) | [AdminUpdateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminUpdateChannel.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}` | DELETE | AdminDeleteChannel | [AdminDeleteChannel](../../AccelByte.Sdk/Api/Ugc/Operation/AdminChannel/AdminDeleteChannel.cs) | [AdminDeleteChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminChannel/AdminDeleteChannel.cs) |

### Admin Content Wrapper:  [AdminContent](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminContent.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents` | POST | AdminUploadContentDirect | [AdminUploadContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUploadContentDirect.cs) | [AdminUploadContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3` | POST | AdminUploadContentS3 | [AdminUploadContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUploadContentS3.cs) | [AdminUploadContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentS3.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId}` | PUT | SingleAdminUpdateContentS3 | [SingleAdminUpdateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/SingleAdminUpdateContentS3.cs) | [SingleAdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentS3.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/search` | GET | AdminSearchChannelSpecificContent | [AdminSearchChannelSpecificContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminSearchChannelSpecificContent.cs) | [AdminSearchChannelSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminSearchChannelSpecificContent.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | PUT | SingleAdminUpdateContentDirect | [SingleAdminUpdateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/SingleAdminUpdateContentDirect.cs) | [SingleAdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | DELETE | SingleAdminDeleteContent | [SingleAdminDeleteContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/SingleAdminDeleteContent.cs) | [SingleAdminDeleteContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminDeleteContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents` | GET | SingleAdminGetContent | [SingleAdminGetContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/SingleAdminGetContent.cs) | [SingleAdminGetContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminGetContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/bulk` | POST | AdminGetContentBulk | [AdminGetContentBulk](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetContentBulk.cs) | [AdminGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContentBulk.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/search` | GET | AdminSearchContent | [AdminSearchContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminSearchContent.cs) | [AdminSearchContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminSearchContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/bulk` | POST | AdminGetContentBulkByShareCodes | [AdminGetContentBulkByShareCodes](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetContentBulkByShareCodes.cs) | [AdminGetContentBulkByShareCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContentBulkByShareCodes.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | AdminGetUserContentByShareCode | [AdminGetUserContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetUserContentByShareCode.cs) | [AdminGetUserContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetUserContentByShareCode.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}` | GET | AdminGetSpecificContent | [AdminGetSpecificContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetSpecificContent.cs) | [AdminGetSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetSpecificContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/preview` | GET | AdminDownloadContentPreview | [AdminDownloadContentPreview](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminDownloadContentPreview.cs) | [AdminDownloadContentPreview](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminDownloadContentPreview.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/rollback/{versionId}` | PUT | RollbackContentVersion | [RollbackContentVersion](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/RollbackContentVersion.cs) | [RollbackContentVersion](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/RollbackContentVersion.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots` | PUT | AdminUpdateScreenshots | [AdminUpdateScreenshots](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUpdateScreenshots.cs) | [AdminUpdateScreenshots](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateScreenshots.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots` | POST | AdminUploadContentScreenshot | [AdminUploadContentScreenshot](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUploadContentScreenshot.cs) | [AdminUploadContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentScreenshot.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots/{screenshotId}` | DELETE | AdminDeleteContentScreenshot | [AdminDeleteContentScreenshot](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminDeleteContentScreenshot.cs) | [AdminDeleteContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminDeleteContentScreenshot.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/versions` | GET | ListContentVersions | [ListContentVersions](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/ListContentVersions.cs) | [ListContentVersions](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/ListContentVersions.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | AdminUpdateContentS3ByShareCode | [AdminUpdateContentS3ByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUpdateContentS3ByShareCode.cs) | [AdminUpdateContentS3ByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentS3ByShareCode.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | AdminUpdateContentS3 | [AdminUpdateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUpdateContentS3.cs) | [AdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentS3.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}` | DELETE | DeleteContentByShareCode | [DeleteContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/DeleteContentByShareCode.cs) | [DeleteContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/DeleteContentByShareCode.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | AdminUpdateContentDirect | [AdminUpdateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUpdateContentDirect.cs) | [AdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | DELETE | AdminDeleteContent | [AdminDeleteContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminDeleteContent.cs) | [AdminDeleteContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminDeleteContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents` | GET | AdminGetContent | [AdminGetContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetContent.cs) | [AdminGetContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide` | PUT | AdminHideUserContent | [AdminHideUserContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminHideUserContent.cs) | [AdminHideUserContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminHideUserContent.cs) |

### Admin Group Wrapper:  [AdminGroup](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/groups` | GET | SingleAdminGetAllGroups | [SingleAdminGetAllGroups](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/SingleAdminGetAllGroups.cs) | [SingleAdminGetAllGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminGetAllGroups.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups` | POST | AdminCreateGroup | [AdminCreateGroup](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminCreateGroup.cs) | [AdminCreateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminCreateGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}` | GET | SingleAdminGetGroup | [SingleAdminGetGroup](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/SingleAdminGetGroup.cs) | [SingleAdminGetGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminGetGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}` | PUT | SingleAdminUpdateGroup | [SingleAdminUpdateGroup](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/SingleAdminUpdateGroup.cs) | [SingleAdminUpdateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminUpdateGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}` | DELETE | SingleAdminDeleteGroup | [SingleAdminDeleteGroup](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/SingleAdminDeleteGroup.cs) | [SingleAdminDeleteGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminDeleteGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/groups/{groupId}/contents` | GET | SingleAdminGetGroupContents | [SingleAdminGetGroupContents](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/SingleAdminGetGroupContents.cs) | [SingleAdminGetGroupContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/SingleAdminGetGroupContents.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups` | GET | AdminGetAllGroups | [AdminGetAllGroups](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminGetAllGroups.cs) | [AdminGetAllGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetAllGroups.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}` | GET | AdminGetGroup | [AdminGetGroup](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminGetGroup.cs) | [AdminGetGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}` | PUT | AdminUpdateGroup | [AdminUpdateGroup](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminUpdateGroup.cs) | [AdminUpdateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminUpdateGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}` | DELETE | AdminDeleteGroup | [AdminDeleteGroup](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminDeleteGroup.cs) | [AdminDeleteGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminDeleteGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents` | GET | AdminGetGroupContents | [AdminGetGroupContents](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminGetGroupContents.cs) | [AdminGetGroupContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetGroupContents.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/groups/{groupId}/contents` | GET | AdminGetOfficialGroupContentsV2 | [AdminGetOfficialGroupContentsV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminGetOfficialGroupContentsV2.cs) | [AdminGetOfficialGroupContentsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetOfficialGroupContentsV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents` | GET | AdminGetUserGroupContentsV2 | [AdminGetUserGroupContentsV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminGroup/AdminGetUserGroupContentsV2.cs) | [AdminGetUserGroupContentsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminGroup/AdminGetUserGroupContentsV2.cs) |

### Admin Tag Wrapper:  [AdminTag](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/tags` | GET | AdminGetTag | [AdminGetTag](../../AccelByte.Sdk/Api/Ugc/Operation/AdminTag/AdminGetTag.cs) | [AdminGetTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminGetTag.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/tags` | POST | AdminCreateTag | [AdminCreateTag](../../AccelByte.Sdk/Api/Ugc/Operation/AdminTag/AdminCreateTag.cs) | [AdminCreateTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminCreateTag.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/tags/{tagId}` | PUT | AdminUpdateTag | [AdminUpdateTag](../../AccelByte.Sdk/Api/Ugc/Operation/AdminTag/AdminUpdateTag.cs) | [AdminUpdateTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminUpdateTag.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/tags/{tagId}` | DELETE | AdminDeleteTag | [AdminDeleteTag](../../AccelByte.Sdk/Api/Ugc/Operation/AdminTag/AdminDeleteTag.cs) | [AdminDeleteTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminTag/AdminDeleteTag.cs) |

### Admin Type Wrapper:  [AdminType](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/types` | GET | AdminGetType | [AdminGetType](../../AccelByte.Sdk/Api/Ugc/Operation/AdminType/AdminGetType.cs) | [AdminGetType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminGetType.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/types` | POST | AdminCreateType | [AdminCreateType](../../AccelByte.Sdk/Api/Ugc/Operation/AdminType/AdminCreateType.cs) | [AdminCreateType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminCreateType.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/types/{typeId}` | PUT | AdminUpdateType | [AdminUpdateType](../../AccelByte.Sdk/Api/Ugc/Operation/AdminType/AdminUpdateType.cs) | [AdminUpdateType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminUpdateType.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/types/{typeId}` | DELETE | AdminDeleteType | [AdminDeleteType](../../AccelByte.Sdk/Api/Ugc/Operation/AdminType/AdminDeleteType.cs) | [AdminDeleteType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminType/AdminDeleteType.cs) |

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Ugc/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels` | DELETE | AdminDeleteAllUserChannels | [AdminDeleteAllUserChannels](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/AdminDeleteAllUserChannels.cs) | [AdminDeleteAllUserChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserChannels.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents` | DELETE | AdminDeleteAllUserContents | [AdminDeleteAllUserContents](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/AdminDeleteAllUserContents.cs) | [AdminDeleteAllUserContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserContents.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups` | DELETE | AdminDeleteAllUserGroup | [AdminDeleteAllUserGroup](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/AdminDeleteAllUserGroup.cs) | [AdminDeleteAllUserGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserGroup.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/states` | DELETE | AdminDeleteAllUserStates | [AdminDeleteAllUserStates](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/AdminDeleteAllUserStates.cs) | [AdminDeleteAllUserStates](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/AdminDeleteAllUserStates.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels` | DELETE | DeleteAllUserChannel | [DeleteAllUserChannel](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/DeleteAllUserChannel.cs) | [DeleteAllUserChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserChannel.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents` | DELETE | DeleteAllUserContents | [DeleteAllUserContents](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/DeleteAllUserContents.cs) | [DeleteAllUserContents](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserContents.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups` | DELETE | DeleteAllUserGroup | [DeleteAllUserGroup](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/DeleteAllUserGroup.cs) | [DeleteAllUserGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/states` | DELETE | DeleteAllUserStates | [DeleteAllUserStates](../../AccelByte.Sdk/Api/Ugc/Operation/Anonymization/DeleteAllUserStates.cs) | [DeleteAllUserStates](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/Anonymization/DeleteAllUserStates.cs) |

### Public Content (Legacy) Wrapper:  [PublicContentLegacy](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicContentLegacy.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents` | GET | SearchChannelSpecificContent | [SearchChannelSpecificContent](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/SearchChannelSpecificContent.cs) | [SearchChannelSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/SearchChannelSpecificContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents` | GET | PublicSearchContent | [PublicSearchContent](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicSearchContent.cs) | [PublicSearchContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicSearchContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/bulk` | POST | PublicGetContentBulk | [PublicGetContentBulk](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicGetContentBulk.cs) | [PublicGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicGetContentBulk.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/bulk` | POST | PublicGetContentBulkByShareCodes | [PublicGetContentBulkByShareCodes](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicGetContentBulkByShareCodes.cs) | [PublicGetContentBulkByShareCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicGetContentBulkByShareCodes.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | PublicDownloadContentByShareCode | [PublicDownloadContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicDownloadContentByShareCode.cs) | [PublicDownloadContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicDownloadContentByShareCode.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}` | GET | PublicDownloadContentByContentID | [PublicDownloadContentByContentID](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicDownloadContentByContentID.cs) | [PublicDownloadContentByContentID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicDownloadContentByContentID.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/preview` | GET | PublicDownloadContentPreview | [PublicDownloadContentPreview](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicDownloadContentPreview.cs) | [PublicDownloadContentPreview](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicDownloadContentPreview.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents` | POST | CreateContentDirect | [CreateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/CreateContentDirect.cs) | [CreateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/CreateContentDirect.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3` | POST | CreateContentS3 | [CreateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/CreateContentS3.cs) | [CreateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/CreateContentS3.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | PublicUpdateContentByShareCode | [PublicUpdateContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicUpdateContentByShareCode.cs) | [PublicUpdateContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicUpdateContentByShareCode.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | UpdateContentS3 | [UpdateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UpdateContentS3.cs) | [UpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UpdateContentS3.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}` | DELETE | PublicDeleteContentByShareCode | [PublicDeleteContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicDeleteContentByShareCode.cs) | [PublicDeleteContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicDeleteContentByShareCode.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | UpdateContentDirect | [UpdateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UpdateContentDirect.cs) | [UpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UpdateContentDirect.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | DELETE | DeleteContent | [DeleteContent](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/DeleteContent.cs) | [DeleteContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/DeleteContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/sharecode` | PATCH | UpdateContentShareCode | [UpdateContentShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UpdateContentShareCode.cs) | [UpdateContentShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UpdateContentShareCode.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents` | GET | PublicGetUserContent | [PublicGetUserContent](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicGetUserContent.cs) | [PublicGetUserContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicGetUserContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots` | PUT | UpdateScreenshots | [UpdateScreenshots](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UpdateScreenshots.cs) | [UpdateScreenshots](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UpdateScreenshots.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots` | POST | UploadContentScreenshot | [UploadContentScreenshot](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UploadContentScreenshot.cs) | [UploadContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UploadContentScreenshot.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}` | DELETE | DeleteContentScreenshot | [DeleteContentScreenshot](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/DeleteContentScreenshot.cs) | [DeleteContentScreenshot](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/DeleteContentScreenshot.cs) |

### Public Follow Wrapper:  [PublicFollow](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicFollow.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/followed` | GET | GetFollowedContent | [GetFollowedContent](../../AccelByte.Sdk/Api/Ugc/Operation/PublicFollow/GetFollowedContent.cs) | [GetFollowedContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetFollowedContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/followed` | GET | GetFollowedUsers | [GetFollowedUsers](../../AccelByte.Sdk/Api/Ugc/Operation/PublicFollow/GetFollowedUsers.cs) | [GetFollowedUsers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetFollowedUsers.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/follow` | PUT | UpdateUserFollowStatus | [UpdateUserFollowStatus](../../AccelByte.Sdk/Api/Ugc/Operation/PublicFollow/UpdateUserFollowStatus.cs) | [UpdateUserFollowStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/UpdateUserFollowStatus.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/followers` | GET | GetPublicFollowers | [GetPublicFollowers](../../AccelByte.Sdk/Api/Ugc/Operation/PublicFollow/GetPublicFollowers.cs) | [GetPublicFollowers](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetPublicFollowers.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/following` | GET | GetPublicFollowing | [GetPublicFollowing](../../AccelByte.Sdk/Api/Ugc/Operation/PublicFollow/GetPublicFollowing.cs) | [GetPublicFollowing](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicFollow/GetPublicFollowing.cs) |

### Public Like (Legacy) Wrapper:  [PublicLikeLegacy](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicLikeLegacy.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/liked` | GET | GetLikedContent | [GetLikedContent](../../AccelByte.Sdk/Api/Ugc/Operation/PublicLikeLegacy/GetLikedContent.cs) | [GetLikedContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicLikeLegacy/GetLikedContent.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/like` | PUT | UpdateContentLikeStatus | [UpdateContentLikeStatus](../../AccelByte.Sdk/Api/Ugc/Operation/PublicLikeLegacy/UpdateContentLikeStatus.cs) | [UpdateContentLikeStatus](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicLikeLegacy/UpdateContentLikeStatus.cs) |

### Public Download Count (Legacy) Wrapper:  [PublicDownloadCountLegacy](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicDownloadCountLegacy.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}/downloadcount` | POST | AddDownloadCount | [AddDownloadCount](../../AccelByte.Sdk/Api/Ugc/Operation/PublicDownloadCountLegacy/AddDownloadCount.cs) | [AddDownloadCount](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicDownloadCountLegacy/AddDownloadCount.cs) |

### Public Tag Wrapper:  [PublicTag](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/tags` | GET | GetTag | [GetTag](../../AccelByte.Sdk/Api/Ugc/Operation/PublicTag/GetTag.cs) | [GetTag](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicTag/GetTag.cs) |

### Public Type Wrapper:  [PublicType](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/types` | GET | GetType | [GetType](../../AccelByte.Sdk/Api/Ugc/Operation/PublicType/GetType.cs) | [GetType](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicType/GetType.cs) |

### Public Creator Wrapper:  [PublicCreator](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicCreator.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/users` | GET | PublicSearchCreator | [PublicSearchCreator](../../AccelByte.Sdk/Api/Ugc/Operation/PublicCreator/PublicSearchCreator.cs) | [PublicSearchCreator](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicCreator/PublicSearchCreator.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}` | GET | PublicGetCreator | [PublicGetCreator](../../AccelByte.Sdk/Api/Ugc/Operation/PublicCreator/PublicGetCreator.cs) | [PublicGetCreator](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicCreator/PublicGetCreator.cs) |

### Public Channel Wrapper:  [PublicChannel](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels` | GET | GetChannels | [GetChannels](../../AccelByte.Sdk/Api/Ugc/Operation/PublicChannel/GetChannels.cs) | [GetChannels](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/GetChannels.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels` | POST | PublicCreateChannel | [PublicCreateChannel](../../AccelByte.Sdk/Api/Ugc/Operation/PublicChannel/PublicCreateChannel.cs) | [PublicCreateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/PublicCreateChannel.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}` | PUT | UpdateChannel | [UpdateChannel](../../AccelByte.Sdk/Api/Ugc/Operation/PublicChannel/UpdateChannel.cs) | [UpdateChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/UpdateChannel.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}` | DELETE | DeleteChannel | [DeleteChannel](../../AccelByte.Sdk/Api/Ugc/Operation/PublicChannel/DeleteChannel.cs) | [DeleteChannel](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicChannel/DeleteChannel.cs) |

### Public Group Wrapper:  [PublicGroup](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups` | GET | GetGroups | [GetGroups](../../AccelByte.Sdk/Api/Ugc/Operation/PublicGroup/GetGroups.cs) | [GetGroups](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/GetGroups.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups` | POST | CreateGroup | [CreateGroup](../../AccelByte.Sdk/Api/Ugc/Operation/PublicGroup/CreateGroup.cs) | [CreateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/CreateGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}` | GET | GetGroup | [GetGroup](../../AccelByte.Sdk/Api/Ugc/Operation/PublicGroup/GetGroup.cs) | [GetGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/GetGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}` | PUT | UpdateGroup | [UpdateGroup](../../AccelByte.Sdk/Api/Ugc/Operation/PublicGroup/UpdateGroup.cs) | [UpdateGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/UpdateGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}` | DELETE | DeleteGroup | [DeleteGroup](../../AccelByte.Sdk/Api/Ugc/Operation/PublicGroup/DeleteGroup.cs) | [DeleteGroup](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/DeleteGroup.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents` | GET | GetGroupContent | [GetGroupContent](../../AccelByte.Sdk/Api/Ugc/Operation/PublicGroup/GetGroupContent.cs) | [GetGroupContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/GetGroupContent.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents` | GET | PublicGetGroupContentsV2 | [PublicGetGroupContentsV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicGroup/PublicGetGroupContentsV2.cs) | [PublicGetGroupContentsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicGroup/PublicGetGroupContentsV2.cs) |

### Admin Content V2 Wrapper:  [AdminContentV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminContentV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents` | GET | AdminGetContentByChannelIDV2 | [AdminGetContentByChannelIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentByChannelIDV2.cs) | [AdminGetContentByChannelIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentByChannelIDV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents` | POST | AdminCreateContentV2 | [AdminCreateContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminCreateContentV2.cs) | [AdminCreateContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminCreateContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | DELETE | AdminDeleteOfficialContentV2 | [AdminDeleteOfficialContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminDeleteOfficialContentV2.cs) | [AdminDeleteOfficialContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminDeleteOfficialContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | PATCH | AdminUpdateOfficialContentV2 | [AdminUpdateOfficialContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateOfficialContentV2.cs) | [AdminUpdateOfficialContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateOfficialContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}/fileLocation` | PATCH | AdminUpdateOfficialContentFileLocation | [AdminUpdateOfficialContentFileLocation](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateOfficialContentFileLocation.cs) | [AdminUpdateOfficialContentFileLocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateOfficialContentFileLocation.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}/uploadUrl` | PATCH | AdminGenerateOfficialContentUploadURLV2 | [AdminGenerateOfficialContentUploadURLV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGenerateOfficialContentUploadURLV2.cs) | [AdminGenerateOfficialContentUploadURLV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGenerateOfficialContentUploadURLV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents` | GET | AdminListContentV2 | [AdminListContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminListContentV2.cs) | [AdminListContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminListContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/bulk` | POST | AdminBulkGetContentByIDsV2 | [AdminBulkGetContentByIDsV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminBulkGetContentByIDsV2.cs) | [AdminBulkGetContentByIDsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminBulkGetContentByIDsV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/sharecodes/bulk` | POST | AdminGetContentBulkByShareCodesV2 | [AdminGetContentBulkByShareCodesV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentBulkByShareCodesV2.cs) | [AdminGetContentBulkByShareCodesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentBulkByShareCodesV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | AdminGetContentByShareCodeV2 | [AdminGetContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentByShareCodeV2.cs) | [AdminGetContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentByShareCodeV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}` | GET | AdminGetContentByContentIDV2 | [AdminGetContentByContentIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentByContentIDV2.cs) | [AdminGetContentByContentIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentByContentIDV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/rollback/{versionId}` | PUT | RollbackContentVersionV2 | [RollbackContentVersionV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/RollbackContentVersionV2.cs) | [RollbackContentVersionV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/RollbackContentVersionV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/screenshots` | PUT | AdminUpdateScreenshotsV2 | [AdminUpdateScreenshotsV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateScreenshotsV2.cs) | [AdminUpdateScreenshotsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateScreenshotsV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/screenshots` | POST | AdminUploadContentScreenshotV2 | [AdminUploadContentScreenshotV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUploadContentScreenshotV2.cs) | [AdminUploadContentScreenshotV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUploadContentScreenshotV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/screenshots/{screenshotId}` | DELETE | AdminDeleteContentScreenshotV2 | [AdminDeleteContentScreenshotV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminDeleteContentScreenshotV2.cs) | [AdminDeleteContentScreenshotV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminDeleteContentScreenshotV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/versions` | GET | ListContentVersionsV2 | [ListContentVersionsV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/ListContentVersionsV2.cs) | [ListContentVersionsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/ListContentVersionsV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | AdminUpdateContentByShareCodeV2 | [AdminUpdateContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateContentByShareCodeV2.cs) | [AdminUpdateContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateContentByShareCodeV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}` | DELETE | AdminDeleteContentByShareCodeV2 | [AdminDeleteContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminDeleteContentByShareCodeV2.cs) | [AdminDeleteContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminDeleteContentByShareCodeV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | DELETE | AdminDeleteUserContentV2 | [AdminDeleteUserContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminDeleteUserContentV2.cs) | [AdminDeleteUserContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminDeleteUserContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PATCH | AdminUpdateUserContentV2 | [AdminUpdateUserContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateUserContentV2.cs) | [AdminUpdateUserContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateUserContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/fileLocation` | PATCH | AdminUpdateUserContentFileLocation | [AdminUpdateUserContentFileLocation](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateUserContentFileLocation.cs) | [AdminUpdateUserContentFileLocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateUserContentFileLocation.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/uploadUrl` | PATCH | AdminGenerateUserContentUploadURLV2 | [AdminGenerateUserContentUploadURLV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGenerateUserContentUploadURLV2.cs) | [AdminGenerateUserContentUploadURLV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGenerateUserContentUploadURLV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/contents` | GET | AdminGetContentByUserIDV2 | [AdminGetContentByUserIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentByUserIDV2.cs) | [AdminGetContentByUserIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentByUserIDV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide` | PUT | AdminUpdateContentHideStatusV2 | [AdminUpdateContentHideStatusV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateContentHideStatusV2.cs) | [AdminUpdateContentHideStatusV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateContentHideStatusV2.cs) |

### Admin Config Wrapper:  [AdminConfig](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v2/admin/namespaces/{namespace}/configs` | GET | AdminGetConfigs | [AdminGetConfigs](../../AccelByte.Sdk/Api/Ugc/Operation/AdminConfig/AdminGetConfigs.cs) | [AdminGetConfigs](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminConfig/AdminGetConfigs.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/configs/{key}` | PATCH | AdminUpdateConfig | [AdminUpdateConfig](../../AccelByte.Sdk/Api/Ugc/Operation/AdminConfig/AdminUpdateConfig.cs) | [AdminUpdateConfig](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminConfig/AdminUpdateConfig.cs) |

### Public Content V2 Wrapper:  [PublicContentV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicContentV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v2/public/namespaces/{namespace}/channels/{channelId}/contents` | GET | PublicGetContentByChannelIDV2 | [PublicGetContentByChannelIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentByChannelIDV2.cs) | [PublicGetContentByChannelIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentByChannelIDV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents` | GET | PublicListContentV2 | [PublicListContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicListContentV2.cs) | [PublicListContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicListContentV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/bulk` | POST | PublicBulkGetContentByIDV2 | [PublicBulkGetContentByIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicBulkGetContentByIDV2.cs) | [PublicBulkGetContentByIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicBulkGetContentByIDV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/sharecodes/bulk` | POST | PublicGetContentBulkByShareCodesV2 | [PublicGetContentBulkByShareCodesV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentBulkByShareCodesV2.cs) | [PublicGetContentBulkByShareCodesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentBulkByShareCodesV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | PublicGetContentByShareCodeV2 | [PublicGetContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentByShareCodeV2.cs) | [PublicGetContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentByShareCodeV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/{contentId}` | GET | PublicGetContentByIDV2 | [PublicGetContentByIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentByIDV2.cs) | [PublicGetContentByIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentByIDV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents` | POST | PublicCreateContentV2 | [PublicCreateContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicCreateContentV2.cs) | [PublicCreateContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicCreateContentV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | PublicUpdateContentByShareCodeV2 | [PublicUpdateContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicUpdateContentByShareCodeV2.cs) | [PublicUpdateContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicUpdateContentByShareCodeV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}` | DELETE | PublicDeleteContentByShareCodeV2 | [PublicDeleteContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicDeleteContentByShareCodeV2.cs) | [PublicDeleteContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicDeleteContentByShareCodeV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | DELETE | PublicDeleteContentV2 | [PublicDeleteContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicDeleteContentV2.cs) | [PublicDeleteContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicDeleteContentV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PATCH | PublicUpdateContentV2 | [PublicUpdateContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicUpdateContentV2.cs) | [PublicUpdateContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicUpdateContentV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/fileLocation` | PATCH | PublicUpdateContentFileLocation | [PublicUpdateContentFileLocation](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicUpdateContentFileLocation.cs) | [PublicUpdateContentFileLocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicUpdateContentFileLocation.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/sharecode` | PATCH | UpdateContentShareCodeV2 | [UpdateContentShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/UpdateContentShareCodeV2.cs) | [UpdateContentShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/UpdateContentShareCodeV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/uploadUrl` | PATCH | PublicGenerateContentUploadURLV2 | [PublicGenerateContentUploadURLV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGenerateContentUploadURLV2.cs) | [PublicGenerateContentUploadURLV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGenerateContentUploadURLV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/contents` | GET | PublicGetContentByUserIDV2 | [PublicGetContentByUserIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentByUserIDV2.cs) | [PublicGetContentByUserIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentByUserIDV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots` | PUT | UpdateScreenshotsV2 | [UpdateScreenshotsV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/UpdateScreenshotsV2.cs) | [UpdateScreenshotsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/UpdateScreenshotsV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots` | POST | UploadContentScreenshotV2 | [UploadContentScreenshotV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/UploadContentScreenshotV2.cs) | [UploadContentScreenshotV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/UploadContentScreenshotV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId}` | DELETE | DeleteContentScreenshotV2 | [DeleteContentScreenshotV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/DeleteContentScreenshotV2.cs) | [DeleteContentScreenshotV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/DeleteContentScreenshotV2.cs) |

### Public Download Count V2 Wrapper:  [PublicDownloadCountV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicDownloadCountV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v2/public/namespaces/{namespace}/contents/{contentId}/downloadcount` | POST | PublicAddDownloadCountV2 | [PublicAddDownloadCountV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicDownloadCountV2/PublicAddDownloadCountV2.cs) | [PublicAddDownloadCountV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicDownloadCountV2/PublicAddDownloadCountV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/{contentId}/downloader` | GET | PublicListContentDownloaderV2 | [PublicListContentDownloaderV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicDownloadCountV2/PublicListContentDownloaderV2.cs) | [PublicListContentDownloaderV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicDownloadCountV2/PublicListContentDownloaderV2.cs) |

### Public Like V2 Wrapper:  [PublicLikeV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicLikeV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v2/public/namespaces/{namespace}/contents/{contentId}/like` | GET | PublicListContentLikeV2 | [PublicListContentLikeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicLikeV2/PublicListContentLikeV2.cs) | [PublicListContentLikeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicLikeV2/PublicListContentLikeV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/{contentId}/like` | PUT | UpdateContentLikeStatusV2 | [UpdateContentLikeStatusV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicLikeV2/UpdateContentLikeStatusV2.cs) | [UpdateContentLikeStatusV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicLikeV2/UpdateContentLikeStatusV2.cs) |


&nbsp;  

## Operations with Generic Response

### Admin Channel Wrapper:  [AdminChannel](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Content Wrapper:  [AdminContent](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminContent.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents` | POST | AdminUploadContentDirect | [AdminUploadContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUploadContentDirect.cs) | [AdminUploadContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3` | POST | AdminUploadContentS3 | [AdminUploadContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUploadContentS3.cs) | [AdminUploadContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUploadContentS3.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId}` | PUT | SingleAdminUpdateContentS3 | [SingleAdminUpdateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/SingleAdminUpdateContentS3.cs) | [SingleAdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | PUT | SingleAdminUpdateContentDirect | [SingleAdminUpdateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/SingleAdminUpdateContentDirect.cs) | [SingleAdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/SingleAdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/bulk` | POST | AdminGetContentBulk | [AdminGetContentBulk](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetContentBulk.cs) | [AdminGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContentBulk.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/bulk` | POST | AdminGetContentBulkByShareCodes | [AdminGetContentBulkByShareCodes](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetContentBulkByShareCodes.cs) | [AdminGetContentBulkByShareCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetContentBulkByShareCodes.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | AdminGetUserContentByShareCode | [AdminGetUserContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetUserContentByShareCode.cs) | [AdminGetUserContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetUserContentByShareCode.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}` | GET | AdminGetSpecificContent | [AdminGetSpecificContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminGetSpecificContent.cs) | [AdminGetSpecificContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminGetSpecificContent.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/rollback/{versionId}` | PUT | RollbackContentVersion | [RollbackContentVersion](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/RollbackContentVersion.cs) | [RollbackContentVersion](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/RollbackContentVersion.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | AdminUpdateContentS3ByShareCode | [AdminUpdateContentS3ByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUpdateContentS3ByShareCode.cs) | [AdminUpdateContentS3ByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentS3ByShareCode.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | AdminUpdateContentS3 | [AdminUpdateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUpdateContentS3.cs) | [AdminUpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | AdminUpdateContentDirect | [AdminUpdateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminUpdateContentDirect.cs) | [AdminUpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminUpdateContentDirect.cs) |
| `/ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide` | PUT | AdminHideUserContent | [AdminHideUserContent](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContent/AdminHideUserContent.cs) | [AdminHideUserContent](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContent/AdminHideUserContent.cs) |

### Admin Group Wrapper:  [AdminGroup](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Tag Wrapper:  [AdminTag](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Type Wrapper:  [AdminType](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Anonymization Wrapper:  [Anonymization](../../AccelByte.Sdk/Api/Ugc/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Content (Legacy) Wrapper:  [PublicContentLegacy](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicContentLegacy.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v1/public/namespaces/{namespace}/contents/bulk` | POST | PublicGetContentBulk | [PublicGetContentBulk](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicGetContentBulk.cs) | [PublicGetContentBulk](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicGetContentBulk.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/bulk` | POST | PublicGetContentBulkByShareCodes | [PublicGetContentBulkByShareCodes](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicGetContentBulkByShareCodes.cs) | [PublicGetContentBulkByShareCodes](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicGetContentBulkByShareCodes.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | PublicDownloadContentByShareCode | [PublicDownloadContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicDownloadContentByShareCode.cs) | [PublicDownloadContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicDownloadContentByShareCode.cs) |
| `/ugc/v1/public/namespaces/{namespace}/contents/{contentId}` | GET | PublicDownloadContentByContentID | [PublicDownloadContentByContentID](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicDownloadContentByContentID.cs) | [PublicDownloadContentByContentID](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicDownloadContentByContentID.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents` | POST | CreateContentDirect | [CreateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/CreateContentDirect.cs) | [CreateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/CreateContentDirect.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3` | POST | CreateContentS3 | [CreateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/CreateContentS3.cs) | [CreateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/CreateContentS3.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | PublicUpdateContentByShareCode | [PublicUpdateContentByShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/PublicUpdateContentByShareCode.cs) | [PublicUpdateContentByShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/PublicUpdateContentByShareCode.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId}` | PUT | UpdateContentS3 | [UpdateContentS3](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UpdateContentS3.cs) | [UpdateContentS3](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UpdateContentS3.cs) |
| [DEPRECATED] `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PUT | UpdateContentDirect | [UpdateContentDirect](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UpdateContentDirect.cs) | [UpdateContentDirect](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UpdateContentDirect.cs) |
| `/ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/sharecode` | PATCH | UpdateContentShareCode | [UpdateContentShareCode](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentLegacy/UpdateContentShareCode.cs) | [UpdateContentShareCode](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentLegacy/UpdateContentShareCode.cs) |

### Public Follow Wrapper:  [PublicFollow](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicFollow.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Like (Legacy) Wrapper:  [PublicLikeLegacy](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicLikeLegacy.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Download Count (Legacy) Wrapper:  [PublicDownloadCountLegacy](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicDownloadCountLegacy.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Tag Wrapper:  [PublicTag](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicTag.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Type Wrapper:  [PublicType](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicType.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Creator Wrapper:  [PublicCreator](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicCreator.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Channel Wrapper:  [PublicChannel](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicChannel.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Group Wrapper:  [PublicGroup](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicGroup.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Admin Content V2 Wrapper:  [AdminContentV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminContentV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents` | POST | AdminCreateContentV2 | [AdminCreateContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminCreateContentV2.cs) | [AdminCreateContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminCreateContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}` | PATCH | AdminUpdateOfficialContentV2 | [AdminUpdateOfficialContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateOfficialContentV2.cs) | [AdminUpdateOfficialContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateOfficialContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId}/fileLocation` | PATCH | AdminUpdateOfficialContentFileLocation | [AdminUpdateOfficialContentFileLocation](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateOfficialContentFileLocation.cs) | [AdminUpdateOfficialContentFileLocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateOfficialContentFileLocation.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/bulk` | POST | AdminBulkGetContentByIDsV2 | [AdminBulkGetContentByIDsV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminBulkGetContentByIDsV2.cs) | [AdminBulkGetContentByIDsV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminBulkGetContentByIDsV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/sharecodes/bulk` | POST | AdminGetContentBulkByShareCodesV2 | [AdminGetContentBulkByShareCodesV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentBulkByShareCodesV2.cs) | [AdminGetContentBulkByShareCodesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentBulkByShareCodesV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | AdminGetContentByShareCodeV2 | [AdminGetContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentByShareCodeV2.cs) | [AdminGetContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentByShareCodeV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}` | GET | AdminGetContentByContentIDV2 | [AdminGetContentByContentIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminGetContentByContentIDV2.cs) | [AdminGetContentByContentIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminGetContentByContentIDV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/contents/{contentId}/rollback/{versionId}` | PUT | RollbackContentVersionV2 | [RollbackContentVersionV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/RollbackContentVersionV2.cs) | [RollbackContentVersionV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/RollbackContentVersionV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | AdminUpdateContentByShareCodeV2 | [AdminUpdateContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateContentByShareCodeV2.cs) | [AdminUpdateContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateContentByShareCodeV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PATCH | AdminUpdateUserContentV2 | [AdminUpdateUserContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateUserContentV2.cs) | [AdminUpdateUserContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateUserContentV2.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/fileLocation` | PATCH | AdminUpdateUserContentFileLocation | [AdminUpdateUserContentFileLocation](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateUserContentFileLocation.cs) | [AdminUpdateUserContentFileLocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateUserContentFileLocation.cs) |
| `/ugc/v2/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide` | PUT | AdminUpdateContentHideStatusV2 | [AdminUpdateContentHideStatusV2](../../AccelByte.Sdk/Api/Ugc/Operation/AdminContentV2/AdminUpdateContentHideStatusV2.cs) | [AdminUpdateContentHideStatusV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/AdminContentV2/AdminUpdateContentHideStatusV2.cs) |

### Admin Config Wrapper:  [AdminConfig](../../AccelByte.Sdk/Api/Ugc/Wrapper/AdminConfig.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Content V2 Wrapper:  [PublicContentV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicContentV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|
| `/ugc/v2/public/namespaces/{namespace}/contents/bulk` | POST | PublicBulkGetContentByIDV2 | [PublicBulkGetContentByIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicBulkGetContentByIDV2.cs) | [PublicBulkGetContentByIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicBulkGetContentByIDV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/sharecodes/bulk` | POST | PublicGetContentBulkByShareCodesV2 | [PublicGetContentBulkByShareCodesV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentBulkByShareCodesV2.cs) | [PublicGetContentBulkByShareCodesV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentBulkByShareCodesV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/sharecodes/{shareCode}` | GET | PublicGetContentByShareCodeV2 | [PublicGetContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentByShareCodeV2.cs) | [PublicGetContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentByShareCodeV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/contents/{contentId}` | GET | PublicGetContentByIDV2 | [PublicGetContentByIDV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicGetContentByIDV2.cs) | [PublicGetContentByIDV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicGetContentByIDV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents` | POST | PublicCreateContentV2 | [PublicCreateContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicCreateContentV2.cs) | [PublicCreateContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicCreateContentV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/sharecodes/{shareCode}` | PUT | PublicUpdateContentByShareCodeV2 | [PublicUpdateContentByShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicUpdateContentByShareCodeV2.cs) | [PublicUpdateContentByShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicUpdateContentByShareCodeV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}` | PATCH | PublicUpdateContentV2 | [PublicUpdateContentV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicUpdateContentV2.cs) | [PublicUpdateContentV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicUpdateContentV2.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/fileLocation` | PATCH | PublicUpdateContentFileLocation | [PublicUpdateContentFileLocation](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/PublicUpdateContentFileLocation.cs) | [PublicUpdateContentFileLocation](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/PublicUpdateContentFileLocation.cs) |
| `/ugc/v2/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId}/sharecode` | PATCH | UpdateContentShareCodeV2 | [UpdateContentShareCodeV2](../../AccelByte.Sdk/Api/Ugc/Operation/PublicContentV2/UpdateContentShareCodeV2.cs) | [UpdateContentShareCodeV2](../../samples/AccelByte.Sdk.Sample.Cli/ApiCommand/Ugc/PublicContentV2/UpdateContentShareCodeV2.cs) |

### Public Download Count V2 Wrapper:  [PublicDownloadCountV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicDownloadCountV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|

### Public Like V2 Wrapper:  [PublicLikeV2](../../AccelByte.Sdk/Api/Ugc/Wrapper/PublicLikeV2.cs)
| Endpoint | Method | ID | Class | Example |
|---|---|---|---|---|


&nbsp;  

## Models

| Model | Class |
|---|---|
| `models.AddDownloadCountResponse` | [ModelsAddDownloadCountResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsAddDownloadCountResponse.cs) |
| `models.AdminContentRequestV2` | [ModelsAdminContentRequestV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsAdminContentRequestV2.cs) |
| `models.AdminGetContentBulkRequest` | [ModelsAdminGetContentBulkRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsAdminGetContentBulkRequest.cs) |
| `models.AdminUpdateContentRequest` | [ModelsAdminUpdateContentRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsAdminUpdateContentRequest.cs) |
| `models.AdminUpdateContentRequestV2` | [ModelsAdminUpdateContentRequestV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsAdminUpdateContentRequestV2.cs) |
| `models.ChannelRequest` | [ModelsChannelRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsChannelRequest.cs) |
| `models.ChannelResponse` | [ModelsChannelResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsChannelResponse.cs) |
| `models.ConfigResponse` | [ModelsConfigResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsConfigResponse.cs) |
| `models.ContentDownloadResponse` | [ModelsContentDownloadResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentDownloadResponse.cs) |
| `models.ContentDownloadResponseV2` | [ModelsContentDownloadResponseV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentDownloadResponseV2.cs) |
| `models.ContentDownloaderResponse` | [ModelsContentDownloaderResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentDownloaderResponse.cs) |
| `models.ContentLikeRequest` | [ModelsContentLikeRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentLikeRequest.cs) |
| `models.ContentLikeResponse` | [ModelsContentLikeResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentLikeResponse.cs) |
| `models.ContentLikersResponse` | [ModelsContentLikersResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentLikersResponse.cs) |
| `models.ContentRequestV2` | [ModelsContentRequestV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentRequestV2.cs) |
| `models.ContentSnapshot` | [ModelsContentSnapshot](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentSnapshot.cs) |
| `models.ContentVersionResponse` | [ModelsContentVersionResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsContentVersionResponse.cs) |
| `models.CreateContentRequest` | [ModelsCreateContentRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateContentRequest.cs) |
| `models.CreateContentRequestS3` | [ModelsCreateContentRequestS3](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateContentRequestS3.cs) |
| `models.CreateContentResponse` | [ModelsCreateContentResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateContentResponse.cs) |
| `models.CreateContentResponseV2` | [ModelsCreateContentResponseV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateContentResponseV2.cs) |
| `models.CreateGroupRequest` | [ModelsCreateGroupRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateGroupRequest.cs) |
| `models.CreateGroupResponse` | [ModelsCreateGroupResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateGroupResponse.cs) |
| `models.CreateScreenshotRequest` | [ModelsCreateScreenshotRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateScreenshotRequest.cs) |
| `models.CreateScreenshotResponse` | [ModelsCreateScreenshotResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateScreenshotResponse.cs) |
| `models.CreateTagRequest` | [ModelsCreateTagRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTagRequest.cs) |
| `models.CreateTagResponse` | [ModelsCreateTagResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTagResponse.cs) |
| `models.CreateTypeRequest` | [ModelsCreateTypeRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTypeRequest.cs) |
| `models.CreateTypeResponse` | [ModelsCreateTypeResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTypeResponse.cs) |
| `models.CreatorFollowState` | [ModelsCreatorFollowState](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreatorFollowState.cs) |
| `models.CreatorOverviewResponse` | [ModelsCreatorOverviewResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreatorOverviewResponse.cs) |
| `models.CreatorResponse` | [ModelsCreatorResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreatorResponse.cs) |
| `models.GenerateContentUploadURLRequest` | [ModelsGenerateContentUploadURLRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsGenerateContentUploadURLRequest.cs) |
| `models.GenerateContentUploadURLResponse` | [ModelsGenerateContentUploadURLResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsGenerateContentUploadURLResponse.cs) |
| `models.GetContentBulkByShareCodesRequest` | [ModelsGetContentBulkByShareCodesRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsGetContentBulkByShareCodesRequest.cs) |
| `models.GetContentPreviewResponse` | [ModelsGetContentPreviewResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsGetContentPreviewResponse.cs) |
| `models.HideContentRequest` | [ModelsHideContentRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsHideContentRequest.cs) |
| `models.LikeState` | [ModelsLikeState](../../AccelByte.Sdk/Api/Ugc/Model/ModelsLikeState.cs) |
| `models.ListContentVersionsResponse` | [ModelsListContentVersionsResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsListContentVersionsResponse.cs) |
| `models.PaginatedContentDownloadResponse` | [ModelsPaginatedContentDownloadResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedContentDownloadResponse.cs) |
| `models.PaginatedContentDownloadResponseV2` | [ModelsPaginatedContentDownloadResponseV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedContentDownloadResponseV2.cs) |
| `models.PaginatedContentDownloaderResponse` | [ModelsPaginatedContentDownloaderResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedContentDownloaderResponse.cs) |
| `models.PaginatedContentLikersResponse` | [ModelsPaginatedContentLikersResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedContentLikersResponse.cs) |
| `models.PaginatedCreatorOverviewResponse` | [ModelsPaginatedCreatorOverviewResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedCreatorOverviewResponse.cs) |
| `models.PaginatedGetChannelResponse` | [ModelsPaginatedGetChannelResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGetChannelResponse.cs) |
| `models.PaginatedGetConfigsResponse` | [ModelsPaginatedGetConfigsResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGetConfigsResponse.cs) |
| `models.PaginatedGetTagResponse` | [ModelsPaginatedGetTagResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGetTagResponse.cs) |
| `models.PaginatedGetTypeResponse` | [ModelsPaginatedGetTypeResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGetTypeResponse.cs) |
| `models.PaginatedGroupResponse` | [ModelsPaginatedGroupResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGroupResponse.cs) |
| `models.PagingCursor` | [ModelsPagingCursor](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPagingCursor.cs) |
| `models.PayloadURL` | [ModelsPayloadURL](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPayloadURL.cs) |
| `models.PreviewURL` | [ModelsPreviewURL](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPreviewURL.cs) |
| `models.PublicChannelRequest` | [ModelsPublicChannelRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPublicChannelRequest.cs) |
| `models.PublicCreateContentRequestS3` | [ModelsPublicCreateContentRequestS3](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPublicCreateContentRequestS3.cs) |
| `models.PublicGetContentBulkRequest` | [ModelsPublicGetContentBulkRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPublicGetContentBulkRequest.cs) |
| `models.ScreenshotResponse` | [ModelsScreenshotResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsScreenshotResponse.cs) |
| `models.UpdateChannelRequest` | [ModelsUpdateChannelRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateChannelRequest.cs) |
| `models.UpdateConfigRequest` | [ModelsUpdateConfigRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateConfigRequest.cs) |
| `models.UpdateContentRequest` | [ModelsUpdateContentRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateContentRequest.cs) |
| `models.UpdateContentRequestV2` | [ModelsUpdateContentRequestV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateContentRequestV2.cs) |
| `models.UpdateContentResponseV2` | [ModelsUpdateContentResponseV2](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateContentResponseV2.cs) |
| `models.UpdateContentShareCodeRequest` | [ModelsUpdateContentShareCodeRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateContentShareCodeRequest.cs) |
| `models.UpdateFileLocationRequest` | [ModelsUpdateFileLocationRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateFileLocationRequest.cs) |
| `models.UpdateScreenshotRequest` | [ModelsUpdateScreenshotRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateScreenshotRequest.cs) |
| `models.UpdateScreenshotResponse` | [ModelsUpdateScreenshotResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateScreenshotResponse.cs) |
| `models.UserFollowRequest` | [ModelsUserFollowRequest](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUserFollowRequest.cs) |
| `models.UserFollowResponse` | [ModelsUserFollowResponse](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUserFollowResponse.cs) |
| `models.createScreenshotRequestItem` | [ModelsCreateScreenshotRequestItem](../../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateScreenshotRequestItem.cs) |
| `models.previewMetadata` | [ModelsPreviewMetadata](../../AccelByte.Sdk/Api/Ugc/Model/ModelsPreviewMetadata.cs) |
| `models.updateScreenshot` | [ModelsUpdateScreenshot](../../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateScreenshot.cs) |
| `response.Error` | [ResponseError](../../AccelByte.Sdk/Api/Ugc/Model/ResponseError.cs) |
