using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsAgentType : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AgentType")]
        public int? AgentType { get; set; }
        
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
    }
}