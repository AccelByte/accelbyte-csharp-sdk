using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class ModelSearchUsersByPlatformIDResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Data")]
        public List<AccountcommonUserSearchByPlatformIDResult>? Data { get; set; }
        
        [JsonPropertyName("Paging")]
        public AccountcommonPagination? Paging { get; set; }
        
    }
}