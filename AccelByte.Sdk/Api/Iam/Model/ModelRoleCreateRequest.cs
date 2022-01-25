using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleCreateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AdminRole")]
        public bool? AdminRole { get; set; }
        
        [JsonPropertyName("Managers")]
        public List<AccountcommonRoleManager>? Managers { get; set; }
        
        [JsonPropertyName("Members")]
        public List<AccountcommonRoleMember>? Members { get; set; }
        
        [JsonPropertyName("Permissions")]
        public List<AccountcommonPermission>? Permissions { get; set; }
        
        [JsonPropertyName("RoleName")]
        public string? RoleName { get; set; }
        
    }
}