// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class TierCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("index")]
        public int? Index { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("tier")]
        public TierInput? Tier { get; set; }
        
    }
}