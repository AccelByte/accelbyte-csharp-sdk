using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleUpdateRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isWildcard")]
        public bool? IsWildcard { get; set; }
        
        [JsonPropertyName("roleName")]
        public string? RoleName { get; set; }
        
    }
}