using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Leaderboard.Model
{
    public class ModelsSetUserVisibilityRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("visibility")]
        public bool? Visibility { get; set; }
        
    }
}