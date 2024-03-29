// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class LootBoxConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("rewardCount")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? RewardCount { get; set; }

        [JsonPropertyName("rewards")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<LootBoxReward>? Rewards { get; set; }

        [JsonPropertyName("rollFunction")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public LootBoxConfigRollFunction? RollFunction { get; set; }

    }



    public class LootBoxConfigRollFunction : StringEnum<LootBoxConfigRollFunction>
    {
        public static readonly LootBoxConfigRollFunction CUSTOM
            = new LootBoxConfigRollFunction("CUSTOM");

        public static readonly LootBoxConfigRollFunction DEFAULT
            = new LootBoxConfigRollFunction("DEFAULT");


        public static implicit operator LootBoxConfigRollFunction(string value)
        {
            return NewValue(value);
        }

        public LootBoxConfigRollFunction(string enumValue)
            : base(enumValue)
        {

        }
    }
}