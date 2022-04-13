// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsUpdateRegionOverrideRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("buffer_count")]
        public int? BufferCount { get; set; }

        [JsonPropertyName("buffer_percent")]
        public int? BufferPercent { get; set; }

        [JsonPropertyName("max_count")]
        public int? MaxCount { get; set; }

        [JsonPropertyName("min_count")]
        public int? MinCount { get; set; }

        [JsonPropertyName("use_buffer_percent")]
        public bool? UseBufferPercent { get; set; }

    }
}