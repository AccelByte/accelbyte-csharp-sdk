using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateGroupConfigurationRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("groupMaxMember")]
        public int? GroupMaxMember { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
    }
}