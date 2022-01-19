using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyGroupDynamicInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("availableSaleCount")]
        public int? AvailableSaleCount { get; set; }
        
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
        [JsonPropertyName("saleCount")]
        public int? SaleCount { get; set; }
        
    }
}