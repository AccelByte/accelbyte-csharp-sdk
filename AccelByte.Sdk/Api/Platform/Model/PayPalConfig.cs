using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PayPalConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientID")]
        public string? ClientID { get; set; }
        
        [JsonPropertyName("clientSecret")]
        public string? ClientSecret { get; set; }
        
        [JsonPropertyName("returnUrl")]
        public string? ReturnUrl { get; set; }
        
        [JsonPropertyName("webHookId")]
        public string? WebHookId { get; set; }
        
    }
}