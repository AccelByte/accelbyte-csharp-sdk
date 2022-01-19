using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class KeyPagingSliceResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<KeyInfo>? Data { get; set; }
        
        [JsonPropertyName("paging")]
        public Paging? Paging { get; set; }
        
    }
}