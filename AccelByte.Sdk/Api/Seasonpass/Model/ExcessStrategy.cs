// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ExcessStrategy : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currency")]
        public string? Currency { get; set; }
        
        [JsonPropertyName("method")]
        public string? Method { get; set; }
        
        [JsonPropertyName("percentPerExp")]
        public int? PercentPerExp { get; set; }
        
    }
}