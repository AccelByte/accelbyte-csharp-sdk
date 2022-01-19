using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsUserFollowRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("followStatus")]
        public bool? FollowStatus { get; set; }
        
    }
}