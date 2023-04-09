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
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencyNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyNamespace { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderCreateItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("notifyUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Platform { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("sandbox")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("subscriptionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubscriptionId { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

    }

    public class PaymentOrderCreate<T1> : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("currencyNamespace")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrencyNamespace { get; set; }

        [JsonPropertyName("customParameters")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T1? CustomParameters { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }

        [JsonPropertyName("extUserId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ExtUserId { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public PaymentOrderCreateItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("notifyUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? OmitNotification { get; set; }

        [JsonPropertyName("platform")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Platform { get; set; }

        [JsonPropertyName("price")]
        public int? Price { get; set; }

        [JsonPropertyName("recurringPaymentOrderNo")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RecurringPaymentOrderNo { get; set; }

        [JsonPropertyName("region")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Region { get; set; }

        [JsonPropertyName("returnUrl")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReturnUrl { get; set; }

        [JsonPropertyName("sandbox")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("sku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sku { get; set; }

        [JsonPropertyName("subscriptionId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
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

        public static readonly PaymentOrderCreateItemType EXTENSION
            = new PaymentOrderCreateItemType("EXTENSION");

        public static readonly PaymentOrderCreateItemType INGAMEITEM
            = new PaymentOrderCreateItemType("INGAMEITEM");

        public static readonly PaymentOrderCreateItemType LOOTBOX
            = new PaymentOrderCreateItemType("LOOTBOX");

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