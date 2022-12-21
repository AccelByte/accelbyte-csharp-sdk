// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RevokeItemSummary : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("itemId")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemId { get; set; }

        [JsonPropertyName("itemSku")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemSku { get; set; }

        [JsonPropertyName("itemType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ItemType { get; set; }

        [JsonPropertyName("revokeStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RevokeItemSummaryRevokeStatus? RevokeStatus { get; set; }

    }

    public class RevokeItemSummaryRevokeStatus : StringEnum<RevokeItemSummaryRevokeStatus>
    {
        public static readonly RevokeItemSummaryRevokeStatus COMPLETED
            = new RevokeItemSummaryRevokeStatus("COMPLETED");

        public static readonly RevokeItemSummaryRevokeStatus SKIPPED
            = new RevokeItemSummaryRevokeStatus("SKIPPED");


        public static implicit operator RevokeItemSummaryRevokeStatus(string value)
        {
            return NewValue(value);
        }

        public RevokeItemSummaryRevokeStatus(string enumValue)
            : base(enumValue)
        {

        }
    }    
}