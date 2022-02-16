// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class GameProfilePublicInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("profileId")]
        public string? ProfileId { get; set; }
        
        [JsonPropertyName("profileName")]
        public string? ProfileName { get; set; }
        
    }
}