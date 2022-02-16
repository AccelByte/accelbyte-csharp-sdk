// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsUpdateChannelRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("findMatchTimeoutSeconds")]
        public int? FindMatchTimeoutSeconds { get; set; }
        
        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }
        
        [JsonPropertyName("max_delay_ms")]
        public int? MaxDelayMs { get; set; }
        
        [JsonPropertyName("ruleSet")]
        public ModelsUpdateRuleset? RuleSet { get; set; }
        
        [JsonPropertyName("sessionQueueTimeoutSeconds")]
        public int? SessionQueueTimeoutSeconds { get; set; }
        
        [JsonPropertyName("socialMatchmaking")]
        public bool? SocialMatchmaking { get; set; }
        
        [JsonPropertyName("use_sub_gamemode")]
        public bool? UseSubGamemode { get; set; }
        
    }
}