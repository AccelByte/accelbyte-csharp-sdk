// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Ams.Model
{
    public class ApiFleetListItemResponse : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("active")]
        public bool? Active { get; set; }

        [JsonPropertyName("counts")]
        public List<ApiFleetRegionalServerCounts>? Counts { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("image")]
        public string? Image { get; set; }

        [JsonPropertyName("instanceProvider")]
        public string? InstanceProvider { get; set; }

        [JsonPropertyName("isLocal")]
        public bool? IsLocal { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("onDemand")]
        public bool? OnDemand { get; set; }

        [JsonPropertyName("regions")]
        public List<string>? Regions { get; set; }

    }


}