// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

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
        [JsonStringEnum]
        public CodeInfoRedeemType? RedeemType { get; set; }

        [JsonPropertyName("redeemedCount")]
        public int? RedeemedCount { get; set; }

        [JsonPropertyName("remainder")]
        public int? Remainder { get; set; }

        [JsonPropertyName("status")]
        [JsonStringEnum]
        public CodeInfoStatus? Status { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public CodeInfoType? Type { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("value")]
        public string? Value { get; set; }

    }

    public class CodeInfoRedeemType : StringEnum<CodeInfoRedeemType>
    {
        public static readonly CodeInfoRedeemType ITEM
            = new CodeInfoRedeemType("ITEM");


        public static implicit operator CodeInfoRedeemType(string value)
        {
            return Create(value);
        }

        public CodeInfoRedeemType(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CodeInfoStatus : StringEnum<CodeInfoStatus>
    {
        public static readonly CodeInfoStatus ACTIVE
            = new CodeInfoStatus("ACTIVE");

        public static readonly CodeInfoStatus INACTIVE
            = new CodeInfoStatus("INACTIVE");


        public static implicit operator CodeInfoStatus(string value)
        {
            return Create(value);
        }

        public CodeInfoStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    

    public class CodeInfoType : StringEnum<CodeInfoType>
    {
        public static readonly CodeInfoType REDEMPTION
            = new CodeInfoType("REDEMPTION");


        public static implicit operator CodeInfoType(string value)
        {
            return Create(value);
        }

        public CodeInfoType(string enumValue)
            : base(enumValue)
        {

        }
    }    
}