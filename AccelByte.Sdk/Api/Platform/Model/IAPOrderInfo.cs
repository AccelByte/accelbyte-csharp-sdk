// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class IAPOrderInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("credits")]
        public List<CreditSummary>? Credits { get; set; }

        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("entitlements")]
        public List<EntitlementSummary>? Entitlements { get; set; }

        [JsonPropertyName("fulfilledTime")]
        public DateTime? FulfilledTime { get; set; }

        [JsonPropertyName("iapOrderNo")]
        public string? IapOrderNo { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("price")]
        public double? Price { get; set; }

        [JsonPropertyName("productId")]
        public string? ProductId { get; set; }

        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        [JsonPropertyName("receiptData")]
        public string? ReceiptData { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("retryCount")]
        public int? RetryCount { get; set; }

        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public IAPOrderInfoStatus? Status { get; set; }

        [JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }

        [JsonPropertyName("transactionId")]
        public string? TransactionId { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public IAPOrderInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("userId")]
        public string? UserId { get; set; }

    }

    public class IAPOrderInfoStatus : StringEnum<IAPOrderInfoStatus>
    {
        public static readonly IAPOrderInfoStatus VERIFIED
            = new IAPOrderInfoStatus("VERIFIED");

        public static readonly IAPOrderInfoStatus FULFILLED
            = new IAPOrderInfoStatus("FULFILLED");

        public static readonly IAPOrderInfoStatus FAILED
            = new IAPOrderInfoStatus("FAILED");


        public static implicit operator IAPOrderInfoStatus(string value)
        {
            return Create(value);
        }

        public IAPOrderInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class IAPOrderInfoType : StringEnum<IAPOrderInfoType>
    {
        public static readonly IAPOrderInfoType APPLE
            = new IAPOrderInfoType("APPLE");

        public static readonly IAPOrderInfoType GOOGLE
            = new IAPOrderInfoType("GOOGLE");

        public static readonly IAPOrderInfoType PLAYSTATION
            = new IAPOrderInfoType("PLAYSTATION");

        public static readonly IAPOrderInfoType STEAM
            = new IAPOrderInfoType("STEAM");

        public static readonly IAPOrderInfoType XBOX
            = new IAPOrderInfoType("XBOX");

        public static readonly IAPOrderInfoType STADIA
            = new IAPOrderInfoType("STADIA");

        public static readonly IAPOrderInfoType EPICGAMES
            = new IAPOrderInfoType("EPICGAMES");

        public static readonly IAPOrderInfoType TWITCH
            = new IAPOrderInfoType("TWITCH");


        public static implicit operator IAPOrderInfoType(string value)
        {
            return Create(value);
        }

        public IAPOrderInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}