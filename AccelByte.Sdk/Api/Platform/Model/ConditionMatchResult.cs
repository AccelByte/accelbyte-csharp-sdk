// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ConditionMatchResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("matched")]
        public bool? Matched { get; set; }

        [JsonPropertyName("matchedConditions")]
        public List<object>? MatchedConditions { get; set; }

        [JsonPropertyName("notMatchReason")]
        public string? NotMatchReason { get; set; }

    }
}