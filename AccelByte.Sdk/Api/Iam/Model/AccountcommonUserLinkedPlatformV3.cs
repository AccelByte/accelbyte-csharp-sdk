using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserLinkedPlatformV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("accountGroup")]
        public string? AccountGroup { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("linkedAt")]
        public string? LinkedAt { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("originNamespace")]
        public string? OriginNamespace { get; set; }
        
        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}