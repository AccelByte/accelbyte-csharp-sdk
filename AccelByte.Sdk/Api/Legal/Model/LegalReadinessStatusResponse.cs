using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Legal.Model
{
    public class LegalReadinessStatusResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("isReady")]
        public bool? IsReady { get; set; }
        
    }
}