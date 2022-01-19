using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPermissionDeleteRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Action")]
        public int? Action { get; set; }
        
        [JsonPropertyName("Resource")]
        public string? Resource { get; set; }
        
    }
}