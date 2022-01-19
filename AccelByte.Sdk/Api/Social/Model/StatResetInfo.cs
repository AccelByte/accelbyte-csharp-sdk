using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class StatResetInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<object, object>? AdditionalData { get; set; }
        
    }
}