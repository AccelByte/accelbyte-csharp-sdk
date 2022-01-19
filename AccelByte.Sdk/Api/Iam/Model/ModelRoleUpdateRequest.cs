using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleUpdateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("RoleName")]
        public string? RoleName { get; set; }
        
    }
}