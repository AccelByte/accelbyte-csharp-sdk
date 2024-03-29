// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsUpdateDeploymentOverrideRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("buffer_count")]
        public int? BufferCount { get; set; }

        [JsonPropertyName("buffer_percent")]
        public int? BufferPercent { get; set; }

        [JsonPropertyName("configuration")]
        public string? Configuration { get; set; }

        [JsonPropertyName("enable_region_overrides")]
        public bool? EnableRegionOverrides { get; set; }

        [JsonPropertyName("game_version")]
        public string? GameVersion { get; set; }

        [JsonPropertyName("max_count")]
        public int? MaxCount { get; set; }

        [JsonPropertyName("min_count")]
        public int? MinCount { get; set; }

        [JsonPropertyName("regions")]
        public List<string>? Regions { get; set; }

        [JsonPropertyName("session_timeout")]
        public int? SessionTimeout { get; set; }

        [JsonPropertyName("unlimited")]
        public bool? Unlimited { get; set; }

        [JsonPropertyName("use_buffer_percent")]
        public bool? UseBufferPercent { get; set; }

    }


}