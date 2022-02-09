using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsPublicCreateNewGroupRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("configurationCode")]
        public string? ConfigurationCode { get; set; }
        
        [JsonPropertyName("customAttributes")]
        public Dictionary<string, object>? CustomAttributes { get; set; }
        
        [JsonPropertyName("groupDescription")]
        public string? GroupDescription { get; set; }
        
        [JsonPropertyName("groupIcon")]
        public string? GroupIcon { get; set; }
        
        [JsonPropertyName("groupMaxMember")]
        public int? GroupMaxMember { get; set; }
        
        [JsonPropertyName("groupName")]
        public string? GroupName { get; set; }
        
        [JsonPropertyName("groupRegion")]
        public string? GroupRegion { get; set; }
        
        [JsonPropertyName("groupRules")]
        public ModelsGroupRule? GroupRules { get; set; }
        
        [JsonPropertyName("groupType")]
        public string? GroupType { get; set; }
        
    }
}