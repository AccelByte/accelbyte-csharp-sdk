using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreatorFollowState : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("state")]
        public bool? State { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}