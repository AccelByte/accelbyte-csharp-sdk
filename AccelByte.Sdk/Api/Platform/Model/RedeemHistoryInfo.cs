using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RedeemHistoryInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("campaignId")]
        public string? CampaignId { get; set; }
        
        [JsonPropertyName("code")]
        public string? Code { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("orderNo")]
        public string? OrderNo { get; set; }
        
        [JsonPropertyName("redeemedAt")]
        public DateTime? RedeemedAt { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("userId")]
        public string? UserId { get; set; }
        
    }
}