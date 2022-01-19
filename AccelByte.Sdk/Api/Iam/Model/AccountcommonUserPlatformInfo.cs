using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserPlatformInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}