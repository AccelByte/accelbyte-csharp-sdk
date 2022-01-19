using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelAssignUserV4Request : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("assignedNamespaces")]
        public List<string>? AssignedNamespaces { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}