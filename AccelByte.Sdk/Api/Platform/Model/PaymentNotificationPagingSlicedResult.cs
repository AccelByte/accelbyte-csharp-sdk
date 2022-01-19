using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentNotificationPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<PaymentNotificationInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}