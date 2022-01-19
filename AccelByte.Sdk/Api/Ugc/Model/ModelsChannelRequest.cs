using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsChannelRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}