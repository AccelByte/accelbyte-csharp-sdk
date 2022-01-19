using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class RestapiErrorResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Code")]
        public int? Code { get; set; }
        
        [JsonPropertyName("Message")]
        public string? Message { get; set; }
        
    }
}