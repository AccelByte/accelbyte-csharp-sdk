// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Cloudsave.Model
{
    public class ModelsPluginResponse : AccelByte.Sdk.Core.Model
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
        public ModelsPluginResponseExtendType? ExtendType { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

    }



    public class ModelsPluginResponseExtendType : StringEnum<ModelsPluginResponseExtendType>
    {
        public static readonly ModelsPluginResponseExtendType APP
            = new ModelsPluginResponseExtendType("APP");

        public static readonly ModelsPluginResponseExtendType CUSTOM
            = new ModelsPluginResponseExtendType("CUSTOM");


        public static implicit operator ModelsPluginResponseExtendType(string value)
        {
            return NewValue(value);
        }

        public ModelsPluginResponseExtendType(string enumValue)
            : base(enumValue)
        {

        }
    }
}