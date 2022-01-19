using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppleIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
    }
}