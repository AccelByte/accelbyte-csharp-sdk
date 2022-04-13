// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderCreateResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("paymentStationUrl")]
        public string? PaymentStationUrl { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PaymentOrderCreateResultStatus? Status { get; set; }

        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }

    }

    public class PaymentOrderCreateResultStatus : StringEnum<PaymentOrderCreateResultStatus>
    {
        public static readonly PaymentOrderCreateResultStatus INIT
            = new PaymentOrderCreateResultStatus("INIT");

        public static readonly PaymentOrderCreateResultStatus AUTHORISED
            = new PaymentOrderCreateResultStatus("AUTHORISED");

        public static readonly PaymentOrderCreateResultStatus AUTHORISEFAILED
            = new PaymentOrderCreateResultStatus("AUTHORISE_FAILED");

        public static readonly PaymentOrderCreateResultStatus CHARGED
            = new PaymentOrderCreateResultStatus("CHARGED");

        public static readonly PaymentOrderCreateResultStatus CHARGEFAILED
            = new PaymentOrderCreateResultStatus("CHARGE_FAILED");

        public static readonly PaymentOrderCreateResultStatus NOTIFICATIONOFCHARGEBACK
            = new PaymentOrderCreateResultStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly PaymentOrderCreateResultStatus REQUESTFORINFORMATION
            = new PaymentOrderCreateResultStatus("REQUEST_FOR_INFORMATION");

        public static readonly PaymentOrderCreateResultStatus CHARGEBACK
            = new PaymentOrderCreateResultStatus("CHARGEBACK");

        public static readonly PaymentOrderCreateResultStatus CHARGEBACKREVERSED
            = new PaymentOrderCreateResultStatus("CHARGEBACK_REVERSED");

        public static readonly PaymentOrderCreateResultStatus REFUNDING
            = new PaymentOrderCreateResultStatus("REFUNDING");

        public static readonly PaymentOrderCreateResultStatus REFUNDED
            = new PaymentOrderCreateResultStatus("REFUNDED");

        public static readonly PaymentOrderCreateResultStatus REFUNDFAILED
            = new PaymentOrderCreateResultStatus("REFUND_FAILED");

        public static readonly PaymentOrderCreateResultStatus DELETED
            = new PaymentOrderCreateResultStatus("DELETED");


        public static implicit operator PaymentOrderCreateResultStatus(string value)
        {
            return Create(value);
        }

        public PaymentOrderCreateResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}