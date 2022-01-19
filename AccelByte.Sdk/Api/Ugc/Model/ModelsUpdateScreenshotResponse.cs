using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsUpdateScreenshotResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("screenshots")]
        public List<ModelsUpdateScreenshot>? Screenshots { get; set; }
        
    }
}