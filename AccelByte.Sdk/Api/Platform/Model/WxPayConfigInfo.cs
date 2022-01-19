using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class WxPayConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("certPath")]
        public string? CertPath { get; set; }
        
        [JsonPropertyName("key")]
        public string? Key { get; set; }
        
        [JsonPropertyName("mchid")]
        public string? Mchid { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
    }
}