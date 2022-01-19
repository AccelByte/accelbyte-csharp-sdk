using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelGetAdminUsersResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<ModelUserResponse>? Data { get; set; }
        
        [JsonPropertyName("Paging")]
        public AccountcommonPagination? Paging { get; set; }
        
    }
}