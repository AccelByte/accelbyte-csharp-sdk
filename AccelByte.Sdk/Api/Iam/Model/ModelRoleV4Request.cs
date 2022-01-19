using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleV4Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("adminRole")]
        public bool? AdminRole { get; set; }
        
        [JsonPropertyName("isWildcard")]
        public bool? IsWildcard { get; set; }
        
        [JsonPropertyName("roleName")]
        public string? RoleName { get; set; }
        
    }
}