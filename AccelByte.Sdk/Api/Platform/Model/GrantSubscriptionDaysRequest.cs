using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class GrantSubscriptionDaysRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("grantDays")]
        public int? GrantDays { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
    }
}