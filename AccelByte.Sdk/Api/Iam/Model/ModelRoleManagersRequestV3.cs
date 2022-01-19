using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleManagersRequestV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("managers")]
        public List<AccountcommonRoleManagerV3>? Managers { get; set; }
        
    }
}