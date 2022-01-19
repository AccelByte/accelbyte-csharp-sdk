using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class FulfillmentScriptUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("grantDays")]
        public string? GrantDays { get; set; }
        
    }
}