// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CreditPayload : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("balanceOrigin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public CreditPayloadBalanceOrigin? BalanceOrigin { get; set; }

        [JsonPropertyName("count")]
        public long? Count { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("expireAt")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? ExpireAt { get; set; }

    }



    public class CreditPayloadBalanceOrigin : StringEnum<CreditPayloadBalanceOrigin>
    {
        public static readonly CreditPayloadBalanceOrigin Epic
            = new CreditPayloadBalanceOrigin("Epic");

        public static readonly CreditPayloadBalanceOrigin GooglePlay
            = new CreditPayloadBalanceOrigin("GooglePlay");

        public static readonly CreditPayloadBalanceOrigin IOS
            = new CreditPayloadBalanceOrigin("IOS");

        public static readonly CreditPayloadBalanceOrigin Nintendo
            = new CreditPayloadBalanceOrigin("Nintendo");

        public static readonly CreditPayloadBalanceOrigin Oculus
            = new CreditPayloadBalanceOrigin("Oculus");

        public static readonly CreditPayloadBalanceOrigin Other
            = new CreditPayloadBalanceOrigin("Other");

        public static readonly CreditPayloadBalanceOrigin Playstation
            = new CreditPayloadBalanceOrigin("Playstation");

        public static readonly CreditPayloadBalanceOrigin Steam
            = new CreditPayloadBalanceOrigin("Steam");

        public static readonly CreditPayloadBalanceOrigin System
            = new CreditPayloadBalanceOrigin("System");

        public static readonly CreditPayloadBalanceOrigin Twitch
            = new CreditPayloadBalanceOrigin("Twitch");

        public static readonly CreditPayloadBalanceOrigin Xbox
            = new CreditPayloadBalanceOrigin("Xbox");


        public static implicit operator CreditPayloadBalanceOrigin(string value)
        {
            return NewValue(value);
        }

        public CreditPayloadBalanceOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }
}