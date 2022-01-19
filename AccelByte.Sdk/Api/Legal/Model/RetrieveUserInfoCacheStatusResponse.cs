using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class RetrieveUserInfoCacheStatusResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("lastUpdatedAt")]
        public DateTime? LastUpdatedAt { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
    }
}