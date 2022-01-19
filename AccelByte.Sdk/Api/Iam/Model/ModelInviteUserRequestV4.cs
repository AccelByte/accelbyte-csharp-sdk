using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelInviteUserRequestV4 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("assignedNamespaces")]
        public List<string>? AssignedNamespaces { get; set; }
        
        [JsonPropertyName("emailAddresses")]
        public List<string>? EmailAddresses { get; set; }
        
        [JsonPropertyName("isAdmin")]
        public bool? IsAdmin { get; set; }
        
        [JsonPropertyName("roleId")]
        public string? RoleId { get; set; }
        
    }
}