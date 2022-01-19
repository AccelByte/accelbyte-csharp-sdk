using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBanReasonV3 : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("reason")]
        public string? Reason { get; set; }
        
    }
}