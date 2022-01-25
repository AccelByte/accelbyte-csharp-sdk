using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlatformDlcEntry : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("platform")]
        public string? Platform { get; set; }
        
        [JsonPropertyName("platformDlcIdMap")]
        public Dictionary<string, string>? PlatformDlcIdMap { get; set; }
        
    }
}