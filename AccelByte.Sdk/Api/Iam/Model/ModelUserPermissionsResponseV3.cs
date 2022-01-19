using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUserPermissionsResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        public int? Action { get; set; }
        
        [JsonPropertyName("resource")]
        public string? Resource { get; set; }
        
        [JsonPropertyName("schedAction")]
        public int? SchedAction { get; set; }
        
        [JsonPropertyName("schedCron")]
        public string? SchedCron { get; set; }
        
        [JsonPropertyName("schedRange")]
        public List<string>? SchedRange { get; set; }
        
    }
}