using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBanV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("ban")]
        public string? Ban { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("descriptions")]
        public AccountcommonDescription? Descriptions { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
    }
}