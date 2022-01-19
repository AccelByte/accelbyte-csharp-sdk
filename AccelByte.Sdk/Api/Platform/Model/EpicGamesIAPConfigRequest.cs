using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EpicGamesIAPConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("sandboxId")]
        public string? SandboxId { get; set; }
        
    }
}