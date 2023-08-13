// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptContext : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("item")]
        public ItemInfo? Item { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("order")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OrderSummary? Order { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public FulfillmentScriptContextSource? Source { get; set; }

    }



    public class FulfillmentScriptContextSource : StringEnum<FulfillmentScriptContextSource>
    {
        public static readonly FulfillmentScriptContextSource ACHIEVEMENT
            = new FulfillmentScriptContextSource("ACHIEVEMENT");

        public static readonly FulfillmentScriptContextSource CONSUMEENTITLEMENT
            = new FulfillmentScriptContextSource("CONSUME_ENTITLEMENT");

        public static readonly FulfillmentScriptContextSource DLC
            = new FulfillmentScriptContextSource("DLC");

        public static readonly FulfillmentScriptContextSource DLCREVOCATION
            = new FulfillmentScriptContextSource("DLC_REVOCATION");

        public static readonly FulfillmentScriptContextSource EXPIRATION
            = new FulfillmentScriptContextSource("EXPIRATION");

        public static readonly FulfillmentScriptContextSource GIFT
            = new FulfillmentScriptContextSource("GIFT");

        public static readonly FulfillmentScriptContextSource IAP
            = new FulfillmentScriptContextSource("IAP");

        public static readonly FulfillmentScriptContextSource ORDERREVOCATION
            = new FulfillmentScriptContextSource("ORDER_REVOCATION");

        public static readonly FulfillmentScriptContextSource OTHER
            = new FulfillmentScriptContextSource("OTHER");

        public static readonly FulfillmentScriptContextSource PAYMENT
            = new FulfillmentScriptContextSource("PAYMENT");

        public static readonly FulfillmentScriptContextSource PROMOTION
            = new FulfillmentScriptContextSource("PROMOTION");

        public static readonly FulfillmentScriptContextSource PURCHASE
            = new FulfillmentScriptContextSource("PURCHASE");

        public static readonly FulfillmentScriptContextSource REDEEMCODE
            = new FulfillmentScriptContextSource("REDEEM_CODE");

        public static readonly FulfillmentScriptContextSource REFERRALBONUS
            = new FulfillmentScriptContextSource("REFERRAL_BONUS");

        public static readonly FulfillmentScriptContextSource REWARD
            = new FulfillmentScriptContextSource("REWARD");

        public static readonly FulfillmentScriptContextSource SELLBACK
            = new FulfillmentScriptContextSource("SELL_BACK");


        public static implicit operator FulfillmentScriptContextSource(string value)
        {
            return NewValue(value);
        }

        public FulfillmentScriptContextSource(string enumValue)
            : base(enumValue)
        {

        }
    }
}