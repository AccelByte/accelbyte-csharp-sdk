// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsPluginRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsAppConfig? AppConfig { get; set; }

        [JsonPropertyName("customConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ModelsCustomConfig? CustomConfig { get; set; }

        [JsonPropertyName("customFunction")]
        public ModelsCustomFunction? CustomFunction { get; set; }

        [JsonPropertyName("extendType")]
        [JsonStringEnum]
        public ModelsPluginRequestExtendType? ExtendType { get; set; }

    }



    public class ModelsPluginRequestExtendType : StringEnum<ModelsPluginRequestExtendType>
    {
        public static readonly ModelsPluginRequestExtendType APP
            = new ModelsPluginRequestExtendType("APP");

        public static readonly ModelsPluginRequestExtendType CUSTOM
            = new ModelsPluginRequestExtendType("CUSTOM");


        public static implicit operator ModelsPluginRequestExtendType(string value)
        {
            return NewValue(value);
        }

        public ModelsPluginRequestExtendType(string enumValue)
            : base(enumValue)
        {

        }
    }
}