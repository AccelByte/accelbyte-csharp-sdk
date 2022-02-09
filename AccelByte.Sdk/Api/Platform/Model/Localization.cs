using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Localization : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("localExt")]
        public Dictionary<string, object>? LocalExt { get; set; }
        
        [JsonPropertyName("longDescription")]
        public string? LongDescription { get; set; }
        
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        
    }
}