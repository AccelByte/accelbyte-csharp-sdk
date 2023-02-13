// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreatorResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("creatorFollowState")]
        public ModelsCreatorFollowState? CreatorFollowState { get; set; }

        [JsonPropertyName("followCount")]
        public int? FollowCount { get; set; }

        [JsonPropertyName("followingCount")]
        public int? FollowingCount { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("parentNamespace")]
        public string? ParentNamespace { get; set; }

        [JsonPropertyName("totalLikedContent")]
        public long? TotalLikedContent { get; set; }

    }


}