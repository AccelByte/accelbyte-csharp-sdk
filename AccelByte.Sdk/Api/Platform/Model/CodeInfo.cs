using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CodeInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("acquireOrderNo")]
        public string? AcquireOrderNo { get; set; }
        
        [JsonPropertyName("acquireUserId")]
        public string? AcquireUserId { get; set; }
        
        [JsonPropertyName("batchNo")]
        public int? BatchNo { get; set; }
        
        [JsonPropertyName("campaignId")]
        public string? CampaignId { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        
        [JsonPropertyName("items")]
        public List<RedeemableItem>? Items { get; set; }
        
        [JsonPropertyName("maxRedeemCountPerCampaignPerUser")]
        public int? MaxRedeemCountPerCampaignPerUser { get; set; }
        
        [JsonPropertyName("maxRedeemCountPerCode")]
        public int? MaxRedeemCountPerCode { get; set; }
        
        [JsonPropertyName("maxRedeemCountPerCodePerUser")]
        public int? MaxRedeemCountPerCodePerUser { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
        [JsonPropertyName("redeemEnd")]
        public DateTime? RedeemEnd { get; set; }
        
        [JsonPropertyName("redeemStart")]
        public DateTime? RedeemStart { get; set; }
        
        [JsonPropertyName("redeemType")]
        public string? RedeemType { get; set; }
        
        [JsonPropertyName("redeemedCount")]
        public int? RedeemedCount { get; set; }
        
        [JsonPropertyName("remainder")]
        public int? Remainder { get; set; }
        
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
        [JsonPropertyName("value")]
        public string? Value { get; set; }
        
    }
}