using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EpicGamesReconcileRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("epicGamesJwtToken")]
        public string? EpicGamesJwtToken { get; set; }
        
    }
}