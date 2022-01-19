using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsAddPlayerRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("as_spectator")]
        public bool? AsSpectator { get; set; }
        
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }
        
    }
}