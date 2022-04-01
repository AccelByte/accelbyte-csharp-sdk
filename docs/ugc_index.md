# Ugc Service Index

&nbsp;  

## Operations

### Admin Channel Wrapper:  [AdminChannel](../AccelByte.Sdk/Api/Ugc/Wrapper/AdminChannel.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/admin/namespaces/{namespace}/channels | GET | SingleAdminGetChannel | [SingleAdminGetChannel](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminGetChannel.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels | POST | AdminCreateChannel | [AdminCreateChannel](../AccelByte.Sdk/Api/Ugc/Operation//AdminCreateChannel.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId} | PUT | SingleAdminUpdateChannel | [SingleAdminUpdateChannel](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminUpdateChannel.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId} | DELETE | SingleAdminDeleteChannel | [SingleAdminDeleteChannel](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminDeleteChannel.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels | GET | AdminGetChannel | [AdminGetChannel](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetChannel.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId} | PUT | AdminUpdateChannel | [AdminUpdateChannel](../AccelByte.Sdk/Api/Ugc/Operation//AdminUpdateChannel.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId} | DELETE | AdminDeleteChannel | [AdminDeleteChannel](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteChannel.cs) |

### Admin Content Wrapper:  [AdminContent](../AccelByte.Sdk/Api/Ugc/Wrapper/AdminContent.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents | POST | AdminUploadContentDirect | [AdminUploadContentDirect](../AccelByte.Sdk/Api/Ugc/Operation//AdminUploadContentDirect.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3 | POST | AdminUploadContentS3 | [AdminUploadContentS3](../AccelByte.Sdk/Api/Ugc/Operation//AdminUploadContentS3.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/s3/{contentId} | PUT | SingleAdminUpdateContentS3 | [SingleAdminUpdateContentS3](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminUpdateContentS3.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/search | GET | AdminSearchChannelSpecificContent | [AdminSearchChannelSpecificContent](../AccelByte.Sdk/Api/Ugc/Operation//AdminSearchChannelSpecificContent.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId} | PUT | SingleAdminUpdateContentDirect | [SingleAdminUpdateContentDirect](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminUpdateContentDirect.cs) |
| /ugc/v1/admin/namespaces/{namespace}/channels/{channelId}/contents/{contentId} | DELETE | SingleAdminDeleteContent | [SingleAdminDeleteContent](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminDeleteContent.cs) |
| /ugc/v1/admin/namespaces/{namespace}/contents | GET | SingleAdminGetContent | [SingleAdminGetContent](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminGetContent.cs) |
| /ugc/v1/admin/namespaces/{namespace}/contents/search | GET | AdminSearchContent | [AdminSearchContent](../AccelByte.Sdk/Api/Ugc/Operation//AdminSearchContent.cs) |
| /ugc/v1/admin/namespaces/{namespace}/contents/{contentId} | GET | AdminGetSpecificContent | [AdminGetSpecificContent](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetSpecificContent.cs) |
| /ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/preview | GET | AdminDownloadContentPreview | [AdminDownloadContentPreview](../AccelByte.Sdk/Api/Ugc/Operation//AdminDownloadContentPreview.cs) |
| /ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots | PUT | AdminUpdateScreenshots | [AdminUpdateScreenshots](../AccelByte.Sdk/Api/Ugc/Operation//AdminUpdateScreenshots.cs) |
| /ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots | POST | AdminUploadContentScreenshot | [AdminUploadContentScreenshot](../AccelByte.Sdk/Api/Ugc/Operation//AdminUploadContentScreenshot.cs) |
| /ugc/v1/admin/namespaces/{namespace}/contents/{contentId}/screenshots/{screenshotId} | DELETE | AdminDeleteContentScreenshot | [AdminDeleteContentScreenshot](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteContentScreenshot.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} | PUT | AdminUpdateContentS3 | [AdminUpdateContentS3](../AccelByte.Sdk/Api/Ugc/Operation//AdminUpdateContentS3.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} | PUT | AdminUpdateContentDirect | [AdminUpdateContentDirect](../AccelByte.Sdk/Api/Ugc/Operation//AdminUpdateContentDirect.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} | DELETE | AdminDeleteContent | [AdminDeleteContent](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteContent.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents | GET | AdminGetContent | [AdminGetContent](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetContent.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents/{contentId}/hide | PUT | AdminHideUserContent | [AdminHideUserContent](../AccelByte.Sdk/Api/Ugc/Operation//AdminHideUserContent.cs) |

### Admin Group Wrapper:  [AdminGroup](../AccelByte.Sdk/Api/Ugc/Wrapper/AdminGroup.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/admin/namespaces/{namespace}/groups | GET | SingleAdminGetAllGroups | [SingleAdminGetAllGroups](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminGetAllGroups.cs) |
| /ugc/v1/admin/namespaces/{namespace}/groups | POST | AdminCreateGroup | [AdminCreateGroup](../AccelByte.Sdk/Api/Ugc/Operation//AdminCreateGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/groups/{groupId} | GET | SingleAdminGetGroup | [SingleAdminGetGroup](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminGetGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/groups/{groupId} | PUT | SingleAdminUpdateGroup | [SingleAdminUpdateGroup](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminUpdateGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/groups/{groupId} | DELETE | SingleAdminDeleteGroup | [SingleAdminDeleteGroup](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminDeleteGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/groups/{groupId}/contents | GET | SingleAdminGetGroupContents | [SingleAdminGetGroupContents](../AccelByte.Sdk/Api/Ugc/Operation//SingleAdminGetGroupContents.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups | GET | AdminGetAllGroups | [AdminGetAllGroups](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetAllGroups.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId} | GET | AdminGetGroup | [AdminGetGroup](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId} | PUT | AdminUpdateGroup | [AdminUpdateGroup](../AccelByte.Sdk/Api/Ugc/Operation//AdminUpdateGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId} | DELETE | AdminDeleteGroup | [AdminDeleteGroup](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents | GET | AdminGetGroupContents | [AdminGetGroupContents](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetGroupContents.cs) |

### Admin Tag Wrapper:  [AdminTag](../AccelByte.Sdk/Api/Ugc/Wrapper/AdminTag.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/admin/namespaces/{namespace}/tags | GET | AdminGetTag | [AdminGetTag](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetTag.cs) |
| /ugc/v1/admin/namespaces/{namespace}/tags | POST | AdminCreateTag | [AdminCreateTag](../AccelByte.Sdk/Api/Ugc/Operation//AdminCreateTag.cs) |
| /ugc/v1/admin/namespaces/{namespace}/tags/{tagId} | PUT | AdminUpdateTag | [AdminUpdateTag](../AccelByte.Sdk/Api/Ugc/Operation//AdminUpdateTag.cs) |
| /ugc/v1/admin/namespaces/{namespace}/tags/{tagId} | DELETE | AdminDeleteTag | [AdminDeleteTag](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteTag.cs) |

### Admin Type Wrapper:  [AdminType](../AccelByte.Sdk/Api/Ugc/Wrapper/AdminType.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/admin/namespaces/{namespace}/types | GET | AdminGetType | [AdminGetType](../AccelByte.Sdk/Api/Ugc/Operation//AdminGetType.cs) |
| /ugc/v1/admin/namespaces/{namespace}/types | POST | AdminCreateType | [AdminCreateType](../AccelByte.Sdk/Api/Ugc/Operation//AdminCreateType.cs) |
| /ugc/v1/admin/namespaces/{namespace}/types/{typeId} | PUT | AdminUpdateType | [AdminUpdateType](../AccelByte.Sdk/Api/Ugc/Operation//AdminUpdateType.cs) |
| /ugc/v1/admin/namespaces/{namespace}/types/{typeId} | DELETE | AdminDeleteType | [AdminDeleteType](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteType.cs) |

### Anonymization Wrapper:  [Anonymization](../AccelByte.Sdk/Api/Ugc/Wrapper/Anonymization.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/channels | DELETE | AdminDeleteAllUserChannels | [AdminDeleteAllUserChannels](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteAllUserChannels.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/contents | DELETE | AdminDeleteAllUserContents | [AdminDeleteAllUserContents](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteAllUserContents.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/groups | DELETE | AdminDeleteAllUserGroup | [AdminDeleteAllUserGroup](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteAllUserGroup.cs) |
| /ugc/v1/admin/namespaces/{namespace}/users/{userId}/states | DELETE | AdminDeleteAllUserStates | [AdminDeleteAllUserStates](../AccelByte.Sdk/Api/Ugc/Operation//AdminDeleteAllUserStates.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels | DELETE | DeleteAllUserChannel | [DeleteAllUserChannel](../AccelByte.Sdk/Api/Ugc/Operation//DeleteAllUserChannel.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents | DELETE | DeleteAllUserContents | [DeleteAllUserContents](../AccelByte.Sdk/Api/Ugc/Operation//DeleteAllUserContents.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups | DELETE | DeleteAllUserGroup | [DeleteAllUserGroup](../AccelByte.Sdk/Api/Ugc/Operation//DeleteAllUserGroup.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/states | DELETE | DeleteAllUserStates | [DeleteAllUserStates](../AccelByte.Sdk/Api/Ugc/Operation//DeleteAllUserStates.cs) |

### Public Content Wrapper:  [PublicContent](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicContent.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/channels/{channelId}/contents | GET | SearchChannelSpecificContent | [SearchChannelSpecificContent](../AccelByte.Sdk/Api/Ugc/Operation//SearchChannelSpecificContent.cs) |
| /ugc/v1/public/namespaces/{namespace}/contents | GET | PublicSearchContent | [PublicSearchContent](../AccelByte.Sdk/Api/Ugc/Operation//PublicSearchContent.cs) |
| /ugc/v1/public/namespaces/{namespace}/contents/sharecodes/{shareCode} | GET | DownloadContentByShareCode | [DownloadContentByShareCode](../AccelByte.Sdk/Api/Ugc/Operation//DownloadContentByShareCode.cs) |
| /ugc/v1/public/namespaces/{namespace}/contents/{contentId} | GET | PublicDownloadContentByContentID | [PublicDownloadContentByContentID](../AccelByte.Sdk/Api/Ugc/Operation//PublicDownloadContentByContentID.cs) |
| /ugc/v1/public/namespaces/{namespace}/contents/{contentId}/preview | GET | PublicDownloadContentPreview | [PublicDownloadContentPreview](../AccelByte.Sdk/Api/Ugc/Operation//PublicDownloadContentPreview.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents | POST | CreateContentDirect | [CreateContentDirect](../AccelByte.Sdk/Api/Ugc/Operation//CreateContentDirect.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3 | POST | CreateContentS3 | [CreateContentS3](../AccelByte.Sdk/Api/Ugc/Operation//CreateContentS3.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/s3/{contentId} | PUT | UpdateContentS3 | [UpdateContentS3](../AccelByte.Sdk/Api/Ugc/Operation//UpdateContentS3.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} | PUT | UpdateContentDirect | [UpdateContentDirect](../AccelByte.Sdk/Api/Ugc/Operation//UpdateContentDirect.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/{contentId} | DELETE | DeleteContent | [DeleteContent](../AccelByte.Sdk/Api/Ugc/Operation//DeleteContent.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents | GET | PublicGetUserContent | [PublicGetUserContent](../AccelByte.Sdk/Api/Ugc/Operation//PublicGetUserContent.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots | PUT | UpdateScreenshots | [UpdateScreenshots](../AccelByte.Sdk/Api/Ugc/Operation//UpdateScreenshots.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots | POST | UploadContentScreenshot | [UploadContentScreenshot](../AccelByte.Sdk/Api/Ugc/Operation//UploadContentScreenshot.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/contents/{contentId}/screenshots/{screenshotId} | DELETE | DeleteContentScreenshot | [DeleteContentScreenshot](../AccelByte.Sdk/Api/Ugc/Operation//DeleteContentScreenshot.cs) |

### Public Follow Wrapper:  [PublicFollow](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicFollow.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/contents/followed | GET | GetFollowedContent | [GetFollowedContent](../AccelByte.Sdk/Api/Ugc/Operation//GetFollowedContent.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/followed | GET | GetFollowedUsers | [GetFollowedUsers](../AccelByte.Sdk/Api/Ugc/Operation//GetFollowedUsers.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/follow | PUT | UpdateUserFollowStatus | [UpdateUserFollowStatus](../AccelByte.Sdk/Api/Ugc/Operation//UpdateUserFollowStatus.cs) |

### Public Like Wrapper:  [PublicLike](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicLike.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/contents/liked | GET | GetLikedContent | [GetLikedContent](../AccelByte.Sdk/Api/Ugc/Operation//GetLikedContent.cs) |
| /ugc/v1/public/namespaces/{namespace}/contents/{contentId}/like | PUT | UpdateContentLikeStatus | [UpdateContentLikeStatus](../AccelByte.Sdk/Api/Ugc/Operation//UpdateContentLikeStatus.cs) |

### Public Download Count Wrapper:  [PublicDownloadCount](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicDownloadCount.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/contents/{contentId}/downloadcount | POST | AddDownloadCount | [AddDownloadCount](../AccelByte.Sdk/Api/Ugc/Operation//AddDownloadCount.cs) |

### Public Tag Wrapper:  [PublicTag](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicTag.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/tags | GET | GetTag | [GetTag](../AccelByte.Sdk/Api/Ugc/Operation//GetTag.cs) |

### Public Type Wrapper:  [PublicType](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicType.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/types | GET | GetType | [GetType](../AccelByte.Sdk/Api/Ugc/Operation//GetType.cs) |

### Public Channel Wrapper:  [PublicChannel](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicChannel.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels | GET | GetChannels | [GetChannels](../AccelByte.Sdk/Api/Ugc/Operation//GetChannels.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels | POST | CreateChannel | [CreateChannel](../AccelByte.Sdk/Api/Ugc/Operation//CreateChannel.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId} | PUT | UpdateChannel | [UpdateChannel](../AccelByte.Sdk/Api/Ugc/Operation//UpdateChannel.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/channels/{channelId} | DELETE | DeleteChannel | [DeleteChannel](../AccelByte.Sdk/Api/Ugc/Operation//DeleteChannel.cs) |

### Public Group Wrapper:  [PublicGroup](../AccelByte.Sdk/Api/Ugc/Wrapper/PublicGroup.cs)
| Endpoint | Method | ID | Class |
|---|---|---|---|
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups | GET | GetGroups | [GetGroups](../AccelByte.Sdk/Api/Ugc/Operation//GetGroups.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups | POST | CreateGroup | [CreateGroup](../AccelByte.Sdk/Api/Ugc/Operation//CreateGroup.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId} | GET | GetGroup | [GetGroup](../AccelByte.Sdk/Api/Ugc/Operation//GetGroup.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId} | PUT | UpdateGroup | [UpdateGroup](../AccelByte.Sdk/Api/Ugc/Operation//UpdateGroup.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId} | DELETE | DeleteGroup | [DeleteGroup](../AccelByte.Sdk/Api/Ugc/Operation//DeleteGroup.cs) |
| /ugc/v1/public/namespaces/{namespace}/users/{userId}/groups/{groupId}/contents | GET | GetGroupContent | [GetGroupContent](../AccelByte.Sdk/Api/Ugc/Operation//GetGroupContent.cs) |


&nbsp;  

## Models

| Model | Class |
|---|---|
| models.AddDownloadCountResponse | [ModelsAddDownloadCountResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsAddDownloadCountResponse.cs) |
| models.ChannelRequest | [ModelsChannelRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsChannelRequest.cs) |
| models.ChannelResponse | [ModelsChannelResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsChannelResponse.cs) |
| models.ContentDownloadResponse | [ModelsContentDownloadResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsContentDownloadResponse.cs) |
| models.ContentLikeRequest | [ModelsContentLikeRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsContentLikeRequest.cs) |
| models.ContentLikeResponse | [ModelsContentLikeResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsContentLikeResponse.cs) |
| models.CreateContentRequest | [ModelsCreateContentRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateContentRequest.cs) |
| models.CreateContentRequestS3 | [ModelsCreateContentRequestS3](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateContentRequestS3.cs) |
| models.CreateContentResponse | [ModelsCreateContentResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateContentResponse.cs) |
| models.CreateGroupRequest | [ModelsCreateGroupRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateGroupRequest.cs) |
| models.CreateGroupResponse | [ModelsCreateGroupResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateGroupResponse.cs) |
| models.CreateScreenshotRequest | [ModelsCreateScreenshotRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateScreenshotRequest.cs) |
| models.CreateScreenshotResponse | [ModelsCreateScreenshotResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateScreenshotResponse.cs) |
| models.CreateTagRequest | [ModelsCreateTagRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTagRequest.cs) |
| models.CreateTagResponse | [ModelsCreateTagResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTagResponse.cs) |
| models.CreateTypeRequest | [ModelsCreateTypeRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTypeRequest.cs) |
| models.CreateTypeResponse | [ModelsCreateTypeResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateTypeResponse.cs) |
| models.CreatorFollowState | [ModelsCreatorFollowState](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreatorFollowState.cs) |
| models.CreatorOverviewResponse | [ModelsCreatorOverviewResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreatorOverviewResponse.cs) |
| models.GetContentPreviewResponse | [ModelsGetContentPreviewResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsGetContentPreviewResponse.cs) |
| models.HideContentRequest | [ModelsHideContentRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsHideContentRequest.cs) |
| models.LikeState | [ModelsLikeState](../AccelByte.Sdk/Api/Ugc/Model/ModelsLikeState.cs) |
| models.PaginatedContentDownloadResponse | [ModelsPaginatedContentDownloadResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedContentDownloadResponse.cs) |
| models.PaginatedCreatorOverviewResponse | [ModelsPaginatedCreatorOverviewResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedCreatorOverviewResponse.cs) |
| models.PaginatedGetChannelResponse | [ModelsPaginatedGetChannelResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGetChannelResponse.cs) |
| models.PaginatedGetTagResponse | [ModelsPaginatedGetTagResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGetTagResponse.cs) |
| models.PaginatedGetTypeResponse | [ModelsPaginatedGetTypeResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGetTypeResponse.cs) |
| models.PaginatedGroupResponse | [ModelsPaginatedGroupResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsPaginatedGroupResponse.cs) |
| models.PagingCursor | [ModelsPagingCursor](../AccelByte.Sdk/Api/Ugc/Model/ModelsPagingCursor.cs) |
| models.PayloadURL | [ModelsPayloadURL](../AccelByte.Sdk/Api/Ugc/Model/ModelsPayloadURL.cs) |
| models.ScreenshotResponse | [ModelsScreenshotResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsScreenshotResponse.cs) |
| models.UpdateScreenshotRequest | [ModelsUpdateScreenshotRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateScreenshotRequest.cs) |
| models.UpdateScreenshotResponse | [ModelsUpdateScreenshotResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateScreenshotResponse.cs) |
| models.UserFollowRequest | [ModelsUserFollowRequest](../AccelByte.Sdk/Api/Ugc/Model/ModelsUserFollowRequest.cs) |
| models.UserFollowResponse | [ModelsUserFollowResponse](../AccelByte.Sdk/Api/Ugc/Model/ModelsUserFollowResponse.cs) |
| models.createScreenshotRequestItem | [ModelsCreateScreenshotRequestItem](../AccelByte.Sdk/Api/Ugc/Model/ModelsCreateScreenshotRequestItem.cs) |
| models.updateScreenshot | [ModelsUpdateScreenshot](../AccelByte.Sdk/Api/Ugc/Model/ModelsUpdateScreenshot.cs) |
| response.Error | [ResponseError](../AccelByte.Sdk/Api/Ugc/Model/ResponseError.cs) |
