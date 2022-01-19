using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsContentLikeResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentId")]
        public string? ContentId { get; set; }
        
        [JsonPropertyName("likeStatus")]
        public bool? LikeStatus { get; set; }
        
    }
}