using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsDeregisterLocalServerRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}