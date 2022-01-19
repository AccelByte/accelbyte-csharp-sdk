using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateScreenshotResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("screenshots")]
        public List<ModelsScreenshotResponse>? Screenshots { get; set; }
        
    }
}