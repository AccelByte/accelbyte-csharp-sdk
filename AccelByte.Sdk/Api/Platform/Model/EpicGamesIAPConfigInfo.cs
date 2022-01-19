using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class EpicGamesIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("sandboxId")]
        public string? SandboxId { get; set; }
        
    }
}