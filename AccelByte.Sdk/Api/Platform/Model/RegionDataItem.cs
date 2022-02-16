// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RegionDataItem : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
        [JsonPropertyName("currencyNamespace")]
        public string? CurrencyNamespace { get; set; }
        
        [JsonPropertyName("currencyType")]
        public string? CurrencyType { get; set; }
        
        [JsonPropertyName("discountAmount")]
        public int? DiscountAmount { get; set; }
        
        [JsonPropertyName("discountExpireAt")]
        public DateTime? DiscountExpireAt { get; set; }
        
        [JsonPropertyName("discountPercentage")]
        public int? DiscountPercentage { get; set; }
        
        [JsonPropertyName("discountPurchaseAt")]
        public DateTime? DiscountPurchaseAt { get; set; }
        
        [JsonPropertyName("discountedPrice")]
        public int? DiscountedPrice { get; set; }
        
        [JsonPropertyName("expireAt")]
        public DateTime? ExpireAt { get; set; }
        
        [JsonPropertyName("price")]
        public int? Price { get; set; }
        
        [JsonPropertyName("purchaseAt")]
        public DateTime? PurchaseAt { get; set; }
        
        [JsonPropertyName("trialPrice")]
        public int? TrialPrice { get; set; }
        
    }
}