using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ugc.Model
{
    public class ModelsAddDownloadCountResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("contentId")]
        public string? ContentId { get; set; }
        
    }
}