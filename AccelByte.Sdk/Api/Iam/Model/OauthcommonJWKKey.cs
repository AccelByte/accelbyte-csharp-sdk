using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class OauthcommonJWKKey : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("alg")]
        public string? Alg { get; set; }
        
        [JsonPropertyName("e")]
        public string? E { get; set; }
        
        [JsonPropertyName("kid")]
        public string? Kid { get; set; }
        
        [JsonPropertyName("kty")]
        public string? Kty { get; set; }
        
        [JsonPropertyName("n")]
        public string? N { get; set; }
        
        [JsonPropertyName("use")]
        public string? Use { get; set; }
        
    }
}