// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsWorkerConfig : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("AutoDeletion")]
        public bool? AutoDeletion { get; set; }

        [JsonPropertyName("CreatedAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("CreatedBy")]
        public string? CreatedBy { get; set; }

        [JsonPropertyName("GhostWorker")]
        public bool? GhostWorker { get; set; }

        [JsonPropertyName("ManualBufferOverride")]
        public bool? ManualBufferOverride { get; set; }

        [JsonPropertyName("ModifiedBy")]
        public string? ModifiedBy { get; set; }

        [JsonPropertyName("Namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("UpdatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonPropertyName("ZombieWorker")]
        public bool? ZombieWorker { get; set; }

    }


}