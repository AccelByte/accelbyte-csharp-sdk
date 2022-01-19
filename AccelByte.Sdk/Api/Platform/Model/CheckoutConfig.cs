using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CheckoutConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }
        
        [JsonPropertyName("secretKey")]
        public string? SecretKey { get; set; }
        
    }
}