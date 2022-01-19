using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketBoothID : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}