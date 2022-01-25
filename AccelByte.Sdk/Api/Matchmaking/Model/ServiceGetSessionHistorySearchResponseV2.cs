using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ServiceGetSessionHistorySearchResponseV2 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ServiceGetSessionHistorySearchResponseItemV2>? Data { get; set; }
        
        [JsonPropertyName("pagination")]
        public ModelsPagination? Pagination { get; set; }
        
    }
}