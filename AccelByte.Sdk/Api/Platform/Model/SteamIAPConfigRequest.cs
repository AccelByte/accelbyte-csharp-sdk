using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class SteamIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("publisherAuthenticationKey")]
        public string? PublisherAuthenticationKey { get; set; }
        
    }
}