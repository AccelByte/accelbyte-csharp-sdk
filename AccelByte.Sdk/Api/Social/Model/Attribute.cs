using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class Attribute : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
    }
}