using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class DLCItemConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        public List<DLCItem>? Data { get; set; }
        
    }
}