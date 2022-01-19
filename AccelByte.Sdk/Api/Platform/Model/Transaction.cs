using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Transaction : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public AdditionalData? AdditionalData { get; set; }
        
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }
        
        [JsonPropertyName("currency")]
        public CurrencySummary? Currency { get; set; }
        
        [JsonPropertyName("extMessage")]
        public string? ExtMessage { get; set; }
        
        [JsonPropertyName("extStatusCode")]
        public string? ExtStatusCode { get; set; }
        
        [JsonPropertyName("extTxId")]
        public string? ExtTxId { get; set; }
        
        [JsonPropertyName("merchantId")]
        public string? MerchantId { get; set; }
        
        [JsonPropertyName("notified")]
        public bool? Notified { get; set; }
        
        [JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }
        
        [JsonPropertyName("paymentMethodFee")]
        public int? PaymentMethodFee { get; set; }
        
        [JsonPropertyName("paymentProviderFee")]
        public int? PaymentProviderFee { get; set; }
        
        [JsonPropertyName("provider")]
        public string? Provider { get; set; }
        
        [JsonPropertyName("salesTax")]
        public int? SalesTax { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("tax")]
        public int? Tax { get; set; }
        
        [JsonPropertyName("txEndTime")]
        public DateTime? TxEndTime { get; set; }
        
        [JsonPropertyName("txId")]
        public string? TxId { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("vat")]
        public int? Vat { get; set; }
        
    }
}