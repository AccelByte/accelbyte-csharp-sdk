// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CreditRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public CreditRequestSource? Source { get; set; }

    }

    public class CreditRequestSource : StringEnum<CreditRequestSource>
    {
        public static readonly CreditRequestSource PURCHASE
            = new CreditRequestSource("PURCHASE");

        public static readonly CreditRequestSource IAP
            = new CreditRequestSource("IAP");

        public static readonly CreditRequestSource PROMOTION
            = new CreditRequestSource("PROMOTION");

        public static readonly CreditRequestSource ACHIEVEMENT
            = new CreditRequestSource("ACHIEVEMENT");

        public static readonly CreditRequestSource REFERRALBONUS
            = new CreditRequestSource("REFERRAL_BONUS");

        public static readonly CreditRequestSource REDEEMCODE
            = new CreditRequestSource("REDEEM_CODE");

        public static readonly CreditRequestSource REWARD
            = new CreditRequestSource("REWARD");

        public static readonly CreditRequestSource GIFT
            = new CreditRequestSource("GIFT");

        public static readonly CreditRequestSource REFUND
            = new CreditRequestSource("REFUND");

        public static readonly CreditRequestSource OTHER
            = new CreditRequestSource("OTHER");


        public static implicit operator CreditRequestSource(string value)
        {
            return Create(value);
        }

        public CreditRequestSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}