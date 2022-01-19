using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class NamespacePublisherInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("publisher")]
        public bool? Publisher { get; set; }
        
        [JsonPropertyName("publisherNamespace")]
        public string? PublisherNamespace { get; set; }
        
    }
}