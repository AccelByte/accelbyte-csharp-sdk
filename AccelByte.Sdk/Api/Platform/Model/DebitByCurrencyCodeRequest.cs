// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class DebitByCurrencyCodeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowOverdraft")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AllowOverdraft { get; set; }

        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("balanceOrigin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DebitByCurrencyCodeRequestBalanceOrigin? BalanceOrigin { get; set; }

        [JsonPropertyName("balanceSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DebitByCurrencyCodeRequestBalanceSource? BalanceSource { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Metadata { get; set; }

        [JsonPropertyName("reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Reason { get; set; }

    }

    public class DebitByCurrencyCodeRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowOverdraft")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? AllowOverdraft { get; set; }

        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("balanceOrigin")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DebitByCurrencyCodeRequestBalanceOrigin? BalanceOrigin { get; set; }

        [JsonPropertyName("balanceSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DebitByCurrencyCodeRequestBalanceSource? BalanceSource { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Metadata { get; set; }

        [JsonPropertyName("reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Reason { get; set; }

    }


    public class DebitByCurrencyCodeRequestBalanceOrigin : StringEnum<DebitByCurrencyCodeRequestBalanceOrigin>
    {
        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Epic
            = new DebitByCurrencyCodeRequestBalanceOrigin("Epic");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin GooglePlay
            = new DebitByCurrencyCodeRequestBalanceOrigin("GooglePlay");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin IOS
            = new DebitByCurrencyCodeRequestBalanceOrigin("IOS");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Nintendo
            = new DebitByCurrencyCodeRequestBalanceOrigin("Nintendo");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Oculus
            = new DebitByCurrencyCodeRequestBalanceOrigin("Oculus");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Other
            = new DebitByCurrencyCodeRequestBalanceOrigin("Other");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Playstation
            = new DebitByCurrencyCodeRequestBalanceOrigin("Playstation");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Steam
            = new DebitByCurrencyCodeRequestBalanceOrigin("Steam");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin System
            = new DebitByCurrencyCodeRequestBalanceOrigin("System");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Twitch
            = new DebitByCurrencyCodeRequestBalanceOrigin("Twitch");

        public static readonly DebitByCurrencyCodeRequestBalanceOrigin Xbox
            = new DebitByCurrencyCodeRequestBalanceOrigin("Xbox");


        public static implicit operator DebitByCurrencyCodeRequestBalanceOrigin(string value)
        {
            return NewValue(value);
        }

        public DebitByCurrencyCodeRequestBalanceOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class DebitByCurrencyCodeRequestBalanceSource : StringEnum<DebitByCurrencyCodeRequestBalanceSource>
    {
        public static readonly DebitByCurrencyCodeRequestBalanceSource DLCREVOCATION
            = new DebitByCurrencyCodeRequestBalanceSource("DLC_REVOCATION");

        public static readonly DebitByCurrencyCodeRequestBalanceSource EXPIRATION
            = new DebitByCurrencyCodeRequestBalanceSource("EXPIRATION");

        public static readonly DebitByCurrencyCodeRequestBalanceSource IAPREVOCATION
            = new DebitByCurrencyCodeRequestBalanceSource("IAP_REVOCATION");

        public static readonly DebitByCurrencyCodeRequestBalanceSource ORDERREVOCATION
            = new DebitByCurrencyCodeRequestBalanceSource("ORDER_REVOCATION");

        public static readonly DebitByCurrencyCodeRequestBalanceSource OTHER
            = new DebitByCurrencyCodeRequestBalanceSource("OTHER");

        public static readonly DebitByCurrencyCodeRequestBalanceSource PAYMENT
            = new DebitByCurrencyCodeRequestBalanceSource("PAYMENT");

        public static readonly DebitByCurrencyCodeRequestBalanceSource TRADE
            = new DebitByCurrencyCodeRequestBalanceSource("TRADE");


        public static implicit operator DebitByCurrencyCodeRequestBalanceSource(string value)
        {
            return NewValue(value);
        }

        public DebitByCurrencyCodeRequestBalanceSource(string enumValue)
            : base(enumValue)
        {

        }
    }
}