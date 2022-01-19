using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class XblIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("businessPartnerCertFileName")]
        public string? BusinessPartnerCertFileName { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
        [JsonPropertyName("relyingPartyCert")]
        public string? RelyingPartyCert { get; set; }
        
    }
}