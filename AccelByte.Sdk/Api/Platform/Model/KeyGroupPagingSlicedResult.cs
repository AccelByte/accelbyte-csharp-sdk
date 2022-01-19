using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyGroupPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<KeyGroupInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}