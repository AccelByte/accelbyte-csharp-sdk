// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CampaignInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("boothName")]
        public string? BoothName { get; set; }
        
        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }
        
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
        
        [JsonPropertyName("maxSaleCount")]
        public int? MaxSaleCount { get; set; }
        
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        
        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }
        
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
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        
        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        
    }
}