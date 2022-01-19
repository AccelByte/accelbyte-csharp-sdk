using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ListUserSeasonInfoPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<ListUserSeasonInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
        [JsonPropertyName("total")]
        public long? Total { get; set; }
        
    }
}