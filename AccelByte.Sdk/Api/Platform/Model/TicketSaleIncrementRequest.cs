using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketSaleIncrementRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }
        
        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }
        
    }
}