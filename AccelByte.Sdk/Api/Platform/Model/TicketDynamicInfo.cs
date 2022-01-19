using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketDynamicInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("availableSaleCount")]
        public int? AvailableSaleCount { get; set; }
        
    }
}