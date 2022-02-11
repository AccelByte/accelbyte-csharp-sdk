using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Social.Model
{
    public class ADTOObjectForResettingUserStatItems : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("additionalData")]
        public Dictionary<string, object>? AdditionalData { get; set; }
        
        [JsonPropertyName("statCode")]
        public string? StatCode { get; set; }
        
    }
}