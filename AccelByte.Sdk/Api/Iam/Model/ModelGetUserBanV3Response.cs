using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelGetUserBanV3Response : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ModelUserBanResponseV3>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public AccountcommonPaginationV3? Paging { get; set; }
        
    }
}