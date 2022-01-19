using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class ADTOForUnbanUserAPICall : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
        
        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }
        
    }
}