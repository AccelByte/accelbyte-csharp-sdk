using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class UserStatItemPagingSlicedResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<UserStatItemInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}