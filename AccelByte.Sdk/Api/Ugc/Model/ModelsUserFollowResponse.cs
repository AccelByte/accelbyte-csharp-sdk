using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsUserFollowResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("followStatus")]
        public bool? FollowStatus { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}