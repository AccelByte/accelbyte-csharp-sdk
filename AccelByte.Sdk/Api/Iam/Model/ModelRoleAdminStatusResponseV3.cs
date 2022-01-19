using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleAdminStatusResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("adminRole")]
        public bool? AdminRole { get; set; }
        
    }
}