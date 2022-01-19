using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsImportResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("affected")]
        public List<string>? Affected { get; set; }
        
        [JsonPropertyName("failed")]
        public List<string>? Failed { get; set; }
        
    }
}