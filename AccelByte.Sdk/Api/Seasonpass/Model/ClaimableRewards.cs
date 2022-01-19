using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class ClaimableRewards : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("toClaimRewards")]
        public Dictionary<object, object>? ToClaimRewards { get; set; }
        
        [JsonPropertyName("claimingRewards")]
        public Dictionary<object, object>? ClaimingRewards { get; set; }
        
    }
}