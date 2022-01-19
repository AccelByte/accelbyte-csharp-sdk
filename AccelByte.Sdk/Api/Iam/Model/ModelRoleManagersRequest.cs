using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleManagersRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Managers")]
        public List<AccountcommonRoleManager>? Managers { get; set; }
        
    }
}