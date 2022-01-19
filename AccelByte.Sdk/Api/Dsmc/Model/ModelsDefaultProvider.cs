using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsDefaultProvider : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }
        
    }
}