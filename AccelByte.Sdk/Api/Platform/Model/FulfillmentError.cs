using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("code")]
        public int? Code { get; set; }
        
        [JsonPropertyName("httpStatus")]
        public int? HttpStatus { get; set; }
        
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        
    }
}