using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelWebLinkingResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("third_party_url")]
        public string? ThirdPartyUrl { get; set; }
        
    }
}