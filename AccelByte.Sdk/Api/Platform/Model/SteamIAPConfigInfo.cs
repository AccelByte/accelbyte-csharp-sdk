using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SteamIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("publisherAuthenticationKey")]
        public string? PublisherAuthenticationKey { get; set; }
        
    }
}