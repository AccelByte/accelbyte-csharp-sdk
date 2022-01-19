using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketSaleIncrementResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("maxSaleCount")]
        public int? MaxSaleCount { get; set; }
        
        [JsonPropertyName("success")]
        public bool? Success { get; set; }
        
    }
}