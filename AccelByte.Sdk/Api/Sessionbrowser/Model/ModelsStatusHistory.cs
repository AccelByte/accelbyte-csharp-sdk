using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsStatusHistory : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("time_stamp")]
        public DateTime? TimeStamp { get; set; }
        
    }
}