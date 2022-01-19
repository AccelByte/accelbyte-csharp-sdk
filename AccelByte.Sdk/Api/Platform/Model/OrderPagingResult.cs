using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class OrderPagingResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<OrderInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
        [JsonPropertyName("total")]
        public long? Total { get; set; }
        
    }
}