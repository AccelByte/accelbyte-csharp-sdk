using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class StadiaIAPConfigInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("jsonFile")]
        public string? JsonFile { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
    }
}