using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TaxResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("enableTax")]
        public bool? EnableTax { get; set; }
        
        [JsonPropertyName("formattedTax")]
        public string? FormattedTax { get; set; }
        
        [JsonPropertyName("state")]
        public string? State { get; set; }
        
        [JsonPropertyName("tax")]
        public int? Tax { get; set; }
        
    }
}