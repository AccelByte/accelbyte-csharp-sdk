// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Converters;

namespace AccelByte.Sdk.Api.Platform.Model
{
    public class GrpcServerInfo : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("address")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Address { get; set; }

        [JsonPropertyName("connectionTypeEnum")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonStringEnum]
        public GrpcServerInfoConnectionTypeEnum? ConnectionTypeEnum { get; set; }

        [JsonPropertyName("status")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Status { get; set; }

        [JsonPropertyName("tlsConfig")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public TLSConfig? TlsConfig { get; set; }

    }



    public class GrpcServerInfoConnectionTypeEnum : StringEnum<GrpcServerInfoConnectionTypeEnum>
    {
        public static readonly GrpcServerInfoConnectionTypeEnum INSECURE
            = new GrpcServerInfoConnectionTypeEnum("INSECURE");

        public static readonly GrpcServerInfoConnectionTypeEnum TLS
            = new GrpcServerInfoConnectionTypeEnum("TLS");


        public static implicit operator GrpcServerInfoConnectionTypeEnum(string value)
        {
            return NewValue(value);
        }

        public GrpcServerInfoConnectionTypeEnum(string enumValue)
            : base(enumValue)
        {

        }
    }
}