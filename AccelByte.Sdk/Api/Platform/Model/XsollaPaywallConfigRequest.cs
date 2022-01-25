using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XsollaPaywallConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("device")]
        public string? Device { get; set; }
        
        [JsonPropertyName("showCloseButton")]
        public bool? ShowCloseButton { get; set; }
        
        [JsonPropertyName("size")]
        public string? Size { get; set; }
        
        [JsonPropertyName("theme")]
        public string? Theme { get; set; }
        
    }
}