// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class LootBoxPluginConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AppConfig? AppConfig { get; set; }

        [JsonPropertyName("customConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BaseCustomConfig? CustomConfig { get; set; }

        [JsonPropertyName("extendType")]
        [JsonStringEnum]
        public LootBoxPluginConfigUpdateExtendType? ExtendType { get; set; }

    }



    public class LootBoxPluginConfigUpdateExtendType : StringEnum<LootBoxPluginConfigUpdateExtendType>
    {
        public static readonly LootBoxPluginConfigUpdateExtendType APP
            = new LootBoxPluginConfigUpdateExtendType("APP");

        public static readonly LootBoxPluginConfigUpdateExtendType CUSTOM
            = new LootBoxPluginConfigUpdateExtendType("CUSTOM");


        public static implicit operator LootBoxPluginConfigUpdateExtendType(string value)
        {
            return NewValue(value);
        }

        public LootBoxPluginConfigUpdateExtendType(string enumValue)
            : base(enumValue)
        {

        }
    }
}