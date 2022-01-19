using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderRefundCreate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
    }
}