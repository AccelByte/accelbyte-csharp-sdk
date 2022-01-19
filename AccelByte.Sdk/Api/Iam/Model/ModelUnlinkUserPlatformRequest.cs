using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelUnlinkUserPlatformRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platformNamespace")]
        public string? PlatformNamespace { get; set; }
        
    }
}