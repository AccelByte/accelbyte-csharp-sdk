// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PredicateValidateResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("matched")]
        public List<string>? Matched { get; set; }

        [JsonPropertyName("predicateName")]
        public string? PredicateName { get; set; }

        [JsonPropertyName("unmatched")]
        public List<string>? Unmatched { get; set; }

        [JsonPropertyName("validated")]
        public bool? Validated { get; set; }

    }
}