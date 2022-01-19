using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsServerLogs : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("logs")]
        public string? Logs { get; set; }
        
    }
}