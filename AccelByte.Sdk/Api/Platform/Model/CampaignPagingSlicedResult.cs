using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CampaignPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<CampaignInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}