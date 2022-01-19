using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class Ownership : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("owned")]
        public bool? Owned { get; set; }
        
    }
}