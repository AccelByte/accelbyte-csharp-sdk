using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonPlatformAccount : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }
        
    }
}