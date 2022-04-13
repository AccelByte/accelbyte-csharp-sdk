// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }

        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSku")]
        public string? ItemSku { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("order")]
        public OrderSummary? Order { get; set; }

        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public FulfillmentRequestSource? Source { get; set; }

        [JsonPropertyName("startDate")]
        public DateTime? StartDate { get; set; }

        [JsonPropertyName("storeId")]
        public string? StoreId { get; set; }

    }

    public class FulfillmentRequestSource : StringEnum<FulfillmentRequestSource>
    {
        public static readonly FulfillmentRequestSource PURCHASE
            = new FulfillmentRequestSource("PURCHASE");

        public static readonly FulfillmentRequestSource IAP
            = new FulfillmentRequestSource("IAP");

        public static readonly FulfillmentRequestSource PROMOTION
            = new FulfillmentRequestSource("PROMOTION");

        public static readonly FulfillmentRequestSource ACHIEVEMENT
            = new FulfillmentRequestSource("ACHIEVEMENT");

        public static readonly FulfillmentRequestSource REFERRALBONUS
            = new FulfillmentRequestSource("REFERRAL_BONUS");

        public static readonly FulfillmentRequestSource REDEEMCODE
            = new FulfillmentRequestSource("REDEEM_CODE");

        public static readonly FulfillmentRequestSource REWARD
            = new FulfillmentRequestSource("REWARD");

        public static readonly FulfillmentRequestSource GIFT
            = new FulfillmentRequestSource("GIFT");

        public static readonly FulfillmentRequestSource DLC
            = new FulfillmentRequestSource("DLC");

        public static readonly FulfillmentRequestSource OTHER
            = new FulfillmentRequestSource("OTHER");


        public static implicit operator FulfillmentRequestSource(string value)
        {
            return Create(value);
        }

        public FulfillmentRequestSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}