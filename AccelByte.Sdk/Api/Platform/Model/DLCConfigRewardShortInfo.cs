// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class DLCConfigRewardShortInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("data")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, object>? Data { get; set; }

        [JsonPropertyName("dlcType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public DLCConfigRewardShortInfoDlcType? DlcType { get; set; }

    }



    public class DLCConfigRewardShortInfoDlcType : StringEnum<DLCConfigRewardShortInfoDlcType>
    {
        public static readonly DLCConfigRewardShortInfoDlcType EPICGAMES
            = new DLCConfigRewardShortInfoDlcType("EPICGAMES");

        public static readonly DLCConfigRewardShortInfoDlcType OCULUS
            = new DLCConfigRewardShortInfoDlcType("OCULUS");

        public static readonly DLCConfigRewardShortInfoDlcType PSN
            = new DLCConfigRewardShortInfoDlcType("PSN");

        public static readonly DLCConfigRewardShortInfoDlcType STEAM
            = new DLCConfigRewardShortInfoDlcType("STEAM");

        public static readonly DLCConfigRewardShortInfoDlcType XBOX
            = new DLCConfigRewardShortInfoDlcType("XBOX");


        public static implicit operator DLCConfigRewardShortInfoDlcType(string value)
        {
            return NewValue(value);
        }

        public DLCConfigRewardShortInfoDlcType(string enumValue)
            : base(enumValue)
        {

        }
    }
}