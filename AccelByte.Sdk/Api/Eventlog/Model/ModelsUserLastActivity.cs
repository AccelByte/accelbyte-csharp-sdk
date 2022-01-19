using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Eventlog.Model
{
    public class ModelsUserLastActivity : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("LastActivityTime")]
        public DateTime? LastActivityTime { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("UserID")]
        public string? UserID { get; set; }
        
    }
}