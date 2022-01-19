using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("amount")]
        public long? Amount { get; set; }
        
    }
}