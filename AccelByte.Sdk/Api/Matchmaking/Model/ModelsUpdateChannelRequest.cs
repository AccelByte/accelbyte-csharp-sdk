// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsUpdateChannelRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("blocked_player_option")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ModelsUpdateChannelRequestBlockedPlayerOption? BlockedPlayerOption { get; set; }

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

        [JsonPropertyName("region_expansion_range_ms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RegionExpansionRangeMs { get; set; }

        [JsonPropertyName("region_expansion_rate_ms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RegionExpansionRateMs { get; set; }

        [JsonPropertyName("region_latency_initial_range_ms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RegionLatencyInitialRangeMs { get; set; }

        [JsonPropertyName("region_latency_max_ms")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RegionLatencyMaxMs { get; set; }

        [JsonPropertyName("ruleSet")]
        public ModelsUpdateRuleset? RuleSet { get; set; }

        [JsonPropertyName("sessionQueueTimeoutSeconds")]
        public int? SessionQueueTimeoutSeconds { get; set; }

        [JsonPropertyName("socialMatchmaking")]
        public bool? SocialMatchmaking { get; set; }

        [JsonPropertyName("sub_gamemode_selection")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public ModelsUpdateChannelRequestSubGamemodeSelection? SubGamemodeSelection { get; set; }

        [JsonPropertyName("ticket_observability_enable")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? TicketObservabilityEnable { get; set; }

        [JsonPropertyName("use_sub_gamemode")]
        public bool? UseSubGamemode { get; set; }

    }



    public class ModelsUpdateChannelRequestBlockedPlayerOption : StringEnum<ModelsUpdateChannelRequestBlockedPlayerOption>
    {
        public static readonly ModelsUpdateChannelRequestBlockedPlayerOption BlockedPlayerCanMatch
            = new ModelsUpdateChannelRequestBlockedPlayerOption("blockedPlayerCanMatch");

        public static readonly ModelsUpdateChannelRequestBlockedPlayerOption BlockedPlayerCanMatchOnDifferentTeam
            = new ModelsUpdateChannelRequestBlockedPlayerOption("blockedPlayerCanMatchOnDifferentTeam");

        public static readonly ModelsUpdateChannelRequestBlockedPlayerOption BlockedPlayerCannotMatch
            = new ModelsUpdateChannelRequestBlockedPlayerOption("blockedPlayerCannotMatch");


        public static implicit operator ModelsUpdateChannelRequestBlockedPlayerOption(string value)
        {
            return NewValue(value);
        }

        public ModelsUpdateChannelRequestBlockedPlayerOption(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class ModelsUpdateChannelRequestSubGamemodeSelection : StringEnum<ModelsUpdateChannelRequestSubGamemodeSelection>
    {
        public static readonly ModelsUpdateChannelRequestSubGamemodeSelection Random
            = new ModelsUpdateChannelRequestSubGamemodeSelection("random");

        public static readonly ModelsUpdateChannelRequestSubGamemodeSelection TicketOrder
            = new ModelsUpdateChannelRequestSubGamemodeSelection("ticketOrder");


        public static implicit operator ModelsUpdateChannelRequestSubGamemodeSelection(string value)
        {
            return NewValue(value);
        }

        public ModelsUpdateChannelRequestSubGamemodeSelection(string enumValue)
            : base(enumValue)
        {

        }
    }
}