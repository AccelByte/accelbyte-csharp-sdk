using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("grantDays")]
        public string? GrantDays { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
    }
}