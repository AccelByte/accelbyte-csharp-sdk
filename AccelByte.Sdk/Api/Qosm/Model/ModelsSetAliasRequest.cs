using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Qosm.Model
{
    public class ModelsSetAliasRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alias")]
        public string? Alias { get; set; }
        
    }
}