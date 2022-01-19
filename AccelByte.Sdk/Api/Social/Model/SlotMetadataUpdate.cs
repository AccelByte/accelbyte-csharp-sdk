using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class SlotMetadataUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("customAttribute")]
        public string? CustomAttribute { get; set; }
        
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
    }
}