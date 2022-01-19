using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsUpdateGroupCustomRuleRequestV1 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("groupCustomRule")]
        public Dictionary<object, object>? GroupCustomRule { get; set; }
        
    }
}