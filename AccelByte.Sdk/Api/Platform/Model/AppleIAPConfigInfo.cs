using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AppleIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
    }
}