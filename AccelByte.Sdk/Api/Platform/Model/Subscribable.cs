using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class Subscribable : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("subscribable")]
        public bool? Subscribable_ { get; set; }
        
    }
}