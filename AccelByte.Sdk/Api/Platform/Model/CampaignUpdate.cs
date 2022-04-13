// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

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
        [JsonStringEnum]
        public CampaignUpdateRedeemType? RedeemType { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public CampaignUpdateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

    }

    public class CampaignUpdateRedeemType : StringEnum<CampaignUpdateRedeemType>
    {
        public static readonly CampaignUpdateRedeemType ITEM
            = new CampaignUpdateRedeemType("ITEM");


        public static implicit operator CampaignUpdateRedeemType(string value)
        {
            return Create(value);
        }

        public CampaignUpdateRedeemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CampaignUpdateStatus : StringEnum<CampaignUpdateStatus>
    {
        public static readonly CampaignUpdateStatus ACTIVE
            = new CampaignUpdateStatus("ACTIVE");

        public static readonly CampaignUpdateStatus INACTIVE
            = new CampaignUpdateStatus("INACTIVE");


        public static implicit operator CampaignUpdateStatus(string value)
        {
            return Create(value);
        }

        public CampaignUpdateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}