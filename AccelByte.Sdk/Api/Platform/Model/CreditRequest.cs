// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CreditRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("expireAt")]
        public DateTime? ExpireAt { get; set; }

        [JsonPropertyName("origin")]
        [JsonStringEnum]
        public CreditRequestOrigin? Origin { get; set; }

        [JsonPropertyName("reason")]
        public string? Reason { get; set; }

        [JsonPropertyName("source")]
        [JsonStringEnum]
        public CreditRequestSource? Source { get; set; }

    }

    public class CreditRequestOrigin : StringEnum<CreditRequestOrigin>
    {
        public static readonly CreditRequestOrigin Playstation
            = new CreditRequestOrigin("Playstation");

        public static readonly CreditRequestOrigin Xbox
            = new CreditRequestOrigin("Xbox");

        public static readonly CreditRequestOrigin Steam
            = new CreditRequestOrigin("Steam");

        public static readonly CreditRequestOrigin Epic
            = new CreditRequestOrigin("Epic");

        public static readonly CreditRequestOrigin Stadia
            = new CreditRequestOrigin("Stadia");

        public static readonly CreditRequestOrigin IOS
            = new CreditRequestOrigin("IOS");

        public static readonly CreditRequestOrigin GooglePlay
            = new CreditRequestOrigin("GooglePlay");

        public static readonly CreditRequestOrigin Twitch
            = new CreditRequestOrigin("Twitch");

        public static readonly CreditRequestOrigin Nintendo
            = new CreditRequestOrigin("Nintendo");

        public static readonly CreditRequestOrigin System
            = new CreditRequestOrigin("System");

        public static readonly CreditRequestOrigin Other
            = new CreditRequestOrigin("Other");


        public static implicit operator CreditRequestOrigin(string value)
        {
            return NewValue(value);
        }

        public CreditRequestOrigin(string enumValue)
            : base(enumValue)
        {

        }
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
            return NewValue(value);
        }

        public CreditRequestSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}