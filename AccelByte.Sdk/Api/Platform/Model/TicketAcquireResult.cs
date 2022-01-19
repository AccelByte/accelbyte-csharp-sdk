using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class TicketAcquireResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("values")]
        public List<string>? Values { get; set; }
        
    }
}