using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreatorOverviewResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("followCount")]
        public int? FollowCount { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
    }
}