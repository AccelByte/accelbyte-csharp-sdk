using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class PlatformDLCConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<PlatformDlcEntry>? Data { get; set; }
        
    }
}