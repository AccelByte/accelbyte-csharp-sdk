using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPlatformUserInformation : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("EmailAddress")]
        public string? EmailAddress { get; set; }
        
        [JsonPropertyName("LinkedAt")]
        public DateTime? LinkedAt { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("PlatformID")]
        public string? PlatformID { get; set; }
        
        [JsonPropertyName("PlatformUserID")]
        public string? PlatformUserID { get; set; }
        
        [JsonPropertyName("XUID")]
        public string? XUID { get; set; }
        
    }
}