using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ListSeasonInfoPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ListSeasonInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}