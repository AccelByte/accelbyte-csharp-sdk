using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CodeCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("quantity")]
        public int? Quantity { get; set; }
        
    }
}