using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateGroupConfigurationGlobalRulesRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ruleDetail")]
        public List<ModelsRuleInformation>? RuleDetail { get; set; }
        
    }
}