using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsListConfigResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("configs")]
        public List<ModelsDSMConfigRecord>? Configs { get; set; }
        
    }
}