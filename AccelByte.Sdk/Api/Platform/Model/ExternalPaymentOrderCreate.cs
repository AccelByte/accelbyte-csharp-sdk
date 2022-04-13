// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class ExternalPaymentOrderCreate : AccelByte.Sdk.Core.Model
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
        public ExternalPaymentOrderCreateItemType? ItemType { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }

        [JsonPropertyName("notifyUrl")]
        public string? NotifyUrl { get; set; }

        [JsonPropertyName("omitNotification")]
        public bool? OmitNotification { get; set; }

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

        public static readonly ExternalPaymentOrderCreateItemType COINS
            = new ExternalPaymentOrderCreateItemType("COINS");

        public static readonly ExternalPaymentOrderCreateItemType INGAMEITEM
            = new ExternalPaymentOrderCreateItemType("INGAMEITEM");

        public static readonly ExternalPaymentOrderCreateItemType BUNDLE
            = new ExternalPaymentOrderCreateItemType("BUNDLE");

        public static readonly ExternalPaymentOrderCreateItemType CODE
            = new ExternalPaymentOrderCreateItemType("CODE");

        public static readonly ExternalPaymentOrderCreateItemType SUBSCRIPTION
            = new ExternalPaymentOrderCreateItemType("SUBSCRIPTION");

        public static readonly ExternalPaymentOrderCreateItemType SEASON
            = new ExternalPaymentOrderCreateItemType("SEASON");

        public static readonly ExternalPaymentOrderCreateItemType MEDIA
            = new ExternalPaymentOrderCreateItemType("MEDIA");


        public static implicit operator ExternalPaymentOrderCreateItemType(string value)
        {
            return Create(value);
        }

        public ExternalPaymentOrderCreateItemType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}