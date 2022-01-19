using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Lobby.Model
{
    public class ModelsPartyPUTCustomAttributesRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("custom_attribute")]
        public Dictionary<object, object>? CustomAttribute { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public long? UpdatedAt { get; set; }
        
    }
}