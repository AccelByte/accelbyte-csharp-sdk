// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsChannelV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("findMatchTimeoutSeconds")]
        public int? FindMatchTimeoutSeconds { get; set; }

        [JsonPropertyName("gameMode")]
        public string? GameMode { get; set; }

        [JsonPropertyName("joinable")]
        public bool? Joinable { get; set; }

        [JsonPropertyName("max_delay_ms")]
        public int? MaxDelayMs { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("region_expansion_range_ms")]
        public int? RegionExpansionRangeMs { get; set; }

        [JsonPropertyName("region_expansion_rate_ms")]
        public int? RegionExpansionRateMs { get; set; }

        [JsonPropertyName("region_latency_initial_range_ms")]
        public int? RegionLatencyInitialRangeMs { get; set; }

        [JsonPropertyName("region_latency_max_ms")]
        public int? RegionLatencyMaxMs { get; set; }

        [JsonPropertyName("ruleSet")]
        public ModelsRuleSetV1? RuleSet { get; set; }

        [JsonPropertyName("sessionQueueTimeoutSeconds")]
        public int? SessionQueueTimeoutSeconds { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonPropertyName("socialMatchmaking")]
        public bool? SocialMatchmaking { get; set; }

        [JsonPropertyName("ticket_observability_enable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TicketObservabilityEnable { get; set; }

        [JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        [JsonPropertyName("use_sub_gamemode")]
        public bool? UseSubGamemode { get; set; }

    }


}