using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Gametelemetry.Model
{
    public class HTTPValidationError : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("detail")]
        public List<ValidationError>? Detail { get; set; }
        
    }
}