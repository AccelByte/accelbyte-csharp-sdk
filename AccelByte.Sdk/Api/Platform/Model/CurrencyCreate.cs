// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CurrencyCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
        [JsonPropertyName("currencySymbol")]
        public string? CurrencySymbol { get; set; }
        
        [JsonPropertyName("currencyType")]
        public string? CurrencyType { get; set; }
        
        [JsonPropertyName("decimals")]
        public int? Decimals { get; set; }
        
        [JsonPropertyName("localizationDescriptions")]
        public Dictionary<string, string>? LocalizationDescriptions { get; set; }
        
    }
}