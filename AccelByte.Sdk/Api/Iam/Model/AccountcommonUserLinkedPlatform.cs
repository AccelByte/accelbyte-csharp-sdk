using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonUserLinkedPlatform : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("EmailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("LinkedAt")]
        public string? LinkedAt { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("OriginNamespace")]
        public string? OriginNamespace { get; set; }
        
        [JsonPropertyName("PlatformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("PlatformUserId")]
        public string? PlatformUserId { get; set; }
        
        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("XUID")]
        public string? XUID { get; set; }
        
    }
}