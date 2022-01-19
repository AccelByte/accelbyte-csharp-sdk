using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Group.Model
{
    public class ModelsRolePermission : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("action")]
        public int? Action { get; set; }
        
        [JsonPropertyName("resourceName")]
        public string? ResourceName { get; set; }
        
    }
}