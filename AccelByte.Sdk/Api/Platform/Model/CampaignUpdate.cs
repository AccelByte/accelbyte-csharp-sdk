using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CampaignUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
        [JsonPropertyName("items")]
        public List<RedeemableItem>? Items { get; set; }
        
        [JsonPropertyName("maxRedeemCountPerCampaignPerUser")]
        public int? MaxRedeemCountPerCampaignPerUser { get; set; }
        
        [JsonPropertyName("maxRedeemCountPerCode")]
        public int? MaxRedeemCountPerCode { get; set; }
        
        [JsonPropertyName("maxRedeemCountPerCodePerUser")]
        public int? MaxRedeemCountPerCodePerUser { get; set; }
        
        [JsonPropertyName("maxSaleCount")]
        public int? MaxSaleCount { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("redeemEnd")]
        public DateTime? RedeemEnd { get; set; }
        
        [JsonPropertyName("redeemStart")]
        public DateTime? RedeemStart { get; set; }
        
        [JsonPropertyName("redeemType")]
        public string? RedeemType { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }
        
    }
}