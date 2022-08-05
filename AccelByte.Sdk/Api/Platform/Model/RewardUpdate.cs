// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RewardUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Description { get; set; }

        [JsonPropertyName("eventTopic")]
        public string? EventTopic { get; set; }

        [JsonPropertyName("maxAwarded")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxAwarded { get; set; }

        [JsonPropertyName("maxAwardedPerUser")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MaxAwardedPerUser { get; set; }

        [JsonPropertyName("namespaceExpression")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NamespaceExpression { get; set; }

        [JsonPropertyName("rewardCode")]
        public string? RewardCode { get; set; }

        [JsonPropertyName("rewardConditions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<RewardCondition>? RewardConditions { get; set; }

        [JsonPropertyName("userIdExpression")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? UserIdExpression { get; set; }

    }
}