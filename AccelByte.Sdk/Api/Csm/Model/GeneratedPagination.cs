// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Csm.Model
{
    public class GeneratedPagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("first")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? First { get; set; }

        [JsonPropertyName("last")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Last { get; set; }

        [JsonPropertyName("next")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Next { get; set; }

        [JsonPropertyName("previous")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Previous { get; set; }

    }


}