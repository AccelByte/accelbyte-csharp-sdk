using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsGroupRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("groupCustomRule")]
        public ModelsGroupRuleGroupCustomRule? GroupCustomRule { get; set; }
        
        [JsonPropertyName("groupPredefinedRules")]
        public List<ModelsRule>? GroupPredefinedRules { get; set; }
        
    }
}