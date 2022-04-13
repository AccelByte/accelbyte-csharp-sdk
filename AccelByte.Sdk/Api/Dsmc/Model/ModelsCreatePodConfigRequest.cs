// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsCreatePodConfigRequest : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("cpu_limit")]
        public int? CpuLimit { get; set; }

        [JsonPropertyName("mem_limit")]
        public int? MemLimit { get; set; }

        [JsonPropertyName("params")]
        public string? Params { get; set; }

    }
}