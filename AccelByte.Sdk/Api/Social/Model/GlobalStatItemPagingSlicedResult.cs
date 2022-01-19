using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class GlobalStatItemPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<GlobalStatItemInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}