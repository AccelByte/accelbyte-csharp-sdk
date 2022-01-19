using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsGetContentPreviewResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("preview")]
        public string? Preview { get; set; }
        
    }
}