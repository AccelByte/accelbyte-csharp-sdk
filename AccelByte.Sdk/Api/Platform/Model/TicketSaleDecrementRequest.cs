using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketSaleDecrementRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }
        
    }
}