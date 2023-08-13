// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class RevocationPluginConfigUpdate : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("appConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public AppConfig? AppConfig { get; set; }

        [JsonPropertyName("customConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public BaseCustomConfig? CustomConfig { get; set; }

        [JsonPropertyName("extendType")]
        [JsonStringEnum]
        public RevocationPluginConfigUpdateExtendType? ExtendType { get; set; }

    }



    public class RevocationPluginConfigUpdateExtendType : StringEnum<RevocationPluginConfigUpdateExtendType>
    {
        public static readonly RevocationPluginConfigUpdateExtendType APP
            = new RevocationPluginConfigUpdateExtendType("APP");

        public static readonly RevocationPluginConfigUpdateExtendType CUSTOM
            = new RevocationPluginConfigUpdateExtendType("CUSTOM");


        public static implicit operator RevocationPluginConfigUpdateExtendType(string value)
        {
            return NewValue(value);
        }

        public RevocationPluginConfigUpdateExtendType(string enumValue)
            : base(enumValue)
        {

        }
    }
}