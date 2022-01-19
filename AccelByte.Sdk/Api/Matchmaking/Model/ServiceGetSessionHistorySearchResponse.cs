using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Matchmaking.Model
{
    public class ServiceGetSessionHistorySearchResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ServiceGetSessionHistorySearchResponseItem>? Data { get; set; }
        
        [JsonPropertyName("pagination")]
        public ModelsPagination? Pagination { get; set; }
        
    }
}