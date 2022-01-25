using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelPublicUserResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("authType")]
        public string? AuthType { get; set; }
        
        [JsonPropertyName("bans")]
        public List<ModelUserActiveBanResponseV3>? Bans { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("deletionStatus")]
        public bool? DeletionStatus { get; set; }
        
        [JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }
        
        [JsonPropertyName("emailVerified")]
        public bool? EmailVerified { get; set; }
        
        [JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }
        
        [JsonPropertyName("lastDateOfBirthChangedTime")]
        public DateTime? LastDateOfBirthChangedTime { get; set; }
        
        [JsonPropertyName("lastEnabledChangedTime")]
        public DateTime? LastEnabledChangedTime { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("namespaceRoles")]
        public List<AccountcommonNamespaceRole>? NamespaceRoles { get; set; }
        
        [JsonPropertyName("permissions")]
        public List<ModelUserPermissionsResponseV3>? Permissions { get; set; }
        
        [JsonPropertyName("phoneVerified")]
        public bool? PhoneVerified { get; set; }
        
        [JsonPropertyName("platformId")]
        public string? PlatformId { get; set; }
        
        [JsonPropertyName("platformUserId")]
        public string? PlatformUserId { get; set; }
        
        [JsonPropertyName("roles")]
        public List<string>? Roles { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
        [JsonPropertyName("userName")]
        public string? UserName { get; set; }
        
    }
}