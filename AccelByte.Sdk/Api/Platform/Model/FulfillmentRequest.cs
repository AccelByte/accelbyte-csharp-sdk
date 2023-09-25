// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("duration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Duration { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemSku { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Metadata { get; set; }

        [JsonPropertyName("order")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OrderSummary? Order { get; set; }

        [JsonPropertyName("orderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OrderNo { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FulfillmentRequestOrigin? Origin { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FulfillmentRequestSource? Source { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("storeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StoreId { get; set; }

    }

    public class FulfillmentRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("duration")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Duration { get; set; }

        [JsonPropertyName("endDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemSku { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Metadata { get; set; }

        [JsonPropertyName("order")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OrderSummary? Order { get; set; }

        [JsonPropertyName("orderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OrderNo { get; set; }

        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FulfillmentRequestOrigin? Origin { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public FulfillmentRequestSource? Source { get; set; }

        [JsonPropertyName("startDate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("storeId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StoreId { get; set; }

    }


    public class FulfillmentRequestOrigin : StringEnum<FulfillmentRequestOrigin>
    {
        public static readonly FulfillmentRequestOrigin Epic
            = new FulfillmentRequestOrigin("Epic");

        public static readonly FulfillmentRequestOrigin GooglePlay
            = new FulfillmentRequestOrigin("GooglePlay");

        public static readonly FulfillmentRequestOrigin IOS
            = new FulfillmentRequestOrigin("IOS");

        public static readonly FulfillmentRequestOrigin Nintendo
            = new FulfillmentRequestOrigin("Nintendo");

        public static readonly FulfillmentRequestOrigin Oculus
            = new FulfillmentRequestOrigin("Oculus");

        public static readonly FulfillmentRequestOrigin Other
            = new FulfillmentRequestOrigin("Other");

        public static readonly FulfillmentRequestOrigin Playstation
            = new FulfillmentRequestOrigin("Playstation");

        public static readonly FulfillmentRequestOrigin Steam
            = new FulfillmentRequestOrigin("Steam");

        public static readonly FulfillmentRequestOrigin System
            = new FulfillmentRequestOrigin("System");

        public static readonly FulfillmentRequestOrigin Twitch
            = new FulfillmentRequestOrigin("Twitch");

        public static readonly FulfillmentRequestOrigin Xbox
            = new FulfillmentRequestOrigin("Xbox");


        public static implicit operator FulfillmentRequestOrigin(string value)
        {
            return NewValue(value);
        }

        public FulfillmentRequestOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class FulfillmentRequestSource : StringEnum<FulfillmentRequestSource>
    {
        public static readonly FulfillmentRequestSource ACHIEVEMENT
            = new FulfillmentRequestSource("ACHIEVEMENT");

        public static readonly FulfillmentRequestSource CONSUMEENTITLEMENT
            = new FulfillmentRequestSource("CONSUME_ENTITLEMENT");

        public static readonly FulfillmentRequestSource DLC
            = new FulfillmentRequestSource("DLC");

        public static readonly FulfillmentRequestSource EXPIRATION
            = new FulfillmentRequestSource("EXPIRATION");

        public static readonly FulfillmentRequestSource GIFT
            = new FulfillmentRequestSource("GIFT");

        public static readonly FulfillmentRequestSource IAP
            = new FulfillmentRequestSource("IAP");

        public static readonly FulfillmentRequestSource IAPCHARGEBACKREVERSED
            = new FulfillmentRequestSource("IAP_CHARGEBACK_REVERSED");

        public static readonly FulfillmentRequestSource ORDERREVOCATION
            = new FulfillmentRequestSource("ORDER_REVOCATION");

        public static readonly FulfillmentRequestSource OTHER
            = new FulfillmentRequestSource("OTHER");

        public static readonly FulfillmentRequestSource PAYMENT
            = new FulfillmentRequestSource("PAYMENT");

        public static readonly FulfillmentRequestSource PROMOTION
            = new FulfillmentRequestSource("PROMOTION");

        public static readonly FulfillmentRequestSource PURCHASE
            = new FulfillmentRequestSource("PURCHASE");

        public static readonly FulfillmentRequestSource REDEEMCODE
            = new FulfillmentRequestSource("REDEEM_CODE");

        public static readonly FulfillmentRequestSource REFERRALBONUS
            = new FulfillmentRequestSource("REFERRAL_BONUS");

        public static readonly FulfillmentRequestSource REWARD
            = new FulfillmentRequestSource("REWARD");

        public static readonly FulfillmentRequestSource SELLBACK
            = new FulfillmentRequestSource("SELL_BACK");


        public static implicit operator FulfillmentRequestSource(string value)
        {
            return NewValue(value);
        }

        public FulfillmentRequestSource(string enumValue)
            : base(enumValue)
        {

        }
    }
}