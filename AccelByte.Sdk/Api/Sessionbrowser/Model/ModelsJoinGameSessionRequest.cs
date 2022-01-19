using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Sessionbrowser.Model
{
    public class ModelsJoinGameSessionRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("password")]
        public string? Password { get; set; }
        
    }
}