// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsChannel : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("find_match_timeout_seconds")]
        public int? FindMatchTimeoutSeconds { get; set; }
        
        [JsonPropertyName("game_mode")]
        public string? GameMode { get; set; }
        
        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }
        
        [JsonPropertyName("max_delay_ms")]
        public int? MaxDelayMs { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("ruleset")]
        public ModelsRuleSet? Ruleset { get; set; }
        
        [JsonPropertyName("session_queue_timeout_seconds")]
        public int? SessionQueueTimeoutSeconds { get; set; }
        
        [JsonPropertyName("slug")]
        public string? Slug { get; set; }
        
        [JsonPropertyName("social_matchmaking")]
        public bool? SocialMatchmaking { get; set; }
        
        [JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }
        
        [JsonPropertyName("use_sub_gamemode")]
        public bool? UseSubGamemode { get; set; }
        
    }
}