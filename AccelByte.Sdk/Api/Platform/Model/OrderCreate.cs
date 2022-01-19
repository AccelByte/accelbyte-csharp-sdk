using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("currencyCode")]
        public string? CurrencyCode { get; set; }
        
        [JsonPropertyName("discountedPrice")]
        public int? DiscountedPrice { get; set; }
        
        [JsonPropertyName("ext")]
        public Dictionary<object, object>? Ext { get; set; }
        
        [JsonPropertyName("itemId")]
        public string? ItemId { get; set; }
        
        [JsonPropertyName("language")]
        public string? Language { get; set; }
        
        [JsonPropertyName("price")]
        public int? Price { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("region")]
        public string? Region { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
    }
}