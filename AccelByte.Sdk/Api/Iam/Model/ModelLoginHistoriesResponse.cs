using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelLoginHistoriesResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<ModelUserLoginHistoryResponse>? Data { get; set; }
        
        [JsonPropertyName("Paging")]
        public AccountcommonPagination? Paging { get; set; }
        
    }
}