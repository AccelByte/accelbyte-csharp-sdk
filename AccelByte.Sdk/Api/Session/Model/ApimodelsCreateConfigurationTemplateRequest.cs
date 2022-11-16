// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Session.Model
{
    public class ApimodelsCreateConfigurationTemplateRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("inactiveTimeout")]
        public int? InactiveTimeout { get; set; }

        [JsonPropertyName("inviteTimeout")]
        public int? InviteTimeout { get; set; }

        [JsonPropertyName("joinability")]
        public string? Joinability { get; set; }

        [JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        [JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("requestedRegions")]
        public List<string>? RequestedRegions { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

    }
}