// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderRefundResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("refundedTime")]
        public DateTime? RefundedTime { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PaymentOrderRefundResultStatus? Status { get; set; }

        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }

    }

    public class PaymentOrderRefundResultStatus : StringEnum<PaymentOrderRefundResultStatus>
    {
        public static readonly PaymentOrderRefundResultStatus INIT
            = new PaymentOrderRefundResultStatus("INIT");

        public static readonly PaymentOrderRefundResultStatus AUTHORISED
            = new PaymentOrderRefundResultStatus("AUTHORISED");

        public static readonly PaymentOrderRefundResultStatus AUTHORISEFAILED
            = new PaymentOrderRefundResultStatus("AUTHORISE_FAILED");

        public static readonly PaymentOrderRefundResultStatus CHARGED
            = new PaymentOrderRefundResultStatus("CHARGED");

        public static readonly PaymentOrderRefundResultStatus CHARGEFAILED
            = new PaymentOrderRefundResultStatus("CHARGE_FAILED");

        public static readonly PaymentOrderRefundResultStatus NOTIFICATIONOFCHARGEBACK
            = new PaymentOrderRefundResultStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly PaymentOrderRefundResultStatus REQUESTFORINFORMATION
            = new PaymentOrderRefundResultStatus("REQUEST_FOR_INFORMATION");

        public static readonly PaymentOrderRefundResultStatus CHARGEBACK
            = new PaymentOrderRefundResultStatus("CHARGEBACK");

        public static readonly PaymentOrderRefundResultStatus CHARGEBACKREVERSED
            = new PaymentOrderRefundResultStatus("CHARGEBACK_REVERSED");

        public static readonly PaymentOrderRefundResultStatus REFUNDING
            = new PaymentOrderRefundResultStatus("REFUNDING");

        public static readonly PaymentOrderRefundResultStatus REFUNDED
            = new PaymentOrderRefundResultStatus("REFUNDED");

        public static readonly PaymentOrderRefundResultStatus REFUNDFAILED
            = new PaymentOrderRefundResultStatus("REFUND_FAILED");

        public static readonly PaymentOrderRefundResultStatus DELETED
            = new PaymentOrderRefundResultStatus("DELETED");


        public static implicit operator PaymentOrderRefundResultStatus(string value)
        {
            return Create(value);
        }

        public PaymentOrderRefundResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}