using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PaymentProviderConfigPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<PaymentProviderConfigInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}