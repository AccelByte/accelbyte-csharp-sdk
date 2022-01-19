using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsRule : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allowedAction")]
        public string? AllowedAction { get; set; }
        
        [JsonPropertyName("ruleDetail")]
        public List<ModelsRuleInformation>? RuleDetail { get; set; }
        
    }
}