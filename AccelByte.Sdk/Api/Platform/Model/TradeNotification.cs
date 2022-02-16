// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TradeNotification : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public AdditionalData? AdditionalData { get; set; }
        
        [JsonPropertyName("authorisedTime")]
        public DateTime? AuthorisedTime { get; set; }
        
        [JsonPropertyName("chargebackReversedTime")]
        public DateTime? ChargebackReversedTime { get; set; }
        
        [JsonPropertyName("chargebackTime")]
        public DateTime? ChargebackTime { get; set; }
        
        [JsonPropertyName("chargedTime")]
        public DateTime? ChargedTime { get; set; }
        
        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }
        
        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }
        
        [JsonPropertyName("customParameters")]
        public Dictionary<string, object>? CustomParameters { get; set; }
        
        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }
        
        [JsonPropertyName("extTxId")]
        public string? ExtTxId { get; set; }
        
        [JsonPropertyName("extUserId")]
        public string? ExtUserId { get; set; }
        
        [JsonPropertyName("issuedAt")]
        public DateTime? IssuedAt { get; set; }
        
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("nonceStr")]
        public string? NonceStr { get; set; }
        
        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }
        
        [JsonPropertyName("paymentMethodFee")]
        public int? PaymentMethodFee { get; set; }
        
        [JsonPropertyName("paymentOrderNo")]
        public string? PaymentOrderNo { get; set; }
        
        [JsonPropertyName("paymentProvider")]
        public string? PaymentProvider { get; set; }
        
        [JsonPropertyName("paymentProviderFee")]
        public int? PaymentProviderFee { get; set; }
        
        [JsonPropertyName("paymentStationUrl")]
        public string? PaymentStationUrl { get; set; }
        
        [JsonPropertyName("price")]
        public int? Price { get; set; }
        
        [JsonPropertyName("refundedTime")]
        public DateTime? RefundedTime { get; set; }
        
        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }
        
        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("statusReason")]
        public string? StatusReason { get; set; }
        
        [JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }
        
        [JsonPropertyName("subtotalPrice")]
        public int? SubtotalPrice { get; set; }
        
        [JsonPropertyName("targetNamespace")]
        public string? TargetNamespace { get; set; }
        
        [JsonPropertyName("targetUserId")]
        public string? TargetUserId { get; set; }
        
        [JsonPropertyName("tax")]
        public int? Tax { get; set; }
        
        [JsonPropertyName("totalPrice")]
        public int? TotalPrice { get; set; }
        
        [JsonPropertyName("totalTax")]
        public int? TotalTax { get; set; }
        
        [JsonPropertyName("txEndTime")]
        public DateTime? TxEndTime { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("vat")]
        public int? Vat { get; set; }
        
    }
}