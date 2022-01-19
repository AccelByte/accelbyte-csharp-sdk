using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelListAssignedUsersV4Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelAssignedUserV4Response>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
    }
}