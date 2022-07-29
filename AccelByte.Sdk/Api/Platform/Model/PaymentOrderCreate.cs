// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrderCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencyNamespace")]
        public string? CurrencyNamespace { get; set; }

        [JsonPropertyName("customParameters")]
        public Dictionary<string, object>? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonStringEnum]
        public PaymentOrderCreateItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("notifyUrl")]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("platform")]
        public string? Platform { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        public string? Sku { get; set; }

        [JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

    }

    public class PaymentOrderCreateItemType : StringEnum<PaymentOrderCreateItemType>
    {
        public static readonly PaymentOrderCreateItemType APP
            = new PaymentOrderCreateItemType("APP");

        public static readonly PaymentOrderCreateItemType BUNDLE
            = new PaymentOrderCreateItemType("BUNDLE");

        public static readonly PaymentOrderCreateItemType CODE
            = new PaymentOrderCreateItemType("CODE");

        public static readonly PaymentOrderCreateItemType COINS
            = new PaymentOrderCreateItemType("COINS");

        public static readonly PaymentOrderCreateItemType INGAMEITEM
            = new PaymentOrderCreateItemType("INGAMEITEM");

        public static readonly PaymentOrderCreateItemType MEDIA
            = new PaymentOrderCreateItemType("MEDIA");

        public static readonly PaymentOrderCreateItemType OPTIONBOX
            = new PaymentOrderCreateItemType("OPTIONBOX");

        public static readonly PaymentOrderCreateItemType SEASON
            = new PaymentOrderCreateItemType("SEASON");

        public static readonly PaymentOrderCreateItemType SUBSCRIPTION
            = new PaymentOrderCreateItemType("SUBSCRIPTION");


        public static implicit operator PaymentOrderCreateItemType(string value)
        {
            return NewValue(value);
        }

        public PaymentOrderCreateItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}