using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateTagRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("tag")]
        public string? Tag { get; set; }
        
    }
}