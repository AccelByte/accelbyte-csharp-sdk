// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RevokeResult : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("revokeItemSummaries")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<RevokeItemSummary>? RevokeItemSummaries { get; set; }

        [JsonPropertyName("reward")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public PlatformReward? Reward { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public RevokeResultStatus? Status { get; set; }

    }



    public class RevokeResultStatus : StringEnum<RevokeResultStatus>
    {
        public static readonly RevokeResultStatus COMPLETED
            = new RevokeResultStatus("COMPLETED");

        public static readonly RevokeResultStatus SKIPPED
            = new RevokeResultStatus("SKIPPED");


        public static implicit operator RevokeResultStatus(string value)
        {
            return NewValue(value);
        }

        public RevokeResultStatus(string enumValue)
            : base(enumValue)
        {

        }
    }
}