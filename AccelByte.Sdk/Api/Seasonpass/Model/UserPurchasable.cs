using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class UserPurchasable : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("passItemId")]
        public string? PassItemId { get; set; }
        
        [JsonPropertyName("tierItemCount")]
        public int? TierItemCount { get; set; }
        
        [JsonPropertyName("tierItemId")]
        public string? TierItemId { get; set; }
        
    }
}