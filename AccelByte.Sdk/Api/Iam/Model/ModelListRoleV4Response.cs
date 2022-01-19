using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelListRoleV4Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelRoleV4Response>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
    }
}