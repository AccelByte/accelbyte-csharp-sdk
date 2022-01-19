using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsCreateScreenshotRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("screenshots")]
        public List<ModelsCreateScreenshotRequestItem>? Screenshots { get; set; }
        
    }
}