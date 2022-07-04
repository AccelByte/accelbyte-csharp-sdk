// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EntitlementGrant : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("grantedCode")]
        public string? GrantedCode { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemNamespace")]
        public string? ItemNamespace { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public EntitlementGrantSource? Source { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

    }

    public class EntitlementGrantSource : StringEnum<EntitlementGrantSource>
    {
        public static readonly EntitlementGrantSource ACHIEVEMENT
            = new EntitlementGrantSource("ACHIEVEMENT");

        public static readonly EntitlementGrantSource GIFT
            = new EntitlementGrantSource("GIFT");

        public static readonly EntitlementGrantSource IAP
            = new EntitlementGrantSource("IAP");

        public static readonly EntitlementGrantSource OTHER
            = new EntitlementGrantSource("OTHER");

        public static readonly EntitlementGrantSource PROMOTION
            = new EntitlementGrantSource("PROMOTION");

        public static readonly EntitlementGrantSource PURCHASE
            = new EntitlementGrantSource("PURCHASE");

        public static readonly EntitlementGrantSource REDEEMCODE
            = new EntitlementGrantSource("REDEEM_CODE");

        public static readonly EntitlementGrantSource REFERRALBONUS
            = new EntitlementGrantSource("REFERRAL_BONUS");

        public static readonly EntitlementGrantSource REWARD
            = new EntitlementGrantSource("REWARD");


        public static implicit operator EntitlementGrantSource(string value)
        {
            return NewValue(value);
        }

        public EntitlementGrantSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}