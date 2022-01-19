using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Basic.Model
{
    public class UserBanRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("actionId")]
        public int? ActionId { get; set; }
        
        [JsonPropertyName("comment")]
        public string? Comment { get; set; }
        
        [JsonPropertyName("userIds")]
        public List<string>? UserIds { get; set; }
        
    }
}