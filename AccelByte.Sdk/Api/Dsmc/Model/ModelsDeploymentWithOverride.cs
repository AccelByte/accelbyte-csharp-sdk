// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsDeploymentWithOverride : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allow_version_override")]
        public bool? AllowVersionOverride { get; set; }

        [JsonPropertyName("buffer_count")]
        public int? BufferCount { get; set; }

        [JsonPropertyName("buffer_percent")]
        public int? BufferPercent { get; set; }

        [JsonPropertyName("configuration")]
        public string? Configuration { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("enable_region_overrides")]
        public bool? EnableRegionOverrides { get; set; }

        [JsonPropertyName("game_version")]
        public string? GameVersion { get; set; }

        [JsonPropertyName("max_count")]
        public int? MaxCount { get; set; }

        [JsonPropertyName("min_count")]
        public int? MinCount { get; set; }

        [JsonPropertyName("modifiedBy")]
        public string? ModifiedBy { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("overrides")]
        public Dictionary<string, ModelsDeploymentConfigOverride>? Overrides { get; set; }

        [JsonPropertyName("region_overrides")]
        public Dictionary<string, ModelsPodCountConfigOverride>? RegionOverrides { get; set; }

        [JsonPropertyName("regions")]
        public List<string>? Regions { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("use_buffer_percent")]
        public bool? UseBufferPercent { get; set; }

    }
}