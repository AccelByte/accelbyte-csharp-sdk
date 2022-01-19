using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class AliPayConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appId")]
        public string? AppId { get; set; }
        
        [JsonPropertyName("privateKey")]
        public string? PrivateKey { get; set; }
        
        [JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
    }
}