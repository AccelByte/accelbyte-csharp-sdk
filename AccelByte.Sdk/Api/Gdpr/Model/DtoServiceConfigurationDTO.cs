// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Gdpr.Model
{
    public class DtoServiceConfigurationDTO : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("extendConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DtoExtendConfigDTO? ExtendConfig { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("serviceConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DtoServiceConfigDTO? ServiceConfig { get; set; }

        [JsonPropertyName("type")]
        [JsonStringEnum]
        public DtoServiceConfigurationDTOType? Type { get; set; }

    }



    public class DtoServiceConfigurationDTOType : StringEnum<DtoServiceConfigurationDTOType>
    {
        public static readonly DtoServiceConfigurationDTOType EXTEND
            = new DtoServiceConfigurationDTOType("EXTEND");

        public static readonly DtoServiceConfigurationDTOType SERVICE
            = new DtoServiceConfigurationDTOType("SERVICE");


        public static implicit operator DtoServiceConfigurationDTOType(string value)
        {
            return NewValue(value);
        }

        public DtoServiceConfigurationDTOType(string enumValue)
            : base(enumValue)
        {

        }
    }
}