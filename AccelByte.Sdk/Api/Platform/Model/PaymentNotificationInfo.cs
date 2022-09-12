// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentNotificationInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("externalId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExternalId { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("notification")]
        public Dictionary<string, object>? Notification { get; set; }

        [JsonPropertyName("notificationSource")]
        [JsonStringEnum]
        public PaymentNotificationInfoNotificationSource? NotificationSource { get; set; }

        [JsonPropertyName("notificationType")]
        public string? NotificationType { get; set; }

        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public PaymentNotificationInfoStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? StatusReason { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class PaymentNotificationInfoNotificationSource : StringEnum<PaymentNotificationInfoNotificationSource>
    {
        public static readonly PaymentNotificationInfoNotificationSource ADYEN
            = new PaymentNotificationInfoNotificationSource("ADYEN");

        public static readonly PaymentNotificationInfoNotificationSource ALIPAY
            = new PaymentNotificationInfoNotificationSource("ALIPAY");

        public static readonly PaymentNotificationInfoNotificationSource CHECKOUT
            = new PaymentNotificationInfoNotificationSource("CHECKOUT");

        public static readonly PaymentNotificationInfoNotificationSource PAYPAL
            = new PaymentNotificationInfoNotificationSource("PAYPAL");

        public static readonly PaymentNotificationInfoNotificationSource STRIPE
            = new PaymentNotificationInfoNotificationSource("STRIPE");

        public static readonly PaymentNotificationInfoNotificationSource WALLET
            = new PaymentNotificationInfoNotificationSource("WALLET");

        public static readonly PaymentNotificationInfoNotificationSource WXPAY
            = new PaymentNotificationInfoNotificationSource("WXPAY");

        public static readonly PaymentNotificationInfoNotificationSource XSOLLA
            = new PaymentNotificationInfoNotificationSource("XSOLLA");


        public static implicit operator PaymentNotificationInfoNotificationSource(string value)
        {
            return NewValue(value);
        }

        public PaymentNotificationInfoNotificationSource(string enumValue)
            : base(enumValue)
        {

        }
    }

    public class PaymentNotificationInfoStatus : StringEnum<PaymentNotificationInfoStatus>
    {
        public static readonly PaymentNotificationInfoStatus ERROR
            = new PaymentNotificationInfoStatus("ERROR");

        public static readonly PaymentNotificationInfoStatus IGNORED
            = new PaymentNotificationInfoStatus("IGNORED");

        public static readonly PaymentNotificationInfoStatus PROCESSED
            = new PaymentNotificationInfoStatus("PROCESSED");

        public static readonly PaymentNotificationInfoStatus WARN
            = new PaymentNotificationInfoStatus("WARN");


        public static implicit operator PaymentNotificationInfoStatus(string value)
        {
            return NewValue(value);
        }

        public PaymentNotificationInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}