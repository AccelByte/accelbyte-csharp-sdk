// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RewardsRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("origin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RewardsRequestOrigin? Origin { get; set; }

        [JsonPropertyName("rewards")]
        public List<PlatformReward>? Rewards { get; set; }

        [JsonPropertyName("source")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RewardsRequestSource? Source { get; set; }

    }

    public class RewardsRequestOrigin : StringEnum<RewardsRequestOrigin>
    {
        public static readonly RewardsRequestOrigin Epic
            = new RewardsRequestOrigin("Epic");

        public static readonly RewardsRequestOrigin GooglePlay
            = new RewardsRequestOrigin("GooglePlay");

        public static readonly RewardsRequestOrigin IOS
            = new RewardsRequestOrigin("IOS");

        public static readonly RewardsRequestOrigin Nintendo
            = new RewardsRequestOrigin("Nintendo");

        public static readonly RewardsRequestOrigin Other
            = new RewardsRequestOrigin("Other");

        public static readonly RewardsRequestOrigin Playstation
            = new RewardsRequestOrigin("Playstation");

        public static readonly RewardsRequestOrigin Stadia
            = new RewardsRequestOrigin("Stadia");

        public static readonly RewardsRequestOrigin Steam
            = new RewardsRequestOrigin("Steam");

        public static readonly RewardsRequestOrigin System
            = new RewardsRequestOrigin("System");

        public static readonly RewardsRequestOrigin Twitch
            = new RewardsRequestOrigin("Twitch");

        public static readonly RewardsRequestOrigin Xbox
            = new RewardsRequestOrigin("Xbox");


        public static implicit operator RewardsRequestOrigin(string value)
        {
            return NewValue(value);
        }

        public RewardsRequestOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class RewardsRequestSource : StringEnum<RewardsRequestSource>
    {
        public static readonly RewardsRequestSource ACHIEVEMENT
            = new RewardsRequestSource("ACHIEVEMENT");

        public static readonly RewardsRequestSource DLC
            = new RewardsRequestSource("DLC");

        public static readonly RewardsRequestSource GIFT
            = new RewardsRequestSource("GIFT");

        public static readonly RewardsRequestSource IAP
            = new RewardsRequestSource("IAP");

        public static readonly RewardsRequestSource OTHER
            = new RewardsRequestSource("OTHER");

        public static readonly RewardsRequestSource PROMOTION
            = new RewardsRequestSource("PROMOTION");

        public static readonly RewardsRequestSource PURCHASE
            = new RewardsRequestSource("PURCHASE");

        public static readonly RewardsRequestSource REDEEMCODE
            = new RewardsRequestSource("REDEEM_CODE");

        public static readonly RewardsRequestSource REFERRALBONUS
            = new RewardsRequestSource("REFERRAL_BONUS");

        public static readonly RewardsRequestSource REWARD
            = new RewardsRequestSource("REWARD");


        public static implicit operator RewardsRequestSource(string value)
        {
            return NewValue(value);
        }

        public RewardsRequestSource(string enumValue)
            : base(enumValue)
        {

        }
    }    
}