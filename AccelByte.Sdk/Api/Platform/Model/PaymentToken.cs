using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentToken : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; }
        
    }
}