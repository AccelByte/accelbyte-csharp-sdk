using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsContentLikeRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("likeStatus")]
        public bool? LikeStatus { get; set; }
        
    }
}