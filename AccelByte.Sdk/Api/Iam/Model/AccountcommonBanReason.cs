using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Iam.Model
{
    public class AccountcommonBanReason : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("Reason")]
        public string? Reason { get; set; }
        
    }
}