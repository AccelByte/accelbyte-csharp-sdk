// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptContext : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("item")]
        public ItemInfo? Item { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("order")]
        public OrderSummary? Order { get; set; }
        
        [JsonPropertyName("source")]
        public string? Source { get; set; }
        
    }
}