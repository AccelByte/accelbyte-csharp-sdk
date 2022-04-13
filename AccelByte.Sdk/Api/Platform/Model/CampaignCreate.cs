// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class CampaignCreate : AccelByte.Sdk.Core.Model
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
        public CampaignCreateRedeemType? RedeemType { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public CampaignCreateStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public CampaignCreateType? Type { get; set; }

    }

    public class CampaignCreateRedeemType : StringEnum<CampaignCreateRedeemType>
    {
        public static readonly CampaignCreateRedeemType ITEM
            = new CampaignCreateRedeemType("ITEM");


        public static implicit operator CampaignCreateRedeemType(string value)
        {
            return Create(value);
        }

        public CampaignCreateRedeemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CampaignCreateStatus : StringEnum<CampaignCreateStatus>
    {
        public static readonly CampaignCreateStatus ACTIVE
            = new CampaignCreateStatus("ACTIVE");

        public static readonly CampaignCreateStatus INACTIVE
            = new CampaignCreateStatus("INACTIVE");


        public static implicit operator CampaignCreateStatus(string value)
        {
            return Create(value);
        }

        public CampaignCreateStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CampaignCreateType : StringEnum<CampaignCreateType>
    {
        public static readonly CampaignCreateType REDEMPTION
            = new CampaignCreateType("REDEMPTION");


        public static implicit operator CampaignCreateType(string value)
        {
            return Create(value);
        }

        public CampaignCreateType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}