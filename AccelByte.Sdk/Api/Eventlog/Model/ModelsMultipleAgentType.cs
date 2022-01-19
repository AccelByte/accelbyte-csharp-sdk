using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsMultipleAgentType : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgentTypes")]
        public List<ModelsAgentType>? AgentTypes { get; set; }
        
    }
}