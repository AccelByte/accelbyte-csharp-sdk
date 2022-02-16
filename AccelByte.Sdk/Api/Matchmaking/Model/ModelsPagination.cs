// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ModelsPagination : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("first")]
        public string? First { get; set; }
        
        [JsonPropertyName("last")]
        public string? Last { get; set; }
        
        [JsonPropertyName("next")]
        public string? Next { get; set; }
        
        [JsonPropertyName("previous")]
        public string? Previous { get; set; }
        
    }
}