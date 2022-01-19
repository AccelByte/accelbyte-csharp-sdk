using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelRoleNamesResponseV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<string>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
    }
}