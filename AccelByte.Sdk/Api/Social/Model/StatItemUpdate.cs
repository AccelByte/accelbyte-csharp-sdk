// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatItemUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<string, object>? AdditionalData { get; set; }
        
        [JsonPropertyName("updateStrategy")]
        public string? UpdateStrategy { get; set; }
        
        [JsonPropertyName("value")]
        public double? Value { get; set; }
        
    }
}