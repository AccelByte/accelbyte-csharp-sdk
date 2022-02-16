// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsContentDownloadResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("channelId")]
        public string? ChannelId { get; set; }
        
        [JsonPropertyName("createdTime")]
        public string? CreatedTime { get; set; }
        
        [JsonPropertyName("creatorFollowState")]
        public ModelsCreatorFollowState? CreatorFollowState { get; set; }
        
        [JsonPropertyName("creatorName")]
        public string? CreatorName { get; set; }
        
        [JsonPropertyName("downloadCount")]
        public int? DownloadCount { get; set; }
        
        [JsonPropertyName("fileExtension")]
        public string? FileExtension { get; set; }
        
        [JsonPropertyName("groups")]
        public List<string>? Groups { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("isHidden")]
        public bool? IsHidden { get; set; }
        
        [JsonPropertyName("isOfficial")]
        public bool? IsOfficial { get; set; }
        
        [JsonPropertyName("likeCount")]
        public int? LikeCount { get; set; }
        
        [JsonPropertyName("likeState")]
        public ModelsLikeState? LikeState { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("payload")]
        public string? Payload { get; set; }
        
        [JsonPropertyName("payloadURL")]
        public List<ModelsPayloadURL>? PayloadURL { get; set; }
        
        [JsonPropertyName("screenshots")]
        public List<ModelsScreenshotResponse>? Screenshots { get; set; }
        
        [JsonPropertyName("shareCode")]
        public string? ShareCode { get; set; }
        
        [JsonPropertyName("subType")]
        public string? SubType { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}