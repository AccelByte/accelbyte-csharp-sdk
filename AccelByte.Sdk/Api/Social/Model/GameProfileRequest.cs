// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class GameProfileRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("achievements")]
        public List<string>? Achievements { get; set; }
        
        [JsonPropertyName("attributes")]
        public Dictionary<string, string>? Attributes { get; set; }
        
        [JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }
        
        [JsonPropertyName("inventories")]
        public List<string>? Inventories { get; set; }
        
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        
        [JsonPropertyName("profileName")]
        public string? ProfileName { get; set; }
        
        [JsonPropertyName("statistics")]
        public List<string>? Statistics { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
    }
}