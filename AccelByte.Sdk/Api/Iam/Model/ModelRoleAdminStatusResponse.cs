using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleAdminStatusResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AdminRole")]
        public bool? AdminRole { get; set; }
        
    }
}