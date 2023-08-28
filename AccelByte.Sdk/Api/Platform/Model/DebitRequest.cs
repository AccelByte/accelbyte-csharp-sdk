// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class DebitRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("balanceSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DebitRequestBalanceSource? BalanceSource { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Metadata { get; set; }

        [JsonPropertyName("reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Reason { get; set; }

    }

    public class DebitRequest<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }

        [JsonPropertyName("balanceSource")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DebitRequestBalanceSource? BalanceSource { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? Metadata { get; set; }

        [JsonPropertyName("reason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Reason { get; set; }

    }


    public class DebitRequestBalanceSource : StringEnum<DebitRequestBalanceSource>
    {
        public static readonly DebitRequestBalanceSource DLCREVOCATION
            = new DebitRequestBalanceSource("DLC_REVOCATION");

        public static readonly DebitRequestBalanceSource EXPIRATION
            = new DebitRequestBalanceSource("EXPIRATION");

        public static readonly DebitRequestBalanceSource IAPREVOCATION
            = new DebitRequestBalanceSource("IAP_REVOCATION");

        public static readonly DebitRequestBalanceSource ORDERREVOCATION
            = new DebitRequestBalanceSource("ORDER_REVOCATION");

        public static readonly DebitRequestBalanceSource OTHER
            = new DebitRequestBalanceSource("OTHER");

        public static readonly DebitRequestBalanceSource PAYMENT
            = new DebitRequestBalanceSource("PAYMENT");


        public static implicit operator DebitRequestBalanceSource(string value)
        {
            return NewValue(value);
        }

        public DebitRequestBalanceSource(string enumValue)
            : base(enumValue)
        {

        }
    }
}