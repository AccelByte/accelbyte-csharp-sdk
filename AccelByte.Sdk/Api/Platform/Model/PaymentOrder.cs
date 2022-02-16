// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentOrder : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authorisedTime")]
        public DateTime? AuthorisedTime { get; set; }
        
        [JsonPropertyName("channel")]
        public string? Channel { get; set; }
        
        [JsonPropertyName("chargebackReversedTime")]
        public DateTime? ChargebackReversedTime { get; set; }
        
        [JsonPropertyName("chargebackTime")]
        public DateTime? ChargebackTime { get; set; }
        
        [JsonPropertyName("chargedTime")]
        public DateTime? ChargedTime { get; set; }
        
        [JsonPropertyName("charging")]
        public bool? Charging { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("createdTime")]
        public DateTime? CreatedTime { get; set; }
        
        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }
        
        [JsonPropertyName("customParameters")]
        public Dictionary<string, object>? CustomParameters { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("extOrderNo")]
        public string? ExtOrderNo { get; set; }
        
        [JsonPropertyName("extUserId")]
        public string? ExtUserId { get; set; }
        
        [JsonPropertyName("itemType")]
        public string? ItemType { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("notifyUrl")]
        public string? NotifyUrl { get; set; }
        
        [JsonPropertyName("omitNotification")]
        public bool? OmitNotification { get; set; }
        
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
        
        [JsonPropertyName("recurringPaymentOrderNo")]
        public string? RecurringPaymentOrderNo { get; set; }
        
        [JsonPropertyName("refundedTime")]
        public DateTime? RefundedTime { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
        [JsonPropertyName("rvn")]
        public int? Rvn { get; set; }
        
        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }
        
        [JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }
        
        [JsonPropertyName("sku")]
        public string? Sku { get; set; }
        
        [JsonPropertyName("state")]
        public string? State { get; set; }
        
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
        
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        
        [JsonPropertyName("totalPrice")]
        public int? TotalPrice { get; set; }
        
        [JsonPropertyName("totalTax")]
        public int? TotalTax { get; set; }
        
        [JsonPropertyName("transactions")]
        public List<Transaction>? Transactions { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("vat")]
        public int? Vat { get; set; }
        
        [JsonPropertyName("zipCode")]
        public string? ZipCode { get; set; }
        
    }
}