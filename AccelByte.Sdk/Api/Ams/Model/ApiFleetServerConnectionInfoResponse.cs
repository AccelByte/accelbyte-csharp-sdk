// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiFleetServerConnectionInfoResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("expiresAt")]
        public ApiTime? ExpiresAt { get; set; }

        [JsonPropertyName("host")]
        public string? Host { get; set; }

        [JsonPropertyName("logstreamPort")]
        public int? LogstreamPort { get; set; }

        [JsonPropertyName("secret")]
        public string? Secret { get; set; }

    }


}