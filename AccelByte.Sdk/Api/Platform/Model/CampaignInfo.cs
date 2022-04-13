// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

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
        [JsonStringEnum]
        public CampaignInfoRedeemType? RedeemType { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public CampaignInfoStatus? Status { get; set; }

        [JsonPropertyName("tags")]
        public List<string>? Tags { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public CampaignInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

    }

    public class CampaignInfoRedeemType : StringEnum<CampaignInfoRedeemType>
    {
        public static readonly CampaignInfoRedeemType ITEM
            = new CampaignInfoRedeemType("ITEM");


        public static implicit operator CampaignInfoRedeemType(string value)
        {
            return Create(value);
        }

        public CampaignInfoRedeemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CampaignInfoStatus : StringEnum<CampaignInfoStatus>
    {
        public static readonly CampaignInfoStatus ACTIVE
            = new CampaignInfoStatus("ACTIVE");

        public static readonly CampaignInfoStatus INACTIVE
            = new CampaignInfoStatus("INACTIVE");


        public static implicit operator CampaignInfoStatus(string value)
        {
            return Create(value);
        }

        public CampaignInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CampaignInfoType : StringEnum<CampaignInfoType>
    {
        public static readonly CampaignInfoType REDEMPTION
            = new CampaignInfoType("REDEMPTION");


        public static implicit operator CampaignInfoType(string value)
        {
            return Create(value);
        }

        public CampaignInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}