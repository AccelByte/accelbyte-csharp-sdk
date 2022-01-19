using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Customization : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("settings")]
        public string? Settings { get; set; }
        
    }
}