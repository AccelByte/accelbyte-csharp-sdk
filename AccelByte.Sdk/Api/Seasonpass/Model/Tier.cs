// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Seasonpass.Model
{
    public class Tier : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("requiredExp")]
        public int? RequiredExp { get; set; }

        [JsonPropertyName("rewards")]
        public Dictionary<string, object>? Rewards { get; set; }

    }
}