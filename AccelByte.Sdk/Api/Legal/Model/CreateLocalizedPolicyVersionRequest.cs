using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class CreateLocalizedPolicyVersionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentType")]
        public string? ContentType { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("localeCode")]
        public string? LocaleCode { get; set; }
        
    }
}