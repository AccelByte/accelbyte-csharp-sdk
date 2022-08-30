// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ExternalPaymentOrderCreate : AccelByte.Sdk.Core.Model
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
        public ExternalPaymentOrderCreateItemType? ItemType { get; set; }

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

        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }

        [JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

    }

    public class ExternalPaymentOrderCreateItemType : StringEnum<ExternalPaymentOrderCreateItemType>
    {
        public static readonly ExternalPaymentOrderCreateItemType APP
            = new ExternalPaymentOrderCreateItemType("APP");

        public static readonly ExternalPaymentOrderCreateItemType BUNDLE
            = new ExternalPaymentOrderCreateItemType("BUNDLE");

        public static readonly ExternalPaymentOrderCreateItemType CODE
            = new ExternalPaymentOrderCreateItemType("CODE");

        public static readonly ExternalPaymentOrderCreateItemType COINS
            = new ExternalPaymentOrderCreateItemType("COINS");

        public static readonly ExternalPaymentOrderCreateItemType EXTENSION
            = new ExternalPaymentOrderCreateItemType("EXTENSION");

        public static readonly ExternalPaymentOrderCreateItemType INGAMEITEM
            = new ExternalPaymentOrderCreateItemType("INGAMEITEM");

        public static readonly ExternalPaymentOrderCreateItemType MEDIA
            = new ExternalPaymentOrderCreateItemType("MEDIA");

        public static readonly ExternalPaymentOrderCreateItemType OPTIONBOX
            = new ExternalPaymentOrderCreateItemType("OPTIONBOX");

        public static readonly ExternalPaymentOrderCreateItemType SEASON
            = new ExternalPaymentOrderCreateItemType("SEASON");

        public static readonly ExternalPaymentOrderCreateItemType SUBSCRIPTION
            = new ExternalPaymentOrderCreateItemType("SUBSCRIPTION");


        public static implicit operator ExternalPaymentOrderCreateItemType(string value)
        {
            return NewValue(value);
        }

        public ExternalPaymentOrderCreateItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}