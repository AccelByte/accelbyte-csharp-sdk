// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderChargeStatus : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("charging")]
        public bool? Charging { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PaymentOrderChargeStatusStatus? Status { get; set; }

    }

    public class PaymentOrderChargeStatusStatus : StringEnum<PaymentOrderChargeStatusStatus>
    {
        public static readonly PaymentOrderChargeStatusStatus INIT
            = new PaymentOrderChargeStatusStatus("INIT");

        public static readonly PaymentOrderChargeStatusStatus AUTHORISED
            = new PaymentOrderChargeStatusStatus("AUTHORISED");

        public static readonly PaymentOrderChargeStatusStatus AUTHORISEFAILED
            = new PaymentOrderChargeStatusStatus("AUTHORISE_FAILED");

        public static readonly PaymentOrderChargeStatusStatus CHARGED
            = new PaymentOrderChargeStatusStatus("CHARGED");

        public static readonly PaymentOrderChargeStatusStatus CHARGEFAILED
            = new PaymentOrderChargeStatusStatus("CHARGE_FAILED");

        public static readonly PaymentOrderChargeStatusStatus NOTIFICATIONOFCHARGEBACK
            = new PaymentOrderChargeStatusStatus("NOTIFICATION_OF_CHARGEBACK");

        public static readonly PaymentOrderChargeStatusStatus REQUESTFORINFORMATION
            = new PaymentOrderChargeStatusStatus("REQUEST_FOR_INFORMATION");

        public static readonly PaymentOrderChargeStatusStatus CHARGEBACK
            = new PaymentOrderChargeStatusStatus("CHARGEBACK");

        public static readonly PaymentOrderChargeStatusStatus CHARGEBACKREVERSED
            = new PaymentOrderChargeStatusStatus("CHARGEBACK_REVERSED");

        public static readonly PaymentOrderChargeStatusStatus REFUNDING
            = new PaymentOrderChargeStatusStatus("REFUNDING");

        public static readonly PaymentOrderChargeStatusStatus REFUNDED
            = new PaymentOrderChargeStatusStatus("REFUNDED");

        public static readonly PaymentOrderChargeStatusStatus REFUNDFAILED
            = new PaymentOrderChargeStatusStatus("REFUND_FAILED");

        public static readonly PaymentOrderChargeStatusStatus DELETED
            = new PaymentOrderChargeStatusStatus("DELETED");


        public static implicit operator PaymentOrderChargeStatusStatus(string value)
        {
            return Create(value);
        }

        public PaymentOrderChargeStatusStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}