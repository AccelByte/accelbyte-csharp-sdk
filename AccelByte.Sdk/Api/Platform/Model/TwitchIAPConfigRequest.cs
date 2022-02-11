using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TwitchIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientId")]
        public string? ClientId { get; set; }
        
        [JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }
        
        [JsonPropertyName("organizationId")]
        public string? OrganizationId { get; set; }
        
    }
}