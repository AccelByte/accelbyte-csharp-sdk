using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class GoogleIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("applicationName")]
        public string? ApplicationName { get; set; }
        
        [JsonPropertyName("serviceAccountId")]
        public string? ServiceAccountId { get; set; }
        
    }
}