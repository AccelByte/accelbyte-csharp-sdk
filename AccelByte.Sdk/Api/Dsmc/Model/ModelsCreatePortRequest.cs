using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCreatePortRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("port")]
        public int? Port { get; set; }
        
    }
}