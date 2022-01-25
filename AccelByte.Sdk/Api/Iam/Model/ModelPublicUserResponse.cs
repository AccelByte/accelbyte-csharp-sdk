using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPublicUserResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AuthType")]
        public string? AuthType { get; set; }
        
        [JsonPropertyName("Bans")]
        public List<ModelUserActiveBanResponse>? Bans { get; set; }
        
        [JsonPropertyName("CreatedAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("DeletionStatus")]
        public bool? DeletionStatus { get; set; }
        
        [JsonPropertyName("DisplayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("EmailVerified")]
        public bool? EmailVerified { get; set; }
        
        [JsonPropertyName("Enabled")]
        public bool? Enabled { get; set; }
        
        [JsonPropertyName("LastEnabledChangedTime")]
        public DateTime? LastEnabledChangedTime { get; set; }
        
        [JsonPropertyName("LoginId")]
        public string? LoginId { get; set; }
        
        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("NamespaceRoles")]
        public List<AccountcommonNamespaceRole>? NamespaceRoles { get; set; }
        
        [JsonPropertyName("Permissions")]
        public List<AccountcommonPermission>? Permissions { get; set; }
        
        [JsonPropertyName("PhoneVerified")]
        public bool? PhoneVerified { get; set; }
        
        [JsonPropertyName("PlatformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("PlatformUserId")]
        public string? PlatformUserId { get; set; }
        
        [JsonPropertyName("Roles")]
        public List<string>? Roles { get; set; }
        
        [JsonPropertyName("UserId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("Username")]
        public string? Username { get; set; }
        
        [JsonPropertyName("XUID")]
        public string? XUID { get; set; }
        
    }
}