// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using System.Text.Json.Serialization;

namespace AccelByte.Sdk.Api.Dsmc.Model
{
    public class ModelsServer : AccelByte.Sdk.Core.Model
    {
        [JsonPropertyName("allocation_events")]
        public List<ModelsAllocationEvent>? AllocationEvents { get; set; }

        [JsonPropertyName("allocation_id")]
        public string? AllocationId { get; set; }

        [JsonPropertyName("alternate_ips")]
        public List<string>? AlternateIps { get; set; }

        [JsonPropertyName("cpu_limit")]
        public int? CpuLimit { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("custom_attribute")]
        public string? CustomAttribute { get; set; }

        [JsonPropertyName("deployment")]
        public string? Deployment { get; set; }

        [JsonPropertyName("deployment_override")]
        public string? DeploymentOverride { get; set; }

        [JsonPropertyName("game_version")]
        public string? GameVersion { get; set; }

        [JsonPropertyName("image_version")]
        public string? ImageVersion { get; set; }

        [JsonPropertyName("ip")]
        public string? Ip { get; set; }

        [JsonPropertyName("is_override_game_version")]
        public bool? IsOverrideGameVersion { get; set; }

        [JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        [JsonPropertyName("last_update")]
        public DateTime? LastUpdate { get; set; }

        [JsonPropertyName("mem_limit")]
        public int? MemLimit { get; set; }

        [JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        [JsonPropertyName("params")]
        public string? Params { get; set; }

        [JsonPropertyName("pod_name")]
        public string? PodName { get; set; }

        [JsonPropertyName("port")]
        public int? Port { get; set; }

        [JsonPropertyName("ports")]
        public Dictionary<string, long>? Ports { get; set; }

        [JsonPropertyName("protocol")]
        public string? Protocol { get; set; }

        [JsonPropertyName("provider")]
        public string? Provider { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("status_history")]
        public List<ModelsStatusHistory>? StatusHistory { get; set; }

        [JsonPropertyName("termination_reason")]
        public string? TerminationReason { get; set; }

    }
}