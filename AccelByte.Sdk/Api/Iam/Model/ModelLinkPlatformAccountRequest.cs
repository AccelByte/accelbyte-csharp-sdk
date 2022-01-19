using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelLinkPlatformAccountRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }
        
    }
}